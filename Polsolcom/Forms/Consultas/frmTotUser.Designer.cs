namespace Polsolcom.Forms.Consultas
{
    partial class frmTotUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpFechas = new System.Windows.Forms.GroupBox();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.busesDS1 = new Polsolcom.Dominio.Data.BusesDS();
            this.grpVista = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.grdTotUser = new System.Windows.Forms.DataGridView();
            this.TDocV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.grdToTUser = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.txtAnul = new System.Windows.Forms.TextBox();
            this.txtVend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chckIngresos = new System.Windows.Forms.CheckBox();
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
=======
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            this.grpFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busesDS1)).BeginInit();
            this.grpVista.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha y Hora Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha y Hora Final";
            // 
            // grpFechas
            // 
<<<<<<< HEAD
            this.grpFechas.Controls.Add(this.button1);
            this.grpFechas.Controls.Add(this.dtpFechaInicial);
            this.grpFechas.Controls.Add(this.dtpFechaFinal);
=======
            this.grpFechas.Controls.Add(this.dtpFecIni);
            this.grpFechas.Controls.Add(this.dtpFecFin);
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            this.grpFechas.Controls.Add(this.btnSalir);
            this.grpFechas.Controls.Add(this.btnImprimir);
            this.grpFechas.Controls.Add(this.btnFiltro);
            this.grpFechas.Controls.Add(this.btnActualizar);
            this.grpFechas.Controls.Add(this.label1);
            this.grpFechas.Controls.Add(this.label2);
            this.grpFechas.Location = new System.Drawing.Point(7, 4);
            this.grpFechas.Name = "grpFechas";
            this.grpFechas.Size = new System.Drawing.Size(601, 100);
            this.grpFechas.TabIndex = 0;
            this.grpFechas.TabStop = false;
            // 
            // dtpFecIni
            // 
<<<<<<< HEAD
            this.dtpFechaInicial.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(16, 32);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(147, 20);
            this.dtpFechaInicial.TabIndex = 1;
=======
            this.dtpFecIni.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecIni.Location = new System.Drawing.Point(16, 32);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(147, 20);
            this.dtpFecIni.TabIndex = 12;
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            // 
            // dtpFecFin
            // 
<<<<<<< HEAD
            this.dtpFechaFinal.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(16, 74);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(147, 20);
            this.dtpFechaFinal.TabIndex = 3;
=======
            this.dtpFecFin.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecFin.Location = new System.Drawing.Point(16, 74);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(147, 20);
            this.dtpFecFin.TabIndex = 13;
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(507, 35);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 41);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(430, 35);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 41);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(273, 35);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 41);
            this.btnFiltro.TabIndex = 5;
            this.btnFiltro.Text = "&Filtra";
            this.btnFiltro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnActualizar
            // 
<<<<<<< HEAD
            this.btnActualiza.Location = new System.Drawing.Point(352, 35);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(75, 41);
            this.btnActualiza.TabIndex = 6;
            this.btnActualiza.Text = "Act&ualiza";
            this.btnActualiza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualiza.UseVisualStyleBackColor = true;
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
=======
            this.btnActualizar.Location = new System.Drawing.Point(352, 35);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 41);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Act&ualiza";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            // 
            // busesDS1
            // 
            this.busesDS1.DataSetName = "BusesDS";
            this.busesDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpVista
            // 
            this.grpVista.Controls.Add(this.grdToTUser);
            this.grpVista.Controls.Add(this.txtCantidad);
            this.grpVista.Controls.Add(this.txtTotal);
            this.grpVista.Controls.Add(this.txtExt);
            this.grpVista.Controls.Add(this.txtAnul);
            this.grpVista.Controls.Add(this.txtVend);
            this.grpVista.Controls.Add(this.label4);
            this.grpVista.Controls.Add(this.label3);
            this.grpVista.Controls.Add(this.chckIngresos);
            this.grpVista.Location = new System.Drawing.Point(9, 112);
            this.grpVista.Name = "grpVista";
            this.grpVista.Size = new System.Drawing.Size(601, 352);
            this.grpVista.TabIndex = 1;
            this.grpVista.TabStop = false;
            // 
