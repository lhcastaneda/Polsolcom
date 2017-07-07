namespace Polsolcom.Forms
{
    partial class frmTalonario
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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCuenta = new System.Windows.Forms.TextBox();
			this.txtNFinal = new System.Windows.Forms.TextBox();
			this.txtNInicial = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSerie = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbDocVenta = new System.Windows.Forms.ComboBox();
			this.tablaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tipoDocumento = new Polsolcom.Dominio.Data.TipoDocumento();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.cmbDefault = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbIngresar = new System.Windows.Forms.Button();
			this.tablaTipoTableAdapter = new Polsolcom.Dominio.Data.TipoDocumentoTableAdapters.TablaTipoTableAdapter();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoDocumento)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCuenta);
			this.groupBox1.Controls.Add(this.txtNFinal);
			this.groupBox1.Controls.Add(this.txtNInicial);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtSerie);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbDocVenta);
			this.groupBox1.Controls.Add(this.txtFecha);
			this.groupBox1.Controls.Add(this.cmbDefault);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(4, -4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(258, 102);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			// 
			// txtCuenta
			// 
			this.txtCuenta.Enabled = false;
			this.txtCuenta.Location = new System.Drawing.Point(185, 77);
			this.txtCuenta.Name = "txtCuenta";
			this.txtCuenta.Size = new System.Drawing.Size(68, 20);
			this.txtCuenta.TabIndex = 6;
			this.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNFinal
			// 
			this.txtNFinal.Location = new System.Drawing.Point(114, 77);
			this.txtNFinal.Name = "txtNFinal";
			this.txtNFinal.Size = new System.Drawing.Size(68, 20);
			this.txtNFinal.TabIndex = 5;
			this.txtNFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNFinal.Enter += new System.EventHandler(this.txtNFinal_Enter);
			this.txtNFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNFinal_KeyDown);
			this.txtNFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNFinal_KeyPress);
			// 
			// txtNInicial
			// 
			this.txtNInicial.Location = new System.Drawing.Point(43, 77);
			this.txtNInicial.Name = "txtNInicial";
			this.txtNInicial.Size = new System.Drawing.Size(68, 20);
			this.txtNInicial.TabIndex = 4;
			this.txtNInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNInicial.TextChanged += new System.EventHandler(this.txtNInicial_TextChanged);
			this.txtNInicial.Enter += new System.EventHandler(this.txtNInicial_Enter);
			this.txtNInicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNInicial_KeyDown);
			this.txtNInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNInicial_KeyPress);
			this.txtNInicial.Leave += new System.EventHandler(this.txtNInicial_Leave);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Navy;
			this.label7.Location = new System.Drawing.Point(186, 61);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 13);
			this.label7.TabIndex = 24;
			this.label7.Text = "N° Cuenta";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Navy;
			this.label6.Location = new System.Drawing.Point(120, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 23;
			this.label6.Text = "N° Final";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(48, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 22;
			this.label5.Text = "N° Inicial";
			// 
			// txtSerie
			// 
			this.txtSerie.Location = new System.Drawing.Point(6, 77);
			this.txtSerie.Name = "txtSerie";
			this.txtSerie.Size = new System.Drawing.Size(34, 20);
			this.txtSerie.TabIndex = 3;
			this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie_KeyDown);
			this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Navy;
			this.label4.Location = new System.Drawing.Point(4, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Serie";
			// 
			// cmbDocVenta
			// 
			this.cmbDocVenta.DataSource = this.tablaTipoBindingSource;
			this.cmbDocVenta.DisplayMember = "Descripcion";
			this.cmbDocVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDocVenta.FormattingEnabled = true;
			this.cmbDocVenta.Location = new System.Drawing.Point(176, 30);
			this.cmbDocVenta.Name = "cmbDocVenta";
			this.cmbDocVenta.Size = new System.Drawing.Size(76, 21);
			this.cmbDocVenta.TabIndex = 2;
			this.cmbDocVenta.SelectedIndexChanged += new System.EventHandler(this.cmbDocVenta_SelectedIndexChanged);
			this.cmbDocVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDocVenta_KeyDown);
			// 
			// tablaTipoBindingSource
			// 
			this.tablaTipoBindingSource.DataMember = "TablaTipo";
			this.tablaTipoBindingSource.DataSource = this.tipoDocumentoBindingSource;
			// 
			// tipoDocumentoBindingSource
			// 
			this.tipoDocumentoBindingSource.DataSource = this.tipoDocumento;
			this.tipoDocumentoBindingSource.Position = 0;
			// 
			// tipoDocumento
			// 
			this.tipoDocumento.DataSetName = "TipoDocumento";
			this.tipoDocumento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// txtFecha
			// 
			this.txtFecha.Enabled = false;
			this.txtFecha.Location = new System.Drawing.Point(58, 30);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(116, 20);
			this.txtFecha.TabIndex = 1;
			this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmbDefault
			// 
			this.cmbDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDefault.FormattingEnabled = true;
			this.cmbDefault.Items.AddRange(new object[] {
            "SI",
            "NO"});
			this.cmbDefault.Location = new System.Drawing.Point(8, 30);
			this.cmbDefault.Name = "cmbDefault";
			this.cmbDefault.Size = new System.Drawing.Size(47, 21);
			this.cmbDefault.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Location = new System.Drawing.Point(179, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Doc. Venta";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(66, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "Fecha de Ingreso";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(7, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Default";
			// 
			// cmbIngresar
			// 
			this.cmbIngresar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmbIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbIngresar.Location = new System.Drawing.Point(174, 100);
			this.cmbIngresar.Name = "cmbIngresar";
			this.cmbIngresar.Size = new System.Drawing.Size(86, 27);
			this.cmbIngresar.TabIndex = 7;
			this.cmbIngresar.Text = "&Ingresar";
			this.cmbIngresar.UseVisualStyleBackColor = true;
			this.cmbIngresar.Click += new System.EventHandler(this.cmbIngresar_Click);
			// 
			// tablaTipoTableAdapter
			// 
			this.tablaTipoTableAdapter.ClearBeforeFill = true;
			// 
			// frmTalonario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 129);
			this.ControlBox = false;
			this.Controls.Add(this.cmbIngresar);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTalonario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingreso de Talon de Documentos de Venta";
			this.Load += new System.EventHandler(this.frmTalonario_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTalonario_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoDocumento)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtNFinal;
        private System.Windows.Forms.TextBox txtNInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDocVenta;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cmbDefault;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmbIngresar;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private Dominio.Data.TipoDocumento tipoDocumento;
        private System.Windows.Forms.BindingSource tablaTipoBindingSource;
        private Dominio.Data.TipoDocumentoTableAdapters.TablaTipoTableAdapter tablaTipoTableAdapter;
    }
}