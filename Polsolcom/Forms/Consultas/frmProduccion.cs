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
    public partial class frmProduccion : Form
    {
        string vSQL = "";
        DataSet dt = new DataSet();
        ReportDocument rpt = new ReportDocument();

        public frmProduccion()
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
            fGrid.DefaultRow.Height = 15;
            fGrid.Cols.Count = 9;
            fGrid.Cols[0].Text = "Doc. Venta";
            fGrid.Cols[0].Width = 60;
            fGrid.Cols[0].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[0].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
            fGrid.Cols[0].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[1].Text = "Especialidad";
            fGrid.Cols[1].Width = 150;
            fGrid.Cols[1].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
            fGrid.Cols[1].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[2].Text = "Producto y/o Servicio";
            fGrid.Cols[2].Width = 210;
            fGrid.Cols[2].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[3].Text = "Precio";
            fGrid.Cols[3].Width = 60;
            fGrid.Cols[3].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[4].Text = "Cantidad";
            fGrid.Cols[4].Width = 40;
            fGrid.Cols[4].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[4].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[4].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[5].Text = "Total S/.";
            fGrid.Cols[5].Width = 60;
            fGrid.Cols[5].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[5].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[5].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[6].Text = "Cajero (a)";
            fGrid.Cols[6].Width = 80;
            fGrid.Cols[6].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[6].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[6].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[7].Text = "Fecha";
            fGrid.Cols[7].Width = 120;
            fGrid.Cols[7].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[7].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[7].CellStyle.ReadOnly = iGBool.True;
            //
            fGrid.Cols[8].Text = "Modo";
            fGrid.Cols[8].Visible = false;
        }

        private void cargarUsuarios()
        {
            DateTime fechaInicio = dtpFechInicio.Value;
            DateTime fechaFinal = dtpFechFinal.Value;
            int selectedIndex = cmbCajero.SelectedIndex;

            this.cajerosTableAdapter.Fill(this.cajerosDS.Cajeros, fechaInicio, fechaFinal);

            //Desencriptar
            for (int i = 0; i < cmbCajero.Items.Count; i++)
            {
                DataRowView row = (DataRowView)cmbCajero.Items[i];
                row.Row["Usuario"] = General.cryptgr(row.Row["Usuario"].ToString(), false, 1);
            }

            cmbCajero.SelectedIndex = selectedIndex;
        }

        private string generateSQL()
        {
            DateTime fechaInicio = dtpFechInicio.Value;
            DateTime fechaFin = dtpFechFinal.Value;

            string idUsuario = "";
            if (cmbCajero.SelectedIndex != -1)
            {
                idUsuario = ((DataRowView)cmbCajero.SelectedItem).Row["Id_User"].ToString();

            }

            string consultorio = "";
            if (cmbEspecialidad.SelectedIndex != -1)
            {
                consultorio = ((DataRowView)cmbEspecialidad.SelectedItem).Row["Id_Consultorio"].ToString();

            }

            int opt = 1;

            if (rbVendido.Checked)
            {
                opt = 1;
            }

            if (rbAnulado.Checked)
            {
                opt = 2;
            }

            if (rbExtorno.Checked)
            {
                opt = 3;
            }

            vSQL = "EXEC TotDet @ini = '" + String.Format("{0:dd/MM/yyyy}", fechaInicio) + "', @fin = '" + String.Format("{0:dd/MM/yyyy}", fechaFin) + "', @dig = '" + idUsuario + "', @idc = '" + consultorio + "', @tc = " + opt.ToString() + ";";

            return vSQL;
        }

        private void WorkerMethod(object sender, WaitWindowEventArgs e)
        {
            try
            {
                Conexion.CMD.CommandText = vSQL;

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

        private void WorkerMethodRPT(object sender, WaitWindowEventArgs e)
        {
            //define la ruta por defecto de la app
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            //define el reporte dependiendo del tipo de seleccion
            path = path + "/Dominio/Reportes/rptProduccion.rpt";

            //carga el reporte
            rpt.Load(path);

            Conexion.CMD.CommandText = this.vSQL;
            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (ProduccionDS ds = new ProduccionDS())
                {
                    ds.Clear();
                    da.Fill(ds, "Produccion");

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ds.Tables[0].Rows[i][6] = General.cryptgr(ds.Tables[0].Rows[i][6].ToString(), false, 1);
                    }

                    rpt.SetDataSource(ds);
                }
            }

            //setea los parametros del reporte Parte de atencion diario
            rpt.SetParameterValue("TituloReporte", "Reporte Detallado X Fecha X Cajero");

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

            //Desencriptamos
            int cVent = 0;
            int cExt = 0;
            float sVent = 0;
            float sExt = 0;

            for (int i = 0; i <= fGrid.Rows.Count - 1; i++)
            {
                if (fGrid.Cells[i, 8].Value.ToString() == "VENDIDOS" || fGrid.Cells[i, 8].Value.ToString() == "ANULADO")
                {
                    cVent += Int32.Parse(fGrid.Cells[i, 4].Value.ToString());
                    sVent += float.Parse(fGrid.Cells[i, 5].Value.ToString());
                }

                if (fGrid.Cells[i, 8].Value.ToString() == "EXTORNOS")
                {
                    cExt += Int32.Parse(fGrid.Cells[i, 4].Value.ToString());
                    sExt += float.Parse(fGrid.Cells[i, 5].Value.ToString());
                }

                fGrid.Cells[i, 6].Value = General.cryptgr(fGrid.Cells[i, 6].Value.ToString(), false, 1);
            }

            txtcVen.Text = cVent.ToString();
            txtsVen.Text = sVent.ToString();
            txtcExt.Text = cExt.ToString();
            txtsExt.Text = sExt.ToString();
            txtCant.Text = (cVent + cExt).ToString();
            txtTotal.Text = (sVent + sExt).ToString();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (Usuario.tipo == "U")
            {
                if (cmbCajero.SelectedIndex != -1)
                {
                    if (Usuario.id_us != ((DataRowView)cmbCajero.SelectedItem).Row["Id_User"].ToString())
                    {
                        MessageBox.Show("No tiene autorización para relizar esta consulta ...", "Permiso denegado");
                    }
                }
            }

            cargarUsuarios();
            llenarGrilla();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            this.consultoriosTableAdapter.Fill(this.consultoriosDS.Consultorios, Operativo.id_oper);

            FormateaGrilla();

            cmbEspecialidad.SelectedIndex = -1;
        }

        private void frmProduccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
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
