namespace Polsolcom.Forms
{
    partial class frmPizarra
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
			this.components = new System.ComponentModel.Container();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtEditMensaj = new System.Windows.Forms.TextBox();
			this.txtMensaje = new System.Windows.Forms.TextBox();
			this.timerMensaj = new System.Windows.Forms.Timer(this.components);
			this.btnTimer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.iGrid1 = new TenTec.Windows.iGridLib.iGrid();
			((System.ComponentModel.ISupportInitialize)(this.iGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(184, 366);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(117, 29);
			this.btnAceptar.TabIndex = 0;
			this.btnAceptar.Text = "&Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			// 
			// txtEditMensaj
			// 
			this.txtEditMensaj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEditMensaj.Location = new System.Drawing.Point(5, 230);
			this.txtEditMensaj.Multiline = true;
			this.txtEditMensaj.Name = "txtEditMensaj";
			this.txtEditMensaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtEditMensaj.Size = new System.Drawing.Size(297, 78);
			this.txtEditMensaj.TabIndex = 1;
			// 
			// txtMensaje
			// 
			this.txtMensaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMensaje.Location = new System.Drawing.Point(4, 335);
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.Size = new System.Drawing.Size(297, 20);
			this.txtMensaje.TabIndex = 2;
			// 
			// timerMensaj
			// 
			this.timerMensaj.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnTimer
			// 
			this.btnTimer.Location = new System.Drawing.Point(4, 361);
			this.btnTimer.Name = "btnTimer";
			this.btnTimer.Size = new System.Drawing.Size(57, 39);
			this.btnTimer.TabIndex = 3;
			this.btnTimer.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(7, 213);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Editar";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkBlue;
			this.label2.Location = new System.Drawing.Point(4, 319);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Título del Mensaje";
			// 
			// iGrid1
			// 
			this.iGrid1.Location = new System.Drawing.Point(0, 0);
			this.iGrid1.Name = "iGrid1";
			this.iGrid1.TabIndex = 0;
			// 
			// frmPizarra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(328, 402);
			this.ControlBox = false;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTimer);
			this.Controls.Add(this.txtMensaje);
			this.Controls.Add(this.txtEditMensaj);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.iGrid1);
			this.Name = "frmPizarra";
			this.Text = "Editar Mensajes";
			((System.ComponentModel.ISupportInitialize)(this.iGrid1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtEditMensaj;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Timer timerMensaj;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private TenTec.Windows.iGridLib.iGrid iGrid1;
	}
}