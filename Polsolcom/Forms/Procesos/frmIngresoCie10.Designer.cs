namespace Polsolcom.Forms.Procesos
{
    partial class frmIngresoCie10
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
            this.tabIngresoConsulta = new System.Windows.Forms.TabControl();
            this.tabIngresar = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaEmi = new System.Windows.Forms.MaskedTextBox();
            this.lstTickets0 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.consultoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.chkOpFil = new System.Windows.Forms.CheckBox();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.cmbDVenta = new System.Windows.Forms.ComboBox();
            this.docVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.lstPacientes = new System.Windows.Forms.ListView();
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTickets1 = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.tmpEspecialistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tmpEspecialistaDS = new Polsolcom.Dominio.Data.tmpEspecialistaDS();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.busesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busesDS = new Polsolcom.Dominio.Data.BusesDS();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDigitador = new System.Windows.Forms.TextBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.grpFiliacion = new System.Windows.Forms.GroupBox();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.dNroHistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPagado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dConclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaEmiFil = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.btnBCie10 = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cIE10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cie10DSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cie10DS = new Polsolcom.Dominio.Data.Cie10DS();
            this.grpEnfermedad = new System.Windows.Forms.GroupBox();
            this.txtEnAcRel = new System.Windows.Forms.TextBox();
            this.txtEnAcCur = new System.Windows.Forms.TextBox();
            this.txtEnAcIni = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpAntecedentes = new System.Windows.Forms.GroupBox();
            this.txtAnOtr = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtAnQui = new System.Windows.Forms.TextBox();
            this.txtAnEpi = new System.Windows.Forms.TextBox();
            this.txtAnFam = new System.Windows.Forms.TextBox();
            this.txtAnPer = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.grpExClinico = new System.Windows.Forms.GroupBox();
            this.txtExClEg = new System.Windows.Forms.TextBox();
            this.txtExClFr = new System.Windows.Forms.TextBox();
            this.txtExClTm = new System.Windows.Forms.TextBox();
            this.txtExClFc = new System.Windows.Forms.TextBox();
            this.txtExClPa = new System.Windows.Forms.TextBox();
            this.txtExClTl = new System.Windows.Forms.TextBox();
            this.txtExClPs = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBoxTraMed = new System.Windows.Forms.GroupBox();
            this.grdTraMed = new System.Windows.Forms.DataGridView();
            this.tMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPresentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.consultoriosTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.ConsultoriosTableAdapter();
            this.chkIdem = new System.Windows.Forms.CheckBox();
            this.txtTi = new System.Windows.Forms.TextBox();
            this.chkCompleto = new System.Windows.Forms.CheckBox();
            this.grdDetCie10 = new System.Windows.Forms.DataGridView();
            this.cNroHistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCie10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaAten = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.busesTableAdapter = new Polsolcom.Dominio.Data.BusesDSTableAdapters.BusesTableAdapter();
            this.tmpEspecialistaTableAdapter = new Polsolcom.Dominio.Data.tmpEspecialistaDSTableAdapters.tmpEspecialistaTableAdapter();
            this.cIE10TableAdapter = new Polsolcom.Dominio.Data.Cie10DSTableAdapters.CIE10TableAdapter();
            this.docVentaTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.DocVentaTableAdapter();
            this.turnoTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TurnoTableAdapter();
            this.tabIngresoConsulta.SuspendLayout();
            this.tabIngresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
            this.tabConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmpEspecialistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpEspecialistaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            this.grpFiliacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIE10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cie10DSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cie10DS)).BeginInit();
            this.grpEnfermedad.SuspendLayout();
            this.grpAntecedentes.SuspendLayout();
            this.grpExClinico.SuspendLayout();
            this.groupBoxTraMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTraMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetCie10)).BeginInit();
            this.SuspendLayout();
            // 
            // tabIngresoConsulta
            // 
            this.tabIngresoConsulta.Controls.Add(this.tabIngresar);
            this.tabIngresoConsulta.Controls.Add(this.tabConsultar);
            this.tabIngresoConsulta.Location = new System.Drawing.Point(0, 1);
            this.tabIngresoConsulta.Name = "tabIngresoConsulta";
            this.tabIngresoConsulta.SelectedIndex = 0;
            this.tabIngresoConsulta.Size = new System.Drawing.Size(432, 175);
            this.tabIngresoConsulta.TabIndex = 0;
            this.tabIngresoConsulta.Click += new System.EventHandler(this.tabIngresoConsulta_Click);
            // 
            // tabIngresar
            // 
            this.tabIngresar.Controls.Add(this.label4);
            this.tabIngresar.Controls.Add(this.txtFechaEmi);
            this.tabIngresar.Controls.Add(this.lstTickets0);
            this.tabIngresar.Controls.Add(this.cmbEspecialidad);
            this.tabIngresar.Controls.Add(this.chkOpFil);
            this.tabIngresar.Controls.Add(this.txtNroTicket);
            this.tabIngresar.Controls.Add(this.txtSerie);
            this.tabIngresar.Controls.Add(this.cmbDVenta);
            this.tabIngresar.Controls.Add(this.label6);
            this.tabIngresar.Controls.Add(this.label5);
            this.tabIngresar.Controls.Add(this.label3);
            this.tabIngresar.Controls.Add(this.label2);
            this.tabIngresar.Controls.Add(this.label1);
            this.tabIngresar.Location = new System.Drawing.Point(4, 22);
            this.tabIngresar.Name = "tabIngresar";
            this.tabIngresar.Padding = new System.Windows.Forms.Padding(3);
            this.tabIngresar.Size = new System.Drawing.Size(424, 149);
            this.tabIngresar.TabIndex = 0;
            this.tabIngresar.Text = "Ingresar datos";
            this.tabIngresar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha Vent.";
            // 
            // txtFechaEmi
            // 
            this.txtFechaEmi.Location = new System.Drawing.Point(188, 27);
            this.txtFechaEmi.Mask = "00/00/0000";
            this.txtFechaEmi.Name = "txtFechaEmi";
            this.txtFechaEmi.Size = new System.Drawing.Size(100, 20);
            this.txtFechaEmi.TabIndex = 19;
            this.txtFechaEmi.ValidatingType = typeof(System.DateTime);
            this.txtFechaEmi.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaEmi_Validating);
            // 
            // lstTickets0
            // 
            this.lstTickets0.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstTickets0.FullRowSelect = true;
            this.lstTickets0.HideSelection = false;
            this.lstTickets0.Location = new System.Drawing.Point(131, 63);
            this.lstTickets0.MultiSelect = false;
            this.lstTickets0.Name = "lstTickets0";
            this.lstTickets0.Size = new System.Drawing.Size(289, 82);
            this.lstTickets0.TabIndex = 17;
            this.lstTickets0.UseCompatibleStateImageBehavior = false;
            this.lstTickets0.View = System.Windows.Forms.View.Details;
            this.lstTickets0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstTickets_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serie";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nro Ticket";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha Emisión";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Digitador";
            this.columnHeader4.Width = 100;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DataSource = this.consultoriosBindingSource;
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(10, 26);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(175, 21);
            this.cmbEspecialidad.TabIndex = 16;
            this.cmbEspecialidad.ValueMember = "Id_Consultorio";
            // 
            // consultoriosBindingSource
            // 
            this.consultoriosBindingSource.DataMember = "Consultorios";
            this.consultoriosBindingSource.DataSource = this.consultoriosDS;
            // 
            // consultoriosDS
            // 
            this.consultoriosDS.DataSetName = "ConsultoriosDS";
            this.consultoriosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkOpFil
            // 
            this.chkOpFil.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOpFil.AutoSize = true;
            this.chkOpFil.Location = new System.Drawing.Point(50, 99);
            this.chkOpFil.Name = "chkOpFil";
            this.chkOpFil.Size = new System.Drawing.Size(71, 23);
            this.chkOpFil.TabIndex = 15;
            this.chkOpFil.Text = "Aplicar filtro";
            this.chkOpFil.UseVisualStyleBackColor = true;
            this.chkOpFil.CheckedChanged += new System.EventHandler(this.chkFiltro_CheckedChanged);
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroTicket.Location = new System.Drawing.Point(53, 63);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.Size = new System.Drawing.Size(74, 20);
            this.txtNroTicket.TabIndex = 11;
            this.txtNroTicket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNroDoc_KeyDown);
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(8, 63);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(42, 20);
            this.txtSerie.TabIndex = 10;
            this.txtSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie_KeyDown);
            // 
            // cmbDVenta
            // 
            this.cmbDVenta.DataSource = this.docVentaBindingSource;
            this.cmbDVenta.DisplayMember = "Descripcion";
            this.cmbDVenta.FormattingEnabled = true;
            this.cmbDVenta.Location = new System.Drawing.Point(293, 27);
            this.cmbDVenta.Name = "cmbDVenta";
            this.cmbDVenta.Size = new System.Drawing.Size(89, 21);
            this.cmbDVenta.TabIndex = 8;
            this.cmbDVenta.ValueMember = "Id_Tipo";
            // 
            // docVentaBindingSource
            // 
            this.docVentaBindingSource.DataMember = "DocVenta";
            this.docVentaBindingSource.DataSource = this.tablaTipoDS;
            // 
            // tablaTipoDS
            // 
            this.tablaTipoDS.DataSetName = "TablaTipoDS";
            this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seleccione una fila resultante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Doc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N°Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Especialidad";
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.lstPacientes);
            this.tabConsultar.Controls.Add(this.lstTickets1);
            this.tabConsultar.Controls.Add(this.txtIdPac);
            this.tabConsultar.Controls.Add(this.txtNombre);
            this.tabConsultar.Controls.Add(this.txtApeMat);
            this.tabConsultar.Controls.Add(this.txtApePat);
            this.tabConsultar.Controls.Add(this.label19);
            this.tabConsultar.Controls.Add(this.label18);
            this.tabConsultar.Controls.Add(this.label17);
            this.tabConsultar.Controls.Add(this.label16);
            this.tabConsultar.Controls.Add(this.label15);
            this.tabConsultar.Controls.Add(this.label14);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(424, 149);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "Consultar Atenciones";
            this.tabConsultar.UseVisualStyleBackColor = true;
            // 
            // lstPacientes
            // 
            this.lstPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader29});
            this.lstPacientes.FullRowSelect = true;
            this.lstPacientes.Location = new System.Drawing.Point(4, 63);
            this.lstPacientes.MultiSelect = false;
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(154, 82);
            this.lstPacientes.TabIndex = 19;
            this.lstPacientes.UseCompatibleStateImageBehavior = false;
            this.lstPacientes.View = System.Windows.Forms.View.Details;
            this.lstPacientes.SelectedIndexChanged += new System.EventHandler(this.lstPacientes_SelectedIndexChanged);
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Paciente";
            this.columnHeader29.Width = 140;
            // 
            // lstTickets1
            // 
            this.lstTickets1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26});
            this.lstTickets1.FullRowSelect = true;
            this.lstTickets1.Location = new System.Drawing.Point(162, 62);
            this.lstTickets1.MultiSelect = false;
            this.lstTickets1.Name = "lstTickets1";
            this.lstTickets1.Size = new System.Drawing.Size(262, 82);
            this.lstTickets1.TabIndex = 18;
            this.lstTickets1.UseCompatibleStateImageBehavior = false;
            this.lstTickets1.View = System.Windows.Forms.View.Details;
            this.lstTickets1.SelectedIndexChanged += new System.EventHandler(this.lstTickets1_SelectedIndexChanged);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Serie";
            this.columnHeader17.Width = 40;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Nro Ticket";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Fecha Atención";
            this.columnHeader19.Width = 80;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Digitador";
            this.columnHeader20.Width = 100;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Nro Historia";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Id Paciente";
            this.columnHeader22.Width = 40;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Descripcion";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Orden";
            this.columnHeader24.Width = 50;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Anulado";
            this.columnHeader25.Width = 70;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Fecha Emisión";
            this.columnHeader26.Width = 70;
            // 
            // txtIdPac
            // 
            this.txtIdPac.Location = new System.Drawing.Point(316, 25);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.Size = new System.Drawing.Size(100, 20);
            this.txtIdPac.TabIndex = 9;
            this.txtIdPac.TextChanged += new System.EventHandler(this.txtIdPac_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(213, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(110, 26);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(100, 20);
            this.txtApeMat.TabIndex = 7;
            this.txtApeMat.TextChanged += new System.EventHandler(this.txtApeMat_TextChanged);
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(6, 26);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(100, 20);
            this.txtApePat.TabIndex = 6;
            this.txtApePat.TextChanged += new System.EventHandler(this.txtApePat_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(160, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Listado de Atenciones";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Listado de Pacientes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(317, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "ID Paciente";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(212, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Nombres";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Apellido Materno";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Apellido Paterno";
            // 
            // cmbMedico
            // 
            this.cmbMedico.DataSource = this.tmpEspecialistaBindingSource;
            this.cmbMedico.DisplayMember = "FullEspecialista";
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(6, 250);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(71, 21);
            this.cmbMedico.TabIndex = 7;
            this.cmbMedico.ValueMember = "NCMP";
            this.cmbMedico.SelectionChangeCommitted += new System.EventHandler(this.cmbMedico_SelectionChangeCommitted);
            this.cmbMedico.Leave += new System.EventHandler(this.cmbMedico_Leave);
            // 
            // tmpEspecialistaBindingSource
            // 
            this.tmpEspecialistaBindingSource.DataMember = "tmpEspecialista";
            this.tmpEspecialistaBindingSource.DataSource = this.tmpEspecialistaDS;
            // 
            // tmpEspecialistaDS
            // 
            this.tmpEspecialistaDS.DataSetName = "tmpEspecialistaDS";
            this.tmpEspecialistaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha Aten.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Consultorio (Bus)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "CMP y Nombre del Médico o Especialista";
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(84, 250);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.ReadOnly = true;
            this.txtMedico.Size = new System.Drawing.Size(270, 20);
            this.txtMedico.TabIndex = 9;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(7, 289);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(303, 20);
            this.txtObservacion.TabIndex = 12;
            this.txtObservacion.Leave += new System.EventHandler(this.txtObservacion_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Observación";
            // 
            // cmbBus
            // 
            this.cmbBus.DataSource = this.busesBindingSource;
            this.cmbBus.DisplayMember = "Bus";
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(112, 200);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(108, 21);
            this.cmbBus.TabIndex = 14;
            this.cmbBus.ValueMember = "Id_Bus";
            this.cmbBus.Leave += new System.EventHandler(this.cmbBus_Leave);
            // 
            // busesBindingSource
            // 
            this.busesBindingSource.DataMember = "Buses";
            this.busesBindingSource.DataSource = this.busesDS;
            // 
            // busesDS
            // 
            this.busesDS.DataSetName = "BusesDS";
            this.busesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(328, 184);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "Digitador";
            // 
            // txtDigitador
            // 
            this.txtDigitador.Location = new System.Drawing.Point(330, 200);
            this.txtDigitador.Name = "txtDigitador";
            this.txtDigitador.ReadOnly = true;
            this.txtDigitador.Size = new System.Drawing.Size(100, 20);
            this.txtDigitador.TabIndex = 20;
            // 
            // cmbTurno
            // 
            this.cmbTurno.DataSource = this.turnoBindingSource;
            this.cmbTurno.DisplayMember = "Descripcion";
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(224, 199);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(103, 21);
            this.cmbTurno.TabIndex = 21;
            this.cmbTurno.ValueMember = "Id_Tipo";
            this.cmbTurno.Leave += new System.EventHandler(this.cmbTurno_Leave);
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.tablaTipoDS;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(226, 182);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Turno";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(357, 249);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.ReadOnly = true;
            this.txtCuenta.Size = new System.Drawing.Size(69, 20);
            this.txtCuenta.TabIndex = 24;
            this.txtCuenta.Text = "0";
            this.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuenta.Leave += new System.EventHandler(this.txtCuenta_Leave);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(328, 273);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(90, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "Fecha de Ingreso";
            // 
            // grpFiliacion
            // 
            this.grpFiliacion.Controls.Add(this.grdDetalle);
            this.grpFiliacion.Controls.Add(this.txtFechaEmiFil);
            this.grpFiliacion.Controls.Add(this.txtFechaNac);
            this.grpFiliacion.Controls.Add(this.txtTotal);
            this.grpFiliacion.Controls.Add(this.txtCajero);
            this.grpFiliacion.Controls.Add(this.label10);
            this.grpFiliacion.Controls.Add(this.label9);
            this.grpFiliacion.Controls.Add(this.btnVerifica);
            this.grpFiliacion.Controls.Add(this.btnBCie10);
            this.grpFiliacion.Controls.Add(this.btnGrabar);
            this.grpFiliacion.Controls.Add(this.btnQuitar);
            this.grpFiliacion.Controls.Add(this.btnAgregar);
            this.grpFiliacion.Controls.Add(this.txtEspecialidad);
            this.grpFiliacion.Controls.Add(this.label25);
            this.grpFiliacion.Controls.Add(this.label24);
            this.grpFiliacion.Controls.Add(this.txtOrden);
            this.grpFiliacion.Controls.Add(this.txtSexo);
            this.grpFiliacion.Controls.Add(this.txtEdad);
            this.grpFiliacion.Controls.Add(this.txtPaciente);
            this.grpFiliacion.Controls.Add(this.label23);
            this.grpFiliacion.Controls.Add(this.label22);
            this.grpFiliacion.Controls.Add(this.label20);
            this.grpFiliacion.Location = new System.Drawing.Point(436, 4);
            this.grpFiliacion.Name = "grpFiliacion";
            this.grpFiliacion.Size = new System.Drawing.Size(430, 310);
            this.grpFiliacion.TabIndex = 31;
            this.grpFiliacion.TabStop = false;
            this.grpFiliacion.Text = "1. FILIACIÓN:";
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.AllowUserToResizeColumns = false;
            this.grdDetalle.AllowUserToResizeRows = false;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNroHistoria,
            this.dIdProducto,
            this.dProducto,
            this.dCantidad,
            this.dPrecio,
            this.dTotal,
            this.dPagado,
            this.dDescuento,
            this.dResultado,
            this.dConclusion,
            this.dM});
            this.grdDetalle.Location = new System.Drawing.Point(14, 146);
            this.grdDetalle.MultiSelect = false;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.Size = new System.Drawing.Size(404, 91);
            this.grdDetalle.TabIndex = 63;
            this.grdDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdDetalle_EditingControlShowing);
            // 
            // dNroHistoria
            // 
            this.dNroHistoria.HeaderText = "Nro Historia";
            this.dNroHistoria.Name = "dNroHistoria";
            this.dNroHistoria.ReadOnly = true;
            this.dNroHistoria.Visible = false;
            // 
            // dIdProducto
            // 
            this.dIdProducto.HeaderText = "Id Producto";
            this.dIdProducto.Name = "dIdProducto";
            this.dIdProducto.ReadOnly = true;
            this.dIdProducto.Visible = false;
            // 
            // dProducto
            // 
            this.dProducto.HeaderText = "Producto y/o servicio";
            this.dProducto.Name = "dProducto";
            this.dProducto.ReadOnly = true;
            this.dProducto.Width = 150;
            // 
            // dCantidad
            // 
            this.dCantidad.HeaderText = "Cnt.";
            this.dCantidad.Name = "dCantidad";
            this.dCantidad.ReadOnly = true;
            this.dCantidad.Width = 50;
            // 
            // dPrecio
            // 
            this.dPrecio.HeaderText = "Prc.";
            this.dPrecio.Name = "dPrecio";
            this.dPrecio.ReadOnly = true;
            this.dPrecio.Width = 50;
            // 
            // dTotal
            // 
            this.dTotal.HeaderText = "S.Total";
            this.dTotal.Name = "dTotal";
            this.dTotal.ReadOnly = true;
            this.dTotal.Width = 50;
            // 
            // dPagado
            // 
            this.dPagado.HeaderText = "Con.";
            this.dPagado.Items.AddRange(new object[] {
            "",
            "R"});
            this.dPagado.Name = "dPagado";
            this.dPagado.ReadOnly = true;
            this.dPagado.Width = 50;
            // 
            // dDescuento
            // 
            this.dDescuento.HeaderText = "Dto.";
            this.dDescuento.Name = "dDescuento";
            this.dDescuento.ReadOnly = true;
            this.dDescuento.Width = 50;
            // 
            // dResultado
            // 
            this.dResultado.HeaderText = "Resultado";
            this.dResultado.Name = "dResultado";
            this.dResultado.ReadOnly = true;
            this.dResultado.Visible = false;
            // 
            // dConclusion
            // 
            this.dConclusion.HeaderText = "Conclusión";
            this.dConclusion.Name = "dConclusion";
            this.dConclusion.ReadOnly = true;
            this.dConclusion.Visible = false;
            // 
            // dM
            // 
            this.dM.HeaderText = "M";
            this.dM.Name = "dM";
            this.dM.ReadOnly = true;
            this.dM.Visible = false;
            // 
            // txtFechaEmiFil
            // 
            this.txtFechaEmiFil.Location = new System.Drawing.Point(306, 120);
            this.txtFechaEmiFil.Mask = "00/00/0000 90:00 aa";
            this.txtFechaEmiFil.Name = "txtFechaEmiFil";
            this.txtFechaEmiFil.ReadOnly = true;
            this.txtFechaEmiFil.Size = new System.Drawing.Size(112, 20);
            this.txtFechaEmiFil.TabIndex = 62;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(319, 38);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.ReadOnly = true;
            this.txtFechaNac.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNac.TabIndex = 61;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(240, 243);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 56;
            // 
            // txtCajero
            // 
            this.txtCajero.Location = new System.Drawing.Point(15, 244);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.ReadOnly = true;
            this.txtCajero.Size = new System.Drawing.Size(214, 20);
            this.txtCajero.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Fecha de Venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Fecha Nac.";
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(333, 271);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(75, 23);
            this.btnVerifica.TabIndex = 50;
            this.btnVerifica.Text = "&Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // btnBCie10
            // 
            this.btnBCie10.Enabled = false;
            this.btnBCie10.Location = new System.Drawing.Point(256, 271);
            this.btnBCie10.Name = "btnBCie10";
            this.btnBCie10.Size = new System.Drawing.Size(75, 23);
            this.btnBCie10.TabIndex = 49;
            this.btnBCie10.Text = "&BCie10";
            this.btnBCie10.UseVisualStyleBackColor = true;
            this.btnBCie10.Click += new System.EventHandler(this.btnBCie10_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Location = new System.Drawing.Point(179, 271);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 48;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(102, 271);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 47;
            this.btnQuitar.Text = "&Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(24, 271);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(15, 122);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(287, 20);
            this.txtEspecialidad.TabIndex = 42;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 105);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(133, 13);
            this.label25.TabIndex = 41;
            this.label25.Text = "Nombre de la Especialidad";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(174, 60);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "Especialista de la Orden";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(174, 77);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.ReadOnly = true;
            this.txtOrden.Size = new System.Drawing.Size(244, 20);
            this.txtOrden.TabIndex = 39;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(69, 76);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 38;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(13, 76);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(48, 20);
            this.txtEdad.TabIndex = 37;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(11, 38);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(303, 20);
            this.txtPaciente.TabIndex = 36;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(70, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 13);
            this.label23.TabIndex = 35;
            this.label23.Text = "Género";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 34;
            this.label22.Text = "Edad";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(172, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Apellidos y Nombres (ID Pacientes)";
            // 
            // cIE10BindingSource
            // 
            this.cIE10BindingSource.DataMember = "CIE10";
            this.cIE10BindingSource.DataSource = this.cie10DSBindingSource;
            // 
            // cie10DSBindingSource
            // 
            this.cie10DSBindingSource.DataSource = this.cie10DS;
            this.cie10DSBindingSource.Position = 0;
            // 
            // cie10DS
            // 
            this.cie10DS.DataSetName = "Cie10DS";
            this.cie10DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpEnfermedad
            // 
            this.grpEnfermedad.Controls.Add(this.txtEnAcRel);
            this.grpEnfermedad.Controls.Add(this.txtEnAcCur);
            this.grpEnfermedad.Controls.Add(this.txtEnAcIni);
            this.grpEnfermedad.Controls.Add(this.label29);
            this.grpEnfermedad.Controls.Add(this.label21);
            this.grpEnfermedad.Controls.Add(this.label13);
            this.grpEnfermedad.Location = new System.Drawing.Point(9, 322);
            this.grpEnfermedad.Name = "grpEnfermedad";
            this.grpEnfermedad.Size = new System.Drawing.Size(340, 103);
            this.grpEnfermedad.TabIndex = 32;
            this.grpEnfermedad.TabStop = false;
            this.grpEnfermedad.Text = "2. ENFERMEDAD ACTUAL :";
            // 
            // txtEnAcRel
            // 
            this.txtEnAcRel.Location = new System.Drawing.Point(8, 78);
            this.txtEnAcRel.Name = "txtEnAcRel";
            this.txtEnAcRel.Size = new System.Drawing.Size(277, 20);
            this.txtEnAcRel.TabIndex = 5;
            // 
            // txtEnAcCur
            // 
            this.txtEnAcCur.Location = new System.Drawing.Point(166, 35);
            this.txtEnAcCur.Name = "txtEnAcCur";
            this.txtEnAcCur.Size = new System.Drawing.Size(120, 20);
            this.txtEnAcCur.TabIndex = 4;
            // 
            // txtEnAcIni
            // 
            this.txtEnAcIni.Location = new System.Drawing.Point(8, 35);
            this.txtEnAcIni.Name = "txtEnAcIni";
            this.txtEnAcIni.Size = new System.Drawing.Size(152, 20);
            this.txtEnAcIni.TabIndex = 3;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 60);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(50, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "Relato ...";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(166, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Curso ...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Inicio ...";
            // 
            // grpAntecedentes
            // 
            this.grpAntecedentes.Controls.Add(this.txtAnOtr);
            this.grpAntecedentes.Controls.Add(this.label43);
            this.grpAntecedentes.Controls.Add(this.txtAnQui);
            this.grpAntecedentes.Controls.Add(this.txtAnEpi);
            this.grpAntecedentes.Controls.Add(this.txtAnFam);
            this.grpAntecedentes.Controls.Add(this.txtAnPer);
            this.grpAntecedentes.Controls.Add(this.label33);
            this.grpAntecedentes.Controls.Add(this.label32);
            this.grpAntecedentes.Controls.Add(this.label31);
            this.grpAntecedentes.Controls.Add(this.label30);
            this.grpAntecedentes.Location = new System.Drawing.Point(353, 319);
            this.grpAntecedentes.Name = "grpAntecedentes";
            this.grpAntecedentes.Size = new System.Drawing.Size(510, 108);
            this.grpAntecedentes.TabIndex = 33;
            this.grpAntecedentes.TabStop = false;
            this.grpAntecedentes.Text = "3. ANTECEDENTES:";
            // 
            // txtAnOtr
            // 
            this.txtAnOtr.Location = new System.Drawing.Point(333, 70);
            this.txtAnOtr.Name = "txtAnOtr";
            this.txtAnOtr.Size = new System.Drawing.Size(172, 20);
            this.txtAnOtr.TabIndex = 43;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(335, 56);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(44, 13);
            this.label43.TabIndex = 42;
            this.label43.Text = "Otros ...";
            // 
            // txtAnQui
            // 
            this.txtAnQui.Location = new System.Drawing.Point(186, 71);
            this.txtAnQui.Name = "txtAnQui";
            this.txtAnQui.Size = new System.Drawing.Size(143, 20);
            this.txtAnQui.TabIndex = 41;
            // 
            // txtAnEpi
            // 
            this.txtAnEpi.Location = new System.Drawing.Point(13, 72);
            this.txtAnEpi.Name = "txtAnEpi";
            this.txtAnEpi.Size = new System.Drawing.Size(167, 20);
            this.txtAnEpi.TabIndex = 40;
            // 
            // txtAnFam
            // 
            this.txtAnFam.Location = new System.Drawing.Point(289, 31);
            this.txtAnFam.Name = "txtAnFam";
            this.txtAnFam.Size = new System.Drawing.Size(212, 20);
            this.txtAnFam.TabIndex = 39;
            // 
            // txtAnPer
            // 
            this.txtAnPer.Location = new System.Drawing.Point(11, 32);
            this.txtAnPer.Name = "txtAnPer";
            this.txtAnPer.Size = new System.Drawing.Size(268, 20);
            this.txtAnPer.TabIndex = 38;
            this.txtAnPer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnPer_KeyDown);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(186, 55);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(72, 13);
            this.label33.TabIndex = 37;
            this.label33.Text = "Quirúrgicos ...";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 57);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 13);
            this.label32.TabIndex = 36;
            this.label32.Text = "Epidemológios ...";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(289, 14);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 13);
            this.label31.TabIndex = 35;
            this.label31.Text = "Familiares ...";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(11, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 13);
            this.label30.TabIndex = 34;
            this.label30.Text = "Personales ...";
            // 
            // grpExClinico
            // 
            this.grpExClinico.Controls.Add(this.txtExClEg);
            this.grpExClinico.Controls.Add(this.txtExClFr);
            this.grpExClinico.Controls.Add(this.txtExClTm);
            this.grpExClinico.Controls.Add(this.txtExClFc);
            this.grpExClinico.Controls.Add(this.txtExClPa);
            this.grpExClinico.Controls.Add(this.txtExClTl);
            this.grpExClinico.Controls.Add(this.txtExClPs);
            this.grpExClinico.Controls.Add(this.label40);
            this.grpExClinico.Controls.Add(this.label39);
            this.grpExClinico.Controls.Add(this.label38);
            this.grpExClinico.Controls.Add(this.label37);
            this.grpExClinico.Controls.Add(this.label36);
            this.grpExClinico.Controls.Add(this.label35);
            this.grpExClinico.Controls.Add(this.label34);
            this.grpExClinico.Location = new System.Drawing.Point(7, 429);
            this.grpExClinico.Name = "grpExClinico";
            this.grpExClinico.Size = new System.Drawing.Size(347, 105);
            this.grpExClinico.TabIndex = 34;
            this.grpExClinico.TabStop = false;
            this.grpExClinico.Text = "4. EXAMEN CLÍNICO:";
            // 
            // txtExClEg
            // 
            this.txtExClEg.Location = new System.Drawing.Point(9, 70);
            this.txtExClEg.Name = "txtExClEg";
            this.txtExClEg.Size = new System.Drawing.Size(332, 20);
            this.txtExClEg.TabIndex = 49;
            // 
            // txtExClFr
            // 
            this.txtExClFr.Location = new System.Drawing.Point(264, 31);
            this.txtExClFr.Name = "txtExClFr";
            this.txtExClFr.Size = new System.Drawing.Size(37, 20);
            this.txtExClFr.TabIndex = 48;
            // 
            // txtExClTm
            // 
            this.txtExClTm.Location = new System.Drawing.Point(304, 31);
            this.txtExClTm.Name = "txtExClTm";
            this.txtExClTm.Size = new System.Drawing.Size(37, 20);
            this.txtExClTm.TabIndex = 47;
            // 
            // txtExClFc
            // 
            this.txtExClFc.Location = new System.Drawing.Point(225, 31);
            this.txtExClFc.Name = "txtExClFc";
            this.txtExClFc.Size = new System.Drawing.Size(35, 20);
            this.txtExClFc.TabIndex = 46;
            // 
            // txtExClPa
            // 
            this.txtExClPa.Location = new System.Drawing.Point(143, 31);
            this.txtExClPa.Name = "txtExClPa";
            this.txtExClPa.Size = new System.Drawing.Size(78, 20);
            this.txtExClPa.TabIndex = 45;
            // 
            // txtExClTl
            // 
            this.txtExClTl.Location = new System.Drawing.Point(78, 31);
            this.txtExClTl.Name = "txtExClTl";
            this.txtExClTl.Size = new System.Drawing.Size(60, 20);
            this.txtExClTl.TabIndex = 44;
            // 
            // txtExClPs
            // 
            this.txtExClPs.Location = new System.Drawing.Point(8, 31);
            this.txtExClPs.Name = "txtExClPs";
            this.txtExClPs.Size = new System.Drawing.Size(66, 20);
            this.txtExClPs.TabIndex = 43;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(9, 54);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(85, 13);
            this.label40.TabIndex = 41;
            this.label40.Text = "Exámen General";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(303, 15);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 13);
            this.label39.TabIndex = 40;
            this.label39.Text = "T(°C)";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(265, 15);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(21, 13);
            this.label38.TabIndex = 39;
            this.label38.Text = "FR";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(225, 15);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(20, 13);
            this.label37.TabIndex = 38;
            this.label37.Text = "FC";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(144, 14);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(50, 13);
            this.label36.TabIndex = 37;
            this.label36.Text = "Pres. Art.";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(78, 14);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(30, 13);
            this.label35.TabIndex = 36;
            this.label35.Text = "Talla";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(8, 16);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(31, 13);
            this.label34.TabIndex = 35;
            this.label34.Text = "Peso";
            // 
            // groupBoxTraMed
            // 
            this.groupBoxTraMed.Controls.Add(this.grdTraMed);
            this.groupBoxTraMed.Location = new System.Drawing.Point(360, 434);
            this.groupBoxTraMed.Name = "groupBoxTraMed";
            this.groupBoxTraMed.Size = new System.Drawing.Size(506, 100);
            this.groupBoxTraMed.TabIndex = 35;
            this.groupBoxTraMed.TabStop = false;
            this.groupBoxTraMed.Text = "7. TRATAMIENTO";
            // 
            // grdTraMed
            // 
            this.grdTraMed.AllowUserToAddRows = false;
            this.grdTraMed.AllowUserToDeleteRows = false;
            this.grdTraMed.AllowUserToResizeColumns = false;
            this.grdTraMed.AllowUserToResizeRows = false;
            this.grdTraMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTraMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tMedicamento,
            this.tPresentacion,
            this.tCantidad,
            this.tDosis,
            this.tDias});
            this.grdTraMed.Location = new System.Drawing.Point(5, 15);
            this.grdTraMed.MultiSelect = false;
            this.grdTraMed.Name = "grdTraMed";
            this.grdTraMed.RowHeadersVisible = false;
            this.grdTraMed.Size = new System.Drawing.Size(496, 80);
            this.grdTraMed.TabIndex = 61;
            this.grdTraMed.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdTraMed_EditingControlShowing);
            this.grdTraMed.Enter += new System.EventHandler(this.grdTraMed_Enter);
            // 
            // tMedicamento
            // 
            this.tMedicamento.HeaderText = "Nombre de medicamento";
            this.tMedicamento.Name = "tMedicamento";
            this.tMedicamento.Width = 180;
            // 
            // tPresentacion
            // 
            this.tPresentacion.HeaderText = "Presentación";
            this.tPresentacion.Name = "tPresentacion";
            // 
            // tCantidad
            // 
            this.tCantidad.HeaderText = "Cant.";
            this.tCantidad.Name = "tCantidad";
            this.tCantidad.Width = 50;
            // 
            // tDosis
            // 
            this.tDosis.HeaderText = "Dósis";
            this.tDosis.Name = "tDosis";
            this.tDosis.Width = 110;
            // 
            // tDias
            // 
            this.tDias.HeaderText = "Días";
            this.tDias.Name = "tDias";
            this.tDias.Width = 50;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(12, 544);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(158, 13);
            this.label41.TabIndex = 36;
            this.label41.Text = "5. IMPRESIÓN DIAGNÓSTICA:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(430, 541);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(187, 13);
            this.label42.TabIndex = 37;
            this.label42.Text = "6. PROCEDIMIENTOS - EXÁMENES:";
            // 
            // consultoriosTableAdapter
            // 
            this.consultoriosTableAdapter.ClearBeforeFill = true;
            // 
            // chkIdem
            // 
            this.chkIdem.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIdem.AutoSize = true;
            this.chkIdem.Location = new System.Drawing.Point(359, 223);
            this.chkIdem.Name = "chkIdem";
            this.chkIdem.Size = new System.Drawing.Size(40, 23);
            this.chkIdem.TabIndex = 38;
            this.chkIdem.Text = "Idem";
            this.chkIdem.UseVisualStyleBackColor = true;
            this.chkIdem.CheckedChanged += new System.EventHandler(this.chkIdem_CheckedChanged);
            // 
            // txtTi
            // 
            this.txtTi.Location = new System.Drawing.Point(328, 1);
            this.txtTi.Name = "txtTi";
            this.txtTi.ReadOnly = true;
            this.txtTi.Size = new System.Drawing.Size(100, 20);
            this.txtTi.TabIndex = 54;
            this.txtTi.Text = "0";
            this.txtTi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkCompleto
            // 
            this.chkCompleto.AutoSize = true;
            this.chkCompleto.Location = new System.Drawing.Point(200, 4);
            this.chkCompleto.Name = "chkCompleto";
            this.chkCompleto.Size = new System.Drawing.Size(70, 17);
            this.chkCompleto.TabIndex = 56;
            this.chkCompleto.Text = "Completo";
            this.chkCompleto.UseVisualStyleBackColor = true;
            // 
            // grdDetCie10
            // 
            this.grdDetCie10.AllowUserToAddRows = false;
            this.grdDetCie10.AllowUserToDeleteRows = false;
            this.grdDetCie10.AllowUserToResizeColumns = false;
            this.grdDetCie10.AllowUserToResizeRows = false;
            this.grdDetCie10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetCie10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNroHistoria,
            this.cCie10,
            this.cDescripcion,
            this.cProcedimiento});
            this.grdDetCie10.Location = new System.Drawing.Point(10, 560);
            this.grdDetCie10.MultiSelect = false;
            this.grdDetCie10.Name = "grdDetCie10";
            this.grdDetCie10.RowHeadersVisible = false;
            this.grdDetCie10.Size = new System.Drawing.Size(845, 81);
            this.grdDetCie10.TabIndex = 58;
            this.grdDetCie10.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdDetCie10_CellBeginEdit);
            this.grdDetCie10.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetCie10_CellClick);
            this.grdDetCie10.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetCie10_CellEndEdit);
            this.grdDetCie10.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetCie10_CellEnter);
            this.grdDetCie10.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdDetCie10_EditingControlShowing);
            this.grdDetCie10.Validated += new System.EventHandler(this.grdDetCie10_Validated);
            // 
            // cNroHistoria
            // 
            this.cNroHistoria.HeaderText = "NroH istoria";
            this.cNroHistoria.Name = "cNroHistoria";
            this.cNroHistoria.Visible = false;
            // 
            // cCie10
            // 
            this.cCie10.DataSource = this.cIE10BindingSource;
            this.cCie10.DisplayMember = "CIE10";
            this.cCie10.HeaderText = "Cie10";
            this.cCie10.Name = "cCie10";
            this.cCie10.ValueMember = "CIE10";
            this.cCie10.Width = 90;
            // 
            // cDescripcion
            // 
            this.cDescripcion.HeaderText = "Descripción del diagnóstico";
            this.cDescripcion.Name = "cDescripcion";
            this.cDescripcion.ReadOnly = true;
            this.cDescripcion.Width = 370;
            // 
            // cProcedimiento
            // 
            this.cProcedimiento.HeaderText = "Procedimientos, exámenes aux, inervenciones...";
            this.cProcedimiento.Name = "cProcedimiento";
            this.cProcedimiento.Width = 370;
            // 
            // txtFechaAten
            // 
            this.txtFechaAten.Location = new System.Drawing.Point(9, 200);
            this.txtFechaAten.Mask = "00/00/0000";
            this.txtFechaAten.Name = "txtFechaAten";
            this.txtFechaAten.Size = new System.Drawing.Size(100, 20);
            this.txtFechaAten.TabIndex = 59;
            this.txtFechaAten.ValidatingType = typeof(System.DateTime);
            this.txtFechaAten.Leave += new System.EventHandler(this.txtFechaAten_Leave);
            this.txtFechaAten.Validating += new System.ComponentModel.CancelEventHandler(this.txtFechaAten_Validating);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(314, 288);
            this.txtFechaIngreso.Mask = "00/00/0000 90:00 aa";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.ReadOnly = true;
            this.txtFechaIngreso.Size = new System.Drawing.Size(115, 20);
            this.txtFechaIngreso.TabIndex = 60;
            // 
            // busesTableAdapter
            // 
            this.busesTableAdapter.ClearBeforeFill = true;
            // 
            // tmpEspecialistaTableAdapter
            // 
            this.tmpEspecialistaTableAdapter.ClearBeforeFill = true;
            // 
            // cIE10TableAdapter
            // 
            this.cIE10TableAdapter.ClearBeforeFill = true;
            // 
            // docVentaTableAdapter
            // 
            this.docVentaTableAdapter.ClearBeforeFill = true;
            // 
            // turnoTableAdapter
            // 
            this.turnoTableAdapter.ClearBeforeFill = true;
            // 
            // frmIngresoCie10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 647);
            this.ControlBox = false;
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtFechaAten);
            this.Controls.Add(this.grdDetCie10);
            this.Controls.Add(this.chkCompleto);
            this.Controls.Add(this.txtTi);
            this.Controls.Add(this.chkIdem);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.groupBoxTraMed);
            this.Controls.Add(this.grpExClinico);
            this.Controls.Add(this.grpAntecedentes);
            this.Controls.Add(this.grpEnfermedad);
            this.Controls.Add(this.grpFiliacion);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.txtDigitador);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabIngresoConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmIngresoCie10";
            this.Text = "Ingreso y Consulta de Atenciones Realizadas (epicrisis, diagnóstico, tratamiento," +
    " etc.)";
            this.Load += new System.EventHandler(this.frmIngresoCie10_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIngresoCie10_KeyDown);
            this.tabIngresoConsulta.ResumeLayout(false);
            this.tabIngresar.ResumeLayout(false);
            this.tabIngresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
            this.tabConsultar.ResumeLayout(false);
            this.tabConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmpEspecialistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpEspecialistaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            this.grpFiliacion.ResumeLayout(false);
            this.grpFiliacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIE10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cie10DSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cie10DS)).EndInit();
            this.grpEnfermedad.ResumeLayout(false);
            this.grpEnfermedad.PerformLayout();
            this.grpAntecedentes.ResumeLayout(false);
            this.grpAntecedentes.PerformLayout();
            this.grpExClinico.ResumeLayout(false);
            this.grpExClinico.PerformLayout();
            this.groupBoxTraMed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTraMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetCie10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabIngresoConsulta;
        private System.Windows.Forms.TabPage tabIngresar;
        private System.Windows.Forms.TextBox txtNroTicket;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.ComboBox cmbDVenta;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.TextBox txtIdPac;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox grpEnfermedad;
        private System.Windows.Forms.TextBox txtEnAcRel;
        private System.Windows.Forms.TextBox txtEnAcCur;
        private System.Windows.Forms.TextBox txtEnAcIni;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpFiliacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Button btnBCie10;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.TextBox txtDigitador;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox grpExClinico;
        private System.Windows.Forms.TextBox txtExClFr;
        private System.Windows.Forms.TextBox txtExClTm;
        private System.Windows.Forms.TextBox txtExClFc;
        private System.Windows.Forms.TextBox txtExClPa;
        private System.Windows.Forms.TextBox txtExClTl;
        private System.Windows.Forms.TextBox txtExClPs;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox grpAntecedentes;
        private System.Windows.Forms.TextBox txtAnQui;
        private System.Windows.Forms.TextBox txtAnEpi;
        private System.Windows.Forms.TextBox txtAnFam;
        private System.Windows.Forms.TextBox txtAnPer;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBoxTraMed;
        private System.Windows.Forms.TextBox txtExClEg;
        private System.Windows.Forms.TextBox txtAnOtr;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.BindingSource consultoriosBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.ConsultoriosTableAdapter consultoriosTableAdapter;
        private System.Windows.Forms.CheckBox chkOpFil;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ListView lstTickets0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox chkIdem;
        private System.Windows.Forms.TextBox txtTi;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.ListView lstTickets1;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ListView lstPacientes;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.CheckBox chkCompleto;
        private System.Windows.Forms.DataGridView grdDetCie10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtFechaEmi;
        private System.Windows.Forms.MaskedTextBox txtFechaAten;
        private System.Windows.Forms.MaskedTextBox txtFechaIngreso;
        private System.Windows.Forms.MaskedTextBox txtFechaEmiFil;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private System.Windows.Forms.BindingSource busesBindingSource;
        private Dominio.Data.BusesDS busesDS;
        private Dominio.Data.BusesDSTableAdapters.BusesTableAdapter busesTableAdapter;
        private System.Windows.Forms.BindingSource tmpEspecialistaBindingSource;
        private Dominio.Data.tmpEspecialistaDS tmpEspecialistaDS;
        private Dominio.Data.tmpEspecialistaDSTableAdapters.tmpEspecialistaTableAdapter tmpEspecialistaTableAdapter;
        private Dominio.Data.Cie10DS cie10DS;
        private System.Windows.Forms.BindingSource cie10DSBindingSource;
        private System.Windows.Forms.BindingSource cIE10BindingSource;
        private Dominio.Data.Cie10DSTableAdapters.CIE10TableAdapter cIE10TableAdapter;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource docVentaBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.DocVentaTableAdapter docVentaTableAdapter;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TurnoTableAdapter turnoTableAdapter;
        private System.Windows.Forms.DataGridView grdTraMed;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPresentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNroHistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotal;
        private System.Windows.Forms.DataGridViewComboBoxColumn dPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dConclusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNroHistoria;
        private System.Windows.Forms.DataGridViewComboBoxColumn cCie10;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProcedimiento;
    }
}