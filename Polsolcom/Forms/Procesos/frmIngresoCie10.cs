using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
    public partial class frmIngresoCie10 : Form
    {
        Dictionary<string, string> paciente;
        Dictionary<string, string> ticket;
        Dictionary<string, string> medic;
        List<Dictionary<string, string>> medics;
        List<Dictionary<string, string>> tickets;
        List<Dictionary<string, string>> pacientes;
        List<Dictionary<string, string>> tempDetVent;
        string nh;
        int dr;
        int iu;
        int pg;

        public frmIngresoCie10()
        {
            InitializeComponent();
            tempDetVent = new List<Dictionary<string, string>>();
        }

        private void frmIngresoCie10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tipoDocumento.TablaTipo' table. You can move, or remove it, as needed.
            this.tablaTipoTableAdapter.Fill(this.tipoDocumento.TablaTipo);
            this.consultoriosTableAdapter.Fill(this.consultoriosDS.Consultorios, Operativo.id_oper);
            //Hacemos que no salgan nseleccionados ningún ítem
            cmbEspecialidad.SelectedIndex = -1;
            cmbDVenta.SelectedIndex = -1;
        }

        private void chkFiltro_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ((CheckBox)sender).Checked;

            cmbEspecialidad.Enabled = !check;
            cmbDVenta.Enabled = !check;
            chkFechaVent.Enabled = !check;
            dtpFechaEmi.Enabled = !check && chkFechaVent.Checked;
            txtSerie.Enabled = !check;
        }

        private void txtNroDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNroDoc.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese Nro. de documento de venta ...", "Ingreso y consulta de atenciones realizadas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

                int count = pfv();
                chkFiltro.Focus();

                if (count == 0)
                {
                    MessageBox.Show("Documento de venta no existe o no corresponde a la especialidad, verifique ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    pcl();
                }
            }
        }

        public void pcl()
        {
            Conexion.ExecuteNonQuery("DELETE FROM #tmpDetVent");
            Conexion.ExecuteNonQuery("DELETE FROM #tmpCie10");

            int ne = cmbEspecialidad.SelectedIndex;
            DateTime fe = dtpFechaEmi.Value;
            int dv = cmbDVenta.SelectedIndex;
            string sr = txtSerie.Text;

            DateTime fa = dtpFechaAten.Value;
            int bs = cmbBus.SelectedIndex;
            int tr = cmbTurno.SelectedIndex;
            int cm = cmbMedico.SelectedIndex;
            string cn = txtCuenta.Text;

            clearFields();

            btnVerifica.Enabled = true;

            cmbEspecialidad.SelectedIndex = ne;
            dtpFechaEmi.Value = fe;
            cmbDVenta.SelectedIndex = dv;
            txtSerie.Text = sr;
            txtCuenta.Text = cn;

            if (chkIdem.Checked)
            {
                dtpFechaAten.Value = fa;
                cmbBus.SelectedIndex = bs;
                cmbTurno.SelectedIndex = tr;
                cmbMedico.SelectedIndex = cm;
                //txtMedico.Text = (cmbMedico.SelectedIndex == -1?"":medic.especialista)
            }

            dtpFechaAten.Value = fa;
            dtpFechaAten.Enabled = false;
            txtTi.Text = "0";
            txtTotal.Text = "0.00";
            txtNroDoc.Focus();
            Refresh();

        }

        void clearFields()
        { }

        DateTime hi;

        private int pfv()
        {
            this.hi = DateTime.Today;

            string vSQL = "";
            vSQL += "Select T.Serie,T.Nro_Ticket,";
            vSQL += tabIngresoConsulta.SelectedIndex == 1 ? "T.Fecha_Emision," : "CB.Fecha_Atencion,";
            vSQL += "T.Digitador+Space(11) Digitador,T.Nro_Historia,T.Id_Paciente,C.Descripcion,X.Orden,T.Anulado";
            vSQL += tabIngresoConsulta.SelectedIndex == 1 ?" ": ",T.Fecha_Emision ";
            vSQL += "From Tickets T Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " + "Inner Join (Select Ape_Paterno+' '+Ape_Materno+', '+Nombres+' ('+SubString(TNCol,2,6)+')' Orden,Id_Personal " + "From Personal Union All Select Descripcion,Id_Tipo From TablaTipo Where Id_Tabla In " + "(Select Id_Tipo From TablaTipo Where Descripcion='VAR_EXTRAS' And Id_Tabla='0'))X On T.CMP=X.Id_Personal ";
            vSQL += tabIngresoConsulta.SelectedIndex == 1 ?"": "Inner Join Cab_Cie10 CB On CB.Nro_Historia=T.Nro_Historia ";
            vSQL += "Where";

            if (tabIngresoConsulta.SelectedIndex == 0)
            {
                if (chkFiltro.Checked || General.vtrls(Especialidad.esp))
                {
                    vSQL += cmbEspecialidad.SelectedIndex != -1 ? (" T.Id_Consultorio Like '" + (((DataRowView)cmbEspecialidad.SelectedItem).Row["Id_Consultorio"]).ToString() + "'") : "";
                    vSQL += vSQL.Contains("Like") && cmbEspecialidad.SelectedIndex != -1 ? " And" : "";
                    vSQL += chkFechaVent.Checked ? (" T.Fecha_Emision Between '" + dtpFechaEmi.Value.ToString() + "' And '" + dtpFechaEmi.Value.AddDays(1).ToString() + "'") : "";
                    vSQL += vSQL.Contains("Like") && chkFechaVent.Checked ? " And" : "";
                    vSQL += cmbDVenta.SelectedIndex != -1 ? (" T.DVenta Like '" + (((DataRowView)cmbDVenta.SelectedItem).Row["Id_Tipo"]).ToString() + "'") : "";
                }

                vSQL += vSQL.Contains("Like") && cmbDVenta.SelectedIndex != -1 ? " And" : "";
                vSQL += txtSerie.Text.Length > 0 ? (" T.Serie Like '" + txtSerie.Text + "'") : "";
                vSQL += vSQL.Contains("Like") && txtSerie.Text.Length > 0 ? " And" : "";
                vSQL += txtNroDoc.Text.Length > 0 ? (" T.Nro_Ticket Like '" + txtNroDoc.Text + "'") : "";
            }
            else
            {
                vSQL += " T.Id_Paciente='" + paciente["id_paciente"] + "'";
            }

            lstTickets0.Items.Clear();
            lstTickets1.Items.Clear();

            tickets = General.GetDictionaryList(vSQL);

            //General.TradUser()
            if (tickets.Count > 0)
            {
                string[] fields = {"Serie", "Nro_Ticket", "Fecha_Emision", "Digitador" };

                if (tabIngresoConsulta.SelectedIndex == 0)
                {
                    General.FillListView(lstTickets0, tickets, fields);
                    lstTickets0.Focus();
                }
                else
                {
                    General.FillListView(lstTickets1, tickets, fields);
                    lstTickets1.Focus();
                }
            }

            return tickets.Count;
        }

        private void frmIngresoCie10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNroDoc.Focus();
            }
        }

        private void chkFechaVent_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaEmi.Enabled = chkFechaVent.Checked;
        }

        bool opened = false;

        private void lstTickets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index = General.GetSelectedIndex((ListView)sender);
                ticket = tickets[index];

                if (!opened)
                {
                    if (ticket["Anulado"] != "")
                    {
                        MessageBox.Show("N° de documento de venta esta anulado ...", "Anulado");
                        pcl();
                        return;
                    }

                    pfp(ticket["Id_Paciente"]);
                    pla();
                    opened = true;
                }

            }
        }


        public int vexis(string sql, string msg, bool cnd, string pex)
        {
            int c = Conexion.ExecuteScalar(sql);

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


        public void pfp(string lp = null)
        {
            string xp = lp;
            int np = tabIngresoConsulta.SelectedIndex;

            string pt = (np == 1 ? txtApePat.Text : "");
            string mt = (np == 1 ? txtApeMat.Text : "");
            string nm = (np == 1 ? txtNombre.Text : "");
            string ip = (lp == null ? txtIdPac.Text : xp);

            if ((pt.Length + nm.Length + ip.Length) > 0)
            {
                string sql = General.DevuelveQueryPaciente(pt, mt, nm, "", ip, "", 2, 0);
                pacientes = General.GetDictionaryList(sql);
                paciente = pacientes[0];
                General.FillListView(lstPacientes, pacientes, new string[] { "Paciente" });
            }

            if (np == 2)
            {
                lstTickets1.Items.Clear();
            }

            Refresh();
        }

        public void pla()
        {
            txtPaciente.Text = paciente["Ape_Paterno"] + " " + paciente["Ape_Materno"] + ", " + paciente["Nombre"] + " (" + paciente["Id_Paciente"] + ")";
            dtpFechaNac.Value = DateTime.Parse(paciente["Fecha_Nac"]);
            txtEdad.Text = paciente["Edad"];
            txtSexo.Text = paciente["Sexo"] == "M" ? "MASCULINO" : "FEMENINO";
            txtOrden.Text = ticket["Orden"];
            txtEspecialidad.Text = ticket["Descripcion"];
            dtpFechaEmiFil.Value = DateTime.Parse(ticket["Fecha_Emision"]);
            txtCajero.Text = "CAJERO: ( " + ticket["Digitador"] + " )";
            this.nh = ticket["Nro_Historia"];

            tempDetVent.Clear();

            string detSql = "Select D.*,P.Descripcion From Detalles D Inner Join Productos P On D.Id_Producto=P.Id_Producto Where Nro_Historia='" + this.nh + "'";
            List<Dictionary<string, string>> detalles = General.GetDictionaryList(detSql);

            double total = 0f;
            for (int i = 0; i < detalles.Count; i++)
            {
                double subtotal = Math.Round(int.Parse(detalles[i]["Cantidad"]) * double.Parse(detalles[i]["Monto"]), 2);
                total += subtotal;
                //
                detalles[i]["Subtotal"] = subtotal.ToString();
                detalles[i]["M"] = "1";
            }

            txtTotal.Text = total.ToString();

            string cabCie10Sql = "Select * From Cab_Cie10 Where Nro_Historia = '" + ticket["Nro_Historia"] + "'";
            Dictionary<string, string> cabCie10 = General.GetDictionary(cabCie10Sql);

            if (cabCie10.Count > 0)
            {
                if (tabIngresoConsulta.SelectedIndex == 0)
                {
                    MessageBox.Show("Ya fue procesada la historia clinica ...", "Advertencia");
                    string ia = Usuario.id_area;//REEMPLAZAR
                    string iu = cabCie10["Digitador"];
                    /*
                    //La siguiente línea no se pudo ejecutar
                    if (ia.Substring(0, 3) == Operativo.id_oper)//REEMPLAZAR
                    {
                        vexis("Select Count(*) as C From sysaccusers Where Id_Us = '" + iu + "' And Id_Area = '" + ia + "'", "Este registro no corresponde a su consultorio", false, "pcl");
                    }*/

                    txtNroDoc.Focus();
                }

                pce(true, true);//Change
                dtpFechaAten.Text = cabCie10["Fecha_Atencion"];
                cmbBus.SelectedValue = cabCie10["id_bus"];
                cmbTurno.SelectedValue = cabCie10["turno"];
                cmbMedico.SelectedValue = cabCie10["cmp"];
                txtMedico.Text = cmbMedico.SelectedIndex != -1 ? "" : medic["especialista"];
                txtDigitador.Text = General.TradUser(cabCie10["digitador"]);
                txtEnAcIni.Text = cabCie10["en_ac_ini"];
                txtEnAcCur.Text = cabCie10["en_ac_cur"];
                txtEnAcRel.Text = cabCie10["en_ac_rel"];
                txtAnPer.Text = cabCie10["an_per"];
                txtAnFam.Text = cabCie10["an_fam"];
                txtAnEpi.Text = cabCie10["an_epi"];
                txtAnQui.Text = cabCie10["an_qui"];
                txtAnOtr.Text = cabCie10["an_otr"];
                txtExClPs.Text = (cabCie10["ex_cl_ps"].Length == 0 ? "0.00" : cabCie10["ex_cl_ps"]);
                txtExClTl.Text = (cabCie10["ex_cl_tl"].Length == 0 ? "0.00" : cabCie10["ex_cl_tl"]);
                txtExClPa.Text = cabCie10["ex_cl_pa"];
                txtExClFc.Text = (cabCie10["ex_cl_fc"].Length == 0 ? "0" : cabCie10["ex_cl_fc"]);
                txtExClFr.Text = (cabCie10["ex_cl_fr"].Length == 0 ? "0" : cabCie10["ex_cl_fr"]);
                txtExClTm.Text = (cabCie10["ex_cl_tm"].Length == 0 ? "0" : cabCie10["ex_cl_tm"]);
                txtExClEg.Text = cabCie10["ex_cl_eg"];
                txtObservacion.Text = cabCie10["observacion"];
                dtpFechaIngreso.Value = DateTime.Parse(cabCie10["fecha_ingreso"]);

                //tmpCie10.Clear();

                string detCie10Sql = "Select DC.*,CI.Descripcion From Det_Cie10 DC Left Join Cie10 CI On DC.Cie10=CI.Cie10 Where Nro_Historia='" + this.nh + "'";
                List<Dictionary<string, string>> tmpCie10 = General.GetDictionaryList(detCie10Sql);
                this.dr = tmpCie10.Count;

                btnAgregar.Enabled = btnQuitar.Enabled = btnBCie10.Enabled = (dr > 0 && tabIngresoConsulta.SelectedIndex == 0);
                //btnImprimir.Enabled = (dr > 0);
                btnGrabar.Enabled = (tabIngresoConsulta.SelectedIndex == 0);

                string tratMedSql = "Select * From tratmed Where nro_reg='" + this.nh + "'";
                List<Dictionary<string, string>> tratMed = General.GetDictionaryList(tratMedSql);

                this.dr += tratMed.Count;
                this.iu = 1;
                this.pg = cabCie10["id_per"] != "" ? 1 : 0;

            }
            else
            {
                this.dr = 0;
                this.iu = 0;
                this.pg = 0;

                clearFields();

                btnVerifica.Enabled = true;
                cmbBus.SelectedValue = ("Usuario.id_area".Substring(0, 3) == "Operativo.id_oper") ? "Usuario.id_area" : cmbBus.SelectedValue;
                txtDigitador.Text = Usuario.usuario;
                //dtpFechaIngreso = NULL;
                if (chkIdem.Checked)
                {
                    dtpFechaAten.Focus();
                }
                else
                {
                    txtObservacion.Focus();
                }
            }

            this.Refresh();

        }


        void plaold(string nro_historia)
        {
            txtPaciente.Text = Paciente.Ape_Paterno + " " + Paciente.Ape_Materno + ", " + Paciente.Nombre + "(" + Paciente.Id_Paciente + ")";
            dtpFechaNac.Value = DateTime.Parse(Paciente.Fecha_Nac);
            txtEdad.Text = Paciente.Edad;


            string sql1 = "Select Nro_Historia, Fecha_Atencion, CMP, Id_Bus, Turno, Digitador, Fecha_Ingreso, Tsg From Cab_Cie10 Where Nro_Historia = '" + nro_historia + "'";

            SqlCommand cmd1 = new SqlCommand(sql1, Conexion.CNN);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            CabCie10 cabCie10 = null;

            while (dr1.Read())
            {
                cabCie10 = new CabCie10()
                {
                    Nro_Historia = dr1.GetValue(0).ToString(),
                    Fecha_Atencion = DateTime.Parse(dr1.GetValue(1).ToString()),
                    CMP = dr1.GetValue(2).ToString(),
                    Id_Bus = dr1.GetValue(3).ToString(),
                    Turno = dr1.GetValue(4).ToString(),
                    Digitador = dr1.GetValue(5).ToString(),
                    Fecha_Ingreso = dr1.GetValue(6).ToString(),
                    Tsg = dr1.GetValue(7).ToString(),
                };
            }

            //Comprobamos si hay datos
            if (cabCie10 != null)
            {
                if (tabIngresoConsulta.SelectedIndex == 0)
                {
                    MessageBox.Show("Ya fue procesada la historia clinica ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    string ia = Usuario.id_area;
                    string iu = cabCie10.Digitador;

                    if (iu.Substring(0, 3) == Operativo.id_oper)
                    {
                        string sql2 = "Select Count(*) As C From sysaccusers Where Id_Us = '" + iu + "' And Id_Area= '" + ia + "'";

                        SqlCommand cmd2 = new SqlCommand(sql2, Conexion.CNN);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        int count = 0;
                        while (dr2.Read())
                        {
                            count = int.Parse(dr2.GetValue(0).ToString());
                        }

                        if (count == 0)
                        {
                            MessageBox.Show("Este registro no corresponde a su consultorio", "Ingreso y consulta de atenciones realizadas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }

                    txtNroDoc.Focus();
                }

                pce(true, true);
            }
            else {

            }
        }

        void pce(bool lci, bool lrc)
        {
            int xcm = (cmbMedico.SelectedIndex != -1 && lrc? cmbMedico.SelectedIndex: -1);
            cmbMedico.Items.Clear();

            if (lci && lrc)
            {
                BorrarTablaEspecialista();
                string sql1 = "Select Id_Personal As NCMP, SubString(TNCol,2,7) As CMP, Ape_Paterno + ' ' + Ape_Materno + ', ' + Nombres As Especialista, MB.Id_Bus "+
                    "Into #tmpEspecialista From Personal P Inner Join MedBus MB On P.Id_Personal = MB.CMP Order By 3";
                Conexion.ExecuteNonQuery(sql1);
            }

            string bus = (cmbBus.SelectedIndex == -1 ? "": cmbBus.SelectedValue.ToString());

            string sql2 = "Select * From #tmpEspecialista " + (lci ? "": "Where Id_Bus Like '" + bus + "%'") + " Order By 3";
            medics = General.GetDictionaryList(sql2);

            foreach (Dictionary<string, string> medic in medics)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = medic["CMP"] + " | " + medic["Especialista"];
                item.Value = medic["CMP"];
                cmbMedico.Items.Add(item);
            }

            if (xcm != -1 && lrc)
            {
                cmbMedico.SelectedIndex = xcm;
                txtMedico.Text = xcm == -1 ? "" : medics[xcm]["Especialista"];
                this.medic = medics[xcm];
            }

            Refresh();
        }

        private string BorrarTablaTemporal(bool execute = true)
        {
            string vSQL = "IF OBJECT_ID('tempdb.dbo.#tmpEspecialista', 'U') IS NOT NULL DROP TABLE #tmpEspecialista;";

            if (execute)
            {
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
            }

            return vSQL;
        }

        private string BorrarTablaEspecialista()
        {
            string vSQL = "IF OBJECT_ID('tempdb.dbo.#tmpEspecialista', 'U') IS NOT NULL DROP TABLE #tmpEspecialista;";
            Conexion.CMD.CommandText = vSQL;
            Conexion.CMD.ExecuteNonQuery();
            return vSQL;
        }

        private string BorrarTablaMedic()
        {
            string vSQL = "IF OBJECT_ID('tempdb.dbo.#tmpMedic', 'U') IS NOT NULL DROP TABLE #tmpMedic;";
            Conexion.CMD.CommandText = vSQL;
            Conexion.CMD.ExecuteNonQuery();
            return vSQL;
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {

        }
    }

   

}
