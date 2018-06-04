using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
	public partial class frmBuscaT:Form
	{
        List<Dictionary<string, string>> busts = new List<Dictionary<string, string>>();
        public Dictionary<string, string> bust = new Dictionary<string, string>();
		
        public frmBuscaT()
		{
			InitializeComponent();
		}

        public void bdv(string scon, string sapa, string sama, string snom, string stik, string sser, string dni = "", string fec = "" )
        {
			/*
            if (sapa.Length == 0 && sama.Length == 0 && snom.Length == 0 && stik.Length == 0 && scon.Length == 0 && sser.Length == 0)
            {
                sapa = "AB";
                sama = snom = "A";
            }

            if (sapa.Length == 0 && sama.Length == 0 && snom.Length >= 1)
                sapa = sama = "A";

            if (sapa.Length == 0 && snom.Length == 0 && sama.Length >= 1)
                sapa = snom = "A";

            if (sama.Length == 0 && snom.Length == 0 && sapa.Length >= 1)
                sama = snom = "A";
			*/
            int lap = sapa.Trim().Length;
            int lam = sama.Trim().Length;
            int lnm = snom.Trim().Length;
            int ltk = stik.Trim().Length;
            int lsr = sser.Trim().Length;
            int lcn = scon.Trim().Length;
			int ldn = dni.Trim().Length;
			int lfe = fec.Trim().Length;

			string sql = "Select Top 50 Descripcion As Consultorio,P.Ape_Paterno+' '+P.Ape_Materno+' '+P.Nombre As Paciente," +
						"T.Serie+'-'+T.Nro_Ticket As Ticket,T.Id_Paciente,CONVERT(VARCHAR,T.Fecha_Emision, 103) Fecha_Emision, " +
						"T.Nro_Historia,T.Anulado, " +
						"(SELECT CONVERT(DECIMAL(10,2),SUM((D.Monto*D.Cantidad)-D.Dscto)) " +
						" From Detalles D, Productos P " +
						" Where T.Nro_Historia = D.Nro_Historia " +
						" And D.Id_Producto = P.Id_Producto " +
						" And T.ForPago = '' " +
						" And T.Anulado = '') As Total " +
						"From Tickets T Inner Join Pacientes P " +
						"On T.Id_Paciente=P.Id_paciente Inner Join Consultorios C " +
						"On T.Id_Consultorio = C.Id_Consultorio Where 1 = 1 And ";
			if( ldn == 8 )
				sql += "P.DNI = '" + dni.Trim() + "' ";
			else
				sql += "P.DNI Like '" + dni.Trim() + "%' ";

			if( lfe == 10 )
				sql += "AND CONVERT(VARCHAR,T.Fecha_Emision, 103) = '" + fec.Trim() + "' ";

			if( lap > 0 )
			{
				if( sql.Contains("Like") )
					sql += "And P.Ape_Paterno Like '" + sapa + "%' ";
				else
					sql += "P.Ape_Paterno Like '" + sapa + "%' ";
			}
            if (lam > 0)
            {
                if (sql.Contains("Like"))
                    sql += "And P.Ape_Materno Like '" + sama + "%' ";
                else
                    sql += "P.Ape_Materno Like '" + sama + "%' ";
            }
            if (lnm > 0)
            {
                if (sql.Contains("Like"))
                    sql += "And P.Nombre Like '" + snom + "%' ";
                else
                    sql += "P.Nombre Like '" + snom + "%' ";
            }
            if (lsr > 0)
            {
                if (sql.Contains("Like"))
                    sql += "And T.DVenta Like '%' And T.Serie Like '" + sser + "' ";
                else
                    sql += "T.DVenta Like '%' And T.Serie Like '" + sser + "' ";
            }
            if (ltk > 0)
            {
                if (sql.Contains("Like"))
                    sql += "And T.Nro_Ticket Like '" + stik + "%' ";
                else
                    sql += "T.Nro_Ticket Like '" + stik + "%' ";
            }
            if (lcn > 0)
            {
                if (sql.Contains("Like"))
                    sql += "And C.Id_Consultorio='" + scon + "' ";
                else
                    sql += "C.Id_Consultorio='" + scon + "' ";
            }
			sql += "And Left(T.Nro_Historia,3)='" + Operativo.id_oper + "' Order By 2";
			busts = General.GetDictionaryList(sql);
            General.Fill(lstBuscar, busts, new[] { "Consultorio", "Paciente", "Ticket", "Id_Paciente", "Fecha_Emision", "Total" });
        }

        private void frmBuscaT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnCancelar_Click(btnCancelar, new EventArgs());
        }

        private void frmBuscaT_Load(object sender, System.EventArgs e)
        {
            especialidadTableAdapter.Fill(consultoriosDS.Especialidad, Operativo.id_oper);
            cmbEspecialidad.SelectedIndex = -1;
		}

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(lstBuscar, false);

			if( i != -1 )
			{
				if( lstBuscar.Items.Count > 0 )
				{
					DialogResult = DialogResult.OK;
					Close();
				}
				else
					btnCancelar_Click(btnCancelar, new EventArgs());
			}
			else
			{
				//MessageBox.Show("Debe selecciona como minimo un filtro", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				//return;
			}
        }

   		private void txtApePaterno_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
				btnCancelar_Click(btnCancelar, new EventArgs());

			if( e.KeyCode == Keys.Enter )
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
		}

		private void txtApeMaterno_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
				btnCancelar_Click(btnCancelar, new EventArgs());

			if( e.KeyCode == Keys.Enter)
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
        }

        private void txtNroTicket_KeyDown(object sender, KeyEventArgs e)
        {
			if( e.KeyCode == Keys.Escape )
				btnCancelar_Click(btnCancelar, new EventArgs());

			if( e.KeyCode == Keys.Enter)
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
        }

        private void cmbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string especialidad = cmbEspecialidad.SelectedIndex == -1 ? "": cmbEspecialidad.SelectedValue.ToString();
			bdv(especialidad, txtApePaterno.Text, txtApeMaterno.Text, txtNombres.Text, txtNroTicket.Text, txtSerie.Text.Trim(), txtDNI.Text.Trim(), txtFechaEmision.Text.Trim());
        }

        private void cmbEspecialidad_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    cmbEspecialidad.SelectedIndex = -1;
                    break;
                case Keys.Enter:
                    cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
                    break;
				case Keys.Escape:
					btnCancelar_Click(btnCancelar, new EventArgs());
					break;
			}
		}

        private void lstBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(lstBuscar);
			bust = busts[i];

            //txtFechaEmision.Text = bust["Fecha_Emision"];

            if ( bust["Anulado"] == "S")
                lblEstado.Text = "ANULADO";

            if ( bust["Anulado"] != "S" && bust["Anulado"] != "")
                lblEstado.Text = "EXTORNO";

            if ( bust["Anulado"] == "")
                lblEstado.Text = "";
        }

        private void lstBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    cmbEspecialidad.Focus();
                    break;
                case Keys.Enter:
                    btnAceptar_Click(btnAceptar, new EventArgs());
                    break;
				case Keys.Escape:
					btnCancelar_Click(btnCancelar, new EventArgs());
					break;
			}
		}

        private void lstBuscar_DoubleClick(object sender, EventArgs e)
        {
            btnAceptar_Click(btnAceptar, new EventArgs());
        }

        private void txtNombres_KeyDown(object sender, KeyEventArgs e)
        {
			if( e.KeyCode == Keys.Escape )
				btnCancelar_Click(btnCancelar, new EventArgs());

			if( e.KeyCode == Keys.Enter)
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.Cancel;
			Close();
        }

		private void txtSerie_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
				btnCancelar_Click(btnCancelar, new EventArgs());

			if( e.KeyCode == Keys.Enter )
				cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
		}

		private void txtDNI_TextChanged( object sender, EventArgs e )
		{
			if( txtDNI.Text.Trim().Length >= 8 )
				cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
		}

		private void txtFechaEmision_TextChanged( object sender, EventArgs e )
		{
			if( txtFechaEmision.Text.Trim().Length == 10 )
				cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
		}

		private void txtFechaEmision_Leave( object sender, EventArgs e )
		{
			if( txtFechaEmision.Text.Trim().Length > 4 && txtFechaEmision.Text.Trim().Length < 10 )
			{
				MessageBox.Show("Fecha debe ser completa", "Aviso al usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				txtFechaEmision.Focus();
				txtFechaEmision.Text = "";
				return;
			}
		}

		private void txtFechaEmision_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode >= Keys.D0 || e.KeyCode <= Keys.D9 )
				return;

			if( e.KeyCode == Keys.Escape )
				btnCancelar_Click(btnCancelar, new EventArgs());
			
			if( e.KeyCode == Keys.Enter )
			{			
				if( txtFechaEmision.Text.Trim().Length == 10 )
					cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
				else
					txtFechaEmision_Leave(txtFechaEmision, new EventArgs());
			}
		}

		private void txtDNI_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
				e.Handled = true;
		}
	}
}
