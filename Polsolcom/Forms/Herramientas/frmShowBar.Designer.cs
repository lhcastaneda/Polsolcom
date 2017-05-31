namespace Polsolcom.Forms
{
    partial class frmShowBar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowBar));
			this.txtLastUpdate = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lstPTusuarios = new System.Windows.Forms.ListBox();
			this.lstTusuarios = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrompt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNroBar = new System.Windows.Forms.TextBox();
			this.txtPadMenu = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtLastUpdate
			// 
			this.txtLastUpdate.BackColor = System.Drawing.Color.Black;
			this.txtLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastUpdate.ForeColor = System.Drawing.Color.White;
			this.txtLastUpdate.Location = new System.Drawing.Point(167, 20);
			this.txtLastUpdate.Name = "txtLastUpdate";
			this.txtLastUpdate.Size = new System.Drawing.Size(268, 24);
			this.txtLastUpdate.TabIndex = 50;
			this.txtLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAceptar
			// 
			this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(267, 299);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(83, 39);
			this.btnAceptar.TabIndex = 7;
			this.btnAceptar.Text = "&Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Navy;
			this.label7.Location = new System.Drawing.Point(228, 200);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 13);
			this.label7.TabIndex = 49;
			this.label7.Text = "Tipos de Usuario Permitidos";
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(353, 299);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(83, 39);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			this.btnCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancelar_KeyDown);
			// 
			// lstPTusuarios
			// 
			this.lstPTusuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstPTusuarios.FormattingEnabled = true;
			this.lstPTusuarios.Location = new System.Drawing.Point(224, 217);
			this.lstPTusuarios.Name = "lstPTusuarios";
			this.lstPTusuarios.Size = new System.Drawing.Size(212, 80);
			this.lstPTusuarios.Sorted = true;
			this.lstPTusuarios.TabIndex = 6;
			this.lstPTusuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPTusuarios_KeyDown);
			this.lstPTusuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPTusuarios_MouseDoubleClick);
			// 
			// lstTusuarios
			// 
			this.lstTusuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstTusuarios.FormattingEnabled = true;
			this.lstTusuarios.Location = new System.Drawing.Point(9, 217);
			this.lstTusuarios.Name = "lstTusuarios";
			this.lstTusuarios.Size = new System.Drawing.Size(212, 80);
			this.lstTusuarios.Sorted = true;
			this.lstTusuarios.TabIndex = 5;
			this.lstTusuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstTusuarios_KeyDown);
			this.lstTusuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTusuarios_MouseDoubleClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Navy;
			this.label6.Location = new System.Drawing.Point(7, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 13);
			this.label6.TabIndex = 48;
			this.label6.Text = "Tipos de Usuario";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(9, 145);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(428, 49);
			this.txtDescripcion.TabIndex = 4;
			this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(7, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(143, 13);
			this.label5.TabIndex = 46;
			this.label5.Text = "Descripcion Referencial";
			// 
			// txtCommand
			// 
			this.txtCommand.Location = new System.Drawing.Point(9, 103);
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(428, 20);
			this.txtCommand.TabIndex = 3;
			this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Navy;
			this.label4.Location = new System.Drawing.Point(7, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 13);
			this.label4.TabIndex = 44;
			this.label4.Text = "Comando a Ejecutarse";
			// 
			// txtPrompt
			// 
			this.txtPrompt.Location = new System.Drawing.Point(9, 60);
			this.txtPrompt.Name = "txtPrompt";
			this.txtPrompt.Size = new System.Drawing.Size(428, 20);
			this.txtPrompt.TabIndex = 2;
			this.txtPrompt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrompt_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Location = new System.Drawing.Point(7, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 13);
			this.label3.TabIndex = 40;
			this.label3.Text = "Indicador o Nombre";
			// 
			// txtNroBar
			// 
			this.txtNroBar.Enabled = false;
			this.txtNroBar.Location = new System.Drawing.Point(92, 20);
			this.txtNroBar.Name = "txtNroBar";
			this.txtNroBar.Size = new System.Drawing.Size(68, 20);
			this.txtNroBar.TabIndex = 1;
			this.txtNroBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPadMenu
			// 
			this.txtPadMenu.Enabled = false;
			this.txtPadMenu.Location = new System.Drawing.Point(9, 20);
			this.txtPadMenu.Name = "txtPadMenu";
			this.txtPadMenu.Size = new System.Drawing.Size(80, 20);
			this.txtPadMenu.TabIndex = 0;
			this.txtPadMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(93, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 37;
			this.label2.Text = "N° Barra";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(7, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 34;
			this.label1.Text = "Nivel Menu";
			// 
			// frmShowBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 343);
			this.ControlBox = false;
			this.Controls.Add(this.txtLastUpdate);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.lstPTusuarios);
			this.Controls.Add(this.lstTusuarios);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCommand);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPrompt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNroBar);
			this.Controls.Add(this.txtPadMenu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmShowBar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Elemento de Menu";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.frmShowBar_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmShowBar_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLastUpdate;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lstPTusuarios;
        private System.Windows.Forms.ListBox lstTusuarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroBar;
        private System.Windows.Forms.TextBox txtPadMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}