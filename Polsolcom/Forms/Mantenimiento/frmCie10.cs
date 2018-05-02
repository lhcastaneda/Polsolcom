using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
	public partial class frmCie10 : Form
    {
        int current = 0;
		string CID = "";
        public string descripcion = "";
        public string cie10 = "";
        List<Dictionary<string, string>> items;

        public frmCie10()
        {
            InitializeComponent();
        }

        void LlenarLista()
        {
            string sql = "Select * From Cie10 Order By 2";
			items = General.GetDictionaryList(sql);
        }

        void LlenarListView(Dictionary<string, string> filters = null)
        {
            General.Fill(lstDatos, this.items, new[] { "Descripcion", "CIE10" });
        }

        private void frmCie10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
				DialogResult = DialogResult.Cancel;
				descripcion = "";
				cie10 = "";
				Close();
            }
        }

        private void frmCie10_Load(object sender, EventArgs e)
        {
            btnInicio.Enabled = false;
            btnAnterior.Enabled = false;
			btnNuevo.Enabled = true;
			btnModificar.Enabled = btnEliminar.Enabled = false;
            LlenarLista();
            LlenarListView();
            //Seleccionamos primer elemento
            txtCIE10.Text = items[current]["CIE10"];
            txtDescripcion.Text = items[current]["Descripcion"];
        }

        private void txtFilt2_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> filters = new Dictionary<string, string>();
            filters["CIE10"] = txtFilt1.Text;
            filters["Descripcion"] = txtFilt2.Text;
            General.Fill(lstDatos, items, new[] { "Descripcion", "CIE10" }, filters);
			current = 0;
		}

        private void txtFilt1_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> filters = new Dictionary<string, string>();
            filters["CIE10"] = txtFilt1.Text;
            filters["Descripcion"] = txtFilt2.Text;
            General.Fill(lstDatos, items, new[] { "Descripcion", "CIE10" }, filters);
			current = 0;
        }

        private void lstDatos_Click(object sender, EventArgs e)
        {
            ListViewItem item = General.GetSelectedItem((ListView)sender);
			current = lstDatos.SelectedIndices[0];
			txtCIE10.Text = item.SubItems[1].Text;
            txtDescripcion.Text = item.SubItems[0].Text;
			btnModificar.Enabled = btnEliminar.Enabled = true;
		}

        private void lstDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListViewItem item = General.GetSelectedItem((ListView)sender);
				descripcion = item.SubItems[0].Text;
				cie10 = item.SubItems[1].Text;
				Close();
            }
        }

		private void btnAnterior_Click( object sender, EventArgs e )
		{
			current--;
			if( current == 0 )
			{
				btnInicio.Enabled = false;
				btnAnterior.Enabled = false;
			}
			
			if( current < 0 )
			{
				current = 0;
				return;
			}

			btnSiguiente.Enabled = true;
			btnUltimo.Enabled = true;
			btnModificar.Enabled = btnEliminar.Enabled = true;

			lstDatos.Focus();
			lstDatos.Items[current].Selected = true;
			ListViewItem item = lstDatos.Items[current];
			txtCIE10.Text = item.SubItems[1].Text;
			txtDescripcion.Text = item.SubItems[0].Text;
		}

		private void btnInicio_Click(object sender, EventArgs e)
        {
			ListViewItem item = lstDatos.Items[0];
			current = 0;
            btnInicio.Enabled = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;
			btnModificar.Enabled = btnEliminar.Enabled = true;
			lstDatos.Focus();
			lstDatos.Items[0].Selected = true;
			txtCIE10.Text = item.SubItems[1].Text;
			txtDescripcion.Text = item.SubItems[0].Text;
			
		}

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
			current++;
			if (current == lstDatos.Items.Count - 1 )
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }
			if( current > lstDatos.Items.Count - 1 )
				return;

			lstDatos.Focus();
			lstDatos.Items[current].Selected = true;
			ListViewItem item = lstDatos.Items[current];
			btnInicio.Enabled = true;
            btnAnterior.Enabled = true;
			btnModificar.Enabled = btnEliminar.Enabled = true;
			txtCIE10.Text = item.SubItems[1].Text;
			txtDescripcion.Text = item.SubItems[0].Text;
		}

		private void btnUltimo_Click(object sender, EventArgs e)
        {
			current = lstDatos.Items.Count - 1; //items.Count - 1;
			ListViewItem item = lstDatos.Items[lstDatos.Items.Count-1];
			lstDatos.Focus();
			lstDatos.Items[current].Selected = true;
			btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            btnInicio.Enabled = true;
            btnAnterior.Enabled = true;
			btnModificar.Enabled = btnEliminar.Enabled = true;
			//txtCIE10.Text = items[current]["CIE10"];
			//txtDescripcion.Text = items[current]["Descripcion"];
			txtCIE10.Text = item.SubItems[1].Text;
			txtDescripcion.Text = item.SubItems[0].Text;
		}

		private void btnSalir_Click(object sender, EventArgs e)
        {
            descripcion = "";
            cie10 = "";
            Close();
        }

		private void btnModificar_Click( object sender, EventArgs e )
		{
			btnNuevo.Enabled = false;
			string vSQL = "";

			if( btnModificar.Text == "&Modificar" )
			{
				btnModificar.Text = "&Guardar";
				lstDatos.Enabled = false;
				txtCIE10.Enabled = false;
				txtDescripcion.Focus();
				CID = "M";
			}
			else
			{
				if( txtDescripcion.Text.Trim() == "" )
				{
					MessageBox.Show("Ingrese Descripción del Cie10 ....", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtDescripcion.Focus();
					return;
				}

				if( MessageBox.Show("Desea guardar los cambios ... ?", "Mensaje al Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes )
				{
					vSQL = "UPDATE Cie10 SET Descripcion = '" + txtDescripcion.Text.Trim().ToUpper() + "' " +
							"WHERE Cie10 = '" + txtCIE10.Text.Trim().ToUpper() + "' ";
					Conexion.CMD.CommandText = vSQL;
					Conexion.CMD.ExecuteNonQuery();

					LlenarLista();
					LlenarListView();
					current = 0;
					txtCIE10.Text = items[current]["CIE10"];
					txtDescripcion.Text = items[current]["Descripcion"];
					CID = "N";
					btnModificar.Text = "&Modificar";
					lstDatos.Enabled = true;
					txtCIE10.Enabled = true;
					lstDatos.Focus();
					txtFilt1.Text = txtFilt2.Text = "";
				}
			}
		}

		private void btnEliminar_Click( object sender, EventArgs e )
		{
			string vSQL = "";
			string vCant = "";
			
			if( txtCIE10.Text.Trim() == "" )
			{
				MessageBox.Show("Seleccione Codigo Cie10 ...", "Aviso al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				lstDatos.Focus();
				return;
			}

			string sQuery = "SELECT COUNT(*) FROM Det_Cie10 " + 
				            "WHERE Cie10 = '" + txtCIE10.Text.Trim().ToUpper() + "' ";
			vCant = General.TomaValor(sQuery);

			if( Convert.ToInt32(vCant) > 0 )
			{
				MessageBox.Show("No puede eliminar Cie10 ... ya se esta utilizando", "Aviso al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				lstDatos.Focus();
				return;
			}
			
			if( MessageBox.Show("Desea Eliminar el CIE10 " + txtCIE10.Text + " ... ?", "Mensaje al Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes )
			{
				vSQL = "DELETE FROM Cie10 " +
		               "WHERE Cie10 = '" + txtCIE10.Text.Trim().ToUpper() + "' ";
				Conexion.CMD.CommandText = vSQL;
				Conexion.CMD.ExecuteNonQuery();

				LlenarLista();
				LlenarListView();
				current = 0;
				txtCIE10.Text = items[current]["CIE10"];
				txtDescripcion.Text = items[current]["Descripcion"];
				lstDatos.Enabled = true;
				lstDatos.Focus();
				btnNuevo.Enabled = false;
				txtFilt1.Text = txtFilt2.Text = "";
			}
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			string vSQL = "";

			btnModificar.Enabled = btnEliminar.Enabled = false;
			if( btnNuevo.Text == "&Nuevo" )
			{
				btnNuevo.Text = "&Guardar";
				lstDatos.Enabled = false;
				txtCIE10.Text = "";
				txtDescripcion.Text = "";
				txtCIE10.Focus();
			}
			else
			{
				if( txtCIE10.Text.Trim() == "" )
				{
					MessageBox.Show("Ingrese Codigo Cie10 ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtCIE10.Focus();
					return;
				}

				if( txtDescripcion.Text.Trim() == "" )
				{
					MessageBox.Show("Ingrese Descripción del Cie10 ....", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtDescripcion.Focus();
					return;
				}

				if( MessageBox.Show("Desea guardar los cambios ... ?", "Mensaje al Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes )
				{
					vSQL = "INSERT INTO Cie10 VALUES (" +
					        "'" + txtCIE10.Text.Trim().ToUpper() + "'," +
							"'" + txtDescripcion.Text.Trim().ToUpper() + "','')";
					Conexion.CMD.CommandText = vSQL;
					Conexion.CMD.ExecuteNonQuery();

					LlenarLista();
					LlenarListView();
					current = 0;
					txtCIE10.Text = items[current]["CIE10"];
					txtDescripcion.Text = items[current]["Descripcion"];
					CID = "N";
					btnNuevo.Text = "&Nuevo";
					lstDatos.Enabled = true;
					lstDatos.Focus();
					txtFilt1.Text = txtFilt2.Text = "";
				}
			}
		}	
	}
}
