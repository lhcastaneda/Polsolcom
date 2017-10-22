using CrystalDecisions.CrystalReports.Engine;
using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
    public partial class frmResultado : Form
    {
        public string cn_;
        public string es_;
        public string cn;
        public string es;
        public string nh;
        public string pr = "";
        public string rs = "";
        public string er = "";
        public string pa = "";
        public int cp = 0;
        //LABELS
        public string docVenta = "";
        public string paciente = "";
        public string edad = "";
        public string especialidad = "";
        public string medico = "";
        public string fechaAtencion = "";
        ReportDocument rpt = new ReportDocument();

        public frmResultado(List<Dictionary<string, string>> items, string cn, string es, string nh)
        {
            InitializeComponent();
            this.cn = cn;
            this.es = es;
            this.cn_ = cn;
            this.es_ = es;
            this.nh = nh;

            General.FillDataGridView(grdProductos, items, new[] { "dM" });
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int x = grdProductos.CurrentCell.RowIndex;
            this.pr = grdProductos.Rows[x].Cells["dIdProducto"].Value.ToString();
            this.rs = txtResultado.Text;
            this.cn_ = txtConclusion.Text;

            if (MessageBox.Show("Desea guardar los cambios ... ?", "Aviso al usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sql = "Update Detalles Set Pagado='R', Resultado = '" + rs + "', Conclusion = '" + cn_ + "' Where Nro_Historia = '" + nh + "' And Id_Producto = '" + pr + "'";
                Conexion.ExecuteNonQuery(sql);
                MessageBox.Show("Operación ejecutada con éxito", "Mensaje");

                for (int i = 0; i < grdProductos.Rows.Count; i++)
                {
                    if (grdProductos.Rows[i].Cells["dNroHistoria"].Value.ToString() == this.nh && grdProductos.Rows[i].Cells["dIdProducto"].ToString() == this.pr)
                    {
                        grdProductos.Rows[i].Cells["dResultado"].Value = this.rs;
                        grdProductos.Rows[i].Cells["dConclusion"].Value = this.cn_;
                        grdProductos.Rows[i].Cells["dPagado"].Value = "R";
                    }
                }

                btnImprimir.Enabled = true;
            }
        }

        private void frmResultado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                btnGrabar_Click(btnGrabar, new EventArgs());
            }

            if (e.KeyCode == Keys.Escape)
            {
                btnImprimir.Enabled = false;
                grdProductos.Rows.Clear();

                int cp = General.GetDictionaryList(grdProductos).FindAll(x => x["dNroHistoria"] == this.nh && x["dPagado"].Length > 0).Count;
                this.Close();
            }
        }

        private void dgvProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
        }

        private void grdProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdProductos.CurrentCell.RowIndex;
            int j = grdProductos.CurrentCell.ColumnIndex;
            string columnName = grdProductos.Columns[j].Name;

            txtResultado.Text = (grdProductos.Rows[i].Cells["dPagado"].Value.ToString() != "" ? grdProductos.Rows[i].Cells["dResultado"].Value.ToString() : "");
            txtConclusion.Text = (grdProductos.Rows[i].Cells["dPagado"].Value.ToString() != "" ? grdProductos.Rows[i].Cells["dConclusion"].Value.ToString() : "");
            btnImprimir.Enabled = (grdProductos.Rows[i].Cells["dPagado"].Value.ToString() != "" && (grdProductos.Rows[i].Cells["dResultado"].Value.ToString() + grdProductos.Rows[i].Cells["dConclusion"].Value.ToString()).Length > 0);
            cmbParticular.Enabled = btnGrabar.Enabled = (grdProductos.Rows[i].Cells["dPagado"].Value.ToString() != "P");
            if (btnGrabar.Enabled)
            {
                string pr = grdProductos.Rows[i].Cells["dIdProducto"].Value.ToString();
                cmbParticular.SelectedIndex = -1;
                this.plantillasTableAdapter.Fill(this.plantillasDS.Plantillas, this.cn_, this.es_, pr);
            }
            this.Refresh();
        }

        private void WorkerMethodRPT(object sender, WaitWindowEventArgs e)
        {
            this.cn_ = this.rs = "";

            List<Dictionary<string, string>> xx = General.GetDictionaryList(grdProductos);
            List<Dictionary<string, string>> items = xx.FindAll(x => x["dNroHistoria"] == this.nh && x["dM"] == "True");
            foreach (Dictionary<string, string> item in items)
            {
                this.rs += (rs.Length > 0 ? "\n" : "") + item["dResultado"];
                this.cn_ += (cn_.Length > 0 ? "\n" : "") + item["dConclusion"];
                this.er += (rs.Length + cn_.Length > 0 ? item["dDescripcion"] + ", " : "");
            }

            string result = this.rs + "\n" + (this.cn_.Length > 0? "CONCLUSION:\n" + this.cn_: "");

            er = er.Length > 0 ? General.SafeSubstring(er, 0, er.Length - 1) : "";

            //define la ruta por defecto de la app
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            //define el reporte dependiendo del tipo de seleccion
            path = path + "/Dominio/Reportes/rptResultado.rpt";

            //carga el reporte
            rpt.Load(path);

            //setea los parametros del reporte Parte de atencion diario
            rpt.SetParameterValue("Operativo", Operativo.descripcion);
            rpt.SetParameterValue("Especialidad", this.especialidad);
            rpt.SetParameterValue("docVenta", this.docVenta);
            rpt.SetParameterValue("Paciente", this.paciente + "(" + this.edad + " AÑOS)");
            rpt.SetParameterValue("Examen", this.especialidad + " " + this.er);
            rpt.SetParameterValue("Especialista", this.medico);
            rpt.SetParameterValue("Fecha", this.fechaAtencion);
            rpt.SetParameterValue("resultados", result);

            if (e.Arguments.Count > 0)
                e.Result = e.Arguments[0].ToString();
            else
                e.Result = "Proceso culminado.";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea imprimir los resultados seleccionados ... ?", "Aviso al usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
        }

        private void cmbParticular_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = grdProductos.CurrentCell.RowIndex;

            this.cn_ = this.cn;
            this.es_ = this.es;

            this.pr = grdProductos.Rows[i].Cells["dIdProducto"].Value.ToString();
            this.pa = cmbParticular.SelectedValue.ToString();

            if (this.pr == "" || this.pa == "")
            {
                MessageBox.Show("Faltan datos para realizar la consulta ...", "Advertencia");
                return;
            }

            string sql = "Select tx_plant Resultado From Plantillas  Where id_cons = '" + this.cn_ + "' And id_pers = '" + this.es + "' And id_prod = '" + pr + "' And id_part = '" + pa + "'";
            Dictionary<string, string> plantilla = General.GetDictionary(sql);

            int pc = plantilla["dResultado"].IndexOf("'CONCLUSION:'");

            txtResultado.Text = plantilla["dResultado"].Substring(0, pc - 3);
            txtConclusion.Text = plantilla["dResultado"].Substring(pc + 13);
            btnGrabar.Enabled = true;
            this.Refresh();
        }
    }
}
