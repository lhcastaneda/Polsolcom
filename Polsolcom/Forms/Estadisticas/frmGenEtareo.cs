using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;
using System.Windows.Forms.DataVisualization.Charting;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Connection;

namespace Polsolcom.Forms
{
	public partial class frmGenEtareo : System.Windows.Forms.Form 
	{
		//define variable para SQL
		string vSQL = "";
		DataSet dt = new DataSet();
		DataTable dtg = new DataTable();
		Chart chartFinal = new Chart();

		public frmGenEtareo() 
		{
			InitializeComponent();
		}

		private void BorraTablaTemporal()
		{
			//borra la tabla temporal
			vSQL = "DELETE FROM tmpGETareo WHERE id_user = '" + Usuario.id_us + "'";
			Conexion.CMD.CommandText = vSQL;
			Conexion.CMD.ExecuteNonQuery();
		}

		public void FormateaGrilla()
		{
			fGrid.RowHeader.Visible = false;
            fGrid.DefaultRow.Height = 20;
            fGrid.Cols.Count = 3;
            fGrid.Cols[0].Text = "Sexo";
			fGrid.Cols[0].Width = 95;
			fGrid.Cols[0].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[0].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
			fGrid.Cols[0].CellStyle.ReadOnly = iGBool.True;
			fGrid.Cols[1].Text = "Grupo Etareo";
			fGrid.Cols[1].Width = 100;
			fGrid.Cols[1].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
			fGrid.Cols[1].CellStyle.ReadOnly = iGBool.True;
			fGrid.Cols[2].Text = "Cantidad";
			fGrid.Cols[2].Width = 90;
			fGrid.Cols[2].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
			fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;
		}

		private void WorkerMethod( object sender, WaitWindowEventArgs e )
		{
			BorraTablaTemporal();
			try
			{
				//selecciona los datos e inserta en tabla temporal
				vSQL = "INSERT INTO tmpGETareo " +
						"SELECT X.Sexo,X.Gpo_Etareo,Sum(Cantidad) AS Cantidad,'" + Usuario.id_us + "' " +
						"FROM(SELECT O.DescripciON AS Operativo," +
						"   Departamento, Provincia, Distrito," +
						"   CASE WHEN P.Sexo = 'M' THEN 'Masculino' ELSE 'Femenino' END AS Sexo," +
						"   CASE WHEN P.Edad BETWEEN 0 AND 4 THEN '00 a 04' WHEN P.Edad BETWEEN 5 AND 9 THEN '05 a 09'" +
						"   WHEN P.Edad BETWEEN 10 AND 14 THEN '10 a 14' WHEN P.Edad BETWEEN 15 AND 19 THEN '15 a 19'" +
						"   WHEN P.Edad BETWEEN 20 AND 24 THEN '20 a 24' WHEN P.Edad BETWEEN 25 AND 29 THEN '25 a 29'" +
						"   WHEN P.Edad BETWEEN 30 AND 34 THEN '30 a 34' WHEN P.Edad BETWEEN 35 AND 39 THEN '35 a 39'" +
						"   WHEN P.Edad BETWEEN 40 AND 44 THEN '40 a 44' WHEN P.Edad BETWEEN 45 AND 49 THEN '45 a 49'" +
						"   WHEN P.Edad BETWEEN 50 AND 54 THEN '50 a 54' WHEN P.Edad BETWEEN 55 AND 59 THEN '55 a 59'" +
						"   WHEN P.Edad BETWEEN 60 AND 64 THEN '60 a 64' WHEN P.Edad BETWEEN 65 AND 69 THEN '65 a 69'" +
						"   WHEN P.Edad BETWEEN 70 AND 74 THEN '70 a 74' WHEN P.Edad BETWEEN 75 AND 79 THEN '75 a 79'" +
						"   WHEN P.Edad >= 80 THEN 'Mayor a 80' END AS Gpo_Etareo," +
						"   COUNT(P.Id_Paciente) AS Cantidad" +
						"   FROM Pacientes P INNER JOIN( " +
						"    SELECT Id_Paciente, Left(Nro_Historia, 3) AS Id_Oper " +
						"    FROM Tickets WHERE Anulado = '' " +
						"    AND CONVERT(VARCHAR, Fecha_Emision, 103) >= '" + dtpicFInicial.Text.Substring(0, 10) + "' " +
						"    AND CONVERT(VARCHAR, Fecha_Emision, 103) <= '" + dtpicFFinal.Text.Substring(0, 10) + "' " +
						"    GROUP BY Id_Paciente, Left(Nro_Historia, 3)) T" +
						"   ON T.Id_Paciente = P.Id_Paciente" +
						"   INNER JOIN Operativo O" +
						"   ON T.Id_Oper = O.Id_Oper" +
						"   LEFT JOIN Ubigeo2005 U" +
						"   ON P.Id_Distrito = U.Id_Old" +
						"   WHERE T.Id_Oper = '" + Operativo.id_oper + "'" +
						"   GROUP BY O.Descripcion, Departamento, Provincia, Distrito, P.Sexo, P.Edad) X " +
						" GROUP BY X.Sexo,X.Gpo_Etareo" +
						" ORDER BY 1,2";
				Conexion.CMD.CommandType = CommandType.Text;
				Conexion.CMD.CommandText = vSQL;
				Conexion.CMD.ExecuteNonQuery();
				
				//agrupa los datos para mostrarlos en la grilla
				vSQL = "SELECT sexo, gpo_etareo, cantidad" +
					   " FROM tmpGETareo" +
					   " WHERE id_user = '" + Usuario.id_us + "'" +
					   " ORDER BY 1, 2";
				Conexion.CMD.CommandText = vSQL;
				using ( SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD) )
				{
					dt.Clear();
					da.Fill(dt);
					da.Dispose();
				}
			}
			catch ( SqlException ex )
			{
				MessageBox.Show(ex.Message);
				return;
			}

