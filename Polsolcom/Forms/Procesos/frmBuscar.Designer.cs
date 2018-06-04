namespace Polsolcom.Forms.Procesos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDNI = new System.Windows.Forms.MaskedTextBox();
			this.lblIdPaciente = new System.Windows.Forms.Label();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.txtApeMaterno = new System.Windows.Forms.TextBox();
			this.txtApePaterno = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lstBuscar = new System.Windows.Forms.ListView();
			this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDNI);
			this.groupBox1.Controls.Add(this.lblIdPaciente);
			this.groupBox1.Controls.Add(this.txtNombres);
			this.groupBox1.Controls.Add(this.txtApeMaterno);
			this.groupBox1.Controls.Add(this.txtApePaterno);
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
			this.txtDNI.Location = new System.Drawing.Point(4, 25);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(96, 20);
			this.txtDNI.TabIndex = 1;
			this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
			this.txtDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDNI_KeyDown);
			this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
			// 
			// lblIdPaciente
			// 
			this.lblIdPaciente.AutoSize = true;
			this.lblIdPaciente.Location = new System.Drawing.Point(403, 7);
			this.lblIdPaciente.Name = "lblIdPaciente";
			this.lblIdPaciente.Size = new System.Drawing.Size(0, 13);
			this.lblIdPaciente.TabIndex = 3;
			// 
			// txtNombres
			// 
			this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombres.Location = new System.Drawing.Point(396, 25);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(147, 20);
			this.txtNombres.TabIndex = 4;
			this.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
			this.txtNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombres_KeyDown);
			// 
			// txtApeMaterno
			// 
			this.txtApeMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApeMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApeMaterno.Location = new System.Drawing.Point(249, 25);
			this.txtApeMaterno.Name = "txtApeMaterno";
			this.txtApeMaterno.Size = new System.Drawing.Size(145, 20);
			this.txtApeMaterno.TabIndex = 3;
			this.txtApeMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtApeMaterno.TextChanged += new System.EventHandler(this.txtApeMaterno_TextChanged);
			this.txtApeMaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscar_KeyDown);
			// 
			// txtApePaterno
			// 
			this.txtApePaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApePaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApePaterno.Location = new System.Drawing.Point(102, 25);
			this.txtApePaterno.Name = "txtApePaterno";
			this.txtApePaterno.Size = new System.Drawing.Size(145, 20);
			this.txtApePaterno.TabIndex = 2;
			this.txtApePaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtApePaterno.TextChanged += new System.EventHandler(this.txtApePaterno_TextChanged);
			this.txtApePaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscar_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(4, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "D.N.I.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(395, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nombres";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(250, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido Materno";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(103, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Apellido Paterno";
			// 
			// lstBuscar
			// 
			this.lstBuscar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Id,
            this.DNI});
			this.lstBuscar.FullRowSelect = true;
			this.lstBuscar.Location = new System.Drawing.Point(4, 49);
			this.lstBuscar.MultiSelect = false;
			this.lstBuscar.Name = "lstBuscar";
			this.lstBuscar.Size = new System.Drawing.Size(548, 168);
			this.lstBuscar.TabIndex = 5;
			this.lstBuscar.UseCompatibleStateImageBehavior = false;
			this.lstBuscar.View = System.Windows.Forms.View.Details;
			this.lstBuscar.SelectedIndexChanged += new System.EventHandler(this.lstBuscar_SelectedIndexChanged);
			this.lstBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstBuscar_KeyDown);
			this.lstBuscar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBuscar_MouseDoubleClick);
			// 
			// Nombre
			// 
			this.Nombre.Text = "Apellidos y Nombres";
			this.Nombre.Width = 319;
			// 
			// Id
			// 
			this.Id.Text = "Id Paciente";
			this.Id.Width = 100;
			// 
			// DNI
			// 
			this.DNI.Text = "DNI";
			this.DNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.DNI.Width = 100;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Enabled = false;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(391, 219);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(81, 30);
			this.btnAceptar.TabIndex = 6;
			this.btnAceptar.Text = "&Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(472, 219);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(81, 30);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// frmBuscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 250);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lstBuscar);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.Name = "frmBuscar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Busqueda de Pacientes - ";
			this.Load += new System.EventHandler(this.frmBuscar_Load);
			this.Shown += new System.EventHandler(this.frmBuscar_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscar_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.ListView lstBuscar;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader DNI;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtDNI;
    }
}