using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Polsolcom.Clases;
using Microsoft.VisualBasic;

namespace Polsolcom.Forms
{
	public partial class frmTalonario : Form
    {
		//define variable para sentencias SQL
        string vSQL = "";
        string sCantTalon = "";
        string sMaxNInicial = "";
        string sMaxNFinal = "";
                
        public frmTalonario()
        {
            InitializeComponent();
        }

        private void frmTalonario_Load(object sender, EventArgs e)
        {
            CargaDatosDefault();
            General.ttMensaje.InitialDelay = 0;
            General.ttMensaje.IsBalloon = false;
			cmbDocVenta.Focus();
        }

        private void CargaDatosDefault()
        {
            //Carga valores por defecto
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            cmbDefault.SelectedIndex = 0;

            if (Usuario.tipo == "A")
                cmbDefault.Enabled = true;
            else
                cmbDefault.Enabled = false;

            txtSerie.Text = Talon.serie;
            General.CargaTipoDocVenta(cmbDocVenta);
            cmbDocVenta.Focus();

            //trae los valores maximos de inicio y fin del talonario
            vSQL = "SELECT MAX(CONVERT(int, ninicial)), MAX(CONVERT(int, nfinal)) ";
            vSQL = vSQL + " FROM Talon ";
            Conexion.CMD.CommandText = vSQL;
            using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
            {
                if ( drLectura.HasRows )
                {
                    while ( drLectura.Read() )
                    {//asigna valor minimo y maximo del talonario
                        sMaxNInicial = drLectura.GetValue(0).ToString();
                        sMaxNFinal = drLectura.GetValue(1).ToString();
                    }
                }
                drLectura.Close();
            }

        }

        private void txtSerie_KeyDown(object sender, KeyEventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

			//si se presiona ENTER mueve al siguiente control
            if ( e.KeyCode == Keys.Enter )
            {
                if ( txtSerie.Text.Trim().Length == 0 )
                    return;

                txtNInicial.Focus();
                e.Handled = true;
            }
        }

        private void txtNInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if ( e.KeyCode == Keys.Enter )
            {
                if ( txtNInicial.Text.Trim().Length == 0 )
                    return;

                txtNFinal.Focus();
                e.Handled = true;
            }
        }

