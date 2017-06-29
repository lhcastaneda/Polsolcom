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

        private void BorraTablaTemporal()
        {
            //borra la tabla temporal
            string vSQL = "IF OBJECT_ID('tempdb.dbo.#tmpEstVent', 'U') IS NOT NULL DROP TABLE #tmpEstVent;";
            Conexion.CMD.CommandText = vSQL;
            Conexion.CMD.ExecuteNonQuery();
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
            }
        }

        private List<string> getSelected(ListSelectionWrapper<DataRow> lista) {
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

        private string getSQL(int mod, List<string> arrayEspecialidades, List<string> arrayMeses)
        {

            //agrupa los datos para mostrarlos en la grilla
            switch (mod)
            {
                case 1:
                    return "CREATE TABLE #tmpEstVent(Consultorio varchar(20), Tickets int, Cantidad int, Total int, Fecha DateTime, TCons varchar(25), Operativo varchar(20), Mes varchar(10), Año int);" +
                "INSERT INTO #tmpEstVent EXEC TotCons @fini = '" + String.Format("{0:dd/MM/yyyy}", dtpicFInicial.Value) + "', @ffin = '" + String.Format("{0:dd/MM/yyyy}", dtpicFFinal.Value) + "', @idc = '" + String.Join(",", arrayEspecialidades.ToArray()) + "', @mod = " + mod.ToString() + ";" +
                "SELECT Fecha, SUM(Tickets) AS Tickets, SUM(Cantidad) AS Cantidad, SUM(Total) AS Total FROM #tmpEstVent GROUP BY Fecha ORDER BY 1;";
                case 2:
                    return "CREATE TABLE #tmpEstVent(Consultorio varchar(20), Tickets int, Cantidad int, Total int, TCons varchar(25), Operativo varchar(20), Mes varchar(10), NMes int, Año int);" +
                "INSERT INTO #tmpEstVent EXEC TotCons @fini = '" + String.Format("{0:dd/MM/yyyy}", dtpicFInicial.Value) + "', @ffin = '" + String.Format("{0:dd/MM/yyyy}", dtpicFFinal.Value) + "', @idc = '" + String.Join(",", arrayEspecialidades.ToArray()) + "', @mod = " + mod.ToString() + ";" +
                 "SELECT Año, Mes, SUM(Tickets) AS Tickets, SUM(Cantidad) AS Cantidad, SUM(Total) AS Total FROM #tmpEstVent WHERE NMes In(" + String.Join(", ", arrayMeses.ToArray()) + ") GROUP BY Año, Mes, NMes ORDER BY 1, 3;";
                case 3:
                    return "CREATE TABLE #tmpEstVent(Consultorio varchar(20), Tickets int, Cantidad int, Total int, TCons varchar(25), Operativo varchar(20), Año int);" +
                "INSERT INTO #tmpEstVent EXEC TotCons @fini = '" + String.Format("{0:dd/MM/yyyy}", dtpicFInicial.Value) + "', @ffin = '" + String.Format("{0:dd/MM/yyyy}", dtpicFFinal.Value) + "', @idc = '" + String.Join(",", arrayEspecialidades.ToArray()) + "', @mod = " + mod.ToString() + ";" +
                "SELECT Año, SUM(Tickets) AS Tickets, SUM(Cantidad) AS Cantidad, SUM(Total) AS Total FROM #tmpEstVent GROUP BY Año ORDER BY 1;";
                case 4:
                    return "CREATE TABLE #tmpEstVent(Consultorio varchar(20), Tickets int, Cantidad int, Total int, TCons varchar(25), Operativo varchar(20));" +
                "INSERT INTO #tmpEstVent EXEC TotCons @fini = '" + String.Format("{0:dd/MM/yyyy}", dtpicFInicial.Value) + "', @ffin = '" + String.Format("{0:dd/MM/yyyy}", dtpicFFinal.Value) + "', @idc = '" + String.Join(",", arrayEspecialidades.ToArray()) + "', @mod = " + mod.ToString() + ";" +
                "SELECT Consultorio, SUM(Tickets) AS Tickets, SUM(Cantidad) AS Cantidad, SUM(Total) AS Total FROM #tmpEstVent GROUP BY Consultorio ORDER BY 1;";
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

            BorraTablaTemporal();

            try
            {
                //selecciona los datos e inserta en tabla temporal
                string vSQL = getSQL(mod, arrayEspecialidades, arrayMeses);
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

            int tNew = 0;
            int tOld = 0;
            int tTot = 0;

            for (int i = 0; i <= fGrid.Rows.Count - 1; i++)
            {
                tNew = tNew + Convert.ToInt32(fGrid.Cells[i, fGrid.Cols.Count - 3].Value);
                tOld = tOld + Convert.ToInt32(fGrid.Cells[i, fGrid.Cols.Count - 2].Value);
                tTot = tTot + Convert.ToInt32(fGrid.Cells[i, fGrid.Cols.Count - 1].Value);

            }

            txtTNew.Text = tNew.ToString();
            txtTOld.Text = tOld.ToString();
            txtTTot.Text = tTot.ToString();

            //Cantidad de filas
            lblCantidad.Text = fGrid.Rows.Count.ToString();

        }

        private void frmEstVent_Load(object sender, EventArgs e)
        {
            //Borrar esto al reestablecer el formulario de login como pantalla principal
            Conexion.ConectaBD();
            Conexion.CMD.Connection = Conexion.CNN;
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
                BorraTablaTemporal();
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
