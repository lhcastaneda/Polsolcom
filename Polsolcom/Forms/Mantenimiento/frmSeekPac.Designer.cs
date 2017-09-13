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
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbTDoc = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cntUbigeo = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsegurado = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
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
            this.txtODoc = new System.Windows.Forms.TextBox();
            this.grpIdPac = new System.Windows.Forms.GroupBox();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.grpNroPac = new System.Windows.Forms.GroupBox();
            this.txtNroHist = new System.Windows.Forms.TextBox();
            this.cntUbigeo.SuspendLayout();
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
            this.lstPacientes.Size = new System.Drawing.Size(709, 113);
            this.lstPacientes.TabIndex = 8;
            this.lstPacientes.UseCompatibleStateImageBehavior = false;
            this.lstPacientes.View = System.Windows.Forms.View.Details;
            this.lstPacientes.SelectedIndexChanged += new System.EventHandler(this.lstPacientes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Apellidos y Nombres";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dirección y Distrito";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DNI";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Teléfono";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(538, 181);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(74, 56);
            this.btnEditar.TabIndex = 12;
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
            this.btnCancelar.Location = new System.Drawing.Point(460, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 56);
            this.btnCancelar.TabIndex = 11;
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
            this.btnGrabar.Location = new System.Drawing.Point(381, 180);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(74, 56);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(303, 181);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(74, 56);
            this.btnNuevo.TabIndex = 9;
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
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(107, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 1;
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
            this.txtApePaterno.Enabled = false;
            this.txtApePaterno.Location = new System.Drawing.Point(263, 24);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(139, 20);
            this.txtApePaterno.TabIndex = 3;
            this.txtApePaterno.Tag = "UserData";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Enabled = false;
            this.txtApeMaterno.Location = new System.Drawing.Point(408, 24);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(146, 20);
            this.txtApeMaterno.TabIndex = 4;
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
            this.label6.TabIndex = 5;
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
            this.label17.TabIndex = 26;
            this.label17.Text = "Dirección (Av. /Calle /Urb. /Mz. /Lt. / etc)";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(171, 64);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(518, 20);
            this.txtDireccion.TabIndex = 27;
            this.txtDireccion.Tag = "UserData";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(567, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(124, 20);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.Tag = "UserData";
            // 
            // txtDoc
            // 
            this.txtDoc.Enabled = false;
            this.txtDoc.Location = new System.Drawing.Point(600, 20);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(83, 20);
            this.txtDoc.TabIndex = 29;
            this.txtDoc.Tag = "UserData";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkBlue;
            this.label18.Location = new System.Drawing.Point(564, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 30;
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
            this.label19.TabIndex = 31;
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
            this.label26.TabIndex = 44;
            this.label26.Text = "Tipo Otro Doc.";
            // 
            // cmbTDoc
            // 
            this.cmbTDoc.Enabled = false;
            this.cmbTDoc.FormattingEnabled = true;
            this.cmbTDoc.Location = new System.Drawing.Point(6, 155);
            this.cmbTDoc.Name = "cmbTDoc";
            this.cmbTDoc.Size = new System.Drawing.Size(177, 21);
            this.cmbTDoc.TabIndex = 45;
            this.cmbTDoc.Tag = "UserData";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.DarkBlue;
            this.label28.Location = new System.Drawing.Point(397, 136);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(163, 13);
            this.label28.TabIndex = 48;
            this.label28.Text = "Email (email1 /email2/ etc.)";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(398, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 20);
            this.txtEmail.TabIndex = 50;
            this.txtEmail.Tag = "UserData";
            // 
            // cntUbigeo
            // 
            this.cntUbigeo.Controls.Add(this.label14);
            this.cntUbigeo.Controls.Add(this.cmbDepartamento);
            this.cntUbigeo.Controls.Add(this.cmbProvincia);
            this.cntUbigeo.Controls.Add(this.cmbDistrito);
            this.cntUbigeo.Controls.Add(this.label15);
            this.cntUbigeo.Controls.Add(this.label16);
            this.cntUbigeo.Location = new System.Drawing.Point(-1, 90);
            this.cntUbigeo.Name = "cntUbigeo";
            this.cntUbigeo.Size = new System.Drawing.Size(562, 45);
            this.cntUbigeo.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(7, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DisplayMember = "Departamento";
            this.cmbDepartamento.Enabled = false;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(8, 20);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(177, 21);
            this.cmbDepartamento.TabIndex = 21;
            this.cmbDepartamento.Tag = "UserData";
            this.cmbDepartamento.ValueMember = "Id_Old";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DisplayMember = "Provincia";
            this.cmbProvincia.Enabled = false;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(191, 20);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(181, 21);
            this.cmbProvincia.TabIndex = 22;
            this.cmbProvincia.Tag = "UserData";
            this.cmbProvincia.ValueMember = "Id_Old";
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.DisplayMember = "Distrito";
            this.cmbDistrito.Enabled = false;
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(378, 20);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(179, 21);
            this.cmbDistrito.TabIndex = 23;
            this.cmbDistrito.Tag = "UserData";
            this.cmbDistrito.ValueMember = "Id_Old";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(188, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Provincia";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(375, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Distrito";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdPaciente.Enabled = false;
            this.txtIdPaciente.Location = new System.Drawing.Point(4, 24);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(99, 20);
            this.txtIdPaciente.TabIndex = 71;
            this.txtIdPaciente.Tag = "UserData";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.DarkBlue;
            this.label31.Location = new System.Drawing.Point(7, 8);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(78, 13);
            this.label31.TabIndex = 72;
            this.label31.Text = "ID Paciente:";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatos.Controls.Add(this.txtODoc);
            this.pnlDatos.Controls.Add(this.txtFechaNac);
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
            this.pnlDatos.Controls.Add(this.txtIdPaciente);
            this.pnlDatos.Controls.Add(this.cntUbigeo);
            this.pnlDatos.Controls.Add(this.txtEmail);
            this.pnlDatos.Controls.Add(this.label28);
            this.pnlDatos.Controls.Add(this.cmbTDoc);
            this.pnlDatos.Controls.Add(this.label26);
            this.pnlDatos.Controls.Add(this.label19);
            this.pnlDatos.Controls.Add(this.label18);
            this.pnlDatos.Controls.Add(this.txtDoc);
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
            this.pnlDatos.Location = new System.Drawing.Point(9, 182);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(711, 258);
            this.pnlDatos.TabIndex = 2;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(6, 64);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNac.TabIndex = 83;
            this.txtFechaNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(615, 181);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(74, 56);
            this.btnAnular.TabIndex = 82;
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
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Celular";
            // 
            // txtAsegurado
            // 
            this.txtAsegurado.Enabled = false;
            this.txtAsegurado.Location = new System.Drawing.Point(294, 155);
            this.txtAsegurado.Name = "txtAsegurado";
            this.txtAsegurado.Size = new System.Drawing.Size(97, 20);
            this.txtAsegurado.TabIndex = 80;
            this.txtAsegurado.Tag = "UserData";
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(110, 65);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(55, 20);
            this.txtEdad.TabIndex = 78;
            this.txtEdad.Tag = "UserData";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(109, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Edad";
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(5, 15);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(76, 20);
            this.txtDni.TabIndex = 76;
            this.txtDni.Tag = "UserData";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(599, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "D.N.I.";
            // 
            // txtSexo
            // 
            this.txtSexo.Enabled = false;
            this.txtSexo.Location = new System.Drawing.Point(559, 22);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(35, 20);
            this.txtSexo.TabIndex = 74;
            this.txtSexo.Tag = "UserData";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(558, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Sexo";
            // 
            // grpApePat
            // 
            this.grpApePat.Controls.Add(this.txtApePat);
            this.grpApePat.Location = new System.Drawing.Point(10, 10);
            this.grpApePat.Name = "grpApePat";
            this.grpApePat.Size = new System.Drawing.Size(140, 43);
            this.grpApePat.TabIndex = 83;
            this.grpApePat.TabStop = false;
            this.grpApePat.Text = "Apellido Paterno";
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(6, 17);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(128, 20);
            this.txtApePat.TabIndex = 0;
            // 
            // grpApeMat
            // 
            this.grpApeMat.Controls.Add(this.txtApeMat);
            this.grpApeMat.Location = new System.Drawing.Point(152, 11);
            this.grpApeMat.Name = "grpApeMat";
            this.grpApeMat.Size = new System.Drawing.Size(140, 43);
            this.grpApeMat.TabIndex = 84;
            this.grpApeMat.TabStop = false;
            this.grpApeMat.Text = "Apellido Materno";
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(6, 17);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(128, 20);
            this.txtApeMat.TabIndex = 0;
            // 
            // grpNom
            // 
            this.grpNom.Controls.Add(this.txtNom);
            this.grpNom.Location = new System.Drawing.Point(296, 12);
            this.grpNom.Name = "grpNom";
            this.grpNom.Size = new System.Drawing.Size(140, 43);
            this.grpNom.TabIndex = 84;
            this.grpNom.TabStop = false;
            this.grpNom.Text = "Nombres";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(6, 17);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(128, 20);
            this.txtNom.TabIndex = 0;
            // 
            // grpDNI
            // 
            this.grpDNI.Controls.Add(this.txtDni);
            this.grpDNI.Location = new System.Drawing.Point(438, 13);
            this.grpDNI.Name = "grpDNI";
            this.grpDNI.Size = new System.Drawing.Size(85, 43);
            this.grpDNI.TabIndex = 84;
            this.grpDNI.TabStop = false;
            this.grpDNI.Text = "DNI";
            // 
            // txtODoc
            // 
            this.txtODoc.Location = new System.Drawing.Point(191, 156);
            this.txtODoc.Name = "txtODoc";
            this.txtODoc.Size = new System.Drawing.Size(94, 20);
            this.txtODoc.TabIndex = 0;
            // 
            // grpIdPac
            // 
            this.grpIdPac.Controls.Add(this.txtIdPac);
            this.grpIdPac.Location = new System.Drawing.Point(529, 12);
            this.grpIdPac.Name = "grpIdPac";
            this.grpIdPac.Size = new System.Drawing.Size(83, 43);
            this.grpIdPac.TabIndex = 84;
            this.grpIdPac.TabStop = false;
            this.grpIdPac.Text = "ID Paciente";
            // 
            // txtIdPac
            // 
            this.txtIdPac.Location = new System.Drawing.Point(6, 17);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.Size = new System.Drawing.Size(72, 20);
            this.txtIdPac.TabIndex = 0;
            // 
            // grpNroPac
            // 
            this.grpNroPac.Controls.Add(this.txtNroHist);
            this.grpNroPac.Location = new System.Drawing.Point(618, 12);
            this.grpNroPac.Name = "grpNroPac";
            this.grpNroPac.Size = new System.Drawing.Size(98, 43);
            this.grpNroPac.TabIndex = 84;
            this.grpNroPac.TabStop = false;
            this.grpNroPac.Text = "Nro Historia";
            // 
            // txtNroHist
            // 
            this.txtNroHist.Location = new System.Drawing.Point(6, 17);
            this.txtNroHist.Name = "txtNroHist";
            this.txtNroHist.Size = new System.Drawing.Size(87, 20);
            this.txtNroHist.TabIndex = 0;
            // 
            // frmSeekPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 470);
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
            this.cntUbigeo.ResumeLayout(false);
            this.cntUbigeo.PerformLayout();
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
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbTDoc;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel cntUbigeo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsegurado;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
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
        private System.Windows.Forms.TextBox txtNroHist;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
    }
}