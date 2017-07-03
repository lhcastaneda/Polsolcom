namespace Polsolcom.Forms
{
	partial class frmGenEtareo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenEtareo));
            this.fGrid = new TenTec.Windows.iGridLib.iGrid();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.optCircular = new System.Windows.Forms.RadioButton();
            this.optLineas = new System.Windows.Forms.RadioButton();
            this.optAreas = new System.Windows.Forms.RadioButton();
            this.optBarras = new System.Windows.Forms.RadioButton();
            this.grpTipoGraph = new System.Windows.Forms.GroupBox();
            this.optColumnas = new System.Windows.Forms.RadioButton();
            this.optEtareo = new System.Windows.Forms.RadioButton();
            this.dtpicFFinal = new System.Windows.Forms.DateTimePicker();
            this.optSexo = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpicFInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVerGraf = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).BeginInit();
            this.grpTipoGraph.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // fGrid
            // 
            this.fGrid.Location = new System.Drawing.Point(6, 202);
            this.fGrid.Name = "fGrid";
            this.fGrid.ReadOnly = true;
            this.fGrid.Size = new System.Drawing.Size(323, 176);
            this.fGrid.TabIndex = 0;
            this.fGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGrid_KeyDown);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidad.Location = new System.Drawing.Point(247, 381);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(80, 13);
            this.lblCantidad.TabIndex = 33;
            this.lblCantidad.Text = "000";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // optCircular
            // 
            this.optCircular.ForeColor = System.Drawing.Color.Black;
            this.optCircular.Image = ((System.Drawing.Image)(resources.GetObject("optCircular.Image")));
            this.optCircular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optCircular.Location = new System.Drawing.Point(174, 42);
            this.optCircular.Name = "optCircular";
            this.optCircular.Size = new System.Drawing.Size(136, 21);
            this.optCircular.TabIndex = 6;
            this.optCircular.Text = "Grafico Circular";
            this.optCircular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optCircular.UseVisualStyleBackColor = true;
            // 
            // optLineas
            // 
            this.optLineas.ForeColor = System.Drawing.Color.Black;
            this.optLineas.Image = ((System.Drawing.Image)(resources.GetObject("optLineas.Image")));
            this.optLineas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optLineas.Location = new System.Drawing.Point(174, 19);
            this.optLineas.Name = "optLineas";
            this.optLineas.Size = new System.Drawing.Size(148, 21);
            this.optLineas.TabIndex = 5;
            this.optLineas.Text = "Grafico de Lineas";
            this.optLineas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optLineas.UseVisualStyleBackColor = true;
            // 
            // optAreas
            // 
            this.optAreas.ForeColor = System.Drawing.Color.Black;
            this.optAreas.Image = ((System.Drawing.Image)(resources.GetObject("optAreas.Image")));
            this.optAreas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optAreas.Location = new System.Drawing.Point(10, 65);
            this.optAreas.Name = "optAreas";
            this.optAreas.Size = new System.Drawing.Size(142, 21);
            this.optAreas.TabIndex = 4;
            this.optAreas.Text = "Grafico de Areas";
            this.optAreas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optAreas.UseVisualStyleBackColor = true;
            // 
            // optBarras
            // 
            this.optBarras.ForeColor = System.Drawing.Color.Black;
            this.optBarras.Image = ((System.Drawing.Image)(resources.GetObject("optBarras.Image")));
            this.optBarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optBarras.Location = new System.Drawing.Point(10, 42);
            this.optBarras.Name = "optBarras";
            this.optBarras.Size = new System.Drawing.Size(146, 21);
            this.optBarras.TabIndex = 3;
            this.optBarras.Text = "Grafico de Barras";
            this.optBarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optBarras.UseVisualStyleBackColor = true;
            // 
            // grpTipoGraph
            // 
            this.grpTipoGraph.Controls.Add(this.optCircular);
            this.grpTipoGraph.Controls.Add(this.optLineas);
            this.grpTipoGraph.Controls.Add(this.optAreas);
            this.grpTipoGraph.Controls.Add(this.optBarras);
            this.grpTipoGraph.Controls.Add(this.optColumnas);
            this.grpTipoGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoGraph.ForeColor = System.Drawing.Color.Navy;
            this.grpTipoGraph.Location = new System.Drawing.Point(6, 42);
            this.grpTipoGraph.Name = "grpTipoGraph";
            this.grpTipoGraph.Size = new System.Drawing.Size(324, 90);
            this.grpTipoGraph.TabIndex = 32;
            this.grpTipoGraph.TabStop = false;
            this.grpTipoGraph.Text = "Tipo de Grafico";
            // 
            // optColumnas
            // 
            this.optColumnas.Checked = true;
            this.optColumnas.ForeColor = System.Drawing.Color.Black;
            this.optColumnas.Image = ((System.Drawing.Image)(resources.GetObject("optColumnas.Image")));
            this.optColumnas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optColumnas.Location = new System.Drawing.Point(10, 19);
            this.optColumnas.Name = "optColumnas";
            this.optColumnas.Size = new System.Drawing.Size(163, 21);
            this.optColumnas.TabIndex = 2;
            this.optColumnas.TabStop = true;
            this.optColumnas.Text = "Grafico de Columnas";
            this.optColumnas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optColumnas.UseVisualStyleBackColor = true;
            // 
            // optEtareo
            // 
            this.optEtareo.AutoSize = true;
            this.optEtareo.ForeColor = System.Drawing.Color.Black;
            this.optEtareo.Location = new System.Drawing.Point(210, 15);
            this.optEtareo.Name = "optEtareo";
            this.optEtareo.Size = new System.Drawing.Size(85, 17);
            this.optEtareo.TabIndex = 8;
            this.optEtareo.Text = "Por Etareo";
            this.optEtareo.UseVisualStyleBackColor = true;
            // 
            // dtpicFFinal
            // 
            this.dtpicFFinal.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpicFFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpicFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicFFinal.Location = new System.Drawing.Point(185, 19);
            this.dtpicFFinal.Name = "dtpicFFinal";
            this.dtpicFFinal.Size = new System.Drawing.Size(142, 20);
            this.dtpicFFinal.TabIndex = 25;
            this.dtpicFFinal.Value = new System.DateTime(2017, 4, 8, 9, 44, 22, 0);
            // 
            // optSexo
            // 
            this.optSexo.AutoSize = true;
            this.optSexo.Checked = true;
            this.optSexo.ForeColor = System.Drawing.Color.Black;
            this.optSexo.Location = new System.Drawing.Point(41, 16);
            this.optSexo.Name = "optSexo";
            this.optSexo.Size = new System.Drawing.Size(76, 17);
            this.optSexo.TabIndex = 7;
            this.optSexo.TabStop = true;
            this.optSexo.Text = "Por Sexo";
            this.optSexo.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.optEtareo);
            this.grpGender.Controls.Add(this.optSexo);
            this.grpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGender.ForeColor = System.Drawing.Color.Navy;
            this.grpGender.Location = new System.Drawing.Point(6, 134);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(323, 39);
            this.grpGender.TabIndex = 31;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Agrupar Grafico Por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(217, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha Final";
            // 
            // dtpicFInicial
            // 
            this.dtpicFInicial.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpicFInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpicFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicFInicial.Location = new System.Drawing.Point(7, 19);
            this.dtpicFInicial.Name = "dtpicFInicial";
            this.dtpicFInicial.Size = new System.Drawing.Size(142, 20);
            this.dtpicFInicial.TabIndex = 24;
            this.dtpicFInicial.Value = new System.DateTime(2017, 4, 8, 9, 44, 33, 0);
            this.dtpicFInicial.ValueChanged += new System.EventHandler(this.dtpicFInicial_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(32, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha Inicial";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(222, 176);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 23);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVerGraf
            // 
            this.btnVerGraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerGraf.ForeColor = System.Drawing.Color.Black;
            this.btnVerGraf.Image = ((System.Drawing.Image)(resources.GetObject("btnVerGraf.Image")));
            this.btnVerGraf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerGraf.Location = new System.Drawing.Point(116, 176);
            this.btnVerGraf.Name = "btnVerGraf";
            this.btnVerGraf.Size = new System.Drawing.Size(100, 23);
            this.btnVerGraf.TabIndex = 28;
            this.btnVerGraf.Text = "&Ver Gráfico";
            this.btnVerGraf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerGraf.UseVisualStyleBackColor = true;
            this.btnVerGraf.Click += new System.EventHandler(this.btnVerGraf_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.ForeColor = System.Drawing.Color.Black;
            this.btnEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("btnEjecutar.Image")));
            this.btnEjecutar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjecutar.Location = new System.Drawing.Point(10, 176);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(100, 23);
            this.btnEjecutar.TabIndex = 27;
            this.btnEjecutar.Text = "E&jecutar";
            this.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // frmGenEtareo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 397);
            this.ControlBox = false;
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.grpTipoGraph);
            this.Controls.Add(this.dtpicFFinal);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpicFInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerGraf);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.fGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenEtareo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estadistica - Genero y Grupo Etareo";
            this.Load += new System.EventHandler(this.frmGenEtareo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGenEtareo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).EndInit();
            this.grpTipoGraph.ResumeLayout(false);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion		

		private TenTec.Windows.iGridLib.iGrid fGrid;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.RadioButton optCircular;
		private System.Windows.Forms.RadioButton optLineas;
		private System.Windows.Forms.RadioButton optAreas;
		private System.Windows.Forms.RadioButton optBarras;
		private System.Windows.Forms.GroupBox grpTipoGraph;
		private System.Windows.Forms.RadioButton optColumnas;
		private System.Windows.Forms.RadioButton optEtareo;
		private System.Windows.Forms.DateTimePicker dtpicFFinal;
		private System.Windows.Forms.RadioButton optSexo;
		private System.Windows.Forms.GroupBox grpGender;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpicFInicial;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnVerGraf;
		private System.Windows.Forms.Button btnEjecutar;
	}
}

