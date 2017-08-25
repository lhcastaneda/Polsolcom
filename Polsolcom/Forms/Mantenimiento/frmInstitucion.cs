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
        int index = 0;
        List<Dictionary<string, string>> RepInst = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> ModTrans = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> InstitucionList = new List<Dictionary<string, string>>();

        public frmInstitucion()
        {
            InitializeComponent();
        }

        public void busins(string sins, string sdoc, string lest, string sopc)
        {
            lstInstitucion.Items.Clear();

            string sql = "Select * From Institucion Where Nom_Raz_Soc Like '%" + sins + "%' And RUC Like '" + sdoc + "%' And Estado Like '" + lest + "%' Order By Nom_Raz_soc";
            this.InstitucionList = General.GetDictionaryList(sql);

            General.FillListView(lstInstitucion, this.InstitucionList, new[] { "Nom_Raz_Soc", "RUC" });

            if (sopc.Length == 0)
            {
                this.index = 0;
            }
            else
            {
                this.index = this.InstitucionList.FindIndex(x => x["Nom_Raz_Soc"] == sopc);
            }

            lstInstitucion.Items[this.index].Selected = true;
            lstInstitucion_SelectedIndexChanged(lstInstitucion, new EventArgs());
        }

        public void clears()
        {
            General.setAll<TextBox, string>(this, "Text", "");
            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);
            General.setAll<CheckBox, bool>(this, "Checked", false);
            this.Refresh();
        }

        public void habil(bool lest)
        {
            General.setAll<TextBox, bool>(this, "Enabled", lest);
            General.setAll<ComboBox, bool>(this, "Enabled", lest);
            General.setAll<CheckBox, bool>(this, "Enabled", lest);
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

            if (cmbTIns.SelectedValue.ToString() == "T" || cmbModTrans.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione modalidad de transporte ...", "Advertencia");
                return false;
            }

            if (cmbRepresent.SelectedIndex != -1 && txtRepresent.Text.Length > 0)
            {
                MessageBox.Show("Verifique representante ... solo debe ingresarse una vez ...", "Advertencia");
                return false;
            }

            return true;
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {

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

        }

        private void frmInstitucion_Load(object sender, EventArgs e)
        {
            string sql1 = "Select Ape_Paterno + ' ' + Ape_Materno + ', ' + Nombres Descripcion, Id_Personal From Personal Order By 1";
            this.RepInst = General.GetDictionaryList(sql1);

            string sql2 = "Select Descripcion,Id_Tipo From TablaTipo Where Id_Tabla In (Select Id_Tipo From TablaTipo Where Descripcion = 'MODALIDAD_TRANSPORTE' And Id_Tabla='0') Order By 2";
            this.ModTrans = General.GetDictionaryList(sql2);

            txtBuscar_TextChanged(txtBuscar, new EventArgs());
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstInstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Change");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }




    }
}
