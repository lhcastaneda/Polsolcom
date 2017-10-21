namespace Polsolcom.Forms.Mantenimiento
{
    partial class frmSeekPac
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
            this.lstPacientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbTDoc = new System.Windows.Forms.ComboBox();
            this.docIdentidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
            this.label28 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosDS = new Polsolcom.Dominio.Data.DepartamentosDS();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasDS = new Polsolcom.Dominio.Data.ProvinciasDS();
            this.distritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distritoDS = new Polsolcom.Dominio.Data.DistritoDS();
            this.label31 = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.txtDoc = new System.Windows.Forms.MaskedTextBox();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.txtODoc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsegurado = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpApePat = new System.Windows.Forms.GroupBox();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.grpApeMat = new System.Windows.Forms.GroupBox();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.grpNom = new System.Windows.Forms.GroupBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grpDNI = new System.Windows.Forms.GroupBox();
            this.txtDni = new System.Windows.Forms.MaskedTextBox();
            this.grpIdPac = new System.Windows.Forms.GroupBox();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.grpNroPac = new System.Windows.Forms.GroupBox();
            this.txtNroHist = new System.Windows.Forms.MaskedTextBox();
            this.departamentosTableAdapter = new Polsolcom.Dominio.Data.DepartamentosDSTableAdapters.DepartamentosTableAdapter();
            this.provinciasTableAdapter = new Polsolcom.Dominio.Data.ProvinciasDSTableAdapters.ProvinciasTableAdapter();
            this.distritoTableAdapter = new Polsolcom.Dominio.Data.DistritoDSTableAdapters.DistritoTableAdapter();
            this.docIdentidadTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.DocIdentidadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.docIdentidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoDS)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.grpApePat.SuspendLayout();
            this.grpApeMat.SuspendLayout();
            this.grpNom.SuspendLayout();
            this.grpDNI.SuspendLayout();
            this.grpIdPac.SuspendLayout();
            this.grpNroPac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPacientes
            // 
            this.lstPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstPacientes.FullRowSelect = true;
            this.lstPacientes.Location = new System.Drawing.Point(9, 61);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(709, 162);
            this.lstPacientes.TabIndex = 6;
            this.lstPacientes.UseCompatibleStateImageBehavior = false;
            this.lstPacientes.View = System.Windows.Forms.View.Details;
            this.lstPacientes.SelectedIndexChanged += new System.EventHandler(this.lstPacientes_SelectedIndexChanged);
            this.lstPacientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPacientes_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Apellidos y Nombres";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dirección y Distrito";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DNI";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Teléfono";
            this.columnHeader4.Width = 100;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(541, 182);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(74, 39);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(463, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 39);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrabar.Location = new System.Drawing.Point(384, 181);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(74, 39);
            this.btnGrabar.TabIndex = 35;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(306, 182);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(74, 39);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(106, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(107, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Tag = "UserData";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(260, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido Paterno";
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApePaterno.Enabled = false;
            this.txtApePaterno.Location = new System.Drawing.Point(263, 24);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(139, 20);
            this.txtApePaterno.TabIndex = 19;
            this.txtApePaterno.Tag = "UserData";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeMaterno.Enabled = false;
            this.txtApeMaterno.Location = new System.Drawing.Point(412, 24);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(146, 20);
            this.txtApeMaterno.TabIndex = 20;
            this.txtApeMaterno.Tag = "UserData";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(405, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Apellido Materno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(7, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de Nac.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkBlue;
            this.label17.Location = new System.Drawing.Point(170, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(251, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Dirección (Av. /Calle /Urb. /Mz. /Lt. / etc)";
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(171, 64);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(518, 20);
            this.txtDireccion.TabIndex = 25;
            this.txtDireccion.Tag = "UserData";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(567, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(124, 20);
            this.txtTelefono.TabIndex = 29;
            this.txtTelefono.Tag = "UserData";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkBlue;
            this.label18.Location = new System.Drawing.Point(564, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Teléfono";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(189, 139);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "N° Otro Doc.";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DarkBlue;
            this.label26.Location = new System.Drawing.Point(5, 139);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 13);
            this.label26.TabIndex = 13;
            this.label26.Text = "Tipo Otro Doc.";
            // 
            // cmbTDoc
            // 
            this.cmbTDoc.DataSource = this.docIdentidadBindingSource;
            this.cmbTDoc.DisplayMember = "Descripcion";
            this.cmbTDoc.DropDownWidth = 400;
            this.cmbTDoc.Enabled = false;
            this.cmbTDoc.FormattingEnabled = true;
            this.cmbTDoc.Location = new System.Drawing.Point(6, 155);
            this.cmbTDoc.Name = "cmbTDoc";
            this.cmbTDoc.Size = new System.Drawing.Size(177, 21);
            this.cmbTDoc.TabIndex = 30;
            this.cmbTDoc.Tag = "UserData";
            this.cmbTDoc.ValueMember = "Id_Tipo";
            this.cmbTDoc.SelectionChangeCommitted += new System.EventHandler(this.cmbTDoc_SelectionChangeCommitted);
            // 
            // docIdentidadBindingSource
            // 
            this.docIdentidadBindingSource.DataMember = "DocIdentidad";
            this.docIdentidadBindingSource.DataSource = this.tablaTipoDS;
            // 
            // tablaTipoDS
            // 
            this.tablaTipoDS.DataSetName = "TablaTipoDS";
            this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.DarkBlue;
            this.label28.Location = new System.Drawing.Point(375, 139);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(163, 13);
            this.label28.TabIndex = 16;
            this.label28.Text = "Email (email1 /email2/ etc.)";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(376, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 20);
            this.txtEmail.TabIndex = 33;
            this.txtEmail.Tag = "UserData";
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
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.DarkBlue;
            this.label31.Location = new System.Drawing.Point(7, 8);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(78, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "ID Paciente:";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatos.Controls.Add(this.label14);
            this.pnlDatos.Controls.Add(this.cmbDepartamento);
            this.pnlDatos.Controls.Add(this.txtIdPaciente);
            this.pnlDatos.Controls.Add(this.cmbProvincia);
            this.pnlDatos.Controls.Add(this.txtDoc);
            this.pnlDatos.Controls.Add(this.cmbDistrito);
            this.pnlDatos.Controls.Add(this.txtODoc);
            this.pnlDatos.Controls.Add(this.label15);
            this.pnlDatos.Controls.Add(this.txtFechaNac);
            this.pnlDatos.Controls.Add(this.label16);
            this.pnlDatos.Controls.Add(this.btnAnular);
            this.pnlDatos.Controls.Add(this.btnEditar);
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.btnGrabar);
            this.pnlDatos.Controls.Add(this.txtAsegurado);
            this.pnlDatos.Controls.Add(this.btnNuevo);
            this.pnlDatos.Controls.Add(this.txtEdad);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.label9);
            this.pnlDatos.Controls.Add(this.txtSexo);
            this.pnlDatos.Controls.Add(this.label8);
            this.pnlDatos.Controls.Add(this.label31);
            this.pnlDatos.Controls.Add(this.txtEmail);
            this.pnlDatos.Controls.Add(this.label28);
            this.pnlDatos.Controls.Add(this.cmbTDoc);
            this.pnlDatos.Controls.Add(this.label26);
            this.pnlDatos.Controls.Add(this.label19);
            this.pnlDatos.Controls.Add(this.label18);
            this.pnlDatos.Controls.Add(this.txtTelefono);
            this.pnlDatos.Controls.Add(this.txtDireccion);
            this.pnlDatos.Controls.Add(this.label17);
            this.pnlDatos.Controls.Add(this.label7);
            this.pnlDatos.Controls.Add(this.label6);
            this.pnlDatos.Controls.Add(this.txtApeMaterno);
            this.pnlDatos.Controls.Add(this.txtApePaterno);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Location = new System.Drawing.Point(9, 230);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(711, 231);
            this.pnlDatos.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(7, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DataSource = this.departamentosBindingSource;
            this.cmbDepartamento.DisplayMember = "Departamento";
            this.cmbDepartamento.Enabled = false;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(8, 109);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(177, 21);
            this.cmbDepartamento.TabIndex = 26;
            this.cmbDepartamento.Tag = "UserData";
            this.cmbDepartamento.ValueMember = "Id_Old";
            this.cmbDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartamento_SelectionChangeCommitted);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Enabled = false;
            this.txtIdPaciente.Location = new System.Drawing.Point(5, 24);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(98, 20);
            this.txtIdPaciente.TabIndex = 17;
            this.txtIdPaciente.Tag = "UserData";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DataSource = this.provinciasBindingSource;
            this.cmbProvincia.DisplayMember = "Provincia";
            this.cmbProvincia.Enabled = false;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(191, 109);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(181, 21);
            this.cmbProvincia.TabIndex = 27;
            this.cmbProvincia.Tag = "UserData";
            this.cmbProvincia.ValueMember = "Id_Old";
            this.cmbProvincia.SelectionChangeCommitted += new System.EventHandler(this.cmbProvincia_SelectionChangeCommitted);
            // 
            // txtDoc
            // 
            this.txtDoc.Enabled = false;
            this.txtDoc.Location = new System.Drawing.Point(599, 22);
            this.txtDoc.Mask = "99999999";
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(90, 20);
            this.txtDoc.TabIndex = 22;
            this.txtDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_Leave);
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.DataSource = this.distritoBindingSource;
            this.cmbDistrito.DisplayMember = "Distrito";
            this.cmbDistrito.Enabled = false;
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(378, 109);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(179, 21);
            this.cmbDistrito.TabIndex = 28;
            this.cmbDistrito.Tag = "UserData";
            this.cmbDistrito.ValueMember = "Id_Old";
            // 
            // txtODoc
            // 
            this.txtODoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtODoc.Enabled = false;
            this.txtODoc.Location = new System.Drawing.Point(191, 156);
            this.txtODoc.Name = "txtODoc";
            this.txtODoc.Size = new System.Drawing.Size(105, 20);
            this.txtODoc.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(188, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Provincia";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Enabled = false;
            this.txtFechaNac.Location = new System.Drawing.Point(6, 64);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNac.TabIndex = 23;
            this.txtFechaNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            this.txtFechaNac.Leave += new System.EventHandler(this.txtFechaNac_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(375, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Distrito";
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(618, 182);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(74, 39);
            this.btnAnular.TabIndex = 38;
            this.btnAnular.Text = "&Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(293, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Asg";
            // 
            // txtAsegurado
            // 
            this.txtAsegurado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsegurado.Enabled = false;
            this.txtAsegurado.Location = new System.Drawing.Point(300, 155);
            this.txtAsegurado.Name = "txtAsegurado";
            this.txtAsegurado.Size = new System.Drawing.Size(71, 20);
            this.txtAsegurado.TabIndex = 32;
            this.txtAsegurado.Tag = "UserData";
            this.txtAsegurado.Leave += new System.EventHandler(this.txtAsegurado_Leave);
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(110, 65);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(55, 20);
            this.txtEdad.TabIndex = 24;
            this.txtEdad.Tag = "UserData";
            this.txtEdad.Leave += new System.EventHandler(this.txtEdad_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(109, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Edad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(599, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "D.N.I.";
            // 
            // txtSexo
            // 
            this.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSexo.Enabled = false;
            this.txtSexo.Location = new System.Drawing.Point(559, 22);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(35, 20);
            this.txtSexo.TabIndex = 21;
            this.txtSexo.Tag = "UserData";
            this.txtSexo.Leave += new System.EventHandler(this.txtSexo_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(558, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sexo";
            // 
            // grpApePat
            // 
            this.grpApePat.Controls.Add(this.txtApePat);
            this.grpApePat.Location = new System.Drawing.Point(10, 10);
            this.grpApePat.Name = "grpApePat";
            this.grpApePat.Size = new System.Drawing.Size(140, 43);
            this.grpApePat.TabIndex = 0;
            this.grpApePat.TabStop = false;
            this.grpApePat.Text = "Apellido Paterno";
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(6, 17);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(128, 20);
            this.txtApePat.TabIndex = 0;
            this.txtApePat.TextChanged += new System.EventHandler(this.txtApePat_TextChanged);
            // 
            // grpApeMat
            // 
            this.grpApeMat.Controls.Add(this.txtApeMat);
            this.grpApeMat.Location = new System.Drawing.Point(152, 11);
            this.grpApeMat.Name = "grpApeMat";
            this.grpApeMat.Size = new System.Drawing.Size(140, 43);
            this.grpApeMat.TabIndex = 1;
            this.grpApeMat.TabStop = false;
            this.grpApeMat.Text = "Apellido Materno";
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(6, 17);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(128, 20);
            this.txtApeMat.TabIndex = 0;
            this.txtApeMat.TextChanged += new System.EventHandler(this.txtApeMat_TextChanged);
            // 
            // grpNom
            // 
            this.grpNom.Controls.Add(this.txtNom);
            this.grpNom.Location = new System.Drawing.Point(296, 12);
            this.grpNom.Name = "grpNom";
            this.grpNom.Size = new System.Drawing.Size(140, 43);
            this.grpNom.TabIndex = 2;
            this.grpNom.TabStop = false;
            this.grpNom.Text = "Nombres";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(6, 17);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(128, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // grpDNI
            // 
            this.grpDNI.Controls.Add(this.txtDni);
            this.grpDNI.Location = new System.Drawing.Point(438, 13);
            this.grpDNI.Name = "grpDNI";
            this.grpDNI.Size = new System.Drawing.Size(85, 43);
            this.grpDNI.TabIndex = 3;
            this.grpDNI.TabStop = false;
            this.grpDNI.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(5, 17);
            this.txtDni.Mask = "99999999";
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(72, 20);
            this.txtDni.TabIndex = 0;
            this.txtDni.Tag = "0";
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // grpIdPac
            // 
            this.grpIdPac.Controls.Add(this.txtIdPac);
            this.grpIdPac.Location = new System.Drawing.Point(529, 12);
            this.grpIdPac.Name = "grpIdPac";
            this.grpIdPac.Size = new System.Drawing.Size(83, 43);
            this.grpIdPac.TabIndex = 4;
            this.grpIdPac.TabStop = false;
            this.grpIdPac.Text = "ID Paciente";
            // 
            // txtIdPac
            // 
            this.txtIdPac.Location = new System.Drawing.Point(6, 17);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.Size = new System.Drawing.Size(72, 20);
            this.txtIdPac.TabIndex = 0;
            this.txtIdPac.TextChanged += new System.EventHandler(this.txtIdPac_TextChanged);
            // 
            // grpNroPac
            // 
            this.grpNroPac.Controls.Add(this.txtNroHist);
            this.grpNroPac.Location = new System.Drawing.Point(618, 12);
            this.grpNroPac.Name = "grpNroPac";
            this.grpNroPac.Size = new System.Drawing.Size(98, 43);
            this.grpNroPac.TabIndex = 5;
            this.grpNroPac.TabStop = false;
            this.grpNroPac.Text = "Nro Historia";
            // 
            // txtNroHist
            // 
            this.txtNroHist.Location = new System.Drawing.Point(4, 18);
            this.txtNroHist.Mask = "999999";
            this.txtNroHist.Name = "txtNroHist";
            this.txtNroHist.Size = new System.Drawing.Size(90, 20);
            this.txtNroHist.TabIndex = 0;
            this.txtNroHist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroHist.TextChanged += new System.EventHandler(this.txtNroHist_TextChanged);
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
            // docIdentidadTableAdapter
            // 
            this.docIdentidadTableAdapter.ClearBeforeFill = true;
            // 
            // frmSeekPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 470);
            this.Controls.Add(this.grpNom);
            this.Controls.Add(this.grpDNI);
            this.Controls.Add(this.grpIdPac);
            this.Controls.Add(this.grpNroPac);
            this.Controls.Add(this.grpApeMat);
            this.Controls.Add(this.grpApePat);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.pnlDatos);
            this.KeyPreview = true;
            this.Name = "frmSeekPac";
            this.Text = "Búsqueda de Pacientes ....";
            this.Load += new System.EventHandler(this.frmSeekPac_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSeekPac_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.docIdentidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoDS)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.grpApePat.ResumeLayout(false);
            this.grpApePat.PerformLayout();
            this.grpApeMat.ResumeLayout(false);
            this.grpApeMat.PerformLayout();
            this.grpNom.ResumeLayout(false);
            this.grpNom.PerformLayout();
            this.grpDNI.ResumeLayout(false);
            this.grpDNI.PerformLayout();
            this.grpIdPac.ResumeLayout(false);
            this.grpIdPac.PerformLayout();
            this.grpNroPac.ResumeLayout(false);
            this.grpNroPac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstPacientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbTDoc;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsegurado;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.GroupBox grpApePat;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.GroupBox grpApeMat;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.GroupBox grpNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox grpDNI;
        private System.Windows.Forms.TextBox txtODoc;
        private System.Windows.Forms.GroupBox grpIdPac;
        private System.Windows.Forms.TextBox txtIdPac;
        private System.Windows.Forms.GroupBox grpNroPac;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private Dominio.Data.DepartamentosDS departamentosDS;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private Dominio.Data.DepartamentosDSTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private Dominio.Data.ProvinciasDS provinciasDS;
        private System.Windows.Forms.BindingSource distritoBindingSource;
        private Dominio.Data.DistritoDS distritoDS;
        private Dominio.Data.ProvinciasDSTableAdapters.ProvinciasTableAdapter provinciasTableAdapter;
        private Dominio.Data.DistritoDSTableAdapters.DistritoTableAdapter distritoTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtDoc;
        private System.Windows.Forms.MaskedTextBox txtDni;
        private System.Windows.Forms.MaskedTextBox txtNroHist;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource docIdentidadBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.DocIdentidadTableAdapter docIdentidadTableAdapter;
    }
}