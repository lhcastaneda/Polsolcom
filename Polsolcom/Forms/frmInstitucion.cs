using Polsolcom.Clases;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
