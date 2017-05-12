using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
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
        //TODO: IMPLEMENTAR GUARDAR Y EDITAR

        public string vSQL;

        List<string> ListaNombres;
        List<Personal> ListaPersonal;
        List<Lugar> ListaLugares;

        public frmPersonal()
        {
            ListaNombres = new List<string>();
            ListaPersonal = General.TraerPersonal();
            ListaLugares = General.TraerLugares();
            InitializeComponent();
            foreach (var item in ListaPersonal)
            {
                string Nombres = $"{item.Ape_Paterno} {item.Ape_Materno}, {item.Nombre}";
                ListaNombres.Add(Nombres);
            }
            ListaNombres.Sort();
            lstPersonal.DataSource = ListaNombres;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LlenarDepartamentos();
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
            //TO DO: Método, subir imagen
        }

        private void lstPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstPersonal.Items[lstPersonal.SelectedIndex];
            Personal personal = ListaPersonal.Find(x => $"{x.Ape_Paterno} {x.Ape_Materno}, {x.Nombre}".Equals(item));
            if (personal != null)
            {
                //TO DO: Completar los demas cuadradillos
                txtDirecc.Text = personal.Direccion;
                txtDni.Text = personal.DNI;
                txtApMaterno.Text = personal.Ape_Materno;
                txtApPaterno.Text = personal.Ape_Paterno;
                txtCel.Text = personal.Celular;
                txtDirecc.Text = personal.Direccion;
                txtEmail.Text = personal.Email;
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

        private void btnOtrosDatos_Click(object sender, EventArgs e)
        {
            frmPersonalDet form = new frmPersonalDet();
            form.Show();
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProvincia.Items.Clear();
            string provincia_aux = ListaLugares.First().Provincia;
            cmbProvincia.Items.Add(provincia_aux);
            string departamento = cmbDepartamento.Items[cmbDepartamento.SelectedIndex].ToString();
            foreach (var item in ListaLugares)
            {
                if (item.Departamento == departamento)
                {
                    if (item.Provincia != provincia_aux)
                    {
                        provincia_aux = item.Provincia;
                        cmbProvincia.Items.Add(provincia_aux);
                    }
                }
                    
            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrito.Items.Clear();
            string provincia = cmbProvincia.Items[cmbProvincia.SelectedIndex].ToString();
            foreach (var item in ListaLugares)
            {
                if (item.Provincia == provincia)
                    cmbDistrito.Items.Add(item.Distrito);
            }
        }

        private void LlenarDepartamentos()
        {
            string departamento_aux = ListaLugares.First().Departamento;
            cmbDepartamento.Items.Add(departamento_aux);
            foreach (var item in ListaLugares)
            {
                if (item.Departamento != departamento_aux)
                {
                    departamento_aux = item.Departamento;
                    cmbDepartamento.Items.Add(departamento_aux);
                }
            }
        }
    }

}

