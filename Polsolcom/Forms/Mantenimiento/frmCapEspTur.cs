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
        public bool ca = false;
        public int rg = 0;

        List<Dictionary<string, string>> items;
        Dictionary<string, string> item;

        public frmCapEspTur(string io)
        {
            InitializeComponent();

            if (io == "C")
            {
                io = Operativo.id_oper;

                string sql = "Select Descripcion, Cast(Left(Turno,1) As Int) AS C, Cast(SubString(Turno,2,3) As Int) AS M, Cast(SubString(Turno,5,3)As Int) AS T, Cast(SubString(Turno,8,3) As Int) AS N, Cast(SubString(Turno,11,3)As Int) AS A, Id_Consultorio From Consultorios Where Estado<>'2' And Id_Consultorio Like '" + io + "%' Order By 1";

                this.items = General.GetDictionaryList(sql);

                foreach (Dictionary<string, string> _item in this.items)
                {
                    DataGridViewRow dgvr = new DataGridViewRow();
                    //
                    dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = _item["Descripcion"] });
                    //
                    DataGridViewCheckBoxCell col2 = new DataGridViewCheckBoxCell();
                    col2.Value = (_item["C"] == "1");
                    //
                    dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = _item["M"] });
                    //
                    dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = _item["T"] });
                    //
                    dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = _item["N"] });
                    //
                    dgvr.Cells.Add(new DataGridViewTextBoxCell { Value = _item["A"] });
                    //
                    grdSpeciality.Rows.Add(dgvr);
                }

            }

        }

        private void frmCapEspTur_Load(object sender, EventArgs e)
        {

        }

        public void up()
        {
            string ie = item["Id_Consultorio"];
            string tr = item["C"];
            string tm = item["M"];
            string tt = item["T"];
            string tn = item["N"];
            string ta = item["A"];
            tr = tr + (tm.Length == 1 ? "00" + tm : (tm.Length == 2 ? "0" + tm : tm));
            tr = tr + (tt.Length == 1 ? "00" + tt : (tt.Length == 2 ? "0" + tt : tt));
            tr = tr + (tn.Length == 1 ? "00" + tn : (tn.Length == 2 ? "0" + tn : tn));
            tr = tr + (ta.Length == 1 ? "00" + ta : (ta.Length == 2 ? "0" + ta : ta));
            tr = (int.Parse(tr) <= 1 ? "" : tr);

            if (int.Parse(tr.Substring(2, 12)) == 0 && tr.Substring(0, 1) == "1")
            {
                MessageBox.Show("La marca de continuo requiere cantidades por turno ... ", "Advertencia");
                return;
            }
            else
            {
                string sql = "Update Consultorios Set Turno=?tr Where LTrim(RTrim(Id_Consultorio)) = '" + ie + "'";
                Conexion.ExecuteNonQuery(sql);
            }
        }

        private void grdSpeciality_SelectionChanged(object sender, EventArgs e)
        {
            if (!this.ca)
            {
                this.rg = 0;
            }
        }

        private void frmCapEspTur_Validated(object sender, EventArgs e)
        {
        }

        //VALID
        private void grdSpeciality_Leave(object sender, EventArgs e)
        {
            switch (grdSpeciality.CurrentCell.ColumnIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    this.up();
                    break;
                case 3:
                    this.up();
                    break;
                case 4:
                    this.up();
                    break;
                case 5:
                    this.up();
                    break;
            }

            this.ca = true;

        }

        //WHEN
        private void grdSpeciality_Enter(object sender, EventArgs e)
        {
            switch (grdSpeciality.CurrentCell.ColumnIndex)
            {
                case 0:
                    this.rg = grdSpeciality.CurrentCell.RowIndex;
                    break;
                case 1:
                    this.rg = grdSpeciality.CurrentCell.RowIndex;
                    break;
                case 2:
                    this.rg = grdSpeciality.CurrentCell.RowIndex;
                    break;
                case 3:
                    this.rg = grdSpeciality.CurrentCell.RowIndex;
                    break;
                case 4:
                    this.rg = grdSpeciality.CurrentCell.RowIndex;
                    break;
                case 5:
                    this.rg = grdSpeciality.CurrentCell.RowIndex;
                    break;

            }

            this.ca = false;

        }

        private void frmCapEspTur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
