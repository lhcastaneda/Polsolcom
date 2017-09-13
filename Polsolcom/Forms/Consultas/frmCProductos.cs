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
using TenTec.Windows.iGridLib;

namespace Polsolcom.Forms
{
    public partial class frmCProductos : Form
    {
        string vSQL = "";
        DataSet dt = new DataSet();
        ReportDocument rpt = new ReportDocument();

        public frmCProductos()
        {
            InitializeComponent();
        }

        private void frmTarProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaTipoDS.TipoProducto' table. You can move, or remove it, as needed.
            this.tipoProductoTableAdapter.Fill(this.tablaTipoDS.TipoProducto);
            //debe pasarse un datareader a la funcion
            this.consultoriosTableAdapter.Fill(this.consultoriosDS.Consultorios, Operativo.id_oper);

            cmbEspecialidad.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;

            FormateaGrilla();
        }

        public void FormateaGrilla()
        {
            fGrid.RowHeader.Visible = false;
            //fGrid.Footer.Visible = true;
            //No sé que fuente ponerle :/
            //fGrid.Footer.Font = new Font("Verdana", 12, FontStyle.Bold);
            //
            fGrid.DefaultRow.Height = 15;
            fGrid.Cols.Count = 3;
            fGrid.Cols[0].Text = "ID Producto";
            fGrid.Cols[0].Width = 70;
            fGrid.Cols[0].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[0].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
            fGrid.Cols[0].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[1].Text = "Nombre del producto y/o servicio";
            fGrid.Cols[1].Width = 400;
            fGrid.Cols[1].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
            fGrid.Cols[1].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[2].Text = "Precio S/.";
            fGrid.Cols[2].Width = 50;
            fGrid.Cols[2].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;
            //
        }

        string generateSQL()
        {
            vSQL = "";
            vSQL += "SELECT P.Id_Producto AS IdProd, P.Descripcion AS Producto, P.Monto AS Precio, T.Descripcion AS Tipo, C.Descripcion AS Consultorio ";
            vSQL += "FROM Productos P  ";
            vSQL += "INNER JOIN Consultorios C On SubString(P.Id_Producto, 1, 6) = C.Id_Consultorio  ";
            vSQL += "INNER JOIN (SELECT Id_Tipo, Descripcion FROM TablaTipo WHERE Id_Tabla In(SELECT Id_Tipo FROM TablaTipo WHERE LTrim(RTrim(Descripcion)) = 'TIPO_PRODUCTO' AND LTrim(RTrim(Id_Tabla)) = '0')) T On P.Tipo = T.Id_Tipo  ";
            vSQL += "WHERE P.Estado = '1' AND LTrim(RTrim(C.Descripcion)) <>'FARMACIA' AND SubString(C.Id_Consultorio, 1, 3) = '" + Operativo.id_oper + "' ";

            if (cmbEspecialidad.SelectedItem != null)
            {
                vSQL += "AND LTrim(RTrim(C.Id_Consultorio)) Like '%" + ((DataRowView)cmbEspecialidad.SelectedItem).Row["Id_Consultorio"].ToString() + "%' ";
                //Seteamos observaciones
                txtObservacion.Text = ((DataRowView)cmbEspecialidad.SelectedItem).Row["Observacion"].ToString();

            }

            if (txtIdProd.Text != "")
            {
                vSQL += "AND LTrim(RTrim(P.Id_Producto)) Like '%" + txtIdProd.Text + "%' ";
            }

            if (txtProd.Text != "")
            {
                vSQL += "AND LTrim(RTrim(P.Descripcion)) Like '%" + txtProd.Text + "%' ";
            }

            if (cmbTipo.SelectedItem != null)
            {
                vSQL += "AND LTrim(RTrim(T.Id_Tipo)) = '" + ((DataRowView)cmbTipo.SelectedItem).Row["Id_Tipo"].ToString() + "' ";
            }

            if (txtPrec.Text != "")
            {
                vSQL += "AND P.Monto Like '%" + txtPrec.Text + "%' ";
            }

            return vSQL;
        }

        private void WorkerMethod(object sender, WaitWindowEventArgs e)
        {
            try
            {
				//debe pasar un datareader para usar la funcion
                Conexion.CMD.CommandText = vSQL + " ORDER BY 5, 2";

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

        void llenarGrilla()
        {
            generateSQL();

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

        }

        private void cmbEspecialidad_SelectedValueChanged(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void txtIdProd_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void txtPrec_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void txtProd_TextChanged(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void frmCProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if (e.KeyCode == Keys.F2)
            {
                cmbEspecialidad.SelectedIndex = -1;
                cmbTipo.SelectedIndex = -1;
                txtIdProd.Clear();
                txtProd.Clear();
                txtPrec.Clear();
            }
            if (e.KeyCode == Keys.F9)
            {
                exportar();
            }

            if (e.KeyCode == Keys.F11)
            {
                int tPrecioTot = 0;

                for (int i = 0; i <= fGrid.Rows.Count - 1; i++)
                {
                    tPrecioTot = tPrecioTot + Convert.ToInt32(fGrid.Cells[i, 2].Value);

                }

                txtSuma.Text = tPrecioTot.ToString();
            }

            if (e.KeyCode == Keys.F12)
            {
                txtSuma.Text = "0.00";
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            exportar();
        }

        void exportar()
        {
            generateSQL();

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
            path = path + "/Dominio/Reportes/rptCProductos.rpt";

            //carga el reporte
            rpt.Load(path);

            Conexion.CMD.CommandText = this.vSQL;
            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (CProductosDS ds = new CProductosDS())
                {
                    ds.Clear();
                    da.Fill(ds, "CProductosDT");
                    rpt.SetDataSource(ds);
                }
            }

            //setea los parametros del reporte Parte de atencion diario
            rpt.SetParameterValue("TituloReporte", "Productos por consultorio");

            if (e.Arguments.Count > 0)
                e.Result = e.Arguments[0].ToString();
            else
                e.Result = "Proceso culminado.";

        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            generateSQL();

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
    }
}
