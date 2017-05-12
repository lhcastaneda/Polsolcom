namespace Polsolcom.Forms
{
    partial class frmNewTratamiento
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
            this.cmbPieza = new System.Windows.Forms.ComboBox();
            this.chklstTicket = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gdvDetalles = new System.Windows.Forms.DataGridView();
            this.cProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSelecProd = new System.Windows.Forms.ComboBox();
            this.cmbSelecTicket = new System.Windows.Forms.ComboBox();
            this.pnlProd = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.cmbOdontologo = new System.Windows.Forms.ComboBox();
            this.dtpFechAten = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles)).BeginInit();
            this.pnlProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro de Pieza";
            // 
            // cmbPieza
            // 
            this.cmbPieza.FormattingEnabled = true;
            this.cmbPieza.Location = new System.Drawing.Point(98, 10);
            this.cmbPieza.Name = "cmbPieza";
            this.cmbPieza.Size = new System.Drawing.Size(121, 21);
            this.cmbPieza.TabIndex = 1;
            // 
            // chklstTicket
            // 
            this.chklstTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chklstTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstTicket.FormattingEnabled = true;
            this.chklstTicket.Items.AddRange(new object[] {
            "Con Ticket",
            "Solidario"});
            this.chklstTicket.Location = new System.Drawing.Point(400, 10);
            this.chklstTicket.Name = "chklstTicket";
            this.chklstTicket.Size = new System.Drawing.Size(97, 30);
            this.chklstTicket.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1. Seleccione Ticket de Venta:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(481, 82);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2. Seleccione un producto:";
            // 
            // gdvDetalles
            // 
            this.gdvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cProd,
            this.cPrec,
            this.cCant,
            this.cTotal});
            this.gdvDetalles.Location = new System.Drawing.Point(16, 194);
            this.gdvDetalles.Name = "gdvDetalles";
            this.gdvDetalles.Size = new System.Drawing.Size(481, 150);
            this.gdvDetalles.TabIndex = 6;
            // 
            // cProd
            // 
            this.cProd.HeaderText = "Producto";
            this.cProd.Name = "cProd";
            this.cProd.Width = 200;
            // 
            // cPrec
            // 
            this.cPrec.HeaderText = "Precio";
            this.cPrec.Name = "cPrec";
            this.cPrec.Width = 80;
            // 
            // cCant
            // 
            this.cCant.HeaderText = "Cantidad";
            this.cCant.Name = "cCant";
            this.cCant.Width = 60;
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total";
            this.cTotal.Name = "cTotal";
            // 
            // cmbSelecProd
            // 
            this.cmbSelecProd.FormattingEnabled = true;
            this.cmbSelecProd.Location = new System.Drawing.Point(203, 167);
            this.cmbSelecProd.Name = "cmbSelecProd";
            this.cmbSelecProd.Size = new System.Drawing.Size(148, 21);
            this.cmbSelecProd.TabIndex = 7;
            // 
            // cmbSelecTicket
            // 
            this.cmbSelecTicket.FormattingEnabled = true;
            this.cmbSelecTicket.Location = new System.Drawing.Point(203, 51);
            this.cmbSelecTicket.Name = "cmbSelecTicket";
            this.cmbSelecTicket.Size = new System.Drawing.Size(148, 21);
            this.cmbSelecTicket.TabIndex = 8;
            // 
            // pnlProd
            // 
            this.pnlProd.Controls.Add(this.dtpFechAten);
            this.pnlProd.Controls.Add(this.cmbOdontologo);
            this.pnlProd.Controls.Add(this.cmbProd);
            this.pnlProd.Controls.Add(this.txtObservacion);
            this.pnlProd.Controls.Add(this.txtCant);
            this.pnlProd.Controls.Add(this.txtPrecio);
            this.pnlProd.Controls.Add(this.label9);
            this.pnlProd.Controls.Add(this.label8);
            this.pnlProd.Controls.Add(this.label7);
            this.pnlProd.Controls.Add(this.label6);
            this.pnlProd.Controls.Add(this.label5);
            this.pnlProd.Controls.Add(this.label4);
            this.pnlProd.Location = new System.Drawing.Point(16, 364);
            this.pnlProd.Name = "pnlProd";
            this.pnlProd.Size = new System.Drawing.Size(481, 165);
            this.pnlProd.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Precio Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Odontólogo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha de Atención";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Observación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(262, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(135, 40);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCant
            // 
            this.txtCant.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCant.Location = new System.Drawing.Point(334, 40);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(124, 20);
            this.txtCant.TabIndex = 7;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(135, 119);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(323, 31);
            this.txtObservacion.TabIndex = 8;
            // 
            // cmbProd
            // 
            this.cmbProd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(135, 13);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(323, 21);
            this.cmbProd.TabIndex = 9;
            // 
            // cmbOdontologo
            // 
            this.cmbOdontologo.FormattingEnabled = true;
            this.cmbOdontologo.Location = new System.Drawing.Point(135, 66);
            this.cmbOdontologo.Name = "cmbOdontologo";
            this.cmbOdontologo.Size = new System.Drawing.Size(323, 21);
            this.cmbOdontologo.TabIndex = 10;
            // 
            // dtpFechAten
            // 
            this.dtpFechAten.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechAten.Location = new System.Drawing.Point(135, 93);
            this.dtpFechAten.Name = "dtpFechAten";
            this.dtpFechAten.Size = new System.Drawing.Size(102, 20);
            this.dtpFechAten.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(269, 535);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(386, 535);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmNewTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 566);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pnlProd);
            this.Controls.Add(this.cmbSelecTicket);
            this.Controls.Add(this.cmbSelecProd);
            this.Controls.Add(this.gdvDetalles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chklstTicket);
            this.Controls.Add(this.cmbPieza);
            this.Controls.Add(this.label1);
            this.Name = "frmNewTratamiento";
            this.Text = "Nuevo Tratamiento";
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetalles)).EndInit();
            this.pnlProd.ResumeLayout(false);
            this.pnlProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPieza;
        private System.Windows.Forms.CheckedListBox chklstTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gdvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.ComboBox cmbSelecProd;
        private System.Windows.Forms.ComboBox cmbSelecTicket;
        private System.Windows.Forms.Panel pnlProd;
        private System.Windows.Forms.DateTimePicker dtpFechAten;
        private System.Windows.Forms.ComboBox cmbOdontologo;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}