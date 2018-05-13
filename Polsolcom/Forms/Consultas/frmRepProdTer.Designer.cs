namespace Polsolcom.Forms
{
    partial class frmRepProdTer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepProdTer));
			this.periodoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.periodoPagoDS = new Polsolcom.Dominio.Data.PeriodoPagoDS();
			this.cmbConsultorio = new System.Windows.Forms.ComboBox();
			this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
			this.cmbBus = new System.Windows.Forms.ComboBox();
			this.busesByModeValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.busesDS = new Polsolcom.Dominio.Data.BusesDS();
			this.cmbCMP = new System.Windows.Forms.ComboBox();
			this.especialistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.medicosDS = new Polsolcom.Dominio.Data.MedicosDS();
			this.cmbTPEsp = new System.Windows.Forms.ComboBox();
			this.tipoSubProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
			this.total = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnEjecutar = new System.Windows.Forms.Button();
			this.btnExportar = new System.Windows.Forms.Button();
			this.btnMarcar = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.especialidadTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter();
			this.especialistasTableAdapter = new Polsolcom.Dominio.Data.MedicosDSTableAdapters.EspecialistasTableAdapter();
			this.periodoPagoTableAdapter = new Polsolcom.Dominio.Data.PeriodoPagoDSTableAdapters.PeriodoPagoTableAdapter();
			this.grdListado = new System.Windows.Forms.ListView();
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.grdDetalle = new System.Windows.Forms.ListView();
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.turnoTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TurnoTableAdapter();
			this.busesByModeValueTableAdapter = new Polsolcom.Dominio.Data.BusesDSTableAdapters.BusesByModeValueTableAdapter();
			this.tipoSubProductoTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TipoSubProductoTableAdapter();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbTodos = new System.Windows.Forms.RadioButton();
			this.rbPagados = new System.Windows.Forms.RadioButton();
			this.rbNoProcesados = new System.Windows.Forms.RadioButton();
			this.rbProcesados = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkHabFecha = new System.Windows.Forms.CheckBox();
			this.grdFechas = new System.Windows.Forms.GroupBox();
			this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.lstFechas = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmbPerPago = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rbFechas = new System.Windows.Forms.RadioButton();
			this.rbProductos = new System.Windows.Forms.RadioButton();
			this.rbRecibos = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.grdResumen = new System.Windows.Forms.ListView();
			this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtTickets = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.periodoPagoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.periodoPagoDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.busesByModeValueBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.busesDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.especialistasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.medicosDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoSubProductoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.grdFechas.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
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
			// cmbConsultorio
			// 
			this.cmbConsultorio.DataSource = this.especialidadBindingSource;
			this.cmbConsultorio.DisplayMember = "Descripcion";
			this.cmbConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbConsultorio.FormattingEnabled = true;
			this.cmbConsultorio.Location = new System.Drawing.Point(9, 327);
			this.cmbConsultorio.Name = "cmbConsultorio";
			this.cmbConsultorio.Size = new System.Drawing.Size(235, 21);
			this.cmbConsultorio.TabIndex = 10;
			this.cmbConsultorio.ValueMember = "Id_Consultorio";
			this.cmbConsultorio.SelectedIndexChanged += new System.EventHandler(this.cmbConsultorio_SelectedIndexChanged);
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
			// cmbBus
			// 
			this.cmbBus.DataSource = this.busesByModeValueBindingSource;
			this.cmbBus.DisplayMember = "Bus";
			this.cmbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBus.Location = new System.Drawing.Point(9, 366);
			this.cmbBus.Name = "cmbBus";
			this.cmbBus.Size = new System.Drawing.Size(234, 21);
			this.cmbBus.TabIndex = 11;
			this.cmbBus.ValueMember = "Id_Bus";
			this.cmbBus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBus_KeyDown);
			// 
			// busesByModeValueBindingSource
			// 
			this.busesByModeValueBindingSource.DataMember = "BusesByModeValue";
			this.busesByModeValueBindingSource.DataSource = this.busesDS;
			// 
			// busesDS
			// 
			this.busesDS.DataSetName = "BusesDS";
			this.busesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmbCMP
			// 
			this.cmbCMP.DataSource = this.especialistasBindingSource;
			this.cmbCMP.DisplayMember = "Medico";
			this.cmbCMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCMP.FormattingEnabled = true;
			this.cmbCMP.Location = new System.Drawing.Point(9, 404);
			this.cmbCMP.Name = "cmbCMP";
			this.cmbCMP.Size = new System.Drawing.Size(235, 21);
			this.cmbCMP.TabIndex = 12;
			this.cmbCMP.ValueMember = "Id_Personal";
			this.cmbCMP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCMP_KeyDown);
			// 
			// especialistasBindingSource
			// 
			this.especialistasBindingSource.DataMember = "Especialistas";
			this.especialistasBindingSource.DataSource = this.medicosDS;
			// 
			// medicosDS
			// 
			this.medicosDS.DataSetName = "MedicosDS";
			this.medicosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmbTPEsp
			// 
			this.cmbTPEsp.DataSource = this.tipoSubProductoBindingSource;
			this.cmbTPEsp.DisplayMember = "Descripcion";
			this.cmbTPEsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTPEsp.FormattingEnabled = true;
			this.cmbTPEsp.Location = new System.Drawing.Point(9, 444);
			this.cmbTPEsp.Name = "cmbTPEsp";
			this.cmbTPEsp.Size = new System.Drawing.Size(235, 21);
			this.cmbTPEsp.TabIndex = 13;
			this.cmbTPEsp.ValueMember = "Id_Tipo";
			this.cmbTPEsp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTPEsp_KeyDown);
			// 
			// tipoSubProductoBindingSource
			// 
			this.tipoSubProductoBindingSource.DataMember = "TipoSubProducto";
			this.tipoSubProductoBindingSource.DataSource = this.tablaTipoDS;
			// 
			// tablaTipoDS
			// 
			this.tablaTipoDS.DataSetName = "TablaTipoDS";
			this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// total
			// 
			this.total.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total.Location = new System.Drawing.Point(765, 313);
			this.total.Name = "total";
			this.total.ReadOnly = true;
			this.total.Size = new System.Drawing.Size(77, 13);
			this.total.TabIndex = 24;
			this.total.Text = "0.00";
			this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(714, 313);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 25;
			this.label5.Text = "Total S/.";
			// 
			// turnoBindingSource
			// 
			this.turnoBindingSource.DataMember = "Turno";
			this.turnoBindingSource.DataSource = this.tablaTipoDS;
			// 
			// btnEjecutar
			// 
			this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("btnEjecutar.Image")));
			this.btnEjecutar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEjecutar.Location = new System.Drawing.Point(29, 477);
			this.btnEjecutar.Name = "btnEjecutar";
			this.btnEjecutar.Size = new System.Drawing.Size(71, 56);
			this.btnEjecutar.TabIndex = 14;
			this.btnEjecutar.Text = "&Ejecutar";
			this.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEjecutar.UseVisualStyleBackColor = true;
			this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
			// 
			// btnExportar
			// 
			this.btnExportar.Enabled = false;
			this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
			this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExportar.Location = new System.Drawing.Point(110, 477);
			this.btnExportar.Name = "btnExportar";
			this.btnExportar.Size = new System.Drawing.Size(71, 56);
			this.btnExportar.TabIndex = 15;
			this.btnExportar.Text = "E&xportar";
			this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExportar.UseVisualStyleBackColor = true;
			this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
			// 
			// btnMarcar
			// 
			this.btnMarcar.Enabled = false;
			this.btnMarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMarcar.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcar.Image")));
			this.btnMarcar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMarcar.Location = new System.Drawing.Point(191, 477);
			this.btnMarcar.Name = "btnMarcar";
			this.btnMarcar.Size = new System.Drawing.Size(71, 56);
			this.btnMarcar.TabIndex = 16;
			this.btnMarcar.Text = "&Marcar";
			this.btnMarcar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnMarcar.UseVisualStyleBackColor = true;
			this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Enabled = false;
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
			this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnImprimir.Location = new System.Drawing.Point(272, 477);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(71, 56);
			this.btnImprimir.TabIndex = 20;
			this.btnImprimir.Text = "Im&primir";
			this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSalir.Location = new System.Drawing.Point(353, 477);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(71, 56);
			this.btnSalir.TabIndex = 22;
			this.btnSalir.Text = "&Salir";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// especialidadTableAdapter
			// 
			this.especialidadTableAdapter.ClearBeforeFill = true;
			// 
			// especialistasTableAdapter
			// 
			this.especialistasTableAdapter.ClearBeforeFill = true;
			// 
			// periodoPagoTableAdapter
			// 
			this.periodoPagoTableAdapter.ClearBeforeFill = true;
			// 
			// grdListado
			// 
			this.grdListado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.grdListado.FullRowSelect = true;
			this.grdListado.Location = new System.Drawing.Point(255, 4);
			this.grdListado.MultiSelect = false;
			this.grdListado.Name = "grdListado";
			this.grdListado.Size = new System.Drawing.Size(619, 160);
			this.grdListado.TabIndex = 42;
			this.grdListado.UseCompatibleStateImageBehavior = false;
			this.grdListado.View = System.Windows.Forms.View.Details;
			this.grdListado.SelectedIndexChanged += new System.EventHandler(this.grdListado_SelectedIndexChanged);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Atención";
			this.columnHeader2.Width = 70;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Serie";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 40;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "N° Recibo";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader4.Width = 65;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "CMP";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 50;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Consultorio";
			this.columnHeader6.Width = 160;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Items";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader7.Width = 40;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Bus";
			this.columnHeader8.Width = 105;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Total S/.";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// grdDetalle
			// 
			this.grdDetalle.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.grdDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
			this.grdDetalle.FullRowSelect = true;
			this.grdDetalle.HideSelection = false;
			this.grdDetalle.Location = new System.Drawing.Point(255, 166);
			this.grdDetalle.MultiSelect = false;
			this.grdDetalle.Name = "grdDetalle";
			this.grdDetalle.Size = new System.Drawing.Size(619, 143);
			this.grdDetalle.TabIndex = 43;
			this.grdDetalle.UseCompatibleStateImageBehavior = false;
			this.grdDetalle.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Producto";
			this.columnHeader10.Width = 380;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Precio";
			this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader11.Width = 70;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Cantidad";
			this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader12.Width = 70;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Total S/.";
			this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader13.Width = 70;
			// 
			// turnoTableAdapter
			// 
			this.turnoTableAdapter.ClearBeforeFill = true;
			// 
			// busesByModeValueTableAdapter
			// 
			this.busesByModeValueTableAdapter.ClearBeforeFill = true;
			// 
			// tipoSubProductoTableAdapter
			// 
			this.tipoSubProductoTableAdapter.ClearBeforeFill = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbTodos);
			this.groupBox1.Controls.Add(this.rbPagados);
			this.groupBox1.Controls.Add(this.rbNoProcesados);
			this.groupBox1.Controls.Add(this.rbProcesados);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Navy;
			this.groupBox1.Location = new System.Drawing.Point(4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(246, 64);
			this.groupBox1.TabIndex = 44;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Condicion de Consulta";
			// 
			// rbTodos
			// 
			this.rbTodos.AutoSize = true;
			this.rbTodos.ForeColor = System.Drawing.Color.Black;
			this.rbTodos.Location = new System.Drawing.Point(146, 42);
			this.rbTodos.Name = "rbTodos";
			this.rbTodos.Size = new System.Drawing.Size(60, 17);
			this.rbTodos.TabIndex = 4;
			this.rbTodos.Text = "Todos";
			this.rbTodos.UseVisualStyleBackColor = true;
			this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
			// 
			// rbPagados
			// 
			this.rbPagados.AutoSize = true;
			this.rbPagados.ForeColor = System.Drawing.Color.Black;
			this.rbPagados.Location = new System.Drawing.Point(146, 18);
			this.rbPagados.Name = "rbPagados";
			this.rbPagados.Size = new System.Drawing.Size(74, 17);
			this.rbPagados.TabIndex = 2;
			this.rbPagados.Text = "Pagados";
			this.rbPagados.UseVisualStyleBackColor = true;
			this.rbPagados.CheckedChanged += new System.EventHandler(this.rbPagados_CheckedChanged);
			// 
			// rbNoProcesados
			// 
			this.rbNoProcesados.AutoSize = true;
			this.rbNoProcesados.ForeColor = System.Drawing.Color.Black;
			this.rbNoProcesados.Location = new System.Drawing.Point(17, 41);
			this.rbNoProcesados.Name = "rbNoProcesados";
			this.rbNoProcesados.Size = new System.Drawing.Size(110, 17);
			this.rbNoProcesados.TabIndex = 3;
			this.rbNoProcesados.Text = "No procesados";
			this.rbNoProcesados.UseVisualStyleBackColor = true;
			this.rbNoProcesados.CheckedChanged += new System.EventHandler(this.rbNoProcesados_CheckedChanged);
			// 
			// rbProcesados
			// 
			this.rbProcesados.AutoSize = true;
			this.rbProcesados.Checked = true;
			this.rbProcesados.ForeColor = System.Drawing.Color.Black;
			this.rbProcesados.Location = new System.Drawing.Point(17, 18);
			this.rbProcesados.Name = "rbProcesados";
			this.rbProcesados.Size = new System.Drawing.Size(91, 17);
			this.rbProcesados.TabIndex = 1;
			this.rbProcesados.TabStop = true;
			this.rbProcesados.Text = "Procesados";
			this.rbProcesados.UseVisualStyleBackColor = true;
			this.rbProcesados.CheckedChanged += new System.EventHandler(this.rbProcesados_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkHabFecha);
			this.groupBox2.Controls.Add(this.grdFechas);
			this.groupBox2.Controls.Add(this.lstFechas);
			this.groupBox2.Controls.Add(this.cmbPerPago);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Navy;
			this.groupBox2.Location = new System.Drawing.Point(4, 69);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(245, 240);
			this.groupBox2.TabIndex = 45;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Periodo de Pago";
			// 
			// chkHabFecha
			// 
			this.chkHabFecha.AutoSize = true;
			this.chkHabFecha.Checked = true;
			this.chkHabFecha.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkHabFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkHabFecha.ForeColor = System.Drawing.Color.DarkBlue;
			this.chkHabFecha.Location = new System.Drawing.Point(8, 38);
			this.chkHabFecha.Name = "chkHabFecha";
			this.chkHabFecha.Size = new System.Drawing.Size(67, 17);
			this.chkHabFecha.TabIndex = 6;
			this.chkHabFecha.Text = "Fechas";
			this.chkHabFecha.UseVisualStyleBackColor = true;
			this.chkHabFecha.CheckedChanged += new System.EventHandler(this.chkHabFecha_CheckedChanged);
			// 
			// grdFechas
			// 
			this.grdFechas.Controls.Add(this.dtpFecFin);
			this.grdFechas.Controls.Add(this.label4);
			this.grdFechas.Controls.Add(this.dtpFecIni);
			this.grdFechas.Controls.Add(this.label3);
			this.grdFechas.Location = new System.Drawing.Point(8, 41);
			this.grdFechas.Name = "grdFechas";
			this.grdFechas.Size = new System.Drawing.Size(101, 101);
			this.grdFechas.TabIndex = 49;
			this.grdFechas.TabStop = false;
			// 
			// dtpFecFin
			// 
			this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecFin.Location = new System.Drawing.Point(5, 76);
			this.dtpFecFin.Name = "dtpFecFin";
			this.dtpFecFin.Size = new System.Drawing.Size(91, 20);
			this.dtpFecFin.TabIndex = 8;
			this.dtpFecFin.ValueChanged += new System.EventHandler(this.dtpFecFin_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(4, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 50;
			this.label4.Text = "Final";
			// 
			// dtpFecIni
			// 
			this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecIni.Location = new System.Drawing.Point(5, 34);
			this.dtpFecIni.Name = "dtpFecIni";
			this.dtpFecIni.Size = new System.Drawing.Size(91, 20);
			this.dtpFecIni.TabIndex = 7;
			this.dtpFecIni.ValueChanged += new System.EventHandler(this.dtpFecIni_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(4, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 48;
			this.label3.Text = "Inicio";
			// 
			// lstFechas
			// 
			this.lstFechas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lstFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstFechas.FullRowSelect = true;
			this.lstFechas.HideSelection = false;
			this.lstFechas.Location = new System.Drawing.Point(116, 40);
			this.lstFechas.Name = "lstFechas";
			this.lstFechas.Size = new System.Drawing.Size(122, 195);
			this.lstFechas.TabIndex = 9;
			this.lstFechas.UseCompatibleStateImageBehavior = false;
			this.lstFechas.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Fecha";
			this.columnHeader1.Width = 100;
			// 
			// cmbPerPago
			// 
			this.cmbPerPago.DataSource = this.periodoPagoBindingSource;
			this.cmbPerPago.DisplayMember = "Name_Per";
			this.cmbPerPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPerPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPerPago.FormattingEnabled = true;
			this.cmbPerPago.Location = new System.Drawing.Point(4, 15);
			this.cmbPerPago.Name = "cmbPerPago";
			this.cmbPerPago.Size = new System.Drawing.Size(235, 20);
			this.cmbPerPago.TabIndex = 5;
			this.cmbPerPago.ValueMember = "Id_Per";
			this.cmbPerPago.SelectedIndexChanged += new System.EventHandler(this.cmbPerPago_SelectedIndexChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.rbFechas);
			this.groupBox4.Controls.Add(this.rbProductos);
			this.groupBox4.Controls.Add(this.rbRecibos);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.Color.Navy;
			this.groupBox4.Location = new System.Drawing.Point(258, 315);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(196, 101);
			this.groupBox4.TabIndex = 46;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Tipos de Reporte";
			// 
			// rbFechas
			// 
			this.rbFechas.AutoSize = true;
			this.rbFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbFechas.ForeColor = System.Drawing.Color.Black;
			this.rbFechas.Location = new System.Drawing.Point(12, 74);
			this.rbFechas.Name = "rbFechas";
			this.rbFechas.Size = new System.Drawing.Size(164, 17);
			this.rbFechas.TabIndex = 19;
			this.rbFechas.Text = "Reporte resumido por Fechas";
			this.rbFechas.UseVisualStyleBackColor = true;
			// 
			// rbProductos
			// 
			this.rbProductos.AutoSize = true;
			this.rbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbProductos.ForeColor = System.Drawing.Color.Black;
			this.rbProductos.Location = new System.Drawing.Point(12, 48);
			this.rbProductos.Name = "rbProductos";
			this.rbProductos.Size = new System.Drawing.Size(177, 17);
			this.rbProductos.TabIndex = 18;
			this.rbProductos.Text = "Reporte resumido por Productos";
			this.rbProductos.UseVisualStyleBackColor = true;
			// 
			// rbRecibos
			// 
			this.rbRecibos.AutoSize = true;
			this.rbRecibos.Checked = true;
			this.rbRecibos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbRecibos.ForeColor = System.Drawing.Color.Black;
			this.rbRecibos.Location = new System.Drawing.Point(12, 22);
			this.rbRecibos.Name = "rbRecibos";
			this.rbRecibos.Size = new System.Drawing.Size(169, 17);
			this.rbRecibos.TabIndex = 17;
			this.rbRecibos.TabStop = true;
			this.rbRecibos.Text = "Reporte detallado por Recibos";
			this.rbRecibos.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(11, 312);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 49;
			this.label1.Text = "Especialidades";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(11, 351);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 50;
			this.label2.Text = "Buses";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Navy;
			this.label7.Location = new System.Drawing.Point(11, 390);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 13);
			this.label7.TabIndex = 51;
			this.label7.Text = "Especialistas";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Navy;
			this.label8.Location = new System.Drawing.Point(11, 429);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(111, 13);
			this.label8.TabIndex = 52;
			this.label8.Text = "Tipos de Producto";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grdResumen
			// 
			this.grdResumen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
			this.grdResumen.FullRowSelect = true;
			this.grdResumen.HideSelection = false;
			this.grdResumen.Location = new System.Drawing.Point(466, 355);
			this.grdResumen.MultiSelect = false;
			this.grdResumen.Name = "grdResumen";
			this.grdResumen.Size = new System.Drawing.Size(407, 163);
			this.grdResumen.TabIndex = 59;
			this.grdResumen.UseCompatibleStateImageBehavior = false;
			this.grdResumen.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Fecha";
			this.columnHeader14.Width = 100;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Tickets";
			this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader15.Width = 85;
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Cantidad";
			this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader16.Width = 90;
			// 
			// columnHeader17
			// 
			this.columnHeader17.Text = "Total S/.";
			this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader17.Width = 100;
			// 
			// cmbTurno
			// 
			this.cmbTurno.DataSource = this.turnoBindingSource;
			this.cmbTurno.DisplayMember = "Descripcion";
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.Enabled = false;
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Location = new System.Drawing.Point(663, 332);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(208, 21);
			this.cmbTurno.TabIndex = 21;
			this.cmbTurno.ValueMember = "Id_Tipo";
			this.cmbTurno.SelectionChangeCommitted += new System.EventHandler(this.cmbTurno_SelectionChangeCommitted);
			// 
			// txtTotal
			// 
			this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTotal.Location = new System.Drawing.Point(752, 520);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(85, 13);
			this.txtTotal.TabIndex = 56;
			this.txtTotal.Text = "0.00";
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtCantidad
			// 
			this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCantidad.Location = new System.Drawing.Point(666, 520);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.ReadOnly = true;
			this.txtCantidad.Size = new System.Drawing.Size(71, 13);
			this.txtCantidad.TabIndex = 55;
			this.txtCantidad.Text = "0";
			this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTickets
			// 
			this.txtTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTickets.Location = new System.Drawing.Point(593, 520);
			this.txtTickets.Name = "txtTickets";
			this.txtTickets.ReadOnly = true;
			this.txtTickets.Size = new System.Drawing.Size(54, 13);
			this.txtTickets.TabIndex = 54;
			this.txtTickets.Text = "0";
			this.txtTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Navy;
			this.label6.Location = new System.Drawing.Point(524, 521);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 13);
			this.label6.TabIndex = 53;
			this.label6.Text = "Totales S/.";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Navy;
			this.label9.Location = new System.Drawing.Point(608, 337);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(46, 13);
			this.label9.TabIndex = 60;
			this.label9.Text = "Turnos";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmRepProdTer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 539);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.grdResumen);
			this.Controls.Add(this.cmbTurno);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtTickets);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grdDetalle);
			this.Controls.Add(this.grdListado);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnMarcar);
			this.Controls.Add(this.btnExportar);
			this.Controls.Add(this.btnEjecutar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.total);
			this.Controls.Add(this.cmbTPEsp);
			this.Controls.Add(this.cmbCMP);
			this.Controls.Add(this.cmbBus);
			this.Controls.Add(this.cmbConsultorio);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.Name = "frmRepProdTer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Producción de Terceros por Consultorio";
			this.Load += new System.EventHandler(this.frmRepProdTer_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRepProdTer_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.periodoPagoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.periodoPagoDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.busesByModeValueBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.busesDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.especialistasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.medicosDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoSubProductoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.grdFechas.ResumeLayout(false);
			this.grdFechas.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.ComboBox cmbCMP;
        private System.Windows.Forms.ComboBox cmbTPEsp;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
        private Dominio.Data.MedicosDS medicosDS;
        private System.Windows.Forms.BindingSource especialistasBindingSource;
        private Dominio.Data.MedicosDSTableAdapters.EspecialistasTableAdapter especialistasTableAdapter;
        private Dominio.Data.PeriodoPagoDS periodoPagoDS;
        private System.Windows.Forms.BindingSource periodoPagoBindingSource;
        private Dominio.Data.PeriodoPagoDSTableAdapters.PeriodoPagoTableAdapter periodoPagoTableAdapter;
        private System.Windows.Forms.ListView grdListado;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView grdDetalle;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TurnoTableAdapter turnoTableAdapter;
        private System.Windows.Forms.BindingSource busesByModeValueBindingSource;
        private Dominio.Data.BusesDS busesDS;
        private Dominio.Data.BusesDSTableAdapters.BusesByModeValueTableAdapter busesByModeValueTableAdapter;
        private System.Windows.Forms.BindingSource tipoSubProductoBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TipoSubProductoTableAdapter tipoSubProductoTableAdapter;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbTodos;
		private System.Windows.Forms.RadioButton rbPagados;
		private System.Windows.Forms.RadioButton rbNoProcesados;
		private System.Windows.Forms.RadioButton rbProcesados;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkHabFecha;
		private System.Windows.Forms.GroupBox grdFechas;
		private System.Windows.Forms.DateTimePicker dtpFecFin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpFecIni;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView lstFechas;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ComboBox cmbPerPago;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rbFechas;
		private System.Windows.Forms.RadioButton rbProductos;
		private System.Windows.Forms.RadioButton rbRecibos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListView grdResumen;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ColumnHeader columnHeader17;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.CheckBox chkTAllTurnos;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtTickets;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
	}
}