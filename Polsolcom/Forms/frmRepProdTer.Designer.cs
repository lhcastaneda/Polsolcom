namespace Polsolcom.Forms
{
    partial class frmRepProdTer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepProdTer));
            this.label1 = new System.Windows.Forms.Label();
            this.chkProc = new System.Windows.Forms.CheckBox();
            this.chkNoProc = new System.Windows.Forms.CheckBox();
            this.chkPagados = new System.Windows.Forms.CheckBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPerPago = new System.Windows.Forms.ComboBox();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.lstFechas = new System.Windows.Forms.ListBox();
            this.chkEspecialidades = new System.Windows.Forms.CheckBox();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.chkConsult = new System.Windows.Forms.CheckBox();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.chkEspecialistas = new System.Windows.Forms.CheckBox();
            this.cmbEspecialistas = new System.Windows.Forms.ComboBox();
            this.chkTipProd = new System.Windows.Forms.CheckBox();
            this.cmbTipProd = new System.Windows.Forms.ComboBox();
            this.gdvAtencion = new System.Windows.Forms.DataGridView();
            this.cAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNroRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cConsultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdvProd = new System.Windows.Forms.DataGridView();
            this.cProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdvTurn = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotTickets = new System.Windows.Forms.TextBox();
            this.txtTotCant = new System.Windows.Forms.TextBox();
            this.txtTotTotal = new System.Windows.Forms.TextBox();
            this.chkTodTurn = new System.Windows.Forms.CheckBox();
            this.cmbTurn = new System.Windows.Forms.ComboBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTipReport = new System.Windows.Forms.Panel();
            this.chkReportDetallado = new System.Windows.Forms.CheckBox();
            this.chkReportResProd = new System.Windows.Forms.CheckBox();
            this.chkReportResFech = new System.Windows.Forms.CheckBox();
            this.pnlCondConsul = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAtencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTurn)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTipReport.SuspendLayout();
            this.pnlCondConsul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condición de Consulta";
            // 
            // chkProc
            // 
            this.chkProc.AutoSize = true;
            this.chkProc.Checked = true;
            this.chkProc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProc.Location = new System.Drawing.Point(10, 4);
            this.chkProc.Name = "chkProc";
            this.chkProc.Size = new System.Drawing.Size(92, 17);
            this.chkProc.TabIndex = 0;
            this.chkProc.Text = "Pro&cesados";
            this.chkProc.UseVisualStyleBackColor = true;
            // 
            // chkNoProc
            // 
            this.chkNoProc.AutoSize = true;
            this.chkNoProc.Location = new System.Drawing.Point(10, 27);
            this.chkNoProc.Name = "chkNoProc";
            this.chkNoProc.Size = new System.Drawing.Size(112, 17);
            this.chkNoProc.TabIndex = 1;
            this.chkNoProc.Text = "&No Procesados";
            this.chkNoProc.UseVisualStyleBackColor = true;
            // 
            // chkPagados
            // 
            this.chkPagados.AutoSize = true;
            this.chkPagados.Location = new System.Drawing.Point(132, 4);
            this.chkPagados.Name = "chkPagados";
            this.chkPagados.Size = new System.Drawing.Size(75, 17);
            this.chkPagados.TabIndex = 2;
            this.chkPagados.Text = "&Pagados";
            this.chkPagados.UseVisualStyleBackColor = true;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(132, 23);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(61, 17);
            this.chkTodos.TabIndex = 3;
            this.chkTodos.Text = "To&dos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preiódo de Pago";
            // 
            // cmbPerPago
            // 
            this.cmbPerPago.FormattingEnabled = true;
            this.cmbPerPago.Location = new System.Drawing.Point(12, 127);
            this.cmbPerPago.Name = "cmbPerPago";
            this.cmbPerPago.Size = new System.Drawing.Size(235, 21);
            this.cmbPerPago.TabIndex = 5;
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFechas.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkFechas.Location = new System.Drawing.Point(12, 163);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(67, 17);
            this.chkFechas.TabIndex = 6;
            this.chkFechas.Text = "Fechas";
            this.chkFechas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Final";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Enabled = false;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(12, 199);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(107, 20);
            this.dtpInicio.TabIndex = 10;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Enabled = false;
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(140, 199);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(107, 20);
            this.dtpFinal.TabIndex = 11;
            // 
            // lstFechas
            // 
            this.lstFechas.Enabled = false;
            this.lstFechas.FormattingEnabled = true;
            this.lstFechas.Location = new System.Drawing.Point(12, 226);
            this.lstFechas.Name = "lstFechas";
            this.lstFechas.ScrollAlwaysVisible = true;
            this.lstFechas.Size = new System.Drawing.Size(235, 95);
            this.lstFechas.TabIndex = 12;
            // 
            // chkEspecialidades
            // 
            this.chkEspecialidades.AutoSize = true;
            this.chkEspecialidades.Checked = true;
            this.chkEspecialidades.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEspecialidades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEspecialidades.Location = new System.Drawing.Point(12, 340);
            this.chkEspecialidades.Name = "chkEspecialidades";
            this.chkEspecialidades.Size = new System.Drawing.Size(170, 17);
            this.chkEspecialidades.TabIndex = 13;
            this.chkEspecialidades.Text = "Todas las Especialidades";
            this.chkEspecialidades.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.Enabled = false;
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(12, 364);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(235, 21);
            this.cmbEspecialidades.TabIndex = 14;
            // 
            // chkConsult
            // 
            this.chkConsult.AutoSize = true;
            this.chkConsult.Checked = true;
            this.chkConsult.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConsult.Location = new System.Drawing.Point(12, 392);
            this.chkConsult.Name = "chkConsult";
            this.chkConsult.Size = new System.Drawing.Size(187, 17);
            this.chkConsult.TabIndex = 15;
            this.chkConsult.Text = "Todos los Consultorios (Bus)";
            this.chkConsult.UseVisualStyleBackColor = true;
            // 
            // cmbBus
            // 
            this.cmbBus.Enabled = false;
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(13, 416);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(234, 21);
            this.cmbBus.TabIndex = 16;
            // 
            // chkEspecialistas
            // 
            this.chkEspecialistas.AutoSize = true;
            this.chkEspecialistas.Checked = true;
            this.chkEspecialistas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEspecialistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEspecialistas.Location = new System.Drawing.Point(12, 443);
            this.chkEspecialistas.Name = "chkEspecialistas";
            this.chkEspecialistas.Size = new System.Drawing.Size(159, 17);
            this.chkEspecialistas.TabIndex = 17;
            this.chkEspecialistas.Text = "Todos los Especialistas";
            this.chkEspecialistas.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialistas
            // 
            this.cmbEspecialistas.Enabled = false;
            this.cmbEspecialistas.FormattingEnabled = true;
            this.cmbEspecialistas.Location = new System.Drawing.Point(12, 467);
            this.cmbEspecialistas.Name = "cmbEspecialistas";
            this.cmbEspecialistas.Size = new System.Drawing.Size(235, 21);
            this.cmbEspecialistas.TabIndex = 18;
            // 
            // chkTipProd
            // 
            this.chkTipProd.AutoSize = true;
            this.chkTipProd.Checked = true;
            this.chkTipProd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTipProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTipProd.Location = new System.Drawing.Point(18, 494);
            this.chkTipProd.Name = "chkTipProd";
            this.chkTipProd.Size = new System.Drawing.Size(195, 17);
            this.chkTipProd.TabIndex = 19;
            this.chkTipProd.Text = "Todos los Tipos de Prodcutos";
            this.chkTipProd.UseVisualStyleBackColor = true;
            // 
            // cmbTipProd
            // 
            this.cmbTipProd.Enabled = false;
            this.cmbTipProd.FormattingEnabled = true;
            this.cmbTipProd.Location = new System.Drawing.Point(12, 519);
            this.cmbTipProd.Name = "cmbTipProd";
            this.cmbTipProd.Size = new System.Drawing.Size(235, 21);
            this.cmbTipProd.TabIndex = 20;
            // 
            // gdvAtencion
            // 
            this.gdvAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAtencion,
            this.cSerie,
            this.cNroRecibo,
            this.cCmp,
            this.cConsultorio,
            this.cItems,
            this.cBus,
            this.cTotal});
            this.gdvAtencion.Location = new System.Drawing.Point(280, 13);
            this.gdvAtencion.Name = "gdvAtencion";
            this.gdvAtencion.Size = new System.Drawing.Size(618, 198);
            this.gdvAtencion.TabIndex = 21;
            // 
            // cAtencion
            // 
            this.cAtencion.HeaderText = "Atención";
            this.cAtencion.Name = "cAtencion";
            // 
            // cSerie
            // 
            this.cSerie.HeaderText = "Serie";
            this.cSerie.Name = "cSerie";
            this.cSerie.Width = 40;
            // 
            // cNroRecibo
            // 
            this.cNroRecibo.HeaderText = "Nro de Recibo";
            this.cNroRecibo.Name = "cNroRecibo";
            // 
            // cCmp
            // 
            this.cCmp.HeaderText = "CMP";
            this.cCmp.Name = "cCmp";
            this.cCmp.Width = 40;
            // 
            // cConsultorio
            // 
            this.cConsultorio.HeaderText = "Consultorio";
            this.cConsultorio.Name = "cConsultorio";
            // 
            // cItems
            // 
            this.cItems.HeaderText = "Items";
            this.cItems.Name = "cItems";
            this.cItems.Width = 40;
            // 
            // cBus
            // 
            this.cBus.HeaderText = "Bus";
            this.cBus.Name = "cBus";
            this.cBus.Width = 60;
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total S/.";
            this.cTotal.Name = "cTotal";
            // 
            // gdvProd
            // 
            this.gdvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cProd,
            this.cPrecio,
            this.cCant,
            this.c2Total});
            this.gdvProd.Location = new System.Drawing.Point(280, 217);
            this.gdvProd.Name = "gdvProd";
            this.gdvProd.Size = new System.Drawing.Size(618, 131);
            this.gdvProd.TabIndex = 22;
            // 
            // cProd
            // 
            this.cProd.HeaderText = "Producto";
            this.cProd.Name = "cProd";
            this.cProd.Width = 280;
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
            // c2Total
            // 
            this.c2Total.HeaderText = "Total S/.";
            this.c2Total.Name = "c2Total";
            // 
            // gdvTurn
            // 
            this.gdvTurn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvTurn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFecha,
            this.cTicket,
            this.c3Cant,
            this.c3Total});
            this.gdvTurn.Location = new System.Drawing.Point(11, 35);
            this.gdvTurn.Name = "gdvTurn";
            this.gdvTurn.Size = new System.Drawing.Size(402, 150);
            this.gdvTurn.TabIndex = 23;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(798, 354);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(728, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTurn);
            this.panel1.Controls.Add(this.chkTodTurn);
            this.panel1.Controls.Add(this.txtTotTotal);
            this.panel1.Controls.Add(this.txtTotCant);
            this.panel1.Controls.Add(this.txtTotTickets);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gdvTurn);
            this.panel1.Location = new System.Drawing.Point(478, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 229);
            this.panel1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Totales";
            // 
            // txtTotTickets
            // 
            this.txtTotTickets.Location = new System.Drawing.Point(137, 199);
            this.txtTotTickets.Name = "txtTotTickets";
            this.txtTotTickets.Size = new System.Drawing.Size(80, 20);
            this.txtTotTickets.TabIndex = 25;
            // 
            // txtTotCant
            // 
            this.txtTotCant.Location = new System.Drawing.Point(223, 199);
            this.txtTotCant.Name = "txtTotCant";
            this.txtTotCant.Size = new System.Drawing.Size(92, 20);
            this.txtTotCant.TabIndex = 26;
            // 
            // txtTotTotal
            // 
            this.txtTotTotal.Location = new System.Drawing.Point(320, 199);
            this.txtTotTotal.Name = "txtTotTotal";
            this.txtTotTotal.Size = new System.Drawing.Size(92, 20);
            this.txtTotTotal.TabIndex = 27;
            // 
            // chkTodTurn
            // 
            this.chkTodTurn.AutoSize = true;
            this.chkTodTurn.Checked = true;
            this.chkTodTurn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTodTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodTurn.Location = new System.Drawing.Point(13, 12);
            this.chkTodTurn.Name = "chkTodTurn";
            this.chkTodTurn.Size = new System.Drawing.Size(124, 17);
            this.chkTodTurn.TabIndex = 28;
            this.chkTodTurn.Text = "Todos los Turnos";
            this.chkTodTurn.UseVisualStyleBackColor = true;
            // 
            // cmbTurn
            // 
            this.cmbTurn.Enabled = false;
            this.cmbTurn.FormattingEnabled = true;
            this.cmbTurn.Location = new System.Drawing.Point(210, 8);
            this.cmbTurn.Name = "cmbTurn";
            this.cmbTurn.Size = new System.Drawing.Size(202, 21);
            this.cmbTurn.TabIndex = 29;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(99, 546);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(71, 56);
            this.btnEjecutar.TabIndex = 27;
            this.btnEjecutar.Text = "&Ejecutar";
            this.btnEjecutar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(22, 608);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(71, 56);
            this.btnExportar.TabIndex = 28;
            this.btnExportar.Text = "E&xportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnMarcar
            // 
            this.btnMarcar.Enabled = false;
            this.btnMarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcar.Location = new System.Drawing.Point(99, 608);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(71, 56);
            this.btnMarcar.TabIndex = 29;
            this.btnMarcar.Text = "&Marcar";
            this.btnMarcar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(176, 608);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(71, 56);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.Text = "Im&primir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(792, 624);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 38);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // cFecha
            // 
            this.cFecha.HeaderText = "Fecha";
            this.cFecha.Name = "cFecha";
            this.cFecha.Width = 80;
            // 
            // cTicket
            // 
            this.cTicket.HeaderText = "Tickets";
            this.cTicket.Name = "cTicket";
            this.cTicket.Width = 80;
            // 
            // c3Cant
            // 
            this.c3Cant.HeaderText = "Cantidad";
            this.c3Cant.Name = "c3Cant";
            // 
            // c3Total
            // 
            this.c3Total.HeaderText = "Total S/.";
            this.c3Total.Name = "c3Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(266, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tipos por Reporte";
            // 
            // pnlTipReport
            // 
            this.pnlTipReport.Controls.Add(this.chkReportResFech);
            this.pnlTipReport.Controls.Add(this.chkReportResProd);
            this.pnlTipReport.Controls.Add(this.chkReportDetallado);
            this.pnlTipReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTipReport.Location = new System.Drawing.Point(269, 438);
            this.pnlTipReport.Name = "pnlTipReport";
            this.pnlTipReport.Size = new System.Drawing.Size(200, 150);
            this.pnlTipReport.TabIndex = 34;
            // 
            // chkReportDetallado
            // 
            this.chkReportDetallado.AutoSize = true;
            this.chkReportDetallado.Checked = true;
            this.chkReportDetallado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReportDetallado.Location = new System.Drawing.Point(11, 16);
            this.chkReportDetallado.Name = "chkReportDetallado";
            this.chkReportDetallado.Size = new System.Drawing.Size(170, 17);
            this.chkReportDetallado.TabIndex = 0;
            this.chkReportDetallado.Text = "Reporte detallado por Recibos";
            this.chkReportDetallado.UseVisualStyleBackColor = true;
            // 
            // chkReportResProd
            // 
            this.chkReportResProd.AutoSize = true;
            this.chkReportResProd.Location = new System.Drawing.Point(11, 57);
            this.chkReportResProd.Name = "chkReportResProd";
            this.chkReportResProd.Size = new System.Drawing.Size(178, 17);
            this.chkReportResProd.TabIndex = 1;
            this.chkReportResProd.Text = "Reporte resumido por Productos";
            this.chkReportResProd.UseVisualStyleBackColor = true;
            // 
            // chkReportResFech
            // 
            this.chkReportResFech.AutoSize = true;
            this.chkReportResFech.Location = new System.Drawing.Point(11, 95);
            this.chkReportResFech.Name = "chkReportResFech";
            this.chkReportResFech.Size = new System.Drawing.Size(165, 17);
            this.chkReportResFech.TabIndex = 2;
            this.chkReportResFech.Text = "Reporte resumido por Fechas";
            this.chkReportResFech.UseVisualStyleBackColor = true;
            // 
            // pnlCondConsul
            // 
            this.pnlCondConsul.Controls.Add(this.chkProc);
            this.pnlCondConsul.Controls.Add(this.chkPagados);
            this.pnlCondConsul.Controls.Add(this.chkNoProc);
            this.pnlCondConsul.Controls.Add(this.chkTodos);
            this.pnlCondConsul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCondConsul.Location = new System.Drawing.Point(12, 37);
            this.pnlCondConsul.Name = "pnlCondConsul";
            this.pnlCondConsul.Size = new System.Drawing.Size(227, 56);
            this.pnlCondConsul.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 553);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 617);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(119, 617);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(195, 617);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(813, 630);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // frmRepProdTer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 674);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCondConsul);
            this.Controls.Add(this.pnlTipReport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gdvProd);
            this.Controls.Add(this.gdvAtencion);
            this.Controls.Add(this.cmbTipProd);
            this.Controls.Add(this.chkTipProd);
            this.Controls.Add(this.cmbEspecialistas);
            this.Controls.Add(this.chkEspecialistas);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.chkConsult);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.chkEspecialidades);
            this.Controls.Add(this.lstFechas);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkFechas);
            this.Controls.Add(this.cmbPerPago);
            this.Controls.Add(this.label2);
            this.Name = "frmRepProdTer";
            this.Text = "Producción de Terceros por Consultorio";
            ((System.ComponentModel.ISupportInitialize)(this.gdvAtencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTurn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTipReport.ResumeLayout(false);
            this.pnlTipReport.PerformLayout();
            this.pnlCondConsul.ResumeLayout(false);
            this.pnlCondConsul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.CheckBox chkPagados;
        private System.Windows.Forms.CheckBox chkNoProc;
        private System.Windows.Forms.CheckBox chkProc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPerPago;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.ListBox lstFechas;
        private System.Windows.Forms.CheckBox chkEspecialidades;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.CheckBox chkConsult;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.CheckBox chkEspecialistas;
        private System.Windows.Forms.ComboBox cmbEspecialistas;
        private System.Windows.Forms.CheckBox chkTipProd;
        private System.Windows.Forms.ComboBox cmbTipProd;
        private System.Windows.Forms.DataGridView gdvAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNroRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cConsultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.DataGridView gdvProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Total;
        private System.Windows.Forms.DataGridView gdvTurn;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTurn;
        private System.Windows.Forms.CheckBox chkTodTurn;
        private System.Windows.Forms.TextBox txtTotTotal;
        private System.Windows.Forms.TextBox txtTotCant;
        private System.Windows.Forms.TextBox txtTotTickets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3Total;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlTipReport;
        private System.Windows.Forms.CheckBox chkReportResFech;
        private System.Windows.Forms.CheckBox chkReportResProd;
        private System.Windows.Forms.CheckBox chkReportDetallado;
        private System.Windows.Forms.Panel pnlCondConsul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}