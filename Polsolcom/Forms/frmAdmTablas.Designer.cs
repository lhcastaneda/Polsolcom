namespace Polsolcom.Forms
{
    partial class frmAdmTablas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmTablas));
            this.btnContinuar = new System.Windows.Forms.Button();
            this.grdTabla = new System.Windows.Forms.DataGridView();
            this.cNomTablas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContinuar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Image = ((System.Drawing.Image)(resources.GetObject("btnContinuar.Image")));
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.Location = new System.Drawing.Point(279, 311);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(89, 28);
            this.btnContinuar.TabIndex = 1;
            this.btnContinuar.Text = "&Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // grdTabla
            // 
            this.grdTabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNomTablas,
            this.cIdTabla});
            this.grdTabla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdTabla.Location = new System.Drawing.Point(5, 3);
            this.grdTabla.Name = "grdTabla";
            this.grdTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdTabla.Size = new System.Drawing.Size(362, 305);
            this.grdTabla.TabIndex = 0;
            // 
            // cNomTablas
            // 
            this.cNomTablas.HeaderText = "Nombre de Tabla";
            this.cNomTablas.Name = "cNomTablas";
            this.cNomTablas.Width = 260;
            // 
            // cIdTabla
            // 
            this.cIdTabla.HeaderText = "ID Tabla";
            this.cIdTabla.Name = "cIdTabla";
            this.cIdTabla.Width = 60;
            // 
            // frmAdmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 342);
            this.ControlBox = false;
            this.Controls.Add(this.grdTabla);
            this.Controls.Add(this.btnContinuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdmTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otras tablas del sistema";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAdmTablas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdmTablas_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.DataGridView grdTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNomTablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdTabla;

    }
}