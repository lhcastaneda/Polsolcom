namespace Polsolcom.Forms.Consultas
{
    partial class frmVentasCons
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
            Polsolcom.Dominio.Controls.CheckBoxProperties checkBoxProperties1 = new Polsolcom.Dominio.Controls.CheckBoxProperties();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbOperativo = new Polsolcom.Dominio.Controls.CheckBoxComboBox();
            this.operativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operativos = new Polsolcom.Dominio.Data.Operativos();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.grpFechaFinal = new System.Windows.Forms.GroupBox();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.grpNivelAgrup = new System.Windows.Forms.GroupBox();
            this.optRango = new System.Windows.Forms.RadioButton();
            this.optAnual = new System.Windows.Forms.RadioButton();
            this.optMensual = new System.Windows.Forms.RadioButton();
            this.optDiario = new System.Windows.Forms.RadioButton();
            this.chkTCons = new System.Windows.Forms.CheckBox();
            this.chkImprimir = new System.Windows.Forms.CheckBox();
            this.tabVendidos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grdVenCons = new System.Windows.Forms.ListView();
            this.gFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gConsultorio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalCons = new System.Windows.Forms.TextBox();
            this.txtCantCons = new System.Windows.Forms.TextBox();
            this.txtTickCons = new System.Windows.Forms.TextBox();
            this.lstConsultorios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkConsultorios = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdVenProds = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalProds = new System.Windows.Forms.TextBox();
            this.txtCantProds = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbConsultorioProd = new System.Windows.Forms.ComboBox();
            this.cmbTipoProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductoProd = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.operativoTableAdapter = new Polsolcom.Dominio.Data.OperativosTableAdapters.OperativoTableAdapter();
            this.grdTCons = new System.Windows.Forms.DataGridView();
            this.idTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTablaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadEspecialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
            this.modalidadEspecialidadTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.ModalidadEspecialidadTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operativoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operativos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpFechaFinal.SuspendLayout();
            this.grpNivelAgrup.SuspendLayout();
            this.tabVendidos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadEspecialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTurno);
            this.groupBox1.Controls.Add(this.cmbOperativo);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operativo - Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DisplayMember = "Id_Tipo";
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "COMPLETO",
            "MAÑANA",
            "TARDE"});
            this.cmbTurno.Location = new System.Drawing.Point(195, 17);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(101, 21);
            this.cmbTurno.TabIndex = 45;
            this.cmbTurno.ValueMember = "Id_Tipo";
            this.cmbTurno.SelectionChangeCommitted += new System.EventHandler(this.cmbTurno_SelectionChangeCommitted);
            // 
            // cmbOperativo
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbOperativo.CheckBoxProperties = checkBoxProperties1;
            this.cmbOperativo.DataSource = this.operativoBindingSource;
            this.cmbOperativo.DisplayMember = "Descripcion";
            this.cmbOperativo.DisplayMemberSingleItem = "Descripcion";
            this.cmbOperativo.FormattingEnabled = true;
            this.cmbOperativo.Location = new System.Drawing.Point(7, 17);
            this.cmbOperativo.Name = "cmbOperativo";
            this.cmbOperativo.Size = new System.Drawing.Size(180, 21);
            this.cmbOperativo.TabIndex = 2;
            this.cmbOperativo.ValueMember = "Id_Oper";
            this.cmbOperativo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOperativo_KeyDown);
            // 
            // operativoBindingSource
            // 
            this.operativoBindingSource.DataMember = "Operativo";
            this.operativoBindingSource.DataSource = this.operativos;
            // 
            // operativos
            // 
            this.operativos.DataSetName = "Operativos";
            this.operativos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFecIni);
            this.groupBox2.Location = new System.Drawing.Point(313, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 44);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha y Hora Inicial";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecIni.Location = new System.Drawing.Point(9, 17);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(152, 20);
            this.dtpFecIni.TabIndex = 2;
            // 
            // grpFechaFinal
            // 
            this.grpFechaFinal.Controls.Add(this.dtpFecFin);
            this.grpFechaFinal.Location = new System.Drawing.Point(487, 5);
            this.grpFechaFinal.Name = "grpFechaFinal";
            this.grpFechaFinal.Size = new System.Drawing.Size(170, 44);
            this.grpFechaFinal.TabIndex = 0;
            this.grpFechaFinal.TabStop = false;
            this.grpFechaFinal.Text = "Fecha y Hora Final";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecFin.Location = new System.Drawing.Point(11, 17);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(152, 20);
            this.dtpFecFin.TabIndex = 3;
            // 
            // grpNivelAgrup
            // 
            this.grpNivelAgrup.Controls.Add(this.optRango);
            this.grpNivelAgrup.Controls.Add(this.optAnual);
            this.grpNivelAgrup.Controls.Add(this.optMensual);
            this.grpNivelAgrup.Controls.Add(this.optDiario);
            this.grpNivelAgrup.Location = new System.Drawing.Point(410, 126);
            this.grpNivelAgrup.Name = "grpNivelAgrup";
            this.grpNivelAgrup.Size = new System.Drawing.Size(241, 49);
            this.grpNivelAgrup.TabIndex = 1;
            this.grpNivelAgrup.TabStop = false;
            this.grpNivelAgrup.Text = "Seleccione Nivel de Agrupamiento";
            // 
            // optRango
            // 
            this.optRango.AutoSize = true;
            this.optRango.Location = new System.Drawing.Point(184, 20);
            this.optRango.Name = "optRango";
            this.optRango.Size = new System.Drawing.Size(57, 17);
            this.optRango.TabIndex = 3;
            this.optRango.Text = "Rango";
            this.optRango.UseVisualStyleBackColor = true;
            // 
            // optAnual
            // 
            this.optAnual.AutoSize = true;
            this.optAnual.Location = new System.Drawing.Point(129, 20);
            this.optAnual.Name = "optAnual";
            this.optAnual.Size = new System.Drawing.Size(52, 17);
            this.optAnual.TabIndex = 2;
            this.optAnual.Text = "Anual";
            this.optAnual.UseVisualStyleBackColor = true;
            // 
            // optMensual
            // 
            this.optMensual.AutoSize = true;
            this.optMensual.Location = new System.Drawing.Point(60, 20);
            this.optMensual.Name = "optMensual";
            this.optMensual.Size = new System.Drawing.Size(65, 17);
            this.optMensual.TabIndex = 1;
            this.optMensual.Text = "Mensual";
            this.optMensual.UseVisualStyleBackColor = true;
            // 
            // optDiario
            // 
            this.optDiario.AutoSize = true;
            this.optDiario.Checked = true;
            this.optDiario.Location = new System.Drawing.Point(6, 19);
            this.optDiario.Name = "optDiario";
            this.optDiario.Size = new System.Drawing.Size(52, 17);
            this.optDiario.TabIndex = 0;
            this.optDiario.TabStop = true;
            this.optDiario.Text = "Diario";
            this.optDiario.UseVisualStyleBackColor = true;
            // 
            // chkTCons
            // 
            this.chkTCons.AutoSize = true;
            this.chkTCons.Checked = true;
            this.chkTCons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTCons.Location = new System.Drawing.Point(8, 56);
            this.chkTCons.Name = "chkTCons";
            this.chkTCons.Size = new System.Drawing.Size(135, 17);
            this.chkTCons.TabIndex = 2;
            this.chkTCons.Text = "Todas las M&odalidades";
            this.chkTCons.UseVisualStyleBackColor = true;
            this.chkTCons.CheckedChanged += new System.EventHandler(this.chkTCons_CheckedChanged);
            // 
            // chkImprimir
            // 
            this.chkImprimir.AutoSize = true;
            this.chkImprimir.Location = new System.Drawing.Point(661, 21);
            this.chkImprimir.Name = "chkImprimir";
            this.chkImprimir.Size = new System.Drawing.Size(88, 17);
            this.chkImprimir.TabIndex = 3;
            this.chkImprimir.Text = "Imprimir &Total";
            this.chkImprimir.UseVisualStyleBackColor = true;
            // 
            // tabVendidos
            // 
            this.tabVendidos.Controls.Add(this.tabPage1);
            this.tabVendidos.Controls.Add(this.tabPage2);
            this.tabVendidos.Location = new System.Drawing.Point(10, 186);
            this.tabVendidos.Name = "tabVendidos";
            this.tabVendidos.SelectedIndex = 0;
            this.tabVendidos.Size = new System.Drawing.Size(731, 309);
            this.tabVendidos.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdVenCons);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTotalCons);
            this.tabPage1.Controls.Add(this.txtCantCons);
            this.tabPage1.Controls.Add(this.txtTickCons);
            this.tabPage1.Controls.Add(this.lstConsultorios);
            this.tabPage1.Controls.Add(this.chkConsultorios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte por Consultorios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grdVenCons
            // 
            this.grdVenCons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gFecha,
            this.gConsultorio,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.grdVenCons.FullRowSelect = true;
            this.grdVenCons.HideSelection = false;
            this.grdVenCons.Location = new System.Drawing.Point(221, 7);
            this.grdVenCons.MultiSelect = false;
            this.grdVenCons.Name = "grdVenCons";
            this.grdVenCons.Size = new System.Drawing.Size(490, 239);
            this.grdVenCons.TabIndex = 48;
            this.grdVenCons.UseCompatibleStateImageBehavior = false;
            this.grdVenCons.View = System.Windows.Forms.View.Details;
            this.grdVenCons.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.grdVenCons_ColumnClick);
            this.grdVenCons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdVenCons_KeyDown);
            // 
            // gFecha
            // 
            this.gFecha.Text = "Fecha";
            this.gFecha.Width = 100;
            // 
            // gConsultorio
            // 
            this.gConsultorio.Text = "Nombre de consultorio";
            this.gConsultorio.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tickets";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cantidad";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total S/.";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Totales:";
            // 
            // txtTotalCons
            // 
            this.txtTotalCons.Location = new System.Drawing.Point(619, 256);
            this.txtTotalCons.Name = "txtTotalCons";
            this.txtTotalCons.Size = new System.Drawing.Size(71, 20);
            this.txtTotalCons.TabIndex = 46;
            // 
            // txtCantCons
            // 
            this.txtCantCons.Location = new System.Drawing.Point(558, 256);
            this.txtCantCons.Name = "txtCantCons";
            this.txtCantCons.Size = new System.Drawing.Size(56, 20);
            this.txtCantCons.TabIndex = 45;
            // 
            // txtTickCons
            // 
            this.txtTickCons.Location = new System.Drawing.Point(494, 256);
            this.txtTickCons.Name = "txtTickCons";
            this.txtTickCons.Size = new System.Drawing.Size(58, 20);
            this.txtTickCons.TabIndex = 44;
            // 
            // lstConsultorios
            // 
            this.lstConsultorios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstConsultorios.Enabled = false;
            this.lstConsultorios.FullRowSelect = true;
            this.lstConsultorios.HideSelection = false;
            this.lstConsultorios.Location = new System.Drawing.Point(8, 29);
            this.lstConsultorios.Name = "lstConsultorios";
            this.lstConsultorios.Size = new System.Drawing.Size(205, 244);
            this.lstConsultorios.TabIndex = 40;
            this.lstConsultorios.UseCompatibleStateImageBehavior = false;
            this.lstConsultorios.View = System.Windows.Forms.View.Details;
            this.lstConsultorios.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Consultorios";
            this.columnHeader1.Width = 200;
            // 
            // chkConsultorios
            // 
            this.chkConsultorios.AutoSize = true;
            this.chkConsultorios.Checked = true;
            this.chkConsultorios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConsultorios.Location = new System.Drawing.Point(8, 6);
            this.chkConsultorios.Name = "chkConsultorios";
            this.chkConsultorios.Size = new System.Drawing.Size(100, 17);
            this.chkConsultorios.TabIndex = 0;
            this.chkConsultorios.Text = "Todos los &Items";
            this.chkConsultorios.UseVisualStyleBackColor = true;
            this.chkConsultorios.CheckedChanged += new System.EventHandler(this.chkConsultorios_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdVenProds);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtTotalProds);
            this.tabPage2.Controls.Add(this.txtCantProds);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reporte por Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdVenProds
            // 
            this.grdVenProds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.grdVenProds.FullRowSelect = true;
            this.grdVenProds.HideSelection = false;
            this.grdVenProds.Location = new System.Drawing.Point(8, 66);
            this.grdVenProds.MultiSelect = false;
            this.grdVenProds.Name = "grdVenProds";
            this.grdVenProds.Size = new System.Drawing.Size(705, 180);
            this.grdVenProds.TabIndex = 51;
            this.grdVenProds.UseCompatibleStateImageBehavior = false;
            this.grdVenProds.View = System.Windows.Forms.View.Details;
            this.grdVenProds.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.grdVenProds_ColumnClick);
            this.grdVenProds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdVenProds_KeyDown);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Especialidad";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Producto o servicio";
            this.columnHeader3.Width = 220;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tipo producto";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Precio";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cantidad";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Total S/.";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Totales:";
            // 
            // txtTotalProds
            // 
            this.txtTotalProds.Location = new System.Drawing.Point(610, 255);
            this.txtTotalProds.Name = "txtTotalProds";
            this.txtTotalProds.Size = new System.Drawing.Size(92, 20);
            this.txtTotalProds.TabIndex = 49;
            // 
            // txtCantProds
            // 
            this.txtCantProds.Location = new System.Drawing.Point(556, 255);
            this.txtCantProds.Name = "txtCantProds";
            this.txtCantProds.Size = new System.Drawing.Size(50, 20);
            this.txtCantProds.TabIndex = 48;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbConsultorioProd);
            this.groupBox4.Controls.Add(this.cmbTipoProd);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtProductoProd);
            this.groupBox4.Location = new System.Drawing.Point(5, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(708, 58);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // cmbConsultorioProd
            // 
            this.cmbConsultorioProd.FormattingEnabled = true;
            this.cmbConsultorioProd.Location = new System.Drawing.Point(8, 27);
            this.cmbConsultorioProd.Name = "cmbConsultorioProd";
            this.cmbConsultorioProd.Size = new System.Drawing.Size(215, 21);
            this.cmbConsultorioProd.TabIndex = 5;
            this.cmbConsultorioProd.SelectionChangeCommitted += new System.EventHandler(this.cmbConsultorioProd_SelectionChangeCommitted);
            this.cmbConsultorioProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbConsultorioProd_KeyDown);
            // 
            // cmbTipoProd
            // 
            this.cmbTipoProd.FormattingEnabled = true;
            this.cmbTipoProd.Location = new System.Drawing.Point(435, 29);
            this.cmbTipoProd.Name = "cmbTipoProd";
            this.cmbTipoProd.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoProd.TabIndex = 41;
            this.cmbTipoProd.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoProd_SelectionChangeCommitted);
            this.cmbTipoProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipoProd_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Especialidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto o Servicio";
            // 
            // txtProductoProd
            // 
            this.txtProductoProd.Location = new System.Drawing.Point(230, 29);
            this.txtProductoProd.Name = "txtProductoProd";
            this.txtProductoProd.Size = new System.Drawing.Size(194, 20);
            this.txtProductoProd.TabIndex = 2;
            this.txtProductoProd.TextChanged += new System.EventHandler(this.txtProductoProd_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(360, 73);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 42);
            this.btnAceptar.TabIndex = 41;
            this.btnAceptar.Text = "&Ejecutar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(442, 72);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(78, 42);
            this.btnExportar.TabIndex = 42;
            this.btnExportar.Text = "E&xportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(526, 72);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(78, 42);
            this.btnImprimir.TabIndex = 43;
            this.btnImprimir.Text = "Im&primir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(609, 72);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 42);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // operativoTableAdapter
            // 
            this.operativoTableAdapter.ClearBeforeFill = true;
            // 
            // grdTCons
            // 
            this.grdTCons.AllowUserToAddRows = false;
            this.grdTCons.AllowUserToDeleteRows = false;
            this.grdTCons.AllowUserToOrderColumns = true;
            this.grdTCons.AllowUserToResizeColumns = false;
            this.grdTCons.AllowUserToResizeRows = false;
            this.grdTCons.AutoGenerateColumns = false;
            this.grdTCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idTablaDataGridViewTextBoxColumn});
            this.grdTCons.DataSource = this.modalidadEspecialidadBindingSource;
            this.grdTCons.Enabled = false;
            this.grdTCons.Location = new System.Drawing.Point(9, 76);
            this.grdTCons.MultiSelect = false;
            this.grdTCons.Name = "grdTCons";
            this.grdTCons.ReadOnly = true;
            this.grdTCons.RowHeadersVisible = false;
            this.grdTCons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTCons.Size = new System.Drawing.Size(341, 99);
            this.grdTCons.TabIndex = 45;
            this.grdTCons.SelectionChanged += new System.EventHandler(this.grdTCons_SelectionChanged);
            // 
            // idTipoDataGridViewTextBoxColumn
            // 
            this.idTipoDataGridViewTextBoxColumn.DataPropertyName = "Id_Tipo";
            this.idTipoDataGridViewTextBoxColumn.HeaderText = "Id_Tipo";
            this.idTipoDataGridViewTextBoxColumn.Name = "idTipoDataGridViewTextBoxColumn";
            this.idTipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Modalidad";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 330;
            // 
            // idTablaDataGridViewTextBoxColumn
            // 
            this.idTablaDataGridViewTextBoxColumn.DataPropertyName = "Id_Tabla";
            this.idTablaDataGridViewTextBoxColumn.HeaderText = "Id_Tabla";
            this.idTablaDataGridViewTextBoxColumn.Name = "idTablaDataGridViewTextBoxColumn";
            this.idTablaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTablaDataGridViewTextBoxColumn.Visible = false;
            // 
            // modalidadEspecialidadBindingSource
            // 
            this.modalidadEspecialidadBindingSource.DataMember = "ModalidadEspecialidad";
            this.modalidadEspecialidadBindingSource.DataSource = this.tablaTipoDS;
            // 
            // tablaTipoDS
            // 
            this.tablaTipoDS.DataSetName = "TablaTipoDS";
            this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modalidadEspecialidadTableAdapter
            // 
            this.modalidadEspecialidadTableAdapter.ClearBeforeFill = true;
            // 
            // frmVentasCons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 498);
            this.ControlBox = false;
            this.Controls.Add(this.grdTCons);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tabVendidos);
            this.Controls.Add(this.chkImprimir);
            this.Controls.Add(this.chkTCons);
            this.Controls.Add(this.grpNivelAgrup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpFechaFinal);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmVentasCons";
            this.Text = "Ventas por Consultorios";
            this.Load += new System.EventHandler(this.frmVentasCons_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVentasCons_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operativoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operativos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpFechaFinal.ResumeLayout(false);
            this.grpNivelAgrup.ResumeLayout(false);
            this.grpNivelAgrup.PerformLayout();
            this.tabVendidos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadEspecialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpFechaFinal;
        private System.Windows.Forms.GroupBox grpNivelAgrup;
        private System.Windows.Forms.RadioButton optRango;
        private System.Windows.Forms.RadioButton optAnual;
        private System.Windows.Forms.RadioButton optMensual;
        private System.Windows.Forms.RadioButton optDiario;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private Dominio.Controls.CheckBoxComboBox cmbOperativo;
        private System.Windows.Forms.CheckBox chkTCons;
        private System.Windows.Forms.CheckBox chkImprimir;
        private System.Windows.Forms.TabControl tabVendidos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstConsultorios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox chkConsultorios;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductoProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalCons;
        private System.Windows.Forms.TextBox txtCantCons;
        private System.Windows.Forms.TextBox txtTickCons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalProds;
        private System.Windows.Forms.TextBox txtCantProds;
        private System.Windows.Forms.ComboBox cmbTipoProd;
        private System.Windows.Forms.ComboBox cmbConsultorioProd;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private Dominio.Data.Operativos operativos;
        private System.Windows.Forms.BindingSource operativoBindingSource;
        private Dominio.Data.OperativosTableAdapters.OperativoTableAdapter operativoTableAdapter;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.DataGridView grdTCons;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource modalidadEspecialidadBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.ModalidadEspecialidadTableAdapter modalidadEspecialidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTablaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView grdVenCons;
        private System.Windows.Forms.ColumnHeader gConsultorio;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader gFecha;
        private System.Windows.Forms.ListView grdVenProds;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}