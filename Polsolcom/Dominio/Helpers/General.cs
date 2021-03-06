﻿using Microsoft.VisualBasic;
using Polsolcom.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Connection;
using System.Data;
using System.Configuration;
using Dapper;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Windows.Forms.ListViewItem;
using System.IO;
using System.Globalization;

namespace Polsolcom.Dominio.Helpers
{
    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class TipoUsuario
    {
        public string Id_Tipo { get; set; }
        public string Descripcion { get; set; }

        public TipoUsuario(string IdTipo, string Desc)
        {
            Id_Tipo = IdTipo;
            Descripcion = Desc;
        }

        public override string ToString()
        {
            return Descripcion;
        }

    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class Ubigeo
    {
        public string IdUbigeo { get; set; }
        public string Descripcion { get; set; }
    }

    //clase que guarda los parametros generales a mostrar en un grafico
    public class Grafico
    {
        public static string sSQL { get; set; }
        public static string TituloChart { get; set; }
        public static string TipoChart { get; set; }
        public static string TituloX { get; set; }
        public static string TituloY { get; set; }
        public static string LeyendaX { get; set; }
        public static string LeyendaY { get; set; }
        public static bool Decimal { get; set; }
        public static List<Serie> series { get; set; }
    }

    public class ItemMenus
    {
        public string Bar_Number { get; set; }
        public string Bar_Popup { get; set; }
        public string Bar_Prompt { get; set; }
        public string Bar_Order { get; set; }
        public string Bar_Command { get; set; }

        public ItemMenus(string _Number, string _Popup, string _Prompt, string _Order, string _Command)
        {
            Bar_Number = _Number;
            Bar_Popup = _Popup;
            Bar_Prompt = _Prompt;
            Bar_Command = _Command;
            Bar_Order = _Order;
        }
    }

    public static class General
    {
        public static string emptyDate = "  /  /";
        public static string emptyDateTime = "  /  /       :";
        public static string dateTimeFormat = "dd/MM/yyyy hh:mm tt";
        public static ToolTip ttMensaje = new ToolTip();
        public static Label lblLabel = new Label();
        public static List<TipoUsuario> lstTipoUsuario = new List<TipoUsuario>();
        public static int ODB = 0; //variable manejo de ventanas form fmrSHClinica 0: Paciente Existente, 1: Paciente Nuevo 
        public static int TDB = 1; //variable manejo de ventanas form fmrSHClinica 0: Paciente Existente, 1: Paciente Nuevo 

        #region Cryptography
        public static string cryptgr(string cWWord, bool lflag, int nlevel)
        {
            string cdone = null;
            string cor1 = null;
            string cor2 = null;
            int e = 0;
            int i = 0;
            int vlong = 0;
            int nasc = 0;
            string cword = null;

            cdone = "";
            cword = Strings.Trim(cWWord);

            if (nlevel == 1)
            {
                cor1 = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789-_.,";
                cor2 = "!9|z7·5s@3$1r%A&0t/2(4j=g6wR8#¿')eZH\\¡Y?<X,:W]-V{>k~^l;_m}[n+*ñaDKJy";
                e = 1;
                while (e <= Strings.Len(cword))
                {
                    i = 1;
                    if (lflag == true)
                    {
                        //Convierte a caracters la cadena de letras
                        while (i <= 68)
                        {
                            if (Strings.Mid(cor1, i, 1) == Strings.Mid(cword, e, 1))
                            {
                                cdone = cdone + Strings.Mid(cor2, i, 1);
                                i = Strings.Len(cor1);
                            }
                            i = i + 1;
                        }
                        e = e + 1;
                    }
                    else
                    {
                        //Convierte a letras la cadena de caracteres
                        while (i <= 68)
                        {
                            if (Strings.Mid(cor2, i, 1) == Strings.Mid(cword, e, 1))
                            {
                                cdone = cdone + Strings.Mid(cor1, i, 1);
                                i = Strings.Len(cor2);
                            }
                            i = i + 1;
                        }
                        e = e + 1;
                    }
                }
            }
            else
            {
                vlong = Strings.Len(Strings.Trim(cword));
                for (i = vlong; i >= 1; i += -1)
                {
                    nasc = Strings.Asc(Strings.Mid(cword, i, 1));
                    if (lflag == true)
                    {
                        if ((nasc + 104) <= 255)
                            cdone = cdone + Strings.Chr(nasc + 104);
                        else
                            cdone = cdone + Strings.Chr(255 - nasc);
                    }
                    else
                    {
                        if ((nasc - 104) > 0)
                            cdone = cdone + Strings.Chr(nasc - 104);
                        else
                            cdone = cdone + Strings.Chr(255 - nasc);
                    }
                }
            }
            return cdone;
        }
        #endregion

        #region Metodos Usuario
        public static void LlenaUsuario(SqlDataReader dr)
        {
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Usuario.id_us = dr.GetValue(0).ToString().Trim();
                    Usuario.usuario = General.cryptgr(dr.GetValue(1).ToString().Trim(), false, 1);
                    Usuario.clave = dr.GetValue(2).ToString().Trim();
                    Usuario.tipo = cryptgr(dr.GetValue(3).ToString().Trim(), false, 2);
                    Usuario.descripcion = dr.GetValue(4).ToString().Trim();
                    Usuario.id_area = dr.GetValue(5).ToString().Trim();
                    Usuario.cargo = dr.GetValue(6).ToString().Trim();
                }
                dr.Close();
            }
        }

		public static void SetearPosicionForm( Form frm)
		{
			int vTop = Screen.PrimaryScreen.WorkingArea.Width;
			int vHeight = Screen.PrimaryScreen.WorkingArea.Height;
			int valorX = (vTop - frm.Width)/2;
			int valorY = (vHeight*3/4 + frm.Height);

			frm.Left = valorX;
			frm.Top = valorY;
		}

