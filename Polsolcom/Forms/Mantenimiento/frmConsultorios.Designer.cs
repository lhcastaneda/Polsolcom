namespace Polsolcom.Forms
{
    partial class frmConsultorios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultorios));
			this.chkEstado = new System.Windows.Forms.CheckBox();
			this.cmbEst = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.btnInicio = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnFin = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.estadoRegistroBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.modalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.modalidadDS = new Polsolcom.Dominio.Data.ModalidadDS();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCreacion = new System.Windows.Forms.TextBox();
			this.txtLastUpdate = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.lstTurnos = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lstBuses = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.edtDescripcion = new System.Windows.Forms.TextBox();
			this.lstConsultorios = new System.Windows.Forms.ListView();
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panelEspecialidad = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.modalidadTableAdapter = new Polsolcom.Dominio.Data.ModalidadDSTableAdapters.ModalidadTableAdapter();
			this.estadoRegistroTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.EstadoRegistroTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.estadoRegistroBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.modalidadBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.modalidadDS)).BeginInit();
			this.panelEspecialidad.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkEstado
			// 
			this.chkEstado.AutoSize = true;
			this.chkEstado.Checked = true;
			this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkEstado.Location = new System.Drawing.Point(8, 8);
			this.chkEstado.Name = "chkEstado";
			this.chkEstado.Size = new System.Drawing.Size(130, 17);
			this.chkEstado.TabIndex = 0;
			this.chkEstado.Text = "Todos los Estados";
			this.chkEstado.UseVisualStyleBackColor = true;
			this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
			// 
			// cmbEst
			// 
			this.cmbEst.DisplayMember = "Id_Tipo";
			this.cmbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEst.Enabled = false;
			this.cmbEst.FormattingEnabled = true;
			this.cmbEst.Location = new System.Drawing.Point(136, 6);
			this.cmbEst.Name = "cmbEst";
			this.cmbEst.Size = new System.Drawing.Size(141, 21);
			this.cmbEst.TabIndex = 2;
			this.cmbEst.ValueMember = "Id_Tipo";
			this.cmbEst.SelectionChangeCommitted += new System.EventHandler(this.cmbEst_SelectionChangeCommitted);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nombre de la especialidad";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Enabled = false;
			this.txtDescripcion.Location = new System.Drawing.Point(6, 21);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(277, 20);
			this.txtDescripcion.TabIndex = 4;
			// 
			// btnInicio
			// 
			this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
			this.btnInicio.Location = new System.Drawing.Point(5, 454);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(64, 44);
			this.btnInicio.TabIndex = 6;
			this.btnInicio.UseVisualStyleBackColor = true;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
			this.btnAnterior.Location = new System.Drawing.Point(74, 454);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(64, 44);
			this.btnAnterior.TabIndex = 7;
			this.btnAnterior.UseVisualStyleBackColor = true;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
			this.btnSiguiente.Location = new System.Drawing.Point(143, 454);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(64, 44);
			this.btnSiguiente.TabIndex = 8;
			this.btnSiguiente.UseVisualStyleBackColor = true;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnFin
			// 
			this.btnFin.Image = ((System.Drawing.Image)(resources.GetObject("btnFin.Image")));
			this.btnFin.Location = new System.Drawing.Point(212, 454);
			this.btnFin.Name = "btnFin";
			this.btnFin.Size = new System.Drawing.Size(64, 44);
			this.btnFin.TabIndex = 9;
			this.btnFin.UseVisualStyleBackColor = true;
			this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(4, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Estado";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(140, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Modalidad";
			// 
			// cmbEstado
			// 
			this.cmbEstado.DataSource = this.estadoRegistroBindingSource;
			this.cmbEstado.DisplayMember = "Descripcion";
			this.cmbEstado.Enabled = false;
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Location = new System.Drawing.Point(6, 60);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(133, 21);
			this.cmbEstado.TabIndex = 12;
			this.cmbEstado.ValueMember = "Id_Tipo";
			// 
			// estadoRegistroBindingSource
			// 
			this.estadoRegistroBindingSource.DataMember = "EstadoRegistro";
			this.estadoRegistroBindingSource.DataSource = this.tablaTipoDS;
			// 
			// tablaTipoDS
			// 
			this.tablaTipoDS.DataSetName = "TablaTipoDS";
			this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmbTipo
			// 
			this.cmbTipo.DataSource = this.modalidadBindingSource;
			this.cmbTipo.DisplayMember = "Descripcion";
			this.cmbTipo.Enabled = false;
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Location = new System.Drawing.Point(144, 60);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(138, 21);
			this.cmbTipo.TabIndex = 13;
			this.cmbTipo.ValueMember = "Id_Tipo";
			// 
			// modalidadBindingSource
			// 
			this.modalidadBindingSource.DataMember = "Modalidad";
			this.modalidadBindingSource.DataSource = this.modalidadDS;
			// 
			// modalidadDS
			// 
			this.modalidadDS.DataSetName = "ModalidadDS";
			this.modalidadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(4, 164);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(247, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Información descriptiva de la Especialidad";
			// 
			// txtCreacion
			// 
			this.txtCreacion.Enabled = false;
			this.txtCreacion.Location = new System.Drawing.Point(6, 250);
			this.txtCreacion.Name = "txtCreacion";
			this.txtCreacion.Size = new System.Drawing.Size(127, 20);
			this.txtCreacion.TabIndex = 21;
			this.txtCreacion.Text = "CREATION";
			// 
			// txtLastUpdate
			// 
			this.txtLastUpdate.Enabled = false;
			this.txtLastUpdate.Location = new System.Drawing.Point(147, 250);
			this.txtLastUpdate.Name = "txtLastUpdate";
			this.txtLastUpdate.Size = new System.Drawing.Size(135, 20);
			this.txtLastUpdate.TabIndex = 22;
			this.txtLastUpdate.Text = "LAST UPDATE";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(4, 7);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(263, 13);
			this.label11.TabIndex = 25;
			this.label11.Text = "Consultorios de la Especialidad seleccionada";
			// 
			// btnEditar
			// 
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Location = new System.Drawing.Point(10, 144);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(86, 24);
			this.btnEditar.TabIndex = 26;
			this.btnEditar.Text = "E&ditar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(101, 144);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(86, 24);
			this.btnAgregar.TabIndex = 27;
			this.btnAgregar.Text = "&Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnQuitar
			// 
			this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuitar.Location = new System.Drawing.Point(192, 144);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(86, 24);
			this.btnQuitar.TabIndex = 28;
			this.btnQuitar.Text = "&Quitar";
			this.btnQuitar.UseVisualStyleBackColor = true;
			this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnNuevo.Location = new System.Drawing.Point(298, 454);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(82, 44);
			this.btnNuevo.TabIndex = 29;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.AccessibleDescription = "Modificar";
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnModificar.Location = new System.Drawing.Point(386, 454);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(82, 44);
			this.btnModificar.TabIndex = 30;
			this.btnModificar.Text = "&Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEliminar.Location = new System.Drawing.Point(474, 454);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(82, 44);
			this.btnEliminar.TabIndex = 31;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// lstTurnos
			// 
			this.lstTurnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lstTurnos.FullRowSelect = true;
			this.lstTurnos.Location = new System.Drawing.Point(6, 84);
			this.lstTurnos.Name = "lstTurnos";
			this.lstTurnos.Size = new System.Drawing.Size(277, 77);
			this.lstTurnos.TabIndex = 33;
			this.lstTurnos.UseCompatibleStateImageBehavior = false;
			this.lstTurnos.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Criterio";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mañana";
			this.columnHeader2.Width = 50;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tarde";
			this.columnHeader3.Width = 50;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Noche";
			this.columnHeader4.Width = 50;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Madrugada";
			this.columnHeader5.Width = 50;
			// 
			// lstBuses
			// 
			this.lstBuses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.lstBuses.FullRowSelect = true;
			this.lstBuses.Location = new System.Drawing.Point(5, 24);
			this.lstBuses.MultiSelect = false;
			this.lstBuses.Name = "lstBuses";
			this.lstBuses.Size = new System.Drawing.Size(278, 118);
			this.lstBuses.TabIndex = 34;
			this.lstBuses.UseCompatibleStateImageBehavior = false;
			this.lstBuses.View = System.Windows.Forms.View.Details;
			this.lstBuses.Enter += new System.EventHandler(this.lstBuses_Enter);
			this.lstBuses.Validated += new System.EventHandler(this.lstBuses_Validated);
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Consultorio";
			this.columnHeader6.Width = 90;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Tur";
			this.columnHeader7.Width = 30;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Fecha";
			this.columnHeader8.Width = 70;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "-";
			this.columnHeader9.Width = 70;
			// 
			// edtDescripcion
			// 
			this.edtDescripcion.Location = new System.Drawing.Point(6, 179);
			this.edtDescripcion.Multiline = true;
			this.edtDescripcion.Name = "edtDescripcion";
			this.edtDescripcion.Size = new System.Drawing.Size(277, 67);
			this.edtDescripcion.TabIndex = 35;
			// 
			// lstConsultorios
			// 
			this.lstConsultorios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
			this.lstConsultorios.FullRowSelect = true;
			this.lstConsultorios.Location = new System.Drawing.Point(5, 31);
			this.lstConsultorios.MultiSelect = false;
			this.lstConsultorios.Name = "lstConsultorios";
			this.lstConsultorios.Size = new System.Drawing.Size(273, 421);
			this.lstConsultorios.TabIndex = 36;
			this.lstConsultorios.UseCompatibleStateImageBehavior = false;
			this.lstConsultorios.View = System.Windows.Forms.View.Details;
			this.lstConsultorios.SelectedIndexChanged += new System.EventHandler(this.lstConsultorios_SelectedIndexChanged);
			this.lstConsultorios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstConsultorios_KeyDown);
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Descripción";
			this.columnHeader11.Width = 194;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "ID";
			this.columnHeader12.Width = 65;
			// 
			// panelEspecialidad
			// 
			this.panelEspecialidad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panelEspecialidad.Controls.Add(this.lstTurnos);
			this.panelEspecialidad.Controls.Add(this.label2);
			this.panelEspecialidad.Controls.Add(this.edtDescripcion);
			this.panelEspecialidad.Controls.Add(this.txtDescripcion);
			this.panelEspecialidad.Controls.Add(this.label3);
			this.panelEspecialidad.Controls.Add(this.label4);
			this.panelEspecialidad.Controls.Add(this.cmbEstado);
			this.panelEspecialidad.Controls.Add(this.cmbTipo);
			this.panelEspecialidad.Controls.Add(this.label5);
			this.panelEspecialidad.Controls.Add(this.txtCreacion);
			this.panelEspecialidad.Controls.Add(this.txtLastUpdate);
			this.panelEspecialidad.Location = new System.Drawing.Point(283, 4);
			this.panelEspecialidad.Name = "panelEspecialidad";
			this.panelEspecialidad.Size = new System.Drawing.Size(287, 274);
			this.panelEspecialidad.TabIndex = 37;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel2.Controls.Add(this.lstBuses);
			this.panel2.Controls.Add(this.btnEditar);
			this.panel2.Controls.Add(this.btnAgregar);
			this.panel2.Controls.Add(this.btnQuitar);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Location = new System.Drawing.Point(283, 278);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(287, 174);
			this.panel2.TabIndex = 38;
			// 
			// modalidadTableAdapter
			// 
			this.modalidadTableAdapter.ClearBeforeFill = true;
			// 
			// estadoRegistroTableAdapter
			// 
			this.estadoRegistroTableAdapter.ClearBeforeFill = true;
			// 
			// frmConsultorios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 500);
			this.ControlBox = false;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelEspecialidad);
			this.Controls.Add(this.lstConsultorios);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnFin);
			this.Controls.Add(this.btnSiguiente);
			this.Controls.Add(this.btnAnterior);
			this.Controls.Add(this.btnInicio);
			this.Controls.Add(this.cmbEst);
			this.Controls.Add(this.chkEstado);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "frmConsultorios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Especialidades y Consultorios";
			this.Load += new System.EventHandler(this.frmConsultorios_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultorios_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.estadoRegistroBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.modalidadBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.modalidadDS)).EndInit();
			this.panelEspecialidad.ResumeLayout(false);
			this.panelEspecialidad.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.ComboBox cmbEst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCreacion;
        private System.Windows.Forms.TextBox txtLastUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListView lstTurnos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lstBuses;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox edtDescripcion;
        private System.Windows.Forms.ListView lstConsultorios;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Panel panelEspecialidad;
        private System.Windows.Forms.Panel panel2;
        private Dominio.Data.ModalidadDS modalidadDS;
        private System.Windows.Forms.BindingSource modalidadBindingSource;
        private Dominio.Data.ModalidadDSTableAdapters.ModalidadTableAdapter modalidadTableAdapter;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource estadoRegistroBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.EstadoRegistroTableAdapter estadoRegistroTableAdapter;
    }
}