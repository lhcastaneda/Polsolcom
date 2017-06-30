using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;

namespace Polsolcom.Forms.Herramientas
{
	public partial class frmBuscaT:Form
	{
		private static string vIDSerie = "";
		private static string vDventa = "";
		private static string vIDEspecialidad = "";

		public frmBuscaT()
		{
			InitializeComponent();
		}

		private void FormateaGrilla()
		{
			fGrid.RowHeader.Visible = false;
			fGrid.RowMode = true;
			fGrid.SelectionMode = iGSelectionMode.One;
			fGrid.DefaultRow.Height = 23;
			fGrid.Cols.Count = 8;

			fGrid.Cols[0].Text = "Consultorio";
			fGrid.Cols[0].Width = 210;
			fGrid.Cols[0].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[0].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
			fGrid.Cols[0].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[1].Text = "Paciente";
			fGrid.Cols[1].Width = 150;
			fGrid.Cols[1].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
			fGrid.Cols[1].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[2].Text = "N° Recibo";
			fGrid.Cols[2].Width = 65;
			fGrid.Cols[2].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[3].Text = "ID Paciente";
			fGrid.Cols[3].Width = 75;
			fGrid.Cols[3].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[4].Text = "Fecha";
			fGrid.Cols[4].Width = 60;
			fGrid.Cols[4].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[4].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[4].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[5].Text = "N° Historia";
			fGrid.Cols[5].Width = 1;

			fGrid.Cols[6].Text = "Anulado";
			fGrid.Cols[6].Width = 1;

			fGrid.Cols[7].Text = "DNI";
			fGrid.Cols[7].Width = 1;

		}

		private void CargaTickets()
		{
			int iCont = 0;
			DataSet dt = new DataSet();

			if( txtApePaterno.Text.Trim() != "" )
				iCont = iCont + 1;

			if( txtApeMaterno.Text.Trim() != "" )
				iCont = iCont + 1;

			if( txtNombres.Text.Trim() != "" )
				iCont = iCont + 1;

			if( vIDSerie != "" || vDventa != "" || vIDEspecialidad != "" )
				if( txtFechaEmision.Text.Trim() == "")
				{
					MessageBox.Show("Para la seleccion de serie, documento o especialidad"+(char)13 + "es necesario ingresar una fecha...", "Ingresar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
					return;
				}

			if( iCont > 0 && iCont < 3 )
			{
				MessageBox.Show("Debe ingresar la combinacion de nombre, apellido paterno" + (char)13 + "y apellido materno para ejecutar la consulta...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}

			string sQuery = "SELECT Descripcion AS Consultorio, " + 
						"P.Ape_Paterno + ' ' + P.Ape_Materno + ' ' + P.Nombre AS Paciente," + 
						"T.Serie + '-' + T.Nro_Ticket AS Ticket, T.Id_Paciente," +
						"CONVERT(VARCHAR(10),T.Fecha_Emision,103),T.Nro_Historia,T.Anulado,P.DNI " + 
						"FROM Tickets T INNER JOIN Pacientes P " + 
						"ON T.Id_Paciente = P.Id_paciente " + 
						"INNER JOIN Consultorios C " + 
						"ON T.Id_Consultorio = C.Id_Consultorio " + 
						"WHERE 1 = 1 " +
						"AND LEFT(T.Nro_Historia,3) = '" + Operativo.id_oper + "' ";

			if( txtDNI.Text.Length == 8 )
				sQuery = sQuery + "AND P.DNI = '" + txtDNI.Text.Trim() + "' ";

			if( txtFechaEmision.Text.Trim().Length == 12 )
				sQuery = sQuery + "AND CONVERT(VARCHAR(10),T.Fecha_Emision,103) = '" + txtFechaEmision.Text.Trim() + "' ";

			if( vIDSerie != "" )
				sQuery = sQuery + "AND T.Serie = '" + vIDSerie + "' ";

			if( vDventa != "" )
				sQuery = sQuery + "AND T.DVenta = '" + vDventa + "' ";

			if( vIDEspecialidad != "" )
				sQuery = sQuery + "AND C.Id_Consultorio = '" + vIDEspecialidad + "' ";

			if( iCont >= 3 )
			{
				sQuery = sQuery + "AND P.Ape_Paterno LIKE '" + txtApePaterno.Text.Trim() + "%' ";
				sQuery = sQuery + "AND P.Ape_Materno LIKE '" + txtApeMaterno.Text.Trim() + "%' ";
				sQuery = sQuery + "AND P.Nombre LIKE '" + txtNombres.Text.Trim() + "%' ";
			}
			sQuery = sQuery + "ORDER BY 2 ";
			Cursor.Current = Cursors.WaitCursor;
			Conexion.CMD.CommandText = sQuery;
			using( SqlDataAdapter da = new SqlDataAdapter(Conexion.CMD) )
			{
				dt.Clear();
				da.Fill(dt);
				da.Dispose();
			}

			fGrid.Rows.Clear();
			using( IDataReader dr = dt.CreateDataReader() )
			{
				fGrid.FillWithData(dr);
				dr.Close();
			}
			Cursor.Current = Cursors.Default;
			FormateaGrilla();

		}

		private void frmBuscaT_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private void frmBuscaT_Load( object sender, System.EventArgs e )
		{
			txtFechaEmision.Mask = "00/00/0000";
			txtFechaEmision.ValidatingType = typeof(System.DateTime);

			General.LlenaComboBox(cmbTDoc, "DOC_VENTA");
			General.LlenaComboBox(cmbSerie, "SERIE");
			//llena combo especialidad
			string vSQL = "SELECT DISTINCT Descripcion,Id_Consultorio AS IdUbigeo " +
						  "FROM Consultorios " +
						  "WHERE Id_Consultorio LIKE '" + Operativo.id_oper + "%' " +
						  "AND Estado= '1' " +
						  "Order By 1";
			General.LlenaComboBox(cmbEspecialidad, "SQL", vSQL);
			vIDSerie = "";
			vDventa = "";
			vIDEspecialidad = "";
			FormateaGrilla();

	}

		private void txtDNI_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
				e.Handled = true;
		}

		private void txtDNI_TextChanged( object sender, System.EventArgs e )
		{
			if( txtDNI.Text.Length == 8 )
				CargaTickets();
		}

		private void btnBuscarT_Click( object sender, EventArgs e )
		{
			CargaTickets();
		}

		private void txtFechaEmision_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}

			if( e.KeyCode == Keys.Enter )
			{
				if( txtFechaEmision.Text.Trim().Length == 10 )
					CargaTickets();
				else
					return;

				e.Handled = true;
			}
		}

