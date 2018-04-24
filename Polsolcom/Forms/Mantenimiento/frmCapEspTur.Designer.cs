namespace Polsolcom.Forms.Mantenimiento
{
    partial class frmCapEspTur
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapEspTur));
			this.grdSpeciality = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdSpeciality)).BeginInit();
			this.SuspendLayout();
			// 
			// grdSpeciality
			// 
			this.grdSpeciality.AllowUserToAddRows = false;
			this.grdSpeciality.AllowUserToDeleteRows = false;
			this.grdSpeciality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdSpeciality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.grdSpeciality.Location = new System.Drawing.Point(3, 1);
			this.grdSpeciality.MultiSelect = false;
			this.grdSpeciality.Name = "grdSpeciality";
			this.grdSpeciality.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdSpeciality.Size = new System.Drawing.Size(596, 415);
			this.grdSpeciality.TabIndex = 0;
			this.grdSpeciality.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdSpeciality_CellBeginEdit);
			this.grdSpeciality.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSpeciality_CellEndEdit);
			this.grdSpeciality.SelectionChanged += new System.EventHandler(this.grdSpeciality_SelectionChanged);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Nombre de la Especialidad";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.Width = 300;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Continuo";
			this.Column2.Name = "Column2";
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column2.Width = 50;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Mañana";
			this.Column3.Name = "Column3";
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column3.Width = 50;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Tarde";
			this.Column4.Name = "Column4";
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column4.Width = 50;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Noche";
			this.Column5.Name = "Column5";
			this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column5.Width = 50;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Madrugada";
			this.Column6.Name = "Column6";
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column6.Width = 50;
			// 
			// frmCapEspTur
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 416);
			this.Controls.Add(this.grdSpeciality);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "frmCapEspTur";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmCapEspTur";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCapEspTur_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.grdSpeciality)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSpeciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}