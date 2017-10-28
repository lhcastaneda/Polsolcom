using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;
using Polsolcom.Forms.Procesos;
using static Polsolcom.Forms.Procesos.frmSHClinica;

namespace Polsolcom.Forms.Procesos
{
	public partial class frmBuscar : Form
	{
        public CpaDelegate CpaCallback;
        public HabDelegate HabCallback;
        public BusDelegate BusCallback;
        public Dictionary<string, string> bpac = new Dictionary<string, string>();
        List<Dictionary<string, string>> bpacs = new List<Dictionary<string, string>>();
        public int odb;

        public frmBuscar(int odb)
		{
			InitializeComponent();
            this.odb = odb;
		}

        public void bpa()
        {
            string sql = General.DevuelveQueryPaciente(txtApePaterno.Text, txtApeMaterno.Text, txtNombres.Text, txtDNI.Text, "", "", 2, this.odb);

            if (sql.Length > 0)
            {
                this.bpacs = General.GetDictionaryList(sql);
                if (this.odb == 0)
                {
                    General.Fill(lstBuscar, this.bpacs, new[] { "Paciente", "Id_Paciente", "DNI" });
                }
                else
                {
                    General.Fill(lstBuscar, this.bpacs, new[] { "Paciente", "Ubigeo", "DNI" });
                }
            }

            btnAceptar.Enabled = true;
        }

        private void frmBuscar_Load( object sender, EventArgs e )
		{
			this.Text = this.Text + "Conexion a BD general: " + (this.odb == 0? "OFF" : "ON");
            General.setAll<TextBox, string>(this, "Text", "");
            this.bpa();

            if (this.odb == 1)
            {
                btnAceptar.Enabled = false;
            }

            txtDNI.Focus();
        }

		private void frmBuscar_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}
       
		private void txtApePaterno_TextChanged( object sender, EventArgs e )
		{
            if (this.odb == 0)
            {
                this.bpa();
            }
        }

		private void txtApeMaterno_TextChanged( object sender, EventArgs e )
		{
            if (this.odb == 0)
            {
                this.bpa();
            }
        }

        private void txtNombres_TextChanged( object sender, EventArgs e )
		{
            if (this.odb == 0 || txtNombres.Text.Length > 0)
            {
                this.bpa();
            }
		}

		private void txtDNI_TextChanged( object sender, EventArgs e )
		{
            if(txtDNI.Text.Length > 0)
            {
                this.bpa();
            }
        }

        private void txtDNI_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
				e.Handled = true;
		}

		private void txtNombres_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
			else if( e.KeyCode == Keys.Enter )
            { 
			}
		}

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lstBuscar.Items.Count > 0)
            {
                if (this.odb == 0)
                {
                    if (this.bpac["Asegurado"] == "A")
                    {
                        MessageBox.Show("El registro esta anulado, consulte con el administrador del sistema ...", "Advertencia");
                        btnCancelar_Click(btnCancelar, new EventArgs());
                        return;
                    }

                    BusCallback(this.bpac, 0);
                    CpaCallback(0, false);
                }
                else
                {
                    BusCallback(this.bpac, 1);
                    HabCallback(0);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                btnCancelar_Click(btnCancelar, new EventArgs());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lstBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    txtApePaterno.Focus();
                    return;
                case Keys.Enter:
                    btnAceptar_Click(btnAceptar, new EventArgs());
                    break;
            }
        }

        private void lstBuscar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnAceptar_Click(btnAceptar, new EventArgs());
        }

        private void lstBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = General.GetSelectedIndex(lstBuscar);
            this.bpac = this.bpacs[index];
        }

        private void txtDNI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDNI_TextChanged(txtDNI, new EventArgs());
            }
        }

        private void frmBuscar_Shown(object sender, EventArgs e)
        {
            txtDNI.Focus();
        }
    }
}
