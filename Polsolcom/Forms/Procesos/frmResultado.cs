using Polsolcom.Dominio.Connection;
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
        public string cn;
        public string es;
        public string nh;
        public List<Dictionary<string, string>> items;

        public frmResultado(List<Dictionary<string, string>> items, string cn, string es, string nh)
        {
            InitializeComponent();
            this.items = items;
            this.cn = cn;
            this.es = es;
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
            string pr = this.items[rowIndex]["id_producto"];
            string rs = txtResultado.Text;
            string cn = txtResultado.Text;

            if (MessageBox.Show("Desea guardar los cambios ... ?", "Aviso al usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sql = "Update Detalles Set Pagado='R', Resultado = '" + rs + "', Conclusion = '" + cn + "' Where Nro_Historia = '" + nh + "' And Id_Producto = '" + pr + "'";
                Conexion.ExecuteNonQuery(sql);

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
            this.items[rowIndex]["m"] = dgvProductos.Rows[rowIndex].Cells[colIndex].Value.ToString();
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
                this.plantillasTableAdapter.Fill(this.plantillasDS.Plantillas, this.cn, this.es, pr);
            }
            this.Refresh();
        }
    }
}
