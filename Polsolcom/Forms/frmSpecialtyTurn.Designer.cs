namespace Polsolcom.Forms
{
    partial class frmSpecialtyTurn
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
            this.GridSpecialtyTurn = new System.Windows.Forms.DataGridView();
            this.NomEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mannana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madrugada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridSpecialtyTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // GridSpecialtyTurn
            // 
            this.GridSpecialtyTurn.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GridSpecialtyTurn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSpecialtyTurn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomEspecialidad,
            this.continuo,
            this.mannana,
            this.tarde,
            this.noche,
            this.madrugada});
            this.GridSpecialtyTurn.Location = new System.Drawing.Point(15, 26);
            this.GridSpecialtyTurn.Name = "GridSpecialtyTurn";
            this.GridSpecialtyTurn.Size = new System.Drawing.Size(642, 289);
            this.GridSpecialtyTurn.TabIndex = 0;
            // 
            // NomEspecialidad
            // 
            this.NomEspecialidad.HeaderText = "Nombre de la Especialidad";
            this.NomEspecialidad.Name = "NomEspecialidad";
            // 
            // continuo
            // 
            this.continuo.HeaderText = "Continuo";
            this.continuo.Name = "continuo";
            // 
            // mannana
            // 
            this.mannana.HeaderText = "Mañana";
            this.mannana.Name = "mannana";
            // 
            // tarde
            // 
            this.tarde.HeaderText = "Tarde";
            this.tarde.Name = "tarde";
            // 
            // noche
            // 
            this.noche.HeaderText = "Noche";
            this.noche.Name = "noche";
            // 
            // madrugada
            // 
            this.madrugada.HeaderText = "Madrugada";
            this.madrugada.Name = "madrugada";
            // 
            // frmSpecialtyTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(669, 349);
            this.ControlBox = false;
            this.Controls.Add(this.GridSpecialtyTurn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSpecialtyTurn";
            this.Text = "Especialidad y Turnos";
            ((System.ComponentModel.ISupportInitialize)(this.GridSpecialtyTurn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridSpecialtyTurn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn continuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mannana;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarde;
        private System.Windows.Forms.DataGridViewTextBoxColumn noche;
        private System.Windows.Forms.DataGridViewTextBoxColumn madrugada;
    }
}