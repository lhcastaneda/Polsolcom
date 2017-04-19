using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Polsolcom.Clases;
using System.Configuration;
using System.Drawing;

namespace Polsolcom.Forms
{
	public partial class frmGrafico : Form
	{
		public frmGrafico( )
		{
			InitializeComponent();
		}

		private void btnCerrar_Click( object sender, EventArgs e )
		{
			DialogResult = DialogResult.Cancel;
			chartGrafico.Series.Dispose();
			Close();
		}
		
		private void frmGrafico_Load( object sender, EventArgs e )
		{

		}
		
		internal void CargaChart()
		{
			//borra las leyendas y agrega una nueva
			chartGrafico.Legends.Clear();
			chartGrafico.Legends.Add(Grafico.LeyendaX);
			chartGrafico.Legends.Add(Grafico.LeyendaY);
			//borra la area y agrega una nueva
			chartGrafico.ChartAreas.Clear();
			chartGrafico.ChartAreas.Add("Area");
			//borra la serie y agrega una nueva
			chartGrafico.Series.Clear();
			chartGrafico.Series.Add(Grafico.LeyendaSerie);

			//Define el tipo de grafico a mostrar
			SeriesChartType chartTYPE = new SeriesChartType();
			if ( Grafico.TipoChart == "Bar" )
				chartTYPE = SeriesChartType.Bar;
			else if ( Grafico.TipoChart == "Area" )
				chartTYPE = SeriesChartType.Area;
			else if ( Grafico.TipoChart == "Line" )
				chartTYPE = SeriesChartType.Line;
			else if ( Grafico.TipoChart == "Column" )
				chartTYPE = SeriesChartType.Column;
			else if ( Grafico.TipoChart == "Pie" )
				chartTYPE = SeriesChartType.Pie;
						
			//seteos generales del grafico
			chartGrafico.Series[0].ChartType = chartTYPE;
			chartGrafico.Series[0].Color = System.Drawing.Color.Blue;
			chartGrafico.Series[0].IsXValueIndexed = true;
			chartGrafico.Series[0].IsVisibleInLegend = true;
			chartGrafico.Series[0].ChartArea = chartGrafico.ChartAreas[0].Name;
			chartGrafico.Series[0].Font = new Font("Verdana", 16, FontStyle.Bold);

			//seteo del eje X
			chartGrafico.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;
			chartGrafico.ChartAreas[0].AxisX.TextOrientation = TextOrientation.Horizontal;
			chartGrafico.ChartAreas[0].AxisX.Title = Grafico.TituloX;
			chartGrafico.ChartAreas[0].AxisX.TitleFont = new Font("Verdana", 14, FontStyle.Bold);

			//seteo del eje Y
			chartGrafico.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;
			chartGrafico.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Auto;
			chartGrafico.ChartAreas[0].AxisY.Title = Grafico.TituloY;
			chartGrafico.ChartAreas[0].AxisY.TitleFont = new Font("Verdana", 14, FontStyle.Bold);

			//agrega el titulo al grafico 
			chartGrafico.Titles.Add(new Title(Grafico.TituloChart, Docking.Top, new Font("Verdana", 20, FontStyle.Bold), Color.Black));

			using ( SqlConnection cnxDB = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				cnxDB.Open();
				using ( SqlCommand cmdExec = new SqlCommand(Grafico.sSQL, cnxDB) )
				using ( SqlDataReader dr = cmdExec.ExecuteReader() )
				{
					if ( dr.HasRows )
					{
						int i = 0;
						while ( dr.Read() )
						{	//dibuja los puntos de la grafica
							chartGrafico.Series[0].Points.AddXY(dr.GetString(0), dr.GetInt32(1));
							chartGrafico.Series[0].Points[i].Label = dr.GetValue(1).ToString();
							chartGrafico.Series[0].Points[i].Font = new Font("Verdana", 10, FontStyle.Bold);
							i = i + 1;
						}
						dr.Close();
					}
				}
			}
		}




	}
}
