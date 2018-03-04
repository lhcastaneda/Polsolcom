namespace Polsolcom.Forms
{
    partial class frmEspecialistas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspecialistas));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEspecialista = new System.Windows.Forms.TextBox();
			this.txtNCP = new System.Windows.Forms.TextBox();
			this.txtEspecialidad = new System.Windows.Forms.TextBox();
			this.txtConsultorio = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbEstList = new System.Windows.Forms.ComboBox();
			this.estadoRegistroBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
			this.cmbPersonal = new System.Windows.Forms.ComboBox();
			this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.personalDS = new Polsolcom.Dominio.Data.PersonalDS();
			this.cmbTCol = new System.Windows.Forms.ComboBox();
			this.tipoColegiaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
			this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbConsultorio = new System.Windows.Forms.ComboBox();
			this.busesByIdEspBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.busesDS = new Polsolcom.Dominio.Data.BusesDS();
			this.label14 = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnGrabar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.lstBusMed = new System.Windows.Forms.ListView();
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtObs = new System.Windows.Forms.TextBox();
			this.txtLastUpDate = new System.Windows.Forms.TextBox();
			this.txtCreacion = new System.Windows.Forms.TextBox();
			this.pnlEspec = new System.Windows.Forms.Panel();
			this.txtRNE = new System.Windows.Forms.MaskedTextBox();
			this.txtNCol = new System.Windows.Forms.MaskedTextBox();
			this.busesByIdEspTableAdapter = new Polsolcom.Dominio.Data.BusesDSTableAdapters.BusesByIdEspTableAdapter();
			this.personalTableAdapter = new Polsolcom.Dominio.Data.PersonalDSTableAdapters.PersonalTableAdapter();
			this.especialidadTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter();
			this.tipoColegiaturaTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TipoColegiaturaTableAdapter();
			this.estadoRegistroTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.EstadoRegistroTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.estadoRegistroBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personalDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoColegiaturaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.busesByIdEspBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.busesDS)).BeginInit();
			this.pnlEspec.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkBlue;
			this.label2.Location = new System.Drawing.Point(10, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre del Especialista";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkBlue;
			this.label3.Location = new System.Drawing.Point(228, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nro Coleg";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkBlue;
			this.label4.Location = new System.Drawing.Point(305, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nombre de la Especialidad";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkBlue;
			this.label5.Location = new System.Drawing.Point(498, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Nombre del Consultorio";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkBlue;
			this.label6.Location = new System.Drawing.Point(689, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Estado del Bus";
			// 
			// txtEspecialista
			// 
			this.txtEspecialista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEspecialista.Location = new System.Drawing.Point(7, 25);
			this.txtEspecialista.Name = "txtEspecialista";
			this.txtEspecialista.Size = new System.Drawing.Size(210, 20);
			this.txtEspecialista.TabIndex = 6;
			this.txtEspecialista.TextChanged += new System.EventHandler(this.txtEspecialista_TextChanged);
			// 
			// txtNCP
			// 
			this.txtNCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNCP.Location = new System.Drawing.Point(224, 25);
			this.txtNCP.MaxLength = 6;
			this.txtNCP.Name = "txtNCP";
			this.txtNCP.Size = new System.Drawing.Size(74, 20);
			this.txtNCP.TabIndex = 7;
			this.txtNCP.TextChanged += new System.EventHandler(this.txtNCP_TextChanged);
			// 
			// txtEspecialidad
			// 
			this.txtEspecialidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEspecialidad.Location = new System.Drawing.Point(303, 25);
			this.txtEspecialidad.Name = "txtEspecialidad";
			this.txtEspecialidad.Size = new System.Drawing.Size(187, 20);
			this.txtEspecialidad.TabIndex = 8;
			this.txtEspecialidad.TextChanged += new System.EventHandler(this.txtEspecialidad_TextChanged);
			// 
			// txtConsultorio
			// 
			this.txtConsultorio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtConsultorio.Location = new System.Drawing.Point(495, 25);
			this.txtConsultorio.Name = "txtConsultorio";
			this.txtConsultorio.Size = new System.Drawing.Size(185, 20);
			this.txtConsultorio.TabIndex = 9;
			this.txtConsultorio.TextChanged += new System.EventHandler(this.txtConsultorio_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Apellidos y Nombres";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 51);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(118, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Tipo de Colegiatura";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(156, 52);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Nro Coleg";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(244, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "R.N.E.";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(332, 50);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 13);
			this.label11.TabIndex = 16;
			this.label11.Text = "Estado";
			// 
			// cmbEstList
			// 
			this.cmbEstList.DataSource = this.estadoRegistroBindingSource;
			this.cmbEstList.DisplayMember = "Descripcion";
			this.cmbEstList.FormattingEnabled = true;
			this.cmbEstList.Location = new System.Drawing.Point(684, 24);
			this.cmbEstList.Name = "cmbEstList";
			this.cmbEstList.Size = new System.Drawing.Size(117, 21);
			this.cmbEstList.TabIndex = 17;
			this.cmbEstList.ValueMember = "Id_Tipo";
			this.cmbEstList.SelectionChangeCommitted += new System.EventHandler(this.cmbEstList_SelectionChangeCommitted);
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
			// cmbPersonal
			// 
			this.cmbPersonal.DataSource = this.personalBindingSource;
			this.cmbPersonal.DisplayMember = "Descripcion";
			this.cmbPersonal.Enabled = false;
			this.cmbPersonal.FormattingEnabled = true;
			this.cmbPersonal.Location = new System.Drawing.Point(5, 23);
			this.cmbPersonal.Name = "cmbPersonal";
			this.cmbPersonal.Size = new System.Drawing.Size(460, 21);
			this.cmbPersonal.TabIndex = 18;
			this.cmbPersonal.ValueMember = "Id_Personal";
			this.cmbPersonal.SelectionChangeCommitted += new System.EventHandler(this.cmbPersonal_SelectionChangeCommitted);
			// 
			// personalBindingSource
			// 
			this.personalBindingSource.DataMember = "Personal";
			this.personalBindingSource.DataSource = this.personalDS;
			// 
			// personalDS
			// 
			this.personalDS.DataSetName = "PersonalDS";
			this.personalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmbTCol
			// 
			this.cmbTCol.BackColor = System.Drawing.SystemColors.Window;
			this.cmbTCol.DataSource = this.tipoColegiaturaBindingSource;
			this.cmbTCol.DisplayMember = "Descripcion";
			this.cmbTCol.Enabled = false;
			this.cmbTCol.FormattingEnabled = true;
			this.cmbTCol.Location = new System.Drawing.Point(5, 67);
			this.cmbTCol.Name = "cmbTCol";
			this.cmbTCol.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbTCol.Size = new System.Drawing.Size(142, 21);
			this.cmbTCol.TabIndex = 19;
			this.cmbTCol.ValueMember = "Id_Tipo";
			// 
			// tipoColegiaturaBindingSource
			// 
			this.tipoColegiaturaBindingSource.DataMember = "TipoColegiatura";
			this.tipoColegiaturaBindingSource.DataSource = this.tablaTipoDS;
			// 
			// cmbEstado
			// 
			this.cmbEstado.DataSource = this.estadoRegistroBindingSource;
			this.cmbEstado.DisplayMember = "Descripcion";
			this.cmbEstado.Enabled = false;
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Location = new System.Drawing.Point(328, 66);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(137, 21);
			this.cmbEstado.TabIndex = 22;
			this.cmbEstado.ValueMember = "Id_Tipo";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(8, 94);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(79, 13);
			this.label12.TabIndex = 23;
			this.label12.Text = "Especialidad";
			// 
			// cmbEspecialidad
			// 
			this.cmbEspecialidad.DataSource = this.especialidadBindingSource;
			this.cmbEspecialidad.DisplayMember = "Descripcion";
			this.cmbEspecialidad.Enabled = false;
			this.cmbEspecialidad.FormattingEnabled = true;
			this.cmbEspecialidad.Location = new System.Drawing.Point(5, 110);
			this.cmbEspecialidad.Name = "cmbEspecialidad";
			this.cmbEspecialidad.Size = new System.Drawing.Size(290, 21);
			this.cmbEspecialidad.TabIndex = 24;
			this.cmbEspecialidad.ValueMember = "Id_Consultorio";
			this.cmbEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cmbEspecialidad_SelectionChangeCommitted);
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
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(296, 94);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(103, 13);
			this.label13.TabIndex = 25;
			this.label13.Text = "Consultorio (Bus)";
			// 
			// cmbConsultorio
			// 
			this.cmbConsultorio.DataSource = this.busesByIdEspBindingSource;
			this.cmbConsultorio.DisplayMember = "Bus";
			this.cmbConsultorio.Enabled = false;
			this.cmbConsultorio.FormattingEnabled = true;
			this.cmbConsultorio.Location = new System.Drawing.Point(299, 110);
			this.cmbConsultorio.Name = "cmbConsultorio";
			this.cmbConsultorio.Size = new System.Drawing.Size(165, 21);
			this.cmbConsultorio.TabIndex = 26;
			this.cmbConsultorio.ValueMember = "Id_Bus";
			// 
			// busesByIdEspBindingSource
			// 
			this.busesByIdEspBindingSource.DataMember = "BusesByIdEsp";
			this.busesByIdEspBindingSource.DataSource = this.busesDS;
			// 
			// busesDS
			// 
			this.busesDS.DataSetName = "BusesDS";
			this.busesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(9, 138);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(74, 13);
			this.label14.TabIndex = 27;
			this.label14.Text = "Descripción";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(389, 324);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(84, 28);
			this.btnNuevo.TabIndex = 29;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnGrabar
			// 
			this.btnGrabar.Enabled = false;
			this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
			this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGrabar.Location = new System.Drawing.Point(476, 324);
			this.btnGrabar.Name = "btnGrabar";
			this.btnGrabar.Size = new System.Drawing.Size(85, 28);
			this.btnGrabar.TabIndex = 30;
			this.btnGrabar.Text = "&Grabar";
			this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGrabar.UseVisualStyleBackColor = true;
			this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(564, 324);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(82, 28);
			this.btnCancelar.TabIndex = 31;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(649, 324);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(86, 28);
			this.btnEditar.TabIndex = 32;
			this.btnEditar.Text = "&Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// lstBusMed
			// 
			this.lstBusMed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
			this.lstBusMed.FullRowSelect = true;
			this.lstBusMed.HideSelection = false;
			this.lstBusMed.Location = new System.Drawing.Point(8, 55);
			this.lstBusMed.MultiSelect = false;
			this.lstBusMed.Name = "lstBusMed";
			this.lstBusMed.Size = new System.Drawing.Size(314, 296);
			this.lstBusMed.TabIndex = 37;
			this.lstBusMed.UseCompatibleStateImageBehavior = false;
			this.lstBusMed.View = System.Windows.Forms.View.Details;
			this.lstBusMed.SelectedIndexChanged += new System.EventHandler(this.lstBusMed_SelectedIndexChanged);
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Especialista";
			this.columnHeader11.Width = 200;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Especialidad";
			this.columnHeader12.Width = 100;
			// 
			// txtObs
			// 
			this.txtObs.Enabled = false;
			this.txtObs.Location = new System.Drawing.Point(5, 154);
			this.txtObs.Multiline = true;
			this.txtObs.Name = "txtObs";
			this.txtObs.Size = new System.Drawing.Size(461, 67);
			this.txtObs.TabIndex = 38;
			// 
			// txtLastUpDate
			// 
			this.txtLastUpDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.txtLastUpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastUpDate.Location = new System.Drawing.Point(247, 230);
			this.txtLastUpDate.Name = "txtLastUpDate";
			this.txtLastUpDate.Size = new System.Drawing.Size(185, 20);
			this.txtLastUpDate.TabIndex = 40;
			this.txtLastUpDate.Text = "LastUpDate";
			this.txtLastUpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCreacion
			// 
			this.txtCreacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.txtCreacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCreacion.Location = new System.Drawing.Point(41, 230);
			this.txtCreacion.Name = "txtCreacion";
			this.txtCreacion.Size = new System.Drawing.Size(190, 20);
			this.txtCreacion.TabIndex = 39;
			this.txtCreacion.Text = "Creation";
			this.txtCreacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pnlEspec
			// 
			this.pnlEspec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.pnlEspec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlEspec.Controls.Add(this.txtRNE);
			this.pnlEspec.Controls.Add(this.txtNCol);
			this.pnlEspec.Controls.Add(this.label7);
			this.pnlEspec.Controls.Add(this.txtLastUpDate);
			this.pnlEspec.Controls.Add(this.label8);
			this.pnlEspec.Controls.Add(this.txtCreacion);
			this.pnlEspec.Controls.Add(this.label9);
			this.pnlEspec.Controls.Add(this.txtObs);
			this.pnlEspec.Controls.Add(this.label10);
			this.pnlEspec.Controls.Add(this.label11);
			this.pnlEspec.Controls.Add(this.cmbPersonal);
			this.pnlEspec.Controls.Add(this.cmbTCol);
			this.pnlEspec.Controls.Add(this.label14);
			this.pnlEspec.Controls.Add(this.cmbEstado);
			this.pnlEspec.Controls.Add(this.cmbConsultorio);
			this.pnlEspec.Controls.Add(this.label12);
			this.pnlEspec.Controls.Add(this.label13);
			this.pnlEspec.Controls.Add(this.cmbEspecialidad);
			this.pnlEspec.Location = new System.Drawing.Point(330, 56);
			this.pnlEspec.Name = "pnlEspec";
			this.pnlEspec.Size = new System.Drawing.Size(472, 261);
			this.pnlEspec.TabIndex = 41;
			// 
			// txtRNE
			// 
			this.txtRNE.Enabled = false;
			this.txtRNE.Location = new System.Drawing.Point(239, 66);
			this.txtRNE.Mask = "999999";
			this.txtRNE.Name = "txtRNE";
			this.txtRNE.Size = new System.Drawing.Size(80, 20);
			this.txtRNE.TabIndex = 42;
			// 
			// txtNCol
			// 
			this.txtNCol.Enabled = false;
			this.txtNCol.Location = new System.Drawing.Point(153, 66);
			this.txtNCol.Mask = "999999";
			this.txtNCol.Name = "txtNCol";
			this.txtNCol.Size = new System.Drawing.Size(80, 20);
			this.txtNCol.TabIndex = 41;
			// 
			// busesByIdEspTableAdapter
			// 
			this.busesByIdEspTableAdapter.ClearBeforeFill = true;
			// 
			// personalTableAdapter
			// 
			this.personalTableAdapter.ClearBeforeFill = true;
			// 
			// especialidadTableAdapter
			// 
			this.especialidadTableAdapter.ClearBeforeFill = true;
			// 
			// tipoColegiaturaTableAdapter
			// 
			this.tipoColegiaturaTableAdapter.ClearBeforeFill = true;
			// 
			// estadoRegistroTableAdapter
			// 
			this.estadoRegistroTableAdapter.ClearBeforeFill = true;
			// 
			// frmEspecialistas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 359);
			this.ControlBox = false;
			this.Controls.Add(this.pnlEspec);
			this.Controls.Add(this.lstBusMed);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGrabar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.cmbEstList);
			this.Controls.Add(this.txtConsultorio);
			this.Controls.Add(this.txtEspecialidad);
			this.Controls.Add(this.txtNCP);
			this.Controls.Add(this.txtEspecialista);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "frmEspecialistas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registro de Especialistas por Consultorio";
			this.Load += new System.EventHandler(this.frmEspecialistas_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEspecialistas_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.estadoRegistroBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personalDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoColegiaturaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.busesByIdEspBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.busesDS)).EndInit();
			this.pnlEspec.ResumeLayout(false);
			this.pnlEspec.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEspecialista;
        private System.Windows.Forms.TextBox txtNCP;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtConsultorio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEstList;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.ComboBox cmbTCol;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ListView lstBusMed;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtLastUpDate;
        private System.Windows.Forms.TextBox txtCreacion;
        private System.Windows.Forms.Panel pnlEspec;
        private System.Windows.Forms.BindingSource busesByIdEspBindingSource;
        private Dominio.Data.BusesDS busesDS;
        private Dominio.Data.BusesDSTableAdapters.BusesByIdEspTableAdapter busesByIdEspTableAdapter;
        private Dominio.Data.PersonalDS personalDS;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private Dominio.Data.PersonalDSTableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource tipoColegiaturaBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TipoColegiaturaTableAdapter tipoColegiaturaTableAdapter;
        private System.Windows.Forms.BindingSource estadoRegistroBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.EstadoRegistroTableAdapter estadoRegistroTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtRNE;
        private System.Windows.Forms.MaskedTextBox txtNCol;
    }
}