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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCMP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.medicosProduccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosDS = new Polsolcom.Dominio.Data.MedicosDS();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grdProduccion = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.especialidadTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter();
            this.medicosProduccionTableAdapter = new Polsolcom.Dominio.Data.MedicosDSTableAdapters.MedicosProduccionTableAdapter();
            this.txtFechaActual = new System.Windows.Forms.MaskedTextBox();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.allProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosDS = new Polsolcom.Dominio.Data.ProductosDS();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.allProductsTableAdapter = new Polsolcom.Dominio.Data.ProductosDSTableAdapters.AllProductsTableAdapter();
            this.turnoTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TurnoTableAdapter();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pCorrelativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFechaSys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIdConsultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pConsultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosProduccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.rb1);
            this.panel1.Controls.Add(this.rb0);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 26);
            this.panel1.TabIndex = 3;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(367, 4);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(103, 17);
            this.rb1.TabIndex = 3;
            this.rb1.TabStop = true;
            this.rb1.Text = "Consulta data";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb0.Location = new System.Drawing.Point(235, 4);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(114, 17);
            this.rb0.TabIndex = 2;
            this.rb0.TabStop = true;
            this.rb0.Text = "Ingreso de data";
            this.rb0.UseVisualStyleBackColor = true;
            this.rb0.CheckedChanged += new System.EventHandler(this.rb0_CheckedChanged);
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
            this.txtCMP.Leave += new System.EventHandler(this.txtCMP_Leave);
            this.txtCMP.Validated += new System.EventHandler(this.txtCMP_Validated);
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
            this.cmbMedico.Size = new System.Drawing.Size(289, 21);
            this.cmbMedico.TabIndex = 9;
            this.cmbMedico.ValueMember = "CMP";
            this.cmbMedico.SelectionChangeCommitted += new System.EventHandler(this.cmbMedico_SelectionChangeCommitted);
            // 
            // medicosProduccionBindingSource
            // 
            this.medicosProduccionBindingSource.DataMember = "MedicosProduccion";
            this.medicosProduccionBindingSource.DataSource = this.medicosDS;
            // 
            // medicosDS
            // 
            this.medicosDS.DataSetName = "MedicosDS";
            this.medicosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DataSource = this.especialidadBindingSource;
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(519, 62);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(205, 21);
            this.cmbEspecialidad.TabIndex = 10;
            this.cmbEspecialidad.ValueMember = "Id_Consultorio";
            this.cmbEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cmbEspecialidad_SelectionChangeCommitted);
            // 
            // especialidadBindingSource
            // 
            this.especialidadBindingSource.DataMember = "Especialidad";
            this.especialidadBindingSource.DataSource = this.consultoriosDS;
            // 
            // consultoriosDS
            // 
            this.consultoriosDS.DataSetName = "ConsultoriosDS";
            this.consultoriosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(516, 46);
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
            // cmbTurno
            // 
            this.cmbTurno.DataSource = this.turnoBindingSource;
            this.cmbTurno.DisplayMember = "Descripcion";
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(333, 114);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(198, 21);
            this.cmbTurno.TabIndex = 18;
            this.cmbTurno.ValueMember = "Id_Tipo";
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "Turno";
            this.turnoBindingSource.DataSource = this.tablaTipoDS;
            // 
            // tablaTipoDS
            // 
            this.tablaTipoDS.DataSetName = "TablaTipoDS";
            this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(816, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha System";
            // 
            // grdProduccion
            // 
            this.grdProduccion.AllowUserToAddRows = false;
            this.grdProduccion.AllowUserToDeleteRows = false;
            this.grdProduccion.AllowUserToOrderColumns = true;
            this.grdProduccion.AllowUserToResizeColumns = false;
            this.grdProduccion.AllowUserToResizeRows = false;
            this.grdProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pCorrelativo,
            this.pFecha,
            this.pFechaSys,
            this.pUsuario,
            this.pCMP,
            this.pMedico,
            this.pIdConsultorio,
            this.pConsultorio,
            this.pIdProducto,
            this.pProducto,
            this.pCantidad,
            this.pPrecio,
            this.pMonto,
            this.pTurno,
            this.pObservacion});
            this.grdProduccion.Location = new System.Drawing.Point(12, 166);
            this.grdProduccion.MultiSelect = false;
            this.grdProduccion.Name = "grdProduccion";
            this.grdProduccion.RowHeadersVisible = false;
            this.grdProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProduccion.Size = new System.Drawing.Size(1043, 237);
            this.grdProduccion.TabIndex = 24;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(942, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Enabled = false;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(945, 33);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(111, 23);
            this.btnFiltrar.TabIndex = 26;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(945, 62);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 23);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "&Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(945, 91);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(111, 23);
            this.btnGrabar.TabIndex = 28;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(945, 120);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 23);
            this.btnBorrar.TabIndex = 29;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // especialidadTableAdapter
            // 
            this.especialidadTableAdapter.ClearBeforeFill = true;
            // 
            // medicosProduccionTableAdapter
            // 
            this.medicosProduccionTableAdapter.ClearBeforeFill = true;
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(818, 20);
            this.txtFechaActual.Mask = "00/00/0000";
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(90, 20);
            this.txtFechaActual.TabIndex = 31;
            this.txtFechaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFechaActual.ValidatingType = typeof(System.DateTime);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(13, 63);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(96, 20);
            this.txtFecha.TabIndex = 32;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            this.txtFecha.Leave += new System.EventHandler(this.txtFecha_Leave);
            this.txtFecha.Validated += new System.EventHandler(this.txtFecha_Validated);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DataSource = this.allProductsBindingSource;
            this.cmbProducto.DisplayMember = "Descripcion";
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(728, 63);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(209, 21);
            this.cmbProducto.TabIndex = 33;
            this.cmbProducto.ValueMember = "Id_Producto";
            this.cmbProducto.SelectionChangeCommitted += new System.EventHandler(this.cmbProducto_SelectionChangeCommitted);
            // 
            // allProductsBindingSource
            // 
            this.allProductsBindingSource.DataMember = "AllProducts";
            this.allProductsBindingSource.DataSource = this.productosDS;
            // 
            // productosDS
            // 
            this.productosDS.DataSetName = "ProductosDS";
            this.productosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(728, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Producto";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(536, 115);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(401, 20);
            this.txtObservacion.TabIndex = 35;
            // 
            // allProductsTableAdapter
            // 
            this.allProductsTableAdapter.ClearBeforeFill = true;
            // 
            // turnoTableAdapter
            // 
            this.turnoTableAdapter.ClearBeforeFill = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(15, 115);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 39;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(228, 115);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 40;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(120, 115);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 41;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // pCorrelativo
            // 
            this.pCorrelativo.HeaderText = "Correlativo";
            this.pCorrelativo.Name = "pCorrelativo";
            this.pCorrelativo.Visible = false;
            // 
            // pFecha
            // 
            this.pFecha.HeaderText = "Fecha";
            this.pFecha.Name = "pFecha";
            this.pFecha.Width = 60;
            // 
            // pFechaSys
            // 
            this.pFechaSys.HeaderText = "Fecha Sys";
            this.pFechaSys.Name = "pFechaSys";
            this.pFechaSys.Visible = false;
            // 
            // pUsuario
            // 
            this.pUsuario.HeaderText = "Usuario";
            this.pUsuario.Name = "pUsuario";
            this.pUsuario.Visible = false;
            // 
            // pCMP
            // 
            this.pCMP.HeaderText = "CMP";
            this.pCMP.Name = "pCMP";
            this.pCMP.Width = 60;
            // 
            // pMedico
            // 
            this.pMedico.HeaderText = "Medico";
            this.pMedico.Name = "pMedico";
            this.pMedico.Width = 180;
            // 
            // pIdConsultorio
            // 
            this.pIdConsultorio.HeaderText = "Id Consultorio";
            this.pIdConsultorio.Name = "pIdConsultorio";
            this.pIdConsultorio.Visible = false;
            // 
            // pConsultorio
            // 
            this.pConsultorio.HeaderText = "Consultorio";
            this.pConsultorio.Name = "pConsultorio";
            this.pConsultorio.Width = 180;
            // 
            // pIdProducto
            // 
            this.pIdProducto.HeaderText = "Id Producto";
            this.pIdProducto.Name = "pIdProducto";
            this.pIdProducto.Visible = false;
            // 
            // pProducto
            // 
            this.pProducto.HeaderText = "Producto";
            this.pProducto.Name = "pProducto";
            this.pProducto.Width = 180;
            // 
            // pCantidad
            // 
            this.pCantidad.HeaderText = "Cantidad";
            this.pCantidad.Name = "pCantidad";
            this.pCantidad.Width = 60;
            // 
            // pPrecio
            // 
            this.pPrecio.HeaderText = "Precio";
            this.pPrecio.Name = "pPrecio";
            this.pPrecio.Width = 60;
            // 
            // pMonto
            // 
            this.pMonto.HeaderText = "Monto";
            this.pMonto.Name = "pMonto";
            this.pMonto.Width = 60;
            // 
            // pTurno
            // 
            this.pTurno.HeaderText = "Turno";
            this.pTurno.Name = "pTurno";
            this.pTurno.Width = 60;
            // 
            // pObservacion
            // 
            this.pObservacion.HeaderText = "Observación";
            this.pObservacion.Name = "pObservacion";
            // 
            // frmProduccionMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 414);
            this.ControlBox = false;
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grdProduccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCMP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmProduccionMedicos";
            this.Text = "Producción de Especialistas";
            this.Load += new System.EventHandler(this.frmProduccionMedicos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduccionMedicos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosProduccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grdProduccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
        private Dominio.Data.MedicosDS medicosDS;
        private System.Windows.Forms.BindingSource medicosProduccionBindingSource;
        private Dominio.Data.MedicosDSTableAdapters.MedicosProduccionTableAdapter medicosProduccionTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtFechaActual;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.BindingSource allProductsBindingSource;
        private Dominio.Data.ProductosDS productosDS;
        private Dominio.Data.ProductosDSTableAdapters.AllProductsTableAdapter allProductsTableAdapter;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb0;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TurnoTableAdapter turnoTableAdapter;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCorrelativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFechaSys;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdConsultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn pConsultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn pObservacion;
    }
}