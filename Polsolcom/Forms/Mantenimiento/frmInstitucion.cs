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
    public partial class frmInstitucion : Form
    {
        List<Institucion> ListaInstituciones;
        List<string> ListaNombresInstituciones;
        public frmInstitucion()
        {
            InitializeComponent();
            ListaInstituciones = General.TraerInstitucion();
            ListaNombresInstituciones = new List<string>();
            foreach (var item in ListaInstituciones)
            {
                ListaNombresInstituciones.Add(item.Nom_Raz_Soc);
            }
            lstInstitucion.DataSource = ListaNombresInstituciones;
        }
        

        private void lstInstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstInstitucion.Items[lstInstitucion.SelectedIndex];
            var razonSocial = item.ToString();
            Institucion institucion = ListaInstituciones.Find(x => x.Nom_Raz_Soc == razonSocial);
            if (institucion != null)
            {
                //TO DO: Completar los demas cuadradillos
                txtRuc.Text = institucion.RUC;
            }
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
