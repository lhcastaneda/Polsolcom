using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
	public partial class frmVerificaCie : Form
    {
        public string nroTicket = "";
        List<Dictionary<string, string>> items;

        public frmVerificaCie(List<Dictionary<string, string>> items)
        {
            InitializeComponent();
            this.items = items;

            for (int i = 0; i < this.items.Count; i++)
                this.items[i]["Digitador"] = General.TradUser(this.items[i]["Digitador"]);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int index = General.GetSelectedIndex(lstMostrarDatos);
			nroTicket = items[index]["Nro_Ticket"];
			DialogResult = DialogResult.OK;
			Close();
        }

        private void frmVerificaCie_Load(object sender, EventArgs e)
        {
            if ( items.Count > 0)
            {
                General.Fill(lstMostrarDatos, items, new[] { "Serie", "Nro_Ticket", "Fecha_Atencion", "CMP", "Bus", "Consultorio", "Turno", "Digitador", "Cie10", "Procedimiento", "Nro_Historia", "Diagnostico" });

                txtEspecialidad.Text = lstMostrarDatos.Items[0].SubItems["Consultorio"].Text;
                txtCMP.Text = lstMostrarDatos.Items[0].SubItems["CMP"].Text;
                txtDigitador.Text = lstMostrarDatos.Items[0].SubItems["Digitador"].Text;
                txtToTing.Text = items.Count.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			nroTicket = "";
			DialogResult = DialogResult.Cancel;
			Close();
        }

        private void frmVerificaCie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnCancelar_Click(btnCancelar, new EventArgs());
        }

        private void lstMostrarDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index = General.GetSelectedIndex(lstMostrarDatos);
				nroTicket = items[index]["Nro_Ticket"];
				DialogResult = DialogResult.OK;
				Close();
            }
        }

		private void btnEliminar_Click( object sender, EventArgs e )
		{

		}
	}
}
