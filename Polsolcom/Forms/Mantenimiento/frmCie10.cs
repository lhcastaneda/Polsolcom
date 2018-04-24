using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
	public partial class frmCie10 : Form
    {
        int current = 0;
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
            this.items = General.GetDictionaryList(sql);
        }

        void LlenarListView(Dictionary<string, string> filters = null)
        {
            General.Fill(lstDatos, this.items, new[] { "Descripcion", "CIE10" });
        }

        private void frmCie10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.descripcion = "";
                this.cie10 = "";
                this.Close();
            }
        }

        private void frmCie10_Load(object sender, EventArgs e)
        {
            btnInicio.Enabled = false;
            btnAnterior.Enabled = false;
            btnNuevo.Enabled = btnModificar.Enabled = btnEliminar.Enabled = false;
            LlenarLista();
            LlenarListView();
            //Seleccionamos primer elemento
            txtCIE10.Text = this.items[current]["CIE10"];
            txtDescripcion.Text = this.items[current]["Descripcion"];
        }

        private void txtFilt2_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> filters = new Dictionary<string, string>();
            filters["CIE10"] = txtFilt1.Text;
            filters["Descripcion"] = txtFilt2.Text;
            General.Fill(lstDatos, this.items, new[] { "Descripcion", "CIE10" }, filters);
        }

        private void txtFilt1_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> filters = new Dictionary<string, string>();
            filters["CIE10"] = txtFilt1.Text;
            filters["Descripcion"] = txtFilt2.Text;
            General.Fill(lstDatos, this.items, new[] { "Descripcion", "CIE10" }, filters);
        }

        private void lstDatos_Click(object sender, EventArgs e)
        {
            ListViewItem item = General.GetSelectedItem((ListView)sender);
            txtCIE10.Text = item.SubItems[1].Text;
            txtDescripcion.Text = item.SubItems[0].Text;
        }

        private void lstDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListViewItem item = General.GetSelectedItem((ListView)sender);
                this.descripcion = item.SubItems[0].Text;
                this.cie10 = item.SubItems[1].Text;
                this.Close();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.current--;

            if (current == 0)
            {
                btnInicio.Enabled = false;
                btnAnterior.Enabled = false; 
            }

            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;

            txtCIE10.Text = this.items[current]["CIE10"];
            txtDescripcion.Text = this.items[current]["Descripcion"];
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.current = 0;
            btnInicio.Enabled = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;
            txtCIE10.Text = this.items[current]["CIE10"];
            txtDescripcion.Text = this.items[current]["Descripcion"];
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

			object searchText = this.TextBox1.Text;
			if( (searchText == String.Empty) )
			{
				MessageBox.Show("Please enter search text.");
			}
			else
			{
				object startIndex = 0;
				ListViewItem item = null;
				if( ((this.lstDatos.SelectedItems.Count == 1)
							&& (this.lstDatos.SelectedItems(0).Text == searchText)) )
				{
					startIndex = (this.lstDatos.SelectedIndices(0) + 1);
				}

				if( (startIndex < this.lstDatos.Items.Count) )
				{
					for(
					; true;
					)
					{
						item = this.lstDatos.FindItemWithText(searchText, false, startIndex);
						if( ((item == null)
									|| (item.Text == searchText)) )
						{
							break; //Warning!!! Review that break works as 'Exit Do' as it could be in a nested instruction like switch
						}

						startIndex = (item.Index + 1);
						if( (startIndex >= this.lstDatos.Items.Count) )
						{
							break; //Warning!!! Review that break works as 'Exit Do' as it could be in a nested instruction like switch
						}

					}

				}

				this.lstDatos.SelectedItems.Clear();
				if( (item == null) )
				{
					MessageBox.Show("No match found.");
				}
				else
				{
					item.Selected = true;
					item.EnsureVisible();
					this.lstDatos.Select();
				}

			}








			this.current++;

            if (current == this.items.Count - 1)
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }

            btnInicio.Enabled = true;
            btnAnterior.Enabled = true;

            txtCIE10.Text = this.items[current]["CIE10"];
            txtDescripcion.Text = this.items[current]["Descripcion"];
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            this.current = this.items.Count - 1;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            btnInicio.Enabled = true;
            btnAnterior.Enabled = true;
            txtCIE10.Text = this.items[current]["CIE10"];
            txtDescripcion.Text = this.items[current]["Descripcion"];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.descripcion = "";
            this.cie10 = "";
            this.Close();
        }

		private void btnModificar_Click( object sender, EventArgs e )
		{

		}

		private void btnEliminar_Click( object sender, EventArgs e )
		{

		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{

		}
	}
}
