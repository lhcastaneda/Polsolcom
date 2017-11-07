using Polsolcom.Dominio.Helpers;
using Polsolcom.Forms.Mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polsolcom.Forms.Consultas
{
    public partial class frmVenxPac : Form
    {
        string sql = "";
        string id_paciente = "";

        public frmVenxPac()
        {
            InitializeComponent();
        }

        int preimpexp(string idpac)
        {
            string xidp = idpac;

            if (rbVentas.Checked)
            {
                this.sql = "Select T.Nro_Historia,T.Serie+'-'+T.Nro_Ticket Ticket,C.Descripcion Consultorio,P.Descripcion " +
"Producto,D.Monto Precio,D.Cantidad,(D.Monto*D.Cantidad)Total,T.Fecha_Emision,T.Id_Paciente," +
"T.Anulado,O.Descripcion Operativo " +
"From Tickets T Inner Join Detalles D On T.Nro_Historia=D.Nro_Historia Inner Join Productos P " +
"On D.Id_Producto=P.Id_Producto Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " +
"Inner Join Operativo O On Left(T.Nro_Historia,3)=O.Id_Oper " +
"Where T.ForPago='' And T.Anulado='' And T.Id_Paciente='" + xidp + "' " +
"Order By T.Fecha_Emision,T.Nro_Historia,T.Nro_Ticket";
            }
            else
            {
                this.sql = "Select T.Nro_Historia,T.Serie+'-'+T.Nro_Ticket Ticket,C.Descripcion Consultorio,T.Fecha_Emision," +
"T.Id_Paciente,T.Anulado,CB.Fecha_Atencion,(P.Ape_Paterno+' '+P.Ape_Materno+', '+P.Nombres)Medico," +
"DC.Cie10,CI.Descripcion Diagnostico,DC.Procedimiento,O.Descripcion Operativo " +
"From Tickets T Inner Join Cab_Cie10 CB On T.Nro_Historia=CB.Nro_Historia Left Join Det_Cie10 DC On " +
"CB.Nro_Historia=DC.Nro_Historia Left Join Cie10 CI On DC.Cie10=CI.Cie10 Inner Join Personal P On " +
"CB.CMP=P.Id_Personal Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " +
"Inner Join Operativo O On Left(T.Nro_Historia,3)=O.Id_Oper " +
"Where T.ForPago='' And T.Anulado='' And T.Id_Paciente='" + xidp + "' And CB.Fecha_Atencion Is Not Null " +
"Order By T.Fecha_Emision,T.Nro_Historia,T.Nro_Ticket";
            }

            return General.GetDictionaryList(this.sql).Count;

        }

        private void frmVenxPac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSalir_Click(btnSalir, new EventArgs());
            }
        }

        private void grdHead_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = grdHead.CurrentCell.RowIndex;
            Dictionary<string, string> item = General.GetSelectedDictionary(grdHead);

            string xhis = item["Nro_Historia"];
            string sqlTicket = "Select P.Descripcion As Producto,D.Cantidad,D.Monto As Precio,(D.Monto*D.Cantidad)As Total " +
"From Detalles D Inner Join Productos P On D.Id_Producto=P.Id_Producto " +
"Where D.Nro_Historia='" + xhis + "'";
            List<Dictionary<string, string>> dbdeta = General.GetDictionaryList(sqlTicket);
            General.Fill(grdDetaTicket, dbdeta);

            string sqlHis = "Select D.Cie10,LTrim(Rtrim(Descripcion))As NomCie,Procedimiento From Det_Cie10 D Left Join Cie10 C " +
