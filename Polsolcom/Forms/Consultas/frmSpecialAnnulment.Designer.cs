namespace Polsolcom.Forms
{
    partial class frmSpecialAnnulment
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
            this.cmbTipDoc = new System.Windows.Forms.ComboBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.GridSpecialAnn = new System.Windows.Forms.DataGridView();
            this.TDocV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridSpecialAnn)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipDoc
            // 
            this.cmbTipDoc.FormattingEnabled = true;
            this.cmbTipDoc.Location = new System.Drawing.Point(152, 48);
            this.cmbTipDoc.Name = "cmbTipDoc";
            this.cmbTipDoc.Size = new System.Drawing.Size(123, 21);
            this.cmbTipDoc.TabIndex = 0;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(333, 49);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(98, 20);
            this.txtSerie.TabIndex = 1;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(604, 49);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(98, 20);
            this.txtNumDoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo Documento Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "N. Documento de Venta";
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(572, 397);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(129, 32);
            this.btnAnular.TabIndex = 6;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // GridSpecialAnn
            // 
            this.GridSpecialAnn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridSpecialAnn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSpecialAnn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TDocV,
            this.NDVenta,
            this.FVenta,
            this.Paciente,
            this.Especialidad,
            this.FAtencion,
            this.Consultorio,
            this.Total});
            this.GridSpecialAnn.Location = new System.Drawing.Point(12, 93);
            this.GridSpecialAnn.Name = "GridSpecialAnn";
            this.GridSpecialAnn.Size = new System.Drawing.Size(690, 284);
            this.GridSpecialAnn.TabIndex = 7;
            this.GridSpecialAnn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TDocV
            // 
            this.TDocV.HeaderText = "TDocV";
            this.TDocV.Name = "TDocV";
            // 
            // NDVenta
            // 
            this.NDVenta.HeaderText = "NDVenta";
            this.NDVenta.Name = "NDVenta";
            // 
            // FVenta
            // 
            this.FVenta.HeaderText = "FVenta";
            this.FVenta.Name = "FVenta";
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // FAtencion
            // 
            this.FAtencion.HeaderText = "FAtencion";
            this.FAtencion.Name = "FAtencion";
            // 
            // Consultorio
            // 
            this.Consultorio.HeaderText = "Consultorio";
            this.Consultorio.Name = "Consultorio";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(291, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Anulacion Especial";
            // 
            // frmSpecialAnnulment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GridSpecialAnn);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.cmbTipDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSpecialAnnulment";
            this.Text = "Anulacion Especial";
            ((System.ComponentModel.ISupportInitialize)(this.GridSpecialAnn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipDoc;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView GridSpecialAnn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDocV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label4;

    }
}