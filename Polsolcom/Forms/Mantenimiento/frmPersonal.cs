using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Forms.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Polsolcom.Forms
{
    public partial class frmPersonal : Form
    {
        //TODO: IMPLEMENTAR GUARDAR Y EDITAR
        bool lnew = false;
        int nfn = 0;
        string rnet = "";
        int i = 0;
        List<Dictionary<string, string>> personalList = new List<Dictionary<string, string>>();
        Dictionary<string, string> xPac = new Dictionary<string, string>();
        string pthfoto = "";

        public frmPersonal()
        {
            InitializeComponent();
        }

        public void busper(string sper, string sdoc, string lest, string sopc = "")
        {
            string sql = "Select Ape_Paterno + ' ' + Ape_Materno + ', ' + Nombres as Fullname, * From Personal Where Ape_Paterno+' '+Ape_Materno+' '+Nombres Like '%" + sper + "%' And DNI Like '" + sdoc + "%' And Estado Like '" + lest + "%' Order By Ape_Paterno, Ape_Materno, Nombres";
            this.personalList = General.GetDictionaryList(sql);
            General.FillListView(lstPersonal, this.personalList, new[] { "Fullname", "DNI" });

            if (lstPersonal.Items.Count > 0)
            {
                if (sopc.Length > 0)
                {
                    this.i = this.personalList.FindIndex(x => x["DNI"] == sopc);
                }
                else {
                    this.i = 0;
                }

                lstPersonal.EnsureVisible(this.i);
                lstPersonal.Items[this.i].Selected = true;
                lstPersonal.Items[this.i].Focused = true;
                lstPersonal.Items[this.i].EnsureVisible();
                //lstPersonal.Select();
                lstPersonal_SelectedIndexChanged(lstPersonal, new EventArgs());
            }

            btnFoto.Enabled = lstPersonal.Items.Count > 0;
            btnCurriculum.Enabled = lstPersonal.Items.Count > 0;
        }

        public void clears()
        {
            General.setAll<TextBox, string>(this, "Text", "");
            General.setAll <MaskedTextBox, string>(this, "Text", "");
            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);

            picFoto.Image = null;
            txtFechaIng.Text = General.emptyDate;
            txtFechaNac.Text = General.emptyDate;
            txtFechaCes.Text = General.emptyDate;
            chkStatus.Checked = false;
        }

        public void habil(bool lest)
        {
            General.setAll<TextBox, bool>(this, "Enabled", lest);
            General.setAll<MaskedTextBox, bool>(this, "Enabled", lest);
            General.setAll<ComboBox, bool>(this, "Enabled", lest);
            General.setAll<RadioButton, bool>(opgSexo, "Enabled", lest);
            General.setAll<System.Windows.Controls.CheckBox, bool>(this, "Enabled", lest);
            General.setAll<Button, bool>(this, "Enabled", !lest);
            txtIdPersonal.Enabled = false;

            btnFoto.Enabled = btnCurriculum.Enabled = true;
            txtBuscar.Enabled = txtDoc.Enabled = cmbEstado.Enabled = lstPersonal.Enabled = !lest;
            btnCancelar.Enabled = btnGrabar.Enabled = lest;
        }

        public void updbal()
        {
            txtNombres.Text = this.xPac["Nombres"];
            txtPaterno.Text = this.xPac["Ape_Pat"];
            txtMaterno.Text = this.xPac["Ape_Mat"];
            txtDni.Text = this.xPac["DNI"];
            txtFechaNac.Text = this.xPac["Fec_Nac"];
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
            if (xdi.Length > 0 && xdi.Length < 8)
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
            if(xrc.Length > 0 && xrc.Length < 11)
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

            string sql = "Select Id_Personal,Nombres,Ape_Paterno,Ape_Materno,DNI From Personal Where Nombres='" + xno + "' And Ape_Paterno='" + xap + "' And Ape_Materno='" + xam + "'";
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

            return true;

        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaTipoDS.EstadoRegistro' table. You can move, or remove it, as needed.
            this.estadoRegistroTableAdapter.Fill(this.tablaTipoDS.EstadoRegistro);
            cmbEstado.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.TipoColegiatura' table. You can move, or remove it, as needed.
            this.tipoColegiaturaTableAdapter.Fill(this.tablaTipoDS.TipoColegiatura);
            cmbTCol.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'departamentosDS.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.departamentosDS.Departamentos);
            cmbDepartamento.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'cargoDS.Cargos' table. You can move, or remove it, as needed.
            this.cargosTableAdapter.Fill(this.cargoDS.Cargos);
            cmbCargo.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.AreaTrabajo' table. You can move, or remove it, as needed.
            this.areaTrabajoTableAdapter.Fill(this.tablaTipoDS.AreaTrabajo);
            cmbArea.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.GradoInstruccion' table. You can move, or remove it, as needed.
            this.gradoInstruccionTableAdapter.Fill(this.tablaTipoDS.GradoInstruccion);
            cmbGrado.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.EstadoCivil' table. You can move, or remove it, as needed.
            this.estadoCivilTableAdapter.Fill(this.tablaTipoDS.EstadoCivil);
            cmbEstadoCivil.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.ModalidadContatacion' table. You can move, or remove it, as needed.
            this.modalidadContatacionTableAdapter.Fill(this.tablaTipoDS.ModalidadContatacion);
            cmbModCont.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.Profesion' table. You can move, or remove it, as needed.
            this.profesionTableAdapter.Fill(this.tablaTipoDS.Profesion);
            cmbProfesion.SelectedIndex = -1;

            if (this.nfn == 0)
            {
                string scad = "Select Descripcion From TablaTipo Where Id_Tabla='22' And Id_Tipo='F'";
                this.rnet = Conexion.ExecuteScalar<string>(scad);
            }

            string _rut = Conexion.ExecuteScalar<string>("Select Descripcion From TablaTipo Where Id_Tabla In (Select Id_Tipo From TablaTipo Where Descripcion='VAR_PERSONAL') And Id_Tipo='CF'");

            if (Directory.Exists(_rut))
            {
                picFoto.Image = Image.FromFile(@_rut);
                lblVitae.Text = _rut;
            }

            txtBuscar_TextChanged(txtBuscar, new EventArgs());

            txtDoc.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.habil(false);
            General.setAll<Button, bool>(this, "Enabled", true);
            btnCancelar.Enabled = false;
            btnGrabar.Enabled = false;
            lstPersonal.Enabled = true;

            lstPersonal.EnsureVisible(this.i);
            lstPersonal.Items[this.i].Selected = true;
            lstPersonal.Items[this.i].Focused = true;
            lstPersonal.Items[this.i].EnsureVisible();
            lstPersonal.Select();
            lstPersonal_SelectedIndexChanged(lstPersonal, new EventArgs());

            this.lnew = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lnew = true;
            lstPersonal.Enabled = false;
            this.habil(true);
            this.clears();
            General.setAll<Button, bool>(this, "Enabled", false);
            btnCancelar.Enabled = true;
            btnGrabar.Enabled = true;

            if (MessageBox.Show("Desea buscar en base de datos alterna ... ?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                frmSeekPac frmSeekPac = new frmSeekPac(1);
                frmSeekPac.FormClosed += new FormClosedEventHandler(frmSeekPac_FormClosed);
                frmSeekPac.Show();
                this.Hide();
            }
            else {
                txtNombres.Focus();
            }
        }

        private void frmSeekPac_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.xPac = ((frmSeekPac)sender).xPac;

            this.Show();

            if (this.xPac != null)
            {
                this.updbal();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.habil(true);
            this.lnew = false;
            General.setAll<Button, bool>(this, "Enabled", false);
            btnCancelar.Enabled = true;
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = false;
            txtNombres.Focus();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            //TO DO: Método, subir imagen
        }

        private void lstPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.i = General.GetSelectedIndex(lstPersonal, false);

            if (i > -1)
            {
                txtIdPersonal.Text = personalList[this.i]["Id_Personal"];
                txtNombres.Text = personalList[this.i]["Nombres"];
                txtPaterno.Text = personalList[this.i]["Ape_Paterno"];
                txtMaterno.Text = personalList[this.i]["Ape_Materno"];
                if (personalList[this.i]["Sexo"] == "M")
                {
                    rbMasculino.Checked = true;
                    rbFemenino.Checked = false;
                }
                else
                {
                    rbMasculino.Checked = false;
                    rbFemenino.Checked = true;
                }

                txtDni.Text = personalList[this.i]["DNI"];
                txtRuc.Text = personalList[this.i]["RUC"];
                txtFechaNac.Text = personalList[this.i]["Fec_Nac"];
                txtEdad.Text = General.getYearUntilNow(txtFechaNac.Text).ToString();
                cmbTCol.SelectedValue = personalList[this.i]["TNCol"].Substring(0, 1);
                txtNCol.Text = personalList[this.i]["TNCol"].Length > 8 ? personalList[this.i]["TNCol"].Substring(1, 7) : personalList[this.i]["TNCol"].Substring(1);
                txtRne.Text = personalList[this.i]["RNE"];
                txtDireccion.Text = personalList[this.i]["Direccion"];
                cmbDepartamento.SelectedValue = personalList[this.i]["Id_Distrito"].Substring(0, 2);
                cmbDepartamento_SelectionChangeCommitted(cmbDepartamento, new EventArgs());
                cmbProvincia.SelectedValue = personalList[this.i]["Id_Distrito"].Substring(0, 4);
                cmbProvincia_SelectionChangeCommitted(cmbProvincia, new EventArgs());
                cmbDistrito.SelectedValue = personalList[this.i]["Id_Distrito"];
                txtFechaIng.Text = personalList[this.i]["Fec_Ing"];
                txtFechaCes.Text = (personalList[this.i]["Fec_Ces"].Length > 0 ? personalList[this.i]["Fec_Ces"] : General.emptyDate);
                txtTelefono.Text = personalList[this.i]["Telefono"];
                txtCelular.Text = personalList[this.i]["Celular"];
                cmbModCont.SelectedValue = personalList[this.i]["Mod_Cont"];
                cmbProfesion.SelectedValue = personalList[this.i]["Id_Profesion"];
                cmbGrado.SelectedValue = personalList[this.i]["Id_GInst"];
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
            }
           
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.SelectedIndex == -1 ? "" : cmbEstado.SelectedValue.ToString();
            this.busper(txtBuscar.Text, txtDoc.Text, estado);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string estado = cmbEstado.SelectedIndex == -1 ? "" : cmbEstado.SelectedValue.ToString();
            this.busper(txtBuscar.Text, txtDoc.Text, estado);
        }

        private void btnOtrosDatos_Click(object sender, EventArgs e)
        {
            string id = txtIdPersonal.Text;

            frmPersonalDet frmPersonalDet = new frmPersonalDet(id);
            frmPersonalDet.FormClosed += new FormClosedEventHandler(frmPersonalDet_FormClosed);
            frmPersonalDet.Show();
            this.Hide();
        }

        private void frmPersonalDet_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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

        private void btnCurriculum_Click(object sender, EventArgs e)
        {
            string xdni = txtDni.Text;

            if (String.IsNullOrEmpty(xdni))
            {
                MessageBox.Show("Ingrese el DNI primero", "Advertencia");
                txtDni.Focus();
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word 97-2003 Documents (*.doc)|*.doc|Word 2007 Documents (*.docx)|*.docx";
            openFileDialog.Title = "Seleccione un documento";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string basename = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                if (basename != xdni)
                {
                    MessageBox.Show("DNI y nombre del archivo deben ser iguales ...", "Advertencia");
                    return;
                }
                else
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        if (MessageBox.Show("Se copiara el archivo seleccionado a la carpeta predeterminada de fotos, desea continuar ... ?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            System.IO.File.Copy(openFileDialog.FileName, Path.Combine(this.pthfoto, openFileDialog.SafeFileName), true);
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                lblVitae.Text = openFileDialog.FileName;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            string xdni = txtDni.Text;

            if (String.IsNullOrEmpty(xdni))
            {
                MessageBox.Show("Ingrese el DNI primero", "Advertencia");
                txtDni.Focus();
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.Title = "Seleccione unam imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string basename = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                if (basename != xdni)
                {
                    MessageBox.Show("DNI y nombre del archivo deben ser iguales ...", "Advertencia");
                    return;
                }
                else
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        if (MessageBox.Show("Se copiara el archivo seleccionado a la carpeta predeterminada de fotos, desea continuar ... ?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            System.IO.File.Copy(openFileDialog.FileName, Path.Combine(this.pthfoto, openFileDialog.SafeFileName), true);
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                picFoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string estado = cmbEstado.SelectedIndex == -1 ? "" : cmbEstado.SelectedValue.ToString();
            this.busper(txtBuscar.Text, txtDoc.Text, estado);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string nm = txtNombres.Text;
            string ap = txtPaterno.Text;
            string am = txtMaterno.Text;
            string di = txtDni.Text;
            string rc = txtRuc.Text;

            string sx = "";
            if (rbMasculino.Checked)
            {
                sx = "M";
            }
            else
            {
                sx = "F";
            }

            string fn = txtFechaNac.Text;
            string tc = (cmbTCol.SelectedIndex == -1 ? "" : cmbTCol.SelectedValue.ToString()) + txtNCol.Text;
            string re = txtRne.Text;
            string dr = txtDireccion.Text;
            string ds = (cmbDistrito.SelectedIndex == -1 ? "" : cmbDistrito.SelectedValue.ToString());
            string tf = txtTelefono.Text;
            string cl = txtCelular.Text;
            string mc = (cmbModCont.SelectedIndex == -1 ? "" : cmbModCont.SelectedValue.ToString());
            string ec = (cmbEstadoCivil.SelectedIndex == -1 ? "" : cmbEstadoCivil.SelectedValue.ToString());
            string gi = (cmbGrado.SelectedIndex == -1 ? "" : cmbGrado.SelectedValue.ToString());
            string pr = (cmbProfesion.SelectedIndex == -1 ? "" : cmbProfesion.SelectedValue.ToString());
            string ar = (cmbArea.SelectedIndex == -1 ? "" : cmbArea.SelectedValue.ToString());
            string cr = (cmbCargo.SelectedIndex == -1 ? "" : cmbCargo.SelectedValue.ToString());
            string fi = txtFechaIng.Text;
            string fc = txtFechaCes.Text == General.emptyDate ? "" : txtFechaCes.Text;
            string em = txtEmail.Text;
            string ob = txtObservacion.Text;
            string es = chkStatus.Checked ? "1" : "0";
            string dc = chkDscto.Checked? "S": "";
            string ip = txtIdPersonal.Text;
            string us = Usuario.id_us;

            if (this.validar())
            {
                string sql = "";
                if (this.lnew)
                {
                    sql = "Declare @rs Varchar(7) " +
                        "Exec MaxValor 'Id_Personal','Personal','4',@ret=@rs Output " +
                        "Exec GenUniCod @rs,@ret=@rs Output " +
                        "Set @rs='" + Operativo.id_oper + "' + @rs " +
                        "Insert Into Personal Values (@rs,'" + nm + "','" + ap + "','" + am + "','" + di + "','" + rc + "','" + sx + "','" + fn + "','" + tc + "','" + re + "','" + dr + "','" + ds + "','" + tf + "','" + cl + "','" + mc + "','" + ec + "','" + gi + "','" + pr + "','" + ar + "','" + cr + "','" + fi + "'," + (fc.Length > 0 ? "'" + fc + "'": "NULL") + ",'" + em + "','" + ob + "','" + dc + "','" + es + "','','','','','','',Null,'','','','','','','" + us + "',GetDate(),'" + us + "',GetDate())";
                }
                else
                {
                    sql = "Update Personal Set Nombres='" + nm + "',Ape_Paterno='" + ap + "',Ape_Materno='" + am + "',DNI='" + di + "',RUC='" + rc + "',Sexo='" + sx + "',Fec_Nac='" + fn + "', TNCol='" + tc + "',RNE='" + re + "',Direccion='" + dr + "',Id_Distrito='" + ds + "',Telefono='" + tf + "',Celular='" + cl + "',Mod_Cont='" + mc + "',Est_Civil='" + ec + "', Id_GInst='" + gi + "',Id_Profesion='" + pr + "',Id_Area='" + ar + "',Id_Cargo='" + cr + "',Fec_Ing='" + fi + "',Fec_Ces=" + (fc.Length > 0 ? "'" + fc + "'" : "NULL") + ",Email='" + em + "',Observacion='" + ob + "', Dscto='" + dc + "',Estado='" + es + "',Us_Mod='" + us + "',Fec_Mod=GetDate() Where Id_Personal='" + ip + "'";
                }

                Conexion.ExecuteNonQuery(sql);

                MessageBox.Show("Datos guardados correctamente");

                this.busper("", "", "", di);
                this.habil(false);
            }
        }

        private void txtDoc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblVitae_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = lblVitae.Text;

            if (!File.Exists(target))
            {
                MessageBox.Show("Archivo no existe en carpeta predeterminada", "Aviso");
            }
            else {
                Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
                Document document = ap.Documents.Open(@target);
            }
        }
    }

}

