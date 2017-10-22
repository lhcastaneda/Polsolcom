using System;
using System.Windows.Forms;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Connection;
using System.Collections.Generic;

namespace Polsolcom.Forms.Procesos
{
    public partial class frmSHClinica : Form
    {
        public delegate bool CpaDelegate(int spro, bool reload);
        public delegate bool HabDelegate(int xmd);
        public delegate void BusDelegate(Dictionary<string, string> bpac, int odb = 0);

        Keys lastKey;
        string cad = "";
        string xnrv = "";
        int nhp = 0;
        string nrc = "";
        string hi = "";
        Dictionary<string, string> rdvopen = new Dictionary<string, string>();
        Dictionary<string, string> bpac = new Dictionary<string, string>();
        Dictionary<string, string> igv = new Dictionary<string, string>();

        frmMessage frmMessage = new frmMessage();

        public frmSHClinica()
        {
            InitializeComponent();
        }

        public void adv()
        {
            int i = grdDetalle.CurrentCell.RowIndex;

            General.RemoveAll(grdDetalle, x => x["Id"].Length == 0);

            foreach (Dictionary<string, string> item in General.GetDictionaryList(grdDetalle))
            {
                if (item["Nrv"] == this.xnrv)
                {
                    string nh = this.xnrv;
                    string ip = item["Id"];
                    string pr = Decimal.Parse(item["Precio"]).ToString();
                    string can = item["Cantidad"];
                    Conexion.ExecuteNonQuery("Exec AddDetalle '" + nh + "','" + ip + "','" + pr + "','" + can + "'");
                }

                if (!this.cdv(this.xnrv)) return;
                this.tsg();
            }

            DateTime fe = DateTime.Parse(txtFechaEmision.Text);
            string fi = fe.ToShortDateString();
            string ff = fe.AddDays(1).ToShortDateString();
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
            string nh = this.xnrv;

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
            //this.noc = "NUEVO";
            this.adv();
            this.ghp();
        }

        public void arv()
        {
            string nh = this.xnrv;

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
            //this.noc = "CONTINUADOR";
            this.adv();
        }

        public bool cdv(string lr)
        {
            string nr = lr;
            grdDetalle.Rows.Clear();

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
                txtFechaEmision.Text = DateTime.Parse(tick[i]["Fecha_Emision"]).ToString(General.dateTimeFormat);
                cmbMVen.SelectedValue = tick[i]["ForPago"];
                cmbTDoc.SelectedValue = tick[i]["DVenta"];
                lblSerie.Text = tick[i]["Serie"];
                txtNroTicket.Text = tick[i]["Nro_Ticket"];
                lblDigitador.Text = General.TradUser(tick[i]["Digitador"]);
                txtIdPaciente.Text = tick[i]["Id_Paciente"];
                cmbEspecialidad.SelectedValue = tick[i]["Id_Consultorio"];
                cmbInstitucion.SelectedValue = tick[i]["Id_Inst"];
                cmbMedico.SelectedValue = tick[i]["CMP"];
                txtAutoriza.Text = "";
                if (tick[i]["Descuento"].Length > 0 && tick[i]["Descuento"].Substring(0, 1) == "D")
                {
                    string ads = tick[i]["Descuento"].Substring(29, 9);
                    string sql2 = "Select LTrim(RTrim(Ape_Paterno))+' '+LTrim(RTrim(Ape_Materno))+' '+LTrim(RTrim(Nombres))Personal," +
                        "Id_Personal From Personal Where Id_Personal='" + ads + "' Union All " +
                        "Select Nom_Raz_Soc Personal,TInst + Id_Inst Id_Personal From Institucion Where TInst + Id_Inst = '" + ads + "'";
                    Dictionary<string, string> fmd = General.GetDictionary(sql2);
                    txtAutoriza.Text = fmd["Personal"] + " (S/. " + tick[i]["Descuento"].Substring(38, 8) + ")";
                }

                nr = tick[i]["Nro_Historia"];

                string ne = tick[i]["Id_Consultorio"];
                string sql3 = "Select * From Productos Where Left(Id_Producto,6)='" + ne + "' And Estado='1'";
                //Llenamos productos
                this.productosTableAdapter.Fill(this.productosDS.Productos, ne);
                List<Dictionary<string, string>> productos = General.GetDictionaryList(sql3);

                string sql4 = "Select * From Detalles Where Nro_Historia='" + nr + "'";
                List<Dictionary<string, string>> cdet = General.GetDictionaryList(sql4);
                foreach (Dictionary<string, string> idet in cdet)
                {
                    Dictionary<string, string> producto = productos.Find(x => x["Id_Producto"] == idet["Id_Producto"]);
                    grdDetalle.Rows.Add(new[] { idet["Nro_Historia"], producto["Id_Producto"], producto["Descripcion"], producto["Tipo"], idet["Cantidad"], idet["Monto"], (int.Parse(idet["Cantidad"]) * decimal.Parse(idet["Monto"])).ToString() });
                }

                string ic = tick[i]["Id_Bus"];

                if (ic.Length > 0)
                {
                    this.nrc = Conexion.ExecuteScalar<string>("Select Bus From Buses Where Id_Bus='" + ic + "'");
                }

                this.xnrv = tick[i]["Nro_Historia"];
                if (!this.cpa(1, true)) return false;
                this.ctv();
            }
            else
            {
                General.setAll<TextBox, string>(groupBoxMain, "Text", "");
                General.setAll<MaskedTextBox, string>(groupBoxMain, "Text", "");
            }

