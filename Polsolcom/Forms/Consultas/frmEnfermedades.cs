using CrystalDecisions.CrystalReports.Engine;
using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Data;
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
    public partial class frmEnfermedades : Form
    {
        string texto = "";
        string sql = "";

        DataSet dt = new DataSet();
        ReportDocument rpt = new ReportDocument();

        bool[] orders = { true, true, true };

        List<Dictionary<string, string>> epidemiologo = new List<Dictionary<string, string>>();

        public frmEnfermedades()
        {
            InitializeComponent();
        }

        public int getOg()
        {
            return rbDiario.Checked ? 1 : rbMensual.Checked ? 2 : rbAnual.Checked ? 3 : 4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEnfermedades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCerrar_Click(btnCerrar, new EventArgs());
            }
        }

        private void frmEnfermedades_Load(object sender, EventArgs e)
        {
            this.operativoTableAdapter.Fill(this.operativos.Operativo);
            cmbOperativo.SelectedValue = Operativo.id_oper;

            this.allConsultoriosTableAdapter.Fill(this.consultoriosDS.AllConsultorios);
            cmbConsultorio.SelectedIndex = -1;

            dtpFecIni.Value = DateTime.Today;
            dtpFecFin.Value = DateTime.Today;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string ini = dtpFecIni.Value.ToShortDateString();
            string fin = dtpFecFin.Value.ToShortDateString();
            string con = cmbConsultorio.SelectedIndex == -1 ? "" : cmbConsultorio.SelectedValue.ToString();
            string agr = this.getOg().ToString();
            string ser = cmbOperativo.SelectedIndex == -1 ? "" : cmbOperativo.SelectedValue.ToString();

            this.sql = "Exec Est_Diag '" + ini + "','" + fin + "','" + con + "','" + agr + "','" + ser + "'";

            if (dtpFecIni.Value != null && dtpFecFin.Value != null && cmbConsultorio.SelectedIndex > -1)
            {
                this.texto = "DEL " + dtpFecIni.Value.ToLongDateString() + " AL " + dtpFecFin.Value.ToShortDateString() + " CONSULTORIO DE " + cmbConsultorio.SelectedValue.ToString();
            }

            if (dtpFecIni.Value != null && dtpFecFin.Value != null && cmbConsultorio.SelectedIndex == -1)
            {
                this.texto = "DEL " + dtpFecIni.Value.ToLongDateString() + " AL " + dtpFecFin.Value.ToShortDateString();
            }

            if (dtpFecIni.Value == null && dtpFecFin.Value == null && cmbConsultorio.SelectedIndex == -1)
            {
                this.texto = "";
            }

            if (dtpFecIni.Value == null && dtpFecFin.Value == null && cmbConsultorio.SelectedIndex > -1)
            {
                this.texto = "CONSULTORIO DE " + cmbConsultorio.SelectedValue.ToString();
            }

            this.epidemiologo = General.GetDictionaryList(this.sql, true);
            General.Fill(lstCIE10, this.epidemiologo, new string[] { "CIE10", "DIAGNOSTICO", "CANTIDAD" });

            if (this.epidemiologo.Count == 0)
            {
                MessageBox.Show("La Consulta no genero ningun registro ...", "Aviso al usuario");
            }

            spinner1.Maximum = this.epidemiologo.Count;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string nrep = "Rep_Epidemiologico";

            frmExport frmExport = new frmExport(this.sql, this.Text, nrep + Operativo.descripcion + "_" + DateTime.Today.ToString("yyyy-MM-dd"));
            frmExport.ShowDialog(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkReg_CheckedChanged(object sender, EventArgs e)
        {
            spinner1.Enabled = chkReg.Checked;
        }

        private void lstCIE10_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            string field = "";
            switch (e.Column)
            {
                case 0:
                    field = "CIE10";
                    break;
                case 1:
                    field = "DIAGNOSTICO";
                    break;
                case 2:
                    field = "CANTIDAD";
                    break;
            }


            if (this.orders[e.Column])
            {
                this.epidemiologo = this.epidemiologo.OrderBy(x => int.Parse(x[field])).ToList();
            }
            else
            {
                this.epidemiologo = this.epidemiologo.OrderByDescending(x => int.Parse(x[field])).ToList();
            }

            this.orders[e.Column] = !this.orders[e.Column];

            General.Fill(lstCIE10, this.epidemiologo, new string[] { "CIE10", "DIAGNOSTICO", "CANTIDAD" });
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (lstCIE10.Items.Count > 0)
            {
                string consul = cmbConsultorio.SelectedIndex == -1 ? "" : cmbConsultorio.SelectedValue.ToString();
                string fi = dtpFecIni.Value.ToShortDateString();
                string ff = dtpFecFin.Value.ToShortDateString();

                object result = WaitWindow.Show(WorkerMethodRpt, "Generando el reporte...", new string[] { consul, fi, ff });

                if (result == null)
                {
                    MessageBox.Show("No se pudo procesar el reporte.");
                    return;
                }

                frmCRViewer frg = new frmCRViewer(rpt);
                frg.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos para exportar\n\nDebe de realizar otra consulta", "Aviso");
            }
        }

        private void WorkerMethodRpt(object sender, WaitWindowEventArgs e)
        {
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            path = path + "/Dominio/Reportes/rptFrecEnf.rpt";

            rpt.Load(path);

            Conexion.CMD.CommandText = this.sql;

            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (ReportsDS ds = new ReportsDS())
                {
                    ds.Clear();
                    da.Fill(ds, 0, int.Parse(spinner1.Value.ToString()), "FrecEnf");
                    rpt.SetDataSource(ds);
                }
            }

            //rpt.SetParameterValue("consul", e.Arguments[0].ToString());
            //rpt.SetParameterValue("fi", e.Arguments[1].ToString());
            //rpt.SetParameterValue("ff", e.Arguments[2].ToString());
            rpt.SetParameterValue("texto", this.texto);

            e.Result = true;
        }

        private void spinner1_Leave(object sender, EventArgs e)
        {
            if (spinner1.Value > this.epidemiologo.Count)
            {
                spinner1.Value = this.epidemiologo.Count;
            }
        }
    }
}