			if ( e.Arguments.Count > 0 )
				e.Result = e.Arguments[0].ToString();
			else
				e.Result = "Proceso culminado.";
		}

		private void btnCerrar_Click( object sender, EventArgs e )
		{
			BorraTablaTemporal();
			//cierra el formulario cuando se presiona la tecla ESC
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frmGenEtareo_KeyDown( object sender, KeyEventArgs e )
		{
			//cierra el formulario cuando se presiona la tecla ESC
			if ( e.KeyCode == Keys.Escape )
			{
				BorraTablaTemporal();
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}

		private void btnEjecutar_Click( object sender, EventArgs e )
		{
			if(dtpicFInicial.Text == "")
			{
				MessageBox.Show("Debe seleccionar una fecha de inicio.", "Estadistica - Genero y Grupo Etareo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			if ( dtpicFFinal.Text == "" )
			{
				MessageBox.Show("Debe seleccionar una fecha final.", "Estadistica - Genero y Grupo Etareo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			if ( Convert.ToDateTime(dtpicFFinal.Text.ToString()) < Convert.ToDateTime(dtpicFInicial.Text.ToString()) )
			{
				MessageBox.Show("Fecha final debe ser mayor o igual que la fecha inicial.", "Estadistica - Genero y Grupo Etareo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			object result = Dominio.Helpers.WaitWindow.Show(this.WorkerMethod, "Procesando la consulta...");
			if ( result == null )
			{
				MessageBox.Show("No se pudo procesar la consulta.");
				return;
			}

			//llena la grilla con los datos
			fGrid.Rows.Clear();
			IDataReader dr = dt.CreateDataReader();
			fGrid.FillWithData(dr);
			dr.Close();
			FormateaGrilla();
			
			int iCant = 0;
			for ( int i = 0; i <= fGrid.Rows.Count - 1; i++ )
				iCant = iCant + Convert.ToInt32(fGrid.Cells[i, 2].Value);

			lblCantidad.Text = iCant.ToString();
		}

		private void frmGenEtareo_Load( object sender, EventArgs e )
		{
			lblCantidad.Text = "";
			dtpicFInicial.Value = DateTime.Now;
			dtpicFFinal.Value = DateTime.Now;
			FormateaGrilla();
		}

		private void dtpicFInicial_ValueChanged( object sender, EventArgs e )
		{
			dtpicFFinal.Text = dtpicFInicial.Text;
		}

		private void btnVerGraf_Click( object sender, EventArgs e )
		{
			bool bEncontrado = false;

			//valida que alguna opcion del tipo de grafico debe estar seleccionado
			foreach ( Control cntrl in grpTipoGraph.Controls )
			{
				RadioButton rb = (RadioButton)cntrl;
				if ( rb.Checked )
				{
					bEncontrado = true;
					break;
				}
			}

			if( bEncontrado == false )
			{
				MessageBox.Show("Debe seleccionar un tipo de grafico.", "Estadistica - Genero y Grupo Etareo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			//valida que alguna opcion de agrupacion este seleccionado
			bEncontrado = false;
			foreach ( Control cntrl in grpGender.Controls )
			{
				RadioButton rb = (RadioButton)cntrl;
				if ( rb.Checked )
				{
					bEncontrado = true;
					break;
				}
			}

			if ( bEncontrado == false )
			{
				MessageBox.Show("Debe seleccionar un tipo de agrupacion.", "Estadistica - Genero y Grupo Etareo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}
				
			//define el tipo de grafico a usar
			if ( optColumnas.Checked == true )
				Grafico.TipoChart = "Column";
			else if ( optBarras.Checked == true )
				Grafico.TipoChart = "Bar";
			else if ( optAreas.Checked == true )
				Grafico.TipoChart = "Area";
			else if ( optLineas.Checked == true )
				Grafico.TipoChart = "Line";
			else if ( optCircular.Checked == true )
				Grafico.TipoChart = "Pie";

			if ( optSexo.Checked == true )
			{   //agrupa los datos por sexo
				vSQL = "SELECT sexo AS campo, SUM(cantidad) AS total" +
				       " FROM tmpGETareo" +
				       " GROUP BY sexo" +
				       " ORDER BY 1";
			}
			else
			{   //agrupa los datos por etareo
				vSQL = "SELECT gpo_etareo AS campo, SUM(cantidad) AS total" + 
				       " FROM tmpGETareo" +
				       " GROUP BY gpo_etareo" +
				       " ORDER BY 1";
			}
			//define los valores que se enviara al formulario que grafica
			Grafico.sSQL = vSQL;
			Grafico.LeyendaSerie = "Distribucion de la Informacion";
			Grafico.TituloChart = "Grafico Estadistico del " + dtpicFInicial.Text.Substring(0, 10) + " al " + dtpicFFinal.Text.Substring(0, 10) + ((optSexo.Checked == true) ? " Por Genero" : " Por Grupo Etareo");
			Grafico.TituloX = ((optSexo.Checked == true) ? "Genero" : "Grupo Etareo");
			Grafico.LeyendaX = "Agrupacion por Distribucion";
			Grafico.TituloY = "Cantidad";
			Grafico.LeyendaY = "En Unidades";

			//crea el formulario del grafico
			frmGrafico frg = new frmGrafico();
			frg.CargaChart();
			frg.Text = "Grafico Estadistico " + ( ( optSexo.Checked == true ) ? "Por Genero" : "Por Grupo Etareo" );
			frg.ShowDialog();
		}

		private void fGrid_KeyDown( object sender, KeyEventArgs e )
		{
			//cierra el formulario cuando se presiona la tecla ESC
			if ( e.KeyCode == Keys.Escape )
			{
				BorraTablaTemporal();
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}

	




	}
}