namespace Polsolcom.Forms
{
    partial class frmGenPaySalSpecialist
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVistaPre = new System.Windows.Forms.Button();
            this.chkEspecialistas = new System.Windows.Forms.CheckBox();
            this.cmbEspecialistas = new System.Windows.Forms.ComboBox();
            this.chkEspecialidad = new System.Windows.Forms.CheckBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.chkTurn = new System.Windows.Forms.CheckBox();
            this.cmbTurn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(167, 50);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnVistaPre
            // 
            this.btnVistaPre.Location = new System.Drawing.Point(52, 51);
            this.btnVistaPre.Name = "btnVistaPre";
            this.btnVistaPre.Size = new System.Drawing.Size(100, 23);
            this.btnVistaPre.TabIndex = 4;
            this.btnVistaPre.Text = "Vista &Previa";
            this.btnVistaPre.UseVisualStyleBackColor = true;
            // 
            // chkEspecialistas
            // 
            this.chkEspecialistas.AutoSize = true;
            this.chkEspecialistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEspecialistas.Location = new System.Drawing.Point(13, 129);
            this.chkEspecialistas.Name = "chkEspecialistas";
            this.chkEspecialistas.Size = new System.Drawing.Size(100, 17);
            this.chkEspecialistas.TabIndex = 2;
            this.chkEspecialistas.Text = "Especialistas";
            this.chkEspecialistas.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialistas
            // 
            this.cmbEspecialistas.FormattingEnabled = true;
            this.cmbEspecialistas.Location = new System.Drawing.Point(13, 153);
            this.cmbEspecialistas.Name = "cmbEspecialistas";
            this.cmbEspecialistas.Size = new System.Drawing.Size(325, 21);
            this.cmbEspecialistas.TabIndex = 3;
            // 
            // chkEspecialidad
            // 
            this.chkEspecialidad.AutoSize = true;
            this.chkEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEspecialidad.Location = new System.Drawing.Point(13, 181);
            this.chkEspecialidad.Name = "chkEspecialidad";
            this.chkEspecialidad.Size = new System.Drawing.Size(98, 17);
            this.chkEspecialidad.TabIndex = 4;
            this.chkEspecialidad.Text = "Especialidad";
            this.chkEspecialidad.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(13, 205);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(326, 21);
            this.cmbEspecialidad.TabIndex = 5;
            // 
            // chkTurn
            // 
            this.chkTurn.AutoSize = true;
            this.chkTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTurn.Location = new System.Drawing.Point(13, 233);
            this.chkTurn.Name = "chkTurn";
            this.chkTurn.Size = new System.Drawing.Size(65, 17);
            this.chkTurn.TabIndex = 6;
            this.chkTurn.Text = "Turnos";
            this.chkTurn.UseVisualStyleBackColor = true;
            // 
            // cmbTurn
            // 
            this.cmbTurn.FormattingEnabled = true;
            this.cmbTurn.Location = new System.Drawing.Point(13, 257);
            this.cmbTurn.Name = "cmbTurn";
            this.cmbTurn.Size = new System.Drawing.Size(324, 21);
            this.cmbTurn.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnVistaPre);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(9, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 100);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de Parte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desde:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(54, 20);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(99, 20);
            this.dtpInicio.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(161, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hasta:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(206, 20);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(98, 20);
            this.dtpFinal.TabIndex = 19;
            // 
            // frmGenPaySalSpecialist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 291);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTurn);
            this.Controls.Add(this.chkTurn);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.chkEspecialidad);
            this.Controls.Add(this.cmbEspecialistas);
            this.Controls.Add(this.chkEspecialistas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmGenPaySalSpecialist";
            this.Text = "Planilla de Pago para Especialistas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGenPaySalSpecialist_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVistaPre;
        private System.Windows.Forms.CheckBox chkEspecialistas;
        private System.Windows.Forms.ComboBox cmbEspecialistas;
        private System.Windows.Forms.CheckBox chkEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.CheckBox chkTurn;
        private System.Windows.Forms.ComboBox cmbTurn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFinal;
    }
}