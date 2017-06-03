using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Dapper;
using Polsolcom.Dominio.Data;
using Polsolcom.Dominio.Modelos;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Connection;
using System.Diagnostics;

namespace Polsolcom.Forms
{
	public partial class frmParteDiario : Form
    {
		string vSQL = "";
		string vFechaReporte = "";
		int iOpcionSeleccionada = -1;
		Combos vEspecialidad = new Combos();
		Combos vConsultorio = new Combos();
		Combos vEspecialista = new Combos();
		Combos vTurno = new Combos();
		ReportDocument rpt = new ReportDocument();

		public frmParteDiario()
        {
            InitializeComponent();
        }

		private void frmParteDiario_KeyDown( object sender, KeyEventArgs e )
		{
			//cierra el formulario cuando se presiona la tecla ESC
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private void frmParteDiario_Load( object sender, System.EventArgs e )
		{
			//limpia el combo cmbOpciones
			cmbOpciones.Items.Clear();

			//llena el combo con las opciones
			cmbOpciones.Items.Add("Parte de Atención Diaria");
			cmbOpciones.Items.Add("Consolidado de Atenciones");
			cmbOpciones.Items.Add("Consolidado de Derivaciones");
			cmbOpciones.SelectedIndex = -1;

			//setea la fecha del dia actual
			txtFecha.Mask = "00/00/0000";
			txtFecha.ValidatingType = typeof(System.DateTime);
			txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
			
		}

		//1. DAPPER define la clase que contendra los elementos de la BD
		private class Combos
		{
			public string descripcion { get; set; }
			public string id_tipo { get; set; }
		}
		
		//2. DAPPER define la funcion que traera los datos de la BD
		private static List<Combos> LlenaCombos(string vSQL)
		{
			List<Combos> cOper = new List<Combos>();

			using ( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				try
				{ 
					//si la conexion esta cerrada, la abre
					if ( db.State == ConnectionState.Closed )
						db.Open();

					//Dapper retorna los datos en una lista de objetos del tipo TCombos
					return db.Query<Combos>(vSQL).ToList();
				}
				catch ( Exception ex )
				{
					MessageBox.Show(ex.Message);
					return cOper;
				}
			}
		}

		private void cmbOpciones_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( cmbOpciones.SelectedIndex != -1 )
			{
				txtFecha.Enabled = true;
				txtFecha.Focus();

				//limpia todos los combos
				cmbEspecialidad.DataSource = null;
				cmbEspecialidad.Items.Clear();
				cmbConsultorio.DataSource = null;
				cmbConsultorio.Items.Clear();
				cmbEspecialista.DataSource = null;
				cmbEspecialista.Items.Clear();
				cmbTurno.DataSource = null;
				cmbTurno.Items.Clear();
			}
			iOpcionSeleccionada = cmbOpciones.SelectedIndex;

		}

		private void txtFecha_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}

