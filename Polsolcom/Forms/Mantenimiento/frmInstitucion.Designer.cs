namespace Polsolcom.Forms
{
    partial class frmInstitucion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstitucion));
			this.txtDoc = new System.Windows.Forms.TextBox();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.estadoRegistroBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.pnlBuscar = new System.Windows.Forms.Panel();
			this.lstInstitucion = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Doc = new System.Windows.Forms.Label();
			this.Estado = new System.Windows.Forms.Label();
			this.cntInstitucion = new System.Windows.Forms.Panel();
			this.txtRuc = new System.Windows.Forms.MaskedTextBox();
			this.cntUbigeo = new System.Windows.Forms.Panel();
			this.cmbDistrito = new System.Windows.Forms.ComboBox();
			this.distritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.distritoDS = new Polsolcom.Dominio.Data.DistritoDS();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbDepartamento = new System.Windows.Forms.ComboBox();
			this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.departamentosDS = new Polsolcom.Dominio.Data.DepartamentosDS();
			this.cmbProvincia = new System.Windows.Forms.ComboBox();
			this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.provinciasDS = new Polsolcom.Dominio.Data.ProvinciasDS();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.chkStatus = new System.Windows.Forms.CheckBox();
			this.txtLastUpdate = new System.Windows.Forms.TextBox();
			this.txtCreation = new System.Windows.Forms.TextBox();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.cmbModTrans = new System.Windows.Forms.ComboBox();
			this.modTransBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.modTransDS = new Polsolcom.Dominio.Data.ModTransDS();
			this.txtRepresentante = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.cmbCargo = new System.Windows.Forms.ComboBox();
			this.cargosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cargoDS = new Polsolcom.Dominio.Data.CargoDS();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbRepresentante = new System.Windows.Forms.ComboBox();
			this.representanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.representanteDS = new Polsolcom.Dominio.Data.RepresentanteDS();
			this.label12 = new System.Windows.Forms.Label();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNomRazSocial = new System.Windows.Forms.TextBox();
			this.txtIdInst = new System.Windows.Forms.TextBox();
			this.cmbTIns = new System.Windows.Forms.ComboBox();
			this.tipoInstitucionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGrabar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.modTransTableAdapter = new Polsolcom.Dominio.Data.ModTransDSTableAdapters.ModTransTableAdapter();
			this.representanteTableAdapter = new Polsolcom.Dominio.Data.RepresentanteDSTableAdapters.RepresentanteTableAdapter();
			this.departamentosTableAdapter = new Polsolcom.Dominio.Data.DepartamentosDSTableAdapters.DepartamentosTableAdapter();
			this.provinciasTableAdapter = new Polsolcom.Dominio.Data.ProvinciasDSTableAdapters.ProvinciasTableAdapter();
			this.distritoTableAdapter = new Polsolcom.Dominio.Data.DistritoDSTableAdapters.DistritoTableAdapter();
			this.cargosTableAdapter = new Polsolcom.Dominio.Data.CargoDSTableAdapters.CargosTableAdapter();
			this.estadoRegistroTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.EstadoRegistroTableAdapter();
			this.tipoInstitucionTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TipoInstitucionTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.estadoRegistroBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
			this.pnlBuscar.SuspendLayout();
			this.cntInstitucion.SuspendLayout();
			this.cntUbigeo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.distritoDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departamentosDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.provinciasDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.modTransBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.modTransDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cargosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cargoDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.representanteBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.representanteDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoInstitucionBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtDoc
			// 
			this.txtDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDoc.Location = new System.Drawing.Point(4, 18);
			this.txtDoc.Name = "txtDoc";
			this.txtDoc.Size = new System.Drawing.Size(128, 20);
			this.txtDoc.TabIndex = 0;
			this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
			// 
			// cmbEstado
			// 
			this.cmbEstado.DataSource = this.estadoRegistroBindingSource;
			this.cmbEstado.DisplayMember = "Descripcion";
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Location = new System.Drawing.Point(136, 18);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(149, 21);
			this.cmbEstado.TabIndex = 1;
			this.cmbEstado.ValueMember = "Id_Tipo";
			this.cmbEstado.SelectionChangeCommitted += new System.EventHandler(this.cmbEstado_SelectionChangeCommitted);
			// 
			// estadoRegistroBindingSource
			// 
			this.estadoRegistroBindingSource.DataMember = "EstadoRegistro";
			this.estadoRegistroBindingSource.DataSource = this.tablaTipoDS;
			// 
			// tablaTipoDS
			// 
			this.tablaTipoDS.DataSetName = "TablaTipoDS";
			this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// txtBuscar
			// 
			this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBuscar.Location = new System.Drawing.Point(4, 40);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(281, 20);
			this.txtBuscar.TabIndex = 2;
			this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
			// 
			// pnlBuscar
			// 
			this.pnlBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlBuscar.Controls.Add(this.lstInstitucion);
			this.pnlBuscar.Controls.Add(this.Doc);
			this.pnlBuscar.Controls.Add(this.Estado);
			this.pnlBuscar.Controls.Add(this.txtBuscar);
			this.pnlBuscar.Controls.Add(this.txtDoc);
			this.pnlBuscar.Controls.Add(this.cmbEstado);
			this.pnlBuscar.Location = new System.Drawing.Point(3, 3);
			this.pnlBuscar.Name = "pnlBuscar";
			this.pnlBuscar.Size = new System.Drawing.Size(290, 372);
			this.pnlBuscar.TabIndex = 4;
			// 
			// lstInstitucion
			// 
			this.lstInstitucion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lstInstitucion.FullRowSelect = true;
			this.lstInstitucion.Location = new System.Drawing.Point(4, 63);
			this.lstInstitucion.MultiSelect = false;
			this.lstInstitucion.Name = "lstInstitucion";
			this.lstInstitucion.Size = new System.Drawing.Size(282, 305);
			this.lstInstitucion.TabIndex = 6;
			this.lstInstitucion.UseCompatibleStateImageBehavior = false;
			this.lstInstitucion.View = System.Windows.Forms.View.Details;
			this.lstInstitucion.SelectedIndexChanged += new System.EventHandler(this.lstInstitucion_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Descripcion";
			this.columnHeader1.Width = 180;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "RUC";
			this.columnHeader2.Width = 70;
			// 
			// Doc
			// 
			this.Doc.AutoSize = true;
			this.Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Doc.ForeColor = System.Drawing.Color.DarkBlue;
			this.Doc.Location = new System.Drawing.Point(4, 4);
			this.Doc.Name = "Doc";
			this.Doc.Size = new System.Drawing.Size(30, 13);
			this.Doc.TabIndex = 5;
			this.Doc.Text = "Doc";
			// 
			// Estado
			// 
			this.Estado.AutoSize = true;
			this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Estado.ForeColor = System.Drawing.Color.DarkBlue;
			this.Estado.Location = new System.Drawing.Point(151, 4);
			this.Estado.Name = "Estado";
			this.Estado.Size = new System.Drawing.Size(46, 13);
			this.Estado.TabIndex = 4;
			this.Estado.Text = "Estado";
			// 
			// cntInstitucion
			// 
			this.cntInstitucion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.cntInstitucion.Controls.Add(this.txtRuc);
			this.cntInstitucion.Controls.Add(this.cntUbigeo);
			this.cntInstitucion.Controls.Add(this.chkStatus);
			this.cntInstitucion.Controls.Add(this.txtLastUpdate);
			this.cntInstitucion.Controls.Add(this.txtCreation);
			this.cntInstitucion.Controls.Add(this.txtObservacion);
			this.cntInstitucion.Controls.Add(this.label17);
			this.cntInstitucion.Controls.Add(this.txtEmail);
			this.cntInstitucion.Controls.Add(this.label16);
			this.cntInstitucion.Controls.Add(this.label15);
			this.cntInstitucion.Controls.Add(this.cmbModTrans);
			this.cntInstitucion.Controls.Add(this.txtRepresentante);
			this.cntInstitucion.Controls.Add(this.label14);
			this.cntInstitucion.Controls.Add(this.cmbCargo);
			this.cntInstitucion.Controls.Add(this.label13);
			this.cntInstitucion.Controls.Add(this.cmbRepresentante);
			this.cntInstitucion.Controls.Add(this.label12);
			this.cntInstitucion.Controls.Add(this.txtCelular);
			this.cntInstitucion.Controls.Add(this.txtTelefono);
			this.cntInstitucion.Controls.Add(this.txtDireccion);
			this.cntInstitucion.Controls.Add(this.label11);
			this.cntInstitucion.Controls.Add(this.label10);
			this.cntInstitucion.Controls.Add(this.label9);
			this.cntInstitucion.Controls.Add(this.label5);
			this.cntInstitucion.Controls.Add(this.txtNomRazSocial);
			this.cntInstitucion.Controls.Add(this.txtIdInst);
			this.cntInstitucion.Controls.Add(this.cmbTIns);
			this.cntInstitucion.Controls.Add(this.label3);
			this.cntInstitucion.Controls.Add(this.label2);
			this.cntInstitucion.Controls.Add(this.label1);
			this.cntInstitucion.Location = new System.Drawing.Point(299, 22);
			this.cntInstitucion.Name = "cntInstitucion";
			this.cntInstitucion.Size = new System.Drawing.Size(554, 302);
			this.cntInstitucion.TabIndex = 5;
			// 
			// txtRuc
			// 
			this.txtRuc.Enabled = false;
			this.txtRuc.Location = new System.Drawing.Point(5, 60);
			this.txtRuc.Mask = "99999999999";
			this.txtRuc.Name = "txtRuc";
			this.txtRuc.Size = new System.Drawing.Size(110, 20);
			this.txtRuc.TabIndex = 35;
			// 
			// cntUbigeo
			// 
			this.cntUbigeo.Controls.Add(this.cmbDistrito);
			this.cntUbigeo.Controls.Add(this.label6);
			this.cntUbigeo.Controls.Add(this.cmbDepartamento);
			this.cntUbigeo.Controls.Add(this.cmbProvincia);
			this.cntUbigeo.Controls.Add(this.label7);
			this.cntUbigeo.Controls.Add(this.label8);
			this.cntUbigeo.Location = new System.Drawing.Point(149, 41);
			this.cntUbigeo.Name = "cntUbigeo";
			this.cntUbigeo.Size = new System.Drawing.Size(403, 41);
			this.cntUbigeo.TabIndex = 12;
			// 
			// cmbDistrito
			// 
			this.cmbDistrito.DataSource = this.distritoBindingSource;
			this.cmbDistrito.DisplayMember = "Distrito";
			this.cmbDistrito.Enabled = false;
			this.cmbDistrito.FormattingEnabled = true;
			this.cmbDistrito.Location = new System.Drawing.Point(268, 17);
			this.cmbDistrito.Name = "cmbDistrito";
			this.cmbDistrito.Size = new System.Drawing.Size(133, 21);
			this.cmbDistrito.TabIndex = 11;
			this.cmbDistrito.ValueMember = "Id_Old";
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(4, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Departamento";
			// 
			// cmbDepartamento
			// 
			this.cmbDepartamento.DataSource = this.departamentosBindingSource;
			this.cmbDepartamento.DisplayMember = "Departamento";
			this.cmbDepartamento.Enabled = false;
			this.cmbDepartamento.FormattingEnabled = true;
			this.cmbDepartamento.Location = new System.Drawing.Point(4, 17);
			this.cmbDepartamento.Name = "cmbDepartamento";
			this.cmbDepartamento.Size = new System.Drawing.Size(130, 21);
			this.cmbDepartamento.TabIndex = 9;
			this.cmbDepartamento.ValueMember = "Id_Old";
			this.cmbDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartamento_SelectionChangeCommitted);
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
			// cmbProvincia
			// 
			this.cmbProvincia.DataSource = this.provinciasBindingSource;
			this.cmbProvincia.DisplayMember = "Provincia";
			this.cmbProvincia.Enabled = false;
			this.cmbProvincia.FormattingEnabled = true;
			this.cmbProvincia.Location = new System.Drawing.Point(135, 17);
			this.cmbProvincia.Name = "cmbProvincia";
			this.cmbProvincia.Size = new System.Drawing.Size(132, 21);
			this.cmbProvincia.TabIndex = 10;
			this.cmbProvincia.ValueMember = "Id_Old";
			this.cmbProvincia.SelectionChangeCommitted += new System.EventHandler(this.cmbProvincia_SelectionChangeCommitted);
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
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(137, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Provincia";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(276, 3);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Distrito";
			// 
			// chkStatus
			// 
			this.chkStatus.AutoSize = true;
			this.chkStatus.Enabled = false;
			this.chkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkStatus.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkStatus.Location = new System.Drawing.Point(442, 277);
			this.chkStatus.Name = "chkStatus";
			this.chkStatus.Size = new System.Drawing.Size(104, 19);
			this.chkStatus.TabIndex = 34;
			this.chkStatus.Text = "En Acti&vidad";
			this.chkStatus.UseVisualStyleBackColor = true;
			// 
			// txtLastUpdate
			// 
			this.txtLastUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastUpdate.Location = new System.Drawing.Point(242, 277);
			this.txtLastUpdate.Name = "txtLastUpdate";
			this.txtLastUpdate.ReadOnly = true;
			this.txtLastUpdate.Size = new System.Drawing.Size(193, 20);
			this.txtLastUpdate.TabIndex = 33;
			// 
			// txtCreation
			// 
			this.txtCreation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCreation.Location = new System.Drawing.Point(4, 277);
			this.txtCreation.Name = "txtCreation";
			this.txtCreation.ReadOnly = true;
			this.txtCreation.Size = new System.Drawing.Size(231, 20);
			this.txtCreation.TabIndex = 32;
			// 
			// txtObservacion
			// 
			this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtObservacion.Enabled = false;
			this.txtObservacion.Location = new System.Drawing.Point(265, 220);
			this.txtObservacion.Multiline = true;
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtObservacion.Size = new System.Drawing.Size(284, 53);
			this.txtObservacion.TabIndex = 31;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(265, 203);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(78, 13);
			this.label17.TabIndex = 30;
			this.label17.Text = "Observación";
			// 
			// txtEmail
			// 
			this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEmail.Enabled = false;
			this.txtEmail.Location = new System.Drawing.Point(5, 220);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtEmail.Size = new System.Drawing.Size(258, 52);
			this.txtEmail.TabIndex = 29;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(5, 203);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(151, 13);
			this.label16.TabIndex = 28;
			this.label16.Text = "Email (email1/email2/etc)";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(276, 164);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(144, 13);
			this.label15.TabIndex = 27;
			this.label15.Text = "Modalidad de transporte";
			// 
			// cmbModTrans
			// 
			this.cmbModTrans.DataSource = this.modTransBindingSource;
			this.cmbModTrans.DisplayMember = "Descripcion";
			this.cmbModTrans.Enabled = false;
			this.cmbModTrans.FormattingEnabled = true;
			this.cmbModTrans.Location = new System.Drawing.Point(272, 179);
			this.cmbModTrans.Name = "cmbModTrans";
			this.cmbModTrans.Size = new System.Drawing.Size(278, 21);
			this.cmbModTrans.TabIndex = 26;
			this.cmbModTrans.ValueMember = "Id_Tipo";
			// 
			// modTransBindingSource
			// 
			this.modTransBindingSource.DataMember = "ModTrans";
			this.modTransBindingSource.DataSource = this.modTransDS;
			// 
			// modTransDS
			// 
			this.modTransDS.DataSetName = "ModTransDS";
			this.modTransDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// txtRepresentante
			// 
			this.txtRepresentante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRepresentante.Enabled = false;
			this.txtRepresentante.Location = new System.Drawing.Point(272, 140);
			this.txtRepresentante.Name = "txtRepresentante";
			this.txtRepresentante.Size = new System.Drawing.Size(278, 20);
			this.txtRepresentante.TabIndex = 25;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(5, 164);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(148, 13);
			this.label14.TabIndex = 24;
			this.label14.Text = "Cargo del Representante";
			// 
			// cmbCargo
			// 
			this.cmbCargo.DataSource = this.cargosBindingSource;
			this.cmbCargo.DisplayMember = "Descripcion";
			this.cmbCargo.Enabled = false;
			this.cmbCargo.FormattingEnabled = true;
			this.cmbCargo.Location = new System.Drawing.Point(4, 179);
			this.cmbCargo.Name = "cmbCargo";
			this.cmbCargo.Size = new System.Drawing.Size(266, 21);
			this.cmbCargo.TabIndex = 23;
			this.cmbCargo.ValueMember = "Id_Tipo";
			// 
			// cargosBindingSource
			// 
			this.cargosBindingSource.DataMember = "Cargos";
			this.cargosBindingSource.DataSource = this.cargoDS;
			// 
			// cargoDS
			// 
			this.cargoDS.DataSetName = "CargoDS";
			this.cargoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(276, 126);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(175, 13);
			this.label13.TabIndex = 22;
			this.label13.Text = "Representante No Registrado";
			// 
			// cmbRepresentante
			// 
			this.cmbRepresentante.DataSource = this.representanteBindingSource;
			this.cmbRepresentante.DisplayMember = "Descripcion";
			this.cmbRepresentante.Enabled = false;
			this.cmbRepresentante.FormattingEnabled = true;
			this.cmbRepresentante.Location = new System.Drawing.Point(4, 140);
			this.cmbRepresentante.Name = "cmbRepresentante";
			this.cmbRepresentante.Size = new System.Drawing.Size(266, 21);
			this.cmbRepresentante.TabIndex = 21;
			this.cmbRepresentante.ValueMember = "Id_Personal";
			// 
			// representanteBindingSource
			// 
			this.representanteBindingSource.DataMember = "Representante";
			this.representanteBindingSource.DataSource = this.representanteDS;
			// 
			// representanteDS
			// 
			this.representanteDS.DataSetName = "RepresentanteDS";
			this.representanteDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(5, 126);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(155, 13);
			this.label12.TabIndex = 20;
			this.label12.Text = "Representante Registrado";
			// 
			// txtCelular
			// 
			this.txtCelular.Enabled = false;
			this.txtCelular.Location = new System.Drawing.Point(422, 103);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(128, 20);
			this.txtCelular.TabIndex = 19;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Enabled = false;
			this.txtTelefono.Location = new System.Drawing.Point(309, 103);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(112, 20);
			this.txtTelefono.TabIndex = 18;
			// 
			// txtDireccion
			// 
			this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDireccion.Enabled = false;
			this.txtDireccion.Location = new System.Drawing.Point(4, 103);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(303, 20);
			this.txtDireccion.TabIndex = 17;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(425, 86);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 13);
			this.label11.TabIndex = 16;
			this.label11.Text = "Celular";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(309, 86);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "Teléfono";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(5, 86);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(214, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Dirección (Av/calle/Urb./Mz/Lt/etc)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "R.U.C.";
			// 
			// txtNomRazSocial
			// 
			this.txtNomRazSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNomRazSocial.Enabled = false;
			this.txtNomRazSocial.Location = new System.Drawing.Point(263, 19);
			this.txtNomRazSocial.Name = "txtNomRazSocial";
			this.txtNomRazSocial.Size = new System.Drawing.Size(288, 20);
			this.txtNomRazSocial.TabIndex = 5;
			// 
			// txtIdInst
			// 
			this.txtIdInst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtIdInst.Enabled = false;
			this.txtIdInst.Location = new System.Drawing.Point(151, 19);
			this.txtIdInst.Name = "txtIdInst";
			this.txtIdInst.Size = new System.Drawing.Size(108, 20);
			this.txtIdInst.TabIndex = 4;
			// 
			// cmbTIns
			// 
			this.cmbTIns.DataSource = this.tipoInstitucionBindingSource1;
			this.cmbTIns.DisplayMember = "Descripcion";
			this.cmbTIns.Enabled = false;
			this.cmbTIns.FormattingEnabled = true;
			this.cmbTIns.Location = new System.Drawing.Point(4, 19);
			this.cmbTIns.Name = "cmbTIns";
			this.cmbTIns.Size = new System.Drawing.Size(145, 21);
			this.cmbTIns.TabIndex = 3;
			this.cmbTIns.ValueMember = "Id_Tipo";
			// 
			// tipoInstitucionBindingSource1
			// 
			this.tipoInstitucionBindingSource1.DataMember = "TipoInstitucion";
			this.tipoInstitucionBindingSource1.DataSource = this.tablaTipoDS;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(272, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre o Razón Social";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(156, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nro";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tipo";
			// 
			// btnGrabar
			// 
			this.btnGrabar.Enabled = false;
			this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
			this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGrabar.Location = new System.Drawing.Point(429, 330);
			this.btnGrabar.Name = "btnGrabar";
			this.btnGrabar.Size = new System.Drawing.Size(90, 44);
			this.btnGrabar.TabIndex = 7;
			this.btnGrabar.Text = "&Grabar";
			this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGrabar.UseVisualStyleBackColor = true;
			this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(534, 330);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(90, 44);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(639, 330);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(90, 44);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.Text = "&Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
			this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImprimir.Location = new System.Drawing.Point(744, 330);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(90, 44);
			this.btnImprimir.TabIndex = 10;
			this.btnImprimir.Text = "&Imprimir";
			this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnImprimir.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkBlue;
			this.label4.Location = new System.Drawing.Point(299, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "Institución / Empresa";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(324, 330);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(90, 44);
			this.btnNuevo.TabIndex = 6;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// modTransTableAdapter
			// 
			this.modTransTableAdapter.ClearBeforeFill = true;
			// 
			// representanteTableAdapter
			// 
			this.representanteTableAdapter.ClearBeforeFill = true;
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
			// cargosTableAdapter
			// 
			this.cargosTableAdapter.ClearBeforeFill = true;
			// 
			// estadoRegistroTableAdapter
			// 
			this.estadoRegistroTableAdapter.ClearBeforeFill = true;
			// 
			// tipoInstitucionTableAdapter
			// 
			this.tipoInstitucionTableAdapter.ClearBeforeFill = true;
			// 
			// frmInstitucion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 377);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGrabar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.cntInstitucion);
			this.Controls.Add(this.pnlBuscar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.Name = "frmInstitucion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registro de Empresas e Instituciones";
			this.Load += new System.EventHandler(this.frmInstitucion_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInstitucion_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.estadoRegistroBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
			this.pnlBuscar.ResumeLayout(false);
			this.pnlBuscar.PerformLayout();
			this.cntInstitucion.ResumeLayout(false);
			this.cntInstitucion.PerformLayout();
			this.cntUbigeo.ResumeLayout(false);
			this.cntUbigeo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.distritoDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departamentosDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.provinciasDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.modTransBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.modTransDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cargosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cargoDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.representanteBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.representanteDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoInstitucionBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Panel cntInstitucion;
        private System.Windows.Forms.TextBox txtNomRazSocial;
        private System.Windows.Forms.TextBox txtIdInst;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbTIns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.TextBox txtLastUpdate;
        private System.Windows.Forms.TextBox txtCreation;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbModTrans;
        private System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbRepresentante;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Doc;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ListView lstInstitucion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel cntUbigeo;
        private Dominio.Data.ModTransDS modTransDS;
        private System.Windows.Forms.BindingSource modTransBindingSource;
        private Dominio.Data.ModTransDSTableAdapters.ModTransTableAdapter modTransTableAdapter;
        private Dominio.Data.RepresentanteDS representanteDS;
        private System.Windows.Forms.BindingSource representanteBindingSource;
        private Dominio.Data.RepresentanteDSTableAdapters.RepresentanteTableAdapter representanteTableAdapter;
        private Dominio.Data.DepartamentosDS departamentosDS;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private Dominio.Data.DepartamentosDSTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private Dominio.Data.ProvinciasDS provinciasDS;
        private Dominio.Data.ProvinciasDSTableAdapters.ProvinciasTableAdapter provinciasTableAdapter;
        private System.Windows.Forms.BindingSource distritoBindingSource;
        private Dominio.Data.DistritoDS distritoDS;
        private Dominio.Data.DistritoDSTableAdapters.DistritoTableAdapter distritoTableAdapter;
        private Dominio.Data.CargoDS cargoDS;
        private System.Windows.Forms.BindingSource cargosBindingSource;
        private Dominio.Data.CargoDSTableAdapters.CargosTableAdapter cargosTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtRuc;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource estadoRegistroBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.EstadoRegistroTableAdapter estadoRegistroTableAdapter;
        private System.Windows.Forms.BindingSource tipoInstitucionBindingSource1;
        private Dominio.Data.TablaTipoDSTableAdapters.TipoInstitucionTableAdapter tipoInstitucionTableAdapter;
    }
}