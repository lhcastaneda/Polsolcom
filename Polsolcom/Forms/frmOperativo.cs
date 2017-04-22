using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using Dapper;
using System.Linq;

namespace Polsolcom.Forms
{
	public partial class frmOperativo : Form
    {
		//define variable para ejecutar las sentencias SQL
		//primero se deben ejecutar en el TOAD para asegurar
		//de que estan bien construidas
		string vSQL ="";

		//USANDO DAPPER
		//define la clase Operativo para cargar los datos del operativo
		public Oper cOper { get; set; }

		public frmOperativo()
        {
            InitializeComponent();
        }

        private void frmOperativo_Load(object sender, EventArgs e)
        {
			//setea la fecha del dia para cada DatePicker
			dtpInicio.Value = DateTime.Now;
			dtpCese.Value = DateTime.Now;

			//limpia el combo cmbModOper
			cmbModOper.Items.Clear();
			
			//query para llenar el combo cmbModOper
			vSQL = "SELECT Descripcion, Id_Tipo" +
                    " FROM TablaTipo" +
                    " WHERE Id_Tabla In" +
                    " (SELECT Id_Tipo FROM tablaTipo" +
                    "  WHERE Descripcion = 'MODALIDAD_OPERATIVO'" +
                    "  AND Id_Tabla = '0')" +
                    "  ORDER BY 2";

			//Usando DAPPER
			//3. pasa el query a la funcion que llena el combo cmbModOper
			cmbModOper.DataSource = LlenaCombosListados(vSQL);
			//indica al combo que texto debe mostrar
			cmbModOper.DisplayMember = "descripcion";
			//guarda en ID en el combo
			cmbModOper.ValueMember = "id_tipo";
			//deja el combo en blanco para que el usuario seleccione
			cmbModOper.SelectedIndex = -1;

			//limpia el combo cmbModOper
			cmbEstado.Items.Clear();

			//llema el combo cmbEstado 
			vSQL = "SELECT Descripcion,Id_Tipo" +
                    " FROM TablaTipo" +
                    " WHERE Id_Tabla In" +
                    " (SELECT Id_Tipo" +
                    "  FROM TablaTipo" +
                    "  WHERE Descripcion = 'ESTADO_OPERATIVO' " +
                    "  AND Id_Tabla = '0') " +
                    " ORDER BY 2";
			
			//Usando DAPPER
			//3. pasa el query a la funcion que llena el combo cmbEstado
			cmbEstado.DataSource = LlenaCombosListados(vSQL);
			//guarda la descripcion y id_Tipo en el combo cmbEstado
			cmbEstado.DisplayMember = "descripcion";
			cmbEstado.ValueMember = "id_tipo";
			//deja el combo desmarcado para que el usuario seleccione
			cmbEstado.SelectedIndex = -1;

			//limpia la lista lstOperativos
			lstOperativos.Items.Clear();
			//llena la lista lstOperativos
			vSQL = "SELECT descripcion, id_oper FROM Operativo ORDER BY 2";
			//3. pasa el query a la funcion que llena la lista lstOperativos
			lstOperativos.DataSource = LlenaCombosListados(vSQL);
			//guarda la descripcion, id_oper en el combo lstOperativos
			lstOperativos.DisplayMember = "descripcion";
			lstOperativos.ValueMember = "id_oper";
			//deja la lista desmarcada para que el usuario seleccione
			lstOperativos.SelectedIndex = -1;

		}

		private void frmOperativo_KeyDown( object sender, KeyEventArgs e )
		{
			//cierra el formulario cuando se presiona la tecla ESC
			//este codigo se debe colocar en el metodo "KeyDown" de
			//cada control, textbox, combobox, listbox, command button
			//form, etc. de esta manera se asegura que el usuario pueda
			//cerrar la ventana en el momento que desee
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		//Usando DAPPER
		//1. Define la clase local en el formulario donde se guardara los datos de la BD
		//esta clase es distinta para cada formulario de acuerdo al query
		public partial class TCombos
		{
			public string descripcion { get; set; }
			public int id_tipo { get; set; }
		}

		//Usando DAPPER
		//1. Clase que guardara los datos del Operativo
		public partial class Oper
		{
			public string Id_Oper { get; set; }
			public string Descripcion { get; set; }
			public string Direccion { get; set; }
			public string Telefono { get; set; }
			public string Id_Distrito { get; set; }
			public string Fil_Ubi { get; set; }
			public char Mod_Oper { get; set; }
			public string Id_Emp { get; set; }
			public DateTime Inicio { get; set; }
			public DateTime Cese { get; set; }
			public string Obs { get; set; }
			public char Estado { get; set; }
			public DateTime Fec_Ing { get; set; }
			public string Us_Ing { get; set; }
			public DateTime Fec_Mod { get; set; }
			public string Us_Mod { get; set; }
			public string Uni_Org { get; set; }

		}
		
		//Usando DAPPER
		//2. Define la funcion donde se llenara el objeto TCombos
		//esta funcion debe ser local porque es diferente para otros formularios
		private static List<TCombos> LlenaCombosListados(string vSQL)
		{
			using ( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				//si la conexion esta cerrada, la abre
				if ( db.State == ConnectionState.Closed )
					db.Open();

				//Dapper retorna los datos en una lista de objetos del tipo TCombos
				return db.Query<TCombos>(vSQL).ToList();
			}
		}

		private void btnCancelar_KeyDown( object sender, KeyEventArgs e )
		{
			//cierra el formulario cuando se presiona la tecla ESC
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}

		}

		private void dtpInicio_ValueChanged( object sender, EventArgs e )
		{
			//sincroniza el picker de cese con el picker inicio
			dtpCese.Text = dtpInicio.Text;
		}

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void lstOperativos_DoubleClick( object sender, EventArgs e )
		{
			if ( lstOperativos.SelectedIndex == -1 )
				return;

			//trae los datos de la BD para mostrar en los textos
			vSQL = "SELECT * FROM Operativo " +
					" WHERE LTRIM(RTRIM(Descripcion)) = '" + lstOperativos.GetItemText(lstOperativos.SelectedItem).Trim().ToUpper() + "'" +
					" ORDER BY 2";
			//Usando DAPPER
			using ( IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["CNN"].ConnectionString) )
			{
				//si la conexion esta cerrada, la abre
				if ( db.State == ConnectionState.Closed )
					db.Open();

				//DAPPER retorna los datos en el objeto del tipo Oper
				//el metodo QueryFirst trae solo 1 registro
				cOper = db.QueryFirst<Oper>(vSQL);

				//llena los textos con los datos del query
				txtId.Text = cOper.Id_Oper;
				txtDescrip.Text = cOper.Descripcion;
				txtTel.Text = cOper.Telefono;
				txtDirec.Text = cOper.Direccion;
				txtJefe.Text = ""; //esta variable no se encuentra en la BD
				txtObservacion.Text = cOper.Obs;
	

			}


		}
	}
}
