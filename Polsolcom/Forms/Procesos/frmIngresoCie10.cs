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
            //Hacemos que no salgan nseleccionados ningún ítem
            cmbEspecialidad.SelectedIndex = -1;
            cmbTipoDoc.SelectedIndex = -1;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {

        }

        private void chkFiltro_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ((CheckBox)sender).Checked;

            cmbEspecialidad.Enabled = !check;
            cmbTipoDoc.Enabled = !check;
            chkFechaVent.Enabled = !check;
            dtpFechaVent.Enabled = !check && chkFechaVent.Checked;
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
            if (txtNroDoc.Text.Length == 0)
            {
                MessageBox.Show("Debe escribir un número de documento", "Ingreso y consulta de atenciones realizadas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            string vSQL = "";
            vSQL += "Select T.Serie,T.Nro_Ticket,";
            vSQL += tabIngresoConsulta.SelectedIndex == 1 ? "T.Fecha_Emision," : "CB.Fecha_Atencion,";
            vSQL += "T.Digitador+Space(11) Digitador,T.Nro_Historia,T.Id_Paciente,C.Descripcion,X.Orden,T.Anulado";
            vSQL += tabIngresoConsulta.SelectedIndex == 1 ?" ": ",T.Fecha_Emision ";
            vSQL += "From Tickets T Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " + "Inner Join (Select Ape_Paterno+' '+Ape_Materno+', '+Nombres+' ('+SubString(TNCol,2,6)+')' Orden,Id_Personal " + "From Personal Union All Select Descripcion,Id_Tipo From TablaTipo Where Id_Tabla In " + "(Select Id_Tipo From TablaTipo Where Descripcion='VAR_EXTRAS' And Id_Tabla='0'))X On T.CMP=X.Id_Personal ";
            vSQL += tabIngresoConsulta.SelectedIndex == 1 ?"": "Inner Join Cab_Cie10 CB On CB.Nro_Historia=T.Nro_Historia ";
            vSQL += "Where";

            if (tabIngresoConsulta.SelectedIndex == 0)
            {
                if (chkFiltro.Checked || General.vtrls(Especialidad.esp))
                {
                    vSQL += cmbEspecialidad.SelectedIndex != -1 ? (" T.Id_Consultorio Like '" + (((DataRowView)cmbEspecialidad.SelectedItem).Row["Id_Consultorio"]).ToString() + "'") : "";
                    vSQL += vSQL.Contains("Like") && cmbEspecialidad.SelectedIndex != -1 ? " And" : "";
                    vSQL += chkFechaVent.Checked ? (" T.Fecha_Emision Between '" + dtpFechaVent.Value.ToString() + "' And '" + dtpFechaVent.Value.AddDays(1).ToString() + "'") : "";
                    vSQL += vSQL.Contains("Like") && chkFechaVent.Checked ? " And" : "";
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

                            this.lstTickets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstTickets_KeyDown);

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

        private void txtSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                llenarListaTickets();
            }
        }

        private void chkFechaVent_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVent.Enabled = chkFechaVent.Checked;
        }

        bool opened = false;

        private void lstTickets_KeyDown(object sender, KeyEventArgs e)
        {
            ListView lvTemp = (ListView)sender;

            foreach (ListViewItem item in lvTemp.SelectedItems)
            {
                if (!opened)
                {
                    loadTicket(item.SubItems[4].Text);
                    opened = true;
                }
            }
        }

        void loadTicket(string nro_historia)
        {
            string sql1 = "Select Nro_Historia, Fecha_Atencion, CMP, Id_Bus, Turno, Digitador, Fecha_Ingreso, Tsg From Cab_Cie10 Where Nro_Historia = '" + nro_historia + "'";

            SqlCommand cmd1 = new SqlCommand(sql1, Conexion.CNN);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            CabCie10 cabCie10 = null;

            while (dr1.Read())
            {
                cabCie10 = new CabCie10()
                {
                    Nro_Historia = dr1.GetValue(0).ToString(),
                    Fecha_Atencion = DateTime.Parse(dr1.GetValue(1).ToString()),
                    CMP = dr1.GetValue(2).ToString(),
                    Id_Bus = dr1.GetValue(3).ToString(),
                    Turno = dr1.GetValue(4).ToString(),
                    Digitador = dr1.GetValue(5).ToString(),
                    Fecha_Ingreso = dr1.GetValue(6).ToString(),
                    Tsg = dr1.GetValue(7).ToString(),
                };
            }

            //Comprobamos si hay datos
            if (cabCie10 != null)
            {
                if (tabIngresoConsulta.SelectedIndex == 0)
                {
                    MessageBox.Show("Ya fue procesada la historia clinica ...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    string ia = Usuario.id_area;
                    string iu = cabCie10.Digitador;

                    if (iu.Substring(0, 3) == Operativo.id_oper)
                    {
                        string sql2 = "Select Count(*) As C From sysaccusers Where Id_Us = '" + iu + "' And Id_Area= '" + ia + "'";

                        SqlCommand cmd2 = new SqlCommand(sql2, Conexion.CNN);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        int count = 0;
                        while (dr2.Read())
                        {
                            count = int.Parse(dr2.GetValue(0).ToString());
                        }

                        if (count == 0)
                        {
                            MessageBox.Show("Este registro no corresponde a su consultorio", "Ingreso y consulta de atenciones realizadas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }

                    txtNroDoc.Focus();
                }

                pce(true, true);

                /*
                 * thisformset.pce(.T.)
       .txtfecha_atencion.value = TTOD(cab_cie10.fecha_atencion)
       .cmbbus.value = ALLTRIM(cab_cie10.id_bus)
       .cmbturno.value = ALLTRIM(cab_cie10.turno)
       .cmbmedico.value = ALLTRIM(cab_cie10.cmp)
       .txtmedico.value = IIF(.cmbmedico.listindex=0, '', ALLTRIM(medic.especialista))
       .txtdigitador.value = traduser(ALLTRIM(cab_cie10.digitador), '')
       .edten_ac_ini.value = ALLTRIM(cab_cie10.en_ac_ini)
       .edten_ac_cur.value = ALLTRIM(cab_cie10.en_ac_cur)
       .edten_ac_rel.value = ALLTRIM(cab_cie10.en_ac_rel)
       .edtan_per.value = ALLTRIM(cab_cie10.an_per)
       .edtan_fam.value = ALLTRIM(cab_cie10.an_fam)
       .edtan_epi.value = ALLTRIM(cab_cie10.an_epi)
       .edtan_qui.value = ALLTRIM(cab_cie10.an_qui)
       .edtan_otr.value = ALLTRIM(cab_cie10.an_otr)
       .txtex_cl_ps.value = IIF(EMPTY(cab_cie10.ex_cl_ps), 0.00 , VAL(cab_cie10.ex_cl_ps))
       .txtex_cl_tl.value = IIF(EMPTY(cab_cie10.ex_cl_tl), 0.00 , VAL(cab_cie10.ex_cl_tl))
       .txtex_cl_pa.value = ALLTRIM(cab_cie10.ex_cl_pa)
       .txtex_cl_fc.value = IIF(EMPTY(cab_cie10.ex_cl_fc), 0, VAL(cab_cie10.ex_cl_fc))
       .txtex_cl_fr.value = IIF(EMPTY(cab_cie10.ex_cl_fr), 0, VAL(cab_cie10.ex_cl_fr))
       .txtex_cl_tm.value = IIF(EMPTY(cab_cie10.ex_cl_tm), 0, VAL(cab_cie10.ex_cl_tm))
       .edtex_cl_eg.value = ALLTRIM(cab_cie10.ex_cl_eg)
       .edtobservacion.value = ALLTRIM(cab_cie10.observacion)
       .txtfecha_ingreso.value = cab_cie10.fecha_ingreso
       SELECT tmpcie10
       DELETE ALL
       scad = "Select DC.*,CI.Descripcion From Det_Cie10 DC Left Join Cie10 CI On DC.Cie10=CI.Cie10 "+"Where Nro_Historia='"+thisformset.nh+"'"
       ejecuta(nconnect, scad, 'Det_Cie10')
       SELECT det_cie10
       thisformset.dr = RECCOUNT()
       STORE IIF(thisformset.dr>0 .AND. .pfgmodo.activepage=1, .T., .F.) TO .cmdagregar.enabled, .cmdquitar.enabled, .cmdbcie10.enabled
       STORE IIF(thisformset.dr>0, .T., .F.) TO thisformset.frmresultado.cmdimprimir.enabled
       STORE IIF(.pfgmodo.activepage=1, .T., .F.) TO .cmdgrabar.enabled
       GOTO TOP
       DO WHILE  .NOT. EOF()
          SELECT tmpcie10
          APPEND BLANK
          REPLACE tmpcie10.cie10 WITH ALLTRIM(det_cie10.cie10)
          REPLACE tmpcie10.descripcion WITH IIF(ISNULL(det_cie10.descripcion), '', ALLTRIM(det_cie10.descripcion))
          REPLACE tmpcie10.procedimiento WITH ALLTRIM(det_cie10.procedimiento)
          REPLACE tmpcie10.nro_historia WITH ALLTRIM(det_cie10.nro_historia)
          SELECT det_cie10
          IF  .NOT. EOF()
             SKIP
          ENDIF
       ENDDO
       closecursor('Det_Cie10')
       SELECT tmptratmed
       DELETE ALL
       scad = "Select * From tratmed Where nro_reg='"+thisformset.nh+"'"
       ejecuta(nconnect, scad, 'tratmed')
       SELECT tratmed
       thisformset.dr = thisformset.dr+RECCOUNT()
       GOTO TOP
       DO WHILE  .NOT. EOF()
          SELECT tmptratmed
          APPEND BLANK
          REPLACE tmptratmed.id_med WITH ALLTRIM(tratmed.id_med)
          REPLACE tmptratmed.medicamento WITH ALLTRIM(tratmed.medicamento)
          REPLACE tmptratmed.presentacion WITH ALLTRIM(tratmed.presentacion)
          REPLACE tmptratmed.cant WITH VAL(tratmed.cant)
          REPLACE tmptratmed.dosis WITH ALLTRIM(tratmed.dosis)
          REPLACE tmptratmed.dias WITH VAL(tratmed.dias)
          REPLACE tmptratmed.nro_reg WITH ALLTRIM(tratmed.nro_reg)
          SELECT tratmed
          IF  .NOT. EOF()
             SKIP
          ENDIF
       ENDDO
       closecursor('tratmed')
       thisformset.iu = 1
       thisformset.pg = IIF(cab_cie10.id_per<>'', 1, 0)
                 */


            }
            else {

            }
        }


        void pce(bool lci, bool lrc)
        {
            string xcm = cmbMedico.SelectedIndex != -1 && lrc ? cmbMedico.SelectedItem.ToString() : "";
            cmbMedico.SelectedIndex = -1;
            BorrarTablaMedic();
            if (lci && lrc)
            {
                BorrarTablaEspecialista();
                string sql1 = "Select Id_Personal As NCMP, SubString(TNCol,2,7) As CMP, Ape_Paterno + ' ' + Ape_Materno + ', ' + Nombres As Especialista, MB.Id_Bus "+
                    "Into #tmpEspecialidad From Personal P Inner Join MedBus MB On P.Id_Personal = MB.CMP Order By 3";
                Conexion.CMD.CommandText = sql1;
                Conexion.CMD.ExecuteNonQuery();
            }

            string bus = cmbBus.SelectedValue.ToString();

            string sql2 = "Select * Into #tmpMedic From #tmpEspecialidad " + (lci ? "": "Where Id_Bus Like '" + bus + "%'") + " Order By 3";
            Conexion.CMD.CommandText = sql2;
            Conexion.CMD.ExecuteNonQuery();

        }


        private string BorrarTablaTemporal(bool execute = true)
        {
            string vSQL = "IF OBJECT_ID('tempdb.dbo.#tmpEspecialidad', 'U') IS NOT NULL DROP TABLE #tmpEspecialidad;";

            if (execute)
            {
                Conexion.CMD.CommandText = vSQL;
                Conexion.CMD.ExecuteNonQuery();
            }

            return vSQL;
        }

        private string BorrarTablaEspecialista()
        {
            string vSQL = "IF OBJECT_ID('tempdb.dbo.#tmpEspecialidad', 'U') IS NOT NULL DROP TABLE #tmpEspecialidad;";
            Conexion.CMD.CommandText = vSQL;
            Conexion.CMD.ExecuteNonQuery();
            return vSQL;
        }

        private string BorrarTablaMedic()
        {
            string vSQL = "IF OBJECT_ID('tempdb.dbo.#tmpMedic', 'U') IS NOT NULL DROP TABLE #tmpMedic;";
            Conexion.CMD.CommandText = vSQL;
            Conexion.CMD.ExecuteNonQuery();
            return vSQL;
        }
    }

   

}
