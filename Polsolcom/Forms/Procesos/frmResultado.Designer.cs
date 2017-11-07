namespace Polsolcom.Forms.Procesos
{
    partial class frmResultado
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
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.dNroHistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dConclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cmbParticular = new System.Windows.Forms.ComboBox();
            this.plantillasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantillasDS = new Polsolcom.Dominio.Data.PlantillasDS();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtConclusion = new System.Windows.Forms.TextBox();
            this.plantillasTableAdapter = new Polsolcom.Dominio.Data.PlantillasDSTableAdapters.PlantillasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantillasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantillasDS)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.AllowUserToOrderColumns = true;
            this.grdProductos.AllowUserToResizeColumns = false;
            this.grdProductos.AllowUserToResizeRows = false;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNroHistoria,
            this.dIdProducto,
            this.dProducto,
            this.dCantidad,
            this.dPrecio,
            this.dTotal,
            this.dPagado,
            this.dDescuento,
            this.dResultado,
            this.dConclusion,
            this.dM});
            this.grdProductos.Location = new System.Drawing.Point(4, 2);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdProductos.Size = new System.Drawing.Size(312, 73);
            this.grdProductos.TabIndex = 0;
            this.grdProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductos_CellEnter);
            this.grdProductos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProductos_EditingControlShowing);
            // 
            // dNroHistoria
            // 
            this.dNroHistoria.HeaderText = "Nro Historia";
            this.dNroHistoria.Name = "dNroHistoria";
            this.dNroHistoria.ReadOnly = true;
            this.dNroHistoria.Visible = false;
            // 
            // dIdProducto
            // 
            this.dIdProducto.HeaderText = "Id Producto";
            this.dIdProducto.Name = "dIdProducto";
            this.dIdProducto.ReadOnly = true;
            this.dIdProducto.Visible = false;
            // 
            // dProducto
            // 
            this.dProducto.HeaderText = "Producto y/o servicio";
            this.dProducto.Name = "dProducto";
            this.dProducto.ReadOnly = true;
            this.dProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dProducto.Width = 200;
            // 
            // dCantidad
            // 
            this.dCantidad.HeaderText = "Cantidad";
            this.dCantidad.Name = "dCantidad";
            this.dCantidad.ReadOnly = true;
            this.dCantidad.Visible = false;
            // 
            // dPrecio
            // 
            this.dPrecio.HeaderText = "Precio";
            this.dPrecio.Name = "dPrecio";
            this.dPrecio.ReadOnly = true;
            this.dPrecio.Visible = false;
            // 
            // dTotal
            // 
            this.dTotal.HeaderText = "Total";
            this.dTotal.Name = "dTotal";
            this.dTotal.ReadOnly = true;
            this.dTotal.Visible = false;
            // 
            // dPagado
            // 
            this.dPagado.HeaderText = "Pagado";
            this.dPagado.Name = "dPagado";
            this.dPagado.ReadOnly = true;
            this.dPagado.Visible = false;
            // 
            // dDescuento
            // 
            this.dDescuento.HeaderText = "Descuento";
            this.dDescuento.Name = "dDescuento";
            this.dDescuento.ReadOnly = true;
            this.dDescuento.Visible = false;
            // 
            // dResultado
            // 
            this.dResultado.HeaderText = "Resultado";
            this.dResultado.Name = "dResultado";
            this.dResultado.ReadOnly = true;
            this.dResultado.Visible = false;
            // 
            // dConclusion
            // 
            this.dConclusion.HeaderText = "Conclusión";
            this.dConclusion.Name = "dConclusion";
            this.dConclusion.ReadOnly = true;
            this.dConclusion.Visible = false;
            // 
            // dM
            // 
            this.dM.HeaderText = "*";
            this.dM.Name = "dM";
            this.dM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dM.Width = 50;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(322, 12);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(128, 27);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(324, 48);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(128, 27);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbParticular
            // 
            this.cmbParticular.DataSource = this.plantillasBindingSource;
            this.cmbParticular.DisplayMember = "id_part";
            this.cmbParticular.FormattingEnabled = true;
            this.cmbParticular.Location = new System.Drawing.Point(103, 90);
            this.cmbParticular.Name = "cmbParticular";
            this.cmbParticular.Size = new System.Drawing.Size(192, 21);
            this.cmbParticular.TabIndex = 3;
            this.cmbParticular.ValueMember = "id_part";
            this.cmbParticular.SelectionChangeCommitted += new System.EventHandler(this.cmbParticular_SelectionChangeCommitted);
            // 
            // plantillasBindingSource
            // 
            this.plantillasBindingSource.DataMember = "Plantillas";
            this.plantillasBindingSource.DataSource = this.plantillasDS;
            // 
            // plantillasDS
            // 
            this.plantillasDS.DataSetName = "PlantillasDS";
            this.plantillasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(10, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Particularidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(9, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(11, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Conclusión:";
            // 
            // txtResultado
            // 
            this.txtResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResultado.Location = new System.Drawing.Point(12, 153);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(439, 125);
            this.txtResultado.TabIndex = 7;
            // 
            // txtConclusion
            // 
            this.txtConclusion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConclusion.Location = new System.Drawing.Point(13, 307);
            this.txtConclusion.Multiline = true;
            this.txtConclusion.Name = "txtConclusion";
            this.txtConclusion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConclusion.Size = new System.Drawing.Size(439, 125);
            this.txtConclusion.TabIndex = 8;
            // 
            // plantillasTableAdapter
            // 
            this.plantillasTableAdapter.ClearBeforeFill = true;
            // 
            // frmResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 449);
            this.ControlBox = false;
            this.Controls.Add(this.txtConclusion);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbParticular);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.grdProductos);
            this.KeyPreview = true;
            this.Name = "frmResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Resultados...";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmResultado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantillasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantillasDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cmbParticular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtConclusion;
        private System.Windows.Forms.BindingSource plantillasBindingSource;
        private Dominio.Data.PlantillasDS plantillasDS;
        private Dominio.Data.PlantillasDSTableAdapters.PlantillasTableAdapter plantillasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNroHistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dConclusion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dM;
    }
}