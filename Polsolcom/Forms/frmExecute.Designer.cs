namespace Polsolcom.Forms
{
    partial class frmExecute
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
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.checkAsc = new System.Windows.Forms.CheckBox();
            this.checkDesc = new System.Windows.Forms.CheckBox();
            this.btnEjecuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(13, 13);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(123, 20);
            this.txtInicio.TabIndex = 0;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(13, 40);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(123, 20);
            this.txtFinal.TabIndex = 1;
            // 
            // checkAsc
            // 
            this.checkAsc.AutoSize = true;
            this.checkAsc.Location = new System.Drawing.Point(142, 15);
            this.checkAsc.Name = "checkAsc";
            this.checkAsc.Size = new System.Drawing.Size(83, 17);
            this.checkAsc.TabIndex = 2;
            this.checkAsc.Text = "Ascendente";
            this.checkAsc.UseVisualStyleBackColor = true;
            // 
            // checkDesc
            // 
            this.checkDesc.AutoSize = true;
            this.checkDesc.Location = new System.Drawing.Point(142, 42);
            this.checkDesc.Name = "checkDesc";
            this.checkDesc.Size = new System.Drawing.Size(90, 17);
            this.checkDesc.TabIndex = 3;
            this.checkDesc.Text = "Descendente";
            this.checkDesc.UseVisualStyleBackColor = true;
            // 
            // btnEjecuta
            // 
            this.btnEjecuta.Location = new System.Drawing.Point(86, 77);
            this.btnEjecuta.Name = "btnEjecuta";
            this.btnEjecuta.Size = new System.Drawing.Size(75, 23);
            this.btnEjecuta.TabIndex = 4;
            this.btnEjecuta.Text = "Ejecuta";
            this.btnEjecuta.UseVisualStyleBackColor = true;
            // 
            // frmExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 112);
            this.Controls.Add(this.btnEjecuta);
            this.Controls.Add(this.checkDesc);
            this.Controls.Add(this.checkAsc);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtInicio);
            this.KeyPreview = true;
            this.Name = "frmExecute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejecuta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmExecute_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.CheckBox checkAsc;
        private System.Windows.Forms.CheckBox checkDesc;
        private System.Windows.Forms.Button btnEjecuta;
    }
}