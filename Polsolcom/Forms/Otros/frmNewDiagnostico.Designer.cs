namespace Polsolcom.Forms
{
    partial class frmNewDiagnostico
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
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.pnlOdontologo = new System.Windows.Forms.Panel();
            this.dtpFech = new System.Windows.Forms.DateTimePicker();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOtroDiag = new System.Windows.Forms.TextBox();
            this.cmbDiag = new System.Windows.Forms.ComboBox();
            this.chkOtros = new System.Windows.Forms.CheckBox();
            this.chkCIE10 = new System.Windows.Forms.CheckBox();
            this.cmbOdontologo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlOdontologo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Ticket de Venta - Presione [SUPR] para desmarcar";
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(16, 41);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.ScrollAlwaysVisible = true;
            this.lstTickets.Size = new System.Drawing.Size(497, 95);
            this.lstTickets.TabIndex = 1;
            // 
            // pnlOdontologo
            // 
            this.pnlOdontologo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOdontologo.Controls.Add(this.dtpFech);
            this.pnlOdontologo.Controls.Add(this.txtObservacion);
            this.pnlOdontologo.Controls.Add(this.label4);
            this.pnlOdontologo.Controls.Add(this.label3);
            this.pnlOdontologo.Controls.Add(this.txtOtroDiag);
            this.pnlOdontologo.Controls.Add(this.cmbDiag);
            this.pnlOdontologo.Controls.Add(this.chkOtros);
            this.pnlOdontologo.Controls.Add(this.chkCIE10);
            this.pnlOdontologo.Controls.Add(this.cmbOdontologo);
            this.pnlOdontologo.Controls.Add(this.label2);
            this.pnlOdontologo.Location = new System.Drawing.Point(16, 152);
            this.pnlOdontologo.Name = "pnlOdontologo";
            this.pnlOdontologo.Size = new System.Drawing.Size(497, 198);
            this.pnlOdontologo.TabIndex = 2;
            // 
            // dtpFech
            // 
            this.dtpFech.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFech.Location = new System.Drawing.Point(126, 113);
            this.dtpFech.Name = "dtpFech";
            this.dtpFech.Size = new System.Drawing.Size(106, 20);
            this.dtpFech.TabIndex = 10;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(126, 148);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(352, 33);
            this.txtObservacion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Observación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // txtOtroDiag
            // 
            this.txtOtroDiag.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtOtroDiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtroDiag.Location = new System.Drawing.Point(126, 82);
            this.txtOtroDiag.Name = "txtOtroDiag";
            this.txtOtroDiag.Size = new System.Drawing.Size(352, 20);
            this.txtOtroDiag.TabIndex = 5;
            // 
            // cmbDiag
            // 
            this.cmbDiag.FormattingEnabled = true;
            this.cmbDiag.Location = new System.Drawing.Point(126, 45);
            this.cmbDiag.Name = "cmbDiag";
            this.cmbDiag.Size = new System.Drawing.Size(352, 21);
            this.cmbDiag.TabIndex = 4;
            // 
            // chkOtros
            // 
            this.chkOtros.AutoSize = true;
            this.chkOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOtros.Location = new System.Drawing.Point(16, 82);
            this.chkOtros.Name = "chkOtros";
            this.chkOtros.Size = new System.Drawing.Size(56, 17);
            this.chkOtros.TabIndex = 3;
            this.chkOtros.Text = "Otros";
            this.chkOtros.UseVisualStyleBackColor = true;
            // 
            // chkCIE10
            // 
            this.chkCIE10.AutoSize = true;
            this.chkCIE10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCIE10.Location = new System.Drawing.Point(16, 45);
            this.chkCIE10.Name = "chkCIE10";
            this.chkCIE10.Size = new System.Drawing.Size(60, 17);
            this.chkCIE10.TabIndex = 2;
            this.chkCIE10.Text = "CIE10";
            this.chkCIE10.UseVisualStyleBackColor = true;
            // 
            // cmbOdontologo
            // 
            this.cmbOdontologo.FormattingEnabled = true;
            this.cmbOdontologo.Location = new System.Drawing.Point(126, 11);
            this.cmbOdontologo.Name = "cmbOdontologo";
            this.cmbOdontologo.Size = new System.Drawing.Size(352, 21);
            this.cmbOdontologo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Odontólogo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(307, 369);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(413, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmNewDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pnlOdontologo);
            this.Controls.Add(this.lstTickets);
            this.Controls.Add(this.label1);
            this.Name = "frmNewDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Diagnóstico";
            this.pnlOdontologo.ResumeLayout(false);
            this.pnlOdontologo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Panel pnlOdontologo;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOtroDiag;
        private System.Windows.Forms.ComboBox cmbDiag;
        private System.Windows.Forms.CheckBox chkOtros;
        private System.Windows.Forms.CheckBox chkCIE10;
        private System.Windows.Forms.ComboBox cmbOdontologo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFech;
    }
}