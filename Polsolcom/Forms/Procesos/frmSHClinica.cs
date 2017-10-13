using Dapper;
using Polsolcom.Forms.Herramientas;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Connection;
using System.Collections.Generic;
using System.Drawing;
using TenTec.Windows.iGridLib;

namespace Polsolcom.Forms.Procesos
{
    public partial class frmSHClinica : Form
    {
        Keys lastKey;
        string cad = "";
        int odb = 0;
        string nrv = "";
        int nhp = 0;
        string nrc = "";
        string noc = "";
        string BUS = "";
        string hi = "";
        bool bTieneDocVenta = false;
        string NROHISTORIA = "";
        Dictionary<string, string> rdvopen = new Dictionary<string, string>();
        Dictionary<string, string> bpac = new Dictionary<string, string>();
        List<Dictionary<string, string>> cper = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> cins = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> tmpd = new List<Dictionary<string, string>>();
        Dictionary<string, string> igv = new Dictionary<string, string>();
        Dictionary<string, string> cesp = new Dictionary<string, string>();
        Dictionary<string, string> dventa = new Dictionary<string, string>();
        List<Dictionary<string, string>> productos = new List<Dictionary<string, string>>();

        public frmSHClinica()
        {
            InitializeComponent();
        }

        public void adv()
        {
            int i = grdDetalle.CurrentCell.RowIndex;

            this.tmpd.RemoveAll(x => x["Ipr"].Length == 0);
            //Llenar datagrid view???

            foreach (Dictionary<string, string> item in this.tmpd)
            {
                if (item["Nrv"] == this.nrv)
                {
                    string nh = this.nrv;
                    string ip = item["Ipr"];
                    string pr = Decimal.Parse(item["Cost"]).ToString();
                    string can = item["Cant"];
                    Conexion.ExecuteNonQuery("Exec AddDetalle '" + nh + "','" + ip + "','" + pr + "','" + can + "'");
                }

                this.cdv(this.nrv);
                this.tsg();
            }

            string fi = txtFechaEmision.Text;
            string ff = DateTime.Parse(txtFechaEmision.Text).AddDays(1).ToShortDateString();
            string dv = cmbTDoc.SelectedIndex == -1 ? "" : cmbTDoc.SelectedValue.ToString();
            string sr = txtSerie.Text;
            string cn = txtNroTicket.Text;
            string iu = Usuario.id_us;
            string io = Operativo.id_oper;
            string es = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();
            string ip2 = txtIdPaciente.Text;
            string dp = txtApePaterno.Text + " " + txtApeMaterno.Text + " " + txtNombre.Text;
            string fn = txtFechaNac.Text == General.emptyDate ? "" : txtFechaNac.Text;

            string sql = "Exec GenDocVen '" + fi + "','" + ff + "','" + iu + "','" + io + "','" + sr + "','" + dv + "','" + cn + "'";
            Conexion.ExecuteNonQuery(sql);
            General.matxt(es, ip2 + "\t" + dp + "\t" + fn + "\t" + (sr + "-" + cn) + "\t" + this.cper[i]["Medico"].Trim().Replace(",", "") + "\t" + fi);
        }

        public void arp()
        {
            string nh = this.nrv;

            string nm = txtNombre.Text;
            string ap = txtApePaterno.Text;
            string am = txtApeMaterno.Text;
            string di = txtDNI.Text;
            string fn = txtFechaNac.Text == General.emptyDate ? "" : txtFechaNac.Text;
            string ed = txtEdad.Text;
            string sx = txtSexo.Text;
            string tf = txtTelefono.Text;
            string dr = txtDireccion.Text;
            string sg = txtAsegurado.Text;
            string iu = cmbDistrito.SelectedIndex == -1 ? "" : cmbDistrito.SelectedValue.ToString();
            string od = txtODoc.Text;
            string em = txtEmail.Text;
            string nd = txtNroTicket.Text;
            string fe = txtFechaEmision.Text;
            string es = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();
            string us = Usuario.id_us;
            string op = Operativo.id_oper;
            string sr = txtSerie.Text;
            string om = cmbMedico.SelectedIndex == -1 ? "" : cmbMedico.SelectedValue.ToString();
            string it = cmbInstitucion.SelectedIndex == -1 ? "" : cmbInstitucion.SelectedValue.ToString();
            string fp = cmbMVen.SelectedIndex == -1 ? "" : cmbMVen.SelectedValue.ToString();
            string dv = cmbTDoc.SelectedIndex == -1 ? "" : cmbTDoc.SelectedValue.ToString();

            string sql = "Exec AddPacientes '" + nm + "','" + ap + "','" + am + "','" + di + "','" + fn + "','" + ed + "','" + sx + "','" + tf + "','" + dr + "','" + sg + "','" + iu + "','" + od + "','" + em + "','" + nh + "','" + nd + "','" + fe + "','" + es + "','" + us + "','" + op + "','" + sr + "','" + om + "','" + it + "','" + fp + "','" + dv + "'";
            Conexion.ExecuteNonQuery(sql);

            txtIdPaciente.Text = Conexion.ExecuteScalar<string>("Select Id_Paciente From Tickets Where Nro_Historia='" + nh + "'");
            this.noc = "NUEVO";
            this.adv();
            this.ghp();
        }

        public void arv()
        {
            string nh = this.nrv;

            string nd = txtNroTicket.Text;
            string fe = txtFechaEmision.Text;
            string es = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();
            string ip = txtIdPaciente.Text;
            string us = Usuario.id_us;
            string sr = txtSerie.Text;
            string om = cmbMedico.SelectedIndex == -1 ? "" : cmbMedico.SelectedValue.ToString();
            string it = cmbInstitucion.SelectedIndex == -1 ? "" : cmbInstitucion.SelectedValue.ToString();
            string fp = cmbMVen.SelectedIndex == -1 ? "" : cmbMVen.SelectedValue.ToString();
            string dv = cmbTDoc.SelectedIndex == -1 ? "" : cmbTDoc.SelectedValue.ToString();

            string sql = "Exec AddTicket '" + nh + "','" + nd + "','" + fe + "','" + es + "','" + ip + "','" + us + "','" + sr + "','" + om + "','" + it + "','" + fp + "','" + dv + "'";
            Conexion.ExecuteNonQuery(sql);
            this.noc = "CONTINUADOR";
            this.adv();
        }

        public void bdv(string scon, string sapa, string sama, string snom, string stik, string sser)
        {
            //.frmbuscat.grdbtick.recordsource = ''
            if (sapa.Length == 0 && sama.Length == 0 && snom.Length == 0 && stik.Length == 0 && scon.Length == 0 && sser.Length == 0)
            {
                sapa = "AB";
                sama = snom = "A";
            }

            if (sapa.Length == 0 && sama.Length == 0 && snom.Length >= 1)
            {
                sapa = sama = "A";
            }

            if (sapa.Length == 0 && snom.Length == 0 && sama.Length >= 1)
            {
                sapa = snom = "A";
            }

            if (sama.Length == 0 && snom.Length == 0 && sapa.Length >= 1)
            {
                sama = snom = "A";
            }

            int lap = sapa.Length;
            int lam = sama.Length;
            int lnm = snom.Length;
            int ltk = stik.Length;
            int lsr = sser.Length;
            int lcn = scon.Length;

            string sql = "Select Top 50 Descripcion As Consultorio,P.Ape_Paterno+' '+P.Ape_Materno+' '+P.Nombre As Paciente," +
                "T.Serie+'-'+T.Nro_Ticket As Ticket,T.Id_Paciente,T.Fecha_Emision,T.Nro_Historia,T.Anulado " +
                "From Tickets T Inner Join Pacientes P On T.Id_Paciente=P.Id_paciente Inner Join Consultorios C On T.Id_Consultorio=" +
                "C.Id_Consultorio Where ";

            if (lap > 0)
            {
                sql += "P.Ape_Paterno Like '" + sapa + "%' ";
            }

            if (lam > 0)
            {
                if (sql.Contains("Like"))
                {
                    sql += "And P.Ape_Materno Like '" + sama + "%' ";
                }
                else
                {
                    sql += "P.Ape_Materno Like '" + sama + "%' ";
                }
            }
            if (lnm > 0)
            {
                if (sql.Contains("Like"))
                {
                    sql += "And P.Nombre Like '" + snom + "%' ";
                }
                else
                {
                    sql += "P.Nombre Like '" + snom + "%' ";
                }
            }
            if (lsr > 0)
            {
                if (sql.Contains("Like"))
                {
                    sql += "And T.DVenta Like '' And T.Serie Like '" + sser + "' ";
                }
                else
                {
                    sql += "T.DVenta Like '' And T.Serie Like '" + sser + "' ";
                }
            }
            if (ltk > 0)
            {
                if (sql.Contains("Like"))
                {
                    sql += "And T.Nro_Ticket Like '" + stik + "%' ";
                }
                else
                {
                    sql += "T.Nro_Ticket Like '" + stik + "%' ";
                }
            }
            if (lcn > 0)
            {
                if (sql.Contains("Like"))
                {
                    sql += "And C.Id_Consultorio='" + scon + "' ";
                }
                else
                {
                    sql += "C.Id_Consultorio='" + scon + "' ";
                }
            }
            sql += "And Left(T.Nro_Historia,3)='" + Operativo.id_oper + "' Order By 2";

            List<Dictionary<string, string>> bust = General.GetDictionaryList(sql);
            //.frmbuscat.grdbtick.recordsource = 'Bust'
        }

        public void bpa()
        {
            /*
            WITH thisformset.frmbuscar
               .grdbuscar.recordsource = ''
                lpaciente(ALLTRIM(.txtape_pat.value), ALLTRIM(.txtape_mat.value), ALLTRIM(.txtnom.value), ALLTRIM(.txtdni.value), '', '', 'BPac', 1, thisformset.odb)
                .grdbuscar.recordsource = 'BPac'
                IF thisformset.odb = 0
                   .grdbuscar.column1.controlsource = "Allt(Ape_Paterno)+' '+Allt(Ape_Materno)+' '+Allt(Nombre)"
                   .grdbuscar.column2.controlsource = "Id_Paciente"
                   .grdbuscar.column3.controlsource = "DNI"
                ELSE
                   .grdbuscar.column1.controlsource = "Allt(Ape_Pat)+' '+Allt(Ape_Mat)+' '+Allt(Nombres)"
                   .grdbuscar.column2.controlsource = "Ubigeo"
                   .grdbuscar.column3.controlsource = "DNI"
                ENDIF
                .cmdaceptar.enabled = .T.
                .refresh
             ENDWITH
             */
        }

