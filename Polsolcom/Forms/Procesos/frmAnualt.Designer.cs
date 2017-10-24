namespace Polsolcom.Forms.Procesos
{
    partial class frmAnualt
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
            this.cmbTDoc = new System.Windows.Forms.ComboBox();
            this.docVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtNDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.grdAnualt = new System.Windows.Forms.DataGridView();
            this.docVentaTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.DocVentaTableAdapter();
            this.gTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gMA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gNR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.docVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnualt)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTDoc
            // 
            this.cmbTDoc.DataSource = this.docVentaBindingSource;
            this.cmbTDoc.DisplayMember = "Descripcion";
            this.cmbTDoc.FormattingEnabled = true;
            this.cmbTDoc.Location = new System.Drawing.Point(149, 6);
            this.cmbTDoc.Name = "cmbTDoc";
            this.cmbTDoc.Size = new System.Drawing.Size(123, 21);
            this.cmbTDoc.TabIndex = 0;
            this.cmbTDoc.ValueMember = "Id_Tipo";
            // 
            // docVentaBindingSource
            // 
            this.docVentaBindingSource.DataMember = "DocVenta";
            this.docVentaBindingSource.DataSource = this.tablaTipoDS;
            // 
            // tablaTipoDS
            // 
            this.tablaTipoDS.DataSetName = "TablaTipoDS";
            this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(330, 7);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(98, 20);
            this.txtSerie.TabIndex = 1;
            // 
            // txtNDoc
            // 
            this.txtNDoc.Location = new System.Drawing.Point(601, 7);
            this.txtNDoc.Name = "txtNDoc";
            this.txtNDoc.Size = new System.Drawing.Size(98, 20);
            this.txtNDoc.TabIndex = 2;
            this.txtNDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNDoc_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo Documento Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "N. Documento de Venta";
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(753, 6);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(129, 29);
            this.btnAnular.TabIndex = 6;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // grdAnualt
            // 
            this.grdAnualt.AllowUserToAddRows = false;
            this.grdAnualt.AllowUserToDeleteRows = false;
            this.grdAnualt.AllowUserToOrderColumns = true;
            this.grdAnualt.AllowUserToResizeColumns = false;
            this.grdAnualt.AllowUserToResizeRows = false;
            this.grdAnualt.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdAnualt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAnualt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gTD,
            this.gND,
            this.gFV,
            this.gNP,
            this.gNE,
            this.gFA,
            this.gNC,
            this.gTT,
            this.gMA,
            this.gNR});
            this.grdAnualt.Location = new System.Drawing.Point(8, 40);
            this.grdAnualt.MultiSelect = false;
            this.grdAnualt.Name = "grdAnualt";
            this.grdAnualt.RowHeadersVisible = false;
            this.grdAnualt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAnualt.Size = new System.Drawing.Size(874, 393);
            this.grdAnualt.TabIndex = 7;
            this.grdAnualt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grdAnualt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdAnualt_KeyDown);
            // 
            // docVentaTableAdapter
            // 
            this.docVentaTableAdapter.ClearBeforeFill = true;
            // 
            // gTD
            // 
            this.gTD.HeaderText = "TDocV";
            this.gTD.Name = "gTD";
            this.gTD.ReadOnly = true;
            this.gTD.Width = 60;
            // 
            // gND
            // 
            this.gND.HeaderText = "NDVenta";
            this.gND.Name = "gND";
            this.gND.ReadOnly = true;
            this.gND.Width = 60;
            // 
            // gFV
            // 
            this.gFV.HeaderText = "FVenta";
            this.gFV.Name = "gFV";
            this.gFV.ReadOnly = true;
            this.gFV.Width = 80;
            // 
            // gNP
            // 
            this.gNP.HeaderText = "Paciente";
            this.gNP.Name = "gNP";
            this.gNP.ReadOnly = true;
            this.gNP.Width = 170;
            // 
            // gNE
            // 
            this.gNE.HeaderText = "Especialidad";
            this.gNE.Name = "gNE";
            this.gNE.ReadOnly = true;
            this.gNE.Width = 150;
            // 
            // gFA
            // 
            this.gFA.HeaderText = "FAtencion";
            this.gFA.Name = "gFA";
            this.gFA.ReadOnly = true;
            this.gFA.Width = 80;
            // 
            // gNC
            // 
            this.gNC.HeaderText = "Consultorio";
            this.gNC.Name = "gNC";
            this.gNC.ReadOnly = true;
            this.gNC.Width = 150;
            // 
            // gTT
            // 
            this.gTT.HeaderText = "Total";
            this.gTT.Name = "gTT";
            this.gTT.ReadOnly = true;
            this.gTT.Width = 80;
            // 
            // gMA
            // 
            this.gMA.HeaderText = "Anul";
            this.gMA.Name = "gMA";
            this.gMA.Width = 40;
            // 
            // gNR
            // 
            this.gNR.HeaderText = "NR";
            this.gNR.Name = "gNR";
            this.gNR.ReadOnly = true;
            this.gNR.Visible = false;
            // 
            // frmAnualt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 441);
            this.Controls.Add(this.grdAnualt);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNDoc);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.cmbTDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmAnualt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anulacion Especial";
            this.Load += new System.EventHandler(this.frmAnualt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAnualt_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.docVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnualt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTDoc;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtNDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView grdAnualt;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource docVentaBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.DocVentaTableAdapter docVentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn gND;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNE;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFA;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNR;
    }
}