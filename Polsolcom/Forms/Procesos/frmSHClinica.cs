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
        Dictionary<string, string> rdvopen = new Dictionary<string, string>();
        Dictionary<string, string> bpac = new Dictionary<string, string>();
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
            string sr = lblSerie.Text;
            string cn = txtNroTicket.Text;
            string iu = Usuario.id_us;
            string io = Operativo.id_oper;
            string es = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();
            string ip2 = txtIdPaciente.Text;
            string dp = txtApePaterno.Text + " " + txtApeMaterno.Text + " " + txtNombre.Text;
            string fn = txtFechaNac.Text == General.emptyDate ? "" : txtFechaNac.Text;

            string sql = "Exec GenDocVen '" + fi + "','" + ff + "','" + iu + "','" + io + "','" + sr + "','" + dv + "','" + cn + "'";
            Conexion.ExecuteNonQuery(sql);
            General.matxt(es, ip2 + "\t" + dp + "\t" + fn + "\t" + (sr + "-" + cn) + "\t" + cmbMedico.SelectedValue.ToString().Trim().Replace(",", "") + "\t" + fi);
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
            string sr = lblSerie.Text;
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
            string sr = lblSerie.Text;
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
                lblSerie.Text = tick[i]["Serie"];
                txtNroTicket.Text = tick[i]["Nro_Ticket"];
                lblDigitador.Text = General.TradUser(tick[i]["Digitador"]);
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
                    Dictionary<string, string> producto = this.productos.Find(x => x["Id_Producto"] == idet["Id_Producto"]);

                    Dictionary<string, string> item = new Dictionary<string, string>();
                    item["Nrv"] = idet["Nro_Historia"];
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
            General.setAll<TextBox, bool>(this, "ReadOnly", true);
            General.setAll<ComboBox, bool>(this, "Enabled", false);
            General.setAll<Button, bool>(this, "Enabled", true);
            txtEmail.ReadOnly = true;

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
            string sr = lblSerie.Text;
            string dv = cmbTDoc.SelectedIndex == -1 ? "" : cmbTDoc.SelectedValue.ToString();

            string sql = "Exec GenDocVen '" + fi + "','" + ff + "','" + iu + "','" + io + "','" + sr + "','" + dv + "',''";
            Dictionary<string, string> talon = General.GetDictionary(sql);

            int n = (talon != null ? (int.Parse(talon["NCon"]) == 0 ? int.Parse(talon["NInicial"]) : int.Parse(talon["NCon"]) + 1) : -1);

            if (n == -1)
            {
                General.msg("No tiene rango de documentos de venta", "Advertencia");
                this.DialogResult = DialogResult.Cancel;
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
                    General.setAll<TextBox, bool>(this, "ReadOnly", false);
                    General.setAll<ComboBox, bool>(this, "Enabled", true);
                    General.setAll<Button, bool>(this, "Enabled", false);

                    cmbInstitucion.Enabled = txtNHP.ReadOnly = txtEmail.ReadOnly = false;
                    txtFechaEmision.ReadOnly = txtIdPaciente.ReadOnly = txtNroTicket.ReadOnly = txtNeto.ReadOnly = txtIGV.ReadOnly = txtTotal.ReadOnly = true;

                    this.uvt();

                    txtFechaNac.Text = General.emptyDate;
                    txtNeto.Text = txtIGV.Text = txtTotal.Text = "0.00";

                    if (General.rdvo(Usuario.id_us, "") == null)
                    {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }

                    if (this.rdvopen != null)
                    {
                        cmbTDoc.SelectedValue = this.rdvopen["DVenta"];
                        lblSerie.Text = this.rdvopen["Serie"];
                    }

                    lblDigitador.Text = Usuario.usuario;
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

        public bool exigep()
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Dato necesario, ingrese nombre", "Advertencia");
                txtNombre.Focus();
                return false;
            }

            if (txtApePaterno.Text.Length == 0 && txtApePaterno.Text.Length == 0)
            {
                MessageBox.Show("Los apellidos son necesarios ... ingrese al menos uno ... ", "Advertencia");
                txtApePaterno.Focus();
                return false;
            }

            if (txtApePaterno.Text.Length == 0)
            {
                if (MessageBox.Show("Falta apellido paterno...desea guardar asi... ?\tpara ello de Click en 'Si' y vuelva a guardar ...", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    txtApePaterno.Focus();
                }
                else
                {
                    txtApePaterno.Text = "";
                }
                return false;
            }

            if (txtApeMaterno.Text.Length == 0)
            {
                if (MessageBox.Show("Falta apellido materno...desea guardar asi... ?\tpara ello de Click en 'Si' y vuelva a guardar ...", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    txtApeMaterno.Focus();
                }
                else
                {
                    txtApeMaterno.Text = "";
                }
                return false;
            }

            if (txtSexo.Text.Length == 0)
            {
                MessageBox.Show("Dato necesario, ingrese sexo", "Advertencia");
                txtSexo.Focus();
                return false;
            }

            if (txtEdad.Text.Length == 0)
            {
                MessageBox.Show("Dato necesario, ingrese edad", "Advertencia");
                txtEdad.Focus();
                return false;
            }

            return true;
        }

        private void frmSHClinica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'institucionesDS.InstitucionLite' table. You can move, or remove it, as needed.
            this.institucionLiteTableAdapter.Fill(this.institucionesDS.InstitucionLite);
            cmbInstitucion.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'medicosDS.Medicos' table. You can move, or remove it, as needed.
            this.medicosTableAdapter.Fill(this.medicosDS.Medicos);
            cmbMedico.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'tablaTipoDS.DocVenta' table. You can move, or remove it, as needed.
            this.docVentaTableAdapter.Fill(this.tablaTipoDS.DocVenta);
            cmbTDoc.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'departamentosDS.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.departamentosDS.Departamentos);
            cmbDepartamento.SelectedIndex = -1;

            this.rdvopen = General.rdvo(Usuario.id_us, "");

            //Llenar detalle

            grdDetalle.Rows.Clear();
            lblDigitador.Text = Usuario.usuario;
            lblSerie.Text = this.rdvopen["Serie"];

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
            if (btnNuevo.Text == "&Nuevo Pac")
            {
                this.hi = DateTime.Today.ToShortDateString();
                int x = Conexion.ExecuteScalar<int>("SELECT Count(Name) AS C FROM master.dbo.sysdatabases WHERE Name = 'DNI'");

                if (x > 0)
                    if (MessageBox.Show("Desea realizar busqueda en base de datos general...?", "Busqueda Pacientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        this.hab(1);
                    }
                    else
                    {
                        /*
                        .frmbuscar.setall('Value', '', 'TextBox')
                        .odb = 1
                        .frmhistoria.hide
                        .frmbuscar.show
                        .frmbuscar.cmdaceptar.enabled = .F.
                         */
                    }
                else
                {
                    this.hab(1);
                }
            }
            else
            {
                if (decimal.Parse(txtTotal.Text) == 0)
                {
                    if (MessageBox.Show("No ha agregado productos, desea hacerlo...?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        this.cdv("0");
                        btnNuevo.Text = "&Nuevo Pac";
                        this.deh();
                    }
                    else
                    {
                        txtNombre.Focus();
                    }
                }
                else
                {
                    if (MessageBox.Show("Desea guardar los cambios...?", "Mensaje al Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (this.exigep())
                        {
                            this.vrv();
                            this.hom();
                            this.ddi();
                            this.arp();
                            btnDuplica.Enabled = true;
                        }
                    }
                    else
                    {
                        this.cdv("0");
                    }

                    btnNuevo.Text = "&Nuevo Pac";
                    this.deh();
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

        private void txtDNI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled == true)
            {
                txtDNI.ReadOnly = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "&Busca Pac")
            {
                this.hi = DateTime.Today.ToShortDateString();
                btnBuscar.Text = "&Grabar";
                /*
                 *.frmhistoria.hide
               .frmbuscar.show
               .odb = 0
               .frmbuscar.setall('Value', '', 'TextBox')
                */
                this.bpa();
            }
            else
            {
                if (decimal.Parse(txtTotal.Text) == 0)
                {
                    if (MessageBox.Show("No ha agregado productos ... desea hacerlo ?", "Mensaje al usuario", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        this.cdv("0");
                        btnBuscar.Text = "&Busca Pac";
                        this.deh();
                    }
                }
                else
                {
                    if (MessageBox.Show("Desea guardar los cambios ... ?", "Mensaje al usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.vrv();
                        this.vdp();
                        this.arv();
                    }
                    else
                    {
                        this.cdv("0");
                    }

                    btnBuscar.Text = "&Busca Pac";
                    this.deh();
                }
            }
        }

        private void btnDuplica_Click(object sender, EventArgs e)
        {
            this.hi = DateTime.Today.ToShortDateString();

            txtFechaEmision.Text = this.hi;
            lblDigitador.Text = Usuario.usuario;
            lblSerie.Text = this.rdvopen["Serie"];
            cmbTDoc.SelectedValue = rdvopen["DVenta"];
            cmbMVen.SelectedIndex = cmbEspecialidad.SelectedIndex = cmbMedico.SelectedIndex = -1;
            txtAutoriza.Text = "";

            btnBuscar.Text = "&Grabar";
            General.setAll<ComboBox, bool>(this, "Enabled", true);
            General.setAll<Button, bool>(this, "Enabled", false);
            btnBuscar.Enabled = true;
            cmbInstitucion.Enabled = false;

            txtNeto.Text = txtIGV.Text = txtTotal.Text = "0.00";
            cmbEspecialidad.Focus();

            this.gdv();
            this.uvt();
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
            if (cmbEspecialidad.SelectedIndex == -1)
            {
                btnAgregar.Enabled = false;
                cmbEspecialidad.Focus();
                MessageBox.Show("Seleccionar una especialidad...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                grddetalleC1.ReadOnly = grddetalleC2.ReadOnly = false;
                grddetalleC3.ReadOnly = this.cesp["Descripcion"] != "FARMACIA";
                Dictionary<string, string> item = new Dictionary<string, string>();
                item["Nrv"] = this.nrv;
                item["Npro"] = "";
                item["Tp"] = "";
                item["Cant"] = "";
                item["Cost"] = "";

                this.tmpd.Add(item);
                grdDetalle.Rows.Add(new[] { "", "", "", "" });
                btnQuitar.Enabled = true;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int index = grdDetalle.CurrentCell.RowIndex;

            this.tmpd.RemoveAt(index);
            grdDetalle.Rows.RemoveAt(index);
            this.ctv();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /*string sSQL = "";

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
            */
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

        private void txtDireccion_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtDireccion.ReadOnly = false;
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
                txtDireccion.ReadOnly = false;
            }
        }

        private void txtNroTicket_DoubleClick(object sender, EventArgs e)
        {
            if (txtNroTicket.ReadOnly)
            {
                txtNroTicket.ReadOnly = false;
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
                        this.nrv = Operativo.id_oper + DateTime.Parse(txtFechaEmision.Text).ToString("yyyymmdd").Substring(2) + (cmbTDoc.SelectedIndex == -1 ? "" : cmbTDoc.SelectedValue.ToString()) + lblSerie.Text + txtNroTicket.Text;
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
                        General.msg(ms, "Aviso al usuario");
                        General.chgst("Consultoios", ie, "0");
                        cmbEspecialidad.SelectedIndex = -1;
                        return;
                    }
                    else
                    {
                        ms = (ts - cs < 11 ? "Solo quedan " + (ts - cs).ToString() + ms : "");

                        if (ms.Contains("Solo"))
                        {
                            General.msg(ms, "Aviso al usuario");
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
                if (txtNroTicket.ReadOnly && (btnNuevo.Text == "&Grabar" || btnBuscar.Text == "&Grabar"))
                {
                    txtNroTicket.ReadOnly = false;
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
            if (txtNroTicket.ReadOnly == false && txtNroTicket.Text.Length > 0)
            {
                if (Usuario.tipo == "A")
                {
                    this.vdv(lblSerie.Text, txtNroTicket.Text/*, (cmbTDoc.SelectedIndex == 1 ? "" : cmbTDoc.SelectedValue.ToString())*/, (cmbMVen.SelectedIndex == 1 ? "" : cmbMVen.SelectedValue.ToString()));
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
                        this.vdv(lblSerie.Text, txtNroTicket.Text, cmbMVen.SelectedIndex == -1 ? "" : cmbMVen.SelectedValue.ToString());
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
                txtFechaEmision.ReadOnly = false;
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
                txtDNI.ReadOnly = false;
            }
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (txtDNI.ReadOnly == false)
            {
                if (txtDNI.Text.Length < 8 && this.DialogResult != DialogResult.Cancel)
                {
                    MessageBox.Show("Longitud de DNI no valida ... dato debe contener 8 digitos ... verifique", "Advertencia");
                    txtDNI.Focus();
                }
            }
        }

        private void txtFechaNac_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtFechaNac.ReadOnly = false;
            }
        }

        private void txtFechaNac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtFechaNac.ReadOnly = false;
            }
        }

        private void txtFechaNac_Leave(object sender, EventArgs e)
        {
            if (txtFechaNac.ReadOnly == false && txtFechaNac.Text != General.emptyDate)
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
                txtEdad.ReadOnly = false;
            }
        }

        private void txtEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtEdad.ReadOnly = false;
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.ReadOnly == false)
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
        }

        private void txtSexo_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtSexo.ReadOnly = false;
            }
        }

        private void txtSexo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtSexo.ReadOnly = false;
            }
        }

        private void txtSexo_Leave(object sender, EventArgs e)
        {
            if (txtSexo.ReadOnly == false)
            {
                string sex = txtSexo.Text;

                if (sex == "" || (sex != "M" && sex != "F"))
                {
                    MessageBox.Show("Dato no valido ingrese solo F ó M ...", "Advertencia ...");
                }
            }
        }

        private void txtTelefono_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtTelefono.ReadOnly = false;
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtTelefono.ReadOnly = false;
            }
        }

        private void txtAsegurado_DoubleClick(object sender, EventArgs e)
        {
            if (btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtAsegurado.ReadOnly = false;
            }
        }

        private void txtAsegurado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtAsegurado.ReadOnly = false;
            }
        }

        private void txtAsegurado_Leave(object sender, EventArgs e)
        {
            if (txtAsegurado.ReadOnly == false)
            {
                string seg = txtAsegurado.Text.ToUpper();

                if (seg != "S" && seg != "")
                {
                    MessageBox.Show("Dato no valido ingrese vacio ó S ...", "Advertencia ...");
                }
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
            if (cmbDepartamento.SelectedIndex != -1)
            {
                this.provinciasTableAdapter.Fill(this.provinciasDS.Provincias, cmbDepartamento.SelectedValue.ToString());
                cmbProvincia.SelectedIndex = -1;
                cmbDistrito.SelectedIndex = -1;
            }
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
            if (cmbProvincia.SelectedIndex != -1)
            {
                this.distritoTableAdapter.Fill(this.distritoDS.Distrito, cmbProvincia.SelectedValue.ToString());
                cmbDistrito.SelectedIndex = -1;
            }
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
                txtODoc.ReadOnly = false;
            }
        }

        private void txtODoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnNuevo.Enabled == false && btnBuscar.Enabled)
            {
                txtODoc.ReadOnly = false;
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
            if (btnBuscar.Text == "&Grabar" && txtNHP.ReadOnly)
            {
                txtNHP.ReadOnly = false;
            }
        }

        private void txtNHP_Leave(object sender, EventArgs e)
        {
            if (txtNHP.Text.Length > 0 && txtNHP.ReadOnly == false)
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
                    string sql2 = "Update Pacientes Set Nro_Historia='" + nh + "' Where Id_Paciente='" + ip + "'";
                    Conexion.ExecuteNonQuery(sql2);
                    MessageBox.Show("Operación ejecutada con éxito");
                }
            }
        }

        private void cmbTDoc_Leave(object sender, EventArgs e)
        {
            string mv = cmbMVen.SelectedIndex == -1 ? "" : cmbMVen.SelectedValue.ToString();
            string serie = Conexion.ExecuteScalar<string>("Select Serie From Talon Where Fecha=(Select Max(Fecha) From Talon Where MVenta='" + mv + "') And MVenta='" + mv + "'");
            lblSerie.Text = serie;
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
            /*
             WITH thisformset
               REPLACE tmpd.ipr WITH ALLTRIM(productos.id_producto)
               REPLACE tmpd.npro WITH ALLTRIM(productos.descripcion)
               REPLACE tmpd.cant WITH 1
               REPLACE tmpd.cost WITH productos.monto
               REPLACE tmpd.tp WITH ALLTRIM(productos.tipo)
               n = RECNO()
               COUNT FOR ALLTRIM(tmpd.ipr)=ALLTRIM(productos.id_producto) TO r
               IF r>1
                  MESSAGEBOX('Producto ya fue agregado, solo incremente la cantidad ...', 48, 'Advertencia')
                  SELECT tmpd
                  GOTO n
                  DELETE
                  .frmhistoria.grddetalle.column2.text1.setfocus
               ENDIF
               .ctv
            ENDWITH
             */
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
                txtEmail.ReadOnly = false;
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
                txtEmail.ReadOnly = false;
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