        public void cdv(string lr)
        {
            string nr = lr;
            this.tmpd.Clear();

            string sql = "";

            if (nr != "0")
            {
                sql = "Select * From Tickets Where Nro_Historia='" + nr + "'";
            }
            else
            {
                string us = Usuario.id_us;
                sql = "Select * From Tickets Where Fecha_Emision In(Select Max(Fecha_Emision) From Tickets Where " +
                    "Digitador='" + us + "' And Fecha_Emision >= Convert(Varchar(10), GetDate(), 103)) And Digitador = '" + us + "' And Fecha_Emision>=Convert(Varchar(10),GetDate(),103)";

            }

            List<Dictionary<string, string>> tick = General.GetDictionaryList(sql);

            if (tick.Count > 0)
            {
                int i = tick.Count - 1;
                txtFechaEmision.Text = tick[i]["Fecha_Emision"];
                cmbMVen.SelectedValue = tick[i]["Forpago"];
                cmbTDoc.SelectedValue = tick[i]["DVenta"];
                txtSerie.Text = tick[i]["Serie"];
                txtNroTicket.Text = tick[i]["Nro_Ticket"];
                txtDigitador.Text = General.TradUser(tick[i]["Digitador"]);
                txtIdPaciente.Text = tick[i]["Id_Paciente"];
                cmbEspecialidad.SelectedValue = tick[i]["Id_Consultorio"];
                cmbInstitucion.SelectedValue = tick[i]["Id_Inst"];
                cmbMedico.SelectedValue = tick[i]["CMP"];
                txtAutoriza.Text = "";
                if (tick[i]["Descuento"].Substring(0, 1) == "D")
                {
                    string ads = tick[i]["Descuento"].Substring(29, 9);
                    string sql2 = "Select LTrim(RTrim(Ape_Paterno))+' '+LTrim(RTrim(Ape_Materno))+' '+LTrim(RTrim(Nombres))Personal," +
                        "Id_Personal From Personal Where Id_Personal='" + ads + "' Union All " +
                        "Select Nom_Raz_Soc Personal,TInst + Id_Inst Id_Personal From Institucion Where TInst + Id_Inst = '" + ads + "'";
                    Dictionary<string, string> fmd = General.GetDictionary(sql2);
                    txtAutoriza.Text = fmd["Personal"] + " (S/. " + tick[i]["Descuento"].Substring(38, 8) + ")";
                }

                nr = tick[i]["Nro_historia"];
                //.grddetalle.column1.cmbproducto.rowsource = ''

                string ne = tick[i]["Id_Consultorio"];
                string sql3 = "Select * From Productos Where Left(Id_Producto,6)='" + ne + "'";
                this.productos = General.GetDictionaryList(sql3);
                //.grddetalle.column1.cmbproducto.rowsource = 'Allt(Productos.Descripcion),Id_Producto'

                string sql4 = "Select * From Detalles Where Nro_Historia='" + nr + "'";
                List<Dictionary<string, string>> cdet = General.GetDictionaryList(sql4);

                foreach (Dictionary<string, string> idet in cdet)
                {
                    Dictionary<string, string> item = new Dictionary<string, string>();
                    item["Nrv"] = idet["Nro_Historia"];
                    Dictionary<string, string> producto = this.productos.Find(x => x["Id_Producto"] == idet["Id_Producto"]);
                    item["Npro"] = producto["Descripcion"];
                    item["Tp"] = producto["Tipo"];
                    item["Cant"] = idet["Cantidad"];
                    item["Cost"] = idet["Monto"];

                    this.tmpd.Add(item);
                }

                string ic = tick[i]["Id_Bus"];

                if (ic.Length > 0)
                {
                    this.nrc = Conexion.ExecuteScalar<string>("Select Bus From Buses Where Id_Bus='" + ic + "'");
                }

                this.nrv = tick[i]["Nro_historia"];
                this.cpa(1, "");
                this.ctv();

                /*
                 * SELECT tmpd
       GOTO TOP
                 */
            }
            else
            {
                General.setAll<TextBox, string>(this, "Text", "");
            }
        }

        public void cpa(int spro, string ncur)
        {
            if (ncur.Length == 0)
            {
                string sql = "Select * From Pacientes Where Id_Paciente='" + (txtIdPaciente.Text) + "'";
                this.bpac = General.GetDictionary(sql);
            }

            if (spro == 0)
            {
                this.hab(0);
                btnBuscar.Enabled = true;
                txtFechaEmision.Text = DateTime.Today.ToShortDateString();
                cmbEspecialidad.Focus();
            }

            this.nhp = bpac["Nro_historia"].Length == 0 ? 0 : int.Parse(bpac["Nro_historia"]);

            txtNHP.Text = bpac["Nro_historia"];
            txtNombre.Text = bpac["Nombre"];
            txtApePaterno.Text = bpac["Ape_paterno"];
            txtApeMaterno.Text = bpac["Ape_materno"];
            txtDNI.Text = bpac["Dni"];
            txtODoc.Text = bpac["Odoc"];
            txtFechaNac.Text = bpac["Fecha_nac"].Length == 0 ? General.emptyDate : bpac["Fecha_nac"];
            txtEdad.Text = bpac["Fecha_nac"].Length == 0 ? bpac["Edad"] : General.getYearUntilNow(txtFechaNac.Text).ToString();
            txtSexo.Text = bpac["Sexo"];
            txtTelefono.Text = bpac["Telefono"];
            txtDireccion.Text = bpac["Direccion"];
            txtAsegurado.Text = bpac["Asegurado"];
            cmbDepartamento.SelectedValue = bpac["Id_distrito"].Substring(0, 2);
            //cmbDepartamento_SelectionChangedCommited(cmbDepartamento, new EventArgs());
            cmbProvincia.SelectedValue = bpac["Id_distrito"].Substring(0, 4);
            //cmbProvincia_SelectionChangedCommited(cmbProvincia, new EventArgs());
            cmbDistrito.SelectedValue = bpac["Id_distrito"];
            txtEmail.Text = bpac["E_mail"];
        }

        public void ctv()
        {
            txtTotal.Text = "0.00";

            for (int i = 0; i < this.tmpd.Count; i++)
            {
                if (this.tmpd[i]["Nrv"] == this.nrv)
                {
                    if (this.cesp["Descripcion"] == "FARMACIA")
                    {
                        this.tmpd[i]["Subt"] = this.tmpd[i]["Cost"];
                    }
                    else
                    {
                        this.tmpd[i]["Subt"] = (decimal.Parse(this.tmpd[i]["Cant"]) * decimal.Parse(this.tmpd[i]["Cost"])).ToString();
                    }

                    txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(this.tmpd[i]["Subt"])).ToString();
                    txtNeto.Text = this.dventa["Descripcion"] == "FACTURA" ? Math.Round(decimal.Parse(txtTotal.Text) / decimal.Parse(this.igv["Descripcion"]), 2).ToString() : "0.00";
                    txtIGV.Text = this.dventa["Descripcion"] == "FACTURA" ? (Decimal.Parse(txtTotal.Text) - decimal.Parse(txtNeto.Text)).ToString() : "0.00";
                    txtSon.Text = General.NumeroTexto(txtTotal.Text);
                }
            }
        }

        public void ddi()
        {
            if (txtDNI.Text.Length > 0)
            {
                string ldni = txtDNI.Text;
                string sql = "Select Nombre,Ape_Paterno,Ape_Materno,DNI From Pacientes Where DNI='" + ldni + "'";

                Dictionary<string, string> doc = General.GetDictionary(sql);

                if (doc["DNI"] == ldni)
                {
                    string dupl = doc["Nombre"] + " " + doc["Ape_Paterno"] + " " + doc["Ape_Materno"];
                    MessageBox.Show("DNI pertenece a " + dupl + " verifique y corrija los datos ...", "Advertencia");
                    txtDNI.Focus();
                }
            }

            //ACA FALTA ALGO; REVISAR
        }

        public void deh()
        {
            this.odb = 0;
            General.setAll<TextBox, bool>(this, "Enabled", false);
            General.setAll<ComboBox, bool>(this, "Enabled", false);
            General.setAll<Button, bool>(this, "Enabled", true);
            txtEmail.Enabled = false;

            chkInst.Enabled = btnInst.Enabled = btnAgregar.Enabled = btnQuitar.Enabled = false;

            grdDetalle.ReadOnly = true;

            if (txtIdPaciente.Text.Length == 0)
            {
                btnDuplica.Enabled = btnImprimir.Enabled = false;
            }
        }

        public void gdv()
        {
            this.les();

            string fi = txtFechaEmision.Text == General.emptyDate ? "" : txtFechaEmision.Text;
            string ff = txtFechaEmision.Text == General.emptyDate ? "" : DateTime.Parse(txtFechaEmision.Text).AddDays(1).ToShortDateString();
            string iu = Usuario.id_us;
            string io = Operativo.id_oper;
            string sr = txtSerie.Text;
            string dv = cmbTDoc.SelectedIndex == -1 ? "" : cmbTDoc.SelectedValue.ToString();

            string sql = "Exec GenDocVen '" + fi + "','" + ff + "','" + iu + "','" + io + "','" + sr + "','" + dv + "',''";
            Dictionary<string, string> talon = General.GetDictionary(sql);

            int n = (talon != null ? (int.Parse(talon["NCon"]) == 0 ? int.Parse(talon["NInicial"]) : int.Parse(talon["NCon"]) + 1) : -1);

            if (n == -1)
            {
                General.msg("No tiene rango de documentos de venta", 1, "Advertencia");
                this.Close();
            }
            else
            {
                this.vdv(sr, n.ToString(), dv);
                txtNroTicket.Text = n.ToString();
            }
        }

