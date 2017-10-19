namespace Polsolcom.Forms
{
    partial class frmMntVentas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosDS = new Polsolcom.Dominio.Data.ConsultoriosDS();
            this.cmbTipDoc = new System.Windows.Forms.ComboBox();
            this.docVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaTipoDS = new Polsolcom.Dominio.Data.TablaTipoDS();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtNInicial = new System.Windows.Forms.TextBox();
            this.txtNFinal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbFPago = new System.Windows.Forms.ComboBox();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cmbOpExt = new System.Windows.Forms.ComboBox();
            this.cmbUsExt = new System.Windows.Forms.ComboBox();
            this.txtDscto = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbMotAnul = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbAprDscto = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.grdDet = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dscto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Historia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsFecMod = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlPac = new System.Windows.Forms.Panel();
            this.optPanel = new System.Windows.Forms.Panel();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.lstVentas = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstPacientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.especialidadTableAdapter = new Polsolcom.Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter();
            this.docVentaTableAdapter = new Polsolcom.Dominio.Data.TablaTipoDSTableAdapters.DocVentaTableAdapter();
            this.txtFecEmi = new System.Windows.Forms.MaskedTextBox();
            this.txtFecNac = new System.Windows.Forms.MaskedTextBox();
            this.txtFecExt = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDet)).BeginInit();
            this.pnlPac.SuspendLayout();
            this.optPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Paciente";
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(21, 36);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(137, 20);
            this.txtApePat.TabIndex = 4;
            this.txtApePat.TextChanged += new System.EventHandler(this.txtApePat_TextChanged);
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(164, 36);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(137, 20);
            this.txtApeMat.TabIndex = 5;
            this.txtApeMat.TextChanged += new System.EventHandler(this.txtApeMat_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(307, 36);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(197, 20);
            this.txtNombres.TabIndex = 6;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(23, 323);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtIdPaciente.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Emisión";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre de la Especialidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DataSource = this.especialidadBindingSource;
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(21, 86);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(296, 21);
            this.cmbEspecialidad.TabIndex = 11;
            this.cmbEspecialidad.ValueMember = "Id_Consultorio";
            // 
            // especialidadBindingSource
            // 
            this.especialidadBindingSource.DataMember = "Especialidad";
            this.especialidadBindingSource.DataSource = this.consultoriosDS;
            // 
            // consultoriosDS
            // 
            this.consultoriosDS.DataSetName = "ConsultoriosDS";
            this.consultoriosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTipDoc
            // 
            this.cmbTipDoc.DataSource = this.docVentaBindingSource;
            this.cmbTipDoc.DisplayMember = "Descripcion";
            this.cmbTipDoc.FormattingEnabled = true;
            this.cmbTipDoc.Location = new System.Drawing.Point(323, 85);
            this.cmbTipDoc.Name = "cmbTipDoc";
            this.cmbTipDoc.Size = new System.Drawing.Size(149, 21);
            this.cmbTipDoc.TabIndex = 12;
            this.cmbTipDoc.ValueMember = "Id_Tipo";
            // 
            // docVentaBindingSource
            // 
            this.docVentaBindingSource.DataMember = "DocVenta";
            this.docVentaBindingSource.DataSource = this.tablaTipoDS;
            // 
            // tablaTipoDS
            // 
            this.tablaTipoDS.DataSetName = "TablaTipoDS";
            this.tablaTipoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de Doc.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Serie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(551, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nro Inicial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(641, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "No Final";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(478, 86);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(70, 20);
            this.txtSerie.TabIndex = 17;
            // 
            // txtNInicial
            // 
            this.txtNInicial.Location = new System.Drawing.Point(554, 86);
            this.txtNInicial.Name = "txtNInicial";
            this.txtNInicial.Size = new System.Drawing.Size(84, 20);
            this.txtNInicial.TabIndex = 18;
            // 
            // txtNFinal
            // 
            this.txtNFinal.Location = new System.Drawing.Point(644, 86);
            this.txtNFinal.Name = "txtNFinal";
            this.txtNFinal.Size = new System.Drawing.Size(93, 20);
            this.txtNFinal.TabIndex = 19;
            this.txtNFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNFinal_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Apellidos y Nombres del Paciente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "ID Paciente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(126, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Apellidos y Nombres";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(485, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Género";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(591, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Fecha de Nac.";
            // 
            // txtIdPac
            // 
            this.txtIdPac.Location = new System.Drawing.Point(508, 35);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.Size = new System.Drawing.Size(107, 20);
            this.txtIdPac.TabIndex = 27;
            this.txtIdPac.TextChanged += new System.EventHandler(this.txtIdPac_TextChanged);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(129, 323);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(351, 20);
            this.txtPaciente.TabIndex = 28;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(488, 323);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 29;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(700, 323);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(78, 20);
            this.txtEdad.TabIndex = 31;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(784, 323);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(697, 307);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Edad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(781, 307);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Total S/.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Forma de Pago";
            // 
            // cmbFPago
            // 
            this.cmbFPago.FormattingEnabled = true;
            this.cmbFPago.Location = new System.Drawing.Point(23, 373);
            this.cmbFPago.Name = "cmbFPago";
            this.cmbFPago.Size = new System.Drawing.Size(121, 21);
            this.cmbFPago.TabIndex = 36;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(150, 373);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(121, 21);
            this.cmbMoneda.TabIndex = 37;
            // 
            // txtCajero
            // 
            this.txtCajero.Location = new System.Drawing.Point(277, 373);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.Size = new System.Drawing.Size(100, 20);
            this.txtCajero.TabIndex = 38;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Location = new System.Drawing.Point(383, 373);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 39;
            // 
            // cmbOpExt
            // 
            this.cmbOpExt.FormattingEnabled = true;
            this.cmbOpExt.Location = new System.Drawing.Point(489, 373);
            this.cmbOpExt.Name = "cmbOpExt";
            this.cmbOpExt.Size = new System.Drawing.Size(121, 21);
            this.cmbOpExt.TabIndex = 40;
            // 
            // cmbUsExt
            // 
            this.cmbUsExt.FormattingEnabled = true;
            this.cmbUsExt.Location = new System.Drawing.Point(616, 374);
            this.cmbUsExt.Name = "cmbUsExt";
            this.cmbUsExt.Size = new System.Drawing.Size(114, 21);
            this.cmbUsExt.TabIndex = 41;
            // 
            // txtDscto
            // 
            this.txtDscto.Location = new System.Drawing.Point(812, 373);
            this.txtDscto.Name = "txtDscto";
            this.txtDscto.Size = new System.Drawing.Size(72, 20);
            this.txtDscto.TabIndex = 43;
            this.txtDscto.Leave += new System.EventHandler(this.txtDscto_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(147, 357);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Moneda";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(274, 357);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 45;
            this.label20.Text = "Admisión - Caja";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(380, 357);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "Estado Reg.";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(486, 357);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "Oper. Extorno";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(613, 357);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 48;
            this.label23.Text = "US. Extorno";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(733, 357);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 49;
            this.label24.Text = "Fecha Ext.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(809, 357);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "Dscto. S/.";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(21, 407);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 13);
            this.label26.TabIndex = 51;
            this.label26.Text = "Motivo de Anulación";
            // 
            // cmbMotAnul
            // 
            this.cmbMotAnul.FormattingEnabled = true;
            this.cmbMotAnul.Location = new System.Drawing.Point(23, 423);
            this.cmbMotAnul.Name = "cmbMotAnul";
            this.cmbMotAnul.Size = new System.Drawing.Size(310, 21);
            this.cmbMotAnul.TabIndex = 52;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(20, 461);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(112, 13);
            this.label27.TabIndex = 53;
            this.label27.Text = "Aprobo Descuento";
            // 
            // cmbAprDscto
            // 
            this.cmbAprDscto.FormattingEnabled = true;
            this.cmbAprDscto.Location = new System.Drawing.Point(23, 477);
            this.cmbAprDscto.Name = "cmbAprDscto";
            this.cmbAprDscto.Size = new System.Drawing.Size(310, 21);
            this.cmbAprDscto.TabIndex = 54;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(20, 513);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 13);
            this.label28.TabIndex = 55;
            this.label28.Text = "Observación";
            // 
            // grdDet
            // 
            this.grdDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Monto,
            this.Total,
            this.MD,
            this.Pagado,
            this.Dscto,
            this.Id_Producto,
            this.Nro_Historia,
            this.PD});
            this.grdDet.Location = new System.Drawing.Point(346, 401);
            this.grdDet.MultiSelect = false;
            this.grdDet.Name = "grdDet";
            this.grdDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDet.Size = new System.Drawing.Size(538, 182);
            this.grdDet.TabIndex = 57;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto y/o Servicio";
            this.Producto.Name = "Producto";
            this.Producto.Width = 260;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 60;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Precio";
            this.Monto.Name = "Monto";
            this.Monto.Width = 60;
            // 
            // Total
            // 
            this.Total.HeaderText = "Sub Total";
            this.Total.Name = "Total";
            this.Total.Width = 60;
            // 
            // MD
            // 
            this.MD.HeaderText = "MD";
            this.MD.Name = "MD";
            this.MD.Width = 60;
            // 
            // Pagado
            // 
            this.Pagado.HeaderText = "Pagado";
            this.Pagado.Name = "Pagado";
            this.Pagado.Visible = false;
            // 
            // Dscto
            // 
            this.Dscto.HeaderText = "Dscto";
            this.Dscto.Name = "Dscto";
            this.Dscto.Visible = false;
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id Producto";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.Visible = false;
            // 
            // Nro_Historia
            // 
            this.Nro_Historia.HeaderText = "Nro Historia";
            this.Nro_Historia.Name = "Nro_Historia";
            this.Nro_Historia.Visible = false;
            // 
            // PD
            // 
            this.PD.HeaderText = "PD";
            this.PD.Name = "PD";
            this.PD.Visible = false;
            // 
            // txtUsFecMod
            // 
            this.txtUsFecMod.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUsFecMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsFecMod.Location = new System.Drawing.Point(457, 591);
            this.txtUsFecMod.Name = "txtUsFecMod";
            this.txtUsFecMod.Size = new System.Drawing.Size(172, 20);
            this.txtUsFecMod.TabIndex = 62;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(644, 589);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(112, 23);
            this.btnGrabar.TabIndex = 63;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(762, 588);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 23);
            this.btnEliminar.TabIndex = 64;
            this.btnEliminar.Text = "E&liminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlPac
            // 
            this.pnlPac.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlPac.Controls.Add(this.txtFecEmi);
            this.pnlPac.Controls.Add(this.optPanel);
            this.pnlPac.Controls.Add(this.lstVentas);
            this.pnlPac.Controls.Add(this.lstPacientes);
            this.pnlPac.Controls.Add(this.label5);
            this.pnlPac.Controls.Add(this.label4);
            this.pnlPac.Controls.Add(this.txtNFinal);
            this.pnlPac.Controls.Add(this.txtNInicial);
            this.pnlPac.Controls.Add(this.txtSerie);
            this.pnlPac.Controls.Add(this.cmbTipDoc);
            this.pnlPac.Controls.Add(this.label7);
            this.pnlPac.Controls.Add(this.label8);
            this.pnlPac.Controls.Add(this.label9);
            this.pnlPac.Controls.Add(this.label10);
            this.pnlPac.Controls.Add(this.label11);
            this.pnlPac.Controls.Add(this.txtIdPac);
            this.pnlPac.Location = new System.Drawing.Point(0, 0);
            this.pnlPac.Name = "pnlPac";
            this.pnlPac.Size = new System.Drawing.Size(900, 299);
            this.pnlPac.TabIndex = 66;
            // 
            // optPanel
            // 
            this.optPanel.Controls.Add(this.rb0);
            this.optPanel.Controls.Add(this.rb3);
            this.optPanel.Controls.Add(this.rb1);
            this.optPanel.Controls.Add(this.rb2);
            this.optPanel.Location = new System.Drawing.Point(768, 9);
            this.optPanel.Name = "optPanel";
            this.optPanel.Size = new System.Drawing.Size(108, 100);
            this.optPanel.TabIndex = 32;
            // 
            // rb0
            // 
            this.rb0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb0.BackColor = System.Drawing.SystemColors.Control;
            this.rb0.Checked = true;
            this.rb0.Location = new System.Drawing.Point(1, 2);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(104, 24);
            this.rb0.TabIndex = 28;
            this.rb0.TabStop = true;
            this.rb0.Text = "Anulado";
            this.rb0.UseVisualStyleBackColor = false;
            this.rb0.CheckedChanged += new System.EventHandler(this.rb0_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb3.BackColor = System.Drawing.SystemColors.Control;
            this.rb3.Location = new System.Drawing.Point(1, 74);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(104, 24);
            this.rb3.TabIndex = 31;
            this.rb3.Text = "Observación";
            this.rb3.UseVisualStyleBackColor = false;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb1.BackColor = System.Drawing.SystemColors.Control;
            this.rb1.Location = new System.Drawing.Point(1, 26);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(104, 24);
            this.rb1.TabIndex = 29;
            this.rb1.Text = "Descuento";
            this.rb1.UseVisualStyleBackColor = false;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb2.BackColor = System.Drawing.SystemColors.Control;
            this.rb2.Location = new System.Drawing.Point(1, 50);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(104, 24);
            this.rb2.TabIndex = 30;
            this.rb2.Text = "Extornado";
            this.rb2.UseVisualStyleBackColor = false;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // lstVentas
            // 
            this.lstVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstVentas.FullRowSelect = true;
            this.lstVentas.Location = new System.Drawing.Point(332, 112);
            this.lstVentas.MultiSelect = false;
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(550, 178);
            this.lstVentas.TabIndex = 24;
            this.lstVentas.UseCompatibleStateImageBehavior = false;
            this.lstVentas.View = System.Windows.Forms.View.Details;
            this.lstVentas.SelectedIndexChanged += new System.EventHandler(this.lstVentas_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo Doc.";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Serie y Número";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha de emisión";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nombre de la especialidad";
            this.columnHeader6.Width = 280;
            // 
            // lstPacientes
            // 
            this.lstPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstPacientes.FullRowSelect = true;
            this.lstPacientes.Location = new System.Drawing.Point(7, 136);
            this.lstPacientes.MultiSelect = false;
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(319, 154);
            this.lstPacientes.TabIndex = 23;
            this.lstPacientes.UseCompatibleStateImageBehavior = false;
            this.lstPacientes.View = System.Windows.Forms.View.Details;
            this.lstPacientes.SelectedIndexChanged += new System.EventHandler(this.lstPacientes_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Paciente";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(23, 529);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(310, 54);
            this.txtObservacion.TabIndex = 56;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(358, 594);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(93, 13);
            this.label29.TabIndex = 67;
            this.label29.Text = "Us. Fecha Mod";
            // 
            // especialidadTableAdapter
            // 
            this.especialidadTableAdapter.ClearBeforeFill = true;
            // 
            // docVentaTableAdapter
            // 
            this.docVentaTableAdapter.ClearBeforeFill = true;
            // 
            // txtFecEmi
            // 
            this.txtFecEmi.Location = new System.Drawing.Point(618, 35);
            this.txtFecEmi.Mask = "00/00/0000";
            this.txtFecEmi.Name = "txtFecEmi";
            this.txtFecEmi.Size = new System.Drawing.Size(120, 20);
            this.txtFecEmi.TabIndex = 33;
            this.txtFecEmi.ValidatingType = typeof(System.DateTime);
            this.txtFecEmi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFecEmi_KeyDown);
            // 
            // txtFecNac
            // 
            this.txtFecNac.Location = new System.Drawing.Point(594, 323);
            this.txtFecNac.Mask = "00/00/0000";
            this.txtFecNac.Name = "txtFecNac";
            this.txtFecNac.Size = new System.Drawing.Size(102, 20);
            this.txtFecNac.TabIndex = 68;
            this.txtFecNac.ValidatingType = typeof(System.DateTime);
            // 
            // txtFecExt
            // 
            this.txtFecExt.Location = new System.Drawing.Point(735, 373);
            this.txtFecExt.Mask = "00/00/0000";
            this.txtFecExt.Name = "txtFecExt";
            this.txtFecExt.Size = new System.Drawing.Size(72, 20);
            this.txtFecExt.TabIndex = 69;
            this.txtFecExt.ValidatingType = typeof(System.DateTime);
            // 
            // frmMntVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 635);
            this.ControlBox = false;
            this.Controls.Add(this.txtFecExt);
            this.Controls.Add(this.txtFecNac);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtUsFecMod);
            this.Controls.Add(this.grdDet);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cmbAprDscto);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.cmbMotAnul);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtDscto);
            this.Controls.Add(this.cmbUsExt);
            this.Controls.Add(this.cmbOpExt);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCajero);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.cmbFPago);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApeMat);
            this.Controls.Add(this.txtApePat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmMntVentas";
            this.Text = "Depuración de Documentos de Venta";
            this.Load += new System.EventHandler(this.frmMntVentas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMntVentas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDet)).EndInit();
            this.pnlPac.ResumeLayout(false);
            this.pnlPac.PerformLayout();
            this.optPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ComboBox cmbTipDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtNInicial;
        private System.Windows.Forms.TextBox txtNFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdPac;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbFPago;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cmbOpExt;
        private System.Windows.Forms.ComboBox cmbUsExt;
        private System.Windows.Forms.TextBox txtDscto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbMotAnul;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbAprDscto;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView grdDet;
        private System.Windows.Forms.TextBox txtUsFecMod;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlPac;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private Dominio.Data.ConsultoriosDS consultoriosDS;
        private Dominio.Data.ConsultoriosDSTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
        private Dominio.Data.TablaTipoDS tablaTipoDS;
        private System.Windows.Forms.BindingSource docVentaBindingSource;
        private Dominio.Data.TablaTipoDSTableAdapters.DocVentaTableAdapter docVentaTableAdapter;
        private System.Windows.Forms.ListView lstPacientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstVentas;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.Panel optPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dscto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Historia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PD;
        private System.Windows.Forms.MaskedTextBox txtFecEmi;
        private System.Windows.Forms.MaskedTextBox txtFecNac;
        private System.Windows.Forms.MaskedTextBox txtFecExt;
    }
}