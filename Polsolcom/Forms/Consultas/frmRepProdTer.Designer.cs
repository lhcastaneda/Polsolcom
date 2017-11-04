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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPerPago = new System.Windows.Forms.ComboBox();
            this.periodoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodoPagoDS = new Polsolcom.Dominio.Data.PeriodoPagoDS();
            this.chkHabFecha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.chkAllConsultorios = new System.Windows.Forms.CheckBox();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.chkAllBuses = new System.Windows.Forms.CheckBox();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.busesByModeValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busesDS = new Polsolcom.Dominio.Data.BusesDS();
            this.chkAllCMP = new System.Windows.Forms.CheckBox();
            this.cmbCMP = new System.Windows.Forms.ComboBox();
            this.especialistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosDS = new Polsolcom.Dominio.Data.MedicosDS();
            this.chkAllProEsp = new System.Windows.Forms.CheckBox();
            this.cmbTPEsp = new System.Windows.Forms.ComboBox();
            this.tipoSubProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
            this.total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdResumen = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkTAllTurnos = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTipReport = new System.Windows.Forms.Panel();
            this.rbFechas = new System.Windows.Forms.RadioButton();
            this.rbProductos = new System.Windows.Forms.RadioButton();
            this.rbRecibos = new System.Windows.Forms.RadioButton();
            this.pnlCondConsul = new System.Windows.Forms.Panel();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbPagados = new System.Windows.Forms.RadioButton();
            this.rbNoProcesados = new System.Windows.Forms.RadioButton();
            this.rbProcesados = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.especialidadTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter();
            this.especialistasTableAdapter = new Polsolcom.Dominio.Data.MedicosDSTableAdapters.EspecialistasTableAdapter();
            this.periodoPagoTableAdapter = new Polsolcom.Dominio.Data.PeriodoPagoDSTableAdapters.PeriodoPagoTableAdapter();
            this.lstFechas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            this.pnlTipReport.SuspendLayout();
            this.pnlCondConsul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condición de Consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Periodo de Pago";
            // 
            // cmbPerPago
            // 
            this.cmbPerPago.DataSource = this.periodoPagoBindingSource;
            this.cmbPerPago.DisplayMember = "Name_Per";
            this.cmbPerPago.FormattingEnabled = true;
            this.cmbPerPago.Location = new System.Drawing.Point(12, 127);
            this.cmbPerPago.Name = "cmbPerPago";
            this.cmbPerPago.Size = new System.Drawing.Size(235, 21);
            this.cmbPerPago.TabIndex = 5;
            this.cmbPerPago.ValueMember = "Id_Per";
            this.cmbPerPago.SelectionChangeCommitted += new System.EventHandler(this.cmbPerPago_SelectionChangeCommitted);
            this.cmbPerPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerPago_KeyDown);
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
            // chkHabFecha
            // 
            this.chkHabFecha.AutoSize = true;
            this.chkHabFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabFecha.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkHabFecha.Location = new System.Drawing.Point(12, 163);
            this.chkHabFecha.Name = "chkHabFecha";
            this.chkHabFecha.Size = new System.Drawing.Size(67, 17);
            this.chkHabFecha.TabIndex = 6;
            this.chkHabFecha.Text = "Fechas";
            this.chkHabFecha.UseVisualStyleBackColor = true;
            this.chkHabFecha.CheckedChanged += new System.EventHandler(this.chkHabFecha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Final";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Enabled = false;
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(140, 199);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(107, 20);
            this.dtpFecFin.TabIndex = 10;
            this.dtpFecFin.ValueChanged += new System.EventHandler(this.dtpFecFin_ValueChanged);
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Enabled = false;
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(11, 199);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(107, 20);
            this.dtpFecIni.TabIndex = 11;
            // 
            // chkAllConsultorios
            // 
            this.chkAllConsultorios.AutoSize = true;
            this.chkAllConsultorios.Checked = true;
            this.chkAllConsultorios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllConsultorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllConsultorios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAllConsultorios.Location = new System.Drawing.Point(12, 340);
            this.chkAllConsultorios.Name = "chkAllConsultorios";
            this.chkAllConsultorios.Size = new System.Drawing.Size(170, 17);
            this.chkAllConsultorios.TabIndex = 13;
            this.chkAllConsultorios.Text = "Todas las Especialidades";
            this.chkAllConsultorios.UseVisualStyleBackColor = true;
            this.chkAllConsultorios.CheckedChanged += new System.EventHandler(this.chkAllConsultorios_CheckedChanged);
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.especialidadBindingSource;
            this.cmbConsultorio.DisplayMember = "Descripcion";
            this.cmbConsultorio.Enabled = false;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(12, 364);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(235, 21);
            this.cmbConsultorio.TabIndex = 14;
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
            // chkAllBuses
            // 
            this.chkAllBuses.AutoSize = true;
            this.chkAllBuses.Checked = true;
            this.chkAllBuses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllBuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllBuses.Location = new System.Drawing.Point(12, 392);
            this.chkAllBuses.Name = "chkAllBuses";
            this.chkAllBuses.Size = new System.Drawing.Size(187, 17);
            this.chkAllBuses.TabIndex = 15;
            this.chkAllBuses.Text = "Todos los Consultorios (Bus)";
            this.chkAllBuses.UseVisualStyleBackColor = true;
            this.chkAllBuses.CheckedChanged += new System.EventHandler(this.chkAllBuses_CheckedChanged);
            // 
            // cmbBus
            // 
            this.cmbBus.DataSource = this.busesByModeValueBindingSource;
            this.cmbBus.DisplayMember = "Bus";
            this.cmbBus.Enabled = false;
            this.cmbBus.Location = new System.Drawing.Point(13, 416);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(234, 21);
            this.cmbBus.TabIndex = 16;
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
            // chkAllCMP
            // 
            this.chkAllCMP.AutoSize = true;
            this.chkAllCMP.Checked = true;
            this.chkAllCMP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllCMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllCMP.Location = new System.Drawing.Point(12, 443);
            this.chkAllCMP.Name = "chkAllCMP";
            this.chkAllCMP.Size = new System.Drawing.Size(159, 17);
            this.chkAllCMP.TabIndex = 17;
            this.chkAllCMP.Text = "Todos los Especialistas";
            this.chkAllCMP.UseVisualStyleBackColor = true;
            this.chkAllCMP.CheckedChanged += new System.EventHandler(this.chkAllCMP_CheckedChanged);
            // 
            // cmbCMP
            // 
            this.cmbCMP.DataSource = this.especialistasBindingSource;
            this.cmbCMP.DisplayMember = "Medico";
            this.cmbCMP.Enabled = false;
            this.cmbCMP.FormattingEnabled = true;
            this.cmbCMP.Location = new System.Drawing.Point(12, 467);
            this.cmbCMP.Name = "cmbCMP";
            this.cmbCMP.Size = new System.Drawing.Size(235, 21);
            this.cmbCMP.TabIndex = 18;
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
            // chkAllProEsp
            // 
            this.chkAllProEsp.AutoSize = true;
            this.chkAllProEsp.Checked = true;
            this.chkAllProEsp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllProEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllProEsp.Location = new System.Drawing.Point(18, 494);
            this.chkAllProEsp.Name = "chkAllProEsp";
            this.chkAllProEsp.Size = new System.Drawing.Size(195, 17);
            this.chkAllProEsp.TabIndex = 19;
            this.chkAllProEsp.Text = "Todos los Tipos de Productos";
            this.chkAllProEsp.UseVisualStyleBackColor = true;
            this.chkAllProEsp.CheckedChanged += new System.EventHandler(this.chkAllProEsp_CheckedChanged);
            // 
            // cmbTPEsp
            // 
            this.cmbTPEsp.DataSource = this.tipoSubProductoBindingSource;
            this.cmbTPEsp.DisplayMember = "Descripcion";
            this.cmbTPEsp.Enabled = false;
            this.cmbTPEsp.FormattingEnabled = true;
            this.cmbTPEsp.Location = new System.Drawing.Point(12, 519);
            this.cmbTPEsp.Name = "cmbTPEsp";
            this.cmbTPEsp.Size = new System.Drawing.Size(235, 21);
            this.cmbTPEsp.TabIndex = 20;
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
            this.total.Location = new System.Drawing.Point(798, 354);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 24;
            this.total.Text = "0.00";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(728, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdResumen);
            this.panel1.Controls.Add(this.cmbTurno);
            this.panel1.Controls.Add(this.chkTAllTurnos);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtTickets);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(478, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 229);
            this.panel1.TabIndex = 26;
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
            this.grdResumen.Location = new System.Drawing.Point(12, 38);
            this.grdResumen.MultiSelect = false;
            this.grdResumen.Name = "grdResumen";
            this.grdResumen.Size = new System.Drawing.Size(407, 154);
            this.grdResumen.TabIndex = 30;
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
            this.columnHeader15.Width = 90;
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
            this.cmbTurno.Enabled = false;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(210, 8);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(208, 21);
            this.cmbTurno.TabIndex = 29;
            this.cmbTurno.ValueMember = "Id_Tipo";
            this.cmbTurno.SelectionChangeCommitted += new System.EventHandler(this.cmbTurno_SelectionChangeCommitted);
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.tablaTipoDS;
            // 
            // chkTAllTurnos
            // 
            this.chkTAllTurnos.AutoSize = true;
            this.chkTAllTurnos.Checked = true;
            this.chkTAllTurnos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTAllTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTAllTurnos.Location = new System.Drawing.Point(13, 12);
            this.chkTAllTurnos.Name = "chkTAllTurnos";
            this.chkTAllTurnos.Size = new System.Drawing.Size(124, 17);
            this.chkTAllTurnos.TabIndex = 28;
            this.chkTAllTurnos.Text = "Todos los Turnos";
            this.chkTAllTurnos.UseVisualStyleBackColor = true;
            this.chkTAllTurnos.CheckedChanged += new System.EventHandler(this.chkTAllTurnos_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(320, 199);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(92, 20);
            this.txtTotal.TabIndex = 27;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(223, 199);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(92, 20);
            this.txtCantidad.TabIndex = 26;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(137, 199);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.ReadOnly = true;
            this.txtTickets.Size = new System.Drawing.Size(80, 20);
            this.txtTickets.TabIndex = 25;
            this.txtTickets.Text = "0";
            this.txtTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Totales";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(99, 546);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(71, 56);
            this.btnEjecutar.TabIndex = 27;
            this.btnEjecutar.Text = "&Ejecutar";
            this.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(22, 608);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(71, 56);
            this.btnExportar.TabIndex = 28;
            this.btnExportar.Text = "E&xportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnMarcar
            // 
            this.btnMarcar.Enabled = false;
            this.btnMarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcar.Location = new System.Drawing.Point(99, 608);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(71, 56);
            this.btnMarcar.TabIndex = 29;
            this.btnMarcar.Text = "&Marcar";
            this.btnMarcar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(176, 608);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(71, 56);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.Text = "Im&primir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(792, 624);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 38);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(266, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tipos por Reporte";
            // 
            // pnlTipReport
            // 
            this.pnlTipReport.Controls.Add(this.rbFechas);
            this.pnlTipReport.Controls.Add(this.rbProductos);
            this.pnlTipReport.Controls.Add(this.rbRecibos);
            this.pnlTipReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTipReport.Location = new System.Drawing.Point(269, 438);
            this.pnlTipReport.Name = "pnlTipReport";
            this.pnlTipReport.Size = new System.Drawing.Size(200, 150);
            this.pnlTipReport.TabIndex = 34;
            // 
            // rbFechas
            // 
            this.rbFechas.AutoSize = true;
            this.rbFechas.Location = new System.Drawing.Point(10, 109);
            this.rbFechas.Name = "rbFechas";
            this.rbFechas.Size = new System.Drawing.Size(164, 17);
            this.rbFechas.TabIndex = 43;
            this.rbFechas.Text = "Reporte resumido por Fechas";
            this.rbFechas.UseVisualStyleBackColor = true;
            // 
            // rbProductos
            // 
            this.rbProductos.AutoSize = true;
            this.rbProductos.Location = new System.Drawing.Point(10, 66);
            this.rbProductos.Name = "rbProductos";
            this.rbProductos.Size = new System.Drawing.Size(177, 17);
            this.rbProductos.TabIndex = 42;
            this.rbProductos.Text = "Reporte resumido por Productos";
            this.rbProductos.UseVisualStyleBackColor = true;
            // 
            // rbRecibos
            // 
            this.rbRecibos.AutoSize = true;
            this.rbRecibos.Checked = true;
            this.rbRecibos.Location = new System.Drawing.Point(10, 23);
            this.rbRecibos.Name = "rbRecibos";
            this.rbRecibos.Size = new System.Drawing.Size(169, 17);
            this.rbRecibos.TabIndex = 41;
            this.rbRecibos.TabStop = true;
            this.rbRecibos.Text = "Reporte detallado por Recibos";
            this.rbRecibos.UseVisualStyleBackColor = true;
            // 
            // pnlCondConsul
            // 
            this.pnlCondConsul.Controls.Add(this.rbTodos);
            this.pnlCondConsul.Controls.Add(this.rbPagados);
            this.pnlCondConsul.Controls.Add(this.rbNoProcesados);
            this.pnlCondConsul.Controls.Add(this.rbProcesados);
            this.pnlCondConsul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCondConsul.Location = new System.Drawing.Point(12, 37);
            this.pnlCondConsul.Name = "pnlCondConsul";
            this.pnlCondConsul.Size = new System.Drawing.Size(227, 56);
            this.pnlCondConsul.TabIndex = 35;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(129, 32);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(60, 17);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbPagados
            // 
            this.rbPagados.AutoSize = true;
            this.rbPagados.Location = new System.Drawing.Point(128, 9);
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
            this.rbNoProcesados.Location = new System.Drawing.Point(9, 31);
            this.rbNoProcesados.Name = "rbNoProcesados";
            this.rbNoProcesados.Size = new System.Drawing.Size(110, 17);
            this.rbNoProcesados.TabIndex = 1;
            this.rbNoProcesados.Text = "No procesados";
            this.rbNoProcesados.UseVisualStyleBackColor = true;
            this.rbNoProcesados.CheckedChanged += new System.EventHandler(this.rbNoProcesados_CheckedChanged);
            // 
            // rbProcesados
            // 
            this.rbProcesados.AutoSize = true;
            this.rbProcesados.Checked = true;
            this.rbProcesados.Location = new System.Drawing.Point(8, 9);
            this.rbProcesados.Name = "rbProcesados";
            this.rbProcesados.Size = new System.Drawing.Size(91, 17);
            this.rbProcesados.TabIndex = 0;
            this.rbProcesados.TabStop = true;
            this.rbProcesados.Text = "Procesados";
            this.rbProcesados.UseVisualStyleBackColor = true;
            this.rbProcesados.CheckedChanged += new System.EventHandler(this.rbProcesados_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 553);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 617);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(119, 617);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(195, 617);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(813, 630);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
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
            // lstFechas
            // 
            this.lstFechas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstFechas.FullRowSelect = true;
            this.lstFechas.HideSelection = false;
            this.lstFechas.Location = new System.Drawing.Point(10, 226);
            this.lstFechas.Name = "lstFechas";
            this.lstFechas.Size = new System.Drawing.Size(238, 109);
            this.lstFechas.TabIndex = 41;
            this.lstFechas.UseCompatibleStateImageBehavior = false;
            this.lstFechas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 200;
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
            this.grdListado.Location = new System.Drawing.Point(276, 17);
            this.grdListado.MultiSelect = false;
            this.grdListado.Name = "grdListado";
            this.grdListado.Size = new System.Drawing.Size(621, 184);
            this.grdListado.TabIndex = 42;
            this.grdListado.UseCompatibleStateImageBehavior = false;
            this.grdListado.View = System.Windows.Forms.View.Details;
            this.grdListado.SelectedIndexChanged += new System.EventHandler(this.grdListado_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Atención";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Serie";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "N° Recibo";
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CMP";
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
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Bus";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Total S/.";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 65;
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
            this.grdDetalle.Location = new System.Drawing.Point(275, 207);
            this.grdDetalle.MultiSelect = false;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.Size = new System.Drawing.Size(622, 143);
            this.grdDetalle.TabIndex = 43;
            this.grdDetalle.UseCompatibleStateImageBehavior = false;
            this.grdDetalle.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Producto";
            this.columnHeader10.Width = 390;
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
            this.columnHeader13.Text = "Total";
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
            // frmRepProdTer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 674);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.grdListado);
            this.Controls.Add(this.lstFechas);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCondConsul);
            this.Controls.Add(this.pnlTipReport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total);
            this.Controls.Add(this.cmbTPEsp);
            this.Controls.Add(this.chkAllProEsp);
            this.Controls.Add(this.cmbCMP);
            this.Controls.Add(this.chkAllCMP);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.chkAllBuses);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.chkAllConsultorios);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkHabFecha);
            this.Controls.Add(this.cmbPerPago);
            this.Controls.Add(this.label2);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            this.pnlTipReport.ResumeLayout(false);
            this.pnlTipReport.PerformLayout();
            this.pnlCondConsul.ResumeLayout(false);
            this.pnlCondConsul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPerPago;
        private System.Windows.Forms.CheckBox chkHabFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.CheckBox chkAllConsultorios;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.CheckBox chkAllBuses;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.CheckBox chkAllCMP;
        private System.Windows.Forms.ComboBox cmbCMP;
        private System.Windows.Forms.CheckBox chkAllProEsp;
        private System.Windows.Forms.ComboBox cmbTPEsp;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.CheckBox chkTAllTurnos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlTipReport;
        private System.Windows.Forms.Panel pnlCondConsul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton rbFechas;
        private System.Windows.Forms.RadioButton rbProductos;
        private System.Windows.Forms.RadioButton rbRecibos;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbPagados;
        private System.Windows.Forms.RadioButton rbNoProcesados;
        private System.Windows.Forms.RadioButton rbProcesados;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
        private Dominio.Data.MedicosDS medicosDS;
        private System.Windows.Forms.BindingSource especialistasBindingSource;
        private Dominio.Data.MedicosDSTableAdapters.EspecialistasTableAdapter especialistasTableAdapter;
        private Dominio.Data.PeriodoPagoDS periodoPagoDS;
        private System.Windows.Forms.BindingSource periodoPagoBindingSource;
        private Dominio.Data.PeriodoPagoDSTableAdapters.PeriodoPagoTableAdapter periodoPagoTableAdapter;
        private System.Windows.Forms.ListView lstFechas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
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
        private System.Windows.Forms.ListView grdResumen;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TurnoTableAdapter turnoTableAdapter;
        private System.Windows.Forms.BindingSource busesByModeValueBindingSource;
        private Dominio.Data.BusesDS busesDS;
        private Dominio.Data.BusesDSTableAdapters.BusesByModeValueTableAdapter busesByModeValueTableAdapter;
        private System.Windows.Forms.BindingSource tipoSubProductoBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TipoSubProductoTableAdapter tipoSubProductoTableAdapter;
    }
}