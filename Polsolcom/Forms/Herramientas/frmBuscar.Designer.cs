namespace Polsolcom.Forms.Herramientas
{
	partial class frmBuscar
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
			if ( disposing && (components != null) )
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.txtAPMaterno = new System.Windows.Forms.TextBox();
			this.txtAPPaterno = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.fGrid = new TenTec.Windows.iGridLib.iGrid();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDNI);
			this.groupBox1.Controls.Add(this.txtNombres);
			this.groupBox1.Controls.Add(this.txtAPMaterno);
			this.groupBox1.Controls.Add(this.txtAPPaterno);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(4, -3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(548, 49);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(449, 25);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(93, 20);
			this.txtDNI.TabIndex = 3;
			this.txtDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDNI_KeyDown);
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(301, 25);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(145, 20);
			this.txtNombres.TabIndex = 2;
			this.txtNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombres_KeyDown);
			// 
			// txtAPMaterno
			// 
			this.txtAPMaterno.Location = new System.Drawing.Point(154, 25);
			this.txtAPMaterno.Name = "txtAPMaterno";
			this.txtAPMaterno.Size = new System.Drawing.Size(145, 20);
			this.txtAPMaterno.TabIndex = 1;
			this.txtAPMaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAPMaterno_KeyDown);
			// 
			// txtAPPaterno
			// 
			this.txtAPPaterno.Location = new System.Drawing.Point(7, 25);
			this.txtAPPaterno.Name = "txtAPPaterno";
			this.txtAPPaterno.Size = new System.Drawing.Size(145, 20);
			this.txtAPPaterno.TabIndex = 0;
			this.txtAPPaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAPPaterno_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(451, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "D.N.I.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(304, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombres";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(158, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellido Materno";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Apellido Paterno";
			// 
			// fGrid
			// 
			this.fGrid.Location = new System.Drawing.Point(5, 48);
			this.fGrid.Name = "iGrid1";
			this.fGrid.Size = new System.Drawing.Size(545, 200);
			this.fGrid.TabIndex = 0;
			this.fGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscar_KeyDown);
			// 
			// frmBuscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 250);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.fGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmBuscar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Busqueda de Pacientes ...";
			this.Load += new System.EventHandler(this.frmBuscar_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscar_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.TextBox txtAPMaterno;
		private System.Windows.Forms.TextBox txtAPPaterno;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private TenTec.Windows.iGridLib.iGrid fGrid;
	}
}