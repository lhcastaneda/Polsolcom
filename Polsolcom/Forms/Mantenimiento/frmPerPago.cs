using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
    public partial class frmPerPago : Form
    {
        public int iou = 0;
        public int index = 0;
        List<Dictionary<string, string>> perPago = new List<Dictionary<string, string>>();

        public frmPerPago()
        {
            InitializeComponent();
        }

        public void habil(bool lm)
        {
            General.setAll<Button, bool>(this, "Enabled", !lm);
            txtPeriodo.Enabled = lm;

            txtBuscar.Enabled = lstPeriodos.Enabled = !lm;

            if (this.iou == 0)
            {
                string fec = Conexion.ExecuteScalar<string>("Select Max(Date_End)Fec From PerPago");

                dtpInicioPer.Value = DateTime.Parse(fec);
                dtpFinalPer.Value = DateTime.Now;
                btnNuevo.Enabled = true;

                if (lm)
                {
                    General.setAll<TextBox, string>(this, "Text", "");
                }
            }
            else
            {
                btnModificar.Enabled = true;
            }
        }

        public void lprpg(string lcr)
        {
            lstPeriodos.Items.Clear();

            string sql = "Select * From PerPago Where Name_Per Like '%" + lcr + "%' Order By 1";
            this.perPago = General.GetDictionaryList(sql);
            General.FillListView(lstPeriodos, this.perPago, new[] { "Name_Per", "Id_Per" });

            if (txtIdPer.Text.Length == 0 && this.perPago.Count > 0)
            {
                this.index = 0;
            }
            else
            {
                this.index = this.perPago.FindIndex(x => x["Id_Per"] == txtIdPer.Text);

                if (this.index == -1)
                {
                    this.index = 0;

                }
            }

            //lstPeriodos.Select();
            lstPeriodos.EnsureVisible(this.index);
            lstPeriodos.Items[this.index].Selected = true;
            lstPeriodos.Items[this.index].Focused = true;
            lstPeriodos.Items[this.index].EnsureVisible();
            lstPeriodos_SelectedIndexChanged(lstPeriodos, new EventArgs());
        }

        public bool validar()
        {
            if (txtPeriodo.Text.Length == 0)
            {
                MessageBox.Show("Ingrese nombre del periodo", "Advertencia");
                return false;
            }

            /*
             * IF EMPTY(.cntfec_ini.cmbfecha.object.value) .OR. EMPTY(.cntfec_fin.cmbfecha.object.value)
       MESSAGEBOX('Seleccione el rango de fechas', 48, 'Advertencia')
       RETURN TO cancel 
    ENDIF
    */
            string xnp = txtPeriodo.Text;
            string xfi = dtpInicioPer.Value.ToShortDateString();
            string xff = dtpFinalPer.Value.ToShortDateString();

            string sql = "Select (Select Id_Per From PerPago Where Name_Per='" + xnp + "')N, (Select Id_Per From PerPago Where Date_Ini='" + xfi + "' And Date_End='" + xff + "')D";
            Dictionary<string, string> nmp = General.GetDictionary(sql);
            string n = nmp["N"];
            string d = nmp["D"];

            if (this.iou == 0)
            {
                if (n.Length > 0)
                {
                    MessageBox.Show("Nombre de periodo ya existe ...", "Advertencia");
                    return false;
                }

                if (d.Length > 0)
                {
                    MessageBox.Show("Rango de fecha ya se esta utilizando ...", "Advertencia");
                    return false;
                }
            }
            else
            {
                if (n != txtIdPer.Text && n.Length > 0)
                {
                    MessageBox.Show("Nombre de periodo ya existe ...", "Advertencia");
                    return false;
                }

                if (d != txtIdPer.Text && d.Length > 0)
                {
                    MessageBox.Show("Rango de fecha ya se esta utilizando...", "Advertencia");
                    return false;
                }
            }

            return true;
        }

        private void frmPerPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void frmPerPago_Load(object sender, EventArgs e)
        {
            dtpInicioPer.Value = DateTime.Today;
            dtpFinalPer.Value = DateTime.Today;
            this.lprpg("");
        }

        private void lstPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPeriodos.Items.Count > 0)
            {
                this.index = General.GetSelectedIndex(lstPeriodos);

                if (this.index > -1)
                {
                    dtpInicioPer.Value = DateTime.Parse(this.perPago[this.index]["Date_Ini"]);
                    dtpFinalPer.Value = DateTime.Parse(this.perPago[this.index]["Date_End"]);
                    txtIdPer.Text = this.perPago[this.index]["Id_Per"];
                    txtPeriodo.Text = this.perPago[this.index]["Name_Per"];
                    txtCreation.Text = General.TradUser(this.perPago[this.index]["Us_Ins"]) + " - " + DateTime.Parse(this.perPago[this.index]["Date_Ins"]).ToShortDateString();
                    txtLastUpDate.Text = General.TradUser(this.perPago[this.index]["Us_Up"]) + " - " + DateTime.Parse(this.perPago[this.index]["Date_Up"]).ToShortDateString();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.lprpg(txtBuscar.Text);
        }

        private void dtpFinalPer_ValueChanged(object sender, EventArgs e)
        {
            dtpInicioPer_ValueChanged(dtpInicioPer, new EventArgs());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "&Nuevo")
            {
                btnNuevo.Text = "&Grabar";
                this.iou = 0;
                this.habil(true);
                dtpInicioPer.Focus();
            }
            else
            {
                if (MessageBox.Show("Desea guardar los cambios ... ?", "Aviso al usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (this.validar())
                    {
                        string xfi = dtpInicioPer.Value.ToShortDateString();
                        string xff = dtpFinalPer.Value.ToShortDateString();
                        string xnp = txtPeriodo.Text;

                        string sql = "Declare @res Varchar(7) Exec MaxValor 'Id_Per','PerPago','1',@ret=@res Output Exec GenUniCod @res,@ret=@res Output Insert Into PerPago Values(@res,'" + xnp + "','" + xfi + "','" + xff + "','','" + Usuario.id_us + "',GetDate(),'" + Usuario.id_us + "',GetDate()) Select @res Ret";
                        string ret = Conexion.ExecuteScalar<string>(sql);

                        txtIdPer.Text = ret;

                        MessageBox.Show("Operación completada con éxito", "Éxito");

                    }
                }

                this.habil(false);
                this.lprpg("");
                btnNuevo.Text = "&Nuevo";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstPeriodos.Items.Count > 0 && txtIdPer.Text.Length > 0)
            {
                if (btnModificar.Text == "&Modificar")
                {
                    btnModificar.Text = "&Grabar";
                    this.iou = 1;
                    this.habil(true);
                    dtpInicioPer.Focus();
                }
                else
                {
                    if (MessageBox.Show("Desea guardar los cambios ... ?", "Aviso al usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if(this.validar())
                        {
                            string xip = txtIdPer.Text;
                            string xfi = dtpInicioPer.Value.ToShortDateString();
                            string xff = dtpFinalPer.Value.ToShortDateString();
                            string xnp = txtPeriodo.Text;

                            string sql = "Update PerPago Set Name_Per='" + xnp + "',Date_Ini='" + xfi + "',Date_End='" + xff + "',Us_Up='" + Usuario.id_us + "',Date_Up=GetDate() Where Id_Per='" + xip + "'";
                            Conexion.ExecuteNonQuery(sql);
                            MessageBox.Show("Operación completada con éxito", "Éxito");
                        }
                    }

                    this.habil(false);
                    this.lprpg("");
                    btnNuevo.Text = "&Modificar";
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstPeriodos.Items.Count > 0 && txtIdPer.Text.Length > 0)
            {
                string crt = txtIdPer.Text;
                int c = Conexion.ExecuteScalar<int>("Select Count(*)C From Cab_Cie10 Where Id_Per='" + crt + "'");

                if (c > 0)
                {
                    MessageBox.Show("No puede eliminar registro ... se esta utilizando ...", "Advertencia");
                }
                else
                {
                    string sql = "Delete From PerPago Where Id_Per='" + crt + "'";
                    Conexion.ExecuteNonQuery(sql);
                    txtIdPer.Text = "";
                    this.lprpg("");
                    MessageBox.Show("Operación completada con éxito", "Éxito");
                }
            }
        }

        private void dtpInicioPer_ValueChanged(object sender, EventArgs e)
        {
            DateTime xfi = dtpInicioPer.Value;
            DateTime xff = dtpFinalPer.Value;

            string spr = "Del " + xfi.Day + " de " + xfi.ToString("MMM", CultureInfo.InvariantCulture) + " del " + xfi.Year + " al " + xff.Day + " de " + xff.ToString("MMM", CultureInfo.InvariantCulture) + " del " + xff.Year;
            txtPeriodo.Text = spr.ToUpper();
        }
    }
}
