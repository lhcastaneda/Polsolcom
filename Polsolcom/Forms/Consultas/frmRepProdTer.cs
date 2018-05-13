using CrystalDecisions.CrystalReports.Engine;
using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Data;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
	public partial class frmRepProdTer : Form
    {
        DataSet dt = new DataSet();
        ReportDocument rpt = new ReportDocument();
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

        private void frmRepProdTer_Load(object sender, EventArgs e)
        {
			tipoSubProductoTableAdapter.Fill(tablaTipoDS.TipoSubProducto);
            cmbTPEsp.SelectedIndex = -1;

			turnoTableAdapter.Fill(tablaTipoDS.Turno);
            cmbTurno.SelectedIndex = -1;

			periodoPagoTableAdapter.Fill(periodoPagoDS.PeriodoPago);
            cmbPerPago.SelectedIndex = -1;

			especialidadTableAdapter.Fill(consultoriosDS.Especialidad, Operativo.id_oper);
            cmbConsultorio.SelectedIndex = -1;

			busesByModeValueTableAdapter.Fill(busesDS.BusesByModeValue, "1", Operativo.id_oper.Trim());
            cmbBus.SelectedIndex = -1;

			especialistasTableAdapter.Fill(medicosDS.Especialistas);
            cmbCMP.SelectedIndex = -1;

			chkHabFecha.Checked = false;
		}
	
        private void grdListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(grdListado, false);

			if (i > -1)
            {
                string pg = pcon;
                string nh = lista[i]["Nro_Historia"];
                string sql = "Select P.Descripcion Producto,CONVERT(DECIMAL(10,2), D.Monto) As Precio, " +
							"D.Cantidad,CONVERT(DECIMAL(10,2),((D.Monto*D.Cantidad)-D.Dscto)) As Total " +
							"From Tickets T Inner Join Detalles D " +
							"On T.Nro_Historia=D.Nro_Historia Inner Join Productos P " +
							"On D.Id_Producto=P.Id_Producto " +
							"Where T.ForPago='' " +
							"And T.Anulado='' " +
							"And T.Nro_Historia='" + nh + "' " +
							"And D.Pagado Like '" + pg + "'";
				detalles = General.GetDictionaryList(sql);
                General.Fill(grdDetalle, detalles, new string[] { "Producto", "Precio", "Cantidad", "Total" });
                total.Text = detalles.Sum(x => decimal.Parse(x["Total"])).ToString("N");
            }
        }

        private void cmbConsultorio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbBus.SelectedIndex = -1;
            if (cmbConsultorio.SelectedIndex > -1)
            {
                string ic = cmbConsultorio.SelectedValue.ToString();
				busesByModeValueTableAdapter.Fill(busesDS.BusesByModeValue, "0", ic);
            }
            else
				busesByModeValueTableAdapter.Fill(busesDS.BusesByModeValue, "1", Operativo.id_oper);

            cmbBus.SelectedIndex = -1;
        }

        private void cmbBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                cmbBus.SelectedIndex = -1;
        }

        private void cmbCMP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                cmbCMP.SelectedIndex = -1;
        }

        private void cmbTPEsp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                cmbTPEsp.SelectedIndex = -1;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (dtpFecIni.Value == null || dtpFecFin.Value == null)
            {
                MessageBox.Show("Ingrese el rango de fechas a procesar ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cmbPerPago.Focus();
                return;
            }

            string cran = "(";
            foreach(int i in lstFechas.SelectedIndices)
                cran += "'" + DateTime.Parse(fechas[i]["Fecha"]).ToShortDateString() + "',";

            if (cran == "(")
            {
                MessageBox.Show("No hay fechas seleccionadas ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            cran = cran.Substring(0, cran.Length - 1) + ") ";
            grdListado.Items.Clear();
            grdDetalle.Items.Clear();
            grdResumen.Items.Clear();
            txtTickets.Text = txtCantidad.Text = "0";
            total.Text = txtTotal.Text = "0.00";
            cmbTurno.SelectedIndex = -1;

			string pg = pcon;

			sqlResultado = "SELECT CB.Fecha_Atencion,T.Serie,T.Nro_Ticket Ticket,P.Nombre,P.Ape_Paterno,P.Ape_Materno, " +
							"SubString(M.TNCol, 2, 7)CMP,C.Descripcion Consultorio, B.Bus,Pr.Descripcion Producto, " +
							"CONVERT(DECIMAL(10, 2), D.Monto) As Precio, D.Cantidad, CONVERT(DECIMAL(10, 2), " +
							"((D.Monto * D.Cantidad) - D.Dscto)) As Total, CB.Turno,CB.Nro_Historia " +
							"FROM Cab_Cie10 CB Inner Join Tickets T " +
							"On CB.Nro_Historia = T.Nro_Historia Inner Join Detalles D " +
							"On T.Nro_Historia = D.Nro_Historia Inner Join Buses B " +
							"On CB.Id_Bus = B.Id_Bus Inner Join Personal M " +
							"On CB.CMP = M.Id_Personal Inner Join Consultorios C " +
							"On T.Id_Consultorio = C.Id_Consultorio Inner Join Pacientes P " +
							"On P.Id_Paciente = T.Id_paciente Inner Join Productos Pr " +
							"On D.Id_Producto = Pr.Id_Producto " +
							"WHERE T.ForPago = '' " +
							"And T.Anulado = '' " +
							"And CB.Fecha_Atencion In " + cran + " " +
							"And D.Pagado Like '" + pg + "' ";

			if( cmbConsultorio.SelectedIndex != -1 )
				if ( cmbConsultorio.SelectedValue.ToString() != "*" )
					sqlResultado += "And C.Id_Consultorio = '" + cmbConsultorio.SelectedValue.ToString() + "' ";

			if( cmbBus.SelectedIndex != -1 )
				if( cmbBus.SelectedValue.ToString() != "*" )
					sqlResultado += "And CB.Id_Bus = '" + cmbBus.SelectedValue.ToString() + "' ";

			if( cmbCMP.SelectedIndex != -1 )
				if( cmbCMP.SelectedValue.ToString() != "*" )
					sqlResultado += "And CB.CMP = '" + cmbCMP.SelectedValue.ToString() + "' ";

			if( cmbTPEsp.SelectedIndex != -1 )
				if( cmbTPEsp.SelectedValue.ToString() != "*" )
						sqlResultado += "And Pr.TPEsp='" + cmbTPEsp.SelectedValue.ToString() + "' ";

			sqlLista = "SELECT CONVERT(VARCHAR,X.Fecha_Atencion,103) Fecha_Atencion, X.Serie, X.Ticket, X.CMP, X.Consultorio, " +
						"COUNT(X.Ticket) AS Nro, X.Bus, SUM(X.Total) AS Total, " +
						"X.Nro_Historia, X.Turno, SUM(X.Cantidad) AS Cantidad " +
						"FROM (" + sqlResultado + ") X " +
						"GROUP BY X.Fecha_Atencion, X.Consultorio, X.Bus, X.Serie, X.Ticket, X.CMP, X.Nro_Historia, X.Turno ";
			lista = General.GetDictionaryList(sqlLista + "ORDER BY X.Fecha_Atencion, X.Consultorio, X.Bus, X.CMP, X.Nro_Historia");
            if ( lista.Count > 0)
            {
                General.Fill(grdListado, lista, new string[] {"Fecha_Atencion", "Serie", "Ticket", "CMP", "Consultorio", "Nro", "Bus", "Total" });
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
                MessageBox.Show("Consulta no genero ningun resultado ... verifique los criterios ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                btnExportar.Enabled = btnMarcar.Enabled = btnImprimir.Enabled = false;
                return;
            }

			cmbTurno.Enabled = true;
			sqlResumen = "SELECT CONVERT(VARCHAR,X.Fecha_Atencion,103) AS Fecha, COUNT(X.Ticket) AS NTickets, " +
						"SUM(X.Cantidad) AS NCant, SUM(X.Total) AS NTotal, X.Turno " +
						"FROM (" + sqlLista + ") X " +
						"GROUP BY X.Fecha_Atencion, X.Turno " +
						"ORDER BY X.Fecha_Atencion";
			resumen = General.GetDictionaryList(sqlResumen);

            txtTickets.Text = resumen.Sum(x => int.Parse(x["NTickets"])).ToString();
            txtCantidad.Text = resumen.Sum(x => int.Parse(x["NCant"])).ToString();
            txtTotal.Text = resumen.Sum(x => decimal.Parse(x["NTotal"])).ToString("N");
            General.Fill(grdResumen, resumen, new string[] { "Fecha", "NTickets", "NCant", "NTotal" });
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dtpFecIni.Value == null || dtpFecFin.Value == null)
            {
                MessageBox.Show("Debe de ingresar el rango de fechas a procesar ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cmbPerPago.Focus();
                return;
            }
            else
            {
                if (grdListado.Items.Count > 0)
                {
                    frmExport frmExport = new frmExport(sqlResultado + "Order By CB.Fecha_Atencion,T.Nro_Ticket,Pr.Descripcion", Text, "Terceros_" + Operativo.descripcion + "_" + DateTime.Now.ToString("yyyyMMddHHmmss"));
                    frmExport.ShowDialog(this);
                }
                else
                    MessageBox.Show("No hay datos para exportar\ndebe realizar otra consulta", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (cmbPerPago.SelectedIndex == -1)
            {
                MessageBox.Show("No hay periodo de pago seleccionado ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (MessageBox.Show("Esta seguro de marcar como pagado segun el periodo seleccionado ... ?", "Aviso al usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (grdListado.Items.Count > 0)
                {
                    string sqlFechas = "SELECT X.Fecha_Atencion AS Fecha FROM (" + sqlLista + ") X GROUP BY X.Fecha_Atencion ORDER BY 1";
                    List<Dictionary<string, string>> fechas = General.GetDictionaryList(sqlFechas);

                    string cr = "";
                    foreach (Dictionary<string, string> fecha in fechas)
                        cr += "'" + DateTime.Parse(fecha["Fecha"]).ToShortDateString() + "',";

					cr = cr.Substring(0, cr.Length - 1);
					string ic = "";
					string ib = "";
					string cm = "";
					string te = "";
					string pp = cmbPerPago.SelectedIndex == -1 ? "" : cmbPerPago.SelectedValue.ToString();
					
					if( cmbConsultorio.SelectedIndex != -1 )
						if( cmbConsultorio.SelectedValue.ToString() != "*" )
							ic= cmbConsultorio.SelectedValue.ToString();

					if( cmbBus.SelectedIndex != -1 )
						if( cmbBus.SelectedValue.ToString() != "*" )
							ib = cmbBus.SelectedValue.ToString();

					if( cmbCMP.SelectedIndex != -1 )
						if( cmbCMP.SelectedValue.ToString() != "*" )
							cm= cmbCMP.SelectedValue.ToString();

					if( cmbTPEsp.SelectedIndex != -1 )
						if( cmbTPEsp.SelectedValue.ToString() != "*" )
							te= cmbTPEsp.SelectedValue.ToString();

                    string sql = "Update Cab_Cie10 Set Id_Per='" + pp + "' " +
								"From Cab_Cie10 CB Inner Join Tickets T " +
								"On CB.Nro_Historia=T.Nro_Historia " +
								"Inner Join Detalles D  " +
								"On T.Nro_Historia=D.Nro_Historia Inner Join Productos P " +
								"On P.Id_Producto=D.Id_Producto Inner Join Consultorios C " +
								"On C.Id_Consultorio=T.Id_Consultorio " +
								"Where T.ForPago='' " +
								"And T.Anulado='' " +
								"And CB.Fecha_Atencion In (" + cr + ") " +
								"And D.Pagado='R' " +
								"And P.TPEsp Like '" + te + "'+'%' " +
								"And CB.CMP Like '" + cm + "'+'%' " +
								"And C.Id_Consultorio Like '" + ic + "'+'%' " +
								"And CB.Id_Bus Like '" + ib + "'";
                    Conexion.ExecuteNonQuery(sql);

                    string sql2 = "Update Detalles Set Pagado='P' " +
								"From Cab_Cie10 CB Inner Join Tickets T " +
								"On CB.Nro_Historia=T.Nro_Historia " +
								"Inner Join Detalles D " +
								"On T.Nro_Historia=D.Nro_Historia Inner Join Productos P " +
								"On P.Id_Producto=D.Id_Producto Inner Join Consultorios C " +
								"On C.Id_Consultorio=T.Id_Consultorio " +
								"Where T.ForPago='' " +
								"And T.Anulado='' " +
								"And CB.Fecha_Atencion In (" + cr + ") " +
								"And D.Pagado='R' " +
								"And P.TPEsp Like '" + te + "%' " +
								"And CB.CMP Like '" + cm + "%' " +
								"And C.Id_Consultorio Like '" + ic + "%' " +
								"And CB.Id_Bus Like '" + ib + "'";
                    Conexion.ExecuteNonQuery(sql2);

                    MessageBox.Show("Actualización culminada con éxito ... registros fueron marcados como pagados ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    btnMarcar.Enabled = false;
                }
                else
                    MessageBox.Show("No hay datos para marca de pagado ...\n\nDebe realizar otra consulta ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.Cancel;
			Close();
        }

        private void cmbPerPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                cmbPerPago.SelectedIndex = -1;
        }

        private void chkHabFecha_CheckedChanged(object sender, EventArgs e)
        {
			cmbPerPago.SelectedIndex = -1;
			lstFechas.Items.Clear();
			if( chkHabFecha.Checked == true )
			{
				dtpFecIni.Value = DateTime.Now;
				dtpFecFin.Value = DateTime.Now;
				grdFechas.Enabled = true;
				cmbPerPago.Enabled = false;
				grdListado.Items.Clear();
				grdDetalle.Items.Clear();
				grdResumen.Items.Clear();
				txtTickets.Text = txtCantidad.Text = "0";
				total.Text = txtTotal.Text = "0.00";
				cmbTurno.SelectedIndex = -1;
				cmbTurno.Enabled = false;
				btnExportar.Enabled = btnMarcar.Enabled = btnImprimir.Enabled = false;
			}
			else
			{
				grdFechas.Enabled = false;
				cmbPerPago.Enabled = true;
			}
        }

        private void frmRepProdTer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnSalir_Click(btnSalir, new EventArgs());
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dtpFecIni.Value == null && dtpFecFin.Value == null)
            {
                MessageBox.Show("Debe ingresar el rango de fechas a consultar ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cmbPerPago.Focus();
                return;
            }

            int option = 0;
            string sql = "";
            string rptName = "";
            string rptTable = "";
            string ntext = "Atenciones En" + (cmbConsultorio.SelectedIndex == -1 ? "" : " " + cmbConsultorio.SelectedText + ", ");
            ntext = ntext + " Consultorio " + cmbBus.SelectedText + ", Periodo " + cmbPerPago.SelectedText;
            ntext = ntext + "\t" + Operativo.id_oper + " - '" + Operativo.descripcion + "'";

            if (rbRecibos.Checked)
            {
                sql = sqlResultado + "Order By CB.Fecha_Atencion,T.Nro_Ticket,Pr.Descripcion";
                option = 1;
                rptName = "rptRepTerDet";
                rptTable = "RepTerDet";
            }

            if (rbProductos.Checked)
            {
                sql = "SELECT X.producto, SUM(X.cantidad) AS cantidad FROM (" + sqlResultado + ") X GROUP BY X.producto ORDER BY X.producto";
                option = 2;
                rptName = "rptRepTerRes";
                rptTable = "RepTerRes";
            }

            if (rbFechas.Checked)
            {
                sql = sqlResumen;
                option = 3;
                rptName = "rptRepTerResDia";
                rptTable = "RepTerResDia";
            }

            object result = WaitWindow.Show(WorkerMethodRPT, "Procesando el reporte...", new object[] { option, sql, rptName, rptTable, ntext });
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

		private void cmbConsultorio_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbConsultorio.SelectedIndex != -1)
				cmbConsultorio_SelectionChangeCommitted(cmbConsultorio, new EventArgs());
		}

		private void cmbPerPago_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbPerPago.SelectedIndex == -1 )
				return;

			grdListado.Items.Clear();
			grdDetalle.Items.Clear();
			grdResumen.Items.Clear();
			txtTickets.Text = txtCantidad.Text = "0";
			total.Text = txtTotal.Text = "0.00";
			cmbTurno.SelectedIndex = -1;
			cmbTurno.Enabled = false;
			btnExportar.Enabled = btnMarcar.Enabled = btnImprimir.Enabled = false;

			Dictionary<string, string> perPag = General.GetSelectedDictionary(cmbPerPago);
			dtpFecIni.Value = DateTime.Parse(perPag["Date_Ini"]);
			dtpFecFin.Value = DateTime.Parse(perPag["Date_End"]);
			//dtpFecFin_ValueChanged(dtpFecFin, new EventArgs());
			
		}

		private void rbProcesados_CheckedChanged( object sender, EventArgs e )
		{
			if( rbProcesados.Checked )
				pcon = "R";
		}

		private void rbPagados_CheckedChanged( object sender, EventArgs e )
		{
			if( rbPagados.Checked )
				pcon = "P";
		}

		private void rbNoProcesados_CheckedChanged( object sender, EventArgs e )
		{
			if( rbNoProcesados.Checked )
				pcon = "";
		}

		private void rbTodos_CheckedChanged( object sender, EventArgs e )
		{
			if( rbTodos.Checked )
				pcon = "%";
		}

		private void dtpFecFin_ValueChanged( object sender, EventArgs e )
		{
			if( dtpFecFin.Value.CompareTo(dtpFecIni.Value) < 0 )
			{
				MessageBox.Show("Rango incorrecto", "Aviso");
				dtpFecFin.ResetText();
				dtpFecFin.Focus();
				return;
			}

			string fi = dtpFecIni.Value.ToShortDateString();
			string ff = dtpFecFin.Value.ToShortDateString();
			string pg = pcon;

			string sql = "SELECT DISTINCT CONVERT(varchar,  Fecha_Atencion, 103) Fecha " +
						 "FROM Cab_Cie10 C Inner Join Detalles D On C.Nro_Historia=D.Nro_Historia " +
						 "WHERE Fecha_Atencion Between '" + fi + "' And '" + ff + "' And Pagado";
			sql += (pg == "%" ? " Like '" + pg + "' " : "='" + pg + "' ");
			sql += "Group By Fecha_Atencion Order By 1";

			fechas = General.GetDictionaryList(sql);
			General.Fill(lstFechas, fechas, new string[] { "Fecha" });

			for( int i = 0; i < lstFechas.Items.Count; i++ )
			{
				lstFechas.Select();
				lstFechas.EnsureVisible(i);
				lstFechas.Items[i].Selected = true;
				lstFechas.Items[i].Focused = true;
				lstFechas.Items[i].EnsureVisible();
			}
		}

		private void dtpFecIni_ValueChanged( object sender, EventArgs e )
		{
			dtpFecFin.Value = DateTime.Now;
			DateTime date = dtpFecIni.Value;
			var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
			var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
			dtpFecFin.Value = lastDayOfMonth;
		}

		private void cmbTurno_SelectionChangeCommitted( object sender, EventArgs e )
		{
			string xturn = "";
			List<Dictionary<string, string>> list = null;

			if( cmbTurno.SelectedIndex == -1 )
				xturn = "";
			else if( cmbTurno.SelectedValue.ToString() == "*" )
				xturn = "";
			else
				xturn = cmbTurno.SelectedValue.ToString();

			if( xturn == "" || xturn == "*" )
				list = resumen;
			else
				list = resumen.FindAll(x => x["Turno"] == xturn);

			General.Fill(grdResumen, list, new string[] { "Fecha", "NTickets", "NCant", "NTotal" });
			txtTickets.Text = list.Sum(x => int.Parse(x["NTickets"])).ToString();
			txtCantidad.Text = list.Sum(x => int.Parse(x["NCant"])).ToString();
			txtTotal.Text = list.Sum(x => decimal.Parse(x["NTotal"])).ToString("N");
		}
	}
}
