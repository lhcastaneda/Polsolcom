namespace Polsolcom.Forms.Herramientas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaT));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.txtApeMaterno = new System.Windows.Forms.TextBox();
			this.txtApePaterno = new System.Windows.Forms.TextBox();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFechaEmision = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbSerie = new System.Windows.Forms.ComboBox();
			this.cmbTDoc = new System.Windows.Forms.ComboBox();
			this.btnBuscarT = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.fGrid = new TenTec.Windows.iGridLib.iGrid();
			this.lblTicket = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDNI);
			this.groupBox1.Controls.Add(this.txtApeMaterno);
			this.groupBox1.Controls.Add(this.txtApePaterno);
			this.groupBox1.Controls.Add(this.txtNombres);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtFechaEmision);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmbEspecialidad);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbSerie);
			this.groupBox1.Controls.Add(this.cmbTDoc);
			this.groupBox1.ForeColor = System.Drawing.Color.Navy;
			this.groupBox1.Location = new System.Drawing.Point(3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(470, 91);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Seleccionar Uno o Mas Filtros para Realizar la Busqueda";
			// 
			// txtDNI
			// 
			this.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDNI.Location = new System.Drawing.Point(82, 29);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(71, 20);
			this.txtDNI.TabIndex = 1;
			this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
			this.txtDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaT_KeyDown);
			this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
			// 
			// txtApeMaterno
			// 
			this.txtApeMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApeMaterno.Location = new System.Drawing.Point(255, 29);
			this.txtApeMaterno.Name = "txtApeMaterno";
			this.txtApeMaterno.Size = new System.Drawing.Size(100, 20);
			this.txtApeMaterno.TabIndex = 3;
			this.txtApeMaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApeMaterno_KeyDown);
			// 
			// txtApePaterno
			// 
			this.txtApePaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApePaterno.Location = new System.Drawing.Point(154, 29);
			this.txtApePaterno.Name = "txtApePaterno";
			this.txtApePaterno.Size = new System.Drawing.Size(100, 20);
			this.txtApePaterno.TabIndex = 2;
			this.txtApePaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApePaterno_KeyDown);
			// 
			// txtNombres
			// 
			this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombres.Location = new System.Drawing.Point(356, 29);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(110, 20);
			this.txtNombres.TabIndex = 4;
			this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
			this.txtNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaT_KeyDown);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label14.Location = new System.Drawing.Point(98, 15);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(41, 13);
			this.label14.TabIndex = 36;
			this.label14.Text = "D.N.I.";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label12.Location = new System.Drawing.Point(270, 15);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(73, 13);
			this.label12.TabIndex = 35;
			this.label12.Text = "AP Materno";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label11.Location = new System.Drawing.Point(172, 15);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 13);
			this.label11.TabIndex = 34;
			this.label11.Text = "AP Paterno";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label10.Location = new System.Drawing.Point(384, 15);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 13);
			this.label10.TabIndex = 33;
			this.label10.Text = "Nombres";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(2, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 28;
			this.label4.Text = "Fecha Ticket";
			// 
			// txtFechaEmision
			// 
			this.txtFechaEmision.Culture = new System.Globalization.CultureInfo("es-PE");
			this.txtFechaEmision.Location = new System.Drawing.Point(5, 30);
			this.txtFechaEmision.Mask = "00/00/0000";
			this.txtFechaEmision.Name = "txtFechaEmision";
			this.txtFechaEmision.Size = new System.Drawing.Size(76, 20);
			this.txtFechaEmision.TabIndex = 0;
			this.txtFechaEmision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFechaEmision.ValidatingType = typeof(System.DateTime);
			this.txtFechaEmision.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.txtFechaEmision_TypeValidationCompleted);
			this.txtFechaEmision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaEmision_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(242, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 26;
			this.label2.Text = "Especialidad";
			// 
			// cmbEspecialidad
			// 
			this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEspecialidad.FormattingEnabled = true;
			this.cmbEspecialidad.Location = new System.Drawing.Point(173, 65);
			this.cmbEspecialidad.Name = "cmbEspecialidad";
			this.cmbEspecialidad.Size = new System.Drawing.Size(292, 21);
			this.cmbEspecialidad.Sorted = true;
			this.cmbEspecialidad.TabIndex = 7;
			this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
			this.cmbEspecialidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaT_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(27, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Serie";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(94, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Doc. Venta";
			// 
			// cmbSerie
			// 
			this.cmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSerie.FormattingEnabled = true;
			this.cmbSerie.Location = new System.Drawing.Point(5, 65);
			this.cmbSerie.Name = "cmbSerie";
			this.cmbSerie.Size = new System.Drawing.Size(80, 21);
			this.cmbSerie.Sorted = true;
			this.cmbSerie.TabIndex = 5;
			this.cmbSerie.SelectedIndexChanged += new System.EventHandler(this.cmbSerie_SelectedIndexChanged);
			this.cmbSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaT_KeyDown);
			// 
			// cmbTDoc
			// 
			this.cmbTDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTDoc.FormattingEnabled = true;
			this.cmbTDoc.Location = new System.Drawing.Point(87, 65);
			this.cmbTDoc.Name = "cmbTDoc";
			this.cmbTDoc.Size = new System.Drawing.Size(83, 21);
			this.cmbTDoc.Sorted = true;
			this.cmbTDoc.TabIndex = 6;
			this.cmbTDoc.SelectedIndexChanged += new System.EventHandler(this.cmbTDoc_SelectedIndexChanged);
			this.cmbTDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaT_KeyDown);
			// 
			// btnBuscarT
			// 
			this.btnBuscarT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarT.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarT.Image")));
			this.btnBuscarT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnBuscarT.Location = new System.Drawing.Point(476, 46);
			this.btnBuscarT.Name = "btnBuscarT";
			this.btnBuscarT.Size = new System.Drawing.Size(108, 42);
			this.btnBuscarT.TabIndex = 8;
			this.btnBuscarT.Text = "Buscar &Venta";
			this.btnBuscarT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBuscarT.UseVisualStyleBackColor = true;
			this.btnBuscarT.Click += new System.EventHandler(this.btnBuscarT_Click);
			this.btnBuscarT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaT_KeyDown);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(476, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 22);
			this.label5.TabIndex = 32;
			this.label5.Text = "ESTADO";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fGrid
			// 
			this.fGrid.DefaultAutoGroupRow.Height = 15;
			this.fGrid.DefaultRow.Height = 15;
			this.fGrid.DefaultRow.NormalCellHeight = 15;
			this.fGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fGrid.Header.Height = 17;
			this.fGrid.Location = new System.Drawing.Point(0, 95);
			this.fGrid.Name = "iGrid1";
			this.fGrid.Size = new System.Drawing.Size(585, 195);
			this.fGrid.TabIndex = 9;
			this.fGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaT_KeyDown);
			this.fGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fGrid_MouseDoubleClick);
			// 
			// lblTicket
			// 
			this.lblTicket.AutoSize = true;
			this.lblTicket.Location = new System.Drawing.Point(514, 7);
			this.lblTicket.Name = "lblTicket";
			this.lblTicket.Size = new System.Drawing.Size(0, 13);
			this.lblTicket.TabIndex = 33;
			this.lblTicket.Visible = false;
			// 
			// frmBuscaT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 291);
			this.ControlBox = false;
			this.Controls.Add(this.lblTicket);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnBuscarT);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.fGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmBuscaT";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Busqueda de Documentos de Venta";
			this.Load += new System.EventHandler(this.frmBuscaT_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaT_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbSerie;
		private System.Windows.Forms.ComboBox cmbTDoc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbEspecialidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox txtFechaEmision;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.TextBox txtApeMaterno;
		private System.Windows.Forms.TextBox txtApePaterno;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnBuscarT;
		private System.Windows.Forms.Label label5;
		private TenTec.Windows.iGridLib.iGrid fGrid;
		public System.Windows.Forms.Label lblTicket;
	}
}