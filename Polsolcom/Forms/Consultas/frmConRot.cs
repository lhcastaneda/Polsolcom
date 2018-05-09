using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Polsolcom.Forms
{
	public partial class frmConRot : Form
    {
        public frmConRot()
        {
            InitializeComponent();
        }

        private void frmConsRotations_Load(object sender, EventArgs e)
        {
			rotacionConsultoriosTableAdapter.Fill(consultoriosDS.RotacionConsultorios);
            cmbEspecialidad.SelectedIndex = -1;

            dtpFecFin.Value = DateTime.Now;
            dtpFecFin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
        }

        private void frmConsRotations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
				DialogResult = DialogResult.Cancel;
				Close();
            }
        }

        private void grdRes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string fi = General.FormatDateTime(dtpFecIni.Value).Substring(0,10);
            string ff = General.FormatDateTime(dtpFecFin.Value).Substring(0,10);
			string ie = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();

            grdRes.Rows.Clear();
            grdCab.Rows.Clear();
            grdDet.Rows.Clear();

			string sql = "SELECT CONVERT(varchar(10), Fecha, 103) Fecha,Espe,Cons,Alte,Sum(Vend) Vend,Sum(Anul) Anul " +
							"FROM(SELECT Cast(Convert(Varchar(10), Fecha_Emision, 103) As DateTime) Fecha, " +
							"C.Descripcion Espe, Bus Cons, Alterno Alte, " +
							"Case When Anulado <> 'S' Then Count(*) Else 0 End Vend, " +
							"Case When Anulado = 'S' Then Count(*) Else 0 End Anul " +
							"FROM Tickets T Inner Join Buses B " +
							"On T.Id_Bus = B.Id_Bus Inner Join Consultorios C " +
							"On T.Id_Consultorio = C.Id_Consultorio " +
							"WHERE Fecha_Emision Between '" + fi + " 00:00:00' And '" + ff + " 23:59:59' " +
							"And T.Id_Bus In(SELECT Id_Bus " +
							"FROM Buses ";
							if( ie.Trim() == "*" )
								sql = sql + ") ";
							else
								sql = sql + "WHERE Id_Esp = '" + ie + "') ";
							sql = sql +	"Group By Cast(Convert(Varchar(10), Fecha_Emision, 103) As DateTime), " +
							"C.Descripcion, Bus, Alterno, Anulado) X " +
							"Group By Fecha, Espe, Cons, Alte " +
							"Order By 1,2 ";
            List<Dictionary<string, string>> rtrs = General.GetDictionaryList(sql);
            General.Fill(grdRes, rtrs);
        }

        private void grdRes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grdRes.Rows.Count > 0)
            {
                int i = grdRes.CurrentCell.RowIndex;
                int j = grdRes.CurrentCell.ColumnIndex;
                string columnName = grdRes.Columns[j].Name;

                grdCab.Rows.Clear();
                grdDet.Rows.Clear();

                string fi = DateTime.Parse(grdRes.Rows[i].Cells["rFecha"].Value.ToString()).ToShortDateString();
                string ff = DateTime.Parse(grdRes.Rows[i].Cells["rFecha"].Value.ToString()).ToShortDateString();
				string nc = grdRes.Rows[i].Cells["rConsultorio"].Value.ToString();

                string sql = "SELECT Serie+'-'+Nro_Ticket DVenta,Fecha_Emision,Ape_Paterno+' '+Ape_Materno+', '+Nombre Paciente, " +
							"Case When Anulado = 'S' AND Left( Descuento,1)= 'A' Then 1 Else 0 End Anul, " +
							"Key_Pass Cajero,T.Nro_Historia " +
							"FROM Tickets T Inner Join Pacientes P " +
							"ON T.Id_Paciente = P.Id_Paciente Inner Join sysaccusers S " +
							"ON T.Digitador = S.Id_Us  " +
							"WHERE Fecha_Emision Between '" + fi + " 00:00:00' AND '" + ff + " 23:59:59' " +
							"AND Id_Bus IN " +
							"(SELECT Id_Bus " +
							" FROM Buses WHERE Bus = '" + nc + "') " +
							"Order By 2";
                List<Dictionary<string, string>> cabs = General.GetDictionaryList(sql).Select(x => { x["Cajero"] = General.TradUser(x["Cajero"]); return x; }).ToList();
                General.Fill(grdCab, cabs, new string[] { "Anul" });
            }
        }

        private void grdCab_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCab.Rows.Count > 0)
            {
                int i = grdCab.CurrentCell.RowIndex;
                int j = grdCab.CurrentCell.ColumnIndex;
                string columnName = grdCab.Columns[j].Name;
                grdDet.Rows.Clear();
                string nr = grdCab.Rows[i].Cells["cNroHistoria"].Value.ToString();
                string sql = "SELECT P.Descripcion,D.Cantidad,D.Monto,(D.Monto*D.Cantidad) Total " +
							"FROM Detalles D Inner Join Productos P On D.Id_Producto=P.Id_Producto " +
							"WHERE D.Nro_Historia = '" + nr + "' " +
							"Order By 1";
                List<Dictionary<string, string>> dtrt = General.GetDictionaryList(sql);
                General.Fill(grdDet, dtrt);
            }
        }

		private void dtpFecIni_ValueChanged( object sender, EventArgs e )
		{
			dtpFecFin.Text = dtpFecIni.Text;
			grdRes.Rows.Clear();
			grdCab.Rows.Clear();
			grdDet.Rows.Clear();
			cmbEspecialidad.SelectedIndex = -1;
		}

		private void dtpFecFin_ValueChanged( object sender, EventArgs e )
		{
			grdRes.Rows.Clear();
			grdCab.Rows.Clear();
			grdDet.Rows.Clear();
			cmbEspecialidad.SelectedIndex = -1;
		}
	}
}
