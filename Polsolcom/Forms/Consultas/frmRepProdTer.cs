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
    public partial class frmRepProdTer : Form
    {
        DataSet dt = new DataSet();
        ReportDocument rpt = new ReportDocument();
        //
        string pcon = "R";
        string sqlResultado = "";
        string sqlLista = "";
        string sqlResumen = "";
        List<Dictionary<string, string>> fechas = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> lista = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> detalles = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> resumen = new List<Dictionary<string, string>>();

        public frmRepProdTer()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRepProdTer_Load(object sender, EventArgs e)
        {
            this.tipoSubProductoTableAdapter.Fill(this.tablaTipoDS.TipoSubProducto);
            cmbTPEsp.SelectedIndex = -1;

            this.turnoTableAdapter.Fill(this.tablaTipoDS.Turno);
            cmbTurno.SelectedIndex = -1;

            this.periodoPagoTableAdapter.Fill(this.periodoPagoDS.PeriodoPago);
            cmbPerPago.SelectedIndex = -1;

            this.especialidadTableAdapter.Fill(consultoriosDS.Especialidad, Operativo.id_oper);
            cmbConsultorio.SelectedIndex = -1;

            this.busesByModeValueTableAdapter.Fill(busesDS.BusesByModeValue, "1", Operativo.id_oper);
            cmbBus.SelectedIndex = -1;

            this.especialistasTableAdapter.Fill(this.medicosDS.Especialistas);
            cmbCMP.SelectedIndex = -1;

        }

        private void chkTAllTurnos_CheckedChanged(object sender, EventArgs e)
        {
            txtTickets.Text = this.resumen.Sum(x => int.Parse(x["NTickets"])).ToString();
            txtCantidad.Text = this.resumen.Sum(x => int.Parse(x["NCant"])).ToString();
            txtTotal.Text = this.resumen.Sum(x => decimal.Parse(x["NTotal"])).ToString("N");

            cmbTurno.SelectedIndex = -1;
            cmbTurno.Enabled = !cmbTurno.Enabled;
            cmbTurno.Focus();
        }

        private void dtpFecFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecFin.Value.CompareTo(dtpFecIni.Value) < 0)
            {
                MessageBox.Show("Rango incorrecto", "Aviso");
                dtpFecFin.ResetText();
                dtpFecFin.Focus();
                return;
            }

            string fi = dtpFecIni.Value.ToShortDateString();
            string ff = dtpFecFin.Value.ToShortDateString();
            string pg = this.pcon;

            string sql = "Select Fecha_Atencion Fecha From Cab_Cie10 C Inner Join Detalles D On C.Nro_Historia=D.Nro_Historia " + 
                "Where Fecha_Atencion Between '" + fi + "' And '" + ff + "' And Pagado";
            sql += (pg == "%" ? " Like '" + pg + "' " : "='" + pg + "' ");
            sql += "Group By Fecha_Atencion Order By 1";

            this.fechas = General.GetDictionaryList(sql);
            General.Fill(lstFechas, this.fechas, new string[] { "Fecha" });

            for (int i = 0; i < lstFechas.Items.Count; i++)
            {
                lstFechas.Select();
                lstFechas.EnsureVisible(i);
                lstFechas.Items[i].Selected = true;
                lstFechas.Items[i].Focused = true;
                lstFechas.Items[i].EnsureVisible();
            }
        }

        private void grdListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(grdListado, false);

            if (i > -1)
            {
                string pg = this.pcon;
                string nh = this.lista[i]["Nro_Historia"];
                string sql = "Select P.Descripcion Producto,CONVERT(DECIMAL(10,2), D.Monto) As Precio,D.Cantidad,CONVERT(DECIMAL(10,2),((D.Monto*D.Cantidad)-D.Dscto)) As Total From " +
"Tickets T Inner Join Detalles D On T.Nro_Historia=D.Nro_Historia Inner Join Productos P On D.Id_Producto=" +
"P.Id_Producto Where T.ForPago='' And T.Anulado='' And T.Nro_Historia='" + nh + "' And D.Pagado Like '" + pg + "'";
                this.detalles = General.GetDictionaryList(sql);
                General.Fill(grdDetalle, this.detalles, new string[] { "Producto", "Precio", "Cantidad", "Total" });
                total.Text = this.detalles.Sum(x => decimal.Parse(x["Total"])).ToString("N");
            }
        }

        private void rbProcesados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProcesados.Checked)
            {
                this.pcon = "R";
            }
        }

        private void rbPagados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPagados.Checked)
            {
                this.pcon = "P";
            }
        }

        private void rbNoProcesados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoProcesados.Checked)
            {
                this.pcon = "";
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                this.pcon = "%";
            }
        }

        private void chkAllConsultorios_CheckedChanged(object sender, EventArgs e)
        {
            cmbConsultorio.SelectedIndex = -1;
            cmbConsultorio.Enabled = !cmbConsultorio.Enabled;
            cmbConsultorio_SelectionChangeCommitted(cmbConsultorio, new EventArgs());
            cmbConsultorio.Focus();
        }


        private void cmbConsultorio_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cmbBus.SelectedIndex = -1;

            if (cmbConsultorio.SelectedIndex > -1)
            {
                string ic = cmbConsultorio.SelectedValue.ToString();
                this.busesByModeValueTableAdapter.Fill(busesDS.BusesByModeValue, "0", ic);
            }
            else
            {
                this.busesByModeValueTableAdapter.Fill(busesDS.BusesByModeValue, "1", Operativo.id_oper);
            }

            cmbBus.SelectedIndex = -1;
        }

        private void chkAllBuses_CheckedChanged(object sender, EventArgs e)
        {
            cmbBus.SelectedIndex = -1;
            cmbBus.Enabled = !cmbBus.Enabled;
            cmbBus.Focus();
        }

        private void cmbBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                cmbBus.SelectedIndex = -1;
            }
        }

        private void cmbCMP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                cmbCMP.SelectedIndex = -1;
            }
        }

        private void chkAllCMP_CheckedChanged(object sender, EventArgs e)
        {
            cmbCMP.SelectedIndex = -1;
            cmbCMP.Enabled = !cmbCMP.Enabled;
            cmbCMP.Focus();
        }

        private void cmbTPEsp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                cmbTPEsp.SelectedIndex = -1;
            }
        }

        private void chkAllProEsp_CheckedChanged(object sender, EventArgs e)
        {
            cmbTPEsp.SelectedIndex = -1;
            cmbTPEsp.Enabled = !cmbTPEsp.Enabled;
            cmbTPEsp.Focus();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (dtpFecIni.Value == null || dtpFecFin.Value == null)
            {
                MessageBox.Show("Ingrese el rango de fechas a procesar ...", "Advertencia");
                cmbPerPago.Focus();
                return;
            }

            string cran = "(";
            foreach(int i in lstFechas.SelectedIndices)
            {
                cran += "'" + DateTime.Parse(this.fechas[i]["Fecha"]).ToShortDateString() + "',";
            }

            if (cran == "(")
            {
                MessageBox.Show("No hay fechas seleccionadas ...", "Advertencia");
                return;
            }

            cran = cran.Substring(0, cran.Length - 1) + ") ";

            grdListado.Items.Clear();
            grdDetalle.Items.Clear();
            grdResumen.Items.Clear();

            txtTickets.Text = txtCantidad.Text = "0";
            total.Text = txtTotal.Text = "0.00";
            chkTAllTurnos.Checked = true;
            cmbTurno.Enabled = false;
            cmbTurno.SelectedIndex = -1;

            string pg = this.pcon;

            this.sqlResultado = "Select CB.Fecha_Atencion,T.Serie,T.Nro_Ticket Ticket,P.Nombre,P.Ape_Paterno,P.Ape_Materno," +
"SubString(M.TNCol,2,7)CMP,C.Descripcion Consultorio,B.Bus,Pr.Descripcion Producto, CONVERT(DECIMAL(10,2), D.Monto) As Precio," +
"D.Cantidad, CONVERT(DECIMAL(10,2), ((D.Monto*D.Cantidad)-D.Dscto)) As Total,CB.Turno,CB.Nro_Historia " +
"From Cab_Cie10 CB Inner Join Tickets T On CB.Nro_Historia=T.Nro_Historia " +
"Inner Join Detalles D On T.Nro_Historia=D.Nro_Historia Inner Join Buses B On CB.Id_Bus=B.Id_Bus " +
"Inner Join Personal M On CB.CMP=M.Id_Personal Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " +
"Inner Join Pacientes P On P.Id_Paciente=T.Id_paciente Inner Join Productos Pr On D.Id_Producto=Pr.Id_Producto " +
"Where T.ForPago='' And T.Anulado='' And CB.Fecha_Atencion In " + cran + " And D.Pagado Like '" + pg + "' ";
            this.sqlResultado += cmbConsultorio.SelectedIndex == -1 ? "" : "And C.Id_Consultorio='" + cmbConsultorio.SelectedValue.ToString() + "' ";
            this.sqlResultado += cmbBus.SelectedIndex == -1 ? "" : "And CB.Id_Bus='" + cmbBus.SelectedValue.ToString() + "' ";
            this.sqlResultado += cmbCMP.SelectedIndex == -1 ? "" : "And CB.CMP='" + cmbCMP.SelectedValue.ToString() + "' ";
            this.sqlResultado += cmbTPEsp.SelectedIndex == -1 ? "" : "And Pr.TPEsp='" + cmbTPEsp.SelectedValue.ToString() + "' ";

            this.sqlLista = "SELECT X.Fecha_Atencion, X.Serie, X.Ticket, X.CMP, X.Consultorio, COUNT(X.Ticket) AS Nro, X.Bus, SUM(X.Total) AS Total, X.Nro_Historia, X.Turno, SUM(X.Cantidad) AS Cantidad FROM (" + this.sqlResultado + ") X GROUP BY X.Fecha_Atencion, X.Consultorio, X.Bus, X.Serie, X.Ticket, X.CMP, X.Nro_Historia, X.Turno";

            this.lista = General.GetDictionaryList(this.sqlLista + " ORDER BY X.Fecha_Atencion, X.Consultorio, X.Bus, X.CMP, X.Nro_Historia");
            if (this.lista.Count > 0)
            {
                General.Fill(grdListado, this.lista, new string[] {"Fecha_Atencion", "Serie", "Ticket", "CMP", "Consultorio", "Nro", "Bus", "Total" });
                btnExportar.Enabled = btnMarcar.Enabled = btnImprimir.Enabled = true;
                grdListado.Focus();

                grdListado.Select();
                grdListado.EnsureVisible(0);
                grdListado.Items[0].Selected = true;
                grdListado.Items[0].Focused = true;
                grdListado.Items[0].EnsureVisible();
            }
            else
            {
                MessageBox.Show("Consulta no genero ningun resultado ... verifique los criterios ...", "Aviso al usuario");
                btnExportar.Enabled = btnMarcar.Enabled = btnImprimir.Enabled = false;
                return;
            }

            this.sqlResumen = "SELECT X.Fecha_Atencion AS Fecha, COUNT(X.Ticket) AS NTickets, SUM(X.Cantidad) AS NCant, SUM(X.Total) AS NTotal, X.Turno FROM (" + this.sqlLista + ") X GROUP BY X.Fecha_Atencion, X.Turno ORDER BY X.Fecha_Atencion";
            this.resumen = General.GetDictionaryList(this.sqlResumen);

            txtTickets.Text = this.resumen.Sum(x => int.Parse(x["NTickets"])).ToString();
            txtCantidad.Text = this.resumen.Sum(x => int.Parse(x["NCant"])).ToString();
            txtTotal.Text = this.resumen.Sum(x => decimal.Parse(x["NTotal"])).ToString("N");

            General.Fill(grdResumen, this.resumen, new string[] { "Fecha", "NTickets", "NCant", "NTotal" });
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dtpFecIni.Value == null || dtpFecFin.Value == null)
            {
                MessageBox.Show("Debe de ingresar el rango de fechas a procesar ...", "Aviso al usuario");
                cmbPerPago.Focus();
                return;
            }
            else
            {
                if (grdListado.Items.Count > 0)
                {
                    frmExport frmExport = new frmExport(this.sqlResultado + "Order By CB.Fecha_Atencion,T.Nro_Ticket,Pr.Descripcion", this.Text, "Terceros_" + Operativo.descripcion + "_" + DateTime.Today.ToString("yyyy-MM-dd"));
                    frmExport.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar\ndebe realizar otra consulta", "Aviso al usuario");
                }
            }
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (cmbPerPago.SelectedIndex == -1)
            {
                MessageBox.Show("No hay periodo de pago seleccionado ...", "Advertencia");
                return;
            }

            if (MessageBox.Show("Esta seguro de marcar como pagado segun el periodo seleccionado ... ?", "Aviso al usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (grdListado.Items.Count > 0)
                {
                    string sqlFechas = "SELECT X.Fecha_Atencion AS Fecha FROM (" + this.sqlLista + ") X GROUP BY X.Fecha_Atencion ORDER BY 1";
                    List<Dictionary<string, string>> fechas = General.GetDictionaryList(sqlFechas);

                    string cr = "";
                    foreach (Dictionary<string, string> fecha in fechas)
                    {
                        cr += "'" + DateTime.Parse(fecha["Fecha"]).ToShortDateString() + "',";
                    }
                    cr = cr.Substring(0, cr.Length - 1);
                    string ic = cmbConsultorio.SelectedIndex == -1 ? "" : cmbConsultorio.SelectedValue.ToString();
                    string ib = cmbBus.SelectedIndex == -1 ? "" : cmbBus.SelectedValue.ToString();
                    string cm = cmbCMP.SelectedIndex == -1 ? "" : cmbCMP.SelectedValue.ToString();
                    string te = cmbTPEsp.SelectedIndex == -1 ? "" : cmbTPEsp.SelectedValue.ToString();
                    string pp = cmbPerPago.SelectedIndex == -1 ? "" : cmbPerPago.SelectedValue.ToString();

                    string sql = "Update Cab_Cie10 Set Id_Per='" + pp + "' " +
"From Cab_Cie10 CB Inner Join Tickets T On CB.Nro_Historia=T.Nro_Historia " +
"Inner Join Detalles D On T.Nro_Historia=D.Nro_Historia Inner Join Productos P On " +
"P.Id_Producto=D.Id_Producto Inner Join Consultorios C On C.Id_Consultorio=T.Id_Consultorio " +
"Where T.ForPago='' And T.Anulado='' And CB.Fecha_Atencion In (" + cr + ") And D.Pagado='R' And " +
"P.TPEsp Like '" + te + "'+'%' And CB.CMP Like '" + cm + "'+'%' And C.Id_Consultorio Like '" + ic + "'+'%' And CB.Id_Bus Like '" + ib + "'";
                    Conexion.ExecuteNonQuery(sql);

                    string sql2 = "Update Detalles Set Pagado='P' " +
"From Cab_Cie10 CB Inner Join Tickets T On CB.Nro_Historia=T.Nro_Historia " +
"Inner Join Detalles D On T.Nro_Historia=D.Nro_Historia Inner Join Productos P On " +
"P.Id_Producto=D.Id_Producto Inner Join Consultorios C On C.Id_Consultorio=T.Id_Consultorio " +
"Where T.ForPago='' And T.Anulado='' And CB.Fecha_Atencion In (" + cr + ") And D.Pagado='R' And " +
"P.TPEsp Like '" + te + "%' And CB.CMP Like '" + cm + "%' And C.Id_Consultorio Like '" + ic + "%' And CB.Id_Bus Like '" + ib + "'";
                    Conexion.ExecuteNonQuery(sql2);

                    MessageBox.Show("Actualización culminada con éxito ... registros fueron marcados como pagados ...", "Aviso al usuario");
                    btnMarcar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No hay datos para marca de pagado ...\n\nDebe realizar otra consulta ...", "Advertencia");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTurno.SelectedIndex > -1)
            {
                string xturn = cmbTurno.SelectedValue.ToString();
                List<Dictionary<string, string>> list = this.resumen.FindAll(x => x["Turno"] == xturn);

                General.Fill(grdResumen, this.resumen, new string[] { "Fecha", "NTickets", "NCant", "NTotal" });

                txtTickets.Text = list.Sum(x => int.Parse(x["NTickets"])).ToString();
                txtCantidad.Text = list.Sum(x => int.Parse(x["NCant"])).ToString();
                txtTotal.Text = list.Sum(x => decimal.Parse(x["NTotal"])).ToString("N");
            }
        }

        private void cmbPerPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                cmbPerPago.SelectedIndex = -1;
            }
        }

        private void cmbPerPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPerPago.SelectedIndex > -1)
            {
                Dictionary<string, string> perPag = General.GetSelectedDictionary(cmbPerPago);
                dtpFecIni.Value = DateTime.Parse(perPag["Date_Ini"]);
                dtpFecFin.Value = DateTime.Parse(perPag["Date_End"]);
                //dtpFecFin_ValueChanged(dtpFecFin, new EventArgs());
            }
        }

        private void chkHabFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecIni.Enabled = !dtpFecIni.Enabled;
            dtpFecFin.Enabled = !dtpFecFin.Enabled;
            cmbPerPago.SelectedIndex = -1;
        }

        private void frmRepProdTer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSalir_Click(btnSalir, new EventArgs());
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dtpFecIni.Value == null && dtpFecFin.Value == null)
            {
                MessageBox.Show("Debe ingresar el rango de fechas a consultar ...", "Aviso al usuario");
                cmbPerPago.Focus();
                return;
            }


           
            /*
            IF MESSAGEBOX('Desea imprimir directamente ... ?', 0292, 'Aviso al usuario')=7
                mprt = 'Preview NoConsole'
            ELSE
                mprt = 'To Printer Prompt NoConsole'
            ENDIF
            */

            int option = 0;
            string sql = "";
            string rptName = "";
            string rptTable = "";
            string ntext = "Atenciones En" + (cmbConsultorio.SelectedIndex == -1 ? "" : " " + cmbConsultorio.SelectedText + ", ");
            ntext = ntext + " Consultorio " + cmbBus.SelectedText + ", Periodo " + cmbPerPago.SelectedText;
            ntext = ntext + "\t" + Operativo.id_oper + " - '" + Operativo.descripcion + "'";

            if (rbRecibos.Checked)
            {
                sql = this.sqlResultado + "Order By CB.Fecha_Atencion,T.Nro_Ticket,Pr.Descripcion";
                option = 1;
                rptName = "rptRepTerDet";
                rptTable = "RepTerDet";
            }

            if (rbProductos.Checked)
            {
                sql = "SELECT X.producto, SUM(X.cantidad) AS cantidad FROM (" + this.sqlResultado + ") X GROUP BY X.producto ORDER BY X.producto";
                option = 2;
                rptName = "rptRepTerRes";
                rptTable = "RepTerRes";
            }

            if (rbFechas.Checked)
            {
                sql = this.sqlResumen;
                option = 3;
                rptName = "rptRepTerResDia";
                rptTable = "RepTerResDia";
            }

            object result = Dominio.Helpers.WaitWindow.Show(this.WorkerMethodRPT, "Procesando el reporte...", new object[] { option, sql, rptName, rptTable, ntext });
            if (result == null)
            {
                MessageBox.Show("No se pudo procesar el reporte.");
                return;
            }

            //llama al formulario que muestra el reporte
            frmCRViewer frg = new frmCRViewer(rpt);
            frg.ShowDialog();

        }

        private void WorkerMethodRPT(object sender, WaitWindowEventArgs e)
        {
            int option = (int)e.Arguments[0];
            string sql = e.Arguments[1].ToString();
            string rptName = e.Arguments[2].ToString();
            string rptTable = e.Arguments[3].ToString();
            string nText = e.Arguments[4].ToString();

            //define la ruta por defecto de la app
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            //define el reporte dependiendo del tipo de seleccion
            path = path + "/Dominio/Reportes/" + rptName + ".rpt";

            //carga el reporte
            rpt.Load(path);

            Conexion.CMD.CommandText = sql;
            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (ReportsDS ds = new ReportsDS())
                {
                    ds.Clear();
                    da.Fill(ds, rptTable);
                    rpt.SetDataSource(ds);
                }
            }

            //setea los parametros del reporte Parte de atencion diario
            rpt.SetParameterValue("nText", nText);

            if (e.Arguments.Count > 0)
                e.Result = e.Arguments[0].ToString();
            else
                e.Result = "Proceso culminado.";
        }
    }
}
