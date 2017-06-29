using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using System.Drawing;
using Polsolcom.Dominio.Helpers;

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
            //borra la serie 
            chartGrafico.Series.Clear();

            //Agregamosáreas y series
            foreach (Serie serie in Grafico.series)
            {
                chartGrafico.Series.Add(serie.leyenda);
            }

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



            for (int i = 0; i < Grafico.series.Count; i++)
            {
                //seteos generales del grafico
                chartGrafico.Series[i].ChartType = chartTYPE;
                chartGrafico.Series[i].Color = Grafico.series[i].color;
                chartGrafico.Series[i].IsXValueIndexed = true;
                chartGrafico.Series[i].IsVisibleInLegend = true;
                chartGrafico.Series[i].ChartArea = chartGrafico.ChartAreas[0].Name;
                chartGrafico.Series[i].Font = new Font("Verdana", 16, FontStyle.Bold);
            }


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
                            for (int j = 0; j < Grafico.series.Count; j++) {
                                chartGrafico.Series[j].Points.AddXY(dr.GetString(Grafico.series.Count), dr.GetInt32(j));
                                chartGrafico.Series[j].Points[i].Label = dr.GetInt32(j).ToString();
                                chartGrafico.Series[j].Points[i].Font = new Font("Verdana", 10, FontStyle.Bold);
                            }
                               
							i = i + 1;
						}
						dr.Close();
					}
				}
			}
		}




	}
}
