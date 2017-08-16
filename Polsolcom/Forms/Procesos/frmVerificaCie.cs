using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            {
                this.items[i]["Digitador"] = General.TradUser(this.items[i]["Digitador"]);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int index = General.GetSelectedIndex(lstMostrarDatos);
            this.nroTicket = this.items[index]["Nro_Ticket"];
            this.Close();
        }

        private void frmVerificaCie_Load(object sender, EventArgs e)
        {
            if (this.items.Count > 0)
            {
                General.FillListView(lstMostrarDatos, this.items, new[] { "Serie", "Nro_Ticket", "Fecha_Atencion", "CMP", "Bus", "Consultorio", "Turno", "Digitador", "Cie10", "Procedimiento", "Nro_Historia", "Diagnostico" });

                txtEspecialidad.Text = lstMostrarDatos.Items[0].SubItems["Consultorio"].Text;
                txtCMP.Text = lstMostrarDatos.Items[0].SubItems["CMP"].Text;
                txtDigitador.Text = lstMostrarDatos.Items[0].SubItems["Digitador"].Text;
                txtToTing.Text = this.items.Count.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.nroTicket = "";
            this.Close();
        }

        private void frmVerificaCie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.nroTicket = "";
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void lstMostrarDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index = General.GetSelectedIndex(lstMostrarDatos);
                this.nroTicket = this.items[index]["Nro_Ticket"];
                this.Close();
            }
        }
    }
}
