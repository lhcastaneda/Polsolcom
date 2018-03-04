namespace Polsolcom.Forms
{
    partial class frmCie10
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCie10));
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.grpBusqueda = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilt1 = new System.Windows.Forms.TextBox();
			this.txtFilt2 = new System.Windows.Forms.TextBox();
			this.lstDatos = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.grpDescrip = new System.Windows.Forms.GroupBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtCIE10 = new System.Windows.Forms.TextBox();
			this.btnInicio = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.grpBusqueda.SuspendLayout();
			this.grpDescrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSalir.Location = new System.Drawing.Point(531, 63);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(59, 44);
			this.btnSalir.TabIndex = 31;
			this.btnSalir.Text = "&Salir";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnUltimo
			// 
			this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
			this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnUltimo.Location = new System.Drawing.Point(530, 23);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(60, 35);
			this.btnUltimo.TabIndex = 30;
			this.btnUltimo.Text = "&Ultimo";
			this.btnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnUltimo.UseVisualStyleBackColor = true;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
			this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSiguiente.Location = new System.Drawing.Point(470, 23);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(60, 35);
			this.btnSiguiente.TabIndex = 29;
			this.btnSiguiente.Text = "&Siguiente";
			this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSiguiente.UseVisualStyleBackColor = true;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
			this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAnterior.Location = new System.Drawing.Point(410, 23);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(60, 35);
			this.btnAnterior.TabIndex = 28;
			this.btnAnterior.Text = "&Anterior";
			this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAnterior.UseVisualStyleBackColor = true;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// grpBusqueda
			// 
			this.grpBusqueda.Controls.Add(this.label2);
			this.grpBusqueda.Controls.Add(this.label1);
			this.grpBusqueda.Controls.Add(this.txtFilt1);
			this.grpBusqueda.Controls.Add(this.txtFilt2);
			this.grpBusqueda.Controls.Add(this.lstDatos);
			this.grpBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBusqueda.ForeColor = System.Drawing.Color.DarkBlue;
			this.grpBusqueda.Location = new System.Drawing.Point(9, 122);
			this.grpBusqueda.Name = "grpBusqueda";
			this.grpBusqueda.Size = new System.Drawing.Size(588, 170);
			this.grpBusqueda.TabIndex = 27;
			this.grpBusqueda.TabStop = false;
			this.grpBusqueda.Text = "Ingrese criterios de búsqueda";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 32;
			this.label2.Text = "Descripción->";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(422, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "Cie10 ->";
			// 
			// txtFilt1
			// 
			this.txtFilt1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFilt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilt1.Location = new System.Drawing.Point(479, 26);
			this.txtFilt1.Name = "txtFilt1";
			this.txtFilt1.Size = new System.Drawing.Size(100, 20);
			this.txtFilt1.TabIndex = 20;
			this.txtFilt1.TextChanged += new System.EventHandler(this.txtFilt1_TextChanged);
			// 
			// txtFilt2
			// 
			this.txtFilt2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFilt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilt2.Location = new System.Drawing.Point(102, 25);
			this.txtFilt2.Name = "txtFilt2";
			this.txtFilt2.Size = new System.Drawing.Size(316, 20);
			this.txtFilt2.TabIndex = 19;
			this.txtFilt2.TextChanged += new System.EventHandler(this.txtFilt2_TextChanged);
			// 
			// lstDatos
			// 
			this.lstDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lstDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstDatos.FullRowSelect = true;
			this.lstDatos.Location = new System.Drawing.Point(11, 51);
			this.lstDatos.MultiSelect = false;
			this.lstDatos.Name = "lstDatos";
			this.lstDatos.Size = new System.Drawing.Size(569, 111);
			this.lstDatos.TabIndex = 18;
			this.lstDatos.UseCompatibleStateImageBehavior = false;
			this.lstDatos.View = System.Windows.Forms.View.Details;
			this.lstDatos.Click += new System.EventHandler(this.lstDatos_Click);
			this.lstDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstDatos_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Descripción";
			this.columnHeader1.Width = 466;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "CIE10";
			this.columnHeader2.Width = 100;
			// 
			// grpDescrip
			// 
			this.grpDescrip.Controls.Add(this.txtDescripcion);
			this.grpDescrip.Controls.Add(this.txtCIE10);
			this.grpDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpDescrip.ForeColor = System.Drawing.Color.DarkBlue;
			this.grpDescrip.Location = new System.Drawing.Point(10, 11);
			this.grpDescrip.Name = "grpDescrip";
			this.grpDescrip.Size = new System.Drawing.Size(337, 103);
			this.grpDescrip.TabIndex = 26;
			this.grpDescrip.TabStop = false;
			this.grpDescrip.Text = "Diagnóstico Cie10";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(14, 45);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescripcion.Size = new System.Drawing.Size(306, 51);
			this.txtDescripcion.TabIndex = 1;
			// 
			// txtCIE10
			// 
			this.txtCIE10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCIE10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCIE10.Location = new System.Drawing.Point(13, 22);
			this.txtCIE10.Name = "txtCIE10";
			this.txtCIE10.Size = new System.Drawing.Size(100, 20);
			this.txtCIE10.TabIndex = 0;
			// 
			// btnInicio
			// 
			this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
			this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnInicio.Location = new System.Drawing.Point(350, 23);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(60, 35);
			this.btnInicio.TabIndex = 25;
			this.btnInicio.Text = "&Inicio";
			this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnInicio.UseVisualStyleBackColor = true;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEliminar.Location = new System.Drawing.Point(471, 63);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(60, 44);
			this.btnEliminar.TabIndex = 34;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnModificar.Location = new System.Drawing.Point(411, 63);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(60, 44);
			this.btnModificar.TabIndex = 33;
			this.btnModificar.Text = "&Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnNuevo.Location = new System.Drawing.Point(351, 63);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(60, 44);
			this.btnNuevo.TabIndex = 32;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNuevo.UseVisualStyleBackColor = true;
			// 
			// frmCie10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 299);
			this.ControlBox = false;
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnUltimo);
			this.Controls.Add(this.btnSiguiente);
			this.Controls.Add(this.btnAnterior);
			this.Controls.Add(this.grpBusqueda);
			this.Controls.Add(this.grpDescrip);
			this.Controls.Add(this.btnInicio);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "frmCie10";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consultar Cie10";
			this.Load += new System.EventHandler(this.frmCie10_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCie10_KeyDown);
			this.grpBusqueda.ResumeLayout(false);
			this.grpBusqueda.PerformLayout();
			this.grpDescrip.ResumeLayout(false);
			this.grpDescrip.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilt1;
        private System.Windows.Forms.TextBox txtFilt2;
        private System.Windows.Forms.ListView lstDatos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox grpDescrip;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCIE10;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
    }
}