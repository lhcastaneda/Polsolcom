using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Connection;

namespace Polsolcom.Forms
{
	public partial class frmChangeClave : Form
    {
        string vSQL = "";
        
        public frmChangeClave()
        {
            InitializeComponent();
        }

        private void frmChangeClave_Load(object sender, EventArgs e)
        {
            txtAnterior.Text = General.cryptgr(General.cryptgr(Usuario.clave, false, 2), false, 1);
        }

        private void cmdCambiar_Click(object sender, EventArgs e)
        {
            string vNueva = txtNueva.Text.Trim(); 
            string vConfirma = txtConfirma.Text.Trim();

            if ( vNueva == txtAnterior.Text )
            {
                MessageBox.Show("Contraseña anterior no puede ser igual a la nueva.", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				DialogResult = DialogResult.Cancel;
                txtNueva.Focus();
                return;
            }

            if ( vNueva.Length < 8  )
            {
                MessageBox.Show("Contraseña debe ser mayor a 8 caracteres.", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				DialogResult = DialogResult.Cancel;
                txtNueva.Focus();
                return;
            }

            if ( vNueva != vConfirma )
            {
                MessageBox.Show("Error en la confirmacion de contraseña ...", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				DialogResult = DialogResult.Cancel;
                txtConfirma.Focus();
                return;
            }

            if ( General.ValidaPass(vNueva) != true )
            {
                MessageBox.Show("Contraseña SOLO debe contener mayusculas, minusculas y numeros", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				DialogResult = DialogResult.Cancel;
                txtNueva.Focus();
                return;
            }

            if ( General.ValidaPass(vConfirma) != true )
            {
                MessageBox.Show("Contraseña SOLO debe contener mayusculas, minusculas y numeros", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				DialogResult = DialogResult.Cancel;
                txtConfirma.Focus();
                return;
            }

            vNueva = General.cryptgr(General.cryptgr(vNueva, true, 1), true, 2);
            try
            {
                vSQL = "UPDATE sysaccusers ";
                vSQL = vSQL + " SET Us_Log = '" + @vNueva + "' ";
                vSQL = vSQL + " WHERE Id_Us = '" + Usuario.id_us + "' ";
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
                MessageBox.Show("Actualizacion satisfactoria.", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				DialogResult = DialogResult.OK;
				Close();
            }
            catch ( SqlException ex )
            {
                MessageBox.Show(ex.Message);
				DialogResult = DialogResult.Cancel;
                return;
            }
        }

        private void txtNueva_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
            {
                if ( txtNueva.Text.Trim().Length == 0 )
                    return;
                
                txtConfirma.Focus();
                e.Handled = true;
            }

            if ( e.KeyCode == Keys.Escape )
            {
				DialogResult = DialogResult.Cancel;
				Close();
            }
            
        }

        private void txtConfirma_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
            {
                if ( txtConfirma.Text.Trim().Length == 0 )
                    return;

                cmdCambiar.Focus();
                e.Handled = true;
            }

            if ( e.KeyCode == Keys.Escape )
            {
				DialogResult = DialogResult.Cancel;
				Close();
            }
        }

        private void cmdCambiar_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
				DialogResult = DialogResult.Cancel;
				Close();
            }
        }

        private void txtNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsUpper(e.KeyChar) && !char.IsLower(e.KeyChar) )
                e.Handled = true;
        }

        private void txtConfirma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsUpper(e.KeyChar) && !char.IsLower(e.KeyChar) )
                e.Handled = true;
        }
                     
    }
}
