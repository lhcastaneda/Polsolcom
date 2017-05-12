namespace Polsolcom.Forms
{
    partial class frmGenPaySalSpecialist
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
            this.pnlFech = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVistaPre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEspecialistas = new System.Windows.Forms.CheckBox();
            this.cmbEspecialistas = new System.Windows.Forms.ComboBox();
            this.chkEspecialidad = new System.Windows.Forms.CheckBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.chkTurn = new System.Windows.Forms.CheckBox();
            this.cmbTurn = new System.Windows.Forms.ComboBox();
            this.pnlFech.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFech
            // 
            this.pnlFech.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFech.Controls.Add(this.btnCerrar);
            this.pnlFech.Controls.Add(this.btnVistaPre);
            this.pnlFech.Controls.Add(this.label3);
            this.pnlFech.Controls.Add(this.txtHasta);
            this.pnlFech.Controls.Add(this.txtDesde);
            this.pnlFech.Controls.Add(this.label2);
            this.pnlFech.Location = new System.Drawing.Point(12, 35);
            this.pnlFech.Name = "pnlFech";
            this.pnlFech.Size = new System.Drawing.Size(359, 83);
            this.pnlFech.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(203, 48);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnVistaPre
            // 
            this.btnVistaPre.Location = new System.Drawing.Point(64, 48);
            this.btnVistaPre.Name = "btnVistaPre";
            this.btnVistaPre.Size = new System.Drawing.Size(100, 23);
            this.btnVistaPre.TabIndex = 4;
            this.btnVistaPre.Text = "Vista &Previa";
            this.btnVistaPre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta :";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(234, 9);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 2;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(61, 9);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desde :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de Parte";
            // 
            // chkEspecialistas
            // 
            this.chkEspecialistas.AutoSize = true;
            this.chkEspecialistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEspecialistas.Location = new System.Drawing.Point(13, 129);
            this.chkEspecialistas.Name = "chkEspecialistas";
            this.chkEspecialistas.Size = new System.Drawing.Size(100, 17);
            this.chkEspecialistas.TabIndex = 2;
            this.chkEspecialistas.Text = "Especialistas";
            this.chkEspecialistas.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialistas
            // 
            this.cmbEspecialistas.FormattingEnabled = true;
            this.cmbEspecialistas.Location = new System.Drawing.Point(13, 153);
            this.cmbEspecialistas.Name = "cmbEspecialistas";
            this.cmbEspecialistas.Size = new System.Drawing.Size(361, 21);
            this.cmbEspecialistas.TabIndex = 3;
            // 
            // chkEspecialidad
            // 
            this.chkEspecialidad.AutoSize = true;
            this.chkEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEspecialidad.Location = new System.Drawing.Point(13, 181);
            this.chkEspecialidad.Name = "chkEspecialidad";
            this.chkEspecialidad.Size = new System.Drawing.Size(98, 17);
            this.chkEspecialidad.TabIndex = 4;
            this.chkEspecialidad.Text = "Especialidad";
            this.chkEspecialidad.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(13, 205);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(361, 21);
            this.cmbEspecialidad.TabIndex = 5;
            // 
            // chkTurn
            // 
            this.chkTurn.AutoSize = true;
            this.chkTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTurn.Location = new System.Drawing.Point(13, 233);
            this.chkTurn.Name = "chkTurn";
            this.chkTurn.Size = new System.Drawing.Size(65, 17);
            this.chkTurn.TabIndex = 6;
            this.chkTurn.Text = "Turnos";
            this.chkTurn.UseVisualStyleBackColor = true;
            // 
            // cmbTurn
            // 
            this.cmbTurn.FormattingEnabled = true;
            this.cmbTurn.Location = new System.Drawing.Point(13, 257);
            this.cmbTurn.Name = "cmbTurn";
            this.cmbTurn.Size = new System.Drawing.Size(361, 21);
            this.cmbTurn.TabIndex = 7;
            // 
            // frmGenPaySalSpecialist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 291);
            this.Controls.Add(this.cmbTurn);
            this.Controls.Add(this.chkTurn);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.chkEspecialidad);
            this.Controls.Add(this.cmbEspecialistas);
            this.Controls.Add(this.chkEspecialistas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlFech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGenPaySalSpecialist";
            this.Text = "Planilla de Pago para Especialistas";
            this.pnlFech.ResumeLayout(false);
            this.pnlFech.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFech;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVistaPre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEspecialistas;
        private System.Windows.Forms.ComboBox cmbEspecialistas;
        private System.Windows.Forms.CheckBox chkEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.CheckBox chkTurn;
        private System.Windows.Forms.ComboBox cmbTurn;
    }
}