namespace Polsolcom.Forms.Procesos
{
	partial class frmSHClinica
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSHClinica));
            TenTec.Windows.iGridLib.iGColPattern iGColPattern26 = new TenTec.Windows.iGridLib.iGColPattern();
            TenTec.Windows.iGridLib.iGColPattern iGColPattern27 = new TenTec.Windows.iGridLib.iGColPattern();
            TenTec.Windows.iGridLib.iGColPattern iGColPattern28 = new TenTec.Windows.iGridLib.iGColPattern();
            TenTec.Windows.iGridLib.iGColPattern iGColPattern29 = new TenTec.Windows.iGridLib.iGColPattern();
            TenTec.Windows.iGridLib.iGColPattern iGColPattern30 = new TenTec.Windows.iGridLib.iGColPattern();
            this.iGridCol0CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGDDL = new TenTec.Windows.iGridLib.iGDropDownList();
            this.iGridCol0ColHdrStyle1 = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGridCol1CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGridCol1ColHdrStyle1 = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGridCol2CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGridCol2ColHdrStyle1 = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGridCol3CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGridCol3ColHdrStyle1 = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGridCol4CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGridCol4ColHdrStyle1 = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDigitador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIGV = new System.Windows.Forms.ComboBox();
            this.cmbTDoc = new System.Windows.Forms.ComboBox();
            this.txtNHP = new System.Windows.Forms.TextBox();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.cmbMVen = new System.Windows.Forms.ComboBox();
            this.txtFechaEmision = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDuplica = new System.Windows.Forms.Button();
            this.btnBuscat = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInst = new System.Windows.Forms.Button();
            this.chkInst = new System.Windows.Forms.CheckBox();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbInstitucion = new System.Windows.Forms.ComboBox();
            this.institucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institucionesDS = new Polsolcom.Dominio.Data.InstitucionesDS();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.consultoriosSHClinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAsegurado = new System.Windows.Forms.TextBox();
            this.txtODoc = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.distritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distritoDS = new Polsolcom.Dominio.Data.DistritoDS();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasDS = new Polsolcom.Dominio.Data.ProvinciasDS();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosDS = new Polsolcom.Dominio.Data.DepartamentosDS();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtAutoriza = new System.Windows.Forms.TextBox();
            this.txtSon = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.fGrid = new TenTec.Windows.iGridLib.iGrid();
            this.iGrid1DefaultCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.iGrid1DefaultColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            this.iGrid1RowTextColCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            this.departamentosTableAdapter = new Polsolcom.Dominio.Data.DepartamentosDSTableAdapters.DepartamentosTableAdapter();
            this.provinciasTableAdapter = new Polsolcom.Dominio.Data.ProvinciasDSTableAdapters.ProvinciasTableAdapter();
            this.distritoTableAdapter = new Polsolcom.Dominio.Data.DistritoDSTableAdapters.DistritoTableAdapter();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.grddetalleC1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grddetalleC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grddetalleC3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grddetalleC4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institucionTableAdapter = new Polsolcom.Dominio.Data.InstitucionesDSTableAdapters.InstitucionTableAdapter();
            this.consultoriosSHClinicaTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.ConsultoriosSHClinicaTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.institucionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institucionesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosSHClinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // iGridCol0CellStyle
            // 
            this.iGridCol0CellStyle.DropDownControl = this.iGDDL;
            this.iGridCol0CellStyle.EmptyStringAs = TenTec.Windows.iGridLib.iGEmptyStringAs.EmptyString;
            // 
            // iGDDL
            // 
            this.iGDDL.BackColor = System.Drawing.Color.Empty;
            this.iGDDL.ForeColor = System.Drawing.Color.Empty;
            this.iGDDL.SelItemBackColor = System.Drawing.Color.Empty;
            this.iGDDL.SelItemForeColor = System.Drawing.Color.Empty;
            this.iGDDL.SelectedItemChanged += new TenTec.Windows.iGridLib.iGSelectedItemChangedEventHandler(this.iGDDL_SelectedItemChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtDigitador);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbIGV);
            this.groupBox1.Controls.Add(this.cmbTDoc);
            this.groupBox1.Controls.Add(this.txtNHP);
            this.groupBox1.Controls.Add(this.txtNroTicket);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.cmbMVen);
            this.groupBox1.Controls.Add(this.txtFechaEmision);
            this.groupBox1.Location = new System.Drawing.Point(4, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDigitador
            // 
            this.txtDigitador.BackColor = System.Drawing.Color.Gold;
            this.txtDigitador.Location = new System.Drawing.Point(368, 24);
            this.txtDigitador.Name = "txtDigitador";
            this.txtDigitador.ReadOnly = true;
            this.txtDigitador.Size = new System.Drawing.Size(90, 20);
            this.txtDigitador.TabIndex = 5;
            this.txtDigitador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDigitador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(550, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "IGV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "N° Historia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cajero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "N° Doc Ven";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Doc. Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mod. Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha Emision";
            // 
            // cmbIGV
            // 
            this.cmbIGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIGV.FormattingEnabled = true;
            this.cmbIGV.Location = new System.Drawing.Point(541, 24);
            this.cmbIGV.Name = "cmbIGV";
            this.cmbIGV.Size = new System.Drawing.Size(50, 21);
            this.cmbIGV.Sorted = true;
            this.cmbIGV.TabIndex = 7;
            this.cmbIGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // cmbTDoc
            // 
            this.cmbTDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTDoc.FormattingEnabled = true;
            this.cmbTDoc.Location = new System.Drawing.Point(168, 24);
            this.cmbTDoc.Name = "cmbTDoc";
            this.cmbTDoc.Size = new System.Drawing.Size(83, 21);
            this.cmbTDoc.Sorted = true;
            this.cmbTDoc.TabIndex = 2;
            this.cmbTDoc.Leave += new System.EventHandler(this.cmbTDoc_Leave);
            // 
            // txtNHP
            // 
            this.txtNHP.BackColor = System.Drawing.SystemColors.Window;
            this.txtNHP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNHP.Location = new System.Drawing.Point(458, 24);
            this.txtNHP.Name = "txtNHP";
            this.txtNHP.ReadOnly = true;
            this.txtNHP.Size = new System.Drawing.Size(81, 20);
            this.txtNHP.TabIndex = 6;
            this.txtNHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNHP.DoubleClick += new System.EventHandler(this.txtNHP_DoubleClick);
            this.txtNHP.Leave += new System.EventHandler(this.txtNHP_Leave);
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.BackColor = System.Drawing.SystemColors.Window;
            this.txtNroTicket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroTicket.ForeColor = System.Drawing.Color.Navy;
            this.txtNroTicket.Location = new System.Drawing.Point(294, 24);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.ReadOnly = true;
            this.txtNroTicket.Size = new System.Drawing.Size(73, 20);
            this.txtNroTicket.TabIndex = 4;
            this.txtNroTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroTicket.DoubleClick += new System.EventHandler(this.txtNroTicket_DoubleClick);
            this.txtNroTicket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNroTicket_KeyDown);
            this.txtNroTicket.Leave += new System.EventHandler(this.txtNroTicket_Leave);
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.Gold;
            this.txtSerie.Location = new System.Drawing.Point(252, 24);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(42, 20);
            this.txtSerie.TabIndex = 3;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // cmbMVen
            // 
            this.cmbMVen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMVen.FormattingEnabled = true;
            this.cmbMVen.Location = new System.Drawing.Point(88, 24);
            this.cmbMVen.Name = "cmbMVen";
            this.cmbMVen.Size = new System.Drawing.Size(78, 21);
            this.cmbMVen.Sorted = true;
            this.cmbMVen.TabIndex = 1;
            this.cmbMVen.Leave += new System.EventHandler(this.cmbMVen_Leave);
            // 
            // txtFechaEmision
            // 
            this.txtFechaEmision.Location = new System.Drawing.Point(4, 24);
            this.txtFechaEmision.Mask = "00/00/0000";
            this.txtFechaEmision.Name = "txtFechaEmision";
            this.txtFechaEmision.Size = new System.Drawing.Size(83, 20);
            this.txtFechaEmision.TabIndex = 0;
            this.txtFechaEmision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaEmision.ValidatingType = typeof(System.DateTime);
            this.txtFechaEmision.DoubleClick += new System.EventHandler(this.txtFechaEmision_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnDuplica);
            this.groupBox2.Controls.Add(this.btnBuscat);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(602, -3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(3, 381);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 39);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.Text = "&Imprimir Venta";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitar.Location = new System.Drawing.Point(3, 305);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(110, 39);
            this.btnQuitar.TabIndex = 32;
            this.btnQuitar.Text = "&Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            this.btnQuitar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(3, 263);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 39);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // btnDuplica
            // 
            this.btnDuplica.Enabled = false;
            this.btnDuplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplica.Image = ((System.Drawing.Image)(resources.GetObject("btnDuplica.Image")));
            this.btnDuplica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuplica.Location = new System.Drawing.Point(3, 96);
            this.btnDuplica.Name = "btnDuplica";
            this.btnDuplica.Size = new System.Drawing.Size(110, 39);
            this.btnDuplica.TabIndex = 29;
            this.btnDuplica.Text = "&Duplica Venta";
            this.btnDuplica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDuplica.UseVisualStyleBackColor = true;
            this.btnDuplica.Click += new System.EventHandler(this.btnDuplica_Click);
            this.btnDuplica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // btnBuscat
            // 
            this.btnBuscat.Enabled = false;
            this.btnBuscat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscat.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscat.Image")));
            this.btnBuscat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscat.Location = new System.Drawing.Point(3, 138);
            this.btnBuscat.Name = "btnBuscat";
            this.btnBuscat.Size = new System.Drawing.Size(110, 39);
            this.btnBuscat.TabIndex = 30;
            this.btnBuscat.Text = "Buscar &Venta";
            this.btnBuscat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscat.UseVisualStyleBackColor = true;
            this.btnBuscat.Click += new System.EventHandler(this.btnBuscat_Click);
            this.btnBuscat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(3, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 39);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "&Buscar Paciente";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(3, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 39);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "&Nuevo Paciente";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.btnInst);
            this.groupBox3.Controls.Add(this.chkInst);
            this.groupBox3.Controls.Add(this.cmbMedico);
            this.groupBox3.Controls.Add(this.cmbInstitucion);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.cmbEspecialidad);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txtAsegurado);
            this.groupBox3.Controls.Add(this.txtODoc);
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.cmbDistrito);
            this.groupBox3.Controls.Add(this.cmbProvincia);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.cmbDepartamento);
            this.groupBox3.Controls.Add(this.txtDireccion);
            this.groupBox3.Controls.Add(this.txtEdad);
            this.groupBox3.Controls.Add(this.txtFechaNac);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtDNI);
            this.groupBox3.Controls.Add(this.txtSexo);
            this.groupBox3.Controls.Add(this.txtApeMaterno);
            this.groupBox3.Controls.Add(this.txtApePaterno);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtIdPaciente);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(4, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnInst
            // 
            this.btnInst.Location = new System.Drawing.Point(187, 151);
            this.btnInst.Name = "btnInst";
            this.btnInst.Size = new System.Drawing.Size(41, 20);
            this.btnInst.TabIndex = 49;
            this.btnInst.Text = "...";
            this.btnInst.UseVisualStyleBackColor = true;
            this.btnInst.Click += new System.EventHandler(this.btnInst_Click);
            // 
            // chkInst
            // 
            this.chkInst.AutoSize = true;
            this.chkInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInst.Location = new System.Drawing.Point(2, 154);
            this.chkInst.Name = "chkInst";
            this.chkInst.Size = new System.Drawing.Size(147, 17);
            this.chkInst.TabIndex = 48;
            this.chkInst.Text = "Institución o empresa";
            this.chkInst.UseVisualStyleBackColor = true;
            this.chkInst.CheckedChanged += new System.EventHandler(this.chkInst_CheckedChanged);
            // 
            // cmbMedico
            // 
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(229, 170);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(363, 21);
            this.cmbMedico.Sorted = true;
            this.cmbMedico.TabIndex = 26;
            this.cmbMedico.SelectionChangeCommitted += new System.EventHandler(this.cmbMedico_SelectionChangeCommitted);
            this.cmbMedico.Leave += new System.EventHandler(this.cmbMedico_Leave);
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.DataSource = this.institucionBindingSource;
            this.cmbInstitucion.DisplayMember = "Nom_Raz_Soc";
            this.cmbInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstitucion.FormattingEnabled = true;
            this.cmbInstitucion.Location = new System.Drawing.Point(3, 170);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Size = new System.Drawing.Size(222, 21);
            this.cmbInstitucion.TabIndex = 25;
            this.cmbInstitucion.ValueMember = "Id_Inst";
            this.cmbInstitucion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbInstitucion_KeyDown);
            // 
            // institucionBindingSource
            // 
            this.institucionBindingSource.DataMember = "Institucion";
            this.institucionBindingSource.DataSource = this.institucionesDS;
            // 
            // institucionesDS
            // 
            this.institucionesDS.DataSetName = "InstitucionesDS";
            this.institucionesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(313, 157);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(217, 13);
            this.label27.TabIndex = 47;
            this.label27.Text = "Especialista de la Orden de Atencion";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DataSource = this.consultoriosSHClinicaBindingSource;
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(303, 135);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(288, 21);
            this.cmbEspecialidad.TabIndex = 24;
            this.cmbEspecialidad.ValueMember = "Id_Consultorio";
            this.cmbEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cmbEspecialidad_SelectionChangeCommitted);
            // 
            // consultoriosSHClinicaBindingSource
            // 
            this.consultoriosSHClinicaBindingSource.DataMember = "ConsultoriosSHClinica";
            this.consultoriosSHClinicaBindingSource.DataSource = this.consultoriosDS;
            // 
            // consultoriosDS
            // 
            this.consultoriosDS.DataSetName = "ConsultoriosDS";
            this.consultoriosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(5, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 20);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.DoubleClick += new System.EventHandler(this.txtEmail_DoubleClick);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(408, 121);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 13);
            this.label25.TabIndex = 43;
            this.label25.Text = "Especialidad";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(74, 121);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(158, 13);
            this.label24.TabIndex = 42;
            this.label24.Text = "Correo Electronico (E-mail)";
            // 
            // txtAsegurado
            // 
            this.txtAsegurado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsegurado.Location = new System.Drawing.Point(568, 97);
            this.txtAsegurado.MaxLength = 1;
            this.txtAsegurado.Name = "txtAsegurado";
            this.txtAsegurado.Size = new System.Drawing.Size(24, 20);
            this.txtAsegurado.TabIndex = 22;
            this.txtAsegurado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAsegurado.DoubleClick += new System.EventHandler(this.txtAsegurado_DoubleClick);
            this.txtAsegurado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAsegurado_KeyDown);
            this.txtAsegurado.Leave += new System.EventHandler(this.txtAsegurado_Leave);
            // 
            // txtODoc
            // 
            this.txtODoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtODoc.Location = new System.Drawing.Point(445, 97);
            this.txtODoc.Name = "txtODoc";
            this.txtODoc.Size = new System.Drawing.Size(122, 20);
            this.txtODoc.TabIndex = 21;
            this.txtODoc.DoubleClick += new System.EventHandler(this.txtODoc_DoubleClick);
            this.txtODoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtODoc_KeyDown);
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(280, 97);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(164, 20);
            this.txtTelefono.TabIndex = 20;
            this.txtTelefono.DoubleClick += new System.EventHandler(this.txtTelefono_DoubleClick);
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyDown);
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.DataSource = this.distritoBindingSource;
            this.cmbDistrito.DisplayMember = "Distrito";
            this.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(141, 97);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(136, 21);
            this.cmbDistrito.TabIndex = 19;
            this.cmbDistrito.ValueMember = "Id_Old";
            this.cmbDistrito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDistrito_KeyDown);
            this.cmbDistrito.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbDistrito_MouseDoubleClick);
            // 
            // distritoBindingSource
            // 
            this.distritoBindingSource.DataMember = "Distrito";
            this.distritoBindingSource.DataSource = this.distritoDS;
            // 
            // distritoDS
            // 
            this.distritoDS.DataSetName = "DistritoDS";
            this.distritoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DataSource = this.provinciasBindingSource;
            this.cmbProvincia.DisplayMember = "Provincia";
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(5, 97);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(133, 21);
            this.cmbProvincia.TabIndex = 18;
            this.cmbProvincia.ValueMember = "Id_Old";
            this.cmbProvincia.SelectionChangeCommitted += new System.EventHandler(this.cmbProvincia_SelectionChangeCommitted);
            this.cmbProvincia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProvincia_KeyDown);
            this.cmbProvincia.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbProvincia_MouseDoubleClick);
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "Provincias";
            this.provinciasBindingSource.DataSource = this.provinciasDS;
            // 
            // provinciasDS
            // 
            this.provinciasDS.DataSetName = "ProvinciasDS";
            this.provinciasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(565, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 36;
            this.label23.Text = "Asg";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(480, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "Otro Doc.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(291, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(137, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "Telefono (Tel1/Tel2...)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(184, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Distrito";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(45, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Provincia";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DataSource = this.departamentosBindingSource;
            this.cmbDepartamento.DisplayMember = "Departamento";
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(458, 59);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(133, 21);
            this.cmbDepartamento.TabIndex = 17;
            this.cmbDepartamento.ValueMember = "Id_Old";
            this.cmbDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartamento_SelectionChangeCommitted);
            this.cmbDepartamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDepartamento_KeyDown);
            this.cmbDepartamento.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbDepartamento_MouseDoubleClick);
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.departamentosDS;
            // 
            // departamentosDS
            // 
            this.departamentosDS.DataSetName = "DepartamentosDS";
            this.departamentosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(134, 59);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(321, 20);
            this.txtDireccion.TabIndex = 16;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.DoubleClick += new System.EventHandler(this.txtDireccion_DoubleClick);
            this.txtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDireccion_KeyDown);
            // 
            // txtEdad
            // 
            this.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdad.Location = new System.Drawing.Point(89, 59);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(43, 20);
            this.txtEdad.TabIndex = 15;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEdad.DoubleClick += new System.EventHandler(this.txtEdad_DoubleClick);
            this.txtEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEdad_KeyDown);
            this.txtEdad.Leave += new System.EventHandler(this.txtEdad_Leave);
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(4, 59);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(83, 20);
            this.txtFechaNac.TabIndex = 14;
            this.txtFechaNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            this.txtFechaNac.DoubleClick += new System.EventHandler(this.txtFechaNac_DoubleClick);
            this.txtFechaNac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaNac_KeyDown);
            this.txtFechaNac.Leave += new System.EventHandler(this.txtFechaNac_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(480, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Departamento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(162, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(260, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Direccion (Av, Calle, Urbanizacion, Mz, Lte.)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(91, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Edad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Fecha Nac.";
            // 
            // txtDNI
            // 
            this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDNI.Location = new System.Drawing.Point(80, 23);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(66, 20);
            this.txtDNI.TabIndex = 9;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDNI.DoubleClick += new System.EventHandler(this.txtDNI_DoubleClick);
            this.txtDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDNI_KeyDown);
            this.txtDNI.Leave += new System.EventHandler(this.txtDNI_Leave);
            // 
            // txtSexo
            // 
            this.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSexo.Location = new System.Drawing.Point(510, 23);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(80, 20);
            this.txtSexo.TabIndex = 13;
            this.txtSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSexo.DoubleClick += new System.EventHandler(this.txtSexo_DoubleClick);
            this.txtSexo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSexo_KeyDown);
            this.txtSexo.Leave += new System.EventHandler(this.txtSexo_Leave);
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeMaterno.Location = new System.Drawing.Point(394, 23);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(115, 20);
            this.txtApeMaterno.TabIndex = 12;
            this.txtApeMaterno.TextChanged += new System.EventHandler(this.txtApeMaterno_TextChanged);
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApePaterno.Location = new System.Drawing.Point(277, 23);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(115, 20);
            this.txtApePaterno.TabIndex = 11;
            this.txtApePaterno.TextChanged += new System.EventHandler(this.txtApePaterno_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(148, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdPaciente.Location = new System.Drawing.Point(4, 23);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.ReadOnly = true;
            this.txtIdPaciente.Size = new System.Drawing.Size(74, 20);
            this.txtIdPaciente.TabIndex = 8;
            this.txtIdPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(92, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "D.N.I.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(531, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Sexo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(423, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "AP Materno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(303, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "AP Paterno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nombres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "ID Paciente";
            // 
            // txtNeto
            // 
            this.txtNeto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNeto.Location = new System.Drawing.Point(523, 360);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(76, 20);
            this.txtNeto.TabIndex = 36;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNeto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // txtIGV
            // 
            this.txtIGV.BackColor = System.Drawing.SystemColors.Window;
            this.txtIGV.Location = new System.Drawing.Point(523, 381);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.ReadOnly = true;
            this.txtIGV.Size = new System.Drawing.Size(76, 20);
            this.txtIGV.TabIndex = 37;
            this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Location = new System.Drawing.Point(523, 402);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 38;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // txtAutoriza
            // 
            this.txtAutoriza.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutoriza.Location = new System.Drawing.Point(5, 360);
            this.txtAutoriza.Name = "txtAutoriza";
            this.txtAutoriza.ReadOnly = true;
            this.txtAutoriza.Size = new System.Drawing.Size(515, 20);
            this.txtAutoriza.TabIndex = 34;
            this.txtAutoriza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // txtSon
            // 
            this.txtSon.BackColor = System.Drawing.SystemColors.Window;
            this.txtSon.Location = new System.Drawing.Point(5, 381);
            this.txtSon.Name = "txtSon";
            this.txtSon.ReadOnly = true;
            this.txtSon.Size = new System.Drawing.Size(515, 20);
            this.txtSon.TabIndex = 35;
            this.txtSon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(10, 406);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(507, 12);
            this.label28.TabIndex = 47;
            this.label28.Text = "[Ins] Nuevo Paciente   [F3] Buscar Paciente   [F4] Buscar Venta   [F5] Recargar V" +
    "enta   [F6] Grabar";
            // 
            // fGrid
            // 
            iGColPattern26.CellStyle = this.iGridCol0CellStyle;
            iGColPattern26.ColHdrStyle = this.iGridCol0ColHdrStyle1;
            iGColPattern27.CellStyle = this.iGridCol1CellStyle;
            iGColPattern27.ColHdrStyle = this.iGridCol1ColHdrStyle1;
            iGColPattern28.CellStyle = this.iGridCol2CellStyle;
            iGColPattern28.ColHdrStyle = this.iGridCol2ColHdrStyle1;
            iGColPattern29.CellStyle = this.iGridCol3CellStyle;
            iGColPattern29.ColHdrStyle = this.iGridCol3ColHdrStyle1;
            iGColPattern30.CellStyle = this.iGridCol4CellStyle;
            iGColPattern30.ColHdrStyle = this.iGridCol4ColHdrStyle1;
            this.fGrid.Cols.AddRange(new TenTec.Windows.iGridLib.iGColPattern[] {
            iGColPattern26,
            iGColPattern27,
            iGColPattern28,
            iGColPattern29,
            iGColPattern30});
            this.fGrid.DefaultCol.CellStyle = this.iGrid1DefaultCellStyle;
            this.fGrid.DefaultCol.ColHdrStyle = this.iGrid1DefaultColHdrStyle;
            this.fGrid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fGrid.Location = new System.Drawing.Point(6, 236);
            this.fGrid.Name = "fGrid";
            this.fGrid.RowTextCol.CellStyle = this.iGrid1RowTextColCellStyle;
            this.fGrid.Size = new System.Drawing.Size(591, 121);
            this.fGrid.TabIndex = 48;
            this.fGrid.TreeCol = null;
            this.fGrid.TreeLines.Color = System.Drawing.SystemColors.WindowText;
            this.fGrid.SelectionChanged += new System.EventHandler(this.fGrid_SelectionChanged);
            this.fGrid.CellClick += new TenTec.Windows.iGridLib.iGCellClickEventHandler(this.fGrid_CellClick);
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // distritoTableAdapter
            // 
            this.distritoTableAdapter.ClearBeforeFill = true;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowDrop = true;
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.AllowUserToOrderColumns = true;
            this.grdDetalle.AllowUserToResizeColumns = false;
            this.grdDetalle.AllowUserToResizeRows = false;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grddetalleC1,
            this.grddetalleC2,
            this.grddetalleC3,
            this.grddetalleC4});
            this.grdDetalle.Location = new System.Drawing.Point(29, 254);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(570, 119);
            this.grdDetalle.TabIndex = 49;
            this.grdDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalle_CellEndEdit);
            this.grdDetalle.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalle_CellLeave);
            this.grdDetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdDetalle_EditingControlShowing);
            // 
            // grddetalleC1
            // 
            this.grddetalleC1.HeaderText = "Descripción del producto o servicio";
            this.grddetalleC1.Name = "grddetalleC1";
            this.grddetalleC1.Width = 350;
            // 
            // grddetalleC2
            // 
            this.grddetalleC2.HeaderText = "Cant.";
            this.grddetalleC2.Name = "grddetalleC2";
            this.grddetalleC2.Width = 70;
            // 
            // grddetalleC3
            // 
            this.grddetalleC3.HeaderText = "Precio";
            this.grddetalleC3.Name = "grddetalleC3";
            this.grddetalleC3.Width = 70;
            // 
            // grddetalleC4
            // 
            this.grddetalleC4.HeaderText = "SubTotal";
            this.grddetalleC4.Name = "grddetalleC4";
            this.grddetalleC4.Width = 70;
            // 
            // institucionTableAdapter
            // 
            this.institucionTableAdapter.ClearBeforeFill = true;
            // 
            // consultoriosSHClinicaTableAdapter
            // 
            this.consultoriosSHClinicaTableAdapter.ClearBeforeFill = true;
            // 
            // frmSHClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(718, 425);
            this.ControlBox = false;
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.fGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtSon);
            this.Controls.Add(this.txtAutoriza);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmSHClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proceso de Ventas";
            this.Load += new System.EventHandler(this.frmSHClinica_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSHClinica_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.institucionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institucionesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosSHClinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox txtFechaEmision;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbIGV;
		private System.Windows.Forms.ComboBox cmbTDoc;
		private System.Windows.Forms.TextBox txtNHP;
		private System.Windows.Forms.TextBox txtDigitador;
		private System.Windows.Forms.TextBox txtNroTicket;
		private System.Windows.Forms.TextBox txtSerie;
		private System.Windows.Forms.ComboBox cmbMVen;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnDuplica;
		private System.Windows.Forms.Button btnBuscat;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtIdPaciente;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.TextBox txtSexo;
		private System.Windows.Forms.TextBox txtApeMaterno;
		private System.Windows.Forms.TextBox txtApePaterno;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.ComboBox cmbDepartamento;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.MaskedTextBox txtFechaNac;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtAsegurado;
		private System.Windows.Forms.TextBox txtODoc;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.ComboBox cmbDistrito;
		private System.Windows.Forms.ComboBox cmbProvincia;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ComboBox cmbEspecialidad;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.ComboBox cmbMedico;
		private System.Windows.Forms.ComboBox cmbInstitucion;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox txtNeto;
		private System.Windows.Forms.TextBox txtIGV;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtAutoriza;
		private System.Windows.Forms.TextBox txtSon;
		private System.Windows.Forms.Label label28;
		private TenTec.Windows.iGridLib.iGDropDownList iGDDL;
		private TenTec.Windows.iGridLib.iGrid fGrid;
		private TenTec.Windows.iGridLib.iGCellStyle iGrid1DefaultCellStyle;
		private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1DefaultColHdrStyle;
		private TenTec.Windows.iGridLib.iGCellStyle iGrid1RowTextColCellStyle;
		private TenTec.Windows.iGridLib.iGCellStyle iGridCol0CellStyle;
		private TenTec.Windows.iGridLib.iGColHdrStyle iGridCol0ColHdrStyle1;
		private TenTec.Windows.iGridLib.iGCellStyle iGridCol1CellStyle;
		private TenTec.Windows.iGridLib.iGColHdrStyle iGridCol1ColHdrStyle1;
		private TenTec.Windows.iGridLib.iGCellStyle iGridCol2CellStyle;
		private TenTec.Windows.iGridLib.iGColHdrStyle iGridCol2ColHdrStyle1;
		private TenTec.Windows.iGridLib.iGCellStyle iGridCol3CellStyle;
		private TenTec.Windows.iGridLib.iGColHdrStyle iGridCol3ColHdrStyle1;
		private TenTec.Windows.iGridLib.iGCellStyle iGridCol4CellStyle;
		private TenTec.Windows.iGridLib.iGColHdrStyle iGridCol4ColHdrStyle1;
        private Dominio.Data.DepartamentosDS departamentosDS;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private Dominio.Data.DepartamentosDSTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.BindingSource distritoBindingSource;
        private Dominio.Data.DistritoDS distritoDS;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private Dominio.Data.ProvinciasDS provinciasDS;
        private Dominio.Data.ProvinciasDSTableAdapters.ProvinciasTableAdapter provinciasTableAdapter;
        private Dominio.Data.DistritoDSTableAdapters.DistritoTableAdapter distritoTableAdapter;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.DataGridViewComboBoxColumn grddetalleC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grddetalleC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn grddetalleC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn grddetalleC4;
        private Dominio.Data.InstitucionesDS institucionesDS;
        private System.Windows.Forms.BindingSource institucionBindingSource;
        private Dominio.Data.InstitucionesDSTableAdapters.InstitucionTableAdapter institucionTableAdapter;
        private System.Windows.Forms.BindingSource consultoriosSHClinicaBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.ConsultoriosSHClinicaTableAdapter consultoriosSHClinicaTableAdapter;
        private System.Windows.Forms.CheckBox chkInst;
        private System.Windows.Forms.Button btnInst;
    }
}