using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
    public partial class frmEspecialistas : Form
    {
        string idmb = "";
        bool nrg = false;
        List<Dictionary<string, string>> esbs = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> espbus = new List<Dictionary<string, string>>();
        public frmEspecialistas()
        {
            InitializeComponent();
        }

        public void clsa()
        {
            General.setAll<TextBox, string>(this, "Text", "");
            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);
            General.setAll<TextBox, string>(pnlEspec, "Text", "");
            General.setAll<ComboBox, int>(pnlEspec, "SelectedIndex", -1);
            //this.Refresh();
        }

        public void crgesp(bool lup)
        {
            if (lup)
            {
                string sql = "Select P.Ape_Paterno+' '+P.Ape_Materno+', '+P.Nombres Especialista,B.Bus,C.Descripcion,B.Id_Esp,MB.Id_Bus,MB.CMP,MB.Estado,MB.Obs,MB.Us_Ing,MB.Fec_Ing,MB.Us_Mod,MB.Fec_Mod,MB.Id_Bus+MB.CMP Idmb, P.TNCol " +
                    "From MedBus MB " +
                    "Inner Join Personal P On MB.CMP=P.Id_Personal " +
                    "Inner Join Buses B On MB.Id_Bus=B.Id_Bus " +
                    "Inner Join Consultorios C On B.Id_Esp=C.Id_Consultorio " +
                    "Order By 1,2";

                this.esbs = General.GetDictionaryList(sql);
                this.personalTableAdapter.Fill(this.personalDS.Personal);
            }

            this.espbus = this.esbs.FindAll(x => (x["Especialista"].Contains(txtEspecialista.Text) && x["TNCol"].Contains(txtNCP.Text)) && x["Descripcion"].Contains(txtEspecialidad.Text) && x["Bus"].Contains(txtConsultorio.Text) && x["Estado"].Contains(cmbEstList.SelectedIndex != -1 ? cmbEstList.SelectedValue.ToString() : ""));
            General.FillListView(lstBusMed, this.espbus, new[] { "Especialista", "Bus", "Idmb" });

            if (lstBusMed.Items.Count > 0)
            {
                int i = 0;

                if (this.idmb != "")
                {
                    int index = this.espbus.FindIndex(x => x["Idmb"] == this.idmb);

                    if (index != -1)
                    {
                        i = index;
                    }
                }

                lstBusMed.Select();
                lstBusMed.EnsureVisible(i);
                lstBusMed.Items[i].Selected = true;
                lstBusMed.Items[i].Focused = true;
                lstBusMed.Items[i].EnsureVisible();
                lstBusMed_SelectedIndexChanged(lstBusMed, new EventArgs());
            }
        }

        public void habil(bool lest)
        {
            cmbPersonal.Enabled = cmbTCol.Enabled = txtNCol.Enabled = txtRNE.Enabled = cmbEstado.Enabled = cmbEspecialidad.Enabled = cmbConsultorio.Enabled = txtObs.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = lest;
            btnNuevo.Enabled = btnEditar.Enabled = lstBusMed.Enabled = cmbEstList.Enabled = txtEspecialista.Enabled = txtEspecialidad.Enabled = txtConsultorio.Enabled = txtNCP.Enabled = !lest;
            //this.Refresh();
        }

        public void lcons()
        {
            string ie = cmbEspecialidad.SelectedIndex != -1 ? cmbEspecialidad.SelectedValue.ToString() : "";
            this.busesByIdEspTableAdapter.Fill(this.busesDS.BusesByIdEsp, ie);
            //this.Refresh();
        }

        public int vexis(string sql, string msg, bool cnd, string pex = "")
        {
            int c = Conexion.ExecuteScalar<int>(sql);

            if (!cnd ? c == 0 : c > 0)
            {
                MessageBox.Show(msg, "Advertencia");
                if (!cnd)
                {
                    Type thisType = this.GetType();
                    MethodInfo theMethod = thisType.GetMethod(pex);
                    theMethod.Invoke(this, null);
                }

                return 0;
            }
            else
                return c;
        }

        private void frmEspecialistas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaTipoDS.EstadoRegistro' table. You can move, or remove it, as needed.
            this.estadoRegistroTableAdapter.Fill(this.tablaTipoDS.EstadoRegistro);
            cmbEstList.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.TipoColegiatura' table. You can move, or remove it, as needed.
            this.tipoColegiaturaTableAdapter.Fill(this.tablaTipoDS.TipoColegiatura);
            // TODO: This line of code loads data into the 'personalDS.Personal' table. You can move, or remove it, as needed.
            this.personalTableAdapter.Fill(this.personalDS.Personal);
            //
            this.especialidadTableAdapter.Fill(this.consultoriosDS.Especialidad, Operativo.id_oper);
            //
            this.crgesp(true);

        }

        private void frmEspecialistas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void cmbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.lcons();
        }

        private void cmbPersonal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = cmbPersonal.SelectedIndex;

            if (i != -1)
            {
                DataRow item = ((DataRowView)cmbPersonal.SelectedItem).Row;

                cmbTCol.SelectedValue = item["TNCol"].ToString().Substring(0, 1);
                txtNCol.Text = item["TNCol"].ToString().Substring(1);
                txtRNE.Text = item["RNE"].ToString();
                //this.Refresh();
            }
        }

        private void cmbEstList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.crgesp(false);
            cmbEstList.Focus();
        }

        private void lstBusMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(lstBusMed);

            if (lstBusMed.Items[i].Selected)
            {
                if (this.espbus.Count > 0)
                {
                    this.idmb = this.espbus[i]["Idmb"];
                    cmbPersonal.SelectedValue = this.espbus[i]["CMP"];
                    cmbEstado.SelectedValue = this.espbus[i]["Estado"];
                    cmbEspecialidad.SelectedValue = this.espbus[i]["Id_Esp"];
                    cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
                    cmbConsultorio.SelectedValue = this.espbus[i]["Id_Bus"];
                    txtObs.Text = this.espbus[i]["Obs"];
                    txtCreacion.Text = General.TradUser(this.espbus[i]["Us_Ing"]) + " - " + this.espbus[i]["Fec_Ing"];
                    txtLastUpDate.Text = General.TradUser(this.espbus[i]["Us_Mod"]) + " - " + this.espbus[i]["Fec_Mod"];
                    cmbPersonal_SelectionChangeCommitted(cmbPersonal, new EventArgs());
                }
                else
                {
                    this.clsa();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nrg = true;
            this.habil(true);
            this.clsa();
            cmbEstado.SelectedValue = "1";
            cmbPersonal.Focus();
            //this.Refresh();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (cmbPersonal.SelectedIndex == -1 || cmbTCol.SelectedIndex == -1 || txtNCol.Text.Length == 0 || cmbConsultorio.SelectedIndex == -1 || cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos para grabar el registro ...", "Aviso al usuario");
                return;
            }

            string pk = this.idmb;
            string ib = cmbConsultorio.SelectedValue.ToString();
            string ip = cmbPersonal.SelectedValue.ToString();
            string st = cmbEstado.SelectedValue.ToString();
            string ob = txtObs.Text;
            string iu = Usuario.id_us;
            string cm = cmbTCol.SelectedValue.ToString() + txtNCol.Text;
            string rn = txtRNE.Text;

            string sql = "Select Count(*)C From MedBus Where Id_Bus='" + ib + "' And CMP='" + ip + "'";
            int c = Conexion.ExecuteScalar<int>(sql);

            if (c > 0)
            {
                if (this.nrg)
                {
                    MessageBox.Show("Ya existe el registro ...", "Advertencia");
                    return;
                }

                if (!this.nrg && ib + ip != pk)
                {
                    MessageBox.Show("Ya existe el registro ...", "Advertencia");
                    return;
                }
            }

            string msg = this.nrg ? "Desea ingresar el registro ... ?" : "Desea guardar los cambios ... ?";

            if (MessageBox.Show(msg, "Aviso de confirmacion", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            string usql = "";
            if (this.nrg)
            {
                usql = "Insert Into MedBus Values('" + ib + "', '" + ip + "', '" + st + "', '" + ob + "', '" + iu + "',GetDate(), '" + iu + "', GetDate()) Select Id_Bus+CMP Ret From MedBus Where Id_Bus='" + ib + "' And CMP='" + ip + "'";
            }
            else
            {
                int i = General.GetSelectedIndex(lstBusMed);

                if (ib != this.espbus[i]["Id_Bus"])
                {
                    usql = "Select Case When Exists(Select * From Cab_Cie10 Where Id_Bus+CMP='" + pk + "') Then 1 Else 0 End C";

                    int x = this.vexis(usql, "No puede modificar, ya existen registros procesados ... verifique", true, "");

                    if (x == 0)
                    {
                        return;
                    }
                }
                else
                {
                    usql = "Update MedBus Set Id_Bus = '" + ib + "', CMP = '" + ip + "', Estado = '" + st + "', Obs = '" + ob + "', Us_Mod = '" + iu + "', Fec_Mod = GetDate() Where Id_Bus + CMP = '" + pk + "'";
                }
            }

            Conexion.ExecuteNonQuery(usql);

            //Se entiende que USED servía ara comprobar que un cursor fue abierto por otro usuario, 
            //pero en esta aplicación ´debería ser indiferente
            //.idmb = IIF(USED('Ret'), ALLTRIM(ret.ret), ALLTRIM(.idmb))

           

            DataRow item = ((DataRowView)cmbPersonal.SelectedItem).Row;
            string xsql = "Update Personal Set " + (cm != item["TNCol"].ToString() ? "TNCol='" + cm + "'" : "");
            xsql += (rn != item["RNE"].ToString() ? (xsql.Contains("=") ? ", " : "") + "RNE = '" + rn + "'" : "");
            xsql += (xsql.Contains("=") ? " Where Id_Personal = '" + ip + "'" : "");

            if (xsql.Contains("Where"))
            {
                if (MessageBox.Show("Desea guardar cambios de CMP y RNE ... ?", "Aviso al usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Conexion.ExecuteNonQuery(xsql);
                }
            }

            this.crgesp(true);
            this.nrg = false;
            this.habil(false);

            txtEspecialista.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.nrg = false;
            this.habil(false);
            lstBusMed_SelectedIndexChanged(lstBusMed, new EventArgs());
            lstBusMed.Focus();
            //this.Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.nrg = false;
            this.habil(true);
            cmbPersonal.Focus();
            //this.Refresh();
        }

        private void txtEspecialista_TextChanged(object sender, EventArgs e)
        {
            this.crgesp(false);
            txtEspecialista.Focus();
        }

        private void txtConsultorio_TextChanged(object sender, EventArgs e)
        {
            this.crgesp(false);
            txtConsultorio.Focus();
        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {
            this.crgesp(false);
            txtEspecialidad.Focus();
        }

        private void txtNCP_TextChanged(object sender, EventArgs e)
        {
            this.crgesp(false);
            txtNCP.Focus();
        }
    }
}
