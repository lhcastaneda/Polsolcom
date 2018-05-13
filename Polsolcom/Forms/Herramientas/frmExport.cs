using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Polsolcom.Dominio.Connection;
using System.Text.RegularExpressions;
using Polsolcom.Dominio.Helpers;

namespace Polsolcom.Forms
{
	public partial class frmExport : Form
    {
        const int max_records = 65500;
        string title = "";
        string sql = "";
        string worksheetName = "Reporte";
        string nfe = "";
        DataTable dataTable;

        public frmExport(string sql, string title, string nfil)
        {
            InitializeComponent();
            this.title = title;
            this.sql = sql;
            txtPath.Text = AppDomain.CurrentDomain.BaseDirectory;
            txtNomFile.Text = nfil;
        }

        public bool exportar()
        {
			nfe = txtPath.Text + txtNomFile.Text + "." + cmbTipo.SelectedItem.ToString();
            if (File.Exists(nfe) )
            {
                if (MessageBox.Show("El archivo ya existe, desea reemplazarlo ... ?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    txtNomFile.Focus();
                    return false;
                }
            }

			dataTable = Conexion.GetTable(sql);
            if (cmbTipo.SelectedItem.ToString() == "XLSX" && dataTable.Rows.Count > max_records)
            {
                if (MessageBox.Show("Cantidad de registros mayor a " + max_records.ToString() + ", desea continuar ...?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                    return false;
            }
            return (bool)WaitWindow.Show(WorkerMethod, "Generando el archivo...");
        }

        private void WorkerMethod(object sender, WaitWindowEventArgs e)
        {
			Excel.Application excel;
            Excel.Workbook excelworkBook;
            Excel.Worksheet excelSheet;
            Excel.Range excelCellrange;

			try
			{
				// Start Excel and get Application object.
				excel = new Excel.Application();
				// for making Excel visible
				excel.Visible = false;
				excel.DisplayAlerts = false;
				// Creation a new Workbook
				excelworkBook = excel.Workbooks.Add(Type.Missing);
				// Workk sheet
				excelSheet = (Excel.Worksheet)excelworkBook.ActiveSheet;
				excelSheet.Name = worksheetName;
				excelSheet.Cells[1, 1] = title.Trim().ToUpper();
                excelSheet.Cells[1, 2] = "Date : " + DateTime.Now.ToShortDateString();

                // loop through each row and add values to our sheet
                int rowcount = 2;
                foreach (DataRow datarow in dataTable.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= dataTable.Columns.Count; i++)
                    {   // on the first iteration we add the column headers
                        if (rowcount == 3)
                        {
                            excelSheet.Cells[2, i] = dataTable.Columns[i - 1].ColumnName.Trim().ToUpper();
                            excelSheet.Cells.Font.Color = System.Drawing.Color.Black;
                        }

						DateTime dt;
						if( DateTime.TryParse(datarow[i - 1].ToString(),out dt) )
							excelSheet.Cells[rowcount, i] = ((DateTime)(datarow[i - 1])).ToString("dd/MM/yyyy").ToString();
						else
							excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();
                        
						//for alternate rows
                        if (rowcount > 3)
                        {
                            if (i == dataTable.Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, dataTable.Columns.Count]];
                                    FormattingExcelCells(excelCellrange, "#CCCCFF", System.Drawing.Color.Black, false);
                                }

                            }
                        }
                    }
                }

                // now we resize the columns
                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount, dataTable.Columns.Count]];
                excelCellrange.EntireColumn.AutoFit();
				Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;
                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[2, dataTable.Columns.Count]];
                FormattingExcelCells(excelCellrange, "#000099", System.Drawing.Color.White, true);
                //now save the workbook and exit Excel
                excelworkBook.SaveAs(nfe); ;
                excelworkBook.Close();
                excel.Quit();
                e.Result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Result = false;
            }
            finally
            {
                excelSheet = null;
                excelCellrange = null;
                excelworkBook = null;
            }
            e.Result = true;
        }
		
        public void FormattingExcelCells( Excel.Range range, string HTMLcolorCode, System.Drawing.Color fontColor, bool IsFontbool)
        {
            range.Interior.Color = System.Drawing.ColorTranslator.FromHtml(HTMLcolorCode);
            range.Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
            if (IsFontbool == true)
                range.Font.Bold = IsFontbool;
        }

        public void crearExcel(DataTable dtable, string nfe)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@nfe);
            xlWorkSheet = xlWorkBook.ActiveSheet as Excel.Worksheet;

            xlWorkSheet.UsedRange.Select();
            xlWorkSheet.UsedRange.Delete(Excel.XlDeleteShiftDirection.xlShiftUp);
            xlApp.DisplayAlerts = false;

            ////*** Generating the column Names here
            string[] colNames = new string[dtable.Columns.Count];

            int col = 0;
            foreach (DataColumn dc in dtable.Columns)
                colNames[col++] = dc.ColumnName;

            char lastColumn = (char)(65 + dtable.Columns.Count - 1);
            xlWorkSheet.get_Range("A1", lastColumn + "1").Value2 = colNames;
            xlWorkSheet.get_Range("A1", lastColumn + "1").Font.Bold = true;
            xlWorkSheet.get_Range("A1", lastColumn + "1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            /////*** Inserting the Column and Values into Excel file
            for (int i = 0; i <= dtable.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= dtable.Columns.Count - 1; j++)
                {
                    string data = dtable.Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 2, j + 1] = data;
                }
            }
            ///**Saving the csv file without notification.
            xlApp.DisplayAlerts = false;
            xlWorkBook.Save();
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            { GC.Collect(); }
        }

        private void frmExport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
				DialogResult = DialogResult.Cancel;
				Close();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (txtPath.Text.Length == 0)
            {
                msg = "Indique la ruta donde se guardara el archivo ...";
                goto Go;
            }

            if (txtNomFile.Text.Length == 0)
            {
                msg = "Indique el nombre para guardar el archivo ...";
                goto Go;
            }

            if (cmbTipo.SelectedIndex == -1)
            {
                msg = "Indique el tipo de extension para guardar el archivo ...";
                goto Go;
            }

        Go:
            if (msg.Length > 0)
            {
                MessageBox.Show(msg, "Advertencia");
                return;
            }

            if (!exportar())
				return;

			MessageBox.Show("Archivo creado con exito ...", "Aviso al usuario");
			DialogResult = DialogResult.OK;
			Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.Cancel;
			Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog(this);

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPath.Text = fbd.SelectedPath.Substring(fbd.SelectedPath.Length -1) == "\\" ? fbd.SelectedPath: fbd.SelectedPath + "\\";
                    txtNomFile.Focus();
                }
            }
        }

        private void txtNomFile_Leave(object sender, EventArgs e)
        {
            bool result = Regex.IsMatch(txtNomFile.Text, @"^[\w\-. ]+$");
            if (!result)
            {
                MessageBox.Show("Hay caracteres no permitidos en el nombre de archivo, corregir", "Aviso al usuario");
                txtNomFile.Focus();
            }
        }
    }
}
