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

namespace Polsolcom.Forms.Mantenimiento
{
    public partial class frmCapEspTur : Form
    {
        //public bool ca = false;
        public int rg = 0;

        List<Dictionary<string, string>> items;

        public frmCapEspTur(string io)
        {
            InitializeComponent();

            if (io.GetType() != typeof(String))
            {
                io = Operativo.id_oper;
            }

            string sql = "Select Descripcion, Cast(Left(Turno,1) As Int) AS C, Cast(SubString(Turno,2,3) As Int) AS M, Cast(SubString(Turno,5,3)As Int) AS T, Cast(SubString(Turno,8,3) As Int) AS N, Cast(SubString(Turno,11,3)As Int) AS A, Id_Consultorio From Consultorios Where Estado<>'2' And Id_Consultorio Like '" + io + "%' Order By 1";

            this.items = General.GetDictionaryList(sql);

            foreach (Dictionary<string, string> item in this.items)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                //
                dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["Descripcion"] });
                //
                DataGridViewCheckBoxCell chkCell = new DataGridViewCheckBoxCell();
                chkCell.Value = (item["C"] == "1");
                dgvr.Cells.Add(chkCell);
                //
                dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["M"], MaxInputLength = 3 });
                //
                dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["T"], MaxInputLength = 3 });
                //
                dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["N"], MaxInputLength = 3 });
                //
                dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = item["A"], MaxInputLength = 3 });
                //
                grdSpeciality.Rows.Add(dgvr);
            }
        }

        public void up()
        {
            string ie = this.items[this.rg]["Id_Consultorio"];
            string tr = this.items[this.rg]["C"];
            string tm = this.items[this.rg]["M"];
            string tt = this.items[this.rg]["T"];
            string tn = this.items[this.rg]["N"];
            string ta = this.items[this.rg]["A"];
            tr = tr + (tm.Length == 1 ? "00" + tm : (tm.Length == 2 ? "0" + tm : tm));
            tr = tr + (tt.Length == 1 ? "00" + tt : (tt.Length == 2 ? "0" + tt : tt));
            tr = tr + (tn.Length == 1 ? "00" + tn : (tn.Length == 2 ? "0" + tn : tn));
            tr = tr + (ta.Length == 1 ? "00" + ta : (ta.Length == 2 ? "0" + ta : ta));
            tr = (Int64.Parse(tr) <= 1 ? "" : tr);

            if (tr.Length > 0 && Int64.Parse(tr.Substring(1, 12)) == 0 && tr.Substring(0, 1) == "1")
            {
                MessageBox.Show("La marca de continuo requiere cantidades por turno ... ", "Advertencia");
                this.items[this.rg]["C"] = "0";
                grdSpeciality.CurrentCell.Value = false;
                //grdSpeciality.Rows[this.rg].Cells[1].Value = false;
                return;
            }
            else
            {
                string sql = "Update Consultorios Set Turno = '" + tr + "' Where LTrim(RTrim(Id_Consultorio)) = '" + ie + "'";
                Conexion.ExecuteNonQuery(sql);
            }
        }

        private void grdSpeciality_SelectionChanged(object sender, EventArgs e)
        {

            //if (!this.ca)
            //{
            //    this.rg = 0;
            //}
        }

        private void frmCapEspTur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void grdSpeciality_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.rg = grdSpeciality.CurrentCell.RowIndex;
            //this.ca = false;
        }

        private void grdSpeciality_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSpeciality.CurrentCell.Value == null || grdSpeciality.CurrentCell.Value.ToString() == "")
            {
                grdSpeciality.CurrentCell.Value = "";
            }

            switch (grdSpeciality.CurrentCell.ColumnIndex)
            {
                case 0:
                    break;
                case 1:
                    this.items[this.rg]["C"] = ((bool)grdSpeciality.CurrentCell.Value) ? "1" : "0";
                    this.up();
                    break;
                case 2:
                    this.items[this.rg]["M"] = grdSpeciality.CurrentCell.Value.ToString();
                    this.up();
                    break;
                case 3:
                    this.items[this.rg]["T"] = grdSpeciality.CurrentCell.Value.ToString();
                    this.up();
                    break;
                case 4:
                    this.items[this.rg]["N"] = grdSpeciality.CurrentCell.Value.ToString();
                    this.up();
                    break;
                case 5:
                    this.items[this.rg]["A"] = grdSpeciality.CurrentCell.Value.ToString();
                    this.up();
                    break;
            }

            //this.ca = true;
        }
    }
}
