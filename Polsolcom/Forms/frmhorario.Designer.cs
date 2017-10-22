namespace Polsolcom.Forms
{
    partial class frmhorario
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
            this.dtpTurn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspedd = new System.Windows.Forms.ComboBox();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEspelst = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTrun = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gdvEspec = new System.Windows.Forms.DataGridView();
            this.cFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEspecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTurn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAsistio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtHor = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chklstAsistio = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEspec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Turno";
            // 
            // dtpTurn
            // 
            this.dtpTurn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTurn.Location = new System.Drawing.Point(16, 44);
            this.dtpTurn.Name = "dtpTurn";
            this.dtpTurn.Size = new System.Drawing.Size(99, 20);
            this.dtpTurn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(131, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione Especialidad";
            // 
            // cmbEspedd
            // 
            this.cmbEspedd.FormattingEnabled = true;
            this.cmbEspedd.Location = new System.Drawing.Point(134, 43);
            this.cmbEspedd.Name = "cmbEspedd";
            this.cmbEspedd.Size = new System.Drawing.Size(336, 21);
            this.cmbEspedd.TabIndex = 3;
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(476, 42);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(169, 21);
            this.cmbConsultorio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(473, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione Consultorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione Especialista";
            // 
            // cmbEspelst
            // 
            this.cmbEspelst.FormattingEnabled = true;
            this.cmbEspelst.Location = new System.Drawing.Point(16, 109);
            this.cmbEspelst.Name = "cmbEspelst";
            this.cmbEspelst.Size = new System.Drawing.Size(293, 21);
            this.cmbEspelst.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(312, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seleccione Turno";
            // 
            // cmbTrun
            // 
            this.cmbTrun.FormattingEnabled = true;
            this.cmbTrun.Location = new System.Drawing.Point(315, 107);
            this.cmbTrun.Name = "cmbTrun";
            this.cmbTrun.Size = new System.Drawing.Size(155, 21);
            this.cmbTrun.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(473, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Horas";
            // 
            // gdvEspec
            // 
            this.gdvEspec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvEspec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFech,
            this.cEspecialidad,
            this.cBus,
            this.cEspecialista,
            this.cTurn,
            this.cDe,
            this.cAsistio,
            this.cHoras});
            this.gdvEspec.Location = new System.Drawing.Point(16, 159);
            this.gdvEspec.Name = "gdvEspec";
            this.gdvEspec.Size = new System.Drawing.Size(763, 170);
            this.gdvEspec.TabIndex = 11;
            // 
            // cFech
            // 
            this.cFech.HeaderText = "Fecha";
            this.cFech.Name = "cFech";
            this.cFech.Width = 60;
            // 
            // cEspecialidad
            // 
            this.cEspecialidad.HeaderText = "Especialidad";
            this.cEspecialidad.Name = "cEspecialidad";
            this.cEspecialidad.Width = 160;
            // 
            // cBus
            // 
            this.cBus.HeaderText = "Bus";
            this.cBus.Name = "cBus";
            this.cBus.Width = 80;
            // 
            // cEspecialista
            // 
            this.cEspecialista.HeaderText = "Especialista";
            this.cEspecialista.Name = "cEspecialista";
            this.cEspecialista.Width = 200;
            // 
            // cTurn
            // 
            this.cTurn.HeaderText = "Turno";
            this.cTurn.Name = "cTurn";
            // 
            // cDe
            // 
            this.cDe.HeaderText = "De";
            this.cDe.Name = "cDe";
            this.cDe.Width = 40;
            // 
            // cAsistio
            // 
            this.cAsistio.HeaderText = "A";
            this.cAsistio.Name = "cAsistio";
            this.cAsistio.Width = 40;
            // 
            // cHoras
            // 
            this.cHoras.HeaderText = "Horas";
            this.cHoras.Name = "cHoras";
            this.cHoras.Width = 40;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(686, 14);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 30);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrabar.Location = new System.Drawing.Point(686, 57);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(93, 30);
            this.btnGrabar.TabIndex = 13;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(686, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 30);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(48, 348);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 30);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(352, 348);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(118, 30);
            this.btnFiltrar.TabIndex = 16;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(200, 348);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(118, 30);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // txtHor
            // 
            this.txtHor.Location = new System.Drawing.Point(476, 108);
            this.txtHor.Name = "txtHor";
            this.txtHor.Size = new System.Drawing.Size(61, 20);
            this.txtHor.TabIndex = 18;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(487, 348);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 30);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Im&primir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(627, 348);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 30);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // chklstAsistio
            // 
            this.chklstAsistio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chklstAsistio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklstAsistio.FormattingEnabled = true;
            this.chklstAsistio.Items.AddRange(new object[] {
            "Asistio",
            "Cerrado"});
            this.chklstAsistio.Location = new System.Drawing.Point(556, 96);
            this.chklstAsistio.Name = "chklstAsistio";
            this.chklstAsistio.Size = new System.Drawing.Size(89, 32);
            this.chklstAsistio.TabIndex = 21;
            // 
            // frmhorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 389);
            this.ControlBox = false;
            this.Controls.Add(this.chklstAsistio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtHor);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gdvEspec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTrun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEspelst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.cmbEspedd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTurn);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmhorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso y Mantenimiento de Horarios";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmhorario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gdvEspec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEspedd;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEspelst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTrun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gdvEspec;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTurn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAsistio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHoras;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtHor;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckedListBox chklstAsistio;
    }
}