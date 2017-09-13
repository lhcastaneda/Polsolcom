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
        int df = -1;

        List<Dictionary<string, string>> r0 = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> r1 = new List<Dictionary<string, string>>();

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
                if (this.df == 0)
                {
                    General.FillListView(lstPacientes, this.r0, new[] { "Cambiar" });
                }
                else
                {
                    General.FillListView(lstPacientes, this.r1, new[] { "Cambiar" });
                }

                lstPacientes.Items[0].Selected = true;
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

                string di = dupl["Id_Paciente"];
                string dd = dupl["DNI"];
                string dp = dupl["Nombre"] + ' ' + dupl["Ape_Paterno"] + ' ' + dupl["Ape_Materno"];

                nd = (this.iu == false ? (dd == nd ? "0" : "") : (dd == nd && di != txtIdPaciente.Text ? "0" : ""));

                if (nd == "0")
                {
                    if(MessageBox.Show("DNI " + dd + " pertenece a " + dp + " (" + di + ")" + ", verificar y corregir datos ...", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        txtDoc.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        public void fil(string lp)
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

                if (this.df == 0)
                {
                    General.FillListView(lstPacientes, this.r0, new[] { "Cambiar" });
                }
                else
                {
                    General.FillListView(lstPacientes, this.r1, new[] { "Cambiar" });
                }

                if (xp == null)
                {
                    lstPacientes.Items[0].Selected = true;
                }
                else
                {
                    lstPacientes.Items[0].Selected = true;
                }


                lstPacientes_SelectedIndexChanged(lstPacientes, new EventArgs());
            }

        }

        public void hab(bool ls, bool lm)
        {
            General.setAll<TextBox, bool>(this, "Enabled", ls);
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
            else {
                this.df = 1;
                txtApePat.Focus();
            }

            string[] tipos = new[] { "A", "O" };

            txtNombre.Enabled = txtApePaterno.Enabled = txtApeMaterno.Enabled = (tipos.Contains(Usuario.tipo) && ls);
            btnAnular.Enabled = tipos.Contains(Usuario.tipo) ? !ls : false;
            btnGrabar.Enabled = btnCancelar.Enabled = ls;
            txtIdPaciente.Enabled = false;
        }

        public bool hom()
        {
            string nm = txtNombre.Text;
            string ap = txtApePaterno.Text;
            string am = txtApeMaterno.Text;
            string nd = txtODoc.Text;

            if (nm.Length > 0 && ap.Length > 0 && am.Length > 0)
            {
                string sql = "Select Nombre,Ape_Paterno,Ape_Materno,DNI,Id_Paciente From Pacientes Where Nombre='" + nm + "' And Ape_Paterno='" + ap + " And Ape_Materno='" + am + "'";
                Dictionary<string, string> hom = General.GetDictionary(sql);

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

            return true;
        }

        public bool vob(bool lp)
        {
            if (lp)
            {
                if (txtAsegurado.Text == "A" && !(new[] { "A", "S" }).Contains(Usuario.tipo))
                {
                    MessageBox.Show("Este registro esta anulado ...", "Advertencia");
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

                if(cmbTDoc.SelectedIndex == -1 && txtX NOT.EMPTY(.txtodoc.value)).OR. ( .NOT.EMPTY(.cmbtdoc.value).AND.EMPTY(.txtodoc.value))
          MESSAGEBOX('El tipo y numero de otro documento son complementarios ... corrija ...', 48, 'Advertencia')
          .cmbtdoc.setfocus
          RETURN TO cancel
       ENDIF
            }
        }

        private void frmSeekPac_Load(object sender, EventArgs e)
        {
            if (this.df == -1)
            {
                this.KeyPreview = false;

                if (this.df == 1)
                {
                    txtIdPac.Visible = false;
                    txtNroHist.Visible = false;
                }

                General.setAll<Button, bool>(this, "Enabled", false);
                this.Text = "Mantenimiento del registro " + this.Text;
            }
            else
            {
                this.hab(false, false);
                this.Text = "Búsqueda " + this.Text;
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

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }
    }
}
