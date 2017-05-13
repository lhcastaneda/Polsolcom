namespace Polsolcom.Forms
{
    partial class frmStatPatients
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechInicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cAnno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNuevos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAntiguos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotNuevos = new System.Windows.Forms.TextBox();
            this.txtTotCont = new System.Windows.Forms.TextBox();
            this.txtTotTotal = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnVerGraf = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadística Pacientes y Continuadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rango de Fechas";
            // 
            // txtFechInicio
            // 
            this.txtFechInicio.Location = new System.Drawing.Point(87, 88);
            this.txtFechInicio.Name = "txtFechInicio";
            this.txtFechInicio.Size = new System.Drawing.Size(100, 20);
            this.txtFechInicio.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Final:";
            // 
            // txtFechFinal
            // 
            this.txtFechFinal.Location = new System.Drawing.Point(282, 88);
            this.txtFechFinal.Name = "txtFechFinal";
            this.txtFechFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFechFinal.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Agrupar por:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Por año",
            "Por fecha"});
            this.checkedListBox1.Location = new System.Drawing.Point(421, 85);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 34);
            this.checkedListBox1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAnno,
            this.cMes,
            this.cFech,
            this.cNuevos,
            this.cAntiguos,
            this.cTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 165);
            this.dataGridView1.TabIndex = 8;
            // 
            // cAnno
            // 
            this.cAnno.HeaderText = "Año";
            this.cAnno.Name = "cAnno";
            // 
            // cMes
            // 
            this.cMes.HeaderText = "Mes";
            this.cMes.Name = "cMes";
            // 
            // cFech
            // 
            this.cFech.HeaderText = "Fecha";
            this.cFech.Name = "cFech";
            // 
            // cNuevos
            // 
            this.cNuevos.HeaderText = "Nuevos";
            this.cNuevos.Name = "cNuevos";
            // 
            // cAntiguos
            // 
            this.cAntiguos.HeaderText = "Antiguos";
            this.cAntiguos.Name = "cAntiguos";
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total";
            this.cTotal.Name = "cTotal";
            // 
            // txtTotNuevos
            // 
            this.txtTotNuevos.Location = new System.Drawing.Point(354, 321);
            this.txtTotNuevos.Name = "txtTotNuevos";
            this.txtTotNuevos.Size = new System.Drawing.Size(100, 20);
            this.txtTotNuevos.TabIndex = 9;
            // 
            // txtTotCont
            // 
            this.txtTotCont.Location = new System.Drawing.Point(460, 321);
            this.txtTotCont.Name = "txtTotCont";
            this.txtTotCont.Size = new System.Drawing.Size(100, 20);
            this.txtTotCont.TabIndex = 10;
            // 
            // txtTotTotal
            // 
            this.txtTotTotal.Location = new System.Drawing.Point(566, 321);
            this.txtTotTotal.Name = "txtTotTotal";
            this.txtTotTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotTotal.TabIndex = 11;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(421, 8);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 12;
            this.btnEjecutar.Text = "&Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(503, 8);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "I&mprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(584, 106);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 14;
            this.btnExportar.Text = "E&xportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnVerGraf
            // 
            this.btnVerGraf.Location = new System.Drawing.Point(584, 368);
            this.btnVerGraf.Name = "btnVerGraf";
            this.btnVerGraf.Size = new System.Drawing.Size(75, 23);
            this.btnVerGraf.TabIndex = 15;
            this.btnVerGraf.Text = "&Ver Gráfico";
            this.btnVerGraf.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(584, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo de Gráfico";
            // 
            // frmStatPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 453);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerGraf);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtTotTotal);
            this.Controls.Add(this.txtTotCont);
            this.Controls.Add(this.txtTotNuevos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFechFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStatPatients";
            this.Text = "frmStatPatients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAnno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNuevos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAntiguos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.TextBox txtTotNuevos;
        private System.Windows.Forms.TextBox txtTotCont;
        private System.Windows.Forms.TextBox txtTotTotal;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnVerGraf;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
    }
}