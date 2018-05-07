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
			if( lstConsultorios.Items.Count == 0 )
				return;

            if ( mntspList.Count > 0)
            {
                btnInicio.Enabled = btnAnterior.Enabled = false;
                btnSiguiente.Enabled = btnFin.Enabled = true;
            }

			i = 0;
            lstConsultorios.Select();
            lstConsultorios.EnsureVisible(i);
            lstConsultorios.Items[i].Selected = true;
            lstConsultorios.Items[i].Focused = true;
            lstConsultorios.Items[i].EnsureVisible();
            //this.ctb();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
			if( lstConsultorios.Items.Count == 0 )
				return;

			if( mntspList.Count > 0)
            {
                btnInicio.Enabled = btnAnterior.Enabled = true;
                btnSiguiente.Enabled = btnFin.Enabled = false;
            }

			i = mntspList.Count - 1;
            lstConsultorios.Select();
            lstConsultorios.EnsureVisible(i);
            lstConsultorios.Items[i].Selected = true;
            lstConsultorios.Items[i].Focused = true;
            lstConsultorios.Items[i].EnsureVisible();
            //this.ctb();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
			if( lstConsultorios.Items.Count == 0 )
				return;

			if( mntspList.Count > 0)
            {
                if ( i > 0)
                {
					i--;
                    lstConsultorios.Items[i].Selected = true;

                    btnAnterior.Enabled = btnInicio.Enabled = btnAnterior.Enabled = true;

                    if ( i == 0)
                    {
                        btnInicio.Enabled = btnAnterior.Enabled = false;
                        btnSiguiente.Enabled = btnFin.Enabled = true;
                    }
                }
            }

            lstConsultorios.Select();
            lstConsultorios.EnsureVisible(i);
            lstConsultorios.Items[i].Selected = true;
            lstConsultorios.Items[i].Focused = true;
            lstConsultorios.Items[i].EnsureVisible();
            //this.ctb();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
			if( lstConsultorios.Items.Count == 0 )
				return;

			if( mntspList.Count > 0)
            {
                if ( i < mntspList.Count - 1)
                {
					i++;
                    lstConsultorios.Items[i].Selected = true;

                    btnSiguiente.Enabled = btnInicio.Enabled = btnAnterior.Enabled = true;

                    if ( i == (mntspList.Count - 1))
                    {
                        btnInicio.Enabled = btnAnterior.Enabled = true;
                        btnSiguiente.Enabled = btnFin.Enabled = false;
                    }
                }

            }

            lstConsultorios.Select();
            lstConsultorios.EnsureVisible(i);
            lstConsultorios.Items[i].Selected = true;
            lstConsultorios.Items[i].Focused = true;
            lstConsultorios.Items[i].EnsureVisible();
            //this.ctb();
        }

        private void frmConsultorios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
				DialogResult = DialogResult.Cancel;
				Close();
            }
        }

        public void cet(string md = "")
        {
            frmCapEspTur frmCapEspTur = new frmCapEspTur(md.Length > 0 ? ie : md);
            frmCapEspTur.FormClosed += new FormClosedEventHandler(frmCapEspTur_FormClosed);
            frmCapEspTur.Show();
			Hide();
			les(md.Length > 0? ie : md);
        }

		private void LimpiaCampos()
		{
			txtDescripcion.Text = "";
			edtDescripcion.Text = "";
			txtCreacion.Text = "";
			txtLastUpdate.Text = "";
			lstTurnos.Items.Clear();			
			lstBuses.Items.Clear();
			cmbTipo.SelectedIndex = -1;
			cmbEstado.SelectedIndex = -1;
		}

        private void frmCapEspTur_FormClosed(object sender, FormClosedEventArgs e)
        {
			Show();
        }

        public void ctb()
        {
            lstBuses.Items.Clear();
            lstTurnos.Items.Clear();

			ie = mntspList[this.i]["Id_Consultorio"];
            string sp = General.bfc("Space", "11");

            string sql = "Select Id_Bus, Id_Esp, Bus, Alterno, Turno, Estado, TBus, Id_Emp, Fec_Ing, Us_Ing + " + sp + " As Us_Ing,Fec_Mod,Us_Mod + " + sp + " As Us_Mod From Buses Where LTrim(RTrim(Id_Esp))= '" + ie + "' Order By Bus";

			busList = General.GetDictionaryList(sql);

            for (int i = 0; i < busList.Count; i++)
            {
				busList[i]["Us_Ing"] = General.TradUser(busList[i]["Us_Ing"]);
				busList[i]["Us_Mod"] = General.TradUser(busList[i]["Us_Mod"]);
            }

            General.Fill(lstBuses, busList, new[] { "Bus", "TBus", "Fec_Mod", "Us_Mod" });
            btnEditar.Enabled = false;
            btnAgregar.Enabled = btnQuitar.Enabled = busList.Count > 0;

            if ( mntspList.Count > 0)
            {
				ie = mntspList[i]["Id_Consultorio"];
                txtDescripcion.Text = mntspList[i]["Descripcion"];
                cmbEstado.SelectedValue = mntspList[i]["Estado"];
                cmbTipo.SelectedValue = mntspList[i]["Tipo"];
                edtDescripcion.Text = mntspList[i]["Observacion"];
                txtCreacion.Text = General.TradUser(mntspList[i]["Us_Ing"]) + " - " + mntspList[i]["Fec_Ing"];
                txtLastUpdate.Text = General.TradUser(mntspList[i]["Us_Mod"]) + " - " + mntspList[i]["Fec_Mod"];
                //
                string tr = mntspList[i]["Turno"];
                string mc = tr != null && tr.Length > 0? tr.Substring(0, 1): "";
                //
                List<Dictionary<string, string>> tmptr = new List<Dictionary<string, string>>();
                foreach (Dictionary<string, string> item in mntspList )
                {
                    if (item["Id_Consultorio"] == ie )
                    {
                        Dictionary<string, string> newItem = new Dictionary<string, string>();
                        newItem["c"] = (mc == "0" && mc != "1" ? "NO CONTINUO" : (mc == "1" && mc != "0" ? "CONTINUO" : ""));
                        newItem["m"] = (mc.Length > 0 ? tr.Substring(1, 3) : "");
                        newItem["t"] = (mc.Length > 0 ? tr.Substring(4, 3) : "");
                        newItem["n"] = (mc.Length > 0 ? tr.Substring(7, 3) : "");
                        newItem["a"] = (mc.Length > 0 ? tr.Substring(10, 3) : "");
                        tmptr.Add(newItem);
                    }
                }
                General.Fill(lstTurnos, tmptr, new[] { "c", "m", "t", "n", "a" });

                //Deseleccionar todos
                //General.UnselectListView(lstConsultorios);
                //lstConsultorios.Items[this.i].Selected = true;
            }
            else
				hab(false);
        }

        public void hab(bool lst)
        {
            General.setAll<TextBox, bool>(panelEspecialidad, "Enabled", lst);
            General.setAll<ComboBox, bool>(panelEspecialidad, "Enabled", lst);
            General.setAll<Button, bool>(panelEspecialidad, "Enabled", lst);

            btnAgregar.Enabled = btnQuitar.Enabled = btnEditar.Enabled = false;
            chkEstado.Enabled = cmbEst.Enabled = lstConsultorios.Enabled = !lst;

            if ( iu )
                btnModificar.Enabled = lstBuses.Enabled = true;
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
			string st = "";
			if( cmbEst.SelectedIndex != -1 )
			{
				Ubigeo itm = (Ubigeo)cmbEst.SelectedItem;
				st = itm.IdUbigeo;
			}
			else
				st = cmbEst.SelectedIndex > 0? cmbEst.SelectedValue.ToString(): "";

			string io = Operativo.id_oper;

            lstConsultorios.Items.Clear();
            string sql = "Select * From Consultorios Where SubString(Id_Consultorio,1,3)= '" + io + "' And Estado Like '" + st + "%' Order By 2";
			mntspList = General.GetDictionaryList(sql);
            General.Fill(lstConsultorios, mntspList, new[] { "Descripcion", "Id_Consultorio" });

            if (typeof(T) == typeof(String))
            {
                for (int i = 0; i < mntspList.Count; i++)
                {
                    if ( mntspList[i]["Id_Consultorio"] == ie.ToString())
                    {
                        lstConsultorios.Items[i].Selected = true;
                        lstConsultorios.Select();
                    }
                }
            }
            else
                btnFin_Click(btnFin, new EventArgs());

			lblCantidad.Text = "Cantidad de Registros: " + lstConsultorios.Items.Count.ToString();

		}

        public bool viu()
        {
            string ne = txtDescripcion.Text;
            string io = Operativo.id_oper;

            string sql = "Select Sum(C)As C,Sum(T)As T From (Select Count(*)As C,0 As T From Consultorios Where LTrim(RTrim(Descripcion))='" + ne + "' And SubString(Id_Consultorio,1,3) = '" + io + "'" + (iu ? " And LTrim(RTrim(Id_Consultorio))<> '" + ie + "'" : "") + (mntspList[i]["Descripcion"] != ne && iu ? " Union All Select 0 As C,Count(*)As T From Tickets Where LTrim(RTrim(Id_Consultorio))= '" + ie + "'" : "") + ")As X";
            Dictionary<string, string> res = General.GetDictionary(sql);

            int c = int.Parse(res["C"]);
            int t = int.Parse(res["T"]);

            if (c > 0)
            {
                MessageBox.Show("Nombre de especialidad ya existe, verifique ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }

            if (t > 0)
            {
                ne = mntspList[i]["Descripcion"];
                MessageBox.Show("Nombre de especialidad no puede cambiarse ...\nexisten ventas realizadas para " + ne + ".", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtDescripcion.Text = ne;
                return false;
            }

            if (txtDescripcion.Text.Length == 0 || cmbEstado.SelectedIndex == -1 || cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos para grabar el registro ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
			if( chkEstado.Checked )
			{
				cmbEst.SelectedIndex = -1;
				cmbEst.Enabled = false;
			}
			else
			{
				cmbEst.Enabled = true;
				cmbEst.SelectedIndex = -1;
				lstConsultorios.Items.Clear();
				LimpiaCampos();
				lblCantidad.Text = "Cantidad de Registros: " + lstConsultorios.Items.Count.ToString();
				return;
			}

            //cmbEst.Enabled = !cmbEst.Enabled;
            cmbEst_SelectionChangeCommitted(cmbEst, new EventArgs());
			LimpiaCampos();
        }

        private void cmbEst_SelectionChangeCommitted(object sender, EventArgs e)
        {
			les("");
        }

        private void lstConsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
			i = General.GetSelectedIndex(lstConsultorios);
			ctb();
        }

        private void lstConsultorios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
				cet();

            if (e.KeyCode == Keys.F3)
				cet("C");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNewBus frmNewBus = new frmNewBus(ie, "", null, "Agregar consultorio");
            frmNewBus.FormClosed += new FormClosedEventHandler(frmNewBus_FormClosed);
            frmNewBus.Show();
			Hide();
			ctb();
        }

        private void frmNewBus_FormClosed(object sender, FormClosedEventArgs e)
        {
			Show();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int index = General.GetSelectedIndex(lstBuses);

            if ( ie.Length > 0)
            {
                string ic = busList[index]["Id_Bus"];
                string nb = busList[index]["Bus"];

                string sql = "Select Sum(C)As C From(Select Count(*)As C From Cab_Cie10 Where LTrim(RTrim(Id_Bus))='" + ic + "' Union All Select Count(*)As C From Tickets Where LTrim(RTrim(Id_Bus))='" + ic + "')X";

                int c = Conexion.ExecuteScalar<int>(sql);

                if (c > 0)
                {
                    MessageBox.Show("No puede eliminar el consultorio " + nb + ", por encontrarse en uso ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

                if (MessageBox.Show("Esta seguro de eliminar el consultorio " + nb + " ... ?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    return;

                string sql2 = "Delete From Buses Where LTrim(RTrim(Id_Bus)) = '" + ic + "'";
                Conexion.ExecuteNonQuery(sql2);
				ctb();
            }
            else
            {
                MessageBox.Show("No hay consultorios a eliminar ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                btnQuitar.Enabled = btnEditar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if ( mntspList.Count > 0)
            {
                if (btnModificar.Text == "&Modificar")
                {
                    btnModificar.Text = "&Grabar";
					iu = true;
					hab(true);
					btnAgregar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnQuitar.Enabled = lstBuses.Items.Count > 0;
                }
                else
                {
                    if (MessageBox.Show("Desea guardar los cambios ... ?", "Mensaje al Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        if ( viu())
                        {
                            string ne = txtDescripcion.Text;
                            string st = cmbEstado.SelectedValue.ToString();
                            string tp = cmbTipo.SelectedValue.ToString();
                            string ob = txtDescripcion.Text;
                            string iu = Usuario.id_us;

                            string sql = "Update consultorios Set descripcion = '" + ne + "', estado = '" + st + "', tipo = '" + tp + "', observacion = '" + ob + "', us_mod = '" + iu + "', fec_mod = GetDate() Where LTrim(RTrim(id_consultorio)) = '" + ie + "'";
                            Conexion.ExecuteNonQuery(sql);
                            General.chgst("Consultorios", ie, st);
                        }
                        else
                            return;
                    }

                    btnModificar.Text = "&Modificar";
                    btnNuevo.Enabled = true;
                    btnEliminar.Enabled = true;
					hab(false);
					les(ie);
                    this.iu = false;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = General.GetSelectedIndex(lstBuses);

            if (lstBuses.Items.Count == 0)
            {
                MessageBox.Show("No hay consultorios (Buses) a editar ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                btnQuitar.Enabled = btnEditar.Enabled = false;
                return;
            }

            //Cargar formulario
            frmNewBus frmNewBus = new frmNewBus(ie, busList[index]["Id_Bus"], busList[index], "Editar bus");
            frmNewBus.FormClosed += new FormClosedEventHandler(frmNewBus_FormClosed);
            frmNewBus.Show();
			Hide();
			ctb();
        }
		
        private void lstBuses_Validated(object sender, EventArgs e)
        {
			if( lstBuses.Items.Count != 0 )
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
                    MessageBox.Show("No puede eliminar el registro ... existen ventas para esta especialidad ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

                string sql2 = "Select Count(*)As C From Buses Where LTrim(RTrim(Id_Esp)) = '" + ie + "'";
                int c2 = Conexion.ExecuteScalar<int>(sql2);

                if (c2 > 0)
                {
                    MessageBox.Show("No puede eliminar el registro ... existen consultorios creados ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

                if (MessageBox.Show("Esta seguro de eliminar la Especialidad " + txtDescripcion.Text + " ... ?", "Advertencia de eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    string sql3 = "Delete From Consultorios Where LTrim(RTrim(Id_Consultorio)) = '" + ie + "'";
                    Conexion.ExecuteNonQuery(sql3);
					les("");
                }
				LimpiaCampos();
            }
        }

        private void frmConsultorios_Load(object sender, EventArgs e)
        {
			string vSQL = "SELECT Descripcion, Id_Tipo AS IdUbigeo " +
							"FROM tablatipo " +
							"WHERE id_tabla = 3 " +
							"ORDER BY 1";
			General.LlenaComboBox(cmbEst, "SQL", vSQL);
			estadoRegistroTableAdapter.Fill(tablaTipoDS.EstadoRegistro);
			modalidadTableAdapter.Fill(modalidadDS.Modalidad);
            cmbEst.SelectedIndex = -1;
			les("");
            btnInicio_Click(btnInicio, new EventArgs());
			LimpiaCampos();
        }

        private void lstBuses_Enter(object sender, EventArgs e)
        {
			if( lstBuses.Items.Count!=0 )
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
				hab(true);
            }
            else {
                if (MessageBox.Show("Desea guardar los datos ... ?", "Mensaje al usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    if ( viu())
                    {
                        string ne = txtDescripcion.Text;
                        string st = cmbEstado.SelectedValue.ToString();
                        //string tp = cmbTipo.SelectedIndex > 0 ? cmbTipo.SelectedValue.ToString() : "";
						string tp = cmbTipo.SelectedValue.ToString();
						string ob = edtDescripcion.Text;
                        string iu = Usuario.id_us;
                        string io = Operativo.id_oper;

                        string sql = General.exsp("addconsultorio", General.TDB) + "'" + ne + "', '" + st + "', '', '" + tp + "', '" + io + "', '" + ob + "', '" + iu + "'" + General.exsp("", General.TDB);
                        Conexion.ExecuteNonQuery(sql);
                    }
                    else
                        return;
                }

                this.iu = false;
                btnNuevo.Text = "&Nuevo";
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
				hab(false);
				les("");
            }

        }

		private void cmbEst_SelectedIndexChanged( object sender, EventArgs e )
		{
			LimpiaCampos();
		}
	}
}
