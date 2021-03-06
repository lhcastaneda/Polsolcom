using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
	public partial class frmMain : Form
    {        
        public bool confirm = true;
        public bool closed = false;

        public Form RefToLogin { get; set;}
        string vSQL = "";
        List<ItemMenus> list = new List<ItemMenus>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load( object sender, EventArgs e )
        {
            this.confirm = true;
            this.closed = false;

			Text = Text + " " + Usuario.descripcion;
			CargaDatosDefecto();
			CargaMenuUsuario();
		}

		private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape )
            {
                this.Close();
            }
        }

        private void CargaDatosDefecto()
        {
             if(Usuario.id_us.Substring(0,3) == Operativo.id_oper)
            {
                //selecciona los datos de la especialidad del usuario         

                vSQL = "SELECT Descripcion AS Esp, " +
				       " Nom_Raz_Soc AS Nrz, " +
				       " Bus AS Con, " +
				       " TBus AS Tcn " +
				       " FROM Consultorios C INNER JOIN Buses B " +
				       " ON C.Id_Consultorio = B.Id_Esp " +
				       " INNER JOIN Institucion I " +
				       " ON B.Id_Emp = I.TInst + I.Id_Inst " +
				       " WHERE LTRIM(RTRIM(Id_Bus)) = '" + Usuario.id_us + "' ";
                Conexion.CMD.CommandText = vSQL;
                using ( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
                {
                    if ( drLectura.HasRows )
                        General.LlenaEspecialidad(drLectura);
                }
            }
        }

        private void CargaMenuUsuario()
        {
            if ( Usuario.id_us.Trim() != "" && Usuario.tipo.Trim() != "" && menuMDI.Items.Count == 0 )
                InicializaMenu();
        }

        private void CreaSubMenus()
        {
			//try
			//{
				foreach ( ToolStripMenuItem itm in menuMDI.Items )
				{                
					for ( int j = 0; j < list.Count; j++ )
					{
						if ( (string)itm.Tag == list[j].Bar_Popup )
						{
							if ( list[j].Bar_Command == "" )
							{
								ToolStripSeparator mnu = new ToolStripSeparator();
								itm.DropDownItems.Add(mnu);
							}
							else
							{
								ToolStripMenuItem mnu = new ToolStripMenuItem();
								mnu.ShowShortcutKeys = true;
								mnu.Name = list[j].Bar_Command;
								mnu.Tag = list[j].Bar_Popup;
								mnu.Text = list[j].Bar_Prompt;
								mnu.Click += new EventHandler(ChildClick);
								itm.DropDownItems.Add(mnu);
							}
						}
					}

					if ( (string)itm.Tag == "SALIR" )
					{
						//opcion de salir del sistema
						ToolStripMenuItem mnuExit = new ToolStripMenuItem();
						mnuExit.ShowShortcutKeys = true;
						mnuExit.Name = "exitapp";
						mnuExit.Tag = "EXIT";
						mnuExit.Text = "&Salir del Sistema";
						mnuExit.ShortcutKeys = Keys.Alt | Keys.X;
						mnuExit.Click += new EventHandler(ChildClick);
						itm.DropDownItems.Add(mnuExit);

						//opcion de cerrar sesion
						ToolStripMenuItem mnuClose = new ToolStripMenuItem();
						mnuClose.ShowShortcutKeys = true;
						mnuClose.Name = "closesession";
						mnuClose.Tag = "CLOSE";
						mnuClose.Text = "&Cerrar la Sesion";
						mnuClose.ShortcutKeys = Keys.Alt | Keys.C;
						mnuClose.Click += new EventHandler(ChildClick);
						itm.DropDownItems.Add(mnuClose);
					}
				}
			//}
			//catch( Exception ex )
			//{
			//	var st = new StackTrace(ex, true);
			//	var frame = st.GetFrame(0);
			//	var line = frame.GetFileLineNumber();
			//	var col = frame.GetFileColumnNumber();
			//	MessageBox.Show(ex.Message + (char)13 + "Linea: " + line + " Columna: " + col);
			//}
		}

		private void ChildClick(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            if ( clickedItem.Name == "exitapp" )
            {
				CloseReason c = new CloseReason();
				FormClosingEventArgs a = new FormClosingEventArgs(c, false);
                this.Close();
			}
            else if ( clickedItem.Name == "closesession" )
            {
                if ( MessageBox.Show("Desea Cerrar la Sesion...?", "Ventana Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes )
                {
                    General.ReseteaSesion();
                    //this.RefToLogin.Tag = "finsesion";
                    this.RefToLogin.Text = "finsesion";
                    this.RefToLogin.Activate();
                    this.RefToLogin.Show();
                    this.confirm = false;
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            else if ( clickedItem.Name != "" )
            {
                Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);
                foreach ( Type type in frmAssembly.GetTypes() )
                {
                    if ( type.BaseType == typeof(Form) )
                    {
                        if ( type.Name.Trim().ToUpper() == clickedItem.Name.Trim().ToUpper() )
                        {
                            Form frmShow = (Form)frmAssembly.CreateInstance(type.ToString());
                            foreach ( Form form in this.MdiChildren )
                                form.Close();

                            frmShow.MdiParent = this;
                            frmShow.StartPosition = FormStartPosition.CenterScreen;
                            frmShow.WindowState = FormWindowState.Normal;
                            frmShow.ControlBox = false;
                            frmShow.TopMost  = true;
                            frmShow.BringToFront();
                            frmShow.Show();
                        }
                    }
                }
            }
        }

		private void InicializaMenu()
		{
			//llena menu principal
			if( Usuario.id_us == "SYSAD" )
			{
				vSQL = "SELECT *, 'SYSAD' AS Mnu_Us " +
					   " FROM PadMenu  " +
					   " WHERE Pad_Name In ('PAD001','PAD005') " +
					   " ORDER BY Pad_Order ";
			}
			else
			{
				vSQL = "SELECT PM.*,A.Mnu_Us " +
					   " FROM PadMenu PM INNER JOIN BarMenu BM " +
					   " ON PM.Pad_Popup = BM.Bar_Popup INNER JOIN Accesos A " +
					   " ON BM.Bar_Number = A.Mnu_Bar " +
					   " AND BM.Bar_Popup = A.Mnu_Pop " +
					   " WHERE LTrim(RTrim(A.Mnu_Us)) = '" + Usuario.id_us + "' " +
					   " GROUP BY PM.Pad_Name,PM.Pad_Prompt,PM.Pad_Popup,PM.Pad_Order,A.Mnu_Us " +
					   " ORDER BY PM.Pad_Order ";
			}
			Conexion.CMD.CommandText = vSQL;
			using( SqlDataReader drLectura = Conexion.CMD.ExecuteReader() )
			{
				if( drLectura.HasRows )
				{
					while( drLectura.Read() )
					{
						ToolStripMenuItem mnuItem = new ToolStripMenuItem();
						mnuItem.ShowShortcutKeys = true;
						mnuItem.Text = drLectura.GetValue(1).ToString().ToUpper();
						//mnuItem.ShortcutKeys = Keys.Alt | Keys.O;
						mnuItem.ShortcutKeyDisplayString = drLectura.GetValue(1).ToString();
						mnuItem.Tag = drLectura.GetValue(2).ToString();
						menuMDI.Items.Add(mnuItem);
						mnuItem = null;

					}
					drLectura.Close();

					ToolStripMenuItem mnuItemSalir = new ToolStripMenuItem();
					mnuItemSalir.ShowShortcutKeys = true;
					mnuItemSalir.Text = "&SALIR";
					mnuItemSalir.ShortcutKeys = Keys.Alt | Keys.S;
					mnuItemSalir.Tag = "SALIR";
					mnuItemSalir.ShortcutKeyDisplayString = "&Salir";
					menuMDI.Items.Add(mnuItemSalir);
				}
			}

			//limpia el arreglo para asignar los datos
			list.Clear();
			//try
			//{
				//llena submenues por cada item del menu principal
				if( Usuario.id_us == "SYSAD" )
				{
					vSQL =  "SELECT bar_number,bar_popup,bar_prompt,bar_order," +
							" REPLACE(LTRIM(RTRIM(SUBSTRING(bar_command, 8, 42))),'.scx','') AS form " +
							" FROM BarMenu " +
							" WHERE Bar_Popup + CAST(Bar_Number AS Varchar(3)) = 'POP00113' " +
							" Or Bar_Popup= 'POP005' " +
							" ORDER BY Bar_Popup,Bar_Order ";
				}
				else
				{
					vSQL = "SELECT bar_number,bar_popup,bar_prompt,bar_order," +
						" REPLACE(LTRIM(RTRIM(SUBSTRING(bar_command, 8, 42))),'.scx','') AS form " +
						" FROM Barmenu BM INNER JOIN Accesos A" +
						" ON BM.Bar_Popup = A.Mnu_Pop" +
						" AND BM.Bar_Number = A.Mnu_Bar" +
						" WHERE LTrim(RTrim(A.Mnu_Us)) = '" + Usuario.id_us + "' " +
						" ORDER BY BM.Bar_Popup,BM.Bar_Order";
				}
				Conexion.CMD.CommandText = vSQL;
				using( SqlDataReader dr = Conexion.CMD.ExecuteReader() )
				{
					if( dr.HasRows )
					{
						while( dr.Read() )
						{
							if( dr.GetValue(4).ToString() != "" )
							{
								if( dr.GetValue(4).ToString().Substring(0, 3).ToUpper() == "FRM" )
								{
									ItemMenus mnu = new ItemMenus(dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString());
									list.Add(mnu);
								}
							}
							else
							{
								ItemMenus mnu = new ItemMenus(dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString());
								list.Add(mnu);
							}
						}
						dr.Close();
					}
				}

				//crea los submenus para cada item del menu principal
				CreaSubMenus();
			//}
			//catch( Exception ex )
			//{
			//	var st = new StackTrace(ex, true);
			//	var frame = st.GetFrame(0);
			//	var line = frame.GetFileLineNumber();
			//	var col = frame.GetFileColumnNumber();
			//	MessageBox.Show(ex.Message + (char)13 + "Linea: " + line + " Columna: " + col);
			//}
		}

		private void tmrMDI_Tick( object sender, EventArgs e )
		{
			toolStripStatusF1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
		}


        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.confirm && !this.closed)
            {
                if (MessageBox.Show("Desea Salir del Sistema...?", "Ventana Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    this.closed = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
