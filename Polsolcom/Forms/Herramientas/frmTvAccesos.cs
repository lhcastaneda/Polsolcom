using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Data;

namespace Polsolcom.Forms
{
	public partial class frmTvAccesos : Form
    {
		string vSQL = "";
		string IdUS = "";
		string IdUSCopia = "";
		string TipoUS = "";
		string IdMenu = "";
		TreeNode selectedNodeG = new TreeNode();
		TreeNode selectedNodeU = new TreeNode();

		public frmTvAccesos()
        {
            InitializeComponent();
        }

        private void frmTvAccesos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
				DialogResult = DialogResult.Cancel;
				Close();
            }
        }

		private int GetTotalNodes( TreeNodeCollection nodes )
		{
			int rootNodes = nodes.Count;
			foreach( TreeNode node in nodes )
				rootNodes += this.GetTotalNodes(node.Nodes);

			return rootNodes;
		}

		private void CargaMenuGeneral( string optMenu )
		{
			TV2.Nodes.Clear();
			//selecciona los menus principales
			vSQL = "SELECT Pad_Popup,Pad_Prompt,Pad_Name,Pad_Order ";
			vSQL = vSQL + " FROM Padmenu ";
			vSQL = vSQL + " WHERE Pad_Popup = '" + optMenu.Trim() + "' ";
			vSQL = vSQL + " ORDER BY Pad_Popup";
			SqlDataAdapter dNodos = new SqlDataAdapter(vSQL, Conexion.CNN);

			//selecciona los items de cada menu principal
			vSQL = "SELECT B.Bar_Popup,B.Bar_Prompt,B.Bar_Number,B.Bar_Order,DBO.Cryptgr(B.PTU,0,1) PTU, " +
					"(SELECT DBO.Cryptgr(S.Key_Pass, 0, 1) " +
					" FROM sysaccusers S " +
					" WHERE B.Us_Up = S.Id_Us " +
					" AND B.Bar_Popup = '" + optMenu.Trim() + "') Us_Up " +
					" FROM Barmenu B " +
					"WHERE EXISTS " +
					"(SELECT 1 " +
					" FROM sysaccusers S " +
					" WHERE B.Us_Up = S.Id_Us " +
					" AND B.Bar_Popup = '" + optMenu.Trim() + "') " +
					"ORDER BY B.Bar_Order";
			SqlDataAdapter dHijos = new SqlDataAdapter(vSQL, Conexion.CNN);

			//metodo que relaciona tabla cabecera con tabla detalle
			DataSet ds = new DataSet();
			dNodos.Fill(ds, "Padmenu");
			dHijos.Fill(ds, "Barmenu");
			ds.Relations.Add("PadBarMenu", ds.Tables["Padmenu"].Columns["Pad_Popup"], ds.Tables["Barmenu"].Columns["Bar_Popup"]);
			TV2.ImageIndex = 1;

			foreach( DataRow dr in ds.Tables["Padmenu"].Rows )
			{//llena nodos principales con tabla cabecera
				TreeNode tnPadre = new TreeNode();
				tnPadre.Name = dr["Pad_Name"].ToString();
				tnPadre.Text = dr["Pad_Prompt"].ToString();
				tnPadre.Tag = dr["Pad_Popup"].ToString() + "*" + dr["Pad_Name"].ToString() + "*" + dr["Pad_Order"].ToString();
				tnPadre.ImageIndex = 0;
				tnPadre.SelectedImageIndex = 0;
				foreach( DataRow drChild in dr.GetChildRows("PadBarMenu") )
				{//llena nodos secundarios con tabla detalle
					TreeNode tnHijo = new TreeNode();
					tnHijo.Name = drChild["Bar_Number"].ToString();
					tnHijo.Text = drChild["Bar_Prompt"].ToString();
					tnHijo.Tag = drChild["Bar_Popup"].ToString() + "*" + drChild["Bar_Number"].ToString() + "*" + drChild["Bar_Order"].ToString() + "*" + drChild["PTU"].ToString() + "*" + drChild["Us_Up"].ToString();
					tnHijo.ImageIndex = 1;
					tnHijo.SelectedImageIndex = 1;
					tnPadre.Nodes.Add(tnHijo);
				}
				TV2.Nodes.Add(tnPadre);
			}
			TV2.ExpandAll();
			TV2.SelectedNode = TV2.Nodes[0];
			selectedNodeG = TV2.Nodes[0];
		}

		private void CargaMenuUsuario( string optUsuario )
		{
			string vCant = "";
			TV1.Nodes.Clear();

			vSQL = "SELECT COUNT(*) " +
					"FROM Padmenu " +
					"WHERE Pad_Popup IN " +
					"(SELECT DISTINCT Pad_Popup " +
					" FROM Accesos A INNER JOIN Barmenu B " +
					" ON A.Mnu_Pop = B.Bar_Popup " +
					" AND A.Mnu_Bar = B.Bar_Number INNER JOIN Padmenu P " +
					" ON A.Mnu_Pop = P.Pad_Popup INNER JOIN sysaccusers S " +
					" ON A.Us_Up = S.Id_Us " +
					" WHERE Mnu_Us = '" + optUsuario.Trim() + "')";
			vCant = General.TomaValor(vSQL);
			if( Convert.ToInt32(vCant) == 0 )
			{
				cmdDelAll.Enabled = false;
				return;
			}				

			vSQL = "SELECT COUNT(*) " +
					"FROM Barmenu B " +
					"WHERE EXISTS " +
					"(SELECT 1 " +
					" FROM Accesos A, Padmenu P, sysaccusers S " +
					" WHERE A.Mnu_Pop = B.Bar_Popup " +
					" AND A.Mnu_Bar = B.Bar_Number " +
					" AND A.Mnu_Pop = P.Pad_Popup " +
					" AND A.Us_Up = S.Id_Us " +
					" AND A.Mnu_Us = '" + optUsuario.Trim() + "')";
			vCant = General.TomaValor(vSQL);
			if( Convert.ToInt32(vCant) == 0 )
			{
				cmdDelAll.Enabled = false;
				return;
			}				

			//selecciona los menus principales
			vSQL = "SELECT Pad_Popup,Pad_Prompt,Pad_Name,Pad_Order " +
					"FROM Padmenu " +
					"WHERE Pad_Popup IN " +
					"(SELECT DISTINCT Pad_Popup " +
					" FROM Accesos A INNER JOIN Barmenu B " +
					" ON A.Mnu_Pop = B.Bar_Popup " +
					" AND A.Mnu_Bar = B.Bar_Number INNER JOIN Padmenu P " +
					" ON A.Mnu_Pop = P.Pad_Popup INNER JOIN sysaccusers S " +
					" ON A.Us_Up = S.Id_Us " +
					" WHERE Mnu_Us = '" + optUsuario.Trim() + "') " +
					"ORDER BY Pad_Popup";
			SqlDataAdapter dNodos = new SqlDataAdapter(vSQL, Conexion.CNN);
			
			//selecciona los items de cada menu principal
			vSQL = "SELECT B.Bar_Popup,B.Bar_Prompt,B.Bar_Number,B.Bar_Order " +
					"FROM Barmenu B " +
					"WHERE EXISTS " +
					"(SELECT 1 " +
					" FROM Accesos A, Padmenu P, sysaccusers S " +
					" WHERE A.Mnu_Pop = B.Bar_Popup " +
					" AND A.Mnu_Bar = B.Bar_Number " +
					" AND A.Mnu_Pop = P.Pad_Popup " +
					" AND A.Us_Up = S.Id_Us " +
					" AND A.Mnu_Us = '" + optUsuario.Trim() + "') " +
					"ORDER BY B.Bar_Popup,B.Bar_Order";
			SqlDataAdapter dHijos = new SqlDataAdapter(vSQL, Conexion.CNN);

			//metodo que relaciona tabla cabecera con tabla detalle
			DataSet ds = new DataSet();
			dNodos.Fill(ds, "Padmenu");
			dHijos.Fill(ds, "Barmenu");
			ds.Relations.Add("PadBarMenu", ds.Tables["Padmenu"].Columns["Pad_Popup"], ds.Tables["Barmenu"].Columns["Bar_Popup"]);
			TV1.ImageIndex = 1;

			foreach( DataRow dr in ds.Tables["Padmenu"].Rows )
			{//llena nodos principales con tabla cabecera
				TreeNode tnPadre = new TreeNode();
				tnPadre.Name = dr["Pad_Name"].ToString();
				tnPadre.Text = dr["Pad_Prompt"].ToString();
				tnPadre.Tag = dr["Pad_Popup"].ToString() + "*" + dr["Pad_Name"].ToString() + "*" + dr["Pad_Order"].ToString();
				tnPadre.ImageIndex = 0;
				tnPadre.SelectedImageIndex = 0;
				foreach( DataRow drChild in dr.GetChildRows("PadBarMenu") )
				{//llena nodos secundarios con tabla detalle
					TreeNode tnHijo = new TreeNode();
					tnHijo.Name = drChild["Bar_Number"].ToString();
					tnHijo.Text = drChild["Bar_Prompt"].ToString();
					tnHijo.Tag = drChild["Bar_Popup"].ToString() + "*" + drChild["Bar_Number"].ToString() + "*" + drChild["Bar_Order"].ToString();
					tnHijo.ImageIndex = 1;
					tnHijo.SelectedImageIndex = 1;
					tnPadre.Nodes.Add(tnHijo);
				}
				TV1.Nodes.Add(tnPadre);
			}
			TV1.ExpandAll();
			TV1.SelectedNode = TV1.Nodes[0];
			selectedNodeU = TV1.Nodes[0];
		}
		
		private void frmTvAccesos_Load( object sender, EventArgs e )
		{
			vSQL = "SELECT Nombres+' '+Ape_Paterno+' '+Ape_Materno Descripcion,Id_Us+'*'+DBO.Cryptgr(Type,0,2) IdUbigeo " +
					"FROM sysaccusers S INNER JOIN Personal P " +
					"ON S.Id_Per = P.Id_Personal " +
					"INNER JOIN ( SELECT Id_Tipo, Descripcion " +
					"			FROM TablaTipo " +
					"			WHERE Id_Tabla In (SELECT Id_Tipo " +
					"							   FROM TablaTipo " +
					"							   WHERE Descripcion = 'ESTADO_REGISTRO')) E " +
					"  ON S.State = E.Id_Tipo " +
					"WHERE E.Descripcion = 'ACTIVADO' " +
					"ORDER BY 1";
			General.LlenaComboBox(cmbUsuario, "SQL", vSQL);

			vSQL = "SELECT Pad_Prompt Descripcion, Pad_Popup IdUbigeo FROM Padmenu ORDER BY Pad_Prompt";
			General.LlenaComboBox(cmbPadMenu, "SQL", vSQL);

			TV1.CollapseAll();
			TV1.Enabled = false;
			selectedNodeU = null;
			
			TV2.CollapseAll();
			TV2.Enabled = false;
			selectedNodeG = null;
		}

		private void cmbPadMenu_SelectedIndexChanged( object sender, EventArgs e )
		{
			IdMenu = "";
			if( cmbPadMenu.SelectedIndex == -1 )
				return;

			TV2.Enabled = true;
			Ubigeo itm = (Ubigeo)cmbPadMenu.SelectedItem;
			IdMenu = itm.IdUbigeo;
			CargaMenuGeneral(IdMenu);
			cmdAddAll.Enabled = true;
			cmdAdd.Enabled = false;
		}

		private void cmbUsuario_SelectedIndexChanged( object sender, EventArgs e )
		{
			IdUS = "";
			TipoUS = "";
			if( cmbUsuario.SelectedIndex == -1 )
				return;

			TV1.Enabled = true;
			Ubigeo itm = (Ubigeo)cmbUsuario.SelectedItem;
			IdUS = itm.IdUbigeo.Substring(0,itm.IdUbigeo.IndexOf("*"));
			TipoUS = itm.IdUbigeo.Substring(itm.IdUbigeo.IndexOf("*") + 1, itm.IdUbigeo.Length - itm.IdUbigeo.IndexOf("*") - 1);
			CargaMenuUsuario(IdUS);
			cmdDelAll.Enabled = true;
			cmdDel.Enabled = false;
			cmdCpPl.Enabled = true;
		}

		private void TV1_AfterSelect( object sender, TreeViewEventArgs e )
		{
			selectedNodeU = TV1.SelectedNode;
			cmdDel.Enabled = true;
		}

		private void TV2_AfterSelect( object sender, TreeViewEventArgs e )
		{
			selectedNodeG = TV2.SelectedNode;
			cmdAdd.Enabled = true;
		}

		private void cmdAddAll_Click( object sender, EventArgs e )
		{
			string[] sNodoActual = null;
			string vCant = "";

			if( cmbPadMenu.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar una opcion.", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			if( cmbUsuario.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un usuario.", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			for( int i = 0; i < TV2.SelectedNode.GetNodeCount(true); i++ )
			{
				sNodoActual = TV2.SelectedNode.Nodes[i].Tag.ToString().Split('*');
				if( sNodoActual[3].IndexOf(TipoUS) == -1 )
				{
					if( TV2.SelectedNode.Nodes[i].Text != "\\-" )
						MessageBox.Show("Usuario seleccionado no tiene privilegios de uso para el menu" + (char)13 + TV2.SelectedNode.Nodes[i].Text.ToUpper(), "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				}
				else
				{
					vSQL = "SELECT COUNT(*) FROM Accesos " +
							"WHERE Mnu_Us = '" + IdUS + "' " +
							"AND Mnu_Pop = '" + sNodoActual[0] + "' " +
							"AND Mnu_Bar = " + sNodoActual[1] ;
					vCant = General.TomaValor(vSQL);
					if( Convert.ToInt32(vCant) == 0 )
					{
						vSQL = "INSERT INTO Accesos VALUES (" +
							"'" + sNodoActual[0] + "', " +
							"" + sNodoActual[1] + ", " +
							"'" + IdUS + "', " +
							"'" + Usuario.id_us + "', " +
							"GETDATE()) ";
						Conexion.CMD.CommandText = vSQL;
						Conexion.CMD.ExecuteNonQuery();
					}
				}
			}
			CargaMenuUsuario(IdUS);
		}

		private void cmdAdd_Click( object sender, EventArgs e )
		{
			string[] sNodoActual = null;
			string vCant = "";

			if( cmbPadMenu.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un menu.", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			if( cmbUsuario.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un usuario.", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			if( selectedNodeG == null )
			{
				MessageBox.Show("Debe seleccionar una opcion de menu.", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			sNodoActual = selectedNodeG.Tag.ToString().Split('*');
			if( sNodoActual[3].IndexOf(TipoUS) == -1 )
			{
				if( selectedNodeG.Text != "\\-" )
					MessageBox.Show("Usuario seleccionado no tiene privilegios de uso para el menu" + (char)13 + selectedNodeG.Text.ToUpper(), "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

				return;
			}

			vSQL = "SELECT COUNT(*) FROM Accesos " +
					"WHERE Mnu_Us = '" + IdUS + "' " +
					"AND Mnu_Pop = '" + sNodoActual[0] + "' " +
					"AND Mnu_Bar = " + sNodoActual[1];
			vCant = General.TomaValor(vSQL);
			if( Convert.ToInt32(vCant) != 0 )
			{
				MessageBox.Show("Usuario seleccionado ya cuenta con la opcion de menu de " + (char)13 + selectedNodeG.Text.ToUpper(), "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				return;
			}
			else
			{
				vSQL = "INSERT INTO Accesos VALUES (" +
					"'" + sNodoActual[0] + "', " +
					"" + sNodoActual[1] + ", " +
					"'" + IdUS + "', " +
					"'" + Usuario.id_us + "', " +
					"GETDATE()) ";
				Conexion.CMD.CommandText = vSQL;
				Conexion.CMD.ExecuteNonQuery();
			}
			CargaMenuUsuario(IdUS);
			cmdAdd.Enabled = false;
			selectedNodeG = null;
		}

		private void cmdDelAll_Click( object sender, EventArgs e )
		{
			string[] sNodoActual = null;
			string vCant = "";

			if( cmbUsuario.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un usuario.", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			vSQL = "SELECT COUNT(*) " +
					"FROM Accesos " +
					"WHERE Mnu_Us = '" + IdUS + "' ";
			vCant = General.TomaValor(vSQL);
			if( Convert.ToInt32(vCant) == 0 )
			{
				MessageBox.Show("Usuario seleccionado no cuenta con opciones...", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				return;
			}

			if( MessageBox.Show("Desea eliminar todos los accesos para el usuario" + (char)13 + cmbUsuario.Text + "...?", "Opcion Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes )
			{
				//for( int i = 0; i < TV1.SelectedNode.GetNodeCount(true); i++ )
				//{
				//	sNodoActual = TV1.SelectedNode.Nodes[i].Tag.ToString().Split('*');
				//}

				vSQL = "DELETE FROM Accesos WHERE Mnu_Us = '" + IdUS + "' ";
				Conexion.CMD.CommandText = vSQL;
				Conexion.CMD.ExecuteNonQuery();
			}
			else
				return;

			CargaMenuUsuario(IdUS);
			cmdDelAll.Enabled = false;
			cmbUsuario.SelectedIndex = -1;
		}

		private void cmdDel_Click( object sender, EventArgs e )
		{
			string[] sNodoActual = null;
			string vCant = "";

			if( cmbUsuario.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un usuario.", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			vSQL = "SELECT COUNT(*) " +
					"FROM Accesos " +
					"WHERE Mnu_Us = '" + IdUS + "' ";
			vCant = General.TomaValor(vSQL);
			if( Convert.ToInt32(vCant) == 0 )
				return;

			if( selectedNodeU == null )
			{
				MessageBox.Show("Debe seleccionar una opcion de menu.", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			sNodoActual = selectedNodeU.Tag.ToString().Split('*');
			if( MessageBox.Show("Desea eliminar la opcion" + (char)13 + selectedNodeU.Text.ToUpper() + "...?", "Opcion Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes )
			{
				vSQL = "DELETE FROM Accesos " +
						"WHERE Mnu_Pop = '" + sNodoActual[0] + "' " +
						"AND Mnu_Bar = " + sNodoActual[1] + " " +
						"AND Mnu_Us = '" + IdUS + "' ";
				Conexion.CMD.CommandText = vSQL;
				Conexion.CMD.ExecuteNonQuery();
			}
			else
				return;

			CargaMenuUsuario(IdUS);
			cmdDel.Enabled = false;
			selectedNodeU = null;
		}

		private void cmdClose_Click( object sender, EventArgs e )
		{
			Close();
		}

		private void cmdCpPl_Click( object sender, EventArgs e )
		{
			if( cmbUsuario.SelectedIndex == -1 )
				return;
		
			if( cmdCpPl.Text == "&Copiar Plantilla" )
			{
				if( cmbUsuario.SelectedIndex != -1 )
				{
					if( GetTotalNodes(TV1.Nodes) == 0 )
					{
						MessageBox.Show("Debe selecciona un usuario que tenga opciones de menu...", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
						return;
					}

					Ubigeo itm = (Ubigeo)cmbUsuario.SelectedItem;
					IdUSCopia = itm.IdUbigeo.Substring(0, itm.IdUbigeo.IndexOf("*"));
				}
				cmdCpPl.Text = "&Pegar Plantilla";
			}
			else
			{
				Ubigeo itm = (Ubigeo)cmbUsuario.SelectedItem;
				IdUS = itm.IdUbigeo.Substring(0, itm.IdUbigeo.IndexOf("*"));
				if( IdUS.Trim() == IdUSCopia.Trim() )
				{
					MessageBox.Show("Seleccione un usuario diferente del que sirve de plantilla ...", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
					return;
				}

				MessageBox.Show("Solo copiara menus sobre los cuales tenga privilegios ...", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				cmdCpPl.Text = "&Copiar Plantilla";

				vSQL = "DELETE FROM Accesos WHERE Mnu_Us= '" + IdUS.Trim() + "'";
				Conexion.CMD.CommandText = vSQL;
				Conexion.CMD.ExecuteNonQuery();

				vSQL = "INSERT INTO Accesos (Mnu_Pop,Mnu_Bar,Mnu_Us,Us_Up,Date_Up) " +
						"SELECT LTrim(RTrim(Mnu_Pop)), Mnu_Bar,'"+ IdUS.Trim()+"','"+Usuario.id_us+ "',GETDATE() " +
						"FROM Accesos " +
						"WHERE Mnu_Us = '" + IdUSCopia.Trim() + "' " +
						"AND LTrim(RTrim(Mnu_Pop)) + Cast(Mnu_Bar As Varchar(2)) In " +
						"(SELECT LTrim(RTrim(Bar_Popup)) + Cast(Bar_Number As Varchar(2)) " +
						" FROM Barmenu " +
						" WHERE DBO.Cryptgr(PTU,0,1) Like '%"+ TipoUS.Trim()+"%')";
				Conexion.CMD.CommandText = vSQL;
				Conexion.CMD.ExecuteNonQuery();
				CargaMenuUsuario(IdUS);
				cmdCpPl.Enabled = false;
				IdUSCopia = "";
			}
		}
	}
}
