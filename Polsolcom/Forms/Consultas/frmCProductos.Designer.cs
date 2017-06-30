﻿namespace Polsolcom.Forms
{
    partial class frmCProductos
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
            this.fGrid = new TenTec.Windows.iGridLib.iGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.consultoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.tablaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProductoDS = new Polsolcom.Dominio.Data.TipoProductoDS();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.consultoriosTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.ConsultoriosTableAdapter();
            this.tablaTipoTableAdapter = new Polsolcom.Dominio.Data.TipoProductoDSTableAdapters.TablaTipoTableAdapter();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // fGrid
            // 
            this.fGrid.Location = new System.Drawing.Point(6, 200);
            this.fGrid.Name = "fGrid";
            this.fGrid.ReadOnly = true;
            this.fGrid.Size = new System.Drawing.Size(570, 176);
            this.fGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Especialidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DataSource = this.consultoriosBindingSource;
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(186, 43);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(244, 21);
            this.cmbEspecialidad.TabIndex = 1;
            this.cmbEspecialidad.ValueMember = "Id_Consultorio";
            this.cmbEspecialidad.SelectedValueChanged += new System.EventHandler(this.cmbEspecialidad_SelectedValueChanged);
            // 
            // consultoriosBindingSource
            // 
            this.consultoriosBindingSource.DataMember = "Consultorios";
            this.consultoriosBindingSource.DataSource = this.consultoriosDS;
            // 
            // consultoriosDS
            // 
            this.consultoriosDS.DataSetName = "ConsultoriosDS";
            this.consultoriosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre del Producto";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataSource = this.tablaTipoBindingSource;
            this.cmbTipo.DisplayMember = "Descripcion";
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(123, 123);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 7;
            this.cmbTipo.ValueMember = "Id_Tipo";
            this.cmbTipo.SelectedValueChanged += new System.EventHandler(this.cmbTipo_SelectedValueChanged);
            // 
            // tablaTipoBindingSource
            // 
            this.tablaTipoBindingSource.DataMember = "TablaTipo";
            this.tablaTipoBindingSource.DataSource = this.tipoProductoDS;
            // 
            // tipoProductoDS
            // 
            this.tipoProductoDS.DataSetName = "TipoProductoDS";
            this.tipoProductoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(331, 123);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(99, 20);
            this.txtIdProd.TabIndex = 8;
            this.txtIdProd.TextChanged += new System.EventHandler(this.txtIdProd_TextChanged);
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(479, 123);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(100, 20);
            this.txtPrec.TabIndex = 9;
            this.txtPrec.TextChanged += new System.EventHandler(this.txtPrec_TextChanged);
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(145, 164);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(285, 20);
            this.txtProd.TabIndex = 10;
            this.txtProd.TextChanged += new System.EventHandler(this.txtProd_TextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(479, 43);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 65);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(479, 164);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.ReadOnly = true;
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 12;
            this.txtSuma.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Suma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(13, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tarifario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.MenuText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(24, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(536, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "[F2] = Limpiar criterios [F9] = Imprimir tarifario [F11] = Sumar precios [F12] = " +
    "Limpiar precios sumados [ESC] = Salir";
            // 
            // consultoriosTableAdapter
            // 
            this.consultoriosTableAdapter.ClearBeforeFill = true;
            // 
            // tablaTipoTableAdapter
            // 
            this.tablaTipoTableAdapter.ClearBeforeFill = true;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(17, 71);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ReadOnly = true;
            this.txtObservacion.Size = new System.Drawing.Size(413, 43);
            this.txtObservacion.TabIndex = 18;
            // 
            // frmCProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 402);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.txtPrec);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCProductos";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmTarProducts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCProductos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtPrec;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.ConsultoriosTableAdapter consultoriosTableAdapter;
        private Dominio.Data.TipoProductoDS tipoProductoDS;
        private Dominio.Data.TipoProductoDSTableAdapters.TablaTipoTableAdapter tablaTipoTableAdapter;
        private System.Windows.Forms.BindingSource tablaTipoBindingSource;
        private System.Windows.Forms.BindingSource consultoriosBindingSource;
        private TenTec.Windows.iGridLib.iGrid fGrid;
        private System.Windows.Forms.TextBox txtObservacion;
    }
}