using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Data;
using Polsolcom.Dominio.Helpers;
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
using TenTec.Windows.iGridLib;

namespace Polsolcom.Forms
{
    public partial class frmEstVent : Form
    {
        DataSet dt = new DataSet();
        DataTable dtg = new DataTable();
        ListSelectionWrapper<DataRow> listaOperativos;
        ListSelectionWrapper<DataRow> listaEspecialidades;
        ListSelectionWrapper<DataRow> listaMeses;

        public frmEstVent()
        {
            InitializeComponent();
        }

        private int getMod()
        {
            if (rbFechas.Checked)
                return 1;
            if (rbMeses.Checked)
                return 2;
            if (rbAños.Checked)
                return 3;
            if (rbEspecialidad.Checked)
                return 4;
            return 0;
        }

        private void LlenarOperativos()
        {
            DataTable dataTable = Conexion.GetTable("select Id_Oper as Id, Descripcion as SomePropertyOrColumnName from Operativo");

            listaOperativos = new ListSelectionWrapper<DataRow>(
                dataTable.Rows,
                "SomePropertyOrColumnName",
                "(Seleccione operativos)"
                );

            cmbOperativo.DataSource = listaOperativos;
            cmbOperativo.DisplayMemberSingleItem = "Name";
            cmbOperativo.DisplayMember = "Various";
            cmbOperativo.ValueMember = "Selected";
        }

        private void LlenarMeses()
        {
            DataTable DT = new DataTable("MESES");
            DT.Columns.AddRange(
            new DataColumn[]
                {
        new DataColumn("Id", typeof(int)),
        new DataColumn("SomePropertyOrColumnName", typeof(string)),
                });


            string[] meses = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            for (int i = 0; i < meses.Length; i++)
            {
                if (meses[i].Length > 0)
                {
                    DT.Rows.Add(i + 1, meses[i].ToUpper());
                }
            }

            listaMeses = new ListSelectionWrapper<DataRow>(
                DT.Rows,
                // "SomePropertyOrColumnName" will populate the Name 
                // on ObjectSelectionWrapper.
                "SomePropertyOrColumnName",
                "(Seleccione meses)"
                );

            cmbMeses.DataSource = listaMeses;
            cmbMeses.DisplayMemberSingleItem = "Name";
            cmbMeses.DisplayMember = "Various";
            cmbMeses.ValueMember = "Selected";
        }

        private void LlenarEspecialidades()
        {
            DataTable dataTable = Conexion.GetTable("select Id_Consultorio as Id, Descripcion as SomePropertyOrColumnName from Consultorios where Estado = 1");

            listaEspecialidades = new ListSelectionWrapper<DataRow>(
                dataTable.Rows,
                "SomePropertyOrColumnName",
                "(Seleccione especialidades)"
                );

            cmbEspecialidad.DataSource = listaEspecialidades;
            cmbEspecialidad.DisplayMemberSingleItem = "Name";
            cmbEspecialidad.DisplayMember = "Various";
            cmbEspecialidad.ValueMember = "Selected";
        }

        private string BorrarTablaTemporal(bool execute = true)
        {
            string vSQL = "IF OBJECT_ID('tempdb.dbo.#tmpEstVent', 'U') IS NOT NULL DROP TABLE #tmpEstVent;";

            if (execute)
            {
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
            }

            return vSQL;
        }

