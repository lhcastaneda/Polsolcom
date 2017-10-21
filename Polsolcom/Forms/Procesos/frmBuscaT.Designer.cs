namespace Polsolcom.Forms.Procesos
{
	partial class frmBuscaT
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && (components != null) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.MaskedTextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaEmision = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lstBuscar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNroTicket);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.txtApeMaterno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApePaterno);
            this.groupBox1.Controls.Add(this.cmbEspecialidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFechaEmision);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Uno o Mas Filtros para Realizar la Busqueda";
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.Location = new System.Drawing.Point(81, 29);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.Size = new System.Drawing.Size(89, 20);
            this.txtNroTicket.TabIndex = 4;
            this.txtNroTicket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNroTicket_KeyDown);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(4, 32);
            this.txtSerie.Mask = "9999";
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(68, 20);
            this.txtSerie.TabIndex = 3;
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeMaterno.Location = new System.Drawing.Point(253, 68);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApeMaterno.TabIndex = 12;
            this.txtApeMaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApeMaterno_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especialidad";
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApePaterno.Location = new System.Drawing.Point(152, 68);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApePaterno.TabIndex = 11;
            this.txtApePaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApePaterno_KeyDown);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DataSource = this.especialidadBindingSource;
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(172, 29);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(292, 21);
            this.cmbEspecialidad.TabIndex = 5;
            this.cmbEspecialidad.ValueMember = "Id_Consultorio";
            this.cmbEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cmbEspecialidad_SelectionChangeCommitted);
            this.cmbEspecialidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEspecialidad_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(354, 68);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(110, 20);
            this.txtNombres.TabIndex = 13;
            this.txtNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombres_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doc. Venta";
            // 
            // txtFechaEmision
            // 
            this.txtFechaEmision.Location = new System.Drawing.Point(3, 69);
            this.txtFechaEmision.Mask = "00/00/0000";
            this.txtFechaEmision.Name = "txtFechaEmision";
            this.txtFechaEmision.ReadOnly = true;
            this.txtFechaEmision.Size = new System.Drawing.Size(76, 20);
            this.txtFechaEmision.TabIndex = 10;
            this.txtFechaEmision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaEmision.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(268, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "AP Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Ticket";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(382, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(170, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "AP Paterno";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(476, 27);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 36);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaT_KeyDown);
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Navy;
            this.lblEstado.Location = new System.Drawing.Point(476, 6);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(107, 22);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "ESTADO";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(514, 7);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(0, 13);
            this.lblTicket.TabIndex = 3;
            this.lblTicket.Visible = false;
            // 
            // lstBuscar
            // 
            this.lstBuscar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstBuscar.FullRowSelect = true;
            this.lstBuscar.Location = new System.Drawing.Point(3, 96);
            this.lstBuscar.MultiSelect = false;
            this.lstBuscar.Name = "lstBuscar";
            this.lstBuscar.Size = new System.Drawing.Size(582, 191);
            this.lstBuscar.TabIndex = 1;
            this.lstBuscar.UseCompatibleStateImageBehavior = false;
            this.lstBuscar.View = System.Windows.Forms.View.Details;
            this.lstBuscar.SelectedIndexChanged += new System.EventHandler(this.lstBuscar_SelectedIndexChanged);
            this.lstBuscar.DoubleClick += new System.EventHandler(this.lstBuscar_DoubleClick);
            this.lstBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstBuscar_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Consultorio";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Paciente";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "N° Recibo";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id Paciente";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha";
            this.columnHeader5.Width = 80;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(475, 67);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // frmBuscaT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 294);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lstBuscar);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBuscaT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda de Documentos de Venta";
            this.Load += new System.EventHandler(this.frmBuscaT_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaT_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbEspecialidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox txtFechaEmision;
		private System.Windows.Forms.TextBox txtApeMaterno;
		private System.Windows.Forms.TextBox txtApePaterno;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblEstado;
		public System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.TextBox txtNroTicket;
        private System.Windows.Forms.MaskedTextBox txtSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstBuscar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
    }
}