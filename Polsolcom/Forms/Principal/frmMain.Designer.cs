namespace Polsolcom.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.menuMDI = new System.Windows.Forms.MenuStrip();
			this.statusMDI = new System.Windows.Forms.StatusStrip();
			this.pn1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pn2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pn3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pn4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pn5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pn6 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pn7 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pn8 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusMDI.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMDI
			// 
			this.menuMDI.Location = new System.Drawing.Point(0, 0);
			this.menuMDI.Name = "menuMDI";
			this.menuMDI.Size = new System.Drawing.Size(979, 24);
			this.menuMDI.TabIndex = 4;
			this.menuMDI.Text = "menuStrip1";
			// 
			// statusMDI
			// 
			this.statusMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pn1,
            this.pn2,
            this.pn3,
            this.pn4,
            this.pn5,
            this.pn6,
            this.pn7,
            this.pn8});
			this.statusMDI.Location = new System.Drawing.Point(0, 437);
			this.statusMDI.Name = "statusMDI";
			this.statusMDI.Size = new System.Drawing.Size(979, 22);
			this.statusMDI.TabIndex = 6;
			// 
			// pn1
			// 
			this.pn1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.pn1.Name = "pn1";
			this.pn1.Size = new System.Drawing.Size(4, 17);
			// 
			// pn2
			// 
			this.pn2.Name = "pn2";
			this.pn2.Size = new System.Drawing.Size(0, 17);
			// 
			// pn3
			// 
			this.pn3.Name = "pn3";
			this.pn3.Size = new System.Drawing.Size(0, 17);
			// 
			// pn4
			// 
			this.pn4.Name = "pn4";
			this.pn4.Size = new System.Drawing.Size(0, 17);
			// 
			// pn5
			// 
			this.pn5.Name = "pn5";
			this.pn5.Size = new System.Drawing.Size(0, 17);
			// 
			// pn6
			// 
			this.pn6.Name = "pn6";
			this.pn6.Size = new System.Drawing.Size(0, 17);
			// 
			// pn7
			// 
			this.pn7.Name = "pn7";
			this.pn7.Size = new System.Drawing.Size(0, 17);
			// 
			// pn8
			// 
			this.pn8.Name = "pn8";
			this.pn8.Size = new System.Drawing.Size(0, 17);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(979, 459);
			this.ControlBox = false;
			this.Controls.Add(this.statusMDI);
			this.Controls.Add(this.menuMDI);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de Atencion ... Bienvenido(a) :  ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
			this.statusMDI.ResumeLayout(false);
			this.statusMDI.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuMDI;
        private System.Windows.Forms.StatusStrip statusMDI;
        private System.Windows.Forms.ToolStripStatusLabel pn1;
        private System.Windows.Forms.ToolStripStatusLabel pn2;
        private System.Windows.Forms.ToolStripStatusLabel pn3;
        private System.Windows.Forms.ToolStripStatusLabel pn4;
        private System.Windows.Forms.ToolStripStatusLabel pn5;
        private System.Windows.Forms.ToolStripStatusLabel pn6;
        private System.Windows.Forms.ToolStripStatusLabel pn7;
		private System.Windows.Forms.ToolStripStatusLabel pn8;
    }
}



