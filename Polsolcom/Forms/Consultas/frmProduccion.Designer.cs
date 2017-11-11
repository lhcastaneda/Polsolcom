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
            this.fGrid = new TenTec.Windows.iGridLib.iGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.consultoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCajero = new System.Windows.Forms.ComboBox();
            this.cajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajerosDS = new Polsolcom.Dominio.Data.CajerosDS();
            this.btnTimer = new System.Windows.Forms.Button();
            this.dtpFechInicio = new System.Windows.Forms.DateTimePicker();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFechFinal = new System.Windows.Forms.DateTimePicker();
            this.tmrSelec = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
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
            this.cajerosTableAdapter = new Polsolcom.Dominio.Data.CajerosDSTableAdapters.CajerosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajerosDS)).BeginInit();
            this.pnlCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // fGrid
            // 
            this.fGrid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fGrid.Header.Height = 19;
            this.fGrid.Location = new System.Drawing.Point(6, 110);
            this.fGrid.Name = "fGrid";
            this.fGrid.ReadOnly = true;
            this.fGrid.Size = new System.Drawing.Size(805, 250);
            this.fGrid.TabIndex = 13;
            this.fGrid.TreeCol = null;
            this.fGrid.TreeLines.Color = System.Drawing.SystemColors.WindowText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(10, 9);
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
            this.cmbEspecialidad.Location = new System.Drawing.Point(10, 26);
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
            this.label2.Location = new System.Drawing.Point(271, 7);
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
            this.cmbCajero.Location = new System.Drawing.Point(273, 26);
            this.cmbCajero.Name = "cmbCajero";
            this.cmbCajero.Size = new System.Drawing.Size(157, 21);
            this.cmbCajero.TabIndex = 3;
            this.cmbCajero.ValueMember = "Id_User";
            // 
            // cajerosBindingSource
            // 
            this.cajerosBindingSource.DataMember = "Cajeros";
            this.cajerosBindingSource.DataSource = this.cajerosDS;
            // 
            // cajerosDS
            // 
            this.cajerosDS.DataSetName = "CajerosDS";
            this.cajerosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(387, 55);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(45, 33);
            this.btnTimer.TabIndex = 8;
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Visible = false;
            // 
            // dtpFechInicio
            // 
            this.dtpFechInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechInicio.Location = new System.Drawing.Point(12, 70);
            this.dtpFechInicio.Name = "dtpFechInicio";
            this.dtpFechInicio.Size = new System.Drawing.Size(160, 20);
            this.dtpFechInicio.TabIndex = 5;
            this.dtpFechInicio.ValueChanged += new System.EventHandler(this.dtpFechInicio_ValueChanged);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(712, 4);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(97, 31);
            this.btnEjecutar.TabIndex = 10;
            this.btnEjecutar.Text = "&Ejecutar";
            this.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(712, 38);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 31);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(712, 71);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 31);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtpFechFinal
            // 
            this.dtpFechFinal.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechFinal.Location = new System.Drawing.Point(183, 69);
            this.dtpFechFinal.Name = "dtpFechFinal";
            this.dtpFechFinal.Size = new System.Drawing.Size(156, 20);
            this.dtpFechFinal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(11, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione Fecha Inicial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(513, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Vendidos S/.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(513, 395);
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
            this.label10.Location = new System.Drawing.Point(513, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total Final S/,";
            // 
            // txtcVen
            // 
            this.txtcVen.Location = new System.Drawing.Point(624, 365);
            this.txtcVen.Name = "txtcVen";
            this.txtcVen.ReadOnly = true;
            this.txtcVen.Size = new System.Drawing.Size(91, 20);
            this.txtcVen.TabIndex = 15;
            // 
            // txtcExt
            // 
            this.txtcExt.Location = new System.Drawing.Point(624, 392);
            this.txtcExt.Name = "txtcExt";
            this.txtcExt.ReadOnly = true;
            this.txtcExt.Size = new System.Drawing.Size(91, 20);
            this.txtcExt.TabIndex = 20;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(624, 418);
            this.txtCant.Name = "txtCant";
            this.txtCant.ReadOnly = true;
            this.txtCant.Size = new System.Drawing.Size(91, 20);
            this.txtCant.TabIndex = 0;
            // 
            // txtsVen
            // 
            this.txtsVen.Location = new System.Drawing.Point(721, 365);
            this.txtsVen.Name = "txtsVen";
            this.txtsVen.ReadOnly = true;
            this.txtsVen.Size = new System.Drawing.Size(91, 20);
            this.txtsVen.TabIndex = 18;
            // 
            // txtsExt
            // 
            this.txtsExt.Location = new System.Drawing.Point(722, 392);
            this.txtsExt.Name = "txtsExt";
            this.txtsExt.ReadOnly = true;
            this.txtsExt.Size = new System.Drawing.Size(90, 20);
            this.txtsExt.TabIndex = 21;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(722, 419);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(90, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.rbExtorno);
            this.pnlCheck.Controls.Add(this.rbAnulado);
            this.pnlCheck.Controls.Add(this.rbVendido);
            this.pnlCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCheck.Location = new System.Drawing.Point(517, 4);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(104, 93);
            this.pnlCheck.TabIndex = 9;
            // 
            // rbExtorno
            // 
            this.rbExtorno.AutoSize = true;
            this.rbExtorno.Location = new System.Drawing.Point(14, 62);
            this.rbExtorno.Name = "rbExtorno";
            this.rbExtorno.Size = new System.Drawing.Size(74, 19);
            this.rbExtorno.TabIndex = 2;
            this.rbExtorno.Text = "Extorno";
            this.rbExtorno.UseVisualStyleBackColor = true;
            // 
            // rbAnulado
            // 
            this.rbAnulado.AutoSize = true;
            this.rbAnulado.Location = new System.Drawing.Point(13, 37);
            this.rbAnulado.Name = "rbAnulado";
            this.rbAnulado.Size = new System.Drawing.Size(77, 19);
            this.rbAnulado.TabIndex = 1;
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
            this.rbVendido.TabIndex = 0;
            this.rbVendido.TabStop = true;
            this.rbVendido.Text = "Vendido";
            this.rbVendido.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(180, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Seleccione Fecha Final:";
            // 
            // consultoriosTableAdapter
            // 
            this.consultoriosTableAdapter.ClearBeforeFill = true;
            // 
            // cajerosTableAdapter
            // 
            this.cajerosTableAdapter.ClearBeforeFill = true;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 451);
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
            this.Controls.Add(this.fGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Detallado de los Cajeros";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduccion_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajerosDS)).EndInit();
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
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
        private TenTec.Windows.iGridLib.iGrid fGrid;
        private System.Windows.Forms.BindingSource cajerosBindingSource;
        private Dominio.Data.CajerosDS cajerosDS;
        private Dominio.Data.CajerosDSTableAdapters.CajerosTableAdapter cajerosTableAdapter;
    }
}