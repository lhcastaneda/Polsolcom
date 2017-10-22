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
            this.lstUsers = new System.Windows.Forms.ListBox();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relación de usuarios";
            // 
            // cmbListUs
            // 
            this.cmbListUs.FormattingEnabled = true;
            this.cmbListUs.Location = new System.Drawing.Point(202, 13);
            this.cmbListUs.Name = "cmbListUs";
            this.cmbListUs.Size = new System.Drawing.Size(98, 21);
            this.cmbListUs.TabIndex = 1;
            // 
            // lstUsers
            // 
            this.lstUsers.Enabled = false;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(16, 60);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.ScrollAlwaysVisible = true;
            this.lstUsers.Size = new System.Drawing.Size(284, 355);
            this.lstUsers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos y Nombres";
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.Location = new System.Drawing.Point(18, 35);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(360, 21);
            this.cmbPersonal.TabIndex = 4;
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(18, 62);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(357, 20);
            this.txtDirec.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(18, 88);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(177, 20);
            this.txtTel.TabIndex = 7;
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
            this.pnlUsuarios.Location = new System.Drawing.Point(306, 13);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(394, 334);
            this.pnlUsuarios.TabIndex = 8;
            // 
            // txtLastUpd
            // 
            this.txtLastUpd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastUpd.Location = new System.Drawing.Point(201, 305);
            this.txtLastUpd.Name = "txtLastUpd";
            this.txtLastUpd.Size = new System.Drawing.Size(174, 20);
            this.txtLastUpd.TabIndex = 22;
            this.txtLastUpd.Text = "Last Update";
            this.txtLastUpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCreation
            // 
            this.txtCreation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCreation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreation.Location = new System.Drawing.Point(18, 305);
            this.txtCreation.Name = "txtCreation";
            this.txtCreation.Size = new System.Drawing.Size(177, 20);
            this.txtCreation.TabIndex = 21;
            this.txtCreation.Text = "Creation";
            this.txtCreation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(18, 237);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(357, 61);
            this.txtObservacion.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(18, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(251, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(248, 189);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(127, 21);
            this.cmbEstado.TabIndex = 17;
            // 
            // cmbAreaTrab
            // 
            this.cmbAreaTrab.FormattingEnabled = true;
            this.cmbAreaTrab.Location = new System.Drawing.Point(18, 189);
            this.cmbAreaTrab.Name = "cmbAreaTrab";
            this.cmbAreaTrab.Size = new System.Drawing.Size(224, 21);
            this.cmbAreaTrab.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(18, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Área de Trabajo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(245, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo";
            // 
            // cmbTipUser
            // 
            this.cmbTipUser.FormattingEnabled = true;
            this.cmbTipUser.Location = new System.Drawing.Point(248, 145);
            this.cmbTipUser.Name = "cmbTipUser";
            this.cmbTipUser.Size = new System.Drawing.Size(130, 21);
            this.cmbTipUser.TabIndex = 13;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(133, 145);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(109, 20);
            this.txtClave.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(130, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(18, 145);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(109, 20);
            this.txtLogin.TabIndex = 10;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(201, 88);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(177, 20);
            this.txtCel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(315, 366);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 50);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(412, 366);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(91, 50);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(509, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 50);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(606, 366);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 50);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "&Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(346, 370);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(439, 370);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(536, 370);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(637, 370);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // frmRegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 438);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.cmbListUs);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbListUs;
        private System.Windows.Forms.ListBox lstUsers;
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}