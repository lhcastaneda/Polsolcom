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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduccion));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCajero = new System.Windows.Forms.ComboBox();
            this.btnTimer = new System.Windows.Forms.Button();
            this.dtpFechInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHorInicio = new System.Windows.Forms.DateTimePicker();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFechFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpHorFinal = new System.Windows.Forms.DateTimePicker();
            this.tmrSelec = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gdvDatos = new System.Windows.Forms.DataGridView();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProdSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDocVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcVen = new System.Windows.Forms.TextBox();
            this.txtcExt = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtsVen = new System.Windows.Forms.TextBox();
            this.txtsExt = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.chkVendido = new System.Windows.Forms.CheckBox();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.chkAnulado = new System.Windows.Forms.CheckBox();
            this.chkExtorno = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).BeginInit();
            this.pnlCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(13, 30);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(255, 21);
            this.cmbEspecialidad.TabIndex = 1;
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
            this.cmbCajero.FormattingEnabled = true;
            this.cmbCajero.Location = new System.Drawing.Point(274, 30);
            this.cmbCajero.Name = "cmbCajero";
            this.cmbCajero.Size = new System.Drawing.Size(157, 21);
            this.cmbCajero.TabIndex = 3;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(386, 94);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(45, 41);
            this.btnTimer.TabIndex = 4;
            this.btnTimer.UseVisualStyleBackColor = true;
            // 
            // dtpFechInicio
            // 
            this.dtpFechInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechInicio.Location = new System.Drawing.Point(91, 89);
            this.dtpFechInicio.Name = "dtpFechInicio";
            this.dtpFechInicio.Size = new System.Drawing.Size(106, 20);
            this.dtpFechInicio.TabIndex = 5;
            // 
            // dtpHorInicio
            // 
            this.dtpHorInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorInicio.Location = new System.Drawing.Point(91, 115);
            this.dtpHorInicio.Name = "dtpHorInicio";
            this.dtpHorInicio.Size = new System.Drawing.Size(106, 20);
            this.dtpHorInicio.TabIndex = 6;
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
            this.dtpFechFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechFinal.Location = new System.Drawing.Point(274, 89);
            this.dtpFechFinal.Name = "dtpFechFinal";
            this.dtpFechFinal.Size = new System.Drawing.Size(106, 20);
            this.dtpFechFinal.TabIndex = 10;
            // 
            // dtpHorFinal
            // 
            this.dtpHorFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorFinal.Location = new System.Drawing.Point(274, 115);
            this.dtpHorFinal.Name = "dtpHorFinal";
            this.dtpHorFinal.Size = new System.Drawing.Size(106, 20);
            this.dtpHorFinal.TabIndex = 11;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(13, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(204, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(204, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hora";
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
            // cTotal
            // 
            this.cTotal.HeaderText = "Total S/.";
            this.cTotal.Name = "cTotal";
            // 
            // cCant
            // 
            this.cCant.HeaderText = "Cantidad";
            this.cCant.Name = "cCant";
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio";
            this.cPrecio.Name = "cPrecio";
            // 
            // cProdSer
            // 
            this.cProdSer.HeaderText = "Producto / Servicio";
            this.cProdSer.Name = "cProdSer";
            this.cProdSer.Width = 200;
            // 
            // cEspecialidad
            // 
            this.cEspecialidad.HeaderText = "Especialidad";
            this.cEspecialidad.Name = "cEspecialidad";
            this.cEspecialidad.Width = 200;
            // 
            // cDocVenta
            // 
            this.cDocVenta.HeaderText = "Doc. Venta";
            this.cDocVenta.Name = "cDocVenta";
            this.cDocVenta.Width = 60;
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
            // chkVendido
            // 
            this.chkVendido.AutoSize = true;
            this.chkVendido.Location = new System.Drawing.Point(13, 13);
            this.chkVendido.Name = "chkVendido";
            this.chkVendido.Size = new System.Drawing.Size(78, 19);
            this.chkVendido.TabIndex = 27;
            this.chkVendido.Text = "&Vendido";
            this.chkVendido.UseVisualStyleBackColor = true;
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.chkExtorno);
            this.pnlCheck.Controls.Add(this.chkAnulado);
            this.pnlCheck.Controls.Add(this.chkVendido);
            this.pnlCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCheck.Location = new System.Drawing.Point(512, 32);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(93, 98);
            this.pnlCheck.TabIndex = 28;
            // 
            // chkAnulado
            // 
            this.chkAnulado.AutoSize = true;
            this.chkAnulado.Location = new System.Drawing.Point(13, 37);
            this.chkAnulado.Name = "chkAnulado";
            this.chkAnulado.Size = new System.Drawing.Size(78, 19);
            this.chkAnulado.TabIndex = 28;
            this.chkAnulado.Text = "A&nulado";
            this.chkAnulado.UseVisualStyleBackColor = true;
            // 
            // chkExtorno
            // 
            this.chkExtorno.AutoSize = true;
            this.chkExtorno.Location = new System.Drawing.Point(13, 61);
            this.chkExtorno.Name = "chkExtorno";
            this.chkExtorno.Size = new System.Drawing.Size(75, 19);
            this.chkExtorno.TabIndex = 29;
            this.chkExtorno.Text = "E&xtorno";
            this.chkExtorno.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(767, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(767, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(767, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 482);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHorFinal);
            this.Controls.Add(this.dtpFechFinal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dtpHorInicio);
            this.Controls.Add(this.dtpFechInicio);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.cmbCajero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label1);
            this.Name = "frmProduccion";
            this.Text = "Reporte Detallado de los Cajeros";
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).EndInit();
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpHorInicio;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpFechFinal;
        private System.Windows.Forms.DateTimePicker dtpHorFinal;
        private System.Windows.Forms.Timer tmrSelec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.CheckBox chkVendido;
        private System.Windows.Forms.Panel pnlCheck;
        private System.Windows.Forms.CheckBox chkExtorno;
        private System.Windows.Forms.CheckBox chkAnulado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}