namespace Polsolcom.Forms
{
    partial class frmRegistroUsuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuarios));
			this.label1 = new System.Windows.Forms.Label();
			this.cmbListUs = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbPersonal = new System.Windows.Forms.ComboBox();
			this.txtDirec = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.pnlUsuarios = new System.Windows.Forms.Panel();
			this.txtLastUpd = new System.Windows.Forms.TextBox();
			this.txtCreation = new System.Windows.Forms.TextBox();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.cmbAreaTrab = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbTipUser = new System.Windows.Forms.ComboBox();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtCel = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnGrabar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lstUsers = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pnlUsuarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuarios del Sistema";
			// 
			// cmbListUs
			// 
			this.cmbListUs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbListUs.FormattingEnabled = true;
			this.cmbListUs.Location = new System.Drawing.Point(188, 32);
			this.cmbListUs.Name = "cmbListUs";
			this.cmbListUs.Size = new System.Drawing.Size(114, 21);
			this.cmbListUs.TabIndex = 1;
			this.cmbListUs.SelectedIndexChanged += new System.EventHandler(this.cmbListUs_SelectedIndexChanged);
			this.cmbListUs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.DarkBlue;
			this.label2.Location = new System.Drawing.Point(7, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nombre del Empleado";
			// 
			// cmbPersonal
			// 
			this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPersonal.FormattingEnabled = true;
			this.cmbPersonal.Location = new System.Drawing.Point(7, 23);
			this.cmbPersonal.Name = "cmbPersonal";
			this.cmbPersonal.Size = new System.Drawing.Size(360, 21);
			this.cmbPersonal.TabIndex = 4;
			this.cmbPersonal.SelectedIndexChanged += new System.EventHandler(this.cmbPersonal_SelectedIndexChanged);
			this.cmbPersonal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// txtDirec
			// 
			this.txtDirec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDirec.Location = new System.Drawing.Point(7, 50);
			this.txtDirec.Name = "txtDirec";
			this.txtDirec.Size = new System.Drawing.Size(360, 20);
			this.txtDirec.TabIndex = 5;
			this.txtDirec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// txtTel
			// 
			this.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTel.Location = new System.Drawing.Point(7, 76);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(177, 20);
			this.txtTel.TabIndex = 7;
			this.txtTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// pnlUsuarios
			// 
			this.pnlUsuarios.Controls.Add(this.txtLastUpd);
			this.pnlUsuarios.Controls.Add(this.txtCreation);
			this.pnlUsuarios.Controls.Add(this.txtObservacion);
			this.pnlUsuarios.Controls.Add(this.label8);
			this.pnlUsuarios.Controls.Add(this.label7);
			this.pnlUsuarios.Controls.Add(this.cmbEstado);
			this.pnlUsuarios.Controls.Add(this.cmbAreaTrab);
			this.pnlUsuarios.Controls.Add(this.label6);
			this.pnlUsuarios.Controls.Add(this.label5);
			this.pnlUsuarios.Controls.Add(this.cmbTipUser);
			this.pnlUsuarios.Controls.Add(this.txtClave);
			this.pnlUsuarios.Controls.Add(this.label4);
			this.pnlUsuarios.Controls.Add(this.txtLogin);
			this.pnlUsuarios.Controls.Add(this.txtCel);
			this.pnlUsuarios.Controls.Add(this.label3);
			this.pnlUsuarios.Controls.Add(this.label2);
			this.pnlUsuarios.Controls.Add(this.txtTel);
			this.pnlUsuarios.Controls.Add(this.cmbPersonal);
			this.pnlUsuarios.Controls.Add(this.txtDirec);
			this.pnlUsuarios.Enabled = false;
			this.pnlUsuarios.Location = new System.Drawing.Point(305, 6);
			this.pnlUsuarios.Name = "pnlUsuarios";
			this.pnlUsuarios.Size = new System.Drawing.Size(373, 301);
			this.pnlUsuarios.TabIndex = 8;
			// 
			// txtLastUpd
			// 
			this.txtLastUpd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastUpd.ForeColor = System.Drawing.Color.White;
			this.txtLastUpd.Location = new System.Drawing.Point(191, 276);
			this.txtLastUpd.Name = "txtLastUpd";
			this.txtLastUpd.Size = new System.Drawing.Size(174, 18);
			this.txtLastUpd.TabIndex = 22;
			this.txtLastUpd.Text = "Last Update";
			this.txtLastUpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCreation
			// 
			this.txtCreation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtCreation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCreation.ForeColor = System.Drawing.Color.White;
			this.txtCreation.Location = new System.Drawing.Point(8, 276);
			this.txtCreation.Name = "txtCreation";
			this.txtCreation.Size = new System.Drawing.Size(177, 18);
			this.txtCreation.TabIndex = 21;
			this.txtCreation.Text = "Creation";
			this.txtCreation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtObservacion
			// 
			this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtObservacion.Location = new System.Drawing.Point(7, 196);
			this.txtObservacion.Multiline = true;
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtObservacion.Size = new System.Drawing.Size(359, 76);
			this.txtObservacion.TabIndex = 20;
			this.txtObservacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.DarkBlue;
			this.label8.Location = new System.Drawing.Point(6, 181);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "Descripción";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.DarkBlue;
			this.label7.Location = new System.Drawing.Point(238, 140);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Estado";
			// 
			// cmbEstado
			// 
			this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Location = new System.Drawing.Point(236, 156);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(130, 21);
			this.cmbEstado.TabIndex = 17;
			this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
			this.cmbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// cmbAreaTrab
			// 
			this.cmbAreaTrab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAreaTrab.FormattingEnabled = true;
			this.cmbAreaTrab.Location = new System.Drawing.Point(7, 156);
			this.cmbAreaTrab.Name = "cmbAreaTrab";
			this.cmbAreaTrab.Size = new System.Drawing.Size(224, 21);
			this.cmbAreaTrab.TabIndex = 16;
			this.cmbAreaTrab.SelectedIndexChanged += new System.EventHandler(this.cmbAreaTrab_SelectedIndexChanged);
			this.cmbAreaTrab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.DarkBlue;
			this.label6.Location = new System.Drawing.Point(10, 139);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Área de Trabajo";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.DarkBlue;
			this.label5.Location = new System.Drawing.Point(186, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Tipo";
			// 
			// cmbTipUser
			// 
			this.cmbTipUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipUser.FormattingEnabled = true;
			this.cmbTipUser.Location = new System.Drawing.Point(183, 114);
			this.cmbTipUser.Name = "cmbTipUser";
			this.cmbTipUser.Size = new System.Drawing.Size(182, 21);
			this.cmbTipUser.TabIndex = 13;
			this.cmbTipUser.SelectedIndexChanged += new System.EventHandler(this.cmbTipUser_SelectedIndexChanged);
			this.cmbTipUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(102, 114);
			this.txtClave.Name = "txtClave";
			this.txtClave.PasswordChar = '*';
			this.txtClave.Size = new System.Drawing.Size(77, 20);
			this.txtClave.TabIndex = 12;
			this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.DarkBlue;
			this.label4.Location = new System.Drawing.Point(106, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Password";
			// 
			// txtLogin
			// 
			this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtLogin.Location = new System.Drawing.Point(7, 114);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(91, 20);
			this.txtLogin.TabIndex = 10;
			// 
			// txtCel
			// 
			this.txtCel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCel.Location = new System.Drawing.Point(190, 76);
			this.txtCel.Name = "txtCel";
			this.txtCel.Size = new System.Drawing.Size(177, 20);
			this.txtCel.TabIndex = 9;
			this.txtCel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.DarkBlue;
			this.label3.Location = new System.Drawing.Point(7, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Login";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnNuevo.Location = new System.Drawing.Point(315, 310);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(85, 50);
			this.btnNuevo.TabIndex = 9;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			this.btnNuevo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// btnGrabar
			// 
			this.btnGrabar.Enabled = false;
			this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
			this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnGrabar.Location = new System.Drawing.Point(404, 310);
			this.btnGrabar.Name = "btnGrabar";
			this.btnGrabar.Size = new System.Drawing.Size(85, 50);
			this.btnGrabar.TabIndex = 10;
			this.btnGrabar.Text = "&Grabar";
			this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnGrabar.UseVisualStyleBackColor = true;
			this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
			this.btnGrabar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancelar.Location = new System.Drawing.Point(493, 310);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(85, 50);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			this.btnCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEdit.Location = new System.Drawing.Point(582, 310);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(85, 50);
			this.btnEdit.TabIndex = 12;
			this.btnEdit.Text = "&Editar";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			this.btnEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(52, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// lstUsers
			// 
			this.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lstUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstUsers.FullRowSelect = true;
			this.lstUsers.Location = new System.Drawing.Point(2, 57);
			this.lstUsers.MultiSelect = false;
			this.lstUsers.Name = "lstUsers";
			this.lstUsers.Size = new System.Drawing.Size(299, 304);
			this.lstUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lstUsers.TabIndex = 15;
			this.lstUsers.UseCompatibleStateImageBehavior = false;
			this.lstUsers.View = System.Windows.Forms.View.Details;
			this.lstUsers.Click += new System.EventHandler(this.lstUsers_Click);
			this.lstUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Nombre Usuario";
			this.columnHeader1.Width = 203;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Usuario";
			this.columnHeader2.Width = 75;
			// 
			// frmRegistroUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 363);
			this.ControlBox = false;
			this.Controls.Add(this.lstUsers);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGrabar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.pnlUsuarios);
			this.Controls.Add(this.cmbListUs);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRegistroUsuarios";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registro de Usuarios";
			this.Load += new System.EventHandler(this.frmRegistroUsuarios_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroUsuarios_KeyDown);
			this.pnlUsuarios.ResumeLayout(false);
			this.pnlUsuarios.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbListUs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.TextBox txtLastUpd;
        private System.Windows.Forms.TextBox txtCreation;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbAreaTrab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipUser;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView lstUsers;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}