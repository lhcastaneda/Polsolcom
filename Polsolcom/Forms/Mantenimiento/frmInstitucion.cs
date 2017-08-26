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
    public partial class frmInstitucion : Form
    {
        bool lnew = false;
        int index = 0;
        List<Dictionary<string, string>> InstitucionList = new List<Dictionary<string, string>>();

        public frmInstitucion()
        {
            InitializeComponent();
        }

        public void busins(string sins, string sdoc, string lest, string sopc)
        {
            string sql = "Select * From Institucion Where Nom_Raz_Soc Like '%" + sins + "%' And RUC Like '" + sdoc + "%' And Estado Like '" + lest + "%' Order By Nom_Raz_soc";
            this.InstitucionList = General.GetDictionaryList(sql);

            General.FillListView(lstInstitucion, this.InstitucionList, new[] { "Nom_Raz_Soc", "RUC" });

            if (sopc.Length == 0)
            {
                this.index = 0;
            }
            else
            {
                this.index = this.InstitucionList.FindIndex(x => x["RUC"] == sopc);
            }

            if (this.InstitucionList.Count > 0)
            {
                lstInstitucion.Select();
                lstInstitucion.EnsureVisible(this.index);
                lstInstitucion.Items[this.index].Selected = true;
                lstInstitucion.Items[this.index].Focused = true;
                lstInstitucion.Items[this.index].EnsureVisible();
                lstInstitucion_SelectedIndexChanged(lstInstitucion, new EventArgs());
                btnEditar.Enabled = true;
            }
            else {
                this.clears();
                btnEditar.Enabled = false;
            }

            this.Refresh();
        }

        public void clears()
        {
            this.provinciasTableAdapter.Fill(this.provinciasDS.Provincias, "");
            this.distritoTableAdapter.Fill(this.distritoDS.Distrito, "");

            General.setAll<TextBox, string>(cntInstitucion, "Text", "");
            General.setAll<MaskedTextBox, string>(cntInstitucion, "Text", "");
            General.setAll<ComboBox, int>(cntInstitucion, "SelectedIndex", -1);
            General.setAll<CheckBox, bool>(cntInstitucion, "Checked", false);
            General.setAll<ComboBox, int>(cntUbigeo, "SelectedIndex", -1);
            this.Refresh();
        }

        public void habil(bool lest)
        {
            General.setAll<TextBox, bool>(cntInstitucion, "Enabled", lest);
            General.setAll<MaskedTextBox, bool>(cntInstitucion, "Enabled", lest);
            General.setAll<ComboBox, bool>(cntInstitucion, "Enabled", lest);
            General.setAll<CheckBox, bool>(cntInstitucion, "Enabled", lest);
            General.setAll<Button, bool>(this, "Enabled", !lest);
            General.setAll<ComboBox, bool>(cntUbigeo, "Enabled", lest);

            txtBuscar.Enabled = txtDoc.Enabled = cmbEstado.Enabled = lstInstitucion.Enabled = !lest;
            btnCancelar.Enabled = btnGrabar.Enabled = lest;
            txtCreation.Enabled = txtLastUpdate.Enabled = txtIdInst.Enabled = false;

            this.Refresh();
        }

        public bool validar()
        {
            if (cmbTIns.SelectedIndex == -1 || txtNomRazSocial.Text.Length == 0 || txtRuc.Text.Length == 0)
            {
                MessageBox.Show("Faltan datos para grabar el registro ...", "Advertencia");
                return false;
            }

            if (cmbTIns.SelectedValue.ToString() == "T" && cmbModTrans.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione modalidad de transporte ...", "Advertencia");
                return false;
            }

            if (cmbRepresentante.SelectedIndex != -1 && txtRepresentante.Text.Length > 0)
            {
                MessageBox.Show("Verifique representante ... solo debe ingresarse una vez ...", "Advertencia");
                return false;
            }

            string xrc = txtRuc.Text;
            if (xrc.Length < 11)
            {
                MessageBox.Show("Cantidad de digitos en RUC incorrecta ...", "Advertencia");
                txtRuc.Focus();
                return false;
            }

            if (this.lnew && !chkStatus.Checked)
            {
                MessageBox.Show("Estado del nuevo registro debe ser activo ...", "Advertencia");
                chkStatus.Focus();
                return false;
            }

            string sql = "Select TInst + Id_Inst Id_Inst, Nom_Raz_Soc, Ruc From Institucion Where RUC = '" + xrc + "'";
            Dictionary<string, string> xruc = General.GetDictionary(sql);

            string xrz = (xruc == null ? "" : xruc["Nom_Raz_Soc"]);
            string xid = (xruc == null ? "" : xruc["Id_Inst"]);
            xrc = (xruc == null ? "" : xruc["Ruc"]);

            if (xrz.Length > 0)
            {
                string xmsg = "R.U.C. (" + xrc + ") pertenece a (" + xrz + "),\nverifique por favor ...";

                if (this.lnew == false)
                {
                    if (xid != cmbTIns.SelectedValue.ToString() + txtIdInst.Text)
                    {
                        MessageBox.Show(xmsg, "Advertencia");
                        txtRuc.Focus();
                        return false;
                    }
                }
                else {
                    MessageBox.Show(xmsg, "Advertencia");
                    txtRuc.Focus();
                    return false;
                }
            }

            xrz = txtNomRazSocial.Text;
            string sql2 = "Select TInst + Id_Inst Id_Inst, Nom_Raz_Soc, Ruc From Institucion Where Nom_Raz_Soc = '" + xrz + "'";
            Dictionary<string, string> xins = General.GetDictionary(sql2);

            xrz = (xruc == null ? "" : xins["Nom_Raz_Soc"]);
            xid = (xruc == null ? "" : xins["Id_Inst"]);
            xrc = (xruc == null ? "" : xins["Ruc"]);

            if (xrz.Length > 0)
            {
                string xmsg = "(" + xrz + ") ya esta registrado con Id (" + xid + ") \ny RUC " + xrc + ", verifique por favor ...";

                if (lnew == false)
                {
                    if (xid != cmbTIns.SelectedValue.ToString() + txtIdInst.Text)
                    {
                        MessageBox.Show(xmsg, "Advertencia");
                        txtNomRazSocial.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(xmsg, "Advertencia");
                    txtNomRazSocial.Focus();
                    return false;
                }
            }

            this.Refresh();

            return true;
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            txtBuscar_TextChanged(txtBuscar, new EventArgs());
        }

        private void frmInstitucion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lnew = true;
            this.habil(true);
            this.clears();
            chkStatus.Checked = true;
            cmbTIns.Focus();
            this.Refresh();
        }

        private void frmInstitucion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estadosDS.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.estadosDS.Estados);
            // TODO: This line of code loads data into the 'tipoInstitucionDS.TipoInstitucion' table. You can move, or remove it, as needed.
            this.tipoInstitucionTableAdapter.Fill(this.tipoInstitucionDS.TipoInstitucion);
            // TODO: This line of code loads data into the 'cargoDS.Cargos' table. You can move, or remove it, as needed.
            this.cargosTableAdapter.Fill(this.cargoDS.Cargos);
            // TODO: This line of code loads data into the 'departamentosDS.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.departamentosDS.Departamentos);
            // TODO: This line of code loads data into the 'representanteDS.Representante' table. You can move, or remove it, as needed.
            this.representanteTableAdapter.Fill(this.representanteDS.Representante);
            // TODO: This line of code loads data into the 'modTransDS.ModTrans' table. You can move, or remove it, as needed.
            this.modTransTableAdapter.Fill(this.modTransDS.ModTrans);

            cmbEstado.SelectedIndex = -1;
            txtBuscar_TextChanged(txtBuscar, new EventArgs());
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.SelectedIndex != -1 ? cmbEstado.SelectedValue.ToString() : "";
            this.busins(txtBuscar.Text, txtDoc.Text, estado, "");
        }

        private void lstInstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index = General.GetSelectedIndex(lstInstitucion);

            cmbTIns.SelectedValue = this.InstitucionList[this.index]["TInst"];
            txtIdInst.Text = this.InstitucionList[this.index]["Id_Inst"];
            txtNomRazSocial.Text = this.InstitucionList[this.index]["Nom_Raz_Soc"];
            txtRuc.Text = this.InstitucionList[this.index]["RUC"];
            cmbDepartamento.SelectedValue = this.InstitucionList[this.index]["Id_Distrito"].Substring(0, 2);
            cmbDepartamento_SelectionChangeCommitted(cmbDepartamento, new EventArgs());
            cmbProvincia.SelectedValue = this.InstitucionList[this.index]["Id_Distrito"].Substring(0, 4);
            cmbProvincia_SelectionChangeCommitted(cmbProvincia, new EventArgs());
            cmbDistrito.SelectedValue = this.InstitucionList[this.index]["Id_Distrito"];
            txtDireccion.Text = this.InstitucionList[this.index]["Direccion"];
            txtTelefono.Text = this.InstitucionList[this.index]["Telefono"];
            txtCelular.Text = this.InstitucionList[this.index]["Celular"];
            cmbRepresentante.SelectedValue = this.InstitucionList[this.index]["Id_Represent"];
            txtRepresentante.Text = this.InstitucionList[this.index]["Representante"];
            cmbCargo.SelectedValue = this.InstitucionList[this.index]["Id_Cargo"];
            cmbModTrans.SelectedValue = this.InstitucionList[this.index]["Mod_Trans"];
            txtEmail.Text = this.InstitucionList[this.index]["Email"];
            txtObservacion.Text = this.InstitucionList[this.index]["Observacion"];
            txtCreation.Text = General.TradUser(this.InstitucionList[this.index]["Us_Ing"]) + " - " + this.InstitucionList[this.index]["Fec_Ing"];
            txtLastUpdate.Text = General.TradUser(this.InstitucionList[this.index]["Us_Mod"]) + " - " + this.InstitucionList[this.index]["Fec_Mod"];
            chkStatus.Checked = this.InstitucionList[this.index]["Estado"] == "1";
            this.Refresh();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string nom = txtNomRazSocial.Text;
            string ruc = txtRuc.Text;
            string dis = cmbDistrito.SelectedIndex != -1 ? cmbDistrito.SelectedValue.ToString() : "";
            string drc = txtDireccion.Text;
            string fon = txtTelefono.Text;
            string cel = txtCelular.Text;
            string irp = cmbRepresentante.SelectedIndex != -1 ? cmbRepresentante.SelectedValue.ToString() : "";
            string rep = txtRepresentante.Text;
            string car = cmbCargo.SelectedIndex != -1 ? cmbCargo.SelectedValue.ToString() : "";
            string mtr = cmbModTrans.SelectedIndex != -1 ? cmbModTrans.SelectedValue.ToString() : "";
            string ema = txtEmail.Text;
            string obs = txtObservacion.Text;
            string est = chkStatus.Checked ? "1" : "0";
            string idi = cmbTIns.SelectedIndex != -1 ? cmbTIns.SelectedValue.ToString() : "";

            if (this.validar())
            {
                string sql = "";
                if (this.lnew)
                {
                    sql = "Declare @res Varchar(7) Set @res=(Select Cast(Count(Id_Inst)+1 As Varchar(7)) From Institucion Where TInst= '" + idi + "') Insert Into Institucion Values ('" + idi + "', @res, '" + nom + "', '" + ruc + "', '" + drc + "', '" + dis + "', '" + fon + "', '" + cel + "', '" + irp + "', '" + rep + "', '" + car + "', '" + mtr + "', '" + ema + "', '" + obs + "', '" + est + "', GetDate(), '" + Usuario.id_us + "', GetDate(), '" + Usuario.id_us + "')";
                }
                else
                {
                    idi = idi + txtIdInst.Text;
                    sql = "Update Institucion Set Nom_Raz_Soc = '" + nom + "', RUC = '" + ruc + "', Direccion = '" + drc + "', Id_Distrito = '" + dis + "', Telefono = '" + fon + "', Celular = '" + cel + "', Id_Represent = '" + irp + "', Representante = '" + rep + "', Id_Cargo = '" + car + "', Mod_Trans = '" + mtr + "', Email = '" + ema + "', Observacion = '" + obs + "', Estado = '" + est + "', Fec_Mod = GetDate(), Us_Mod = '" + Usuario.id_us + "' Where TInst + Id_Inst = '" + idi + "'";
                }

                Conexion.ExecuteNonQuery(sql);
                this.busins("", "", "", ruc);
                this.habil(false);
            }
        
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.habil(true);
            this.lnew = cmbTIns.Enabled = false;
            txtNomRazSocial.Focus();

            this.Refresh();
        }

        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtBuscar_TextChanged(txtBuscar, new EventArgs());
        }

        private void cmbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.provinciasTableAdapter.Fill(this.provinciasDS.Provincias, cmbDepartamento.SelectedValue.ToString());
            cmbProvincia.SelectedIndex = -1;
        }

        private void cmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.distritoTableAdapter.Fill(this.distritoDS.Distrito, cmbProvincia.SelectedValue.ToString());
            cmbDistrito.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.habil(false);
            lstInstitucion_SelectedIndexChanged(lstInstitucion, new EventArgs());
            this.lnew = false;

            lstInstitucion.Select();
            lstInstitucion.EnsureVisible(this.index);
            lstInstitucion.Items[this.index].Selected = true;
            lstInstitucion.Items[this.index].Focused = true;
            lstInstitucion.Items[this.index].EnsureVisible();
            this.Refresh();
        }
    }
}
