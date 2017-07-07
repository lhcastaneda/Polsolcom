using Polsolcom.Dominio.Connection;
using Polsolcom.Dominio.Helpers;
using Polsolcom.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms.Procesos
{
    public partial class frmIngresoCie10 : Form
    {
        public frmIngresoCie10()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmIngresoCie10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tipoDocumento.TablaTipo' table. You can move, or remove it, as needed.
            this.tablaTipoTableAdapter.Fill(this.tipoDocumento.TablaTipo);
            this.consultoriosTableAdapter.Fill(this.consultoriosDS.Consultorios, Operativo.id_oper);

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {

        }

        private void chkFiltro_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ((CheckBox)sender).Checked;

            cmbEspecialidad.Enabled = !check;
            cmbTipoDoc.Enabled = !check;
            dtpFechaVent.Enabled = !check;
            txtSerie.Enabled = !check;
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtNroDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                llenarListaTickets();
            }
        }

        private void llenarListaTickets()
        {
            string vSQL = "";
            vSQL += "Select T.Serie,T.Nro_Ticket,";
            vSQL += tabIngresoConsulta.SelectedIndex == 1 ? "T.Fecha_Emision," : "CB.Fecha_Atencion,";
            vSQL += "T.Digitador+Space(11) Digitador,T.Nro_Historia,T.Id_Paciente,C.Descripcion,X.Orden,T.Anulado";
            vSQL += tabIngresoConsulta.SelectedIndex == 1 ?" ": ",T.Fecha_Emision ";
            vSQL += "From Tickets T Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " + "Inner Join (Select Ape_Paterno+' '+Ape_Materno+', '+Nombres+' ('+SubString(TNCol,2,6)+')' Orden,Id_Personal " + "From Personal Union All Select Descripcion,Id_Tipo From TablaTipo Where Id_Tabla In " + "(Select Id_Tipo From TablaTipo Where Descripcion='VAR_EXTRAS' And Id_Tabla='0'))X On T.CMP=X.Id_Personal ";
            vSQL += tabIngresoConsulta.SelectedIndex == 1 ?"": "Inner Join Cab_Cie10 CB On CB.Nro_Historia=T.Nro_Historia ";
            vSQL += "Where";

            MessageBox.Show(tabIngresoConsulta.SelectedIndex.ToString());

            if (tabIngresoConsulta.SelectedIndex == 0)
            {
                if (chkFiltro.Checked || General.vtrls("LA MELLI"))//Averiguar de donde sale frmmain.esp
                {
                    vSQL += cmbEspecialidad.SelectedIndex != -1 ? (" T.Id_Consultorio Like '" + (((DataRowView)cmbEspecialidad.SelectedItem).Row["Id_Consultorio"]).ToString() + "'") : "";
                    vSQL += vSQL.Contains("Like") && cmbEspecialidad.SelectedIndex != -1 ? " And" : "";
                    vSQL += dtpFechaVent.Value != null ? (" T.Fecha_Emision Between '" + dtpFechaVent.Value.ToString() + "' And '" + dtpFechaVent.Value.AddDays(1).ToString() + "'") : "";
                    vSQL += vSQL.Contains("Like") && dtpFechaVent.Value != null ? " And" : "";
                    vSQL += cmbTipoDoc.SelectedIndex != -1 ? (" T.DVenta Like '" + (((DataRowView)cmbTipoDoc.SelectedItem).Row["Id_Tipo"]).ToString() + "'") : "";
                }

                vSQL += vSQL.Contains("Like") && cmbTipoDoc.SelectedIndex != -1 ? " And" : "";
                vSQL += txtSerie.Text.Length > 0 ? (" T.Serie Like '" + txtSerie.Text + "'") : "";
                vSQL += vSQL.Contains("Like") && txtSerie.Text.Length > 0 ? " And" : "";
                vSQL += txtNroDoc.Text.Length > 0 ? (" T.Nro_Ticket Like '" + txtNroDoc.Text + "'") : "";

            }
            else
            {
                //Averiguar de donde sale pac
                //vSQL += " T.Id_Paciente='" + ALLTRIM(pac.id_paciente) + "'";
            }

            using (SqlCommand cmd = new SqlCommand(vSQL, Conexion.CNN))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ListViewItem item = new ListViewItem(new string[] {
                                dr.GetValue(0).ToString(),
                                dr.GetValue(1).ToString(),
                                dr.GetValue(2).ToString(),
                                dr.GetValue(3).ToString(),
                                dr.GetValue(4).ToString(),
                                dr.GetValue(5).ToString(),
                                dr.GetValue(6).ToString(),
                                dr.GetValue(7).ToString(),
                                dr.GetValue(8).ToString(),
                                dr.GetValue(9).ToString(),
                            });

                            lstTickets.Items.Add(item);

                            //RangoVenta.Oper = dr.GetValue(0).ToString();
                            //RangoVenta.Usuario = dr.GetValue(1).ToString();

                        }
                    }

                    dr.Close();
                }
            }


        }

        private void frmIngresoCie10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
