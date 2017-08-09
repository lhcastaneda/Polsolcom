using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
    public partial class frmIngresoCie10 : Form
    {
        const string EMPTY_DATE = "  /  /";
        const string EMPTY_DATETIME = "  /  /       :  :    m";
        Dictionary<string, string> ticket;
        List<Dictionary<string, string>> tickets;
        List<Dictionary<string, string>> pacientes;
        List<Dictionary<string, string>> tmpDetVent = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> tmpCie10 = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> tmpTratMed = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> iCons = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> medicaments;

        string[] tmpDetVenFields = { "Descripcion", "Cantidad", "Monto", "Subtotal", "Pagado", "Dscto" };
        string[] tmpTratMedFields = new string[] { "nro_reg", "id_med", "cant", "dosis", "dias" };

        string nh;
        int dr;
        int iu;
        int pg;
        int ce = 0;
        int ca = 0;
        int ga = 0;
        DateTime hi;
        public int iteration = 0;
        bool opened = false;

        public frmIngresoCie10()
        {
            InitializeComponent();

            this.tablaTipoTableAdapter.Fill(this.tipoDocumento.TablaTipo);
            this.consultoriosTableAdapter.Fill(this.consultoriosDS.Consultorios, Operativo.id_oper);
            this.busesTableAdapter.Fill(this.busesDS.Buses, Operativo.id_oper);
            this.tablaTipoTableAdapter1.Fill(this.turnosDS.TablaTipo);

            //ce = General.vtrls(Especialidad.esp);
            //ca = Especialidad.esp.Length > 0 ? 1 : 0;
            ce = 0;
            ca = 0;

            txtEnAcIni.Enabled = txtEnAcCur.Enabled = txtEnAcRel.Enabled = txtAnPer.Enabled = txtAnFam.Enabled = txtAnEpi.Enabled = txtAnQui.Enabled = txtAnOtr.Enabled = txtExClPs.Enabled = txtExClTl.Enabled = txtExClPa.Enabled = txtExClFc.Enabled = txtExClFr.Enabled = txtExClTm.Enabled = txtExClEg.Enabled = groupBoxTraMed.Enabled = dgvDetCie10.Enabled = chkCompleto.Enabled = btnAgregar.Enabled = btnQuitar.Enabled = btnBCie10.Enabled = btnVerifica.Enabled = cmbEspecialidad.Enabled = !(ca + ce == 2);
            chkCompleto.Checked = (ca + ce == 2);
            cmbEspecialidad.SelectedIndex = (ca + ce == 2) ? 0 : -1;
            cmbBus.Enabled = !(ca == 1);
            cmbBus.SelectedValue = (ca == 1 ? Usuario.id_area : "");
            txtFechaAten.Text = (ca == 1 ? DateTime.Today.ToString() : "");
            txtDigitador.Text = Usuario.usuario;

            this.pce(true, true);
        }

        private void frmIngresoCie10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cie10DS.CIE10' table. You can move, or remove it, as needed.
            this.cIE10TableAdapter.Fill(this.cie10DS.CIE10);
            // TODO: This line of code loads data into the 'turnosDS.TablaTipo' table. You can move, or remove it, as needed.
            //Hacemos que no salgan nseleccionados ningún ítem
            cmbDVenta.SelectedIndex = -1;
            cmbTurno.SelectedIndex = -1;

            string cr = "";
            if (Especialidad.esp.Length > 0)
            {
                cr = "Descripcion='" + Especialidad.esp + "'";
            }
            else
            {
                cr = "Left(Id_Consultorio,3)='" + Operativo.id_oper + "'";
            }

            string sql1 = "Select Id_Consultorio,Descripcion From Consultorios Where " + cr + " Order By 2";
            this.iCons = General.GetDictionaryList(sql1);

            string sql3 = "Select id_med, descr + Case When Len(conc)>0 Then ' (' + conc + ')' Else '' End medicamento, cla2 + ' (' + pres + ')' presentacion From medicaments Order By 2";
            this.medicaments = General.GetDictionaryList(sql3);

        }

        private void chkFiltro_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ((CheckBox)sender).Checked;

            cmbEspecialidad.Enabled = !check;
            cmbDVenta.Enabled = !check;
            txtFechaEmi.Enabled = !check;
            txtSerie.Enabled = !check;
            this.Refresh();
        }

        private void processKeyDown()
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

        private void txtNroDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                processKeyDown();
            }
        }

        public void pcl()
        {
            this.tmpDetVent.Clear();
            tmpCie10.Clear();

            int ne = cmbEspecialidad.SelectedIndex;
            string fe = txtFechaEmi.Text;
            int dv = cmbDVenta.SelectedIndex;
            string sr = txtSerie.Text;

            string fa = txtFechaAten.Text;
            int bs = cmbBus.SelectedIndex;
            int tr = cmbTurno.SelectedIndex;
            int cm = cmbMedico.SelectedIndex;
            string cn = txtCuenta.Text;

            setAll<TextBox, string>(this, "Text", "");
            setAll<ComboBox, int>(this, "SelectedIndex", -1);
            setAll<Button, bool>(this, "Enabled", false);

            btnVerifica.Enabled = true;

            cmbEspecialidad.SelectedIndex = ne;
            txtFechaEmi.Text = fe;
            cmbDVenta.SelectedIndex = dv;
            txtSerie.Text = sr;
            txtCuenta.Text = cn;

            if (chkIdem.Checked)
            {
                txtFechaAten.Text = fa;
                cmbBus.SelectedIndex = bs;
                cmbTurno.SelectedIndex = tr;
                cmbMedico.SelectedIndex = cm;
                txtMedico.Text = General.GetSelectedString(cmbMedico, "FullEspecialista");
            }

            txtFechaAten.Text = EMPTY_DATE;
            txtTi.Text = "0";
            txtTotal.Text = "0.00";
            txtNroDoc.Focus();
            Refresh();

        }

        void setAll<A, B>(Control control, string property, B value)
        {
            foreach (Control subControl in control.Controls)
            {
                if (subControl is A)
                {
                    Type t = subControl.GetType();
                    PropertyInfo p = t.GetProperty(property);
                    p.SetValue(subControl, value);
                }
            }
        }

        private int pfv()
        {
            this.hi = DateTime.Today;

            string vSQL = "";
            vSQL += "Select T.Serie,T.Nro_Ticket,";
            vSQL += tabIngresoConsulta.SelectedIndex == 0 ? "T.Fecha_Emision," : "CB.Fecha_Atencion,";
            vSQL += "T.Digitador AS Digitador,T.Nro_Historia,T.Id_Paciente,C.Descripcion,X.Orden,T.Anulado";
            vSQL += tabIngresoConsulta.SelectedIndex == 0 ? " " : ",T.Fecha_Emision ";
            vSQL += "From Tickets T Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " + "Inner Join (Select Ape_Paterno+' '+Ape_Materno+', '+Nombres+' ('+SubString(TNCol,2,6)+')' Orden,Id_Personal " + "From Personal Union All Select Descripcion,Id_Tipo From TablaTipo Where Id_Tabla In " + "(Select Id_Tipo From TablaTipo Where Descripcion='VAR_EXTRAS' And Id_Tabla='0'))X On T.CMP=X.Id_Personal ";
            vSQL += tabIngresoConsulta.SelectedIndex == 0 ? "" : "Inner Join Cab_Cie10 CB On CB.Nro_Historia=T.Nro_Historia ";
            vSQL += "Where";

            if (tabIngresoConsulta.SelectedIndex == 0)
            {
                if (chkFiltro.Checked || General.vtrls(Especialidad.esp) == 1)
                {
                    vSQL += cmbEspecialidad.SelectedIndex != -1 ? (" T.Id_Consultorio Like '" + (((DataRowView)cmbEspecialidad.SelectedItem).Row["Id_Consultorio"]).ToString() + "'") : "";
                    vSQL += vSQL.Contains("Like") && cmbEspecialidad.SelectedIndex != -1 ? " And" : "";
                    vSQL += txtFechaEmi.Text != EMPTY_DATE ? (" T.Fecha_Emision Between '" + txtFechaEmi.Text + "' And '" + DateTime.Parse(txtFechaEmi.Text).AddDays(1).ToString() + "'") : "";
                    vSQL += vSQL.Contains("Like") && txtFechaEmi.Text != EMPTY_DATE ? " And" : "";
                    vSQL += cmbDVenta.SelectedIndex != -1 ? (" T.DVenta Like '" + (((DataRowView)cmbDVenta.SelectedItem).Row["Id_Tipo"]).ToString() + "'") : "";
                }

                vSQL += vSQL.Contains("Like") && cmbDVenta.SelectedIndex != -1 ? " And" : "";
                vSQL += txtSerie.Text.Length > 0 ? (" T.Serie Like '" + txtSerie.Text + "'") : "";
                vSQL += vSQL.Contains("Like") && txtSerie.Text.Length > 0 ? " And" : "";
                vSQL += txtNroDoc.Text.Length > 0 ? (" T.Nro_Ticket Like '" + txtNroDoc.Text + "%'") : "";
            }
            else
            {
                Dictionary<string, string> paciente = pacientes[General.GetSelectedIndex(lstPacientes)];
                vSQL += " T.Id_Paciente='" + paciente["id_paciente"] + "'";
            }

            lstTickets0.Items.Clear();
            lstTickets1.Items.Clear();

            tickets = General.GetDictionaryList(vSQL);

            if (tickets.Count > 0)
            {
                string[] fields = { "Serie", "Nro_Ticket", "Fecha_Emision", "Digitador" };

                if (tabIngresoConsulta.SelectedIndex == 0)
                {
                    General.FillListView(lstTickets0, tickets, fields);
                    for (int i = 0; i < lstTickets0.Items.Count; i++)
                    {
                        lstTickets0.Items[i].SubItems["Digitador"].Text = General.TradUser(lstTickets0.Items[i].SubItems["Digitador"].Text);
                    }
                    lstTickets0.Focus();
                }
                else
                {
                    General.FillListView(lstTickets1, tickets, fields);
                    for (int i = 0; i < lstTickets1.Items.Count; i++)
                    {
                        lstTickets1.Items[i].SubItems["Digitador"].Text = General.TradUser(lstTickets1.Items[i].SubItems["Digitador"].Text);
                    }
                    lstTickets1.Focus();
                }
            }


            return tickets.Count;
        }

        public int pct()
        {
            string fa = txtFechaAten.Text;
            string bs = cmbBus.SelectedValue.ToString();
            string tr = cmbTurno.SelectedValue.ToString();
            string cm = cmbMedico.SelectedValue.ToString();
            string sql = "Select Count(*) AS C From Cab_Cie10 Where Fecha_Atencion='" + fa + "' And Id_Bus='" + bs + "' And Turno='" + tr + "' ";

            if (this.ptc(bs, 0) == "P")
            {
                sql += " And CMP='" + cm + "";
            }
            return Conexion.ExecuteScalar<int>(sql);
        }

        private void frmIngresoCie10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                txtObservacion.Focus();
            }

            if (e.KeyCode == Keys.F2)
            {
                this.pce(true, true);
            }

            if (e.KeyCode == Keys.F3 && btnAgregar.Enabled)
            {
                btnAgregar_Click(btnAgregar, e);
            }

            if (e.KeyCode == Keys.F4 && btnQuitar.Enabled)
            {
                btnQuitar_Click(btnQuitar, e);
            }

            if (e.KeyCode == Keys.F5 && btnBCie10.Enabled)
            {
                btnBCie10_Click(btnBCie10, e);
            }

            if (e.KeyCode == Keys.F6 && btnGrabar.Enabled)
            {
                btnGrabar_Click(btnGrabar, e);
            }

            if (e.KeyCode == Keys.F7 && btnVerifica.Enabled)
            {
                btnVerifica_Click(btnVerifica, e);
            }

            if (e.KeyCode == Keys.F8)
            {
                chkIdem.Enabled = true;
                chkIdem.Checked = false;
                chkIdem_CheckedChanged(chkIdem, e);
            }

            if (e.KeyCode == Keys.F9 && cmbBus.SelectedIndex > -1 && cmbMedico.SelectedIndex > -1)
            {
                frmResultado frmResultado = new frmResultado(this.tmpDetVent, cmbBus.SelectedValue.ToString(), cmbMedico.SelectedValue.ToString(), this.nh);
                frmResultado.FormClosed += new FormClosedEventHandler(frmResultado_FormClosed);
                frmResultado.Show();
                this.Hide();
            }
        }

        private void frmResultado_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tmpDetVent = ((frmResultado)sender).items;
            //
            txtNroDoc.Text = "";
            txtNroDoc.Focus();

            int cp = 0;
            foreach (Dictionary<string, string> item in this.tmpDetVent)
            {
                if (item["Nro_Historia"] == this.nh)
                {
                    cp += item["Pagado"] != "" ? 1 : 0;
                }
            }

            if (this.iu == 0 && cp == 0)
            {
                this.btnGrabar_Click(btnGrabar, new EventArgs());
            }

            this.Show();
        }

        private void txtSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNroDoc.Focus();
            }
        }

        private void lstTickets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iteration++;
                int index = General.GetSelectedIndex((ListView)sender);
                ticket = tickets[index];

                if (!opened)
                {
                    if (ticket["Anulado"] != "")
                    {
                        MessageBox.Show("N° de documento de venta esta anulado ...", "Advertencia");
                        pcl();
                        return;
                    }

                    pfp(ticket["Id_Paciente"]);
                    pla();
                    opened = true;
                }

                if (iteration == ((ListView)sender).Items.Count)
                {
                    opened = false;
                    iteration = 0;
                }
            }
        }


        public int vexis(string sql, string msg, bool cnd, string pex)
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
            Dictionary<string, string> paciente = pacientes[General.GetSelectedIndex(lstPacientes)];

            txtPaciente.Text = paciente["Ape_Paterno"] + " " + paciente["Ape_Materno"] + ", " + paciente["Nombre"] + " (" + paciente["Id_Paciente"] + ")";
            txtFechaNac.Text = paciente["Fecha_Nac"];
            txtEdad.Text = paciente["Edad"];
            txtSexo.Text = paciente["Sexo"] == "M" ? "MASCULINO" : "FEMENINO";
            txtOrden.Text = ticket["Orden"];
            txtEspecialidad.Text = ticket["Descripcion"];
            txtFechaEmiFil.Text = ticket["Fecha_Emision"];
            txtCajero.Text = "CAJERO: ( " + General.TradUser(ticket["Digitador"]) + " )";
            this.nh = ticket["Nro_Historia"];

            this.tmpDetVent.Clear();

            string detSql = "Select D.*,P.Descripcion From Detalles D Inner Join Productos P On D.Id_Producto=P.Id_Producto Where Nro_Historia='" + this.nh + "'";
            this.tmpDetVent = General.GetDictionaryList(detSql);

            double total = 0f;
            for (int i = 0; i < this.tmpDetVent.Count; i++)
            {
                double subtotal = Math.Round(int.Parse(this.tmpDetVent[i]["Cantidad"]) * double.Parse(this.tmpDetVent[i]["Monto"]), 2);
                total += subtotal;
                //
                this.tmpDetVent[i]["Subtotal"] = subtotal.ToString();
                this.tmpDetVent[i]["M"] = "1";
            }

            txtTotal.Text = total.ToString();
            General.FillListView(grdDetalle, this.tmpDetVent, this.tmpDetVenFields);
            string cabCie10Sql = "Select * From Cab_Cie10 Where Nro_Historia = '" + ticket["Nro_Historia"] + "'";
            Dictionary<string, string> cabCie10 = General.GetDictionary(cabCie10Sql);

            if (cabCie10 != null)
            {
                if (tabIngresoConsulta.SelectedIndex == 0)
                {
                    MessageBox.Show("Ya fue procesada la historia clinica ...", "Advertencia");
                    string ia = Usuario.id_area;//REEMPLAZAR
                    string iu = cabCie10["Digitador"];

                    //La siguiente línea no se pudo ejecutar
                    if ((ia.Length > 3 ? ia.Substring(0, 3) : ia) == Operativo.id_oper)//REEMPLAZAR
                    {
                        vexis("Select Count(*) as C From sysaccusers Where Id_Us = '" + iu + "' And Id_Area = '" + ia + "'", "Este registro no corresponde a su consultorio", false, "pcl");
                    }

                    txtNroDoc.Focus();
                }

                pce(true, true);//Changecm
                txtFechaAten.Text = cabCie10["Fecha_Atencion"];
                cmbBus.SelectedValue = cabCie10["Id_Bus"];
                cmbTurno.SelectedValue = cabCie10["Turno"];
                cmbMedico.SelectedValue = cabCie10["CMP"];
                txtMedico.Text = General.GetSelectedString(cmbMedico, "FullEspecialista");
                txtDigitador.Text = General.TradUser(cabCie10["Digitador"]);
                txtEnAcIni.Text = cabCie10["En_Ac_Ini"];
                txtEnAcCur.Text = cabCie10["En_Ac_Cur"];
                txtEnAcRel.Text = cabCie10["En_Ac_Rel"];
                txtAnPer.Text = cabCie10["An_Per"];
                txtAnFam.Text = cabCie10["An_Fam"];
                txtAnEpi.Text = cabCie10["An_Epi"];
                txtAnQui.Text = cabCie10["An_Qui"];
                txtAnOtr.Text = cabCie10["An_Otr"];
                txtExClPs.Text = (cabCie10["Ex_Cl_Ps"].Length == 0 ? "0.00" : cabCie10["Ex_Cl_Ps"]);
                txtExClTl.Text = (cabCie10["Ex_Cl_Tl"].Length == 0 ? "0.00" : cabCie10["Ex_Cl_Tl"]);
                txtExClPa.Text = cabCie10["Ex_Cl_PA"];
                txtExClFc.Text = (cabCie10["Ex_Cl_FC"].Length == 0 ? "0" : cabCie10["Ex_Cl_FC"]);
                txtExClFr.Text = (cabCie10["Ex_Cl_FR"].Length == 0 ? "0" : cabCie10["Ex_Cl_FR"]);
                txtExClTm.Text = (cabCie10["Ex_Cl_Tm"].Length == 0 ? "0" : cabCie10["Ex_Cl_Tm"]);
                txtExClEg.Text = cabCie10["Ex_Cl_Eg"];
                txtObservacion.Text = cabCie10["Observacion"];
                txtFechaIngreso.Text = cabCie10["Fecha_Ingreso"];

                tmpCie10.Clear();

                string detCie10Sql = "Select DC.*,CI.Descripcion From Det_Cie10 DC Left Join Cie10 CI On DC.Cie10=CI.Cie10 Where Nro_Historia='" + this.nh + "'";
                this.tmpCie10 = General.GetDictionaryList(detCie10Sql);
                this.dr = tmpCie10.Count;

                dgvDetCie10.Rows.Clear();
                foreach (Dictionary<string, string> item in this.tmpCie10)
                {
                    dgvDetCie10.Rows.Add(new[] { item["CIE10"], item["Descripcion"], item["Procedimiento"] });
                }

                btnAgregar.Enabled = btnQuitar.Enabled = btnBCie10.Enabled = (this.dr > 0 && tabIngresoConsulta.SelectedIndex == 0);
                //btnImprimir.Enabled = (this.dr > 0);//CUal botón imprimir?
                btnGrabar.Enabled = (tabIngresoConsulta.SelectedIndex == 0);

                string tratMedSql = "Select * From tratmed Where nro_reg='" + this.nh + "'";
                this.tmpTratMed = General.GetDictionaryList(tratMedSql);

                this.dr += this.tmpTratMed.Count;
                this.iu = 1;
                this.pg = cabCie10["Id_Per"] != "" ? 1 : 0;

            }
            else
            {
                this.dr = 0;
                this.iu = 0;
                this.pg = 0;

                setAll<TextBox, string>(this, "Text", "");
                setAll<Button, bool>(this, "Enabled", false);

                btnVerifica.Enabled = true;
                cmbBus.SelectedValue = ((Usuario.id_area.Length > 3 ? Usuario.id_area.Substring(0, 3) : Usuario.id_area) == Operativo.id_oper) ? Usuario.id_area : cmbBus.SelectedValue;
                txtDigitador.Text = Usuario.usuario;
                txtFechaIngreso.Text = EMPTY_DATE;
                if (chkIdem.Checked)
                {
                    txtFechaAten.Focus();
                }
                else
                {
                    txtObservacion.Focus();
                }
            }

            this.Refresh();

        }

        public void pvl(int lv)
        {
            if (lv == 5)
            {
                if (this.tmpDetVent.Count == 0)
                {
                    MessageBox.Show("El registro no tiene detalle de venta ... comuniquese con el administrador del sistema ... urgente !!!", "Advertencia");
                    return;
                }
            }

            if (lv == 1 || lv == 5)
            {
                if ((txtFechaAten.Text != EMPTY_DATE && txtFechaEmi.Text != EMPTY_DATE) && (DateTime.Parse(txtFechaAten.Text) < DateTime.Parse(txtFechaEmi.Text)))
                {
                    MessageBox.Show("Corregir datos, fecha de atención no puede ser menor que fecha de emisión ...", "Advertencia");
                    txtFechaAten.Focus();
                    return;
                }
            }

            if (lv == 2 || lv == 5)
            {

                if (cmbBus.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese nombre de  consultorio (Bus) ...", "Advertencia");
                    cmbBus.Focus();
                    return;
                }
            }

            if (lv == 3 || lv == 5)
            {
                if (cmbTurno.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese turno ...", "Advertencia");
                    cmbTurno.Focus();
                    return;
                }
            }

            if (lv == 4 || lv == 5)
            {
                if (cmbMedico.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese numero de colegiatura del especialista ...", "Advertencia");
                    cmbMedico.Focus();
                    return;
                }
            }
        }

        public string ptc(string lib, int lmd)
        {
            string xib = lib.Trim();
            return Conexion.ExecuteScalar<string>("Select " + (lmd == 0 ? "C.Tipo" : "C.Descripcion") + " As Res From Consultorios C Inner Join Buses B On C.Id_Consultorio=B.Id_Esp Where B.Id_Bus = '" + xib + "'");
        }

        void pce(bool lci, bool lrc)
        {
            int xcm = (cmbMedico.SelectedIndex != -1 && lrc ? cmbMedico.SelectedIndex : -1);

            if (lci && lrc)
            {
                BorrarTablaEspecialista();
                string sql = "Select Id_Personal As NCMP, SubString(TNCol,2,7) As CMP, Ape_Paterno + ' ' + Ape_Materno + ', ' + Nombres As Especialista, MB.Id_Bus " +
                    "Into tmpEspecialista From Personal P Inner Join MedBus MB On P.Id_Personal = MB.CMP Order By 3";
                Conexion.ExecuteNonQuery(sql);
            }

            string bus = (cmbBus.SelectedIndex == -1 || lci ? "%" : cmbBus.SelectedValue.ToString());

            //Llenamos especialistas
            this.tmpEspecialistaTableAdapter.Fill(this.tmpEspecialistaDS.tmpEspecialista, bus);
            General.AdjustComboBoxWidth(cmbMedico);

            if (xcm != -1 && lrc)
            {
                cmbMedico.SelectedIndex = xcm;
                txtMedico.Text = General.GetSelectedString(cmbMedico, "FullEspecialista");
            }

            this.Refresh();
        }

        private string BorrarTablaEspecialista(bool execute = true)
        {
            string vSQL = "IF OBJECT_ID('dbo.tmpEspecialista', 'U') IS NOT NULL DROP TABLE tmpEspecialista;";

            if (execute)
            {
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
            }

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
            string xbs = cmbBus.SelectedValue != null ? cmbBus.SelectedValue.ToString() : "";
            string xtr = cmbTurno.SelectedValue != null ? cmbTurno.SelectedValue.ToString().Substring(0, 1) : "";
            string xfa = txtFechaAten.Text;
            string xcm = cmbMedico.SelectedValue.ToString();

            if (xbs.Length == 0 || xtr.Length == 0 || xfa.Length == 0 || xcm.Length == 0)
            {
                return;
            }
            //
            string sql = "Select Serie, Nro_Ticket, Fecha_Atencion, SubString(TNCol,2, 7)CMP,B.Bus,C.Descripcion Consultorio, U.Descripcion Turno, CB.Digitador,DC.Cie10,DC.Procedimiento,CB.Nro_Historia,CI.Descripcion Diagnostico From Cab_Cie10 CB Inner Join(Select Id_Tipo, Descripcion From TablaTipo Where Id_Tabla In (Select Id_Tipo From TablaTipo Where Descripcion = 'TURNOS' And Id_Tabla = '0'))U On CB.Turno = U.Id_Tipo Inner Join Tickets T On CB.Nro_Historia = T.Nro_Historia Inner Join Consultorios C On C.Id_Consultorio = T.Id_Consultorio Inner Join Buses B On CB.Id_Bus = B.Id_Bus Inner Join Personal P On CB.CMP = P.Id_Personal Left Join Det_Cie10 DC On CB.Nro_Historia = DC.Nro_Historia Left Join Cie10 CI On DC.Cie10 = CI.Cie10 Where CB.Id_Bus = '" + xbs + "' And CB.Turno = '" + xtr + "' And Fecha_Atencion = '" + xfa + "' ";
            sql += this.ptc(xbs, 0) == "T" ? "" : "And CB.CMP = '" + xcm + "' ";
            sql += "Order By Fecha_Ingreso";
            //
            List<Dictionary<string, string>> list = General.GetDictionaryList(sql);
            frmVerificaCie frmVerificaCie10 = new frmVerificaCie(list);
            frmVerificaCie10.FormClosed += new FormClosedEventHandler(frmVerificaCie_FormClosed);
            frmVerificaCie10.Show();
            this.Hide();
        }

        private void frmVerificaCie_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtNroDoc.Text = ((frmVerificaCie)sender).nroTicket;
            this.processKeyDown();
            this.Show();
        }

        private void chkIdem_CheckedChanged(object sender, EventArgs e)
        {
            txtFechaAten.Enabled = cmbTurno.Enabled = cmbMedico.Enabled = !chkIdem.Checked;
            cmbBus.Enabled = !chkIdem.Checked && ((Usuario.id_area.Length > 2? Usuario.id_area.Substring(0, 3) : Usuario.id_area) != Operativo.id_oper);
            txtCuenta.Enabled = chkIdem.Checked;
        }

        private void txtApePat_TextChanged(object sender, EventArgs e)
        {
            this.pfp();
        }

        private void txtApeMat_TextChanged(object sender, EventArgs e)
        {
            this.pfp();
        }

        private void txtIdPac_TextChanged(object sender, EventArgs e)
        {
            this.pfp();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.pfp();
        }

        private void lstTickets1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pla();
        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pfv();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.ga == 0)
            {
                dgvDetCie10.Rows.Add(new[] { "", "", "" });
            }

            this.dr++;
            if (dr > 0)
            {
                btnQuitar.Enabled = btnGrabar.Enabled = true;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            dgvDetCie10.Rows.RemoveAt(dgvDetCie10.CurrentCell.RowIndex);

            this.dr--;

            if (this.dr == 0)
            {
                btnGrabar.Enabled = btnQuitar.Enabled = btnBCie10.Enabled = true;
            }

            this.Refresh();
        }

        private void btnBCie10_Click(object sender, EventArgs e)
        {
            frmCie10 frmCie10 = new frmCie10();
            frmCie10.FormClosed += new FormClosedEventHandler(frmCie10_FormClosed);
            frmCie10.Show();
            this.Hide();
        }

        private void frmCie10_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((frmCie10)sender).cie10.Length > 0)
            {
                this.dgvDetCie10.Rows[this.dgvDetCie10.CurrentCell.RowIndex].Cells[0].Value = ((frmCie10)sender).cie10;
                this.dgvDetCie10.Rows[this.dgvDetCie10.CurrentCell.RowIndex].Cells[1].Value = ((frmCie10)sender).descripcion;
            }
            this.Show();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            this.pvl(5);

            string nh = this.nh;
            string fa = txtFechaAten.Text;
            string cm = cmbMedico.SelectedValue.ToString();
            string bs = cmbBus.SelectedValue.ToString();
            string tr = cmbTurno.SelectedValue.ToString();
            string dg = Usuario.id_us;
            string ei = txtEnAcIni.Text;
            string ec = txtEnAcCur.Text;
            string er = txtEnAcRel.Text;
            string ap = txtAnPer.Text;
            string af = txtAnFam.Text;
            string ae = txtAnEpi.Text;
            string aq = txtAnQui.Text;
            string ao = txtAnOtr.Text;
            string ps = txtExClPs.Text;
            string tl = txtExClTl.Text;
            string pa = txtExClPa.Text;
            string fc = txtExClFc.Text;
            string fr = txtExClFr.Text;
            string tm = txtExClTm.Text;
            string eg = txtExClEg.Text;
            string ob = txtObservacion.Text;
            double df = (DateTime.Today - this.hi).TotalSeconds;

            //Borramos tmpcie10
            List<Dictionary<string, string>> lista = new List<Dictionary<string, string>>();
            foreach (Dictionary<string, string> item in this.tmpCie10)
            {
                if (!(item["Nro_Historia"] == "" || (item["CIE10"] + item["Procedimiento"]).Length == 0))
                {
                    lista.Add(item);
                }
            }
            this.tmpCie10 = lista;
            int dn = lista.Count;
            //
            if (dn == 0 && this.ptc(bs, 1) != "LABORATORIO" && General.vtrls(Especialidad.esp) == 0)
            {
                if (MessageBox.Show("No ha agregado diagnostico alguno ... desea continuar ?", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    btnAgregar.Focus();
                    return;
                }
            }
            //
            if (MessageBox.Show("Desea guardar los datos ... ?", "Confirmación de grabado", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                if (this.iu == 0)
                {
                    if (this.ptc(bs, 1) != "LABORATORIO")
                    {
                        Conexion.ExecuteNonQuery("Update Detalles Set Pagado = 'R' Where Nro_Historia = '" + this.nh + "'");

                        for (int i = 0; i < this.tmpDetVent.Count; i++)
                        {
                            if (this.tmpDetVent[i]["Nro_Historia"] == this.nh)
                            {
                                this.tmpDetVent[i]["Pagado"] = "R";
                            }
                        }
                    }

                    string sql = "Exec AddCie10 '" + nh + "', '" + fa + "', '" + cm + "', '" + bs + "', '" + tr + "', '" + dg + "', '" + ei + "', '" + ec + "', '" + er + "', '" + ap + "', '" + af + "', '" + ae + "', '" + aq + "', '" + ao + "', '" + ps + "', '" + tl + "', '" + pa + "', '" + fc + "', '" + fr + "', '" + tm + "', '" + eg + "', '" + ob + "', '" + df + "'";
                    Conexion.ExecuteNonQuery(sql);

                    if (chkIdem.Checked)
                    {
                        float cuenta = int.Parse(txtCuenta.Text);
                        txtCuenta.Text = (cuenta > 0 ? cuenta - 1 : 0).ToString();

                        if (cuenta > 0)
                        {
                            chkIdem.Enabled = true;
                            chkIdem.Checked = false;
                            chkIdem_CheckedChanged(chkIdem, new EventArgs());
                        }
                    }

                }
                else
                {
                    if (this.pg == 1)
                    {
                        MessageBox.Show("El registro ya fue pagado ... no se puede modificar ...", "Advertencia");
                        return;
                    }
                    //
                    if (Usuario.usuario != txtDigitador.Text)
                    {
                        if (MessageBox.Show("Está seguro de modificar datos ingresados por:\n" + txtDigitador.Text + "?", "Aviso al usuario", MessageBoxButtons.OKCancel) != DialogResult.OK)
                        {
                            return;
                        }
                    }
                    //
                    string sql1 = "Update Cab_Cie10 Set Fecha_Atencion = '" + fa + "', CMP = '" + cm + "', Id_Bus = '" + bs + "', Turno = '" + tr + "', Digitador = '" + dg + "', En_Ac_Ini = '" + ei + "', '+'En_Ac_Cur = '" + ec + "', En_Ac_Rel = '" + er + "', An_Per = '" + ap + "', An_Fam = '" + af + "', An_Epi = '" + ae + "', An_Qui = '" + aq + "', An_Otr = '" + ao + "', Ex_Cl_Ps = '" + ps + "', '+'Ex_Cl_Tl = '" + tl + "', Ex_Cl_PA = '" + pa + "', Ex_Cl_FC = '" + fc + "', Ex_Cl_FR = '" + fr + "', Ex_Cl_Tm = '" + tm + "', Ex_Cl_Eg = '" + eg + "', Observacion = '" + ob + "', '+'Fecha_Ingreso = '" + DateTime.Now + "', tsg = '" + df + "' Where Nro_Historia = '" + this.nh + "'";
                    Conexion.ExecuteNonQuery(sql1);

                    string sql2 = "Delete From Det_Cie10 Where Nro_Historia = '" + this.nh + "'";
                    Conexion.ExecuteNonQuery(sql2);

                    string sql3 = "Delete From tratmed Where nro_reg = '" + this.nh + "'";
                    Conexion.ExecuteNonQuery(sql3);

                    //Se debería poner en readonly columnas 5, 6 y 7 de grdDetalle
                }
                //
                if (this.ptc(bs, 1) != "LABORATORIO")
                {
                    foreach (Dictionary<string, string> item in this.tmpCie10)
                    {
                        string sql3 = "Exec AddDetCie10 '" + this.nh + "', '" + item["CIE10"] + "', '" + item["Procedimiento"] + "'";
                        Conexion.ExecuteNonQuery(sql3);
                    }
                }
                //
                foreach (Dictionary<string, string> item in this.tmpTratMed)
                {
                    string sql4 = "Insert Into tratmed Values('" + this.nh + "', '" + item["id_med"] + "', '" + item["cant"] + "', '" + item["dosis"] + "', '" + item["dias"] + "')";
                    Conexion.ExecuteNonQuery(sql4);
                }
            }

            this.hi = DateTime.Now;
            this.pg = 0;
            txtTi.Text = this.pct().ToString();
            //
            txtFechaIngreso.Text = DateTime.Now.ToString();
            btnGrabar.Enabled = false;

            if (this.Visible)
            {
                txtNroDoc.Text = "";
                txtNroDoc.Focus();
            }
        }

        private void cmbBus_Leave(object sender, EventArgs e)
        {
            this.pvl(1);

            DataRow bus = (DataRow)cmbBus.SelectedItem;

            if (bus["Estado"].ToString() != "1")
            {
                MessageBox.Show("Consultorio (Bus) seleccionado esta desactivado ...", "Advertencia");
                cmbBus.SelectedIndex = 1;
                return;
            }

            string es = txtEspecialidad.Text;
            string ib = cmbBus.SelectedValue.ToString();

            string sql = "'Select Count(*) As C From Buses B Inner Join Consultorios C On C.Id_Consultorio=B.Id_Esp Where C.Descripcion = '" + es + "' And Id_Bus = '" + ib + "'";
            int c = Conexion.ExecuteScalar<int>(sql);

            if (c == 0)
            {
                MessageBox.Show("Consultorio (Bus) no corresponde a la especialidad ... desea continuar ?", "Advertencia");
                cmbBus.SelectedIndex = 1;
                return;
            }

            this.pce(false, true);
        }

        private void cmbTurno_Leave(object sender, EventArgs e)
        {
            this.pvl(2);
        }

        private void txtObservacion_Leave(object sender, EventArgs e)
        {
            this.pvl(4);

            if (this.pg == 0 && tabIngresoConsulta.SelectedIndex == 0)
            {
                if (this.ptc(cmbBus.SelectedValue.ToString(), 1) == "LABORATORIO")
                {
                    btnGrabar.Enabled = /* .grddetalle.column5.cmbpagado.enabled = */ true;
                    /*STORE .F. TO .grddetalle.column5.readonly, .grddetalle.column6.readonly
          .grddetalle.column5.cmbpagado.setfocus */
                }
                else
                {
                    /*STORE IIF(thisformset.iu=0, .T., .F.) TO .grddetalle.column5.readonly, .grddetalle.column6.readonly
          .grddetalle.column5.cmbpagado.enabled = IIF(thisformset.iu=0, .F., .T.)*/
                    btnAgregar.Enabled = true;
                }

                this.ga = 0;
            }

            this.Refresh();
        }

        private void cmbMedico_Leave(object sender, EventArgs e)
        {
            this.pvl(3);
            txtMedico.Text = General.GetSelectedString(cmbMedico, "FullEspecialista");

            if (chkCompleto.Checked)
            {
                txtObservacion.Focus();
            }
        }

        private void txtFechaEmi_Validating(object sender, CancelEventArgs e)
        {
            DateTime rs;
            if (!DateTime.TryParseExact(this.txtFechaEmi.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out rs))
            {
                e.Cancel = true;
            }
        }

        private void txtFechaAten_Validating(object sender, CancelEventArgs e)
        {
            DateTime rs;
            if (!DateTime.TryParseExact(this.txtFechaAten.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out rs))
            {
                e.Cancel = true;
            }
        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabIngresoConsulta_Click(object sender, EventArgs e)
        {
            setAll<Button, bool>(this, "Enabled", false);
        }

        private void grdDetCie10_Enter(object sender, EventArgs e)
        {
            this.ga = 0;
        }

        private void grdTraMed_Enter(object sender, EventArgs e)
        {
            this.ga = 1;
        }

        private void txtCuenta_Leave(object sender, EventArgs e)
        {
            chkIdem.Enabled = txtCuenta.Enabled = !(chkIdem.Checked && txtCuenta.Text.Length > 0);
        }

        private void txtFechaAten_Leave(object sender, EventArgs e)
        {
            if (txtFechaEmiFil.Text == EMPTY_DATE || txtFechaAten.Text == EMPTY_DATE)
            {
                txtNroDoc.Focus();
            }

            this.vFecha(DateTime.Parse(txtFechaAten.Text), txtFechaAten);
            this.Refresh();

        }

        public void vFecha(DateTime pfec, MaskedTextBox pobj)
        {
            DateTime sfec = DateTime.Today;

            if (pfec.Month != sfec.Month && pfec.Year != sfec.Year)
            {
                if (MessageBox.Show("Dato ingresado no corresponde al mes y año en curso ... desea continuar ?", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    pobj.Text = EMPTY_DATE;
                    return;
                }
            }

            if (pfec.Month != sfec.Month)
            {
                if (MessageBox.Show("Dato ingresado no corresponde al mes en curso...desea continuar ? ", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    pobj.Text = EMPTY_DATE;
                    return;
                }
            }

            if (pfec.Year != sfec.Year)
            {
                if (MessageBox.Show("Dato ingresado no corresponde al año en curso ... desea continuar ?", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    pobj.Text = EMPTY_DATE;
                    return;
                }
            }
        }

        private void txtAnPer_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmbMedico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.pvl(3);
            txtMedico.Text = General.GetSelectedString(cmbMedico, "FullEspecialista");

            if (!chkCompleto.Checked)
            {
                txtObservacion.Focus();
            }

            this.Refresh();
        }

        private void dgvDetCie10_Enter(object sender, EventArgs e)
        {
        }

        private void dgvDetCie10_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Only for a DatagridComboBoxColumn at ColumnIndex 0.
            if (dgvDetCie10.CurrentCell.ColumnIndex == 0)
            {
                ComboBox combo = (ComboBox)e.Control;
                if ((combo != null))
                {
                    // Remove an existing event-handler, if present, to avoid 
                    // adding multiple handlers when the editing control is reused.
                    combo.SelectionChangeCommitted -= new EventHandler(ComboBox_SelectionChangeCommitted);

                    // Add the event handler. 
                    combo.SelectionChangeCommitted += new EventHandler(ComboBox_SelectionChangeCommitted);
                }
            }
        }

        private void ComboBox_SelectionChangeCommitted(System.Object sender, System.EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string description = (((DataRowView)combo.SelectedItem).Row["Descripcion"]).ToString();
            dgvDetCie10.Rows[dgvDetCie10.CurrentCell.RowIndex].Cells[1].Value = description;
            //MessageBox.Show("Row: " + dgvDetCie10.CurrentCell.RowIndex + ", Value: " + combo.SelectedItem);
            dgvDetCie10.CurrentCell = dgvDetCie10.Rows[dgvDetCie10.CurrentCell.RowIndex].Cells[2];
            dgvDetCie10.CurrentCell.Selected = true;
            //Console.WriteLine("Row: {0}, Value: {1}", dgvDetCie10.CurrentCell.RowIndex, combo.SelectedItem);
        }

        private void dgvDetCie10_Validated(object sender, EventArgs e)
        {
            this.ga = 0;
        }

        private void grdTraMed_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
