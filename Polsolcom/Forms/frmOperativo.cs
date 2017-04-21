using Polsolcom.Clases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Polsolcom.Forms
{
    public partial class frmOperativo : Form
    {
        public frmOperativo()
        {
            InitializeComponent();
        }

        private void frmOperativo_Load(object sender, EventArgs e)
        {
            //llena combo tipo de modalidad
            string vSQL = "select Descripcion, Id_Tipo" +
                    " From TablaTipo" +
                    " Where Id_Tabla In" +
                    " (Select Id_Tipo From tablaTipo" +
                    " Where Descripcion = 'MODALIDAD_OPERATIVO'" +
                    " And Id_Tabla = '0')" +
                    " Order By 2";
            Conexion.CMD.CommandText = vSQL;
            using (SqlDataReader dr = Conexion.CMD.ExecuteReader())
            {
                cmbModOper.Items.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                        cmbModOper.Items.Add(new Item(dr.GetValue(0).ToString(), Convert.ToInt32(dr.GetValue(1).ToString())));
                }
                dr.Close();
            }

            //llema estados 
            vSQL = "Select Descripcion,Id_Tipo" +
                    " From TablaTipo" +
                    " Where Id_Tabla In" +
                    " (Select Id_Tipo" +
                    " From TablaTipo" +
                    " Where Descripcion = 'ESTADO_OPERATIVO' " +
                    " And Id_Tabla = '0') " +
                    " Order By 2";
            Conexion.CMD.CommandText = vSQL;
            using (SqlDataReader dr = Conexion.CMD.ExecuteReader())
            {
                cmbEstado.Items.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                        cmbEstado.Items.Add(new Item(dr.GetValue(0).ToString(), Convert.ToInt32(dr.GetValue(1).ToString())));
                }
                dr.Close();
            }

            //llenar lista de operativos

        }
    }
}
