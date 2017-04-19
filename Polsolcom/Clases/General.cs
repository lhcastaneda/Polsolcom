using Microsoft.VisualBasic;
using Polsolcom.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Polsolcom.Clases
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

	public class Grafico
	{
		public static string sSQL { get; set; }
		public static string NombreSerie { get; set; }
		public static string LeyendaSerie { get; set; }
		public static string TituloChart { get; set; }
		public static string TipoChart { get; set; }
		public static string TituloX { get; set; }
		public static string TituloY { get; set; }
		public static string LeyendaX { get; set; }
		public static string LeyendaY { get; set; }
	}

	public class ItemMenus
    {
        public string Bar_Number { get; set; }
        public string Bar_Popup { get; set; }
        public string Bar_Prompt { get; set; }
        public string Bar_Order { get; set; }
        public string Bar_Command { get; set; }
        
        public ItemMenus(string _Number, string _Popup, string _Prompt, string _Order, string _Command )
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
        public static ToolTip ttMensaje = new ToolTip();
        public static List<TipoUsuario> lstTipoUsuario = new List<TipoUsuario>();
        
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

            if ( nlevel == 1 )
            {
                cor1 = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789-_.,";
                cor2 = "!9|z7·5s@3$1r%A&0t/2(4j=g6wR8#¿')eZH\\¡Y?<X,:W]-V{>k~^l;_m}[n+*ñaDKJy";
                e = 1;
                while ( e <= Strings.Len(cword) )
                {
                    i = 1;
                    if ( lflag == true )
                    {
                        //Convierte a caracters la cadena de letras
                        while ( i <= 68 )
                        {
                            if ( Strings.Mid(cor1, i, 1) == Strings.Mid(cword, e, 1) )
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
                        while ( i <= 68 )
                        {
                            if ( Strings.Mid(cor2, i, 1) == Strings.Mid(cword, e, 1) )
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
                for ( i = vlong; i >= 1; i += -1 )
                {
                    nasc = Strings.Asc(Strings.Mid(cword, i, 1));
                    if ( lflag == true )
                    {
                        if ( (nasc + 104) <= 255 )
                            cdone = cdone + Strings.Chr(nasc + 104);
                        else
                            cdone = cdone + Strings.Chr(255 - nasc);
                    }
                    else
                    {
                        if ( (nasc - 104) > 0 )
                            cdone = cdone + Strings.Chr(nasc - 104);
                        else
                            cdone = cdone + Strings.Chr(255 - nasc);
                    }
                }
            }
            return cdone;
        }

        public static void LlenaOperativo(SqlDataReader dr)
        {
            if ( dr.HasRows )
            {
                while ( dr.Read() )
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
        }

        public static void LlenaUsuario(SqlDataReader dr)
        {
            if ( dr.HasRows )
            {
                while ( dr.Read() )
                {
                    Usuario.id_us = dr.GetValue(0).ToString();
                    Usuario.usuario = dr.GetValue(1).ToString();
                    Usuario.clave= dr.GetValue(2).ToString();
                    Usuario.tipo = dr.GetValue(3).ToString();
                    Usuario.descripcion = dr.GetValue(4).ToString();
                    Usuario.id_area = dr.GetValue(5).ToString();
                    Usuario.cargo = dr.GetValue(6).ToString();
                }
                dr.Close();
            }
        }

        public static void LlenaTalon(SqlDataReader dr)
        {
            if ( dr.HasRows )
            {
                while ( dr.Read() )
                {
                    Talon.usuario = dr.GetValue(0).ToString();
                    Talon.fecha = Convert.ToDateTime(dr.GetValue(1).ToString());
                    Talon.ninicial = dr.GetValue(2).ToString();
                    Talon.nfinal = dr.GetValue(3).ToString();
                    Talon.id_oper = dr.GetValue(4).ToString();
                    Talon.serie = dr.GetValue(5).ToString();
                    Talon.dventa = Convert.ToChar(dr.GetValue(6).ToString());
                    Talon.ncon = dr.GetValue(7).ToString();
                    Talon.tdef = Convert.ToChar(dr.GetValue(8).ToString());
                }
                dr.Close();
            }
        }

        public static void LlenaEspecialidad(SqlDataReader dr)
        {
            if ( dr.HasRows )
            {
                while ( dr.Read() )
                {
                    Especialidad.esp = dr.GetValue(0).ToString();
                    Especialidad.nrz = dr.GetValue(1).ToString();
                    Especialidad.con = dr.GetValue(2).ToString();
                    Especialidad.tcn = dr.GetValue(3).ToString();
                }
                dr.Close();
            }
        }

        public static bool ValidaPass(string sPassword)
        {
            string c1 = sPassword.ToString();
            int x = 0;
            int y = 0;
            int z = 0;
            
            for ( int i = 0; i < c1.Length; i += 1 )
            {
                char sTemp = c1[i];
                if ( Char.IsDigit(sTemp) )
                    x = 1;

                if ( Char.IsUpper(sTemp) )
                    y = 1;

                if ( Char.IsLower(sTemp) )
                    z = 1;                
            }

            if ( (x + y + z) < 3 || c1.Length < 8 )
                return false;
            else
                return true;
        }

        public static void CargaTipoDocVenta(ComboBox cmb)
        {
            string vSQL = "";

            cmb.Items.Clear();

            vSQL = "SELECT Id_Tipo,Descripcion ";
            vSQL = vSQL + "FROM TablaTipo ";
            vSQL = vSQL + "WHERE Id_Tabla IN ";
            vSQL = vSQL + "(SELECT Id_Tipo ";
            vSQL = vSQL + " FROM TablaTipo ";
            vSQL = vSQL + " WHERE LTRIM(RTRIM(Descripcion)) = 'DOC_VENTA' ";
            vSQL = vSQL + " AND LTRIM(RTRIM(Id_Tabla)) = '0') ";
            vSQL = vSQL + "ORDER BY 2 ";
            Conexion.CMD.CommandText = vSQL;
            using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
            {
                if ( drLectura.HasRows )
                {
                    while ( drLectura.Read() )
                        cmb.Items.Add(new Item(drLectura.GetValue(1).ToString(), Convert.ToInt32(drLectura.GetValue(0).ToString())));
                }
                drLectura.Close();
            }
            cmb.SelectedIndex = -1;
        }

        public static string DevuelveUsuario(string id_usuario)
        {
            string sUsuario = "";
            string vSQL = "";

            vSQL = "SELECT nombres + ' ' + ape_paterno + ' ' + ape_materno AS persona ";
            vSQL = vSQL + "FROM personal ";
            vSQL = vSQL + "WHERE Id_Personal = '" + id_usuario + "' ";
            using ( SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN) )
            {
                using ( SqlDataReader drUsuario = cmd.ExecuteReader() )
                {
                    if ( drUsuario.HasRows )
                    {
                        while ( drUsuario.Read() )
                            sUsuario = drUsuario.GetValue(0).ToString();
                    }
                    drUsuario.Close();
                }            
            }
            return sUsuario;
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
            Talon.dventa = '\0';
            Talon.ncon = "";
            Talon.tdef = '\0';

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

            vSQL = "SELECT Id_Tipo,Descripcion ";
            vSQL = vSQL + " FROM TablaTipo ";
            vSQL = vSQL + " WHERE Id_Tabla IN ";
            vSQL = vSQL + " (SELECT Id_Tipo ";
            vSQL = vSQL + "  FROM TablaTipo ";
            vSQL = vSQL + "  WHERE LTRIM(RTRIM(Descripcion)) = 'TIPO_USUARIO' ";
            vSQL = vSQL + "  AND LTRIM(RTRIM(Id_Tabla)) = '0') ";
            vSQL = vSQL + " ORDER BY 1 ";
            Conexion.CMD.CommandText = vSQL;
            using ( SqlDataReader dr = Conexion.CMD.ExecuteReader() )
            {
                if ( dr.HasRows )
                {
                    while ( dr.Read() )
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

            vSQL = "SELECT Key_Pass AS Usuario  ";
            vSQL = vSQL + "FROM sysaccusers ";
            vSQL = vSQL + "WHERE LTRIM(RTRIM(Id_Us)) = '" + sVariable + "' ";
            vSQL = vSQL + "OR LTRIM(RTRIM(Key_Pass)) = '" + sVariable + "' ";
            using ( SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN) )
            {
                using ( SqlDataReader drUsuario = cmd.ExecuteReader() )
                {
                    if ( drUsuario.HasRows )
                    {
                        while ( drUsuario.Read() )
                            sUsuario = cryptgr(drUsuario.GetValue(0).ToString(),false,1);
                    }
                    drUsuario.Close();
                }
            }
            return sUsuario;
        }
    }
}