<<<<<<< HEAD
            // grdTotUser
            // 
            this.grdTotUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdTotUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTotUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TDocV,
            this.NDVenta,
            this.Consultorio,
            this.Column3,
            this.Column1,
            this.Column2,
            this.Total});
            this.grdTotUser.Location = new System.Drawing.Point(8, 39);
            this.grdTotUser.Name = "grdTotUser";
            this.grdTotUser.Size = new System.Drawing.Size(581, 273);
            this.grdTotUser.TabIndex = 2;
            // 
            // TDocV
            // 
            this.TDocV.HeaderText = "Fecha";
            this.TDocV.Name = "TDocV";
            this.TDocV.Width = 150;
            // 
            // NDVenta
            // 
            this.NDVenta.HeaderText = "Cajero";
            this.NDVenta.Name = "NDVenta";
            // 
            // Consultorio
            // 
            this.Consultorio.HeaderText = "Vend.";
            this.Consultorio.Name = "Consultorio";
            this.Consultorio.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Anul.";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ext.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total S/.";
            this.Total.Name = "Total";
=======
            // grdToTUser
            // 
            this.grdToTUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.grdToTUser.FullRowSelect = true;
            this.grdToTUser.Location = new System.Drawing.Point(8, 34);
            this.grdToTUser.MultiSelect = false;
            this.grdToTUser.Name = "grdToTUser";
            this.grdToTUser.ShowItemToolTips = true;
            this.grdToTUser.Size = new System.Drawing.Size(587, 280);
            this.grdToTUser.TabIndex = 14;
            this.grdToTUser.UseCompatibleStateImageBehavior = false;
            this.grdToTUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cajero";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vend.";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Anul.";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ext.";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cantidad";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total S/.";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 90;
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(450, 320);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(52, 20);
<<<<<<< HEAD
            this.txtCantidad.TabIndex = 7;
=======
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.Text = "0";
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(510, 320);
            this.txtTotal.Name = "txtTotal";
<<<<<<< HEAD
            this.txtTotal.Size = new System.Drawing.Size(66, 20);
            this.txtTotal.TabIndex = 8;
=======
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(73, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Text = "0.00";
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(386, 320);
            this.txtExt.Name = "txtExt";
<<<<<<< HEAD
            this.txtExt.Size = new System.Drawing.Size(47, 20);
            this.txtExt.TabIndex = 6;
=======
            this.txtExt.ReadOnly = true;
            this.txtExt.Size = new System.Drawing.Size(58, 20);
            this.txtExt.TabIndex = 9;
            this.txtExt.Text = "0";
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            // 
            // txtAnul
            // 
            this.txtAnul.Location = new System.Drawing.Point(319, 320);
            this.txtAnul.Name = "txtAnul";
<<<<<<< HEAD
            this.txtAnul.Size = new System.Drawing.Size(47, 20);
            this.txtAnul.TabIndex = 5;
=======
            this.txtAnul.ReadOnly = true;
            this.txtAnul.Size = new System.Drawing.Size(62, 20);
            this.txtAnul.TabIndex = 8;
            this.txtAnul.Text = "0";
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            // 
            // txtVend
            // 
            this.txtVend.Location = new System.Drawing.Point(235, 320);
            this.txtVend.Name = "txtVend";
<<<<<<< HEAD
            this.txtVend.Size = new System.Drawing.Size(47, 20);
            this.txtVend.TabIndex = 4;
=======
            this.txtVend.ReadOnly = true;
            this.txtVend.Size = new System.Drawing.Size(79, 20);
            this.txtVend.TabIndex = 7;
            this.txtVend.Text = "0";
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(133, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total de Finales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(210, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tickects Emitidos";
            // 
            // chckIngresos
            // 
            this.chckIngresos.AutoSize = true;
            this.chckIngresos.Location = new System.Drawing.Point(404, 14);
            this.chckIngresos.Name = "chckIngresos";
            this.chckIngresos.Size = new System.Drawing.Size(66, 17);
            this.chckIngresos.TabIndex = 0;
            this.chckIngresos.Text = "Ingresos";
            this.chckIngresos.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
            // frmTotUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 473);
            this.ControlBox = false;
            this.Controls.Add(this.grpVista);
            this.Controls.Add(this.grpFechas);
            this.KeyPreview = true;
            this.Name = "frmTotUser";
            this.Text = "Resumen Diario por Cajero";
            this.Load += new System.EventHandler(this.frmTotUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTotUser_KeyDown);
            this.grpFechas.ResumeLayout(false);
            this.grpFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busesDS1)).EndInit();
            this.grpVista.ResumeLayout(false);
            this.grpVista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpFechas;
        private Dominio.Data.BusesDS busesDS1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grpVista;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.TextBox txtAnul;
        private System.Windows.Forms.TextBox txtVend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chckIngresos;
<<<<<<< HEAD
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DataGridView grdTotUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDocV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button1;
=======
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.ListView grdToTUser;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
>>>>>>> b108115ada264d06dfa388834bfe95c177878181
    }
}