"On D.Cie10=C.Cie10 Where D.Nro_Historia='" + xhis + "'";
            List<Dictionary<string, string>> dbDetHis = General.GetDictionaryList(sqlHis);
            General.Fill(grdDetaHisto, dbDetHis);
        }

        private void grdHead_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (txtPaciente.Text.Length == 0)
            {
                return;
            }

            if (this.preimpexp(this.id_paciente) == 0)
            {
                MessageBox.Show("No se hallaron registros ... ", "Aviso al usuario");
                return;
            }

            frmExport frmExport = new frmExport(this.sql, this.Text, "Reporte_" + (rbVentas.Checked? "Ventas_": "Atenciones_") + "Paciente");
            frmExport.ShowDialog(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /*
             *  WITH thisform
    IF EMPTY(.txtpaciente.value)
       RETURN
    ENDIF
    WAIT WINDOW NOWAIT 'Procesando la informacion solicitada ... un momento por favor ...'
    .prepimpexp(ALLTRIM(.id_paciente))
    SELECT COUNT(nro_historia) AS tottic FROM dbRep1 GROUP BY nro_historia INTO CURSOR Conteo NOWAIT NOCONSOLE
    SELECT conteo
    ntotalrec = RECCOUNT()
    USE IN conteo
    SELECT dbrep1
    IF .optgrupo.value=1
       REPORT FORM rptVenxPac.frx PREVIEW
    ELSE
       REPORT FORM rptAtenxPac.frx PREVIEW
    ENDIF
 ENDWITH
             */
        }

        private void btnBPac_Click(object sender, EventArgs e)
        {
            this.id_paciente = "";

            frmSeekPac frmSeekPac = new frmSeekPac(0);
            frmSeekPac.FormClosed += new FormClosedEventHandler(frmSeekPac_FormClosed);
            frmSeekPac.Show();
            this.Hide();
        }

        private void frmSeekPac_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dictionary<string, string> xPac = ((frmSeekPac)sender).xPac;

            if (xPac != null)
            {
                this.id_paciente = xPac["Id_Paciente"];
                txtPaciente.Text = xPac["Ape_Paterno"] + " " + xPac["Ape_Materno"] + " " + xPac["Nombre"];
                txtDireccion.Text = xPac["Direccion"] + " - " + xPac["Distrito"];
                txtTelefono.Text = xPac["Telefono"];
                txtDni.Text = xPac["DNI"];
                txtEdad.Text = xPac["Edad"];
                btnConsulta_Click(btnConsulta, new EventArgs());
            }

            this.Show();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (this.id_paciente.Length == 0)
            {
                return;
            }

            string xip = this.id_paciente;

            string sql = "Select O.Descripcion Operativo,T.Serie+'-'+T.Nro_Ticket Ticket,T.Fecha_Emision,Count(T.Nro_Ticket)Nro," +
"Sum(D.Monto*D.Cantidad)Total,CB.Fecha_Atencion,C.Descripcion Consultorio,SubString(P.TNCol,2,7)CMP," +
"(P.Ape_Paterno+' '+P.Ape_Materno+', '+P.Nombres)Medico,B.Bus,T.Anulado, CASE WHEN LEN(T.Anulado) > 0 THEN 1 ELSE 0 END As BAnulado,T.Nro_Historia,D.Pagado," +
"T.Id_Paciente,Sum(D.Cantidad)Cant " +
"From Tickets T Left Join Cab_Cie10 CB On T.Nro_Historia=CB.Nro_Historia Inner Join Detalles D " +
"On T.Nro_Historia=D.Nro_Historia Inner Join Consultorios C On T.Id_Consultorio=C.Id_Consultorio " +
"Left Join Personal P On CB.CMP=P.Id_Personal Left Join Buses B On CB.Id_Bus=B.Id_Bus " +
"Inner Join Operativo O On Left(T.Nro_Historia,3)=O.Id_Oper " +
"Where T.ForPago='' And T.Id_Paciente='" + xip + "' " +
"Group By O.Descripcion,T.Serie,T.Nro_Ticket,T.Fecha_Emision,CB.Fecha_Atencion,C.Descripcion," +
"SubString(P.TNCol,2,7),P.Ape_Paterno,P.Ape_Materno,P.Nombres,B.Bus,T.Anulado,T.Id_Paciente," +
"T.Nro_Historia,D.Pagado " +
"Order By T.Fecha_Emision,T.Nro_Ticket,C.Descripcion,B.Bus,SubString(P.TNCol,2,7),T.Nro_Historia";

            List<Dictionary<string, string>> consulta = General.GetDictionaryList(sql);

            if (consulta.Count > 0)
            {
                General.Fill(grdHead, consulta, new string[] { "BAnulado" });

                txtItem.Text = consulta.Where(x => x["Anulado"] == "").Sum(x => int.Parse(x["Nro"])).ToString();
                txtTot.Text = consulta.Where(x => x["Anulado"] == "").Sum(x => decimal.Parse(x["Total"])).ToString();
                txtProd.Text = consulta.Where(x => x["Anulado"] == "").Sum(x => int.Parse(x["Cant"])).ToString();

                txtTkVen.Text = consulta.Where(x => x["Anulado"] == "").Count().ToString();
                txtTkAnul.Text = consulta.Where(x => x["Anulado"] != "").Count().ToString();
                txtAten.Text = consulta.Where(x => x["Anulado"].Length > 0).Count().ToString();

                grdHead.Focus();
            }
            else
            {
                MessageBox.Show("La consulta no genero ningun registro ... ", "Aviso al usuario");
            }
        }
    }
}