        private string GenerarTabla(int mod, List<string> arrayEspecialidades, List<string> arrayMeses, bool execute = true)
        {
            string bSQL = BorrarTablaTemporal(execute);

            string vSQL = "";
            //agrupa los datos para mostrarlos en la grilla
            switch (mod)
            {
                case 1:
                    vSQL = "CREATE TABLE #tmpEstVent(Consultorio varchar(50), Tickets int, Cantidad int, Total decimal(10,2), Fecha DateTime, TCons varchar(25), Operativo varchar(20), Mes varchar(10), Año int);" +
                        "INSERT INTO #tmpEstVent EXEC TotCons @fini = '" + String.Format("{0:dd/MM/yyyy}", dtpicFInicial.Value) + "', @ffin = '" + String.Format("{0:dd/MM/yyyy}", dtpicFFinal.Value) + "', @idc = '" + String.Join(",", arrayEspecialidades.ToArray()) + "', @mod = " + mod.ToString() + ";";
                    break;
                case 2:
                    vSQL = "CREATE TABLE #tmpEstVent(Consultorio varchar(50), Tickets int, Cantidad int, Total decimal(10,2), TCons varchar(25), Operativo varchar(20), Mes varchar(10), NMes int, Año int);" +
                        "INSERT INTO #tmpEstVent EXEC TotCons @fini = '" + String.Format("{0:dd/MM/yyyy}", dtpicFInicial.Value) + "', @ffin = '" + String.Format("{0:dd/MM/yyyy}", dtpicFFinal.Value) + "', @idc = '" + String.Join(",", arrayEspecialidades.ToArray()) + "', @mod = " + mod.ToString() + ";" ;
                    break;
                case 3:
                    vSQL = "CREATE TABLE #tmpEstVent(Consultorio varchar(50), Tickets int, Cantidad int, Total decimal(10,2), TCons varchar(25), Operativo varchar(20), Año int);" +
                        "INSERT INTO #tmpEstVent EXEC TotCons @fini = '" + String.Format("{0:dd/MM/yyyy}", dtpicFInicial.Value) + "', @ffin = '" + String.Format("{0:dd/MM/yyyy}", dtpicFFinal.Value) + "', @idc = '" + String.Join(",", arrayEspecialidades.ToArray()) + "', @mod = " + mod.ToString() + ";";
                    break;
                case 4:
                    vSQL = "CREATE TABLE #tmpEstVent(Consultorio varchar(50), Tickets int, Cantidad int, Total decimal(10,2), TCons varchar(25), Operativo varchar(20));" +
                        "INSERT INTO #tmpEstVent EXEC TotCons @fini = '" + String.Format("{0:dd/MM/yyyy}", dtpicFInicial.Value) + "', @ffin = '" + String.Format("{0:dd/MM/yyyy}", dtpicFFinal.Value) + "', @idc = '" + String.Join(",", arrayEspecialidades.ToArray()) + "', @mod = " + mod.ToString() + ";";
                    break;
            }

            if (execute)
            {
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
            }

            return bSQL + vSQL;
        }