            return true;
        }

        public bool cpa(int spro, bool reload = true)
        {
            if (reload)
            {
                string sql = "Select * From Pacientes Where Id_Paciente='" + txtIdPaciente.Text + "'";
                this.bpac = General.GetDictionary(sql);
            }

            if (spro == 0)
            {
                if (!this.hab(0)) return false;
                btnBuscar.Enabled = true;
                txtFechaEmision.Text = DateTime.Now.ToString(General.dateTimeFormat);
                cmbEspecialidad.Focus();
            }

            this.nhp = this.bpac["Nro_Historia"].Length == 0 ? 0 : int.Parse(this.bpac["Nro_Historia"]);

            txtNHP.Text = this.bpac["Nro_Historia"];
            txtNombre.Text = this.bpac["Nombre"];
            txtApePaterno.Text = this.bpac["Ape_Paterno"];
            txtApeMaterno.Text = this.bpac["Ape_Materno"];
            txtDNI.Text = this.bpac["DNI"];
            txtODoc.Text = this.bpac["ODoc"];
            txtFechaNac.Text = this.bpac["Fecha_Nac"].Length == 0 ? General.emptyDate : bpac["Fecha_Nac"];
            txtEdad.Text = this.bpac["Fecha_Nac"].Length == 0 ? this.bpac["Edad"] : General.getYearsUntilNow(txtFechaNac.Text).ToString();
            txtSexo.Text = this.bpac["Sexo"];
            txtTelefono.Text = this.bpac["Telefono"];
            txtDireccion.Text = this.bpac["Direccion"];
            txtAsegurado.Text = this.bpac["Asegurado"];
            cmbDepartamento.SelectedValue = this.bpac["Id_Distrito"].Length > 0? this.bpac["Id_Distrito"].Substring(0, 2): "";
            cmbDepartamento_SelectionChangeCommitted(cmbDepartamento, new EventArgs());
            cmbProvincia.SelectedValue = this.bpac["Id_Distrito"].Length > 0 ? this.bpac["Id_Distrito"].Substring(0, 4) : "";
            cmbProvincia_SelectionChangeCommitted(cmbProvincia, new EventArgs());
            cmbDistrito.SelectedValue = this.bpac["Id_Distrito"];
            txtEmail.Text = this.bpac["E_Mail"];

            return true;
        }

