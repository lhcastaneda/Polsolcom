using Dapper;
using Polsolcom.Forms.Herramientas;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Connection;

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
			Habilita(0);

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
			if( btnNuevo.Text == "&Nuevo Paciente" )
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
						Habilita(1);
					else
					{
						General.ODB = 1;  //1: Nuevo Paciente, 0: Paciente Existente
						frmBuscar fr = new frmBuscar();
						fr.ShowDialog();
					}
				else
					Habilita(1);

				
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
					LimpiaControles(this);
					UbicaItemCombo(cmbTDoc,Talon.dventa);
					UbicaItemCombo(cmbMVen, "");
					UbicaItemCombo(cmbInstitucion, TieneInstitucion());
					txtSerie.Text = Talon.serie;
					txtDigitador.Text = Usuario.usuario;
					txtNombres.Focus();
					break;
				case 1:
					Habilita(0);
					btnNuevo.Text = "&Grabar Venta";
					txtFechaEmision.Text = General.FechaServidor();
					UbicaItemCombo(cmbDistrito, Operativo.id_distrito.Substring(0, 4));
					UbicaItemCombo(cmbProvincia, Operativo.id_distrito.Substring(0,4));
					UbicaItemCombo(cmbDepartamento, Operativo.id_distrito.Substring(0,2));
					ValidaRangosDocsVenta();
					txtNombres.Focus();
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

		private void LimpiaControles( Control con )
		{
			foreach( Control c in con.Controls )
			{
				if( c is TextBox )
					( (TextBox)c ).Clear();
				else if( c is ComboBox )
					( (ComboBox)c ).SelectedIndex = -1;

				if( c.HasChildren )
					LimpiaControles(c);
			}
		}

		private void UbicaItemCombo (ComboBox cmb, string sValor)
		{
			if( sValor == null )
				sValor = "";

			foreach( var item in cmb.Items )
				if( ((Ubigeo)item).IdUbigeo == sValor )
				{
					cmb.SelectedItem = item;
					break;
				}
		}

		private string TieneInstitucion()
		{
			string sRes = "";
			string sQuery = "SELECT Id_Inst FROM Tickets " + 
							"WHERE Nro_Historia In " + 
							"(SELECT Max(Nro_Historia) " + 
							" FROM Tickets " + 
							" WHERE Fecha_Emision >= CAST('" + General.FechaServidor("YYYY-MM-DD") + "' AS smalldatetime) " + 
							" And Digitador = '" + Usuario.id_us + "' " +
							" And Id_Consultorio In " + 
							" (SELECT Left(Id_producto, 6) " + 
							"  FROM ImpFicha WHERE Estado = '1'))";
			using( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				try
				{
					if( db.State == ConnectionState.Closed )
						db.Open();

					sRes = db.ExecuteScalar<string>(sQuery);
				}
				catch( Exception ex )
				{ MessageBox.Show(ex.Message); }
			}
			return sRes;
		}

		private bool ValidaRangosDocsVenta()
		{
			string F1 = General.FechaServidor("YYYY-MM-DD");
			string F2 = Convert.ToDateTime(F1).AddDays(1).ToString("yyyy-MM-dd");
			int iCant = 0;
			string sRes = "";
			string sQuery = "";
			string NCon = "";
			bool Error = false;

			sQuery = "SELECT COUNT(*) AS C " + 
				  	 "FROM Talon " + 
					 "WHERE Fecha Between CAST('" + F1 + "' AS smalldatetime) " +
					 "AND CAST('" + F2 + "' AS smalldatetime) " +  
					 "AND Usuario = '" + Usuario.id_us + "' " +
					 "AND Id_Oper = '" + Operativo.id_oper + "' " +
					 "AND NCon <> NFinal " + 
					 "AND NCon <> '' " + 
					 "AND Serie = '" + Talon.serie + "' " +
					 "AND DVenta = '" + Talon.dventa + "'";
			using( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				if( db.State == ConnectionState.Closed )
					db.Open();

				iCant = db.ExecuteScalar<int>(sQuery);
				if( iCant > 0 && NCon != "" )
				{
					sQuery = "UPDATE Talon " +
							 "SET NCon= '" + NCon + "' " +
							 "WHERE Fecha Between CAST('" + F1 + "' AS smalldatetime) " +
							 "AND CAST('" + F2 + "' AS smalldatetime) " +
							 "AND Usuario = '" + Usuario.id_us + "' " +
							 "AND Id_Oper = '" + Operativo.id_oper + "' " +
							 "AND NCon <> NFinal " + 
							 "AND NCon <> '' " +
							 "AND Serie = '" + Talon.serie + "' " +
							 "AND DVenta = '" + Talon.dventa + "'";
					iCant = db.Execute(sQuery);

					sQuery = "UPDATE Talon " + 
							 "SET NFinal = NCon, " + 
							 "NCon = '' " +
							 "WHERE Fecha Between CAST('" + F1 + "' AS smalldatetime) " +
							 "AND CAST('" + F2 + "' AS smalldatetime) " +
							 "AND Usuario = '" + Usuario.id_us + "' " +
							 "AND Id_Oper = '" + Operativo.id_oper + "' " +
							 "AND NCon = NFinal " + 
							 "AND NCon <> '' " +
							 "AND Serie = '" + Talon.serie + "' " +
							 "AND DVenta = '" + Talon.dventa + "'";
					iCant = db.Execute(sQuery);
				}

				sQuery = "SELECT COUNT(*) C " + 
						 "FROM Talon " +
						 "WHERE Fecha Between CAST('" + F1 + "' AS smalldatetime) " +
						 "AND CAST('" + F2 + "' AS smalldatetime) " +
						 "AND Usuario = '" + Usuario.id_us + "' " +
						 "AND Id_Oper = '" + Operativo.id_oper + "' " +
						 "AND NCon <> NFinal " + 
						 "AND NCon <> '' " +
						 "AND Serie = '" + Talon.serie + "' " +
						 "AND DVenta = '" + Talon.dventa + "'";
				iCant = db.ExecuteScalar<int>(sQuery);

				sQuery = "SELECT Usuario,Fecha,NInicial,NFinal,Id_Oper,Serie,DVenta,NCon,TDef " +
						 "FROM Talon " +
						 "WHERE Fecha Between CAST('" + F1 + "' AS smalldatetime) " +
						 "AND CAST('" + F2 + "' AS smalldatetime) " +
						 "AND Usuario = '" + Usuario.id_us + "' " +
						 "AND Id_Oper = '" + Operativo.id_oper + "' " +
						 "AND NCon <> NFinal " +
						 "AND NCon <> '' " +
						 "AND Serie = '" + Talon.serie + "' " +
						 "AND DVenta = '" + Talon.dventa + "'";
				using( SqlCommand cmd = new SqlCommand(sQuery, Conexion.CNN) )
				{
					using( SqlDataReader dr = cmd.ExecuteReader() )
					{
						if( dr.HasRows )
							General.LlenaTalon(dr);
						dr.Close();
					}
				}
			}

			sRes = iCant>0 ? (int.Parse(Talon.ncon) == 0 ? Talon.ninicial : Convert.ToString(int.Parse(Talon.ncon) + 1)) : "";
			if( ( sRes == null || sRes == String.Empty || sRes == "" ) )
			{
				MessageBox.Show("No tiene rango de documentos de venta ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				Error = true;
			}
			else
			{
				Error = ValidaUsoTicket(Talon.serie, Talon.ninicial, Talon.dventa);
				if( Error == false )
					txtNroTicket.Text = Talon.ninicial;
			}
			return Error;
		}

		private bool ValidaUsoTicket(string sSerie, string sInicial, string sDventa)
		{
			int iCant = 0;
			string sQuery = "";
			bool Error = false;

			sQuery = "SELECT COUNT(*) AS C FROM Tickets " +
					 "WHERE Serie = '" + sSerie + "' " +
					 "AND DVenta = '" + sDventa + "'" +
					 "AND Nro_Ticket = '" + sInicial + "'";
			using( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				if( db.State == ConnectionState.Closed )
					db.Open();

				iCant = db.ExecuteScalar<int>(sQuery);
			}

			sQuery = "SELECT Nro_Historia,Nro_Ticket,CONVERT(VARCHAR(10),Fecha_Emision,103) AS Fecha," +
					 "Id_Consultorio,Id_Paciente,Digitador,Anulado,ForPago,Descuento," +
					 "Serie,CMP,Id_Inst,Moneda,Convenio,DVenta,Id_Bus,tsg " +
					 "FROM Tickets " +
					 "WHERE Serie = '" + sSerie + "' " +
					 "AND DVenta = '" + sDventa + "'" +
					 "AND Nro_Ticket = '" + sInicial + "'";
			using( SqlCommand cmd = new SqlCommand(sQuery, Conexion.CNN) )
			{
				using( SqlDataReader dr = cmd.ExecuteReader() )
				{
					if( dr.HasRows )
					{
						dr.Read();
						if( iCant > 0 )
						{
							MessageBox.Show("El recibo N° " + dr.GetValue(9).ToString() + "-" + dr.GetValue(1).ToString() + " ya fue emitido por " + General.TradUser(dr.GetValue(5).ToString()) + (char)13 + " en fecha del " + dr.GetValue(2).ToString() + ", comuniquese con el administrador del" + (char)13 + "sistema de manera inmediata. Es de urgencia !!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
							txtNroTicket.Text = "";
							Error = true;
						}
					}
					dr.Close();
				}
			}
			return Error;
		}
	}
}
