using Polsolcom.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: This line of code loads data into the 'consultoriosDS.RotacionConsultorios' table. You can move, or remove it, as needed.
            this.rotacionConsultoriosTableAdapter.Fill(this.consultoriosDS.RotacionConsultorios);
            cmbEspecialidad.SelectedIndex = -1;

            dtpFecFin.Value = DateTime.Now;
            dtpFecFin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
        }

        private void frmConsRotations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void grdRes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string fi = General.FormatDateTime(dtpFecIni.Value);
            string ff = General.FormatDateTime(dtpFecFin.Value);
            string ie = cmbEspecialidad.SelectedIndex == -1 ? "" : cmbEspecialidad.SelectedValue.ToString();

            grdRes.Rows.Clear();
            grdCab.Rows.Clear();
            grdDet.Rows.Clear();

            string sql = "Select Fecha,Espe,Cons,Alte,Sum(Vend)Vend,Sum(Anul)Anul From (" +
"Select Cast(Convert(Varchar(10),Fecha_Emision,103)As DateTime)Fecha,C.Descripcion Espe,Bus Cons,Alterno Alte," +
"Case When Anulado<>'S' Then Count(*) Else 0 End Vend,Case When Anulado='S' Then Count(*) Else 0 End Anul " +
"From Tickets T Inner Join Buses B On T.Id_Bus=B.Id_Bus " +
"Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " +
"Where Fecha_Emision Between '" + fi + "' And '" + ff + "' And T.Id_Bus In(Select Id_Bus From Buses Where Id_Esp='" + ie + "') " +
"Group By Cast(Convert(Varchar(10),Fecha_Emision,103)As DateTime),C.Descripcion,Bus,Alterno,Anulado)X " +
"Group By Fecha,Espe,Cons,Alte " +
"Order By 1,2";
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
                string ff = DateTime.Parse(fi).AddDays(1).ToShortDateString();
                string nc = grdRes.Rows[i].Cells["rConsultorio"].Value.ToString();

                string sql = "Select Serie+'-'+Nro_Ticket DVenta,Fecha_Emision,Ape_Paterno+' '+Ape_Materno+', '+Nombre Paciente," +
"Case When Anulado='S' And Left(Descuento,1)='A' Then 1 Else 0 End Anul,Key_Pass Cajero,T.Nro_Historia " +
"From Tickets T Inner Join Pacientes P On T.Id_Paciente=P.Id_Paciente " +
"Inner Join sysaccusers S On T.Digitador=S.Id_Us " +
"Where Fecha_Emision Between '" + fi + "' And '" + ff + "' And Id_Bus In(Select Id_Bus From Buses Where Bus='" + nc + "') " +
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

                string sql = "Select P.Descripcion,D.Cantidad,D.Monto,(D.Monto*D.Cantidad) Total " +
"From Detalles D Inner Join Productos P On D.Id_Producto=P.Id_Producto " +
"Where D.Nro_Historia='" + nr + "' " +
"Order By 1";
                List<Dictionary<string, string>> dtrt = General.GetDictionaryList(sql);
                General.Fill(grdDet, dtrt);
            }
        }
    }
}
