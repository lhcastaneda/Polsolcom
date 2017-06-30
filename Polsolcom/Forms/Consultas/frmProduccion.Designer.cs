namespace Polsolcom.Forms
{
    partial class frmProduccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.consultoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCajero = new System.Windows.Forms.ComboBox();
            this.btnTimer = new System.Windows.Forms.Button();
            this.dtpFechInicio = new System.Windows.Forms.DateTimePicker();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFechFinal = new System.Windows.Forms.DateTimePicker();
            this.tmrSelec = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.gdvDatos = new System.Windows.Forms.DataGridView();
            this.cDocVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProdSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcVen = new System.Windows.Forms.TextBox();
            this.txtcExt = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtsVen = new System.Windows.Forms.TextBox();
            this.txtsExt = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.rbExtorno = new System.Windows.Forms.RadioButton();
            this.rbAnulado = new System.Windows.Forms.RadioButton();
            this.rbVendido = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.consultoriosTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.ConsultoriosTableAdapter();
            this.cajerosDS = new Polsolcom.Dominio.Data.CajerosDS();
            this.cajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajerosTableAdapter = new Polsolcom.Dominio.Data.CajerosDSTableAdapters.CajerosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).BeginInit();
            this.pnlCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajerosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajerosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Especialidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DataSource = this.consultoriosBindingSource;
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(13, 30);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(255, 21);
            this.cmbEspecialidad.TabIndex = 1;
            this.cmbEspecialidad.ValueMember = "Id_Consultorio";
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
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(271, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione cajer@";
            // 
            // cmbCajero
            // 
            this.cmbCajero.DataSource = this.cajerosBindingSource;
            this.cmbCajero.DisplayMember = "Usuario";
            this.cmbCajero.FormattingEnabled = true;
            this.cmbCajero.Location = new System.Drawing.Point(274, 30);
            this.cmbCajero.Name = "cmbCajero";
            this.cmbCajero.Size = new System.Drawing.Size(157, 21);
            this.cmbCajero.TabIndex = 3;
            this.cmbCajero.ValueMember = "Id_User";
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(378, 65);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(45, 41);
            this.btnTimer.TabIndex = 4;
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Visible = false;
            // 
            // dtpFechInicio
            // 
            this.dtpFechInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechInicio.Location = new System.Drawing.Point(12, 77);
            this.dtpFechInicio.Name = "dtpFechInicio";
            this.dtpFechInicio.Size = new System.Drawing.Size(139, 20);
            this.dtpFechInicio.TabIndex = 5;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(711, 15);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(97, 36);
            this.btnEjecutar.TabIndex = 7;
            this.btnEjecutar.Text = "&Ejecutar";
            this.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(711, 57);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 36);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(711, 99);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 36);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dtpFechFinal
            // 
            this.dtpFechFinal.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechFinal.Location = new System.Drawing.Point(207, 76);
            this.dtpFechFinal.Name = "dtpFechFinal";
            this.dtpFechFinal.Size = new System.Drawing.Size(138, 20);
            this.dtpFechFinal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seleccione Inicio";
            // 
            // gdvDatos
            // 
            this.gdvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDocVenta,
            this.cEspecialidad,
            this.cProdSer,
            this.cPrecio,
            this.cCant,
            this.cTotal});
            this.gdvDatos.Location = new System.Drawing.Point(13, 159);
            this.gdvDatos.Name = "gdvDatos";
            this.gdvDatos.Size = new System.Drawing.Size(795, 230);
            this.gdvDatos.TabIndex = 17;
            // 
            // cDocVenta
            // 
            this.cDocVenta.HeaderText = "Doc. Venta";
            this.cDocVenta.Name = "cDocVenta";
            this.cDocVenta.Width = 60;
            // 
            // cEspecialidad
            // 
            this.cEspecialidad.HeaderText = "Especialidad";
            this.cEspecialidad.Name = "cEspecialidad";
            this.cEspecialidad.Width = 200;
            // 
            // cProdSer
            // 
            this.cProdSer.HeaderText = "Producto / Servicio";
            this.cProdSer.Name = "cProdSer";
            this.cProdSer.Width = 200;
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio";
            this.cPrecio.Name = "cPrecio";
            // 
            // cCant
            // 
            this.cCant.HeaderText = "Cantidad";
            this.cCant.Name = "cCant";
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total S/.";
            this.cTotal.Name = "cTotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(509, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Vendidos S/.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(509, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total Extorno S/.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(509, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total Final S/,";
            // 
            // txtcVen
            // 
            this.txtcVen.Location = new System.Drawing.Point(620, 395);
            this.txtcVen.Name = "txtcVen";
            this.txtcVen.Size = new System.Drawing.Size(91, 20);
            this.txtcVen.TabIndex = 21;
            this.txtcVen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcExt
            // 
            this.txtcExt.Location = new System.Drawing.Point(620, 422);
            this.txtcExt.Name = "txtcExt";
            this.txtcExt.Size = new System.Drawing.Size(91, 20);
            this.txtcExt.TabIndex = 22;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(620, 448);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(91, 20);
            this.txtCant.TabIndex = 23;
            // 
            // txtsVen
            // 
            this.txtsVen.Location = new System.Drawing.Point(717, 395);
            this.txtsVen.Name = "txtsVen";
            this.txtsVen.Size = new System.Drawing.Size(91, 20);
            this.txtsVen.TabIndex = 24;
            // 
            // txtsExt
            // 
            this.txtsExt.Location = new System.Drawing.Point(718, 422);
            this.txtsExt.Name = "txtsExt";
            this.txtsExt.Size = new System.Drawing.Size(90, 20);
            this.txtsExt.TabIndex = 25;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(718, 449);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(90, 20);
            this.txtTotal.TabIndex = 26;
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.rbExtorno);
            this.pnlCheck.Controls.Add(this.rbAnulado);
            this.pnlCheck.Controls.Add(this.rbVendido);
            this.pnlCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCheck.Location = new System.Drawing.Point(512, 32);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(104, 93);
            this.pnlCheck.TabIndex = 28;
            // 
            // rbExtorno
            // 
            this.rbExtorno.AutoSize = true;
            this.rbExtorno.Location = new System.Drawing.Point(14, 62);
            this.rbExtorno.Name = "rbExtorno";
            this.rbExtorno.Size = new System.Drawing.Size(74, 19);
            this.rbExtorno.TabIndex = 32;
            this.rbExtorno.Text = "Extorno";
            this.rbExtorno.UseVisualStyleBackColor = true;
            // 
            // rbAnulado
            // 
            this.rbAnulado.AutoSize = true;
            this.rbAnulado.Location = new System.Drawing.Point(13, 37);
            this.rbAnulado.Name = "rbAnulado";
            this.rbAnulado.Size = new System.Drawing.Size(77, 19);
            this.rbAnulado.TabIndex = 31;
            this.rbAnulado.Text = "Anulado";
            this.rbAnulado.UseVisualStyleBackColor = true;
            // 
            // rbVendido
            // 
            this.rbVendido.AutoSize = true;
            this.rbVendido.Checked = true;
            this.rbVendido.Location = new System.Drawing.Point(13, 12);
            this.rbVendido.Name = "rbVendido";
            this.rbVendido.Size = new System.Drawing.Size(77, 19);
            this.rbVendido.TabIndex = 30;
            this.rbVendido.TabStop = true;
            this.rbVendido.Text = "Vendido";
            this.rbVendido.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(204, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Seleccione Final";
            // 
            // consultoriosTableAdapter
            // 
            this.consultoriosTableAdapter.ClearBeforeFill = true;
            // 
            // cajerosDS
            // 
            this.cajerosDS.DataSetName = "CajerosDS";
            this.cajerosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cajerosBindingSource
            // 
            this.cajerosBindingSource.DataMember = "Cajeros";
            this.cajerosBindingSource.DataSource = this.cajerosDS;
            // 
            // cajerosTableAdapter
            // 
            this.cajerosTableAdapter.ClearBeforeFill = true;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 482);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pnlCheck);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtsExt);
            this.Controls.Add(this.txtsVen);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtcExt);
            this.Controls.Add(this.txtcVen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gdvDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechFinal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dtpFechInicio);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.cmbCajero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmProduccion";
            this.Text = "Reporte Detallado de los Cajeros";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduccion_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).EndInit();
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajerosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajerosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCajero;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.DateTimePicker dtpFechInicio;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpFechFinal;
        private System.Windows.Forms.Timer tmrSelec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gdvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDocVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProdSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcVen;
        private System.Windows.Forms.TextBox txtcExt;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtsVen;
        private System.Windows.Forms.TextBox txtsExt;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel pnlCheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource consultoriosBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.ConsultoriosTableAdapter consultoriosTableAdapter;
        private System.Windows.Forms.RadioButton rbExtorno;
        private System.Windows.Forms.RadioButton rbAnulado;
        private System.Windows.Forms.RadioButton rbVendido;
        private System.Windows.Forms.BindingSource cajerosBindingSource;
        private Dominio.Data.CajerosDS cajerosDS;
        private Dominio.Data.CajerosDSTableAdapters.CajerosTableAdapter cajerosTableAdapter;
    }
}