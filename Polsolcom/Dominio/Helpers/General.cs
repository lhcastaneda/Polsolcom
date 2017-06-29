using Microsoft.VisualBasic;
using Polsolcom.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Connection;
using Polsolcom.Resources;
using System.Data;

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
        public static List<Serie> series { get; set; }
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
                    Usuario.usuario = dr.GetValue(1).ToString().Trim();
					Usuario.clave = dr.GetValue(2).ToString().Trim();
					Usuario.tipo = cryptgr(dr.GetValue(3).ToString().Trim(), false, 2);
					Usuario.descripcion = dr.GetValue(4).ToString().Trim();
					Usuario.id_area = dr.GetValue(5).ToString().Trim();
					Usuario.cargo = dr.GetValue(6).ToString().Trim();
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
            using (SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN))
            {
                using (SqlDataReader drUsuario = cmd.ExecuteReader())
                {
                    if (drUsuario.HasRows)
                    {
                        while (drUsuario.Read())
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

            vSQL = "SELECT Key_Pass AS Usuario  " +
                    "FROM sysaccusers " +
                    "WHERE LTRIM(RTRIM(Id_Us)) = '" + sVariable + "' " +
                    "OR LTRIM(RTRIM(Key_Pass)) = '" + sVariable + "' ";
            using (SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN))
            {
                using (SqlDataReader drUsuario = cmd.ExecuteReader())
                {
                    if (drUsuario.HasRows)
                    {
                        while (drUsuario.Read())
                            sUsuario = cryptgr(drUsuario.GetValue(0).ToString(), false, 1);
                    }
                    drUsuario.Close();
                }
            }
            return sUsuario;
        }
        #endregion

        public static void LlenaOperativo()
        {
            //consulta que trae los datos del centro operativo
           string  vSQL = "SELECT O.Descripcion,O.Id_Oper,O.Estado,MO.Descripcion As Mod_Oper, ";
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

        public static List<Lugar>TraerLugares()
        {
            List<Lugar> ListaLugares = new List<Lugar>();
            var vSQL = "SELECT * " +
                    "FROM ubigeo2005 ";
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
            vSQL = "SELECT *";
            vSQL = vSQL + "FROM  Institucion";
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
            var vSQL = "SELECT *";
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

        public static List<Consultorio> TraerConsultorios(string operativo)
        {
            List<Consultorio> ConsultorioList = new List<Consultorio>();
            var vSQL = "SELECT * FROM  Consultorios WHERE Estado = '1' And SubString(Id_Consultorio,1, 3) = '" + operativo + "' ORDER BY 1";

            Conexion.CMD.CommandText = vSQL;
            SqlDataReader dr = Conexion.CMD.ExecuteReader();
            //declarandolo de esta manera el datareader se puede usar nuevamente mas adelante
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Consultorio oConsultorio = new Consultorio()
                        {
                            Id = dr.GetValue(0).ToString(),
                            Descripcion = dr.GetValue(1).ToString(),
                            Estado = dr.GetValue(2).ToString(),
                            Turno = dr.GetValue(3).ToString(),
                            Tipo = dr.GetValue(4).ToString(),
                            Observacion = dr.GetValue(5).ToString(),
                            Us_Ing = dr.GetValue(6).ToString(),
                            Us_Mod = dr.GetValue(7).ToString(),
                            Fec_Ing = dr.GetValue(8).ToString(),
                            Fec_Mod = dr.GetValue(9).ToString()
                        };
                        ConsultorioList.Add(oConsultorio);
                    }
                    dr.Close();
                }
            
           
            return ConsultorioList;
        } 

        public static List<Producto> TraerProductos()
        {
            List<Producto> ProductosList = new List<Producto>();
            bool statebool = false;
            var vSQL = "SELECT *";
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

        #region Estadistica Pacientes
        public static List<StatPatientsModel> TraerDatosPacientes()
        {
            SqlDataReader drStatPatientsList;
            List<StatPatientsModel> StatPatientsList = new List<StatPatientsModel>();
            var vSQL = Variables.PatientQuery;
            SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN);
            drStatPatientsList = cmd.ExecuteReader();              
            while (drStatPatientsList.Read())
            {
                StatPatientsModel oConsultorio = new StatPatientsModel()
                {
                    Year = Convert.ToInt32(drStatPatientsList.GetValue(0)),
                    Month = drStatPatientsList.GetValue(1).ToString(),
                    Fecha = Convert.ToDateTime(drStatPatientsList.GetValue(2)),
                    Pnew = Convert.ToInt32(drStatPatientsList.GetValue(3)),
                    PCon = Convert.ToInt32(drStatPatientsList.GetValue(4)),
                    Ptot = Convert.ToInt32(drStatPatientsList.GetValue(5))
                };
                StatPatientsList.Add(oConsultorio);
            }
            return StatPatientsList;
        }

    }

    public class StatPatientsModel
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public DateTime Fecha { get; set; }
        public int Pnew { get; set; }
        public int PCon { get; set; }
        public int Ptot { get; set; }
    }
    #endregion

}