        public void FormateaGrilla()
        {
            int mod = getMod();

            fGrid.Cols.Clear();
            fGrid.RowHeader.Visible = false;
            fGrid.DefaultRow.Height = 20;

            switch (mod)
            {
                case 1:
                    //fGrid.Footer.Visible = true;
                    //No sé que fuente ponerle :/
                    //fGrid.Footer.Font = new Font("Verdana", 12, FontStyle.Bold);
                    //
                    fGrid.Cols.Count = 4;
                    //
                    fGrid.Cols[0].Text = "Fecha";
                    fGrid.Cols[0].Width = 230;
                    fGrid.Cols[0].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[0].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
                    fGrid.Cols[0].CellStyle.ReadOnly = iGBool.True;
                    //
                    fGrid.Cols[1].Text = "Tickets";
                    fGrid.Cols[1].Width = 90;
                    fGrid.Cols[1].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[1].CellStyle.ReadOnly = iGBool.True;
                    //
                    fGrid.Cols[2].Text = "Cantidad";
                    fGrid.Cols[2].Width = 90;
                    fGrid.Cols[2].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;
                    //fGrid.Footer.Cells[0, 5].AggregateFunction = iGAggregateFunction.Sum;
                    //
                    fGrid.Cols[3].Text = "Total";
                    fGrid.Cols[3].Width = 90;
                    fGrid.Cols[3].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;
                    //fGrid.Footer.Cells[0, 5].AggregateFunction = iGAggregateFunction.Sum;
                    break;
                case 2:
                    //fGrid.Footer.Visible = true;
                    //No sé que fuente ponerle :/
                    //fGrid.Footer.Font = new Font("Verdana", 12, FontStyle.Bold);
                    //
                    fGrid.Cols.Count = 5;
                    //
                    fGrid.Cols[0].Text = "Año";
                    fGrid.Cols[0].Width = 95;
                    fGrid.Cols[0].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[0].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
                    fGrid.Cols[0].CellStyle.ReadOnly = iGBool.True;
                    //
                    fGrid.Cols[1].Text = "Mes";
                    fGrid.Cols[1].Width = 95;
                    fGrid.Cols[1].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
                    fGrid.Cols[1].CellStyle.ReadOnly = iGBool.True;
                    //
                    fGrid.Cols[2].Text = "Tickets";
                    fGrid.Cols[2].Width = 90;
                    fGrid.Cols[2].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;
                    //
                    fGrid.Cols[3].Text = "Cantidad";
                    fGrid.Cols[3].Width = 90;
                    fGrid.Cols[3].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;
                    //fGrid.Footer.Cells[0, 5].AggregateFunction = iGAggregateFunction.Sum;
                    //
                    fGrid.Cols[4].Text = "Total";
                    fGrid.Cols[4].Width = 90;
                    fGrid.Cols[4].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[4].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[4].CellStyle.ReadOnly = iGBool.True;
                    //fGrid.Footer.Cells[0, 5].AggregateFunction = iGAggregateFunction.Sum;
                    break;
                case 3:
                    //fGrid.Footer.Visible = true;
                    //No sé que fuente ponerle :/
                    //fGrid.Footer.Font = new Font("Verdana", 12, FontStyle.Bold);
                    //
                    fGrid.Cols.Count = 4;
                    //
                    fGrid.Cols[0].Text = "Año";
                    fGrid.Cols[0].Width = 95;
                    fGrid.Cols[0].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[0].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
                    fGrid.Cols[0].CellStyle.ReadOnly = iGBool.True;
                    //
                    fGrid.Cols[1].Text = "Tickets";
                    fGrid.Cols[1].Width = 90;
                    fGrid.Cols[1].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[1].CellStyle.ReadOnly = iGBool.True;
                    //
                    fGrid.Cols[2].Text = "Cantidad";
                    fGrid.Cols[2].Width = 90;
                    fGrid.Cols[2].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;
                    //fGrid.Footer.Cells[0, 5].AggregateFunction = iGAggregateFunction.Sum;
                    //
                    fGrid.Cols[3].Text = "Total";
                    fGrid.Cols[3].Width = 90;
                    fGrid.Cols[3].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;
                    //fGrid.Footer.Cells[0, 5].AggregateFunction = iGAggregateFunction.Sum;
                    break;
                case 4:
                    //fGrid.Footer.Visible = true;
                    //No sé que fuente ponerle :/
                    //fGrid.Footer.Font = new Font("Verdana", 12, FontStyle.Bold);
                    //
                    fGrid.Cols.Count = 4;
                    //
                    fGrid.Cols[0].Text = "Consultorio";
                    fGrid.Cols[0].Width = 230;
                    fGrid.Cols[0].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[0].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
                    fGrid.Cols[0].CellStyle.ReadOnly = iGBool.True;
                    //
                    fGrid.Cols[1].Text = "Tickets";
                    fGrid.Cols[1].Width = 90;
                    fGrid.Cols[1].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[1].CellStyle.ReadOnly = iGBool.True;
                    //
                    fGrid.Cols[2].Text = "Cantidad";
                    fGrid.Cols[2].Width = 90;
                    fGrid.Cols[2].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;
                    //fGrid.Footer.Cells[0, 5].AggregateFunction = iGAggregateFunction.Sum;
                    //
                    fGrid.Cols[3].Text = "Total";
                    fGrid.Cols[3].Width = 90;
                    fGrid.Cols[3].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
                    fGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
                    fGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;
                    //fGrid.Footer.Cells[0, 5].AggregateFunction = iGAggregateFunction.Sum;
                    break;
            }
        }

