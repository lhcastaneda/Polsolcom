using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
    public partial class frmAnualt : Form
    {
        public frmAnualt()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAnualt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void grdAnualt_KeyDown(object sender, KeyEventArgs e)
        {
            int i = grdAnualt.CurrentCell.RowIndex;
            int j = grdAnualt.CurrentCell.ColumnIndex;
            string columnName = grdAnualt.Columns[j].Name;

            if (e.KeyCode == Keys.F1)
            {
                txtNDoc.Focus();
            }
        }

        private void frmAnualt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaTipoDS.DocVenta' table. You can move, or remove it, as needed.
            this.docVentaTableAdapter.Fill(this.tablaTipoDS.DocVenta);
            cmbTDoc.SelectedIndex = -1;

        }

        private void txtNDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string td = cmbTDoc.SelectedIndex == -1 ? "" : cmbTDoc.SelectedValue.ToString();
                string sr = txtSerie.Text;
                string nd = txtNDoc.Text;

                if (td.Length > 0 && sr.Length > 0 && nd.Length > 0)
                {
                    string rn = "";

                    if (grdAnualt.Rows.Count > 0)
                    {
                        rn = "Or T.Nro_Historia In('";

                        for (int i = 0; i < grdAnualt.Rows.Count; i++)
                        {
                            rn += grdAnualt.Rows[i].Cells["gNR"].Value.ToString() + "','";
                        }
                        rn = rn.Substring(0, rn.Length - 2) + ") ";
                    }

                    string sql = "Select DV.Descripcion td,Serie+'-'+Nro_Ticket nd,Cast(Convert(Varchar(10),Fecha_Emision,103)" +
"As DateTime)fv,Ape_Paterno+' '+Ape_Materno+', '+Nombre np,C.Descripcion ne,Fecha_Atencion fa," +
"B.Bus nc,Sum(Cantidad*Monto)tt,Case When Anulado='' Then 0 Else 1 End ma,T.Nro_Historia nr " +
"From Tickets T Inner Join (Select Id_Tipo,Descripcion From TablaTipo Where Id_Tabla " +
"In(Select Id_Tipo From TablaTipo Where LTrim(RTrim(Descripcion))='DOC_VENTA' And " +
"LTrim(RTrim(Id_Tabla))='0'))DV On T.DVenta=DV.Id_Tipo " +
"Inner Join Pacientes P On T.Id_Paciente=P.Id_Paciente " +
"Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " +
"Inner Join Cab_Cie10 CB On T.Nro_Historia=CB.Nro_Historia " +
"Inner Join Buses B On CB.Id_Bus=B.Id_Bus " +
"Inner Join Detalles D On T.Nro_Historia=D.Nro_Historia " +
"Where (DV.Id_Tipo='" + td + "' And Serie='" + sr + "' And Nro_Ticket='" + nd + "') " + (rn.Length > 0 ? rn : "") + "Group By DV.Descripcion,Serie+'-'+Nro_Ticket,Cast(Convert(Varchar(10),Fecha_Emision,103)As DateTime)" +
",Ape_Paterno+' '+Ape_Materno+', '+Nombre,C.Descripcion,Fecha_Atencion,B.Bus,Anulado,T.Nro_Historia";
                    List<Dictionary<string, string>> items = General.GetDictionaryList(sql);
                    General.Fill(grdAnualt, items, new string[] { "ma" });
                }
                else
                {
                    General.msg("Faltan datos ...", "Advertencia", true);
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de actualizar la condición de anulado ?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < grdAnualt.Rows.Count; i++)
                {
                    string us = Usuario.id_us;
                    string sa = grdAnualt.Rows[i].Cells["gMA"].Value.ToString() == "True" ? "S" : "";
                    string nr = grdAnualt.Rows[i].Cells["gNR"].Value.ToString();
                    string sql = "Update Tickets Set Anulado='" + sa + "',Descuento='A'+'" + us + "'+Space(9-Len('" + us + "'))+" + "Convert(Varchar(10),GetDate(),103)+' '+Convert(Varchar(10),GetDate(),108)+' ANU.ALT.'" + "Where Nro_Historia='" + nr + "'";
                    Conexion.ExecuteNonQuery(sql);
                }
            }
        }
    }
}
