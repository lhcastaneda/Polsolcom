namespace Polsolcom.Forms.Procesos
{
    partial class frmVerificaCie
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
			this.lstMostrarDatos = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtToTing = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtEspecialidad = new System.Windows.Forms.TextBox();
			this.txtCMP = new System.Windows.Forms.TextBox();
			this.txtDigitador = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lstMostrarDatos
			// 
			this.lstMostrarDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
			this.lstMostrarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstMostrarDatos.FullRowSelect = true;
			this.lstMostrarDatos.Location = new System.Drawing.Point(4, 28);
			this.lstMostrarDatos.MultiSelect = false;
			this.lstMostrarDatos.Name = "lstMostrarDatos";
			this.lstMostrarDatos.Size = new System.Drawing.Size(963, 337);
			this.lstMostrarDatos.TabIndex = 19;
			this.lstMostrarDatos.UseCompatibleStateImageBehavior = false;
			this.lstMostrarDatos.View = System.Windows.Forms.View.Details;
			this.lstMostrarDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMostrarDatos_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Serie";
			this.columnHeader1.Width = 36;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "N° DVenta";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Fecha";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "CMP";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 50;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Consultorio";
			this.columnHeader5.Width = 90;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Especialidad";
			this.columnHeader6.Width = 160;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Turno";
			this.columnHeader7.Width = 70;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Digitador";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader8.Width = 100;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Cie10";
			this.columnHeader9.Width = 50;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Procedimiento";
			this.columnHeader10.Width = 240;
			// 
			// txtToTing
			// 
			this.txtToTing.Location = new System.Drawing.Point(478, 4);
			this.txtToTing.Name = "txtToTing";
			this.txtToTing.ReadOnly = true;
			this.txtToTing.Size = new System.Drawing.Size(100, 20);
			this.txtToTing.TabIndex = 20;
			this.txtToTing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(657, 3);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(100, 23);
			this.btnEliminar.TabIndex = 21;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(761, 3);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(100, 23);
			this.btnAceptar.TabIndex = 22;
			this.btnAceptar.Text = "&Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(865, 3);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(100, 23);
			this.btnCancelar.TabIndex = 23;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// txtEspecialidad
			// 
			this.txtEspecialidad.Location = new System.Drawing.Point(4, 4);
			this.txtEspecialidad.Name = "txtEspecialidad";
			this.txtEspecialidad.ReadOnly = true;
			this.txtEspecialidad.Size = new System.Drawing.Size(281, 20);
			this.txtEspecialidad.TabIndex = 24;
			// 
			// txtCMP
			// 
			this.txtCMP.Location = new System.Drawing.Point(288, 4);
			this.txtCMP.Name = "txtCMP";
			this.txtCMP.ReadOnly = true;
			this.txtCMP.Size = new System.Drawing.Size(61, 20);
			this.txtCMP.TabIndex = 25;
			this.txtCMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDigitador
			// 
			this.txtDigitador.Location = new System.Drawing.Point(352, 4);
			this.txtDigitador.Name = "txtDigitador";
			this.txtDigitador.ReadOnly = true;
			this.txtDigitador.Size = new System.Drawing.Size(123, 20);
			this.txtDigitador.TabIndex = 26;
			this.txtDigitador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// frmVerificaCie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(970, 367);
			this.ControlBox = false;
			this.Controls.Add(this.txtDigitador);
			this.Controls.Add(this.txtCMP);
			this.Controls.Add(this.txtEspecialidad);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.txtToTing);
			this.Controls.Add(this.lstMostrarDatos);
			this.KeyPreview = true;
			this.Name = "frmVerificaCie";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Verificación de Historias Procesadas";
			this.Load += new System.EventHandler(this.frmVerificaCie_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVerificaCie_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstMostrarDatos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtToTing;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtCMP;
        private System.Windows.Forms.TextBox txtDigitador;
    }
}