        private List<string> getSelected(ListSelectionWrapper<DataRow> lista)
        {
            //Lista de operativos
            List<string> array = new List<string>();

            foreach (ObjectSelectionWrapper<DataRow> objectSelectionWrapper in lista)
            {
                if (objectSelectionWrapper.Selected)
                {
                    array.Add(objectSelectionWrapper.Item.Field<Object>("Id").ToString());
                }
            }

            return array;
        }

        private string getSQL(int mod, List<string> arrayMeses)
        {

            //agrupa los datos para mostrarlos en la grilla
            switch (mod)
            {
                case 1:
                    return "SELECT Fecha, SUM(Tickets) AS Tickets, SUM(Cantidad) AS Cantidad, SUM(Total) AS Total FROM #tmpEstVent GROUP BY Fecha";
                case 2:
                    return "SELECT Año, Mes, SUM(Tickets) AS Tickets, SUM(Cantidad) AS Cantidad, SUM(Total) AS Total FROM #tmpEstVent WHERE NMes In(" + String.Join(", ", arrayMeses.ToArray()) + ") GROUP BY Año, Mes, NMes";
                case 3:
                    return "SELECT Año, SUM(Tickets) AS Tickets, SUM(Cantidad) AS Cantidad, SUM(Total) AS Total FROM #tmpEstVent GROUP BY Año";
                case 4:
                    return "SELECT Consultorio, SUM(Tickets) AS Tickets, SUM(Cantidad) AS Cantidad, SUM(Total) AS Total FROM #tmpEstVent GROUP BY Consultorio";
            }

            return null;

        }

