using System;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Polsolcom.Clases
{
    public static class Conexion
    {
        public static string connetionString {get;set;}
        public static string strServer {get;set;}
        public static SqlConnection CNN {get;set;}
        public static SqlCommand CMD {get;set;}
       
        static public SqlConnection ConectaBD()
        {
            strServer = "server";
            if ( strServer == "" )
            {
                MessageBox.Show("No se obtuvo nombre del servidor de base de datos." + (char)13 + "Contactar al administrador de sistemas", "Error Conexion");
                Application.Exit();
                return null;
            }
            else
            {
                connetionString = "Server=" + strServer + ";Database=DesPolsolcom;Integrated Security=SSPI;Connect Timeout=15;MultipleActiveResultSets=true;";
                CNN = new SqlConnection();
                CMD = new SqlCommand();

                CNN.ConnectionString = connetionString;
                CNN.Open();
                if ( CNN.State == ConnectionState.Open )
                    return CNN;
                else
                {
                    MessageBox.Show("Error de Conexion" + (char)13 + "Conctactar al administrador de sistemas", "Conexion BD");
                    Application.Exit();
                    return null;
                }
            }
        }
    }

	public static class AppSetings
	{
		Configuration 

	}
}
