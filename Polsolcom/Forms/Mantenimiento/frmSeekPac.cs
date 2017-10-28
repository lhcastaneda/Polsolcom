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

namespace Polsolcom.Forms.Mantenimiento
{
    public partial class frmSeekPac : Form
    {
        bool iu = false;
        int df = 0;

        List<Dictionary<string, string>> pacs = new List<Dictionary<string, string>>();
        Dictionary<string, string> anul = new Dictionary<string, string>();

        public Dictionary<string, string> xPac = new Dictionary<string, string>();

        public frmSeekPac()
        {
            InitializeComponent();
        }

        public frmSeekPac(int df)
        {
            InitializeComponent();
            this.df = df;
        }

        public void clr()
        {
            General.setAll<TextBox, string>(this, "Text", "");
            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);

            if (this.iu)
            {
                General.Fill(lstPacientes, this.pacs, (this.df == 0 ? new[] { "Paciente", "FullDireccion", "DNI", "Telefono" } : new[] { "Paciente", "FullDireccion", "DNI" }));

                if (this.iu)
                {
                    lstPacientes.Items[0].Selected = true;
                }
            }
            else
            {
                lstPacientes.Items.Clear();
            }

            txtFechaNac.Text = General.emptyDate;
            this.df = 0;
        }

        public bool ddi()
        {
            if (txtDoc.Text.Length > 0)
            {
                string nd = txtDoc.Text;

                string sql = "Select Nombre,Ape_Paterno,Ape_Materno,DNI,Id_Paciente From Pacientes Where DNI='" + nd + "'";

                Dictionary<string, string> dupl = General.GetDictionary(sql);

                if (dupl != null)
                {
                    string di = dupl["Id_Paciente"];
                    string dd = dupl["DNI"];
                    string dp = dupl["Nombre"] + ' ' + dupl["Ape_Paterno"] + ' ' + dupl["Ape_Materno"];

                    nd = (this.iu == false ? (dd == nd ? "0" : "") : (dd == nd && di != txtIdPaciente.Text ? "0" : ""));

                    if (nd == "0")
                    {
                        if (MessageBox.Show("DNI " + dd + " pertenece a " + dp + " (" + di + ")" + ", verificar y corregir datos ...", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            txtDoc.Focus();
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public void fil(string lp = null)
        {
            string xp = lp;
            string pt = txtApePat.Text;
            string mt = txtApeMat.Text;
            string nm = txtNom.Text;
            string di = txtDni.Text;
            string ip = xp == null ? txtIdPac.Text : xp;
            string nh = txtNroHist.Text;

            if ((pt.Length + mt.Length + nm.Length + di.Length + ip.Length + nh.Length) > 0)
            {
                string sql = General.DevuelveQueryPaciente(pt, mt, nm, di, ip, nh, 2, this.df);
                this.pacs = General.GetDictionaryList(sql);

                General.Fill(lstPacientes, this.pacs, (this.df == 0 ? new[] { "Paciente", "FullDireccion", "DNI", "Telefono" } : new[] { "Paciente", "FullDireccion", "DNI" }));

                if (lstPacientes.Items.Count > 0)
                {
                    if (xp != null)
                    {
                        lstPacientes.Items[0].Selected = true;
                    }

                    lstPacientes_SelectedIndexChanged(lstPacientes, new EventArgs());
                }
            }
        }

        public void hab(bool ls, bool lm = false)
        {
            General.setAll<TextBox, bool>(this, "Enabled", ls);
            General.setAll<MaskedTextBox, bool>(this, "Enabled", ls);
            General.setAll<ComboBox, bool>(this, "Enabled", ls);
            General.setAll<ListView, bool>(this, "Enabled", ls);

            General.setAll<Button, bool>(this, "Enabled", !ls);

            txtEmail.Enabled = ls;
            this.df = 0;

            if (lm == false)
            {
                txtApePat.Enabled = txtApeMat.Enabled = txtNom.Enabled = txtDni.Enabled = txtIdPac.Enabled = txtNroHist.Enabled = lstPacientes.Enabled = !ls;
                txtNombre.Focus();
            }
            else
            {
                this.df = 1;
                txtApePat.Focus();
            }

            string[] tipos = new[] { "A", "O" };

            txtNombre.Enabled = txtApePaterno.Enabled = txtApeMaterno.Enabled = (tipos.Contains(Usuario.tipo) && ls);
            btnAnular.Enabled = tipos.Contains(Usuario.tipo) ? !ls : false;
            btnGrabar.Enabled = btnCancelar.Enabled = ls;
            txtIdPaciente.Enabled = this.iu = false;
            btnAnular.Text = "&Anular";
        }

        public bool hom()
        {
            string nm = txtNombre.Text;
            string ap = txtApePaterno.Text;
            string am = txtApeMaterno.Text;
            string nd = txtODoc.Text;

            if (nm.Length > 0 && ap.Length > 0 && am.Length > 0)
            {
                string sql = "Select Nombre,Ape_Paterno,Ape_Materno,DNI,Id_Paciente From Pacientes Where Nombre='" + nm + "' And Ape_Paterno='" + ap + "' And Ape_Materno='" + am + "'";
                Dictionary<string, string> hom = General.GetDictionary(sql);

                if (hom != null)
                {
                    string hi = hom["Id_Paciente"];
                    string hd = hom["DNI"];
                    string hp = hom["Nombre"] + " " + hom["Ape_Paterno"] + " " + hom["Ape_Materno"];

                    if (hp == (nm + " " + ap + " " + am))
                    {
                        nd = (this.iu ? (hi != txtIdPaciente.Text ? (hd == nd && nd.Length > 0 ? "2" : "1") : "") : (hd == nd && nd.Length > 0 ? "2" : "1"));

                        switch (nd)
                        {
                            case "2":
                                hp = hp + " con DNI " + hd;
                                MessageBox.Show("Paciente " + hp + " ya esta registrado ... solo realice la busqueda ...", "Advertencia");
                                txtNombre.Select();
                                return false;
                            case "1":
                                if (MessageBox.Show("Paciente " + hp + " ya esta registrado ... desea ingresar HOMONIMO ... ?", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                {
                                    txtNombre.Text = txtNombre.Text + " (H)";
                                }
                                else
                                {
                                    txtNombre.Select();
                                    return false;
                                }
                                break;
                        }
                    }
                }
            }

            return true;
        }

        public bool vob(bool lp = false)
        {
            if (lp)
            {
                if (txtAsegurado.Text == "A" && !(new[] { "A", "S" }).Contains(Usuario.tipo))
                {
                    MessageBox.Show("Este registro está anulado ...", "Advertencia");
                    return false;
                }
            }
            else
            {
                if (this.iu)
                {
                    string ni = txtNombre.Text.Substring(0, 1) + txtApePaterno.Text.Substring(0, 1) + txtApeMaterno.Text.Substring(0, 1);
                    string oi = txtIdPaciente.Text.Substring(3, 3);

                    if (ni != oi)
                    {
                        MessageBox.Show("Nombres y Apellidos no pueden cambiarse, por no coincidir con el ID ...", "Advertencia");
                        return false;
                    }
                }

                if (txtApePaterno.Text.Length == 0 && txtApeMaterno.Text.Length == 0)
                {
                    MessageBox.Show("Los apellidos son necesarios ... ingrese al menos uno ...", "Advertencia");
                    txtApePaterno.Focus();
                    return false;
                }

                if ((cmbTDoc.SelectedIndex == -1 && txtODoc.Text.Length > 0) || (cmbTDoc.SelectedIndex != -1 && txtODoc.Text.Length == 0))
                {
                    MessageBox.Show("El tipo y numero de otro documento son complementarios ... corrija ...", "Advertencia");
                    cmbTDoc.Focus();
                    return false;
                }

                General.valObj(txtNombre, "nombres");
                General.valObj(txtApePaterno, "apellido paterno");
                General.valObj(txtApeMaterno, "apellido materno");
                General.valObj(txtSexo, "genero o sexo");
                General.valObj(txtEdad, "edad");

            }

            return true;
        }

        private void frmSeekPac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaTipoDS.DocIdentidad' table. You can move, or remove it, as needed.
            this.docIdentidadTableAdapter.Fill(this.tablaTipoDS.DocIdentidad);
            cmbTDoc.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'departamentosDS.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.departamentosDS.Departamentos);
            cmbDepartamento.SelectedIndex = -1;

            if (this.df == 1)
            {
                grpIdPac.Visible = false;
                grpNroPac.Visible = false;
                pnlDatos.Visible = false;
                this.Height = 257;

                General.setAll<Button, bool>(this, "Enabled", false);
                this.Text = "Mantenimiento del registro de Pacientes";
            }
            else
            {
                this.hab(false, false);
                this.Text = "Búsqueda de paciente";
            }
        }

        private void frmSeekPac_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    break;
                case Keys.F1:
                    if (lstPacientes.Enabled)
                    {
                        lstPacientes.Focus();
                        lstPacientes.Items[0].Selected = true;
                        lstPacientes_SelectedIndexChanged(lstPacientes, new EventArgs());
                    }
                    break;
                case Keys.F5:
                    if (btnNuevo.Enabled)
                    {
                        btnNuevo_Click(btnNuevo, new EventArgs());
                    }
                    break;
                case Keys.F6:
                    if (btnGrabar.Enabled)
                    {
                        btnGrabar_Click(btnGrabar, new EventArgs());
                    }
                    break;
                case Keys.F7:
                    if (btnCancelar.Enabled)
                    {
                        btnCancelar_Click(btnCancelar, new EventArgs());
                    }
                    break;
                case Keys.F8:
                    if (btnEditar.Enabled)
                    {
                        btnEditar_Click(btnEditar, new EventArgs());
                    }
                    break;
                case Keys.F9:
                    if (btnAnular.Enabled)
                    {
                        btnAnular_Click(btnAnular, new EventArgs());
                    }
                    break;
            }

        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.df == 0)
            {
                int i = General.GetSelectedIndex(lstPacientes);

                if (lstPacientes.Items.Count > 0)
                {
                    txtApePaterno.Text = this.pacs[i]["Ape_Paterno"];
                    txtApeMaterno.Text = this.pacs[i]["Ape_Materno"];
                    txtNombre.Text = this.pacs[i]["Nombre"];
                    txtSexo.Text = this.pacs[i]["Sexo"];
                    txtDoc.Text = this.pacs[i]["DNI"];
                    txtFechaNac.Text = this.pacs[i]["Fecha_Nac"].Length == 0 ? General.emptyDate : this.pacs[i]["Fecha_Nac"];
                    txtEdad.Text = this.pacs[i]["Fecha_Nac"].Length == 0 ? this.pacs[i]["Edad"] : General.getYearsUntilNow(this.pacs[i]["Fecha_Nac"]).ToString();

                    cmbDepartamento.SelectedValue = this.pacs[i]["Id_Distrito"].Substring(0, 2);
                    cmbDepartamento_SelectionChangeCommitted(cmbDepartamento, new EventArgs());
                    cmbProvincia.SelectedValue = this.pacs[i]["Id_Distrito"].Substring(0, 4);
                    cmbProvincia_SelectionChangeCommitted(cmbProvincia, new EventArgs());
                    cmbDistrito.SelectedValue = this.pacs[i]["Id_Distrito"];

                    txtIdPaciente.Text = this.pacs[i]["Id_Paciente"];
                    txtDireccion.Text = this.pacs[i]["Direccion"];
                    txtTelefono.Text = this.pacs[i]["Telefono"];
                    if (this.pacs[i]["ODoc"].Length > 0)
                    {
                        cmbTDoc.SelectedValue = this.pacs[i]["ODoc"].Substring(0, 1);
                        txtODoc.Text = this.pacs[i]["ODoc"].Length < 19 ? this.pacs[i]["ODoc"] : this.pacs[i]["ODoc"].Substring(1, 19);
                    }
                    else
                    {
                        cmbTDoc.SelectedIndex = -1;
                        txtODoc.Text = "";
                    }

                    txtAsegurado.Text = this.pacs[i]["Asegurado"];
                    txtEmail.Text = this.pacs[i]["E_Mail"];
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.clr();

            string sql = "Select Case When Exists(Select Name From master..sysdatabases Where Name='DNI') Then 1 Else 0 End C";
            int c = Conexion.ExecuteScalar<int>(sql);

            if (c > 0)
            {
                if (MessageBox.Show("Desea realizar busqueda en base de datos alterna ... ?", "'Aviso al usuario'", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.hab(true, true);
                }
                else
                {
                    this.hab(true, false);
                }
            }
            else
            {
                this.hab(true, false);
            }

            txtNombre.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar los cambios ... ?", "Aviso al usuario", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                btnCancelar_Click(btnCancelar, new EventArgs());
                return;
            }

            if (!this.vob())
            {
                return;
            }

            if (!this.hom())
            {
                return;
            }

            if (!this.ddi())
            {
                return;
            }

            string nm = txtNombre.Text;
            string ap = txtApePaterno.Text;
            string am = txtApeMaterno.Text;
            string di = txtDoc.Text;
            string fn = txtFechaNac.Text.Length == 0 ? "" : txtFechaNac.Text;
            string ed = txtEdad.Text;
            string sx = txtSexo.Text;
            string tf = txtTelefono.Text;
            string dr = txtDireccion.Text;
            string sg = txtAsegurado.Text;
            string ds = cmbDistrito.SelectedIndex == -1 ? "" : cmbDistrito.SelectedValue.ToString();
            string od = cmbTDoc.SelectedIndex == -1 ? "" : (cmbTDoc.SelectedValue.ToString() + txtODoc.Text);
            string em = txtEmail.Text;
            string ip = this.iu ? txtIdPaciente.Text : Operativo.id_oper;

            string sql = "Exec AddPaciente '" + nm + "','" + ap + "','" + am + "','" + di + "','" + fn + "','" + ed + "','" + sx + "','" + tf + "','" + dr + "','" + sg + "','" + ds + "','" + od + "','" + em + "','" + ip + "'";
            Dictionary<string, string> cpac = General.GetDictionary(sql);

            ip = this.iu ? txtIdPaciente.Text : cpac["Id_Paciente"];

            this.hab(false);
            this.fil(ip);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.clr();
            this.hab(false);

            txtApePat.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIdPaciente.Text.Length > 0)
            {
                if (!this.vob(true))
                {
                    return;
                }

                this.hab(true);
                this.iu = true;
                txtNombre.Select();
            }
            else
            {
                return;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (txtIdPaciente.Text.Length > 0 && txtAsegurado.Text != "A")
            {
                string ip = txtIdPaciente.Text;

                switch (btnAnular.Text)
                {
                    case "&Anular":

                        string sql = "Select Case When Exists(Select Top 1 * From Tickets Where Id_Paciente='" + ip + "' And Anulado='') " + "Then 1 Else 0 End C";
                        int c = Conexion.ExecuteScalar<int>(sql);

                        if (c > 0)
                        {
                            if (MessageBox.Show("El registro tiene ventas registradas ... desea continuar?", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                General.setAll<Button, bool>(this, "Enabled", false);
                                btnAnular.Enabled = true;
                                btnAnular.Text = "&Paso 1";

                                this.anul = this.pacs.Find(x => x["Id_Paciente"] == ip);
                                this.anul["Anulado"] = "1";

                                MessageBox.Show("Seleccione el paciente a quien transferirle las ventas ...", "Advertencia");
                                lstPacientes.Items.Clear();
                                txtApePat.Focus();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            string sql2 = "Update Pacientes Set Asegurado='A' Where Id_Paciente='" + ip + "'";
                            Conexion.ExecuteNonQuery(sql2);
                            MessageBox.Show("Registro anulado correctamente");
                            this.fil(ip);
                        }

                        break;
                    case "&Paso 1":

                        if (ip == this.anul["Id_Paciente"])
                        {
                            MessageBox.Show("Seleccione otro ... es el registro anterior", "Advertencia");
                            return;
                        }

                        lstPacientes.Items.Clear();

                        this.pacs = this.pacs.FindAll(x => x["Id_Paciente"] == ip);
                        this.pacs.Add(this.anul);

                        if (MessageBox.Show("Desea continuar con el proceso ...?", "Paso 1", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            General.Fill(lstPacientes, this.pacs, (this.df == 0 ? new[] { "Paciente", "FullDireccion", "DNI", "Telefono" } : new[] { "Paciente", "FullDireccion", "DNI" }));
                            lstPacientes_SelectedIndexChanged(lstPacientes, new EventArgs());
                            btnAnular.Text = "&Paso 2";
                        }
                        else
                        {
                            this.hab(false);
                            this.fil(ip);
                        }

                        break;
                    case "&Paso 2":
                        lstPacientes.Items.Clear();

                        if (MessageBox.Show("Desea continuar con el proceso ...?", "Paso 2", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            string msg = "Confirma el traslado de las atenciones del paciente:\n";
                            string ip1 = this.pacs[1]["Id_Paciente"];
                            string ip0 = this.pacs[0]["Id_Paciente"];
                            msg += this.pacs[1]["Ape_Paterno"] + " " + this.pacs[1]["Ape_Materno"] + ", " + this.pacs[1]["Nombre"] + " con ID: (" + this.pacs[1]["Id_Paciente"] + ")\n";
                            msg += "hacia el paciente:\n";
                            msg += this.pacs[0]["Ape_Paterno"] + " " + this.pacs[0]["Ape_Materno"] + ", " + this.pacs[0]["Nombre"] + " con ID: (" + this.pacs[0]["Id_Paciente"] + ")\n";

                            if (MessageBox.Show(msg, "Aviso al usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                string sql2 = "Update Tickets Set Id_Paciente='" + ip0 + "' Where Id_Paciente='" + ip1 + "'";
                                Conexion.ExecuteNonQuery(sql2);

                                string sql3 = "Update Pacientes Set Asegurado='A' Where Id_Paciente='" + ip1 + "'";
                                Conexion.ExecuteNonQuery(sql2);

                                MessageBox.Show("Las ventas fueron movidas y el registro del paciente fue anulado ...", "Aviso al usuario");
                                this.hab(false);
                                this.fil(ip1);
                            }
                            else
                            {
                                return;
                            }

                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Asegurese que el usuario no esté anulado", "Advertencia");
            }
        }

        private void cmbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string departamento = cmbDepartamento.SelectedIndex == -1 ? "" : cmbDepartamento.SelectedValue.ToString();
            this.provinciasTableAdapter.Fill(this.provinciasDS.Provincias, departamento);
            cmbProvincia.SelectedIndex = -1;
        }

        private void cmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string provincia = cmbProvincia.SelectedIndex == -1 ? "" : cmbProvincia.SelectedValue.ToString();
            this.distritoTableAdapter.Fill(this.distritoDS.Distrito, provincia);
            cmbDistrito.SelectedIndex = -1;
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            //if (this.df == 0 || txtNom.Text.Length > 0)
            if (txtNom.Text.Length > 0)
            {
                this.fil();
            }
        }

        private void txtApeMat_TextChanged(object sender, EventArgs e)
        {
            //if (this.df == 0)
            if (txtApeMat.Text.Length > 0)
            {
                this.fil();
            }
        }

        private void txtApePat_TextChanged(object sender, EventArgs e)
        {
            //if (this.df == 0)
            if (txtApePat.Text.Length > 0)
            {
                this.fil();
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            //if (this.df == 0 || (this.df == 1 && txtDni.Text.Length == 8))
            if (txtDni.Text.Length == 8)
            {
                this.fil();
            }
        }

        private void lstPacientes_KeyDown(object sender, KeyEventArgs e)
        {
            int i = General.GetSelectedIndex(lstPacientes);

            if (e.KeyCode == Keys.Enter && lstPacientes.Items.Count > 0)
            {
                string ip = this.df == 0 ? this.pacs[i]["Id_Paciente"] : this.pacs[i]["DNI"];

                if (this.df == 0)
                {
                    this.xPac = this.pacs.Find(x => x["Id_Paciente"] == ip);
                }
                else
                {
                    this.xPac = this.pacs.Find(x => x["DNI"] == ip);
                    this.Close();
                }
            }

            if (e.KeyCode == Keys.Tab && this.df == 1)
            {
                txtEdad.Focus();
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text.Length == 0)
            {
                MessageBox.Show("Ingrese la edad del Paciente ...", "Advertencia ...");
                txtEdad.Focus();
                return;
            }

            if (int.Parse(txtEdad.Text) < 0)
            {
                MessageBox.Show("Corregir los datos ... la edad no puede ser un número negativo ...", "Advertencia ...");
                return;
            }

            if (int.Parse(txtEdad.Text) > 100)
            {
                if (MessageBox.Show("Verifique los datos ... la edad del paciente es mayor a 100 años ?", "Advertencia ...", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void txtSexo_Leave(object sender, EventArgs e)
        {
            if (txtSexo.Text.Length == 0 || !(new string[] { "M", "F" }).Contains(txtSexo.Text))
            {
                MessageBox.Show("Dato no valido ingrese solo F ó M ...", "Advertencia");
                txtSexo.Focus();
                return;
            }
        }

        private void txtDoc_Leave(object sender, EventArgs e)
        {
            if (txtDoc.Text.Length > 8)
            {
                MessageBox.Show("Longitud de DNI no valida ... debe contener 8 digitos ... verifique", "Advertencia");
                return;

            }
        }

        private void txtFechaNac_Leave(object sender, EventArgs e)
        {
            if (txtFechaNac.Text != General.emptyDate)
            {
                DateTime fechaNac = DateTime.Today;

                bool validDate = DateTime.TryParse(txtFechaNac.Text, out fechaNac);

                if (!validDate || fechaNac.CompareTo(DateTime.Today) > 0 || fechaNac.Year < 1900)
                {
                    MessageBox.Show("Fecha de nacimiento erronea ... corrija los datos ...", "Advertencia");
                    txtFechaNac.Focus();
                    return;
                }

                txtEdad.Text = General.getYearsUntilNow(fechaNac).ToString();
            }
        }

        private void txtAsegurado_Leave(object sender, EventArgs e)
        {
            if (txtAsegurado.Text != "S" && txtAsegurado.Text.Length > 0)
            {
                MessageBox.Show("Dato no valido ingrese vacio ó S ...", "Advertencia ...");
                txtAsegurado.Focus();
                return;
            }
        }

        private void txtIdPac_TextChanged(object sender, EventArgs e)
        {
            if (this.df == 0)
            {
                this.fil();
            }
        }

        private void txtNroHist_TextChanged(object sender, EventArgs e)
        {
            //if (this.df == 0)
            if (txtNroHist.Text.Length > 0)
            {
                this.fil();
            }
        }

        private void cmbTDoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
    }
}
