﻿using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
	public partial class frmIngresoCie10 : Form
    {
		Dictionary<string, string> ticket;
        Dictionary<string, string> pac;
        List<Dictionary<string, string>> tickets;
        List<Dictionary<string, string>> pacs = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> iCons = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> medicaments;

        string nh;
        int dr;
        int iu;
        int pg;
        int ga = 0;
        DateTime hi;

        public frmIngresoCie10()
        {
            InitializeComponent();
        }

        private void frmIngresoCie10_Load(object sender, EventArgs e)
        {
			turnoTableAdapter.Fill(tablaTipoDS.Turno);
            cmbTurno.SelectedIndex = -1;
			docVentaTableAdapter.Fill(tablaTipoDS.DocVenta);
            cmbDVenta.SelectedIndex = -1;
			cIE10TableAdapter.Fill(cie10DS.CIE10);
			consultoriosTableAdapter.Fill(consultoriosDS.Consultorios, Operativo.id_oper);
            cmbEspecialidad.SelectedIndex = -1;
			busesTableAdapter.Fill(busesDS.Buses, Operativo.id_oper);
            cmbBus.SelectedIndex = -1;
			turnoTableAdapter.Fill(tablaTipoDS.Turno);
            cmbTurno.SelectedIndex = -1;

			int ce = General.vtrls(Especialidad.esp);
            int ca = Especialidad.esp.Length > 0 ? 1 : 0;
        
            txtEnAcIni.Enabled = txtEnAcCur.Enabled = txtEnAcRel.Enabled = txtAnPer.Enabled = txtAnFam.Enabled = txtAnEpi.Enabled = txtAnQui.Enabled = txtAnOtr.Enabled = txtExClPs.Enabled = txtExClTl.Enabled = txtExClPa.Enabled = txtExClFc.Enabled = txtExClFr.Enabled = txtExClTm.Enabled = txtExClEg.Enabled = groupBoxTraMed.Enabled = grdDetCie10.Enabled = chkCompleto.Enabled = btnAgregar.Enabled = btnQuitar.Enabled = btnBCie10.Enabled = btnVerifica.Enabled = cmbEspecialidad.Enabled = !(ca + ce == 2);
            /*chkCompleto.Checked = (ca + ce == 2);
            cmbEspecialidad.SelectedIndex = (ca + ce == 2) ? 0 : -1;
            cmbBus.Enabled = !(ca == 1);
            cmbBus.SelectedValue = (ca == 1 ? Usuario.id_area : "");
            txtFechaAten.Text = (ca == 1 ? DateTime.Today.ToString() : "");*/
            txtDigitador.Text = Usuario.usuario;

			pce(true, true);

            string cr = "";
            if (Especialidad.esp.Length > 0)
                cr = "Descripcion='" + Especialidad.esp + "'";
            else
                cr = "Left(Id_Consultorio,3)='" + Operativo.id_oper + "'";

            string sql1 = "Select Id_Consultorio,Descripcion From Consultorios Where " + cr + " Order By 2";
			iCons = General.GetDictionaryList(sql1);

            string sql3 = "Select id_med, descr + Case When Len(conc)>0 Then ' (' + conc + ')' Else '' End medicamento, cla2 + ' (' + pres + ')' presentacion From medicaments Order By 2";
			medicaments = General.GetDictionaryList(sql3);

        }

        private void chkFiltro_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ((CheckBox)sender).Checked;

            cmbEspecialidad.Enabled = !check;
            cmbDVenta.Enabled = !check;
            txtFechaEmi.Enabled = !check;
            txtSerie.Enabled = !check;
        }

        private bool processKeyDown()
        {
            if (txtNroTicket.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nro. de documento de venta ...", "Ingreso y consulta de atenciones realizadas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }

			LimpiaFormulario();
            int count = pfv();
            chkOpFil.Focus();

            if (count == 0)
            {
                MessageBox.Show("Documento de venta no existe o no corresponde a la especialidad, verifique ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                pcl();
            }
            return true;
        }

        private void txtNroDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                processKeyDown();
        }

		public void LimpiaFormulario()
		{
			cmbBus.SelectedIndex = -1;
			cmbTurno.SelectedIndex = -1;
			cmbMedico.SelectedIndex = -1;
			chkIdem.Checked = false;

			txtPaciente.Text = txtFechaNac.Text = txtEdad.Text = txtSexo.Text = txtOrden.Text = txtEspecialidad.Text = txtFechaEmiFil.Text = "";

			txtExClEg.Text = txtDigitador.Text = txtMedico.Text = txtCuenta.Text = txtObservacion.Text = txtFechaIngreso.Text = txtEnAcIni.Text = txtEnAcCur.Text = txtEnAcRel.Text = txtExClPs.Text = txtExClTl.Text = txtExClPa.Text = txtExClFc.Text = txtExClFr.Text = txtExClTm.Text = txtExClEg.Text = "";

			txtAnPer.Text = txtAnFam.Text = txtAnEpi.Text = txtAnQui.Text = txtAnOtr.Text = "";

			grdDetalle.Rows.Clear();
			grdTraMed.Rows.Clear();
			grdDetCie10.Rows.Clear();
		}

		public void pcl()
        {
            string ne = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();
            string fe = txtFechaEmi.Text;
            string dv = cmbDVenta.SelectedIndex == -1 ? "" : cmbDVenta.SelectedValue.ToString();
            string sr = txtSerie.Text;

            string fa = txtFechaAten.Text;
            int bs = cmbBus.SelectedIndex;
            int tr = cmbTurno.SelectedIndex;
            int cm = cmbMedico.SelectedIndex;
            string cn = txtCuenta.Text;

            General.setAll<TextBox, string>(this, "Text", "");
            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);
            General.setAll<Button, bool>(this, "Enabled", false);

            btnVerifica.Enabled = true;
            cmbEspecialidad.SelectedValue = ne;
            txtFechaEmi.Text = fe;
            cmbDVenta.SelectedValue = dv;
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

            txtFechaAten.Text = General.emptyDate;
            txtTi.Text = "0";
            txtTotal.Text = "0.00";
            txtNroTicket.Focus();
        }

        private int pfv()
        {
			hi = DateTime.Today;

            string sql = "";
            sql += "Select T.Serie,T.Nro_Ticket,";
            sql += tabIngresoConsulta.SelectedIndex == 0 ? "T.Fecha_Emision," : "CB.Fecha_Atencion,";
            sql += "T.Digitador AS Digitador,T.Nro_Historia,T.Id_Paciente,C.Descripcion,X.Orden,T.Anulado";
            sql += tabIngresoConsulta.SelectedIndex == 0 ? " " : ",T.Fecha_Emision ";
            sql += "From Tickets T Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " + "Inner Join (Select Ape_Paterno+' '+Ape_Materno+', '+Nombres+' ('+SubString(TNCol,2,6)+')' Orden,Id_Personal " + "From Personal Union All Select Descripcion,Id_Tipo From TablaTipo Where Id_Tabla In " + "(Select Id_Tipo From TablaTipo Where Descripcion='VAR_EXTRAS' And Id_Tabla='0'))X On T.CMP=X.Id_Personal ";
            sql += tabIngresoConsulta.SelectedIndex == 0 ? "" : "Inner Join Cab_Cie10 CB On CB.Nro_Historia=T.Nro_Historia ";
            sql += "Where 1 = 1 And ";

            if (tabIngresoConsulta.SelectedIndex == 0)
            {
                if (chkOpFil.Checked || General.vtrls(Especialidad.esp) == 1)
                {
                    sql += cmbEspecialidad.SelectedIndex != -1 ? (" T.Id_Consultorio Like '" + General.GetSelectedDictionary(cmbEspecialidad)["Id_Consultorio"] + "'") : "";
                    sql += sql.Contains("Like") && cmbEspecialidad.SelectedIndex != -1 ? " And " : "";
                    sql += txtFechaEmi.Text != General.emptyDate ? (" T.Fecha_Emision Between CONVERT(SMALLDATETIME,'" + txtFechaEmi.Text + "',103) And CONVERT(SMALLDATETIME,'" + DateTime.Parse(txtFechaEmi.Text).AddDays(1).ToString("dd/MM/yyyy") + "',103) And ") : "";
                    sql += sql.Contains("Like") && txtFechaEmi.Text != General.emptyDate ? " And" : "";
                    sql += cmbDVenta.SelectedIndex != -1 ? (" T.DVenta Like '" + General.GetSelectedDictionary(cmbDVenta)["Id_Tipo"] + "'") : "";
                }

                sql += sql.Contains("Like") && cmbDVenta.SelectedIndex != -1 ? " And" : "";
                sql += txtSerie.Text.Length > 0 ? (" T.Serie Like '" + txtSerie.Text + "'") : "";
                sql += sql.Contains("Like") && txtSerie.Text.Length > 0 ? " And" : "";
                sql += txtNroTicket.Text.Length > 0 ? (" T.Nro_Ticket Like '%" + txtNroTicket.Text + "%'") : "";
            }
            else
                sql += " T.Id_Paciente='" + pac["Id_Paciente"] + "'";

            lstTickets0.Items.Clear();
            lstTickets1.Items.Clear();
			
			tickets = General.GetDictionaryList(sql);
            for (int i = 0; i < tickets.Count; i++)
				tickets[i]["Digitador"] = General.TradUser(tickets[i]["Digitador"]);

            if ( tickets.Count > 0)
            {
                string[] fields = { "Serie", "Nro_Ticket", "Fecha_Emision", "Digitador" };

                if (tabIngresoConsulta.SelectedIndex == 0)
                {
                    General.Fill(lstTickets0, tickets, fields);
                    lstTickets0.Focus();
                }
                else
                {
                    General.Fill(lstTickets1, tickets, fields);
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
			string sql = "";

			sql = "Select Count(*) AS C From Cab_Cie10 Where Fecha_Atencion='" + fa + "' And Id_Bus='" + bs + "' And Turno='" + tr + "' ";
            if ( ptc(bs, 0) == "P")
                sql += " And CMP='" + cm + "";

			return Conexion.ExecuteScalar<int>(sql);
        }

        private void frmIngresoCie10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
				DialogResult = DialogResult.Cancel;
				Close();
            }

            if (e.KeyCode == Keys.F1)
                txtObservacion.Focus();

            if (e.KeyCode == Keys.F2)
				pce(true, true);

            if (e.KeyCode == Keys.F3 && btnAgregar.Enabled)
                btnAgregar_Click(btnAgregar, e);

            if (e.KeyCode == Keys.F4 && btnQuitar.Enabled)
                btnQuitar_Click(btnQuitar, e);

            if (e.KeyCode == Keys.F5 && btnBCie10.Enabled)
                btnBCie10_Click(btnBCie10, e);

            if (e.KeyCode == Keys.F6 && btnGrabar.Enabled)
                btnGrabar_Click(btnGrabar, e);

            if (e.KeyCode == Keys.F7 && btnVerifica.Enabled)
                btnVerifica_Click(btnVerifica, e);

            if (e.KeyCode == Keys.F8)
            {
                chkIdem.Enabled = true;
                chkIdem.Checked = false;
                chkIdem_CheckedChanged(chkIdem, e);
            }

            if (e.KeyCode == Keys.F9 && cmbBus.SelectedIndex > -1 && cmbMedico.SelectedIndex > -1)
            {
                List<Dictionary<string, string>> detalles = General.GetDictionaryList(grdDetalle);
                frmResultado frmResultado = new frmResultado(detalles, cmbBus.SelectedValue.ToString(), cmbMedico.SelectedValue.ToString(), nh);
                frmResultado.docVenta = ticket["Serie"] + "-" + ticket["Nro_Ticket"];
                frmResultado.paciente = txtPaciente.Text;
                frmResultado.edad = txtEdad.Text;
                frmResultado.especialidad = txtEspecialidad.Text;
                frmResultado.medico = txtMedico.Text;
                frmResultado.fechaAtencion = txtFechaAten.Text;
                frmResultado.FormClosed += new FormClosedEventHandler(frmResultado_FormClosed);
                frmResultado.ShowDialog();
				//Hide();
            }
        }

        private void frmResultado_FormClosed(object sender, FormClosedEventArgs e)
        {
            int cp = ((frmResultado)sender).cp;

            txtNroTicket.Text = "";
            txtNroTicket.Focus();

            if ( iu == 0 && cp == 0)
				btnGrabar_Click(btnGrabar, new EventArgs());

			Show();
        }

        private void txtSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtNroTicket.Focus();
        }

        private void lstTickets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index = General.GetSelectedIndex((ListView)sender);
                ticket = tickets[index];

                if (ticket["Anulado"] != "")
                {
                    MessageBox.Show("N° de documento de venta esta anulado ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    pcl();
                    return;
                }
				pfp(ticket["Id_Paciente"]);
				pla();
            }
        }
		
        public int vexis(string sql, string msg, bool cnd, string pex)
        {
            int c = Conexion.ExecuteScalar<int>(sql);

            if (!cnd ? c == 0 : c > 0)
            {
                MessageBox.Show(msg, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (!cnd)
                {
                    Type thisType = GetType();
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
				pacs = General.GetDictionaryList(sql);
                if ( pacs.Count > 0)
					pac = pacs[0];

                General.Fill(lstPacientes, pacs, new string[] { "Paciente" });
            }

			/*
            if (np == 1)
                lstTickets1.Items.Clear();
			*/
        }

        public void pla()
        {
			if( ticket == null )
			{
				MessageBox.Show("No se encuentra ticket para el registro seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}
			else if( ticket.Count == 0 )
			{
				MessageBox.Show("No se encuentra ticket para el registro seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

            txtPaciente.Text = pac["Ape_Paterno"] + " " + pac["Ape_Materno"] + ", " + pac["Nombre"] + " (" + pac["Id_Paciente"] + ")";
            txtFechaNac.Text = pac["Fecha_Nac"];
            txtEdad.Text = pac["Edad"];
            txtSexo.Text = pac["Sexo"] == "M" ? "MASCULINO" : "FEMENINO";
            txtOrden.Text = ticket["Orden"];
            txtEspecialidad.Text = ticket["Descripcion"];
            txtFechaEmiFil.Text = DateTime.Parse(ticket["Fecha_Emision"]).ToString(General.dateTimeFormat);
            txtCajero.Text = "CAJERO: ( " + ticket["Digitador"] + " )";
			nh = ticket["Nro_Historia"];

            string sql = "Select D.Nro_Historia, D.Id_Producto, P.Descripcion, D.Cantidad, CAST(D.Monto AS DECIMAL(16,2)) as Monto, CAST(D.Cantidad * D.Monto AS DECIMAL(16,2)) As SubTotal, D.Pagado,  CAST(D.Dscto AS DECIMAL(16,2)) as Dscto, D.Resultado, D.Conclusion, 1 As M From Detalles D Inner Join Productos P On D.Id_Producto=P.Id_Producto Where Nro_Historia='" + nh + "'";
            List<Dictionary<string, string>> detalles = General.GetDictionaryList(sql);

            txtTotal.Text = detalles.Sum(x => decimal.Parse(x["SubTotal"])).ToString();
            General.Fill(grdDetalle, detalles);
            string cabCie10Sql = "Select * From Cab_Cie10 Where Nro_Historia = '" + ticket["Nro_Historia"] + "'";
            Dictionary<string, string> cabCie10 = General.GetDictionary(cabCie10Sql);

            if (cabCie10 != null)
            {
                if (tabIngresoConsulta.SelectedIndex == 0)
                {
                    MessageBox.Show("Ya fue procesada la historia clinica ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    string ia = Usuario.id_area;
                    string iu = cabCie10["Digitador"];

                    //La siguiente línea no se pudo ejecutar
                    if (General.SafeSubstring(ia, 0, 3) == Operativo.id_oper)
                        vexis("Select Count(*) as C From sysaccusers Where Id_Us = '" + iu + "' And Id_Area = '" + ia + "'", "Este registro no corresponde a su consultorio", false, "pcl");

                    txtNroTicket.Focus();
                }

				pce(true, true);//Se asume que el segundo parámetro tiene una valor por defecto de TRUE
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
                txtFechaIngreso.Text = DateTime.Parse(cabCie10["Fecha_Ingreso"]).ToString(General.dateTimeFormat);

                string detCie10Sql = "Select DC.*,CI.Descripcion From Det_Cie10 DC Left Join Cie10 CI On DC.Cie10=CI.Cie10 Where Nro_Historia='" + nh + "'";
                List<Dictionary<string, string>> tmpCie10 = General.GetDictionaryList(detCie10Sql);
				dr = tmpCie10.Count;

                grdDetCie10.Rows.Clear();
                foreach (Dictionary<string, string> item in tmpCie10)
                    grdDetCie10.Rows.Add(new[] { item["Nro_Historia"], item["CIE10"], item["Descripcion"], item["Procedimiento"] });

                btnAgregar.Enabled = btnQuitar.Enabled = btnBCie10.Enabled = (dr > 0 && tabIngresoConsulta.SelectedIndex == 0);
                //btnImprimir.Enabled = (this.dr > 0);//CUal botón imprimir?
                btnGrabar.Enabled = (tabIngresoConsulta.SelectedIndex == 0);

                string tratMedSql = "Select * From tratmed Where nro_reg='" + nh + "'";
                List<Dictionary<string, string>> tmpTratMed = General.GetDictionaryList(tratMedSql);
                General.Fill(grdTraMed, tmpTratMed);
				//General.FillListView(grdTraMed, this.tmpTratMed, new[] {"nro_reg", "id_med", "cant", "dosis", "dias" });

				dr += tmpTratMed.Count;
                this.iu = 1;
				pg = cabCie10["Id_Per"] != "" ? 1 : 0;
            }
            else
            {
				dr = 0;
				iu = 0;
				pg = 0;

                General.setAll<TextBox, string>(this, "Text", "");
                General.setAll<Button, bool>(this, "Enabled", false);

                btnVerifica.Enabled = true;
                cmbBus.SelectedValue = ((Usuario.id_area.Length > 3 ? Usuario.id_area.Substring(0, 3) : Usuario.id_area) == Operativo.id_oper) ? Usuario.id_area : cmbBus.SelectedValue;
                txtDigitador.Text = Usuario.usuario;
                txtFechaIngreso.Text = General.emptyDateTime;
                if (chkIdem.Checked)
                    txtFechaAten.Focus();
                else
                    txtObservacion.Focus();
            }
        }

        public bool pvl(int lv)
        {
            if (lv == 5)
            {
                if (grdDetalle.Rows.Count == 0)
                {
                    MessageBox.Show("El registro no tiene detalle de venta ... comuniquese con el administrador del sistema ... urgente !!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
            }

            if (lv == 1 || lv == 5)
            {
                if ((txtFechaAten.Text != General.emptyDate && txtFechaEmi.Text != General.emptyDate) && (DateTime.Parse(txtFechaAten.Text) < DateTime.Parse(txtFechaEmi.Text)))
                {
                    MessageBox.Show("Corregir datos, fecha de atención no puede ser menor que fecha de emisión ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    txtFechaAten.Focus();
                    return false;
                }
            }

            if (lv == 2 || lv == 5)
            {
                if (cmbBus.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese nombre de  consultorio (Bus) ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    cmbBus.Focus();
                    return false;
                }
            }

            if (lv == 3 || lv == 5)
            {
                if (cmbTurno.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese turno ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    cmbTurno.Focus();
                    return false;
                }
            }

            if (lv == 4 || lv == 5)
            {
                if (cmbMedico.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese numero de colegiatura del especialista ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    cmbMedico.Focus();
                    return false;
                }
            }
            return true;
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
			tmpEspecialistaTableAdapter.Fill(tmpEspecialistaDS.tmpEspecialista, bus);
            cmbMedico.SelectedIndex = -1;
            General.AdjustComboBoxWidth(cmbMedico);

            if (xcm != -1 && lrc)
            {
                cmbMedico.SelectedIndex = xcm;
                txtMedico.Text = General.GetSelectedString(cmbMedico, "FullEspecialista");
            }
        }

        private string BorrarTablaEspecialista(bool execute = true)
        {
            string sql = "IF OBJECT_ID('dbo.tmpEspecialista', 'U') IS NOT NULL DROP TABLE tmpEspecialista;";

            if (execute)
                Conexion.ExecuteNonQuery(sql);

            return sql;
        }

        private string BorrarTablaMedic()
        {
            string sql = "IF OBJECT_ID('tempdb.dbo.#tmpMedic', 'U') IS NOT NULL DROP TABLE #tmpMedic;";
            Conexion.ExecuteNonQuery(sql);
            return sql;
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            string xbs = cmbBus.SelectedIndex == -1 ? "": cmbBus.SelectedValue.ToString();
            string xtr = cmbTurno.SelectedIndex == -1 ? "": cmbTurno.SelectedValue.ToString().Substring(0, 1);
            string xfa = txtFechaAten.Text;
            string xcm = cmbMedico.SelectedIndex == -1? "": cmbMedico.SelectedValue.ToString();

            if (xbs.Length == 0 || xtr.Length == 0 || xfa.Length == 0 || xcm.Length == 0)
                return;
            //
            string sql = "Select Serie, Nro_Ticket, CONVERT(VARCHAR,Fecha_Atencion, 103) Fecha_Atencion, SubString(TNCol,2, 7)CMP, " +
						"B.Bus,C.Descripcion Consultorio, U.Descripcion Turno, CB.Digitador, " +
						"DC.Cie10,DC.Procedimiento,CB.Nro_Historia,CI.Descripcion Diagnostico " +
						"From Cab_Cie10 CB Inner Join " +
						"(Select Id_Tipo, Descripcion " +
						" From TablaTipo " +
						" Where Id_Tabla In " +
						" (Select Id_Tipo " +
						"  From TablaTipo " +
						"  Where Descripcion = 'TURNOS' " +
						"  And Id_Tabla = '0')) U " +
						"On CB.Turno = U.Id_Tipo Inner Join Tickets T " +
						"On CB.Nro_Historia = T.Nro_Historia Inner Join Consultorios C " +
						"On C.Id_Consultorio = T.Id_Consultorio Inner Join Buses B " +
						"On CB.Id_Bus = B.Id_Bus Inner Join Personal P " +
						"On CB.CMP = P.Id_Personal Left Join Det_Cie10 DC " +
						"On CB.Nro_Historia = DC.Nro_Historia Left Join Cie10 CI " +
						"On DC.Cie10 = CI.Cie10 " +
						"Where CB.Id_Bus = '" + xbs + "' And CB.Turno = '" + xtr + "' And Fecha_Atencion = '" + xfa + "' ";
            sql += ptc(xbs, 0) == "T" ? "" : "And CB.CMP = '" + xcm + "' ";
            sql += "Order By Fecha_Ingreso";
            //
            List<Dictionary<string, string>> list = General.GetDictionaryList(sql);
            frmVerificaCie frmVerificaCie10 = new frmVerificaCie(list);
            frmVerificaCie10.FormClosed += new FormClosedEventHandler(frmVerificaCie_FormClosed);
            frmVerificaCie10.ShowDialog();
			//Hide();
        }

        private void frmVerificaCie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((frmVerificaCie)sender).DialogResult == DialogResult.OK)
            {
                txtNroTicket.Text = ((frmVerificaCie)sender).nroTicket;
				processKeyDown();
            }
			Show();
        }

        private void chkIdem_CheckedChanged(object sender, EventArgs e)
        {
            txtFechaAten.Enabled = cmbTurno.Enabled = cmbMedico.Enabled = !chkIdem.Checked;
            cmbBus.Enabled = !chkIdem.Checked && General.SafeSubstring(Usuario.id_area, 0, 3) != Operativo.id_oper;
            txtCuenta.Enabled = chkIdem.Checked;
            txtCuenta.Text = "0";
        }

        private void txtApePat_TextChanged(object sender, EventArgs e)
        {
			lstTickets1.Items.Clear();
			LimpiaFormulario();
			pfp();
        }

        private void txtApeMat_TextChanged(object sender, EventArgs e)
        {
			lstTickets1.Items.Clear();
			LimpiaFormulario();
			pfp();
        }

        private void txtIdPac_TextChanged(object sender, EventArgs e)
        {
			lstTickets1.Items.Clear();
			LimpiaFormulario();
			pfp();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
			lstTickets1.Items.Clear();
			LimpiaFormulario();
			pfp();
        }

        private void lstTickets1_SelectedIndexChanged(object sender, EventArgs e)
        {
			//pla();
        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(lstPacientes);
			pac = pacs[i];
			int count = pfv();
			if( count == 0 )
				return;
		}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ( ga == 0)
                grdDetCie10.Rows.Add(new[] { "", "", "", "" });

			dr++;
            if (dr > 0)
                btnQuitar.Enabled = btnGrabar.Enabled = true;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            grdDetCie10.Rows.RemoveAt(grdDetCie10.CurrentCell.RowIndex);

			dr--;
            if ( dr == 0)
                btnGrabar.Enabled = btnQuitar.Enabled = btnBCie10.Enabled = true;
        }

        private void btnBCie10_Click(object sender, EventArgs e)
        {
            frmCie10 frmCie10 = new frmCie10();
            frmCie10.FormClosed += new FormClosedEventHandler(frmCie10_FormClosed);
            frmCie10.ShowDialog();
			//Hide();
        }

        private void frmCie10_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((frmCie10)sender).cie10.Length > 0)
            {
				grdDetCie10.Rows[grdDetCie10.CurrentCell.RowIndex].Cells[0].Value = ((frmCie10)sender).cie10;
				grdDetCie10.Rows[grdDetCie10.CurrentCell.RowIndex].Cells[1].Value = ((frmCie10)sender).descripcion;
            }
			Show();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!pvl(5)) return;

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
            double df = (DateTime.Today - hi).TotalSeconds;

			//General.RemoveAll(grdDetCie10, x => x["cNroHistoria"].Length == 0 || (x["cCie10"].Length + x["cProcedimiento"].Length) == 0);
			General.RemoveAll(grdDetCie10, x => x["cNroHistoria"].Length == 0 || (x["cCie10"].Length + x["cProcedimiento"].Length) == 0);
			int dn = grdDetCie10.Rows.Count;

			if (dn == 0 && ptc(bs, 1) != "LABORATORIO" && General.vtrls(Especialidad.esp) == 0)
            {
                if (MessageBox.Show("No ha agregado diagnostico alguno ... desea continuar ?", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    btnAgregar.Focus();
                    return;
                }
            }

            if (MessageBox.Show("Desea guardar los datos ... ?", "Confirmación de grabado", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                if ( iu == 0)
                {
                    if ( ptc(bs, 1) != "LABORATORIO")
                    {
                        Conexion.ExecuteNonQuery("Update Detalles Set Pagado = 'R' Where Nro_Historia = '" + this.nh + "'");

                        for (int i = 0; i < grdDetalle.Rows.Count; i++)
                        {
                            if (grdDetalle.Rows[i].Cells["Nro_Historia"].Value.ToString() == this.nh)
                                grdDetalle.Rows[i].Cells["Pagado"].Value = "R";
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
                    if ( pg == 1)
                    {
                        MessageBox.Show("El registro ya fue pagado ... no se puede modificar ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    if (Usuario.usuario != txtDigitador.Text)
                    {
                        if (MessageBox.Show("Está seguro de modificar datos ingresados por:\n" + txtDigitador.Text + "?", "Aviso al usuario", MessageBoxButtons.OKCancel) != DialogResult.OK)
                            return;
                    }

                    string sql1 = "Update Cab_Cie10 Set Fecha_Atencion = '" + fa + "', CMP = '" + cm + "', Id_Bus = '" + bs + "', Turno = '" + tr + "', Digitador = '" + dg + "', En_Ac_Ini = '" + ei + "', '+'En_Ac_Cur = '" + ec + "', En_Ac_Rel = '" + er + "', An_Per = '" + ap + "', An_Fam = '" + af + "', An_Epi = '" + ae + "', An_Qui = '" + aq + "', An_Otr = '" + ao + "', Ex_Cl_Ps = '" + ps + "', '+'Ex_Cl_Tl = '" + tl + "', Ex_Cl_PA = '" + pa + "', Ex_Cl_FC = '" + fc + "', Ex_Cl_FR = '" + fr + "', Ex_Cl_Tm = '" + tm + "', Ex_Cl_Eg = '" + eg + "', Observacion = '" + ob + "', '+'Fecha_Ingreso = '" + DateTime.Now + "', tsg = '" + df + "' Where Nro_Historia = '" + this.nh + "'";
                    Conexion.ExecuteNonQuery(sql1);

                    string sql2 = "Delete From Det_Cie10 Where Nro_Historia = '" + this.nh + "'";
                    Conexion.ExecuteNonQuery(sql2);

                    string sql3 = "Delete From tratmed Where nro_reg = '" + this.nh + "'";
                    Conexion.ExecuteNonQuery(sql3);

                    //Se debería poner en readonly columnas 5, 6 y 7 de grdDetalle
                }

                if ( ptc(bs, 1) != "LABORATORIO")
                {
                    foreach (Dictionary<string, string> item in General.GetDictionaryList(grdDetCie10))
                    {
                        string sql3 = "Exec AddDetCie10 '" + this.nh + "', '" + item["cCie10"] + "', '" + item["cProcedimiento"] + "'";
                        Conexion.ExecuteNonQuery(sql3);
                    }
                }

                foreach (Dictionary<string, string> item in General.GetDictionaryList(grdTraMed))
                {
                    string sql4 = "Insert Into tratmed Values('" + this.nh + "', '" + item["id_med"] + "', '" + item["cant"] + "', '" + item["dosis"] + "', '" + item["dias"] + "')";
                    Conexion.ExecuteNonQuery(sql4);
                }
                MessageBox.Show("Operación ejecutada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

			hi = DateTime.Now;
			pg = 0;
            txtTi.Text = pct().ToString();
            //
            txtFechaIngreso.Text = DateTime.Now.ToString(General.dateTimeFormat);
            btnGrabar.Enabled = false;

            if ( Visible )
            {
                txtNroTicket.Text = "";
                txtNroTicket.Focus();
            }
        }

        private void cmbBus_Leave(object sender, EventArgs e)
        {
            if (cmbBus.SelectedIndex != -1)
            {
                if (!pvl(1)) return;

                Dictionary<string,string> bus = General.GetSelectedDictionary(cmbBus);

                if (bus["Estado"].ToString() != "1")
                {
                    MessageBox.Show("Consultorio (Bus) seleccionado esta desactivado ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    cmbBus.SelectedIndex = 1;
                    return;
                }

                string es = txtEspecialidad.Text;
                string ib = cmbBus.SelectedValue.ToString();

                string sql = "Select Count(*) As C From Buses B Inner Join Consultorios C On C.Id_Consultorio=B.Id_Esp Where C.Descripcion = '" + es + "' And Id_Bus = '" + ib + "'";
                int c = Conexion.ExecuteScalar<int>(sql);

                if (c == 0)
                {
                    MessageBox.Show("Consultorio (Bus) no corresponde a la especialidad ... desea continuar ?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    cmbBus.SelectedIndex = 1;
                    return;
                }

				pce(false, true);
            }
        }

        private void cmbTurno_Leave(object sender, EventArgs e)
        {
            if (!pvl(2)) return;
        }

        private void txtObservacion_Leave(object sender, EventArgs e)
        {
            if (!pvl(4)) return;

            if ( pg == 0 && tabIngresoConsulta.SelectedIndex == 0)
            {
                if ( ptc(cmbBus.SelectedValue.ToString(), 1) == "LABORATORIO")
                    btnGrabar.Enabled = true;
                else
                    btnAgregar.Enabled = true;

				ga = 0;
            }
        }

        private void cmbMedico_Leave(object sender, EventArgs e)
        {
            if ( DialogResult != DialogResult.Cancel)
                cmbMedico_SelectionChangeCommitted(cmbMedico, new EventArgs());
        }

        private void txtFechaEmi_Validating(object sender, CancelEventArgs e)
        {
            DateTime rs;
            if (txtFechaEmi.Text != General.emptyDate && !DateTime.TryParseExact(txtFechaEmi.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out rs))
                e.Cancel = true;
        }

        private void txtFechaAten_Validating(object sender, CancelEventArgs e)
        {
            DateTime rs;
            if (txtFechaAten.Text != General.emptyDate && !DateTime.TryParseExact(txtFechaAten.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out rs))
                e.Cancel = true;
        }
        
        private void tabIngresoConsulta_Click(object sender, EventArgs e)
        {
			if( tabIngresoConsulta.SelectedIndex == 0 )
			{
				cmbEspecialidad.SelectedIndex = -1;
				cmbDVenta.SelectedIndex = -1;
				txtFechaEmi.Text = "";
				chkOpFil.Checked = false;
				txtSerie.Text = "";
				txtNroTicket.Text = "";
				lstTickets0.Items.Clear();
				LimpiaFormulario();
			}
			else if( tabIngresoConsulta.SelectedIndex == 1 )
			{
				txtApePat.Text = "";
				txtApeMat.Text = "";
				txtNombre.Text = "";
				txtIdPac.Text = "";
				lstPacientes.Items.Clear();
				lstTickets1.Items.Clear();
				LimpiaFormulario();
				General.setAll<Button, bool>(this, "Enabled", false);
			}
        }

        private void grdDetCie10_Enter(object sender, EventArgs e)
        {
			ga = 0;
        }

        private void grdTraMed_Enter(object sender, EventArgs e)
        {
			ga = 1;
        }

        private void txtCuenta_Leave(object sender, EventArgs e)
        {
            chkIdem.Enabled = txtCuenta.Enabled = !(chkIdem.Checked && txtCuenta.Text.Length > 0);
        }

        private void txtFechaAten_Leave(object sender, EventArgs e)
        {
            if (txtFechaEmiFil.Text == General.emptyDateTime || txtFechaAten.Text == General.emptyDate)
            {
                txtNroTicket.Focus();
                return;
            }

            if (General.vFecha(DateTime.Parse(txtFechaAten.Text), txtFechaAten))
                cmbBus.Focus();
            else
                txtNroTicket.Focus();
        }

        private void txtAnPer_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.Left))
                txtEnAcRel.Focus();
        }

        private void cmbMedico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!pvl(3)) return;
            txtMedico.Text = General.GetSelectedString(cmbMedico, "FullEspecialista");

            if (!chkCompleto.Checked)
                txtObservacion.Focus();
        }
        
        private void grdDetCie10_Validated(object sender, EventArgs e)
        {
			ga = 0;
        }

        private void grdTraMed_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int i = grdTraMed.CurrentCell.RowIndex;
            int j = grdTraMed.CurrentCell.ColumnIndex;
            string columnName = grdTraMed.Columns[j].Name;

            if (columnName == "tMedicamento")
                grdTraMed.Rows[i].Cells[j].Value = nh;
        }

        private void grdDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int i = grdDetalle.CurrentCell.RowIndex;
            int j = grdDetalle.CurrentCell.ColumnIndex;
            string columnName = grdDetalle.Columns[j].Name;

            if (columnName == "dPagado")
            {
                ComboBox combo = (ComboBox)e.Control;
                if ((combo != null))
                {
                    combo.SelectionChangeCommitted -= new EventHandler(dPagado_SelectionChangeCommitted);
                    combo.SelectionChangeCommitted += new EventHandler(dPagado_SelectionChangeCommitted);
                }
            }

            if (columnName == "dDescuento")
            {
                decimal descuento = decimal.Parse(grdDetalle.Rows[i].Cells["Nro_Historia"].Value.ToString());
                decimal precio = decimal.Parse(grdDetalle.Rows[i].Cells["Precio"].Value.ToString());
                decimal cantidad = decimal.Parse(grdDetalle.Rows[i].Cells["Cantidad"].Value.ToString());

                if (descuento > (precio * descuento) || descuento < 0)
                {
                    MessageBox.Show("Valor para descuento no valido ... verifique", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    grdDetalle.Rows[i].Cells["Descuento"].Value = "0.00";
                }
                else
                {
                    string nh = grdDetalle.Rows[i].Cells["Nro_Historia"].Value.ToString();
                    string ip = grdDetalle.Rows[i].Cells["Id_Producto"].Value.ToString();
                    string pg = grdDetalle.Rows[i].Cells["Pagado"].Value.ToString();

                    Dictionary<string, string> descuentoObj = General.GetDictionaryList(grdDetalle).Find(x => x["Nro_Historia"] == nh && x["Id_Producto"] == ip);

                    if (descuento != decimal.Parse(descuentoObj["Descuento"]) && pg != "P")
                    {
                        string sql = "Update Detalles Set Dscto='" + descuento.ToString() + "' Where Nro_Historia='" + nh + "' And Id_Producto='" + ip + "'";
                        Conexion.ExecuteNonQuery(sql);
                    }
                    else
                        grdDetalle.Rows[i].Cells["Descuento"].Value = "0.00";
                }
            }
        }

        private void dPagado_SelectionChangeCommitted(System.Object sender, System.EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            int i = grdDetalle.CurrentCell.RowIndex;
            string nh = grdDetalle.Rows[i].Cells["Nro_Historia"].Value.ToString();
            string ip = grdDetalle.Rows[i].Cells["Id_Producto"].Value.ToString();
            string pg = grdDetalle.Rows[i].Cells["Pagado"].Value.ToString();

            string sql = "Update Detalles Set Pagado='" + pg + "' Where Nro_Historia='" + nh + "' And Id_Producto='" + ip + "'";
            Dictionary<string, string> pagado = General.GetDictionaryList(grdDetalle).Find(x => x["Nro_Historia"] == nh && x["Id_Producto"] == ip);

            if (pagado["Pagado"] == "P")
            {
                MessageBox.Show("No puede modificar esta condicion ... ya fue pagado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                grdDetalle.Rows[i].Cells["Condicion"].Value = pagado["Pagado"];
                return;
            }

            if (pagado["Pagado"] == "R" && grdDetalle.Rows[i].Cells["Condicion"].Value.ToString() != "R")
            {
                if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    grdDetalle.Rows[i].Cells["Condicion"].Value = pagado["Pagado"];
                else
                    Conexion.ExecuteNonQuery(sql);
            }

        }

        private void grdDetCie10_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdDetCie10.CurrentCell.RowIndex;
            int j = grdDetCie10.CurrentCell.ColumnIndex;
            string columnName = grdDetCie10.Columns[j].Name;

            if (columnName == "cProcedimiento")
                grdDetCie10.Rows[i].Cells["cNroHistoria"].Value = nh;
        }

        private void grdDetCie10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grdDetCie10.BeginEdit(true);
        }

        private void grdDetCie10_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
			if( e.Control is TextBox )
				((TextBox)e.Control).CharacterCasing = CharacterCasing.Upper;

			int i = grdDetCie10.CurrentCell.RowIndex;
            int j = grdDetCie10.CurrentCell.ColumnIndex;
            string columnName = grdDetCie10.Columns[j].Name;

            if (columnName == "cCie10")
            {
                ComboBox combo = (ComboBox)e.Control;
                if ((combo != null))
                {
                    combo.SelectionChangeCommitted -= new EventHandler(cCie10_SelectionChangeCommitted);
                    combo.SelectionChangeCommitted += new EventHandler(cCie10_SelectionChangeCommitted);
                }
            }
		}

		private void cCie10_SelectionChangeCommitted(System.Object sender, System.EventArgs e)
        {
            int i = grdDetCie10.CurrentCell.RowIndex;
            int j = grdDetCie10.CurrentCell.ColumnIndex;

            ComboBox combo = (ComboBox)sender;
            string description = General.GetSelectedDictionary(combo)["Descripcion"];
            grdDetCie10.Rows[i].Cells["cDescripcion"].Value = description;
            grdDetCie10.CurrentCell = grdDetCie10.Rows[i].Cells["cProcedimiento"];
            grdDetCie10.CurrentCell.Selected = true;
        }

        private void grdDetCie10_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = false;
            }
        }

		private void txtSerie_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
				e.Handled = true;
		}

		private void txtExClPs_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') )
				e.Handled = true;
		}

		private void lstTickets0_DoubleClick( object sender, EventArgs e )
		{
			if( lstTickets0.SelectedIndices.Count > 0 )
			{
				if( lstTickets0.SelectedItems[0] != null )
					lstTickets_KeyDown(sender, new KeyEventArgs(Keys.Enter));
			}
				
		}

		private void lstTickets1_DoubleClick( object sender, EventArgs e )
		{
			if( lstTickets1.SelectedIndices.Count > 0 )
			{
				if( lstTickets1.SelectedItems[0] != null )
					lstTickets_KeyDown(sender, new KeyEventArgs(Keys.Enter));
			}
		}
	}
}
