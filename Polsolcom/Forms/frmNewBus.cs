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
    public partial class frmNewBus : Form
    {
        Dictionary<string, string> mntsp;
        Dictionary<string, string> bus;

        string ie;
        string mu;
        string descripcion;

        public frmNewBus(string ie, string mu, string descripcion)
        {
            InitializeComponent();

            this.ie = ie;
            this.mu = mu;
            this.Text = descripcion;

        }

        private void frmNewBus_Load(object sender, EventArgs ev)
        {
            // TODO: This line of code loads data into the 'rotationDS.Rotation' table. You can move, or remove it, as needed.
            this.rotationTableAdapter.Fill(this.rotationDS.Rotation);
            string sql = "Select TInst &sc Id_Inst Id_Emp,Nom_Raz_Soc From Institucion Where Estado='1' And TInst Not In ('T','M') Order By 2";

            if (mu.Length > 0)
            {
                txtCreation.Text = bus["Us_Ing"] + " - " + bus["Fec_Ing"];
                txtLastUpDate.Text = bus["Us_Mod"] + " - " + bus["Fec_Mod"];
                txtBus.Text = bus["Bus"];
                txtAlterno.Text = bus["Alterno"];
                cmbEstado.SelectedValue = bus["Estado"];
                cmbTipo.SelectedValue = bus["TBus"];
                cmbRotacion.SelectedValue = bus["Turno"].Substring(0, 1);
                cmbEmpresa.SelectedValue = bus["Id_Emp"];
            }
            else
            {
                cmbEstado.SelectedValue = "1";
            }

            txtBus.Focus();
            this.Refresh();
        }

        public int vu()
        {
            int o = 0;

            if (this.mu.Length > 0)
            {
                string sql = "Select B.Bus,B.TBus,B.Id_Emp,Count(*)As C From Buses As B Inner Join Cab_Cie10 As CB On LTrim(RTrim(B.Id_Bus))=LTrim(RTrim(CB.Id_Bus)) Where LTrim(RTrim(B.Id_Bus))='" + this.mu + "' And CB.Id_Per<>'' Group By B.Bus,B.TBus,B.Id_Emp";
                Dictionary<string, string> vnc = General.GetDictionary(sql);

                if (vnc.Count > 0)
                {
                    if (txtBus.Text != vnc["Bus"])
                    {
                        txtBus.Text = vnc["Bus"];
                        o++;
                    }

                    if (cmbTipo.SelectedValue.ToString() != vnc["TBus"])
                    {
                        cmbTipo.SelectedValue = vnc["TBus"];
                        o++;
                    }

                    if (cmbEmpresa.SelectedValue.ToString() != vnc["Id_Emp"])
                    {
                        cmbEmpresa.SelectedValue = vnc["Id_Emp"];
                        o++;
                    }
                }

                if (o > 0)
                {
                    MessageBox.Show("Nombre, Tipo o Razón Social no pueden cambiarse ...\nexisten pagos realizados para el consultorio " + txtBus.Text + ".", "Advertencia");
                }
            }

            return o;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (this.vu() == 0)
            {
                string ic = this.mu;
                string nc = txtBus.Text;
                string na = txtAlterno.Text;
                string st = cmbEstado.SelectedValue.ToString();
                string tp = cmbTipo.SelectedValue.ToString();
                string rt = (st != "1" || cmbRotacion.SelectedValue.ToString().Length == 0 ? "" : cmbRotacion.SelectedValue.ToString() + (this.mu.Length == 0 ? "0" : ""));
                string ne = cmbEmpresa.SelectedValue.ToString();
                string iu = Usuario.id_us;
                string io = Operativo.id_oper;

                if (this.ie.Length == 0 || nc.Length == 0 || st.Length == 0 || tp.Length == 0 || (ne.Length == 0 && tp == "T"))
                {
                    MessageBox.Show("Faltan datos para grabar el registro ...", "Aviso al usuario");
                    return;
                }

                if (this.mu.Length == 0)
                {

                }

            
            }
        }
    }
}
