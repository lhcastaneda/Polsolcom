namespace Polsolcom.Forms
{
    partial class frmPersonal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDoc = new System.Windows.Forms.MaskedTextBox();
            this.lstPersonal = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.estadoRegistroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtRne = new System.Windows.Forms.MaskedTextBox();
            this.txtNCol = new System.Windows.Forms.MaskedTextBox();
            this.txtRuc = new System.Windows.Forms.MaskedTextBox();
            this.txtDni = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosDS = new Polsolcom.Dominio.Data.DepartamentosDS();
            this.opgSexo = new System.Windows.Forms.Panel();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasDS = new Polsolcom.Dominio.Data.ProvinciasDS();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.distritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distritoDS = new Polsolcom.Dominio.Data.DistritoDS();
            this.txtFechaCes = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFechaIng = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtIdPersonal = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnCurriculum = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.chkDscto = new System.Windows.Forms.CheckBox();
            this.lblVitae = new System.Windows.Forms.LinkLabel();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cargosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargoDS = new Polsolcom.Dominio.Data.CargoDS();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.areaTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.cmbProfesion = new System.Windows.Forms.ComboBox();
            this.profesionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.gradoInstruccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.estadoCivilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbModCont = new System.Windows.Forms.ComboBox();
            this.modalidadContatacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTCol = new System.Windows.Forms.ComboBox();
            this.tipoColegiaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnOtrosDatos = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.profesionTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.ProfesionTableAdapter();
            this.modalidadContatacionTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.ModalidadContatacionTableAdapter();
            this.estadoCivilTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.EstadoCivilTableAdapter();
            this.gradoInstruccionTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.GradoInstruccionTableAdapter();
            this.areaTrabajoTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.AreaTrabajoTableAdapter();
            this.cargosTableAdapter = new Polsolcom.Dominio.Data.CargoDSTableAdapters.CargosTableAdapter();
            this.departamentosTableAdapter = new Polsolcom.Dominio.Data.DepartamentosDSTableAdapters.DepartamentosTableAdapter();
            this.provinciasTableAdapter = new Polsolcom.Dominio.Data.ProvinciasDSTableAdapters.ProvinciasTableAdapter();
            this.distritoTableAdapter = new Polsolcom.Dominio.Data.DistritoDSTableAdapters.DistritoTableAdapter();
            this.tipoColegiaturaTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TipoColegiaturaTableAdapter();
            this.estadoRegistroTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.EstadoRegistroTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoRegistroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosDS)).BeginInit();
            this.opgSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaTrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoInstruccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCivilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadContatacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoColegiaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDoc);
            this.panel1.Controls.Add(this.lstPersonal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 446);
            this.panel1.TabIndex = 0;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(5, 23);
            this.txtDoc.Mask = "99999999";
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(70, 20);
            this.txtDoc.TabIndex = 3;
            this.txtDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDoc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDoc_MaskInputRejected);
            this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
            // 
            // lstPersonal
            // 
            this.lstPersonal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstPersonal.FullRowSelect = true;
            this.lstPersonal.HideSelection = false;
            this.lstPersonal.Location = new System.Drawing.Point(6, 95);
            this.lstPersonal.Name = "lstPersonal";
            this.lstPersonal.Size = new System.Drawing.Size(194, 336);
            this.lstPersonal.TabIndex = 6;
            this.lstPersonal.UseCompatibleStateImageBehavior = false;
            this.lstPersonal.View = System.Windows.Forms.View.Details;
            this.lstPersonal.SelectedIndexChanged += new System.EventHandler(this.lstPersonal_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Personal";
            this.columnHeader1.Width = 190;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Búsqueda";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(4, 70);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(196, 20);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DataSource = this.estadoRegistroBindingSource;
            this.cmbEstado.DisplayMember = "Descripcion";
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(79, 23);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doc.";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatos.Controls.Add(this.txtRne);
            this.pnlDatos.Controls.Add(this.txtNCol);
            this.pnlDatos.Controls.Add(this.txtRuc);
            this.pnlDatos.Controls.Add(this.txtDni);
            this.pnlDatos.Controls.Add(this.label14);
            this.pnlDatos.Controls.Add(this.cmbDepartamento);
            this.pnlDatos.Controls.Add(this.opgSexo);
            this.pnlDatos.Controls.Add(this.cmbProvincia);
            this.pnlDatos.Controls.Add(this.txtFechaNac);
            this.pnlDatos.Controls.Add(this.cmbDistrito);
            this.pnlDatos.Controls.Add(this.txtFechaCes);
            this.pnlDatos.Controls.Add(this.label15);
            this.pnlDatos.Controls.Add(this.txtFechaIng);
            this.pnlDatos.Controls.Add(this.label16);
            this.pnlDatos.Controls.Add(this.label31);
            this.pnlDatos.Controls.Add(this.txtIdPersonal);
            this.pnlDatos.Controls.Add(this.lblDNI);
            this.pnlDatos.Controls.Add(this.picFoto);
            this.pnlDatos.Controls.Add(this.btnCurriculum);
            this.pnlDatos.Controls.Add(this.btnFoto);
            this.pnlDatos.Controls.Add(this.chkStatus);
            this.pnlDatos.Controls.Add(this.chkDscto);
            this.pnlDatos.Controls.Add(this.lblVitae);
            this.pnlDatos.Controls.Add(this.txtObservacion);
            this.pnlDatos.Controls.Add(this.txtEmail);
            this.pnlDatos.Controls.Add(this.label29);
            this.pnlDatos.Controls.Add(this.label28);
            this.pnlDatos.Controls.Add(this.label27);
            this.pnlDatos.Controls.Add(this.cmbCargo);
            this.pnlDatos.Controls.Add(this.cmbArea);
            this.pnlDatos.Controls.Add(this.label26);
            this.pnlDatos.Controls.Add(this.cmbProfesion);
            this.pnlDatos.Controls.Add(this.label25);
            this.pnlDatos.Controls.Add(this.cmbGrado);
            this.pnlDatos.Controls.Add(this.label24);
            this.pnlDatos.Controls.Add(this.label23);
            this.pnlDatos.Controls.Add(this.label22);
            this.pnlDatos.Controls.Add(this.label21);
            this.pnlDatos.Controls.Add(this.label20);
            this.pnlDatos.Controls.Add(this.cmbEstadoCivil);
            this.pnlDatos.Controls.Add(this.cmbModCont);
            this.pnlDatos.Controls.Add(this.label19);
            this.pnlDatos.Controls.Add(this.label18);
            this.pnlDatos.Controls.Add(this.txtCelular);
            this.pnlDatos.Controls.Add(this.txtTelefono);
            this.pnlDatos.Controls.Add(this.txtDireccion);
            this.pnlDatos.Controls.Add(this.label17);
            this.pnlDatos.Controls.Add(this.label13);
            this.pnlDatos.Controls.Add(this.label12);
            this.pnlDatos.Controls.Add(this.label11);
            this.pnlDatos.Controls.Add(this.cmbTCol);
            this.pnlDatos.Controls.Add(this.label10);
            this.pnlDatos.Controls.Add(this.label9);
            this.pnlDatos.Controls.Add(this.txtEdad);
            this.pnlDatos.Controls.Add(this.label8);
            this.pnlDatos.Controls.Add(this.label7);
            this.pnlDatos.Controls.Add(this.label6);
            this.pnlDatos.Controls.Add(this.txtMaterno);
            this.pnlDatos.Controls.Add(this.txtPaterno);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.txtNombres);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Location = new System.Drawing.Point(223, 13);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(773, 373);
            this.pnlDatos.TabIndex = 1;
            // 
            // txtRne
            // 
            this.txtRne.Enabled = false;
            this.txtRne.Location = new System.Drawing.Point(476, 61);
            this.txtRne.Mask = "999999";
            this.txtRne.Name = "txtRne";
            this.txtRne.Size = new System.Drawing.Size(74, 20);
            this.txtRne.TabIndex = 39;
            this.txtRne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNCol
            // 
            this.txtNCol.Enabled = false;
            this.txtNCol.Location = new System.Drawing.Point(392, 59);
            this.txtNCol.Mask = "999999";
            this.txtNCol.Name = "txtNCol";
            this.txtNCol.Size = new System.Drawing.Size(74, 20);
            this.txtNCol.TabIndex = 38;
            this.txtNCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRuc
            // 
            this.txtRuc.Enabled = false;
            this.txtRuc.Location = new System.Drawing.Point(145, 61);
            this.txtRuc.Mask = "99999999";
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(105, 20);
            this.txtRuc.TabIndex = 36;
            this.txtRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(63, 61);
            this.txtDni.Mask = "99999999";
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(77, 20);
            this.txtDni.TabIndex = 35;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(3, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DataSource = this.departamentosBindingSource;
            this.cmbDepartamento.DisplayMember = "Departamento";
            this.cmbDepartamento.Enabled = false;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(4, 102);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(177, 21);
            this.cmbDepartamento.TabIndex = 40;
            this.cmbDepartamento.Tag = "UserData";
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
            // opgSexo
            // 
            this.opgSexo.Controls.Add(this.rbMasculino);
            this.opgSexo.Controls.Add(this.rbFemenino);
            this.opgSexo.Location = new System.Drawing.Point(590, 31);
            this.opgSexo.Name = "opgSexo";
            this.opgSexo.Size = new System.Drawing.Size(161, 25);
            this.opgSexo.TabIndex = 12;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Enabled = false;
            this.rbMasculino.Location = new System.Drawing.Point(5, 3);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "&Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Enabled = false;
            this.rbFemenino.Location = new System.Drawing.Point(86, 4);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.Text = "&Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DataSource = this.provinciasBindingSource;
            this.cmbProvincia.DisplayMember = "Provincia";
            this.cmbProvincia.Enabled = false;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(187, 102);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(181, 21);
            this.cmbProvincia.TabIndex = 41;
            this.cmbProvincia.Tag = "UserData";
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
            // txtFechaNac
            // 
            this.txtFechaNac.Enabled = false;
            this.txtFechaNac.Location = new System.Drawing.Point(455, 21);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(97, 20);
            this.txtFechaNac.TabIndex = 33;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            this.txtFechaNac.Leave += new System.EventHandler(this.txtFechaNac_Leave);
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.DataSource = this.distritoBindingSource;
            this.cmbDistrito.DisplayMember = "Distrito";
            this.cmbDistrito.Enabled = false;
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(374, 102);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(179, 21);
            this.cmbDistrito.TabIndex = 42;
            this.cmbDistrito.Tag = "UserData";
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
            // txtFechaCes
            // 
            this.txtFechaCes.Enabled = false;
            this.txtFechaCes.Location = new System.Drawing.Point(106, 184);
            this.txtFechaCes.Mask = "00/00/0000";
            this.txtFechaCes.Name = "txtFechaCes";
            this.txtFechaCes.Size = new System.Drawing.Size(97, 20);
            this.txtFechaCes.TabIndex = 47;
            this.txtFechaCes.ValidatingType = typeof(System.DateTime);
            this.txtFechaCes.Leave += new System.EventHandler(this.txtFechaCes_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(184, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Provincia";
            // 
            // txtFechaIng
            // 
            this.txtFechaIng.Enabled = false;
            this.txtFechaIng.Location = new System.Drawing.Point(3, 184);
            this.txtFechaIng.Mask = "00/00/0000";
            this.txtFechaIng.Name = "txtFechaIng";
            this.txtFechaIng.Size = new System.Drawing.Size(97, 20);
            this.txtFechaIng.TabIndex = 46;
            this.txtFechaIng.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(371, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Distrito";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.DarkBlue;
            this.label31.Location = new System.Drawing.Point(569, 8);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(28, 13);
            this.label31.TabIndex = 4;
            this.label31.Text = "ID :";
            // 
            // txtIdPersonal
            // 
            this.txtIdPersonal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtIdPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPersonal.Enabled = false;
            this.txtIdPersonal.Location = new System.Drawing.Point(603, 5);
            this.txtIdPersonal.Name = "txtIdPersonal";
            this.txtIdPersonal.Size = new System.Drawing.Size(158, 20);
            this.txtIdPersonal.TabIndex = 5;
            this.txtIdPersonal.Tag = "UserData";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(633, 310);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(69, 18);
            this.lblDNI.TabIndex = 29;
            this.lblDNI.Text = "*458513";
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Location = new System.Drawing.Point(572, 60);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(189, 247);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFoto.TabIndex = 57;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // btnCurriculum
            // 
            this.btnCurriculum.Enabled = false;
            this.btnCurriculum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurriculum.Location = new System.Drawing.Point(674, 340);
            this.btnCurriculum.Name = "btnCurriculum";
            this.btnCurriculum.Size = new System.Drawing.Size(91, 23);
            this.btnCurriculum.TabIndex = 59;
            this.btnCurriculum.Tag = "UserData";
            this.btnCurriculum.Text = "&Curriculum";
            this.btnCurriculum.UseVisualStyleBackColor = true;
            this.btnCurriculum.Click += new System.EventHandler(this.btnCurriculum_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Enabled = false;
            this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.Location = new System.Drawing.Point(572, 340);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(92, 23);
            this.btnFoto.TabIndex = 58;
            this.btnFoto.Tag = "UserData";
            this.btnFoto.Text = "&Fotografía";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Enabled = false;
            this.chkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStatus.Location = new System.Drawing.Point(446, 331);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(98, 17);
            this.chkStatus.TabIndex = 57;
            this.chkStatus.Tag = "UserData";
            this.chkStatus.Text = "En Acti&vidad";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // chkDscto
            // 
            this.chkDscto.AutoSize = true;
            this.chkDscto.Enabled = false;
            this.chkDscto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDscto.Location = new System.Drawing.Point(322, 331);
            this.chkDscto.Name = "chkDscto";
            this.chkDscto.Size = new System.Drawing.Size(105, 17);
            this.chkDscto.TabIndex = 56;
            this.chkDscto.Tag = "UserData";
            this.chkDscto.Text = "Realiza &Dscto";
            this.chkDscto.UseVisualStyleBackColor = true;
            // 
            // lblVitae
            // 
            this.lblVitae.AutoSize = true;
            this.lblVitae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitae.Location = new System.Drawing.Point(2, 330);
            this.lblVitae.Name = "lblVitae";
            this.lblVitae.Size = new System.Drawing.Size(88, 15);
            this.lblVitae.TabIndex = 55;
            this.lblVitae.TabStop = true;
            this.lblVitae.Text = "Ver Curriculum";
            this.lblVitae.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVitae_LinkClicked);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Enabled = false;
            this.txtObservacion.Location = new System.Drawing.Point(289, 305);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(263, 20);
            this.txtObservacion.TabIndex = 0;
            this.txtObservacion.Tag = "UserData";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(3, 305);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 20);
            this.txtEmail.TabIndex = 60;
            this.txtEmail.Tag = "UserData";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.DarkBlue;
            this.label29.Location = new System.Drawing.Point(287, 289);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(78, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "Observación";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.DarkBlue;
            this.label28.Location = new System.Drawing.Point(2, 289);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(163, 13);
            this.label28.TabIndex = 27;
            this.label28.Text = "Email (email1 /email2/ etc.)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DarkBlue;
            this.label27.Location = new System.Drawing.Point(287, 249);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 13);
            this.label27.TabIndex = 26;
            this.label27.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DataSource = this.cargosBindingSource;
            this.cmbCargo.DisplayMember = "Descripcion";
            this.cmbCargo.Enabled = false;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(289, 265);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(263, 21);
            this.cmbCargo.TabIndex = 53;
            this.cmbCargo.Tag = "UserData";
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
            // cmbArea
            // 
            this.cmbArea.DataSource = this.areaTrabajoBindingSource;
            this.cmbArea.DisplayMember = "Descripcion";
            this.cmbArea.Enabled = false;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(3, 265);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(280, 21);
            this.cmbArea.TabIndex = 52;
            this.cmbArea.Tag = "UserData";
            this.cmbArea.ValueMember = "Id_Tipo";
            // 
            // areaTrabajoBindingSource
            // 
            this.areaTrabajoBindingSource.DataMember = "AreaTrabajo";
            this.areaTrabajoBindingSource.DataSource = this.tablaTipoDS;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DarkBlue;
            this.label26.Location = new System.Drawing.Point(2, 249);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(98, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Área de Trabajo";
            // 
            // cmbProfesion
            // 
            this.cmbProfesion.DataSource = this.profesionBindingSource;
            this.cmbProfesion.DisplayMember = "Descripcion";
            this.cmbProfesion.Enabled = false;
            this.cmbProfesion.FormattingEnabled = true;
            this.cmbProfesion.Location = new System.Drawing.Point(289, 225);
            this.cmbProfesion.Name = "cmbProfesion";
            this.cmbProfesion.Size = new System.Drawing.Size(263, 21);
            this.cmbProfesion.TabIndex = 51;
            this.cmbProfesion.Tag = "UserData";
            this.cmbProfesion.ValueMember = "Id_Tipo";
            // 
            // profesionBindingSource
            // 
            this.profesionBindingSource.DataMember = "Profesion";
            this.profesionBindingSource.DataSource = this.tablaTipoDS;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DarkBlue;
            this.label25.Location = new System.Drawing.Point(286, 209);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "Profesión";
            // 
            // cmbGrado
            // 
            this.cmbGrado.DataSource = this.gradoInstruccionBindingSource;
            this.cmbGrado.DisplayMember = "Descripcion";
            this.cmbGrado.Enabled = false;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(3, 225);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(280, 21);
            this.cmbGrado.TabIndex = 50;
            this.cmbGrado.Tag = "UserData";
            this.cmbGrado.ValueMember = "Id_Tipo";
            // 
            // gradoInstruccionBindingSource
            // 
            this.gradoInstruccionBindingSource.DataMember = "GradoInstruccion";
            this.gradoInstruccionBindingSource.DataSource = this.tablaTipoDS;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DarkBlue;
            this.label24.Location = new System.Drawing.Point(2, 209);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(126, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Grado de Instrucción";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkBlue;
            this.label23.Location = new System.Drawing.Point(370, 169);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Estado Civil";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkBlue;
            this.label22.Location = new System.Drawing.Point(211, 169);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Mod. Contratación";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkBlue;
            this.label21.Location = new System.Drawing.Point(106, 169);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Fecha Cese";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkBlue;
            this.label20.Location = new System.Drawing.Point(2, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Fecha Inicio";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DataSource = this.estadoCivilBindingSource;
            this.cmbEstadoCivil.DisplayMember = "Descripcion";
            this.cmbEstadoCivil.Enabled = false;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(373, 185);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(179, 21);
            this.cmbEstadoCivil.TabIndex = 49;
            this.cmbEstadoCivil.Tag = "UserData";
            this.cmbEstadoCivil.ValueMember = "Id_Tipo";
            // 
            // estadoCivilBindingSource
            // 
            this.estadoCivilBindingSource.DataMember = "EstadoCivil";
            this.estadoCivilBindingSource.DataSource = this.tablaTipoDS;
            // 
            // cmbModCont
            // 
            this.cmbModCont.DataSource = this.modalidadContatacionBindingSource;
            this.cmbModCont.DisplayMember = "Descripcion";
            this.cmbModCont.Enabled = false;
            this.cmbModCont.FormattingEnabled = true;
            this.cmbModCont.Location = new System.Drawing.Point(207, 186);
            this.cmbModCont.Name = "cmbModCont";
            this.cmbModCont.Size = new System.Drawing.Size(160, 21);
            this.cmbModCont.TabIndex = 48;
            this.cmbModCont.Tag = "UserData";
            this.cmbModCont.ValueMember = "Id_Tipo";
            // 
            // modalidadContatacionBindingSource
            // 
            this.modalidadContatacionBindingSource.DataMember = "ModalidadContatacion";
            this.modalidadContatacionBindingSource.DataSource = this.tablaTipoDS;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(452, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Celular";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkBlue;
            this.label18.Location = new System.Drawing.Point(370, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Teléfono";
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(455, 146);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(97, 20);
            this.txtCelular.TabIndex = 45;
            this.txtCelular.Tag = "UserData";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(373, 146);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(76, 20);
            this.txtTelefono.TabIndex = 44;
            this.txtTelefono.Tag = "UserData";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(3, 146);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(364, 20);
            this.txtDireccion.TabIndex = 43;
            this.txtDireccion.Tag = "UserData";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkBlue;
            this.label17.Location = new System.Drawing.Point(2, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(251, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Dirección (Av. /Calle /Urb. /Mz. /Lt. / etc)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(470, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "R.N.E.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(388, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nro Coleg.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(252, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tip Coleg.";
            // 
            // cmbTCol
            // 
            this.cmbTCol.DataSource = this.tipoColegiaturaBindingSource;
            this.cmbTCol.DisplayMember = "Descripcion";
            this.cmbTCol.Enabled = false;
            this.cmbTCol.FormattingEnabled = true;
            this.cmbTCol.Location = new System.Drawing.Point(254, 60);
            this.cmbTCol.Name = "cmbTCol";
            this.cmbTCol.Size = new System.Drawing.Size(131, 21);
            this.cmbTCol.TabIndex = 37;
            this.cmbTCol.Tag = "UserData";
            this.cmbTCol.ValueMember = "Id_Tipo";
            // 
            // tipoColegiaturaBindingSource
            // 
            this.tipoColegiaturaBindingSource.DataMember = "TipoColegiatura";
            this.tipoColegiaturaBindingSource.DataSource = this.tablaTipoDS;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(147, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "R.U.C.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(64, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "D.N.I.";
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(3, 60);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(55, 20);
            this.txtEdad.TabIndex = 34;
            this.txtEdad.Tag = "UserData";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(2, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Edad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(453, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha de Nac.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(301, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Apellido Materno";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Enabled = false;
            this.txtMaterno.Location = new System.Drawing.Point(304, 21);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(146, 20);
            this.txtMaterno.TabIndex = 32;
            this.txtMaterno.Tag = "UserData";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Enabled = false;
            this.txtPaterno.Location = new System.Drawing.Point(159, 21);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(139, 20);
            this.txtPaterno.TabIndex = 31;
            this.txtPaterno.Tag = "UserData";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(156, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellido Paterno";
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(3, 21);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(150, 20);
            this.txtNombres.TabIndex = 30;
            this.txtNombres.Tag = "UserData";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(2, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(275, 412);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 38);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrabar.Location = new System.Drawing.Point(389, 412);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(108, 38);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(503, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(617, 412);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 38);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnOtrosDatos
            // 
            this.btnOtrosDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtrosDatos.Location = new System.Drawing.Point(731, 412);
            this.btnOtrosDatos.Name = "btnOtrosDatos";
            this.btnOtrosDatos.Size = new System.Drawing.Size(108, 38);
            this.btnOtrosDatos.TabIndex = 6;
            this.btnOtrosDatos.Text = "&Otros\r\nDatos";
            this.btnOtrosDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOtrosDatos.UseVisualStyleBackColor = true;
            this.btnOtrosDatos.Click += new System.EventHandler(this.btnOtrosDatos_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(845, 412);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(108, 38);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // profesionTableAdapter
            // 
            this.profesionTableAdapter.ClearBeforeFill = true;
            // 
            // modalidadContatacionTableAdapter
            // 
            this.modalidadContatacionTableAdapter.ClearBeforeFill = true;
            // 
            // estadoCivilTableAdapter
            // 
            this.estadoCivilTableAdapter.ClearBeforeFill = true;
            // 
            // gradoInstruccionTableAdapter
            // 
            this.gradoInstruccionTableAdapter.ClearBeforeFill = true;
            // 
            // areaTrabajoTableAdapter
            // 
            this.areaTrabajoTableAdapter.ClearBeforeFill = true;
            // 
            // cargosTableAdapter
            // 
            this.cargosTableAdapter.ClearBeforeFill = true;
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
            // tipoColegiaturaTableAdapter
            // 
            this.tipoColegiaturaTableAdapter.ClearBeforeFill = true;
            // 
            // estadoRegistroTableAdapter
            // 
            this.estadoRegistroTableAdapter.ClearBeforeFill = true;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 478);
            this.ControlBox = false;
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnOtrosDatos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro del Personal";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPersonal_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoRegistroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosDS)).EndInit();
            this.opgSexo.ResumeLayout(false);
            this.opgSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoInstruccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCivilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadContatacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoColegiaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCurriculum;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.CheckBox chkDscto;
        private System.Windows.Forms.LinkLabel lblVitae;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbProfesion;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.ComboBox cmbModCont;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTCol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtIdPersonal;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnOtrosDatos;
        private System.Windows.Forms.Button btnImprimir;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource profesionBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.ProfesionTableAdapter profesionTableAdapter;
        private System.Windows.Forms.BindingSource modalidadContatacionBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.ModalidadContatacionTableAdapter modalidadContatacionTableAdapter;
        private System.Windows.Forms.BindingSource estadoCivilBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.EstadoCivilTableAdapter estadoCivilTableAdapter;
        private System.Windows.Forms.BindingSource gradoInstruccionBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.GradoInstruccionTableAdapter gradoInstruccionTableAdapter;
        private System.Windows.Forms.BindingSource areaTrabajoBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.AreaTrabajoTableAdapter areaTrabajoTableAdapter;
        private Dominio.Data.CargoDS cargoDS;
        private System.Windows.Forms.BindingSource cargosBindingSource;
        private Dominio.Data.CargoDSTableAdapters.CargosTableAdapter cargosTableAdapter;
        private System.Windows.Forms.ListView lstPersonal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private System.Windows.Forms.MaskedTextBox txtFechaCes;
        private System.Windows.Forms.MaskedTextBox txtFechaIng;
        private System.Windows.Forms.Panel opgSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Dominio.Data.DepartamentosDS departamentosDS;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private Dominio.Data.DepartamentosDSTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private Dominio.Data.ProvinciasDS provinciasDS;
        private System.Windows.Forms.BindingSource distritoBindingSource;
        private Dominio.Data.DistritoDS distritoDS;
        private Dominio.Data.ProvinciasDSTableAdapters.ProvinciasTableAdapter provinciasTableAdapter;
        private Dominio.Data.DistritoDSTableAdapters.DistritoTableAdapter distritoTableAdapter;
        private System.Windows.Forms.BindingSource tipoColegiaturaBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TipoColegiaturaTableAdapter tipoColegiaturaTableAdapter;
        private System.Windows.Forms.BindingSource estadoRegistroBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.EstadoRegistroTableAdapter estadoRegistroTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtDoc;
        private System.Windows.Forms.MaskedTextBox txtRne;
        private System.Windows.Forms.MaskedTextBox txtNCol;
        private System.Windows.Forms.MaskedTextBox txtRuc;
        private System.Windows.Forms.MaskedTextBox txtDni;
    }
}