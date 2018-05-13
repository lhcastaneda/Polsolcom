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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
			this.rotacionConsultoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
			this.grdRes = new System.Windows.Forms.DataGridView();
			this.rFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rConsultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rAlterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rVend = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rAnul = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdCab = new System.Windows.Forms.DataGridView();
			this.cDocVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.cCajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cNroHistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdDet = new System.Windows.Forms.DataGridView();
			this.dProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.rotacionConsultoriosTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.RotacionConsultoriosTableAdapter();
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
			this.label4.TabIndex = 4;
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
			this.cmbEspecialidad.TabIndex = 3;
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdRes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grdRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rFecha,
            this.rEspecialidad,
            this.rConsultorio,
            this.rAlterno,
            this.rVend,
            this.rAnul});
			this.grdRes.Location = new System.Drawing.Point(6, 47);
			this.grdRes.MultiSelect = false;
			this.grdRes.Name = "grdRes";
			this.grdRes.ReadOnly = true;
			this.grdRes.RowHeadersVisible = false;
			this.grdRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdRes.Size = new System.Drawing.Size(582, 127);
			this.grdRes.TabIndex = 4;
			this.grdRes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRes_CellEnter);
			// 
			// rFecha
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.rFecha.DefaultCellStyle = dataGridViewCellStyle2;
			this.rFecha.HeaderText = "Fecha";
			this.rFecha.Name = "rFecha";
			this.rFecha.ReadOnly = true;
			this.rFecha.Width = 75;
			// 
			// rEspecialidad
			// 
			this.rEspecialidad.HeaderText = "Especialidad";
			this.rEspecialidad.Name = "rEspecialidad";
			this.rEspecialidad.ReadOnly = true;
			this.rEspecialidad.Width = 200;
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
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.rVend.DefaultCellStyle = dataGridViewCellStyle3;
			this.rVend.HeaderText = "Vend";
			this.rVend.Name = "rVend";
			this.rVend.ReadOnly = true;
			this.rVend.Width = 40;
			// 
			// rAnul
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.rAnul.DefaultCellStyle = dataGridViewCellStyle4;
			this.rAnul.HeaderText = "Anul";
			this.rAnul.Name = "rAnul";
			this.rAnul.ReadOnly = true;
			this.rAnul.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.rAnul.Width = 40;
			// 
			// grdCab
			// 
			this.grdCab.AllowUserToAddRows = false;
			this.grdCab.AllowUserToDeleteRows = false;
			this.grdCab.AllowUserToOrderColumns = true;
			this.grdCab.AllowUserToResizeColumns = false;
			this.grdCab.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdCab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.grdCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdCab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDocVenta,
            this.cFecha,
            this.cPaciente,
            this.cA,
            this.cCajero,
            this.cNroHistoria});
			this.grdCab.Location = new System.Drawing.Point(6, 177);
			this.grdCab.MultiSelect = false;
			this.grdCab.Name = "grdCab";
			this.grdCab.ReadOnly = true;
			this.grdCab.RowHeadersVisible = false;
			this.grdCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdCab.Size = new System.Drawing.Size(582, 127);
			this.grdCab.TabIndex = 5;
			this.grdCab.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCab_CellEnter);
			// 
			// cDocVenta
			// 
			this.cDocVenta.HeaderText = "Doc. Venta";
			this.cDocVenta.Name = "cDocVenta";
			this.cDocVenta.ReadOnly = true;
			this.cDocVenta.Width = 85;
			// 
			// cFecha
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.cFecha.DefaultCellStyle = dataGridViewCellStyle6;
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
			this.cA.HeaderText = "Anul";
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
			this.cCajero.Width = 90;
			// 
			// cNroHistoria
			// 
			this.cNroHistoria.HeaderText = "Nro Historia";
			this.cNroHistoria.Name = "cNroHistoria";
			this.cNroHistoria.ReadOnly = true;
			this.cNroHistoria.Visible = false;
			// 
			// grdDet
			// 
			this.grdDet.AllowUserToAddRows = false;
			this.grdDet.AllowUserToDeleteRows = false;
			this.grdDet.AllowUserToOrderColumns = true;
			this.grdDet.AllowUserToResizeColumns = false;
			this.grdDet.AllowUserToResizeRows = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdDet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.grdDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dProducto,
            this.dCant,
            this.dPrecio,
            this.dTotal});
			this.grdDet.Location = new System.Drawing.Point(6, 307);
			this.grdDet.MultiSelect = false;
			this.grdDet.Name = "grdDet";
			this.grdDet.ReadOnly = true;
			this.grdDet.RowHeadersVisible = false;
			this.grdDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDet.Size = new System.Drawing.Size(582, 127);
			this.grdDet.TabIndex = 6;
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
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dCant.DefaultCellStyle = dataGridViewCellStyle8;
			this.dCant.HeaderText = "Cantidad";
			this.dCant.Name = "dCant";
			this.dCant.ReadOnly = true;
			this.dCant.Width = 50;
			// 
			// dPrecio
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dPrecio.DefaultCellStyle = dataGridViewCellStyle9;
			this.dPrecio.HeaderText = "Precio";
			this.dPrecio.Name = "dPrecio";
			this.dPrecio.ReadOnly = true;
			this.dPrecio.Width = 70;
			// 
			// dTotal
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dTotal.DefaultCellStyle = dataGridViewCellStyle10;
			this.dTotal.HeaderText = "Total";
			this.dTotal.Name = "dTotal";
			this.dTotal.ReadOnly = true;
			this.dTotal.Width = 70;
			// 
			// dtpFecFin
			// 
			this.dtpFecFin.Checked = false;
			this.dtpFecFin.CustomFormat = "dd/MM/yyyy";
			this.dtpFecFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFecFin.Location = new System.Drawing.Point(160, 22);
			this.dtpFecFin.Name = "dtpFecFin";
			this.dtpFecFin.Size = new System.Drawing.Size(97, 20);
			this.dtpFecFin.TabIndex = 2;
			this.dtpFecFin.ValueChanged += new System.EventHandler(this.dtpFecFin_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(192, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Fecha Final";
			// 
			// dtpFecIni
			// 
			this.dtpFecIni.Checked = false;
			this.dtpFecIni.CustomFormat = "dd/MM/yyyy";
			this.dtpFecIni.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFecIni.Location = new System.Drawing.Point(6, 21);
			this.dtpFecIni.Name = "dtpFecIni";
			this.dtpFecIni.Size = new System.Drawing.Size(97, 20);
			this.dtpFecIni.TabIndex = 1;
			this.dtpFecIni.ValueChanged += new System.EventHandler(this.dtpFecIni_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(31, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Fecha Inicial";
			// 
			// rotacionConsultoriosTableAdapter
			// 
			this.rotacionConsultoriosTableAdapter.ClearBeforeFill = true;
			// 
			// frmConRot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 439);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn rFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn rEspecialidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn rConsultorio;
		private System.Windows.Forms.DataGridViewTextBoxColumn rAlterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn rVend;
		private System.Windows.Forms.DataGridViewTextBoxColumn rAnul;
	}
}