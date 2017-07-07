using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
    public partial class frmConsultorios : Form
    {
        public List<Consultorio> ListaConsultorios { get; set; }
        public List<string> ListaNombresConsultorios;

        public frmConsultorios()
        {
            InitializeComponent();
            ListaNombresConsultorios = new List<string>();
            ListaConsultorios = General.TraerConsultorios();
            foreach (var item in ListaConsultorios)
            {
                ListaNombresConsultorios.Add(item.Descripcion);
            }
            ListaNombresConsultorios.Sort();
            lstConsultorios.DataSource = ListaNombresConsultorios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstConsultorios.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var final_index = lstConsultorios.Items.Count - 1;
            lstConsultorios.SelectedIndex = final_index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = lstConsultorios.SelectedIndex - 1;
            if (index >= 0)
                lstConsultorios.SelectedIndex = index;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var index = lstConsultorios.SelectedIndex + 1;
            if (index < lstConsultorios.Items.Count)
                lstConsultorios.SelectedIndex = index;
        }

        private void frmConsultorios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