			if ( e.KeyCode == Keys.Enter )
			{
				if ( txtFecha.Text.Trim().Length == 0 )
					return;
				else
				{
					//cambia el puntero del mouse a Wait
					Cursor.Current = Cursors.WaitCursor;
					vFechaReporte = txtFecha.Text;

					//limpia el combo
					cmbEspecialidad.DataSource = null;
					cmbEspecialidad.Items.Clear();
					//query que llema combo de especialidades
					vSQL = "SELECT DISTINCT Consultorios.descripcion, Consultorios.Id_Consultorio AS id_tipo " + 
							"FROM Consultorios, Buses " + 
							"WHERE Consultorios.id_consultorio = Buses.Id_Esp " + 
							"AND EXISTS " + 
							"(SELECT 1 " + 
							" FROM tickets, Cab_CIE10 " + 
							" WHERE tickets.Nro_Historia = Cab_CIE10.Nro_Historia " +
							" AND CONVERT(VARCHAR,Cab_CIE10.fecha_atencion, 103) = '" + txtFecha.Text + "' " +
							" AND CONVERT(VARCHAR,tickets.fecha_emision, 103) = '" + txtFecha.Text + "' " +
							" AND consultorios.id_consultorio = tickets.id_consultorio) " + 
							"UNION ALL " + 
							"SELECT '** TODAS LAS ESPECIALIDADES **', 'TODOS' " + 
							"FROM dual " + 
							"ORDER BY 1 ASC ";
					//3. DAPPER pasa el query a la funcion que llena los combos
					cmbEspecialidad.DataSource = LlenaCombos(vSQL);
					cmbEspecialidad.DisplayMember = "descripcion";
					cmbEspecialidad.SelectedIndex = -1;
					cmbEspecialidad.Enabled = true;

					//limpia el combo
					cmbConsultorio.DataSource = null;
					cmbConsultorio.Items.Clear();
					//query que llema combo de consultorios
					vSQL = "SELECT DISTINCT Buses.bus AS descripcion, Buses.id_bus AS id_tipo " +
							"FROM Consultorios, Buses " +
							"WHERE Consultorios.id_consultorio = Buses.Id_Esp " +
							"AND EXISTS " +
							"(SELECT 1 " +
							" FROM tickets, Cab_CIE10 " +
							" WHERE tickets.Nro_Historia = Cab_CIE10.Nro_Historia " +
							" AND CONVERT(VARCHAR,Cab_CIE10.fecha_atencion, 103) = '" + txtFecha.Text + "' " +
							" AND CONVERT(VARCHAR,tickets.fecha_emision, 103) = '" + txtFecha.Text + "' " +
							" AND Cab_CIE10.id_bus = buses.id_bus) " +
							"UNION ALL " +
							"SELECT '** TODOS LOS CONSULTORIOS **', 'TODOS' " +
							"FROM dual " +
							"ORDER BY 1 ASC ";
					//3. DAPPER pasa el query a la funcion que llena los combos
					cmbConsultorio.DataSource = LlenaCombos(vSQL);
					cmbConsultorio.DisplayMember = "descripcion";
					cmbConsultorio.SelectedIndex = -1;
					cmbConsultorio.Enabled = true;

					//limpia el combo
					cmbEspecialista.DataSource = null;
					cmbEspecialista.Items.Clear();
					//query que llema combo de especialistas
					vSQL = "SELECT DISTINCT Personal.Ape_Paterno+' '+Personal.Ape_Materno+' '+Personal.Nombres AS descripcion,MedBus.CMP AS id_tipo " +
							"FROM MedBus, Personal, Buses, Consultorios " +
							"WHERE MedBus.CMP = Personal.Id_Personal " +
							"AND MedBus.Id_Bus = Buses.Id_Bus " +
							"AND Buses.Id_Esp = Consultorios.Id_Consultorio " +
							"AND EXISTS " +
							"(SELECT 1 " +
							" FROM tickets, Cab_CIE10 " +
							" WHERE tickets.Nro_Historia = Cab_CIE10.Nro_Historia " +
							" AND CONVERT(VARCHAR,Cab_CIE10.fecha_atencion, 103) = '" + txtFecha.Text + "' " +
							" AND CONVERT(VARCHAR,tickets.fecha_emision, 103) = '" + txtFecha.Text + "' " +
							" AND Cab_CIE10.CMP = MedBus.CMP) " +
							"UNION ALL " +
							"SELECT '** TODOS LOS ESPECIALISTAS **', 'TODOS' " +
							"FROM dual " +
							"ORDER BY 1 ASC " ;
					//3. DAPPER pasa el query a la funcion que llena los combos
					cmbEspecialista.DataSource = LlenaCombos(vSQL);
					cmbEspecialista.DisplayMember = "descripcion";
					cmbEspecialista.SelectedIndex = -1;
					cmbEspecialista.Enabled = true;

					//limpia el combo
					cmbTurno.DataSource = null;
					cmbTurno.Items.Clear();
					//query que llema combo de turnos
					vSQL = "SELECT DISTINCT descripcion, id_tipo " + 
							"FROM TablaTipo " + 
							"WHERE Id_Tabla IN " + 
							"(SELECT Id_Tipo " + 
							" FROM TablaTipo T2 " + 
							" WHERE LTRIM(RTRIM(Descripcion)) = 'TURNOS' " + 
							" AND TablaTipo.Id_Tabla = T2.Id_Tipo " + 
							" AND LTRIM(RTRIM(Id_Tabla)) = '0') " + 
							"AND EXISTS " + 
							"(SELECT 1 " + 
							" FROM tickets, Cab_CIE10 " + 
							" WHERE tickets.Nro_Historia = Cab_CIE10.Nro_Historia " +
							" AND CONVERT(VARCHAR,Cab_CIE10.fecha_atencion, 103) = '" + txtFecha.Text + "' " +
							" AND CONVERT(VARCHAR,tickets.fecha_emision, 103) = '" + txtFecha.Text + "' " +
							" AND Cab_CIE10.turno = TablaTipo.id_tipo) " + 
							"UNION ALL " + 
							"SELECT '** TODOS LOS TURNOS **', 'TODOS' " + 
							"FROM dual " + 
							"ORDER BY 1 ASC ";
					//3. DAPPER se usara la misma clase dado que los campos de la BD son del mismo tipo
					cmbTurno.DataSource = LlenaCombos(vSQL);
					cmbTurno.DisplayMember = "Descripcion";
					cmbTurno.SelectedIndex = -1;
					cmbTurno.Enabled = true;

					btnVistaPrevia.Enabled = true;
					//regresa el cursos al puntero por defecto
					Cursor.Current = Cursors.Default;
					cmbEspecialidad.Focus();
				}
				e.Handled = true;
			}

		}

		private void txtFecha_TypeValidationCompleted( object sender, TypeValidationEventArgs e )
		{
			if ( !e.IsValidInput )
			{
				MessageBox.Show("Fecha debe tener formato dd/MM/yyyy", "Generacion Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				txtFecha.Focus();
				return;
			}
		}

		private void cmbOpciones_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private void cmbEspecialidad_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private void cmbConsultorio_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private void cmbEspecialista_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private void cmbTurno_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private void btnVistaPrevia_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private void txtFecha_Enter( object sender, EventArgs e )
		{
			BeginInvoke((Action)delegate { SetMaskedTextBoxSelectAll((MaskedTextBox)sender); });

		}

		private void SetMaskedTextBoxSelectAll( MaskedTextBox txtbox )
		{
			txtbox.SelectAll();
		}

		private void btnVistaPrevia_Click( object sender, EventArgs e )
		{
			try
			{

			//ingresa fecha del reporte, no debe ser mayor que la fecha actual
			if ( Convert.ToDateTime(txtFecha.Text) > DateTime.Today )
			{
				MessageBox.Show("Fecha del reporte no debe ser mayor que la fecha actual.", "Generacion Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				txtFecha.Focus();
				return;
			}

			//selecciona opcion de reporte cmbOpciones
			if ( cmbOpciones.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un tipo de reporte a generar.", "Generacion Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				cmbOpciones.Focus();
				return;
			}
			else if ( cmbOpciones.SelectedIndex == 0 )
			{//Parte de Atención Diaria
				vSQL = "Select C.Descripcion AS Especialidad, B.Bus, Serie + '-' + Nro_Ticket AS Ticket, " +
						"P.Ape_Paterno + ' ' + P.Ape_Materno + ' ' + P.Nombre AS Completo, " +
						"P.Edad, CASE WHEN P.Sexo = 'M' THEN 'MASCULINO' ELSE 'FEMENINO' END AS Sexo, " +
						"CB.Nro_Historia,CB.Fecha_Atencion, (SELECT DISTINCT Descripcion FROM TablaTipo T1 " +
						"WHERE T1.Id_Tipo = CB.turno " +
						"AND EXISTS (" +
						" SELECT 1 " +
						" FROM TablaTipo T2 " + 
						" WHERE T1.Id_Tabla = T2.Id_Tipo " +
						" AND LTRIM(RTRIM(T2.Descripcion)) = 'TURNOS' " +
						" AND LTRIM(RTRIM(T2.Id_Tabla)) = '0')) AS Turno, " +
						" M.Ape_Paterno + ' ' + M.Ape_Materno + ' ' + M.Nombres AS CMP,DC.Cie10 AS prdg, " +
						" LTrim(RTrim(DC.Procedimiento)) AS prcn " +
						"FROM Cab_Cie10 CB Inner Join Tickets T " +
						"On CB.Nro_Historia = T.Nro_Historia " +
						"Inner Join Pacientes P " +
						"On T.Id_Paciente = P.Id_Paciente " +
						"Left Join Det_Cie10 DC " +
						"On CB.Nro_Historia = DC.Nro_Historia " +
						"Inner Join Personal M " +
						"On CB.CMP = M.Id_Personal " +
						"Inner Join Buses B " +
						"On CB.Id_Bus = B.Id_Bus " +
						"Inner Join Consultorios C " +
						"On B.Id_Esp = C.Id_Consultorio " +
						"Where CONVERT(VARCHAR,cb.fecha_atencion, 103) = '" + txtFecha.Text + "' " +
						"And Left(CB.Nro_Historia,3) = '" + Operativo.id_oper + "'";
			}
			else if ( cmbOpciones.SelectedIndex == 1 )
			{//Consolidado de Atenciones
				vSQL = "Select C.Descripcion Consu,B.Bus,X.Descripcion Turn,Ape_Paterno+' ' + Ape_Materno + Case " +
						"Nombres When '' Then '' Else ', ' End + Nombres Completo,P.Descripcion Producto, " +
						"Sum(D.Cantidad) Cantidad,D.Monto Precio,Sum(D.Cantidad*D.Monto) Total " +
						"From Cab_Cie10 CB Inner Join Tickets T " +
						"On CB.Nro_Historia = T.Nro_Historia " +
						"Inner Join Detalles D " +
						"On T.Nro_Historia = D.Nro_Historia " +
						"Inner Join Productos P " +
						"On D.Id_Producto = P.Id_Producto " +
						"Inner Join Buses B " +
						"On CB.Id_Bus = B.Id_Bus " +
						"Inner Join Consultorios C " +
						"On B.Id_Esp = C.Id_Consultorio " +
						"Inner Join " +
						"(Select Id_Tipo,Descripcion " +
						" From TablaTipo " +
						" Where Id_Tabla In " +
						" (Select Id_Tipo " +
						"  From TablaTipo " +
						"  Where Descripcion = 'TURNOS' " +
						"  And Id_Tabla = '0')) X " +
						"On CB.Turno = X.Id_Tipo " +
						"Inner Join Personal M " +
						"On CB.CMP = M.Id_Personal " +
						"Where CONVERT(VARCHAR,fecha_atencion, 103) = '" + txtFecha.Text + "' " +
						"And Left(CB.Nro_Historia,3) = '" + Operativo.id_oper + "'";
			}
			else if ( cmbOpciones.SelectedIndex == 2 )
			{//Consolidado de Atenciones
				vSQL = "Select C.Descripcion Especialidad,B.Bus Consultorio,X.Descripcion Turno,Ape_Paterno+' '+Ape_Materno+Case" +
						" Nombres When '' Then '' Else ', ' End + Nombres Especialista,P.Descripcion Producto," +
						" Sum(D.Cantidad) Cantidad,D.Monto Precio,Sum(D.Cantidad*D.Monto) Total" +
						" From Cab_Cie10 CB Inner Join Tickets T" +
						" On CB.Nro_Historia = T.Nro_Historia" +
						" Inner Join Detalles D" +
						" On T.Nro_Historia = D.Nro_Historia" +
						" Inner Join Productos P" +
						" On D.Id_Producto = P.Id_Producto" +
						" Inner Join Buses B" +
						" On CB.Id_Bus = B.Id_Bus" +
						" Inner Join Consultorios C" +
						" On B.Id_Esp = C.Id_Consultorio" +
						" Inner Join" +
						" (Select Id_Tipo,Descripcion" +
						"  From TablaTipo" +
						"  Where Id_Tabla" +
						"  In (Select Id_Tipo" +
						" 	   From TablaTipo" +
						"      Where Descripcion = 'TURNOS'" +
						"      And Id_Tabla = '0')) X" +
						" On CB.Turno = X.Id_Tipo" +
						" Inner Join" +
						" (Select Ape_Paterno,Ape_Materno,Nombres,Id_Personal" +
						"  From Personal" +
						"  Union All Select Descripcion,'','', Id_Tipo " +
						"  From TablaTipo" +
						"  Where Id_Tabla In" +
						"  (Select Id_Tipo" +
						"   From TablaTipo" +
						"   Where Descripcion = 'VAR_EXTRAS'" +
						"   And Id_Tabla = '0')) M" +
						" On T.CMP = M.Id_Personal" +
						" Where CONVERT(VARCHAR,fecha_atencion, 103) = '" + txtFecha.Text + "' " +
						" And Left(CB.Nro_Historia,3) = '" + Operativo.id_oper + "'";
			}

			//si la especialidad esta en 'ECOGRAFIA', 'RAYOS X', 'MAMOGRAFIA' entonces D.Pagado <> ''
			int iCantE = CuentaEspecialidad(Operativo.id_oper, txtFecha.Text);

			if ( cmbOpciones.SelectedIndex > 0 && iCantE > 0 )
			vSQL = vSQL + "And NOT D.Pagado = '' ";
			
			//selecciona especialidad cmbEspecialidad
			if ( cmbEspecialidad.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar una especialidad.", "Generacion Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				cmbEspecialidad.Focus();
				return;
			}
			else
				vEspecialidad = (Combos)cmbEspecialidad.SelectedItem;
			 
			//selecciona consultorio cmbConsultorio
			if ( cmbConsultorio.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un consultorio.", "Generacion Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				cmbConsultorio.Focus();
				return;
			}
			else
				vConsultorio = (Combos)cmbConsultorio.SelectedItem;
			
			//selecciona especialista cmbEspecialista
			if ( cmbEspecialista.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un especialista.", "Generacion Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				cmbEspecialista.Focus();
				return;
			}
			else
				vEspecialista = (Combos)cmbEspecialista.SelectedItem;

			//selecciona turno cmbTurno
			if ( cmbTurno.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un turno.", "Generacion Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				cmbTurno.Focus();
				return;
			}
			else
				vTurno = (Combos)cmbTurno.SelectedItem;

			//agrega especialidad al query de los 3 tipos
			if ( vEspecialidad.id_tipo != "TODOS" )
				vSQL = vSQL + "And C.Id_Consultorio = '" + vEspecialidad.id_tipo + "' ";

			//agrega consultorio al query de los 3 tipos
			if ( vConsultorio.id_tipo != "TODOS" )
				vSQL = vSQL + "And CB.Id_Bus = '" + vConsultorio.id_tipo + "' ";

			//agrega especialista al query de los 3 tipos
			if ( vEspecialista.id_tipo != "TODOS" )
				vSQL = vSQL + "And CB.CMP = '" + vEspecialista.id_tipo + "' ";

			//agrega turno al query de los 3 tipos
			if ( vTurno.id_tipo != "TODOS" )
				vSQL = vSQL + "And CB.Turno = '" + vTurno.id_tipo + "' ";

			//agrega ordenacion al query Parte de Atención Diaria
			if ( cmbOpciones.SelectedIndex == 0 )
				vSQL = vSQL + "Order By C.Descripcion,B.Bus,CB.Fecha_Atencion,CB.Turno ";

			//agrega agrupacion y ordenacion al query Consolidado de Atenciones y de Consolidado de Derivaciones
			if ( cmbOpciones.SelectedIndex > 0 )
			{
				vSQL = vSQL + "Group By C.Descripcion,B.Bus,X.Descripcion,Ape_Paterno,Ape_Materno,Nombres,P.Descripcion,D.Monto ";
				vSQL = vSQL + "Order By 1,2,3,4,5";
			}
			
			//genera reporte y carga los datos
			object result = WaitWindow.Show(WorkerMethod, "Generando el reporte...");
			if ( result == null )
			{
				MessageBox.Show("No se pudo procesar el reporte.");
				return;
			}

			//llama al formulario que muestra el reporte
			frmCRViewer frg = new frmCRViewer(rpt);
			frg.ShowDialog();

		}
			catch( Exception ex )
			{
				var st = new StackTrace(ex, true);
		var frame = st.GetFrame(0);
		var line = frame.GetFileLineNumber();
		var col = frame.GetFileColumnNumber();
		MessageBox.Show(ex.Message + (char)13 + "Linea: " + line + " Columna: " + col);
			}


}

		private void WorkerMethod( object sender, WaitWindowEventArgs e )
		{
			//define la ruta por defecto de la app
			string path = Application.StartupPath;
			path = path.Replace("\\", "/");
			path = path.Replace("/bin/Debug", "");

			//define el reporte dependiendo del tipo de seleccion
			if ( iOpcionSeleccionada == 0 )
				path = path + "/Dominio/Reportes/rptpardia.rpt";
			else if ( iOpcionSeleccionada > 0 )
				path = path + "/Dominio/Reportes/rptconpardia.rpt";

			//carga el reporte
			rpt.Load(path);

			if ( iOpcionSeleccionada == 0 )
			{
				Conexion.CMD.CommandText = vSQL;
				using ( SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD) )
				{
					using ( ParteDiario ds = new ParteDiario() )
					{
						ds.Clear();
						da.Fill(ds, "ParteDiario");
						rpt.SetDataSource(ds);
					}
				}

				//setea los parametros del reporte Parte de atencion diario
				rpt.SetParameterValue("TituloReporte", "Reporte Parte de Atencion Diario");
				rpt.SetParameterValue("Operativo", Operativo.descripcion);
				rpt.SetParameterValue("CabEspecialidad", vEspecialidad.descripcion);
				rpt.SetParameterValue("CabConsultorio", vConsultorio.descripcion);
				rpt.SetParameterValue("CabTurno", vTurno.descripcion);
				rpt.SetParameterValue("CabEspecialista", vEspecialista.descripcion);
				rpt.SetParameterValue("FechaAtencion", vFechaReporte);
			}
			else if ( iOpcionSeleccionada > 0 )
			{
				Conexion.CMD.CommandText = vSQL;
				using ( SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD) )
				{
					using ( Consolidado ds = new Consolidado() )
					{
						ds.Clear();
						da.Fill(ds, "Consolidado");
						rpt.SetDataSource(ds);
					}
				}

				//setea los parametros del reporte consolidacion de atencion diario o derivacion diario
				if ( iOpcionSeleccionada == 1 )
					rpt.SetParameterValue("TituloReporte", "Consolidado de Atencion Diaria");
				else if ( iOpcionSeleccionada == 2 )
					rpt.SetParameterValue("TituloReporte", "Consolidado de Derivacion Diaria");

				rpt.SetParameterValue("Operativo", Operativo.descripcion);
				rpt.SetParameterValue("FechaAtencion", vFechaReporte);
			}

			if ( e.Arguments.Count > 0 )
				e.Result = e.Arguments[0].ToString();
			else
				e.Result = "Proceso culminado.";

		}

		private void cmbEspecialidad_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( cmbEspecialidad.SelectedIndex != -1 )
			{
				Combos itm = (Combos)cmbEspecialidad.SelectedItem;
				
				//limpia todos los combos
				cmbConsultorio.DataSource = null;
				cmbConsultorio.Items.Clear();
				cmbEspecialista.DataSource = null;
				cmbEspecialista.Items.Clear();
				cmbTurno.DataSource = null;
				cmbTurno.Items.Clear();

				//query que llema combo de consultorios
				vSQL = "SELECT DISTINCT Buses.bus AS descripcion, Buses.id_bus AS id_tipo " +
						"FROM Consultorios, Buses " +
						"WHERE Consultorios.id_consultorio = Buses.Id_Esp ";
				if ( cmbEspecialidad.SelectedIndex != 0 )
					vSQL = vSQL + "AND Consultorios.Id_Consultorio = '" + itm.id_tipo + "' ";
				vSQL = vSQL + "AND EXISTS " +
						"(SELECT 1 " +
						" FROM tickets, Cab_CIE10 " +
						" WHERE tickets.Nro_Historia = Cab_CIE10.Nro_Historia " +
						" AND CONVERT(VARCHAR,Cab_CIE10.fecha_atencion, 103) = '" + txtFecha.Text + "' " +
						" AND CONVERT(VARCHAR,tickets.fecha_emision, 103) = '" + txtFecha.Text + "' " +
						" AND Cab_CIE10.id_bus = buses.id_bus) " +
						"UNION ALL " +
						"SELECT '** TODOS LOS CONSULTORIOS **', 'TODOS' " +
						"FROM dual " +
						"ORDER BY 1 ASC ";
				//3. DAPPER pasa el query a la funcion que llena los combos
				cmbConsultorio.DataSource = LlenaCombos(vSQL);
				cmbConsultorio.DisplayMember = "descripcion";
				cmbConsultorio.SelectedIndex = -1;
				cmbConsultorio.Enabled = true;
			}
		}

		private void cmbConsultorio_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( cmbConsultorio.SelectedIndex != -1 )
			{
				Combos itm = (Combos)cmbConsultorio.SelectedItem;

				//limpia todos los combos
				cmbEspecialista.DataSource = null;
				cmbEspecialista.Items.Clear();
				cmbTurno.DataSource = null;
				cmbTurno.Items.Clear();

				//query que llema combo de especialistas
				vSQL = "SELECT DISTINCT Personal.Ape_Paterno+' '+Personal.Ape_Materno+' '+Personal.Nombres AS descripcion,MedBus.CMP AS id_tipo " +
						"FROM MedBus, Personal, Buses, Consultorios " +
						"WHERE MedBus.CMP = Personal.Id_Personal " +
						"AND MedBus.Id_Bus = Buses.Id_Bus ";
				if ( cmbConsultorio.SelectedIndex != 0 )
					vSQL = vSQL + "AND MedBus.Id_Bus = '" + itm.id_tipo + "' ";
				vSQL = vSQL + "AND Buses.Id_Esp = Consultorios.Id_Consultorio " +
						"AND EXISTS " +
						"(SELECT 1 " +
						" FROM tickets, Cab_CIE10 " +
						" WHERE tickets.Nro_Historia = Cab_CIE10.Nro_Historia " +
						" AND CONVERT(VARCHAR,Cab_CIE10.fecha_atencion, 103) = '" + txtFecha.Text + "' " +
						" AND CONVERT(VARCHAR,tickets.fecha_emision, 103) = '" + txtFecha.Text + "' " +
						" AND Cab_CIE10.CMP = MedBus.CMP) " +
						"UNION ALL " +
						"SELECT '** TODOS LOS ESPECIALISTAS **', 'TODOS' " +
						"FROM dual " +
						"ORDER BY 1 ASC ";
				//3. DAPPER pasa el query a la funcion que llena los combos
				cmbEspecialista.DataSource = LlenaCombos(vSQL);
				cmbEspecialista.DisplayMember = "descripcion";
				cmbEspecialista.SelectedIndex = -1;
				cmbEspecialista.Enabled = true;
			}
		}

		private void cmbEspecialista_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( cmbEspecialista.SelectedIndex != -1 )
			{
				Combos itm = (Combos)cmbEspecialista.SelectedItem;

				//limpia el combo
				cmbTurno.DataSource = null;
				cmbTurno.Items.Clear();

				//query que llema combo de turnos
				vSQL = "SELECT DISTINCT descripcion, id_tipo " +
						"FROM TablaTipo " +
						"WHERE Id_Tabla IN " +
						"(SELECT Id_Tipo " +
						" FROM TablaTipo T2 " +
						" WHERE LTRIM(RTRIM(Descripcion)) = 'TURNOS' " +
						" AND TablaTipo.Id_Tabla = T2.Id_Tipo " +
						" AND LTRIM(RTRIM(Id_Tabla)) = '0') " +
						"AND EXISTS " +
						"(SELECT 1 " +
						" FROM tickets, Cab_CIE10 " +
						" WHERE tickets.Nro_Historia = Cab_CIE10.Nro_Historia " +
						" AND CONVERT(VARCHAR,Cab_CIE10.fecha_atencion, 103) = '" + txtFecha.Text + "' " +
						" AND CONVERT(VARCHAR,tickets.fecha_emision, 103) = '" + txtFecha.Text + "' ";
				if ( cmbEspecialista.SelectedIndex != 0 )
					vSQL = vSQL + " AND Cab_CIE10.CMP = '" + itm.id_tipo + "' ";
				vSQL = vSQL + " AND Cab_CIE10.turno = TablaTipo.id_tipo) " +
						"UNION ALL " +
						"SELECT '** TODOS LOS TURNOS **', 'TODOS' " +
						"FROM dual " +
						"ORDER BY 1 ASC ";
				//3. DAPPER se usara la misma clase dado que los campos de la BD son del mismo tipo
				cmbTurno.DataSource = LlenaCombos(vSQL);
				cmbTurno.DisplayMember = "Descripcion";
				cmbTurno.SelectedIndex = -1;
				cmbTurno.Enabled = true;
			}
		}

		private int CuentaEspecialidad (string sOper, string sFecha)
		{
			int iCant = 0;
			string vSQL = "SELECT COUNT(*) indicador " +
							"FROM Consultorios C INNER JOIN Buses B " +
							"ON C.Id_Consultorio = B.Id_Esp " +
							"INNER JOIN Institucion I " +
							"ON B.Id_Emp = I.TInst + I.Id_Inst " + 
							"WHERE LEFT(LTRIM(RTRIM(Id_Bus)),3) = '" + sOper + "' " +
							"AND Descripcion IN('ECOGRAFIA', 'RAYOS X', 'MAMOGRAFIA') " +
							"AND EXISTS " +
							"(SELECT 1 " +
							" FROM tickets, Cab_CIE10 " +
							" WHERE tickets.Nro_Historia = Cab_CIE10.Nro_Historia " +
							" AND CONVERT(VARCHAR,Cab_CIE10.fecha_atencion, 103) = '" + sFecha + "' " +
							" AND CONVERT(VARCHAR,tickets.fecha_emision, 103) = '" + sFecha + "' " +
							" AND C.id_consultorio = tickets.id_consultorio)";
			using ( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				try
				{
					//si la conexion esta cerrada, la abre
					if ( db.State == ConnectionState.Closed )
						db.Open();

					//Dapper retorna los datos en una lista de objetos del tipo TCombos
					iCant = db.ExecuteScalar<int>(vSQL);

				}
				catch ( Exception ex )
				{
					MessageBox.Show(ex.Message);
					return iCant;
				}
			}

			if( iCant == 0 )
				return 0;
			else
				return 1;

		}

		private void btnCerrar_Click( object sender, EventArgs e )
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
