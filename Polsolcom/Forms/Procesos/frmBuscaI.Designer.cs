namespace Polsolcom.Forms.Procesos
{
    partial class frmBuscaI
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbTInst = new System.Windows.Forms.ComboBox();
			this.tipoInstitucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
			this.rb1 = new System.Windows.Forms.RadioButton();
			this.rb2 = new System.Windows.Forms.RadioButton();
			this.txtCriterio = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lstBuscar = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tipoInstitucionTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.TipoInstitucionTableAdapter();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tipoInstitucionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbTInst);
			this.groupBox1.Location = new System.Drawing.Point(2, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(156, 43);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo de empresa";
			// 
			// cmbTInst
			// 
			this.cmbTInst.DataSource = this.tipoInstitucionBindingSource;
			this.cmbTInst.DisplayMember = "Descripcion";
			this.cmbTInst.FormattingEnabled = true;
			this.cmbTInst.Location = new System.Drawing.Point(5, 15);
			this.cmbTInst.Name = "cmbTInst";
			this.cmbTInst.Size = new System.Drawing.Size(144, 21);
			this.cmbTInst.TabIndex = 0;
			this.cmbTInst.ValueMember = "Id_Tipo";
			this.cmbTInst.SelectionChangeCommitted += new System.EventHandler(this.cmbTInst_SelectionChangeCommitted);
			this.cmbTInst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTInst_KeyDown);
			// 
			// tipoInstitucionBindingSource
			// 
			this.tipoInstitucionBindingSource.DataMember = "TipoInstitucion";
			this.tipoInstitucionBindingSource.DataSource = this.tablaTipoDS;
			// 
			// tablaTipoDS
			// 
			this.tablaTipoDS.DataSetName = "TablaTipoDS";
			this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// rb1
			// 
			this.rb1.AutoSize = true;
			this.rb1.Checked = true;
			this.rb1.Location = new System.Drawing.Point(184, 4);
			this.rb1.Name = "rb1";
			this.rb1.Size = new System.Drawing.Size(130, 17);
			this.rb1.TabIndex = 1;
			this.rb1.TabStop = true;
			this.rb1.Text = "Nombre o razón social";
			this.rb1.UseVisualStyleBackColor = true;
			// 
			// rb2
			// 
			this.rb2.AutoSize = true;
			this.rb2.Location = new System.Drawing.Point(323, 4);
			this.rb2.Name = "rb2";
			this.rb2.Size = new System.Drawing.Size(139, 17);
			this.rb2.TabIndex = 2;
			this.rb2.Text = "Dirección de la empresa";
			this.rb2.UseVisualStyleBackColor = true;
			// 
			// txtCriterio
			// 
			this.txtCriterio.Location = new System.Drawing.Point(170, 21);
			this.txtCriterio.Name = "txtCriterio";
			this.txtCriterio.Size = new System.Drawing.Size(300, 20);
			this.txtCriterio.TabIndex = 3;
			this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(3, 6);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "&Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(84, 6);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnAceptar);
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Location = new System.Drawing.Point(473, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(166, 37);
			this.panel1.TabIndex = 6;
			// 
			// lstBuscar
			// 
			this.lstBuscar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lstBuscar.FullRowSelect = true;
			this.lstBuscar.Location = new System.Drawing.Point(3, 54);
			this.lstBuscar.MultiSelect = false;
			this.lstBuscar.Name = "lstBuscar";
			this.lstBuscar.Size = new System.Drawing.Size(638, 204);
			this.lstBuscar.TabIndex = 7;
			this.lstBuscar.UseCompatibleStateImageBehavior = false;
			this.lstBuscar.View = System.Windows.Forms.View.Details;
			this.lstBuscar.SelectedIndexChanged += new System.EventHandler(this.lstBuscar_SelectedIndexChanged);
			this.lstBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstBuscar_KeyDown);
			this.lstBuscar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBuscar_MouseDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Nombre o razón social";
			this.columnHeader1.Width = 310;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Dirección de la empresa o institución";
			this.columnHeader2.Width = 310;
			// 
			// tipoInstitucionTableAdapter
			// 
			this.tipoInstitucionTableAdapter.ClearBeforeFill = true;
			// 
			// frmBuscaI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 261);
			this.Controls.Add(this.lstBuscar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtCriterio);
			this.Controls.Add(this.rb2);
			this.Controls.Add(this.rb1);
			this.Controls.Add(this.groupBox1);
			this.KeyPreview = true;
			this.Name = "frmBuscaI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Busqueda de empresas o instituciones";
			this.Load += new System.EventHandler(this.frmBuscaI_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaI_KeyDown);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tipoInstitucionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTInst;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstBuscar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource tipoInstitucionBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.TipoInstitucionTableAdapter tipoInstitucionTableAdapter;
    }
}