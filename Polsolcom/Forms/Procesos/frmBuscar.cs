using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;
using Polsolcom.Forms.Procesos;
using static Polsolcom.Forms.Procesos.frmSHClinica;

namespace Polsolcom.Forms.Procesos
{
	public partial class frmBuscar : Form
	{
        public CpaDelegate CpaCallback;
        public Dictionary<string, string> bpac = new Dictionary<string, string>();
        List<Dictionary<string, string>> bpacs = new List<Dictionary<string, string>>();

        public frmBuscar()
		{
			InitializeComponent();
		}

        public void bpa()
        {
            lstBuscar.Items.Clear();
            string sql = General.DevuelveQueryPaciente(txtApeMaterno.Text, txtApeMaterno.Text, txtNombres.Text, txtDNI.Text, "", "", 1, General.ODB);
            General.FillListView(lstBuscar, this.bpacs, new[] { "Paciente", "Id_Paciente", "DNI" });

            btnAceptar.Enabled = true;
        }

        private void frmBuscar_Load( object sender, EventArgs e )
		{
			this.Text = this.Text + "Conexion a BD general: " + (General.ODB == 0? "OFF" : "ON");
            General.setAll<TextBox, string>(this, "Text", "");
            this.bpa();
		}

		private void frmBuscar_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}
        /*
		private void CargaGrilla()
		{
			string vSQL = "";
			DataSet dt = new DataSet();

			vSQL = General.DevuelveQueryPaciente(txtAPPaterno.Text.ToString(),txtAPMaterno.Text.ToString(),txtNombres.Text.ToString(),txtDNI.Text.ToString(),"","",1,General.ODB);

			if( vSQL == "" )
				return;

			Cursor.Current = Cursors.WaitCursor;
			Conexion.CMD.CommandText = vSQL;
			using( SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD) )
			{
				dt.Clear();
				da.Fill(dt);
				da.Dispose();
			}

			fGrid.Rows.Clear();
			using( IDataReader dr = dt.CreateDataReader() )
			{
				fGrid.FillWithData(dr);
				dr.Close();
			}
			Cursor.Current = Cursors.Default;
			FormateaGrilla();
		}
        */
		private void txtApePaterno_TextChanged( object sender, EventArgs e )
		{
            this.bpa();
		}

		private void txtApeMaterno_TextChanged( object sender, EventArgs e )
		{
            this.bpa();
        }

        private void txtNombres_TextChanged( object sender, EventArgs e )
		{
            if (txtNombres.Text.Length > 0)
            {
                this.bpa();
            }
		}

		private void txtDNI_TextChanged( object sender, EventArgs e )
		{
            if (txtDNI.Text.Length > 8)
            {
                this.bpa();
            }
        }

		private void txtDNI_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
				e.Handled = true;
		}

		private void txtNombres_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
			else if( e.KeyCode == Keys.Enter )
            { 
			}
		}


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int index = General.GetSelectedIndex(lstBuscar);
            this.bpac = this.bpacs[index];

            if (lstBuscar.Items.Count > 0)
            {
                if (General.ODB == 0)
                {
                    if (this.bpac["Asegurado"] == "A")
                    {
                        MessageBox.Show("El registro esta anulado, consulte con el administrador del sistema ...", "Advertencia");
                        btnCancelar_Click(btnCancelar, new EventArgs());
                        return;
                    }

                    CpaCallback(0, false);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void lstBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    txtApePaterno.Focus();
                    return;
                case Keys.Enter:
                    btnAceptar_Click(btnAceptar, new EventArgs());
                    break;
            }
        }

        private void lstBuscar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnAceptar_Click(btnAceptar, new EventArgs());
        }
    }
}
