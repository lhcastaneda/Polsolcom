namespace Polsolcom.Forms.Consultas
{
    partial class frmPaciente
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
            this.grpNom = new System.Windows.Forms.GroupBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grpDNI = new System.Windows.Forms.GroupBox();
            this.txtDni = new System.Windows.Forms.MaskedTextBox();
            this.grpIdPac = new System.Windows.Forms.GroupBox();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.grpNroPac = new System.Windows.Forms.GroupBox();
            this.txtNroHist = new System.Windows.Forms.MaskedTextBox();
            this.grpApeMat = new System.Windows.Forms.GroupBox();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.grpApePat = new System.Windows.Forms.GroupBox();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.lstPacientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpNom.SuspendLayout();
            this.grpDNI.SuspendLayout();
            this.grpIdPac.SuspendLayout();
            this.grpNroPac.SuspendLayout();
            this.grpApeMat.SuspendLayout();
            this.grpApePat.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNom
            // 
            this.grpNom.Controls.Add(this.txtNom);
            this.grpNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNom.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpNom.Location = new System.Drawing.Point(302, 7);
            this.grpNom.Name = "grpNom";
            this.grpNom.Size = new System.Drawing.Size(140, 43);
            this.grpNom.TabIndex = 9;
            this.grpNom.TabStop = false;
            this.grpNom.Text = "Nombres";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(6, 17);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(128, 20);
            this.txtNom.TabIndex = 0;
            // 
            // grpDNI
            // 
            this.grpDNI.Controls.Add(this.txtDni);
            this.grpDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDNI.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpDNI.Location = new System.Drawing.Point(444, 8);
            this.grpDNI.Name = "grpDNI";
            this.grpDNI.Size = new System.Drawing.Size(78, 43);
            this.grpDNI.TabIndex = 10;
            this.grpDNI.TabStop = false;
            this.grpDNI.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(5, 17);
            this.txtDni.Mask = "99999999";
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(67, 20);
            this.txtDni.TabIndex = 0;
            this.txtDni.Tag = "0";
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpIdPac
            // 
            this.grpIdPac.Controls.Add(this.txtIdPac);
            this.grpIdPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIdPac.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpIdPac.Location = new System.Drawing.Point(526, 7);
            this.grpIdPac.Name = "grpIdPac";
            this.grpIdPac.Size = new System.Drawing.Size(92, 43);
            this.grpIdPac.TabIndex = 11;
            this.grpIdPac.TabStop = false;
            this.grpIdPac.Text = "ID Paciente";
            // 
            // txtIdPac
            // 
            this.txtIdPac.Location = new System.Drawing.Point(6, 17);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.Size = new System.Drawing.Size(81, 20);
            this.txtIdPac.TabIndex = 0;
            // 
            // grpNroPac
            // 
            this.grpNroPac.Controls.Add(this.txtNroHist);
            this.grpNroPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNroPac.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpNroPac.Location = new System.Drawing.Point(624, 7);
            this.grpNroPac.Name = "grpNroPac";
            this.grpNroPac.Size = new System.Drawing.Size(98, 43);
            this.grpNroPac.TabIndex = 12;
            this.grpNroPac.TabStop = false;
            this.grpNroPac.Text = "Nro Historia";
            // 
            // txtNroHist
            // 
            this.txtNroHist.Location = new System.Drawing.Point(4, 18);
            this.txtNroHist.Mask = "999999";
            this.txtNroHist.Name = "txtNroHist";
            this.txtNroHist.Size = new System.Drawing.Size(90, 20);
            this.txtNroHist.TabIndex = 0;
            this.txtNroHist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpApeMat
            // 
            this.grpApeMat.Controls.Add(this.txtApeMat);
            this.grpApeMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpApeMat.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpApeMat.Location = new System.Drawing.Point(158, 6);
            this.grpApeMat.Name = "grpApeMat";
            this.grpApeMat.Size = new System.Drawing.Size(140, 43);
            this.grpApeMat.TabIndex = 8;
            this.grpApeMat.TabStop = false;
            this.grpApeMat.Text = "Apellido Materno";
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(6, 17);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(128, 20);
            this.txtApeMat.TabIndex = 0;
            // 
            // grpApePat
            // 
            this.grpApePat.Controls.Add(this.txtApePat);
            this.grpApePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpApePat.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpApePat.Location = new System.Drawing.Point(16, 5);
            this.grpApePat.Name = "grpApePat";
            this.grpApePat.Size = new System.Drawing.Size(140, 43);
            this.grpApePat.TabIndex = 7;
            this.grpApePat.TabStop = false;
            this.grpApePat.Text = "Apellido Paterno";
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(6, 17);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(128, 20);
            this.txtApePat.TabIndex = 0;
            // 
            // lstPacientes
            // 
            this.lstPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstPacientes.FullRowSelect = true;
            this.lstPacientes.Location = new System.Drawing.Point(15, 56);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(709, 174);
            this.lstPacientes.TabIndex = 13;
            this.lstPacientes.UseCompatibleStateImageBehavior = false;
            this.lstPacientes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Apellidos y Nombres";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dirección y Distrito";
            this.columnHeader2.Width = 280;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DNI";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Teléfono";
            this.columnHeader4.Width = 100;
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 242);
            this.Controls.Add(this.grpNom);
            this.Controls.Add(this.grpDNI);
            this.Controls.Add(this.grpIdPac);
            this.Controls.Add(this.grpNroPac);
            this.Controls.Add(this.grpApeMat);
            this.Controls.Add(this.grpApePat);
            this.Controls.Add(this.lstPacientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaciente";
            this.Text = "Mantenimiento del registro de pacientes ...";
            this.grpNom.ResumeLayout(false);
            this.grpNom.PerformLayout();
            this.grpDNI.ResumeLayout(false);
            this.grpDNI.PerformLayout();
            this.grpIdPac.ResumeLayout(false);
            this.grpIdPac.PerformLayout();
            this.grpNroPac.ResumeLayout(false);
            this.grpNroPac.PerformLayout();
            this.grpApeMat.ResumeLayout(false);
            this.grpApeMat.PerformLayout();
            this.grpApePat.ResumeLayout(false);
            this.grpApePat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox grpDNI;
        private System.Windows.Forms.MaskedTextBox txtDni;
        private System.Windows.Forms.GroupBox grpIdPac;
        private System.Windows.Forms.TextBox txtIdPac;
        private System.Windows.Forms.GroupBox grpNroPac;
        private System.Windows.Forms.MaskedTextBox txtNroHist;
        private System.Windows.Forms.GroupBox grpApeMat;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.GroupBox grpApePat;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.ListView lstPacientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}