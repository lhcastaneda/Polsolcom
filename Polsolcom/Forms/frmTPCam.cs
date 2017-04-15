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
using Polsolcom.Clases;
using Microsoft.VisualBasic;

namespace Polsolcom.Forms
{
    public partial class frmTPCam : Form
    {
        string vSQL = "";

        public frmTPCam()
        {
            InitializeComponent();
        }

        private void frmTPCam_Load(object sender, EventArgs e)
        {
            txtFecha.Mask = "00/00/0000";
            txtFecha.ValidatingType = typeof(System.DateTime);
                        
            vSQL = "SELECT CONVERT(varchar, MAX(Fecha), 103), ";
            vSQL = vSQL + " FORMAT(MAX(c_dolar),'#0.#0'),";
            vSQL = vSQL + " FORMAT(MAX(c_euro),'#0.#0')";
            vSQL = vSQL + " FROM Cambio WHERE Fecha >= (SELECT MAX(Fecha) FROM Cambio)";
            Conexion.CMD.CommandText = vSQL;
            using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
            {
                string vRes = "";
                string vDol = "";
                string vEur = "";

                if ( drLectura.HasRows )
                {
                    while ( drLectura.Read() )
                    {
                        vRes = drLectura.GetValue(0).ToString();
                        vDol = drLectura.GetValue(1).ToString();
                        vEur = drLectura.GetValue(2).ToString();
                    }
                }
                drLectura.Close();

                if ( vRes == "0" || vRes == "" || vRes == null )
                {
                    txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    txtUSD.Text = "0.00";
                    txtEURO.Text = "0.00";
                    txtUSD.Focus();
                }
                else
                {
                    if ( vRes == DateTime.Now.ToString("dd/MM/yyyy") )
                    {
                        if ( MessageBox.Show("Ya existe tipo de cambio para esta fecha." + (char)13 + "Desea ingresar uno nuevo..?", "Tipo de Cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes )
                            txtFecha.Enabled = true;
                    }
                    txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    txtUSD.Text = vDol;
                    txtEURO.Text = vEur;
                    txtFecha.Focus();
                }
            }
        }

        private void txtUSD_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if ( e.KeyCode == Keys.Enter )
            {
                if ( txtUSD.Text.Trim().Length == 0 )
                    return;

                txtEURO.Focus();
                e.Handled = true;
            }
        }

        private void txtEURO_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if ( e.KeyCode == Keys.Enter )
            {
                if ( txtEURO.Text.Trim().Length == 0 )
                    return;

                btnAceptar.Focus();
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if ( txtFecha.Text.Trim() == "" )
            {
                MessageBox.Show("Fecha no puede estar en blanco.", "Tipo de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtFecha.Focus();
                return;
            }

            if ( txtUSD.Text.Trim() == "" )
            {
                MessageBox.Show("Ingrese tipo de cambio a dolares.", "Tipo de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtUSD.Focus();
                return;
            }

            if ( txtEURO.Text.Trim() == "" )
            {
                MessageBox.Show("Ingrese tipo de cambio a euros.", "Tipo de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtEURO.Focus();
                return;
            }

            try
            {
                vSQL = "INSERT INTO Cambio VALUES ";
                vSQL = vSQL + "( CONVERT(smalldatetime, '" + txtFecha.Text.Trim() + "',103),";
                vSQL = vSQL + " " + txtUSD.Text.Trim() + ",";
                vSQL = vSQL + " " + txtEURO.Text.Trim() + ",";
                vSQL = vSQL + " '" + Usuario.id_us + "',";
                vSQL = vSQL + " '" + Operativo.id_oper + "')";
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
                MessageBox.Show("Actualizacion satisfactoria.", "Tipo de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch ( SqlException ex )
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtUSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') )
                e.Handled = true;
           
            //solo acepta 1 punto decimal
            if ( (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1) )
                e.Handled = true;
        }

        private void txtEURO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') )
                e.Handled = true;

            if ( (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1) )
                e.Handled = true;
        }

        private void txtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if ( e.KeyCode == Keys.Enter )
            {
                if ( txtFecha.Text.Trim().Length == 0 )
                    return;

                txtUSD.Focus();
                e.Handled = true;
            }
        }

        private void txtFecha_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if ( !e.IsValidInput )
            {
                MessageBox.Show("Fecha debe tener formato dd/MM/yyyy", "Tipo de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtFecha.Focus();
                return;
            }
        }
    }
}
