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

namespace Polsolcom.Forms.Consultas
{
    public partial class frmTotUser : Form
    {
        DataSet dt = new DataSet();
        ReportDocument rpt = new ReportDocument();
        string vSQL = "";
        List<Dictionary<string, string>> VTot_Users = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> xOcus = new List<Dictionary<string, string>>();

        public frmTotUser()
        {
            InitializeComponent();
        }

        void filtra()
        {
            grdToTUser.Items.Clear();

            string fini = dtpFecIni.Value.ToShortDateString();
            string ffin = dtpFecFin.Value.ToShortDateString();

            this.vSQL = "Select Fecha,Digitador,TkVend,TkAnul,Extorno,Cantidad,Total,Id_Oper,'' As Obs " +
                "From Tot_User Where Fecha Between '" + fini + "' And '" + ffin + "' And Id_Oper='" + Operativo.id_oper + "' Order By 1,2";
            this.VTot_Users = General.GetDictionaryList(this.vSQL);

            fini = General.FormatDateTime(dtpFecIni.Value);
            ffin = General.FormatDateTime(dtpFecFin.Value);

            string sql = "Select Cast(Convert(Varchar(10),Fecha_Emision,103)As DateTime)Fecha,Digitador,Nro_Historia From Tickets " +
                "Where Nro_Historia Not In (Select Nro_Historia From Detalles) And Fecha_Emision Between '" + fini + "' And '" + ffin + "' " +
                "Group By Cast(Convert(Varchar(10),Fecha_Emision,103)As DateTime),Digitador,Nro_Historia";
            this.xOcus = General.GetDictionaryList(sql);

            if (this.VTot_Users.Count > 0)
            {
                if (this.xOcus.Count > 0)
                {
                    foreach (Dictionary<string, string> vTot_User in this.VTot_Users)
                    {
                        vTot_User["Fecha"] = DateTime.Parse(vTot_User["Fecha"]).ToShortDateString();
                        foreach (Dictionary<string, string> xOcu in this.xOcus)
                        {
                            xOcu["Fecha"] = DateTime.Parse(xOcu["Fecha"]).ToShortDateString();
                            if (vTot_User["Fecha"] == xOcu["Fecha"] && vTot_User["Digitador"] == xOcu["Digitador"])
                            {
                                vTot_User["Obs"] += (vTot_User["Obs"].Length == 0 ? xOcu["Nro_Historia"] : ", " + xOcu["Nro_Historia"]);
                            }
                        }

                        vTot_User["Digitador"] = General.TradUser(vTot_User["Digitador"]);
                        vTot_User["Total"] = decimal.Parse(vTot_User["Total"]).ToString("N");
                    }

                    this.VTot_Users.Sort((x, y) => {
                        int ret = DateTime.Parse(x["Fecha"]).CompareTo(DateTime.Parse(y["Fecha"]));
                        if (ret == 0) ret = x["Digitador"].CompareTo(y["Digitador"]);
                        return ret;
                    });

                    General.Fill(grdToTUser, this.VTot_Users, new string[] { "Fecha", "Digitador", "TkVend", "TkAnul", "Extorno", "Cantidad", "Total"});

                    for (int i = 0; i < grdToTUser.Items.Count; i++)
                    {
                        if (this.VTot_Users[i]["Obs"].Length > 0)
                        {
                            grdToTUser.Items[i].ToolTipText = this.VTot_Users[i]["Obs"];
                        }
                    }

                    txtVend.Text = this.VTot_Users.Sum(x => int.Parse(x["TkVend"])).ToString();
                    txtAnul.Text = this.VTot_Users.Sum(x => int.Parse(x["TkAnul"])).ToString();
                    txtExt.Text = this.VTot_Users.Sum(x => int.Parse(x["Extorno"])).ToString();
                    txtCantidad.Text = this.VTot_Users.Sum(x => int.Parse(x["Cantidad"])).ToString();
                    txtTotal.Text = this.VTot_Users.Sum(x => decimal.Parse(x["Total"])).ToString("N");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.filtra();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string fi = General.FormatDateTime(dtpFecIni.Value);
            string ff = General.FormatDateTime(dtpFecFin.Value);
            string sql = "Exec UpTotUser '" + fi + "','" + ff + "','" + Operativo.id_oper + "'";
            Conexion.ExecuteNonQuery(sql);
            this.filtra();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (this.VTot_Users.Count == 0)
            {
                MessageBox.Show("'No hay resultados a imprimir ...", "Aviso al usuario");
                return;
            }

            object result = WaitWindow.Show(WorkerMethodRpt, "Generando el reporte...", new string[] { "SOP" });

            if (result == null)
            {
                MessageBox.Show("No se pudo procesar el reporte.");
                return;
            }

            frmCRViewer frg = new frmCRViewer(rpt);
            frg.ShowDialog();
        }

        private void frmTotUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSalir_Click(btnSalir, new EventArgs());
            }
        }

        private void frmTotUser_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today;
            dtpFecIni.Value = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            dtpFecFin.Value = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);
            btnActualizar_Click(btnActualizar, new EventArgs());
        }

        private void WorkerMethodRpt(object sender, WaitWindowEventArgs e)
        {
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            path = path + "/Dominio/Reportes/rptTotUser.rpt";

            rpt.Load(path);

            Conexion.CMD.CommandText = this.vSQL;
            int count = 0;

            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (ReportsDS ds = new ReportsDS())
                {
                    ds.Clear();
                    da.Fill(ds, "TotUser");
                    count = ds.Tables["TotUser"].Rows.Count;

                    foreach (DataRow row in ds.Tables["TotUser"].Rows)
                    {
                        row["Digitador"] = General.TradUser(row["Digitador"].ToString());
                    }
                    rpt.SetDataSource(ds);
                }
            }

            e.Result = count.ToString();
        }
    }
}
