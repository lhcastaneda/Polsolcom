namespace Polsolcom.Forms
{
    partial class frmProdMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdMed));
            this.btnCons = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.btnSOP = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.chkHabFecha = new System.Windows.Forms.CheckBox();
            this.chkCMP = new System.Windows.Forms.CheckBox();
            this.chklstMostrar = new System.Windows.Forms.CheckedListBox();
            this.chkConsultorio = new System.Windows.Forms.CheckBox();
            this.chkTurno = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPerPago = new System.Windows.Forms.ComboBox();
            this.periodoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodoPagoDS = new Polsolcom.Dominio.Data.PeriodoPagoDS();
            this.chkColegiaturas = new System.Windows.Forms.CheckBox();
            this.txtProc = new System.Windows.Forms.TextBox();
            this.pnlOpc = new System.Windows.Forms.Panel();
            this.grdColegiatura = new System.Windows.Forms.DataGridView();
            this.gDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            this.rbActual = new System.Windows.Forms.RadioButton();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.cmbCMP = new System.Windows.Forms.ComboBox();
            this.produccionXMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosDS = new Polsolcom.Dominio.Data.MedicosDS();
            this.txtSOP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.especialidadTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter();
            this.produccionXMedicoTableAdapter = new Polsolcom.Dominio.Data.MedicosDSTableAdapters.ProduccionXMedicoTableAdapter();
            this.periodoPagoTableAdapter = new Polsolcom.Dominio.Data.PeriodoPagoDSTableAdapters.PeriodoPagoTableAdapter();
            this.turnoTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TurnoTableAdapter();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.periodoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoPagoDS)).BeginInit();
            this.pnlOpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdColegiatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produccionXMedicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCons
            // 
            this.btnCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCons.Location = new System.Drawing.Point(126, 402);
            this.btnCons.Name = "btnCons";
            this.btnCons.Size = new System.Drawing.Size(76, 52);
            this.btnCons.TabIndex = 0;
            this.btnCons.Text = "&Consultas";
            this.btnCons.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCons.UseVisualStyleBackColor = true;
            this.btnCons.Click += new System.EventHandler(this.btnCons_Click);
            // 
            // btnProc
            // 
            this.btnProc.Enabled = false;
            this.btnProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProc.Location = new System.Drawing.Point(208, 402);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(144, 23);
            this.btnProc.TabIndex = 1;
            this.btnProc.Text = "&Procedimientos";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnSOP
            // 
            this.btnSOP.Enabled = false;
            this.btnSOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOP.Location = new System.Drawing.Point(208, 431);
            this.btnSOP.Name = "btnSOP";
            this.btnSOP.Size = new System.Drawing.Size(144, 23);
            this.btnSOP.TabIndex = 2;
            this.btnSOP.Text = "Sala de &Operaciones";
            this.btnSOP.UseVisualStyleBackColor = true;
            this.btnSOP.Click += new System.EventHandler(this.btnSOP_Click);
            // 
            // btnMarcar
            // 
            this.btnMarcar.Enabled = false;
            this.btnMarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMarcar.Location = new System.Drawing.Point(358, 402);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(77, 52);
            this.btnMarcar.TabIndex = 3;
            this.btnMarcar.Text = "&Marcar";
            this.btnMarcar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // chkHabFecha
            // 
            this.chkHabFecha.AutoSize = true;
            this.chkHabFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabFecha.Location = new System.Drawing.Point(12, 52);
            this.chkHabFecha.Name = "chkHabFecha";
            this.chkHabFecha.Size = new System.Drawing.Size(73, 17);
            this.chkHabFecha.TabIndex = 4;
            this.chkHabFecha.Text = "Habilitar";
            this.chkHabFecha.UseVisualStyleBackColor = true;
            this.chkHabFecha.CheckedChanged += new System.EventHandler(this.chkHabFecha_CheckedChanged);
            // 
            // chkCMP
            // 
            this.chkCMP.AutoSize = true;
            this.chkCMP.Checked = true;
            this.chkCMP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCMP.Location = new System.Drawing.Point(28, 3);
            this.chkCMP.Name = "chkCMP";
            this.chkCMP.Size = new System.Drawing.Size(136, 17);
            this.chkCMP.TabIndex = 5;
            this.chkCMP.Text = "Todos los Especialistas";
            this.chkCMP.UseVisualStyleBackColor = true;
            this.chkCMP.CheckedChanged += new System.EventHandler(this.chkEspecialista_CheckedChanged);
            // 
            // chklstMostrar
            // 
            this.chklstMostrar.BackColor = System.Drawing.SystemColors.Control;
            this.chklstMostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chklstMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstMostrar.FormattingEnabled = true;
            this.chklstMostrar.Items.AddRange(new object[] {
            "Mostrar Horas",
            "Mostrar Pago"});
            this.chklstMostrar.Location = new System.Drawing.Point(12, 407);
            this.chklstMostrar.Name = "chklstMostrar";
            this.chklstMostrar.Size = new System.Drawing.Size(108, 30);
            this.chklstMostrar.TabIndex = 6;
            // 
            // chkConsultorio
            // 
            this.chkConsultorio.AutoSize = true;
            this.chkConsultorio.Checked = true;
            this.chkConsultorio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConsultorio.Location = new System.Drawing.Point(28, 53);
            this.chkConsultorio.Name = "chkConsultorio";
            this.chkConsultorio.Size = new System.Drawing.Size(146, 17);
            this.chkConsultorio.TabIndex = 7;
            this.chkConsultorio.Text = "Todas las Especialidades";
            this.chkConsultorio.UseVisualStyleBackColor = true;
            this.chkConsultorio.CheckedChanged += new System.EventHandler(this.chkConsultorio_CheckedChanged);
            // 
            // chkTurno
            // 
            this.chkTurno.AutoSize = true;
            this.chkTurno.Checked = true;
            this.chkTurno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTurno.Location = new System.Drawing.Point(28, 103);
            this.chkTurno.Name = "chkTurno";
            this.chkTurno.Size = new System.Drawing.Size(108, 17);
            this.chkTurno.TabIndex = 8;
            this.chkTurno.Text = "Todos los Turnos";
            this.chkTurno.UseVisualStyleBackColor = true;
            this.chkTurno.CheckedChanged += new System.EventHandler(this.chkTurno_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sleccione Periodo de Pago";
            // 
            // cmbPerPago
            // 
            this.cmbPerPago.DataSource = this.periodoPagoBindingSource;
            this.cmbPerPago.DisplayMember = "Name_Per";
            this.cmbPerPago.FormattingEnabled = true;
            this.cmbPerPago.Location = new System.Drawing.Point(12, 25);
            this.cmbPerPago.Name = "cmbPerPago";
            this.cmbPerPago.Size = new System.Drawing.Size(423, 21);
            this.cmbPerPago.TabIndex = 11;
            this.cmbPerPago.ValueMember = "Id_Per";
            this.cmbPerPago.SelectionChangeCommitted += new System.EventHandler(this.cmbPerPago_SelectionChangeCommitted);
            // 
            // periodoPagoBindingSource
            // 
            this.periodoPagoBindingSource.DataMember = "PeriodoPago";
            this.periodoPagoBindingSource.DataSource = this.periodoPagoDS;
            // 
            // periodoPagoDS
            // 
            this.periodoPagoDS.DataSetName = "PeriodoPagoDS";
            this.periodoPagoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkColegiaturas
            // 
            this.chkColegiaturas.AutoSize = true;
            this.chkColegiaturas.Checked = true;
            this.chkColegiaturas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColegiaturas.Location = new System.Drawing.Point(28, 153);
            this.chkColegiaturas.Name = "chkColegiaturas";
            this.chkColegiaturas.Size = new System.Drawing.Size(133, 17);
            this.chkColegiaturas.TabIndex = 12;
            this.chkColegiaturas.Text = "Todas las Colegiaturas";
            this.chkColegiaturas.UseVisualStyleBackColor = true;
            this.chkColegiaturas.CheckedChanged += new System.EventHandler(this.chkColegiaturas_CheckedChanged);
            // 
            // txtProc
            // 
            this.txtProc.Location = new System.Drawing.Point(228, 76);
            this.txtProc.Name = "txtProc";
            this.txtProc.Size = new System.Drawing.Size(100, 20);
            this.txtProc.TabIndex = 16;
            // 
            // pnlOpc
            // 
            this.pnlOpc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOpc.Controls.Add(this.grdColegiatura);
            this.pnlOpc.Controls.Add(this.rbNuevo);
            this.pnlOpc.Controls.Add(this.rbActual);
            this.pnlOpc.Controls.Add(this.cmbTurno);
            this.pnlOpc.Controls.Add(this.cmbConsultorio);
            this.pnlOpc.Controls.Add(this.cmbCMP);
            this.pnlOpc.Controls.Add(this.chkCMP);
            this.pnlOpc.Controls.Add(this.chkConsultorio);
            this.pnlOpc.Controls.Add(this.chkTurno);
            this.pnlOpc.Controls.Add(this.chkColegiaturas);
            this.pnlOpc.Location = new System.Drawing.Point(12, 102);
            this.pnlOpc.Name = "pnlOpc";
            this.pnlOpc.Size = new System.Drawing.Size(423, 286);
            this.pnlOpc.TabIndex = 17;
            // 
            // grdColegiatura
            // 
            this.grdColegiatura.AllowUserToAddRows = false;
            this.grdColegiatura.AllowUserToDeleteRows = false;
            this.grdColegiatura.AllowUserToResizeColumns = false;
            this.grdColegiatura.AllowUserToResizeRows = false;
            this.grdColegiatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdColegiatura.ColumnHeadersVisible = false;
            this.grdColegiatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gDescripcion,
            this.gIdTipo});
            this.grdColegiatura.Enabled = false;
            this.grdColegiatura.Location = new System.Drawing.Point(9, 171);
            this.grdColegiatura.Name = "grdColegiatura";
            this.grdColegiatura.ReadOnly = true;
            this.grdColegiatura.RowHeadersVisible = false;
            this.grdColegiatura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdColegiatura.Size = new System.Drawing.Size(300, 104);
            this.grdColegiatura.TabIndex = 22;
            // 
            // gDescripcion
            // 
            this.gDescripcion.HeaderText = "Descripcion";
            this.gDescripcion.Name = "gDescripcion";
            this.gDescripcion.ReadOnly = true;
            this.gDescripcion.Width = 290;
            // 
            // gIdTipo
            // 
            this.gIdTipo.HeaderText = "ID Tipo";
            this.gIdTipo.Name = "gIdTipo";
            this.gIdTipo.ReadOnly = true;
            this.gIdTipo.Visible = false;
            // 
            // rbNuevo
            // 
            this.rbNuevo.AutoSize = true;
            this.rbNuevo.Location = new System.Drawing.Point(314, 215);
            this.rbNuevo.Name = "rbNuevo";
            this.rbNuevo.Size = new System.Drawing.Size(96, 17);
            this.rbNuevo.TabIndex = 21;
            this.rbNuevo.Text = "Reporte nuevo";
            this.rbNuevo.UseVisualStyleBackColor = true;
            // 
            // rbActual
            // 
            this.rbActual.AutoSize = true;
            this.rbActual.Checked = true;
            this.rbActual.Location = new System.Drawing.Point(315, 188);
            this.rbActual.Name = "rbActual";
            this.rbActual.Size = new System.Drawing.Size(95, 17);
            this.rbActual.TabIndex = 20;
            this.rbActual.TabStop = true;
            this.rbActual.Text = "Reporte actual";
            this.rbActual.UseVisualStyleBackColor = true;
            // 
            // cmbTurno
            // 
            this.cmbTurno.DataSource = this.turnoBindingSource;
            this.cmbTurno.DisplayMember = "Descripcion";
            this.cmbTurno.Enabled = false;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(13, 126);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(386, 21);
            this.cmbTurno.TabIndex = 16;
            this.cmbTurno.ValueMember = "Id_Tipo";
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.tablaTipoDS;
            // 
            // tablaTipoDS
            // 
            this.tablaTipoDS.DataSetName = "TablaTipoDS";
            this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.especialidadBindingSource;
            this.cmbConsultorio.DisplayMember = "Descripcion";
            this.cmbConsultorio.Enabled = false;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(13, 76);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(386, 21);
            this.cmbConsultorio.TabIndex = 15;
            this.cmbConsultorio.ValueMember = "Id_Consultorio";
            this.cmbConsultorio.SelectionChangeCommitted += new System.EventHandler(this.cmbConsultorio_SelectionChangeCommitted);
            // 
            // especialidadBindingSource
            // 
            this.especialidadBindingSource.DataMember = "Especialidad";
            this.especialidadBindingSource.DataSource = this.consultoriosDS;
            // 
            // consultoriosDS
            // 
            this.consultoriosDS.DataSetName = "ConsultoriosDS";
            this.consultoriosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCMP
            // 
            this.cmbCMP.DataSource = this.produccionXMedicoBindingSource;
            this.cmbCMP.DisplayMember = "Medico";
            this.cmbCMP.Enabled = false;
            this.cmbCMP.FormattingEnabled = true;
            this.cmbCMP.Location = new System.Drawing.Point(13, 26);
            this.cmbCMP.Name = "cmbCMP";
            this.cmbCMP.Size = new System.Drawing.Size(386, 21);
            this.cmbCMP.TabIndex = 14;
            this.cmbCMP.ValueMember = "Id_Personal";
            this.cmbCMP.SelectionChangeCommitted += new System.EventHandler(this.cmbCMP_SelectionChangeCommitted);
            // 
            // produccionXMedicoBindingSource
            // 
            this.produccionXMedicoBindingSource.DataMember = "ProduccionXMedico";
            this.produccionXMedicoBindingSource.DataSource = this.medicosDS;
            // 
            // medicosDS
            // 
            this.medicosDS.DataSetName = "MedicosDS";
            this.medicosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSOP
            // 
            this.txtSOP.Location = new System.Drawing.Point(335, 76);
            this.txtSOP.Name = "txtSOP";
            this.txtSOP.Size = new System.Drawing.Size(100, 20);
            this.txtSOP.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Proc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "SOP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(379, 407);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // especialidadTableAdapter
            // 
            this.especialidadTableAdapter.ClearBeforeFill = true;
            // 
            // produccionXMedicoTableAdapter
            // 
            this.produccionXMedicoTableAdapter.ClearBeforeFill = true;
            // 
            // periodoPagoTableAdapter
            // 
            this.periodoPagoTableAdapter.ClearBeforeFill = true;
            // 
            // turnoTableAdapter
            // 
            this.turnoTableAdapter.ClearBeforeFill = true;
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Enabled = false;
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(12, 76);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(102, 20);
            this.dtpFecIni.TabIndex = 14;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Enabled = false;
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(120, 76);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(102, 20);
            this.dtpFecFin.TabIndex = 15;
            // 
            // frmProdMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 471);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSOP);
            this.Controls.Add(this.pnlOpc);
            this.Controls.Add(this.txtProc);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.cmbPerPago);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chklstMostrar);
            this.Controls.Add(this.chkHabFecha);
            this.Controls.Add(this.btnSOP);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnCons);
            this.KeyPreview = true;
            this.Name = "frmProdMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Producción por Médico";
            this.Load += new System.EventHandler(this.frmProdMed_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProdMed_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.periodoPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoPagoDS)).EndInit();
            this.pnlOpc.ResumeLayout(false);
            this.pnlOpc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdColegiatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produccionXMedicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCons;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnSOP;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.CheckBox chkHabFecha;
        private System.Windows.Forms.CheckBox chkCMP;
        private System.Windows.Forms.CheckedListBox chklstMostrar;
        private System.Windows.Forms.CheckBox chkConsultorio;
        private System.Windows.Forms.CheckBox chkTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPerPago;
        private System.Windows.Forms.CheckBox chkColegiaturas;
        private System.Windows.Forms.TextBox txtProc;
        private System.Windows.Forms.Panel pnlOpc;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.ComboBox cmbCMP;
        private System.Windows.Forms.TextBox txtSOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbNuevo;
        private System.Windows.Forms.RadioButton rbActual;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
        private Dominio.Data.MedicosDS medicosDS;
        private System.Windows.Forms.BindingSource produccionXMedicoBindingSource;
        private Dominio.Data.MedicosDSTableAdapters.ProduccionXMedicoTableAdapter produccionXMedicoTableAdapter;
        private Dominio.Data.PeriodoPagoDS periodoPagoDS;
        private System.Windows.Forms.BindingSource periodoPagoBindingSource;
        private Dominio.Data.PeriodoPagoDSTableAdapters.PeriodoPagoTableAdapter periodoPagoTableAdapter;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TurnoTableAdapter turnoTableAdapter;
        private System.Windows.Forms.DataGridView grdColegiatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIdTipo;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
    }
}