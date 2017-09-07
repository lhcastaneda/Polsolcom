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
        int cip = 0;
        Dictionary<string, string> product = new Dictionary<string, string> ();
        Dictionary<string, string> espec = new Dictionary<string, string>();
        List<Dictionary<string, string>> productList = new List<Dictionary<string, string>>();

        public frmProductos()
        {
            InitializeComponent();
        }

        public void capTab(int i)
        {
            //this.i = dgvProductos.CurrentCell.RowIndex;
            this.product = this.productList[i];

            txtIdProducto.Text = this.product["Id_Producto"];
            cmbConsultorio.SelectedValue = this.product["Id_Producto"].Substring(0, 6);
            txtDescripcion.Text = this.product["Descripcion"];
            txtMonto.Text = this.product["Monto"];
            cmbTipo.SelectedValue = this.product["Tipo"];
            cmbEstado.SelectedValue = this.product["Estado"];
            cmbTPEsp.SelectedValue = this.product["TPEsp"];
        }

        public void carData(bool xcr)
        {
            string io = Operativo.id_oper;
            string sql = "Select * From Productos Where SubString(Id_Producto,1,3)='" + io + "' Order By Id_Producto";
            this.product = General.GetDictionary(sql);

            if (!xcr)
            {
                string sql2 = "Select P.Descripcion As Producto,T.Descripcion As Tipo,Monto,Cast(Estado As Int)As Estado,Id_Producto " + 
                    "From Productos P Inner Join (Select Id_Tipo,Descripcion From TablaTipo Where Id_Tabla In(Select Id_Tipo " + 
                    "From TablaTipo Where LTrim(RTrim(Descripcion))='TIPO_PRODUCTO' And Id_Tabla='0'))T On P.Tipo=T.Id_Tipo " + 
                    "Where SubString(Id_Producto,1,3)='" + io + "' Order By Id_Producto";

                this.productList = General.GetDictionaryList(sql2);

                foreach (Dictionary<string, string> item in this.productList)
                {
                    DataGridViewRow dgvr = new DataGridViewRow();
                    //
                    dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["Descripcion"] });
                    //
                    dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["Tipo"] });
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
            General.setAll<TextBox, bool>(this, "Readonly", true);
            General.setAll<ComboBox, bool>(this, "Enabled", false);
            General.setAll<Button, bool>(this, "Enabled", true);

            txtCriterio.ReadOnly = false;
            txtCriterio_TextChanged(txtCriterio, new EventArgs());
            txtCriterio.Focus();
        }

        public void habilita()
        {
            dgvProductos.Enabled = false;
            txtDescripcion.ReadOnly = false;
            txtMonto.ReadOnly = false;
            txtCriterio.ReadOnly = true;

            General.setAll<ComboBox, bool>(this,"Enabled", true);
            General.setAll<Button, bool>(this, "Enabled", true);

            if (this.cip == 2)
            {
                cmbConsultorio.Enabled = false;
                btnModificar.Enabled = true;
                cmbTipo.Focus();
            }
            else
            {
                General.setAll<ComboBox, string>(this, "Text", "");
                General.setAll<Button, int>(this, "SelectedIndex", -1);
                txtMonto.Text = "0.00";
                btnNuevo.Enabled = true;
                cmbConsultorio.Enabled = true;
                cmbConsultorio.Focus();
            }
        }

        public void les()
        {
            string io = Operativo.id_oper;
            string sql = "Select * From Consultorios Where SubString(Id_Consultorio,1,3)='" + io + "' Order By 2";
            this.espec = General.GetDictionary(sql);
        }

        public void ubica(string idp, int xmd)
        {
            bool nmd = xmd == 0 ? false : true;
            this.carData(nmd);

            int i = this.productList.FindIndex(x => x["Id_Producto"] == idp);
            this.capTab(i);
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

            if (cmbConsultorio.SelectedIndex == -1 || txtDescripcion.Text.Length == 0 || cmbEstado.SelectedIndex == -1 || cmbTipo.SelectedIndex == -1 || float.Parse(txtMonto.Text) == 0f) {
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
            this.Text = "Productos del " + Operativo.mod_oper + " " + Operativo.descripcion + " ...";
            this.les();
            this.carData(false);
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

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
