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
    public partial class frmConsultorios : Form
    {
        List<Dictionary<string, string>> buses = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> mntspList = new List<Dictionary<string, string>>();
        Dictionary<string, string> mntsp = new Dictionary<string, string>();
        public List<Consultorio> ListaConsultorios { get; set; }
        public List<string> ListaNombresConsultorios;
        bool iu = true;
        string sc = "";
        string ie = "";

        public frmConsultorios()
        {
            InitializeComponent();
            ListaNombresConsultorios = new List<string>();
            ListaConsultorios = General.TraerConsultorios();
            foreach (var item in ListaConsultorios)
            {
                ListaNombresConsultorios.Add(item.Descripcion);
            }
            ListaNombresConsultorios.Sort();
            lstConsultorios.DataSource = ListaNombresConsultorios;
            //
            btnInicio_Click(btnInicio, new EventArgs());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            lstConsultorios.SelectedIndex = 0;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            var final_index = lstConsultorios.Items.Count - 1;
            lstConsultorios.SelectedIndex = final_index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = lstConsultorios.SelectedIndex - 1;
            if (index >= 0)
                lstConsultorios.SelectedIndex = index;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var index = lstConsultorios.SelectedIndex + 1;
            if (index < lstConsultorios.Items.Count)
                lstConsultorios.SelectedIndex = index;
        }

        private void frmConsultorios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        public void cet(bool md = false)
        {
            //Cargar otro formulario
            /*
             hide
    DO FORM frmCapEspTur.scx WITH IIF(md, ALLTRIM(.ie), md)
    .show
    .les(IIF(md, ALLTRIM(.ie), md))
    .refresh
             */
        }

        public void ctb()
        {
            lstBuses.Items.Clear();
            lstTurnos.Items.Clear();

            this.ie = this.mntsp["Id_Consultorio"];
            string sp = General.bfc("Space", "11");

            string sql = "Select Id_Bus,Id_Esp,Bus,Alterno,Turno,Estado,TBus,Id_Emp,Fec_Ing,Us_Ing&sc&sp As Us_Ing,Fec_Mod,Us_Mod&sc&sp As Us_Mod From Buses Where LTrim(RTrim(Id_Esp))= '" + this.ie + "' Order By Bus";

            List < Dictionary < string, string>> this.buses = new List<Dictionary<string, string>>();

            for (int i = 0; i < this.buses.Count; i++)
            {
                this.buses[i]["Us_Ing"] = General.TradUser(this.buses[i]["Us_Ing"]);
                this.buses[i]["Us_Mod"] = General.TradUser(this.buses[i]["Us_Mod"]);
            }

            General.FillListView(lstBuses, this.buses, new[] { "Bus", "TBus", "Fec_Mod", "Us_Mod" });

            btnEditar.Enabled = false;

            btnAgregar.Enabled = btnQuitar.Enabled = this.buses.Count > 0;

            if (this.mntspList.Count > 0)
            {
                this.ie = this.mntsp["Id_Consultorio"];
                txtDescripcion.Text = this.mntsp["Descripcion"];
                cmbEstado.SelectedValue = this.mntsp["Estado"];
                cmbTipo.SelectedValue = this.mntsp["Tipo"];
                edtDescripcion.Text = this.mntsp["Observacion"];
                txtCreacion.Text = General.TradUser(this.mntsp["Us_Ing"]) + " - " + this.mntsp["Fec_Ing"];
                txtLastUpdate.Text = General.TradUser(this.mntsp["Us_Mod"]) + " - " + this.mntsp["Fec_Mod"];
                //
                string tr = this.mntsp["Turno"];
                string mc = tr.Substring(0, 1);
                //
                List<Dictionary<string, string>> tmptr = new List<Dictionary<string, string>>();
                foreach (Dictionary<string, string> item in this.mntspList)
                {
                    if (item["Id_Consultorio"] == this.ie)
                    {
                        Dictionary<string, string> newItem = new Dictionary<string, string>();
                        newItem["c"] = (mc == "0" && mc != "1" ? "NO CONTINUO" : (mc == "1" && mc != "0" ? "CONTINUO" : ""));
                        newItem["m"] = (mc.Length > 0 ? tr.Substring(2, 3) : "");
                        newItem["t"] = (mc.Length > 0 ? tr.Substring(5, 3) : "");
                        newItem["n"] = (mc.Length > 0 ? tr.Substring(8, 3) : "");
                        newItem["a"] = (mc.Length > 0 ? tr.Substring(11, 3) : "");
                        tmptr.Add(newItem);
                    }
                }

                General.FillListView(lstTurnos, tmptr, new[] { "c", "m", "t", "n", "a" });

                lstConsultorios.SelectedIndex = mntspList.IndexOf(mntsp);

            }
            else
            {
                this.hab(false);
            }

        }

        public void hab(bool lst)
        {
            General.setAll<TextBox, bool>(this, "Readonly", !lst);
            General.setAll<ComboBox, bool>(this, "Readonly", !lst);
            General.setAll<Button, bool>(this, "Enabled", lst);

            btnAgregar.Enabled = btnQuitar.Enabled = btnEditar.Enabled = false;
            chkEstado.Enabled = cmbEst.Enabled = lstConsultorios.Enabled = !lst;

            if (this.iu)
            {
                btnModificar.Enabled = lstBuses.Enabled = true;
            }
            else
            {
                General.setAll<TextBox, string>(this, "Value", "");
                General.setAll<ComboBox, string>(this, "SelectedValue", "");
                lstBuses.Items.Clear();
                lstTurnos.Items.Clear();
                btnNuevo.Enabled = true;
                cmbEstado.SelectedValue = "1";
            }
        }

        public void les<T>(T ie)
        {
            string st = cmbEst.SelectedValue.ToString();
            string io = Operativo.id_oper;

            lstConsultorios.Items.Clear();

            string sql = "Select * From Consultorios Where SubString(Id_Consultorio,1,3)= '" + io + "' And Estado Like '" + st + this.sc + "%' Order By 2";

            List<Dictionary<string, string>> mntsp = General.GetDictionaryList(sql);
            General.FillListView(lstConsultorios, mntsp, new[] { "Descripcion", "Id_Consultorio" });


            if (typeof(T) == typeof(String))
            {
                for (int i = 0; i < mntsp.Count; i++)
                {
                    if (mntsp[i]["Id_Consultorio"] == ie.ToString())
                    {
                        lstConsultorios.Items[i].Selected = true;
                        lstConsultorios.Select();
                    }
                }

            }
            else
            {
                btnFin_Click(btnFin, new EventArgs());
            }
        }

        public void viu()
        {
            string ne = txtDescripcion.Text;
            string io = Operativo.id_oper;

            string sql = "Select Sum(C)As C,Sum(T)As T From (Select Count(*)As C,0 As T From Consultorios Where LTrim(RTrim(Descripcion))='" + ne + "' And SubString(Id_Consultorio,1,3) = '" + io + (this.iu ? " And LTrim(RTrim(Id_Consultorio))<> '" + this.ie + "'" : "") + (this.mntsp["Descripcion"] != ne && this.iu ? " Union All Select 0 As C,Count(*)As T From Tickets Where LTrim(RTrim(Id_Consultorio))= '" + this.ie + "'" : "") + ")As X";
            Dictionary<string, string> res = General.GetDictionary(sql);

            int c = int.Parse(res["c"]);
            int t = int.Parse(res["t"]);

            if (c > 0)
            {
                MessageBox.Show("Nombre de especialidad ya existe, verifique ...", "Advertencia");
                return;
            }

            if (t > 0)
            {
                ne = mntsp["Descripcion"];
                MessageBox.Show("Nombre de especialidad no puede cambiarse ...\nexisten ventas realizadas para " + ne + ".", "Advertencia");
                txtDescripcion.Text = ne;
                return;
            }

            if (txtDescripcion.Text.Length == 0 || cmbEstado.SelectedIndex == -1 || cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos para grabar el registro ...", "Advertencia");
            }

            this.Refresh();
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            cmbEst.SelectedValue = chkEstado.Checked ? null : cmbEst.SelectedValue;
            cmbEst.Enabled = !cmbEst.Enabled;
            cmbEst_SelectionChangeCommitted(cmbEst, new EventArgs());


        }

        private void cmbEst_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.les<string>("");
        }

        private void lstConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ctb();
        }

        private void lstConsultorios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.cet();
            }

            if (e.KeyCode == Keys.F3)
            {
                this.cet(true);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*cargamos nuevo formulario*/
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (this.ie == "")
            {
                int index = General.GetSelectedIndex(lstBuses, true);
                Dictionary<string, string> bus = this.buses[index];
                string ic = bus["Id_Bus"];
                string nb = bus["Bus"];

                string sql = "Select Sum(C)As C From(Select Count(*)As C From Cab_Cie10 Where LTrim(RTrim(Id_Bus))='" + ic + "' Union All Select Count(*)As C From Tickets Where LTrim(RTrim(Id_Bus))='" + ic + "')X";

                int c = Conexion.ExecuteScalar<int>(sql);

                if (c > 0)
                {
                    MessageBox.Show("No puede eliminar el consultorio " + nb + ", por encontrarse en uso ...", "Advertencia");
                    return;
                }

                if (MessageBox.Show("Esta seguro de eliminar el consultorio " + nb + " ... ?", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }

                string sql2 = "Delete From Buses Where LTrim(RTrim(Id_Bus)) = '" + ic + "'";
                Conexion.ExecuteNonQuery(sql2);

                this.ctb();
            }
            else
            {
                MessageBox.Show("No hay consultorios a eliminar ...", "Aviso al usuario");
                btnQuitar.Enabled = btnEditar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string papaya = "";

            if (this.mntspList.Count > 0)
            {
                if (btnModificar.AccessibleDescription == "Modificar")
                {
                    btnModificar.AccessibleDescription = "Grabar";
                }

                this.iu = 1;
                this.hab(true);
                btnAgregar.Enabled = true;
                btnQuitar.Enabled = lstBuses.Items.Count > 0;
            }
            else
            {
                if (MessageBox.Show("Desea guardar los cambios ... ?", "Mensaje al Usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.viu();
                    string ne = txtDescripcion.Text;
                    string st = cmbEstado.SelectedValue.ToString();
                    string tp = cmbTipo.SelectedValue.ToString();
                    string ob = txtDescripcion.Text;
                    string iu = Usuario.id_us;

                    string sql = "Update consultorios Set descripcion = '" + ne + ", estado = '" + st + ", tipo = '" + tp + ", observacion = '" + ob + "', us_mod = '" + iu + "', fec_mod = GetDate() Where LTrim(RTrim(id_consultorio)) = '" + ie + "'";
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstBuses.Items.Count == 0)
            {
                MessageBox.Show("No hay consultorios (Buses) a editar ...", "Aviso al usuario");
                btnQuitar.Enabled = btnEditar.Enabled = false;
                return;
            }

            //Cargar formulario
            frmNewBus frmNewBus = new frmNewBus();
            frmNewBus.FormClosed += new FormClosedEventHandler(frmNewBus_FormClosed);
            frmNewBus.Show();
            this.Hide();
        }

        private void frmNewBus_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void lstBuses_Validated(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (mntspList.Count > 0)
            {
                string sql = "Select Count(*)As C From Tickets Where LTrim(RTrim(Id_Consultorio)) = '" + ie + "'";
                int c = Conexion.ExecuteScalar<int>(sql);

                if (c > 0)
                {
                    MessageBox.Show("No puede eliminar el registro ... existen ventas para esta especialidad ...", "Advertencia");
                    return;
                }

                string sql2 = "Select Count(*)As C From Buses Where LTrim(RTrim(Id_Esp)) = '" + ie + "'";
                int c2 = Conexion.ExecuteScalar<int>(sql2);

                if (c2 > 0)
                {
                    MessageBox.Show("No puede eliminar el registro ... existen consultorios creados ...", "Advertencia");
                    return;
                }

                if (MessageBox.Show("Esta seguro de eliminar la Especialidad " + txtDescripcion.Text + " ... ?", "Advertencia de eliminación", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sql3 = "Delete From Consultorios Where LTrim(RTrim(Id_Consultorio)) = '" + ie + "'";
                    Conexion.ExecuteNonQuery(sql3);
                    this.les<string>("");
                }
            }
        }
    }
}
