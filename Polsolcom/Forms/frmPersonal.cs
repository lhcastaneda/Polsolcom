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
    public partial class frmPersonal : Form
    {
        public string vSQL;

        public frmPersonal()
        {
            List<string> ListaPersonal = General.TraerNombresPersonal();            
            InitializeComponent();
            lstPersonal.DataSource = ListaPersonal;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void pnlDatos_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EnabledPanelControls();
        }

        private void EnabledPanelControls()
        {
            foreach (Control item in pnlDatos.Controls)
            {
                item.Enabled = true;
            }
        }
        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EnabledPanelControls();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }
    }

}

