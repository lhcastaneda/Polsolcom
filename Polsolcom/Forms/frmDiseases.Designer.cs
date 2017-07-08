namespace Polsolcom.Forms
{
    partial class frmDiseases
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
            this.cmbOperativo = new System.Windows.Forms.ComboBox();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.checkAgrupar = new System.Windows.Forms.CheckBox();
            this.checklstAgrupar = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cCie10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.checkTop = new System.Windows.Forms.CheckBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operativo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consultorio";
            // 
            // cmbOperativo
            // 
            this.cmbOperativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperativo.FormattingEnabled = true;
            this.cmbOperativo.Location = new System.Drawing.Point(81, 18);
            this.cmbOperativo.Name = "cmbOperativo";
            this.cmbOperativo.Size = new System.Drawing.Size(136, 21);
            this.cmbOperativo.TabIndex = 2;
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(299, 18);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(136, 21);
            this.cmbConsultorio.TabIndex = 3;
            // 
            // checkAgrupar
            // 
            this.checkAgrupar.AutoSize = true;
            this.checkAgrupar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAgrupar.Location = new System.Drawing.Point(453, 18);
            this.checkAgrupar.Name = "checkAgrupar";
            this.checkAgrupar.Size = new System.Drawing.Size(134, 17);
            this.checkAgrupar.TabIndex = 9;
            this.checkAgrupar.Text = "&Agrupar Cabeceras";
            this.checkAgrupar.UseVisualStyleBackColor = true;
            // 
            // checklstAgrupar
            // 
            this.checklstAgrupar.FormattingEnabled = true;
            this.checklstAgrupar.Items.AddRange(new object[] {
            "Diario",
            "Mensual",
            "Anual",
            "Rango"});
            this.checklstAgrupar.Location = new System.Drawing.Point(451, 39);
            this.checklstAgrupar.Name = "checklstAgrupar";
            this.checklstAgrupar.Size = new System.Drawing.Size(117, 64);
            this.checklstAgrupar.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCie10,
            this.cDiag,
            this.cCant});
            this.dataGridView1.Location = new System.Drawing.Point(16, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // cCie10
            // 
            this.cCie10.HeaderText = "CIE 10";
            this.cCie10.Name = "cCie10";
            // 
            // cDiag
            // 
            this.cDiag.HeaderText = "Diagnóstico";
            this.cDiag.Name = "cDiag";
            this.cDiag.Width = 460;
            // 
            // cCant
            // 
            this.cCant.HeaderText = "Cantidad";
            this.cCant.Name = "cCant";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(201, 329);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(124, 32);
            this.btnEjecutar.TabIndex = 12;
            this.btnEjecutar.Text = "&Ejecutar";
            this.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(331, 329);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(124, 32);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "E&xportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(461, 329);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(124, 32);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(591, 329);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(124, 32);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // checkTop
            // 
            this.checkTop.AutoSize = true;
            this.checkTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTop.Location = new System.Drawing.Point(601, 18);
            this.checkTop.Name = "checkTop";
            this.checkTop.Size = new System.Drawing.Size(48, 17);
            this.checkTop.TabIndex = 16;
            this.checkTop.Text = "&Top";
            this.checkTop.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(598, 39);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(109, 20);
            this.domainUpDown1.TabIndex = 17;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 51);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango Fechas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(90, 20);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(99, 20);
            this.dtpInicio.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(203, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Final:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(286, 21);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(98, 20);
            this.dtpFinal.TabIndex = 19;
            // 
            // frmDiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 375);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.checkTop);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checklstAgrupar);
            this.Controls.Add(this.checkAgrupar);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.cmbOperativo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmDiseases";
            this.Text = "Epidemología";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDiseases_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOperativo;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.CheckBox checkAgrupar;
        private System.Windows.Forms.CheckedListBox checklstAgrupar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCie10;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCant;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.CheckBox checkTop;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFinal;
    }
}