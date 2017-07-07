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
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lstInstitucion = new System.Windows.Forms.ListBox();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.Doc = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.pnlInstitucion = new System.Windows.Forms.Panel();
            this.chkActiv = new System.Windows.Forms.CheckBox();
            this.txtLastUpdate = new System.Windows.Forms.TextBox();
            this.txtCreation = new System.Windows.Forms.TextBox();
            this.txtObserv = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbModTrans = new System.Windows.Forms.ComboBox();
            this.txtRepresent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbRepresent = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDirecc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cbmDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomRazSocial = new System.Windows.Forms.TextBox();
            this.txtNumId = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBuscar.SuspendLayout();
            this.pnlInstitucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(17, 27);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(128, 20);
            this.txtDoc.TabIndex = 0;
            this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(151, 27);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(122, 21);
            this.cmbEstado.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(17, 74);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(256, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // lstInstitucion
            // 
            this.lstInstitucion.FormattingEnabled = true;
            this.lstInstitucion.Location = new System.Drawing.Point(17, 117);
            this.lstInstitucion.Name = "lstInstitucion";
            this.lstInstitucion.ScrollAlwaysVisible = true;
            this.lstInstitucion.Size = new System.Drawing.Size(256, 342);
            this.lstInstitucion.TabIndex = 3;
            this.lstInstitucion.SelectedIndexChanged += new System.EventHandler(this.lstInstitucion_SelectedIndexChanged);
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBuscar.Controls.Add(this.Doc);
            this.pnlBuscar.Controls.Add(this.Estado);
            this.pnlBuscar.Controls.Add(this.lstInstitucion);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Controls.Add(this.txtDoc);
            this.pnlBuscar.Controls.Add(this.cmbEstado);
            this.pnlBuscar.Location = new System.Drawing.Point(13, 13);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(290, 483);
            this.pnlBuscar.TabIndex = 4;
            // 
            // Doc
            // 
            this.Doc.AutoSize = true;
            this.Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc.ForeColor = System.Drawing.Color.Blue;
            this.Doc.Location = new System.Drawing.Point(17, 8);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(30, 13);
            this.Doc.TabIndex = 5;
            this.Doc.Text = "Doc";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.ForeColor = System.Drawing.Color.Blue;
            this.Estado.Location = new System.Drawing.Point(151, 8);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(46, 13);
            this.Estado.TabIndex = 4;
            this.Estado.Text = "Estado";
            // 
            // pnlInstitucion
            // 
            this.pnlInstitucion.Controls.Add(this.chkActiv);
            this.pnlInstitucion.Controls.Add(this.txtLastUpdate);
            this.pnlInstitucion.Controls.Add(this.txtCreation);
            this.pnlInstitucion.Controls.Add(this.txtObserv);
            this.pnlInstitucion.Controls.Add(this.label17);
            this.pnlInstitucion.Controls.Add(this.txtEmail);
            this.pnlInstitucion.Controls.Add(this.label16);
            this.pnlInstitucion.Controls.Add(this.label15);
            this.pnlInstitucion.Controls.Add(this.cmbModTrans);
            this.pnlInstitucion.Controls.Add(this.txtRepresent);
            this.pnlInstitucion.Controls.Add(this.label14);
            this.pnlInstitucion.Controls.Add(this.cmbCargo);
            this.pnlInstitucion.Controls.Add(this.label13);
            this.pnlInstitucion.Controls.Add(this.cmbRepresent);
            this.pnlInstitucion.Controls.Add(this.label12);
            this.pnlInstitucion.Controls.Add(this.txtCel);
            this.pnlInstitucion.Controls.Add(this.txtTel);
            this.pnlInstitucion.Controls.Add(this.txtDirecc);
            this.pnlInstitucion.Controls.Add(this.label11);
            this.pnlInstitucion.Controls.Add(this.label10);
            this.pnlInstitucion.Controls.Add(this.label9);
            this.pnlInstitucion.Controls.Add(this.label8);
            this.pnlInstitucion.Controls.Add(this.label7);
            this.pnlInstitucion.Controls.Add(this.cmbDistrito);
            this.pnlInstitucion.Controls.Add(this.cmbProvincia);
            this.pnlInstitucion.Controls.Add(this.cbmDepartamento);
            this.pnlInstitucion.Controls.Add(this.label6);
            this.pnlInstitucion.Controls.Add(this.txtRuc);
            this.pnlInstitucion.Controls.Add(this.label5);
            this.pnlInstitucion.Controls.Add(this.txtNomRazSocial);
            this.pnlInstitucion.Controls.Add(this.txtNumId);
            this.pnlInstitucion.Controls.Add(this.cmbTipo);
            this.pnlInstitucion.Controls.Add(this.label3);
            this.pnlInstitucion.Controls.Add(this.label2);
            this.pnlInstitucion.Controls.Add(this.label1);
            this.pnlInstitucion.Location = new System.Drawing.Point(310, 41);
            this.pnlInstitucion.Name = "pnlInstitucion";
            this.pnlInstitucion.Size = new System.Drawing.Size(583, 394);
            this.pnlInstitucion.TabIndex = 5;
            // 
            // chkActiv
            // 
            this.chkActiv.AutoSize = true;
            this.chkActiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActiv.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.chkActiv.Location = new System.Drawing.Point(454, 362);
            this.chkActiv.Name = "chkActiv";
            this.chkActiv.Size = new System.Drawing.Size(104, 19);
            this.chkActiv.TabIndex = 34;
            this.chkActiv.Text = "En Acti&vidad";
            this.chkActiv.UseVisualStyleBackColor = true;
            // 
            // txtLastUpdate
            // 
            this.txtLastUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastUpdate.Location = new System.Drawing.Point(214, 336);
            this.txtLastUpdate.Name = "txtLastUpdate";
            this.txtLastUpdate.Size = new System.Drawing.Size(171, 20);
            this.txtLastUpdate.TabIndex = 33;
            // 
            // txtCreation
            // 
            this.txtCreation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreation.Location = new System.Drawing.Point(15, 336);
            this.txtCreation.Name = "txtCreation";
            this.txtCreation.Size = new System.Drawing.Size(193, 20);
            this.txtCreation.TabIndex = 32;
            // 
            // txtObserv
            // 
            this.txtObserv.Location = new System.Drawing.Point(265, 254);
            this.txtObserv.Multiline = true;
            this.txtObserv.Name = "txtObserv";
            this.txtObserv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObserv.Size = new System.Drawing.Size(295, 76);
            this.txtObserv.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(265, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Observación";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 254);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEmail.Size = new System.Drawing.Size(243, 76);
            this.txtEmail.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Email (email1/email2/etc)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(276, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Modalidad de transporte";
            // 
            // cmbModTrans
            // 
            this.cmbModTrans.FormattingEnabled = true;
            this.cmbModTrans.Location = new System.Drawing.Point(272, 205);
            this.cmbModTrans.Name = "cmbModTrans";
            this.cmbModTrans.Size = new System.Drawing.Size(286, 21);
            this.cmbModTrans.TabIndex = 26;
            // 
            // txtRepresent
            // 
            this.txtRepresent.Location = new System.Drawing.Point(272, 162);
            this.txtRepresent.Name = "txtRepresent";
            this.txtRepresent.Size = new System.Drawing.Size(288, 20);
            this.txtRepresent.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cargo del Representante";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(16, 205);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(247, 21);
            this.cmbCargo.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(276, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Representante No Registrado";
            // 
            // cmbRepresent
            // 
            this.cmbRepresent.FormattingEnabled = true;
            this.cmbRepresent.Location = new System.Drawing.Point(16, 161);
            this.cmbRepresent.Name = "cmbRepresent";
            this.cmbRepresent.Size = new System.Drawing.Size(247, 21);
            this.cmbRepresent.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Representante Registrado";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(422, 117);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(136, 20);
            this.txtCel.TabIndex = 19;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(316, 117);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 18;
            // 
            // txtDirecc
            // 
            this.txtDirecc.Location = new System.Drawing.Point(16, 117);
            this.txtDirecc.Name = "txtDirecc";
            this.txtDirecc.Size = new System.Drawing.Size(291, 20);
            this.txtDirecc.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(419, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(313, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Teléfono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dirección (Av/calle/Urb./Mz/Lt/etc)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Distrito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Provincia";
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(419, 73);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(141, 21);
            this.cmbDistrito.TabIndex = 11;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(272, 72);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(141, 21);
            this.cmbProvincia.TabIndex = 10;
            // 
            // cbmDepartamento
            // 
            this.cbmDepartamento.FormattingEnabled = true;
            this.cbmDepartamento.Location = new System.Drawing.Point(125, 73);
            this.cbmDepartamento.Name = "cbmDepartamento";
            this.cbmDepartamento.Size = new System.Drawing.Size(141, 21);
            this.cbmDepartamento.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Departamento";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(16, 73);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(103, 20);
            this.txtRuc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "R.U.C.";
            // 
            // txtNomRazSocial
            // 
            this.txtNomRazSocial.Location = new System.Drawing.Point(272, 30);
            this.txtNomRazSocial.Name = "txtNomRazSocial";
            this.txtNomRazSocial.Size = new System.Drawing.Size(288, 20);
            this.txtNomRazSocial.TabIndex = 5;
            // 
            // txtNumId
            // 
            this.txtNumId.Location = new System.Drawing.Point(159, 31);
            this.txtNumId.Name = "txtNumId";
            this.txtNumId.Size = new System.Drawing.Size(107, 20);
            this.txtNumId.TabIndex = 4;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(16, 30);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(137, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre o Razón Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(336, 451);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 45);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(444, 451);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(102, 45);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(552, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 45);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(660, 451);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 45);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(768, 451);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 45);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(309, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Institución / Empresa";
            // 
            // frmInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 513);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlInstitucion);
            this.Controls.Add(this.pnlBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmInstitucion";
            this.Text = "Registro de Empresas e Instituciones";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInstitucion_KeyDown);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnlInstitucion.ResumeLayout(false);
            this.pnlInstitucion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListBox lstInstitucion;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Panel pnlInstitucion;
        private System.Windows.Forms.TextBox txtNomRazSocial;
        private System.Windows.Forms.TextBox txtNumId;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cbmDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkActiv;
        private System.Windows.Forms.TextBox txtLastUpdate;
        private System.Windows.Forms.TextBox txtCreation;
        private System.Windows.Forms.TextBox txtObserv;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbModTrans;
        private System.Windows.Forms.TextBox txtRepresent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbRepresent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDirecc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Doc;
        private System.Windows.Forms.Label Estado;
    }
}