namespace Polsolcom.Forms
{
    partial class frmStatGenGroupEtareo
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
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnVerGraf = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkedlstAgrupar = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGrupoEt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFechInicio = new System.Windows.Forms.ComboBox();
            this.cmbFechFinal = new System.Windows.Forms.ComboBox();
            this.nmrHoraInicio = new System.Windows.Forms.NumericUpDown();
            this.nmrHoraFinal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHoraInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHoraFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(276, 223);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(111, 23);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "E&jecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerGraf
            // 
            this.btnVerGraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerGraf.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnVerGraf.Location = new System.Drawing.Point(510, 223);
            this.btnVerGraf.Name = "btnVerGraf";
            this.btnVerGraf.Size = new System.Drawing.Size(111, 23);
            this.btnVerGraf.TabIndex = 1;
            this.btnVerGraf.Text = "&Ver Gráfico";
            this.btnVerGraf.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(510, 434);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estadística - Género y Grupo Etareo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hora :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Agrupar por:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tipo de Gráfico";
            // 
            // checkedlstAgrupar
            // 
            this.checkedlstAgrupar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedlstAgrupar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedlstAgrupar.FormattingEnabled = true;
            this.checkedlstAgrupar.Items.AddRange(new object[] {
            "Por sexo",
            "Por Etareo"});
            this.checkedlstAgrupar.Location = new System.Drawing.Point(39, 188);
            this.checkedlstAgrupar.Name = "checkedlstAgrupar";
            this.checkedlstAgrupar.Size = new System.Drawing.Size(120, 32);
            this.checkedlstAgrupar.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xSexo,
            this.cGrupoEt,
            this.cCant});
            this.dataGridView1.Location = new System.Drawing.Point(30, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // xSexo
            // 
            this.xSexo.HeaderText = "Sexo";
            this.xSexo.Name = "xSexo";
            this.xSexo.Width = 150;
            // 
            // cGrupoEt
            // 
            this.cGrupoEt.HeaderText = "Grupo Etareo";
            this.cGrupoEt.Name = "cGrupoEt";
            this.cGrupoEt.Width = 250;
            // 
            // cCant
            // 
            this.cCant.HeaderText = "Cantidad";
            this.cCant.Name = "cCant";
            this.cCant.Width = 150;
            // 
            // cmbFechInicio
            // 
            this.cmbFechInicio.FormattingEnabled = true;
            this.cmbFechInicio.Location = new System.Drawing.Point(92, 64);
            this.cmbFechInicio.Name = "cmbFechInicio";
            this.cmbFechInicio.Size = new System.Drawing.Size(121, 21);
            this.cmbFechInicio.TabIndex = 14;
            // 
            // cmbFechFinal
            // 
            this.cmbFechFinal.FormattingEnabled = true;
            this.cmbFechFinal.Location = new System.Drawing.Point(92, 124);
            this.cmbFechFinal.Name = "cmbFechFinal";
            this.cmbFechFinal.Size = new System.Drawing.Size(121, 21);
            this.cmbFechFinal.TabIndex = 15;
            // 
            // nmrHoraInicio
            // 
            this.nmrHoraInicio.Location = new System.Drawing.Point(267, 65);
            this.nmrHoraInicio.Name = "nmrHoraInicio";
            this.nmrHoraInicio.Size = new System.Drawing.Size(120, 20);
            this.nmrHoraInicio.TabIndex = 16;
            // 
            // nmrHoraFinal
            // 
            this.nmrHoraFinal.Location = new System.Drawing.Point(267, 125);
            this.nmrHoraFinal.Name = "nmrHoraFinal";
            this.nmrHoraFinal.Size = new System.Drawing.Size(120, 20);
            this.nmrHoraFinal.TabIndex = 17;
            // 
            // frmStatGenGroupEtareo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 469);
            this.Controls.Add(this.nmrHoraFinal);
            this.Controls.Add(this.nmrHoraInicio);
            this.Controls.Add(this.cmbFechFinal);
            this.Controls.Add(this.cmbFechInicio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkedlstAgrupar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerGraf);
            this.Controls.Add(this.btnEjecutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmStatGenGroupEtareo";
            this.Text = "frmStatGenGroupEtareo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHoraInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHoraFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnVerGraf;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox checkedlstAgrupar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGrupoEt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCant;
        private System.Windows.Forms.ComboBox cmbFechInicio;
        private System.Windows.Forms.ComboBox cmbFechFinal;
        private System.Windows.Forms.NumericUpDown nmrHoraInicio;
        private System.Windows.Forms.NumericUpDown nmrHoraFinal;
    }
}