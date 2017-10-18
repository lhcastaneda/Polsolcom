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
    public partial class frmMntVentas : Form
    {
        List<Dictionary<string, string>> vcab = new List<Dictionary<string, string>>();
        List<Dictionary<string, string>> npac = new List<Dictionary<string, string>>();
        public frmMntVentas()
        {
            InitializeComponent();
        }

        void pcl()
        {
            string ap = txtApePat.Text;
            string am = txtApeMat.Text;
            string nm = txtNombres.Text;
            string ip = txtIdPaciente.Text;
            string fe = txtFecEmi.Text;
            string ne = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();
            string td = cmbTipDoc.SelectedIndex == -1 ? "" : cmbTipDoc.SelectedValue.ToString();
            string sr = txtSerie.Text;
            string ni = txtNInicial.Text;
            string nf = txtNFinal.Text;

            General.setAll<TextBox, string>(this, "Text", "");
            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);

            txtFecEmi.Text = txtFecNac.Text = txtFecExt.Text = General.emptyDate;
            cmbMotAnul.SelectedIndex = -1;
            grdDet.Rows.Clear();
            txtApePat.Text = ap;
            txtApeMat.Text = am;
            txtNombres.Text = nm;
            txtIdPaciente.Text = ip;
            txtFecEmi.Text = fe;
            cmbEspecialidad.SelectedValue = ne;
            cmbTipDoc.SelectedValue = td;
            txtSerie.Text = sr;
            txtNInicial.Text = ni;
            txtNFinal.Text = nf;
        }

        void pfp<T>(T lp)
        {
            T xp = lp;

            string ip = lp is string ? xp.ToString() : txtIdPaciente.Text;
            string pt = txtApePat.Text;
            string mt = txtApeMat.Text;
            string nm = txtNombres.Text;

            if ((pt.Length + mt.Length + nm.Length) > 0)
            {
                string sql = General.DevuelveQueryPaciente(pt, mt, nm, "", ip, "", 2, 0);
                this.npac = General.GetDictionaryList(sql);
                General.FillListView(lstPacientes, this.npac, new[] {"Paciente", "Id_Paciente" });
            }
        }

        bool pfv<T>(T lp)
        {
            T xp = lp;
            string ip = xp is string ? xp.ToString() : "";
            string fi = txtFecEmi.Text;
            string ff = DateTime.Parse(txtFecEmi.Text).AddDays(1).ToShortDateString();
            string dv = cmbTipDoc.SelectedIndex == -1 ? "" : cmbTipDoc.SelectedValue.ToString();
            string sr = txtSerie.Text;
            string ni = txtNInicial.Text;
            string nf = txtNFinal.Text;
            string es = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();
            ni = ni.Length == 0 ? nf : ni;

            if(fi.Length == 0 && ip.Length == 0)
            {
                MessageBox.Show("Ingrese fecha de emision o seleccione paciente como minimo ...", "Advertencia");
                txtFecEmi.Focus();
                return false;
            }

            if (nf.Length == 0 && ip.Length == 0)
            {
                MessageBox.Show("Es necesario el numero final ...", "Advertencia");
                txtNFinal.Focus();
                return false;
            }

            lstVentas.Items.Clear();

            string sql = "Select D.Descripcion DVen,T.Serie+'-'+T.Nro_Ticket NDoc,Fecha_Emision,C.Descripcion Especialidad,Id_Paciente," + 
                "Digitador+Space(11) Digitador,Anulado,ForPago,Descuento,Moneda,Convenio,Nro_Historia " + 
                "From Tickets T Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " + 
                "Inner Join (Select Id_Tipo,Descripcion From TablaTipo Where Id_Tabla In (Select Id_Tipo From TablaTipo " + 
                "Where Descripcion='DOC_VENTA'))D On T.Dventa=D.Id_Tipo " + 
                "Where ";

            sql += (txtFecEmi.Text.Length == 0? "": "T.Fecha_Emision Between '" + fi + "' And '" + ff + "' ");

            if (cmbTipDoc.SelectedIndex > -1)
            {
                sql += sql.Contains("And") ? "And T.DVenta Like '" + dv + "' " : "T.DVenta Like '" + dv + "' ";
            }

            if (sr.Length > 0)
            {
                sql += sql.Contains("Like") || sql.Contains("And") ? "And T.Serie Like '" + sr + "' " : "And T.Serie Like '" + sr + "' ";
            }

            if (nf.Length > 0)
            {
                sql += sql.Contains("Like") || sql.Contains("And") ? "And Cast(T.Nro_Ticket As Int) Between '" + ni + "' And '" + nf  + "' " : "Cast(T.Nro_Ticket As Int) Between '" + ni + "' And '" + nf + "' ";
            }

            if (cmbEspecialidad.SelectedIndex > -1)
            {
                sql += sql.Contains("Like") || sql.Contains("And") ? "And T.Id_Consultorio Like '" + es + "' " : "And T.Id_Consultorio Like '" + es + "' ";
            }

            if (ip.Length > 0)
            {
                sql += sql.Contains("Like") || sql.Contains("And") ? "And T.Id_Paciente Like '" + ip + "' " : "And T.Id_Paciente Like '" + ip + "' ";
            }

            sql += "order by 3, 2";

            this.vcab = General.GetDictionaryList(sql);

            for (int i = 0; i < vcab.Count; i++)
            {
                vcab[i]["Digitador"] = General.TradUser(vcab[i]["Digitador"]);
            }

            General.FillListView(lstVentas, vcab, new[] { "DVen", "NDoc", "Fecha_Emision", "Especialidad" });

            rb0.Checked = true;
            optPanel.Enabled = btnEliminar.Enabled = false;
            return true;
        }

        public void phb(bool lm, string op)
        {
            txtApePat.Enabled = txtApeMat.Enabled = txtNombres.Enabled = txtIdPac.Enabled = txtFecEmi.Enabled = cmbEspecialidad.Enabled = cmbTipDoc.Enabled = txtSerie.Enabled = txtNInicial.Enabled = txtNFinal.Enabled = optPanel.Enabled = lstPacientes.Enabled = lstVentas.Enabled = lm;
            btnEliminar.Enabled = cmbAprDscto.Enabled = false;
            txtObservacion.Enabled = btnGrabar.Enabled = !lm;
            /*
            STORE IIF(op=1, 39, IIF(op=2, 24, IIF(op=3, 28, 41))) TO .txtobservacion.maxlength
            STORE IIF(op=1 .OR. op=3, 'Allt(Mot'+IIF(op=1, 'Anul', 'Ext')+'.Descripcion),Id_Tipo', '') TO .cmbmotanul.rowsource
            */

            if (rb0.Checked)
            {
                cmbMotAnul.Enabled = !lm;
            }

            if (rb1.Checked)
            {
                txtDscto.Enabled = !lm;
                //STORE lm TO .grddet.column5.readonly
                txtDscto.Text = "0.00";
                /*
                SELECT vdet
                REPLACE vdet.md WITH 1 ALL
                 */
            }

            if (rb2.Checked)
            {
                cmbOpExt.Enabled = cmbUsExt.Enabled = txtFecExt.Enabled = cmbMotAnul.Enabled = !lm;
                txtFecExt.Text = DateTime.Today.ToShortDateString();
                cmbOpExt.Text = Operativo.id_oper;
            }

        }

        private void gdvTipDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void frmMntVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                txtDscto.Focus();
            }
        }

        private void frmMntVentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaTipoDS.DocVenta' table. You can move, or remove it, as needed.
            this.docVentaTableAdapter.Fill(this.tablaTipoDS.DocVenta);
            cmbTipDoc.SelectedIndex = -1;

            this.especialidadTableAdapter.Fill(this.consultoriosDS.Especialidad, Operativo.id_oper);
            cmbTipDoc.SelectedIndex = -1;

            string sql = "Select Key_Pass Usuario,Id_Us From sysaccusers";
            List<Dictionary<string, string>> nusr = General.GetDictionaryList(sql);

            for (int i = 0; i < nusr.Count; i++)
            {
                nusr[i]["Usuario"] = General.TradUser(nusr[i]["Usuario"]);
            }

            nusr.OrderBy(x => x["Usuario"]);

            string sql2 = "Select LTrim(RTrim(Ape_Paterno))+' '+LTrim(RTrim(Ape_Materno))+' '+LTrim(RTrim(Nombres))Personal,Id_Personal " + 
                "From Personal Where Dscto='S' Union All " + 
                "Select Nom_Raz_Soc Personal,TInst+Id_Inst Id_Personal From Institucion Where TInst='S' Order By 1";
            List<Dictionary<string, string>> nper = General.GetDictionaryList(sql2);


        }

        private void txtNFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.pfv<string>("");
            }
        }

        private void txtApePat_TextChanged(object sender, EventArgs e)
        {
            this.pfp<string>("");
        }

        private void txtApeMat_TextChanged(object sender, EventArgs e)
        {
            this.pfp<string>("");
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            this.pfp<string>("");
        }

        private void lstVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(lstVentas);
            this.pcl();
            this.pfp(this.vcab[i]["Id_Paciente"]);

            int j = this.npac.FindIndex(x => x["Id_Paciente"] == this.vcab[i]["Id_Paciente"]);
            txtIdPaciente.Text = this.npac[j]["Id_Paciente"];
            txtPaciente.Text = this.npac[j]["Ape_Paterno"] + " " + this.npac[j]["Ape_Materno"] + " " + this.npac[j]["Nombre"];
            txtSexo.Text = this.npac[j]["Sexo"] == "M" ? "MASCULINO" : "FEMENINO";
            txtFecNac.Text = this.npac[j]["Fecha_Nac"];
            txtEdad.Text = this.npac[j]["Edad"];
            txtCajero.Text = this.vcab[i]["Digitador"];
            cmbFPago.Text = this.vcab[i]["ForPago"];
            cmbMoneda.Text = this.vcab[i]["Moneda"];

            if (this.vcab[i]["Descuento"].Substring(0, 1) == "A" && this.vcab[i]["Anulado"].Length == 1)
            {
                //.cmbmotanul.rowsource = 'Allt(MotAnul.Descripcion),Id_Tipo'
                cmbMotAnul.SelectedValue = this.vcab[i]["Descuento"].Substring(29, 1);
                txtObservacion.Text = this.vcab[i]["Descuento"].Substring(30, 40);
            }

            if (this.vcab[i]["Descuento"].Substring(0, 1) == "D")
            {
                cmbAprDscto.SelectedValue = this.vcab[i]["Descuento"].Substring(29, 9);
                txtDscto.Text = this.vcab[i]["Descuento"].Substring(38, 8);
                txtObservacion.Text = this.vcab[i]["Descuento"].Substring(46, 24);
            }

            if (this.vcab[i]["Descuento"].Substring(0, 1) == "E" && this.vcab[i]["Anulado"].Length == 10)
            {
                txtFecExt.Text = this.vcab[i]["Anulado"];
                cmbOpExt.SelectedValue = this.vcab[i]["Descuento"].Substring(29, 3);
                cmbUsExt.SelectedValue = this.vcab[i]["Descuento"].Substring(32, 9);
                //.cmbmotanul.rowsource = 'Allt(MotExt.Descripcion),Id_Tipo'
                cmbMotAnul.SelectedValue = this.vcab[i]["Descuento"].Substring(41, 1);
                txtObservacion.Text = this.vcab[i]["Descuento"].Substring(42, 28);
            }

            if (this.vcab[i]["Descuento"].Substring(0, 1) == "O")
            {
                txtObservacion.Text = this.vcab[i]["Descuento"].Substring(29, 41);
            }

            txtEstado.Text = (this.vcab[i]["Anulado"] == "" && this.vcab[i]["Descuento"] == "" ? "VENDIDO" : (this.vcab[i]["Anulado"].Length == 10 && this.vcab[i]["Descuento"].Substring(0, 1) == "E" ? "EXTORNO" : (this.vcab[i]["Anulado"] == "S" && this.vcab[i]["Anulado"].Substring(0, 1) == "A" ? "ANULADO" : "EDITADO")));
            txtUsFechMod.Text = (this.vcab[i]["Descuento"].Length > 0? General.TradUser(this.vcab[i]["Descuento"].Substring(1, 9)) + " - " + this.vcab[i]["Descuento"].Substring(10, 19): "");

            string nh = this.vcab[i]["Nro_Historia"];

            grdDet.Rows.Clear();

            string sql = "Select P.Descripcion Producto,Cantidad,D.Monto,D.Monto*Cantidad Total,0 MD,Pagado,Dscto,D.Id_Producto,'+'Nro_Historia,0.00 PD From Detalles D Inner Join Productos P On D.Id_Producto=P.Id_Producto Where Nro_Historia='" + nh + "'";
            List<Dictionary<string, string>> vdet = General.GetDictionaryList(sql);
            //Llenamos grilla
            //.grddet.recordsource = 'vdet'
            //SUM vdet.total TO .txttotal.value

            int c = Conexion.ExecuteScalar<int>("Select Count(*)C From Cab_Cie10 Where Nro_Historia='" + nh + "'");
            optPanel.Enabled = c == 0;
            btnEliminar.Enabled = c == 0 && (Usuario.tipo == "A" || Usuario.tipo == "O");
        }
    }
}
