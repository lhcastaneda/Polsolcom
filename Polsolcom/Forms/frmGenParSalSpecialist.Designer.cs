namespace Polsolcom.Forms
{
    partial class frmGenParSalSpecialist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbEspec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridPagoEspec = new System.Windows.Forms.DataGridView();
            this.cEspec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEspecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPProc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPagoEspec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnGrabar);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.cmbEspec);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(721, 37);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(609, 37);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(106, 23);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "G&rabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(497, 37);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(106, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // cmbEspec
            // 
            this.cmbEspec.FormattingEnabled = true;
            this.cmbEspec.Location = new System.Drawing.Point(17, 39);
            this.cmbEspec.Name = "cmbEspec";
            this.cmbEspec.Size = new System.Drawing.Size(474, 21);
            this.cmbEspec.TabIndex = 1;
            this.cmbEspec.SelectedIndexChanged += new System.EventHandler(this.cmbEspec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidad";
            // 
            // GridPagoEspec
            // 
            this.GridPagoEspec.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GridPagoEspec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPagoEspec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEspec,
            this.cEspecialista,
            this.cBTurno,
            this.cModPago,
            this.cPCon,
            this.cPProc,
            this.cSOP,
            this.cEstado});
            this.GridPagoEspec.Location = new System.Drawing.Point(9, 97);
            this.GridPagoEspec.Name = "GridPagoEspec";
            this.GridPagoEspec.Size = new System.Drawing.Size(832, 172);
            this.GridPagoEspec.TabIndex = 1;
            // 
            // cEspec
            // 
            this.cEspec.HeaderText = "Especialidad";
            this.cEspec.Name = "cEspec";
            this.cEspec.Width = 200;
            // 
            // cEspecialista
            // 
            this.cEspecialista.HeaderText = "Especialista";
            this.cEspecialista.Name = "cEspecialista";
            this.cEspecialista.Width = 200;
            // 
            // cBTurno
            // 
            this.cBTurno.HeaderText = "B Turno";
            this.cBTurno.Name = "cBTurno";
            this.cBTurno.Width = 50;
            // 
            // cModPago
            // 
            this.cModPago.HeaderText = "Modo de Pago";
            this.cModPago.Name = "cModPago";
            // 
            // cPCon
            // 
            this.cPCon.HeaderText = "P Con.";
            this.cPCon.Name = "cPCon";
            this.cPCon.Width = 50;
            // 
            // cPProc
            // 
            this.cPProc.HeaderText = "P Proc.";
            this.cPProc.Name = "cPProc";
            this.cPProc.Width = 50;
            // 
            // cSOP
            // 
            this.cSOP.HeaderText = "P SOP";
            this.cSOP.Name = "cSOP";
            this.cSOP.Width = 50;
            // 
            // cEstado
            // 
            this.cEstado.HeaderText = "Estado";
            this.cEstado.Name = "cEstado";
            // 
            // frmGenParSalSpecialist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 286);
            this.ControlBox = false;
            this.Controls.Add(this.GridPagoEspec);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmGenParSalSpecialist";
            this.Text = "Generador de Parámetros de Pago por Especialista";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGenParSalSpecialist_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPagoEspec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbEspec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView GridPagoEspec;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEspec;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEstado;
    }
}