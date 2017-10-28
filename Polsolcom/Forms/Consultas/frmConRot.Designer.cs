namespace Polsolcom.Forms
{
    partial class frmConRot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.rotacionConsultoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.grdRes = new System.Windows.Forms.DataGridView();
            this.grdCab = new System.Windows.Forms.DataGridView();
            this.grdDet = new System.Windows.Forms.DataGridView();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rotacionConsultoriosTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.RotacionConsultoriosTableAdapter();
            this.rFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rConsultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAlterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rVend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAnul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDocVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNroHistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rotacionConsultoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccione la Especialidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DataSource = this.rotacionConsultoriosBindingSource;
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(307, 21);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(279, 21);
            this.cmbEspecialidad.TabIndex = 4;
            this.cmbEspecialidad.ValueMember = "Id_Consultorio";
            this.cmbEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cmbEspecialidad_SelectionChangeCommitted);
            // 
            // rotacionConsultoriosBindingSource
            // 
            this.rotacionConsultoriosBindingSource.DataMember = "RotacionConsultorios";
            this.rotacionConsultoriosBindingSource.DataSource = this.consultoriosDS;
            // 
            // consultoriosDS
            // 
            this.consultoriosDS.DataSetName = "ConsultoriosDS";
            this.consultoriosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdRes
            // 
            this.grdRes.AllowUserToAddRows = false;
            this.grdRes.AllowUserToDeleteRows = false;
            this.grdRes.AllowUserToOrderColumns = true;
            this.grdRes.AllowUserToResizeColumns = false;
            this.grdRes.AllowUserToResizeRows = false;
            this.grdRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rFecha,
            this.rEspecialidad,
            this.rConsultorio,
            this.rAlterno,
            this.rVend,
            this.rAnul});
            this.grdRes.Location = new System.Drawing.Point(7, 47);
            this.grdRes.MultiSelect = false;
            this.grdRes.Name = "grdRes";
            this.grdRes.ReadOnly = true;
            this.grdRes.RowHeadersVisible = false;
            this.grdRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRes.Size = new System.Drawing.Size(579, 119);
            this.grdRes.TabIndex = 13;
            this.grdRes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRes_CellEnter);
            // 
            // grdCab
            // 
            this.grdCab.AllowUserToAddRows = false;
            this.grdCab.AllowUserToDeleteRows = false;
            this.grdCab.AllowUserToOrderColumns = true;
            this.grdCab.AllowUserToResizeColumns = false;
            this.grdCab.AllowUserToResizeRows = false;
            this.grdCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDocVenta,
            this.cFecha,
            this.cPaciente,
            this.cA,
            this.cCajero,
            this.cNroHistoria});
            this.grdCab.Location = new System.Drawing.Point(4, 173);
            this.grdCab.MultiSelect = false;
            this.grdCab.Name = "grdCab";
            this.grdCab.ReadOnly = true;
            this.grdCab.RowHeadersVisible = false;
            this.grdCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCab.Size = new System.Drawing.Size(582, 127);
            this.grdCab.TabIndex = 14;
            this.grdCab.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCab_CellEnter);
            // 
            // grdDet
            // 
            this.grdDet.AllowUserToAddRows = false;
            this.grdDet.AllowUserToDeleteRows = false;
            this.grdDet.AllowUserToOrderColumns = true;
            this.grdDet.AllowUserToResizeColumns = false;
            this.grdDet.AllowUserToResizeRows = false;
            this.grdDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dProducto,
            this.dCant,
            this.dPrecio,
            this.dTotal});
            this.grdDet.Location = new System.Drawing.Point(5, 307);
            this.grdDet.MultiSelect = false;
            this.grdDet.Name = "grdDet";
            this.grdDet.ReadOnly = true;
            this.grdDet.RowHeadersVisible = false;
            this.grdDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDet.Size = new System.Drawing.Size(580, 121);
            this.grdDet.TabIndex = 15;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Checked = false;
            this.dtpFecFin.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFecFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecFin.Location = new System.Drawing.Point(160, 22);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(142, 20);
            this.dtpFecFin.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(192, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha Final";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Checked = false;
            this.dtpFecIni.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFecIni.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecIni.Location = new System.Drawing.Point(6, 21);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(142, 20);
            this.dtpFecIni.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(31, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha Inicial";
            // 
            // rotacionConsultoriosTableAdapter
            // 
            this.rotacionConsultoriosTableAdapter.ClearBeforeFill = true;
            // 
            // rFecha
            // 
            this.rFecha.HeaderText = "Fecha";
            this.rFecha.Name = "rFecha";
            this.rFecha.ReadOnly = true;
            this.rFecha.Width = 80;
            // 
            // rEspecialidad
            // 
            this.rEspecialidad.HeaderText = "Especialidad";
            this.rEspecialidad.Name = "rEspecialidad";
            this.rEspecialidad.ReadOnly = true;
            this.rEspecialidad.Width = 210;
            // 
            // rConsultorio
            // 
            this.rConsultorio.HeaderText = "Consultorio";
            this.rConsultorio.Name = "rConsultorio";
            this.rConsultorio.ReadOnly = true;
            // 
            // rAlterno
            // 
            this.rAlterno.HeaderText = "Alterno";
            this.rAlterno.Name = "rAlterno";
            this.rAlterno.ReadOnly = true;
            // 
            // rVend
            // 
            this.rVend.HeaderText = "Vend";
            this.rVend.Name = "rVend";
            this.rVend.ReadOnly = true;
            this.rVend.Width = 40;
            // 
            // rAnul
            // 
            this.rAnul.HeaderText = "Anul";
            this.rAnul.Name = "rAnul";
            this.rAnul.ReadOnly = true;
            this.rAnul.Width = 40;
            // 
            // cDocVenta
            // 
            this.cDocVenta.HeaderText = "Doc. Venta";
            this.cDocVenta.Name = "cDocVenta";
            this.cDocVenta.ReadOnly = true;
            this.cDocVenta.Width = 90;
            // 
            // cFecha
            // 
            this.cFecha.HeaderText = "Fecha y Hora";
            this.cFecha.Name = "cFecha";
            this.cFecha.ReadOnly = true;
            this.cFecha.Width = 120;
            // 
            // cPaciente
            // 
            this.cPaciente.HeaderText = "Paciente";
            this.cPaciente.Name = "cPaciente";
            this.cPaciente.ReadOnly = true;
            this.cPaciente.Width = 220;
            // 
            // cA
            // 
            this.cA.HeaderText = "A";
            this.cA.Name = "cA";
            this.cA.ReadOnly = true;
            this.cA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cA.Width = 40;
            // 
            // cCajero
            // 
            this.cCajero.HeaderText = "Cajero";
            this.cCajero.Name = "cCajero";
            this.cCajero.ReadOnly = true;
            // 
            // cNroHistoria
            // 
            this.cNroHistoria.HeaderText = "Nro Historia";
            this.cNroHistoria.Name = "cNroHistoria";
            this.cNroHistoria.ReadOnly = true;
            this.cNroHistoria.Visible = false;
            // 
            // dProducto
            // 
            this.dProducto.HeaderText = "Producto o Servicio";
            this.dProducto.Name = "dProducto";
            this.dProducto.ReadOnly = true;
            this.dProducto.Width = 360;
            // 
            // dCant
            // 
            this.dCant.HeaderText = "Cantidad";
            this.dCant.Name = "dCant";
            this.dCant.ReadOnly = true;
            this.dCant.Width = 70;
            // 
            // dPrecio
            // 
            this.dPrecio.HeaderText = "Precio";
            this.dPrecio.Name = "dPrecio";
            this.dPrecio.ReadOnly = true;
            this.dPrecio.Width = 70;
            // 
            // dTotal
            // 
            this.dTotal.HeaderText = "Total";
            this.dTotal.Name = "dTotal";
            this.dTotal.ReadOnly = true;
            this.dTotal.Width = 70;
            // 
            // frmConRot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 435);
            this.ControlBox = false;
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdDet);
            this.Controls.Add(this.grdCab);
            this.Controls.Add(this.grdRes);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmConRot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Rotaciones Aplicadas";
            this.Load += new System.EventHandler(this.frmConsRotations_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsRotations_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rotacionConsultoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.DataGridView grdRes;
        private System.Windows.Forms.DataGridView grdCab;
        private System.Windows.Forms.DataGridView grdDet;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label2;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private System.Windows.Forms.BindingSource rotacionConsultoriosBindingSource;
        private Dominio.Data.ConsultoriosDSTableAdapters.RotacionConsultoriosTableAdapter rotacionConsultoriosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn rConsultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAlterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn rVend;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAnul;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDocVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPaciente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNroHistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotal;
    }
}