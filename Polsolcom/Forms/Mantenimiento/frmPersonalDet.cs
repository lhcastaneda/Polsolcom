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
            this.rechargeFam();
            this.rechargeEst();
            this.rechargeExp();

            string sql = "Select Proyeccion,Capacitacion,Centro_Capac,Otras_Capac,Salud,Ult_Eva_Med,Ult_Diagnostico," + "Grp_Sang,Afi_Dep,Instr_Musical,Canta,Tipo_Musica,Hobby From Personal Where Id_Personal='" + this.id_personal + "'";
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
            txtFechaUltima.Text = datos["Ult_Eva_med"].Length == 0 ? General.emptyDate : datos["Ult_Eva_med"];
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
            General.FillListView(lstEst, this.estudios, new[] { "Training_Center", "Date_Ini", "Date_End", "Speciality", "Title_Degree" });
        }

        public void rechargeExp()
        {
            string sql = "Select Name_Entity,End_Position,Date_Ini,Date_End From Exp_Personal Where Id_Personal='" + this.id_personal + "'";
            this.experiencia = General.GetDictionaryList(sql);
            General.FillListView(lstExp, this.experiencia, new[] { "Name_Entity","End_Position","Date_Ini","Date_End" });
        }

        public void rechargeFam()
        {
            string sql = "Select Id_Parent,Ape_Paterno,Ape_Materno,Nombres,DNI,Fecha_Nac From Fam_Personal Where Id_Personal='" + this.id_personal + "'";
            this.familia = General.GetDictionaryList(sql);
            General.FillListView(lstFam, this.familia, new[] { "Id_Parent", "Ape_Paterno", "Ape_Materno", "Nombres", "DNI", "Fecha_Nac" });
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string ip = this.id_personal;
            string pr = edtProyeccion.Text;
            string cp = edtCapacitacion.Text;
            string cc = edtCentro.Text;
            string oa = edtOtrasAlt.Text;
            string es = "";
            if (optBueno.Checked)
            {
                es = "M";
            }
            if (optMuyBueno.Checked)
            {
                es = "B";
            }
            if (optRegular.Checked)
            {
                es = "R";
            }
            string ue = txtFechaUltima.Text;
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

            string sql = "Update Personal Set Proyeccion = '" + pr + "', Capacitacion = '" + cp + "', Centro_Capac = '" + cc + "', Otras_Capac = '" + oa + "', Salud = '" + es + "', " + "Ult_Diagnostico = '" + ud + "', Grp_Sang = '" + gs + "', Afi_Dep = '" + ad + "', Instr_Musical = '" + im + "', Canta = '" + cn + "', Tipo_Musica = '" + tm + "', Hobby = '" + hb + "',";
            sql += txtFechaUltima.Text.Length > 0 ? "Ult_Eva_Med='" + ue + "'" : "";
            sql += "Us_Mod='" + us + "',Fec_Mod=GetDate() Where Id_Personal='" + ip + "'";
            Conexion.ExecuteNonQuery(sql);


        }
    }
}
