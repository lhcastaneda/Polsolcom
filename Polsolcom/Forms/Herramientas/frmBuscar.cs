using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;

namespace Polsolcom.Forms.Herramientas
{
	public partial class frmBuscar : Form
	{
		public frmBuscar()
		{
			InitializeComponent();
		}

		private void frmBuscar_Load( object sender, EventArgs e )
		{
			Text = Text + "Conexion a BD general: " + (General.ODB == 0? "OFF" : "ON");
		}

		private void frmBuscar_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private void FormateaGrilla()
		{
			fGrid.RowHeader.Visible = false;
			fGrid.RowMode = true;
			fGrid.SelectionMode = iGSelectionMode.One;
			fGrid.DefaultRow.Height = 20;
			fGrid.Cols.Count = 6;

			fGrid.Cols[0].Text = "Apellidos y Nombres";
			fGrid.Cols[0].Width = 320;
			fGrid.Cols[0].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[0].CellStyle.TextAlign = iGContentAlignment.MiddleLeft;
			fGrid.Cols[0].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[1].Text = "ID Paciente";
			fGrid.Cols[1].Width = 100;
			fGrid.Cols[1].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[1].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[1].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[2].Text = "DNI";
			fGrid.Cols[2].Width = 100;
			fGrid.Cols[2].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[2].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[2].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[3].Text = "Id_Old";
			fGrid.Cols[3].Width = 1;
			fGrid.Cols[3].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[3].Text = "Id_Distrito";
			fGrid.Cols[3].Width = 1;
			fGrid.Cols[3].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[3].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[3].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[4].Text = "Id_Asegurado";
			fGrid.Cols[4].Width = 1;
			fGrid.Cols[4].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[4].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[4].CellStyle.ReadOnly = iGBool.True;

			fGrid.Cols[5].Text = "Nro_Historia";
			fGrid.Cols[5].Width = 1;
			fGrid.Cols[5].ColHdrStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[5].CellStyle.TextAlign = iGContentAlignment.MiddleCenter;
			fGrid.Cols[5].CellStyle.ReadOnly = iGBool.True;
		}

		private void CargaGrilla()
		{
			string vSQL = "";
			DataSet dt = new DataSet();

			vSQL = General.DevuelveQueryPaciente(txtAPPaterno.Text.ToString(),txtAPMaterno.Text.ToString(),txtNombres.Text.ToString(),txtDNI.Text.ToString(),"","",1,General.ODB);

			if( vSQL == "" )
				return;

			Cursor.Current = Cursors.WaitCursor;
			Conexion.CMD.CommandText = vSQL;
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

		private void txtAPPaterno_TextChanged( object sender, EventArgs e )
		{
			if( General.ODB == 0 )
				CargaGrilla();
		}

		private void txtAPMaterno_TextChanged( object sender, EventArgs e )
		{
			if( General.ODB == 0 )
				CargaGrilla();
		}

		private void txtNombres_TextChanged( object sender, EventArgs e )
		{
			if( General.ODB == 0 || txtNombres.Text != "" )
				CargaGrilla();
		}

		private void txtDNI_TextChanged( object sender, EventArgs e )
		{
			if( txtDNI.Text.Length == 8 )
				CargaGrilla();
		}

		private void txtDNI_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
				e.Handled = true;
		}

		private void txtNombres_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Escape )
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
			else if( e.KeyCode == Keys.Enter )
			{
				if( General.ODB == 0 || ( txtAPPaterno.Text != "" && txtAPMaterno.Text != "" && txtNombres.Text == "") )
					CargaGrilla();
			}
		}

		private void fGrid_MouseDoubleClick( object sender, MouseEventArgs e )
		{
			if( fGrid.Rows.Count != 0 )
			{
				if( General.ODB == 0 )
				{
					
				}
				else
				{
					MessageBox.Show(fGrid.Cells[fGrid.CurRow.Index, 0].Text);

				}
			}
		}
	}
}
