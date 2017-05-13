namespace Polsolcom.Forms
{
    partial class frmPerPago
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lstPeriodos = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicipPer = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalPer = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomPer = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCreation = new System.Windows.Forms.TextBox();
            this.txtLastUpDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdPer = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(114, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(318, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // lstPeriodos
            // 
            this.lstPeriodos.FormattingEnabled = true;
            this.lstPeriodos.Location = new System.Drawing.Point(12, 40);
            this.lstPeriodos.Name = "lstPeriodos";
            this.lstPeriodos.ScrollAlwaysVisible = true;
            this.lstPeriodos.Size = new System.Drawing.Size(420, 95);
            this.lstPeriodos.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(68, 289);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 40);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(173, 289);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 40);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Búsqueda";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtIdPer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLastUpDate);
            this.panel1.Controls.Add(this.txtCreation);
            this.panel1.Controls.Add(this.txtNomPer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpFinalPer);
            this.panel1.Controls.Add(this.dtpInicipPer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 141);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicio Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(120, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Final Periodo";
            // 
            // dtpInicipPer
            // 
            this.dtpInicipPer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicipPer.Location = new System.Drawing.Point(12, 29);
            this.dtpInicipPer.Name = "dtpInicipPer";
            this.dtpInicipPer.Size = new System.Drawing.Size(102, 20);
            this.dtpInicipPer.TabIndex = 2;
            // 
            // dtpFinalPer
            // 
            this.dtpFinalPer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalPer.Location = new System.Drawing.Point(120, 29);
            this.dtpFinalPer.Name = "dtpFinalPer";
            this.dtpFinalPer.Size = new System.Drawing.Size(102, 20);
            this.dtpFinalPer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del Periodo";
            // 
            // txtNomPer
            // 
            this.txtNomPer.Location = new System.Drawing.Point(12, 78);
            this.txtNomPer.Name = "txtNomPer";
            this.txtNomPer.Size = new System.Drawing.Size(391, 20);
            this.txtNomPer.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(278, 289);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtCreation
            // 
            this.txtCreation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCreation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreation.Location = new System.Drawing.Point(12, 105);
            this.txtCreation.Name = "txtCreation";
            this.txtCreation.Size = new System.Drawing.Size(190, 20);
            this.txtCreation.TabIndex = 6;
            this.txtCreation.Text = "Creation";
            this.txtCreation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastUpDate
            // 
            this.txtLastUpDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtLastUpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastUpDate.Location = new System.Drawing.Point(218, 105);
            this.txtLastUpDate.Name = "txtLastUpDate";
            this.txtLastUpDate.Size = new System.Drawing.Size(185, 20);
            this.txtLastUpDate.TabIndex = 7;
            this.txtLastUpDate.Text = "LastUpDate";
            this.txtLastUpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(300, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Periodo";
            // 
            // txtIdPer
            // 
            this.txtIdPer.Location = new System.Drawing.Point(303, 28);
            this.txtIdPer.Name = "txtIdPer";
            this.txtIdPer.Size = new System.Drawing.Size(100, 20);
            this.txtIdPer.TabIndex = 9;
            // 
            // frmPerPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 341);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstPeriodos);
            this.Controls.Add(this.txtBuscar);
            this.Name = "frmPerPago";
            this.Text = "Periodos de Pago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListBox lstPeriodos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLastUpDate;
        private System.Windows.Forms.TextBox txtCreation;
        private System.Windows.Forms.TextBox txtNomPer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFinalPer;
        private System.Windows.Forms.DateTimePicker dtpInicipPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdPer;
        private System.Windows.Forms.Label label5;
    }
}