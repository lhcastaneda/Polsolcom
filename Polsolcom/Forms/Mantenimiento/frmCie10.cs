using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

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
            string sql = "Select * From Cie10 Order By 1";
            this.items = General.GetDictionaryList(sql);
        }

        void LlenarListView(Dictionary<string, string> filters = null)
        {
            General.FillListView(lstDatos, this.items, new[] { "Descripcion", "CIE10" });
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
            General.FillListView(lstDatos, this.items, new[] { "Descripcion", "CIE10" }, filters);
        }

        private void txtFilt1_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> filters = new Dictionary<string, string>();
            filters["CIE10"] = txtFilt1.Text;
            filters["Descripcion"] = txtFilt2.Text;
            General.FillListView(lstDatos, this.items, new[] { "Descripcion", "CIE10" }, filters);
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
    }
}
