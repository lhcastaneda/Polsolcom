using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Polsolcom.Forms
{
	public partial class frmCRViewer : Form
	{
		ReportDocument rpt = new ReportDocument();

		public frmCRViewer( ReportDocument rptGraficar )
		{
			rpt = rptGraficar;
			InitializeComponent();
		}
		
		private void frmCRViewer_Load( object sender, EventArgs e )
		{
			crpViewer.ReportSource = rpt;
			crpViewer.RefreshReport();
		}
	}
}
