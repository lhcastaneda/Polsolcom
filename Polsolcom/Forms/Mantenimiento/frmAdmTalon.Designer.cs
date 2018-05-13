namespace Polsolcom.Forms
{
    partial class frmAdmTalon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmTalon));
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnCortar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnRecrear = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbOperativo = new System.Windows.Forms.ComboBox();
			this.operativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.operativos = new Polsolcom.Dominio.Data.Operativos();
			this.cmbUsuario = new System.Windows.Forms.ComboBox();
			this.cmbDVenta = new System.Windows.Forms.ComboBox();
			this.docVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpFFinal = new System.Windows.Forms.DateTimePicker();
			this.dtpicFInicial = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnFiltro = new System.Windows.Forms.Button();
			this.txtNCon = new System.Windows.Forms.MaskedTextBox();
			this.txtNFinal = new System.Windows.Forms.MaskedTextBox();
			this.txtNInicial = new System.Windows.Forms.MaskedTextBox();
			this.txtSerie = new System.Windows.Forms.MaskedTextBox();
			this.lstRangos = new System.Windows.Forms.ListView();
			this.cUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cFechayHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cDocVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cSerie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cNInicial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cNFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cActual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cOper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.operativoTableAdapter = new Polsolcom.Dominio.Data.OperativosTableAdapters.OperativoTableAdapter();
			this.docVentaTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.DocVentaTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.operativoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.operativos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.docVentaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(223, 7);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(80, 30);
			this.btnNuevo.TabIndex = 8;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Enabled = false;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(302, 7);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(80, 30);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.Text = "&Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnCortar
			// 
			this.btnCortar.Enabled = false;
			this.btnCortar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCortar.Image = ((System.Drawing.Image)(resources.GetObject("btnCortar.Image")));
			this.btnCortar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCortar.Location = new System.Drawing.Point(381, 7);
			this.btnCortar.Name = "btnCortar";
			this.btnCortar.Size = new System.Drawing.Size(80, 30);
			this.btnCortar.TabIndex = 10;
			this.btnCortar.Text = "&Cortar";
			this.btnCortar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCortar.UseVisualStyleBackColor = true;
			this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(460, 7);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 30);
			this.btnEliminar.TabIndex = 11;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnRecrear
			// 
			this.btnRecrear.Enabled = false;
			this.btnRecrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRecrear.Image = ((System.Drawing.Image)(resources.GetObject("btnRecrear.Image")));
			this.btnRecrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRecrear.Location = new System.Drawing.Point(620, 7);
			this.btnRecrear.Name = "btnRecrear";
			this.btnRecrear.Size = new System.Drawing.Size(80, 30);
			this.btnRecrear.TabIndex = 12;
			this.btnRecrear.Text = "&Recrear";
			this.btnRecrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRecrear.UseVisualStyleBackColor = true;
			this.btnRecrear.Visible = false;
			this.btnRecrear.Click += new System.EventHandler(this.btnRecrear_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Enabled = false;
			this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
			this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImprimir.Location = new System.Drawing.Point(539, 7);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(80, 30);
			this.btnImprimir.TabIndex = 0;
			this.btnImprimir.Text = "&Imprimir";
			this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(285, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 13);
			this.label6.TabIndex = 6;
			// 
			// cmbOperativo
			// 
			this.cmbOperativo.DataSource = this.operativoBindingSource;
			this.cmbOperativo.DisplayMember = "Descripcion";
			this.cmbOperativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOperativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbOperativo.FormattingEnabled = true;
			this.cmbOperativo.Location = new System.Drawing.Point(4, 18);
			this.cmbOperativo.Name = "cmbOperativo";
			this.cmbOperativo.Size = new System.Drawing.Size(145, 21);
			this.cmbOperativo.TabIndex = 0;
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
			// cmbUsuario
			// 
			this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbUsuario.FormattingEnabled = true;
			this.cmbUsuario.Location = new System.Drawing.Point(4, 18);
			this.cmbUsuario.Name = "cmbUsuario";
			this.cmbUsuario.Size = new System.Drawing.Size(108, 21);
			this.cmbUsuario.TabIndex = 0;
			this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
			// 
			// cmbDVenta
			// 
			this.cmbDVenta.DataSource = this.docVentaBindingSource;
			this.cmbDVenta.DisplayMember = "Descripcion";
			this.cmbDVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbDVenta.FormattingEnabled = true;
			this.cmbDVenta.Location = new System.Drawing.Point(4, 18);
			this.cmbDVenta.Name = "cmbDVenta";
			this.cmbDVenta.Size = new System.Drawing.Size(93, 21);
			this.cmbDVenta.TabIndex = 1;
			this.cmbDVenta.ValueMember = "Id_Tipo";
			this.cmbDVenta.SelectedIndexChanged += new System.EventHandler(this.cmbDVenta_SelectedIndexChanged);
			// 
			// docVentaBindingSource
			// 
			this.docVentaBindingSource.DataMember = "DocVenta";
			this.docVentaBindingSource.DataSource = this.tablaTipoDS;
			// 
			// tablaTipoDS
			// 
			this.tablaTipoDS.DataSetName = "TablaTipoDS";
			this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpFFinal);
			this.groupBox1.Controls.Add(this.dtpicFInicial);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
			this.groupBox1.Location = new System.Drawing.Point(3, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(214, 42);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rango de Fecha";
			// 
			// dtpFFinal
			// 
			this.dtpFFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFFinal.Location = new System.Drawing.Point(111, 16);
			this.dtpFFinal.Name = "dtpFFinal";
			this.dtpFFinal.Size = new System.Drawing.Size(98, 20);
			this.dtpFFinal.TabIndex = 1;
			this.dtpFFinal.Value = new System.DateTime(2017, 4, 8, 9, 44, 33, 0);
			this.dtpFFinal.ValueChanged += new System.EventHandler(this.dtpFFinal_ValueChanged);
			// 
			// dtpicFInicial
			// 
			this.dtpicFInicial.Checked = false;
			this.dtpicFInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpicFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpicFInicial.Location = new System.Drawing.Point(6, 16);
			this.dtpicFInicial.Name = "dtpicFInicial";
			this.dtpicFInicial.Size = new System.Drawing.Size(97, 20);
			this.dtpicFInicial.TabIndex = 0;
			this.dtpicFInicial.ValueChanged += new System.EventHandler(this.dtpicFInicial_ValueChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbOperativo);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(3, 42);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(153, 45);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Operativo";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbUsuario);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(156, 42);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(116, 45);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Usuario";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnFiltro);
			this.groupBox4.Controls.Add(this.txtNCon);
			this.groupBox4.Controls.Add(this.txtNFinal);
			this.groupBox4.Controls.Add(this.txtNInicial);
			this.groupBox4.Controls.Add(this.txtSerie);
			this.groupBox4.Controls.Add(this.cmbDVenta);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(272, 42);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(425, 45);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Rango de documento de venta";
			// 
			// btnFiltro
			// 
			this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltro.Image")));
			this.btnFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFiltro.Location = new System.Drawing.Point(348, 11);
			this.btnFiltro.Name = "btnFiltro";
			this.btnFiltro.Size = new System.Drawing.Size(74, 30);
			this.btnFiltro.TabIndex = 5;
			this.btnFiltro.Text = "Filtrar";
			this.btnFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFiltro.UseVisualStyleBackColor = true;
			this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
			// 
			// txtNCon
			// 
			this.txtNCon.Location = new System.Drawing.Point(274, 18);
			this.txtNCon.Mask = "999999999";
			this.txtNCon.Name = "txtNCon";
			this.txtNCon.ReadOnly = true;
			this.txtNCon.Size = new System.Drawing.Size(70, 20);
			this.txtNCon.TabIndex = 0;
			this.txtNCon.Text = "0";
			this.txtNCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNCon.Leave += new System.EventHandler(this.txtNCon_Leave);
			// 
			// txtNFinal
			// 
			this.txtNFinal.Location = new System.Drawing.Point(200, 18);
			this.txtNFinal.Mask = "999999999";
			this.txtNFinal.Name = "txtNFinal";
			this.txtNFinal.ReadOnly = true;
			this.txtNFinal.Size = new System.Drawing.Size(70, 20);
			this.txtNFinal.TabIndex = 4;
			this.txtNFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNInicial
			// 
			this.txtNInicial.Location = new System.Drawing.Point(128, 18);
			this.txtNInicial.Mask = "999999999";
			this.txtNInicial.Name = "txtNInicial";
			this.txtNInicial.ReadOnly = true;
			this.txtNInicial.Size = new System.Drawing.Size(70, 20);
			this.txtNInicial.TabIndex = 3;
			this.txtNInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSerie
			// 
			this.txtSerie.Location = new System.Drawing.Point(99, 18);
			this.txtSerie.Mask = "999";
			this.txtSerie.Name = "txtSerie";
			this.txtSerie.ReadOnly = true;
			this.txtSerie.Size = new System.Drawing.Size(28, 20);
			this.txtSerie.TabIndex = 2;
			this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lstRangos
			// 
			this.lstRangos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cUser,
            this.cFechayHora,
            this.cDocVenta,
            this.cSerie,
            this.cNInicial,
            this.cNFinal,
            this.cActual,
            this.cOper});
			this.lstRangos.FullRowSelect = true;
			this.lstRangos.Location = new System.Drawing.Point(7, 89);
			this.lstRangos.MultiSelect = false;
			this.lstRangos.Name = "lstRangos";
			this.lstRangos.Size = new System.Drawing.Size(688, 328);
			this.lstRangos.TabIndex = 7;
			this.lstRangos.UseCompatibleStateImageBehavior = false;
			this.lstRangos.View = System.Windows.Forms.View.Details;
			this.lstRangos.SelectedIndexChanged += new System.EventHandler(this.lstRangos_SelectedIndexChanged);
			// 
			// cUser
			// 
			this.cUser.Text = "Usuario";
			this.cUser.Width = 90;
			// 
			// cFechayHora
			// 
			this.cFechayHora.Text = "Fecha y Hora";
			this.cFechayHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cFechayHora.Width = 115;
			// 
			// cDocVenta
			// 
			this.cDocVenta.Text = "Doc. Venta";
			this.cDocVenta.Width = 90;
			// 
			// cSerie
			// 
			this.cSerie.Text = "Serie";
			this.cSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cSerie.Width = 45;
			// 
			// cNInicial
			// 
			this.cNInicial.Text = "N° Inicial";
			this.cNInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.cNInicial.Width = 55;
			// 
			// cNFinal
			// 
			this.cNFinal.Text = "N° Final";
			this.cNFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.cNFinal.Width = 55;
			// 
			// cActual
			// 
			this.cActual.Text = "N° Actual";
			this.cActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// cOper
			// 
			this.cOper.Text = "Operativo";
			this.cOper.Width = 145;
			// 
			// operativoTableAdapter
			// 
			this.operativoTableAdapter.ClearBeforeFill = true;
			// 
			// docVentaTableAdapter
			// 
			this.docVentaTableAdapter.ClearBeforeFill = true;
			// 
			// frmAdmTalon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(700, 421);
			this.ControlBox = false;
			this.Controls.Add(this.lstRangos);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnRecrear);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCortar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "frmAdmTalon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Administracion de Talonarios de Documentos de Ventas";
			this.Load += new System.EventHandler(this.frmAdmTalon_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdmTalon_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.operativoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.operativos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.docVentaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRecrear;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOperativo;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbDVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpFFinal;
        private System.Windows.Forms.DateTimePicker dtpicFInicial;
        private System.Windows.Forms.ListView lstRangos;
        private System.Windows.Forms.ColumnHeader cUser;
        private System.Windows.Forms.ColumnHeader cFechayHora;
        private System.Windows.Forms.ColumnHeader cDocVenta;
        private System.Windows.Forms.ColumnHeader cSerie;
        private System.Windows.Forms.ColumnHeader cNInicial;
        private System.Windows.Forms.ColumnHeader cNFinal;
        private System.Windows.Forms.ColumnHeader cActual;
        private System.Windows.Forms.ColumnHeader cOper;
        private Dominio.Data.Operativos operativos;
        private System.Windows.Forms.BindingSource operativoBindingSource;
        private Dominio.Data.OperativosTableAdapters.OperativoTableAdapter operativoTableAdapter;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource docVentaBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.DocVentaTableAdapter docVentaTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtNCon;
        private System.Windows.Forms.MaskedTextBox txtNFinal;
        private System.Windows.Forms.MaskedTextBox txtNInicial;
        private System.Windows.Forms.MaskedTextBox txtSerie;
		private System.Windows.Forms.Button btnFiltro;
	}
}