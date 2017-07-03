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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnVerGraf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpTipoGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Operativo";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(464, 282);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(151, 23);
            this.btnEjecutar.TabIndex = 22;
            this.btnEjecutar.Text = "E&jecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tipo de Gráfico";
            // 
            // btnVerGraf
            // 
            this.btnVerGraf.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnVerGraf.Location = new System.Drawing.Point(469, 322);
            this.btnVerGraf.Name = "btnVerGraf";
            this.btnVerGraf.Size = new System.Drawing.Size(151, 23);
            this.btnVerGraf.TabIndex = 24;
            this.btnVerGraf.Text = "&Ver Gráfico";
            this.btnVerGraf.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.cmbEspecialidad);
            this.groupBox1.Controls.Add(this.cmbMeses);
            this.groupBox1.Location = new System.Drawing.Point(19, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 133);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agrupar por:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbEspecialidad);
            this.panel1.Controls.Add(this.rbAños);
            this.panel1.Controls.Add(this.rbFechas);
            this.panel1.Controls.Add(this.rbMeses);
            this.panel1.Location = new System.Drawing.Point(8, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 107);
            this.panel1.TabIndex = 49;
            // 
            // rbEspecialidad
            // 
            this.rbEspecialidad.AutoSize = true;
            this.rbEspecialidad.Location = new System.Drawing.Point(9, 75);
            this.rbEspecialidad.Name = "rbEspecialidad";
            this.rbEspecialidad.Size = new System.Drawing.Size(119, 17);
            this.rbEspecialidad.TabIndex = 50;
            this.rbEspecialidad.Text = "Por especialidad";
            this.rbEspecialidad.UseVisualStyleBackColor = true;
            // 
            // rbAños
            // 
            this.rbAños.AutoSize = true;
            this.rbAños.Location = new System.Drawing.Point(8, 54);
            this.rbAños.Name = "rbAños";
            this.rbAños.Size = new System.Drawing.Size(75, 17);
            this.rbAños.TabIndex = 49;
            this.rbAños.Text = "Por años";
            this.rbAños.UseVisualStyleBackColor = true;
            // 
            // rbFechas
            // 
            this.rbFechas.AutoSize = true;
            this.rbFechas.Checked = true;
            this.rbFechas.Location = new System.Drawing.Point(8, 12);
            this.rbFechas.Name = "rbFechas";
            this.rbFechas.Size = new System.Drawing.Size(86, 17);
            this.rbFechas.TabIndex = 47;
            this.rbFechas.TabStop = true;
            this.rbFechas.Text = "Por fechas";
            this.rbFechas.UseVisualStyleBackColor = true;
            // 
            // rbMeses
            // 
            this.rbMeses.AutoSize = true;
            this.rbMeses.Location = new System.Drawing.Point(8, 33);
            this.rbMeses.Name = "rbMeses";
            this.rbMeses.Size = new System.Drawing.Size(83, 17);
            this.rbMeses.TabIndex = 48;
            this.rbMeses.Text = "Por meses";
            this.rbMeses.UseVisualStyleBackColor = true;
            this.rbMeses.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cmbEspecialidad
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbEspecialidad.CheckBoxProperties = checkBoxProperties1;
            this.cmbEspecialidad.DisplayMemberSingleItem = "";
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(168, 93);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(178, 21);
            this.cmbEspecialidad.TabIndex = 17;
            // 
            // cmbMeses
            // 
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbMeses.CheckBoxProperties = checkBoxProperties2;
            this.cmbMeses.DisplayMemberSingleItem = "";
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(168, 46);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(181, 21);
            this.cmbMeses.TabIndex = 16;
            // 
            // dtpicFFinal
            // 
            this.dtpicFFinal.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpicFFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpicFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicFFinal.Location = new System.Drawing.Point(83, 113);
            this.dtpicFFinal.Name = "dtpicFFinal";
            this.dtpicFFinal.Size = new System.Drawing.Size(164, 20);
            this.dtpicFFinal.TabIndex = 31;
            this.dtpicFFinal.Value = new System.DateTime(2017, 4, 8, 9, 44, 22, 0);
            // 
            // dtpicFInicial
            // 
            this.dtpicFInicial.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpicFInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpicFInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicFInicial.Location = new System.Drawing.Point(86, 47);
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
            this.grpTipoGraph.Location = new System.Drawing.Point(330, 28);
            this.grpTipoGraph.Name = "grpTipoGraph";
            this.grpTipoGraph.Size = new System.Drawing.Size(324, 90);
            this.grpTipoGraph.TabIndex = 33;
            this.grpTipoGraph.TabStop = false;
            this.grpTipoGraph.Text = "Tipo de Grafico";
            // 
            // optCircular
            // 
            this.optCircular.ForeColor = System.Drawing.Color.Black;
            this.optCircular.Image = ((System.Drawing.Image)(resources.GetObject("optCircular.Image")));
            this.optCircular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optCircular.Location = new System.Drawing.Point(174, 42);
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
            this.optLineas.Location = new System.Drawing.Point(174, 19);
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
            this.fGrid.Location = new System.Drawing.Point(6, 360);
            this.fGrid.Name = "fGrid";
            this.fGrid.ReadOnly = true;
            this.fGrid.Size = new System.Drawing.Size(650, 176);
            this.fGrid.TabIndex = 0;
            // 
            // txtTTot
            // 
            this.txtTTot.Location = new System.Drawing.Point(554, 541);
            this.txtTTot.Name = "txtTTot";
            this.txtTTot.ReadOnly = true;
            this.txtTTot.Size = new System.Drawing.Size(100, 20);
            this.txtTTot.TabIndex = 45;
            // 
            // txtTOld
            // 
            this.txtTOld.Location = new System.Drawing.Point(448, 541);
            this.txtTOld.Name = "txtTOld";
            this.txtTOld.ReadOnly = true;
            this.txtTOld.Size = new System.Drawing.Size(100, 20);
            this.txtTOld.TabIndex = 44;
            // 
            // txtTNew
            // 
            this.txtTNew.Location = new System.Drawing.Point(344, 541);
            this.txtTNew.Name = "txtTNew";
            this.txtTNew.ReadOnly = true;
            this.txtTNew.Size = new System.Drawing.Size(100, 20);
            this.txtTNew.TabIndex = 43;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidad.Location = new System.Drawing.Point(8, 540);
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
            this.cmbOperativo.Location = new System.Drawing.Point(95, 169);
            this.cmbOperativo.Name = "cmbOperativo";
            this.cmbOperativo.Size = new System.Drawing.Size(280, 21);
            this.cmbOperativo.TabIndex = 37;
            // 
            // frmEstVent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 622);
            this.ControlBox = false;
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtTTot);
            this.Controls.Add(this.txtTOld);
            this.Controls.Add(this.txtTNew);
            this.Controls.Add(this.cmbOperativo);
            this.Controls.Add(this.grpTipoGraph);
            this.Controls.Add(this.dtpicFFinal);
            this.Controls.Add(this.dtpicFInicial);
            this.Controls.Add(this.btnVerGraf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmEstVent";
            this.Text = "Estadísticas de Ventas";
            this.Load += new System.EventHandler(this.frmEstVent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEstVent_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpTipoGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnVerGraf;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEspecialidad;
        private System.Windows.Forms.RadioButton rbAños;
    }
}