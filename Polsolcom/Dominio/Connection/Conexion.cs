using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Polsolcom.Dominio.Connection
{
    public static class Conexion
    {
        public static string connetionString { get; set; }
        public static string strServer { get; set; }
        public static SqlConnection CNN { get; set; }
        public static SqlCommand CMD { get; set; }

        static public SqlConnection ConectaBD()
        {
            strServer = "server";
            if (strServer == "")
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
                if (CNN.State == ConnectionState.Open)
                    return CNN;
                else
                {
                    MessageBox.Show("Error de Conexion" + (char)13 + "Conctactar al administrador de sistemas", "Conexion BD");
                    Application.Exit();
                    return null;
                }
            }
        }

        static public void AddParameter(string column, object value)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@" + column;
            param.Value = value;

            CMD.Parameters.Add(param);


        }

        /// <summary>
        /// Retorna un DataTable
        /// </summary>
        /// <param name="sql">Consulta SQL a generar</param>
        /// <returns>DataTable</returns>
        public static DataTable GetTable(string sql)
        {
            CMD.CommandText = sql;
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static int ExecuteNonQuery(string sql)
        {
            CMD.CommandText = sql;
            return CMD.ExecuteNonQuery();
        }

        public static T ExecuteScalar<T>(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, CNN);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                return (T)Convert.ChangeType(dr.GetValue(0), typeof(T));
            }

            return default(T);
        }

        public static SqlDataReader GetDataReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, CNN);
            return cmd.ExecuteReader();
        }
    }
	
}
