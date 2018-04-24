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

namespace Polsolcom.Forms
{
    public partial class frmNewBus : Form
    {
        string ie = "";
        string mu = "";
        Dictionary<string, string> bus = null;

        public frmNewBus(string ie, string mu, Dictionary<string, string> bus, string descripcion)
        {
            InitializeComponent();
            this.ie = ie;
            this.mu = mu;
            this.bus = bus;
            this.Text = descripcion;

        }

        private void frmNewBus_Load(object sender, EventArgs ev)
        {
            // TODO: This line of code loads data into the 'tablaTipoDS.EstadoRegistro' table. You can move, or remove it, as needed.
            this.estadoRegistroTableAdapter.Fill(this.tablaTipoDS.EstadoRegistro);
            // TODO: This line of code loads data into the 'institucionesDS.Institucion' table. You can move, or remove it, as needed.
            this.institucionTableAdapter.Fill(this.institucionesDS.Institucion);
            // TODO: This line of code loads data into the 'modalidadDS.Modalidad' table. You can move, or remove it, as needed.
            this.modalidadTableAdapter.Fill(this.modalidadDS.Modalidad);
            // TODO: This line of code loads data into the 'rotationDS.Rotation' table. You can move, or remove it, as needed.
            this.rotationTableAdapter.Fill(this.rotationDS.Rotation);

            if (this.bus != null)
            {
                txtCreation.Text = this.bus["Us_Ing"] + " - " + this.bus["Fec_Ing"];
                txtLastUpDate.Text = this.bus["Us_Mod"] + " - " + this.bus["Fec_Mod"];
                txtBus.Text = this.bus["Bus"];
                txtAlterno.Text = this.bus["Alterno"];
                cmbEstado.SelectedValue = this.bus["Estado"];
                cmbTipo.SelectedValue = this.bus["TBus"];
                cmbRotacion.SelectedValue = this.bus["Turno"].Substring(0, 1);
                cmbEmpresa.SelectedValue = this.bus["Id_Emp"];
            }
            else
            {
                cmbEmpresa.SelectedIndex = -1;
                cmbTipo.SelectedIndex = -1;
                cmbRotacion.SelectedIndex = -1;
                cmbEstado.SelectedValue = "1";
            }

            txtBus.Focus();
            this.Refresh();
        }

        public int vu()
        {
            int o = 0;

            if (this.mu.Length > 0)
            {
                string sql = "Select B.Bus,B.TBus,B.Id_Emp,Count(*)As C From Buses As B Inner Join Cab_Cie10 As CB On LTrim(RTrim(B.Id_Bus))=LTrim(RTrim(CB.Id_Bus)) Where LTrim(RTrim(B.Id_Bus))='" + this.mu + "' And CB.Id_Per<>'' Group By B.Bus,B.TBus,B.Id_Emp";
                List<Dictionary<string, string>> vnc = General.GetDictionaryList(sql);

                if (vnc.Count > 0)
                {
                    if (txtBus.Text != vnc[0]["Bus"])
                    {
                        txtBus.Text = vnc[0]["Bus"];
                        o++;
                    }

                    if (cmbTipo.SelectedValue.ToString() != vnc[0]["TBus"])
                    {
                        cmbTipo.SelectedValue = vnc[0]["TBus"];
                        o++;
                    }

                    if (cmbEmpresa.SelectedValue.ToString() != vnc[0]["Id_Emp"])
                    {
                        cmbEmpresa.SelectedValue = vnc[0]["Id_Emp"];
                        o++;
                    }
                }

                if (o > 0)
                {
                    MessageBox.Show("Nombre, Tipo o Razón Social no pueden cambiarse ...\nexisten pagos realizados para el consultorio " + txtBus.Text + ".", "Advertencia");
                }
            }
            return o;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (this.vu() == 0)
            {
                string ic = this.mu;
                string nc = txtBus.Text;
                string na = txtAlterno.Text;
                string st = cmbEstado.SelectedValue.ToString();
                string tp = cmbTipo.SelectedValue.ToString();
                string rt = (st != "1" || cmbRotacion.SelectedValue.ToString().Length == 0 ? "" : cmbRotacion.SelectedValue.ToString() + (this.mu.Length == 0 ? "0" : ""));
                string ne = cmbEmpresa.SelectedValue.ToString();
                string iu = Usuario.id_us;
                string io = Operativo.id_oper;

                if (this.ie.Length == 0 || nc.Length == 0 || st.Length == 0 || tp.Length == 0 || (ne.Length == 0 && tp == "T"))
                {
                    MessageBox.Show("Faltan datos para grabar el registro ...", "Aviso al usuario");
                    return;
                }

                string sql = "";

                if (this.mu.Length == 0)
                {
                    sql = "Declare @res Varchar(9) Exec MaxValor 'Id_Bus', 'Buses', '4', @ret = @res Output Exec GenUniCod @res,@ret = @res Output Set @res = '"+ io + "' + @res Insert Into Buses Values(@res, '" + this.ie + "', '" + nc + "', '" + na + "', '" + rt + "', '" + st + "', '" + tp + "', '" + ne + "', GetDate(), '" + iu + "', GetDate(), '" + iu + "')";
                }
                else
                {
                    sql = "Update Buses Set Bus = '" + nc + "', Alterno = '" + na + "',Estado = '" + st + "', TBus = '" + tp + "', Id_Emp = '" + ne + "', Fec_Mod = GetDate(), Us_Mod = '" + iu + "', Turno = '" + rt + "'" + (rt.Length > 0 ? "+ SubString(Turno,2,3)" : "") + " Where LTrim(RTrim(Id_Bus)) = '" + ic + "'";
                }

                Conexion.ExecuteNonQuery(sql);
                this.Close();
            
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAlterno_Leave(object sender, EventArgs e)
        {
            if (txtAlterno.Text.Length > 0)
            {
                string ic = this.mu;
                string na = txtAlterno.Text;

                string sql = "Select Count(*) As C From Buses Where LTrim(RTrim(Id_Esp)) = '" + this.ie + "' And LTrim(RTrim(Alterno)) = '" + na + "'";
                sql += (this.mu.Length == 0 ? "" : " And LTrim(RTrim(Id_Bus)) <> '" + ic + "')");

                int c = Conexion.ExecuteScalar<int>(sql);

                if (c > 0)
                {
                    MessageBox.Show("Nombre alterno ya existe para esta Especialidad ...", "Advertencia");
                    return;
                }
            }
        }

        private void txtBus_Leave(object sender, EventArgs e)
        {
            if (txtBus.Text.Length > 0) {
                string ic = this.mu;
                string nb = txtBus.Text;

                string sql = "Select Count(*) As C From Buses Where LTrim(RTrim(Id_Esp)) = '" + this.ie + "' And LTrim(RTrim(Bus)) = '" + nb + "'";
                sql += (this.mu.Length == 0? "": " And LTrim(RTrim(Id_Bus)) <> '" + ic + "'");

                int c = Conexion.ExecuteScalar<int>(sql);

                if (c > 0)
                {
                    MessageBox.Show("Nombre de Consultorio (Bus) ya existe para esta Especialidad ...", "Advertencia");
                    return;
                }
            }
        }

        private void frmNewBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
