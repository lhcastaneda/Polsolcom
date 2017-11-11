namespace Polsolcom.Forms
{
    partial class frmEnfermedades
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOperativo = new System.Windows.Forms.ComboBox();
            this.operativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operativos = new Polsolcom.Dominio.Data.Operativos();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.allConsultoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.chkAgrupar = new System.Windows.Forms.CheckBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.chkReg = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.rbDiario = new System.Windows.Forms.RadioButton();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.rbRango = new System.Windows.Forms.RadioButton();
            this.operativoTableAdapter = new Polsolcom.Dominio.Data.OperativosTableAdapters.OperativoTableAdapter();
            this.allConsultoriosTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.AllConsultoriosTableAdapter();
            this.lstCIE10 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spinner1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.operativoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operativos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allConsultoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinner1)).BeginInit();
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
            this.cmbOperativo.DataSource = this.operativoBindingSource;
            this.cmbOperativo.DisplayMember = "Descripcion";
            this.cmbOperativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperativo.FormattingEnabled = true;
            this.cmbOperativo.Location = new System.Drawing.Point(81, 18);
            this.cmbOperativo.Name = "cmbOperativo";
            this.cmbOperativo.Size = new System.Drawing.Size(136, 21);
            this.cmbOperativo.TabIndex = 2;
            this.cmbOperativo.ValueMember = "Id_Oper";
            // 
            // operativoBindingSource
            // 
            this.operativoBindingSource.DataMember = "Operativo";
            this.operativoBindingSource.DataSource = this.operativos;
            // 
            // operativos
            // 
            this.operativos.DataSetName = "Operativos";
            this.operativos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.allConsultoriosBindingSource;
            this.cmbConsultorio.DisplayMember = "Descripcion";
            this.cmbConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(299, 18);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(136, 21);
            this.cmbConsultorio.TabIndex = 3;
            this.cmbConsultorio.ValueMember = "Descripcion";
            // 
            // allConsultoriosBindingSource
            // 
            this.allConsultoriosBindingSource.DataMember = "AllConsultorios";
            this.allConsultoriosBindingSource.DataSource = this.consultoriosDS;
            // 
            // consultoriosDS
            // 
            this.consultoriosDS.DataSetName = "ConsultoriosDS";
            this.consultoriosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkAgrupar
            // 
            this.chkAgrupar.AutoSize = true;
            this.chkAgrupar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgrupar.Location = new System.Drawing.Point(453, 18);
            this.chkAgrupar.Name = "chkAgrupar";
            this.chkAgrupar.Size = new System.Drawing.Size(134, 17);
            this.chkAgrupar.TabIndex = 9;
            this.chkAgrupar.Text = "&Agrupar Cabeceras";
            this.chkAgrupar.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(201, 449);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(124, 32);
            this.btnEjecutar.TabIndex = 12;
            this.btnEjecutar.Text = "&Ejecutar";
            this.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(331, 449);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(124, 32);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "E&xportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(461, 449);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(124, 32);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(591, 449);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(124, 32);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // chkReg
            // 
            this.chkReg.AutoSize = true;
            this.chkReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReg.Location = new System.Drawing.Point(656, 18);
            this.chkReg.Name = "chkReg";
            this.chkReg.Size = new System.Drawing.Size(48, 17);
            this.chkReg.TabIndex = 16;
            this.chkReg.Text = "&Top";
            this.chkReg.UseVisualStyleBackColor = true;
            this.chkReg.CheckedChanged += new System.EventHandler(this.chkReg_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFecIni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFecFin);
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
            // dtpFecIni
            // 
            this.dtpFecIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(90, 20);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(99, 20);
            this.dtpFecIni.TabIndex = 18;
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
            // dtpFecFin
            // 
            this.dtpFecFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(286, 21);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(98, 20);
            this.dtpFecFin.TabIndex = 19;
            // 
            // rbDiario
            // 
            this.rbDiario.AutoSize = true;
            this.rbDiario.Checked = true;
            this.rbDiario.Location = new System.Drawing.Point(451, 49);
            this.rbDiario.Name = "rbDiario";
            this.rbDiario.Size = new System.Drawing.Size(52, 17);
            this.rbDiario.TabIndex = 45;
            this.rbDiario.TabStop = true;
            this.rbDiario.Text = "Diario";
            this.rbDiario.UseVisualStyleBackColor = true;
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Location = new System.Drawing.Point(451, 71);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(65, 17);
            this.rbMensual.TabIndex = 46;
            this.rbMensual.Text = "Mensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Location = new System.Drawing.Point(531, 50);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(52, 17);
            this.rbAnual.TabIndex = 47;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            // 
            // rbRango
            // 
            this.rbRango.AutoSize = true;
            this.rbRango.Location = new System.Drawing.Point(531, 70);
            this.rbRango.Name = "rbRango";
            this.rbRango.Size = new System.Drawing.Size(57, 17);
            this.rbRango.TabIndex = 48;
            this.rbRango.Text = "Rango";
            this.rbRango.UseVisualStyleBackColor = true;
            // 
            // operativoTableAdapter
            // 
            this.operativoTableAdapter.ClearBeforeFill = true;
            // 
            // allConsultoriosTableAdapter
            // 
            this.allConsultoriosTableAdapter.ClearBeforeFill = true;
            // 
            // lstCIE10
            // 
            this.lstCIE10.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstCIE10.FullRowSelect = true;
            this.lstCIE10.Location = new System.Drawing.Point(11, 118);
            this.lstCIE10.MultiSelect = false;
            this.lstCIE10.Name = "lstCIE10";
            this.lstCIE10.Size = new System.Drawing.Size(709, 326);
            this.lstCIE10.TabIndex = 49;
            this.lstCIE10.UseCompatibleStateImageBehavior = false;
            this.lstCIE10.View = System.Windows.Forms.View.Details;
            this.lstCIE10.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstCIE10_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CIE10";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Diagnóstico";
            this.columnHeader2.Width = 550;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // spinner1
            // 
            this.spinner1.Enabled = false;
            this.spinner1.Location = new System.Drawing.Point(610, 39);
            this.spinner1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(94, 20);
            this.spinner1.TabIndex = 50;
            this.spinner1.Leave += new System.EventHandler(this.spinner1_Leave);
            // 
            // frmEnfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 490);
            this.ControlBox = false;
            this.Controls.Add(this.spinner1);
            this.Controls.Add(this.lstCIE10);
            this.Controls.Add(this.rbRango);
            this.Controls.Add(this.rbAnual);
            this.Controls.Add(this.rbMensual);
            this.Controls.Add(this.rbDiario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkReg);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.chkAgrupar);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.cmbOperativo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmEnfermedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Epidemología";
            this.Load += new System.EventHandler(this.frmEnfermedades_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEnfermedades_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.operativoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operativos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allConsultoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinner1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOperativo;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.CheckBox chkAgrupar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.CheckBox chkReg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.RadioButton rbDiario;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.RadioButton rbRango;
        private Dominio.Data.Operativos operativos;
        private System.Windows.Forms.BindingSource operativoBindingSource;
        private Dominio.Data.OperativosTableAdapters.OperativoTableAdapter operativoTableAdapter;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private System.Windows.Forms.BindingSource allConsultoriosBindingSource;
        private Dominio.Data.ConsultoriosDSTableAdapters.AllConsultoriosTableAdapter allConsultoriosTableAdapter;
        private System.Windows.Forms.ListView lstCIE10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown spinner1;
    }
}