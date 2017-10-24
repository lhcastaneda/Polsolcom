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
    public partial class frmPersonalDet : Form
    {
        string id_personal;
        List<Dictionary<string, string>> estudios;
        List<Dictionary<string, string>> experiencia;
        List<Dictionary<string, string>> familia;

        public frmPersonalDet(string id_personal)
        {
            InitializeComponent();

            this.id_personal = id_personal;
        }

        private void frmPersonalDet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void frmPersonalDet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grupoSanguineo._GrupoSanguineo' table. You can move, or remove it, as needed.
            this.grupoSanguineoTableAdapter.Fill(this.grupoSanguineo._GrupoSanguineo);
            cmbGrupo.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.tablaTipoDS.Genero);
            cmbSexo.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.NivelEstudios' table. You can move, or remove it, as needed.
            this.nivelEstudiosTableAdapter.Fill(this.tablaTipoDS.NivelEstudios);
            cmbNivel.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.Parentesco' table. You can move, or remove it, as needed.
            this.parentescoTableAdapter.Fill(this.tablaTipoDS.Parentesco);
            cmbParent.SelectedIndex = -1;
            //
            this.rechargeFam();
            this.rechargeEst();
            this.rechargeExp();

            string sql = "Select Proyeccion,Capacitacion,Centro_Capac,Otras_Capac,Salud,Ult_Eva_Med,Ult_Diagnostico,Grp_Sang,Afi_Dep,Instr_Musical,Canta,Tipo_Musica,Hobby From Personal Where Id_Personal='" + this.id_personal + "'";
            Dictionary<string, string> datos = General.GetDictionary(sql);

            edtProyeccion.Text = datos["Proyeccion"];
            edtCapacitacion.Text = datos["Capacitacion"];
            edtCentro.Text = datos["Centro_Capac"];
            edtOtrasAlt.Text = datos["Otras_Capac"];
            switch (datos["Salud"])
            {
                case "M":
                    optMuyBueno.Checked = true;
                    break;
                case "B":
                    optBueno.Checked = true;
                    break;
                default:
                    optRegular.Checked = true;
                    break;
            }
            txtFechaUltima.Text = datos["Ult_Eva_Med"].Length == 0 ? General.emptyDate : datos["Ult_Eva_Med"];
            cmbGrupo.SelectedValue = datos["Grp_Sang"];
            txtDiagnostico.Text = datos["Ult_Diagnostico"];
            txtAficion.Text = datos["Afi_Dep"];
            txtInstrumental.Text = datos["Instr_Musical"];
            if (datos["Canta"] == "S")
            {
                optSi.Checked = true;
            }
            else {
                optNo.Checked = true;
            }
            txtTipoMusica.Text = datos["Tipo_Musica"];
            txtHobby.Text = datos["Hobby"];
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        public void rechargeEst()
        {
            string sql = "Select Training_Center,Date_Ini,Date_End,Speciality,Title_Degree From Est_Personal Where Id_Personal='" + this.id_personal + "'";
            this.estudios = General.GetDictionaryList(sql);
            General.Fill(lstEst, this.estudios, new[] { "Training_Center", "Date_Ini", "Date_End", "Speciality", "Title_Degree" });
        }

        public void rechargeExp()
        {
            string sql = "Select Name_Entity,End_Position,Date_Ini,Date_End From Exp_Personal Where Id_Personal='" + this.id_personal + "'";
            this.experiencia = General.GetDictionaryList(sql);
            General.Fill(lstExp, this.experiencia, new[] { "Name_Entity","End_Position","Date_Ini","Date_End" });
        }

        public void rechargeFam()
        {
            string sql = "Select Id_Parent,Ape_Paterno,Ape_Materno,Nombres,DNI,Fecha_Nac From Fam_Personal Where Id_Personal='" + this.id_personal + "'";
            this.familia = General.GetDictionaryList(sql);
            General.Fill(lstFam, this.familia, new[] { "Id_Parent", "Ape_Paterno", "Ape_Materno", "Nombres", "DNI", "Fecha_Nac" });
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string ip = this.id_personal;
            string pr = edtProyeccion.Text;
            string cp = edtCapacitacion.Text;
            string cc = edtCentro.Text;
            string oa = edtOtrasAlt.Text;
            string es = "";
            if (optMuyBueno.Checked)
            {
                es = "M";
            }
            if (optBueno.Checked)
            {
                es = "B";
            }
            if (optRegular.Checked)
            {
                es = "R";
            }
            string ue = txtFechaUltima.Text == General.emptyDate ? "": txtFechaUltima.Text;
            string ud = txtDiagnostico.Text;
            string gs = cmbGrupo.SelectedIndex == -1 ? "" : cmbGrupo.SelectedValue.ToString();
            string ad = txtAficion.Text;
            string im = txtInstrumental.Text;
            string cn = "";
            if (optSi.Checked)
            {
                cn = "S";
            }
            if (optNo.Checked)
            {
                cn = "N";
            }
            string tm = txtTipoMusica.Text;
            string hb = txtHobby.Text;
            string us = Usuario.id_us;

            string sql = "Update Personal Set Proyeccion = '" + pr + "', Capacitacion = '" + cp + "', Centro_Capac = '" + cc + "', Otras_Capac = '" + oa + "', Salud = '" + es + "', " + "Ult_Diagnostico = '" + ud + "', Grp_Sang = '" + gs + "', Afi_Dep = '" + ad + "', Instr_Musical = '" + im + "', Canta = '" + cn + "', Tipo_Musica = '" + tm + "', Hobby = '" + hb + "', ";
            sql += txtFechaUltima.Text.Length > 0 ? "Ult_Eva_Med='" + ue + "', " : ", ";
            sql += "Us_Mod='" + us + "', Fec_Mod=GetDate() Where Id_Personal='" + ip + "'";
            Conexion.ExecuteNonQuery(sql);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtFechaNac_Leave(object sender, EventArgs e)
        {
            txtEdad.Text = General.getYearsUntilNow(txtFechaNac.Text).ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ip = this.id_personal;
            string pr = cmbParent.SelectedIndex == -1 ? "" : cmbParent.SelectedValue.ToString();
            string ap = txtPaterno.Text;
            string am = txtMaterno.Text;
            string nm = txtNombres.Text;
            string sx = cmbSexo.SelectedIndex == -1 ? "" : cmbSexo.SelectedValue.ToString();
            string di = txtDNI.Text;
            string fn = txtFechaNac.Text == General.emptyDate ? "" : txtFechaNac.Text;
            string us = Usuario.id_us;

            if (pr.Length == 0 || ap.Length == 0 || am.Length == 0 || nm.Length == 0 || fn.Length == 0 || sx.Length == 0)
            {
                MessageBox.Show("Faltan datos para anexar este registro", "Aviso");
                return;
            }

            if (MessageBox.Show("Seguro de añadir este registro al personal", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string sql = "Insert Into Fam_Personal Values('" + ip + "','" + pr + "','" + ap + "','" + am + "','" + nm + "','" + fn + "','" + sx + "','" + di + "','" + us + "',GetDate(),'" + us + "',GetDate())";
            Conexion.ExecuteNonQuery(sql);

            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);
            General.setAll<TextBox, string>(this, "Text", "");
            General.setAll<MaskedTextBox, string>(this, "Text", "");

            this.rechargeFam();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstFam.Items.Count > 0)
            {
                int i = General.GetSelectedIndex(lstFam);

                string ip = this.id_personal + this.familia[i]["Id_Parent"] + this.familia[i]["Ape_Paterno"] + this.familia[i]["Ape_Materno"] + this.familia[i]["Nombres"];

                string sql = "Delete From Fam_Personal Where Id_Personal+Id_Parent+Ape_Paterno+Ape_Materno+Nombres='" + ip + "'";

                if (MessageBox.Show("Esta seguro de eliminar el registro actual", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                Conexion.ExecuteNonQuery(sql);

                this.rechargeFam();
            }
            else
            {
                MessageBox.Show("No hay qué eliminar", "Aviso");
            }
        }

        private void lstEst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitar2_Click(object sender, EventArgs e)
        {
            if (lstEst.Items.Count > 0)
            {
                int i = General.GetSelectedIndex(lstEst);

                string ip = this.id_personal + this.estudios[i]["Training_Center"] + this.estudios[i]["Speciality"] + this.estudios[i]["Title_Degree"];

                string sql = "Delete From Est_Personal Where Id_Personal+Training_Center+Speciality+Title_Degree='" + ip + "'";

                if (MessageBox.Show("Esta seguro de eliminar el registro actual", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                Conexion.ExecuteNonQuery(sql);

                this.rechargeEst();
            }
            else
            {
                MessageBox.Show("No hay qué eliminar", "Aviso");
            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            string ip = this.id_personal;
            string ce = txtCentro.Text;
            string fi = txtEstDel.Text == General.emptyDate ? "" : txtEstDel.Text;
            string fc = txtEstAl.Text == General.emptyDate ? "" : txtEstAl.Text;
            string nt = txtNroTitulo.Text;
            string es = txtEspecialidad.Text;
            string nv = cmbNivel.SelectedIndex == -1 ? "" : cmbNivel.SelectedValue.ToString();
            string tt = txtTitulo.Text;
            string us = Usuario.id_us;

            if (ce.Length == 0 || fi.Length == 0 || fc.Length == 0)
            {
                MessageBox.Show("Ingrese el centro de estudios y las fechas ...", "Aviso");
                return;
            }

            if (MessageBox.Show("Seguro de añadir este registro al personal", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string sql = "Insert Into Est_Personal Values('" + ip + "','" + nv + "','" + es + "','" + ce + "','" + fi + "','" + fc + "','" + tt + "','" + nt + "','" + us + "',GetDate(),'" + us + "',GetDate())";
            Conexion.ExecuteNonQuery(sql);

            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);
            General.setAll<TextBox, string>(this, "Text", "");
            General.setAll<MaskedTextBox, string>(this, "Text", "");

            this.rechargeEst();
        }

        private void btnQuitar3_Click(object sender, EventArgs e)
        {
            if (lstExp.Items.Count > 0)
            {
                int i = General.GetSelectedIndex(lstExp);

                string ip = this.id_personal + this.experiencia[i]["Name_Entity"] + this.experiencia[i]["End_Position"];

                string sql = "Delete From Exp_Personal Where Id_Personal+Name_Entity+End_Position='" + ip + "'";

                if (MessageBox.Show("Esta seguro de eliminar el registro actual", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                Conexion.ExecuteNonQuery(sql);

                this.rechargeExp();
            }
            else
            {
                MessageBox.Show("No hay qué eliminar", "Aviso");
            }
        }

        private void btnAgregar3_Click(object sender, EventArgs e)
        {
            string ip = this.id_personal;
            string cn = txtCentroLaboral.Text;
            string cr = txtCargo.Text;
            string fi = txtDesde.Text == General.emptyDate ? "" : txtDesde.Text;
            string fc = txtHasta.Text == General.emptyDate ? "" : txtHasta.Text;
            string us = Usuario.id_us;

            if (cn.Length == 0 || cr.Length == 0 || fi.Length == 0 || fc.Length == 0)
            {
                MessageBox.Show("Faltan datos para anexar registro", "Aviso");
                return;
            }

            if (MessageBox.Show("Seguro de añadir este registro al personal", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string sql = "Insert Into Exp_Personal Values('" + ip + "','" + cn + "','" + cr + "','" + fi + "','" + fc + "','" + us + "',GetDate(),'" + us + "',GetDate())";
            Conexion.ExecuteNonQuery(sql);

            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);
            General.setAll<TextBox, string>(this, "Text", "");
            General.setAll<MaskedTextBox, string>(this, "Text", "");

            this.rechargeExp();
        }
    }
}