		public static void LlenarRegistroVenta(string idUsuario, string DVenta)
        {
            string vSQL = "SELECT S.id_oper AS Oper,T.Usuario,T.DVenta,T.Serie,S.Autoriz " +
                          "FROM Talon T INNER JOIN Serie S " +
                          "ON T.Id_Oper = S.Id_Oper " +
                          "AND T.DVenta = S.Id_TDoc " +
                          "AND T.Serie = S.Serie " +
                          "WHERE CONVERT(VARCHAR(10),Fecha,103) = ( SELECT CONVERT(VARCHAR(10), GETDATE(), 103) FROM dual) " +
                          "AND Usuario = '" + idUsuario.Trim() + "' " +
                          "AND NCon <> '' ";
            if (DVenta.Trim() == "")
                vSQL = vSQL + "AND TDef = '' ";
            else
                vSQL = vSQL + "AND DVenta = '" + DVenta.Trim() + "'";

            using (SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            RangoVenta.Oper = dr.GetValue(0).ToString();
                            RangoVenta.Usuario = dr.GetValue(1).ToString();
                            RangoVenta.DVenta = dr.GetValue(2).ToString();
                            RangoVenta.Serie = dr.GetValue(3).ToString();
                            RangoVenta.Autoriz = dr.GetValue(4).ToString();
                        }
                    }
                    else
                    {
                        RangoVenta.Oper = "";
                        RangoVenta.Usuario = "";
                        RangoVenta.DVenta = "";
                        RangoVenta.Serie = "";
                        RangoVenta.Autoriz = "";
                    }
                    dr.Close();
                }
            }
        }

        public static bool ValidaPass(string sPassword)
        {
            string c1 = sPassword.ToString();
            int x = 0;
            int y = 0;
            int z = 0;

            for (int i = 0; i < c1.Length; i += 1)
            {
                char sTemp = c1[i];
                if (Char.IsDigit(sTemp))
                    x = 1;

                if (Char.IsUpper(sTemp))
                    y = 1;

                if (Char.IsLower(sTemp))
                    z = 1;
            }

            if ((x + y + z) < 3 || c1.Length < 8)
                return false;
            else
                return true;
        }

        public static string DevuelveUsuario(string id_usuario)
        {
            string sUsuario = "";
            string vSQL = "";

            vSQL = "SELECT nombres + ' ' + ape_paterno + ' ' + ape_materno AS persona " +
                    "FROM personal " +
                    "WHERE Id_Personal = '" + id_usuario + "' ";
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    sUsuario = db.ExecuteScalar<string>(vSQL);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            return sUsuario;
        }

        public static string TomaValor(string sSQL)
        {
            string sResult = "";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    sResult = db.ExecuteScalar<string>(sSQL);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            return sResult;

        }

        public static string Frase(string PT)
        {
            string sValor = "";
            string vSQL = "";
            int iCant = 0;

            if (PT.Trim() == "D")
            {
                vSQL = "SELECT COUNT(*) AS C FROM Frases WHERE Tipo = 'D'";
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();

                        iCant = db.ExecuteScalar<int>(vSQL);
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }

                if (iCant == 0)
                {
                    vSQL = "UPDATE Frases SET Tipo = 'D' WHERE Tipo = 'X'";
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
                    {
                        int vRes = db.Execute(vSQL);
                    }
                }
            }

            vSQL = "SELECT TOP 1 frase FROM Frases WHERE Tipo = '" + PT.Trim() + "'";
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    sValor = db.ExecuteScalar<string>(vSQL);
                    sValor = sValor.Trim();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }

            if (PT.Trim() == "D")
            {
                vSQL = "UPDATE Frases SET Tipo = 'X' WHERE Frase LIKE '" + @sValor + "'";
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
                {
                    try
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();

                        int vRes = db.Execute(vSQL);
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
            return sValor;
        }

        public static Dictionary<string, string> rdvo(string pu, string pd)
        {
            string sql = "SELECT T.DVenta,T.Serie,S.Autoriz " +
                          "FROM Talon T INNER JOIN Serie S " +
                          "ON T.Id_Oper = S.Id_Oper " +
                          "AND T.DVenta = S.Id_TDoc " +
                          "AND T.Serie = S.Serie " +
                          "WHERE CONVERT(VARCHAR(10),Fecha,103) = ( SELECT CONVERT(VARCHAR(10), GETDATE(), 103) FROM dual) " +
                          "AND Usuario = '" + pu.Trim() + "' " +
                          "AND NCon <> '' ";
            if (pd.Trim() == "")
                sql = sql + "AND TDef = '' ";
            else
                sql = sql + "AND DVenta = '" + pd.Trim() + "'";

            Dictionary<string, string> rdvopen = General.GetDictionary(sql);

			if( rdvopen == null )
				MessageBox.Show("No tiene rango de documentos de venta...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
			else if( rdvopen.Count == 0 )
			{
				rdvopen = null;
				MessageBox.Show("No tiene rango de documentos de venta...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
			}
			return rdvopen;
        }

        public static void ReseteaSesion()
        {
            //Limpia Usuario
            Usuario.id_us = "";
            Usuario.usuario = "";
            Usuario.clave = "";
            Usuario.tipo = "";
            Usuario.descripcion = "";
            Usuario.id_area = "";
            Usuario.cargo = "";

            //Limpia Talon
            Talon.usuario = "";
            Talon.ninicial = "";
            Talon.nfinal = "";
            Talon.id_oper = "";
            Talon.serie = "";
            Talon.dventa = "";
            Talon.ncon = "";
            Talon.tdef = "";

            //Limpia Especialidad
            Especialidad.esp = "";
            Especialidad.nrz = "";
            Especialidad.con = "";
            Especialidad.tcn = "";

            frmLogin.sSerie = "";
            frmLogin.nroVeces = 1;
            frmLogin.sFecTalon = "";
            frmLogin.sNroTicket = "";
            frmLogin.bBlanco = false;

        }

        public static void CargaTipoUsuario()
        {
            string vSQL = "";
            lstTipoUsuario.Clear();

            vSQL = "SELECT Id_Tipo,Descripcion " +
                    " FROM TablaTipo " +
                    " WHERE Id_Tabla IN " +
                    " (SELECT Id_Tipo " +
                    "  FROM TablaTipo " +
                    "  WHERE LTRIM(RTRIM(Descripcion)) = 'TIPO_USUARIO' " +
                    "  AND LTRIM(RTRIM(Id_Tabla)) = '0') " +
                    " ORDER BY 1 ";
            Conexion.CMD.CommandText = vSQL;
            using (SqlDataReader dr = Conexion.CMD.ExecuteReader())
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TipoUsuario tu = new TipoUsuario(dr.GetValue(0).ToString(), dr.GetValue(1).ToString());
                        lstTipoUsuario.Add(tu);
                    }
                    dr.Close();
                }
            }

        }

        public static string TradUser(string sVariable)
        {
            string sUsuario = "";
            string vSQL = "";

            vSQL = "SELECT Key_Pass AS Usuario " +
                    "FROM sysaccusers " +
                    "WHERE LTRIM(RTRIM(Id_Us)) = '" + sVariable.Replace("'", "''") + "' " +
                    "OR LTRIM(RTRIM(Key_Pass)) = '" + sVariable.Replace("'", "''") + "' ";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    sUsuario = db.ExecuteScalar<string>(vSQL);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            sUsuario = cryptgr(sUsuario, false, 1);
            return sUsuario;

        }
        #endregion

        public static void LlenaOperativo()
        {
            //consulta que trae los datos del centro operativo
            string vSQL = "SELECT O.Descripcion,O.Id_Oper,O.Estado,MO.Descripcion As Mod_Oper, ";
            vSQL = vSQL + " O.Id_Distrito,O.Uni_Org,O.Fil_Ubi,I.Nom_Raz_Soc,I.RUC,I.Direccion,U.Distrito ";
            vSQL = vSQL + " FROM Operativo O INNER JOIN ";
            vSQL = vSQL + " (SELECT Id_Tipo,Descripcion ";
            vSQL = vSQL + "  FROM TablaTipo ";
            vSQL = vSQL + "  WHERE Id_Tabla In ";
            vSQL = vSQL + "  (SELECT Id_Tipo ";
            vSQL = vSQL + "   FROM TablaTipo ";
            vSQL = vSQL + "   WHERE LTrim(RTrim(Descripcion))='MODALIDAD_OPERATIVO' ";
            vSQL = vSQL + "   And LTrim(RTrim(Id_Tabla))='0')) MO ";
            vSQL = vSQL + " On O.Mod_Oper=MO.Id_Tipo INNER JOIN Institucion I ";
            vSQL = vSQL + " On O.Id_Emp=I.TInst+I.Id_Inst INNER JOIN Ubigeo2005 U ";
            vSQL = vSQL + " On I.Id_Distrito=U.Id_Old ";
            vSQL = vSQL + " ORDER BY 2";
            Conexion.CMD.CommandText = vSQL;
            using (SqlDataReader dr = Conexion.CMD.ExecuteReader())
            {//declarandolo de esta manera el datareader se puede usar nuevamente mas adelante
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Operativo.descripcion = dr.GetValue(0).ToString();
                        Operativo.id_oper = dr.GetValue(1).ToString();
                        Operativo.estado = dr.GetValue(2).ToString();
                        Operativo.mod_oper = dr.GetValue(3).ToString();
                        Operativo.id_distrito = dr.GetValue(4).ToString();
                        Operativo.uni_org = dr.GetValue(5).ToString();
                        Operativo.fil_ubi = dr.GetValue(6).ToString();
                        Operativo.nom_raz_soc = dr.GetValue(7).ToString();
                        Operativo.ruc = dr.GetValue(8).ToString();
                        Operativo.direccion = dr.GetValue(9).ToString();
                        Operativo.distrito = dr.GetValue(10).ToString();
                    }
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("No se tiene datos del operativo." + (char)13 + "Contactar al admnistrador de sistemas.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Application.Exit();
                }
            }
        }

        public static void LlenaTalon(SqlDataReader dr)
        {
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Talon.usuario = dr.GetValue(0).ToString();
                    Talon.fecha = Convert.ToDateTime(dr.GetValue(1).ToString());
                    Talon.ninicial = dr.GetValue(2).ToString();
                    Talon.nfinal = dr.GetValue(3).ToString();
                    Talon.id_oper = dr.GetValue(4).ToString();
                    Talon.serie = dr.GetValue(5).ToString();
                    Talon.dventa = dr.GetValue(6).ToString();
                    Talon.ncon = dr.GetValue(7).ToString();
                    Talon.tdef = dr.GetValue(8).ToString();
                }
                dr.Close();
            }
        }

        public static void LlenaEspecialidad(SqlDataReader dr)
        {
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Especialidad.esp = dr.GetValue(0).ToString();
                    Especialidad.nrz = dr.GetValue(1).ToString();
                    Especialidad.con = dr.GetValue(2).ToString();
                    Especialidad.tcn = dr.GetValue(3).ToString();
                }
                dr.Close();
            }
        }

        public static void CargaTipoDocVenta(ComboBox cmb)
        {
            string vSQL = "";

            cmb.Items.Clear();
            vSQL = "SELECT Id_Tipo,Descripcion " +
                    "FROM TablaTipo " +
                    "WHERE Id_Tabla IN " +
                    "(SELECT Id_Tipo " +
                    " FROM TablaTipo " +
                    " WHERE LTRIM(RTRIM(Descripcion)) = 'DOC_VENTA' " +
                    " AND LTRIM(RTRIM(Id_Tabla)) = '0') " +
                    "ORDER BY 2 ";
            Conexion.CMD.CommandText = vSQL;
            using (SqlDataReader drLectura = Conexion.CMD.ExecuteReader())
            {
                if (drLectura.HasRows)
                {
                    while (drLectura.Read())
                        cmb.Items.Add(new Item(drLectura.GetValue(1).ToString(), Convert.ToInt32(drLectura.GetValue(0).ToString())));
                }
                drLectura.Close();
            }
            cmb.SelectedIndex = -1;
        }

        public static string NumeroTexto(string numero, string moneda = "")
        {
            string literal = "";
            string parte_decimal;
            Regex r;

            numero = numero.Replace(",", ""); //quita las comas de miles  
            if (numero.IndexOf(".") == -1)
                numero = numero + ".00"; //no tienedecimal, agrega .00  

            r = new Regex(@"\d{1,9}.\d{1,2}"); //valida formato 0.00 y 999 999 999.00  
            MatchCollection mc = r.Matches(numero);
            if (mc.Count > 0)
            {
                string[] Num = numero.Split('.'); //divide nro 0000000,00 en entero y decimal  

                parte_decimal = Num[1] + (moneda.Trim() == "" ? "/100 SOLES" : "/100 " + moneda.Trim().ToUpper());

                if (int.Parse(Num[0]) == 0)
                    literal = "CERO ";
                else if (int.Parse(Num[0]) > 999999)
                    literal = Millones(Num[0]);
                else if (int.Parse(Num[0]) > 999)
                    literal = Miles(Num[0]);
                else if (int.Parse(Num[0]) > 99)
                    literal = Centenas(Num[0]);
                else if (int.Parse(Num[0]) > 9)
                    literal = Decenas(Num[0]);
                else
                    literal = Unidades(Num[0]);

                return (literal + "CON " + parte_decimal).ToUpper();
            }
            else
                return literal = null;
        }
		
        private static string Unidades(string numero)
        {
            string[] UNIDADES = { "", "UN ", "DOS ", "TRES ", "CUATRO ", "CINCO ", "SEIS ", "SIETE ", "OCHO ", "NUEVE " };

            string num = numero.Substring(numero.Length - 1);
            return UNIDADES[int.Parse(num)];
        }

        private static string Decenas(string num)
        {
            string[] DECENAS = { "DIEZ ", "ONCE ", "DOCE ", "TRECE ", "CATORCE ", "QUINCE ", "DIECISEIS ", "DIECISIETE ", "DIECIOCHO ", "DIECINUEVE", "VEINTE ", "TREINTA ", "CUARENTA ", "CINCUENTA ", "SESENTA ", "SETENTA ", "OCHENTA ", "NOVENTA " };

            int n = int.Parse(num);

            if (n < 10)
                return Unidades(num); //para 01...09  
            else if (n > 19)
            {
                string u = Unidades(num); //para 20...99  
                if (u.Equals(""))
                    return DECENAS[int.Parse(num.Substring(0, 1)) + 8]; //para 20,30,40,50,60,70,80,90  
                else
                    return DECENAS[int.Parse(num.Substring(0, 1)) + 8] + "Y " + u;
            }
            else
                return DECENAS[n - 10]; //numeros entre 11 y 19  
        }

        private static string Centenas(string num)
        {
            string[] CENTENAS = { "", "CIENTO ", "DOSCIENTOS ", "TRECIENTOS ", "CUATROCIENTOS ", "QUINIENTOS ", "SEISCIENTOS ", "SETECIENTOS ", "OCHOCIENTOS ", "NOVECIENTOS " };

            if (int.Parse(num) > 99)
            {
                if (int.Parse(num) == 100)
                    return " CIEN ";
                else
                    return CENTENAS[int.Parse(num.Substring(0, 1))] + Decenas(num.Substring(1));
            }
            else
                return Decenas(int.Parse(num) + "");
        }

        private static string Miles(string numero)
        {
            string c = numero.Substring(numero.Length - 3); //lee las centenas  
            string m = numero.Substring(0, numero.Length - 3); //lee los miles  
            string n = "";

            if (int.Parse(m) > 0) //se valida que miles tenga valor entero  
            {
                n = Centenas(m);
                return n + "MIL " + Centenas(c);
            }
            else
                return "" + Centenas(c);
        }

        private static string Millones(string numero)
        {
            string miles = numero.Substring(numero.Length - 6); //lee los miles  
            string millon = numero.Substring(0, numero.Length - 6); //lee los millones  
            string n = "";

            if (millon.Length > 1)
                n = Centenas(millon) + "MILLONES ";
            else
                n = Unidades(millon) + "MILLON ";

            return n + Miles(miles);
        }

        #region Metodos Personal
        public static List<Personal> TraerPersonal()
        {
            List<Personal> lista = new List<Personal>();
            string vSQL;
            vSQL = "SELECT *";
            vSQL = vSQL + "FROM  Personal";
            SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN);
            SqlDataReader drUsuarios = cmd.ExecuteReader();
            while (drUsuarios.Read())
            {
                Personal oPersonal = new Personal()
                {
                    Id_Personal = drUsuarios.GetValue(0).ToString(),
                    Nombre = drUsuarios.GetValue(1).ToString(),
                    Ape_Paterno = drUsuarios.GetValue(2).ToString(),
                    Ape_Materno = drUsuarios.GetValue(3).ToString(),
                    DNI = drUsuarios.GetValue(4).ToString(),
                    RUC = drUsuarios.GetValue(5).ToString(),
                    Sexo = drUsuarios.GetValue(6).ToString(),
                    //Fecha_Nac = drUsuarios.GetValue(7).ToString(),
                    TNCol = drUsuarios.GetValue(8).ToString(),
                    RNE = drUsuarios.GetValue(9).ToString(),
                    Direccion = drUsuarios.GetValue(10).ToString(),
                    Id_Distrito = drUsuarios.GetValue(11).ToString(),
                    Telefono = drUsuarios.GetValue(12).ToString(),
                    Celular = drUsuarios.GetValue(13).ToString(),
                    Mod_Cont = drUsuarios.GetValue(14).ToString(),
                    Est_Civ = drUsuarios.GetValue(15).ToString(),
                    Id_GInst = drUsuarios.GetValue(16).ToString(),
                    Id_Profesion = drUsuarios.GetValue(17).ToString(),
                    Id_Area = drUsuarios.GetValue(18).ToString(),
                    Id_Cargo = drUsuarios.GetValue(19).ToString(),
                    //Fec_Ing = drUsuarios.GetValue(20).ToString(),
                    //Fec_Ces = drUsuarios.GetValue(21).ToString(),
                    Email = drUsuarios.GetValue(22).ToString(),
                    Observacion = drUsuarios.GetValue(23).ToString(),
                    Dscto = drUsuarios.GetValue(24).ToString(),
                    Estado = drUsuarios.GetValue(25).ToString(),
                    Proyeccion = drUsuarios.GetValue(26).ToString(),
                    Capacitacion = drUsuarios.GetValue(27).ToString(),
                    Centro_Capac = drUsuarios.GetValue(28).ToString(),
                    Otras_Capac = drUsuarios.GetValue(29).ToString(),
                    Salud = drUsuarios.GetValue(30).ToString(),
                    Grp_Sang = drUsuarios.GetValue(31).ToString(),
                    //Ult_Eva_Med = drUsuarios.GetValue(32).ToString(),
                    Ult_Diagnostico = drUsuarios.GetValue(33).ToString(),
                    Afi_Dep = drUsuarios.GetValue(34).ToString(),
                    Instr_Musical = drUsuarios.GetValue(35).ToString(),
                    Canta = drUsuarios.GetValue(36).ToString(),
                    Tipo_Musica = drUsuarios.GetValue(37).ToString(),
                    Hobby = drUsuarios.GetValue(38).ToString(),
                    Us_Ins = drUsuarios.GetValue(39).ToString(),
                    //Fec_Ins = drUsuarios.GetValue(40).ToString(),
                    Us_Mod = drUsuarios.GetValue(41).ToString()
                    //Fec_Mod = drUsuarios.GetValue(42).ToString(),
                };
                lista.Add(oPersonal);
            }
            return lista;
        }

        public static bool UpdatePersonal()
        {

            return true;
        }
        #endregion

        public static List<Lugar> TraerLugares()
        {
            List<Lugar> ListaLugares = new List<Lugar>();
            var vSQL = "SELECT * FROM ubigeo2005 ";
            SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN);
            SqlDataReader drLugares = cmd.ExecuteReader();
            while (drLugares.Read())
            {
                Lugar lugar = new Lugar()
                {
                    Id = Convert.ToInt32(drLugares.GetValue(0).ToString()),
                    Departamento = drLugares.GetValue(1).ToString(),
                    Provincia = drLugares.GetValue(2).ToString(),
                    Distrito = drLugares.GetValue(3).ToString()
                };
                ListaLugares.Add(lugar);
            }
            return ListaLugares;
        }

        public static List<Institucion> TraerInstitucion()
        {
            List<Institucion> lista = new List<Institucion>();
            string vSQL;
            vSQL = "SELECT * ";
            vSQL = vSQL + "FROM Institucion";
            SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN);
            SqlDataReader drInstitucion = cmd.ExecuteReader();
            while (drInstitucion.Read())
            {
                Institucion oInstitucion = new Institucion()
                {
                    Id = Convert.ToInt16(drInstitucion.GetValue(1).ToString()),
                    Nom_Raz_Soc = drInstitucion.GetValue(2).ToString(),
                    RUC = drInstitucion.GetValue(3).ToString(),
                    Direccion = drInstitucion.GetValue(4).ToString(),
                    Id_Distrito = drInstitucion.GetValue(5).ToString(),
                    Telefono = drInstitucion.GetValue(6).ToString(),
                    Celular = drInstitucion.GetValue(7).ToString(),
                    Id_Represent = drInstitucion.GetValue(8).ToString(),
                    Representante = drInstitucion.GetValue(9).ToString(),
                    Id_Cargo = drInstitucion.GetValue(10).ToString(),
                    Mod_Trans = drInstitucion.GetValue(11).ToString(),
                    Email = drInstitucion.GetValue(12).ToString(),
                    Observacion = drInstitucion.GetValue(13).ToString(),
                    Estado = drInstitucion.GetValue(14).ToString(),
                    //Fec_Ing = drInstitucion.GetValue(15).ToString(),
                    Us_Ing = drInstitucion.GetValue(16).ToString(),
                    //Fec_Mod = drInstitucion.GetValue(17).ToString(),
                    Us_Mod = drInstitucion.GetValue(18).ToString()
                };
                lista.Add(oInstitucion);
            }
            return lista;
        }

        public static List<Consultorio> TraerConsultorios()
        {
            List<Consultorio> ConsultorioList = new List<Consultorio>();
            var vSQL = "SELECT * ";
            vSQL = vSQL + "FROM  Consultorios";
            SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN);
            SqlDataReader drConsultorios = cmd.ExecuteReader();
            while (drConsultorios.Read())
            {
                Consultorio oConsultorio = new Consultorio()
                {
                    Id = drConsultorios.GetValue(0).ToString(),
                    Descripcion = drConsultorios.GetValue(1).ToString(),
                    Estado = drConsultorios.GetValue(2).ToString(),
                    Turno = drConsultorios.GetValue(3).ToString(),
                    Tipo = drConsultorios.GetValue(4).ToString(),
                    Observacion = drConsultorios.GetValue(5).ToString(),
                    Us_Ing = drConsultorios.GetValue(6).ToString(),
                    Us_Mod = drConsultorios.GetValue(7).ToString(),
                    Fec_Ing = drConsultorios.GetValue(8).ToString(),
                    Fec_Mod = drConsultorios.GetValue(9).ToString()
                };
                ConsultorioList.Add(oConsultorio);
            }
            return ConsultorioList;
        }

        public static List<Producto> TraerProductos()
        {
            List<Producto> ProductosList = new List<Producto>();
            bool statebool = false;
            var vSQL = "SELECT * ";
            vSQL = vSQL + "FROM  Productos";
            SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN);
            SqlDataReader drProductos = cmd.ExecuteReader();
            while (drProductos.Read())
            {
                var state = int.Parse(drProductos.GetValue(4).ToString());
                if (state == 1)
                    statebool = true;
                else
                    statebool = false;
                Producto oProducto = new Producto()
                {
                    Id = drProductos.GetValue(0).ToString(),
                    Descripcion = drProductos.GetValue(1).ToString(),
                    Monto = double.Parse(drProductos.GetValue(2).ToString()),
                    Tipo = drProductos.GetValue(3).ToString(),
                    Estado = statebool,
                    TPEsp = drProductos.GetValue(5).ToString()
                };
                ProductosList.Add(oProducto);
            }
            return ProductosList;
        }

        public static List<Especialista> TraerEspecialistas()
        {
            List<Especialista> ListaEspecialistas = new List<Especialista>();
            var vSQL = "Select P.Ape_Paterno+' '+P.Ape_Materno+', '+P.Nombres Especialista,B.Bus,C.Descripcion,B.Id_Esp,MB.Id_Bus," +
                        "MB.CMP,MB.Estado,MB.Obs,MB.Us_Ing,MB.Fec_Ing,MB.Us_Mod,MB.Fec_Mod,MB.Id_Bus+MB.CMP Idmb " +
                        "From MedBus MB Inner Join Personal P On MB.CMP=P.Id_Personal Inner Join Buses B On MB.Id_Bus=B.Id_Bus " +
                        "Inner Join Consultorios C On B.Id_Esp=C.Id_Consultorio Order By 1,2";
            SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN);
            SqlDataReader drEspecialistas = cmd.ExecuteReader();
            while (drEspecialistas.Read())
            {
                Especialista oEspecialista = new Especialista()
                {
                    FullName = drEspecialistas.GetString(0),
                    Consultorio = drEspecialistas.GetString(1),
                    Descripcion = drEspecialistas.GetString(2),
                    Especialidad = drEspecialistas.GetString(3)
                };
                ListaEspecialistas.Add(oEspecialista);
            }
            return ListaEspecialistas;
        }

        public static void LUbigeo(string sValor, string sTipo, ComboBox cmb)
        {
            string vSQL = "";
            List<Ubigeo> cOper = new List<Ubigeo>();

            cmb.DataSource = null;
            cmb.Items.Clear();

            if (sTipo.Trim().ToUpper() == "DEPARTAMENTO")
            {
                vSQL = "SELECT DISTINCT departamento AS Descripcion,LEFT(id_old,2) AS IdUbigeo " +
                        "FROM Ubigeo2005 " +
                        "WHERE LEFT(ubigeo, 2) <= '26' " +
                        "ORDER BY 1 ";
            }
            else if (sTipo.Trim().ToUpper() == "PROVINCIA")
            {
                vSQL = "SELECT DISTINCT provincia AS Descripcion,LEFT(id_old,4) AS IdUbigeo " +
                        "FROM Ubigeo2005 " +
                        "WHERE LEFT(ubigeo,2) <= '26' " +
                        "AND LEFT(id_old,2) LIKE '%" + sValor.Trim().ToUpper() + "' " +
                        "ORDER BY 1 ";
            }
            else if (sTipo.Trim().ToUpper() == "DISTRITO")
            {
                vSQL = "SELECT DISTINCT distrito AS descripcion,MAX(LEFT(id_old,6)) AS IdUbigeo " +
                        "FROM Ubigeo2005 " +
                        "WHERE LEFT(ubigeo,2) <= '26' " +
                        "AND LEFT(id_old,4) LIKE '%" + sValor.Trim().ToUpper() + "' " +
                        "GROUP BY distrito " +
                        "ORDER BY 1 ";
            }

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    cmb.DataSource = db.Query<Ubigeo>(vSQL).ToList();
                    cmb.DisplayMember = "Descripcion";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmb.DataSource = cOper;
                }
            }
            cmb.SelectedIndex = -1;
        }

        public static void LlenaComboBox(ComboBox cmb, string sTIPO, string vSQL = "")
        {
            string sQuery = "";
            switch (sTIPO)
            {
                case "MEDICO":
                    sQuery = "SELECT Ape_Paterno+' '+Ape_Materno+','+Nombres AS Descripcion,Id_Personal AS IdUbigeo " +
                            "FROM Personal " +
                            "WHERE TNCol <> '' " +
                            "UNION SELECT '** '+Descripcion+' **' AS Descripcion,Id_Tipo " +
                            "FROM TablaTipo " +
                            "WHERE Id_Tabla IN " +
                            "(SELECT Id_Tipo " +
                            " FROM TablaTipo " +
                            " WHERE Descripcion = 'VAR_EXTRAS' " +
                            " AND Id_Tabla = '0') " +
                            "ORDER BY 1";
                    break;
                case "INSTITUCION":
                    sQuery = "SELECT Nom_Raz_Soc AS Descripcion,TInst+Id_Inst AS IdUbigeo " +
                              "FROM Institucion " +
                             "WHERE Estado = '1' " +
                             "AND TInst IN('T', 'M') " +
                             "ORDER BY 1";
                    break;
                case "FORMA_PAGO":
                    sQuery = "SELECT Descripcion, Id_Tipo AS IdUbigeo " +
                             "FROM TablaTipo " +
                             "WHERE Id_Tabla In " +
                             "(SELECT Id_Tipo " +
                             " FROM TablaTipo " +
                             " WHERE LTrim(RTrim(Descripcion)) = 'FORMA_PAGO' " +
                             " AND LTrim(RTrim(Id_Tabla)) = '0') " +
                             "ORDER BY 1";
                    break;
                case "DOC_VENTA":
                    sQuery = "SELECT Descripcion, Id_Tipo AS IdUbigeo " +
                             "FROM TablaTipo " +
                             "WHERE Id_Tabla In " +
                             "(SELECT Id_Tipo " +
                             " FROM TablaTipo " +
                             " WHERE LTRIM(RTRIM(Descripcion)) = 'DOC_VENTA' " +
                             " AND LTRIM(RTRIM(Id_Tabla)) = '0') " +
                             "ORDER BY 1";
                    break;
                case "IGV":
                    sQuery = "SELECT Descripcion, Id_Tipo AS IdUbigeo " +
                             "FROM TablaTipo " +
                             "WHERE Id_Tabla In " +
                             "(SELECT Id_Tipo " +
                             " FROM TablaTipo " +
                             " WHERE LTRIM(RTRIM(Descripcion)) Like '%IGV%' " +
                             " And LTRIM(RTRIM(Id_Tabla)) = '0') " +
                             " And Val_Abr = '1' " +
                             "ORDER BY 1";
                    break;
                case "SERIE":
                    sQuery = "SELECT serie+' - '+autoriz AS Descripcion,id_serie AS IdUbigeo " +
                             "FROM serie ORDER BY Id_Serie";
                    break;
                case "SQL":
                    sQuery = vSQL;
                    break;
            }

            List<Ubigeo> cOper = new List<Ubigeo>();
            cmb.DataSource = null;
            cmb.Items.Clear();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    cmb.DataSource = db.Query<Ubigeo>(sQuery).ToList();
                    cmb.DisplayMember = "Descripcion";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmb.DataSource = cOper;
                }
            }

            if (cmb.Items.Count == 0)
                cmb.Enabled = false;
            else
                cmb.SelectedIndex = -1;
        }

        public static string FechaServidor(string sFormat = "DD/MM/YYYY")
        {
            string sFec = "";
            string sQuery = "";

            switch (sFormat)
            {
                case "DD/MM/YYYY":
                    sQuery = "SELECT CONVERT(VARCHAR(10),GETDATE(),103) FROM dual";
                    break;
                case "YYYY-MM-DD":
                    sQuery = "SELECT CONVERT(VARCHAR,GETDATE(),23) FROM dual";
                    break;
            }

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    sFec = db.ExecuteScalar<string>(sQuery);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            return sFec;
        }

        public static string DevuelveQueryPaciente(string ApPaterno, string ApMaterno, string Nombres, string DNI, string IdPaciente, string NroHistoria, int Num1, int ODB)
        {
            string sVSQL = "";
            int iVal = 0;
            int TDB = 1; //variable seteada para sintaxis SQL Server

            string sApPaterno = ApPaterno.Trim();
            string sApMaterno = ApMaterno.Trim();
            string sNombres = Nombres.Trim();
            string sDNI = DNI.Trim();
            string sIdPaciente = IdPaciente.Trim();
            string sNroHistoria = NroHistoria.Trim();

            if (ODB == 1)
            {
                iVal = (sApPaterno == "" ? 0 : 1);
                iVal = iVal + (sApMaterno == "" ? 0 : 1);
                iVal = iVal + (sNombres == "" ? 0 : 1);
                iVal = iVal + (sDNI == "" ? 0 : 1);

                if (iVal < 1)
                    return "";

                sVSQL = "SELECT " + (TDB == 1 ? "Top 50 " : "") +
                        "P.*, ISNULL(P.Ape_Pat, '') +' '+P.Ape_Mat+' '+P.Nombres As Paciente,U.Id_Old, '' As Direccion, U.Distrito As FullDireccion " +
                        "FROM DNI..Padron P INNER JOIN DNI..Ubigeo2005 U " +
                        "ON P.Ubigeo=U.Ubigeo WHERE 1 = 1 ";

                if (sApPaterno != "")
                    sVSQL = sVSQL + "AND Ape_Pat LIKE '" + sApPaterno + "%' ";

                if (sApMaterno != "")
                    sVSQL = sVSQL + "AND Ape_Mat LIKE '" + sApMaterno + "%' ";

                if (sNombres != "")
                    sVSQL = sVSQL + "AND Nombres LIKE '" + sNombres + "%' ";

                if (sDNI != "")
                    sVSQL = sVSQL + "AND DNI = '" + sDNI + "' ";

                sVSQL = sVSQL + "Order By Ape_Pat,Ape_Mat,Nombres " + (TDB == 1 ? "" : " Limit 50");
            }
            else
            {
                sVSQL = "SELECT " + (TDB == 1 ? "Top 50 " : "") +
                        "P.Ape_Paterno, P.Ape_Materno, P.Nombre, P.ape_paterno+' '+P.Ape_Materno+' '+P.Nombre As Paciente, P.Id_Paciente, P.DNI, P.Id_Distrito, P.Asegurado, P.Nro_Historia, P.Fecha_Nac, P.Edad, P.Sexo, P.Telefono, P.ODoc, P.E_Mail ";

                if (Num1 == 2)
                    sVSQL = sVSQL + ",CASE WHEN U.Distrito IS NULL THEN '' ELSE U.Distrito END AS Distrito, P.Direccion, CASE WHEN U.Distrito IS NULL THEN P.Direccion ELSE P.Direccion + ' - ' + U.Distrito END As FullDireccion ";

                sVSQL = sVSQL + " FROM Pacientes P ";

                if (Num1 == 2)
                    sVSQL = sVSQL + "LEFT JOIN Ubigeo2005 U ON P.Id_Distrito = U.Id_Old ";

                sVSQL = sVSQL + " WHERE 1 = 1 ";

                if (sApPaterno.Length > 0)
                    sVSQL = sVSQL + "AND Ape_Paterno LIKE '" + sApPaterno + "%' ";

                if (sApMaterno.Length > 0)
                    sVSQL = sVSQL + "AND Ape_Materno LIKE '" + sApMaterno + "%' ";

                if (sNombres.Length > 0)
                    sVSQL = sVSQL + "AND Nombre LIKE '" + sNombres + "%' ";

                if (sDNI.Length == 8)
                    sVSQL = sVSQL + "AND DNI = '" + sDNI + "' ";
                else
                    sVSQL = sVSQL + "AND DNI LIKE '" + sDNI + "%' ";

                if (sIdPaciente.Length > 3)
                    sVSQL = sVSQL + "AND Id_Paciente LIKE '" + sIdPaciente + "%' ";

                if (sNroHistoria.Length > 0)
                    sVSQL = sVSQL + "AND Nro_Historia LIKE '" + sNroHistoria + "%' ";

                sVSQL = sVSQL + "ORDER BY Ape_Paterno,Ape_Materno,Nombre" + (TDB == 1 ? "" : " Limit 50");
            }
            return sVSQL;
        }

        public static int vtrls(string parameter)
        {
            string[] array = { "ECOGRAFIA", "RAYOS X", "MAMOGRAFIA" };
            return array.Contains(parameter) ? 1 : 0;
        }

        public static void SetPropertyValue(object obj, string propName, object value)
        {
            obj.GetType().GetProperty(propName).SetValue(obj, value, null);
        }

        public static List<Dictionary<string, string>> GetDictionaryList(string sql, bool toUpperKey = false)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            using (SqlCommand cmd = new SqlCommand(sql, Conexion.CNN))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Dictionary<string, string> item = new Dictionary<string, string>();
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                string key = dr.GetName(i);
                                if (toUpperKey)
                                    key = dr.GetName(i).ToUpper();

                                item.Add(key, dr.GetValue(i).ToString());
                            }
                            list.Add(item);
                        }
                    }
                    dr.Close();
                }
            }
            return list;
        }

        public static Dictionary<string, string> GetDictionary(string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, Conexion.CNN))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Dictionary<string, string> item = new Dictionary<string, string>();
                            for (int i = 0; i < dr.FieldCount; i++)
                                item.Add(dr.GetName(i), dr.GetValue(i).ToString());

                            return item;
                        }
                    }
                    dr.Close();
                }
            }
            return null;
        }

        private static ListViewItem getListViewItem(Dictionary<string, string> item, string[] fields)
        {
            List<ListViewSubItem> values = new List<ListViewSubItem>();
            foreach (string field in fields)
            {
                ListViewSubItem subItem = new ListViewSubItem();
                subItem.Name = field;
                subItem.Text = item[field];
                values.Add(subItem);
            }
            return new ListViewItem(values.ToArray(), 0);
        }

        private static bool getFilter(Dictionary<string, string> item, Dictionary<string, string> filters)
        {
            bool ok = true;
            foreach (string key in filters.Keys)
            {
                if (!string.IsNullOrEmpty(key))
                    ok = ok && item[key].Contains(filters[key]);
            }
            return ok;
        }

        public static void Fill(DataGridView dataGridView, List<Dictionary<string, string>> items, string[] boolColumns = null)
        {
            dataGridView.Rows.Clear();

            foreach (Dictionary<string, string> item in items)
            {
                List<object> array = new List<object>();
                foreach (KeyValuePair<string, string> entry in item)
                {
                    if (boolColumns != null && boolColumns.Contains(entry.Key))
                        array.Add(entry.Value.ToString() == "1");
                    else
                        array.Add(entry.Value);
                }
                dataGridView.Rows.Add(array.ToArray());
            }
        }

        public static void Fill(ListView listview, List<Dictionary<string, string>> items, string[] fields, Dictionary<string, string> filters = null)
        {
            listview.Items.Clear();

            if (filters != null)
                listview.Items.AddRange(items.Where(i => General.getFilter(i, filters)).Select(c => General.getListViewItem(c, fields)).ToArray());
            else
                listview.Items.AddRange(items.Select(c => General.getListViewItem(c, fields)).ToArray());
        }

        public static void Fill(ComboBox comboBox, List<Dictionary<string, string>> items, string valueMember, string displayMember)
        {
            comboBox.Items.Clear();
            foreach (Dictionary<string, string> item in items)
            {
                ComboboxItem comboBoxItem = new ComboboxItem();
                comboBoxItem.Text = item[displayMember];
                comboBoxItem.Value = item[valueMember];
                comboBox.Items.Add(comboBoxItem);
            }
        }

        public static void Fill(ComboBox comboBox, List<string> items)
        {
            comboBox.Items.Clear();
            foreach (string item in items)
            {
                ComboboxItem comboBoxItem = new ComboboxItem();
                comboBoxItem.Text = item;
                comboBoxItem.Value = item;
                comboBox.Items.Add(comboBoxItem);
            }
        }

        public static ListViewItem GetSelectedItem(ListView listView)
        {
            foreach (ListViewItem item in listView.SelectedItems)
                return item;

            return null;
        }

        public static Dictionary<string, string> ConvertToDictionary(ListViewItem item)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (ListViewSubItem subitem in item.SubItems)
                dictionary[subitem.Name] = subitem.Text;

			return dictionary;
        }

        public static Dictionary<string, string> GetSelectedItemAsDictionary(ListView listView, bool returnFirst = true)
        {
            foreach (ListViewItem item in listView.SelectedItems)
                return General.ConvertToDictionary(item);

            if (listView.Items.Count > 0 && returnFirst)
                return General.ConvertToDictionary(listView.Items[0]);
            else
                return null;
        }

        public static int GetSelectedIndex(ListView listView, bool returnFirst = true)
        {
            foreach (int index in listView.SelectedIndices)
                return index;

            if (listView.Items.Count > 0 && returnFirst)
                return 0;
            else
                return -1;
        }

        public static int GetSelectedIndex(DataGridView dataGridView, bool returnFirst = true)
        {
            DataGridViewCell currentCell = dataGridView.CurrentCell;
            if (currentCell != null)
                return currentCell.RowIndex;

            if (dataGridView.Rows.Count > 0 && returnFirst)
                return 0;
            else
                return -1;
        }

        public static void AdjustComboBoxWidth(ComboBox comboBox)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in comboBox.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), comboBox.Font).Width;
                if (temp > maxWidth)
                    maxWidth = temp;
            }
            comboBox.DropDownWidth = maxWidth;
        }

        public static string GetSelectedString(ComboBox comboBox, string attribute)
        {
            return comboBox.SelectedIndex == -1 ? "" : ((DataRowView)comboBox.SelectedItem)[attribute].ToString();
        }

        public static string bfc(string nf, string lp)
        {
            if (nf == "Space")
                return (TDB == 1 ? "Space(" : "Repeat(' ',") + lp + ")";
            else
                return "";
        }

        public static void setAll<A, B>(Control control, string property, B value, bool recursive = true)
        {
            foreach (Control subControl in control.Controls)
            {
                if (subControl is A)
                {
                    Type t = subControl.GetType();
                    PropertyInfo p = t.GetProperty(property);
                    p.SetValue(subControl, value);
                }

                if (recursive && (subControl is Panel || subControl is GroupBox))
                    General.setAll<A, B>(subControl, property, value);
            }
        }

        public static bool chgst(string nt, string it, string st)
        {
            string ne = "";
            string ct = (nt == "Productos" ? "Id_Producto" : "Id_Consultorio");
            if (nt == "Productos")
            {
                string sql = "Select Descripcion From Consultorios Where LTrim(RTrim(Id_Consultorio))='" + it.Substring(0, 6) + "'";
                Dictionary<string, string> spc = General.GetDictionary(sql);
                ne = spc["Descripcion"];
            }

            string sql2 = "Update " + nt + " Set Estado='" + st + "' Where " + ct + "='" + it + "'";
            Conexion.ExecuteNonQuery(sql2);

            string sql3 = "Select Descripcion,Estado From " + nt + " Where LTrim(RTrim(" + ct + "))='" + it + "'";
            Dictionary<string, string> sta = General.GetDictionary(sql3);
            string vc = sta["Descripcion"];
            st = sta["Estado"];

            st = (st == "1" ? "ACTIVADO" : (st == "0" ? "DESACTIVADO" : "SEPARADO"));
            string ms = (nt == "Productos" ? vc + " de " : "Especialidad de ") + (nt == "Productos" ? ne : vc) + (st == "ACTIVADO" ? " " : " no ") + "vendan, ha sido " + st + ".";

            return msg(ms, "", false);
        }

        public static void UnselectListView(ListView listView)
        {
            for (int i = 0; i < listView.Items.Count; i++)
                listView.Items[i].Selected = false;
        }

        public static string exsp(string np, int db)
        {
            return (np.Length > 0 ? (db == 1 ? "Exec " + np + " " : "Select " + np + "(") : (db == 1 ? "" : ")"));
        }

        public static bool msg(string ms, string tw = "", bool mm = true)
        {
            if (mm)
                MessageBox.Show(ms, tw);

			return true;
            //Envia un mensaje a todos o algun usuario en la red local
            //return MessageBox.Show(ms, bw, MessageBoxButtons.YesNoCancel);
        }

        public static void valObj(TextBox obj, string txt)
        {
            if (obj.Text.Length == 0)
            {
                if (txt.Contains("paterno") || txt.Contains("materno"))
                {
                    if (MessageBox.Show("Falta " + txt + " ... desea guardar asi ... ?\npara ello de Click en 'Si' y vuelva a guardar ... ", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        obj.Text = ".";
                        return;
                    }
                }
                MessageBox.Show("Dato necesario, ingrese " + txt + " ...", "Advertencia");
                obj.Focus();
                return;
            }
        }

        public static int getYearsUntilNow(DateTime date)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - date.Year;
            if (date > now.AddYears(-age)) age--;
            return age;
        }

        public static int getYearsUntilNow(string date)
        {
            DateTime datetime = new DateTime();
            bool valid = DateTime.TryParse(date, out datetime);

            if (!valid)
                throw new Exception("Fecha inválida");

            return General.getYearsUntilNow(datetime);
        }

        /// <summary>
        /// Obtiene la cantidad de días desde una fecha hasta hoy
        /// </summary>
        /// <param name="date">Fecha de inicio</param>
        /// <returns>Cantidad de días</returns>
        public static int getDaysUntilNow(DateTime date)
        {
            DateTime now = DateTime.Today;
            return (int)(now - date).TotalDays;
        }

        public static int getDaysUntilNow(string date)
        {
            DateTime datetime = new DateTime();
            bool valid = DateTime.TryParse(date, out datetime);

            if (!valid)
                throw new Exception("Fecha inválida");

            return General.getDaysUntilNow(datetime);
        }

        public static string cnum(string lp)
        {
            int num = 0;
            bool result = int.TryParse(lp, out num);

            return result ? num.ToString() : lp;
        }

        public static void matxt(string ie, string cval)
        {
            string sql = "Select descripcion,val_abr From tablatipo Where descripcion Like '%" + ie + "%'";
            Dictionary<string, string> vsr = General.GetDictionary(sql);

            if (vsr != null)
            {
                string fp = vsr["Descripcion"];
                string cs = vsr["Val_Abr"];
                cval = (cs == "TAB" ? cval : cval.Replace("\t", cs));
                string fa = DateTime.Today.ToShortDateString();

                int c = Conexion.ExecuteScalar<int>("Select Count(*)As c From Tickets Where Id_Consultorio='" + ie + "' And Fecha_Emision>='" + fa + "'");

                if (c == 1)
                    File.Delete(fp);

                if (!File.Exists(fp))
                    File.WriteAllText(@fp, cval);
            }
        }

        public static Dictionary<string, string> GetDictionary(ComboBox combobox, int index)
        {
            if (combobox.Items.Count > 0 && index > -1)
            {
                DataRowView vrow = (DataRowView)combobox.Items[index];
                DataRow row = vrow.Row;
                return row.Table.Columns
                  .Cast<DataColumn>()
                  .ToDictionary(c => c.ColumnName, c => row[c].ToString());
            }
            else
                return null;
        }

        public static Dictionary<string, string> GetDictionary(DataGridView dataGridView, int index)
        {
            Dictionary<string, string> item = new Dictionary<string, string>();
            foreach (DataGridViewColumn column in dataGridView.Columns)
                item[column.DataPropertyName] = dataGridView.Rows[index].Cells[column.Name].Value.ToString();

			return item;
        }

        public static Dictionary<string, string> GetSelectedDictionary(ComboBox combobox)
        {
            int index = combobox.SelectedIndex;
            return General.GetDictionary(combobox, index);
        }

        public static Dictionary<string, string> GetSelectedDictionary(DataGridView dataGridView)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            return General.GetDictionary(dataGridView, index);
        }

        public static List<Dictionary<string, string>> GetDictionaryList(ComboBox combobox)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            for (int i = 0; i < combobox.Items.Count; i++)
                list.Add(General.GetDictionary(combobox, i));

            return list;
        }

        public static List<Dictionary<string, string>> GetDictionaryList(DataGridView dataGridView, bool selected = false)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            if (selected)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    list.Add(General.GetDictionary(dataGridView, row.Index));
            }
            else
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                    list.Add(General.GetDictionary(dataGridView, i));
            }
            return list;
        }

        public static string FormatDate(DateTime dateTime)
        {
            return String.Format("{0:MM/dd/yyyy}", dateTime);
        }

        public static string FormatDateTime(DateTime dateTime)
        {
            string sdate = String.Format("{0:G}", dateTime);
            return sdate.Replace(".", "");
        }

        public static void RemoveAll(DataGridView dataGridView, Predicate<Dictionary<string, string>> predicate)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                Dictionary<string, string> item = General.GetDictionary(dataGridView, i);
                if (predicate(item))
                {
                    dataGridView.Rows.RemoveAt(i);
                    i--; // this just got messy. But you see my point.
                }
            }
        }

        public static Dictionary<string, string> GetIGV()
        {
            string sql = "Select Id_Tipo,Descripcion From TablaTipo Where Id_Tabla In (Select Id_Tipo From " + "TablaTipo Where LTrim(RTrim(Descripcion)) Like '%IGV%' And LTrim(RTrim(Id_Tabla))='0') And Val_Abr='1' Order By 2";
            return General.GetDictionary(sql);
        }

        public static string SafeSubstring(string text, int startIndex, int length)
        {
            if (startIndex + length <= text.Length)
                return text.Substring(startIndex, length);
            else
                return text.Substring(startIndex);
        }

        public static bool vFecha(DateTime pfec, MaskedTextBox pobj)
        {
            DateTime sfec = DateTime.Today;

            if (pfec.Month != sfec.Month && pfec.Year != sfec.Year)
            {
                if (MessageBox.Show("Dato ingresado no corresponde al mes y año en curso ... desea continuar ?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    pobj.Text = General.emptyDate;
                    return false;
                }
            }

            if (pfec.Month != sfec.Month)
            {
                if (MessageBox.Show("Dato ingresado no corresponde al mes en curso...desea continuar ? ", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    pobj.Text = General.emptyDate;
                    return false;
                }
            }

            if (pfec.Year != sfec.Year)
            {
                if (MessageBox.Show("Dato ingresado no corresponde al año en curso ... desea continuar ?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    pobj.Text = General.emptyDate;
                    return false;
                }
            }
            return true;
        }

        public static string ProPer(string text)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(text);
        }

        public static bool CompFechas(DateTime fi, DateTime ff)
        {
            if (ff.CompareTo(fi) < 0)
            {
                MessageBox.Show("Fecha final no puede ser menor a la inicial ...\ncorregir los datos ...", "Advertencia");
                return false;
            }
            return true;
        }

        public static DataTable GetDataTable(List<Dictionary<string, string>> items)
        {
            if (items.Count > 0)
            {
                DataTable dataTable = new DataTable();
                foreach (KeyValuePair<string, string> entry in items[0])
                    dataTable.Columns.Add(entry.Key);

                foreach (Dictionary<string, string> item in items)
                {
                    var row = dataTable.NewRow();
                    foreach (KeyValuePair<string, string> entry in item)
                        row[entry.Key] = entry.Value;

                    dataTable.Rows.Add(row);
                }
                return dataTable;
            }
            else
                return null;
        }

		public static void UpdateVersionApp()
		{
			string[] vVer = null;
			bool NextV = false;
			var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			vVer = config.AppSettings.Settings["VERSION"].Value.ToString().Split('.');
			//Cambio menor (variables, constantes, propiedades)
			vVer[2] = (Convert.ToInt32(vVer[2]) + 1).ToString();
			if( Convert.ToInt32(vVer[2]) >= 100 )
			{
				vVer[2] = "0";
				NextV = true;
			}

			//Actualizacion funcionalidad existente (proceso, control, formulario) 
			if( NextV == true )
			{
				vVer[1] = (Convert.ToInt32(vVer[1]) + 1).ToString();
				if( Convert.ToInt32(vVer[1]) >= 20 )
				{
					vVer[1] = "0";
					NextV = true;
				}
				else
					NextV = false;
			}

			//Nueva funcionalidad (nuevo proceso, fomulario, control)
			if( NextV == true )
				vVer[0] = (Convert.ToInt32(vVer[0]) + 1).ToString();

			config.AppSettings.Settings["VERSION"].Value = vVer[0] + "." + vVer[1] + "." + vVer[2];
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");
		}
    }
}
	
