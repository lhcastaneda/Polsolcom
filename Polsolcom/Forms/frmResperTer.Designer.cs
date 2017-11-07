namespace Polsolcom.Forms
{
    partial class frmResperTer
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
            this.pnlAtencion = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTotPacientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPerPago = new System.Windows.Forms.ComboBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gdvServPrestados = new System.Windows.Forms.DataGridView();
            this.cProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.gdvPerEpidem = new System.Windows.Forms.DataGridView();
            this.cDiag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlAtencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvServPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPerEpidem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAtencion
            // 
            this.pnlAtencion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAtencion.Controls.Add(this.textBox3);
            this.pnlAtencion.Controls.Add(this.textBox2);
            this.pnlAtencion.Controls.Add(this.txtTotPacientes);
            this.pnlAtencion.Controls.Add(this.label3);
            this.pnlAtencion.Controls.Add(this.label2);
            this.pnlAtencion.Controls.Add(this.label1);
            this.pnlAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAtencion.ForeColor = System.Drawing.Color.DarkBlue;
            this.pnlAtencion.Location = new System.Drawing.Point(620, 12);
            this.pnlAtencion.Name = "pnlAtencion";
            this.pnlAtencion.Size = new System.Drawing.Size(313, 100);
            this.pnlAtencion.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 4;
            // 
            // txtTotPacientes
            // 
            this.txtTotPacientes.Location = new System.Drawing.Point(145, 11);
            this.txtTotPacientes.Name = "txtTotPacientes";
            this.txtTotPacientes.Size = new System.Drawing.Size(158, 20);
            this.txtTotPacientes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Atenciones Realizadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacientes Atendidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Especialidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(13, 30);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(220, 21);
            this.cmbEspecialidad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(243, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Consultorio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(239, 30);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(208, 21);
            this.cmbConsultorio.TabIndex = 4;
            this.cmbConsultorio.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(13, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Periodo de Pago";
            // 
            // cmbPerPago
            // 
            this.cmbPerPago.FormattingEnabled = true;
            this.cmbPerPago.Location = new System.Drawing.Point(12, 75);
            this.cmbPerPago.Name = "cmbPerPago";
            this.cmbPerPago.Size = new System.Drawing.Size(221, 21);
            this.cmbPerPago.TabIndex = 6;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Enabled = false;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(239, 76);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(101, 20);
            this.dtpInicio.TabIndex = 7;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpFinal
            // 
            this.dtpFinal.Enabled = false;
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(346, 75);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(101, 20);
            this.dtpFinal.TabIndex = 8;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(243, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(343, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(13, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Servicios Prestados";
            // 
            // gdvServPrestados
            // 
            this.gdvServPrestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvServPrestados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cProd,
            this.cCant,
            this.cPrecio,
            this.cTotal});
            this.gdvServPrestados.Location = new System.Drawing.Point(12, 129);
            this.gdvServPrestados.Name = "gdvServPrestados";
            this.gdvServPrestados.Size = new System.Drawing.Size(542, 150);
            this.gdvServPrestados.TabIndex = 12;
            // 
            // cProd
            // 
            this.cProd.HeaderText = "Producto";
            this.cProd.Name = "cProd";
            this.cProd.Width = 240;
            // 
            // cCant
            // 
            this.cCant.HeaderText = "Cantidad";
            this.cCant.Name = "cCant";
            this.cCant.Width = 60;
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio";
            this.cPrecio.Name = "cPrecio";
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total";
            this.cTotal.Name = "cTotal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(13, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Perfil Epidemológico";
            // 
            // gdvPerEpidem
            // 
            this.gdvPerEpidem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvPerEpidem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDiag,
            this.c2Cant});
            this.gdvPerEpidem.Location = new System.Drawing.Point(12, 313);
            this.gdvPerEpidem.Name = "gdvPerEpidem";
            this.gdvPerEpidem.Size = new System.Drawing.Size(542, 150);
            this.gdvPerEpidem.TabIndex = 14;
            // 
            // cDiag
            // 
            this.cDiag.HeaderText = "Diagnóstico";
            this.cDiag.Name = "cDiag";
            this.cDiag.Width = 400;
            // 
            // c2Cant
            // 
            this.c2Cant.HeaderText = "Cantidad";
            this.c2Cant.Name = "c2Cant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(617, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Gráfico Estadístico por Género";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(617, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Gráfico Estadístico Nuevos y Continuos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(9, 486);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Gráfico Estadístico Grupo Etareo";
            // 
            // frmResperTer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 704);
            this.ControlBox = false;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gdvPerEpidem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gdvServPrestados);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.cmbPerPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlAtencion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmResperTer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen de Terceros";
            this.pnlAtencion.ResumeLayout(false);
            this.pnlAtencion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvServPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPerEpidem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAtencion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTotPacientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPerPago;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gdvServPrestados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gdvPerEpidem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiag;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Cant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}