        public void ctv()
        {
            Dictionary<string, string> cesp = General.GetSelectedDictionary(cmbEspecialidad);
            Dictionary<string, string> dventa = General.GetSelectedDictionary(cmbTDoc);

            if (cesp != null)
            {
                txtTotal.Text = "0.00";

                for (int i = 0; i < grdDetalle.Rows.Count; i++)
                {
                    Dictionary<string, string> item = General.GetDictionary(grdDetalle, i);

                    if (item["Nrv"] == this.xnrv)
                    {
                        if (cesp["Descripcion"] == "FARMACIA")
                        {
                            item["Subtotal"] = item["Precio"];
                        }
                        else
                        {
                            item["Subtotal"] = (int.Parse(item["Cantidad"]) * decimal.Parse(item["Precio"])).ToString();
                        }

                        grdDetalle.Rows[i].Cells["Subtotal"].Value = item["Subtotal"];


                        txtTotal.Text = (decimal.Parse(txtTotal.Text) + decimal.Parse(item["Subtotal"])).ToString();
                        txtNeto.Text = dventa["Descripcion"] == "FACTURA" ? Math.Round(decimal.Parse(txtTotal.Text) / decimal.Parse(this.igv["Descripcion"]), 2).ToString() : "0.00";
                        txtIGV.Text = dventa["Descripcion"] == "FACTURA" ? (Decimal.Parse(txtTotal.Text) - decimal.Parse(txtNeto.Text)).ToString() : "0.00";
                        txtSon.Text = General.NumeroTexto(txtTotal.Text);
                    }
                }
            }
        }

        public bool ddi()
        {
            if (txtDNI.Text.Length > 0)
            {
                string ldni = txtDNI.Text;
                string sql = "Select Nombre,Ape_Paterno,Ape_Materno,DNI From Pacientes Where DNI='" + ldni + "'";

                Dictionary<string, string> doc = General.GetDictionary(sql);

                if (doc != null && doc["DNI"] == ldni)
                {
                    string dupl = doc["Nombre"] + " " + doc["Ape_Paterno"] + " " + doc["Ape_Materno"];
                    MessageBox.Show("DNI pertenece a " + dupl + " verifique y corrija los datos ...", "Advertencia");
                    txtDNI.Focus();
                    return false;
                }
            }

            return true;
        }

        public void deh()
        {
            General.setAll<TextBox, bool>(groupBoxMain, "ReadOnly", true);
            General.setAll<MaskedTextBox, bool>(groupBoxMain, "ReadOnly", true);
            General.setAll<ComboBox, bool>(groupBoxMain, "Enabled", false);
            General.setAll<Button, bool>(this, "Enabled", true);
            txtEmail.ReadOnly = true;

            chkInst.Enabled = btnInst.Enabled = btnAgregar.Enabled = btnQuitar.Enabled = false;

            grdDetalle.ReadOnly = true;

            if (txtIdPaciente.Text.Length == 0)
            {
                btnDuplica.Enabled = btnImprimir.Enabled = false;
            }
        }

        public bool gdv()
        {
            this.les();

            DateTime fe = new DateTime();
            bool result = DateTime.TryParse(txtFechaEmision.Text, out fe);
            string fi = !result ? "" : fe.ToShortDateString();
            string ff = !result ? "" : fe.AddDays(1).ToShortDateString();
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
                if (!this.vdv(sr, n.ToString(), dv)) return false;
                txtNroTicket.Text = n.ToString();
            }

            return true;
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


                    /*foreach (Producto item in this.productos)
                {
                     DIMENSION a1(1)
                     SELECT tipo FROM Productos WHERE id_producto=tmpd.ipr INTO ARRAY a1
                     IF a1(1)='C'
                        tp = 'C'
                        EXIT
                     ELSE
                        tp = '*'
                     ENDIF
                       }
                     */


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

