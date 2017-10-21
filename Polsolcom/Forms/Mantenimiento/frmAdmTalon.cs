using CrystalDecisions.CrystalReports.Engine;
using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Data;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
    public partial class frmAdmTalon : Form
    {
        public List<Dictionary<string, string>> usTal = new List<Dictionary<string, string>>();
        public List<Dictionary<string, string>> rangos = new List<Dictionary<string, string>>();
        public int index = -1;
        ReportDocument rpt = new ReportDocument();

        public frmAdmTalon()
        {
            InitializeComponent();
        }

        string getSql(string fi, string ff, string us, string op)
        {
            string sql = "Select Usuario+Space(11) Us,Fecha,D.Descripcion TDVen,Serie,NInicial,NFinal,NCon," +
"O.Descripcion Operativo,T.Id_Oper,DVenta,Usuario " +
"From Talon T Inner Join Operativo O On T.Id_Oper=O.Id_Oper Inner Join (Select Id_Tipo,Descripcion From " +
"TablaTipo Where Id_Tabla In(Select Id_Tipo From TablaTipo Where Descripcion='DOC_VENTA' And Id_Tabla='0'))D " +
"On T.DVenta=D.Id_Tipo " +
"Where Fecha Between '" + fi + "' And '" + ff + "' And T.Id_Oper Like '" + op + "%'";
            sql += (us.Length > 0 ? "And Usuario Like '" + us + "' " : "");
            sql += "Order By Cast(Convert(Varchar(10),Fecha,103)As DateTime),2 Asc,1";

            return sql;
        }

        public void ejecon()
        {
            string fi = dtpicFInicial.Value.ToShortDateString();
            string ff = dtpFFinal.Value.ToShortDateString();
            string us = cmbUsuario.SelectedIndex == -1 ? "" : this.usTal[cmbUsuario.SelectedIndex]["Id_Us"];
            string op = cmbOperativo.SelectedIndex == -1 ? "" : cmbOperativo.SelectedValue.ToString();

            string sql = getSql(fi, ff, us, op);

            this.rangos = General.GetDictionaryList(sql);

            for (int i = 0; i < this.rangos.Count; i++)
            {
                this.rangos[i]["Us"] = General.TradUser(this.rangos[i]["Us"]);
            }

            General.FillListView(lstRangos, this.rangos, new[] { "Us", "Fecha", "TDVen", "Serie", "NInicial", "NFinal", "NCon", "Operativo" });
            //
            if (lstRangos.Items.Count > 0 && this.index > -1)
            {
                lstRangos.Select();
                lstRangos.EnsureVisible(this.index);
                lstRangos.Items[this.index].Selected = true;
                lstRangos.Items[this.index].Focused = true;
                lstRangos.Items[this.index].EnsureVisible();
            }
        }

        public void guarda(bool lp)
        {
            if (cmbUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione usuario antes de guardar ...", "Aviso al usuario");
                cmbUsuario.Focus();
                return;
            }

            if (cmbOperativo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione operativo  antes de guardar ...", "Aviso al usuario");
                cmbOperativo.Focus();
                return;
            }

            if (txtSerie.Text.Length == 0 || int.Parse(txtSerie.Text) == 0)
            {
                MessageBox.Show("Ingrese serie antes de guardar ...", "Aviso al usuario");
                txtSerie.Focus();
                return;
            }

            if (txtNInicial.Text.Length == 0 || int.Parse(txtNInicial.Text) == 0)
            {
                MessageBox.Show("Ingrese numero inicial antes de guardar ...", "Aviso al usuario");
                txtNInicial.Focus();
                return;
            }

            if (txtNFinal.Text.Length == 0 || int.Parse(txtNFinal.Text) == 0)
            {
                MessageBox.Show("Ingrese numero final antes de guardar ...", "Aviso al usuario");
                txtNInicial.Focus();
                return;
            }

            if (int.Parse(txtNFinal.Text) < int.Parse(txtNInicial.Text))
            {
                MessageBox.Show("Numero final no puede ser menor que el inicial ...", "Aviso al usuario");
                txtNFinal.Focus();
                return;
            }

            string fr = DateTime.Today.ToShortDateString();
            string us = cmbUsuario.SelectedIndex == -1 ? "" : this.usTal[cmbUsuario.SelectedIndex]["Id_Us"];
            string sr = txtSerie.Text;
            string ni = txtNInicial.Text;
            string nf = txtNFinal.Text;
            string op = cmbOperativo.SelectedIndex == -1 ? "" : cmbOperativo.SelectedValue.ToString();
            string td = cmbDVenta.SelectedIndex == -1 ? "" : cmbDVenta.SelectedValue.ToString();
            string cn = txtNCon.Text;

            string sql = "Select * From Talon Where Cast('" + ni + "' As Int) Between Cast(NInicial As Int) And Cast(NFinal As Int) And Serie='" + sr + "' And DVenta='" + td + "'";
            Dictionary<string, string> talo = General.GetDictionary(sql);

            if (talo != null)
            {
                MessageBox.Show("El rango de " + ni + " a " + talo["NFinal"] + " serie " + talo["Serie"] + " corresponde a " + General.TradUser(talo["Usuario"]) + " con fecha " + talo["Fecha"] + " modifique Rango", "Error");

                if (lp)
                {
                    return;
                }
                else
                {
                    if (MessageBox.Show("Desea reemplazar los valores existentes ...", "Modificando rangos ...", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            string sql2 = "Select * From Talon Where Cast('" + nf + "' As Int) Between Cast(NInicial As Int) And Cast(NFinal As Int) And Serie='" + sr + "' And DVenta='" + td + "'";
            talo = General.GetDictionary(sql2);

            if (talo != null)
            {
                MessageBox.Show("El rango de " + talo["NInicial"] + " a " + nf + " serie " + talo["Serie"] + " corresponde a " + General.TradUser(talo["Usuario"]) + " con fecha " + talo["Fecha"] + " modifique Rango", "Error");

                if (lp)
                {
                    return;
                }
                else
                {
                    if (MessageBox.Show("Desea reemplazar los valores existentes ...", "Modificando rangos ...", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            string sql3 = "";
            if (lp)
            {
                sql3 = "Insert Into Talon Values ('" + us + "','" + fr + "','" + ni + "','" + nf + "','" + op + "','" + sr + "','" + td + "','" + cn + "', '')";
            }
            else
            {
                sql3 = "Update Talon Set NInicial='" + ni + "',NFinal='" + nf + "',Serie='" + sr + "',NCon='" + cn + "' Where Usuario='" + this.rangos[this.index]["Usuario"] + "' And Fecha='" + DateTime.Parse(this.rangos[this.index]["Fecha"]).ToShortDateString() + "' And Id_Oper='" + this.rangos[this.index]["Id_Oper"] + "' And Serie='" + this.rangos[this.index]["Serie"] + "' And DVenta='" + this.rangos[this.index]["DVenta"] + "'";
            }

            Conexion.ExecuteNonQuery(sql3);
            MessageBox.Show("Operación completada con éxito");
        }

        public void limpiar()
        {
            General.setAll<ComboBox, int>(this, "SelectedIndex", -1);
            cmbOperativo.SelectedValue = Operativo.id_oper;
            txtSerie.Text = txtNInicial.Text = txtNFinal.Text = txtNCon.Text = "";
            this.index = -1;
        }

        public void setObj(bool lp, bool tp)
        {
            General.setAll<Button, bool>(this, "Enabled", !lp);
            General.setAll<TextBox, bool>(this, "ReadOnly", lp);

            lstRangos.Enabled = !lp;
            txtSerie.ReadOnly = !lp;
            txtNInicial.ReadOnly = !lp;
            txtNFinal.ReadOnly = !lp;

            if (lp && tp)
            {
                btnNuevo.Text = "&Grabar";
                //General.setAll<ComboBox, bool>(this, "Enabled", !lp);
                this.limpiar();
                txtNCon.Text = "0";
                cmbUsuario.Focus();
                return;
            }

            if (!lp && tp)
            {
                btnNuevo.Text = "&Nuevo";
                //General.setAll<ComboBox, bool>(this, "Enabled", lp);
                this.limpiar();
                txtNCon.Text = "0";
                dtpicFInicial.Focus();
                return;
            }

            if (lp && !tp)
            {
                btnEditar.Text = "&Grabar";
                General.setAll<ComboBox, bool>(this, "Enabled", !lp);
                txtNCon.Enabled = true;
                txtSerie.Focus();
                return;
            }

            if (!lp && !tp)
            {
                btnEditar.Text = "&Editar";
                General.setAll<ComboBox, bool>(this, "Enabled", !lp);
                txtNCon.Enabled = true;
                this.limpiar();
                txtNCon.Enabled = false;
                dtpicFInicial.Focus();
                return;
            }
        }

        private void WorkerMethodRPT(object sender, WaitWindowEventArgs e)
        {
            //define la ruta por defecto de la app
            string path = Application.StartupPath;
            path = path.Replace("\\", "/");
            path = path.Replace("/bin/Debug", "");

            //define el reporte dependiendo del tipo de seleccion
            path = path + "/Dominio/Reportes/rptTalon.rpt";

            //carga el reporte
            rpt.Load(path);

            Conexion.CMD.CommandText = getSql(e.Arguments[0].ToString(), e.Arguments[1].ToString(), e.Arguments[2].ToString(), e.Arguments[3].ToString());
            using (SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD))
            {
                using (ReportsDS ds = new ReportsDS())
                {
                    ds.Clear();
                    da.Fill(ds, "Talon");
                    rpt.SetDataSource(ds);
                }
            }

            //setea los parametros del reporte Parte de atencion diario
            rpt.SetParameterValue("TituloReporte", "Talonario de documentos de venta");
            rpt.SetParameterValue("Fecha", DateTime.Now.ToLongDateString());

            if (e.Arguments.Count > 0)
                e.Result = e.Arguments[0].ToString();
            else
                e.Result = "Proceso culminado.";
        }

        private void frmAdmTalon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaTipoDS.DocVenta' table. You can move, or remove it, as needed.
            this.docVentaTableAdapter.Fill(this.tablaTipoDS.DocVenta);
            cmbDVenta.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'operativos.Operativo' table. You can move, or remove it, as needed.
            this.operativoTableAdapter.Fill(this.operativos.Operativo);
            cmbOperativo.SelectedIndex = -1;
            //
            string sql = "Select Usuario Id_Us,Usuario+Space(11) Usuario From Talon Group By Usuario Order By 2";
            this.usTal = General.GetDictionaryList(sql);

            for (int i = 0; i < this.usTal.Count; i++)
            {
                this.usTal[i]["Usuario"] = General.TradUser(this.usTal[i]["Usuario"]);
            }

            cmbOperativo.SelectedValue = Operativo.id_oper;
            General.FillComboBox(cmbUsuario, this.usTal, "Id_Us", "Usuario");
            cmbUsuario.SelectedIndex = -1;
            //
            dtpicFInicial.Value = DateTime.Today;
            dtpFFinal.Value = DateTime.Today;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void frmAdmTalon_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    this.DialogResult = DialogResult.Cancel;
                    break;
                case Keys.F5:
                    btnFiltro_Click(btnFiltro, new EventArgs());
                    break;
            }
        }

        private void lstRangos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index = General.GetSelectedIndex(lstRangos, false);

            if (this.index > -1)
            {
                cmbUsuario.SelectedIndex = this.usTal.FindIndex(x => x["Id_Us"] == this.rangos[this.index]["Usuario"]);
                cmbOperativo.SelectedValue = this.rangos[this.index]["Id_Oper"];
                cmbDVenta.SelectedValue = this.rangos[this.index]["DVenta"];
                txtSerie.Text = this.rangos[this.index]["Serie"];
                txtNInicial.Text = this.rangos[this.index]["NInicial"];
                txtNFinal.Text = this.rangos[this.index]["NFinal"];
                txtNCon.Text = this.rangos[this.index]["NCon"];
            }

        }

        private void txtNCon_Leave(object sender, EventArgs e)
        {
            if (this.DialogResult != DialogResult.Cancel)
            {
                int nCon = int.Parse(txtNCon.Text);
                int nInicial = int.Parse(txtNInicial.Text);
                int nFinal = int.Parse(txtNFinal.Text);

                if (!(nCon > nInicial && nCon < nFinal) && nCon != 0)
                {
                    MessageBox.Show("Valor debe estar comprendido entre numero inicial y final ó ser 0 ...", "Error");
                    txtNCon.Focus();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.index == -1)
            {
                return;
            }

            if (btnEditar.Text == "&Editar")
            {
                this.setObj(true, false);
                btnEditar.Enabled = true;
            }
            else
            {
                if (MessageBox.Show("Desea guardar los datos ...?", "Aviso al usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.guarda(false);
                }

                this.setObj(false, false);
                this.ejecon();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "&Nuevo")
            {
                this.setObj(true, true);
                btnNuevo.Enabled = true;
            }
            else
            {
                if (MessageBox.Show("Desea guardar los datos ...?", "Aviso al usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.guarda(true);
                }

                this.setObj(false, true);
                this.ejecon();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.index == -1)
            {
                return;
            }

            if (MessageBox.Show("Esta seguro de eliminar registro ?: Usuario=" + this.rangos[this.index]["Us"] + ", Fecha=" + this.rangos[this.index]["Fecha"] + ", Doc. Venta=" + this.rangos[this.index]["TDVen"] + ", Serie=" + this.rangos[this.index]["Serie"] + ", NInicial=" + this.rangos[this.index]["NInicial"] + ", NFinal=" + this.rangos[this.index]["NFinal"] + ", Operativo=" + this.rangos[this.index]["Operativo"], "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string xus = this.rangos[this.index]["Usuario"];
                string xfe = this.rangos[this.index]["Fecha"];
                string xio = this.rangos[this.index]["Id_Oper"];
                string xsr = this.rangos[this.index]["Serie"];
                string xdv = this.rangos[this.index]["DVenta"];
                string xni = this.rangos[this.index]["NInicial"];
                string xnf = this.rangos[this.index]["NFinal"];

                string sql = "Select Count(*)As C From Tickets Where Fecha_Emision>='" + DateTime.Parse(xfe).ToShortDateString() + "' And Digitador='" + xus + "' And Nro_Ticket Between '" + xni + "' And '" + xnf + "' And Serie='" + xsr + "' And DVenta='" + xdv + "' And Left(Nro_Historia,3)='" + xio + "'";

                int c = Conexion.ExecuteScalar<int>(sql);

                if (c > 0)
                {
                    MessageBox.Show("No se puede eliminar este rango, ya se realizaron ventas ...", "Advertencia");
                }
                else
                {
                    string sql2 = "Delete From Talon Where Usuario='" + xus + "' And Fecha='" + DateTime.Parse(xfe).ToShortDateString() + "' And Id_Oper='" + xio + "' And Serie='" + xsr + "' And DVenta='" + xdv + "' And NInicial='" + xni + "' And NFinal='" + xnf + "'";
                    Conexion.ExecuteNonQuery(sql2);
                    MessageBox.Show("Operación ejecutada correctamente");
                }
            }

            this.limpiar();
            this.ejecon();
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            if (this.index == -1)
            {
                return;
            }

            if (MessageBox.Show("Esta seguro de realizar el cierre del rango ?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string xu = this.rangos[this.index]["Usuario"];
                string xd = this.rangos[this.index]["Fecha"];
                string xo = this.rangos[this.index]["Id_Oper"];
                string xs = this.rangos[this.index]["Serie"];
                string xt = this.rangos[this.index]["DVenta"];
                string xi = this.rangos[this.index]["NInicial"];
                string xf = this.rangos[this.index]["NFinal"];

                string sql = "Update Talon Set NFinal=NCon,NCon='' Where Usuario='" + xu + "' And Fecha='" + DateTime.Parse(xd).ToShortDateString() + "' And Id_Oper='" + xo + "' And Serie='" + xs + "' " + "And DVenta='" + xt + "' And NInicial='" + xi + "' And NFinal='" + xf + "' And NCon<>'' And NCon<>'0'";
                Conexion.ExecuteNonQuery(sql);
                MessageBox.Show("Operación ejecutada correctamente");
            }

            this.limpiar();
            this.ejecon();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            this.ejecon();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string fi = dtpicFInicial.Value.ToShortDateString();
            string ff = dtpFFinal.Value.ToShortDateString();
            string us = cmbUsuario.SelectedIndex == -1 ? "" : this.usTal[cmbUsuario.SelectedIndex]["Id_Us"];
            string op = cmbOperativo.SelectedIndex == -1 ? "" : cmbOperativo.SelectedValue.ToString();

            //genera reporte y carga los datos
            object result = WaitWindow.Show(WorkerMethodRPT, "Generando el reporte...", new string[] { fi, ff, us, op});
            if (result == null)
            {
                MessageBox.Show("No se pudo procesar el reporte.");
                return;
            }

            //llama al formulario que muestra el reporte
            frmCRViewer frg = new frmCRViewer(rpt);
            frg.ShowDialog();
        }
    }
}
