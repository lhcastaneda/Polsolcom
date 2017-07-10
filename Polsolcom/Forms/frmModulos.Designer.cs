namespace Polsolcom.Forms
{
    partial class frmModulos
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
            this.btnAfCajaProd = new System.Windows.Forms.Button();
            this.btnTrans = new System.Windows.Forms.Button();
            this.btnAdmi = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfCajaProd
            // 
            this.btnAfCajaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfCajaProd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAfCajaProd.Location = new System.Drawing.Point(12, 12);
            this.btnAfCajaProd.Name = "btnAfCajaProd";
            this.btnAfCajaProd.Size = new System.Drawing.Size(329, 31);
            this.btnAfCajaProd.TabIndex = 0;
            this.btnAfCajaProd.Text = "Módulo de &Afiliación, Caja, Producción";
            this.btnAfCajaProd.UseVisualStyleBackColor = true;
            // 
            // btnTrans
            // 
            this.btnTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTrans.Location = new System.Drawing.Point(12, 49);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(329, 31);
            this.btnTrans.TabIndex = 1;
            this.btnTrans.Text = "Módulo de &Transportistas";
            this.btnTrans.UseVisualStyleBackColor = true;
            // 
            // btnAdmi
            // 
            this.btnAdmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmi.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAdmi.Location = new System.Drawing.Point(12, 86);
            this.btnAdmi.Name = "btnAdmi";
            this.btnAdmi.Size = new System.Drawing.Size(329, 31);
            this.btnAdmi.TabIndex = 2;
            this.btnAdmi.Text = "Módulo de &Administración";
            this.btnAdmi.UseVisualStyleBackColor = true;
            // 
            // btnGestion
            // 
            this.btnGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGestion.Location = new System.Drawing.Point(12, 123);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(329, 31);
            this.btnGestion.TabIndex = 3;
            this.btnGestion.Text = "Módulo de &Gestión";
            this.btnGestion.UseVisualStyleBackColor = true;
            // 
            // frmModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 173);
            this.ControlBox = false;
            this.Controls.Add(this.btnGestion);
            this.Controls.Add(this.btnAdmi);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.btnAfCajaProd);
            this.KeyPreview = true;
            this.Name = "frmModulos";
            this.Text = "Módulos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmModulos_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfCajaProd;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Button btnAdmi;
        private System.Windows.Forms.Button btnGestion;
    }
}