﻿namespace Polsolcom.Forms
{
    partial class frmExport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExport));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.txtNomFile = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnExportar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Guardar en (Ruta)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre de Archivo";
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(117, 4);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(439, 20);
			this.txtPath.TabIndex = 1;
			// 
			// txtNomFile
			// 
			this.txtNomFile.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNomFile.Location = new System.Drawing.Point(117, 27);
			this.txtNomFile.Name = "txtNomFile";
			this.txtNomFile.Size = new System.Drawing.Size(327, 20);
			this.txtNomFile.TabIndex = 3;
			this.txtNomFile.Leave += new System.EventHandler(this.txtNomFile_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(446, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Tipo";
			// 
			// cmbTipo
			// 
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
            "XLSX"});
			this.cmbTipo.Location = new System.Drawing.Point(481, 26);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(74, 21);
			this.cmbTipo.TabIndex = 4;
			// 
			// btnOpen
			// 
			this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
			this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnOpen.Location = new System.Drawing.Point(559, 1);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(49, 50);
			this.btnOpen.TabIndex = 2;
			this.btnOpen.Text = "...";
			this.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnExportar
			// 
			this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
			this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExportar.Location = new System.Drawing.Point(406, 52);
			this.btnExportar.Name = "btnExportar";
			this.btnExportar.Size = new System.Drawing.Size(100, 40);
			this.btnExportar.TabIndex = 5;
			this.btnExportar.Text = "&Exportar";
			this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExportar.UseVisualStyleBackColor = true;
			this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(508, 52);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(100, 40);
			this.btnCerrar.TabIndex = 6;
			this.btnCerrar.Text = "&Cerrar";
			this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// frmExport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 94);
			this.ControlBox = false;
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnExportar);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNomFile);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "frmExport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exportar Datos . . .";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmExport_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtNomFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCerrar;
    }
}