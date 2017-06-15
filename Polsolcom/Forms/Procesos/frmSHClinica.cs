using Dapper;
using Polsolcom.Forms.Herramientas;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Helpers;

namespace Polsolcom.Forms.Procesos
{
	public partial class frmSHClinica : Form
	{
		bool bTieneDocVenta = false;

		public frmSHClinica()
		{
			InitializeComponent();
		}

		private void frmSHClinica_Load( object sender, EventArgs e )
		{
			bTieneDocVenta = General.TieneDocVenta(Usuario.id_us,"");
			if( bTieneDocVenta == true )
			{
				General.LlenarRegistroVenta(Usuario.id_us, "");
				btnNuevo.Enabled = true;
				btnAgregar.Enabled = true;
				btnQuitar.Enabled = true;
			}
			else
			{
				


			}

			General.LUbigeo("","DEPARTAMENTO", cmbDepartamento);
			General.LUbigeo("", "PROVINCIA", cmbProvincia);
			General.LUbigeo("", "DISTRITO", cmbDistrito);
			txtDigitador.Text = Usuario.usuario;

			General.LlenaComboBox(cmbEspecialista, "MEDICO");
			General.LlenaComboBox(cmbInstitucion, "INSTITUCION");
			General.LlenaComboBox(cmbMVen, "FORMA_PAGO");
			General.LlenaComboBox(cmbTDoc, "DOC_VENTA");
			General.LlenaComboBox(cmbIGV, "IGV");

			//llena combo especialidad
			string vSQL = "SELECT DISTINCT Descripcion,Id_Consultorio AS IdUbigeo " + 
						  "FROM Consultorios " + 
						  "WHERE Id_Consultorio LIKE '" + Operativo.id_oper + "%' " +
						  "AND Estado= '1' " + 
						  "Order By 1";
			General.LlenaComboBox(cmbEspecialidad, "SQL", vSQL);

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
			if( btnNuevo.Text == "Nuevo Paciente" )
			{
				int iCant = 0;
				string vSQL = "SELECT Count(Name) AS C FROM master.dbo.sysdatabases WHERE Name = 'DNI'";
				using( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
				{
					try
					{
						if( db.State == ConnectionState.Closed )
							db.Open();

						iCant = db.ExecuteScalar<int>(vSQL);
					}
					catch( Exception ex )
					{ MessageBox.Show(ex.Message); }
				}

				if( iCant > 0 )
					if( MessageBox.Show("Desea realizar busqueda en base de datos general...?", "Busqueda Pacientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No )
					{
						Habilita(1);
					}
					else
					{
						frmBuscar fr = new frmBuscar();
						fr.ShowDialog();
					}

			}
			else
			{

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

		private void Habilita(int iOpcion)
		{
			switch( iOpcion )
			{
				case 0:
					break;
				case 1:
					break;
				case 2:
					break;
				case 3:
					break;
				case 4:
					break;
				case 5:
					break;
				case 6:
					break;
			}
		}
	}
}
