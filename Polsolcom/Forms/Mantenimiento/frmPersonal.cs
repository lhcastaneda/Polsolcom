using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
    public partial class frmPersonal : Form
    {
        //TODO: IMPLEMENTAR GUARDAR Y EDITAR
        bool lnew = false;
        int nfn = 0;
        string rnet = "";
        string rsys = "";
        int i = 0;
        List<Dictionary<string, string>> personalList = new List<Dictionary<string, string>>();
        Dictionary<string, string> xPac = new Dictionary<string, string>();
        string pthfoto = "";
        public frmPersonal()
        {
       
        }

        public void busper(string sper, string sdoc, string lest, int sopc = -1)
        {
            string sql = "Select Ape_Paterno + ' ' + Ape_Materno + ', ' + Nombres as Fullname, * From Personal Where Ape_Paterno+' '+Ape_Materno+' '+Nombres Like '%" + sper + "%' And DNI Like '" + sdoc + "%' And Estado Like '" + lest + "%' Order By Ape_Paterno, Ape_Materno, Nombres";
            this.personalList = General.GetDictionaryList(sql);
            General.FillListView(lstPersonal, this.personalList, new[] { "Fullname", "DNI" });

            if (sopc == -1)
            {
                sopc = 0;
            }

            lstPersonal.Select();
            lstPersonal.EnsureVisible(sopc);
            lstPersonal.Items[sopc].Selected = true;
            lstPersonal.Items[sopc].Focused = true;
            lstPersonal.Items[sopc].EnsureVisible();
            this.Refresh();
            //Ejecutamos mevento de cambio
            btnFoto.Enabled = lstPersonal.Items.Count > 0;
            btnCurriculum.Enabled = lstPersonal.Items.Count > 0;
            this.Refresh();
        }

        public void clears()
        {
            General.setAll<TextBox, string>(this, "Text", "");
            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);

            picFoto.Image = null;
            txtFechaIng.Text = General.emptyDate;
            txtFechaNac.Text = General.emptyDate;
            txtFechaCes.Text = General.emptyDate;
            chkStatus.Checked = false;
            this.Refresh();
        }

        public void habil(bool lest)
        {
            General.setAll<TextBox, bool>(this, "Enabled", lest);
            General.setAll<ComboBox, bool>(this, "Enabled", lest);
            General.setAll<RadioButton, bool>(opgSexo, "Enabled", lest);
            General.setAll<CheckBox, bool>(this, "Enabled", lest);
            General.setAll<Button, bool>(this, "Enabled", !lest);
            General.setAll<ComboBox, bool>(cntUbigeo, "Enabled", !lest);
            txtIdPersonal.Enabled = false;

            btnFoto.Enabled = btnCurriculum.Enabled = true;
            txtBuscar.Enabled = txtDoc.Enabled = cmbEstado.Enabled = lstPersonal.Enabled = !lest;
            btnCancelar.Enabled = btnGrabar.Enabled = lest;
            this.Refresh();
        }

        public void updbal()
        {
            txtNombres.Text = this.xPac["Nombres"];
            txtPaterno.Text = this.xPac["Ape_Pat"];
            txtMaterno.Text = this.xPac["Ape_Mat"];
            txtDni.Text = this.xPac["DNI"];
            txtFechaNac.Text = this.xPac["Fecha_Nac"];
            if (this.xPac["Sexo"] == "1")
            {
                rbMasculino.Checked = true;
            }
            else
            {
                rbFemenino.Checked = true;
            }

            cmbDepartamento.SelectedValue = xPac["Id_Old"].Substring(0, 2);
            cmbDepartamento_SelectionChangeCommitted(cmbDepartamento, new EventArgs());
            cmbProvincia.SelectedValue = xPac["Id_Old"].Substring(0, 4);
            cmbProvincia_SelectionChangeCommitted(cmbProvincia, new EventArgs());
            cmbDistrito.SelectedValue = xPac["Id_Old"];
            txtRuc.Focus();
        }

        public bool validar()
        {
            if (txtNombres.Text.Length == 0 || txtPaterno.Text.Length == 0 || txtMaterno.Text.Length == 0 || txtDni.Text.Length == 0 || txtFechaNac.Text == General.emptyDate || txtFechaIng.Text == General.emptyDate || cmbDistrito.SelectedIndex == -1 || cmbModCont.SelectedIndex == -1 || cmbEstadoCivil.SelectedIndex == -1 || cmbGrado.SelectedIndex == -1 || cmbProfesion.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos para grabar el registro ...", "Advertencia");
                return false;
            }

            if (int.Parse(txtEdad.Text) < 0)
            {
                MessageBox.Show("Edad no puede ser negativa ... corrija los datos", "Advertencia");
                txtFechaNac.Focus();
                return false;
            }

            if (cmbTCol.SelectedIndex == -1 && txtNCol.Text.Length > 0)
            {
                MessageBox.Show("Falta el tipo de colegiatura ... verifique", "Advertencia");
                cmbTCol.Focus();
                return false;
            }

            if (cmbTCol.SelectedIndex != -1 && txtNCol.Text.Length == 0)
            {
                MessageBox.Show("Falta el tipo de colegiatura ... verifique", "Advertencia");
                txtNCol.Focus();
                return false;
            }

            string xdp = "";
            string xip = "";

            string xdi = txtDni.Text;
            if (xdi.Length < 8)
            {
                MessageBox.Show("Cantidad de digitos en DNI incorrecta ...", "Advertencia");
                txtDni.Focus();
                return false;
            }

            if (xdi.Length == 8)
            {
                Dictionary<string, string> xdni = General.GetDictionary("Select Id_Personal,Nombres,Ape_Paterno,Ape_Materno,DNI From Personal Where DNI='" + xdi + "'");

                xdp = (xdni == null ? "" : xdni["Nombres"] + " " + xdni["Ape_Paterno"] + " " + xdni["Ape_Materno"]);
                xip = (xdni == null ? "" : xdni["Id_Personal"]);
                xdi = (xdni == null ? "" : xdni["DNI"]);

                if (xdp != "")
                {
                    string xmsg = "D.N.I. (" + xdi + ") pertenece a (" + xdp + "),\nverifique por favor ...";

                    if (this.lnew == false)
                    {
                        if (xip != txtIdPersonal.Text)
                        {
                            MessageBox.Show(xmsg, "Advertencia");
                            txtDni.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(xmsg, "Advertencia");
                        txtDni.Focus();
                        return false;
                    }
                }
            }

            string xrc = txtRuc.Text;
            if(xrc.Length < 11)
            {
                MessageBox.Show("Cantidad de digitos en R.U.C. incorrecta ...", "Advertencia");
                txtRuc.Focus();
                return false;
            }

            if (xrc.Length == 11)
            {
                Dictionary<string, string> xruc = General.GetDictionary("Select Id_Personal,Nombres,Ape_Paterno,Ape_Materno,RUC From Personal Where RUC = '" + xrc + "'");

                xdp = (xruc == null ? "" : xruc["Nombres"] + " " + xruc["Ape_Paterno"] + " " + xruc["Ape_Materno"]);
                xip = (xruc == null ? "" : xruc["Id_Personal"]);
                xrc = (xruc == null ? "" : xruc["RUC"]);

                if (xdp != "")
                {
                    string xmsg = "R.U.C. (" + xrc + ") pertenece a (" + xdp + "),\nverifique por favor ...";

                    if (lnew == false)
                    {
                        if (xip != txtIdPersonal.Text)
                        {
                            MessageBox.Show(xmsg, "Advertencia");
                            txtRuc.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(xmsg, "Advertencia");
                        txtRuc.Focus();
                        return false;
                    }
                }
            }

            string xno = txtNombres.Text;
            string xap = txtPaterno.Text;
            string xam = txtMaterno.Text;

            string sql = "Select Id_Personal,Nombres,Ape_Paterno,Ape_Materno,DNI From Personal Where Nombres='" + xno + " And Ape_Paterno='" + xap + "' And Ape_Materno='" + xam + "'";
            Dictionary<string, string> xper = General.GetDictionary(sql);

            xdp = (xper == null ? "" : xper["Nombres"] + " " + xper["Ape_Paterno"] + " " + xper["Ape_Materno"]);
            xip = (xper == null ? "" : xper["Id_Personal"]);
            xdi = (xper == null ? "" : xper["DNI"]);

            if (xdp != "")
            {
                string xmsg = "(" + xdp + ") ya esta registrado con Id (" + xip + ") \ny DNI " + xdi + ", verifique por favor ...";

                if (this.lnew == false)
                {
                    if (xip != txtIdPersonal.Text)
                    {
                        MessageBox.Show(xmsg, "Advertencia");
                        txtNombres.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(xmsg, "Advertencia");
                    txtNombres.Focus();
                    return false;
                }
            }

            string xnc = cmbTCol.SelectedValue.ToString() + txtNCol.Text;
            string scad = "Select Id_Personal,Nombres,Ape_Paterno,Ape_Materno From Personal Where TNCol='" + xnc + "' And TNCol<>''";
            Dictionary<string, string> xtnc = General.GetDictionary(scad);

            xdp = (xper == null ? "" : xper["Nombres"] + " " + xper["Ape_Paterno"] + " " + xper["Ape_Materno"]);
            xip = (xper == null ? "" : xper["Id_Personal"]);

            if (xdp != "")
            {
                string xmsg = "(" + xdp + ") con Id (" + xip + ") tiene el mismo tipo y\nnumero de colegiatura, verifique por favor ...";

                if (this.lnew == false)
                {
                    if (xip != txtIdPersonal.Text)
                    {
                        MessageBox.Show(xmsg, "Advertencia");
                        cmbTCol.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(xmsg, "Advertencia");
                    cmbTCol.Focus();
                    return false;
                }
            }


            this.Refresh();
            return true;

        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departamentosDS.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.departamentosDS.Departamentos);
            // TODO: This line of code loads data into the 'cargoDS.Cargos' table. You can move, or remove it, as needed.
            this.cargosTableAdapter.Fill(this.cargoDS.Cargos);
            // TODO: This line of code loads data into the 'tablaTipoDS.AreaTrabajo' table. You can move, or remove it, as needed.
            this.areaTrabajoTableAdapter.Fill(this.tablaTipoDS.AreaTrabajo);
            // TODO: This line of code loads data into the 'tablaTipoDS.GradoInstruccion' table. You can move, or remove it, as needed.
            this.gradoInstruccionTableAdapter.Fill(this.tablaTipoDS.GradoInstruccion);
            // TODO: This line of code loads data into the 'tablaTipoDS.EstadoCivil' table. You can move, or remove it, as needed.
            this.estadoCivilTableAdapter.Fill(this.tablaTipoDS.EstadoCivil);
            // TODO: This line of code loads data into the 'tablaTipoDS.ModalidadContatacion' table. You can move, or remove it, as needed.
            this.modalidadContatacionTableAdapter.Fill(this.tablaTipoDS.ModalidadContatacion);
            // TODO: This line of code loads data into the 'tablaTipoDS.Profesion' table. You can move, or remove it, as needed.
            this.profesionTableAdapter.Fill(this.tablaTipoDS.Profesion);

            if (this.nfn == 0)
            {
                string scad = "Select Descripcion From TablaTipo Where Id_Tabla='22' And Id_Tipo='F'";
                this.rnet = Conexion.ExecuteScalar<string>(scad);
            }

            string _rut = Conexion.ExecuteScalar<string>("Select Descripcion From TablaTipo Where Id_Tabla In (Select Id_Tipo From TablaTipo Where Descripcion='VAR_PERSONAL') And Id_Tipo='CF'");

            if (Directory.Exists(_rut))
            {
                picFoto.Image = Image.FromFile(@_rut);
            }

            cmbEstado.SelectedIndex = -1;
            txtBuscar_TextChanged(txtBuscar, new EventArgs());
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnImprimir.Enabled = true;
            btnEditar.Enabled = true;
            btnGrabar.Enabled = false;
            DisabledPanelControls();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EnabledPanelControls();
        }

        private void EnabledPanelControls()
        {
            foreach (Control item in pnlDatos.Controls)
            {
                item.Enabled = true;
            }
        }

        private void DisabledPanelControls()
        {
            foreach (Control item in pnlDatos.Controls)
            {
                item.Enabled = false;
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            EnabledPanelControls();
            btnCancelar.Enabled = true;
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            //TO DO: Método, subir imagen
        }

        private void lstPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            var item = lstPersonal.Items[lstPersonal.SelectedIndex];
            Personal personal = ListaPersonal.Find(x => $"{x.Ape_Paterno} {x.Ape_Materno}, {x.Nombre}".Equals(item));
            if (personal != null)
            {
                //TO DO: Completar los demas cuadradillos
                txtDirecc.Text = personal.Direccion;
                txtDni.Text = personal.DNI;
                txtMaterno.Text = personal.Ape_Materno;
                txtPaterno.Text = personal.Ape_Paterno;
                txtCel.Text = personal.Celular;
                txtDirecc.Text = personal.Direccion;
                txtEmail.Text = personal.Email;
            }
            */
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            /*
           List<Personal> ListaPersonalAux = new List<Personal>();
            List<string> ListaPersonalizada = new List<string>();
            if (txtDoc.Text == "")
            {
                lstPersonal.DataSource = ListaNombres;
            }
            else
            {
                ListaPersonalizada.Clear();
                foreach (var personal in ListaPersonal)
                    {
                    if (personal.DNI.Contains(txtDoc.Text))
                         {
                            var name = $"{personal.Ape_Paterno} {personal.Ape_Materno}, {personal.Nombre}";
                            ListaPersonalizada.Add(name);
                         }
                    }            
                lstPersonal.DataSource = ListaPersonalizada;
            }
            */
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            /*
            List<string> ListaPersonalizada = new List<string>();
            if (txtBuscar.Text == "")
            {
                lstPersonal.DataSource = ListaNombres;
            }
            else
            {
                ListaPersonalizada.Clear();
                foreach (var item in ListaNombres)
                {
                    if (item.Contains(txtBuscar.Text.ToUpper()))
                    {
                        ListaPersonalizada.Add(item);
                    }
                }
                lstPersonal.DataSource = ListaPersonalizada;
            }    
            */ 
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnOtrosDatos_Click(object sender, EventArgs e)
        {
            frmPersonalDet form = new frmPersonalDet();
            form.Show();
        }

        private void frmPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
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

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string dni = txtDni.Text;
                if (dni.Length == 8)
                {
                    if (MessageBox.Show("Desea actualizar desde base de datos alterna ... ?", "Aviso al usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string sql = General.DevuelveQueryPaciente("", "", "", dni, "", "", 2, 1);
                        this.xPac = General.GetDictionary(sql);
                        this.updbal();
                    }
                }
            }
        }

        private void txtFechaNac_Leave(object sender, EventArgs e)
        {
            txtEdad.Text = General.getYearUntilNow(txtFechaNac.Text).ToString();
        }

        private void txtFechaCes_Leave(object sender, EventArgs e)
        {
            string cese = txtFechaCes.Text;
            if (cese != General.emptyDate)
            {
                DateTime fechaIng = DateTime.Parse(txtFechaIng.Text);
                DateTime fechaCes = DateTime.Parse(cese);

                if (fechaCes.CompareTo(fechaIng) < 0)
                {
                    MessageBox.Show("Fecha de cese no puede ser menor que la fecha de ingreso", "Aviso");
                    return;
                }
            }
        }

        private void lstPersonal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.i = General.GetSelectedIndex(lstPersonal);
            txtIdPersonal.Text = personalList[this.i]["Id_Personal"];
            txtNombres.Text = personalList[this.i]["Nombres"];
            txtPaterno.Text = personalList[this.i]["Ape_Paterno"];
            txtMaterno.Text = personalList[this.i]["Ape_Materno"];
            if (personalList[this.i]["Ape_Materno"] == "M")
            {
                rbMasculino.Checked = true;
            }
            else
            {
                rbFemenino.Checked = true;
            }

            txtDni.Text = personalList[this.i]["DNI"];
            txtRuc.Text = personalList[this.i]["RUC"];
            txtFechaNac.Text = personalList[this.i]["Fec_Nac"];
            txtEdad.Text = General.getYearUntilNow(txtFechaNac.Text).ToString();
            cmbTCol.SelectedValue = personalList[this.i]["TNCol"].Substring(0, 1);
            txtNCol.Text = personalList[this.i]["TNCol"].Substring(1, 6);
            txtRne.Text = personalList[this.i]["RNE"];
            txtDireccion.Text = personalList[this.i]["Direccion"];
            cmbDepartamento.SelectedValue = personalList[this.i]["Id_Distrito"].Substring(0, 2);
            cmbDepartamento_SelectionChangeCommitted(cmbDepartamento, new EventArgs());
            cmbProvincia.SelectedValue = personalList[this.i]["Id_Distrito"].Substring(0, 4);
            cmbProvincia_SelectionChangeCommitted(cmbProvincia, new EventArgs());
            cmbDistrito.SelectedValue = personalList[this.i]["Id_Distrito"];
            txtFechaIng.Text = personalList[this.i]["Fec_Ing"];
            txtFechaCes.Text = (personalList[this.i]["Fec_Ces"].Length > 0 ? personalList[this.i]["Fec_Ces"]: General.emptyDate);
            txtTelefono.Text = personalList[this.i]["Telefono"];
            txtCelular.Text = personalList[this.i]["Celular"];
            cmbModCont.SelectedValue = personalList[this.i]["Mod_Cont"];
            cmbProfesion.SelectedValue = personalList[this.i]["Id_Profesion"];
            cmbGrado.SelectedValue = personalList[this.i]["Id_Ginst"];
            cmbArea.SelectedValue = personalList[this.i]["Id_Area"];
            cmbCargo.SelectedValue = personalList[this.i]["Id_Cargo"];
            cmbEstadoCivil.SelectedValue = personalList[this.i]["Est_Civil"];
            chkDscto.Checked = (personalList[this.i]["Dscto"] == "S");
            chkStatus.Checked = (personalList[this.i]["Estado"] == "1");
            txtEmail.Text = personalList[this.i]["Email"];
            txtObservacion.Text = personalList[this.i]["Observacion"];

            if (this.pthfoto.Length > 0)
            {
                string kfile = this.pthfoto + personalList[this.i]["DNI"] + ".jpg";
                string kcurr = this.pthfoto + personalList[this.i]["DNI"] + ".doc";

                if (File.Exists(kfile))
                {
                    picFoto.Image = Image.FromFile(@kfile);
                }
                else
                {
                    picFoto.Image = null;
                }

                if (File.Exists(kcurr))
                {
                    lblVitae.Text = kcurr;
                }
                else
                {
                    lblVitae.Text = "No se hallo hoja de vida";
                }
            }
            this.Refresh();
        }
    }

}

