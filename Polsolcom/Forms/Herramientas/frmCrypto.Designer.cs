namespace Polsolcom.Forms
{
    partial class frmCrypto
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnEjecuta = new System.Windows.Forms.Button();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(197, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(197, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "label4";
			// 
			// btnEjecuta
			// 
			this.btnEjecuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEjecuta.Location = new System.Drawing.Point(126, 87);
			this.btnEjecuta.Name = "btnEjecuta";
			this.btnEjecuta.Size = new System.Drawing.Size(75, 23);
			this.btnEjecuta.TabIndex = 4;
			this.btnEjecuta.Text = "&Ejecuta";
			this.btnEjecuta.UseVisualStyleBackColor = true;
			this.btnEjecuta.Click += new System.EventHandler(this.btnEjecuta_Click);
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(82, 10);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 20);
			this.txt1.TabIndex = 5;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(82, 43);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 20);
			this.txt2.TabIndex = 6;
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(238, 10);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(75, 20);
			this.txt3.TabIndex = 7;
			// 
			// txt4
			// 
			this.txt4.Location = new System.Drawing.Point(238, 43);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(75, 20);
			this.txt4.TabIndex = 8;
			// 
			// frmCrypto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 122);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.btnEjecuta);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmCrypto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Crytografy";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEjecuta;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
    }
}