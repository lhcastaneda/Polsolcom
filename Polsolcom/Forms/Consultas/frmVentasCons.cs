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
    public partial class frmVentasCons : Form
    {
        string venConsTable = "#tmpVenCons";
        string venProdTable = "#tmpVenProd";
        List<Dictionary<string, string>> consultorios = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> venCons = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> venProds = new List<Dictionary<string, string>>();
        string sqlVenCons = "";
        string sqlVenProds = "";
        DataSet dt = new DataSet();
        ReportDocument rpt = new ReportDocument();

        public frmVentasCons()
        {
            InitializeComponent();
        }

        public int getOg()
        {
            return optDiario.Checked ? 1 : optMensual.Checked ? 2 : optAnual.Checked ? 3 : 4;
        }

        public void GenerateVenConsTable(int og, string fi, string ff)
        {
            string ic = "";
            if (lstConsultorios.Enabled)
            {
                foreach (int i in lstConsultorios.SelectedIndices)
                {
                    ic += this.consultorios[i]["Id_Consultorio"];
                }
            }
            else
            {
                foreach (Dictionary<string, string> item in this.consultorios)
                {
                    ic += item["Id_Consultorio"];
                }
            }

            //Borramos la tabla temporal
            Conexion.ExecuteNonQuery("IF OBJECT_ID('tempdb.dbo." + this.venConsTable + "', 'U') IS NOT NULL DROP TABLE " + this.venConsTable + ";");
            //Creamos tabla temporal
            string sql = "";
            switch (og)
            {
                case 1:
                    sql = "CREATE TABLE " + this.venConsTable + "(Consultorio varchar(50), Tickets int, Cantidad int, Total decimal(10,2), Fecha DateTime, TCons varchar(25), Operativo varchar(20), Mes varchar(10), Año int);";
                    break;
                case 2:
                    sql = "CREATE TABLE " + this.venConsTable + "(Consultorio varchar(50), Tickets int, Cantidad int, Total decimal(10,2), TCons varchar(25), Operativo varchar(20), Mes varchar(10), NMes int, Año int);";
                    break;
                case 3:
                    sql = "CREATE TABLE " + this.venConsTable + "(Consultorio varchar(50), Tickets int, Cantidad int, Total decimal(10,2), TCons varchar(25), Operativo varchar(20), Año int);";
                    break;
                case 4:
                    sql = "CREATE TABLE " + this.venConsTable + "(Consultorio varchar(50), Tickets int, Cantidad int, Total decimal(10,2), TCons varchar(25), Operativo varchar(20));";
                    break;
            }
            sql += "INSERT INTO " + this.venConsTable + " Exec TotCons '" + fi + "','" + ff + "','" + ic + "','" + og + "'";
            Conexion.ExecuteNonQuery(sql);
            //Generamos SQL
        }

        public void GenerateVenProdTable(int og, string fi, string ff)
        {
            string ic = "''";
            for (int i = 0; i < lstConsultorios.Items.Count; i++)
            {
                ic += lstConsultorios.Enabled ? (lstConsultorios.Items[i].Selected ? this.consultorios[i]["Id_Consultorio"] + "'',''" : "") : this.consultorios[i]["Id_Consultorio"] + "'',''";
            }
            ic = General.SafeSubstring(ic, 0, ic.Length - 3);

            //Borramos la tabla temporal
            Conexion.ExecuteNonQuery("IF OBJECT_ID('tempdb.dbo." + this.venProdTable + "', 'U') IS NOT NULL DROP TABLE " + this.venProdTable + ";");
            //Creamos tabla temporal
            string sql = "";
            switch (og)
            {
                case 1:
                    sql = "CREATE TABLE " + this.venProdTable + "(Consultorio varchar(50), Producto varchar(100), TProd varchar(25), Precio decimal(10,2), Cantidad int, Total decimal(10,2), Fecha DateTime, TCons varchar(25), Operativo varchar(20), Mes varchar(10), Año int);";
                    break;
                case 2:
                    sql = "CREATE TABLE " + this.venProdTable + "(Consultorio varchar(50), Producto varchar(100), TProd varchar(25), Precio decimal(10,2), Cantidad int, Total decimal(10,2), TCons varchar(25), Operativo varchar(20), Mes varchar(10), NMes int, Año int);";
                    break;
                case 3:
                    sql = "CREATE TABLE " + this.venProdTable + "(Consultorio varchar(50), Producto varchar(100), TProd varchar(25), Precio decimal(10,2), Cantidad int, Total decimal(10,2), TCons varchar(25), Operativo varchar(20), Año int);";
                    break;
                case 4:
                    sql = "CREATE TABLE " + this.venProdTable + "(Consultorio varchar(50), Producto varchar(100), TProd varchar(25), Precio decimal(10,2), Cantidad int, Total decimal(10,2), TCons varchar(25), Operativo varchar(20));";
                    break;
            }

            sql += "INSERT INTO " + this.venProdTable + " Exec TotTipProd '" + fi + "','" + ff + "','" + ic + "','" + og.ToString() + "'";
            Conexion.ExecuteNonQuery(sql);
        }

        public void cturno(string tur)
        {
            DateTime fecIni = dtpFecIni.Value;
            DateTime fecFin = dtpFecFin.Value;

            dtpFecIni.Value = new DateTime(fecIni.Year, fecIni.Month, fecIni.Day, (tur == "TARDE" ? 14 : 0), 0, 0);
            dtpFecFin.Value = new DateTime(fecFin.Year, fecFin.Month, fecFin.Day, (tur == "MAÑANA" ? 13 : 23), 59, 59);
        }

        public bool ejecons()
        {
            DateTime fi = dtpFecIni.Value;
            DateTime ff = dtpFecFin.Value;
            if (!General.CompFechas(fi, ff)) return false;

            int og = this.getOg();

            this.GenerateVenConsTable(og, General.FormatDateTime(fi), General.FormatDateTime(ff));
            this.ordcursor(1, 1, og);

            this.GenerateVenProdTable(og, General.FormatDateTime(fi), General.FormatDateTime(ff));
            this.ordcursor(2, 1, og);

            List<string> venProds_Cons = this.venProds.GroupBy(x => x["Consultorio"]).Select(x => x.Key).OrderBy(x => x).ToList();
            General.Fill(cmbConsultorioProd, venProds_Cons);

            List<string> venProds_TProd = this.venProds.GroupBy(x => x["TProd"]).Select(x => x.Key).OrderBy(x => x).ToList();
            General.Fill(cmbTipoProd, venProds_TProd);

            this.formagrid();

            btnImprimir.Enabled = (og == 1);

            return true;
        }

        public void formagrid()
        {
            if (optDiario.Checked)
            {
                gConsultorio.Width = 160;
                gFecha.Width = 100;
            }
            else
            {
                gConsultorio.Width = 260;
                gFecha.Width = 0;
            }
        }

        public void lconsultorios()
        {
            string op = cmbOperativo.SelectedIndex == -1 ? "" : cmbOperativo.SelectedValue.ToString();
            string tc = !chkTCons.Checked ? General.GetSelectedDictionary(grdTCons)["Id_Tipo"] : "";

            string sql = "Select Id_Consultorio,Descripcion From Consultorios Where Left(Id_Consultorio,3)='" + op + "' And Tipo Like '" + tc + "%' Order By 2";
            this.consultorios = General.GetDictionaryList(sql);
            General.Fill(lstConsultorios, this.consultorios, new string[] { "Descripcion" });
        }

        public void ordcursor(int xpg, int xor, int xgr)
        {
            switch (xpg)
            {
                case 1:

                    this.sqlVenCons = "Select * From " + this.venConsTable + " X Order By ";

                    switch (xgr)
                    {
                        case 1:
                            this.sqlVenCons += "X.Fecha,X.TCons,";
                            break;
                        case 2:
                            this.sqlVenCons += "X.Año,X.NMes,X.TCons,";
                            break;
                        case 3:
                            this.sqlVenCons += "X.Año,X.TCons,";
                            break;
                        case 4:
                            this.sqlVenCons += "X.TCons,";
                            break;
                    }

                    switch (xor)
                    {
                        case 1:
                            this.sqlVenCons += "X.Consultorio";
                            break;
                        case 2:
                            this.sqlVenCons += "X.Tickets Desc";
                            break;
                        case 3:
                            this.sqlVenCons += "X.Cantidad Desc";
                            break;
                        case 4:
                            this.sqlVenCons += "X.Total Desc";
                            break;
                    }

                    this.venCons = General.GetDictionaryList(this.sqlVenCons);

                    if (xgr == 1)
                    {
                        General.Fill(grdVenCons, this.venCons, new string[] { "Consultorio", "Tickets", "Cantidad", "Total", "Fecha" });
                    }
                    else
                    {
                        General.Fill(grdVenCons, this.venCons, new string[] { "Consultorio", "Tickets", "Cantidad", "Total" });
                    }

                    break;
                case 2:
                    string xcn = cmbConsultorioProd.SelectedIndex == -1 ? "" : cmbConsultorioProd.SelectedItem.ToString();
                    string xtp = cmbTipoProd.SelectedIndex == -1 ? "" : cmbTipoProd.SelectedItem.ToString();
                    string xpr = txtProductoProd.Text;

                    this.sqlVenProds = "Select * From " + this.venProdTable + " X Where X.Consultorio Like '" + xcn + "%' And X.TProd Like " + "'" + xtp + "%' And X.Producto Like '" + xpr + "%' Order By ";

                    switch (xgr)
                    {
                        case 1:
                            this.sqlVenProds += "X.Fecha,X.TCons,";
                            break;
                        case 2:
                            this.sqlVenProds += "X.Año,X.NMes,X.TCons,";
                            break;
                        case 3:
                            this.sqlVenProds += "X.Año,X.TCons,";
                            break;
                        case 4:
                            this.sqlVenProds += "X.TCons,";
                            break;
                    }

                    switch (xor)
                    {
                        case 1:
                            this.sqlVenProds += "X.Consultorio";
                            break;
                        case 2:
                            this.sqlVenProds += "X.Tipo";
                            break;
                        case 3:
                            this.sqlVenProds += "X.Cantidad Desc";
                            break;
                        case 4:
                            this.sqlVenProds += "X.Total Desc";
                            break;
                    }

                    this.venProds = General.GetDictionaryList(this.sqlVenProds);
                    General.Fill(grdVenProds, this.venProds, new string[] { "Consultorio", "Producto", "TProd", "Precio", "Cantidad", "Total" });

                    break;
            }

            this.sumcursor(xpg);
        }

        public void sumcursor(int xpg)
        {
            switch (xpg)
            {
                case 1:
                    txtTickCons.Text = this.venCons.Sum(x => int.Parse(x["Tickets"])).ToString();
                    txtCantCons.Text = this.venCons.Sum(x => int.Parse(x["Cantidad"])).ToString();
                    txtTotalCons.Text = this.venCons.Sum(x => decimal.Parse(x["Cantidad"])).ToString("N");
                    break;
                case 2:
                    txtCantProds.Text = this.venProds.Sum(x => int.Parse(x["Cantidad"])).ToString();
                    txtTotalProds.Text = this.venProds.Sum(x => decimal.Parse(x["Cantidad"])).ToString("N");
                    break;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmVentasCons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSalir_Click(btnSalir, new EventArgs());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmVentasCons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaTipoDS.ModalidadEspecialidad' table. You can move, or remove it, as needed.
            this.modalidadEspecialidadTableAdapter.Fill(this.tablaTipoDS.ModalidadEspecialidad);
            this.operativoTableAdapter.Fill(this.operativos.Operativo);
            cmbOperativo.SelectedValue = Operativo.id_oper;

            cmbTurno.SelectedItem = "COMPLETO";
            cmbTurno_SelectionChangeCommitted(cmbTurno, new EventArgs());

            btnExportar.Enabled = (Usuario.tipo == "A");
            dtpFecIni.Value = DateTime.Now;
            dtpFecFin.Value = DateTime.Now;

            this.lconsultorios();
            this.ejecons();
        }

        private void cmbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTurno.SelectedIndex > -1)
            {
                this.cturno(cmbTurno.SelectedItem.ToString());
            }
        }

        private void chkConsultorios_CheckedChanged(object sender, EventArgs e)
        {
            lstConsultorios.Enabled = !chkConsultorios.Checked;
        }

        private void grdVenProds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                dtpFecIni.Focus();
            }
        }

        private void cmbConsultorioProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                cmbConsultorioProd.SelectedIndex = -1;
            }
        }

        private void cmbConsultorioProd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ordcursor(2, 1, this.getOg());
        }

        private void cmbTipoProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                cmbTipoProd.SelectedIndex = -1;
            }
        }

        private void cmbTipoProd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ordcursor(2, 1, this.getOg());
        }

        private void txtProductoProd_TextChanged(object sender, EventArgs e)
        {
            this.ordcursor(2, 1, this.getOg());
        }

        private void grdVendTProds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                dtpFecIni.Focus();
            }
        }

        private void cmbConsultorioTProd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ordcursor(2, 1, this.getOg());
        }

        private void cmbTipoTProd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ordcursor(2, 1, this.getOg());
        }

        private void txtProductoTProd_TextChanged(object sender, EventArgs e)
        {
            this.ordcursor(2, 1, this.getOg());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.ejecons();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (this.grdVenCons.Items.Count == 0)
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
            /*
             *  SELECT vencons
 cmos = 'N'
 REPORT FORM tot_ven_esp.frx PREVIEW NOWAIT*/
        }

        private void cmbOperativo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                cmbOperativo.SelectedIndex = -1;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string sql = "";
            string nrep = "";
            if (tabVendidos.SelectedIndex == 0)
            {
                sql = this.sqlVenCons;
                nrep = "Tot_Tip_Cons_";
            }
            else
            {
                sql = this.sqlVenProds;
                nrep = "Tot_Tip_Prod_";
            }

            frmExport frmExport = new frmExport(sql, this.Text, nrep + Operativo.descripcion + "_" + DateTime.Today.ToString("yyyy-MM-dd"));
            frmExport.ShowDialog(this);
            /*
    IF MESSAGEBOX('Desea enviar informacion de resumen ... ?', 0292, 'Aviso al usuario')=6
       nconn = SQLSTRINGCONNECT(getsys('getsys.rn', 'SUMMARYREMOTE'))
       IF nconn<0
          = MESSAGEBOX('Error en la conexion', 16, 'Advertencia')
       ENDIF
       SELECT vencons
       GOTO TOP
       SCAN
          op = ALLTRIM(vencons.operativo)
          fe = DTOC(vencons.fecha)
          te = ALLTRIM(vencons.tcons)
          es = ALLTRIM(vencons.consultorio)
          dv = vencons.tickets
          cn = vencons.cantidad
          tt = vencons.total
          scad = 'Insert into res_ven_esp values(?op,?fe,?te,?es,?dv,?cn,?tt)'
          ejecuta(nconn, scad)
       ENDSCAN
       nok = SQLDISCONNECT(nconn)
       IF nok<0
          = MESSAGEBOX('Error al cerrar la conexion', 64, 'SQL Error')
       ENDIF
    ENDIF
 */
        }

        private void grdTCons_SelectionChanged(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(grdTCons, false);

            if (i > -1)
            {
                this.lconsultorios();
            }
        }

        private void chkTCons_CheckedChanged(object sender, EventArgs e)
        {
            grdTCons.Enabled = !chkTCons.Checked;

            if (chkTCons.Checked)
            {
                grdTCons.CurrentCell = null;
            }
            else
            {
                if (grdTCons.Rows.Count > 0)
                {
                    grdTCons.CurrentCell = grdTCons.Rows[0].Cells[1];
                }
            }

            this.lconsultorios();

        }

        private void grdVenCons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                dtpFecIni.Focus();
            }
        }

        private void grdVenCons_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.ordcursor(1, e.Column, this.getOg());
        }

        private void grdVenProds_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    this.ordcursor(2, 1, this.getOg());
                    break;
                case 2:
                    this.ordcursor(2, 2, this.getOg());
                    break;
                case 4:
                    this.ordcursor(2, 3, this.getOg());
                    break;
                case 5:
                    this.ordcursor(2, 4, this.getOg());
                    break;
            }
        }

        private void WorkerMethodRpt(object sender, WaitWindowEventArgs e)
        {
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            path = path + "/Dominio/Reportes/rptTotVenEsp.rpt";

            rpt.Load(path);

            Conexion.CMD.CommandText = this.sqlVenCons;

            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (ReportsDS ds = new ReportsDS())
                {
                    ds.Clear();
                    da.Fill(ds, "VenCons");
                    rpt.SetDataSource(ds);
                }
            }

            e.Result = true;
        }
    }
}
