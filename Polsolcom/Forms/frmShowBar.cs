using Polsolcom.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
    public partial class frmShowBar : Form
    {
        public TreeNode selectedNode = new TreeNode();
		//indica si la accion es una insercion o actualizacion
        public bool bInsertar = new bool();
        string vSQL = "";

        public frmShowBar()
        {
            InitializeComponent();
        }

        private void LlenaCombos(string sLista)
        {
			//limpia las listas con los usuarios del sistema
            lstTusuarios.Items.Clear();
            lstPTusuarios.Items.Clear();

            int iLen = sLista.Length;
            int i = 0;
            string sTipo = "";

            while (  i < iLen )
            {
                //por cada tipo de usuario ubica los permisos
                sTipo = General.cryptgr(sLista.Substring(i, 1),false,1);
                for ( int j = 0; j < General.lstTipoUsuario.Count; j++ )
                {
                    TipoUsuario tu = General.lstTipoUsuario[j];
                    if ( tu.Id_Tipo == sTipo )
                    {
                        lstPTusuarios.Items.Add(tu);
                        break;
                    }
                }
                i = i + 1;
            }

            //llena el listbox de usuarios disponibles
            for ( int j = 0; j < General.lstTipoUsuario.Count; j++ )
                lstTusuarios.Items.Add(General.lstTipoUsuario[j]);

            //remueve del listado de usuarios disponibles los que ya tienen permiso
            foreach ( TipoUsuario tuP in lstPTusuarios.Items )
            {
                for ( int k = 0;k < lstTusuarios.Items.Count; k++ )
                {
                    lstTusuarios.SelectedIndex = k;
                    if ( tuP.Descripcion == lstTusuarios.SelectedItem.ToString() )
                        lstTusuarios.Items.RemoveAt(lstTusuarios.SelectedIndex);
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
			string sPTU = "";

			//recorre los usuarios permitidos para obtener el tipo de usuario
			foreach ( TipoUsuario tuP in lstPTusuarios.Items )
				sPTU = sPTU + General.cryptgr(tuP.Id_Tipo.ToString(), true, 1);

			if ( bInsertar == true )
			{//inserta el nuevo elemento 
				vSQL = "DECLARE @bn smallint ";
				vSQL = vSQL + " SET @bn=(SELECT CASE WHEN MAX(Bar_Number) IS NULL THEN 1";
				vSQL = vSQL + "    ELSE MAX(Bar_Number) + 1 END ";
				vSQL = vSQL + " FROM Barmenu";
				vSQL = vSQL + " WHERE Bar_Popup = '" + txtPadMenu.Text.Trim() + "')";
				vSQL = vSQL + " INSERT INTO Barmenu VALUES(@bn,";
				vSQL = vSQL + " '" + txtPadMenu.Text.Trim() + "',";
				vSQL = vSQL + " '" + txtPrompt.Text.Trim() + "',";
				vSQL = vSQL + " '" + txtCommand.Text.Trim() + "',";
				vSQL = vSQL + " '" + txtDescripcion.Text.Trim() + "',";
				vSQL = vSQL + " @bn,";
				vSQL = vSQL + " '" + sPTU + "',";
				vSQL = vSQL + " '" + Usuario.id_us + "',";
				vSQL = vSQL + " GETDATE() )";
				
				try
				{
					Conexion.CMD.CommandText = vSQL;
					Conexion.CMD.ExecuteNonQuery();

					MessageBox.Show("Isercion satisfactoria.", "Actualizacion Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				}
				catch ( SqlException ex )
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
			else
			{//actualiza un elemento 
				vSQL = "UPDATE Barmenu ";
				vSQL = vSQL + " SET Bar_Prompt = '" + txtPrompt.Text.Trim() + "',";
				vSQL = vSQL + " Bar_Command = '" + txtCommand.Text.Trim() + "',";
				vSQL = vSQL + " Bar_Description = '" + txtDescripcion.Text.Trim() + "',";
				vSQL = vSQL + " PTU = '" + sPTU + "',";
				vSQL = vSQL + " Us_Up = '" + Usuario.id_us + "',";
				vSQL = vSQL + " Date_Up = GETDATE() ";
				vSQL = vSQL + " WHERE Bar_Popup = '" + txtPadMenu.Text.Trim() + "'";
				vSQL = vSQL + " AND Bar_Number = '" + txtNroBar.Text.Trim() + "'";
				try
				{
					Conexion.CMD.CommandText = vSQL;
					Conexion.CMD.ExecuteNonQuery();

					MessageBox.Show("Actualizacion satisfactoria.", "Actualizacion Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				}
				catch ( SqlException ex )
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
        }

        private void frmShowBar_Load(object sender, EventArgs e)
        {
			//lee los datos de la opcion seleccionada
			this.Text = this.Text + " - " + selectedNode.Text; 
            string[] sNodoActual = selectedNode.Tag.ToString().Split('*');
            txtPadMenu.Text = sNodoActual[0];
            lstTusuarios.Items.Clear();
            lstPTusuarios.Items.Clear();
            General.CargaTipoUsuario();

            if ( bInsertar == true )
            {   //si es un nuevo ingreso solo agrega al listado de usuarios
                for ( int j = 0; j < General.lstTipoUsuario.Count; j++ )
                    lstTusuarios.Items.Add(General.lstTipoUsuario[j]);
            }
            else
            {   //si es una edicion trae el registro seleccionado
                txtNroBar.Text = sNodoActual[1];

                vSQL = "SELECT * ";
                vSQL = vSQL + " FROM Barmenu b";
                vSQL = vSQL + " WHERE b.Bar_Popup = '" + sNodoActual[0] + "' ";
                vSQL = vSQL + " AND b.Bar_Number = '" + sNodoActual[1] + "'";
				Conexion.CMD.CommandText = vSQL;
				using ( SqlDataReader drUsuario = Conexion.CMD.ExecuteReader() )
                {
                    if ( drUsuario.HasRows )
                    {
                        while ( drUsuario.Read() )
                        {
                            txtPrompt.Text = drUsuario.GetValue(2).ToString();
                            txtCommand.Text = drUsuario.GetValue(3).ToString();
                            txtDescripcion.Text = drUsuario.GetValue(4).ToString();
                            txtLastUpdate.Text = General.TradUser(drUsuario.GetValue(7).ToString()) + " - " + drUsuario.GetValue(8).ToString();
                            //la columna PTU tiene datos encriptados como A, B, C por lo que se necesita desencriptar
                            LlenaCombos(drUsuario.GetValue(6).ToString());
                        }
                    }
                    drUsuario.Close();
                }
            }
            txtPrompt.Focus();
            lstTusuarios.SelectedIndex = -1;
            lstPTusuarios.SelectedIndex = -1;
        }

        private void frmShowBar_KeyDown(object sender, KeyEventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

			//mueve el cursor al siguiente control
            if ( e.KeyCode == Keys.Enter )
            {
                txtPrompt.Focus();
                e.Handled = true;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			//cierra el formulario
            this.Close();
        }

        private void btnCancelar_KeyDown(object sender, KeyEventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
			if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void lstTusuarios_KeyDown(object sender, KeyEventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void lstPTusuarios_KeyDown(object sender, KeyEventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtPrompt_KeyDown(object sender, KeyEventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void lstTusuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			//al hacer doble clic inserta el usuario en la lista de usuarios permitidos
            TipoUsuario oTU = (TipoUsuario)lstTusuarios.SelectedItem;
            lstPTusuarios.Items.Add(oTU);

			//borra de la lista de tipos de usuarios
            if ( lstTusuarios.SelectedIndex >= 0 )
                lstTusuarios.Items.RemoveAt(lstTusuarios.SelectedIndex);
        }

        private void lstPTusuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			//al hacer doble clic inserta el usuario en la lista de tipos de usuario
            TipoUsuario oTUP = (TipoUsuario)lstPTusuarios.SelectedItem;
            lstTusuarios.Items.Add(oTUP);

			//borra de la lista de usuarios permitidos
            if ( lstPTusuarios.SelectedIndex >= 0 )
                lstPTusuarios.Items.RemoveAt(lstPTusuarios.SelectedIndex);
        }

  
    }
}
