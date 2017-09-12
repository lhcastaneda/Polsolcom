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

namespace Polsolcom.Forms
{
    public partial class frmProductos : Form
    {
        int i = 0;
        int j = 0;
        int cip = 0;
        List<Dictionary<string, string>> especList = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> productList = new List<Dictionary<string, string>>();

        public frmProductos()
        {
            InitializeComponent();
        }

        public void capTab()
        {
            txtIdProducto.Text = this.productList[this.j]["Id_Producto"];
            cmbConsultorio.SelectedValue = this.productList[this.j]["Id_Producto"].Substring(0, 6);
            txtDescripcion.Text = this.productList[this.j]["Descripcion"];
            nudMonto.Value = decimal.Parse(this.productList[this.j]["Monto"]);
            cmbTipo.SelectedValue = this.productList[this.j]["Tipo"];
            cmbEstado.SelectedValue = this.productList[this.j]["Estado"];
            cmbTPEsp.SelectedValue = this.productList[this.j]["TPEsp"];
        }

        public void carData()
        {
            string io = Operativo.id_oper;

            string sql = "Select P.Id_Producto, P.Descripcion, Left(P.Id_Producto, 6) as Consultorio, CAST(P.Monto AS DECIMAL(10,2)) as Monto, P.Tipo, P.Estado, P.TPEsp, T.Descripcion As DescripcionTipo " +
                "From Productos P Inner Join (Select Id_Tipo,Descripcion From TablaTipo Where Id_Tabla In(Select Id_Tipo " +
                "From TablaTipo Where LTrim(RTrim(Descripcion))='TIPO_PRODUCTO' And Id_Tabla='0'))T On P.Tipo=T.Id_Tipo " +
                "Where SubString(Id_Producto,1,3)='" + io + "' Order By Id_Producto";

            this.productList = General.GetDictionaryList(sql);

            this.fillDataGridView();
        }

