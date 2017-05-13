namespace Polsolcom.Forms
{
    partial class frmConsRotations
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFechInicio = new System.Windows.Forms.ComboBox();
            this.cmbFechFinal = new System.Windows.Forms.ComboBox();
            this.nmrHorahInicio = new System.Windows.Forms.NumericUpDown();
            this.nmrHoraFinal = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.docVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecyhora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHorahInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHoraFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(182, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Rotaciones Aplicadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccione la Especialidad";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(458, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hora";
            // 
            // cmbFechInicio
            // 
            this.cmbFechInicio.FormattingEnabled = true;
            this.cmbFechInicio.Location = new System.Drawing.Point(132, 63);
            this.cmbFechInicio.Name = "cmbFechInicio";
            this.cmbFechInicio.Size = new System.Drawing.Size(121, 21);
            this.cmbFechInicio.TabIndex = 7;
            // 
            // cmbFechFinal
            // 
            this.cmbFechFinal.FormattingEnabled = true;
            this.cmbFechFinal.Location = new System.Drawing.Point(409, 58);
            this.cmbFechFinal.Name = "cmbFechFinal";
            this.cmbFechFinal.Size = new System.Drawing.Size(121, 21);
            this.cmbFechFinal.TabIndex = 8;
            // 
            // nmrHorahInicio
            // 
            this.nmrHorahInicio.Location = new System.Drawing.Point(132, 91);
            this.nmrHorahInicio.Name = "nmrHorahInicio";
            this.nmrHorahInicio.Size = new System.Drawing.Size(120, 20);
            this.nmrHorahInicio.TabIndex = 9;
            // 
            // nmrHoraFinal
            // 
            this.nmrHoraFinal.Location = new System.Drawing.Point(409, 90);
            this.nmrHoraFinal.Name = "nmrHoraFinal";
            this.nmrHoraFinal.Size = new System.Drawing.Size(120, 20);
            this.nmrHoraFinal.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hora";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.especialidad,
            this.consultorio,
            this.alterno,
            this.vend,
            this.anulado});
            this.dataGridView1.Location = new System.Drawing.Point(2, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 87);
            this.dataGridView1.TabIndex = 13;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 60;
            // 
            // especialidad
            // 
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.Width = 200;
            // 
            // consultorio
            // 
            this.consultorio.HeaderText = "Consultorio";
            this.consultorio.Name = "consultorio";
            // 
            // alterno
            // 
            this.alterno.HeaderText = "Alterno";
            this.alterno.Name = "alterno";
            // 
            // vend
            // 
            this.vend.HeaderText = "Vend";
            this.vend.Name = "vend";
            this.vend.Width = 40;
            // 
            // anulado
            // 
            this.anulado.HeaderText = "Anul";
            this.anulado.Name = "anulado";
            this.anulado.Width = 40;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docVenta,
            this.fecyhora,
            this.paciente,
            this.a,
            this.cajero});
            this.dataGridView2.Location = new System.Drawing.Point(2, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(579, 128);
            this.dataGridView2.TabIndex = 14;
            // 
            // docVenta
            // 
            this.docVenta.HeaderText = "Doc Venta";
            this.docVenta.Name = "docVenta";
            this.docVenta.Width = 80;
            // 
            // fecyhora
            // 
            this.fecyhora.HeaderText = "Fecha y Hora";
            this.fecyhora.Name = "fecyhora";
            // 
            // paciente
            // 
            this.paciente.HeaderText = "Paciente";
            this.paciente.Name = "paciente";
            this.paciente.Width = 220;
            // 
            // a
            // 
            this.a.HeaderText = "A";
            this.a.Name = "a";
            this.a.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.a.Width = 40;
            // 
            // cajero
            // 
            this.cajero.HeaderText = "Cajero";
            this.cajero.Name = "cajero";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.cant,
            this.prec,
            this.total});
            this.dataGridView3.Location = new System.Drawing.Point(2, 444);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(579, 101);
            this.dataGridView3.TabIndex = 15;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto o Servicio";
            this.producto.Name = "producto";
            this.producto.Width = 360;
            // 
            // cant
            // 
            this.cant.HeaderText = "Cantidad";
            this.cant.Name = "cant";
            this.cant.Width = 60;
            // 
            // prec
            // 
            this.prec.HeaderText = "Precio";
            this.prec.Name = "prec";
            this.prec.Width = 60;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.Width = 60;
            // 
            // frmConsRotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 557);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmrHoraFinal);
            this.Controls.Add(this.nmrHorahInicio);
            this.Controls.Add(this.cmbFechFinal);
            this.Controls.Add(this.cmbFechInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmConsRotations";
            this.Text = "frmConsRotations";
            this.Load += new System.EventHandler(this.frmConsRotations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrHorahInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHoraFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFechInicio;
        private System.Windows.Forms.ComboBox cmbFechFinal;
        private System.Windows.Forms.NumericUpDown nmrHorahInicio;
        private System.Windows.Forms.NumericUpDown nmrHoraFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn alterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn vend;
        private System.Windows.Forms.DataGridViewTextBoxColumn anulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn docVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecyhora;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}