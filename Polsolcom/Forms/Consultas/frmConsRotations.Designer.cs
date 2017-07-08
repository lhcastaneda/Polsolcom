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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
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
            this.dtpicFFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpicFInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccione la Especialidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(13, 64);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(458, 21);
            this.cmbEspecialidad.TabIndex = 4;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 97);
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
            this.dataGridView2.Location = new System.Drawing.Point(4, 191);
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
            this.dataGridView3.Location = new System.Drawing.Point(5, 327);
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
            // dtpicFFinal
            // 
            this.dtpicFFinal.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpicFFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpicFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicFFinal.Location = new System.Drawing.Point(267, 19);
            this.dtpicFFinal.Name = "dtpicFFinal";
            this.dtpicFFinal.Size = new System.Drawing.Size(142, 20);
            this.dtpicFFinal.TabIndex = 32;
            this.dtpicFFinal.Value = new System.DateTime(2017, 4, 8, 9, 44, 22, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(299, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha Final";
            // 
            // dtpicFInicial
            // 
            this.dtpicFInicial.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpicFInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpicFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicFInicial.Location = new System.Drawing.Point(89, 19);
            this.dtpicFInicial.Name = "dtpicFInicial";
            this.dtpicFInicial.Size = new System.Drawing.Size(142, 20);
            this.dtpicFInicial.TabIndex = 31;
            this.dtpicFInicial.Value = new System.DateTime(2017, 4, 8, 9, 44, 33, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(114, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha Inicial";
            // 
            // frmConsRotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 439);
            this.ControlBox = false;
            this.Controls.Add(this.dtpicFFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpicFInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmConsRotations";
            this.Text = "Consultar Rotaciones Aplicadas";
            this.Load += new System.EventHandler(this.frmConsRotations_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsRotations_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
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
        private System.Windows.Forms.DateTimePicker dtpicFFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpicFInicial;
        private System.Windows.Forms.Label label2;
    }
}