        private void WorkerMethod(object sender, WaitWindowEventArgs e)
        {
            //Modo
            int mod = getMod();

            //Lista de operativos
            List<string> arrayOperativos = getSelected(listaOperativos);

            //Lista de especialidades
            List<string> arrayEspecialidades = getSelected(listaEspecialidades);

            //Lista de meses
            List<string> arrayMeses = getSelected(listaMeses);

            GenerarTabla(mod, arrayEspecialidades, arrayMeses);

            try
            {
                //selecciona los datos e inserta en tabla temporal
                string vSQL = getSQL(mod, arrayMeses) + (rbMeses.Checked ? " ORDER BY 1, 3": " ORDER BY 1") + ";";
                Conexion.CMD.CommandText = vSQL;
                using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
                {
                    //Se debe reinicializar porque las columnas son dinamicas
                    dt = new DataSet();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int mod = getMod();

            //Lista de operativos
            if (getSelected(listaOperativos).Count == 0)
            {
                MessageBox.Show("Debe seleccionar un Operativo");
                return;
            }

            //Lista de especialidades
            if (getSelected(listaEspecialidades).Count == 0)
            {
                MessageBox.Show("Debe seleccionar una o más especialidades");
                return;
            }

            //Lista de meses
            List<string> arrayMeses = getSelected(listaMeses);

            switch (mod)
            {
                case 1:
                    break;
                case 2:
                    if (arrayMeses.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar uno o más meses");
                        return;
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }

            object result = Dominio.Helpers.WaitWindow.Show(this.WorkerMethod, "Procesando la consulta...");
            if (result == null)
            {
                MessageBox.Show("No se pudo procesar la consulta.");
                return;
            }

            //llena la grilla con los datos
            fGrid.Rows.Clear();
            FormateaGrilla();
            IDataReader dr = dt.CreateDataReader();
            fGrid.FillWithData(dr);
            dr.Close();

            decimal tNew = 0;
            decimal tOld = 0;
            decimal tTot = 0;

            for (int i = 0; i <= fGrid.Rows.Count - 1; i++)
            {
                tNew = tNew + Convert.ToDecimal(fGrid.Cells[i, fGrid.Cols.Count - 3].Value);
                tOld = tOld + Convert.ToDecimal(fGrid.Cells[i, fGrid.Cols.Count - 2].Value);
                tTot = tTot + Convert.ToDecimal(fGrid.Cells[i, fGrid.Cols.Count - 1].Value);

            }

            txtTNew.Text = tNew.ToString();
            txtTOld.Text = tOld.ToString();
            txtTTot.Text = tTot.ToString();

            //Cantidad de filas
            lblCantidad.Text = fGrid.Rows.Count.ToString();

        }

        private void frmEstVent_Load(object sender, EventArgs e)
        {
            //Llenaremos combobox
            LlenarOperativos();
            LlenarMeses();
            LlenarEspecialidades();
            FormateaGrilla();

        }

        private void frmEstVent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BorrarTablaTemporal(true);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVerGraf_Click(object sender, EventArgs e)
        {
            int mod = getMod();

            //Lista de operativos
            List<string> arrayOperativos = getSelected(listaOperativos);

            //Lista de especialidades
            List<string> arrayEspecialidades = getSelected(listaEspecialidades);

            //Lista de meses
            List<string> arrayMeses = getSelected(listaMeses);

            //Lista de operativos
            if (arrayOperativos.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un Operativo");
                return;
            }

            //Lista de especialidades
            if (arrayEspecialidades.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una o más especialidades");
                return;
            }

            switch (mod)
            {
                case 1:
                    break;
                case 2:
                    if (arrayMeses.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar uno o más meses");
                        return;
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }

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
                MessageBox.Show("Debe seleccionar un tipo de grafico.", "Estadistica - Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            //valida que alguna opcion de agrupacion este seleccionado
            bEncontrado = false;
            string description = "";
            foreach (Control cntrl in grpAgrupacion.Controls)
            {
                if (cntrl is RadioButton)
                {
                    RadioButton rb = (RadioButton)cntrl;
                    if (rb.Checked)
                    {
                        bEncontrado = true;
                        description = rb.AccessibleDescription;
                        break;
                    }
                }

            }

            if (bEncontrado == false)
            {
                MessageBox.Show("Debe seleccionar un tipo de agrupacion.", "Estadistica - Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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


            string bSQL = GenerarTabla(mod, arrayEspecialidades, arrayMeses, false);

            //selecciona los datos e inserta en tabla temporal
            string vSQL = getSQL(mod, arrayMeses);

            string gSQL = "";

            if (rbFechas.Checked == true) { 
                gSQL = "SELECT X.Total, CONVERT(varchar(10), X.Fecha, 103) AS campo" +
                       " FROM (" + vSQL + ") X";
            }

            if (rbMeses.Checked == true)
            {  
                gSQL = "SELECT X.Total, X.Mes AS campo" +
                       " FROM (" + vSQL + ") X";
            }

            if (rbAños.Checked == true)
            {   
                gSQL = "SELECT X.Total, STR(X.Año) AS campo" +
                       " FROM (" + vSQL + ") X";
            }

            if (rbEspecialidad.Checked == true)
            {  
                gSQL = "SELECT X.Total, X.Consultorio AS campo" +
                       " FROM (" + vSQL + ") X";
            }

            //define los valores que se enviara al formulario que grafica
            Grafico.series = new List<Serie>();
            Grafico.series.Add(new Serie("Total", Color.Blue));

            Grafico.sSQL = bSQL + gSQL;
            Grafico.TituloChart = "Grafico Estadistico del " + dtpicFInicial.Text.Substring(0, 10) + " al " + dtpicFFinal.Text.Substring(0, 10) + " Por " + description;
            Grafico.TituloX = description;
            Grafico.LeyendaX = "Agrupacion por Distribucion";
            Grafico.TituloY = "Cantidad";
            Grafico.LeyendaY = "En Soles";
            Grafico.Decimal = true;

            //crea el formulario del grafico
            frmGrafico frg = new frmGrafico();
            frg.CargaChart();
            frg.Text = "Grafico Estadistico por " + description;
            frg.ShowDialog();
        }
    }
}
