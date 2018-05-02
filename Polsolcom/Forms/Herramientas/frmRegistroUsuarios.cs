using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
	public partial class frmRegistroUsuarios:Form
	{
		List<Dictionary<string, string>> items;
		string vSQL = "";
		string itmKeyPass = "";
		string itmPersonal = "";
		string itmTipUser = "";
		string itmAreaTrab = "";
		string itmEstado = "";
		string itmIdUS = "";
		string NUEVO = "";

		public frmRegistroUsuarios()
		{
			InitializeComponent();
		}

		private void UbicaItemCombo( ComboBox cmb, string sValor )
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

		void LlenarLista( int vState )
		{
			vSQL = "SELECT LTrim(RTrim(Ape_Paterno))+' '+ " +
					"LTrim(RTrim(Ape_Materno)) + ' ' + " +
					"LTrim(RTrim(Nombres)) Descripcion, " +
					"DBO.Cryptgr(Key_Pass, 0, 1) IdUbigeo " +
					"  FROM sysaccusers S Inner Join Personal P " +
					"ON S.Id_Per = P.Id_Personal " +
					"WHERE State = '" + vState + "' " +
					"ORDER BY 1";
			items = General.GetDictionaryList(vSQL);
		}

		void LlenarListView( Dictionary<string, string> filters = null )
		{
			General.Fill(lstUsers, this.items, new[] { "Descripcion", "IdUbigeo" });
		}

		private void frmRegistroUsuarios_Load( object sender, EventArgs e )
		{
			vSQL = "SELECT Descripcion, Id_Tipo AS IdUbigeo " +
					"FROM tablatipo " +
					"WHERE id_tabla = 8 " +
					"ORDER BY 1";
			General.LlenaComboBox(cmbTipUser, "SQL", vSQL);

			vSQL = "SELECT Descripcion, Id_Tipo AS IdUbigeo " +
					"FROM TablaTipo " +
					"WHERE Id_Tabla In " +
					"(SELECT Id_Tipo " +
					" FROM TablaTipo " +
					" WHERE Descripcion = 'AREA_TRABAJO' " +
					" AND Id_Tabla = '0') " +
					"UNION All " +
					"SELECT Bus Descripcion,Id_Bus AS IdUbigeo " +
					"FROM Buses " +
					"WHERE Bus <> 'COMPUTO' " +
					"ORDER BY 1 ";
			General.LlenaComboBox(cmbAreaTrab, "SQL", vSQL);

			vSQL = "SELECT LTrim(RTrim(Ape_Paterno))+' '+LTrim(RTrim(Ape_Materno))+' '+LTrim(RTrim(Nombres)) Descripcion, " +
					"Id_Personal AS IdUbigeo " +
					"FROM Personal P LEFT JOIN Ubigeo2005 U " +
					"On P.Id_Distrito = U.Id_Old " +
					"WHERE P.Id_Personal NOT IN " +
					"(SELECT id_per " +
					" FROM sysaccusers S) " +
					"ORDER BY 1";
			General.LlenaComboBox(cmbPersonal, "SQL", vSQL);

			vSQL = "SELECT Descripcion, Id_Tipo AS IdUbigeo " +
					"FROM tablatipo " +
					"WHERE id_tabla = 3 " +
					"ORDER BY 1";
			General.LlenaComboBox(cmbListUs, "SQL", vSQL);

			vSQL = "SELECT Descripcion, Id_Tipo AS IdUbigeo " +
					"FROM tablatipo " +
					"WHERE id_tabla = 3 " +
					"ORDER BY 1";
			General.LlenaComboBox(cmbEstado, "SQL", vSQL);
			cmbListUs.SelectedIndex = 0;
		}

		private void frmRegistroUsuarios_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}

		}

		private void cmbListUs_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbListUs.SelectedIndex != -1 )
			{
				Ubigeo itm = (Ubigeo)cmbListUs.SelectedItem;
				LlenarLista(Int32.Parse(itm.IdUbigeo));
				LlenarListView();
				LimpiaTextos();
				pnlUsuarios.Enabled = false;
			}
		}

		private void lstUsers_Click( object sender, EventArgs e )
		{
			int vIndice = -1;
			ListViewItem item = General.GetSelectedItem((ListView)sender);
			vIndice = lstUsers.SelectedIndices[0];

			if( vIndice == -1 )
				return;

			itmKeyPass = item.SubItems[1].Text;
			btnEdit.Enabled = true;

			vSQL = "SELECT P.direccion, P.Telefono, P.Celular,S.Obs, " +
					"DBO.Cryptgr(DBO.Cryptgr(S.Us_Log, 0, 2), 0, 1) Passwd, " +
					"(SELECT DBO.Cryptgr(S1.Key_Pass, 0, 1) " +
					" FROM sysaccusers S1 WHERE S1.Id_Us = S.Us_Ins ),S.date_Ins, " +
					"(SELECT DBO.Cryptgr(S1.Key_Pass, 0, 1) " +
					" FROM sysaccusers S1 WHERE S1.Id_Us = S.Us_up ),S.date_up, " +
					"DBO.Cryptgr(S.Type, 0, 2) Tipo,S.Id_Area,S.State,P.Id_Personal,S.Id_Us " +
					"  FROM sysaccusers S, Personal P " +
					"  WHERE S.Id_Per = P.Id_Personal " +
					"AND DBO.Cryptgr(S.Key_Pass, 0, 1) = '" + itmKeyPass + "' ";
			using( SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN) )
			{
				using( SqlDataReader dr = cmd.ExecuteReader() )
				{
					if( dr.Read() )
					{
						txtDirec.Text = dr.GetValue(0).ToString();
						txtTel.Text = dr.GetValue(1).ToString();
						txtCel.Text = dr.GetValue(2).ToString();
						txtObservacion.Text = dr.GetValue(3).ToString();
						txtLogin.Text = item.SubItems[1].Text;
						txtClave.Text = dr.GetValue(4).ToString();
						txtCreation.Text = dr.GetValue(5).ToString() + " - " + dr.GetValue(6).ToString();
						txtLastUpd.Text = dr.GetValue(7).ToString() + " - " + dr.GetValue(8).ToString();
						UbicaItemCombo(cmbTipUser, dr.GetValue(9).ToString());
						UbicaItemCombo(cmbAreaTrab, dr.GetValue(10).ToString());
						UbicaItemCombo(cmbEstado, dr.GetValue(11).ToString());
						itmPersonal = dr.GetValue(12).ToString().Trim();
						itmIdUS = dr.GetValue(13).ToString().Trim();
					}
					else
					{
						MessageBox.Show("No se tiene datos del usuario." + (char)13 + "Contactar al admnistrador de sistemas.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
						return;
					}
					dr.Close();
				}
			}
		}
		
		private void LimpiaTextos()
		{
			txtDirec.Text = "";
			txtTel.Text = "";
			txtCel.Text = "";
			txtObservacion.Text = "";
			txtLogin.Text = "";
			txtClave.Text = "";
			txtCreation.Text = "";
			txtLastUpd.Text = "";
			cmbPersonal.SelectedIndex = -1;
			cmbTipUser.SelectedIndex = -1;
			cmbAreaTrab.SelectedIndex = -1;
			cmbEstado.SelectedIndex = -1;
		}

		private void btnEdit_Click( object sender, EventArgs e )
		{
			cmbListUs.Enabled = false;
			lstUsers.Enabled = false;
			btnEdit.Enabled = false;
			btnNuevo.Enabled = false;
			btnGrabar.Enabled = true;
			btnCancelar.Enabled = true;

			pnlUsuarios.Enabled = true;
			cmbPersonal.Enabled = false;
			txtDirec.Enabled = false;
			txtTel.Enabled = false;
			txtCel.Enabled = false;
			txtLogin.Enabled = false;
		}

		private void btnNuevo_Click( object sender, EventArgs e )
		{
			btnEdit.Enabled = false;
			btnNuevo.Enabled = false;
			btnGrabar.Enabled = true;
			btnCancelar.Enabled = true;
			lstUsers.Enabled = false;
			cmbListUs.Enabled = false;

			LimpiaTextos();

			itmKeyPass = "";
			itmPersonal = "";
			itmTipUser = "";
			itmAreaTrab = "";
			itmEstado = "";
			itmIdUS = "";

			pnlUsuarios.Enabled = true;
			cmbPersonal.Enabled = true;
			txtDirec.Enabled = true;
			txtTel.Enabled = true;
			txtCel.Enabled = true;
			txtLogin.Enabled = true;
			NUEVO = "SI";
		}

		private void btnCancelar_Click( object sender, EventArgs e )
		{
			btnEdit.Enabled = false;
			btnNuevo.Enabled = true;
			btnCancelar.Enabled = false;
			btnGrabar.Enabled = false;

			pnlUsuarios.Enabled = false;
			cmbListUs.Enabled = true;
			lstUsers.Enabled = true;
			LimpiaTextos();
			NUEVO = "";
		}

		private void btnGrabar_Click( object sender, EventArgs e )
		{
			string vCant = "";

			if( itmKeyPass.Trim() == "")
			{
				MessageBox.Show("Debe seleccionar un usuario del sistema o un nombre de empleado.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				txtLogin.Focus();
				return;
			}

			if( cmbTipUser.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un tipo de usuario.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				cmbTipUser.Focus();
				return;
			}

			if( cmbAreaTrab.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un area de trabajo.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				cmbAreaTrab.Focus();
				return;
			}

			if( cmbEstado.SelectedIndex == -1 )
			{
				MessageBox.Show("Debe seleccionar un estado.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				cmbEstado.Focus();
				return;
			}

			if( itmPersonal.Trim() == "" )
			{
				MessageBox.Show("Debe seleccionar un nombre de empleado.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				cmbPersonal.Focus();
				return;
			}

			if( txtClave.Text.Trim().Length < 8 )
			{
				MessageBox.Show("Contraseña debe ser mayor a 8 caracteres.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				txtClave.Focus();
				return;
			}

			if( General.ValidaPass(txtClave.Text.Trim()) != true )
			{
				MessageBox.Show("Contraseña debe contener mayusculas, minusculas y numeros", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				txtClave.Focus();
				return;
			}

			if( Operativo.id_oper.Trim() == "" )
			{
				MessageBox.Show("Debe existir un Operativo.", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				return;
			}
			
			vSQL = "SELECT SUM(CAST(S As Int))-SUM(CAST(U As Int)) As R " +
					"FROM(SELECT CASE WHEN Id_Tipo = '" + Usuario.tipo + "' THEN Val " +
					"	  ELSE 0 END As S, " +
					"	  CASE WHEN Id_Tipo = '" + itmTipUser + "' THEN Val " +
					"	  ELSE '0' END As U " +
					"	  FROM(SELECT LTrim(RTrim(Id_Tipo)) As Id_Tipo, " +
					"			Cast(LTrim(RTrim(Val_Abr))As Int) As Val " +
					"			FROM TablaTipo " +
					"			WHERE LTrim(RTrim(Id_Tabla)) In " +
					"			(SELECT Id_Tipo From TablaTipo " +
					"			 WHERE LTrim(RTrim(Descripcion)) = 'TIPO_USUARIO' " +
					"			 AND LTrim(RTrim(Id_Tabla)) = '0') " +
					"			AND LTrim(RTrim(Id_Tipo)) In('" + Usuario.tipo + "', '" + itmTipUser + "') " +
					"			UNION SELECT 'S' As Id_Tipo, 6 As Val) X) X";
			vCant = General.TomaValor(vSQL);

			if( Convert.ToInt32(vCant) < 0 )
			{
				MessageBox.Show("Nivel de tipo de usuario no puede ser mayor al suyo ...", "Ingreso de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbTipUser.Focus();
				return;
			}

			if( MessageBox.Show("Desea guardar los datos ...?", "Ingreso de Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No )
				return;

			if( NUEVO == "SI" )
			{
				vSQL = "DECLARE @res Varchar(7) " +
						"EXEC MaxValor 'Id_Us','sysaccusers','4',@ret = @res Output " +
						"EXEC GenUniCod @res, @ret = @res Output Set @res='" + Operativo.id_oper.Trim() + "'+@res " +
						"INSERT INTO sysaccusers VALUES(@res," +
						"'" + General.cryptgr(General.cryptgr(txtClave.Text.Trim(), true, 1), true, 2) + "', " +
						"'" + General.cryptgr(itmKeyPass.Trim(), true, 1) + "'," +
						"'" + General.cryptgr(itmTipUser.Trim(), true, 2) + "'," +
						"'" + itmPersonal.Trim() + "'," +
						"'" + itmAreaTrab.Trim() + "'," +
						"'" + txtObservacion.Text.Trim() + "'," +
						"'" + itmEstado.Trim() + "'," +
						"'" + Usuario.id_us.Trim() + "'," +
						"GETDATE()," +
						"'" + Usuario.id_us.Trim() + "'," +
						"GETDATE()) " +
						"SELECT @res Ret "; 
				Conexion.CMD.CommandText = vSQL;
				Conexion.CMD.ExecuteNonQuery();
				LlenarLista(1); //1 = Activado
				LlenarListView();

				vSQL = "SELECT LTrim(RTrim(Ape_Paterno))+' '+LTrim(RTrim(Ape_Materno))+' '+LTrim(RTrim(Nombres)) Descripcion, " +
						"Id_Personal AS IdUbigeo " +
						"FROM Personal P LEFT JOIN Ubigeo2005 U " +
						"On P.Id_Distrito = U.Id_Old " +
						"WHERE P.Id_Personal NOT IN " +
						"(SELECT id_per " +
						" FROM sysaccusers S) " +
						"ORDER BY 1";
				General.LlenaComboBox(cmbPersonal, "SQL", vSQL);
			}
			else
			{
				if( itmIdUS.Trim() != "" )
				{
					vSQL = "DELETE FROM accesos WHERE Mnu_Us ='" + itmIdUS.Trim() + "'";
					Conexion.CMD.CommandText = vSQL;
					Conexion.CMD.ExecuteNonQuery();
				}

				vSQL = "UPDATE sysaccusers " +
						"SET Us_Log = '" + General.cryptgr(General.cryptgr(txtClave.Text.Trim(), true, 1), true, 2) + "', " +
						"Type = '" + General.cryptgr(itmTipUser.Trim(), true, 2) + "'," +
						"Id_Area = '" + itmAreaTrab.Trim() + "'," +
						"State = '" + itmEstado.Trim() + "'," +
						"Obs = '" + txtObservacion.Text.Trim() + "'," +
						"Us_Up = '" + Usuario.id_us.Trim() + "'," +
						"Date_Up = GETDATE() " +
						"WHERE DBO.Cryptgr(Key_Pass, 0, 1) = '" + itmKeyPass.Trim() + "'";
						Conexion.CMD.CommandText = vSQL;
						Conexion.CMD.ExecuteNonQuery();
			}

			btnCancelar.Enabled = false;
			btnGrabar.Enabled = false;
			btnEdit.Enabled = true;
			btnNuevo.Enabled = true;

			lstUsers.Enabled = true;
			cmbListUs.Enabled = true;
			btnCancelar.Enabled = false;
			pnlUsuarios.Enabled = false;
			LimpiaTextos();
			itmKeyPass = "";
			itmPersonal = "";
			itmTipUser = "";
			itmAreaTrab = "";
			itmEstado = "";
			itmIdUS = "";
			NUEVO = "";
		}

		private void cmbPersonal_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbPersonal.SelectedIndex == -1 )
				return;
						
			Ubigeo itm = (Ubigeo)cmbPersonal.SelectedItem;
			itmPersonal = "";
			vSQL = "SELECT Direccion + ' - ' + Distrito,Telefono,Celular,id_area,id_cargo,estado, " +
					"(SELECT DBO.Cryptgr(S1.Key_Pass, 0, 1) " +
					" FROM sysaccusers S1 WHERE S1.Id_Us = P.Us_Ins),P.Fec_Ins, " +
					"(SELECT DBO.Cryptgr(S1.Key_Pass, 0, 1) " +
					" FROM sysaccusers S1 WHERE S1.Id_Us = P.Us_Mod),P.Fec_Mod,P.Observacion, " +
					"UPPER(SUBSTRING(nombres,1,1)+ape_paterno+SUBSTRING(ape_materno,1,1)),id_personal " +
					"FROM Personal P LEFT JOIN Ubigeo2005 U " +
					"On P.Id_Distrito = U.Id_Old " +
					"WHERE P.Id_Personal = '" + itm.IdUbigeo + "'";
			using( SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN) )
			{
				using( SqlDataReader dr = cmd.ExecuteReader() )
				{
					if( dr.Read() )
					{
						txtDirec.Text = dr.GetValue(0).ToString();
						txtTel.Text = dr.GetValue(1).ToString();
						txtCel.Text = dr.GetValue(2).ToString();
						UbicaItemCombo(cmbAreaTrab, dr.GetValue(3).ToString());
						UbicaItemCombo(cmbTipUser, dr.GetValue(4).ToString());
						UbicaItemCombo(cmbEstado, dr.GetValue(5).ToString());
						txtCreation.Text = dr.GetValue(6).ToString() + " - " + dr.GetValue(7).ToString();
						txtLastUpd.Text = dr.GetValue(8).ToString() + " - " + dr.GetValue(9).ToString();
						txtObservacion.Text = dr.GetValue(10).ToString();
						txtLogin.Text = dr.GetValue(11).ToString().Trim();
						itmPersonal = dr.GetValue(12).ToString().Trim();
						itmKeyPass = txtLogin.Text;
					}
					dr.Close();
				}
			}
		}

		private void cmbTipUser_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbTipUser.SelectedIndex == -1 )
				return;

			itmTipUser = "";
			Ubigeo itm = (Ubigeo)cmbTipUser.SelectedItem;
			itmTipUser = itm.IdUbigeo;
		}

		private void cmbAreaTrab_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbAreaTrab.SelectedIndex == -1 )
				return;

			itmAreaTrab = "";
			Ubigeo itm = (Ubigeo)cmbAreaTrab.SelectedItem;
			itmAreaTrab = itm.IdUbigeo;
		}

		private void cmbEstado_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbEstado.SelectedIndex == -1 )
				return;

			itmEstado = "";
			Ubigeo itm = (Ubigeo)cmbEstado.SelectedItem;
			itmEstado = itm.IdUbigeo;
		}
	}
}