        public void ghp()
        {
            int c = Conexion.ExecuteScalar<int>("Select Count(Descripcion)C From TablaTipo Where Id_Tabla='28' And Id_Tipo='NH'");

            if (c > 0)
            {
                if (!Operativo.mod_oper.Contains("HOSPITAL"))
                {
                    if (MessageBox.Show("Desea generar historia clinica del paciente ... ?", "Aviso al usuario", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        c = 0;
                    }
                }

                if (c > 0)
                {
                    foreach (Dictionary<string, string> item in this.tmpd)
                    {
                        /*
                         DIMENSION a1(1)
                         SELECT tipo FROM Productos WHERE id_producto=tmpd.ipr INTO ARRAY a1
                         IF a1(1)='C'
                            tp = 'C'
                            EXIT
                         ELSE
                            tp = '*'
                         ENDIF
                         */
                    }

                    string ip = txtIdPaciente.Text;
                    string uo = Operativo.uni_org;
                    string ii = "01";
                    string nhp = txtNHP.Text;

                    string sql = "";
                    if (nhp.Length == 0)
                    {
                        sql = "Exec GenHistPac '" + ip + "'";
                    }
                    else
                    {
                        sql = "Update Pacientes Set Nro_Historia='" + nhp + "' Where Id_Paciente='" + ip + "' Select Cast(Nro_Historia As Int)nhp From Pacientes Where Id_Paciente='" + ip + "'";
                    }

                    Dictionary<string, string> res = General.GetDictionary(sql);

                    txtNHP.Text = int.Parse(res["NHP"]) > 0 ? res["NHP"] : txtNHP.Text;
                    this.nhp = int.Parse(res["NHP"]);
                }
            }
        }

        public void hab(int xmd)
        {
            switch (xmd)
            {
                case 0:
                    General.setAll<TextBox, string>(this, "Text", "");
                    General.setAll<ComboBox, int>(this, "SelectedIndex", -1);
                    General.setAll<TextBox, bool>(this, "Enabled", true);
                    General.setAll<ComboBox, bool>(this, "Enabled", true);
                    General.setAll<Button, bool>(this, "Enabled", false);

                    cmbInstitucion.Enabled = false;
                    txtNHP.Enabled = txtEmail.Enabled = true;
                    txtFechaEmision.Enabled = txtIdPaciente.Enabled = txtNroTicket.Enabled = txtNeto.Enabled = txtIGV.Enabled = txtTotal.Enabled = false;

                    this.uvt();

                    txtFechaNac.Text = General.emptyDate;
                    txtNeto.Text = txtIGV.Text = txtTotal.Text = "0.00";

                    if (General.rdvo(Usuario.id_us, "") == null)
                    {
                        this.Close();
                        this.DialogResult = DialogResult.Cancel;
                    }

                    cmbTDoc.Text = this.rdvopen["DVenta"];
                    txtSerie.Text = this.rdvopen["Serie"];
                    txtDigitador.Text = Usuario.usuario;
                    txtEmail.Text = "";

                    break;
                case 1:

                    this.hab(0);
                    btnNuevo.Enabled = true;
                    btnNuevo.Text = "&Grabar";
                    txtFechaEmision.Text = DateTime.Today.ToShortDateString();

                    cmbDepartamento.SelectedValue = Operativo.id_distrito.Substring(0, 2);
                    cmbDepartamento_SelectionChangeCommitted(cmbDepartamento, new EventArgs());
                    cmbProvincia.SelectedValue = Operativo.id_distrito.Substring(0, 4);
                    cmbProvincia_SelectionChangeCommitted(cmbProvincia, new EventArgs());
                    cmbDistrito.SelectedValue = Operativo.id_distrito;

                    this.gdv();

                    this.tmpd.Clear();

                    this.odb = 0;

                    break;
            }
        }

        public bool hom()
        {
            string nom = txtNombre.Text;
            string apa = txtApePaterno.Text;
            string ama = txtApeMaterno.Text;
            string dn = txtDNI.Text;

            if (nom.Length > 0 && apa.Length > 0 && ama.Length > 0)
            {
                string sql = "Select Nombre,Ape_Paterno,Ape_Materno,DNI From Pacientes Where Nombre='" + nom + "' And Ape_Paterno='" + apa + "' And Ape_Materno='" + ama + "'";
                Dictionary<string, string> homon = General.GetDictionary(sql);

                if ((homon["Nombre"] + homon["Ape_Paterno"] + homon["Ape_Materno"]) == (nom + apa + ama))
                {
                    string homo = homon["Nombre"] + " " + homon["Ape_Paterno"] + " " + homon["Ape_Materno"] + " con DNI " + homon["DNI"];

                    if (homon["DNI"] == dn && dn.Length > 0)
                    {
                        MessageBox.Show("Paciente " + homo + " ya esta registrado ... solo realice la busqueda ...", "Advertencia");
                        txtNombre.Focus();
                        return false;
                    }
                    else
                    {
                        homo = nom + " " + apa + " " + ama;

                        if (MessageBox.Show("Paciente " + homo + " ya esta registrado ... desea ingresarlo como HOMONIMO?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            txtNombre.Text += " (H)";
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return true;
                }
            }

            return true;
        }

        public void les()
        {
            //LLenar con DATASET ConsultoriosDS
        }

        public void msg(string op)
        {
            switch (op)
            {
                case "P":
                    //.frmmessage.txtmessage.value = ALLTRIM(.frmhistoria.txtnombre.value)+' '+ALLTRIM(.frmhistoria.txtape_paterno.value)+' '+ALLTRIM(.frmhistoria.txtape_materno.value)

                    break;
                case "D":
                    //.frmmessage.txtmessage.value = ALLTRIM(.frmhistoria.txtdireccion.value)
                    break;
                case "E":
                    //.frmmessage.txtmessage.value = ALLTRIM(.frmhistoria.txtemail.value)
                    break;
            }
            //.frmmessage.txtmessage.selstart = LEN(.frmmessage.txtmessage.value)
        }

        public void tsg()
        {
            if (this.hi.Length > 0)
            {
                string nr = this.nrv;
                string df = General.getDaysUntilNow(this.hi).ToString();
                string sql = "Update Tickets Set tsg='" + df + "' Where Nro_Historia='" + nr + "'";
                Conexion.ExecuteNonQuery(sql);
                MessageBox.Show("Operación generada con éxito");
            }
        }

        public void uvt()
        {
            if (chkInst.Checked)
            {
                string xf = DateTime.Today.ToShortDateString();
                string us = Usuario.id_us;
                string sql = "Select Id_Inst From Tickets Where Nro_Historia In(Select Max(Nro_Historia) From Tickets Where Fecha_Emision" + ">='" + xf + "' And Digitador='" + us + "' And Id_Consultorio In(Select Left(Id_producto,6) From ImpFicha Where Estado='1'))";
                Dictionary<string, string> xemp = General.GetDictionary(sql);
                if (xemp != null)
                {
                    cmbInstitucion.SelectedValue = xemp["Id_Inst"];
                }
            }
        }

        public void vdp()
        {
            string ip = txtIdPaciente.Text;
            string sql = "Select * From Pacientes Where Id_Paciente='" + ip + "'";
            Dictionary<string, string> pacient = General.GetDictionary(sql);

            sql = "Update Pacientes Set ";
            sql += (txtNombre.Text != pacient["Nombre"] ? "Nombre='" + txtNombre.Text + "'" : "");
            sql += (sql.Contains("=") ? "," : "");
            sql += (txtApePaterno.Text != pacient["Ape_paterno"] ? "Ape_Paterno='" + txtApePaterno.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtApeMaterno.Text != pacient["Ape_materno"] ? "Ape_Materno='" + txtApeMaterno.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtDNI.Text != pacient["Dni"] ? "DNI='" + txtDNI.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtODoc.Text != pacient["Odoc"] ? "ODoc='" + txtODoc.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtFechaNac.Text != pacient["Fecha_nac"] && txtFechaNac.Text.Length > 0 ? "Fecha_Nac='" + txtFechaNac.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtEdad.Text != pacient["Edad"] ? "Edad='" + txtEdad.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtSexo.Text != pacient["Sexo"] ? "Sexo='" + txtSexo.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtTelefono.Text != pacient["Telefono"] ? "Telefono='" + txtTelefono.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtDireccion.Text != pacient["Direccion"] ? "Direccion='" + txtDireccion.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtAsegurado.Text != pacient["Asegurado"] ? "Asegurado='" + txtAsegurado.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (cmbDistrito.SelectedValue.ToString() != pacient["Id_distrito"] ? "Id_Distrito='" + cmbDistrito.SelectedValue.ToString() + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtEmail.Text != pacient["E_mail"] ? "E_Mail='" + txtEmail.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? sql.Substring(0, sql.Length - 1) : sql) + (sql.Contains("=") ? " Where Id_Paciente='" + ip + "'" : "");

            if (sql.Contains("Where"))
            {
                if (MessageBox.Show("Los datos del paciente han cambiado, desea guardarlos ... ?", "Aviso al usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Conexion.ExecuteNonQuery(sql);
                    MessageBox.Show("Operación completada con éxito");
                }
            }
        }

        public bool vdv(string lsr, string lnd, string ldv)
        {
            string sr = lsr;
            string nd = lnd;
            string dv = ldv;

            string sql = "Select * From Tickets Where DVenta='" + dv + "' And Serie='" + sr + "' And Nro_Ticket='" + nd + "'";
            Dictionary<string, string> st = General.GetDictionary(sql);

            if (st != null)
            {
                MessageBox.Show("El recibo N° " + st["Serie"] + "-" + st["Nro_Ticket"] + " ya fue emitido por " + General.TradUser(st["Digitador"]) + " con fecha" + "\t" + st["Fecha_Emision"] + ", comuniquese con el administrador del" + "\t" + " sistema ... urgente !!!", "Advertencia");
                txtNroTicket.Text = "";
                return false;
            }

            return true;
        }

        public bool vrv()
        {
            if (txtNroTicket.Text.Length == 0 || cmbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos para registrar la venta ...", "Advertencia");
                return false;
            }

            return true;
        }

        private void frmSHClinica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institucionesDS.Institucion' table. You can move, or remove it, as needed.
            this.institucionTableAdapter.Fill(this.institucionesDS.Institucion);
            // TODO: This line of code loads data into the 'departamentosDS.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.departamentosDS.Departamentos);
            cmbDepartamento.SelectedIndex = -1;

            //General.ttMensaje.InitialDelay = 0;
            //General.ttMensaje.IsBalloon = false;
            //FormateaGrids();
            //btnBuscarT.Enabled = true;
            this.rdvopen = General.rdvo(Usuario.id_us, "");

            if (this.rdvopen != null)
            {
                return;
            }

            string sql = "Select Ape_Paterno+' '+Ape_Materno+', '+Nombres Medico,Id_Personal From Personal Where TNCol<>'' Union Select Descripcion,Id_Tipo From TablaTipo Where Id_Tabla In (Select Id_Tipo From TablaTipo Where Descripcion='VAR_EXTRAS' And Id_Tabla='0') Order By 1";
            this.cper = General.GetDictionaryList(sql);

            string sql2 = "Select Nom_Raz_Soc,TInst+Id_Inst CInst From Institucion Where Estado='1' And TInst In ('T','M') Order By 1";
            this.cins = General.GetDictionaryList(sql2);

            grdDetalle.Rows.Clear();
            txtDigitador.Text = Usuario.usuario;
            txtSerie.Text = this.rdvopen["Serie"];

            this.les();

            /*
            .frmbuscar.hide
            .frmbuscat.hide
            .frmbuscai.hide
            WITH .frmmessage
               .left = 1
               .width = frmmain.width-3
               .top = frmmain.height-frmmain.stbar.height-.height-1
               .txtmessage.width = .width-8
            ENDWITH 
            */

            /*
            if ( bTieneDocVenta == true )
			{
				General.LlenarRegistroVenta(Usuario.id_us, "");
				btnNuevo.Enabled = true;
				btnBuscar.Enabled = true;
			}
			else
			{

			}

			General.LUbigeo("", "DEPARTAMENTO", cmbDepartamento);
			General.LUbigeo("", "PROVINCIA", cmbProvincia);
			General.LUbigeo("", "DISTRITO", cmbDistrito);
			txtDigitador.Text = Usuario.usuario;

			General.LlenaComboBox(cmbEspecialista, "MEDICO");
			General.LlenaComboBox(cmbInstitucion, "INSTITUCION");
			General.LlenaComboBox(cmbMVen, "FORMA_PAGO");
			General.LlenaComboBox(cmbTDoc, "DOC_VENTA");
			General.LlenaComboBox(cmbIGV, "IGV");

			//llena combo especialidad
			string vSQL = "SELECT DISTINCT Descripcion,Id_Consultorio AS IdUbigeo " +
						  "FROM Consultorios " +
						  "WHERE Id_Consultorio LIKE '" + Operativo.id_oper + "%' " +
						  "AND Estado= '1' " +
						  "Order By 1";
			General.LlenaComboBox(cmbEspecialidad, "SQL", vSQL);
			Habilita(0);
			btnAgregar.Enabled = false;
			btnQuitar.Enabled = false;
            */
        }

        private void FormateaGrids()
        {
            //iGDropDownList cmb = new iGDropDownList();
            fGrid.RowHeader.Visible = false;
            fGrid.DefaultRow.Height = 17;
            //iGrid.Cols.Count = 5;
            //producto
            fGrid.Cols[0].Text = "Descripcion del Producto o Servicio";
            fGrid.Cols[0].Width = 425;
            fGrid.Cols[0].CellStyle.ImageAlign = iGContentAlignment.MiddleLeft;
            //iGrid.Cols[0].CellStyle.DropDownControl = iGDropDownList; //agrega el combobox
            fGrid.Cols[0].CellStyle.TypeFlags = iGCellTypeFlags.NoTextEdit;
            fGrid.Cols[0].CellStyle.ValueType = typeof(string);

            //cantidad
            fGrid.Cols[1].Text = "Cant.";
            fGrid.Cols[1].Width = 40;
            fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[1].CellStyle.ReadOnly = iGBool.False;
            //precio
            fGrid.Cols[2].Text = "Precio";
            fGrid.Cols[2].Width = 50;
            fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[2].CellStyle.FormatString = "{0:#,#}";
            fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;
            //sub total
            fGrid.Cols[3].Text = "Sub Total";
            fGrid.Cols[3].Width = 60;
            fGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            fGrid.Cols[3].CellStyle.FormatString = "{0:#,#}";
            fGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;
            //id
            fGrid.Cols[4].Text = "ID";
            fGrid.Cols[4].Width = 1;
            fGrid.Cols[4].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
            fGrid.Cols[4].CellStyle.ReadOnly = iGBool.True;
            // Popup menu de la grid
            //iGrid.ContextMenuStrip = new ContextMenuStrip();
            //iGrid.ContextMenuStrip.Items.Add("Exportar");
            //iGrid.ContextMenuStrip.Items.Add("Copiar");

        }

        private void CargaProductos(string sCategoria, string idProducto = "")
        {
            //iGDropDownList cmb = new iGDropDownList();
            //string sQuery = "SELECT CAST(SubString(Id_Producto,4,5) AS INT) AS Id,Descripcion " +
            string sQuery = "SELECT Id_Producto AS Id, Descripcion " +
                            "FROM Productos " +
                            "WHERE 1 = 1 " +
                            "AND Estado = '1' " +
                            "AND LEFT(Id_Producto,6) = '" + sCategoria.Trim() + "' ";
            if (idProducto != "")
                sQuery = sQuery + "AND Id_Producto = '" + idProducto + "' ";
            else
                sQuery = sQuery + "ORDER BY 2";

            Conexion.CMD.CommandText = sQuery;

            iGDDL.Items.Clear();
            iGDDL.FillWithData(Conexion.CMD, "Id", "Descripcion");

            //cmb.Items.Clear();
            //cmb.FillWithData(Conexion.CMD, "Id", "Descripcion");


            if (iGDDL.Items.Count == 1)
                iGDDL.Items[0].Selectable = true;

            //return cmb;
        }

        private string DevuelvePrecioProducto(string idProduct)
        {
            string sPrecio = "";

            string sQuery = "SELECT monto " +
                            "FROM Productos " +
                            "WHERE 1 = 1 " +
                            "AND Estado = '1' " +
                            "AND Id_Producto = '" + idProduct.Trim() + "' ";
            sPrecio = General.TomaValor(sQuery);
            sPrecio = sPrecio.Trim();
            return sPrecio;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool result = false;
            object sender = new object();
            EventArgs e = new EventArgs();

            if (keyData == Keys.F3)
            {
                result = true;
            }
            else if (keyData == Keys.F4)
            {
                result = true;
            }
            else if (keyData == Keys.F5)
            {
                result = true;
            }
            else if (keyData == Keys.F6)
            {
                result = true;
            }
            else if (keyData == Keys.Insert)
            {
                btnNuevo_Click(sender, e);
                result = true;
            }
            else
                result = base.ProcessCmdKey(ref msg, keyData);

            return result;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string sIDPaciente = "";

            if (btnNuevo.Text == "&Nuevo Paciente")
            {
                btnBuscar.Enabled = false;
                General.ODB = 1;  //1: Nuevo Paciente, 0: Paciente Existente
                int iCant = 0;

                string vSQL = "SELECT Count(Name) AS C FROM master.dbo.sysdatabases WHERE Name = 'DNI'";
                iCant = int.Parse(General.TomaValor(vSQL));
                if (iCant > 0)
                    if (MessageBox.Show("Desea realizar busqueda en base de datos general...?", "Busqueda Pacientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        Habilita(1);
                    else
                    {
                        frmBuscar fr = new frmBuscar();
                        fr.ShowDialog();

                        if (fr.DialogResult != DialogResult.OK)
                            return;
                        else
                            sIDPaciente = fr.lblIdPaciente.Text;

                        CargaDatosPaciente(General.ODB, sIDPaciente);
                        btnBuscar.Enabled = false;
                        btnDuplica.Enabled = false;
                        btnBuscat.Enabled = false;
                        txtDireccion.Focus();
                    }
                else
                    Habilita(1);
            }
            else if (btnNuevo.Text == "&Grabar Venta")
            {
                if (int.Parse(txtTotal.Text) == 0)
                {
                    if (MessageBox.Show("No ha agregado productos, desea hacerlo...?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        btnNuevo.Text = "&Nuevo Paciente";
                        btnBuscar.Enabled = true;
                        btnBuscat.Enabled = true;
                        ValidaDatosTicket("");
                        BloqueaControles(this, "D");
                    }
                    else
                        txtDNI.Focus();
                }
                else
                {
                    if (MessageBox.Show("Desea guardar los cambios...?", "Mensaje al Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                    }

                }
            }
        }

        private void frmSHClinica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }

            if (e.KeyCode == Keys.Insert && btnNuevo.Enabled && btnNuevo.Text == "&Nuevo Pac")
            {
                btnNuevo_Click(btnNuevo, new EventArgs());
            }

            if (e.KeyCode == Keys.F3 && btnBuscar.Enabled && btnBuscar.Text == "&Busca Pac")
            {
                btnBuscar_Click(btnBuscar, new EventArgs());
            }

            if (e.KeyCode == Keys.F4 && btnBuscat.Enabled)
            {
                btnBuscat_Click(btnBuscat, new EventArgs());
            }

            if (e.KeyCode == Keys.F5 && this.nrv != "")
            {
                this.cdv(this.nrv);
            }

            if (e.KeyCode == Keys.F6)
            {
                if (btnBuscar.Text == "&Grabar")
                {
                    btnBuscar_Click(btnBuscar, new EventArgs());
                }

                if (btnNuevo.Text == "&Grabar")
                {
                    btnNuevo_Click(btnNuevo, new EventArgs());
                }
            }

            if (e.KeyCode == Keys.F6 && btnBuscat.Enabled)
            {
                cmbEspecialidad.Focus();
            }

            this.lastKey = e.KeyCode;
        }

        private void ValidaTextosTicket()
        {
            if (txtNombre.Text.Trim() == "" || txtNombre.Text.Trim().Length == 0)
            {

            }
        }

        private void Habilita(int iOpcion)
        {
            switch (iOpcion)
            {
                case 0:
                    LimpiaControles(this);
                    UbicaItemCombo(cmbTDoc, Talon.dventa);
                    UbicaItemCombo(cmbMVen, "");
                    UbicaItemCombo(cmbInstitucion, TieneInstitucion());
                    txtSerie.Text = Talon.serie;
                    txtDigitador.Text = Usuario.usuario;
                    txtDNI.Focus();
                    break;
                case 1:
                    Habilita(0);
                    btnNuevo.Text = "&Grabar Venta";
                    txtFechaEmision.Text = General.FechaServidor();
                    UbicaItemCombo(cmbDistrito, Operativo.id_distrito);
                    UbicaItemCombo(cmbProvincia, Operativo.id_distrito.Substring(0, 4));
                    UbicaItemCombo(cmbDepartamento, Operativo.id_distrito.Substring(0, 2));
                    ValidaRangosDocsVenta();
                    txtDNI.Focus();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        }

        private void LimpiaControles(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
                else if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Clear();

                if (c.HasChildren)
                    LimpiaControles(c);
            }
            fGrid.Rows.Clear();
            FormateaGrids();

        }

        private void UbicaItemCombo(ComboBox cmb, string sValor)
        {
            if (sValor == null)
                sValor = "";

            foreach (var item in cmb.Items)
                if (((Ubigeo)item).IdUbigeo == sValor)
                {
                    cmb.SelectedItem = item;
                    break;
                }
        }

        private string TieneInstitucion()
        {
            string sRes = "";
            string sQuery = "SELECT ISNULL(Id_Inst ,'') AS Id_Inst FROM Tickets " +
                            "WHERE Nro_Historia In " +
                            "(SELECT Max(Nro_Historia) " +
                            " FROM Tickets " +
                            " WHERE Fecha_Emision >= CONVERT(Datetime, '" + General.FechaServidor("YYYY-MM-DD") + "', 120) " +
                            " And Digitador = '" + Usuario.id_us + "' " +
                            " And Id_Consultorio In " +
                            " (SELECT Left(Id_producto, 6) " +
                            "  FROM ImpFicha WHERE Estado = '1'))";
            sRes = General.TomaValor(sQuery);
            return sRes;
        }

        private bool ValidaRangosDocsVenta()
        {
            string F1 = General.FechaServidor();
            string F2 = Convert.ToDateTime(F1).AddDays(1).ToString("dd/MM/yyyy");
            string sRes = "";
            string sQuery = "";
            bool Error = false;

            sQuery = "EXEC GenDocVen '" + F1 + "','" + F2 + "','" + Usuario.id_us + "','" + Operativo.id_oper + "','" + Talon.serie + "','" + Talon.dventa + "',''";
            using (SqlCommand cmd = new SqlCommand(sQuery, Conexion.CNN))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        General.LlenaTalon(dr);
                        sRes = int.Parse(Talon.ncon) == 0 ? Talon.ninicial : Convert.ToString(int.Parse(Talon.ncon) + 1);
                    }
                    dr.Close();
                }
            }

            if ((sRes == null || sRes == String.Empty || sRes == ""))
            {
                MessageBox.Show("No tiene rango de documentos de venta ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                Error = true;
            }
            else
            {
                Error = ValidaUsoTicket(Talon.serie, Talon.ninicial, Talon.dventa);
                if (Error == false)
                    txtNroTicket.Text = Talon.ninicial;
            }
            return Error;
        }

        private bool ValidaUsoTicket(string sSerie, string sInicial, string sDventa)
        {
            int iCant = 0;
            string sQuery = "";
            bool Error = false;

            sQuery = "SELECT COUNT(*) AS C FROM Tickets " +
                     "WHERE Serie = '" + sSerie + "' " +
                     "AND DVenta = '" + sDventa + "'" +
                     "AND Nro_Ticket = '" + sInicial + "'";
            iCant = int.Parse(General.TomaValor(sQuery));

            sQuery = "SELECT Nro_Historia,Nro_Ticket,CONVERT(VARCHAR(10),Fecha_Emision,103) AS Fecha," +
                     "Id_Consultorio,Id_Paciente,Digitador,Anulado,ForPago,Descuento," +
                     "Serie,CMP,Id_Inst,Moneda,Convenio,DVenta,Id_Bus,tsg " +
                     "FROM Tickets " +
                     "WHERE Serie = '" + sSerie + "' " +
                     "AND DVenta = '" + sDventa + "'" +
                     "AND Nro_Ticket = '" + sInicial + "'";
            using (SqlCommand cmd = new SqlCommand(sQuery, Conexion.CNN))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dr.Read();
                        if (iCant > 0)
                        {
                            MessageBox.Show("El recibo N° " + dr.GetValue(9).ToString() + "-" + dr.GetValue(1).ToString() + " ya fue emitido por " + General.TradUser(dr.GetValue(5).ToString()) + (char)13 + " en fecha del " + dr.GetValue(2).ToString() + ", comuniquese con el administrador del" + (char)13 + "sistema de manera inmediata. Es de urgencia !!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            txtNroTicket.Text = "";
                            Error = true;
                        }
                    }
                    dr.Close();
                }
            }
            return Error;
        }

        private void CargaDatosPaciente(int iTipo, string sPaciente, int iEstado = 0)
        {
            string sSQL = "";

            txtDigitador.Text = Usuario.usuario;
            txtSerie.Text = Talon.serie;

            if (iTipo == 0) //0: paciente existente
            {
                sSQL = "SELECT id_paciente,nombre,ape_paterno,ape_materno,dni,edad," +
                        "CASE WHEN sexo = 'M' THEN 'MASCULINO' ELSE 'FEMENINO' END AS sexo," +
                        "telefono,direccion,asegurado,id_distrito,odoc,e_mail,nro_historia,fecha_nac " +
                        "FROM Pacientes P ";
                if (iEstado == 0)
                    sSQL = sSQL + "WHERE id_paciente = '" + sPaciente + "' ";
                else
                    sSQL = sSQL + "WHERE dni = '" + sPaciente + "' ";

                using (SqlCommand cmd = new SqlCommand(sSQL, Conexion.CNN))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            Habilita(0);
                            dr.Read();
                            txtNHP.Text = (dr.GetValue(13).ToString().Length == 0 ? "0" : dr.GetValue(13).ToString());
                            NROHISTORIA = txtNHP.Text;
                            txtIdPaciente.Text = dr.GetValue(0).ToString();
                            txtNombre.Text = dr.GetValue(1).ToString();
                            txtApePaterno.Text = dr.GetValue(2).ToString();
                            txtApeMaterno.Text = dr.GetValue(3).ToString();
                            txtDNI.Text = dr.GetValue(4).ToString();
                            txtEdad.Text = dr.GetValue(5).ToString();
                            txtSexo.Text = dr.GetValue(6).ToString();
                            txtTelefono.Text = dr.GetValue(7).ToString();
                            txtDireccion.Text = dr.GetValue(8).ToString();
                            txtAsegurado.Text = dr.GetValue(9).ToString();
                            UbicaItemCombo(cmbDepartamento, dr.GetValue(10).ToString().Substring(0, 2));
                            UbicaItemCombo(cmbProvincia, dr.GetValue(10).ToString().Substring(0, 4));
                            UbicaItemCombo(cmbDistrito, dr.GetValue(10).ToString());
                            txtODoc.Text = dr.GetValue(11).ToString();
                            txtEmail.Text = dr.GetValue(12).ToString();
                            txtFechaNac.Text = dr.GetValue(14).ToString();
                        }
                        dr.Close();
                    }
                }
            }
            else //1: paciente nuevo
            {
                sSQL = "SELECT P.Dni,P.Nombres,P.Ape_Pat,P.Ape_Mat,CONVERT(datetime, P.Fec_Nac,112) AS Fec_Nac, " +
                        "DATEDIFF(YEAR, P.Fec_Nac, CONVERT(VARCHAR, GETDATE(), 112)) AS Edad," +
                        " CASE WHEN sexo = 1 THEN 'MASCULINO' ELSE 'FEMENINO' END AS sexo,U.Id_Old " +
                        " FROM DNI..Padron P INNER JOIN DNI..Ubigeo2005 U " +
                        "ON P.Ubigeo = U.Ubigeo " +
                        "WHERE DNI = '" + sPaciente + "' ";
                using (SqlCommand cmd = new SqlCommand(sSQL, Conexion.CNN))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dr.Read();
                            Habilita(0);
                            btnNuevo.Text = "&Grabar Venta";
                            txtFechaEmision.Text = General.FechaServidor();
                            txtNHP.Text = "0";
                            NROHISTORIA = txtNHP.Text;
                            UbicaItemCombo(cmbDepartamento, dr.GetValue(7).ToString().Substring(0, 2));
                            UbicaItemCombo(cmbProvincia, dr.GetValue(7).ToString().Substring(0, 4));
                            UbicaItemCombo(cmbDistrito, dr.GetValue(7).ToString());
                            txtNombre.Text = dr.GetValue(1).ToString();
                            txtApePaterno.Text = dr.GetValue(2).ToString();
                            txtApeMaterno.Text = dr.GetValue(3).ToString();
                            txtDNI.Text = dr.GetValue(0).ToString();
                            txtEdad.Text = dr.GetValue(5).ToString();
                            txtSexo.Text = dr.GetValue(6).ToString();
                            txtFechaNac.Text = dr.GetValue(4).ToString().Substring(0, 10);
                        }
                        dr.Close();
                    }
                }
            }
            ValidaRangosDocsVenta();
        }

        private void txtDNI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled == true)
            {
                txtDNI.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnDuplica_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscat_Click(object sender, EventArgs e)
        {
            /*
             * thisformset.frmhistoria.hide
                .show
                .cmbespecialidad.rowsource = 'Allt(cesp.Descripcion),Id_Consultorio'
                .setall('Value', '', 'TextBox')
                .setall('Value', '', 'ComboBox')
                .txtserie.setfocus
                */
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (bTieneDocVenta == false)
                return;

            if (cmbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una especialidad...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (cmbMedico.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un especialidad...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            //agrega una fila
            fGrid.Rows.Count = fGrid.Rows.Count + 1;
            fGrid.Cells[fGrid.Rows.Count - 1, 0].DropDownControl = iGDDL;

            if (fGrid.Rows.Count != 0)
                btnQuitar.Enabled = true;
            else
                btnQuitar.Enabled = false;


        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string sSQL = "";

            Ubigeo oEspecialidad = (Ubigeo)cmbEspecialidad.SelectedItem;

            if (txtNroTicket.Text.Trim() == "" || int.Parse(txtNroTicket.Text.Trim()) == 0)
                return;

            if (NROHISTORIA == "")
                return;

            if (BUS.Trim() == "" || BUS.Trim().Length == 0)
            {
                //agregar codigo para identificar BUS
            }

            sSQL = "SELECT Ape_Paterno,Ape_Materno,Nombre,DNI,ODoc,Fecha_Nac, " +
                   "Edad,Sexo,P.Direccion,DP.Distrito PDist, Nro_Ticket, " +
                   "Fecha_Emision, Serie, C.Descripcion Espec, Nom_Raz_Soc, " +
                   "I.Direccion + ', ' + DI.Distrito IDireccion " +
                   "FROM Tickets T INNER JOIN Pacientes P " +
                   "ON T.Id_Paciente = P.Id_Paciente " +
                   "INNER JOIN Consultorios C " +
                     "ON T.Id_Consultorio = C.Id_Consultorio " +
                   "LEFT JOIN Ubigeo2005 DP " +
                   "ON P.Id_Distrito = DP.Id_Old " +
                   "LEFT JOIN Institucion I " +
                   "ON T.Id_Inst = I.TInst + I.Id_Inst " +
                   "LEFT JOIN Ubigeo2005 DI " +
                   "ON I.Id_Distrito = DI.Id_Old " +
                   "WHERE T.Nro_Historia = '" + NROHISTORIA + "'";
            using (SqlCommand cmd = new SqlCommand(sSQL, Conexion.CNN))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dr.Read();

                    }
                    dr.Close();
                }
            }







        }

        private void CargaDatosHistoria(string sNroHistoria)
        {
            string sSQL = "";

            if (sNroHistoria == "" || sNroHistoria.Length == 0)
                return;

            sSQL = "SELECT T.Nro_Historia, T.Nro_Ticket, T.Fecha_Emision, T.Id_Consultorio, T.Id_Paciente, " +
                    "T.Digitador, T.Anulado, T.ForPago, T.Descuento, T.Serie, T.CMP, T.Id_Inst, T.Moneda, " +
                    "T.Convenio, T.DVenta, T.Id_Bus, T.tsg, P.Nombre, P.Ape_Paterno, P.Ape_Materno, " +
                    "P.DNI, P.Fecha_Nac, P.Edad, CASE WHEN P.Sexo = 'M' THEN 'MASCULINO' ELSE 'FEMENINO' END AS sexo, " +
                    "P.Telefono, P.Direccion, P.Asegurado, P.Id_Distrito, " +
                    "P.ODoc, P.E_Mail, C.Descripcion, C.Estado, C.Turno, " +
                    "C.Tipo, C.Observacion, P.Nro_Historia " +
                    "FROM Tickets T INNER JOIN Pacientes P " +
                    "ON T.Id_Paciente = P.Id_paciente " +
                    "INNER JOIN Consultorios C " +
                    "ON T.Id_Consultorio = C.Id_Consultorio " +
                    "WHERE T.Nro_Historia = '" + sNroHistoria + "'";
            using (SqlCommand cmd = new SqlCommand(sSQL, Conexion.CNN))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txtNHP.Text = dr.GetValue(35).ToString().Trim();
                            txtNroTicket.Text = dr.GetValue(1).ToString().Trim();
                            txtFechaEmision.Text = dr.GetValue(2).ToString().Trim();
                            UbicaItemCombo(cmbEspecialidad, dr.GetValue(3).ToString().Trim());
                            txtIdPaciente.Text = dr.GetValue(4).ToString().Trim();
                            txtDigitador.Text = General.TradUser(dr.GetValue(5).ToString().Trim());
                            UbicaItemCombo(cmbMVen, dr.GetValue(7).ToString().Trim());
                            if (dr.GetValue(8).ToString().Trim() != "")
                                if (dr.GetValue(8).ToString().Substring(0, 1) == "D")
                                {
                                    string ads = dr.GetValue(8).ToString().Substring(29, 9).Trim();

                                    sSQL = "Select LTrim(RTrim(Ape_Paterno))+' '+LTrim(RTrim(Ape_Materno))+' '+LTrim(RTrim(Nombres))Personal,Id_Personal " +
                                            "From Personal " +
                                            "Where Id_Personal = '" + ads.Trim() + "' " +
                                            "Union All " +
                                            "Select Nom_Raz_Soc Personal,TInst + Id_Inst Id_Personal " +
                                            "  From Institucion " +
                                            "  Where TInst + Id_Inst = '" + ads.Trim() + "' ";

                                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
                                    {
                                        try
                                        {
                                            if (db.State == ConnectionState.Closed)
                                                db.Open();

                                            dynamic returns = db.Query<dynamic>(sSQL);
                                            txtAutoriza.Text = returns[0].Personal + " (S/. " + dr.GetValue(8).ToString().Substring(38, 8).Trim() + ")";
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                }
                            txtSerie.Text = dr.GetValue(9).ToString().Trim();
                            UbicaItemCombo(cmbMedico, dr.GetValue(10).ToString().Trim());
                            UbicaItemCombo(cmbInstitucion, dr.GetValue(11).ToString().Trim());
                            UbicaItemCombo(cmbTDoc, dr.GetValue(14).ToString().Trim());
                            txtNombre.Text = dr.GetValue(17).ToString();
                            txtApePaterno.Text = dr.GetValue(18).ToString();
                            txtApeMaterno.Text = dr.GetValue(19).ToString();
                            txtDNI.Text = dr.GetValue(20).ToString();
                            txtFechaNac.Text = dr.GetValue(21).ToString();
                            txtEdad.Text = dr.GetValue(22).ToString();
                            txtSexo.Text = dr.GetValue(23).ToString();
                            txtTelefono.Text = dr.GetValue(24).ToString();
                            txtDireccion.Text = dr.GetValue(25).ToString();
                            txtAsegurado.Text = dr.GetValue(26).ToString();
                            UbicaItemCombo(cmbDepartamento, dr.GetValue(27).ToString().Substring(0, 2));
                            UbicaItemCombo(cmbProvincia, dr.GetValue(27).ToString().Substring(0, 4));
                            UbicaItemCombo(cmbDistrito, dr.GetValue(27).ToString());
                            txtODoc.Text = dr.GetValue(28).ToString();
                            txtEmail.Text = dr.GetValue(29).ToString();
                            //carga detalle
                            CargaDetalleTicket(sNroHistoria, dr.GetValue(3).ToString().Trim());
                        }
                    }
                    dr.Close();
                }
            }
        }

        private void ValidaDatosTicket(string sNroHistoria)
        {
            string sSQL = "";

            if (sNroHistoria != "" || sNroHistoria.Length != 0)
            {
                sSQL = "SELECT Nro_Historia,Nro_Ticket,Fecha_Emision,Id_Consultorio, " +
                        "Id_Paciente,Digitador,Anulado,ForPago,Descuento,Serie, " +
                        "CMP,Id_Inst,Moneda,Convenio,DVenta,Id_Bus,tsg " +
                        "FROM Tickets " +
                        "WHERE Nro_Historia = '" + sNroHistoria + "'";
            }
            else
            {
                sSQL = "SELECT Nro_Historia,Nro_Ticket,Fecha_Emision,Id_Consultorio," +
                        "Id_Paciente,Digitador,Anulado,ForPago,Descuento,Serie," +
                        "CMP,Id_Inst,Moneda,Convenio,DVenta,Id_Bus,tsg " +
                        "FROM Tickets " +
                        "WHERE Fecha_Emision IN " +
                        "(SELECT MAX(Fecha_Emision) " +
                        " FROM Tickets " +
                        " WHERE Digitador = '" + Usuario.id_us + "' " +
                        " AND Fecha_Emision >= Convert(Varchar(10), GetDate(), 103)) " +
                        "AND Digitador = '" + Usuario.id_us + "' " +
                        "AND Fecha_Emision >= Convert(Varchar(10), GetDate(), 103)";
            }

            if (sSQL == "")
                return;

            using (SqlCommand cmd = new SqlCommand(sSQL, Conexion.CNN))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txtFechaEmision.Text = dr.GetValue(2).ToString().Trim();
                            UbicaItemCombo(cmbTDoc, dr.GetValue(14).ToString().Trim());
                            UbicaItemCombo(cmbMVen, dr.GetValue(7).ToString().Trim());
                            txtSerie.Text = dr.GetValue(9).ToString().Trim();
                            txtNroTicket.Text = dr.GetValue(1).ToString().Trim();
                            txtDigitador.Text = General.TradUser(dr.GetValue(5).ToString().Trim());
                            txtIdPaciente.Text = dr.GetValue(4).ToString().Trim();
                            UbicaItemCombo(cmbEspecialidad, dr.GetValue(3).ToString().Trim()); //validar si llena los productos
                            UbicaItemCombo(cmbInstitucion, dr.GetValue(11).ToString().Trim());
                            UbicaItemCombo(cmbMedico, dr.GetValue(10).ToString().Trim());
                            txtAutoriza.Text = "";

                            if (dr.GetValue(8).ToString().Trim() != "")
                                if (dr.GetValue(8).ToString().Trim().Substring(0, 1) == "D")
                                {
                                    string ads = dr.GetValue(8).ToString().Substring(29, 9).Trim();

                                    sSQL = "Select LTrim(RTrim(Ape_Paterno))+' '+LTrim(RTrim(Ape_Materno))+' '+LTrim(RTrim(Nombres))Personal,Id_Personal " +
                                            "From Personal " +
                                            "Where Id_Personal = '" + ads.Trim() + "' " +
                                            "Union All " +
                                            "Select Nom_Raz_Soc Personal,TInst + Id_Inst Id_Personal " +
                                            "  From Institucion " +
                                            "  Where TInst + Id_Inst = '" + ads.Trim() + "' ";

                                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
                                    {
                                        try
                                        {
                                            if (db.State == ConnectionState.Closed)
                                                db.Open();

                                            dynamic returns = db.Query<dynamic>(sSQL);
                                            txtAutoriza.Text = returns[0].Personal + " (S/. " + dr.GetValue(8).ToString().Substring(38, 8).Trim();

                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                }

                            txtNHP.Text = dr.GetValue(0).ToString().Trim();
                            CargaDetalleTicket(dr.GetValue(0).ToString().Trim(), dr.GetValue(3).ToString().Trim());

                            if (dr.GetString(15).Trim() != "")
                            {
                                string vSql = "SELECT Bus FROM buses WHERE id_bus = '" + dr.GetValue(15).ToString().Trim() + "'";
                                BUS = General.TomaValor(vSql);
                            }

                            NROHISTORIA = dr.GetValue(0).ToString().Trim();
                            CargaDatosPaciente(1, "");

                        }
                    }
                    else
                    {

                    }
                    dr.Close();
                }
            }

        }

        private void CargaDetalleTicket(string sNHC, string sEspecialidad)
        {
            iGDropDownList cmb = new iGDropDownList();
            double dTotal = 0;
            fGrid.Rows.Clear();
            FormateaGrids();

            if (sNHC.Trim() == "")
                return;

            if (sEspecialidad.Trim() == "")
                return;

            string vSQL = "SELECT COUNT(*) AS cant " +
                          "FROM Detalles " +
                          "WHERE Nro_Historia = '" + sNHC.ToString() + "'";
            int iCant = int.Parse(General.TomaValor(vSQL));

            vSQL = "SELECT nro_historia,id_producto,monto,cantidad," +
                   "pagado,dscto,resultado,conclusion " +
                   "FROM Detalles " +
                   "WHERE Nro_Historia = '" + sNHC.ToString() + "'";
            using (SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        fGrid.BeginUpdate();
                        fGrid.Rows.Count = iCant;

                        foreach (iGRow row in fGrid.Rows)
                        {
                            dr.Read();
                            //cmb = CargaProductos(sEspecialidad, dr.GetValue(1).ToString());
                            CargaProductos(sEspecialidad, dr.GetValue(1).ToString());
                            row.Cells[0].DropDownControl = iGDDL;
                            row.Cells[0].Value = iGDDL.Items[0].Value;
                            row.Cells[1].Value = dr.GetValue(3).ToString();
                            row.Cells[2].Value = dr.GetValue(2).ToString(); //DevuelvePrecioProducto(dr.GetValue(1).ToString());
                            row.Cells[3].Value = (int.Parse(row.Cells[1].Value.ToString()) * double.Parse(row.Cells[2].Value.ToString())).ToString("#,###.#0");
                            row.Cells[4].Value = dr.GetValue(1).ToString();
                            dTotal = dTotal + double.Parse(row.Cells[3].Value.ToString());
                        }
                        fGrid.EndUpdate();
                        txtNeto.Text = dTotal.ToString("#,###.#0");
                        txtTotal.Text = dTotal.ToString("#,###.#0");
                        txtSon.Text = General.NumeroTexto(dTotal.ToString("#.#0"));
                    }
                    dr.Close();
                }
            }
        }

        private void BloqueaControles(Control con, string FLAG = "")
        {
            //para bloquear dejar en blanco la segunda variable
            //para desbloquear segunda variable no debe estar en blanco

            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    if (FLAG == "")
                    {
                        ((TextBox)c).ReadOnly = true;
                        if (((TextBox)c).BackColor != Color.Gold)
                            ((TextBox)c).BackColor = Color.White;
                    }
                    else
                        ((TextBox)c).ReadOnly = false;
                else if (c is ComboBox)
                    if (FLAG == "")
                    {
                        ((ComboBox)c).Enabled = false;
                        ((ComboBox)c).BackColor = Color.White;
                    }
                    else
                        ((ComboBox)c).Enabled = true;
                else if (c is MaskedTextBox)
                    if (FLAG == "")
                    {
                        ((MaskedTextBox)c).ReadOnly = true;
                        ((MaskedTextBox)c).BackColor = Color.White;
                    }
                    else
                        ((MaskedTextBox)c).ReadOnly = false;

                if (c.HasChildren)
                    BloqueaControles(c);
            }

            if (FLAG == "")
            {
                fGrid.Enabled = false;
                fGrid.BackColor = Color.White;
            }
            else
                fGrid.Enabled = true;
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Ingresar un email valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private string UbicaDuplicadoGrilla(string sDato)
        {
            string sResultado = "";
            int iDup = 0;

            for (int i = 0; i < fGrid.Rows.Count; i++)
            {
                if (sDato == fGrid.Cells[i, 0].AuxValue.ToString().Trim().ToUpper())
                {
                    iDup = iDup + 1;
                    sResultado = i.ToString();
                    //break;
                }
            }

            if (iDup > 1)
                return sResultado;
            else
                return "";

        }

        private bool RemueveItemTicket(int iFila)
        {
            bool bRemovido = false;
            if (iFila == -1)
                return bRemovido;

            int cCant = fGrid.Rows.Count;
            fGrid.Rows.RemoveAt(iFila);

            if (fGrid.Rows.Count != cCant)
                bRemovido = true;

            return bRemovido;
        }

        private void iGDDL_SelectedItemChanged(object sender, iGSelectedItemChangedEventArgs e)
        {
            string sProd = "";

            if (e.SelectedItem == null)
                return;

            if (cmbEspecialidad.SelectedIndex == -1)
                return;

            if (cmbMedico.SelectedIndex == -1)
                return;

            if (fGrid.CurCell.RowIndex == -1)
                return;

            if (fGrid.CurCell.ColIndex == 0)
                if (fGrid.CurCell.AuxValue != null)
                    sProd = fGrid.CurCell.Value.ToString().Trim().ToUpper();

            if (sProd != "")
                fGrid.Cells[fGrid.CurCell.RowIndex, 2].Value = DevuelvePrecioProducto(sProd);





        }

        private void fGrid_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void fGrid_CellClick(object sender, iGCellClickEventArgs e)
        {

            /*


			if( fGrid.Rows.Count < 2 )
				return;
			else
			{
				if( fGrid.CurCell.ColIndex == 0 )
					if( fGrid.CurCell.AuxValue != null )
						sProd = fGrid.CurCell.AuxValue.ToString().Trim().ToUpper();
					else
					{
						fGrid.CurCell.AuxValue = "";
						return;
					}

				if( sProd == "" )
					return;

				sIdxDuplicado = UbicaDuplicadoGrilla(sProd);
				bool bRemovido = false;
				if( sIdxDuplicado != "" )
				{
					MessageBox.Show("No puede seleccionar el mismo producto mas de 1 vez...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					bRemovido = RemueveItemTicket(Int32.Parse(sIdxDuplicado));
				}

				if( bRemovido == true )
				{
					fGrid.CurCell = fGrid.Cells[0, 0];
					btnAgregar.Focus();
				}
			}


			*/

        }

        private void txtDireccion_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtDireccion.Enabled = true;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (this.lastKey == Keys.F12)
            {
                //frmmessage.txtmessage.setfocus
                this.cad = txtDireccion.Text;
                txtDireccion.Text = (cad.Length == 1 ? "" : cad.Substring(0, cad.Length - 1));
            }

            this.msg("D");
        }


        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtDireccion.Enabled = true;
            }
        }

        private void txtNroTicket_DoubleClick(object sender, EventArgs e)
        {
            if (txtNroTicket.Enabled == false)
            {
                txtNroTicket.Enabled = true;
                cmbEspecialidad.SelectedIndex = -1;
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
                btnAgregar.Enabled = false;
                btnQuitar.Enabled = false;
                this.tmpd.Clear();
            }
        }

        private void cmbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ie = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();

            if (ie.Length > 0 && cmbEspecialidad.Enabled)
            {
                if (Usuario.tipo == "A" && this.cesp["Descripcion"] == "FARMACIA")
                {
                    int c = Conexion.ExecuteScalar<int>("Select ISULL(Max(Cast(Nro_Ticket As Int)), 0) C From Tickets Where Id_Consultorio In (Select Id_Consultorio From " +
"Consultorios Where Descripcion Like '%FARMACIA%' And Left(Id_Consultorio,3)='" + Operativo.id_oper + "')");

                    this.nrv = Operativo.id_oper + DateTime.Parse(txtFechaEmision.Text).ToString("yyyymmdd").Substring(2) + (c + 1).ToString();
                    txtNroTicket.Text = this.nrv.Substring(9, 19);
                }
                else
                {
                    if (Usuario.tipo != "A" && cesp["Descripcion"] == "FARMACIA")
                    {
                        cmbEspecialidad.SelectedIndex = -1;
                        return;
                    }
                    else
                    {
                        this.nrv = Operativo.id_oper + DateTime.Parse(txtFechaEmision.Text).ToString("yyyymmdd").Substring(2) + (cmbTDoc.SelectedIndex == -1 ? "" : cmbTDoc.SelectedValue.ToString()) + txtSerie.Text + txtNroTicket.Text;
                    }
                }

                DateTime fe = DateTime.Parse(txtFechaEmision.Text);
                string tr = "";
                string fi = "";

                if (this.cesp["C"] != "")
                {
                    if (fe.Hour >= 7 && fe.Hour <= 13)
                    {
                        tr = "M";
                        fi = "7";
                    }

                    if (fe.Hour >= 14 && fe.Hour <= 19)
                    {
                        tr = "T";
                        fi = "14";
                    }

                    if ((fe.Hour >= 20 && fe.Hour <= 24) || (fe.Hour >= 0 && fe.Hour <= 1))
                    {
                        tr = "N";
                        fi = "20";
                    }

                    if (fe.Hour >= 2 && fe.Hour <= 8)
                    {
                        tr = "A";
                        fi = "2";
                    }

                    fi = (this.cesp["C"] == "0" ? DateTime.Parse(fe.ToShortDateString() + " " + fi).ToLongDateString() : fe.ToShortDateString());
                    int cs = Conexion.ExecuteScalar<int>("Select Case When Sum(Cantidad) Is Null Then 0 Else Sum(Cantidad) End cs " +
                        "From Tickets T Inner Join Detalles D On T.Nro_Historia=D.Nro_Historia " +
                        "Where Fecha_Emision Between '" + fi + "' And '" + fe + "' And Id_Consultorio='" + ie + "' And Anulado=''");

                    int ts = this.cesp["C"] == "0" ? int.Parse(tr) : (int.Parse(this.cesp["M"]) + int.Parse(this.cesp["T"]) + int.Parse(this.cesp["N"]) + int.Parse(this.cesp["A"]));
                    string ms = " ventas para esta especialidad, " + "\t" + "segun los criterios por turno establecidos ...";

                    if (cs >= ts)
                    {
                        ms = "Ha llegado al limite de" + ms;
                        General.msg(ms, 1, "48", "Aviso al usuario");
                        General.chgst("Consultoios", ie, "0");
                        cmbEspecialidad.SelectedIndex = -1;
                        return;
                    }
                    else
                    {
                        ms = (ts - cs < 11 ? "Solo quedan " + (ts - cs).ToString() + ms : "");

                        if (ms.Contains("Solo"))
                        {
                            General.msg(ms, 1, "48", "Aviso al usuario");
                        }
                    }
                }

                //Llenar combobox de productos
                /*
                 *  WITH .grddetalle.column1.cmbproducto
          .rowsource = ''
          closecursor('Productos')
          scad = "Select * From Productos Where Left(Id_Producto,6)=?ie And Estado='1' Order By 2"
          ejecuta(nconnect, scad, 'Productos')
          SELECT productos
          .rowsource = 'Allt(Productos.Descripcion),Id_Producto'
       ENDWITH
                 */

                this.tmpd.Clear();

                txtTotal.Text = "0.00";
                chkInst.Enabled = this.cesp["Tipo"] == "C";
                chkInst.Checked = this.cesp["Tipo"] == "C";
                btnInst.Enabled = this.cesp["Tipo"] == "C";
                cmbInstitucion.Enabled = this.cesp["Tipo"] == "C";
                if (this.cesp["Tipo"] == "C")
                {
                    cmbInstitucion.SelectedIndex = -1;
                }

            }
        }

        private void txtNroTicket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (txtNroTicket.Enabled == false && (btnNuevo.Text == "&Grabar" || btnBuscar.Text == "&Grabar"))
                {
                    txtNroTicket.Enabled = true;
                    cmbEspecialidad.SelectedIndex = -1;
                    cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
                    btnAgregar.Enabled = false;
                    btnQuitar.Enabled = false;

                    this.tmpd.Clear();
                }
            }
        }

        private void txtNroTicket_Leave(object sender, EventArgs e)
        {
            if (txtNroTicket.Enabled && txtNroTicket.Text.Length > 0)
            {
                if (Usuario.tipo == "A")
                {
                    this.vdv(txtSerie.Text, txtNroTicket.Text/*, (cmbTDoc.SelectedIndex == 1 ? "" : cmbTDoc.SelectedValue.ToString())*/, (cmbMVen.SelectedIndex == 1 ? "" : cmbMVen.SelectedValue.ToString()));
                }
                else
                {
                    string fi = txtFechaEmision.Text;
                    string ff = DateTime.Parse(txtFechaEmision.Text).AddDays(1).ToShortDateString();
                    string sql = "Select * From Talon Where Fecha Between '" + fi + "' And '" + ff + "' And Usuario='" + Usuario.id_us + "' And Id_Oper='" + Operativo.id_oper + "' Order By 2";
                    List<Dictionary<string, string>> talones = General.GetDictionaryList(sql);

                    int na = int.Parse(txtNroTicket.Text);
                    int xn = 0;
                    foreach (Dictionary<string, string> talon in talones)
                    {
                        int ni = int.Parse(talon["NInicial"]);
                        int nf = int.Parse(talon["NFinal"]);

                        if (na >= ni && na <= nf)
                        {
                            xn++;
                        }
                    }

                    if (xn > 0)
                    {
                        this.vdv(txtSerie.Text, txtNroTicket.Text, cmbMVen.SelectedIndex == -1 ? "" : cmbMVen.SelectedValue.ToString());
                    }
                    else
                    {
                        MessageBox.Show("N° de documento de venta no pertenece a sus rangos del dia ...", "Advertencia");
                        txtNroTicket.Text = "";
                    }
                }
            }
        }

        private void txtFechaEmision_DoubleClick(object sender, EventArgs e)
        {
            if (Usuario.tipo == "A")
            {
                txtFechaEmision.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!(this.lastKey == Keys.Delete || this.lastKey == Keys.Insert || this.lastKey == Keys.F1 || this.lastKey == Keys.Space || char.IsLetter((char)this.lastKey) || this.lastKey == Keys.Back))
            {
                this.cad = txtNombre.Text;
                txtNombre.Text = cad.Length == 1 ? "" : cad.Substring(0, cad.Length - 1);
                txtNombre.Select();
            }

            if (this.lastKey == Keys.F12)
            {
                //.frmmessage.txtmessage.setfocus
            }

            this.msg("P");
        }

        private void txtApePaterno_TextChanged(object sender, EventArgs e)
        {
            if (!(this.lastKey == Keys.Delete || this.lastKey == Keys.Insert || this.lastKey == Keys.F1 || this.lastKey == Keys.Space || char.IsLetter((char)this.lastKey) || this.lastKey == Keys.Back))
            {
                this.cad = txtApePaterno.Text;
                txtApePaterno.Text = cad.Length == 1 ? "" : cad.Substring(0, cad.Length - 1);
                txtApePaterno.Select();
            }

            if (this.lastKey == Keys.F12)
            {
                //.frmmessage.txtmessage.setfocus
            }

            this.msg("P");
        }

        private void txtApeMaterno_TextChanged(object sender, EventArgs e)
        {
            if (!(this.lastKey == Keys.Delete || this.lastKey == Keys.Insert || this.lastKey == Keys.F1 || this.lastKey == Keys.Space || char.IsLetter((char)this.lastKey) || this.lastKey == Keys.Back))
            {
                this.cad = txtApeMaterno.Text;
                txtApeMaterno.Text = cad.Length == 1 ? "" : cad.Substring(0, cad.Length - 1);
                txtApeMaterno.Select();
            }

            if (this.lastKey == Keys.F12)
            {
                //.frmmessage.txtmessage.setfocus
            }

            this.msg("P");
        }

        private void txtDNI_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtDNI.Enabled = true;
            }
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            int dni = txtDNI.Text.Length;

            if (dni < 8)
            {
                MessageBox.Show("Longitud de DNI no valida ... dato debe contener 8 digitos ... verifique", "Advertencia");
            }
        }

        private void txtFechaNac_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtFechaNac.Enabled = true;
            }
        }

        private void txtFechaNac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtFechaNac.Enabled = true;
            }
        }

        private void txtFechaNac_Leave(object sender, EventArgs e)
        {
            if (txtFechaNac.Enabled && txtFechaNac.Text != General.emptyDate)
            {
                DateTime date = DateTime.Parse(txtFechaNac.Text);
                if (date.CompareTo(DateTime.Today) > 0 || date.Year < 1900)
                {
                    MessageBox.Show("Fecha de nacimiento erronea ... corrija los datos ...", "Advertencia");
                    return;
                }

                txtEdad.Text = General.getYearsUntilNow(date).ToString();
            }
        }

        private void txtEdad_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtEdad.Enabled = true;
            }
        }

        private void txtEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtEdad.Enabled = true;
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text.Length == 0)
            {
                MessageBox.Show("Ingrese la edad del Paciente...", "Advertencia...");
                return;
            }

            if (int.Parse(txtEdad.Text) < 0)
            {
                MessageBox.Show("Corregir los datos ... la edad no puede ser un número negativo ...", "Advertencia...");
                return;
            }

            if (int.Parse(txtEdad.Text) > 100)
            {
                MessageBox.Show("Verifique los datos ... la edad del paciente es mayor a 100 años?", "Advertencia...");
                return;
            }
        }

        private void txtSexo_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtSexo.Enabled = true;
            }
        }

        private void txtSexo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtSexo.Enabled = true;
            }
        }

        private void txtSexo_Leave(object sender, EventArgs e)
        {
            string sex = txtSexo.Text;

            if (sex == "" || (sex != "M" && sex != "F"))
            {
                MessageBox.Show("Dato no valido ingrese solo F ó M ...", "Advertencia ...");
            }
        }

        private void txtTelefono_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtTelefono.Enabled = true;
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtTelefono.Enabled = true;
            }
        }

        private void txtAsegurado_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtAsegurado.Enabled = true;
            }
        }

        private void txtAsegurado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtAsegurado.Enabled = true;
            }
        }

        private void txtAsegurado_Leave(object sender, EventArgs e)
        {
            string seg = txtAsegurado.Text.ToUpper();

            if (seg != "S" && seg != "")
            {
                MessageBox.Show("Dato no valido ingrese vacio ó S ...", "Advertencia ...");

            }
        }

        private void cmbDistrito_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                cmbDistrito.Enabled = true;
            }
        }

        private void cmbDistrito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                cmbDistrito.Enabled = true;
            }

            if (cmbDistrito.Enabled && e.KeyCode == Keys.Delete)
            {
                cmbDistrito.SelectedIndex = -1;
            }
        }

        private void cmbMedico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;

            if (cmbEspecialidad.SelectedIndex == -1)
            {
                cmbMedico.SelectedIndex = -1;
                cmbEspecialidad.Focus();

                MessageBox.Show("Seleccione especialidad ... para poder realizar la venta", "Advertencia");
                return;
            }

            if (chkInst.Enabled && cmbInstitucion.SelectedIndex == -1)
            {
                cmbMedico.SelectedIndex = -1;
                cmbEspecialidad.Focus();
                MessageBox.Show("La Razon Social de la empresa es dato necesario ... para pasar el examen", "Advertencia");
                return;
            }

            btnAgregar.Enabled = true;
        }

        private void cmbMedico_Leave(object sender, EventArgs e)
        {
            cmbMedico_SelectionChangeCommitted(cmbMedico, new EventArgs());
        }

        private void cmbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.provinciasTableAdapter.Fill(this.provinciasDS.Provincias, cmbDepartamento.SelectedValue.ToString());
            cmbProvincia.SelectedIndex = -1;
        }

        private void cmbDepartamento_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                cmbDepartamento.Enabled = true;
            }
        }

        private void cmbDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                cmbDepartamento.Enabled = true;
            }

            if (cmbDepartamento.Enabled && e.KeyCode == Keys.Delete)
            {
                cmbDepartamento.SelectedIndex = -1;
            }
        }

        private void cmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.distritoTableAdapter.Fill(this.distritoDS.Distrito, cmbProvincia.SelectedValue.ToString());
            cmbDistrito.SelectedIndex = -1;
        }

        private void cmbProvincia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                cmbProvincia.Enabled = true;
            }
        }

        private void cmbProvincia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                cmbProvincia.Enabled = true;
            }

            if (cmbProvincia.Enabled && e.KeyCode == Keys.Delete)
            {
                cmbProvincia.SelectedIndex = -1;
            }
        }

        private void txtODoc_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtODoc.Enabled = true;
            }
        }

        private void txtODoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtODoc.Enabled = true;
            }
        }

        private void cmbInstitucion_KeyDown(object sender, KeyEventArgs e)
        {
            if (cmbInstitucion.Enabled && e.KeyCode == Keys.Delete)
            {
                cmbInstitucion.SelectedIndex = -1;
            }
        }

        private void chkInst_CheckedChanged(object sender, EventArgs e)
        {
            btnInst.Enabled = !btnInst.Enabled;
            cmbInstitucion.Enabled = !cmbInstitucion.Enabled;
            cmbInstitucion.SelectedIndex = -1;
        }

        private void btnInst_Click(object sender, EventArgs e)
        {
            //Cargar frmbuscai
            /*
             *  .show
    .cmbtinst.value = 'T'
    .txtcriterio.value = ''
    .txtcriterio.interactivechange
    .txtcriterio.setfocus
             */
        }

        private void txtNHP_DoubleClick(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "&Grabar" && !txtNHP.Enabled)
            {
                txtNHP.Enabled = true;
            }
        }

        private void txtNHP_Leave(object sender, EventArgs e)
        {
            if (txtNHP.Text.Length > 0 && txtNHP.Enabled)
            {
                string nh = txtNHP.Text;
                string sql = "Select Ape_Paterno+' '+Ape_materno+' '+Nombre pac,Nro_Historia nh From Pacientes Where Nro_Historia='" + nh + "'";
                Dictionary<string, string> rnh = General.GetDictionary(sql);
                string msg = rnh != null ? "Nro. de historia " + rnh["nh"] + " corresponde al paciente:\t" + rnh["pac"] + " ... corregir" : "";

                if (msg.Length > 0)
                {
                    MessageBox.Show(msg, "Advertencia");
                    return;
                }

                if (btnBuscar.Text == "&Grabar")
                {
                    string ip = txtIdPaciente.Text;
                    string sql2 = "Update Pacientes Set Nro_Historia='" + nh  + "' Where Id_Paciente='" + ip + "'";
                    Conexion.ExecuteNonQuery(sql2);
                    MessageBox.Show("Operación ejecutada con éxito");
                }
            }
        }

        private void cmbTDoc_Leave(object sender, EventArgs e)
        {
            string mv = cmbMVen.SelectedIndex == -1 ? "" : cmbMVen.SelectedValue.ToString();
            string serie = Conexion.ExecuteScalar<string>("Select Serie From Talon Where Fecha=(Select Max(Fecha) From Talon Where MVenta='" + mv + "') And MVenta='" + mv + "'");
            txtSerie.Text = serie;
        }

        private void cmbMVen_Leave(object sender, EventArgs e)
        {
            cmbTDoc.SelectedValue = cmbMVen.SelectedValue.ToString() == "2" ? "3" : "";
            cmbTDoc.Enabled = cmbMVen.SelectedValue.ToString() == "2";
            if (cmbMVen.SelectedValue.ToString() == "2")
            {
                cmbTDoc_Leave(cmbTDoc, new EventArgs());
            }
        }

        private void grdDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int i = grdDetalle.CurrentCell.RowIndex;

            switch (grdDetalle.CurrentCell.ColumnIndex)
            {
                case 0:
                    break;
                case 1:
                    TextBox textBox = (TextBox)grdDetalle.EditingControl;

                    if (textBox.Enabled)
                    {
                        if (int.Parse(textBox.Text) < 1)
                        {
                            textBox.Text = "1";
                        }

                        if (int.Parse(textBox.Text) > 9)
                        {
                            if (MessageBox.Show("La cantidad ingresada de " + textBox.Text + ", es correcta? ... ?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                return;
                            }
                        }
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }

        }

        private void grdDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Only for a DatagridComboBoxColumn at ColumnIndex 0.
            if (grdDetalle.CurrentCell.ColumnIndex == 0)
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
            int i = grdDetalle.CurrentCell.RowIndex;

            ComboBox combo = (ComboBox)sender;
            int j = combo.SelectedIndex;
            DataRow row = ((DataRowView)combo.SelectedItem).Row;

            this.tmpd[j]["Ipr"] = row["Id_Producto"].ToString();
            this.tmpd[j]["Npro"] = row["Descripcion"].ToString();
            this.tmpd[j]["Npro"] = "1";
            this.tmpd[j]["Cost"] = row["Monto"].ToString();
            this.tmpd[j]["TP"] = row["Tipo"].ToString();

            int r = this.tmpd.FindIndex(x => x["Ipr"] == row["Id_Producto"].ToString());

            if (r > -1)
            {
                MessageBox.Show("Producto ya fue agregado, solo incremente la cantidad ...", "Advertencia");
                this.tmpd.RemoveAt(j);
                grdDetalle.Rows[i].Cells[1].Selected = true;
            }

            this.ctv();
        }

        private void grdDetalle_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdDetalle.CurrentCell.RowIndex;

            switch (grdDetalle.CurrentCell.ColumnIndex)
            {
                case 0:
                    break;
                case 1:
                    this.ctv();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }

        private void txtEmail_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtEmail.Enabled = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (this.lastKey == Keys.F12)
            {
                //.frmmessage.txtmessage.setfocus
                this.cad = txtEmail.Text;
                txtEmail.Text = this.cad.Length == 1 ? "" : cad.Substring(0, cad.Length - 1);
            }

            this.msg("E");
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtEmail.Enabled = true;
            }
        }
    }
}
