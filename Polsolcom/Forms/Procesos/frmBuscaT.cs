using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;

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

        public void bdv(string scon, string sapa, string sama, string snom, string stik, string sser)
        {
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

            this.busts = General.GetDictionaryList(sql);
            General.Fill(lstBuscar, this.busts, new[] { "Consultorio", "Paciente", "Ticket", "Id_Paciente", "Fecha_Emision" });
        }

        private void frmBuscaT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancelar_Click(btnCancelar, new EventArgs());
            }
        }

        private void frmBuscaT_Load(object sender, System.EventArgs e)
        {
            especialidadTableAdapter.Fill(consultoriosDS.Especialidad, Operativo.id_oper);
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(lstBuscar, false);

            if (i > -1)
            {
                if (lstBuscar.Items.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    btnCancelar_Click(btnCancelar, new EventArgs());
                }
            }
        }

   		private void txtApePaterno_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Enter )
			{
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
			}
		}

		private void txtApeMaterno_KeyDown( object sender, KeyEventArgs e )
		{
            if (e.KeyCode == Keys.Enter)
            {
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
            }
        }

        private void txtNroTicket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
            }
        }

        private void cmbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string especialidad = cmbEspecialidad.SelectedIndex == -1 ? "": cmbEspecialidad.SelectedValue.ToString();

            this.bdv(especialidad, txtApePaterno.Text, txtApeMaterno.Text, txtNombres.Text, txtNroTicket.Text, txtSerie.Text);
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
            }
        }

        private void lstBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = General.GetSelectedIndex(lstBuscar);
            this.bust = this.busts[i];

            txtFechaEmision.Text = this.bust["Fecha_Emision"];

            if (this.bust["Anulado"] == "S")
            {
                lblEstado.Text = "ANULADO";
            }

            if (this.bust["Anulado"] != "S" && this.bust["Anulado"] != "")
            {
                lblEstado.Text = "EXTORNO";
            }

            if (this.bust["Anulado"] == "")
            {
                lblEstado.Text = "";
            }
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
            }
        }

        private void lstBuscar_DoubleClick(object sender, EventArgs e)
        {
            btnAceptar_Click(btnAceptar, new EventArgs());
        }

        private void txtNombres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbEspecialidad_SelectionChangeCommitted(cmbEspecialidad, new EventArgs());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
