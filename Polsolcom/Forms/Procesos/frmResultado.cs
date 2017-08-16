﻿using CrystalDecisions.CrystalReports.Engine;
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
        //LABELS
        public string docVenta = "";
        public string paciente = "";
        public string edad = "";
        public string especialidad = "";
        public string medico = "";
        public string fechaAtencion = "";
        public List<Dictionary<string, string>> items;
        ReportDocument rpt = new ReportDocument();

        public frmResultado(List<Dictionary<string, string>> items, string cn, string es, string nh)
        {
            InitializeComponent();
            this.items = items;
            this.cn = cn;
            this.es = es;
            this.cn_ = cn;
            this.es_ = es;
            this.nh = nh;
            foreach (Dictionary<string, string> item in items)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["Descripcion"] });
                //
                DataGridViewCheckBoxCell col2 = new DataGridViewCheckBoxCell();
                col2.Value = true;
                dgvr.Cells.Add(col2);
                //
                dgvProductos.Rows.Add(dgvr);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvProductos.CurrentCell.RowIndex;
            this.pr = this.items[rowIndex]["Id_Producto"];
            this.rs = txtResultado.Text;
            this.cn_ = txtConclusion.Text;

            if (MessageBox.Show("Desea guardar los cambios ... ?", "Aviso al usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sql = "Update Detalles Set Pagado='R', Resultado = '" + rs + "', Conclusion = '" + cn_ + "' Where Nro_Historia = '" + nh + "' And Id_Producto = '" + pr + "'";
                Conexion.ExecuteNonQuery(sql);

                for (int i = 0; i < this.items.Count; i++)
                {
                    if (this.items[i]["Nro_Historia"] == this.nh && this.items[i]["Id_Producto"] == this.pr)
                    {
                        this.items[i]["Resultado"] = this.rs;
                        this.items[i]["Conclusion"] = this.cn_;
                        this.items[i]["Pagado"] = "R";
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
                dgvProductos.Rows.Clear();
                this.Close();
            }
        }

        private void dgvProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int rowIndex = dgvProductos.CurrentCell.RowIndex;
            int colIndex = dgvProductos.CurrentCell.ColumnIndex;
            this.items[rowIndex]["M"] = dgvProductos.Rows[rowIndex].Cells[colIndex].Value.ToString();
            this.Refresh();
        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvProductos.CurrentCell.RowIndex;

            txtResultado.Text = (this.items[rowIndex]["Pagado"] != "" ? this.items[rowIndex]["Resultado"] : "");
            txtConclusion.Text = (this.items[rowIndex]["Pagado"] != "" ? this.items[rowIndex]["Conclusion"] : "");
            btnImprimir.Enabled = (this.items[rowIndex]["Pagado"] != "" && (this.items[rowIndex]["Resultado"] + this.items[rowIndex]["Conclusion"]).Length > 0);
            cmbParticular.Enabled = btnGrabar.Enabled = (this.items[rowIndex]["Pagado"] != "P");
            if (btnGrabar.Enabled)
            {
                string pr = this.items[rowIndex]["Id_Producto"];
                cmbParticular.Items.Clear();
                cmbParticular.SelectedIndex = -1;
                this.plantillasTableAdapter.Fill(this.plantillasDS.Plantillas, this.cn_, this.es_, pr);
            }
            this.Refresh();
        }

        private void WorkerMethodRPT(object sender, WaitWindowEventArgs e)
        {
            this.cn_ = this.rs = "";

            foreach (Dictionary<string, string> item in this.items)
            {
                if (item["Nro_Historia"] == this.nh && item["M"] == "1")
                {
                    this.rs += (rs.Length > 0 ? "\n" : "") + item["Resultado"];
                    this.cn_ += (cn_.Length > 0 ? "\n" : "") + item["Conclusion"];
                    this.er += (rs.Length + cn_.Length > 0 ? item["Descripcion"] + ", " : "");
                }
            }

            string result = this.rs + "\n" + (this.cn_.Length > 0? "CONCLUSION:\n" + this.cn_: "");

            er = er.Substring(1, er.Length - 1);

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
            this.cn_ = this.cn;
            this.es_ = this.es;

            int rowIndex = dgvProductos.CurrentCell.RowIndex;
            this.pr = this.items[rowIndex]["Id_Producto"];
            this.pa = cmbParticular.SelectedValue.ToString();

            if (this.pr == "" || this.pa == "")
            {
                MessageBox.Show("Faltan datos para realizar la consulta ...", "Advertencia");
                return;
            }

            string sql = "Select tx_plant Resultado From Plantillas  Where id_cons = '" + this.cn_ + "' And id_pers = '" + this.es + "' And id_prod = '" + pr + "' And id_part = '" + pa + "'";
            Dictionary<string, string> plantilla = General.GetDictionary(sql);

            int pc = plantilla["Resultado"].IndexOf("'CONCLUSION:'");

            txtResultado.Text = plantilla["Resultado"].Substring(0, pc - 3);
            txtConclusion.Text = plantilla["Resultado"].Substring(pc + 13);
            btnGrabar.Enabled = true;
            this.Refresh();
        }
    }
}
