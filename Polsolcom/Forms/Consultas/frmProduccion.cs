using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
    public partial class frmProduccion : Form
    {
        string vSQL = "";

        public frmProduccion()
        {
            InitializeComponent();
        }

        private void BorraTablaTemporal()
        {
            //borra la tabla temporal
            string vSQL = "IF OBJECT_ID('tempdb.dbo.#tmpProduccion', 'U') IS NOT NULL DROP TABLE #tmpProduccion;";
            Conexion.CMD.CommandText = vSQL;
            Conexion.CMD.ExecuteNonQuery();
        }

        private void cargarUsuarios()
        {
            DateTime fechaInicio = dtpFechInicio.Value;
            DateTime fechaFinal = dtpFechFinal.Value;

            this.cajerosTableAdapter.Fill(this.cajerosDS.Cajeros, fechaInicio, fechaFinal);

            //Desencriptar
            for (int i = 0; i < cmbCajero.Items.Count; i++)
            {
                DataRowView row = (DataRowView)cmbCajero.Items[i];
                row.Row["Usuario"] = General.cryptgr(row.Row["Usuario"].ToString(), false, 1);
            }
        }

        private void generateSQL(int mod, List<string> arrayEspecialidades, List<string> arrayMeses)
        {
            DateTime fechaInicio = dtpFechInicio.Value;
            DateTime fechaFin = dtpFechFinal.Value;
            string idUsuario = ((DataRowView)cmbCajero.SelectedItem).Row["Id_User"].ToString();
            string consultorio = ((DataRowView)cmbEspecialidad.SelectedItem).Row["Id_User"].ToString();
            //string consultorio = ((DataRowView)cmbEspecialidad.SelectedItem).Row["Id_User"].ToString();




            //cmbCajero.Items[i];
            //row.Row["Usuario"] = General.cryptgr(row.Row["Usuario"]



            //cmbCajero.SelectedItem;



            /*
            string fechaInicio = dtpFechInicio.Value;

            xfi = LEFT(TTOC(.cmbfec_ini.object.value), 10) + ' ' + SUBSTR(TTOC(.spnhor_ini.object.value), 12, 12)
            xff = LEFT(TTOC(.cmbfec_fin.object.value), 10) + ' ' + SUBSTR(TTOC(.spnhor_fin.object.value), 12, 12)
            xus = ALLTRIM(.cmbusuario.value)
            xcn = ALLTRIM(.cmbconsultorio.value)
            xop = ALLTRIM(STR(.optfilt.value))
            scad = 'Exec TotDet ?xFi,?xFf,?xUs,?xCn,?xOp'

            vSQL = "CREATE TABLE #tmpProduccion(Consultorio varchar(20), Tickets int, Cantidad int, Total int, Fecha DateTime, TCons varchar(25), Operativo varchar(20), Mes varchar(10), Año int);" +
        "INSERT INTO #tmpEstVent EXEC TotCons @fini = '" + String.Format("{0:dd/MM/yyyy}", dtpicFInicial.Value) + "', @ffin = '" + String.Format("{0:dd/MM/yyyy}", dtpicFFinal.Value) + "', @idc = '" + String.Join(",", arrayEspecialidades.ToArray()) + "', @mod = " + mod.ToString() + ";" +
        "SELECT Fecha, SUM(Tickets) AS Tickets, SUM(Cantidad) AS Cantidad, SUM(Total) AS Total FROM #tmpEstVent GROUP BY Fecha ORDER BY 1;";
        */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            //abre la conexion a la BD
            Conexion.CNN = Conexion.ConectaBD();
            Conexion.CMD.Connection = Conexion.CNN;

            General.LlenaOperativo();
            this.consultoriosTableAdapter.Fill(this.consultoriosDS.Consultorios, Operativo.id_oper);
        }

        private void frmProduccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BorraTablaTemporal();
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
