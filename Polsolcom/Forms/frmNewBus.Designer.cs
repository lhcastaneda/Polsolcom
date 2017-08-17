namespace Polsolcom.Forms
{
    partial class frmNewBus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLastUpDate = new System.Windows.Forms.TextBox();
            this.txtCreation = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRotacion = new System.Windows.Forms.ComboBox();
            this.rotationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rotationDS = new Polsolcom.Dominio.Data.RotationDS();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlterno = new System.Windows.Forms.TextBox();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rotationTableAdapter = new Polsolcom.Dominio.Data.RotationDSTableAdapters.RotationTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtLastUpDate);
            this.panel1.Controls.Add(this.txtCreation);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 53);
            this.panel1.TabIndex = 0;
            // 
            // txtLastUpDate
            // 
            this.txtLastUpDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtLastUpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastUpDate.Location = new System.Drawing.Point(247, 13);
            this.txtLastUpDate.Name = "txtLastUpDate";
            this.txtLastUpDate.Size = new System.Drawing.Size(207, 20);
            this.txtLastUpDate.TabIndex = 1;
            this.txtLastUpDate.Text = "LastUpDate";
            this.txtLastUpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCreation
            // 
            this.txtCreation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCreation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreation.Location = new System.Drawing.Point(17, 13);
            this.txtCreation.Name = "txtCreation";
            this.txtCreation.Size = new System.Drawing.Size(212, 20);
            this.txtCreation.TabIndex = 0;
            this.txtCreation.Text = "Creation";
            this.txtCreation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbEstado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbRotacion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbEmpresa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAlterno);
            this.panel2.Controls.Add(this.txtBus);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 163);
            this.panel2.TabIndex = 1;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(333, 127);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(330, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado Actual";
            // 
            // cmbRotacion
            // 
            this.cmbRotacion.DataSource = this.rotationBindingSource;
            this.cmbRotacion.DisplayMember = "Descripcion";
            this.cmbRotacion.FormattingEnabled = true;
            this.cmbRotacion.Location = new System.Drawing.Point(206, 127);
            this.cmbRotacion.Name = "cmbRotacion";
            this.cmbRotacion.Size = new System.Drawing.Size(121, 21);
            this.cmbRotacion.TabIndex = 9;
            this.cmbRotacion.ValueMember = "Id_Tipo";
            // 
            // rotationBindingSource
            // 
            this.rotationBindingSource.DataMember = "Rotation";
            this.rotationBindingSource.DataSource = this.rotationDS;
            // 
            // rotationDS
            // 
            this.rotationDS.DataSetName = "RotationDS";
            this.rotationDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(203, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rotación Aplicable";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(14, 127);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(186, 21);
            this.cmbTipo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modalidad de Contratación";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(14, 76);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(440, 21);
            this.cmbEmpresa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre o Razón Social";
            // 
            // txtAlterno
            // 
            this.txtAlterno.Location = new System.Drawing.Point(239, 32);
            this.txtAlterno.Name = "txtAlterno";
            this.txtAlterno.Size = new System.Drawing.Size(215, 20);
            this.txtAlterno.TabIndex = 3;
            // 
            // txtBus
            // 
            this.txtBus.Location = new System.Drawing.Point(14, 32);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(215, 20);
            this.txtBus.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(244, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Alterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Consultorio";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(234, 250);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(120, 23);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(360, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rotationTableAdapter
            // 
            this.rotationTableAdapter.ClearBeforeFill = true;
            // 
            // frmNewBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 285);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmNewBus";
            this.Text = "Consultorios / Buses";
            this.Load += new System.EventHandler(this.frmNewBus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLastUpDate;
        private System.Windows.Forms.TextBox txtCreation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRotacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlterno;
        private System.Windows.Forms.TextBox txtBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private Dominio.Data.RotationDS rotationDS;
        private System.Windows.Forms.BindingSource rotationBindingSource;
        private Dominio.Data.RotationDSTableAdapters.RotationTableAdapter rotationTableAdapter;
    }
}