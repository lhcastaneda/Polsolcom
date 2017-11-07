namespace Polsolcom.Forms
{
	partial class frmCRViewer
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
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.crpViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpViewer
            // 
            this.crpViewer.ActiveViewIndex = -1;
            this.crpViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crpViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpViewer.DisplayStatusBar = false;
            this.crpViewer.Location = new System.Drawing.Point(0, 0);
            this.crpViewer.Name = "crpViewer";
            this.crpViewer.ReuseParameterValuesOnRefresh = true;
            this.crpViewer.ShowCloseButton = false;
            this.crpViewer.ShowGroupTreeButton = false;
            this.crpViewer.ShowLogo = false;
            this.crpViewer.ShowParameterPanelButton = false;
            this.crpViewer.ShowRefreshButton = false;
            this.crpViewer.Size = new System.Drawing.Size(682, 394);
            this.crpViewer.TabIndex = 0;
            this.crpViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCRViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 394);
            this.Controls.Add(this.crpViewer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCRViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muestra Reporte Crystal Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCRViewer_Load);
            this.ResumeLayout(false);

		}

		#endregion
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crpViewer;
	}
}