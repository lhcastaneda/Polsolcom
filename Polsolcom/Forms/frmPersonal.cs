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

        List<string> ListaNombres;
        List<Personal> ListaPersonal;

        public frmPersonal()
        {
            ListaNombres = new List<string>();
            ListaPersonal = General.TraerNombresPersonal();
            InitializeComponent();
            foreach (var item in ListaPersonal)
            {
                string Nombres = $"{item.Ape_Paterno} {item.Ape_Materno}, {item.Nombre}";
                ListaNombres.Add(Nombres);
            }
            ListaNombres.Sort();
            lstPersonal.DataSource = ListaNombres;
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
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnImprimir.Enabled = true;
            btnEditar.Enabled = true;
            btnGrabar.Enabled = false;
            DisabledPanelControls();
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

        private void DisabledPanelControls()
        {
            foreach (Control item in pnlDatos.Controls)
            {
                item.Enabled = false;
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            EnabledPanelControls();
            btnCancelar.Enabled = true;
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }

        private void lstPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstPersonal.Items[lstPersonal.SelectedIndex];
            Personal personal = ListaPersonal.Find(x => $"{x.Ape_Paterno} {x.Ape_Materno}, {x.Nombre}".Equals(item));
            if (personal != null)
            {
                //TODO: Completar los demas cuadradillos
                txtDirecc.Text = personal.Direccion;
                txtDni.Text = personal.DNI;
            }
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
           List<Personal> ListaPersonalAux = new List<Personal>();
            List<string> ListaPersonalizada = new List<string>();
            if (txtDoc.Text == "")
            {
                lstPersonal.DataSource = ListaNombres;
            }
            else
            {
                ListaPersonalizada.Clear();
                foreach (var personal in ListaPersonal)
                    {
                    if (personal.DNI.Contains(txtDoc.Text))
                         {
                            var name = $"{personal.Ape_Paterno} {personal.Ape_Materno}, {personal.Nombre}";
                            ListaPersonalizada.Add(name);
                         }
                    }            
                lstPersonal.DataSource = ListaPersonalizada;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<string> ListaPersonalizada = new List<string>();
            if (txtBuscar.Text == "")
            {
                lstPersonal.DataSource = ListaNombres;
            }
            else
            {
                ListaPersonalizada.Clear();
                foreach (var item in ListaNombres)
                {
                    if (item.Contains(txtBuscar.Text.ToUpper()))
                    {
                        ListaPersonalizada.Add(item);
                    }
                }
                lstPersonal.DataSource = ListaPersonalizada;
            }     
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }

}

