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
    public partial class frmProdMed : Form
    {
        string periodo = "";
        string subtitle = "";
        string vSQL = "";
        DataSet dt = new DataSet();
        ReportDocument rpt = new ReportDocument();

        public frmProdMed()
        {
            InitializeComponent();
        }

        private void frmProdMed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void frmProdMed_Load(object sender, EventArgs e)
        {
            this.turnoTableAdapter.Fill(this.tablaTipoDS.Turno);
            cmbTurno.SelectedIndex = -1;
            this.periodoPagoTableAdapter.Fill(this.periodoPagoDS.PeriodoPago);
            cmbPerPago.SelectedIndex = -1;
            this.produccionXMedicoTableAdapter.Fill(this.medicosDS.ProduccionXMedico);
            cmbCMP.SelectedIndex = -1;
            especialidadTableAdapter.Fill(consultoriosDS.Especialidad, Operativo.id_oper);
            cmbConsultorio.SelectedIndex = -1;
            string sql = "SELECT Descripcion, Id_Tipo, Id_Tabla FROM TablaTipo WHERE (Id_Tabla IN (SELECT Id_Tipo FROM TablaTipo AS TablaTipo_1 WHERE (Descripcion = 'TIPO_COLEGIATURA') AND (Id_Tabla = '0'))) ORDER BY Descripcion";
            List<Dictionary<string, string>> colegiaturas = General.GetDictionaryList(sql);
            General.Fill(grdColegiatura, colegiaturas);
            grdColegiatura.ClearSelection();

            cmbPerPago.Focus();
        }

        private void chkConsultorio_CheckedChanged(object sender, EventArgs e)
        {
            cmbConsultorio.SelectedIndex = -1;
            cmbConsultorio.Enabled = !cmbConsultorio.Enabled;
            cmbConsultorio.Focus();
        }

        private void cmbConsultorio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            General.setAll<Button, bool>(this, "Enabled", false);
            btnCons.Enabled = true;
        }

        private void chkEspecialista_CheckedChanged(object sender, EventArgs e)
        {
            cmbCMP.SelectedIndex = -1;
            cmbCMP.Enabled = !cmbCMP.Enabled;
            cmbCMP.Focus();
        }

        private void cmbCMP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            General.setAll<Button, bool>(this, "Enabled", false);
            btnCons.Enabled = true;
        }

        private void chkColegiaturas_CheckedChanged(object sender, EventArgs e)
        {
            grdColegiatura.ClearSelection();
            grdColegiatura.Enabled = !grdColegiatura.Enabled;
            grdColegiatura.Focus();
        }

        private void chkTurno_CheckedChanged(object sender, EventArgs e)
        {
            cmbTurno.SelectedIndex = -1;
            cmbTurno.Enabled = !cmbTurno.Enabled;
            cmbTurno.Focus();
        }

        private void btnSOP_Click(object sender, EventArgs e)
        {
            if (txtSOP.Text.Length == 0)
            {
                MessageBox.Show("Ingrese monto para Sala de Operaciones ...", "Advertencia");
                return;
            }

            this.subtitle = (cmbConsultorio.SelectedIndex != -1 ? "CONSULTORIO: " + cmbConsultorio.SelectedText : "");

            object result = WaitWindow.Show(WorkerMethodRptProdMedPrcSOP, "Generando el reporte...", new string[] { "SOP" });

            if (result == null)
            {
                MessageBox.Show("No se pudo procesar el reporte.");
                return;
            }

            frmCRViewer frg = new frmCRViewer(rpt);
            frg.ShowDialog();

        }

        private void cmbPerPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPerPago.SelectedIndex != -1)
            {
                Dictionary<string, string> perPag = General.GetSelectedDictionary(cmbPerPago);
                dtpFecIni.Value = DateTime.Parse(perPag["Date_Ini"]);
                dtpFecFin.Value = DateTime.Parse(perPag["Date_End"]);
                General.setAll<Button, bool>(this, "Enabled", false);
                btnCons.Enabled = true;
            }
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            if (txtProc.Text.Length == 0)
            {
                MessageBox.Show("Ingrese monto para procedimientos ...", "Advertencia");
                return;
            }

            this.subtitle = (cmbConsultorio.SelectedIndex != -1 ? "CONSULTORIO: " + cmbConsultorio.SelectedText : "");

            object result = WaitWindow.Show(WorkerMethodRptProdMedPrcSOP, "Generando el reporte...", new string[] { "PROCEDIMIENTO" });

            if (result == null)
            {
                MessageBox.Show("No se pudo procesar el reporte.");
                return;
            }

            frmCRViewer frg = new frmCRViewer(rpt);
            frg.ShowDialog();
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            General.setAll<Button, bool>(this, "Enabled", false);
            btnCons.Enabled = true;

            if (cmbPerPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione periodo de pago ...", "Aviso al usuario");
                return;
            }

            if (cmbCMP.SelectedIndex == -1)
            {
                MessageBox.Show("La marca de pago se realiza por especialista ...", "Aviso al usuario");
                return;
            }

            if (MessageBox.Show("Esta seguro de marcar los registros como pagados ... ?", "Aviso al usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string pp = cmbPerPago.SelectedValue.ToString();
                string fi = dtpFecIni.Value.ToShortDateString();
                string ff = dtpFecFin.Value.ToShortDateString();
                string ic = cmbConsultorio.SelectedIndex == -1 ? "" : cmbConsultorio.SelectedValue.ToString();
                string cm = cmbCMP.SelectedValue.ToString();
                string tr = cmbTurno.SelectedIndex == -1 ? "" : cmbTurno.SelectedValue.ToString();

                bool onlySelected = grdColegiatura.Enabled && !chkColegiaturas.Checked;
                List<Dictionary<string, string>> items = items = General.GetDictionaryList(grdColegiatura, onlySelected);

                string cl = "(";
                foreach (Dictionary<string, string> item in items)
                {
                    cl += "'" + item["gIdTipo"] + "',";
                }

                cl = cl.Substring(0, cl.Length - 1) + ")";

                string sql = "Update Cab_Cie10 Set Id_Per='" + pp + "' " +
"From Cab_Cie10 CB Inner Join Detalles D On CB.Nro_Historia=D.Nro_Historia Inner Join Personal M On " +
"CB.CMP=M.Id_Personal Inner Join MedBus MB On M.Id_Personal=MB.CMP Inner Join Buses B On " +
"CB.Id_Bus=B.Id_Bus Inner Join Consultorios C On B.Id_Esp=C.Id_Consultorio " +
"Where D.Pagado<>'' And CB.Id_Bus In(Select Id_Bus From Buses Where TBus='P' And Bus Not In" +
"('COMPUTO')) And CB.Fecha_Atencion BetWeen '" + fi + "' And '" + ff + "' And Left(M.TNCol,1) In " + cl;

                if (!chkConsultorio.Checked && cmbConsultorio.SelectedIndex != -1)
                {
                    sql += " And C.Id_Consultorio='" + ic + "' ";
                }

                if (!chkCMP.Checked && cmbCMP.SelectedIndex != -1)
                {
                    sql += " And CB.CMP='" + cm + "' ";
                }

                if (!chkTurno.Checked && cmbTurno.SelectedIndex != -1)
                {
                    sql += " And CB.Turno='" + tr + "' ";
                }

                Conexion.ExecuteNonQuery(sql);

                string sql2 = "Update ProdMedicos Set Id_Per='" + pp + "' " +
"From ProdMedicos PM Inner Join Personal M On PM.CMP=M.Id_Personal Inner Join MedBus MB On " +
"M.Id_Personal=MB.CMP Inner Join Buses B On MB.Id_Bus=B.Id_Bus Inner Join Consultorios C On " +
"B.Id_Esp=C.Id_Consultorio " +
"Where B.TBus='P' And PM.Fecha_Parte BetWeen '" + fi + "' And '" + ff + "' And Left(M.TNCol,1) In " + cl;

                if (!chkConsultorio.Checked && cmbConsultorio.SelectedIndex != -1)
                {
                    sql += " And C.Id_Consultorio='" + ic + "' ";
                }

                if (!chkCMP.Checked && cmbCMP.SelectedIndex != -1)
                {
                    sql += " And PM.CMP='" + cm + "' ";
                }

                if (!chkTurno.Checked && cmbTurno.SelectedIndex != -1)
                {
                    sql += " And PM.Turno='" + tr + "' ";
                }

                Conexion.ExecuteNonQuery(sql2);

                MessageBox.Show("Actualización culminada con éxito ... registros fueron marcados como pagados ...", "Aviso al usuario");
            }
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            object result = null;

            if (cmbPerPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione periodo de pago o ingrese rango de fechas ...", "Aviso al usuario");
                return;
            }

            string fi = dtpFecIni.Value.ToShortDateString();
            string ff = dtpFecFin.Value.ToShortDateString();
            string ic = cmbConsultorio.SelectedIndex == -1 ? "" : cmbConsultorio.SelectedValue.ToString();
            string cm = cmbCMP.SelectedIndex == -1 ? "" : cmbCMP.SelectedValue.ToString();
            string tr = cmbTurno.SelectedIndex == -1 ? "" : cmbTurno.SelectedValue.ToString();
            this.subtitle = (cmbConsultorio.SelectedIndex != -1 ? "CONSULTORIO: " + cmbConsultorio.SelectedText : "");
            this.periodo = "Periodo " + (cmbPerPago.SelectedIndex != -1 ? General.ProPer(cmbPerPago.SelectedText) : ("Del " + dtpFecIni.Value.ToLongDateString() + " al " + dtpFecFin.Value.ToLongDateString()));

            if (rbActual.Checked)
            {
                bool onlySelected = grdColegiatura.Enabled && !chkColegiaturas.Checked;
                List<Dictionary<string, string>> items = General.GetDictionaryList(grdColegiatura, onlySelected);

                string cl = "(";
                foreach (Dictionary<string, string> item in items)
                {
                    cl += "'" + item["gIdTipo"] + "',";
                }
                cl = cl.Substring(0, cl.Length - 1) + ")";

                this.vSQL = "Select DatePart(Year,CB.Fecha_Atencion)Año,DateName(Month,CB.Fecha_Atencion)Mes,CB.Fecha_Atencion," +
"M.Ape_Paterno+' '+M.Ape_Materno+', '+M.Nombres Medico,C.Descripcion Consultorio,P.Descripcion Producto," +
"D.Monto Precio,Case When P.Tipo='C' And Left(M.TNCol,1) Not In('E','T') Then Sum(D.Cantidad) " +
"When P.Tipo<>'C' And Left(M.TNCol,1) In('E','T') Then Sum(D.Cantidad) Else 0 End cCon," +
"Case When P.Tipo<>'C' And B.Bus<>'SOP' And Left(M.TNCol,1) Not In('E','T') Then Sum(D.Cantidad) " +
"Else 0 End cPrc,Case When P.Tipo<>'C' And B.Bus='SOP' Then Sum(D.Cantidad) Else 0 End cSOP," +
"Case When P.Tipo='C' And Left(M.TNCol,1) Not In('E','T') Then Sum((D.Monto*D.Cantidad)-D.Dscto) " +
"When P.Tipo<>'C' And Left(M.TNCol,1) In('E','T') Then Sum((D.Monto*D.Cantidad)-D.Dscto) Else 0.00 End tCon," +
"Case When P.Tipo<>'C' And B.Bus<>'SOP' And Left(M.TNCol,1) Not In('E','T') " +
"Then Sum((D.Monto*D.Cantidad)-D.Dscto) Else 0.00 End tPrc,Case When P.Tipo<>'C' And B.Bus='SOP' " +
"Then Sum((D.Monto*D.Cantidad)-D.Dscto) Else 0.00 End tSOP,T.Descripcion Turno,T.Valor CTurno," +
"T.Horas,TC.Descripcion Colegiatura,TC.Monto Sueldo " +
"From Cab_Cie10 CB Inner Join Detalles D On CB.Nro_Historia=D.Nro_Historia Inner Join Productos P On " +
"D.Id_Producto=P.Id_Producto Inner Join Personal M On CB.CMP=M.Id_Personal Inner Join Buses B On " +
"CB.Id_Bus=B.Id_Bus Inner Join Consultorios C On B.Id_Esp=C.Id_Consultorio Inner Join " +
"(Select Id_Tipo,Descripcion,Valor,Horas From TablaTipo TT Inner Join ValTurno V On TT.Id_Tipo=V.Id_Turno " +
"Where Id_Tabla In(Select Id_Tipo From TablaTipo Where Descripcion='TURNOS' And Id_Tabla='0'))T On " +
"CB.Turno=T.Id_Tipo Inner Join (Select Id_Tipo,Descripcion,Monto From TablaTipo TT Inner Join ValCol V On " +
"TT.Id_Tipo=V.TCol Where Id_Tabla In(Select Id_Tipo From TablaTipo Where Descripcion='TIPO_COLEGIATURA' " +
"And Id_Tabla='0'))TC On Left(M.TNCol,1)=TC.Id_Tipo " +
"Where D.Pagado<>'' And CB.Id_Bus In(Select Id_Bus From Buses Where TBus='P' And Bus Not In('COMPUTO')) " +
"And CB.Fecha_Atencion BetWeen '" + fi + "' And '" + ff + "' And Left(M.TNCol,1) In " + cl;

                if (!chkConsultorio.Checked && cmbConsultorio.SelectedIndex != -1)
                {
                    this.vSQL += " And C.Id_Consultorio='" + ic + "' ";
                }

                if (!chkCMP.Checked && cmbCMP.SelectedIndex != -1)
                {
                    this.vSQL += " And CB.CMP='" + cm + "' ";
                }

                if (!chkTurno.Checked && cmbTurno.SelectedIndex != -1)
                {
                    this.vSQL += " And CB.Turno='" + tr + "' ";
                }

                this.vSQL += "Group By DatePart(Year,CB.Fecha_Atencion),DateName(Month,CB.Fecha_Atencion),CB.Fecha_Atencion,B.Bus," +
"M.Ape_Paterno+' '+M.Ape_Materno+', '+M.Nombres,C.Descripcion,P.Descripcion,P.Tipo,D.Monto,T.Descripcion," +
"T.Valor,T.Horas,TC.Descripcion,TC.Monto,M.TNCol Union All " +
"Select DatePart(Year,PM.Fecha_Parte)Año,DateName(Month,PM.Fecha_Parte)Mes,PM.Fecha_Parte," +
"M.Ape_Paterno+' '+M.Ape_Materno+', '+M.Nombres Medico,C.Descripcion Consultorio,P.Descripcion " +
"Producto,PM.Precio,Sum(PM.Cantidad)cCon,0 cPrc,0 cSOP,Sum(PM.Monto)tCon,0.00 tPrc,0.00 tSOP," +
"T.Descripcion Turno,T.Valor CTurno,T.Horas,TC.Descripcion Colegiatura,TC.Monto Sueldo " +
"From ProdMedicos PM Inner Join Productos P On PM.Id_Producto=P.Id_Producto Inner Join Personal M On " +
"PM.CMP=M.Id_Personal Inner Join Consultorios C On PM.Id_Consultorio=C.Id_Consultorio Inner Join " +
"(Select Id_Tipo,Descripcion,Valor,Horas From TablaTipo TT Inner Join ValTurno V On TT.Id_Tipo=V.Id_TUrno " +
"Where Id_Tabla In (Select Id_Tipo From TablaTipo Where Descripcion='TURNOS' And Id_Tabla='0'))T On " +
"PM.Turno=T.Id_Tipo Inner Join (Select Id_Tipo,DescriMpcion,Monto From TablaTipo TT Inner Join ValCol V On " +
"TT.Id_Tipo=V.TCol Where Id_Tabla In (Select Id_Tipo From TablaTipo Where Descripcion='TIPO_COLEGIATURA' And " +
"Id_Tabla='0'))TC On Left(M.TNCol,1)=TC.Id_Tipo " +
"Where PM.Fecha_Parte BetWeen '" + fi + "' And '" + ff + "' And Left(M.TNCol,1) In " + cl;

                if (!chkConsultorio.Checked && cmbConsultorio.SelectedIndex != -1)
                {
                    this.vSQL += " And C.Id_Consultorio='" + ic + "' ";
                }

                if (!chkCMP.Checked && cmbCMP.SelectedIndex != -1)
                {
                    this.vSQL += " And PM.CMP='" + cm + "' ";
                }

                if (!chkTurno.Checked && cmbTurno.SelectedIndex != -1)
                {
                    this.vSQL += " And PM.Turno='" + tr + "' ";
                }

                this.vSQL += "Group By DatePart(Year,PM.Fecha_Parte),DateName(Month,PM.Fecha_Parte),PM.Fecha_Parte,M.Ape_Paterno" +
"+' '+M.Ape_Materno+', '+M.Nombres,C.Descripcion,P.Descripcion,PM.Precio,T.Descripcion,T.Valor,T.Horas," +
"TC.Descripcion,TC.Monto";

                result = WaitWindow.Show(WorkerMethodRptProdMedCon, "Generando el reporte...");

                int count = int.Parse(result.ToString());
                General.setAll<Button, bool>(this, "Enabled", count > 0);
                btnCons.Enabled = true;
            }
            else
            {

                this.vSQL = "Exec ProdEspec '" + fi + "','" + ff + "','" + cm + "','" + ic + "','" + tr + "'";

                result = WaitWindow.Show(WorkerMethodRptProdMedCon, "Generando el reporte...");

                int count = int.Parse(result.ToString());
                btnMarcar.Enabled = count > 0;
            }

            if (result == null)
            {
                MessageBox.Show("No se pudo procesar el reporte.");
                return;
            }

            frmCRViewer frg = new frmCRViewer(rpt);
            frg.ShowDialog();
        }

        private void chkHabFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecIni.Enabled = dtpFecFin.Enabled = chkHabFecha.Checked;
        }

        private void WorkerMethodRptProdMedCon(object sender, WaitWindowEventArgs e)
        {
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            path = path + "/Dominio/Reportes/rptProdMedCon.rpt";

            rpt.Load(path);

            int count = 0;
            string sql = "SELECT X.año, X.mes, X.fecha_atencion, X.medico, X.consultorio, SUM(X.ccon) AS cantidad, SUM(X.tcon) AS total, X.turno, X.cturno, X.horas, X.colegiatura, X.sueldo from (" + this.vSQL + ") X WHERE ccon>0 GROUP BY X.año, X.mes, X.fecha_atencion, X.medico, X.consultorio, X.turno, X.cturno, X.horas, X.colegiatura, X.sueldo";
            sql = "SELECT Y.año, Y.mes, Y.fecha_atencion, Y.medico, Y.consultorio, SUM(Y.cantidad) AS cantidad, SUM(Y.total) AS total, Y.turno, Y.cturno, Y.horas, Y.colegiatura, SUM(Y.sueldo * Y.cturno) AS sueldo from (" + sql + ") Y GROUP BY Y.año, Y.mes, Y.fecha_atencion, Y.medico, Y.consultorio, Y.turno, Y.cturno, Y.horas, Y.colegiatura ORDER BY 4, 3, 8";
            Conexion.CMD.CommandText = sql;
            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (ReportsDS ds = new ReportsDS())
                {
                    ds.Clear();
                    da.Fill(ds, "ProdMed");
                    count = ds.Tables["ProdMed"].Rows.Count;
                    rpt.SetDataSource(ds);
                }
            }

            rpt.SetParameterValue("periodo", this.periodo);
            rpt.SetParameterValue("subtitle", this.subtitle);

            e.Result = count.ToString();
        }

        private void WorkerMethodRptProdMedPrcSOP(object sender, WaitWindowEventArgs e)
        {
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            path = path + "/Dominio/Reportes/rptProdMedPrcSOP.rpt";

            rpt.Load(path);

            int count = 0;

            string sql = "";
            if (e.Arguments[0].ToString() == "PROCEDIMIENTO")
            {
                sql = "SELECT X.año, X.mes, X.fecha_atencion, X.medico, X.consultorio, X.producto, SUM(X.cprc) AS cantidad, SUM(X.tprc) AS total, '" + e.Arguments[0].ToString() + "' AS modo, X.sueldo FROM (" + this.vSQL + ") X WHERE X.cprc > 0 GROUP BY X.año, X.mes, X.fecha_atencion, X.medico, X.consultorio, X.producto, X.sueldo ORDER BY 9, 4, 3, 5, 6";
            }
            else
            {
                sql = "SELECT X.año, X.mes, X.fecha_atencion, X.medico, X.consultorio, X.producto, SUM(X.csop) AS cantidad, SUM(X.tsop) AS total, '" + e.Arguments[0].ToString() + "' AS modo, X.sueldo FROM (" + this.vSQL + ") X WHERE X.csop > 0 GROUP BY X.año, X.mes, X.fecha_atencion, X.medico, X.consultorio, X.producto, X.sueldo ORDER BY 9, 4, 3, 5, 6";
            }

            Conexion.CMD.CommandText = sql;
            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (ReportsDS ds = new ReportsDS())
                {
                    ds.Clear();
                    da.Fill(ds, "ProdMedPrcSOP");
                    count = ds.Tables["ProdMedPrcSOP"].Rows.Count;
                    rpt.SetDataSource(ds);
                }
            }

            rpt.SetParameterValue("periodo", this.periodo);
            rpt.SetParameterValue("subtitle", this.subtitle);

            e.Result = count.ToString();
        }

        private void WorkerMethodRptPagEsp(object sender, WaitWindowEventArgs e)
        {
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            path = path + "/Dominio/Reportes/rptPagEsp.rpt";

            rpt.Load(path);

            int count = 0;
            Conexion.CMD.CommandText = this.vSQL;
            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (ReportsDS ds = new ReportsDS())
                {
                    ds.Clear();
                    da.Fill(ds, "PagEsp");
                    count = ds.Tables["PagEsp"].Rows.Count;
                    rpt.SetDataSource(ds);
                }
            }

            rpt.SetParameterValue("periodo", this.periodo);
            rpt.SetParameterValue("subtitle", this.subtitle);

            e.Result = count.ToString();
        }
    }
}
