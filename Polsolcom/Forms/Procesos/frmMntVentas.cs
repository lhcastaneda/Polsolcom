using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
	public partial class frmMntVentas : Form
    {
        List<Dictionary<string, string>> vcabs = new List<Dictionary<string, string>>();
        Dictionary<string, string> vcab = new Dictionary<string, string>();
        List<Dictionary<string, string>> npacs = new List<Dictionary<string, string>>();
        Dictionary<string, string> npac = new Dictionary<string, string>();
        List<Dictionary<string, string>> nusr = new List<Dictionary<string, string>>();

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

            //General.setAll<TextBox, string>(this, "Text", "");
            General.setAll<MaskedTextBox, string>(this, "Text", "");
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
            string ip = lp is bool ? xp.ToString() : txtIdPac.Text;
            string pt = txtApePat.Text;
            string mt = txtApeMat.Text;
            string nm = txtNombres.Text;

            if ((pt.Length + mt.Length + nm.Length + ip.Length) > 0)
            {
                string sql = General.DevuelveQueryPaciente(pt, mt, nm, "", ip, "", 2, 0);
				npacs = General.GetDictionaryList(sql);
                General.Fill(lstPacientes, npacs, new[] {"Paciente", "Id_Paciente" });
            }
        }

        bool pfv<T>(T lp)
        {
            T xp = lp;
            string ip = xp is bool ? "" : xp.ToString();
            string fi = txtFecEmi.Text == General.emptyDate ? "" : txtFecEmi.Text;
            string ff = txtFecEmi.Text == General.emptyDate ? "" : DateTime.Parse(txtFecEmi.Text).AddDays(1).ToShortDateString();
            string dv = cmbTipDoc.SelectedIndex == -1 ? "" : cmbTipDoc.SelectedValue.ToString();
            string sr = txtSerie.Text;
            string ni = txtNInicial.Text;
            string nf = txtNFinal.Text;
            string es = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();
            ni = (ni == General.emptyDate ? nf : ni);

            if (fi.Length == 0 && ip.Length == 0)
            {
                MessageBox.Show("Ingrese fecha de emision o seleccione paciente como minimo ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtFecEmi.Focus();
                return false;
            }

            if (nf.Length == 0 && ip.Length == 0)
            {
                MessageBox.Show("Es necesario el numero final ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtNFinal.Focus();
                return false;
            }

            lstVentas.Items.Clear();

            string sql = "Select D.Descripcion DVen,T.Serie+'-'+T.Nro_Ticket NDoc," +
				"CONVERT(varchar, Fecha_Emision, 103) Fecha_Emision,C.Descripcion Especialidad,Id_Paciente," +
                "Digitador+Space(11) Digitador,Anulado,ForPago,Descuento,Moneda,Convenio,Nro_Historia " +
                "From Tickets T Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " +
                "Inner Join (Select Id_Tipo,Descripcion From TablaTipo Where Id_Tabla In (Select Id_Tipo From TablaTipo " +
                "Where Descripcion='DOC_VENTA'))D On T.Dventa=D.Id_Tipo " +
                "Where ";

            sql += (txtFecEmi.Text == General.emptyDate ? "" : "T.Fecha_Emision Between '" + fi + "' And '" + ff + "' ");

            if (cmbTipDoc.SelectedIndex > -1)
                sql += sql.Contains("And") ? "And T.DVenta Like '" + dv + "' " : "T.DVenta Like '" + dv + "' ";

            if (sr.Length > 0)
                sql += sql.Contains("Like") || sql.Contains("And") ? "And T.Serie Like '" + sr + "' " : "T.Serie Like '" + sr + "' ";

            if (nf.Length > 0)
                sql += sql.Contains("Like") || sql.Contains("And") ? "And Cast(T.Nro_Ticket As Int) Between '" + ni + "' And '" + nf + "' " : "Cast(T.Nro_Ticket As Int) Between '" + ni + "' And '" + nf + "' ";

            if (cmbEspecialidad.SelectedIndex > -1)
                sql += sql.Contains("Like") || sql.Contains("And") ? "And T.Id_Consultorio Like '" + es + "' " : "T.Id_Consultorio Like '" + es + "' ";

            if (ip.Length > 0)
                sql += sql.Contains("Like") || sql.Contains("And") ? "And T.Id_Paciente Like '" + ip + "' " : "T.Id_Paciente Like '" + ip + "' ";

            sql += "order by 3, 2";

			vcabs = General.GetDictionaryList(sql);
            for (int i = 0; i < vcabs.Count; i++)
                vcabs[i]["Digitador"] = General.TradUser(vcabs[i]["Digitador"]);

            General.Fill(lstVentas, vcabs, new[] { "DVen", "NDoc", "Fecha_Emision", "Especialidad" });
            rb0.Checked = true;
            optPanel.Enabled = btnEliminar.Enabled = false;
            return true;
        }

        public void phb(bool lm, string op)
        {
            txtApePat.Enabled = txtApeMat.Enabled = txtNombres.Enabled = txtIdPac.Enabled = txtFecEmi.Enabled = cmbEspecialidad.Enabled = cmbTipDoc.Enabled = txtSerie.Enabled = txtNInicial.Enabled = txtNFinal.Enabled = optPanel.Enabled = lstPacientes.Enabled = lstVentas.Enabled = lm;
            btnEliminar.Enabled = cmbAprDscto.Enabled = false;
            txtObservacion.Enabled = btnGrabar.Enabled = !lm;

            if (rb0.Checked)
                cmbMotAnul.Enabled = !lm;

            if (rb1.Checked)
            {
                txtDscto.Enabled = !lm;
                grdDet.Columns["MD"].ReadOnly = lm;
                txtDscto.Text = "0.00";
                for (int i = 0; i < grdDet.Rows.Count; ++i)
                    grdDet.Rows[i].Cells["MD"].Value = true;
            }

            if (rb2.Checked)
            {
                cmbOpExt.Enabled = cmbUsExt.Enabled = txtFecExt.Enabled = cmbMotAnul.Enabled = !lm;
                txtFecExt.Text = DateTime.Today.ToShortDateString();
                cmbOpExt.SelectedValue = Operativo.id_oper;
            }
        }

        private void frmMntVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
				DialogResult = DialogResult.Cancel;
				Close();
            }

            if (e.KeyCode == Keys.F1)
                txtDscto.Focus();
        }

        private void frmMntVentas_Load(object sender, EventArgs e)
        {
			motivoAnulacionTableAdapter.Fill(tablaTipoDS.MotivoAnulacion);
            cmbMotAnul.SelectedIndex = -1;

			operativoTableAdapter.Fill(operativos.Operativo);
            cmbOpExt.SelectedIndex = -1;

			tipoMonedaTableAdapter.Fill(tablaTipoDS.TipoMoneda);
            cmbMoneda.SelectedIndex = -1;

			formaPagoTableAdapter.Fill(tablaTipoDS.FormaPago);
            cmbFPago.SelectedIndex = -1;

			docVentaTableAdapter.Fill(tablaTipoDS.DocVenta);
            cmbTipDoc.SelectedIndex = -1;

			especialidadTableAdapter.Fill(consultoriosDS.Especialidad, Operativo.id_oper);
            cmbEspecialidad.SelectedIndex = -1;

            string sql = "Select Key_Pass Usuario,Id_Us From sysaccusers";
			nusr = General.GetDictionaryList(sql);
            for (int i = 0; i < nusr.Count; i++)
                nusr[i]["Usuario"] = General.TradUser(nusr[i]["Usuario"]);

			nusr.Sort((x,y) => x["Usuario"].CompareTo(y["Usuario"]));
            General.Fill(cmbUsExt, nusr, "Id_Us", "Usuario");
            General.Fill(cmbAprDscto, nusr, "Id_Us", "Usuario");
            cmbUsExt.SelectedIndex = -1;
            cmbAprDscto.SelectedIndex = -1;

            string sql2 = "Select LTrim(RTrim(Ape_Paterno))+' '+LTrim(RTrim(Ape_Materno))+' '+LTrim(RTrim(Nombres))Personal,Id_Personal " + 
                "From Personal Where Dscto='S' Union All " + 
                "Select Nom_Raz_Soc Personal,TInst+Id_Inst Id_Personal From Institucion Where TInst='S' Order By 1";
            List<Dictionary<string, string>> nper = General.GetDictionaryList(sql2);
        }

        private void txtNFinal_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
				pfv("");
        }

        private void txtApeMat_TextChanged(object sender, EventArgs e)
        {
			pfp("");
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
			pfp("");
        }

        private void txtIdPac_TextChanged(object sender, EventArgs e)
        {
			pfp("");
        }

        private void txtFecEmi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                txtFecEmi.Text = DateTime.Today.ToShortDateString();
        }

        private void txtDscto_Leave(object sender, EventArgs e)
        {
            if ( DialogResult != DialogResult.Cancel)
            {
                if (MessageBox.Show("Desea aplicar descuento a los productos seleccionados ... ?", "Aviso al usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    decimal mm = General.GetDictionaryList(grdDet).FindAll(x => x["MD"] == "True").Sum(x => decimal.Parse(x["Monto"]));
                    if (mm - decimal.Parse(txtDscto.Text) < 1)
                    {
                        General.msg("Descuento no debe generar negativos, corregir proceso ...", "Advertencia", true);
                        return;
                    }

                    int rg = 0;
                    decimal lm = 0;
                    for (int i = 0; i < grdDet.Rows.Count; ++i)
                    {
                        if (grdDet.Rows[i].Cells["MD"].Value.ToString() == "True")
                        {
                            decimal xd = decimal.Parse(grdDet.Rows[i].Cells["Total"].Value.ToString()) / mm;
                            grdDet.Rows[i].Cells["PD"].Value = xd;
                            grdDet.Rows[i].Cells["Monto"].Value = decimal.Parse(grdDet.Rows[i].Cells["Monto"].Value.ToString()) - (decimal.Parse(grdDet.Rows[i].Cells["PD"].Value.ToString()) * decimal.Parse(txtDscto.Text)) / decimal.Parse(grdDet.Rows[i].Cells["Cantidad"].Value.ToString());
                            decimal xtotal = decimal.Parse(grdDet.Rows[i].Cells["Monto"].Value.ToString()) * decimal.Parse(grdDet.Rows[i].Cells["Cantidad"].Value.ToString());
                            grdDet.Rows[i].Cells["Total"].Value = xtotal;
                            lm += xtotal;
                            rg = i;
                        }
                    }

                    decimal df = mm - (lm - decimal.Parse(txtDscto.Text));
                    df = (int.Parse(grdDet.Rows[rg].Cells["Cantidad"].Value.ToString()) > 1 ? df / int.Parse(grdDet.Rows[rg].Cells["Cantidad"].Value.ToString()) : df);
                    grdDet.Rows[rg].Cells["Monto"].Value = (df > 0 ? decimal.Parse(grdDet.Rows[rg].Cells["Monto"].Value.ToString()) + df : (df < 0 ? decimal.Parse(grdDet.Rows[rg].Cells["Monto"].Value.ToString()) - df : grdDet.Rows[rg].Cells["Monto"].Value));
                    grdDet.Rows[rg].Cells["Total"].Value = decimal.Parse(grdDet.Rows[rg].Cells["Monto"].Value.ToString()) * int.Parse(grdDet.Rows[rg].Cells["Cantidad"].Value.ToString());

                    txtTotal.Text = General.GetDictionaryList(grdDet).Sum(x => decimal.Parse(x["Monto"]) * int.Parse(x["Cantidad"])).ToString();
                    cmbAprDscto.Enabled = true;
                    txtDscto.Enabled = false;
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string nh = vcab["Nro_Historia"];
            string us = Usuario.id_us;
            string ob = txtObservacion.Text;
            string sql = "";
            string op = "";

            if (MessageBox.Show("Esta seguro de guardar los cambios ... ?", "Aviso al usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (rb0.Checked)
                {
                    if (cmbMotAnul.SelectedIndex == -1)
                    {
                        MessageBox.Show("Faltan datos para realizar la anulacion ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    string ma = cmbMotAnul.SelectedValue.ToString();
                    sql = "Update Tickets Set Anulado='S',Descuento='A'+'" + us + "'+Space(9-Len('" + us + "'))+Convert(Varchar(10),GetDate(),103)+' '+Convert(Varchar(10),GetDate(),108)+'" + ma + "'+'" + ob + "' Where Nro_Historia='" + nh + "'";
                    op = "1";
                }

                if (rb1.Checked)
                {
                    if (txtDscto.Text.Length == 0 || cmbAprDscto.SelectedIndex == -1)
                    {
                        MessageBox.Show("Faltan datos para realizar descuento ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    string ad = nusr[cmbAprDscto.SelectedIndex]["Id_Us"];
                    string ds = decimal.Parse(txtDscto.Text).ToString();

                    for (int i = 0; i < grdDet.Rows.Count; ++i)
                    {
                        string ip = grdDet.Rows[i].Cells["Id_Producto"].Value.ToString();
                        string mn = grdDet.Rows[i].Cells["Monto"].Value.ToString();
                        string sqlx = "Update Detalles Set Monto='" + mn + "' Where Nro_Historia='" + nh + "' And Id_Producto='" + ip + "'";
                        Conexion.ExecuteNonQuery(sqlx);
                    }

                    sql = "Update Tickets Set Descuento='D'+'" + us + "'+Space(9-Len('" + us + "'))+Convert(Varchar(10),GetDate(),103)+' '+" + "Convert(Varchar(10),GetDate(),108)+'" + ad + "'+Space(9-Len('" + ad + "'))+'" + ds + "'+Space(8-Len('" + ds + "'))+'" + ob + "' " + "Where Nro_Historia='" + nh + "'";
                    string ms = "DESCUENTO DE S/. " + ds + " AL DOC. DE VENTA TIPO " + vcab["DVen"] + " CON NRO. " + vcab["NDoc"] + " YA FUE REALIZADO ... VERIFICAR";
                    op = "2";
                }

                if (rb2.Checked)
                {
                    if (cmbOpExt.SelectedIndex == -1 || cmbUsExt.SelectedIndex == -1 || txtFecExt.Text == General.emptyDate || cmbMotAnul.SelectedIndex == -1)
                    {
                        MessageBox.Show("Faltan datos para realizar extorno ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    string oe = cmbOpExt.SelectedValue.ToString();
                    string ue = nusr[cmbUsExt.SelectedIndex]["Id_Us"];
                    string fe = txtFecExt.Text;
                    string me = cmbMotAnul.SelectedValue.ToString();
                    sql = "Update Tickets Set Descuento='E'+'" + us + "'+Space(9-Len('" + us + "'))+Convert(Varchar(10),GetDate(),103)+' '+Convert(Varchar(10),GetDate(),108)+'" + oe + "'+'" + ue + "'+Space(9-Len('" + ue + "'))+'" + me + "'+'" + ob + "',Anulado='" + fe + "' Where Nro_Historia='" + nh + "'";
                    op = "3";
                }

                if (rb3.Checked)
                {
                    if (txtObservacion.Text.Length == 0)
                    {
                        MessageBox.Show("Ingrese la observacion a guardar ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    sql = "Update Tickets Set Descuento='O'+'" + us + "'+Space(9-Len('" + us + "'))+Convert(Varchar(10),GetDate(),103)+' '+" + "Convert(Varchar(10),GetDate(),108)+'" + ob + "' " + "Where Nro_Historia='" + nh + "'";
                }

                Conexion.ExecuteNonQuery(sql);
                MessageBox.Show("Operación ejecutada con éxito","Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                op = "4";
            }
			phb(true, op);
			pfv("");
            int j = vcabs.FindIndex(x => x["Nro_Historia"] == nh);
            lstVentas.Items[j].Selected = true;
            lstVentas_SelectedIndexChanged(lstVentas, new EventArgs());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ms = vcabs[0]["NDoc"];
            string nh = "'" + vcabs[0]["Nro_Historia"];

            for (int i = 0; i < vcabs.Count; ++i)
            {
                ms += ", " + vcabs[i]["NDoc"];
                nh += ", " + vcabs[i]["Nro_Historia"];
            }
            nh += "'";

            string sql = "Select Case When Exists(Select * From Tickets Where Nro_Historia In(" + nh + ") And Fecha_Emision>=" + "Convert(Varchar(10),GetDate(),103)) Then '1' Else '0' End TI,Case When Exists(Select * From Cab_Cie10 " + "Where Nro_Historia In(" + nh + ")) Then '1' Else '0' End CI,Case When Exists(Select * From Tickets " + "Where Nro_Historia In(" + nh + ") And Anulado<>'') Then '1' Else '0' End AE";
            Dictionary<string, string> result = General.GetDictionary(sql);

            string xr = result["TI"] + result["CI"] + result["AE"];
            if (xr != "100")
            {
                MessageBox.Show("No se puede eliminar el conjunto de resultados obtenidos, por contener:\nventas de fechas anteriores, anulados o extornos, atenciones realizadas ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (MessageBox.Show("Esta seguro de eliminar estos documentos de venta:\n" + ms, "Aviso al usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string sqlx = "Delete From Detalles Where Nro_Historia In(" + nh + ")";
                Conexion.ExecuteNonQuery(sqlx);

                string sqly = "Delete From Tickets Where Nro_Historia In(" + nh + ")";
                Conexion.ExecuteNonQuery(sqly);
				MessageBox.Show("Operación ejecutada con éxito", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				pfv("");
                lstPacientes.Items.Clear();
            }
        }

        private void rb0_CheckedChanged(object sender, EventArgs e)
        {
            if (rb0.Checked)
            {
                if ( vcab["Fecha_Emision"] == DateTime.Today.ToShortDateString())
                {
                    if ( vcab["Anulado"] == "")
                    {
						phb(false, "1");
                        cmbMotAnul.Focus();
                    }

                    if ( vcab["Anulado"] == "S")
                    {
                        if (MessageBox.Show("Desea quitar la anulación de este registro de venta ... ?", "Aviso al usuario",  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            string nh = vcab["Nro_Historia"];
                            string us = Usuario.id_us;
                            string sql = "Update Tickets Set Anulado='',Descuento='A'+'" + us + "'+Space(9-Len('" + us + "'))+Convert(Varchar(10)," + "GetDate(),103)+' '+Convert(Varchar(10),GetDate(),108) Where Nro_Historia='" + nh + "'";
                            Conexion.ExecuteNonQuery(sql);
							MessageBox.Show("Operación ejecutada con éxito", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
							pfv("");
                            int i = vcabs.FindIndex(x => x["Nro_Historia"] == nh);
                            lstVentas.Items[i].Selected = true;
                            lstVentas_SelectedIndexChanged(lstVentas, new EventArgs());
                        }
                        rb0.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Solo se pueden anular o desanular ventas del dia ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    rb0.Checked = false;
                }
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                if (DateTime.Parse(vcab["Fecha_Emision"]).ToShortDateString() == DateTime.Today.ToShortDateString() && vcab["Anulado"] == "")
					phb(false, "2");
                else
                    MessageBox.Show("Solo se puede hacer descuento a ventas del dia ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    rb1.Checked = false;
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                if (DateTime.Parse(vcab["Fecha_Emision"]).ToShortDateString() == DateTime.Today.ToShortDateString() && (txtEstado.Text == "VENDIDO" || txtEstado.Text == "EDITADO"))
                {
					phb(false, "3");
                    cmbOpExt.Focus();
                    return;
                }

                if (txtEstado.Text == "EXTORNO")
                {
                    if (txtFecExt.Text == DateTime.Today.ToShortDateString())
                    {
                        if (MessageBox.Show("Desea quitar la condición de extornado ... ?", "Aviso al usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            string nh = vcab["Nro_Historia"];
                            string us = Usuario.id_us;
                            string sql = "Update Tickets Set Anulado='',Descuento='E'+'" + us + "'+Space(9-Len('" + us + "'))+Convert(Varchar(10)," + "GetDate(),103)+' '+Convert(Varchar(10),GetDate(),108) Where Nro_Historia='" + nh + "'";
                            Conexion.ExecuteNonQuery(sql);
							MessageBox.Show("Operación ejecutada con éxito", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
							pfv("");
                            int i = vcabs.FindIndex(x => x["Nro_Historia"] == nh);
                            lstVentas.Items[i].Selected = true;
                            lstVentas_SelectedIndexChanged(lstVentas, new EventArgs());
                        }
                    }
                    else
                        MessageBox.Show("Extornos de fechas anteriores no pueden ser editados ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    rb2.Checked = false;
                    return;
                }
                MessageBox.Show("Solo se puede extornar ventas de fechas anteriores ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                rb2.Checked = false;
            }
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
            {
                if (DateTime.Parse(vcab["Fecha_Emision"]).ToShortDateString() == DateTime.Today.ToShortDateString() && vcab["Anulado"] == "" && General.SafeSubstring(vcab["Descuento"], 0, 1) != "D")
                {
					phb(false, "4");
                    txtObservacion.Focus();
                }
                else
                {
                    MessageBox.Show("Solo se puede hacer observaciones a ventas del dia, libre de descuento ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    rb3.Checked = false;
                }
            }
        }

		private void txtSerie_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
				e.Handled = true;

		}

		private void txtApePat_TextChanged( object sender, EventArgs e )
		{
			pfp("");
		}

		private void lstVentas_SelectedIndexChanged( object sender, EventArgs e )
		{
			int i = General.GetSelectedIndex(lstVentas, false);

			if( i > -1 )
			{
				vcab = vcabs[i];
				pcl();
				pfp(vcab["Id_Paciente"]);

				int j = npacs.FindIndex(x => x["Id_Paciente"] == vcab["Id_Paciente"]);
				if( j > -1 )
				{
					txtIdPaciente.Text = npacs[j]["Id_Paciente"];
					txtPaciente.Text = npacs[j]["Ape_Paterno"] + " " + npacs[j]["Ape_Materno"] + " " + npacs[j]["Nombre"];
					txtSexo.Text = npacs[j]["Sexo"] == "M" ? "MASCULINO" : "FEMENINO";
					txtFecNac.Text = npacs[j]["Fecha_Nac"];
					txtEdad.Text = npacs[j]["Edad"];
					txtCajero.Text = vcab["Digitador"];
					cmbFPago.SelectedValue = vcab["ForPago"];
					cmbMoneda.SelectedValue = vcab["Moneda"];
				}

				if( General.SafeSubstring(vcab["Descuento"], 0, 1) == "A" && vcab["Anulado"].Length == 1 )
				{
					//.cmbmotanul.rowsource = 'Allt(MotAnul.Descripcion),Id_Tipo'
					cmbMotAnul.SelectedValue = General.SafeSubstring(vcab["Descuento"], 29, 1);
					txtObservacion.Text = General.SafeSubstring(vcab["Descuento"], 30, 40);
				}

				if( General.SafeSubstring(vcab["Descuento"], 0, 1) == "D" )
				{
					cmbAprDscto.SelectedIndex = nusr.FindIndex(x => x["Id_Us"] == General.SafeSubstring(vcab["Descuento"], 29, 9));
					txtDscto.Text = General.SafeSubstring(vcab["Descuento"], 38, 8);
					txtDscto.Text = Convert.ToDecimal(txtDscto.Text).ToString("#,##0.#0");
					txtObservacion.Text = General.SafeSubstring(vcab["Descuento"], 46, 24);
				}

				if( General.SafeSubstring(vcab["Descuento"], 0, 1) == "E" && vcab["Anulado"].Length == 10 )
				{
					txtFecExt.Text = vcab["Anulado"];
					cmbOpExt.SelectedValue = General.SafeSubstring(vcab["Descuento"], 29, 3);
					cmbUsExt.SelectedIndex = nusr.FindIndex(x => x["Id_Us"] == General.SafeSubstring(vcab["Descuento"], 32, 9));
					cmbMotAnul.SelectedValue = General.SafeSubstring(vcab["Descuento"], 41, 1);
					txtObservacion.Text = General.SafeSubstring(vcab["Descuento"], 42, 28);
				}

				if( General.SafeSubstring(vcab["Descuento"], 0, 1) == "O" )
					txtObservacion.Text = General.SafeSubstring(vcab["Descuento"], 29, 41);

				txtEstado.Text = (vcab["Anulado"] == "" && vcab["Descuento"] == "" ? "VENDIDO" : (vcab["Anulado"].Length == 10 && General.SafeSubstring(vcab["Descuento"], 0, 1) == "E" ? "EXTORNO" : (vcab["Anulado"] == "S" && vcab["Anulado"].Substring(0, 1) == "A" ? "ANULADO" : "EDITADO")));
				txtUsFecMod.Text = (vcab["Descuento"].Length > 0 ? General.TradUser(General.SafeSubstring(vcab["Descuento"], 1, 9)) + " - " + General.SafeSubstring(vcab["Descuento"], 10, 19) : "");

				string nh = vcab["Nro_Historia"];
				grdDet.Rows.Clear();
				string sql = "Select P.Descripcion Producto,Cantidad,CONVERT(DECIMAL(10,2),D.Monto) Monto, " +
								"CONVERT(DECIMAL(10, 2), D.Monto * Cantidad) Total,0 MD, " +
								"Pagado,CONVERT(DECIMAL(10, 2), Dscto) Dscto,D.Id_Producto,Nro_Historia,0.00 PD " +
								"From Detalles D Inner Join Productos P " +
								"On D.Id_Producto = P.Id_Producto " +
								"Where Nro_Historia='" + nh + "'";
				List<Dictionary<string, string>> vdets = General.GetDictionaryList(sql);
				General.Fill(grdDet, vdets, new[] { "MD" });
				txtTotal.Text = vdets.Sum(x => decimal.Parse(x["Total"])).ToString();
				txtTotal.Text = Convert.ToDecimal(txtTotal.Text).ToString("#,##0.#0");

				int c = Conexion.ExecuteScalar<int>("Select Count(*)C From Cab_Cie10 Where Nro_Historia='" + nh + "'");
				optPanel.Enabled = c == 0;
				btnEliminar.Enabled = c == 0 && (Usuario.tipo == "A" || Usuario.tipo == "O");
			}
		}

		private void lstPacientes_SelectedIndexChanged( object sender, EventArgs e )
		{
			int i = General.GetSelectedIndex(lstPacientes);
			if( i > -1 )
			{
				npac = npacs[i];
				pfv(npac["Id_Paciente"]);
				txtIdPaciente.Text = npac["Id_Paciente"];
			}
		}
	}
}
