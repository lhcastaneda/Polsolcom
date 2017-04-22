using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Polsolcom.Clases;

namespace Polsolcom.Forms
{
	public partial class frmtvMenus : Form
    {
		//define variable para sentencias SQL
        string vSQL = "";
		//define una variable del nodo seleccionado que se usara
		//en todos los botones mas adelante
        TreeNode selectedNode = new TreeNode();

        public frmtvMenus()
        {
            InitializeComponent();
        }

        private void frmtvMenus_Load(object sender, EventArgs e)
        {
			trvMenu.Nodes.Clear();
            //selecciona los menus principales
            vSQL = "SELECT Pad_Popup,Pad_Prompt,Pad_Name,Pad_Order ";
            vSQL = vSQL + " FROM Padmenu ";
            vSQL = vSQL + " ORDER BY Pad_Popup";
            SqlDataAdapter dNodos = new SqlDataAdapter(vSQL, Conexion.CNN);

            //selecciona los items de cada menu principal
            vSQL = "SELECT Bar_Popup,Bar_Prompt,Bar_Number,Bar_Order ";
            vSQL = vSQL + " FROM Barmenu ";
            vSQL = vSQL + " ORDER BY  Bar_Popup, Bar_Order";
            SqlDataAdapter dHijos = new SqlDataAdapter(vSQL, Conexion.CNN);

			//metodo que relaciona tabla cabecera con tabla detalle
            DataSet ds = new DataSet();
            dNodos.Fill(ds, "Padmenu");
            dHijos.Fill(ds, "Barmenu");
            ds.Relations.Add("PadBarMenu", ds.Tables["Padmenu"].Columns["Pad_Popup"], ds.Tables["Barmenu"].Columns["Bar_Popup"]);
            trvMenu.ImageIndex = 1;
			
            foreach ( DataRow dr in ds.Tables["Padmenu"].Rows )
            {//llena nodos principales con tabla cabecera
                TreeNode tnPadre = new TreeNode();
                tnPadre.Name = dr["Pad_Name"].ToString();
                tnPadre.Text = dr["Pad_Prompt"].ToString();
                tnPadre.Tag = dr["Pad_Popup"].ToString() + "*" + dr["Pad_Name"].ToString() + "*" + dr["Pad_Order"].ToString();
                tnPadre.ImageIndex = 0;
                tnPadre.SelectedImageIndex = 0;
                foreach ( DataRow drChild in dr.GetChildRows("PadBarMenu") )
                {//llena nodos secundarios con tabla detalle
                    TreeNode tnHijo = new TreeNode();
                    tnHijo.Name = drChild["Bar_Number"].ToString();
                    tnHijo.Text = drChild["Bar_Prompt"].ToString();
                    tnHijo.Tag = drChild["Bar_Popup"].ToString() + "*" + drChild["Bar_Number"].ToString() + "*" + drChild["Bar_Order"].ToString();
                    tnHijo.ImageIndex = 1;
                    tnHijo.SelectedImageIndex = 1;
                    tnPadre.Nodes.Add(tnHijo);
                }
                trvMenu.Nodes.Add(tnPadre);
            }
            trvMenu.ExpandAll();
            trvMenu.SelectedNode = trvMenu.Nodes[0];
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmtvMenus_KeyDown(object sender, KeyEventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void trvMenu_KeyDown(object sender, KeyEventArgs e)
        {
			//cierra el formulario cuando se presiona la tecla ESC
            if ( e.KeyCode == Keys.Escape )
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
			if ( selectedNode == null )
			{//valida que exista un nodo seleccionado antes de subir
				MessageBox.Show("Debe seleccionar una opcion.", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				return;
			}
			
            //TreeNode nodeFirst = this.trvMenu.SelectedNode.PrevNode;
			TreeNode nodeFirst = selectedNode.PrevNode;
            if ( nodeFirst == null )
            {
                //this.trvMenu.SelectedNode = this.trvMenu.SelectedNode;
				trvMenu.SelectedNode = selectedNode;
                trvMenu.Select();
                return;
            }

            //string[] sNodoActual = this.trvMenu.SelectedNode.Tag.ToString().Split('*');
			string[] sNodoActual = selectedNode.Tag.ToString().Split('*');
			//string[] sNodoPrevio = this.trvMenu.SelectedNode.PrevNode.Tag.ToString().Split('*');
			string[] sNodoPrevio = selectedNode.PrevNode.Tag.ToString().Split('*');
			
            string sOrderActual = DevuelveOrdenNodo(sNodoActual[0], sNodoActual[1]);
            string sOrderPrevio = DevuelveOrdenNodo(sNodoPrevio[0], sNodoPrevio[1]);
            
            //TreeNode node = this.trvMenu.SelectedNode.Clone() as TreeNode;
			TreeNode node = selectedNode.Clone() as TreeNode;
            int index = -1;
            for ( int j = 0; j < trvMenu.SelectedNode.Parent.Nodes.Count; j++ )
            {
                if ( trvMenu.SelectedNode == trvMenu.SelectedNode.Parent.Nodes[j] )
                {
                    index = j;
                    break;
                }
            }
            trvMenu.BeginUpdate();
            trvMenu.SelectedNode.Parent.Nodes.Insert(index - 1, node);
            trvMenu.SelectedNode.Parent.Nodes.RemoveAt(index + 1);
            trvMenu.EndUpdate();
            trvMenu.SelectedNode = node;
            trvMenu.Select();
			selectedNode = node;

            try
            {
                //actualiza el orden previo con el orden actual
                vSQL = "UPDATE Barmenu ";
                vSQL = vSQL + "SET Bar_Order = " + sOrderActual + " ";
                vSQL = vSQL + " WHERE Bar_Popup = '" + sNodoPrevio[0] + "' ";
                vSQL = vSQL + " AND Bar_Number = '" + sNodoPrevio[1] + "'";
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
                
                //actualiza el orden del nodo actual con el orden previo
                vSQL = "UPDATE Barmenu ";
                vSQL = vSQL + "SET Bar_Order = " + sOrderPrevio + " ";
                vSQL = vSQL + " WHERE Bar_Popup = '" + sNodoActual[0] + "' ";
                vSQL = vSQL + " AND Bar_Number = '" + sNodoActual[1] + "'";
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
            }
            catch ( SqlException ex )
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
			if ( selectedNode == null )
			{//valida que exista un nodo seleccionado antes de bajar
				MessageBox.Show("Debe seleccionar una opcion.", "Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				return;
			}

			TreeNode nodeLast = selectedNode.NextNode;
            if ( nodeLast == null )
            {
				trvMenu.SelectedNode = selectedNode;
                trvMenu.Select();
                return;
            }

			string[] sNodoActual = selectedNode.Tag.ToString().Split('*');
			string[] sNodoPost = selectedNode.NextNode.Tag.ToString().Split('*');

            string sOrderActual = DevuelveOrdenNodo(sNodoActual[0], sNodoActual[1]);
            string sOrderPost = DevuelveOrdenNodo(sNodoPost[0], sNodoPost[1]);

			TreeNode node = selectedNode.Clone() as TreeNode;
            int index = -1;
            for ( int j = 0; j < trvMenu.SelectedNode.Parent.Nodes.Count; j++ )
            {
                if ( this.trvMenu.SelectedNode == trvMenu.SelectedNode.Parent.Nodes[j] )
                {
                    index = j;
                    break;
                }
            }
            trvMenu.BeginUpdate();
            trvMenu.SelectedNode.Parent.Nodes.Insert(index + 2, node);
            trvMenu.SelectedNode.Parent.Nodes.RemoveAt(index);
            trvMenu.EndUpdate();
            trvMenu.SelectedNode = node;
            trvMenu.Select();
			selectedNode = node;

            try
            {
                //actualiza el orden previo con el orden actual
                vSQL = "UPDATE Barmenu ";
                vSQL = vSQL + "SET Bar_Order = " + sOrderActual + " ";
                vSQL = vSQL + " WHERE Bar_Popup = '" + sNodoPost[0] + "' ";
                vSQL = vSQL + " AND Bar_Number = '" + sNodoPost[1] + "'";
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();

                //actualiza el orden del nodo actual con el orden previo
                vSQL = "UPDATE Barmenu ";
                vSQL = vSQL + "SET Bar_Order = " + sOrderPost + " ";
                vSQL = vSQL + " WHERE Bar_Popup = '" + sNodoActual[0] + "' ";
                vSQL = vSQL + " AND Bar_Number = '" + sNodoActual[1] + "'";
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
            }
            catch ( SqlException ex )
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private string DevuelveOrdenNodo(string BPopup, string BNumber)
        {
			//devuelve la posicion en el menu de una opcion
            string sOrder = "";

            vSQL = "SELECT Bar_Order ";
            vSQL = vSQL + " FROM Barmenu ";
            vSQL = vSQL + " WHERE Bar_Popup = '" + BPopup + "' ";
            vSQL = vSQL + " AND Bar_Number = '" + BNumber + "'";
			Conexion.CMD.CommandText = vSQL;
			using ( SqlDataReader dr = Conexion.CMD.ExecuteReader() )
			{
                if ( dr.HasRows )
                {
                    while ( dr.Read() )
                        sOrder = dr.GetValue(0).ToString();
                }
                dr.Close();
            }
            return sOrder;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmShowBar fr = new frmShowBar();
            fr.bInsertar = true;
            fr.selectedNode = trvMenu.SelectedNode;
            fr.ShowDialog();
			frmtvMenus_Load(sender, e); 
			trvMenu.SelectedNode = trvMenu.Nodes[0];
			selectedNode = trvMenu.Nodes[0];
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
			if ( selectedNode == null )
			{//valida que exista un nodo seleccionado antes de editar
				MessageBox.Show("Debe seleccionar una opcion.", "Edicion Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				return;
			}

			if ( selectedNode.Parent == null )
			{//no puede editar un menu principal
				MessageBox.Show("No puede editar la opcion:" + (char)13 + selectedNode.Text  + (char)13 + "Porque es un Menu Principal", "Eliminacion Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				return;
			}

            frmShowBar fr = new frmShowBar();
            fr.bInsertar = false;
			fr.selectedNode = selectedNode;
            fr.ShowDialog();
			frmtvMenus_Load(sender, e);
			trvMenu.SelectedNode = trvMenu.Nodes[0];
			selectedNode = trvMenu.Nodes[0];
        }

        private void trvMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
			if ( selectedNode == null)
			{//valida que exista un nodo seleccionado antes de borrar
				MessageBox.Show("Debe seleccionar una opcion.", "Eliminacion Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				return;
			}

			string sTexto = "";
			if ( selectedNode.Text.Substring(0, 1) == "\\" )
				sTexto = "Separador";
			else
				sTexto = selectedNode.Text;

			if ( selectedNode.Parent == null )
			{
				MessageBox.Show("No puede eliminar la opcion:" + (char)13 + sTexto + (char)13 + "Porque es un Menu Principal", "Eliminacion Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				return;
			}

			if ( MessageBox.Show("Desea eliminar la opcion:" + (char)13 + (char)13 + sTexto + " ..?", "Eliminacion Opcion Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No )
				return;

			string[] sNodoActual = selectedNode.Tag.ToString().Split('*');

			//elimina el nodo seleccionado
			trvMenu.BeginUpdate();
			trvMenu.SelectedNode.Parent.Nodes.RemoveAt(selectedNode.Index);
			trvMenu.EndUpdate();
			trvMenu.Select();
			trvMenu.SelectedNode = trvMenu.Nodes[0];
			selectedNode = null;

			try
			{
				//borra los accesos del usuario de la tabla ACCESOS
				vSQL = "DELETE FROM Accesos ";
				vSQL = vSQL + " WHERE Mnu_Pop = '" + sNodoActual[0] + "' ";
				vSQL = vSQL + " AND Mnu_Bar = '" + sNodoActual[1] + "'";
				Conexion.CMD.CommandText = vSQL;
				Conexion.CMD.ExecuteNonQuery();

				//borra la opcion de la tabla BARMENU
				vSQL = "DELETE FROM Barmenu ";
				vSQL = vSQL + " WHERE Bar_Popup = '" + sNodoActual[0] + "' ";
				vSQL = vSQL + " AND Bar_Number = '" + sNodoActual[1] + "'";
				Conexion.CMD.CommandText = vSQL;
				Conexion.CMD.ExecuteNonQuery();

				MessageBox.Show("Elininacion Satisfactoria de la opcion:" + (char)13 + sTexto, "Eliminacion Opcion Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
			}
			catch ( SqlException ex )
			{
				MessageBox.Show(ex.Message);
				return;
			}
        }
		
		private void trvMenu_MouseClick( object sender, MouseEventArgs e )
		{
			btnSubir.Enabled = true;
			btnBajar.Enabled = true;
			btnInsertar.Enabled = true;
			btnQuitar.Enabled = true;
			btnEditar.Enabled = true;
		}

		private void trvMenu_AfterSelect( object sender, TreeViewEventArgs e )
		{
			selectedNode = trvMenu.SelectedNode;
		}



    }
}
