using Polsolcom.Dominio.Controls;
using Polsolcom.Dominio.Helpers;

namespace Polsolcom.Forms
{
    partial class frmEstVent
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
            Polsolcom.Dominio.Controls.CheckBoxProperties checkBoxProperties1 = new Polsolcom.Dominio.Controls.CheckBoxProperties();
            Polsolcom.Dominio.Controls.CheckBoxProperties checkBoxProperties2 = new Polsolcom.Dominio.Controls.CheckBoxProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstVent));
            Polsolcom.Dominio.Controls.CheckBoxProperties checkBoxProperties3 = new Polsolcom.Dominio.Controls.CheckBoxProperties();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnVerGraf = new System.Windows.Forms.Button();
            this.rbEspecialidad = new System.Windows.Forms.RadioButton();
            this.rbAños = new System.Windows.Forms.RadioButton();
            this.rbFechas = new System.Windows.Forms.RadioButton();
            this.rbMeses = new System.Windows.Forms.RadioButton();
            this.cmbEspecialidad = new Polsolcom.Dominio.Controls.CheckBoxComboBox();
            this.cmbMeses = new Polsolcom.Dominio.Controls.CheckBoxComboBox();
            this.dtpicFFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpicFInicial = new System.Windows.Forms.DateTimePicker();
            this.grpTipoGraph = new System.Windows.Forms.GroupBox();
            this.optCircular = new System.Windows.Forms.RadioButton();
            this.optLineas = new System.Windows.Forms.RadioButton();
            this.optAreas = new System.Windows.Forms.RadioButton();
            this.optBarras = new System.Windows.Forms.RadioButton();
            this.optColumnas = new System.Windows.Forms.RadioButton();
            this.fGrid = new TenTec.Windows.iGridLib.iGrid();
            this.txtTTot = new System.Windows.Forms.TextBox();
            this.txtTOld = new System.Windows.Forms.TextBox();
            this.txtTNew = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbOperativo = new Polsolcom.Dominio.Controls.CheckBoxComboBox();
            this.grpAgrupacion = new System.Windows.Forms.GroupBox();
            this.grpTipoGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).BeginInit();
            this.grpAgrupacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha y Hora Inicial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(180, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha y Hora Final:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(10, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Operativo";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(193, 220);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(151, 23);
            this.btnEjecutar.TabIndex = 22;
            this.btnEjecutar.Text = "E&jecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnVerGraf
            // 
            this.btnVerGraf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerGraf.Location = new System.Drawing.Point(434, 220);
            this.btnVerGraf.Name = "btnVerGraf";
            this.btnVerGraf.Size = new System.Drawing.Size(151, 23);
            this.btnVerGraf.TabIndex = 24;
            this.btnVerGraf.Text = "&Ver Gráfico";
            this.btnVerGraf.UseVisualStyleBackColor = true;
            this.btnVerGraf.Click += new System.EventHandler(this.btnVerGraf_Click);
            // 
            // rbEspecialidad
            // 
            this.rbEspecialidad.AccessibleDescription = "Especialidad";
            this.rbEspecialidad.AutoSize = true;
            this.rbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEspecialidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbEspecialidad.Location = new System.Drawing.Point(15, 84);
            this.rbEspecialidad.Name = "rbEspecialidad";
            this.rbEspecialidad.Size = new System.Drawing.Size(106, 17);
            this.rbEspecialidad.TabIndex = 50;
            this.rbEspecialidad.Text = "Por especialidad:";
            this.rbEspecialidad.UseVisualStyleBackColor = true;
            // 
            // rbAños
            // 
            this.rbAños.AccessibleDescription = "Años";
            this.rbAños.AutoSize = true;
            this.rbAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAños.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAños.Location = new System.Drawing.Point(14, 63);
            this.rbAños.Name = "rbAños";
            this.rbAños.Size = new System.Drawing.Size(67, 17);
            this.rbAños.TabIndex = 49;
            this.rbAños.Text = "Por años";
            this.rbAños.UseVisualStyleBackColor = true;
            // 
            // rbFechas
            // 
            this.rbFechas.AccessibleDescription = "Fechas";
            this.rbFechas.AutoSize = true;
            this.rbFechas.Checked = true;
            this.rbFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFechas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbFechas.Location = new System.Drawing.Point(14, 21);
            this.rbFechas.Name = "rbFechas";
            this.rbFechas.Size = new System.Drawing.Size(76, 17);
            this.rbFechas.TabIndex = 47;
            this.rbFechas.TabStop = true;
            this.rbFechas.Text = "Por fechas";
            this.rbFechas.UseVisualStyleBackColor = true;
            // 
            // rbMeses
            // 
            this.rbMeses.AccessibleDescription = "Meses";
            this.rbMeses.AutoSize = true;
            this.rbMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbMeses.Location = new System.Drawing.Point(14, 42);
            this.rbMeses.Name = "rbMeses";
            this.rbMeses.Size = new System.Drawing.Size(77, 17);
            this.rbMeses.TabIndex = 48;
            this.rbMeses.Text = "Por meses:";
            this.rbMeses.UseVisualStyleBackColor = true;
            this.rbMeses.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cmbEspecialidad
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbEspecialidad.CheckBoxProperties = checkBoxProperties1;
            this.cmbEspecialidad.DisplayMemberSingleItem = "";
            this.cmbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(122, 85);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(256, 21);
            this.cmbEspecialidad.TabIndex = 17;
            // 
            // cmbMeses
            // 
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbMeses.CheckBoxProperties = checkBoxProperties2;
            this.cmbMeses.DisplayMemberSingleItem = "";
            this.cmbMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(122, 40);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(257, 21);
            this.cmbMeses.TabIndex = 16;
            // 
            // dtpicFFinal
            // 
            this.dtpicFFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicFFinal.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpicFFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpicFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicFFinal.Location = new System.Drawing.Point(180, 23);
            this.dtpicFFinal.Name = "dtpicFFinal";
            this.dtpicFFinal.Size = new System.Drawing.Size(164, 20);
            this.dtpicFFinal.TabIndex = 31;
            this.dtpicFFinal.Value = new System.DateTime(2017, 4, 8, 9, 44, 22, 0);
            // 
            // dtpicFInicial
            // 
            this.dtpicFInicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicFInicial.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpicFInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpicFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicFInicial.Location = new System.Drawing.Point(9, 24);
            this.dtpicFInicial.Name = "dtpicFInicial";
            this.dtpicFInicial.Size = new System.Drawing.Size(152, 20);
            this.dtpicFInicial.TabIndex = 30;
            this.dtpicFInicial.Value = new System.DateTime(2017, 4, 8, 9, 44, 33, 0);
            // 
            // grpTipoGraph
            // 
            this.grpTipoGraph.Controls.Add(this.optCircular);
            this.grpTipoGraph.Controls.Add(this.optLineas);
            this.grpTipoGraph.Controls.Add(this.optAreas);
            this.grpTipoGraph.Controls.Add(this.optBarras);
            this.grpTipoGraph.Controls.Add(this.optColumnas);
            this.grpTipoGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoGraph.ForeColor = System.Drawing.Color.Navy;
            this.grpTipoGraph.Location = new System.Drawing.Point(429, 10);
            this.grpTipoGraph.Name = "grpTipoGraph";
            this.grpTipoGraph.Size = new System.Drawing.Size(175, 147);
            this.grpTipoGraph.TabIndex = 33;
            this.grpTipoGraph.TabStop = false;
            this.grpTipoGraph.Text = "Tipo de Grafico";
            // 
            // optCircular
            // 
            this.optCircular.ForeColor = System.Drawing.Color.Black;
            this.optCircular.Image = ((System.Drawing.Image)(resources.GetObject("optCircular.Image")));
            this.optCircular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optCircular.Location = new System.Drawing.Point(10, 112);
            this.optCircular.Name = "optCircular";
            this.optCircular.Size = new System.Drawing.Size(136, 21);
            this.optCircular.TabIndex = 6;
            this.optCircular.Text = "Grafico Circular";
            this.optCircular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optCircular.UseVisualStyleBackColor = true;
            // 
            // optLineas
            // 
            this.optLineas.ForeColor = System.Drawing.Color.Black;
            this.optLineas.Image = ((System.Drawing.Image)(resources.GetObject("optLineas.Image")));
            this.optLineas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optLineas.Location = new System.Drawing.Point(10, 88);
            this.optLineas.Name = "optLineas";
            this.optLineas.Size = new System.Drawing.Size(148, 21);
            this.optLineas.TabIndex = 5;
            this.optLineas.Text = "Grafico de Lineas";
            this.optLineas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optLineas.UseVisualStyleBackColor = true;
            // 
            // optAreas
            // 
            this.optAreas.ForeColor = System.Drawing.Color.Black;
            this.optAreas.Image = ((System.Drawing.Image)(resources.GetObject("optAreas.Image")));
            this.optAreas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optAreas.Location = new System.Drawing.Point(10, 65);
            this.optAreas.Name = "optAreas";
            this.optAreas.Size = new System.Drawing.Size(142, 21);
            this.optAreas.TabIndex = 4;
            this.optAreas.Text = "Grafico de Areas";
            this.optAreas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optAreas.UseVisualStyleBackColor = true;
            // 
            // optBarras
            // 
            this.optBarras.ForeColor = System.Drawing.Color.Black;
            this.optBarras.Image = ((System.Drawing.Image)(resources.GetObject("optBarras.Image")));
            this.optBarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optBarras.Location = new System.Drawing.Point(10, 42);
            this.optBarras.Name = "optBarras";
            this.optBarras.Size = new System.Drawing.Size(146, 21);
            this.optBarras.TabIndex = 3;
            this.optBarras.Text = "Grafico de Barras";
            this.optBarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optBarras.UseVisualStyleBackColor = true;
            // 
            // optColumnas
            // 
            this.optColumnas.Checked = true;
            this.optColumnas.ForeColor = System.Drawing.Color.Black;
            this.optColumnas.Image = ((System.Drawing.Image)(resources.GetObject("optColumnas.Image")));
            this.optColumnas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optColumnas.Location = new System.Drawing.Point(10, 19);
            this.optColumnas.Name = "optColumnas";
            this.optColumnas.Size = new System.Drawing.Size(163, 21);
            this.optColumnas.TabIndex = 2;
            this.optColumnas.TabStop = true;
            this.optColumnas.Text = "Grafico de Columnas";
            this.optColumnas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optColumnas.UseVisualStyleBackColor = true;
            // 
            // fGrid
            // 
            this.fGrid.Location = new System.Drawing.Point(6, 250);
            this.fGrid.Name = "fGrid";
            this.fGrid.ReadOnly = true;
            this.fGrid.Size = new System.Drawing.Size(650, 250);
            this.fGrid.TabIndex = 0;
            // 
            // txtTTot
            // 
            this.txtTTot.Location = new System.Drawing.Point(555, 506);
            this.txtTTot.Name = "txtTTot";
            this.txtTTot.ReadOnly = true;
            this.txtTTot.Size = new System.Drawing.Size(100, 20);
            this.txtTTot.TabIndex = 45;
            // 
            // txtTOld
            // 
            this.txtTOld.Location = new System.Drawing.Point(449, 506);
            this.txtTOld.Name = "txtTOld";
            this.txtTOld.ReadOnly = true;
            this.txtTOld.Size = new System.Drawing.Size(100, 20);
            this.txtTOld.TabIndex = 44;
            // 
            // txtTNew
            // 
            this.txtTNew.Location = new System.Drawing.Point(345, 506);
            this.txtTNew.Name = "txtTNew";
            this.txtTNew.ReadOnly = true;
            this.txtTNew.Size = new System.Drawing.Size(100, 20);
            this.txtTNew.TabIndex = 43;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidad.Location = new System.Drawing.Point(9, 505);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(80, 13);
            this.lblCantidad.TabIndex = 46;
            this.lblCantidad.Text = "000";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOperativo
            // 
            checkBoxProperties3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbOperativo.CheckBoxProperties = checkBoxProperties3;
            this.cmbOperativo.DisplayMemberSingleItem = "";
            this.cmbOperativo.FormattingEnabled = true;
            this.cmbOperativo.Location = new System.Drawing.Point(74, 53);
            this.cmbOperativo.Name = "cmbOperativo";
            this.cmbOperativo.Size = new System.Drawing.Size(270, 21);
            this.cmbOperativo.TabIndex = 37;
            // 
            // grpAgrupacion
            // 
            this.grpAgrupacion.Controls.Add(this.rbEspecialidad);
            this.grpAgrupacion.Controls.Add(this.cmbEspecialidad);
            this.grpAgrupacion.Controls.Add(this.rbFechas);
            this.grpAgrupacion.Controls.Add(this.cmbMeses);
            this.grpAgrupacion.Controls.Add(this.rbAños);
            this.grpAgrupacion.Controls.Add(this.rbMeses);
            this.grpAgrupacion.Location = new System.Drawing.Point(10, 81);
            this.grpAgrupacion.Name = "grpAgrupacion";
            this.grpAgrupacion.Size = new System.Drawing.Size(395, 125);
            this.grpAgrupacion.TabIndex = 50;
            this.grpAgrupacion.TabStop = false;
            this.grpAgrupacion.Text = "Agrupar por";
            // 
            // frmEstVent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 535);
            this.ControlBox = false;
            this.Controls.Add(this.grpAgrupacion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtTTot);
            this.Controls.Add(this.txtTOld);
            this.Controls.Add(this.txtTNew);
            this.Controls.Add(this.cmbOperativo);
            this.Controls.Add(this.grpTipoGraph);
            this.Controls.Add(this.dtpicFFinal);
            this.Controls.Add(this.dtpicFInicial);
            this.Controls.Add(this.btnVerGraf);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmEstVent";
            this.Text = "Estadísticas de Ventas";
            this.Load += new System.EventHandler(this.frmEstVent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEstVent_KeyDown);
            this.grpTipoGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).EndInit();
            this.grpAgrupacion.ResumeLayout(false);
            this.grpAgrupacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnVerGraf;
        private System.Windows.Forms.DateTimePicker dtpicFFinal;
        private System.Windows.Forms.DateTimePicker dtpicFInicial;
        private System.Windows.Forms.GroupBox grpTipoGraph;
        private System.Windows.Forms.RadioButton optCircular;
        private System.Windows.Forms.RadioButton optLineas;
        private System.Windows.Forms.RadioButton optAreas;
        private System.Windows.Forms.RadioButton optBarras;
        private System.Windows.Forms.RadioButton optColumnas;
        private TenTec.Windows.iGridLib.iGrid fGrid;
        private CheckBoxComboBox cmbOperativo;
        private CheckBoxComboBox cmbEspecialidad;
        private CheckBoxComboBox cmbMeses;
        private System.Windows.Forms.TextBox txtTTot;
        private System.Windows.Forms.TextBox txtTOld;
        private System.Windows.Forms.TextBox txtTNew;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.RadioButton rbFechas;
        private System.Windows.Forms.RadioButton rbMeses;
        private System.Windows.Forms.RadioButton rbEspecialidad;
        private System.Windows.Forms.RadioButton rbAños;
        private System.Windows.Forms.GroupBox grpAgrupacion;
    }
}