namespace Polsolcom.Forms
{
    partial class frmAdmTalon
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRecrear = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOperativo = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbDVenta = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpicFInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtNInicial = new System.Windows.Forms.TextBox();
            this.txtNFinal = new System.Windows.Forms.TextBox();
            this.txtNCon = new System.Windows.Forms.TextBox();
            this.grdTraMed = new System.Windows.Forms.ListView();
            this.cUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFechayHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDocVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSerie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNInicial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cActual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cOper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(21, 412);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 35);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(124, 412);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 35);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "E&ditar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCortar
            // 
            this.btnCortar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCortar.Location = new System.Drawing.Point(227, 412);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(97, 35);
            this.btnCortar.TabIndex = 2;
            this.btnCortar.Text = "C&ortar";
            this.btnCortar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCortar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(330, 412);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRecrear
            // 
            this.btnRecrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecrear.Location = new System.Drawing.Point(433, 412);
            this.btnRecrear.Name = "btnRecrear";
            this.btnRecrear.Size = new System.Drawing.Size(97, 35);
            this.btnRecrear.TabIndex = 4;
            this.btnRecrear.Text = "Re&crear";
            this.btnRecrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecrear.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(536, 412);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 35);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(5, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 19;
            // 
            // cmbOperativo
            // 
            this.cmbOperativo.FormattingEnabled = true;
            this.cmbOperativo.Location = new System.Drawing.Point(6, 16);
            this.cmbOperativo.Name = "cmbOperativo";
            this.cmbOperativo.Size = new System.Drawing.Size(257, 21);
            this.cmbOperativo.TabIndex = 20;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(4, 15);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(261, 21);
            this.cmbUsuario.TabIndex = 21;
            // 
            // cmbDVenta
            // 
            this.cmbDVenta.FormattingEnabled = true;
            this.cmbDVenta.Location = new System.Drawing.Point(8, 20);
            this.cmbDVenta.Name = "cmbDVenta";
            this.cmbDVenta.Size = new System.Drawing.Size(138, 21);
            this.cmbDVenta.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dtpicFInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 89);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2017, 4, 8, 9, 44, 33, 0);
            // 
            // dtpicFInicial
            // 
            this.dtpicFInicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicFInicial.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpicFInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpicFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicFInicial.Location = new System.Drawing.Point(95, 23);
            this.dtpicFInicial.Name = "dtpicFInicial";
            this.dtpicFInicial.Size = new System.Drawing.Size(177, 20);
            this.dtpicFInicial.TabIndex = 25;
            this.dtpicFInicial.Value = new System.DateTime(2017, 4, 8, 9, 44, 33, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbOperativo);
            this.groupBox2.Location = new System.Drawing.Point(343, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 44);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operativo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbUsuario);
            this.groupBox3.Location = new System.Drawing.Point(344, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 46);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuario";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSerie);
            this.groupBox4.Controls.Add(this.txtNInicial);
            this.groupBox4.Controls.Add(this.txtNFinal);
            this.groupBox4.Controls.Add(this.txtNCon);
            this.groupBox4.Controls.Add(this.cmbDVenta);
            this.groupBox4.Location = new System.Drawing.Point(9, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(645, 49);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rango de documento de venta";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(158, 20);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(113, 20);
            this.txtSerie.TabIndex = 39;
            // 
            // txtNInicial
            // 
            this.txtNInicial.Location = new System.Drawing.Point(283, 19);
            this.txtNInicial.Name = "txtNInicial";
            this.txtNInicial.Size = new System.Drawing.Size(113, 20);
            this.txtNInicial.TabIndex = 40;
            // 
            // txtNFinal
            // 
            this.txtNFinal.Location = new System.Drawing.Point(403, 19);
            this.txtNFinal.Name = "txtNFinal";
            this.txtNFinal.Size = new System.Drawing.Size(113, 20);
            this.txtNFinal.TabIndex = 41;
            // 
            // txtNCon
            // 
            this.txtNCon.Location = new System.Drawing.Point(524, 19);
            this.txtNCon.Name = "txtNCon";
            this.txtNCon.Size = new System.Drawing.Size(113, 20);
            this.txtNCon.TabIndex = 42;
            // 
            // grdTraMed
            // 
            this.grdTraMed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cUser,
            this.cFechayHora,
            this.cDocVenta,
            this.cSerie,
            this.cNInicial,
            this.cNFinal,
            this.cActual,
            this.cOper});
            this.grdTraMed.FullRowSelect = true;
            this.grdTraMed.Location = new System.Drawing.Point(8, 168);
            this.grdTraMed.MultiSelect = false;
            this.grdTraMed.Name = "grdTraMed";
            this.grdTraMed.Size = new System.Drawing.Size(654, 229);
            this.grdTraMed.TabIndex = 39;
            this.grdTraMed.UseCompatibleStateImageBehavior = false;
            this.grdTraMed.View = System.Windows.Forms.View.Details;
            // 
            // cUser
            // 
            this.cUser.Text = "Usuario";
            this.cUser.Width = 70;
            // 
            // cFechayHora
            // 
            this.cFechayHora.Text = "Fecha y Hora";
            this.cFechayHora.Width = 93;
            // 
            // cDocVenta
            // 
            this.cDocVenta.Text = "Doc. Venta";
            this.cDocVenta.Width = 106;
            // 
            // cSerie
            // 
            this.cSerie.Text = "Serie";
            this.cSerie.Width = 62;
            // 
            // cNInicial
            // 
            this.cNInicial.Text = "N° Inicial";
            this.cNInicial.Width = 67;
            // 
            // cNFinal
            // 
            this.cNFinal.Text = "N° Final";
            this.cNFinal.Width = 61;
            // 
            // cActual
            // 
            this.cActual.Text = "N° Actual";
            this.cActual.Width = 91;
            // 
            // cOper
            // 
            this.cOper.Text = "Operativo";
            this.cOper.Width = 111;
            // 
            // frmAdmTalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(672, 459);
            this.ControlBox = false;
            this.Controls.Add(this.grdTraMed);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnRecrear);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCortar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmAdmTalon";
            this.Text = "Administracion de Talonarios de Documentos de Ventas";
            this.Load += new System.EventHandler(this.frmAdmCounterfoil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRecrear;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOperativo;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbDVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpicFInicial;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtNInicial;
        private System.Windows.Forms.TextBox txtNFinal;
        private System.Windows.Forms.TextBox txtNCon;
        private System.Windows.Forms.ListView grdTraMed;
        private System.Windows.Forms.ColumnHeader cUser;
        private System.Windows.Forms.ColumnHeader cFechayHora;
        private System.Windows.Forms.ColumnHeader cDocVenta;
        private System.Windows.Forms.ColumnHeader cSerie;
        private System.Windows.Forms.ColumnHeader cNInicial;
        private System.Windows.Forms.ColumnHeader cNFinal;
        private System.Windows.Forms.ColumnHeader cActual;
        private System.Windows.Forms.ColumnHeader cOper;
    }
}