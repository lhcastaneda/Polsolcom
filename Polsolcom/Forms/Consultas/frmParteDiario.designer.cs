namespace Polsolcom.Forms
{
    partial class frmParteDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParteDiario));
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.cmbEspecialista = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Enabled = false;
            this.btnVistaPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistaPrevia.Image = ((System.Drawing.Image)(resources.GetObject("btnVistaPrevia.Image")));
            this.btnVistaPrevia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVistaPrevia.Location = new System.Drawing.Point(167, 248);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(110, 29);
            this.btnVistaPrevia.TabIndex = 6;
            this.btnVistaPrevia.Text = "&Vista Previa";
            this.btnVistaPrevia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            this.btnVistaPrevia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnVistaPrevia_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Reporte";
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Location = new System.Drawing.Point(5, 23);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(223, 21);
            this.cmbOpciones.TabIndex = 0;
            this.cmbOpciones.SelectedIndexChanged += new System.EventHandler(this.cmbOpciones_SelectedIndexChanged);
            this.cmbOpciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOpciones_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de Atención";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.Enabled = false;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(5, 73);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(346, 21);
            this.cmbEspecialidad.Sorted = true;
            this.cmbEspecialidad.TabIndex = 2;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            this.cmbEspecialidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEspecialidad_KeyDown);
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Enabled = false;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(5, 223);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(346, 21);
            this.cmbTurno.Sorted = true;
            this.cmbTurno.TabIndex = 5;
            this.cmbTurno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTurno_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Seleccionar Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seleccionar Consultorio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seleccionar Especialista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Seleccionar Turno";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(235, 23);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(112, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            this.txtFecha.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.txtFecha_TypeValidationCompleted);
            this.txtFecha.Enter += new System.EventHandler(this.txtFecha_Enter);
            this.txtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFecha_KeyDown);
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultorio.Enabled = false;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(5, 123);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(346, 21);
            this.cmbConsultorio.Sorted = true;
            this.cmbConsultorio.TabIndex = 3;
            this.cmbConsultorio.SelectedIndexChanged += new System.EventHandler(this.cmbConsultorio_SelectedIndexChanged);
            this.cmbConsultorio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbConsultorio_KeyDown);
            // 
            // cmbEspecialista
            // 
            this.cmbEspecialista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialista.Enabled = false;
            this.cmbEspecialista.FormattingEnabled = true;
            this.cmbEspecialista.Location = new System.Drawing.Point(5, 173);
            this.cmbEspecialista.Name = "cmbEspecialista";
            this.cmbEspecialista.Size = new System.Drawing.Size(346, 21);
            this.cmbEspecialista.Sorted = true;
            this.cmbEspecialista.TabIndex = 4;
            this.cmbEspecialista.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialista_SelectedIndexChanged);
            this.cmbEspecialista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEspecialista_KeyDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(282, 248);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(69, 29);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmParteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 281);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbEspecialista);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOpciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVistaPrevia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmParteDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parte Diario y Consolidados";
            this.Load += new System.EventHandler(this.frmParteDiario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmParteDiario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOpciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox txtFecha;
		private System.Windows.Forms.ComboBox cmbEspecialidad;
		private System.Windows.Forms.ComboBox cmbConsultorio;
		private System.Windows.Forms.ComboBox cmbEspecialista;
		private System.Windows.Forms.Button btnCerrar;
	}
}