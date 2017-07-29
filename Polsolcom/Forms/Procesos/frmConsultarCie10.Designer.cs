namespace Polsolcom.Forms.Procesos
{
    partial class frmConsultarCie10
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.lstDiag = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpDescrip = new System.Windows.Forms.GroupBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqCie = new System.Windows.Forms.TextBox();
            this.txtBusqDescripcion = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpDescrip.SuspendLayout();
            this.grpBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(353, 18);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(69, 39);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "&Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // lstDiag
            // 
            this.lstDiag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDiag.FullRowSelect = true;
            this.lstDiag.Location = new System.Drawing.Point(11, 51);
            this.lstDiag.MultiSelect = false;
            this.lstDiag.Name = "lstDiag";
            this.lstDiag.Size = new System.Drawing.Size(587, 102);
            this.lstDiag.TabIndex = 18;
            this.lstDiag.UseCompatibleStateImageBehavior = false;
            this.lstDiag.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Diagnostico";
            this.columnHeader1.Width = 488;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "code";
            this.columnHeader2.Width = 95;
            // 
            // grpDescrip
            // 
            this.grpDescrip.Controls.Add(this.txtDiagnostico);
            this.grpDescrip.Controls.Add(this.txtcode);
            this.grpDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescrip.Location = new System.Drawing.Point(13, 11);
            this.grpDescrip.Name = "grpDescrip";
            this.grpDescrip.Size = new System.Drawing.Size(337, 117);
            this.grpDescrip.TabIndex = 19;
            this.grpDescrip.TabStop = false;
            this.grpDescrip.Text = "Diagnóstico Cie10";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(14, 45);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnostico.Size = new System.Drawing.Size(306, 60);
            this.txtDiagnostico.TabIndex = 1;
            // 
            // txtcode
            // 
            this.txtcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(13, 22);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(100, 20);
            this.txtcode.TabIndex = 0;
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.label1);
            this.grpBusqueda.Controls.Add(this.txtBusqCie);
            this.grpBusqueda.Controls.Add(this.txtBusqDescripcion);
            this.grpBusqueda.Controls.Add(this.lstDiag);
            this.grpBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBusqueda.Location = new System.Drawing.Point(12, 132);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(612, 170);
            this.grpBusqueda.TabIndex = 20;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Ingrese criterios de búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "<- Descripción o Cie10 ->";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBusqCie
            // 
            this.txtBusqCie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqCie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqCie.Location = new System.Drawing.Point(496, 26);
            this.txtBusqCie.Name = "txtBusqCie";
            this.txtBusqCie.Size = new System.Drawing.Size(100, 20);
            this.txtBusqCie.TabIndex = 20;
            // 
            // txtBusqDescripcion
            // 
            this.txtBusqDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqDescripcion.Location = new System.Drawing.Point(10, 25);
            this.txtBusqDescripcion.Name = "txtBusqDescripcion";
            this.txtBusqDescripcion.Size = new System.Drawing.Size(328, 20);
            this.txtBusqDescripcion.TabIndex = 19;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(425, 18);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(69, 39);
            this.btnAnterior.TabIndex = 21;
            this.btnAnterior.Text = "&Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(494, 19);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(69, 39);
            this.btnSiguiente.TabIndex = 22;
            this.btnSiguiente.Text = "&Siguiente";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(563, 20);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(69, 39);
            this.btnUltimo.TabIndex = 23;
            this.btnUltimo.Text = "&Ultimo";
            this.btnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(564, 63);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 39);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmConsultarCie10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 311);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.grpDescrip);
            this.Controls.Add(this.btnInicio);
            this.Name = "frmConsultarCie10";
            this.Text = "Consultar Cie10";
            this.Load += new System.EventHandler(this.frmAgregarIngreso_Load);
            this.grpDescrip.ResumeLayout(false);
            this.grpDescrip.PerformLayout();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.ListView lstDiag;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox grpDescrip;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqCie;
        private System.Windows.Forms.TextBox txtBusqDescripcion;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSalir;
    }
}