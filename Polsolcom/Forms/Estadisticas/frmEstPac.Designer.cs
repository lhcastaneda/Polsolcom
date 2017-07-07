namespace Polsolcom.Forms
{
    partial class frmEstPac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstPac));
            this.fGrid = new TenTec.Windows.iGridLib.iGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.grpTipoGraph = new System.Windows.Forms.GroupBox();
            this.optCircular = new System.Windows.Forms.RadioButton();
            this.optLineas = new System.Windows.Forms.RadioButton();
            this.optAreas = new System.Windows.Forms.RadioButton();
            this.optBarras = new System.Windows.Forms.RadioButton();
            this.optColumnas = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.optFecha = new System.Windows.Forms.RadioButton();
            this.optAnho = new System.Windows.Forms.RadioButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVerGraf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTNew = new System.Windows.Forms.TextBox();
            this.txtTOld = new System.Windows.Forms.TextBox();
            this.txtTTot = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).BeginInit();
            this.grpTipoGraph.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fGrid
            // 
            resources.ApplyResources(this.fGrid, "fGrid");
            this.fGrid.Name = "fGrid";
            this.fGrid.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Name = "label4";
            // 
            // btnExportar
            // 
            resources.ApplyResources(this.btnExportar, "btnExportar");
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dtpInicio
            // 
            resources.ApplyResources(this.dtpInicio, "dtpInicio");
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dtpFinal
            // 
            resources.ApplyResources(this.dtpFinal, "dtpFinal");
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Name = "dtpFinal";
            // 
            // lblCantidad
            // 
            resources.ApplyResources(this.lblCantidad, "lblCantidad");
            this.lblCantidad.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidad.Name = "lblCantidad";
            // 
            // grpTipoGraph
            // 
            this.grpTipoGraph.Controls.Add(this.optCircular);
            this.grpTipoGraph.Controls.Add(this.optLineas);
            this.grpTipoGraph.Controls.Add(this.optAreas);
            this.grpTipoGraph.Controls.Add(this.optBarras);
            this.grpTipoGraph.Controls.Add(this.optColumnas);
            resources.ApplyResources(this.grpTipoGraph, "grpTipoGraph");
            this.grpTipoGraph.ForeColor = System.Drawing.Color.Navy;
            this.grpTipoGraph.Name = "grpTipoGraph";
            this.grpTipoGraph.TabStop = false;
            // 
            // optCircular
            // 
            this.optCircular.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.optCircular, "optCircular");
            this.optCircular.Name = "optCircular";
            this.optCircular.UseVisualStyleBackColor = true;
            // 
            // optLineas
            // 
            this.optLineas.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.optLineas, "optLineas");
            this.optLineas.Name = "optLineas";
            this.optLineas.UseVisualStyleBackColor = true;
            // 
            // optAreas
            // 
            this.optAreas.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.optAreas, "optAreas");
            this.optAreas.Name = "optAreas";
            this.optAreas.UseVisualStyleBackColor = true;
            // 
            // optBarras
            // 
            this.optBarras.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.optBarras, "optBarras");
            this.optBarras.Name = "optBarras";
            this.optBarras.UseVisualStyleBackColor = true;
            // 
            // optColumnas
            // 
            this.optColumnas.Checked = true;
            this.optColumnas.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.optColumnas, "optColumnas");
            this.optColumnas.Name = "optColumnas";
            this.optColumnas.TabStop = true;
            this.optColumnas.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.optFecha);
            this.grpGender.Controls.Add(this.optAnho);
            resources.ApplyResources(this.grpGender, "grpGender");
            this.grpGender.ForeColor = System.Drawing.Color.Navy;
            this.grpGender.Name = "grpGender";
            this.grpGender.TabStop = false;
            // 
            // optFecha
            // 
            resources.ApplyResources(this.optFecha, "optFecha");
            this.optFecha.ForeColor = System.Drawing.Color.Black;
            this.optFecha.Name = "optFecha";
            this.optFecha.UseVisualStyleBackColor = true;
            // 
            // optAnho
            // 
            resources.ApplyResources(this.optAnho, "optAnho");
            this.optAnho.Checked = true;
            this.optAnho.ForeColor = System.Drawing.Color.Black;
            this.optAnho.Name = "optAnho";
            this.optAnho.TabStop = true;
            this.optAnho.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVerGraf
            // 
            resources.ApplyResources(this.btnVerGraf, "btnVerGraf");
            this.btnVerGraf.ForeColor = System.Drawing.Color.Black;
            this.btnVerGraf.Name = "btnVerGraf";
            this.btnVerGraf.UseVisualStyleBackColor = true;
            this.btnVerGraf.Click += new System.EventHandler(this.btnVerGraf_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTNew
            // 
            resources.ApplyResources(this.txtTNew, "txtTNew");
            this.txtTNew.Name = "txtTNew";
            this.txtTNew.ReadOnly = true;
            // 
            // txtTOld
            // 
            resources.ApplyResources(this.txtTOld, "txtTOld");
            this.txtTOld.Name = "txtTOld";
            this.txtTOld.ReadOnly = true;
            // 
            // txtTTot
            // 
            resources.ApplyResources(this.txtTTot, "txtTTot");
            this.txtTTot.Name = "txtTTot";
            this.txtTTot.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFinal);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // frmEstPac
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTTot);
            this.Controls.Add(this.txtTOld);
            this.Controls.Add(this.txtTNew);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerGraf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpTipoGraph);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.fGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmEstPac";
            this.Load += new System.EventHandler(this.frmEstPac_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEstPac_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fGrid)).EndInit();
            this.grpTipoGraph.ResumeLayout(false);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TenTec.Windows.iGridLib.iGrid fGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox grpTipoGraph;
        private System.Windows.Forms.RadioButton optCircular;
        private System.Windows.Forms.RadioButton optLineas;
        private System.Windows.Forms.RadioButton optAreas;
        private System.Windows.Forms.RadioButton optBarras;
        private System.Windows.Forms.RadioButton optColumnas;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton optFecha;
        private System.Windows.Forms.RadioButton optAnho;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVerGraf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTNew;
        private System.Windows.Forms.TextBox txtTOld;
        private System.Windows.Forms.TextBox txtTTot;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}