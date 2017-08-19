using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Forms.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
	public partial class frmConsultorios : Form
    {
        int i = 0;
        List<Dictionary<string, string>> busList = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> mntspList = new List<Dictionary<string, string>>();
        bool iu = false;
        string ie = "";

        public frmConsultorios()
        {
            InitializeComponent();

            cmbEst.SelectedIndex = -1;

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (this.mntspList.Count > 0)
            {
                btnInicio.Enabled = btnAnterior.Enabled = false;
                btnSiguiente.Enabled = btnFin.Enabled = true;
            }

            this.i = 0;
            lstConsultorios.Items[i].Selected = true;
            lstConsultorios.Items[i].Focused = true;
            lstConsultorios.Items[i].EnsureVisible();
            lstConsultorios.EnsureVisible(i);
            //this.ctb();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (this.mntspList.Count > 0)
            {
                btnInicio.Enabled = btnAnterior.Enabled = true;
                btnSiguiente.Enabled = btnFin.Enabled = false;
            }

            this.i = mntspList.Count - 1;
            lstConsultorios.Items[i].Selected = true;
            lstConsultorios.Items[i].Focused = true;
            lstConsultorios.Items[i].EnsureVisible();
            lstConsultorios.EnsureVisible(i);
            //this.ctb();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (this.mntspList.Count > 0)
            {
                if (this.i > 0)
                {
                    this.i--;
                    lstConsultorios.Items[this.i].Selected = true;

                    btnAnterior.Enabled = btnInicio.Enabled = btnAnterior.Enabled = true;

                    if (this.i == 0)
                    {
                        btnInicio.Enabled = btnAnterior.Enabled = false;
                        btnSiguiente.Enabled = btnFin.Enabled = true;
                    }
                }
            }

            lstConsultorios.Items[i].Selected = true;
            lstConsultorios.Items[i].Focused = true;
            lstConsultorios.Items[i].EnsureVisible();
            lstConsultorios.EnsureVisible(i);
            //this.ctb();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (this.mntspList.Count > 0)
            {
                if (this.i < this.mntspList.Count - 1)
                {
                    this.i++;
                    lstConsultorios.Items[i].Selected = true;

                    btnSiguiente.Enabled = btnInicio.Enabled = btnAnterior.Enabled = true;

                    if (this.i == (this.mntspList.Count - 1))
                    {
                        btnInicio.Enabled = btnAnterior.Enabled = true;
                        btnSiguiente.Enabled = btnFin.Enabled = false;
                    }
                }

            }
            lstConsultorios.Items[i].Selected = true;
            lstConsultorios.Items[i].Focused = true;
            lstConsultorios.Items[i].EnsureVisible();
            lstConsultorios.EnsureVisible(i);
            //this.ctb();
        }

        private void frmConsultorios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        public void cet(string md = "")
        {
            frmCapEspTur frmCapEspTur = new frmCapEspTur(md.Length > 0 ? this.ie: md);
            frmCapEspTur.Show();
            this.Hide();

            this.les<string>(md.Length > 0? this.ie : md);
        }

        public void ctb()
        {
            lstBuses.Items.Clear();
            lstTurnos.Items.Clear();

            this.ie = this.mntspList[this.i]["Id_Consultorio"];
            string sp = General.bfc("Space", "11");

            string sql = "Select Id_Bus, Id_Esp, Bus, Alterno, Turno, Estado, TBus, Id_Emp, Fec_Ing, Us_Ing + " + sp + " As Us_Ing,Fec_Mod,Us_Mod + " + sp + " As Us_Mod From Buses Where LTrim(RTrim(Id_Esp))= '" + this.ie + "' Order By Bus";

            this.busList = General.GetDictionaryList(sql);

            for (int i = 0; i < this.busList.Count; i++)
            {
                this.busList[i]["Us_Ing"] = General.TradUser(this.busList[i]["Us_Ing"]);
                this.busList[i]["Us_Mod"] = General.TradUser(this.busList[i]["Us_Mod"]);
            }

            General.FillListView(lstBuses, this.busList, new[] { "Bus", "TBus", "Fec_Mod", "Us_Mod" });

            btnEditar.Enabled = false;

            btnAgregar.Enabled = btnQuitar.Enabled = this.busList.Count > 0;

            if (this.mntspList.Count > 0)
            {
                this.ie = this.mntspList[this.i]["Id_Consultorio"];
                txtDescripcion.Text = this.mntspList[this.i]["Descripcion"];
                cmbEstado.SelectedValue = this.mntspList[this.i]["Estado"];
                cmbTipo.SelectedValue = this.mntspList[this.i]["Tipo"];
                edtDescripcion.Text = this.mntspList[this.i]["Observacion"];
                txtCreacion.Text = General.TradUser(this.mntspList[this.i]["Us_Ing"]) + " - " + this.mntspList[this.i]["Fec_Ing"];
                txtLastUpdate.Text = General.TradUser(this.mntspList[this.i]["Us_Mod"]) + " - " + this.mntspList[this.i]["Fec_Mod"];
                //
                string tr = this.mntspList[this.i]["Turno"];
                string mc = tr != null && tr.Length > 0? tr.Substring(0, 1): "";
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

                //Deseleccionar todos
                //General.UnselectListView(lstConsultorios);
                //lstConsultorios.Items[this.i].Selected = true;

            }
            else
            {
                this.hab(false);
            }
        }

        public void hab(bool lst)
        {
            General.setAll<TextBox, bool>(panelEspecialidad, "Enabled", lst);
            General.setAll<ComboBox, bool>(panelEspecialidad, "Enabled", lst);
            General.setAll<Button, bool>(panelEspecialidad, "Enabled", lst);

            btnAgregar.Enabled = btnQuitar.Enabled = btnEditar.Enabled = false;
            chkEstado.Enabled = cmbEst.Enabled = lstConsultorios.Enabled = !lst;

            if (this.iu)
            {
                btnModificar.Enabled = lstBuses.Enabled = true;
            }
            else
            {
                General.setAll<TextBox, string>(panelEspecialidad, "Text", "");
                General.setAll<ComboBox, int>(panelEspecialidad, "SelectedIndex", -1);
                lstBuses.Items.Clear();
                lstTurnos.Items.Clear();
                btnNuevo.Enabled = true;
                cmbEstado.SelectedValue = "1";
            }

            txtDescripcion.Focus();
        }

        public void les<T>(T ie)
        {
            string st = cmbEst.SelectedIndex > 0? cmbEst.SelectedValue.ToString(): "";
            string io = Operativo.id_oper;

            lstConsultorios.Items.Clear();

            string sql = "Select * From Consultorios Where SubString(Id_Consultorio,1,3)= '" + io + "' And Estado Like '" + st + "%' Order By 2";

            this.mntspList = General.GetDictionaryList(sql);
            General.FillListView(lstConsultorios, this.mntspList, new[] { "Descripcion", "Id_Consultorio" });

            if (typeof(T) == typeof(String))
            {
                for (int i = 0; i < this.mntspList.Count; i++)
                {
                    if (this.mntspList[i]["Id_Consultorio"] == ie.ToString())
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

        public bool viu()
        {
            string ne = txtDescripcion.Text;
            string io = Operativo.id_oper;

            string sql = "Select Sum(C)As C,Sum(T)As T From (Select Count(*)As C,0 As T From Consultorios Where LTrim(RTrim(Descripcion))='" + ne + "' And SubString(Id_Consultorio,1,3) = '" + io + "'" + (this.iu ? " And LTrim(RTrim(Id_Consultorio))<> '" + this.ie + "'" : "") + (this.mntspList[this.i]["Descripcion"] != ne && this.iu ? " Union All Select 0 As C,Count(*)As T From Tickets Where LTrim(RTrim(Id_Consultorio))= '" + this.ie + "'" : "") + ")As X";
            Dictionary<string, string> res = General.GetDictionary(sql);

            int c = int.Parse(res["C"]);
            int t = int.Parse(res["T"]);

            if (c > 0)
            {
                MessageBox.Show("Nombre de especialidad ya existe, verifique ...", "Advertencia");
                return false;
            }

            if (t > 0)
            {
                ne = this.mntspList[this.i]["Descripcion"];
                MessageBox.Show("Nombre de especialidad no puede cambiarse ...\nexisten ventas realizadas para " + ne + ".", "Advertencia");
                txtDescripcion.Text = ne;
                return false;
            }

            if (txtDescripcion.Text.Length == 0 || cmbEstado.SelectedIndex == -1 || cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos para grabar el registro ...", "Advertencia");
                return false;
            }

            return true;
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEstado.Checked)
            {
                cmbEst.SelectedIndex = -1;
            }
            cmbEst.Enabled = !cmbEst.Enabled;
            cmbEst_SelectionChangeCommitted(cmbEst, new EventArgs());
        }

        private void cmbEst_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.les<string>("");
        }

        private void lstConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.i = General.GetSelectedIndex(lstConsultorios);
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
                this.cet("C");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNewBus frmNewBus = new frmNewBus(this.ie, "", null, "Agregar consultorio");
            frmNewBus.FormClosed += new FormClosedEventHandler(frmNewBus_FormClosed);
            frmNewBus.Show();
            this.Hide();
            //
            this.ctb();
        }

        private void frmNewBus_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int index = General.GetSelectedIndex(lstBuses);

            if (this.ie.Length > 0)
            {
                string ic = this.busList[index]["Id_Bus"];
                string nb = this.busList[index]["Bus"];

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

            if (this.mntspList.Count > 0)
            {
                if (btnModificar.Text == "&Modificar")
                {
                    btnModificar.Text = "&Grabar";
                    this.iu = true;
                    this.hab(true);
                    btnNuevo.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnQuitar.Enabled = lstBuses.Items.Count > 0;
                }
                else
                {
                    if (MessageBox.Show("Desea guardar los cambios ... ?", "Mensaje al Usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (this.viu())
                        {
                            string ne = txtDescripcion.Text;
                            string st = cmbEstado.SelectedValue.ToString();
                            string tp = cmbTipo.SelectedValue.ToString();
                            string ob = txtDescripcion.Text;
                            string iu = Usuario.id_us;

                            string sql = "Update consultorios Set descripcion = '" + ne + "', estado = '" + st + "', tipo = '" + tp + "', observacion = '" + ob + "', us_mod = '" + iu + "', fec_mod = GetDate() Where LTrim(RTrim(id_consultorio)) = '" + ie + "'";
                            Conexion.ExecuteNonQuery(sql);
                            General.chgst("Consultorios", this.ie, st);
                        }
                        else
                        {
                            return;
                        }
                    }

                    btnModificar.Text = "&Modificar";
                    btnNuevo.Enabled = true;
                    btnEliminar.Enabled = true;
                    this.hab(false);
                    this.les<string>(this.ie);
                    this.iu = false;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = General.GetSelectedIndex(lstBuses);

            if (lstBuses.Items.Count == 0)
            {
                MessageBox.Show("No hay consultorios (Buses) a editar ...", "Aviso al usuario");
                btnQuitar.Enabled = btnEditar.Enabled = false;
                return;
            }

            //Cargar formulario
            frmNewBus frmNewBus = new frmNewBus(this.ie, this.busList[index]["Id_Bus"], this.busList[index], "Editar bus");
            frmNewBus.FormClosed += new FormClosedEventHandler(frmNewBus_FormClosed);
            frmNewBus.Show();
            this.Hide();
            this.ctb();
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

        private void frmConsultorios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modalidadDS.Modalidad' table. You can move, or remove it, as needed.
            this.modalidadTableAdapter.Fill(this.modalidadDS.Modalidad);
            // TODO: This line of code loads data into the 'estadosDS.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.estadosDS.Estados);
            cmbEst.SelectedIndex = -1;
            this.les<string>("");
            btnInicio_Click(btnInicio, new EventArgs());
        }

        private void lstBuses_Enter(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "&Nuevo")
            {
                btnNuevo.Text = "&Grabar";
                btnNuevo.Tag = "Guardar registro";
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                this.hab(true);
            }
            else {
                if (MessageBox.Show("Desea guardar los datos ... ?", "Mensaje al usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (this.viu())
                    {
                        string ne = txtDescripcion.Text;
                        string st = cmbEstado.SelectedValue.ToString();
                        string tp = cmbTipo.SelectedIndex > 0 ? cmbTipo.SelectedValue.ToString() : "";
                        string ob = txtDescripcion.Text;
                        string iu = Usuario.id_us;
                        string io = Operativo.id_oper;

                        string sql = General.exsp("addconsultorio", General.TDB) + "'" + ne + "', '" + st + "', '', '" + tp + "', '" + io + "', '" + ob + "', '" + iu + "'" + General.exsp("", General.TDB);
                        Conexion.ExecuteNonQuery(sql);
                    }
                    else {
                        return;
                    }
                }

                this.iu = false;

                btnNuevo.Text = "&Nuevo";
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                this.hab(false);
                this.les<string>("");
            }

        }

        private void lstConsultorios_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }
    }
}
