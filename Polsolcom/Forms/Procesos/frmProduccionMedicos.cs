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

namespace Polsolcom.Forms.Procesos
{
    public partial class frmProduccionMedicos : Form
    {
        public frmProduccionMedicos()
        {
            InitializeComponent();
        }

        public void filtraHoy()
        {
        }

        private void frmProduccionMedicos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicosDS.MedicosProduccion' table. You can move, or remove it, as needed.
            this.medicosProduccionTableAdapter.Fill(this.medicosDS.MedicosProduccion);
            cmbMedico.SelectedIndex = -1;
            especialidadTableAdapter.Fill(consultoriosDS.Especialidad, Operativo.id_oper);
            cmbConsultorio.SelectedIndex = 1;

            string sql = "Select Descripcion,Id_Producto,Monto From Productos Where Left(Id_Producto,3)='XXX' Order By 1";

            this.filtraHoy();
        }
    }
}
