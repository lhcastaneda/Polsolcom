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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperativo));
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
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpCese = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(13, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Seleccione Operativo";
			// 
			// lstOperativos
			// 
			this.lstOperativos.FormattingEnabled = true;
			this.lstOperativos.Location = new System.Drawing.Point(9, 23);
			this.lstOperativos.Name = "lstOperativos";
			this.lstOperativos.ScrollAlwaysVisible = true;
			this.lstOperativos.Size = new System.Drawing.Size(187, 264);
			this.lstOperativos.TabIndex = 0;
			this.lstOperativos.DoubleClick += new System.EventHandler(this.lstOperativos_DoubleClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkBlue;
			this.label2.Location = new System.Drawing.Point(211, 6);
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
			this.label3.Location = new System.Drawing.Point(265, 6);
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
			this.label4.Location = new System.Drawing.Point(505, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Teléfono (nro1/nro2/..)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkBlue;
			this.label5.Location = new System.Drawing.Point(211, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(251, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Dirección (Av. /Calle/Urb. /Mz. / Lt. / etc)";
			// 
			// cmbDepartamento
			// 
			this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDepartamento.FormattingEnabled = true;
			this.cmbDepartamento.Location = new System.Drawing.Point(203, 108);
			this.cmbDepartamento.Name = "cmbDepartamento";
			this.cmbDepartamento.Size = new System.Drawing.Size(134, 21);
			this.cmbDepartamento.TabIndex = 5;
			// 
			// cmbProvincia
			// 
			this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProvincia.FormattingEnabled = true;
			this.cmbProvincia.Location = new System.Drawing.Point(343, 108);
			this.cmbProvincia.Name = "cmbProvincia";
			this.cmbProvincia.Size = new System.Drawing.Size(147, 21);
			this.cmbProvincia.TabIndex = 6;
			// 
			// cmbDistrito
			// 
			this.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDistrito.FormattingEnabled = true;
			this.cmbDistrito.Location = new System.Drawing.Point(496, 108);
			this.cmbDistrito.Name = "cmbDistrito";
			this.cmbDistrito.Size = new System.Drawing.Size(146, 21);
			this.cmbDistrito.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkBlue;
			this.label6.Location = new System.Drawing.Point(211, 92);
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
			this.label7.Location = new System.Drawing.Point(351, 92);
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
			this.label8.Location = new System.Drawing.Point(504, 92);
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
			this.label9.Location = new System.Drawing.Point(211, 136);
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
			this.label10.Location = new System.Drawing.Point(466, 135);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "Modalidad";
			// 
			// cmbModOper
			// 
			this.cmbModOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbModOper.FormattingEnabled = true;
			this.cmbModOper.Location = new System.Drawing.Point(459, 151);
			this.cmbModOper.Name = "cmbModOper";
			this.cmbModOper.Size = new System.Drawing.Size(184, 21);
			this.cmbModOper.TabIndex = 9;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.DarkBlue;
			this.label11.Location = new System.Drawing.Point(211, 178);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(38, 13);
			this.label11.TabIndex = 15;
			this.label11.Text = "Inicio";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(203, 24);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(50, 20);
			this.txtId.TabIndex = 1;
			// 
			// txtDescrip
			// 
			this.txtDescrip.Location = new System.Drawing.Point(259, 24);
			this.txtDescrip.Name = "txtDescrip";
			this.txtDescrip.Size = new System.Drawing.Size(243, 20);
			this.txtDescrip.TabIndex = 2;
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(508, 24);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(135, 20);
			this.txtTel.TabIndex = 3;
			// 
			// txtDirec
			// 
			this.txtDirec.Location = new System.Drawing.Point(203, 67);
			this.txtDirec.Name = "txtDirec";
			this.txtDirec.Size = new System.Drawing.Size(440, 20);
			this.txtDirec.TabIndex = 4;
			// 
			// txtJefe
			// 
			this.txtJefe.Location = new System.Drawing.Point(203, 152);
			this.txtJefe.Name = "txtJefe";
			this.txtJefe.Size = new System.Drawing.Size(252, 20);
			this.txtJefe.TabIndex = 8;
			// 
			// cmbEstado
			// 
			this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Location = new System.Drawing.Point(474, 195);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(169, 21);
			this.cmbEstado.TabIndex = 12;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.DarkBlue;
			this.label12.Location = new System.Drawing.Point(344, 178);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(35, 13);
			this.label12.TabIndex = 24;
			this.label12.Text = "Cese";
			// 
			// txtObservacion
			// 
			this.txtObservacion.Location = new System.Drawing.Point(203, 240);
			this.txtObservacion.Multiline = true;
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtObservacion.Size = new System.Drawing.Size(440, 47);
			this.txtObservacion.TabIndex = 13;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.ForeColor = System.Drawing.Color.Black;
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(68, 292);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(82, 30);
			this.btnNuevo.TabIndex = 14;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = true;
			// 
			// Grabar
			// 
			this.Grabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Grabar.ForeColor = System.Drawing.Color.Black;
			this.Grabar.Image = ((System.Drawing.Image)(resources.GetObject("Grabar.Image")));
			this.Grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Grabar.Location = new System.Drawing.Point(169, 292);
			this.Grabar.Name = "Grabar";
			this.Grabar.Size = new System.Drawing.Size(82, 30);
			this.Grabar.TabIndex = 15;
			this.Grabar.Text = "&Grabar";
			this.Grabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Grabar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.Black;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(270, 292);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(82, 30);
			this.btnCancelar.TabIndex = 16;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			this.btnCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancelar_KeyDown);
			// 
			// btnEditar
			// 
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.Black;
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(371, 292);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(82, 30);
			this.btnEditar.TabIndex = 17;
			this.btnEditar.Text = "&Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.Location = new System.Drawing.Point(472, 292);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(82, 30);
			this.button5.TabIndex = 18;
			this.button5.Text = "E&liminar";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.DarkBlue;
			this.label13.Location = new System.Drawing.Point(483, 178);
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
			this.label14.Location = new System.Drawing.Point(211, 220);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(78, 13);
			this.label14.TabIndex = 32;
			this.label14.Text = "Observación";
			// 
			// dtpInicio
			// 
			this.dtpInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpInicio.Location = new System.Drawing.Point(203, 195);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(127, 20);
			this.dtpInicio.TabIndex = 10;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
			// 
			// dtpCese
			// 
			this.dtpCese.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtpCese.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCese.Location = new System.Drawing.Point(335, 195);
			this.dtpCese.Name = "dtpCese";
			this.dtpCese.Size = new System.Drawing.Size(134, 20);
			this.dtpCese.TabIndex = 11;
			// 
			// frmOperativo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 325);
			this.ControlBox = false;
			this.Controls.Add(this.cmbModOper);
			this.Controls.Add(this.dtpCese);
			this.Controls.Add(this.dtpInicio);
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
			this.Load += new System.EventHandler(this.frmOperativo_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOperativo_KeyDown);
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
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpCese;
    }
}