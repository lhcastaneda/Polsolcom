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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.menuMDI = new System.Windows.Forms.MenuStrip();
			this.statusMDI = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusF1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusF2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusF3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusF4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusF5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tmrLmn = new System.Windows.Forms.Timer(this.components);
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
			this.statusMDI.AutoSize = false;
			this.statusMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusF1,
            this.toolStripStatusF2,
            this.toolStripStatusF3,
            this.toolStripStatusF4,
            this.toolStripStatusF5});
			this.statusMDI.Location = new System.Drawing.Point(0, 437);
			this.statusMDI.Name = "statusMDI";
			this.statusMDI.Size = new System.Drawing.Size(979, 22);
			this.statusMDI.TabIndex = 6;
			// 
			// toolStripStatusF1
			// 
			this.toolStripStatusF1.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusF1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolStripStatusF1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripStatusF1.Name = "toolStripStatusF1";
			this.toolStripStatusF1.Size = new System.Drawing.Size(186, 17);
			this.toolStripStatusF1.Spring = true;
			// 
			// toolStripStatusF2
			// 
			this.toolStripStatusF2.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusF2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolStripStatusF2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripStatusF2.Name = "toolStripStatusF2";
			this.toolStripStatusF2.Size = new System.Drawing.Size(186, 17);
			this.toolStripStatusF2.Spring = true;
			// 
			// toolStripStatusF3
			// 
			this.toolStripStatusF3.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusF3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolStripStatusF3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripStatusF3.Name = "toolStripStatusF3";
			this.toolStripStatusF3.Size = new System.Drawing.Size(186, 17);
			this.toolStripStatusF3.Spring = true;
			// 
			// toolStripStatusF4
			// 
			this.toolStripStatusF4.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusF4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolStripStatusF4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripStatusF4.Name = "toolStripStatusF4";
			this.toolStripStatusF4.Size = new System.Drawing.Size(186, 17);
			this.toolStripStatusF4.Spring = true;
			// 
			// toolStripStatusF5
			// 
			this.toolStripStatusF5.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusF5.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolStripStatusF5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripStatusF5.Name = "toolStripStatusF5";
			this.toolStripStatusF5.Size = new System.Drawing.Size(186, 17);
			this.toolStripStatusF5.Spring = true;
			// 
			// tmrLmn
			// 
			this.tmrLmn.Enabled = true;
			this.tmrLmn.Interval = 1200;
			this.tmrLmn.Tick += new System.EventHandler(this.tmrLmn_Tick);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(979, 459);
			this.Controls.Add(this.statusMDI);
			this.Controls.Add(this.menuMDI);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de Atencion ... Bienvenido(a) :  ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
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
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusF1;
		private System.Windows.Forms.Timer tmrLmn;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusF2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusF3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusF4;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusF5;
	}
}



