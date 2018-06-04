using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            string sql = General.DevuelveQueryPaciente(txtApePaterno.Text, txtApeMaterno.Text, txtNombres.Text, txtDNI.Text, "", "", 2, odb);
            if (sql.Length > 0)
            {
				bpacs = General.GetDictionaryList(sql);
                if ( odb == 0)
                    General.Fill(lstBuscar, bpacs, new[] { "Paciente", "Id_Paciente", "DNI" });
                else
                    General.Fill(lstBuscar, bpacs, new[] { "Paciente", "Ubigeo", "DNI" });
            }
            btnAceptar.Enabled = true;
        }

        private void frmBuscar_Load( object sender, EventArgs e )
		{
			Text = Text + "Conexion a BD general: " + (odb == 0? "OFF" : "ON");
            General.setAll<TextBox, string>(this, "Text", "");
			bpa();

            if ( odb == 1)
                btnAceptar.Enabled = false;

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
            if ( odb == 0)
				bpa();
        }

		private void txtApeMaterno_TextChanged( object sender, EventArgs e )
		{
            if ( odb == 0)
				bpa();
        }

        private void txtNombres_TextChanged( object sender, EventArgs e )
		{
            if ( odb == 0 || txtNombres.Text.Length > 0)
				bpa();
		}

		private void txtDNI_TextChanged( object sender, EventArgs e )
		{
            if(txtDNI.Text.Length > 0)
				bpa();
        }

        private void txtDNI_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !char.IsControl(e.KeyChar) &&  !char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
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
                if ( odb == 0)
                {
                    if ( bpac["Asegurado"] == "A")
                    {
                        MessageBox.Show("El registro esta anulado, consulte con el administrador del sistema ...", "Advertencia");
                        btnCancelar_Click(btnCancelar, new EventArgs());
                        return;
                    }
                    BusCallback(bpac, 0);
                    CpaCallback(0, false);
                }
                else
                {
                    BusCallback(bpac, 1);
                    HabCallback(0);
                }
				DialogResult = DialogResult.OK;
				Close();
            }
            else
                btnCancelar_Click(btnCancelar, new EventArgs());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.Cancel;
			Close();
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
			bpac = bpacs[index];
        }

        private void txtDNI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDNI_TextChanged(txtDNI, new EventArgs());
        }

        private void frmBuscar_Shown(object sender, EventArgs e)
        {
            txtDNI.Focus();
		}


	}
}
