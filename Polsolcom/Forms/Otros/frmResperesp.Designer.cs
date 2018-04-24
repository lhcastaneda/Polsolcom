namespace Polsolcom.Forms
{
    partial class frmResperEsp
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
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gdvProd = new System.Windows.Forms.DataGridView();
            this.cProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdvDiag = new System.Windows.Forms.DataGridView();
            this.cDiag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSumaCant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotPacientes = new System.Windows.Forms.TextBox();
            this.txtTotatAtenciones = new System.Windows.Forms.TextBox();
            this.txtTotVentas = new System.Windows.Forms.TextBox();
            this.pnlAtenciones = new System.Windows.Forms.Panel();
            this.txtSumTot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDiag)).BeginInit();
            this.pnlAtenciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médico";
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(67, 12);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(255, 21);
            this.cmbMedico.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(344, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde :";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(67, 40);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(99, 20);
            this.dtpDesde.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(173, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(223, 40);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(99, 20);
            this.dtpHasta.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Servicios Prestados";
            // 
            // gdvProd
            // 
            this.gdvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cProd,
            this.cCant,
            this.cPrecio,
            this.cTotal});
            this.gdvProd.Enabled = false;
            this.gdvProd.Location = new System.Drawing.Point(13, 121);
            this.gdvProd.Name = "gdvProd";
            this.gdvProd.Size = new System.Drawing.Size(542, 150);
            this.gdvProd.TabIndex = 8;
            // 
            // cProd
            // 
            this.cProd.HeaderText = "Producto";
            this.cProd.Name = "cProd";
            this.cProd.Width = 200;
            // 
            // cCant
            // 
            this.cCant.HeaderText = "Cantidad";
            this.cCant.Name = "cCant";
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
            // gdvDiag
            // 
            this.gdvDiag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDiag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDiag,
            this.c2Cant});
            this.gdvDiag.Enabled = false;
            this.gdvDiag.Location = new System.Drawing.Point(13, 333);
            this.gdvDiag.Name = "gdvDiag";
            this.gdvDiag.Size = new System.Drawing.Size(542, 150);
            this.gdvDiag.TabIndex = 9;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(138, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Suma de Totales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(13, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Perfil Epidemológico";
            // 
            // txtSumaCant
            // 
            this.txtSumaCant.Location = new System.Drawing.Point(246, 274);
            this.txtSumaCant.Name = "txtSumaCant";
            this.txtSumaCant.Size = new System.Drawing.Size(100, 20);
            this.txtSumaCant.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pacientes Atendidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Atencions Realizadas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total de ventas";
            // 
            // txtTotPacientes
            // 
            this.txtTotPacientes.Location = new System.Drawing.Point(152, 11);
            this.txtTotPacientes.Name = "txtTotPacientes";
            this.txtTotPacientes.Size = new System.Drawing.Size(176, 20);
            this.txtTotPacientes.TabIndex = 17;
            // 
            // txtTotatAtenciones
            // 
            this.txtTotatAtenciones.Location = new System.Drawing.Point(152, 37);
            this.txtTotatAtenciones.Name = "txtTotatAtenciones";
            this.txtTotatAtenciones.Size = new System.Drawing.Size(176, 20);
            this.txtTotatAtenciones.TabIndex = 18;
            // 
            // txtTotVentas
            // 
            this.txtTotVentas.Location = new System.Drawing.Point(152, 63);
            this.txtTotVentas.Name = "txtTotVentas";
            this.txtTotVentas.Size = new System.Drawing.Size(176, 20);
            this.txtTotVentas.TabIndex = 19;
            // 
            // pnlAtenciones
            // 
            this.pnlAtenciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAtenciones.Controls.Add(this.label7);
            this.pnlAtenciones.Controls.Add(this.txtTotVentas);
            this.pnlAtenciones.Controls.Add(this.label8);
            this.pnlAtenciones.Controls.Add(this.txtTotatAtenciones);
            this.pnlAtenciones.Controls.Add(this.label9);
            this.pnlAtenciones.Controls.Add(this.txtTotPacientes);
            this.pnlAtenciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAtenciones.ForeColor = System.Drawing.Color.DarkBlue;
            this.pnlAtenciones.Location = new System.Drawing.Point(709, 12);
            this.pnlAtenciones.Name = "pnlAtenciones";
            this.pnlAtenciones.Size = new System.Drawing.Size(343, 95);
            this.pnlAtenciones.TabIndex = 20;
            // 
            // txtSumTot
            // 
            this.txtSumTot.Location = new System.Drawing.Point(455, 274);
            this.txtSumTot.Name = "txtSumTot";
            this.txtSumTot.Size = new System.Drawing.Size(100, 20);
            this.txtSumTot.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(578, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Gráfico Estadístico por Género";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(578, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Gráfico Estadístico Nuevos y Continuos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(13, 503);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Gráfico Estadístico Grupo Etareo";
            // 
            // frmResperEsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 779);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSumTot);
            this.Controls.Add(this.pnlAtenciones);
            this.Controls.Add(this.txtSumaCant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gdvDiag);
            this.Controls.Add(this.gdvProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmResperEsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen de Especialistas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmResperEsp_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gdvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDiag)).EndInit();
            this.pnlAtenciones.ResumeLayout(false);
            this.pnlAtenciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gdvProd;
        private System.Windows.Forms.DataGridView gdvDiag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSumaCant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotPacientes;
        private System.Windows.Forms.TextBox txtTotatAtenciones;
        private System.Windows.Forms.TextBox txtTotVentas;
        private System.Windows.Forms.Panel pnlAtenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiag;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Cant;
        private System.Windows.Forms.TextBox txtSumTot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}