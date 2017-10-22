namespace Polsolcom.Forms.Procesos
{
    partial class frmProduccionMedicos
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
            this.chkIngData = new System.Windows.Forms.CheckBox();
            this.chkConsulData = new System.Windows.Forms.CheckBox();
            this.dtpFechActual = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCMP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbTurn = new System.Windows.Forms.ComboBox();
            this.cmbObservaciones = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.gdvProduccion = new System.Windows.Forms.DataGridView();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cConsultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTurn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cObserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter();
            this.medicosDS = new Polsolcom.Dominio.Data.MedicosDS();
            this.medicosProduccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosProduccionTableAdapter = new Polsolcom.Dominio.Data.MedicosDSTableAdapters.MedicosProduccionTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosProduccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chkIngData
            // 
            this.chkIngData.AutoSize = true;
            this.chkIngData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIngData.Location = new System.Drawing.Point(241, 4);
            this.chkIngData.Name = "chkIngData";
            this.chkIngData.Size = new System.Drawing.Size(117, 17);
            this.chkIngData.TabIndex = 0;
            this.chkIngData.Text = "&Ingreso de Data";
            this.chkIngData.UseVisualStyleBackColor = true;
            // 
            // chkConsulData
            // 
            this.chkConsulData.AutoSize = true;
            this.chkConsulData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConsulData.Location = new System.Drawing.Point(413, 4);
            this.chkConsulData.Name = "chkConsulData";
            this.chkConsulData.Size = new System.Drawing.Size(106, 17);
            this.chkConsulData.TabIndex = 1;
            this.chkConsulData.Text = "&Consulta Data";
            this.chkConsulData.UseVisualStyleBackColor = true;
            // 
            // dtpFechActual
            // 
            this.dtpFechActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechActual.Location = new System.Drawing.Point(820, 27);
            this.dtpFechActual.Name = "dtpFechActual";
            this.dtpFechActual.Size = new System.Drawing.Size(101, 20);
            this.dtpFechActual.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.chkIngData);
            this.panel1.Controls.Add(this.chkConsulData);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 26);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Parte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(125, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CMP";
            // 
            // txtCMP
            // 
            this.txtCMP.Location = new System.Drawing.Point(121, 63);
            this.txtCMP.Name = "txtCMP";
            this.txtCMP.Size = new System.Drawing.Size(100, 20);
            this.txtCMP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(227, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Médico";
            // 
            // cmbMedico
            // 
            this.cmbMedico.DataSource = this.medicosProduccionBindingSource;
            this.cmbMedico.DisplayMember = "Medico";
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(227, 62);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(304, 21);
            this.cmbMedico.TabIndex = 9;
            this.cmbMedico.ValueMember = "Id_Personal";
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DataSource = this.especialidadBindingSource;
            this.cmbConsultorio.DisplayMember = "Descripcion";
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(537, 62);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(252, 21);
            this.cmbConsultorio.TabIndex = 10;
            this.cmbConsultorio.ValueMember = "Id_Consultorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(534, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Consultorio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(13, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(12, 114);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(103, 20);
            this.txtCant.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(125, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(121, 114);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(227, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(227, 114);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // cmbTurn
            // 
            this.cmbTurn.FormattingEnabled = true;
            this.cmbTurn.Location = new System.Drawing.Point(333, 114);
            this.cmbTurn.Name = "cmbTurn";
            this.cmbTurn.Size = new System.Drawing.Size(198, 21);
            this.cmbTurn.TabIndex = 18;
            // 
            // cmbObservaciones
            // 
            this.cmbObservaciones.FormattingEnabled = true;
            this.cmbObservaciones.Location = new System.Drawing.Point(537, 114);
            this.cmbObservaciones.Name = "cmbObservaciones";
            this.cmbObservaciones.Size = new System.Drawing.Size(252, 21);
            this.cmbObservaciones.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(330, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Turno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(534, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Observaciones";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(12, 63);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(821, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha System";
            // 
            // gdvProduccion
            // 
            this.gdvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFecha,
            this.cCMP,
            this.cMedico,
            this.cConsultorio,
            this.cProd,
            this.cCant,
            this.cPrecio,
            this.cMonto,
            this.cTurn,
            this.cObserv});
            this.gdvProduccion.Location = new System.Drawing.Point(12, 166);
            this.gdvProduccion.Name = "gdvProduccion";
            this.gdvProduccion.Size = new System.Drawing.Size(1043, 207);
            this.gdvProduccion.TabIndex = 24;
            // 
            // cFecha
            // 
            this.cFecha.HeaderText = "Fecha";
            this.cFecha.Name = "cFecha";
            this.cFecha.Width = 60;
            // 
            // cCMP
            // 
            this.cCMP.HeaderText = "CMP";
            this.cCMP.Name = "cCMP";
            this.cCMP.Width = 60;
            // 
            // cMedico
            // 
            this.cMedico.HeaderText = "Medico";
            this.cMedico.Name = "cMedico";
            this.cMedico.Width = 180;
            // 
            // cConsultorio
            // 
            this.cConsultorio.HeaderText = "Consultorio";
            this.cConsultorio.Name = "cConsultorio";
            this.cConsultorio.Width = 180;
            // 
            // cProd
            // 
            this.cProd.HeaderText = "Producto";
            this.cProd.Name = "cProd";
            this.cProd.Width = 180;
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
            this.cPrecio.Width = 60;
            // 
            // cMonto
            // 
            this.cMonto.HeaderText = "Monto";
            this.cMonto.Name = "cMonto";
            this.cMonto.Width = 60;
            // 
            // cTurn
            // 
            this.cTurn.HeaderText = "Turno";
            this.cTurn.Name = "cTurn";
            this.cTurn.Width = 60;
            // 
            // cObserv
            // 
            this.cObserv.HeaderText = "Observación";
            this.cObserv.Name = "cObserv";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(944, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnFiltrar.Location = new System.Drawing.Point(944, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(111, 23);
            this.btnFiltrar.TabIndex = 26;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(944, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 23);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "&Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(944, 70);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(111, 23);
            this.btnGrabar.TabIndex = 28;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(944, 99);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 23);
            this.btnBorrar.TabIndex = 29;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // consultoriosDS
            // 
            this.consultoriosDS.DataSetName = "ConsultoriosDS";
            this.consultoriosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especialidadBindingSource
            // 
            this.especialidadBindingSource.DataMember = "Especialidad";
            this.especialidadBindingSource.DataSource = this.consultoriosDS;
            // 
            // especialidadTableAdapter
            // 
            this.especialidadTableAdapter.ClearBeforeFill = true;
            // 
            // medicosDS
            // 
            this.medicosDS.DataSetName = "MedicosDS";
            this.medicosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosProduccionBindingSource
            // 
            this.medicosProduccionBindingSource.DataMember = "MedicosProduccion";
            this.medicosProduccionBindingSource.DataSource = this.medicosDS;
            // 
            // medicosProduccionTableAdapter
            // 
            this.medicosProduccionTableAdapter.ClearBeforeFill = true;
            // 
            // frmProduccionMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 414);
            this.ControlBox = false;
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gdvProduccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbObservaciones);
            this.Controls.Add(this.cmbTurn);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCMP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFechActual);
            this.Name = "frmProduccionMedicos";
            this.Text = "Producción de Especialistas";
            this.Load += new System.EventHandler(this.frmProduccionMedicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosProduccionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIngData;
        private System.Windows.Forms.CheckBox chkConsulData;
        private System.Windows.Forms.DateTimePicker dtpFechActual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbTurn;
        private System.Windows.Forms.ComboBox cmbObservaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gdvProduccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn cConsultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTurn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cObserv;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
        private Dominio.Data.MedicosDS medicosDS;
        private System.Windows.Forms.BindingSource medicosProduccionBindingSource;
        private Dominio.Data.MedicosDSTableAdapters.MedicosProduccionTableAdapter medicosProduccionTableAdapter;
    }
}