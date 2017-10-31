using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Polsolcom.Dominio.Connection;
using System.Text.RegularExpressions;
using Polsolcom.Dominio.Helpers;
using System.Data.SqlClient;

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
            this.nfe = txtPath.Text + txtNomFile.Text + "." + cmbTipo.SelectedItem.ToString();

            if (File.Exists(this.nfe))
            {
                if (MessageBox.Show("El archivo ya existe, desea reemplazarlo ... ?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    txtNomFile.Focus();
                    return false;
                }
            }

            this.dataTable = Conexion.GetTable(this.sql);
            if (cmbTipo.SelectedItem.ToString() == "XLSX" && this.dataTable.Rows.Count > max_records)
            {
                if (MessageBox.Show("Cantidad de registros mayor a " + max_records.ToString() + ", desea continuar ...?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return false;
                }
            }

            return (bool)WaitWindow.Show(WorkerMethod, "Generando el reporte...");
        }

        private void WorkerMethod(object sender, WaitWindowEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;

            try
            {
                // Start Excel and get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application();

                // for making Excel visible
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // Creation a new Workbook
                excelworkBook = excel.Workbooks.Add(Type.Missing);

                // Workk sheet
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
                excelSheet.Name = this.worksheetName;

                excelSheet.Cells[1, 1] = this.title;
                excelSheet.Cells[1, 2] = "Date : " + DateTime.Now.ToShortDateString();

                // loop through each row and add values to our sheet
                int rowcount = 2;

                foreach (DataRow datarow in this.dataTable.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= this.dataTable.Columns.Count; i++)
                    {
                        // on the first iteration we add the column headers
                        if (rowcount == 3)
                        {
                            excelSheet.Cells[2, i] = this.dataTable.Columns[i - 1].ColumnName;
                            excelSheet.Cells.Font.Color = System.Drawing.Color.Black;
                        }

                        excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();

                        //for alternate rows
                        if (rowcount > 3)
                        {
                            if (i == this.dataTable.Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, this.dataTable.Columns.Count]];
                                    FormattingExcelCells(excelCellrange, "#CCCCFF", System.Drawing.Color.Black, false);
                                }

                            }
                        }
                    }
                }

                // now we resize the columns
                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount, this.dataTable.Columns.Count]];
                excelCellrange.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;


                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[2, this.dataTable.Columns.Count]];
                FormattingExcelCells(excelCellrange, "#000099", System.Drawing.Color.White, true);


                //now save the workbook and exit Excel

                excelworkBook.SaveAs(this.nfe); ;
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


        /// <summary>
        /// FUNCTION FOR FORMATTING EXCEL CELLS
        /// </summary>
        /// <param name="range"></param>
        /// <param name="HTMLcolorCode"></param>
        /// <param name="fontColor"></param>
        /// <param name="IsFontbool"></param>
        public void FormattingExcelCells(Microsoft.Office.Interop.Excel.Range range, string HTMLcolorCode, System.Drawing.Color fontColor, bool IsFontbool)
        {
            range.Interior.Color = System.Drawing.ColorTranslator.FromHtml(HTMLcolorCode);
            range.Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
            if (IsFontbool == true)
            {
                range.Font.Bold = IsFontbool;
            }
        }

        public void crearExcel(DataTable dtable, string nfe)
        {
            ////*** Preparing excel Application
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            ///*** Opening Excel application
            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Open(@nfe);
            //xlWorkSheet = (Excel.Worksheet)(xlWorkBook.ActiveSheet as Excel.Worksheet);

            ///*** Opening Excel application
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@nfe);
            xlWorkSheet = (Excel.Worksheet)(xlWorkBook.ActiveSheet as Excel.Worksheet);

            ////*** It will always remove the prvious result from the CSV file so that we can get always the updated data
            xlWorkSheet.UsedRange.Select();
            xlWorkSheet.UsedRange.Delete(Excel.XlDeleteShiftDirection.xlShiftUp);
            xlApp.DisplayAlerts = false;
            //xlWorkBook.Save();

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

            //xlWorkBook.SaveAs("Book1.csv", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            ////MessageBox.Show("Excel file created , you can find the file C:\\Users\\MM18100\\Documents\\informations.xls");
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
            {
                GC.Collect();
            }

        }

        private void frmExport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
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

            if (!this.exportar()) return;
            MessageBox.Show("Archivo creado con exito ...", "Aviso al usuario");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog(this);

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPath.Text = fbd.SelectedPath + "\\";
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
