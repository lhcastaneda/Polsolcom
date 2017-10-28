using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
    public partial class frmProduccionMedicos : Form
    {
        int correlativo = 0;
        bool editMode = false;

        public frmProduccionMedicos()
        {
            InitializeComponent();
        }

        public void filtraHoy()
        {
            string nhoy = DateTime.Today.ToShortDateString();

            txtFechaActual.Text = nhoy;
            txtFechaActual.Enabled = false;
            txtObservacion.Text = "";
            txtFecha.Text = General.emptyDate;

            string sql = "Select PM.Correlativo, PM.Fecha_Parte, PM.Fecha_Sys, PM.Usuario,SubString(M.TNCol,2,7) CMP," +
                "(M.Ape_Paterno+' '+M.Ape_Materno+' '+M.Nombres)Medico,PM.Id_Consultorio,C.Descripcion Consultorio," +
                "PM.Id_Producto,P.Descripcion Producto,PM.Cantidad,PM.Precio,PM.Monto,PM.Turno,PM.Observa " + 
                "From ProdMedicos PM Inner Join Consultorios C On PM.Id_Consultorio=C.Id_Consultorio " + 
                "Inner Join Personal M On PM.CMP=M.Id_Personal Inner Join Productos P On PM.Id_Producto=P.Id_Producto " + 
                "Where Cast(Convert(Char(10),Fecha_Sys,103)As Datetime) Between '" + nhoy + "' And '" + nhoy + "' " + 
                "Order By Cast(PM.Correlativo As Int)";
            List<Dictionary<string, string>> items = General.GetDictionaryList(sql);
            General.Fill(grdProduccion, items);
            txtFecha.Focus();
        }

        private void frmProduccionMedicos_Load(object sender, EventArgs e)
        {
            this.turnoTableAdapter.Fill(this.tablaTipoDS.Turno);
            cmbTurno.SelectedIndex = -1;
            this.medicosProduccionTableAdapter.Fill(this.medicosDS.MedicosProduccion);
            cmbMedico.SelectedIndex = -1;
            especialidadTableAdapter.Fill(consultoriosDS.Especialidad, Operativo.id_oper);
            cmbEspecialidad.SelectedIndex = -1;
            allProductsTableAdapter.Fill(productosDS.AllProducts, "XXX");
            cmbProducto.SelectedIndex = -1;

            this.filtraHoy();
        }

        private void txtFecha_Validated(object sender, EventArgs e)
        {
           
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text != General.emptyDate && rb0.Checked)
            {
                General.vFecha(DateTime.Parse(txtFecha.Text), txtFecha);
            }
        }

        private void txtCMP_Validated(object sender, EventArgs e)
        {

        }

        private void txtCMP_Leave(object sender, EventArgs e)
        {
            if (this.DialogResult != DialogResult.Cancel && txtCMP.Text.Length > 0)
            {
                string xcmp = txtCMP.Text;

                Dictionary<string, string> medico = General.GetDictionaryList(cmbMedico).Find(x => x["CMP"] == xcmp);

                if (medico == null)
                {
                    MessageBox.Show("Numero de CMP no se hallo, verifique", "Aviso");
                    return;
                }
                else
                {
                    if (rb0.Checked)
                    {
                        cmbEspecialidad.SelectedValue = medico["Id_Esp"];
                    }
                }
            }
        }

        private void cmbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (rb0.Checked && cmbEspecialidad.SelectedIndex != -1)
            {
                string xid = cmbEspecialidad.SelectedValue.ToString();
                productosDS.AllProducts.Clear();
                allProductsTableAdapter.Fill(productosDS.AllProducts, xid);
                cmbProducto.SelectedIndex = -1;
            }
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (rb0.Checked && cmbProducto.SelectedIndex != -1 && this.editMode == false)
            {
                Dictionary<string, string> producto = General.GetSelectedDictionary(cmbProducto);
                txtPrecio.Text = decimal.Parse(producto["Monto"]).ToString("N2");
                txtCantidad.Text = "1";
                txtMonto.Text = decimal.Parse(producto["Monto"]).ToString("N2");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmProduccionMedicos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSalir_Click(btnSalir, new EventArgs());
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtFecha.Text == General.emptyDate || txtCMP.Text.Length == 0 || cmbEspecialidad.SelectedIndex == -1 || cmbProducto.SelectedIndex == -1 || cmbTurno.SelectedIndex == -1 || int.Parse(txtCantidad.Text) == 0 || decimal.Parse(txtPrecio.Text) < 0 || decimal.Parse(txtMonto.Text) < 0)
            {
                MessageBox.Show("Faltan datos", "Aviso");
                return;
            }

            string fsys = DateTime.Now.ToShortDateString();
            string xfa = txtFecha.Text;
            string xus = Usuario.id_us;
            string xusuario = Usuario.usuario;
            string xcm = cmbMedico.SelectedValue.ToString();
            string xmedico = cmbMedico.SelectedText;
            string xic = cmbEspecialidad.SelectedValue.ToString();
            string xconsultorio = cmbEspecialidad.SelectedText;
            string xip = cmbProducto.SelectedValue.ToString();
            string xproducto = cmbProducto.SelectedText;
            string xpr = txtPrecio.Text;
            string xcn = txtCantidad.Text;
            string xmn = txtMonto.Text;
            string xtr = cmbTurno.SelectedValue.ToString();
            string xob = txtObservacion.Text;
            //

            string sql = "";
            if (!this.editMode)
            {
                int xcr = Conexion.ExecuteScalar<int>("Select ISNULL(Max(Cast(Correlativo As Int)), 0) Maximo From ProdMedicos") + 1;

                grdProduccion.Rows.Add(new string[] { xcr.ToString(), xfa, fsys, xusuario, xcm, xmedico, xic, xconsultorio, xip, xproducto, xcn, xpr, xmn, xtr, xob});
                sql = "Insert Into Prodmedicos Values ('" + xcr + "','" + xfa + "',GetDate(),'" + xus + "','" + xcm + "','" + xic + "','" + xip + "','" + xpr + "','" + xcn + "','" + xmn + "','" + xtr + "','" + xob + "','')";
                Conexion.ExecuteNonQuery(sql);
                MessageBox.Show("Operación ejecutada con éxito", "Éxito");
            }
            else
            {
                if (MessageBox.Show("Desea guardar cambios ... ?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int xcr = this.correlativo;

                    int i = grdProduccion.CurrentCell.RowIndex;

                    grdProduccion.Rows[i].Cells["pCorrelativo"].Value = xcr;
                    grdProduccion.Rows[i].Cells["pFecha"].Value = xfa;
                    grdProduccion.Rows[i].Cells["pFechaSys"].Value = fsys;
                    grdProduccion.Rows[i].Cells["pUsuario"].Value = xusuario;
                    grdProduccion.Rows[i].Cells["pCMP"].Value = xcm;
                    grdProduccion.Rows[i].Cells["pMedico"].Value = xmedico;
                    grdProduccion.Rows[i].Cells["pIdConsultorio"].Value = xic;
                    grdProduccion.Rows[i].Cells["pConsultorio"].Value = xconsultorio;
                    grdProduccion.Rows[i].Cells["pIdProducto"].Value = xip;
                    grdProduccion.Rows[i].Cells["pProducto"].Value = xproducto;
                    grdProduccion.Rows[i].Cells["pCantidad"].Value = xcn;
                    grdProduccion.Rows[i].Cells["pPrecio"].Value = xpr;
                    grdProduccion.Rows[i].Cells["pMonto"].Value = xmn;
                    grdProduccion.Rows[i].Cells["pTurno"].Value = xtr;
                    grdProduccion.Rows[i].Cells["pObservacion"].Value = xob;


                    sql = "Update Prodmedicos Set Fecha_parte='" + xfa + "',Usuario='" + xus + "',Cmp='" + xcm + "',Id_Consultorio='" + xic + "'," + "Id_Producto='" + xip + "',Precio='" + xpr + "',Cantidad='" + xcn + "',Monto='" + xmn + "',Turno='" + xtr + "',Observa='" + xob + "' " + "Where Correlativo='" + xcr + "'";
                    Conexion.ExecuteNonQuery(sql);
                    MessageBox.Show("Operación ejecutada con éxito", "Éxito");
                }

                grdProduccion.Enabled = true;
                btnEdit.Enabled = true;
                btnBorrar.Enabled = true;
                this.editMode = false;
            }

            txtObservacion.Text = "";
            txtCMP.Focus();

       
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int i = grdProduccion.CurrentCell.RowIndex;
            if (grdProduccion.Rows.Count > 0 || i > -1)
            {
                int wcor = this.correlativo;
                string sql = "Delete From ProdMedicos Where Correlativo=" + wcor.ToString();
                if (MessageBox.Show("Seguro de eliminar la fila actual?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                Conexion.ExecuteNonQuery(sql);
                grdProduccion.Rows.RemoveAt(i);
            }
            else
            {
                MessageBox.Show("Seleccione un registro primero", "Aviso");
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(grdProduccion, false);

            if (grdProduccion.Rows.Count > 0 || i > -1)
            {
                this.correlativo = int.Parse(grdProduccion.Rows[i].Cells["pCorrelativo"].Value.ToString());
                txtFecha.Text = grdProduccion.Rows[i].Cells["pFecha"].Value.ToString();
                txtCMP.Text = grdProduccion.Rows[i].Cells["pCMP"].Value.ToString();
                cmbMedico.SelectedValue = grdProduccion.Rows[i].Cells["pCMP"].Value.ToString();
                cmbEspecialidad.SelectedValue = grdProduccion.Rows[i].Cells["pIdConsultorio"].Value.ToString();
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
                cmbProducto.SelectedValue = grdProduccion.Rows[i].Cells["pIdProducto"].Value.ToString();
                txtCantidad.Text = grdProduccion.Rows[i].Cells["pCantidad"].Value.ToString();
                txtPrecio.Text = decimal.Parse(grdProduccion.Rows[i].Cells["pPrecio"].Value.ToString()).ToString("N2");
                txtMonto.Text = decimal.Parse(grdProduccion.Rows[i].Cells["pMonto"].Value.ToString()).ToString("N2");
                txtObservacion.Text = grdProduccion.Rows[i].Cells["pObservacion"].Value.ToString();
                cmbTurno.SelectedValue = grdProduccion.Rows[i].Cells["pTurno"].Value.ToString();

                grdProduccion.Enabled = false;
                btnEdit.Enabled = false;
                btnBorrar.Enabled = false;
                this.editMode = true;
            }
            else
            {
                MessageBox.Show("Seleccione un registro primero", "Aviso");
                grdProduccion.Focus();
            }
        }

        private void cmbMedico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (rb0.Checked && cmbMedico.SelectedIndex != -1)
            {
                Dictionary<string, string> medico = General.GetSelectedDictionary(cmbMedico);
                txtCMP.Text = medico["CMP"];
                string wcon = medico["Id_Esp"];
                cmbEspecialidad.SelectedValue = medico["Id_Esp"];
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
            }
        }

        private void rb0_CheckedChanged(object sender, EventArgs e)
        {
            if (rb0.Checked)
            {
                btnEdit.Enabled = true;
                btnGrabar.Enabled = true;
                btnBorrar.Enabled = true;
                btnFiltrar.Enabled = false;
                this.filtraHoy();
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                btnEdit.Enabled = false;
                btnGrabar.Enabled = false;
                btnFiltrar.Enabled = true;
                General.setAll<TextBox, string>(this, "Text", "");
                General.setAll<MaskedTextBox, string>(this, "Text", "");
                General.setAll<ComboBox, int>(this, "SelectedIndex", -1);
                txtFechaActual.Enabled = true;
                txtFechaActual.Text = DateTime.Today.ToShortDateString();
                txtCantidad.Text = "0";
                txtMonto.Text = "0.00";
                txtPrecio.Text = "0.00";
                txtFechaActual.Focus();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string fa = txtFechaActual.Text == General.emptyDate ? "" : txtFechaActual.Text + "%";
            string fp = txtFecha.Text == General.emptyDate ? "" : txtFecha.Text + "%";
            string cm = cmbMedico.SelectedIndex == -1 ? "" : cmbMedico.SelectedValue.ToString() + "%";
            string ic = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString() + "%";
            string ip = cmbProducto.SelectedIndex == -1 ? "" : cmbProducto.SelectedValue.ToString() + "%";
            string ct = txtCantidad.Text.Length == 0 ? "" : txtCantidad.Text + "%";
            string pr = txtPrecio.Text.Length == 0 ? "" : txtPrecio.Text + "%";
            string mt = txtMonto.Text.Length == 0 ? "" : txtMonto.Text + "%";
            string ob = txtObservacion.Text + "%";

            string sql = "Select PM.Correlativo,PM.Fecha_parte,PM.Fecha_sys,PM.Usuario,SubString(M.TNCol,2,7) CMP," +
"(M.Ape_Paterno+' '+M.Ape_Materno+' '+M.Nombres)Medico,PM.Id_Consultorio,C.Descripcion Consultorio," +
"PM.Id_Producto,P.Descripcion Producto,PM.Precio,PM.Cantidad,PM.Monto,PM.Turno,PM.Observa " +
"From ProdMedicos PM Inner Join Consultorios C On PM.Id_Consultorio=C.Id_Consultorio " +
"Inner Join Personal M On PM.CMP=M.Id_Personal Inner Join Productos P On PM.Id_Producto=P.Id_Producto " +
"Where Convert(Char(10),Fecha_Sys,103) Like '" + fa + "' And Convert(Char(10),Fecha_Parte,103) Like '" + fp + "' " +
"And PM.CMP Like '" + cm + "' And PM.Id_Consultorio Like '" + ic + "' And PM.Id_Producto Like '" + ip + "' " +
"Order By PM.Correlativo";

            List<Dictionary<string, string>> items = General.GetDictionaryList(sql);

            General.Fill(grdProduccion, items);
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            int x = 0;
            if (!int.TryParse(txtCantidad.Text, out x))
            {
                MessageBox.Show("Cantidad inválida", "Advertencia");
                txtCantidad.Focus();
                return;
            }

            if (rb0.Checked)
            {
                txtMonto.Text = (int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecio.Text)).ToString("N2");
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            decimal x = 0;
            if (!decimal.TryParse(txtPrecio.Text, out x))
            {
                MessageBox.Show("Cantidad inválida", "Advertencia");
                txtPrecio.Focus();
                return;
            }

            if (rb0.Checked)
            {
                txtMonto.Text = (int.Parse(txtCantidad.Text.Length > 0 ? txtCantidad.Text : "0") * decimal.Parse(txtPrecio.Text)).ToString("N2");
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            decimal x = 0;
            if (!decimal.TryParse(txtMonto.Text, out x))
            {
                MessageBox.Show("Cantidad inválida", "Advertencia");
                txtMonto.Focus();
            }
        }
    }
}
