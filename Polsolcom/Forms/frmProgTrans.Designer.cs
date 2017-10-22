namespace Polsolcom.Forms
{
    partial class frmProgTrans
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechProgram = new System.Windows.Forms.DateTimePicker();
            this.dtpHorProgram = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtUsMod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCierre = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFechMod = new System.Windows.Forms.DateTimePicker();
            this.gdvProgram = new System.Windows.Forms.DataGridView();
            this.cFechHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUsCrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUsMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(103, 111);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programación";
            // 
            // dtpFechProgram
            // 
            this.dtpFechProgram.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechProgram.Location = new System.Drawing.Point(113, 36);
            this.dtpFechProgram.Name = "dtpFechProgram";
            this.dtpFechProgram.Size = new System.Drawing.Size(103, 20);
            this.dtpFechProgram.TabIndex = 2;
            // 
            // dtpHorProgram
            // 
            this.dtpHorProgram.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorProgram.Location = new System.Drawing.Point(113, 63);
            this.dtpHorProgram.Name = "dtpHorProgram";
            this.dtpHorProgram.Size = new System.Drawing.Size(103, 20);
            this.dtpHorProgram.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(231, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(231, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Límite";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(296, 36);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 8;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(296, 63);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 20);
            this.txtLimite.TabIndex = 9;
            // 
            // txtUsMod
            // 
            this.txtUsMod.Location = new System.Drawing.Point(495, 35);
            this.txtUsMod.Name = "txtUsMod";
            this.txtUsMod.Size = new System.Drawing.Size(100, 20);
            this.txtUsMod.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(427, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Última Modificación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(185, 111);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "&Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuitar.Location = new System.Drawing.Point(266, 111);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 16;
            this.btnQuitar.Text = "&Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnCierre
            // 
            this.btnCierre.Enabled = false;
            this.btnCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCierre.Location = new System.Drawing.Point(348, 110);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(75, 23);
            this.btnCierre.TabIndex = 17;
            this.btnCierre.Text = "&Cierre";
            this.btnCierre.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(430, 110);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dtpFechMod
            // 
            this.dtpFechMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechMod.Location = new System.Drawing.Point(495, 62);
            this.dtpFechMod.Name = "dtpFechMod";
            this.dtpFechMod.Size = new System.Drawing.Size(100, 20);
            this.dtpFechMod.TabIndex = 19;
            // 
            // gdvProgram
            // 
            this.gdvProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProgram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFechHora,
            this.cCant,
            this.cLimite,
            this.cFechCrea,
            this.cUsCrea,
            this.cFechMod,
            this.cUsMod});
            this.gdvProgram.Location = new System.Drawing.Point(16, 157);
            this.gdvProgram.Name = "gdvProgram";
            this.gdvProgram.Size = new System.Drawing.Size(618, 240);
            this.gdvProgram.TabIndex = 20;
            // 
            // cFechHora
            // 
            this.cFechHora.HeaderText = "Fecha y Hora";
            this.cFechHora.Name = "cFechHora";
            // 
            // cCant
            // 
            this.cCant.HeaderText = "Cantidad";
            this.cCant.Name = "cCant";
            this.cCant.Width = 80;
            // 
            // cLimite
            // 
            this.cLimite.HeaderText = "Límite";
            this.cLimite.Name = "cLimite";
            this.cLimite.Width = 80;
            // 
            // cFechCrea
            // 
            this.cFechCrea.HeaderText = "Fecha Creado";
            this.cFechCrea.Name = "cFechCrea";
            this.cFechCrea.Width = 80;
            // 
            // cUsCrea
            // 
            this.cUsCrea.HeaderText = "Usuario Creado";
            this.cUsCrea.Name = "cUsCrea";
            this.cUsCrea.Width = 80;
            // 
            // cFechMod
            // 
            this.cFechMod.HeaderText = "Fecha Modificado";
            this.cFechMod.Name = "cFechMod";
            this.cFechMod.Width = 80;
            // 
            // cUsMod
            // 
            this.cUsMod.HeaderText = "Usuario Modificado";
            this.cUsMod.Name = "cUsMod";
            this.cUsMod.Width = 80;
            // 
            // frmProgTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 409);
            this.ControlBox = false;
            this.Controls.Add(this.gdvProgram);
            this.Controls.Add(this.dtpFechMod);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsMod);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpHorProgram);
            this.Controls.Add(this.dtpFechProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabar);
            this.Name = "frmProgTrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programación de Transportistas";
            ((System.ComponentModel.ISupportInitialize)(this.gdvProgram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechProgram;
        private System.Windows.Forms.DateTimePicker dtpHorProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtUsMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpFechMod;
        private System.Windows.Forms.DataGridView gdvProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechCrea;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUsCrea;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUsMod;
    }
}