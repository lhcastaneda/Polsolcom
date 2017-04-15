using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Collections.Generic;
using Polsolcom.Clases;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel; 

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
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void frmGrafico_Load( object sender, EventArgs e )
		{


	

		}

	

		


	}
}
