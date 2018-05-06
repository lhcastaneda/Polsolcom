using CrystalDecisions.CrystalReports.Engine;
using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Data;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            string SQL = "SELECT Usuario+Space(11) Us,Fecha,D.Descripcion TDVen,Serie,NInicial, " +
							"NFinal,NCon,O.Descripcion Operativo, T.Id_Oper,DVenta,Usuario " +
							"FROM Talon T INNER JOIN Operativo O " +
							"ON T.Id_Oper = O.Id_Oper INNER JOIN " +
							"( SELECT Id_Tipo, Descripcion " +
							" FROM TablaTipo " +
							" WHERE Id_Tabla IN " +
							" (SELECT Id_Tipo " +
							"  FROM TablaTipo " +
							"  WHERE Descripcion = 'DOC_VENTA' " +
							"  AND Id_Tabla = '0')) D " +
							"ON T.DVenta = D.Id_Tipo " +
						"WHERE CONVERT(VARCHAR, Fecha, 103) Between '" + fi + "' AND '" + ff + "' " +
						"AND T.Id_Oper Like '" + op + "%' ";
			SQL += (us.Length > 0 ? "AND Usuario = '" + us + "' " : "");
			SQL += "Order By Cast(Convert(Varchar(10),Fecha,103)As DateTime),2 Asc,1";

            return SQL;
        }

        public void ejecon()
        {
            string fi = dtpicFInicial.Value.ToShortDateString();
            string ff = dtpFFinal.Value.ToShortDateString();
            string us = cmbUsuario.SelectedIndex == -1 ? "" : usTal[cmbUsuario.SelectedIndex]["Id_Us"];
            string op = cmbOperativo.SelectedIndex == -1 ? "" : cmbOperativo.SelectedValue.ToString();

            string sql = getSql(fi, ff, us, op);
            rangos = General.GetDictionaryList(sql);

            for (int i = 0; i < rangos.Count; i++)
                rangos[i]["Us"] = General.TradUser(rangos[i]["Us"]);

            General.Fill(lstRangos, rangos, new[] { "Us", "Fecha", "TDVen", "Serie", "NInicial", "NFinal", "NCon", "Operativo" });
            //
            if (lstRangos.Items.Count > 0 && index > -1)
            {
                lstRangos.Select();
                lstRangos.EnsureVisible(index);
                lstRangos.Items[index].Selected = true;
                lstRangos.Items[index].Focused = true;
                lstRangos.Items[index].EnsureVisible();
            }
        }

		public void guarda( bool lp )
		{
			if( cmbUsuario.SelectedIndex == -1 )
			{
				MessageBox.Show("Seleccione usuario antes de guardar ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				cmbUsuario.Focus();
				return;
			}

			if( cmbDVenta.SelectedIndex == -1 )
			{
				MessageBox.Show("Seleccione tipo documento antes de guardar ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				cmbUsuario.Focus();
				return;
			}

			if( cmbOperativo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione operativo  antes de guardar ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cmbOperativo.Focus();
                return;
            }

            if (txtSerie.Text.Length == 0 || int.Parse(txtSerie.Text) == 0)
            {
                MessageBox.Show("Ingrese serie antes de guardar ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtSerie.Focus();
                return;
            }

            if (txtNInicial.Text.Length == 0 || int.Parse(txtNInicial.Text) == 0)
            {
                MessageBox.Show("Ingrese numero inicial antes de guardar ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtNInicial.Focus();
                return;
            }

            if (txtNFinal.Text.Length == 0 || int.Parse(txtNFinal.Text) == 0)
            {
                MessageBox.Show("Ingrese numero final antes de guardar ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtNInicial.Focus();
                return;
            }

            if (int.Parse(txtNFinal.Text) < int.Parse(txtNInicial.Text))
            {
                MessageBox.Show("Numero final no puede ser menor que el inicial ...", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtNFinal.Focus();
                return;
            }

            string fr = DateTime.Today.ToShortDateString();
            string us = cmbUsuario.SelectedIndex == -1 ? "" : usTal[cmbUsuario.SelectedIndex]["Id_Us"];
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
                MessageBox.Show("El rango de " + ni + " a " + talo["NFinal"] + " serie " + talo["Serie"] + " corresponde a " + General.TradUser(talo["Usuario"]) + " con fecha " + talo["Fecha"] + " modifique rango...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                if (lp)
					return;
				else
				{
                    if (MessageBox.Show("Desea reemplazar los valores existentes ...", "Modificando rangos ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
						return;
				}
			}

            string sql2 = "Select * From Talon Where Cast('" + nf + "' As Int) Between Cast(NInicial As Int) And Cast(NFinal As Int) And Serie='" + sr + "' And DVenta='" + td + "'";
            talo = General.GetDictionary(sql2);

            if (talo != null)
            {
                MessageBox.Show("El rango de " + talo["NInicial"] + " a " + nf + " serie " + talo["Serie"] + " corresponde a " + General.TradUser(talo["Usuario"]) + " con fecha " + talo["Fecha"] + " modifique rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                if (lp)
					return;
				else
				{
                    if (MessageBox.Show("Desea reemplazar los valores existentes ...", "Modificando rangos ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
						return;
				}
			}

            string sql3 = "";
            if (lp)
                sql3 = "Insert Into Talon Values ('" + us + "','" + fr + "','" + ni + "','" + nf + "','" + op + "','" + sr + "','" + td + "','" + cn + "', '')";
            else
                sql3 = "Update Talon Set NInicial='" + ni + "',NFinal='" + nf + "',Serie='" + sr + "',NCon='" + cn + "' Where Usuario='" + rangos[index]["Usuario"] + "' And Fecha='" + DateTime.Parse(rangos[index]["Fecha"]).ToShortDateString() + "' And Id_Oper='" + rangos[index]["Id_Oper"] + "' And Serie='" + rangos[index]["Serie"] + "' And DVenta='" + rangos[index]["DVenta"] + "'";

            Conexion.ExecuteNonQuery(sql3);
            MessageBox.Show("Operación completada con éxito", "Actualizacion Rangos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public void limpiar()
        {
            General.setAll<ComboBox, int>( this,"SelectedIndex", -1);
            cmbOperativo.SelectedValue = Operativo.id_oper;
            txtSerie.Text = txtNInicial.Text = txtNFinal.Text = txtNCon.Text = "";
            index = -1;
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
                //General.setAll<ComboBox, bool>( "Enabled", !lp);
                limpiar();
                txtNCon.Text = "0";
                cmbUsuario.Focus();
                return;
            }

            if (!lp && tp)
            {
                btnNuevo.Text = "&Nuevo";
                //General.setAll<ComboBox, bool>( "Enabled", lp);
                limpiar();
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
                limpiar();
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
            docVentaTableAdapter.Fill(tablaTipoDS.DocVenta);
            cmbDVenta.SelectedIndex = -1;
            operativoTableAdapter.Fill(operativos.Operativo);
            cmbOperativo.SelectedIndex = -1;

			string sql = "Select Usuario Id_Us,Usuario+Space(11) Usuario From Talon Group By Usuario Order By 2";
            usTal = General.GetDictionaryList(sql);

            for (int i = 0; i < usTal.Count; i++)
                usTal[i]["Usuario"] = General.TradUser(usTal[i]["Usuario"]);

            cmbOperativo.SelectedValue = Operativo.id_oper;
            General.Fill(cmbUsuario, usTal, "Id_Us", "Usuario");
            cmbUsuario.SelectedIndex = -1;
            dtpicFInicial.Value = DateTime.Today;
            dtpFFinal.Value = DateTime.Today;
        }

        private void frmAdmTalon_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    DialogResult = DialogResult.Cancel;
                    break;
                case Keys.F5:
                    btnFiltro_Click(btnFiltro, new EventArgs());
                    break;
            }
        }

        private void lstRangos_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = General.GetSelectedIndex(lstRangos, false);

            if (index > -1)
            {
                cmbUsuario.SelectedIndex = usTal.FindIndex(x => x["Id_Us"] == rangos[index]["Usuario"]);
                cmbOperativo.SelectedValue = rangos[index]["Id_Oper"];
                cmbDVenta.SelectedValue = rangos[index]["DVenta"];
                txtSerie.Text = rangos[index]["Serie"];
                txtNInicial.Text = rangos[index]["NInicial"];
                txtNFinal.Text = rangos[index]["NFinal"];
                txtNCon.Text = rangos[index]["NCon"];
				btnEditar.Enabled = true;
				btnCortar.Enabled = true;
				btnEliminar.Enabled = true;
				btnImprimir.Enabled = true;
			}

		}

        private void txtNCon_Leave(object sender, EventArgs e)
        {
            if (DialogResult != DialogResult.Cancel)
            {
                int nCon = int.Parse(txtNCon.Text);
                int nInicial = int.Parse(txtNInicial.Text);
                int nFinal = int.Parse(txtNFinal.Text);

                if (!(nCon > nInicial && nCon < nFinal) && nCon != 0)
                {
                    MessageBox.Show("Valor debe estar comprendido entre numero inicial y final ó ser 0 ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    txtNCon.Focus();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (index == -1)
				return;

			if( btnEditar.Text == "&Editar")
            {
                setObj(true, false);
                btnEditar.Enabled = true;
			}
            else
            {
                if (MessageBox.Show("Desea guardar los datos ...?", "Aviso al usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    guarda(false);

                setObj(false, false);
                ejecon();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "&Nuevo")
            {
                setObj(true, true);
                btnNuevo.Enabled = true;
				lstRangos.Items.Clear();
			}
			else
            {
                if (MessageBox.Show("Desea guardar los datos ...?", "Aviso al usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    guarda(true);

                setObj(false, true);
                ejecon();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (index == -1)
                return;

            if (MessageBox.Show("Esta seguro de eliminar registro... ?" + (char)13 + "Usuario = " + rangos[index]["Us"] + (char)13 + "Fecha = " + rangos[index]["Fecha"] + (char)13 + "Doc. Venta = " + rangos[index]["TDVen"] + (char)13 + "Serie = " + rangos[index]["Serie"] + (char)13 + "NInicial = " + rangos[index]["NInicial"] + " y NFinal = " + rangos[index]["NFinal"] , "Advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string xus = rangos[index]["Usuario"];
                string xfe = rangos[index]["Fecha"];
                string xio = rangos[index]["Id_Oper"];
                string xsr = rangos[index]["Serie"];
                string xdv = rangos[index]["DVenta"];
                string xni = rangos[index]["NInicial"];
                string xnf = rangos[index]["NFinal"];

                string sql = "Select Count(*)As C From Tickets Where Fecha_Emision>='" + DateTime.Parse(xfe).ToShortDateString() + "' And Digitador='" + xus + "' And Nro_Ticket Between '" + xni + "' And '" + xnf + "' And Serie='" + xsr + "' And DVenta='" + xdv + "' And Left(Nro_Historia,3)='" + xio + "'";

                int c = Conexion.ExecuteScalar<int>(sql);

                if (c > 0)
                    MessageBox.Show("No se puede eliminar este rango, ya se realizaron ventas ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                {
                    string sql2 = "Delete From Talon Where Usuario='" + xus + "' And Fecha='" + DateTime.Parse(xfe).ToShortDateString() + "' And Id_Oper='" + xio + "' And Serie='" + xsr + "' And DVenta='" + xdv + "' And NInicial='" + xni + "' And NFinal='" + xnf + "'";
                    Conexion.ExecuteNonQuery(sql2);
                    MessageBox.Show("Operación ejecutada correctamente","Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            limpiar();
            ejecon();
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            if (index == -1)
				return;

			if( MessageBox.Show("Esta seguro de realizar el cierre del rango ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string xu = rangos[index]["Usuario"];
                string xd = rangos[index]["Fecha"];
                string xo = rangos[index]["Id_Oper"];
                string xs = rangos[index]["Serie"];
                string xt = rangos[index]["DVenta"];
                string xi = rangos[index]["NInicial"];
                string xf = rangos[index]["NFinal"];

                string sql = "Update Talon Set NFinal=NCon,NCon='' Where Usuario='" + xu + "' And Fecha='" + DateTime.Parse(xd).ToShortDateString() + "' And Id_Oper='" + xo + "' And Serie='" + xs + "' " + "And DVenta='" + xt + "' And NInicial='" + xi + "' And NFinal='" + xf + "' And NCon<>'' And NCon<>'0'";
                Conexion.ExecuteNonQuery(sql);
				MessageBox.Show("Operación ejecutada correctamente", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
			}
			limpiar();
            ejecon();
        }
		
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string fi = dtpicFInicial.Value.ToShortDateString();
            string ff = dtpFFinal.Value.ToShortDateString();
            string us = cmbUsuario.SelectedIndex == -1 ? "" : usTal[cmbUsuario.SelectedIndex]["Id_Us"];
            string op = cmbOperativo.SelectedIndex == -1 ? "" : cmbOperativo.SelectedValue.ToString();

            //genera reporte y carga los datos
            object result = WaitWindow.Show(WorkerMethodRPT, "Generando el reporte...", new string[] { fi, ff, us, op});
            if (result == null)
            {
                MessageBox.Show("No se pudo procesar el reporte.","Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				return;
            }

            //llama al formulario que muestra el reporte
            frmCRViewer frg = new frmCRViewer(rpt);
            frg.ShowDialog();
        }

		private void btnRecrear_Click( object sender, EventArgs e )
		{

		}

		private void btnFiltro_Click( object sender, EventArgs e )
		{
			index = -1;
			ejecon();
			if( lstRangos.Items.Count > 0)
				btnImprimir.Enabled = true;
			else
				btnImprimir.Enabled = false;
		}

		private void dtpicFInicial_ValueChanged( object sender, EventArgs e )
		{
			dtpFFinal.Text = dtpicFInicial.Text;
			cmbUsuario.SelectedIndex = -1;
			cmbDVenta.SelectedIndex = -1;
			txtSerie.Text = "";
			txtNInicial.Text = "";
			txtNFinal.Text = "";
			txtNCon.Text = "";
		}

		private void dtpFFinal_ValueChanged( object sender, EventArgs e )
		{
			cmbUsuario.SelectedIndex = -1;
			cmbDVenta.SelectedIndex = -1;
			txtSerie.Text = "";
			txtNInicial.Text = "";
			txtNFinal.Text = "";
			txtNCon.Text = "";
		}

		private void cmbUsuario_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbUsuario.SelectedIndex != -1 )
				cmbDVenta.Focus();
		}

		private void cmbDVenta_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbDVenta.SelectedIndex != -1 )
			{
				txtSerie.Text = "";
				txtNInicial.Text = "";
				txtNFinal.Text = "";
				txtNCon.Text = "";
				txtSerie.Focus();
			}				
		}
	}
}