        public void fillDataGridView()
        {
            dgvProductos.Rows.Clear();

            foreach (Dictionary<string, string> item in this.productList)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                //
                dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["Descripcion"] });
                //
                dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["DescripcionTipo"] });
                //
                dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["Monto"] });
                //
                DataGridViewCheckBoxCell chkCell = new DataGridViewCheckBoxCell();
                chkCell.Value = (item["Estado"] == "1");
                dgvr.Cells.Add(chkCell);
                //
                dgvProductos.Rows.Add(dgvr);
            }
        }

        /*private void LlenarTabla()
        {
            foreach (var producto in ProductsList)
            {                
                dgvProductos.Rows.Add(producto.Descripcion, producto.Tipo, producto.Monto, cEstat.ThreeState = producto.Estado);
            }
        }*/

        public void deshabilita()
        {
            dgvProductos.Enabled = true;
            General.setAll<TextBox, bool>(this, "Enabled", false);
            General.setAll<NumericUpDown, bool>(this, "Enabled", false);
            General.setAll<ComboBox, bool>(this, "Enabled", false);
            General.setAll<Button, bool>(this, "Enabled", true);

            txtCriterio.Enabled = true;
            txtCriterio_TextChanged(txtCriterio, new EventArgs());
            txtCriterio.Focus();
        }

        public void habilita()
        {
            dgvProductos.Enabled = false;
            txtDescripcion.Enabled = true;
            nudMonto.Enabled = true;
            txtCriterio.Enabled = false;
            General.setAll<ComboBox, bool>(this,"Enabled", true);
            General.setAll<Button, bool>(this, "Enabled", false);

            if (this.cip == 2)
            {
                cmbConsultorio.Enabled = false;
                btnModificar.Enabled = true;
                cmbTipo.Focus();
            }
            else
            {
                General.setAll<TextBox, string>(this, "Text", "");
                General.setAll<ComboBox, int>(this, "SelectedIndex", -1);
                nudMonto.Value = 0.00M;
                btnNuevo.Enabled = true;
                cmbConsultorio.Enabled = true;
                cmbConsultorio.Focus();
            }
        }

        public void les()
        {
            string io = Operativo.id_oper;
            string sql = "Select * From Consultorios Where SubString(Id_Consultorio,1,3)='" + io + "' Order By 2";
            this.especList = General.GetDictionaryList(sql);

            General.FillListView(lstCons, this.especList, new[] { "Descripcion" });
        }

        public void ubica(string idp)
        {
            this.carData();

            this.j = this.productList.FindIndex(x => x["Id_Producto"] == idp);
            this.capTab();
        }

        public bool vag()
        {
            string ie = cmbConsultorio.SelectedIndex == -1 ? "" : cmbConsultorio.SelectedValue.ToString();
            string ip = txtIdProducto.Text;
            string ds = txtDescripcion.Text;

            string sql = "Select Count(*)As C From productos Where LTrim(RTrim(descripcion))='" + ds + "' ";
            sql += (this.cip == 2 ? "And LTrim(RTrim(id_producto))<>'" + ip + "' " : "");
            sql += "And SubString(id_producto,1,6)='" + ie + "'";

            int c = Conexion.ExecuteScalar<int>(sql);

            if (cmbConsultorio.SelectedIndex == -1 || txtDescripcion.Text.Length == 0 || cmbEstado.SelectedIndex == -1 || cmbTipo.SelectedIndex == -1 || nudMonto.Value == 0.00M) {
                MessageBox.Show("Faltan datos para guardar ...", "Advertencia");
                return false;
            }

            if (c > 0)
            {
                MessageBox.Show("Producto ya existe en esta especialidad ...", "Advertencia");
                return false;
            }

            return true;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            this.consultoriosTableAdapter.Fill(this.consultoriosDS.Consultorios, Operativo.id_oper);
            // TODO: This line of code loads data into the 'tablaTipoDS.TipoSubProducto' table. You can move, or remove it, as needed.
            this.tipoSubProductoTableAdapter.Fill(this.tablaTipoDS.TipoSubProducto);
            // TODO: This line of code loads data into the 'tablaTipoDS.TipoProducto' table. You can move, or remove it, as needed.
            this.tipoProductoTableAdapter.Fill(this.tablaTipoDS.TipoProducto);
            // TODO: This line of code loads data into the 'tablaTipoDS.EstadoRegistro' table. You can move, or remove it, as needed.
            this.estadoRegistroTableAdapter.Fill(this.tablaTipoDS.EstadoRegistro);
            this.Text = "Productos del " + Operativo.mod_oper + " " + Operativo.descripcion + " ...";
            this.les();
            this.carData();
            btnInicio_Click(btnInicio, new EventArgs());
        }

        private void frmProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            this.i = General.GetSelectedIndex(lstCons);
            string idc = chkCons.Checked ? "" : this.especList[this.i]["Id_Consultorio"];
            string des = txtCriterio.Text;

            string sql = "Select P.Id_Producto, P.Descripcion, Left(P.Id_Producto, 6) as Consultorio, CAST(P.Monto AS DECIMAL(10,2)) as Monto, P.Tipo, P.Estado, P.TPEsp, T.Descripcion As DescripcionTipo " +
                "From Productos P Inner Join (Select Id_Tipo,Descripcion From TablaTipo Where Id_Tabla In(Select Id_Tipo " + 
                "From TablaTipo Where Descripcion='TIPO_PRODUCTO' And Id_Tabla='0'))T On P.Tipo=T.Id_Tipo Where Left" +
                "(Id_Producto,3)='" + Operativo.id_oper + "' And P.Descripcion Like '%" + des +"%' And Left(Id_Producto,6) Like '%" + idc + "%' " + 
                "Order By P.Descripcion";

            this.productList = General.GetDictionaryList(sql);

            this.fillDataGridView();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "&Nuevo")
            {
                this.les();
                btnNuevo.Text = "&Grabar";
                this.cip = 1;
                this.habilita();
                cmbEstado.SelectedValue = "1";
                cmbTPEsp.SelectedValue = "N";
            }
            else
            {
                if (MessageBox.Show("Desea guardar cambios?", "Mensaje al Usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (!this.vag())
                    {
                        return;
                    }

                    string np = txtDescripcion.Text;
                    string pr = nudMonto.Value.ToString();
                    string ie = cmbConsultorio.SelectedIndex == -1 ? "" : cmbConsultorio.SelectedValue.ToString();
                    string tp = cmbTipo.SelectedIndex == -1 ? "" : cmbTipo.SelectedValue.ToString();
                    string st = cmbEstado.SelectedIndex == -1 ? "" : cmbEstado.SelectedValue.ToString();
                    string te = cmbTPEsp.SelectedIndex == -1 ? "" : cmbTPEsp.SelectedValue.ToString();
                    string iu = Usuario.id_us;

                    string sql = "Exec AddProducto '" + np + "', '" + pr + "', '" + ie + "','" + tp + "', '" + st + "', '" + te + "', 'N', '" + iu + "'";

                    Dictionary<string, string> idp = General.GetDictionary(sql);

                    txtIdProducto.Text = idp["Id_Producto"];

                    General.chgst("Productos", txtIdProducto.Text, st);
                }
                else {
                    btnAnterior_Click(btnAnterior, new EventArgs());
                }

                this.ubica(txtIdProducto.Text);
                this.cip = 0;
                btnNuevo.Text = "&Nuevo";
                this.deshabilita();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                if (btnModificar.Text == "&Modificar")
                {
                    this.les();
                    btnModificar.Text = "&Grabar";
                    this.cip = 2;
                    this.habilita();
                }
                else
                {
                    if (MessageBox.Show("Desea guardar cambios?", "Mensaje al Usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (!this.vag())
                        {
                            return;
                        }

                        if (this.cip > 0)
                        {
                            string np = txtDescripcion.Text;
                            string pr = nudMonto.Value.ToString();
                            string ie = cmbConsultorio.SelectedIndex == -1 ? "" : cmbConsultorio.SelectedValue.ToString();
                            string tp = cmbTipo.SelectedIndex == -1 ? "" : cmbTipo.SelectedValue.ToString();
                            string st = cmbEstado.SelectedIndex == -1 ? "" : cmbEstado.SelectedValue.ToString();
                            string te = cmbTPEsp.SelectedIndex == -1 ? "" : cmbTPEsp.SelectedValue.ToString();
                            string ip = txtIdProducto.Text;
                            string iu = Usuario.id_us;

                            string sql = "Exec AddProducto '" + np + "', '" + pr + "', '" + ie + "','" + tp + "', '" + st + "', '" + te + "', '" + ip + "', '" + iu + "'";

                            Conexion.ExecuteNonQuery(sql);

                            General.chgst("Productos", ip, st);

                            this.cip = 2;
                        }
                        else
                        {
                            this.cip = 2;
                        }
                    }

                    this.ubica(txtIdProducto.Text);
                    btnModificar.Text = "&Modificar";
                    this.deshabilita();
                    this.cip = 0;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ip = txtIdProducto.Text;

            if (dgvProductos.Rows.Count > 0)
            {
                string sql = "Select Count(*)As C From detalles Where LTrim(RTrim(Id_Producto))='" + ip + "'";
                int c = Conexion.ExecuteScalar<int>(sql);

                if (c > 0)
                {
                    MessageBox.Show("Producto no se puede eliminar ... ya fue vendido", "Advertencia");
                    return;
                }

                if (MessageBox.Show("Esta seguro de eliminar registro?", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sql2 = "Delete From Productos Where LTrim(RTrim(Id_Producto))='" + ip + "'";
                    int affected = Conexion.ExecuteNonQuery(sql2);

                    this.carData();

                    txtCriterio_TextChanged(txtCriterio, new EventArgs());
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                this.j = 0;
                btnInicio.Enabled = false;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;

            }

            this.capTab();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                if (this.j > 0)
                {
                    this.j--;
                    btnAnterior.Enabled = true;
                    btnInicio.Enabled = true;
                    btnSiguiente.Enabled = true;
                    btnUltimo.Enabled = true;

                    if (this.j == 0)
                    {
                        btnAnterior.Enabled = false;
                        btnInicio.Enabled = false;
                        btnSiguiente.Enabled = true;
                        btnUltimo.Enabled = true;
                    }
                }
            }

            this.capTab();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                if (this.j < dgvProductos.Rows.Count - 1)
                {
                    this.j++;
                    btnSiguiente.Enabled = true;
                    btnInicio.Enabled = true;
                    btnAnterior.Enabled = true;
                    btnUltimo.Enabled = true;

                    if (this.j == dgvProductos.Rows.Count - 1)
                    {
                        btnSiguiente.Enabled = false;
                        btnInicio.Enabled = true;
                        btnAnterior.Enabled = true;
                        btnUltimo.Enabled = false;
                    }
                }
            }

            this.capTab();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                this.j = dgvProductos.Rows.Count - 1;
                btnUltimo.Enabled = false;
                btnInicio.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = false;

            }

            this.capTab();
        }

        private void lstConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCriterio_TextChanged(txtCriterio, new EventArgs());
        }

        private void chkCons_CheckedChanged(object sender, EventArgs e)
        {
            lstCons.Enabled = !lstCons.Enabled;
            //.lstcons.selected(1) = .T.
            txtCriterio_TextChanged(txtCriterio, new EventArgs());
        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.j = dgvProductos.CurrentCell.RowIndex;
            this.capTab();
        }


        private void dgvProductos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            this.j = dgvProductos.CurrentCell.RowIndex;
            int col = dgvProductos.CurrentCell.ColumnIndex;

            if (col == 3)
            {
                string ip = this.productList[this.j]["Id_Producto"];
                string st = ((bool)dgvProductos.CurrentCell.Value) ? "1" : "0";

                General.chgst("Productos", ip, st);

                this.productList[this.j]["Estado"] = st;

                this.capTab();

                cEstat.ReadOnly = int.Parse(st) < 2 ? false : true;
            }
        }
    }
}
