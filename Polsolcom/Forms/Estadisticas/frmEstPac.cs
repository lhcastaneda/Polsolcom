using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using Polsolcom.Dominio.Data;

namespace Polsolcom.Forms
{

    public partial class frmEstPac : Form
    {
        //define variable para SQL
        string vSQL = "";
        DataSet dt = new DataSet();
        Chart chartFinal = new Chart();
        ReportDocument rpt = new ReportDocument();

        public frmEstPac()
        {
            InitializeComponent();
        }

        public void FormateaGrilla()
        {
            fGrid.RowHeader.Visible = false;
            //fGrid.Footer.Visible = true;
            //No sé que fuente ponerle :/
            //fGrid.Footer.Font = new Font("Verdana", 12, FontStyle.Bold);
            //
            fGrid.DefaultRow.Height = 20;
            fGrid.Cols.Count = 6;
            fGrid.Cols[0].Text = "Año";
            fGrid.Cols[0].Width = 80;
            fGrid.Cols[0].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[0].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
            fGrid.Cols[0].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[1].Text = "Mes";
            fGrid.Cols[1].Width = 100;
            fGrid.Cols[1].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
            fGrid.Cols[1].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[2].Text = "Fecha";
            fGrid.Cols[2].Width = 90;
            fGrid.Cols[2].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[3].Text = "Nueva";
            fGrid.Cols[3].Width = 80;
            fGrid.Cols[3].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;
            //fGrid.Footer.Cells[0, 3].AggregateFunction = iGAggregateFunction.Sum;
            //
            fGrid.Cols[4].Text = "Antiguos";
            fGrid.Cols[4].Width = 80;
            fGrid.Cols[4].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[4].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[4].CellStyle.ReadOnly = iGBool.True;
            //fGrid.Footer.Cells[0, 4].AggregateFunction = iGAggregateFunction.Sum;
            //
            fGrid.Cols[5].Text = "Total";
            fGrid.Cols[5].Width = 80;
            fGrid.Cols[5].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[5].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[5].CellStyle.ReadOnly = iGBool.True;
            //fGrid.Footer.Cells[0, 5].AggregateFunction = iGAggregateFunction.Sum;
            //

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void WorkerMethod(object sender, WaitWindowEventArgs e)
        {
            try
            {
                if (dtpInicio.Text == "")
                {
                    MessageBox.Show("Debe seleccionar una fecha de inicio.", "Estadistica - Pacientes Nuevos y Continuadores", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

                if (dtpFinal.Text == "")
                {
                    MessageBox.Show("Debe seleccionar una fecha final.", "Estadistica - Pacientes Nuevos y Continuadores", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

                Conexion.CMD.CommandText = getSQL() + " ORDER BY 3";
                //Conexion.AddParameter("desde", "23/05/2009");
                //Conexion.AddParameter("hasta", "25/05/2009");
                //Conexion.AddParameter("group", "año, mes, fecha");
                using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
                {
                    dt.Clear();
                    da.Fill(dt);
                    da.Dispose();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (e.Arguments.Count > 0)
                e.Result = e.Arguments[0].ToString();
            else
                e.Result = "Proceso culminado.";
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

        private void frmEstPac_Load(object sender, EventArgs e)
        {
            lblCantidad.Text = "";
            dtpInicio.Value = DateTime.Now;
            dtpFinal.Value = DateTime.Now;
            FormateaGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object result = Dominio.Helpers.WaitWindow.Show(this.WorkerMethod, "Procesando la consulta...");
            if (result == null)
            {
                MessageBox.Show("No se pudo procesar la consulta.");
                return;
            }

            //llena la grilla con los datos
            fGrid.Rows.Clear();
            IDataReader dr = dt.CreateDataReader();
            fGrid.FillWithData(dr);
            dr.Close();
            FormateaGrilla();

            int tNew = 0;
            int tOld = 0;
            int tTot = 0;

            for (int i = 0; i <= fGrid.Rows.Count - 1; i++)
            {
                tNew = tNew + Convert.ToInt32(fGrid.Cells[i, 3].Value);
                tOld = tOld + Convert.ToInt32(fGrid.Cells[i, 4].Value);
                tTot = tTot + Convert.ToInt32(fGrid.Cells[i, 5].Value);

            }

            txtTNew.Text = tNew.ToString();
            txtTOld.Text = tOld.ToString();
            txtTTot.Text = tTot.ToString();

            //Cantidad de filas
            lblCantidad.Text = fGrid.Rows.Count.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerGraf_Click(object sender, EventArgs e)
        {
            bool bEncontrado = false;

            //valida que alguna opcion del tipo de grafico debe estar seleccionado
            foreach (Control cntrl in grpTipoGraph.Controls)
            {
                RadioButton rb = (RadioButton)cntrl;
                if (rb.Checked)
                {
                    bEncontrado = true;
                    break;
                }
            }

            if (bEncontrado == false)
            {
                MessageBox.Show("Debe seleccionar un tipo de grafico.", "Estadistica - Pacientes Nuevos y Continuadores", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            //valida que alguna opcion de agrupacion este seleccionado
            bEncontrado = false;
            foreach (Control cntrl in grpGender.Controls)
            {
                RadioButton rb = (RadioButton)cntrl;
                if (rb.Checked)
                {
                    bEncontrado = true;
                    break;
                }
            }

            if (bEncontrado == false)
            {
                MessageBox.Show("Debe seleccionar un tipo de agrupacion.", "Estadistica - Pacientes Nuevos y Continuadores", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            //define el tipo de grafico a usar
            if (optColumnas.Checked == true)
                Grafico.TipoChart = "Column";
            else if (optBarras.Checked == true)
                Grafico.TipoChart = "Bar";
            else if (optAreas.Checked == true)
                Grafico.TipoChart = "Area";
            else if (optLineas.Checked == true)
                Grafico.TipoChart = "Line";
            else if (optCircular.Checked == true)
                Grafico.TipoChart = "Pie";

            string gSQL = "";

            if (optAnho.Checked == true)
            {   //agrupa los datos por sexo
                gSQL = "SELECT SUM(X.PNew) AS new, SUM(X.POld) AS old, SUM(X.PTot) AS total, STR(X.Año) AS campo" +
                       " FROM (" + vSQL + ") X" +
                       " GROUP BY X.Año";
            }
            else
            {   //agrupa los datos por etareo
                gSQL = "SELECT SUM(X.PNew) AS new, SUM(X.POld) AS old, SUM(X.PTot) AS total, CONVERT(varchar(10), X.Fecha, 103) AS campo" +
                       " FROM (" + vSQL + ") X" +
                       " GROUP BY X.Fecha";
            }

            //define los valores que se enviara al formulario que grafica
            Grafico.series = new List<Serie>();
            Grafico.series.Add(new Serie("Nuevos", Color.Orange));
            Grafico.series.Add(new Serie("Antiguos", Color.Yellow));
            Grafico.series.Add(new Serie("Total", Color.Green));

            Grafico.sSQL = gSQL;
            Grafico.TituloChart = "Grafico Estadistico del " + dtpInicio.Text.Substring(0, 10) + " al " + dtpFinal.Text.Substring(0, 10) + ((optAnho.Checked == true) ? " Por Año" : " Por Fecha");
            Grafico.TituloX = ((optAnho.Checked == true) ? "Año" : "Fecha");
            Grafico.LeyendaX = "Agrupacion por Distribucion";
            Grafico.TituloY = "Cantidad";
            Grafico.LeyendaY = "En Unidades";
            Grafico.Decimal = false;

           //crea el formulario del grafico
           frmGrafico frg = new frmGrafico();
            frg.CargaChart();
            frg.Text = "Grafico Estadistico " + ((optAnho.Checked == true) ? "Año" : "Fecha");
            frg.ShowDialog();
        }

        string getSQL()
        {
            vSQL = "";
            vSQL += "SELECT Año as Año, ";
            vSQL += "Mes, ";
            vSQL += "Fecha, ";
            vSQL += "SUM(PNew) AS PNew, ";
            vSQL += "SUM(PTot-PNew) AS POld, ";
            vSQL += "SUM(PTot) AS PTot ";
            vSQL += "FROM ";
            vSQL += "(SELECT Año, ";
            vSQL += "Mes, ";
            vSQL += "Fecha, ";
            vSQL += "CASE ";
            vSQL += "WHEN Tipo='T' THEN SUM(Cant) ";
            vSQL += "ELSE 0 ";
            vSQL += "END AS PTot, ";
            vSQL += "CASE ";
            vSQL += "WHEN Tipo='N' THEN SUM(Cant) ";
            vSQL += "ELSE 0 ";
            vSQL += "END AS PNew ";
            vSQL += "FROM ";
            vSQL += "(SELECT DATEPART(YEAR,x.fecha) AS Año, ";
            vSQL += "DATENAME(MONTH,x.fecha) AS Mes, ";
            vSQL += "CAST(CONVERT(Datetime,CONVERT(varchar(10),x.fecha,103), 103) AS datetime) AS Fecha, ";
            vSQL += "COUNT(x.id_paciente) AS Cant, ";
            vSQL += "'N' AS Tipo ";
            vSQL += "FROM ";
            vSQL += "(SELECT Id_Paciente, ";
            vSQL += "MIN(fecha_emision) AS Fecha ";
            vSQL += "FROM tickets ";
            vSQL += "GROUP BY Id_Paciente) AS x ";
            vSQL += "GROUP BY DATEPART(YEAR,x.fecha), ";
            vSQL += "DATENAME(MONTH,x.fecha), ";
            vSQL += "CAST(CONVERT(Datetime,CONVERT(varchar(10),x.fecha,103), 103) AS datetime) ";
            vSQL += "UNION SELECT DATEPART(YEAR,x.fecha) AS Año, ";
            vSQL += "DATENAME(MONTH,x.fecha) AS Mes, ";
            vSQL += "Fecha, ";
            vSQL += "COUNT(x.id_paciente) AS Cant, ";
            vSQL += "'T' AS Tipo ";
            vSQL += "FROM ";
            vSQL += "(SELECT Id_Paciente, ";
            vSQL += "CAST(CONVERT(Datetime,CONVERT(varchar(10),fecha_emision,103), 103) AS datetime) AS Fecha ";
            vSQL += "FROM tickets ";
            vSQL += "GROUP BY Id_Paciente, ";
            vSQL += "CAST(CONVERT(Datetime,CONVERT(varchar(10),fecha_emision,103), 103) AS datetime)) AS x ";
            vSQL += "GROUP BY DATEPART(YEAR,x.fecha), ";
            vSQL += "DATENAME(MONTH,x.fecha), ";
            vSQL += "x.Fecha) y ";
            vSQL += "GROUP BY año, ";
            vSQL += "mes, ";
            vSQL += "fecha, ";
            vSQL += "tipo) z ";
            //vSQL += "WHERE fecha >= '" + String.Format("{0:yyyy-MM-dd}", dtpInicio.Value) + "' ";
            //vSQL += "AND fecha <= '" + String.Format("{0:yyyy-MM-dd}", dtpFinal.Value) + "' ";
            vSQL += "WHERE fecha >= '" + String.Format("{0:dd/MM/yyyy}", dtpInicio.Value) + "' ";
            vSQL += "AND fecha <= '" + String.Format("{0:dd/MM/yyyy}", dtpFinal.Value) + "' ";
            vSQL += "GROUP BY Año, Mes, Fecha ";

            //MessageBox.Show(vSQL);

            return vSQL;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //genera reporte y carga los datos
            object result = WaitWindow.Show(WorkerMethodRPT, "Generando el reporte...");
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
            //define la ruta por defecto de la app
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            //define el reporte dependiendo del tipo de seleccion
            path = path + "/Dominio/Reportes/rptEstPac2.rpt";

            //carga el reporte
            rpt.Load(path);

            Conexion.CMD.CommandText = getSQL();
            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (ReportsDS ds = new ReportsDS())
                {
                    ds.Clear();
                    da.Fill(ds, "EstPac");
                    rpt.SetDataSource(ds);
                }
            }

            //setea los parametros del reporte Parte de atencion diario
            rpt.SetParameterValue("TituloReporte", "Estadistica - Pacientes Nuevos y Continuadores");

            if (e.Arguments.Count > 0)
                e.Result = e.Arguments[0].ToString();
            else
                e.Result = "Proceso culminado.";

        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpFinal.Text = dtpInicio.Text;
        }

        private void frmEstPac_KeyDown(object sender, KeyEventArgs e)
        {
            //cierra el formulario cuando se presiona la tecla ESC
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}