        private void txtNFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if ( e.KeyCode == Keys.Enter )
            {
                if ( txtNFinal.Text.Trim().Length == 0 )
                    return;

                cmbIngresar.Focus();
                e.Handled = true;
            }
        }

        private void cmbDocVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( !(cmbDocVenta.SelectedIndex == -1) )
                txtSerie.Focus();
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
			//solo acepta numeros enteros sin digito
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') )
                e.Handled = true;
        }

        private void txtNInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') )
                e.Handled = true;
        }

        private void txtNFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') )
                e.Handled = true;
        }

        private void cmbIngresar_Click(object sender, EventArgs e)
        {
			//se define por defecto el resultado de la accion como cancelado
            this.DialogResult = DialogResult.Cancel;
            if ( cmbDocVenta.SelectedIndex == -1 )
            {
                MessageBox.Show("Debe seleccionar un tipo de documento", "Ingreso de Talonario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cmbDocVenta.Focus();
                return;
            }

            if ( txtSerie.Text.Trim() == "" )
            {
                MessageBox.Show("Debe ingresar una serie", "Ingreso de Talonario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtSerie.Focus();
                return;
            }

            if ( txtNInicial.Text.Trim() == "" )
            {
                MessageBox.Show("Debe ingresar un talon inicial", "Ingreso de Talonario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtNInicial.Focus();
                return;
            }

            if ( txtNFinal.Text.Trim() == "" )
            {
                MessageBox.Show("Debe ingresar un talon final", "Ingreso de Talonario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtNFinal.Focus();
                return;
            }

            if ( txtSerie.Text.Trim() != Talon.serie )
            {
                if ( MessageBox.Show("Serie no corresponde al operativo en uso. Desea ingresarlo..?", "Ingreso de Talonario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No )
                    txtSerie.Text = Talon.serie;
            }

            if ( Conversion.Val(txtNFinal.Text.ToString()) < Conversion.Val(txtNInicial.Text.ToString()) )
            {
                MessageBox.Show("Talon inicial no puede ser mayor que el final", "Ingreso de Talonario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtNInicial.Focus();
                return;
            }

            //Trae los valores del documento seleccionado
            Item itm = (Item)cmbDocVenta.SelectedItem;
            string sDef = (cmbDefault.Text == "SI" ? "" : "");
                        
			//valida que no haya valores del talonario abiertos
            vSQL = "SELECT COUNT(*) C ";
            vSQL = vSQL + " FROM Talon ";
            vSQL = vSQL + " WHERE Id_Oper = '" + Operativo.id_oper + "' ";
            vSQL = vSQL + " AND DVenta = '" + itm.Value + "' ";
            vSQL = vSQL + " AND TDef = '" + sDef + "' ";
            vSQL = vSQL + " AND LTRIM(RTRIM(Usuario)) = '" + Usuario.id_us + "' ";
            vSQL = vSQL + " AND LEN(NCon) > 0 ";
            Conexion.CMD.CommandText = vSQL;
            using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
            {
                if ( drLectura.HasRows )
                {
                    while ( drLectura.Read() )
                        sCantTalon = drLectura.GetValue(0).ToString();
                }
                drLectura.Close();
            }

            if ( sCantTalon != "0" )
            {
                MessageBox.Show("Tiene un rango abierto, en esa modalidad y tipo de documento de venta. Cierrelo...", "Ingreso de Talonario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

            vSQL = "SELECT * ";
            vSQL = vSQL + " FROM Talon ";
            vSQL = vSQL + " WHERE Id_Oper = '" + Operativo.id_oper + "' ";
            vSQL = vSQL + " AND DVenta = '" + itm.Value + "' ";
            vSQL = vSQL + " AND serie = '" + txtSerie.Text.ToString() + "' ";
            vSQL = vSQL + " AND TDef = '" + sDef + "' ";
            vSQL = vSQL + " ORDER BY 2,3 ";
            Conexion.CMD.CommandText = vSQL;
            using ( SqlDataReader dr = Conexion.CMD.ExecuteReader() )
            {
                string sUser = "";
                string sFecTalon = "";

                if ( dr.HasRows )
                {
                    while ( dr.Read() )
                    {//valida que el rango del talonario a usar no este siendo usado por alguien mas
                        sUser = General.DevuelveUsuario(dr.GetValue(0).ToString());
                        sFecTalon = dr.GetValue(1).ToString().Substring(0, 10);

                        if ( (Convert.ToInt32(txtNInicial.Text) >= Convert.ToInt32(dr.GetValue(2).ToString())) && (Convert.ToInt32(txtNInicial.Text) <= Convert.ToInt32(dr.GetValue(3).ToString())) && (Convert.ToInt32(txtSerie.Text) == Convert.ToInt32(dr.GetValue(5).ToString())) && (itm.Value == Convert.ToInt32(dr.GetValue(6).ToString())) && (dr.GetValue(8).ToString() == sDef) )
                        {
                            MessageBox.Show("Numero inicial corresponde al rango de " + sUser + " en la fecha de " + sFecTalon + " en la serie " + dr.GetValue(5).ToString() + (char)13 + "Modifique el rango...", "Ingreso de Talonario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            txtNInicial.Focus();
                            return;
                        }

                        if ( (Convert.ToInt32(txtNFinal.Text) >= Convert.ToInt32(dr.GetValue(2).ToString())) && (Convert.ToInt32(txtNFinal.Text) <= Convert.ToInt32(dr.GetValue(3).ToString())) && (Convert.ToInt32(txtSerie.Text) == Convert.ToInt32(dr.GetValue(5).ToString())) && (itm.Value == Convert.ToInt32(dr.GetValue(6).ToString())) && (dr.GetValue(8).ToString() == sDef) )
                        {
                            MessageBox.Show("Numero final corresponde al rango de " + sUser + (char)13 + " en la fecha de " + sFecTalon + " en la serie " + dr.GetValue(5).ToString() + (char)13 + "Modifique el rango...", "Ingreso de Talonario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            txtNFinal.Focus();
                            return;
                        }

                        int i = Convert.ToInt32(txtNInicial.Text);
                        while ( i <= Convert.ToInt32(txtNFinal.Text) )
                        {
                            if ( (i >= Convert.ToInt32(dr.GetValue(2).ToString())) && (i <= Convert.ToInt32(dr.GetValue(3).ToString())) && (Information.IsNumeric(txtSerie.Text) ? (Convert.ToInt32(txtSerie.Text) == Convert.ToInt32(dr.GetValue(5).ToString())) : (txtSerie.Text == dr.GetValue(5).ToString())) && (itm.Value == Convert.ToInt32(dr.GetValue(6).ToString())) && (dr.GetValue(8).ToString() == sDef) )
                            {
                                MessageBox.Show("El rango de " + i + " a " + dr.GetValue(3).ToString() + " le corresponde a " + sUser + " en la fecha de " + sFecTalon + " en la serie " + dr.GetValue(5).ToString() + (char)13 + "Modifique el rango...", "Ingreso de Talonario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                txtNInicial.Focus();
                                return;
                            }
                            i = i + 1;
                        }
                    }
                }
                dr.Close();
            }

            Talon.serie = (itm.Value == 3 ? Talon.serie : txtSerie.Text.Trim());

            try
            {//registra el nuevo rango de talonario para el usuario
                vSQL = "INSERT INTO Talon VALUES ( ";
                vSQL = vSQL + "'" + Usuario.id_us + "', ";
                vSQL = vSQL + "'" + txtFecha.Text.Substring(6, 4) + txtFecha.Text.Substring(3, 2) + txtFecha.Text.Substring(0,2) + ' ' + txtFecha.Text.Substring(11,8) + "', ";
                vSQL = vSQL + "'" + txtNInicial.Text + "', ";
                vSQL = vSQL + "'" + txtNFinal.Text  + "', ";
                vSQL = vSQL + "'" + Operativo.id_oper + "', ";
                vSQL = vSQL + "'" + txtSerie.Text + "', ";
                vSQL = vSQL + "'" + itm.Value + "', ";
                vSQL = vSQL + "'', ";
                vSQL = vSQL + "'' ) ";
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
                MessageBox.Show("Actualizacion satisfactoria.", "Ingreso de Talonario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch ( SqlException ex )
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void txtNInicial_Leave(object sender, EventArgs e)
        {
            if ( txtNInicial.Text.Trim() != "" )
                txtCuenta.Text = "0";
        }

        private void cmbDocVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if ( e.KeyCode == Keys.Enter )
            {
                txtSerie.Focus();
                e.Handled = true;
            }

        }
                      
        private void txtNFinal_Enter(object sender, EventArgs e)
        {
            General.ttMensaje.Show(string.Empty, txtNFinal);
            General.ttMensaje.Show("Talon Final MAX: " + sMaxNFinal, txtNFinal, 0);
        }

        private void txtNInicial_Enter(object sender, EventArgs e)
        {
            General.ttMensaje.Show(string.Empty, txtNInicial);
            General.ttMensaje.Show("Talon Inicial MAX: " + sMaxNInicial, txtNInicial, 0);
        }
    }
}
