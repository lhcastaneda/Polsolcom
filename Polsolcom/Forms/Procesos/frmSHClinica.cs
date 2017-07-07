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
using System.Linq;
using TenTec.Windows.iGridLib;
using System.Collections.Generic;

namespace Polsolcom.Forms.Procesos
{
	public partial class frmSHClinica : Form
	{
		bool bTieneDocVenta = false;
		string BUS = "";
		string NROHISTORIA = "";
		DataGridViewComboBoxCell ComboProducto = new DataGridViewComboBoxCell();
		static List<Temporal> lstTemp = new List<Temporal>();

		public frmSHClinica()
		{
			InitializeComponent();
		}

		private void frmSHClinica_Load( object sender, EventArgs e )
		{
			General.ttMensaje.InitialDelay = 0;
			General.ttMensaje.IsBalloon = false;
			FormateaGrids();
			btnBuscarT.Enabled = true;
			bTieneDocVenta = General.TieneDocVenta(Usuario.id_us,"");
			if( bTieneDocVenta == true )
			{
				General.LlenarRegistroVenta(Usuario.id_us, "");
				btnNuevo.Enabled = true;
				btnBuscar.Enabled = true;
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
			btnAgregar.Enabled = false;
			btnQuitar.Enabled = false;
			
		}
		
		private void FormateaGrids()
		{
			iGDropDownList cmb = new iGDropDownList();
			iGrid.RowHeader.Visible = false;
			iGrid.DefaultRow.Height = 17;
			iGrid.Cols.Count = 5;
			//producto
			iGrid.Cols[0].Text = "Descripcion del Producto o Servicio";
			iGrid.Cols[0].Width = 425;
			iGrid.Cols[0].CellStyle.ImageAlign = iGContentAlignment.MiddleLeft;
			iGrid.Cols[0].CellStyle.DropDownControl = cmb; //agrega el combobox
			iGrid.Cols[0].CellStyle.TypeFlags = iGCellTypeFlags.NoTextEdit;
			iGrid.Cols[0].CellStyle.ValueType = typeof(string);
			
			//cantidad
			iGrid.Cols[1].Text = "Cant.";
			iGrid.Cols[1].Width = 40;
			iGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			iGrid.Cols[1].CellStyle.ReadOnly = iGBool.False;
			//precio
			iGrid.Cols[2].Text = "Precio";
			iGrid.Cols[2].Width = 50;
			iGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
			iGrid.Cols[2].CellStyle.FormatString = "{0:#,#}";
			iGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;
			//sub total
			iGrid.Cols[3].Text = "Sub Total";
			iGrid.Cols[3].Width = 60;
			iGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleRight;
			iGrid.Cols[3].CellStyle.FormatString = "{0:#,#}";
			iGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;
			//id
			iGrid.Cols[4].Text = "ID";
			iGrid.Cols[4].Width = 1;
			iGrid.Cols[4].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			iGrid.Cols[4].CellStyle.ReadOnly = iGBool.True;
			// Popup menu de la grid
			//iGrid.ContextMenuStrip = new ContextMenuStrip();
			//iGrid.ContextMenuStrip.Items.Add("Exportar");
			//iGrid.ContextMenuStrip.Items.Add("Copiar");
			

		}

		private DataGridViewComboBoxCell LlenaProductos( string sCategoria, string idProducto = "" )
		{
			DataGridViewComboBoxCell cmb = new DataGridViewComboBoxCell();

			string sQuery = "SELECT descripcion,CAST(SubString(Id_Producto,4,5) AS INT) AS Id_Producto " +
							"FROM Productos " +
							"WHERE 1 = 1 " +
							"AND Estado = '1' " +
							"AND LEFT(Id_Producto,6) = '" + sCategoria.Trim() + "' ";
			if(idProducto != "")
				sQuery = sQuery + "AND Id_Producto = '" + idProducto + "' ";
			else
				sQuery = sQuery + "ORDER BY 1";

			cmb.DataSource = null;
			cmb.Items.Clear();

			using( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				try
				{
					if( db.State == ConnectionState.Closed )
						db.Open();

					cmb.DataSource = db.Query<Prod>(sQuery).ToList();
					cmb.DisplayMember = "descripcion";
					cmb.ValueMember = "id_producto";
				}
				catch( Exception ex )
				{ MessageBox.Show(ex.Message); }
			}
			
			return cmb;

		}

		private iGDropDownList CargaProductos( string sCategoria, string idProducto = "" )
		{
			iGDropDownList cmb = new iGDropDownList();
			string sQuery = "SELECT CAST(SubString(Id_Producto,4,5) AS INT) AS Id,Descripcion " +
							"FROM Productos " +
							"WHERE 1 = 1 " +
							"AND Estado = '1' " +
							"AND LEFT(Id_Producto,6) = '" + sCategoria.Trim() + "' ";
			if( idProducto != "" )
				sQuery = sQuery + "AND Id_Producto = '" + idProducto + "' ";
			else
				sQuery = sQuery + "ORDER BY 1";

			Conexion.CMD.CommandText = sQuery;
			cmb.Items.Clear();
			cmb.FillWithData(Conexion.CMD, "Id", "Descripcion");

			if( cmb.Items.Count == 1 )
				cmb.Items[0].Selectable = true;
			
			return cmb;
		}
		
		private string DevuelvePrecioProducto( string idProduct )
		{
			string sPrecio = "";

			string sQuery = "SELECT monto " +
							"FROM Productos " +
							"WHERE 1 = 1 " +
							"AND Estado = '1' " +
							"AND Id_Producto = '" + idProduct.Trim() + "' ";
			using( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				try
				{
					if( db.State == ConnectionState.Closed )
						db.Open();

					sPrecio = db.ExecuteScalar<string>(sQuery);
					sPrecio = sPrecio.Trim();
				}
				catch( Exception ex )
				{ MessageBox.Show(ex.Message); }
			}
			return sPrecio;

		}
		
		protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
		{
			bool result = false;
			object sender = new object();
			EventArgs e = new EventArgs();

			if( keyData == Keys.F3 )
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
			else if( keyData == Keys.Insert)
			{
				btnNuevo_Click(sender,e);
				result = true;
			}
			else
				result = base.ProcessCmdKey(ref msg, keyData);

			return result;
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			string sIDPaciente = "";

			if( btnNuevo.Text == "&Nuevo Paciente" )
			{
				btnBuscar.Enabled = false;
				General.ODB = 1;  //1: Nuevo Paciente, 0: Paciente Existente
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
						frmBuscar fr = new frmBuscar();
						fr.ShowDialog();

						if(fr.DialogResult != DialogResult.OK)
							return;
						else
							sIDPaciente = fr.lblIdPaciente.Text;

						CargaDatosPaciente(General.ODB, sIDPaciente);
						btnBuscar.Enabled = false;
						btnDuplica.Enabled = false;
						btnBuscarT.Enabled = false;
						txtDireccion.Focus();
					}
				else
					Habilita(1);
			}
			else if ( btnNuevo.Text == "&Grabar Venta" )
			{
				if( int.Parse(txtTotal.Text) == 0 )
				{
					if( MessageBox.Show("No ha agregado productos, desea hacerlo...?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No )
					{
						btnNuevo.Text = "&Nuevo Paciente";
						btnBuscar.Enabled = true;
						btnBuscarT.Enabled = true;
						ValidaDatosTicket("");
						BloqueaControles();

					}
					else
						txtDNI.Focus();
				}
				else
				{

				}


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
					txtDNI.Focus();
					break;
				case 1:
					Habilita(0);
					btnNuevo.Text = "&Grabar Venta";
					txtFechaEmision.Text = General.FechaServidor();
					UbicaItemCombo(cmbDistrito, Operativo.id_distrito);
					UbicaItemCombo(cmbProvincia, Operativo.id_distrito.Substring(0,4));
					UbicaItemCombo(cmbDepartamento, Operativo.id_distrito.Substring(0,2));
					ValidaRangosDocsVenta();
					txtDNI.Focus();
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

		private void UbicaItemCombo(ComboBox cmb, string sValor)
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
			string sQuery = "SELECT ISNULL(Id_Inst ,'') AS Id_Inst FROM Tickets " + 
							"WHERE Nro_Historia In " + 
							"(SELECT Max(Nro_Historia) " + 
							" FROM Tickets " +
							" WHERE Fecha_Emision >= CONVERT(Datetime, '" + General.FechaServidor("YYYY-MM-DD") + "', 120) " + 
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
			string F1 = General.FechaServidor();
			string F2 = Convert.ToDateTime(F1).AddDays(1).ToString("dd/MM/yyyy");
			string sRes = "";
			string sQuery = "";
			bool Error = false;
			
			sQuery = "EXEC GenDocVen '" + F1 + "','" + F2 + "','" + Usuario.id_us + "','" + Operativo.id_oper + "','" + Talon.serie + "','" + Talon.dventa + "',''";
			using( SqlCommand cmd = new SqlCommand(sQuery, Conexion.CNN) )
			{
				using( SqlDataReader dr = cmd.ExecuteReader() )
				{
					if( dr.HasRows )
					{
						General.LlenaTalon(dr);
						sRes = int.Parse(Talon.ncon) == 0 ? Talon.ninicial : Convert.ToString(int.Parse(Talon.ncon) + 1) ;
					}
					dr.Close();
				}
			}
			
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

		private void CargaDatosPaciente(int iTipo, string sPaciente, int iEstado = 0)
		{
			string sSQL = "";

			txtDigitador.Text = Usuario.usuario;
			txtSerie.Text = Talon.serie;

			if(iTipo == 0) //0: paciente existente
			{
				sSQL = "SELECT id_paciente,nombre,ape_paterno,ape_materno,dni,edad," +
						"CASE WHEN sexo = 'M' THEN 'MASCULINO' ELSE 'FEMENINO' END AS sexo," +
						"telefono,direccion,asegurado,id_distrito,odoc,e_mail,nro_historia,fecha_nac " +
						"FROM Pacientes P ";
				if (iEstado==0)
					sSQL = sSQL + "WHERE id_paciente = '" + sPaciente + "' ";
				else
					sSQL = sSQL + "WHERE dni = '" + sPaciente + "' ";

				using(SqlCommand cmd = new SqlCommand( sSQL, Conexion.CNN ))
				{
					using(SqlDataReader dr = cmd.ExecuteReader())
					{
						if(dr.HasRows)
						{
							Habilita(0);
							dr.Read();
							txtNHP.Text = (dr.GetValue(13).ToString().Length == 0? "0": dr.GetValue(13).ToString());
							NROHISTORIA = txtNHP.Text;
							txtID.Text = dr.GetValue(0).ToString();
							txtNombres.Text = dr.GetValue(1).ToString();
							txtApePaterno.Text = dr.GetValue(2).ToString();
							txtApeMaterno.Text = dr.GetValue(3).ToString();
							txtDNI.Text = dr.GetValue(4).ToString();
							txtEdad.Text = dr.GetValue(5).ToString();
							txtSexo.Text = dr.GetValue(6).ToString();
							txtTelefono.Text = dr.GetValue(7).ToString();
							txtDireccion.Text = dr.GetValue(8).ToString();
							txtAsegurado.Text = dr.GetValue(9).ToString();
							UbicaItemCombo(cmbDepartamento, dr.GetValue(10).ToString().Substring(0, 2));
							UbicaItemCombo(cmbProvincia, dr.GetValue(10).ToString().Substring(0, 4));
							UbicaItemCombo(cmbDistrito, dr.GetValue(10).ToString());
							txtODoc.Text = dr.GetValue(11).ToString();
							txtEmail.Text = dr.GetValue(12).ToString();
							txtFecNac.Text = dr.GetValue(14).ToString();
						}
						dr.Close();
					}
				}
			}
			else //1: paciente nuevo
			{
				sSQL = "SELECT P.Dni,P.Nombres,P.Ape_Pat,P.Ape_Mat,CONVERT(datetime, P.Fec_Nac,112) AS Fec_Nac, " + 
						"DATEDIFF(YEAR, P.Fec_Nac, CONVERT(VARCHAR, GETDATE(), 112)) AS Edad," + 
						" CASE WHEN sexo = 1 THEN 'MASCULINO' ELSE 'FEMENINO' END AS sexo,U.Id_Old " + 
						" FROM DNI..Padron P INNER JOIN DNI..Ubigeo2005 U " + 
						"ON P.Ubigeo = U.Ubigeo " +
						"WHERE DNI = '" + sPaciente + "' ";
				using( SqlCommand cmd = new SqlCommand(sSQL, Conexion.CNN) )
				{
					using( SqlDataReader dr = cmd.ExecuteReader() )
					{
						if( dr.HasRows )
						{
							dr.Read();
							Habilita(0);
							btnNuevo.Text = "&Grabar Venta";
							txtFechaEmision.Text = General.FechaServidor();
							txtNHP.Text = "0";
							NROHISTORIA = txtNHP.Text;
							UbicaItemCombo(cmbDepartamento, dr.GetValue(7).ToString().Substring(0, 2));
							UbicaItemCombo(cmbProvincia, dr.GetValue(7).ToString().Substring(0, 4));
							UbicaItemCombo(cmbDistrito, dr.GetValue(7).ToString());
							txtNombres.Text = dr.GetValue(1).ToString();
							txtApePaterno.Text = dr.GetValue(2).ToString();
							txtApeMaterno.Text = dr.GetValue(3).ToString();
							txtDNI.Text = dr.GetValue(0).ToString();
							txtEdad.Text = dr.GetValue(5).ToString();
							txtSexo.Text = dr.GetValue(6).ToString();
							txtFecNac.Text = dr.GetValue(4).ToString().Substring(0,10);
						}
						dr.Close();
					}
				}
			}
			ValidaRangosDocsVenta();
		}

		private void txtDNI_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
				e.Handled = true;
		}

		private void txtDNI_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}

			if( e.KeyCode == Keys.Enter )
			{
				if( txtDNI.Text.Trim().Length == 8 )
				{
					if( bTieneDocVenta == false )
						return;

					CargaDatosPaciente(General.ODB, txtDNI.Text, 1);
					txtDireccion.Focus();
				}
				e.Handled = true;
			}
		}

		private void cmbDepartamento_SelectedIndexChanged( object sender, EventArgs e )
		{
			Ubigeo itm = (Ubigeo)cmbDepartamento.SelectedItem;
			
			if( cmbDepartamento.SelectedIndex != -1)
				General.LUbigeo(itm.IdUbigeo.Trim().Substring(0, 2), "PROVINCIA", cmbProvincia);
		}

		private void cmbProvincia_SelectedIndexChanged( object sender, EventArgs e )
		{
			Ubigeo itm = (Ubigeo)cmbProvincia.SelectedItem;

			if( cmbProvincia.SelectedIndex != -1 )
				General.LUbigeo(itm.IdUbigeo.Trim().Substring(0, 4), "DISTRITO", cmbDistrito);
		}

		private void btnBuscar_Click( object sender, EventArgs e )
		{

		}

		private void btnDuplica_Click( object sender, EventArgs e )
		{

		}

		private void btnBuscarT_Click( object sender, EventArgs e )
		{
			frmBuscaT fr = new frmBuscaT();
			fr.ShowDialog();

			if( fr.DialogResult != DialogResult.OK )
				return;
			else
				NROHISTORIA = fr.lblTicket.Text;

			if( NROHISTORIA != "" )
			{
				CargaDatosHistoria(NROHISTORIA);
				btnImprimir.Enabled = true;
			}

		}

		private void btnAgregar_Click( object sender, EventArgs e )
		{
			if( bTieneDocVenta == false )
				return;

			if( cmbEspecialidad.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar una especialidad...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			if( cmbEspecialista.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un especialidad...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

		}

		private void btnQuitar_Click( object sender, EventArgs e )
		{

		}

		private void btnImprimir_Click( object sender, EventArgs e )
		{

		}

		private void CargaDatosHistoria( string sNroHistoria )
		{
			string sSQL = "";

			if( sNroHistoria == "" || sNroHistoria.Length == 0 )
				return;

			sSQL = "SELECT T.Nro_Historia, T.Nro_Ticket, T.Fecha_Emision, T.Id_Consultorio, T.Id_Paciente, " + 
					"T.Digitador, T.Anulado, T.ForPago, T.Descuento, T.Serie, T.CMP, T.Id_Inst, T.Moneda, " + 
					"T.Convenio, T.DVenta, T.Id_Bus, T.tsg, P.Nombre, P.Ape_Paterno, P.Ape_Materno, " + 
					"P.DNI, P.Fecha_Nac, P.Edad, P.Sexo, P.Telefono, P.Direccion, P.Asegurado, P.Id_Distrito, " + 
					"P.ODoc, P.E_Mail, C.Descripcion, C.Estado, C.Turno, " + 
					"C.Tipo, C.Observacion " +
					"FROM Tickets T INNER JOIN Pacientes P " +
					"ON T.Id_Paciente = P.Id_paciente " +
					"INNER JOIN Consultorios C " +
					"ON T.Id_Consultorio = C.Id_Consultorio " +
					"WHERE T.Nro_Historia = '" + sNroHistoria + "'";
			using( SqlCommand cmd = new SqlCommand(sSQL, Conexion.CNN) )
			{
				using( SqlDataReader dr = cmd.ExecuteReader() )
				{
					if( dr.HasRows )
					{
						while( dr.Read() )
						{
							txtNHP.Text = dr.GetValue(0).ToString().Trim();
							txtNroTicket.Text = dr.GetValue(1).ToString().Trim();
							txtFechaEmision.Text = dr.GetValue(2).ToString().Trim();
							UbicaItemCombo(cmbEspecialidad, dr.GetValue(3).ToString().Trim());
							txtID.Text = dr.GetValue(4).ToString().Trim();
							txtDigitador.Text = General.TradUser(dr.GetValue(5).ToString().Trim());
							UbicaItemCombo(cmbMVen, dr.GetValue(7).ToString().Trim());
							if( dr.GetValue(8).ToString().Trim() !="")
								if( dr.GetValue(8).ToString().Substring(0, 1) == "D" )
								{
									string ads = dr.GetValue(8).ToString().Substring(29, 9).Trim();

									sSQL = "Select LTrim(RTrim(Ape_Paterno))+' '+LTrim(RTrim(Ape_Materno))+' '+LTrim(RTrim(Nombres))Personal,Id_Personal " +
											"From Personal " +
											"Where Id_Personal = '" + ads.Trim() + "' " +
											"Union All " +
											"Select Nom_Raz_Soc Personal,TInst + Id_Inst Id_Personal " +
											"  From Institucion " +
											"  Where TInst + Id_Inst = '" + ads.Trim() + "' ";

									using( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
									{
										try
										{
											if( db.State == ConnectionState.Closed )
												db.Open();

											dynamic returns = db.Query<dynamic>(sSQL);
											txtAutoriza.Text = returns[0].Personal + " (S/. " + dr.GetValue(8).ToString().Substring(38, 8).Trim() + ")";
										}
										catch( Exception ex )
										{ MessageBox.Show(ex.Message); }
									}
								}
							txtSerie.Text = dr.GetValue(9).ToString().Trim();
							UbicaItemCombo(cmbEspecialista, dr.GetValue(10).ToString().Trim());
							UbicaItemCombo(cmbInstitucion, dr.GetValue(11).ToString().Trim());
							UbicaItemCombo(cmbTDoc, dr.GetValue(14).ToString().Trim());
							txtNombres.Text = dr.GetValue(17).ToString();
							txtApePaterno.Text = dr.GetValue(18).ToString();
							txtApeMaterno.Text = dr.GetValue(19).ToString();
							txtDNI.Text = dr.GetValue(20).ToString();
							txtFecNac.Text = dr.GetValue(21).ToString();
							txtEdad.Text = dr.GetValue(22).ToString();
							txtSexo.Text = dr.GetValue(23).ToString();
							txtTelefono.Text = dr.GetValue(24).ToString();
							txtDireccion.Text = dr.GetValue(25).ToString();
							txtAsegurado.Text = dr.GetValue(26).ToString();
							UbicaItemCombo(cmbDepartamento, dr.GetValue(27).ToString().Substring(0, 2));
							UbicaItemCombo(cmbProvincia, dr.GetValue(27).ToString().Substring(0, 4));
							UbicaItemCombo(cmbDistrito, dr.GetValue(27).ToString());
							txtODoc.Text = dr.GetValue(28).ToString();
							txtEmail.Text = dr.GetValue(29).ToString();
							//carga detalle
							CargaDetalleTicket(sNroHistoria, dr.GetValue(3).ToString().Trim());
						}
					}
					dr.Close();
				}
			}
		}

		private void ValidaDatosTicket( string sNroHistoria )
		{
			string sSQL = "";

			if( sNroHistoria != "" || sNroHistoria.Length != 0 )
			{
				sSQL = "SELECT Nro_Historia,Nro_Ticket,Fecha_Emision,Id_Consultorio, " + 
						"Id_Paciente,Digitador,Anulado,ForPago,Descuento,Serie, " + 
						"CMP,Id_Inst,Moneda,Convenio,DVenta,Id_Bus,tsg " + 
						"FROM Tickets " + 
						"WHERE Nro_Historia = '" + sNroHistoria + "'";
			}
			else
			{
				sSQL = "SELECT Nro_Historia,Nro_Ticket,Fecha_Emision,Id_Consultorio," + 
						"Id_Paciente,Digitador,Anulado,ForPago,Descuento,Serie," + 
						"CMP,Id_Inst,Moneda,Convenio,DVenta,Id_Bus,tsg " + 
						"FROM Tickets " + 
						"WHERE Fecha_Emision IN " + 
						"(SELECT MAX(Fecha_Emision) " + 
						" FROM Tickets " + 
						" WHERE Digitador = '" + Usuario.id_us + "' " + 
						" AND Fecha_Emision >= Convert(Varchar(10), GetDate(), 103)) " +
						"AND Digitador = '" + Usuario.id_us + "' " +
						"AND Fecha_Emision >= Convert(Varchar(10), GetDate(), 103)";
			}

			if( sSQL == "" )
				return;

			using( SqlCommand cmd = new SqlCommand(sSQL, Conexion.CNN) )
			{
				using( SqlDataReader dr = cmd.ExecuteReader() )
				{
					if( dr.HasRows )
					{
						while( dr.Read() )
						{
							txtFechaEmision.Text = dr.GetValue(2).ToString().Trim();
							UbicaItemCombo(cmbTDoc, dr.GetValue(14).ToString().Trim());
							UbicaItemCombo(cmbMVen, dr.GetValue(7).ToString().Trim());
							txtSerie.Text = dr.GetValue(9).ToString().Trim();
							txtNroTicket.Text = dr.GetValue(1).ToString().Trim();
							txtDigitador.Text = General.TradUser(dr.GetValue(5).ToString().Trim());
							txtID.Text = dr.GetValue(4).ToString().Trim();
							UbicaItemCombo(cmbEspecialidad, dr.GetValue(3).ToString().Trim()); //validar si llena los productos
							UbicaItemCombo(cmbInstitucion, dr.GetValue(11).ToString().Trim());
							UbicaItemCombo(cmbEspecialista, dr.GetValue(10).ToString().Trim());
							txtAutoriza.Text = "";

							if( dr.GetValue(8).ToString().Trim()!="")
								if( dr.GetValue(8).ToString().Trim().Substring(0, 1) == "D" )
								{
									string ads = dr.GetValue(8).ToString().Substring(29, 9).Trim();

									sSQL = "Select LTrim(RTrim(Ape_Paterno))+' '+LTrim(RTrim(Ape_Materno))+' '+LTrim(RTrim(Nombres))Personal,Id_Personal " +
											"From Personal " +
											"Where Id_Personal = '" + ads.Trim() + "' " +
											"Union All " +
											"Select Nom_Raz_Soc Personal,TInst + Id_Inst Id_Personal " +
											"  From Institucion " +
											"  Where TInst + Id_Inst = '" + ads.Trim() + "' ";

									using( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
									{
										try
										{
											if( db.State == ConnectionState.Closed )
												db.Open();

											dynamic returns = db.Query<dynamic>(sSQL);
											txtAutoriza.Text = returns[0].Personal + " (S/. " + dr.GetValue(8).ToString().Substring(38, 8).Trim();

										}
										catch( Exception ex )
										{ MessageBox.Show(ex.Message); }
									}
								}

							txtNHP.Text = dr.GetValue(0).ToString().Trim();
							CargaDetalleTicket(dr.GetValue(0).ToString().Trim(), dr.GetValue(3).ToString().Trim());

							if( dr.GetString(15).Trim() != "" )
							{
								string vSql = "SELECT Bus FROM buses WHERE id_bus = '" + dr.GetValue(15).ToString().Trim() + "'";
								BUS = General.TomaValor(vSql);
							}

							NROHISTORIA = dr.GetValue(0).ToString().Trim();
							CargaDatosPaciente(1,"");

						}
					}
					else
					{

					}
					dr.Close();
				}
			}
			
		}

		private void CargaDetalleTicket( string sNHC, string sEspecialidad )
		{			
			iGrid.Rows.Clear();
			FormateaGrids();

			if( sNHC.Trim() == "" )
				return;

			if( sEspecialidad.Trim() == "" )
				return;

			string vSQL = "SELECT COUNT(*) AS cant " +
						  "FROM Detalles " +
						  "WHERE Nro_Historia = '" + sNHC.ToString() + "'";
			int iCant = int.Parse(General.TomaValor(vSQL));
			
			vSQL = "SELECT nro_historia,id_producto,monto,cantidad," +
				   "pagado,dscto,resultado,conclusion " +
				   "FROM Detalles " +
				   "WHERE Nro_Historia = '" + sNHC.ToString() + "'";
			using( SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN) )
			{
				using( SqlDataReader dr = cmd.ExecuteReader() )
				{
					if( dr.HasRows )
					{
						iGrid.BeginUpdate();
						iGrid.Rows.Count = iCant;

						foreach( iGRow row in iGrid.Rows )
						{
							dr.Read();
							iGDropDownList cmb = CargaProductos(sEspecialidad, dr.GetValue(1).ToString());
							row.Cells[0].DropDownControl = cmb;
							row.Cells[0].Value = cmb.Items[0].Value;
							row.Cells[1].Value = dr.GetValue(3).ToString();
							row.Cells[2].Value = dr.GetValue(2).ToString(); //DevuelvePrecioProducto(dr.GetValue(1).ToString());
							row.Cells[3].Value = int.Parse(row.Cells[1].Value.ToString()) * double.Parse(row.Cells[2].Value.ToString());
							row.Cells[4].Value = dr.GetValue(1).ToString();
						}
						iGrid.EndUpdate();
					}
					dr.Close();
				}
			}
		}

		private void BloqueaControles()
		{

		}

		private void txtTelefono_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
				e.Handled = true;
		}

		private void txtDNI_MouseHover( object sender, EventArgs e )
		{
			General.ttMensaje.Show("Presionar ENTER al terminar de digitar el DNI", txtDNI);
		}

		private void txtAsegurado_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( char.ToUpper(e.KeyChar) != 'S' && e.KeyChar != 8 )
				e.Handled = true;
		}

		private void txtAsegurado_MouseHover( object sender, EventArgs e )
		{
			General.ttMensaje.Show("Texto solo deber ser [S] o BLANCO", txtAsegurado);
		}

		private void txtEmail_Validating( object sender, System.ComponentModel.CancelEventArgs e )
		{
			System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

			if( txtEmail.Text.Length > 0 )
			{
				if( !rEMail.IsMatch(txtEmail.Text) )
				{
					MessageBox.Show("Ingresar un email valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtEmail.SelectAll();
					e.Cancel = true;
				}
			}
		}

		private void txtEdad_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
				e.Handled = true;
		}

		private void cmbEspecialidad_SelectedIndexChanged( object sender, EventArgs e )
		{
			Ubigeo itm = (Ubigeo)cmbEspecialidad.SelectedItem;

			if( cmbEspecialidad.SelectedIndex != -1 )
			{
				if( bTieneDocVenta == false )
					return;

				ComboProducto = LlenaProductos(itm.IdUbigeo);
				btnAgregar.Enabled = true;
				cmbEspecialista.Focus();
			}
				
		}

		private void cmbEspecialista_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( bTieneDocVenta == false )
				return;

			if( cmbEspecialidad.SelectedIndex == -1 )
			{
				cmbEspecialista.SelectedIndex = -1;
				return;
			}
			btnAgregar.Enabled = true;
		}
				
	}

	public partial class Prod
	{
		public string Id_Producto {get; set;}
		public string Descripcion {get; set;}
		public double Monto	{get; set;}
		public string Tipo {get; set;}
		public string Estado {get; set;}
		public string TPEsp {get; set;}
	}

	public partial class Temporal
	{
		public string Ipr { get; set; }
		public int Cant { get; set; }
		public double Cost { get; set; }
		public double SubT { get; set; }
		public string Nrv { get; set; }
		public string Npro { get; set; }
		public string Tp { get; set; }
	}

}
