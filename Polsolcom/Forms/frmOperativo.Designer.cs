namespace Polsolcom.Forms
{
    partial class frmOperativo
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
			this.label1 = new System.Windows.Forms.Label();
			this.lstOperativos = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbDepartamento = new System.Windows.Forms.ComboBox();
			this.cmbProvincia = new System.Windows.Forms.ComboBox();
			this.cmbDistrito = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbModOper = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtDescrip = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtDirec = new System.Windows.Forms.TextBox();
			this.txtJefe = new System.Windows.Forms.TextBox();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.Grabar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpCese = new System.Windows.Forms.DateTimePicker();
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
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Seleccione Operativo";
			// 
			// lstOperativos
			// 
			this.lstOperativos.FormattingEnabled = true;
			this.lstOperativos.Location = new System.Drawing.Point(16, 30);
			this.lstOperativos.Name = "lstOperativos";
			this.lstOperativos.ScrollAlwaysVisible = true;
			this.lstOperativos.Size = new System.Drawing.Size(187, 264);
			this.lstOperativos.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkBlue;
			this.label2.Location = new System.Drawing.Point(222, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkBlue;
			this.label3.Location = new System.Drawing.Point(262, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Descripción";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkBlue;
			this.label4.Location = new System.Drawing.Point(511, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Teléfono (nro1/nro2/...)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkBlue;
			this.label5.Location = new System.Drawing.Point(222, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(251, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Dirección (Av. /Calle/Urb. /Mz. / Lt. / etc)";
			// 
			// cmbDepartamento
			// 
			this.cmbDepartamento.FormattingEnabled = true;
			this.cmbDepartamento.Location = new System.Drawing.Point(209, 120);
			this.cmbDepartamento.Name = "cmbDepartamento";
			this.cmbDepartamento.Size = new System.Drawing.Size(134, 21);
			this.cmbDepartamento.TabIndex = 6;
			// 
			// cmbProvincia
			// 
			this.cmbProvincia.FormattingEnabled = true;
			this.cmbProvincia.Location = new System.Drawing.Point(350, 120);
			this.cmbProvincia.Name = "cmbProvincia";
			this.cmbProvincia.Size = new System.Drawing.Size(147, 21);
			this.cmbProvincia.TabIndex = 7;
			// 
			// cmbDistrito
			// 
			this.cmbDistrito.FormattingEnabled = true;
			this.cmbDistrito.Location = new System.Drawing.Point(503, 120);
			this.cmbDistrito.Name = "cmbDistrito";
			this.cmbDistrito.Size = new System.Drawing.Size(146, 21);
			this.cmbDistrito.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkBlue;
			this.label6.Location = new System.Drawing.Point(222, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Departamento";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DarkBlue;
			this.label7.Location = new System.Drawing.Point(347, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Provincia";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.DarkBlue;
			this.label8.Location = new System.Drawing.Point(500, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "Distrito";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DarkBlue;
			this.label9.Location = new System.Drawing.Point(222, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(111, 13);
			this.label9.TabIndex = 12;
			this.label9.Text = "Jefe del Operativo";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.DarkBlue;
			this.label10.Location = new System.Drawing.Point(463, 151);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "Modalidad";
			// 
			// cmbModOper
			// 
			this.cmbModOper.FormattingEnabled = true;
			this.cmbModOper.Location = new System.Drawing.Point(466, 167);
			this.cmbModOper.Name = "cmbModOper";
			this.cmbModOper.Size = new System.Drawing.Size(183, 21);
			this.cmbModOper.TabIndex = 14;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.DarkBlue;
			this.label11.Location = new System.Drawing.Point(222, 198);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(38, 13);
			this.label11.TabIndex = 15;
			this.label11.Text = "Inicio";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(209, 31);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(50, 20);
			this.txtId.TabIndex = 16;
			// 
			// txtDescrip
			// 
			this.txtDescrip.Location = new System.Drawing.Point(265, 31);
			this.txtDescrip.Name = "txtDescrip";
			this.txtDescrip.Size = new System.Drawing.Size(243, 20);
			this.txtDescrip.TabIndex = 17;
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(514, 31);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(135, 20);
			this.txtTel.TabIndex = 18;
			// 
			// txtDirec
			// 
			this.txtDirec.Location = new System.Drawing.Point(209, 74);
			this.txtDirec.Name = "txtDirec";
			this.txtDirec.Size = new System.Drawing.Size(440, 20);
			this.txtDirec.TabIndex = 19;
			// 
			// txtJefe
			// 
			this.txtJefe.Location = new System.Drawing.Point(209, 168);
			this.txtJefe.Name = "txtJefe";
			this.txtJefe.Size = new System.Drawing.Size(248, 20);
			this.txtJefe.TabIndex = 20;
			// 
			// cmbEstado
			// 
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Location = new System.Drawing.Point(466, 214);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(183, 21);
			this.cmbEstado.TabIndex = 23;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.DarkBlue;
			this.label12.Location = new System.Drawing.Point(333, 199);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(35, 13);
			this.label12.TabIndex = 24;
			this.label12.Text = "Cese";
			// 
			// txtObservacion
			// 
			this.txtObservacion.Location = new System.Drawing.Point(209, 260);
			this.txtObservacion.Multiline = true;
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtObservacion.Size = new System.Drawing.Size(440, 35);
			this.txtObservacion.TabIndex = 25;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Location = new System.Drawing.Point(68, 300);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(93, 38);
			this.btnNuevo.TabIndex = 26;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = true;
			// 
			// Grabar
			// 
			this.Grabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Grabar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.Grabar.Location = new System.Drawing.Point(167, 300);
			this.Grabar.Name = "Grabar";
			this.Grabar.Size = new System.Drawing.Size(93, 38);
			this.Grabar.TabIndex = 27;
			this.Grabar.Text = "&Grabar";
			this.Grabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Grabar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnCancelar.Location = new System.Drawing.Point(266, 300);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(93, 38);
			this.btnCancelar.TabIndex = 28;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnEditar
			// 
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Location = new System.Drawing.Point(365, 300);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(93, 38);
			this.btnEditar.TabIndex = 29;
			this.btnEditar.Text = "&Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(464, 300);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(93, 38);
			this.button5.TabIndex = 30;
			this.button5.Text = "E&liminar";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.DarkBlue;
			this.label13.Location = new System.Drawing.Point(463, 198);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(46, 13);
			this.label13.TabIndex = 31;
			this.label13.Text = "Estado";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.DarkBlue;
			this.label14.Location = new System.Drawing.Point(222, 244);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(78, 13);
			this.label14.TabIndex = 32;
			this.label14.Text = "Observación";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(78, 305);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(35, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(177, 305);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(35, 28);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 34;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(273, 305);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(27, 27);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 35;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(375, 305);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(35, 27);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 36;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(473, 305);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(27, 28);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 37;
			this.pictureBox5.TabStop = false;
			// 
			// dtpInicio
			// 
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(209, 214);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(121, 20);
			this.dtpInicio.TabIndex = 38;
			// 
			// dtpCese
			// 
			this.dtpCese.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCese.Location = new System.Drawing.Point(336, 215);
			this.dtpCese.Name = "dtpCese";
			this.dtpCese.Size = new System.Drawing.Size(121, 20);
			this.dtpCese.TabIndex = 39;
			// 
			// frmOperativo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 350);
			this.ControlBox = false;
			this.Controls.Add(this.dtpCese);
			this.Controls.Add(this.dtpInicio);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.Grabar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.txtObservacion);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.cmbEstado);
			this.Controls.Add(this.txtJefe);
			this.Controls.Add(this.txtDirec);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtDescrip);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cmbModOper);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbDistrito);
			this.Controls.Add(this.cmbProvincia);
			this.Controls.Add(this.cmbDepartamento);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstOperativos);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmOperativo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Registro de Operativos";
			this.TopMost = true;
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
        private System.Windows.Forms.ListBox lstOperativos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbModOper;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button Grabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpCese;
    }
}