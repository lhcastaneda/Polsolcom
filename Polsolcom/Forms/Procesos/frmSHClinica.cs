﻿using Dapper;
using Polsolcom.Forms.Herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
	public partial class frmSHClinica : Form
	{
		public frmSHClinica()
		{
			InitializeComponent();
		}

		private void frmSHClinica_Load( object sender, EventArgs e )
		{

		}

		protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
		{
			bool result = false;

			if ( keyData == Keys.F3 )
			{
				result = true;
			}
			else if ( keyData == Keys.F4 )
			{
				result = true;
			}
			else if ( keyData == Keys.F5 )
			{
				result = true;
			}
			else if ( keyData == Keys.F6 )
			{
				result = true;
			}
			else
				result = base.ProcessCmdKey(ref msg, keyData);


			return result;

		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			int iCant = 0;
			string vSQL = "SELECT Count(Name) AS C " +
						  "FROM master.dbo.sysdatabases " +
						  "WHERE Name = 'DNI'";
			using ( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				try
				{
					if ( db.State == ConnectionState.Closed )
						db.Open();

					iCant = db.ExecuteScalar<int>(vSQL);
				}
				catch ( Exception ex )
				{
					MessageBox.Show(ex.Message);
				}
			}

			if (iCant > 0 )
				if ( MessageBox.Show("Desea realizar busqueda en base de datos general...?", "Busqueda Pacientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No )
				{
					//boton habilita
				}
				else
				{
					frmBuscar fr = new frmBuscar();
					fr.ShowDialog();
				}

		}

		private void frmSHClinica_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}
	}
}