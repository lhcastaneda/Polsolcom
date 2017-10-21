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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdPer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastUpDate = new System.Windows.Forms.TextBox();
            this.txtCreation = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFinalPer = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioPer = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstPeriodos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(114, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(318, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(68, 399);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 40);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(173, 399);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 40);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.panel1.Controls.Add(this.txtPeriodo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpFinalPer);
            this.panel1.Controls.Add(this.dtpInicioPer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 127);
            this.panel1.TabIndex = 5;
            // 
            // txtIdPer
            // 
            this.txtIdPer.Enabled = false;
            this.txtIdPer.Location = new System.Drawing.Point(303, 19);
            this.txtIdPer.Name = "txtIdPer";
            this.txtIdPer.Size = new System.Drawing.Size(100, 20);
            this.txtIdPer.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(300, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Periodo";
            // 
            // txtLastUpDate
            // 
            this.txtLastUpDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtLastUpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastUpDate.Location = new System.Drawing.Point(218, 96);
            this.txtLastUpDate.Name = "txtLastUpDate";
            this.txtLastUpDate.Size = new System.Drawing.Size(185, 20);
            this.txtLastUpDate.TabIndex = 7;
            this.txtLastUpDate.Text = "LastUpDate";
            this.txtLastUpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCreation
            // 
            this.txtCreation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCreation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreation.Location = new System.Drawing.Point(12, 96);
            this.txtCreation.Name = "txtCreation";
            this.txtCreation.Size = new System.Drawing.Size(190, 20);
            this.txtCreation.TabIndex = 6;
            this.txtCreation.Text = "Creation";
            this.txtCreation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Location = new System.Drawing.Point(12, 69);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(391, 20);
            this.txtPeriodo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del Periodo";
            // 
            // dtpFinalPer
            // 
            this.dtpFinalPer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalPer.Location = new System.Drawing.Point(120, 20);
            this.dtpFinalPer.Name = "dtpFinalPer";
            this.dtpFinalPer.Size = new System.Drawing.Size(102, 20);
            this.dtpFinalPer.TabIndex = 3;
            this.dtpFinalPer.ValueChanged += new System.EventHandler(this.dtpFinalPer_ValueChanged);
            // 
            // dtpInicioPer
            // 
            this.dtpInicioPer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioPer.Location = new System.Drawing.Point(12, 20);
            this.dtpInicioPer.Name = "dtpInicioPer";
            this.dtpInicioPer.Size = new System.Drawing.Size(102, 20);
            this.dtpInicioPer.TabIndex = 2;
            this.dtpInicioPer.ValueChanged += new System.EventHandler(this.dtpInicioPer_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(120, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Final Periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicio Periodo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(278, 399);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstPeriodos
            // 
            this.lstPeriodos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstPeriodos.FullRowSelect = true;
            this.lstPeriodos.Location = new System.Drawing.Point(10, 40);
            this.lstPeriodos.Name = "lstPeriodos";
            this.lstPeriodos.Size = new System.Drawing.Size(422, 218);
            this.lstPeriodos.TabIndex = 7;
            this.lstPeriodos.UseCompatibleStateImageBehavior = false;
            this.lstPeriodos.View = System.Windows.Forms.View.Details;
            this.lstPeriodos.SelectedIndexChanged += new System.EventHandler(this.lstPeriodos_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Periodo";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id";
            this.columnHeader2.Width = 50;
            // 
            // frmPerPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 449);
            this.ControlBox = false;
            this.Controls.Add(this.lstPeriodos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmPerPago";
            this.Text = "Periodos de Pago";
            this.Load += new System.EventHandler(this.frmPerPago_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPerPago_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLastUpDate;
        private System.Windows.Forms.TextBox txtCreation;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFinalPer;
        private System.Windows.Forms.DateTimePicker dtpInicioPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdPer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstPeriodos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}