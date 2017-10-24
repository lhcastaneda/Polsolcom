using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
    public partial class frmBuscaI : Form
    {
        List<Dictionary<string, string>> binsts = new List<Dictionary<string, string>>();
        public Dictionary<string, string> binst = new Dictionary<string, string>();

        public frmBuscaI()
        {
            InitializeComponent();
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            string cti = cmbTInst.SelectedIndex == -1 ? "" : cmbTInst.SelectedValue.ToString();
            string ccr = txtCriterio.Text;

            string sql = "Select Nom_Raz_Soc,Direccion,TInst+Id_Inst IdI From Institucion Where TInst Like '" + cti +"%' And Estado='1' And ";

            if (rb1.Checked)
            {
                sql += "Nom_Raz_Soc Like '%" + ccr + "%'";
            }
            else
            {
                sql += "Direccion  Like '%" + ccr + "%'";
            }

            this.binsts = General.GetDictionaryList(sql);
            General.Fill(lstBuscar, this.binsts, new[] { "Nom_Raz_Soc", "Direccion" });
        }

        private void frmBuscaI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaTipoDS.TipoInstitucion' table. You can move, or remove it, as needed.
            this.tipoInstitucionTableAdapter.Fill(this.tablaTipoDS.TipoInstitucion);
            cmbTInst.SelectedIndex = -1;

        }

        private void cmbTInst_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCriterio_TextChanged(txtCriterio, new EventArgs());
        }

        private void cmbTInst_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    cmbTInst.SelectedIndex = -1;
                    break;
                case Keys.Enter:
                    txtCriterio_TextChanged(txtCriterio, new EventArgs());
                    break;
            }
        }

        private void lstBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBuscar.Items.Count > 0)
            {
                int i = General.GetSelectedIndex(lstBuscar);
                this.binst = this.binsts[i];
            }
    
        }

        private void lstBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    txtCriterio.Focus();
                    break;
                case Keys.Enter:
                    btnAceptar_Click(btnAceptar, new EventArgs());
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmBuscaI_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Cancel:
                    btnCancelar_Click(btnCancelar, new EventArgs());
                    break;
            }
        }

        private void lstBuscar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnAceptar_Click(btnAceptar, new EventArgs());
        }
    }
}