                    txtNHP.Text = int.Parse(res["nhp"]) > 0 ? res["nhp"] : txtNHP.Text;
                    this.nhp = int.Parse(res["nhp"]);
                }
            }
        }

        public bool hab(int xmd)
        {
            switch (xmd)
            {
                case 0:
                    General.setAll<TextBox, string>(groupBoxMain, "Text", "");
                    General.setAll<MaskedTextBox, string>(groupBoxMain, "Text", "");
                    General.setAll<ComboBox, int>(groupBoxMain, "SelectedIndex", -1);
                    General.setAll<TextBox, bool>(groupBoxMain, "ReadOnly", false);
                    General.setAll<MaskedTextBox, bool>(groupBoxMain, "ReadOnly", false);
                    General.setAll<ComboBox, bool>(groupBoxMain, "Enabled", true);
                    General.setAll<Button, bool>(this, "Enabled", false);

                    cmbInstitucion.Enabled = /*txtNHP.ReadOnly = */txtEmail.ReadOnly = false;
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

                    if (!this.hab(0)) return false;
                    btnNuevo.Enabled = true;
                    btnNuevo.Text = "&Grabar";
                    txtFechaEmision.Text = DateTime.Now.ToString(General.dateTimeFormat);

                    cmbDepartamento.SelectedValue = Operativo.id_distrito.Substring(0, 2);
                    cmbDepartamento_SelectionChangeCommitted(cmbDepartamento, new EventArgs());
                    cmbProvincia.SelectedValue = Operativo.id_distrito.Substring(0, 4);
                    cmbProvincia_SelectionChangeCommitted(cmbProvincia, new EventArgs());
                    cmbDistrito.SelectedValue = Operativo.id_distrito;

                    if (!this.gdv()) return false;

                    grdDetalle.Rows.Clear();
                    break;
            }

            return true;
        }

        public void bus(Dictionary<string, string> xpac, int odb)
        {
            this.bpac = xpac;
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

                if (homon != null && (homon["Nombre"] + homon["Ape_Paterno"] + homon["Ape_Materno"]) == (nom + apa + ama))
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
            this.consultoriosSHClinicaTableAdapter.Fill(this.consultoriosDS.ConsultoriosSHClinica, Operativo.id_oper);
            cmbEspecialidad.SelectedIndex = -1;

        }

        public void msg(string op)
        {
            switch (op)
            {
                case "P":
                    frmMessage.lblMessage.Text = txtNombre.Text + " " + txtApePaterno.Text + " " + txtApeMaterno.Text;
                    break;
                case "D":
                    frmMessage.lblMessage.Text = txtDireccion.Text;
                    break;
                case "E":
                    frmMessage.lblMessage.Text = txtEmail.Text;
                    break;
            }
        }

        public void tsg()
        {
            if (this.hi.Length > 0)
            {
                string nr = this.xnrv;
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
            sql += (txtApePaterno.Text != pacient["Ape_Paterno"] ? "Ape_Paterno='" + txtApePaterno.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtApeMaterno.Text != pacient["Ape_Materno"] ? "Ape_Materno='" + txtApeMaterno.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtDNI.Text != pacient["DNI"] ? "DNI='" + txtDNI.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtODoc.Text != pacient["ODoc"] ? "ODoc='" + txtODoc.Text + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtFechaNac.Text != pacient["Fecha_Nac"] && txtFechaNac.Text.Length > 0 ? "Fecha_Nac='" + txtFechaNac.Text + "'" : "");
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
            sql += (cmbDistrito.SelectedValue.ToString() != pacient["Id_Distrito"] ? "Id_Distrito='" + cmbDistrito.SelectedValue.ToString() + "'" : "");
            sql += (sql.Substring(sql.Length - 1) == "," ? "" : (sql.Contains("=") ? "," : ""));
            sql += (txtEmail.Text != pacient["E_Mail"] ? "E_Mail='" + txtEmail.Text + "'" : "");

            sql = (sql.Substring(sql.Length - 1) == "," ? sql.Substring(0, sql.Length - 1) : sql) + (sql.Contains("=") ? " Where Id_Paciente='" + ip + "'" : "");

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
            frmMessage.Show();

            this.igv = General.GetIGV();
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
                        if (!this.hab(1)) return;
                    }
                    else
                    {
                        frmBuscar frmBuscar = new frmBuscar(1);
                        frmBuscar.CpaCallback += new CpaDelegate(this.cpa);
                        frmBuscar.HabCallback += new HabDelegate(this.hab);
                        frmBuscar.BusCallback += new BusDelegate(this.bus);
                        frmBuscar.FormClosed += new FormClosedEventHandler(frmBuscar_FormClosed);
                        frmBuscar.Show();
                        this.Hide();
                    }
                else
                {
                    if (!this.hab(1)) return;
                }

                txtDNI.Focus();
            }
            else
            {
                if (decimal.Parse(txtTotal.Text) == 0)
                {
                    if (MessageBox.Show("No ha agregado productos, desea hacerlo...?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        if (!this.cdv("0")) return;
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
                        if (!this.exigep()) return;
                        if (!this.vrv()) return;
                        if (!this.hom()) return;
                        if (!this.ddi()) return;
                        this.arp();
                        btnDuplica.Enabled = true;

                    }
                    else
                    {
                        if (!this.cdv("0")) return;
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

            if (e.KeyCode == Keys.F5 && this.xnrv != "")
            {
                if (!this.cdv(this.xnrv)) return;
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

                frmBuscar frmBuscar = new frmBuscar(0);
                frmBuscar.CpaCallback += new CpaDelegate(this.cpa);
                frmBuscar.HabCallback += new HabDelegate(this.hab);
                frmBuscar.BusCallback += new BusDelegate(this.bus);
                frmBuscar.FormClosed += new FormClosedEventHandler(frmBuscar_FormClosed);
                frmBuscar.Show();
                this.Hide();
            }
            else
            {
                if (decimal.Parse(txtTotal.Text) == 0)
                {
                    if (MessageBox.Show("No ha agregado productos ... desea hacerlo ?", "Mensaje al usuario", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        if (!this.cdv("0")) return;
                        btnBuscar.Text = "&Busca Pac";
                        this.deh();
                    }
                }
                else
                {
                    if (MessageBox.Show("Desea guardar los cambios ... ?", "Mensaje al usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (!this.vrv()) return;
                        this.vdp();
                        this.arv();
                    }
                    else
                    {
                        if (!this.cdv("0")) return;
                    }

                    btnBuscar.Text = "&Busca Pac";
                    this.deh();
                }
            }
        }

        private void frmBuscar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((frmBuscar)sender).DialogResult == DialogResult.OK)
            {
                if (((frmBuscar)sender).odb == 0)
                {
                    txtIdPaciente.Text = this.bpac["Id_Paciente"];
                }
                else
                {
                    btnNuevo.Enabled = true;
                    btnNuevo.Text = "&Grabar";
                    txtFechaEmision.Text = DateTime.Now.ToString(General.dateTimeFormat);
                    cmbDepartamento.SelectedValue = this.bpac["Id_Old"].Length > 0 ? this.bpac["Id_Old"].Substring(0, 2) : "";
                    cmbDepartamento_SelectionChangeCommitted(cmbDepartamento, new EventArgs());
                    cmbProvincia.SelectedValue = this.bpac["Id_Old"].Length > 0 ? this.bpac["Id_Old"].Substring(0, 4) : "";
                    cmbProvincia_SelectionChangeCommitted(cmbProvincia, new EventArgs());
                    cmbDistrito.SelectedValue = this.bpac["Id_Old"];
                    txtSexo.Text = this.bpac["Sexo"] == "1" ? "M" : "F";
                    txtNombre.Text = this.bpac["Nombres"];
                    txtApePaterno.Text = this.bpac["Ape_Pat"];
                    txtApeMaterno.Text = this.bpac["Ape_Mat"];
                    txtDNI.Text = this.bpac["DNI"];
                    //La fecha es un número, por lo tanto es indescifrable
                    //txtFechaNac.Text = DateTime.Parse(this.bpac["Fec_Nac"]).ToShortDateString();
                    //txtEdad.Text = General.getYearsUntilNow(this.bpac["Fec_Nac"]).ToString();
                    txtDireccion.Focus();
                }

                lblDigitador.Text = Usuario.usuario;
                lblSerie.Text = this.rdvopen["Serie"];
                grdDetalle.Rows.Clear();
                this.gdv();
            }
            else
            {
                btnBuscar.Text = "&Busca Pac";
            }

            this.Show();
            txtDNI.Focus();
        }

        private void btnDuplica_Click(object sender, EventArgs e)
        {
            grdDetalle.Rows.Clear();

            this.hi = DateTime.Now.ToString(General.dateTimeFormat);

            txtFechaEmision.Text = this.hi;
            lblDigitador.Text = Usuario.usuario;
            lblSerie.Text = this.rdvopen["Serie"];
            cmbTDoc.SelectedValue = rdvopen["DVenta"];
            cmbMVen.SelectedIndex = cmbEspecialidad.SelectedIndex = cmbMedico.SelectedIndex = -1;
            txtAutoriza.Text = "";

            btnBuscar.Text = "&Grabar";
            General.setAll<ComboBox, bool>(groupBoxMain, "Enabled", true);
            General.setAll<Button, bool>(this, "Enabled", false);
            btnBuscar.Enabled = true;
            cmbInstitucion.Enabled = false;

            txtNeto.Text = txtIGV.Text = txtTotal.Text = "0.00";
            cmbEspecialidad.Focus();

            if (!this.gdv()) return;
            this.uvt();
        }

        private void btnBuscat_Click(object sender, EventArgs e)
        {
            General.setAll<TextBox, string>(groupBoxMain, "Text", "");
            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);

            frmBuscaT frmBuscaT = new frmBuscaT();
            frmBuscaT.FormClosed += new FormClosedEventHandler(frmBuscat_FormClosed);
            frmBuscaT.Show();
            this.Hide();
        }

        private void frmBuscat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((frmBuscaT)sender).DialogResult == DialogResult.OK)
            {
                Dictionary<string, string> bust = ((frmBuscaT)sender).bust;
                this.cdv(bust["Nro_Historia"]);
                btnDuplica.Enabled = btnImprimir.Enabled = true;
            }

            this.Show();
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
                Dictionary<string, string> cesp = General.GetSelectedDictionary(cmbEspecialidad);

                Id.ReadOnly = Cantidad.ReadOnly = false;
                Precio.ReadOnly = cesp["Descripcion"] != "FARMACIA";
                grdDetalle.Rows.Add(new string[] { this.xnrv, "", "", "", "0", "0", "0" });
                btnQuitar.Enabled = true;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (grdDetalle.CurrentCell != null)
            {
                int index = grdDetalle.CurrentCell.RowIndex;
                grdDetalle.Rows.RemoveAt(index);
                this.ctv();
            }
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
                frmMessage.lblMessage.Focus();
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
                grdDetalle.Rows.Clear();
            }
        }

        private void cmbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ie = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();

            if (ie.Length > 0 && cmbEspecialidad.Enabled)
            {
                Dictionary<string, string> cesp = General.GetSelectedDictionary(cmbEspecialidad);

                if (Usuario.tipo == "A" && cesp["Descripcion"] == "FARMACIA")
                {
                    int c = Conexion.ExecuteScalar<int>("Select ISULL(Max(Cast(Nro_Ticket As Int)), 0) C From Tickets Where Id_Consultorio In (Select Id_Consultorio From " +
"Consultorios Where Descripcion Like '%FARMACIA%' And Left(Id_Consultorio,3)='" + Operativo.id_oper + "')");

                    this.xnrv = Operativo.id_oper + DateTime.Parse(txtFechaEmision.Text).ToString("yyyymmdd").Substring(2) + (c + 1).ToString();
                    txtNroTicket.Text = this.xnrv.Substring(9, 19);
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
                        this.xnrv = Operativo.id_oper + DateTime.Parse(txtFechaEmision.Text).ToString("yyyymmdd").Substring(2) + (cmbTDoc.SelectedIndex == -1 ? "" : cmbTDoc.SelectedValue.ToString()) + lblSerie.Text + txtNroTicket.Text;
                    }
                }

                DateTime fe = DateTime.Parse(txtFechaEmision.Text);
                string tr = "";
                string fi = "";

                if (cesp["C"] != "")
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

                    fi = (cesp["C"] == "0" ? General.FormatDateTime(DateTime.Parse(fe.ToShortDateString() + " " + fi)) : General.FormatDateTime(fe));
                    string sql2 = "Select Case When Sum(Cantidad) Is Null Then 0 Else Sum(Cantidad) End cs " +
                        "From Tickets T Inner Join Detalles D On T.Nro_Historia=D.Nro_Historia " +
                        "Where Fecha_Emision Between '" + fi + "' And '" + General.FormatDateTime(fe) + "' And Id_Consultorio='" + ie + "' And Anulado=''";
                    int cs = Conexion.ExecuteScalar<int>(sql2);
                    int ts = cesp["C"] == "0" ? int.Parse(cesp[tr]) : (int.Parse(cesp["M"]) + int.Parse(cesp["T"]) + int.Parse(cesp["N"]) + int.Parse(cesp["A"]));
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

                //Limpiamos items
                grdDetalle.Rows.Clear();

                //Llenamos productos
                this.productosTableAdapter.Fill(this.productosDS.Productos, ie);

                txtTotal.Text = "0.00";
                chkInst.Enabled = cesp["Tipo"] == "C";
                chkInst.Checked = cesp["Tipo"] == "C";
                btnInst.Enabled = cesp["Tipo"] == "C";
                cmbInstitucion.Enabled = cesp["Tipo"] == "C";
                if (cesp["Tipo"] == "C")
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

                    grdDetalle.Rows.Clear();
                }
            }
        }

        private void txtNroTicket_Leave(object sender, EventArgs e)
        {
            if (txtNroTicket.ReadOnly == false && txtNroTicket.Text.Length > 0)
            {
                if (Usuario.tipo == "A")
                {
                    if (!this.vdv(lblSerie.Text, txtNroTicket.Text/*, (cmbTDoc.SelectedIndex == 1 ? "" : cmbTDoc.SelectedValue.ToString())*/, (cmbMVen.SelectedIndex == 1 ? "" : cmbMVen.SelectedValue.ToString()))) return;
                }
                else
                {
                    DateTime fe = DateTime.Parse(txtFechaEmision.Text);
                    string fi = fe.ToShortDateString();
                    string ff = fe.AddDays(1).ToShortDateString();
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
                        if (!this.vdv(lblSerie.Text, txtNroTicket.Text, cmbMVen.SelectedIndex == -1 ? "" : cmbMVen.SelectedValue.ToString())) return;
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
            if (!(this.lastKey == Keys.None || this.lastKey == Keys.Delete || this.lastKey == Keys.Insert || this.lastKey == Keys.F1 || this.lastKey == Keys.Space || char.IsLetter((char)this.lastKey) || this.lastKey == Keys.Back))
            {
                this.cad = txtNombre.Text;
                txtNombre.Text = cad.Length == 1 ? "" : cad.Substring(0, cad.Length - 1);
                txtNombre.Select();
            }

            if (this.lastKey == Keys.F12)
            {
                frmMessage.lblMessage.Focus();
            }

            this.msg("P");
        }

        private void txtApePaterno_TextChanged(object sender, EventArgs e)
        {
            if (!(this.lastKey == Keys.None || this.lastKey == Keys.Delete || this.lastKey == Keys.Insert || this.lastKey == Keys.F1 || this.lastKey == Keys.Space || char.IsLetter((char)this.lastKey) || this.lastKey == Keys.Back))
            {
                this.cad = txtApePaterno.Text;
                txtApePaterno.Text = cad.Length == 1 ? "" : cad.Substring(0, cad.Length - 1);
                txtApePaterno.Select();
            }

            if (this.lastKey == Keys.F12)
            {
                frmMessage.lblMessage.Focus();
            }

            this.msg("P");
        }

        private void txtApeMaterno_TextChanged(object sender, EventArgs e)
        {
            if (!(this.lastKey == Keys.None || this.lastKey == Keys.Delete || this.lastKey == Keys.Insert || this.lastKey == Keys.F1 || this.lastKey == Keys.Space || char.IsLetter((char)this.lastKey) || this.lastKey == Keys.Back))
            {
                this.cad = txtApeMaterno.Text;
                txtApeMaterno.Text = cad.Length == 1 ? "" : cad.Substring(0, cad.Length - 1);
                txtApeMaterno.Select();
            }

            if (this.lastKey == Keys.F12)
            {
                frmMessage.lblMessage.Focus();
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
                    txtFechaNac.Focus();
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
                    txtEdad.Focus();
                    return;
                }

                if (int.Parse(txtEdad.Text) < 0)
                {
                    MessageBox.Show("Corregir los datos ... la edad no puede ser un número negativo ...", "Advertencia...");
                    txtEdad.Focus();
                    return;
                }

                if (int.Parse(txtEdad.Text) > 100)
                {
                    MessageBox.Show("Verifique los datos ... la edad del paciente es mayor a 100 años?", "Advertencia...");
                    txtEdad.Focus();
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
                    txtSexo.Focus();
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
                    txtAsegurado.Focus();
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
            frmBuscaI frmBuscaI = new frmBuscaI();
            frmBuscaI.FormClosed += new FormClosedEventHandler(frmBuscai_FormClosed);
            frmBuscaI.Show();
            this.Hide();
        }

        private void frmBuscai_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (((frmBuscaI)sender).DialogResult == DialogResult.OK)
            {
                Dictionary<string, string> binst = ((frmBuscaI)sender).binst;
                cmbInstitucion.SelectedValue = binst["IdI"];
            }

            cmbMedico.Focus();
            this.Show();
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
            this.ctv();
        }

        private void grdDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int i = grdDetalle.CurrentCell.RowIndex;
            int j = grdDetalle.CurrentCell.ColumnIndex;
            string columnName = grdDetalle.Columns[j].Name;

            if (columnName == "Id")
            {
                ComboBox combo = (ComboBox)e.Control;
                if ((combo != null))
                {
                    combo.SelectionChangeCommitted -= new EventHandler(cmbProducto_SelectionChangeCommitted);
                    combo.SelectionChangeCommitted += new EventHandler(cmbProducto_SelectionChangeCommitted);
                    combo.Click -= new EventHandler(cmbProducto_Enter);
                    combo.Click += new EventHandler(cmbProducto_Enter);
                }
            }
        }

        private void cmbProducto_SelectionChangeCommitted(System.Object sender, System.EventArgs e)
        {
            if (grdDetalle.CurrentCell.ReadOnly == false)
            {
                ComboBox cmbProducto = (ComboBox)grdDetalle.EditingControl;

                int i = grdDetalle.CurrentCell.RowIndex;
                int j = cmbProducto.SelectedIndex;

                List<Dictionary<string, string>> productos = General.GetDictionaryList((ComboBox)grdDetalle.EditingControl);

                grdDetalle.Rows[i].Cells["Id"].Value = productos[j]["Id_Producto"];
                grdDetalle.Rows[i].Cells["Descripcion"].Value = productos[j]["Descripcion"];
                grdDetalle.Rows[i].Cells["Tipo"].Value = productos[j]["Tipo"];
                grdDetalle.Rows[i].Cells["Cantidad"].Value = 1;
                grdDetalle.Rows[i].Cells["Precio"].Value = productos[j]["Monto"];
                grdDetalle.Rows[i].Cells["SubTotal"].Value = (int.Parse(grdDetalle.Rows[i].Cells["Cantidad"].Value.ToString()) * decimal.Parse(productos[j]["Monto"])).ToString();

                int r = General.GetDictionaryList(grdDetalle).FindAll(x => x["Id"] == productos[j]["Id_Producto"]).Count;

                if (r > 1)
                {
                    MessageBox.Show("Producto ya fue agregado, solo incremente la cantidad ...", "Advertencia");
                    grdDetalle.Rows.RemoveAt(i);
                }

            }
        }

        private void cmbProducto_Enter(System.Object sender, System.EventArgs e)
        {
            (sender as ComboBox).DroppedDown = true;
        }

        private void grdDetalle_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdDetalle.CurrentCell.RowIndex;
            int j = grdDetalle.CurrentCell.ColumnIndex;
            string columnName = grdDetalle.Columns[j].Name;

            if (columnName == "Id")
            {
                this.ctv();
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
                frmMessage.lblMessage.Focus();
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

        private void grdDetalle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int i = grdDetalle.CurrentCell.RowIndex;
            int j = grdDetalle.CurrentCell.ColumnIndex;
            string columnName = grdDetalle.Columns[j].Name;

            switch (columnName)
            {
                case "Cantidad":

                    if (!grdDetalle.CurrentCell.ReadOnly)
                    {
                        if (int.Parse(grdDetalle.CurrentCell.Value.ToString()) < 1)
                        {
                            grdDetalle.CurrentCell.Value = "1";
                        }

                        if (int.Parse(grdDetalle.CurrentCell.Value.ToString()) > 9)
                        {
                            if (MessageBox.Show("La cantidad ingresada de " + grdDetalle.CurrentCell.Value.ToString() + ", es correcta? ... ?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                e.Cancel = true;
                                //grdDetalle.EndEdit();
                            }
                        }
                    }
                    break;
            }


        }

        private void frmSHClinica_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMessage.Close();
        }
    }
}
