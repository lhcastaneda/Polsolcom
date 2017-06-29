﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Connection;

namespace Polsolcom.Forms
{
	public partial class frmLogin : Form
    {
        public static string vSQL = "";
        public static string sSerie = "";
        public static int nroVeces = 1;
        public static string sFecTalon = "";
        public static string sNroTicket = "";
        public static bool bBlanco = false;
        
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //abre la conexion a la BD
                Conexion.CNN = Conexion.ConectaBD();
                if ( Conexion.CNN.State != ConnectionState.Open )  
                {
                    MessageBox.Show("No se pudo realizar la conexion a la BD." + (char)13 + "Contactar al admnistrador de sistemas.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Application.Exit();
                }

                //crea el comando para ejecutar las sentencias SQL
                Conexion.CMD.Connection = Conexion.CNN;

                General.LlenaOperativo();

                txtOperativo.Text = Operativo.descripcion;

                //consulta que trae los datos del usuario, tipo de usuario y nombre
                vSQL = "SELECT key_pass AS usuario, type AS tipo, Nombres + ' ' + Ape_Paterno + ' ' + Ape_Materno AS nombre ";
                vSQL = vSQL + "FROM sysaccusers S INNER JOIN Personal P ";
                vSQL = vSQL + "ON S.Id_Per = P.Id_Personal INNER JOIN ";
                vSQL = vSQL + "(SELECT id_tipo, descripcion FROM tablatipo ";
                vSQL = vSQL + "WHERE id_tabla IN (SELECT id_tipo FROM tablatipo ";
                vSQL = vSQL + "WHERE LTRIM(RTRIM(descripcion)) = 'ESTADO_REGISTRO')) E ";
                vSQL = vSQL + "On S.State=E.Id_Tipo ";
                vSQL = vSQL + "WHERE LTRIM(RTRIM(E.Descripcion))='ACTIVADO' ";
                Conexion.CMD.CommandText = vSQL;
                using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
                {
                    if ( drLectura.HasRows )
                    {
                        //carga usuarios combo
                        while ( drLectura.Read() )
                        {
                            var vValue = drLectura.GetValue(0);
                            string vR = General.cryptgr(vValue.ToString(), false, 1);
                            cmbUsuario.Items.Add(vR + " - " + drLectura.GetValue(2).ToString());
                        }
                        cmbUsuario.SelectedIndex = -1;
                        cmbUsuario.Focus();
                        drLectura.Close();
                    }
                    else
                    {
                        MessageBox.Show( "La BD no tiene usuarios." + (char)13 + "Contactar al admnistrador de sistemas.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1 );
                        Application.Exit();
                    }
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if( cmbUsuario.SelectedIndex == -1 )
                {
                    MessageBox.Show("Debe seleccionar un usuario.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }

                if ( txtClave.Text.Trim() == "" )
                {
                    MessageBox.Show("Debe ingresar una contraseña.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }

                if ( txtOperativo.Text.Trim() == "" )
                {
                    MessageBox.Show("Debe existir un Operativo.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                
                string vKey_Pass = cmbUsuario.Text.Trim().Substring(0,Strings.InStr(cmbUsuario.Text, "-", CompareMethod.Text) - 1);
                vKey_Pass = @General.cryptgr(vKey_Pass, true, 1);

                //consulta que trae los datos completos del usuario 
                vSQL = "SELECT Id_Us,Key_Pass AS Usuario,Us_Log AS Clave, ";
                vSQL = vSQL + "Type AS Tipo, CASE WHEN Nombres IS NULL ";
                vSQL = vSQL + "THEN 'Root' ELSE Nombres +' '+ Ape_Paterno +' '+ Ape_Materno END AS Descripcion,S.Id_Area, ";
                vSQL = vSQL + "CASE WHEN C.Descripcion IS NULL  ";
                vSQL = vSQL + "THEN 'Root' ELSE C.Descripcion END AS Cargo ";
                vSQL = vSQL + "FROM sysaccusers S LEFT JOIN Personal P ";
                vSQL = vSQL + "ON S.Id_Per = P.Id_Personal ";
                vSQL = vSQL + "LEFT JOIN (SELECT Id_Tipo, Descripcion ";
                vSQL = vSQL + "FROM TablaTipo WHERE Id_Tabla IN  ";
                vSQL = vSQL + "(SELECT Id_Tipo FROM TablaTipo ";
                vSQL = vSQL + " WHERE LTrim(RTrim(Descripcion)) = 'CARGO'  ";
                vSQL = vSQL + " AND LTrim(RTrim(Id_Tabla)) = '0')) C  ";
                vSQL = vSQL + " ON P.Id_Cargo = C.Id_Tipo ";
                vSQL = vSQL + " WHERE Key_Pass = '" + @vKey_Pass + "' ";
                Conexion.CMD.CommandText = vSQL;
                using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
                {
                    if ( drLectura.HasRows )
                        General.LlenaUsuario(drLectura);
                    else
                    {
                        MessageBox.Show("No se tiene datos del usuario." + (char)13 + "Contactar al admnistrador de sistemas.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Application.Exit();
                    }
                }

                if ( txtClave.Text.Trim() == General.cryptgr(General.cryptgr(Usuario.clave, false, 2), false, 1) )
                {
                    MessageBox.Show("Bienvenido(a) " + Usuario.descripcion + " - " + General.cryptgr(Usuario.usuario, false, 1), "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if ( txtClave.Text.Trim().Length < 8)
                    {
                        MessageBox.Show("Contraseña no cumple con protocolos de seguridad ...", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        frmChangeClave fr = new frmChangeClave();
Regresa:
                        fr.ShowDialog();

                        if ( fr.DialogResult != DialogResult.OK )
                        {
                            MessageBox.Show("No puede continuar porque debe cambiar la contraseña", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            goto Regresa;
                        }
                    }

                    //usuario tipo administracion o computo
                    if ( Usuario.id_area == "25" || Usuario.id_area == "27" )
                    {
                        //valida que existe tipo de cambio para la fecha actual
                        vSQL = "SELECT COUNT(*) ";
                        vSQL = vSQL + " FROM cambio ";
                        vSQL = vSQL + " WHERE CONVERT(varchar, fecha, 103) BETWEEN CONVERT(varchar, GETDATE(), 103) AND CONVERT(varchar, GETDATE()+1, 103) ";
                        Conexion.CMD.CommandText = vSQL;
                        using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
                        {
                            string vRes = "";
                            if ( drLectura.HasRows )
                            {
                                while ( drLectura.Read() )
                                    vRes = drLectura.GetValue(0).ToString();
                            }
                            drLectura.Close();

                            if ( vRes == "0" )
                                if ( MessageBox.Show("Desea Ingresar tipo de Cambio ... ?", "Tipo de Cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes )
                                {
                                    frmTPCam fr = new frmTPCam();
                                    fr.ShowDialog();
                                }
                        }
                    }
                    
                    //consulta que trae los datos de las series que son las autorizaciones
                    //para cada una de las ticketeras de pago
                    vSQL = "SELECT Serie FROM ";
                    vSQL = vSQL + " (SELECT Serie ";
                    vSQL = vSQL + "  FROM Serie ";
                    vSQL = vSQL + "  WHERE Fec_Ins IN ";
                    vSQL = vSQL + "  (SELECT MAX(Fec_Ins) ";
                    vSQL = vSQL + "   FROM Serie ";
                    vSQL = vSQL + "   WHERE Id_Oper = '" + Operativo.id_oper + "') ";
                    vSQL = vSQL + "  AND Id_Oper = '" + Operativo.id_oper + "' ";
                    vSQL = vSQL + "  UNION ALL SELECT Serie ";
                    vSQL = vSQL + "  FROM Tickets ";
                    vSQL = vSQL + "  WHERE Digitador = '" + Usuario.id_us + "' ";
                    vSQL = vSQL + "  AND Fecha_Emision = ";
                    vSQL = vSQL + "  (SELECT Max(Fecha_Emision) ";
                    vSQL = vSQL + "   FROM Tickets ";
                    vSQL = vSQL + "   WHERE Digitador = '" + Usuario.id_us + "')) X ";
                    vSQL = vSQL + " GROUP BY Serie ";
                    vSQL = vSQL + " ORDER BY Count(Serie) DESC ";
                    Conexion.CMD.CommandText = vSQL;
                    using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
                    {
                        if ( drLectura.HasRows )
                        {
                            while ( drLectura.Read() )
                                sSerie = drLectura.GetValue(0).ToString();
                        }
                        drLectura.Close();
                    }

                    //usuario tipo admision - caja
                    if ( Usuario.id_area == "28" )
                    {   //consulta que trae la fecha maxima del talonario usado por el usuario                     
                        vSQL = "SELECT CONVERT(varchar, MAX(Fecha), 103) AS Mf ";
                        vSQL = vSQL + "FROM Talon ";
                        vSQL = vSQL + "WHERE LTrim(RTrim(Usuario)) = '" + Usuario.id_us + "' ";
                        vSQL = vSQL + "AND Id_Oper = '" + Operativo.id_oper + "' ";
                        vSQL = vSQL + "AND LTrim(RTrim(NCon)) <> '' ";
                        Conexion.CMD.CommandText = vSQL;
                        using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
                        {
                            if ( drLectura.HasRows )
                            {
                                while ( drLectura.Read() )
                                    sFecTalon = drLectura.GetValue(0).ToString();
                            }
                            drLectura.Close();
                        }

                        if ( !(sFecTalon == null || sFecTalon == String.Empty || sFecTalon == "") )
                        {
                            if ( Convert.ToDateTime(sFecTalon) < DateTime.Now )
                            {   //consulta que trae los datos de la serie, documento de venta para la fecha seleccionada
                                vSQL = "SELECT usuario,fecha,ninicial,nfinal,id_oper,serie,dventa,ncon,tdef ";
                                vSQL = vSQL + "FROM Talon ";
                                vSQL = vSQL + "WHERE LTrim(RTrim(Usuario)) = '" + Usuario.id_us + "' ";
                                vSQL = vSQL + "AND Id_Oper = '" + Operativo.id_oper + "' ";
                                vSQL = vSQL + "AND CONVERT(varchar, MAX(Fecha), 103) >= '" + sFecTalon + "' ";
                                vSQL = vSQL + "AND LTrim(RTrim(NCon)) <> '' ";
                                Conexion.CMD.CommandText = vSQL;
                                using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
                                {
                                    if ( drLectura.HasRows )
                                    {
                                        while ( drLectura.Read() )
                                        {
                                            Talon.usuario = drLectura.GetValue(0).ToString();
                                            Talon.fecha = Convert.ToDateTime(drLectura.GetValue(1).ToString());
                                            Talon.ninicial = drLectura.GetValue(2).ToString();
                                            Talon.nfinal = drLectura.GetValue(3).ToString();
                                            Talon.id_oper = drLectura.GetValue(4).ToString();
                                            Talon.serie = drLectura.GetValue(5).ToString();
                                            Talon.dventa = Convert.ToChar(drLectura.GetValue(6).ToString());
                                            Talon.ncon = drLectura.GetValue(7).ToString();
                                            Talon.tdef = Convert.ToChar(drLectura.GetValue(8).ToString());

                                            vSQL = "SELECT MAX(Nro_Ticket) ";
                                            vSQL = vSQL + " FROM Tickets ";
                                            vSQL = vSQL + " WHERE CONVERT(varchar, Fecha_Emision, 103) >= '" + Talon.fecha + "' ";
                                            vSQL = vSQL + " AND CONVERT(varchar, Fecha_Emision, 103) <= '" + Talon.fecha + "' ";
                                            vSQL = vSQL + " AND LTRIM(RTRIM(Digitador)) = '" + Talon.usuario + "' ";
                                            vSQL = vSQL + " AND SUBSTRING(Nro_Historia,1,3) = '" + Talon.id_oper + "' ";
                                            vSQL = vSQL + " AND LTRIM(RTRIM(Serie)) = '" + Talon.serie + "' ";
                                            vSQL = vSQL + " AND LTRIM(RTRIM(DVenta)) = '" + Talon.dventa + "' ";
                                            Conexion.CMD.CommandText = vSQL;
                                            using ( SqlDataReader drTiket = Conexion.CMD.ExecuteReader() )
                                            {
                                                if ( drTiket.HasRows )
                                                {
                                                    if ( drTiket.Read() )
                                                        sNroTicket = drLectura.GetValue(0).ToString();

                                                    if ( !(sNroTicket.Trim() == null || sNroTicket.Trim() == String.Empty) )
                                                    {
                                                        vSQL = "UPDATE Talon ";
                                                        vSQL = vSQL + " SET NFinal = '" + sNroTicket + "' ";
                                                        vSQL = vSQL + " WHERE LTRIM(RTRIM(NCon)) <> '' ";
                                                        vSQL = vSQL + " AND CONVERT(varchar, Fecha, 103) = '" + Talon.fecha + "' ";
                                                        vSQL = vSQL + " AND LTRIM(RTRIM(Usuario)) = '" + Talon.usuario + "' ";
                                                        vSQL = vSQL + " AND Id_Oper = '" + Talon.id_oper + "' ";
                                                        vSQL = vSQL + " AND LTRIM(RTRIM(Serie)) = '" + Talon.serie + "' ";
                                                        vSQL = vSQL + " AND LTRIM(RTRIM(DVenta)) = '" + Talon.dventa + "' ";
                                                        Conexion.CMD.CommandText = vSQL;
                                                        Conexion.CMD.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }
                                        drLectura.Close();
                                    }
                                }
                            }

                            //Selecciona la serie del usuario en curso
                            vSQL = "SELECT MAX(serie) ";
                            vSQL = vSQL + "FROM Talon ";
                            vSQL = vSQL + "WHERE LTrim(RTrim(Usuario)) = '" + Usuario.id_us + "' ";
                            vSQL = vSQL + "AND Id_Oper = '" + Operativo.id_oper + "' ";
                            vSQL = vSQL + "AND CONVERT(varchar, MAX(Fecha), 103) = '" + sFecTalon + "' ";
                            vSQL = vSQL + "AND LTrim(RTrim(NCon)) <> '' ";
                            Conexion.CMD.CommandText = vSQL;
                            using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
                            {
                                if ( drLectura.HasRows )
                                {
                                    while ( drLectura.Read() )
                                        Talon.serie = drLectura.GetValue(0).ToString();
                                        
                                }
                                drLectura.Close();
                            }

                            if ( (Talon.serie == null || Talon.serie == String.Empty || Talon.serie == "") )
                                bBlanco = true;
                            else
                            {
                                sSerie = Talon.serie;

                            }
                        }
                        else
                            bBlanco = true;
                    }

                    if ( bBlanco == true )
                    {
                        if ( !(sSerie == null || sSerie == String.Empty || sSerie == "") && (Talon.serie == null || Talon.serie == String.Empty || Talon.serie == "") )
                            Talon.serie = sSerie;

                        MessageBox.Show("Debe ingresar rango de documentos de venta.", "Ingreso Rango Documentos Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        frmTalonario fr = new frmTalonario();
RegresaTalon:
                        fr.ShowDialog();
                        if ( fr.DialogResult != DialogResult.OK )
                        {
                            MessageBox.Show("No puede continuar porque debe ingresar un rango de documentos de venta.", "Ingreso Rango Documentos Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            goto RegresaTalon;
                        }
                    }

                    //llama al formulario principal
                    frmMain frmPrincipal = new frmMain();
                    frmPrincipal.RefToLogin = this;
                    frmPrincipal.Tag = "";
                    //this.Visible = false;
                    this.Hide();
                    frmPrincipal.Show();
                }
                else 
                {
                    MessageBox.Show( "Contraseña: " + txtClave.Text.Trim() + " incorrectos" + (char)13 + "Quedan " + (3-nroVeces) + " intentos.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1 );
                    txtClave.Focus();
                    nroVeces = nroVeces + 1;
                    if ( nroVeces > 3 )
                        Application.Exit();

                    return;
                }
            }
            catch ( Exception ex )
            {
				this.DialogResult = DialogResult.Cancel;
				MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void cmbUsuario_DrawItem( object sender, DrawItemEventArgs e )
        {
            if ( e.Index < 0 )
                return;

            Font f = new System.Drawing.Font( "Tahoma", 8, FontStyle.Bold ); 
            e.Graphics.FillRectangle( Brushes.Bisque, e.Bounds );
            e.Graphics.DrawString( cmbUsuario.Items[e.Index].ToString(), f, Brushes.Black, new Point( e.Bounds.X, e.Bounds.Y ) );
                        
            if ( (e.State & DrawItemState.Focus) == 0 )
            {
                e.Graphics.FillRectangle( Brushes.White, e.Bounds );
                e.Graphics.DrawString( cmbUsuario.Items[e.Index].ToString(), f, Brushes.Black, new Point( e.Bounds.X, e.Bounds.Y ) );
            }
        }

        private void txtClave_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if ( e.KeyCode == Keys.Enter )
            {
                if ( txtClave.Text.Trim().Length == 0 )
                    return;

                btnIngresar.Focus();
                e.Handled = true;
            }
        }
        
        private void cmbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if ( e.KeyCode == Keys.Enter )
            {
                if ( cmbUsuario.SelectedIndex == -1 )
                    return;

                txtClave.Focus();
                e.Handled = true;
            }
        }

        private void btnIngresar_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
			if ( DialogResult != DialogResult.OK )
				return;

            General.LlenaOperativo();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            if ( this.Text == "finsesion" )
            {
                this.Text = "";
                cmbUsuario.SelectedIndex = -1;
                txtClave.Text = "";
            }
        }
    }
}
