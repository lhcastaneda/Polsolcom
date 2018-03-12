namespace Polsolcom.Forms
{
    partial class frmProductos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
			this.btnInicio = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.chkCons = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlBusqueda = new System.Windows.Forms.Panel();
			this.txtCriterio = new System.Windows.Forms.TextBox();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIdProducto = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbConsultorio = new System.Windows.Forms.ComboBox();
			this.consultoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbTPEsp = new System.Windows.Forms.ComboBox();
			this.tipoSubProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.estadoRegistroBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.cNomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cEstat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.lstCons = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.estadoRegistroTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.EstadoRegistroTableAdapter();
			this.consultoriosTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.ConsultoriosTableAdapter();
			this.tipoProductoTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TipoProductoTableAdapter();
			this.tipoSubProductoTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TipoSubProductoTableAdapter();
			this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.especialidadTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter();
			this.nudMonto = new System.Windows.Forms.NumericUpDown();
			this.pnlBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.consultoriosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoSubProductoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.estadoRegistroBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
			this.SuspendLayout();
			// 
			// btnInicio
			// 
			this.btnInicio.Enabled = false;
			this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
			this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnInicio.Location = new System.Drawing.Point(568, 2);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(60, 44);
			this.btnInicio.TabIndex = 0;
			this.btnInicio.Text = "&Inicio";
			this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnInicio.UseVisualStyleBackColor = true;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.Enabled = false;
			this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
			this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAnterior.Location = new System.Drawing.Point(630, 2);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(60, 44);
			this.btnAnterior.TabIndex = 1;
			this.btnAnterior.Text = "&Anterior";
			this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAnterior.UseVisualStyleBackColor = true;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
			this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSiguiente.Location = new System.Drawing.Point(692, 2);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(60, 44);
			this.btnSiguiente.TabIndex = 2;
			this.btnSiguiente.Text = "&Siguiente";
			this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSiguiente.UseVisualStyleBackColor = true;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnUltimo
			// 
			this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUltimo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
			this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnUltimo.Location = new System.Drawing.Point(754, 2);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(60, 44);
			this.btnUltimo.TabIndex = 3;
			this.btnUltimo.Text = "&Ultimo";
			this.btnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnUltimo.UseVisualStyleBackColor = true;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// chkCons
			// 
			this.chkCons.AutoSize = true;
			this.chkCons.Checked = true;
			this.chkCons.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkCons.ForeColor = System.Drawing.Color.DarkBlue;
			this.chkCons.Location = new System.Drawing.Point(4, 49);
			this.chkCons.Name = "chkCons";
			this.chkCons.Size = new System.Drawing.Size(154, 17);
			this.chkCons.TabIndex = 4;
			this.chkCons.Text = "&Todos los Consultorios";
			this.chkCons.UseVisualStyleBackColor = true;
			this.chkCons.CheckedChanged += new System.EventHandler(this.chkCons_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Ingrese Criterio de Búsqueda";
			// 
			// pnlBusqueda
			// 
			this.pnlBusqueda.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.pnlBusqueda.Controls.Add(this.txtCriterio);
			this.pnlBusqueda.Controls.Add(this.label1);
			this.pnlBusqueda.Location = new System.Drawing.Point(2, 2);
			this.pnlBusqueda.Name = "pnlBusqueda";
			this.pnlBusqueda.Size = new System.Drawing.Size(563, 44);
			this.pnlBusqueda.TabIndex = 7;
			// 
			// txtCriterio
			// 
			this.txtCriterio.Location = new System.Drawing.Point(4, 19);
			this.txtCriterio.Name = "txtCriterio";
			this.txtCriterio.Size = new System.Drawing.Size(555, 20);
			this.txtCriterio.TabIndex = 7;
			this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(110, 358);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(90, 44);
			this.btnNuevo.TabIndex = 8;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Location = new System.Drawing.Point(283, 358);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(90, 44);
			this.btnModificar.TabIndex = 9;
			this.btnModificar.Text = "&Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(456, 358);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(90, 44);
			this.btnEliminar.TabIndex = 10;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.Location = new System.Drawing.Point(629, 358);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(90, 44);
			this.btnSalir.TabIndex = 11;
			this.btnSalir.Text = "&Salir";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkBlue;
			this.label2.Location = new System.Drawing.Point(6, 283);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "ID Producto";
			// 
			// txtIdProducto
			// 
			this.txtIdProducto.Enabled = false;
			this.txtIdProducto.Location = new System.Drawing.Point(3, 297);
			this.txtIdProducto.Name = "txtIdProducto";
			this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
			this.txtIdProducto.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkBlue;
			this.label3.Location = new System.Drawing.Point(105, 283);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Nombre del Consultorio";
			// 
			// cmbConsultorio
			// 
			this.cmbConsultorio.DataSource = this.consultoriosBindingSource;
			this.cmbConsultorio.DisplayMember = "Descripcion";
			this.cmbConsultorio.Enabled = false;
			this.cmbConsultorio.FormattingEnabled = true;
			this.cmbConsultorio.Location = new System.Drawing.Point(103, 297);
			this.cmbConsultorio.Name = "cmbConsultorio";
			this.cmbConsultorio.Size = new System.Drawing.Size(330, 21);
			this.cmbConsultorio.TabIndex = 15;
			this.cmbConsultorio.ValueMember = "Id_Consultorio";
			// 
			// consultoriosBindingSource
			// 
			this.consultoriosBindingSource.DataMember = "Consultorios";
			this.consultoriosBindingSource.DataSource = this.consultoriosDS;
			// 
			// consultoriosDS
			// 
			this.consultoriosDS.DataSetName = "ConsultoriosDS";
			this.consultoriosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmbTipo
			// 
			this.cmbTipo.DataSource = this.tipoProductoBindingSource;
			this.cmbTipo.DisplayMember = "Descripcion";
			this.cmbTipo.Enabled = false;
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Location = new System.Drawing.Point(433, 297);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(190, 21);
			this.cmbTipo.TabIndex = 16;
			this.cmbTipo.ValueMember = "Id_Tipo";
			// 
			// tipoProductoBindingSource
			// 
			this.tipoProductoBindingSource.DataMember = "TipoProducto";
			this.tipoProductoBindingSource.DataSource = this.tablaTipoDS;
			// 
			// tablaTipoDS
			// 
			this.tablaTipoDS.DataSetName = "TablaTipoDS";
			this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkBlue;
			this.label4.Location = new System.Drawing.Point(435, 283);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Tipo de Producto";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkBlue;
			this.label5.Location = new System.Drawing.Point(625, 283);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Tipo Especial";
			// 
			// cmbTPEsp
			// 
			this.cmbTPEsp.DataSource = this.tipoSubProductoBindingSource;
			this.cmbTPEsp.DisplayMember = "Descripcion";
			this.cmbTPEsp.Enabled = false;
			this.cmbTPEsp.FormattingEnabled = true;
			this.cmbTPEsp.Location = new System.Drawing.Point(623, 297);
			this.cmbTPEsp.Name = "cmbTPEsp";
			this.cmbTPEsp.Size = new System.Drawing.Size(191, 21);
			this.cmbTPEsp.TabIndex = 19;
			this.cmbTPEsp.ValueMember = "Id_Tipo";
			// 
			// tipoSubProductoBindingSource
			// 
			this.tipoSubProductoBindingSource.DataMember = "TipoSubProducto";
			this.tipoSubProductoBindingSource.DataSource = this.tablaTipoDS;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkBlue;
			this.label6.Location = new System.Drawing.Point(5, 321);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(126, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Nombre del Producto";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Enabled = false;
			this.txtDescripcion.Location = new System.Drawing.Point(3, 335);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(481, 20);
			this.txtDescripcion.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DarkBlue;
			this.label7.Location = new System.Drawing.Point(489, 321);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "Precio";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.DarkBlue;
			this.label8.Location = new System.Drawing.Point(639, 321);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 13);
			this.label8.TabIndex = 24;
			this.label8.Text = "Estado";
			// 
			// cmbEstado
			// 
			this.cmbEstado.DataSource = this.estadoRegistroBindingSource;
			this.cmbEstado.DisplayMember = "Descripcion";
			this.cmbEstado.Enabled = false;
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Location = new System.Drawing.Point(635, 335);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(179, 21);
			this.cmbEstado.TabIndex = 25;
			this.cmbEstado.ValueMember = "Id_Tipo";
			// 
			// estadoRegistroBindingSource
			// 
			this.estadoRegistroBindingSource.DataMember = "EstadoRegistro";
			this.estadoRegistroBindingSource.DataSource = this.tablaTipoDS;
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.AllowUserToResizeColumns = false;
			this.dgvProductos.AllowUserToResizeRows = false;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNomProd,
            this.cTipo,
            this.cPrecio,
            this.cEstat});
			this.dgvProductos.Location = new System.Drawing.Point(272, 65);
			this.dgvProductos.MultiSelect = false;
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.RowHeadersVisible = false;
			this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductos.Size = new System.Drawing.Size(543, 215);
			this.dgvProductos.TabIndex = 26;
			this.dgvProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellEnter);
			this.dgvProductos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvProductos_CurrentCellDirtyStateChanged);
			// 
			// cNomProd
			// 
			this.cNomProd.HeaderText = "Nombre del Producto";
			this.cNomProd.Name = "cNomProd";
			this.cNomProd.ReadOnly = true;
			this.cNomProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cNomProd.Width = 280;
			// 
			// cTipo
			// 
			this.cTipo.HeaderText = "Tipo";
			this.cTipo.Name = "cTipo";
			this.cTipo.ReadOnly = true;
			this.cTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// cPrecio
			// 
			this.cPrecio.HeaderText = "Precio";
			this.cPrecio.Name = "cPrecio";
			this.cPrecio.ReadOnly = true;
			this.cPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cPrecio.Width = 80;
			// 
			// cEstat
			// 
			this.cEstat.HeaderText = "Estado";
			this.cEstat.Name = "cEstat";
			this.cEstat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.cEstat.Width = 60;
			// 
			// lstCons
			// 
			this.lstCons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lstCons.Enabled = false;
			this.lstCons.FullRowSelect = true;
			this.lstCons.HideSelection = false;
			this.lstCons.Location = new System.Drawing.Point(3, 65);
			this.lstCons.Name = "lstCons";
			this.lstCons.Size = new System.Drawing.Size(267, 215);
			this.lstCons.TabIndex = 38;
			this.lstCons.UseCompatibleStateImageBehavior = false;
			this.lstCons.View = System.Windows.Forms.View.Details;
			this.lstCons.SelectedIndexChanged += new System.EventHandler(this.lstConsultorios_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Descripción";
			this.columnHeader1.Width = 250;
			// 
			// estadoRegistroTableAdapter
			// 
			this.estadoRegistroTableAdapter.ClearBeforeFill = true;
			// 
			// consultoriosTableAdapter
			// 
			this.consultoriosTableAdapter.ClearBeforeFill = true;
			// 
			// tipoProductoTableAdapter
			// 
			this.tipoProductoTableAdapter.ClearBeforeFill = true;
			// 
			// tipoSubProductoTableAdapter
			// 
			this.tipoSubProductoTableAdapter.ClearBeforeFill = true;
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
			// nudMonto
			// 
			this.nudMonto.DecimalPlaces = 2;
			this.nudMonto.Enabled = false;
			this.nudMonto.Location = new System.Drawing.Point(486, 335);
			this.nudMonto.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.nudMonto.Name = "nudMonto";
			this.nudMonto.Size = new System.Drawing.Size(147, 20);
			this.nudMonto.TabIndex = 40;
			// 
			// frmProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(817, 405);
			this.ControlBox = false;
			this.Controls.Add(this.nudMonto);
			this.Controls.Add(this.lstCons);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.cmbEstado);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbTPEsp);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.cmbConsultorio);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIdProducto);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.pnlBusqueda);
			this.Controls.Add(this.chkCons);
			this.Controls.Add(this.btnUltimo);
			this.Controls.Add(this.btnSiguiente);
			this.Controls.Add(this.btnAnterior);
			this.Controls.Add(this.btnInicio);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "frmProductos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Productos";
			this.Load += new System.EventHandler(this.frmProductos_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductos_KeyDown);
			this.pnlBusqueda.ResumeLayout(false);
			this.pnlBusqueda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.consultoriosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoSubProductoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.estadoRegistroBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.CheckBox chkCons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTPEsp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ListView lstCons;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource estadoRegistroBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.EstadoRegistroTableAdapter estadoRegistroTableAdapter;
        private System.Windows.Forms.BindingSource consultoriosBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.ConsultoriosTableAdapter consultoriosTableAdapter;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TipoProductoTableAdapter tipoProductoTableAdapter;
        private System.Windows.Forms.BindingSource tipoSubProductoBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TipoSubProductoTableAdapter tipoSubProductoTableAdapter;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cEstat;
        private System.Windows.Forms.NumericUpDown nudMonto;
    }
}