		private void txtFechaEmision_TypeValidationCompleted( object sender, TypeValidationEventArgs e )
		{
			if( txtFechaEmision.Text.Trim() == "/  /" )
				return;

			if( !e.IsValidInput )
			{
				MessageBox.Show("Fecha (dd/MM/aaaa) invalida...", "Ingresar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				return;
			}

		}

		private void cmbSerie_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbSerie.SelectedIndex == -1 )
				return;

			Ubigeo itm = (Ubigeo)cmbSerie.SelectedItem;
			vIDSerie = itm.IdUbigeo.Trim();
		}

		private void cmbTDoc_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbTDoc.SelectedIndex == -1 )
				return;

			Ubigeo itm = (Ubigeo)cmbTDoc.SelectedItem;
			vDventa = itm.IdUbigeo.Trim();
		}

		private void cmbEspecialidad_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( cmbEspecialidad.SelectedIndex == -1 )
				return;

			Ubigeo itm = (Ubigeo)cmbEspecialidad.SelectedItem;
			vIDEspecialidad = itm.IdUbigeo.Trim();
		}

		private void fGrid_MouseDoubleClick( object sender, MouseEventArgs e )
		{
			if( fGrid.Rows.Count != 0 )
			{
				if( fGrid.CurRow.Index != -1 )
				{
					lblTicket.Text = fGrid.Cells[fGrid.CurRow.Index, 5].Text;
					DialogResult = DialogResult.OK;
					Close();
				}
	
			}
		}

		private void txtNombres_TextChanged( object sender, EventArgs e )
		{
			if( txtApePaterno.Text.Trim() == "" || txtApeMaterno.Text.Trim() == "" )
				return;

			CargaTickets();
		}
	}
}
