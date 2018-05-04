namespace Polsolcom.Forms
{
    partial class frmTvAccesos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTvAccesos));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlBotones = new System.Windows.Forms.Panel();
			this.cmdDelAll = new System.Windows.Forms.Button();
			this.cmdDel = new System.Windows.Forms.Button();
			this.cmdAddAll = new System.Windows.Forms.Button();
			this.cmdAdd = new System.Windows.Forms.Button();
			this.cmdCpPl = new System.Windows.Forms.Button();
			this.cmbUsuario = new System.Windows.Forms.ComboBox();
			this.cmbPadMenu = new System.Windows.Forms.ComboBox();
			this.cmdClose = new System.Windows.Forms.Button();
			this.TV1 = new System.Windows.Forms.TreeView();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.TV2 = new System.Windows.Forms.TreeView();
			this.pnlBotones.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(5, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Lista de Accesos por U&suario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkBlue;
			this.label2.Location = new System.Drawing.Point(480, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Lista de Opciones por &Menú";
			// 
			// pnlBotones
			// 
			this.pnlBotones.Controls.Add(this.cmdDelAll);
			this.pnlBotones.Controls.Add(this.cmdDel);
			this.pnlBotones.Controls.Add(this.cmdAddAll);
			this.pnlBotones.Controls.Add(this.cmdAdd);
			this.pnlBotones.Controls.Add(this.cmdCpPl);
			this.pnlBotones.Location = new System.Drawing.Point(358, 21);
			this.pnlBotones.Name = "pnlBotones";
			this.pnlBotones.Size = new System.Drawing.Size(117, 347);
			this.pnlBotones.TabIndex = 4;
			// 
			// cmdDelAll
			// 
			this.cmdDelAll.Enabled = false;
			this.cmdDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdDelAll.ForeColor = System.Drawing.Color.Black;
			this.cmdDelAll.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelAll.Image")));
			this.cmdDelAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdDelAll.Location = new System.Drawing.Point(5, 286);
			this.cmdDelAll.Name = "cmdDelAll";
			this.cmdDelAll.Size = new System.Drawing.Size(107, 55);
			this.cmdDelAll.TabIndex = 6;
			this.cmdDelAll.Text = "Quitar To&dos";
			this.cmdDelAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdDelAll.UseVisualStyleBackColor = true;
			this.cmdDelAll.Click += new System.EventHandler(this.cmdDelAll_Click);
			// 
			// cmdDel
			// 
			this.cmdDel.Enabled = false;
			this.cmdDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdDel.ForeColor = System.Drawing.Color.Black;
			this.cmdDel.Image = ((System.Drawing.Image)(resources.GetObject("cmdDel.Image")));
			this.cmdDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdDel.Location = new System.Drawing.Point(5, 229);
			this.cmdDel.Name = "cmdDel";
			this.cmdDel.Size = new System.Drawing.Size(107, 55);
			this.cmdDel.TabIndex = 5;
			this.cmdDel.Text = "&Quitar";
			this.cmdDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdDel.UseVisualStyleBackColor = true;
			this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
			// 
			// cmdAddAll
			// 
			this.cmdAddAll.Enabled = false;
			this.cmdAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAddAll.ForeColor = System.Drawing.Color.Black;
			this.cmdAddAll.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddAll.Image")));
			this.cmdAddAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdAddAll.Location = new System.Drawing.Point(5, 138);
			this.cmdAddAll.Name = "cmdAddAll";
			this.cmdAddAll.Size = new System.Drawing.Size(107, 55);
			this.cmdAddAll.TabIndex = 4;
			this.cmdAddAll.Text = "Agregar &Todos";
			this.cmdAddAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdAddAll.UseVisualStyleBackColor = true;
			this.cmdAddAll.Click += new System.EventHandler(this.cmdAddAll_Click);
			// 
			// cmdAdd
			// 
			this.cmdAdd.Enabled = false;
			this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAdd.ForeColor = System.Drawing.Color.Black;
			this.cmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.Image")));
			this.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdAdd.Location = new System.Drawing.Point(5, 81);
			this.cmdAdd.Name = "cmdAdd";
			this.cmdAdd.Size = new System.Drawing.Size(107, 55);
			this.cmdAdd.TabIndex = 3;
			this.cmdAdd.Text = "&Agregar";
			this.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdAdd.UseVisualStyleBackColor = true;
			this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
			// 
			// cmdCpPl
			// 
			this.cmdCpPl.Enabled = false;
			this.cmdCpPl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCpPl.ForeColor = System.Drawing.Color.Black;
			this.cmdCpPl.Image = ((System.Drawing.Image)(resources.GetObject("cmdCpPl.Image")));
			this.cmdCpPl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdCpPl.Location = new System.Drawing.Point(5, 5);
			this.cmdCpPl.Name = "cmdCpPl";
			this.cmdCpPl.Size = new System.Drawing.Size(107, 55);
			this.cmdCpPl.TabIndex = 2;
			this.cmdCpPl.Text = "&Copiar Plantilla";
			this.cmdCpPl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdCpPl.UseVisualStyleBackColor = true;
			this.cmdCpPl.Click += new System.EventHandler(this.cmdCpPl_Click);
			// 
			// cmbUsuario
			// 
			this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUsuario.FormattingEnabled = true;
			this.cmbUsuario.Location = new System.Drawing.Point(4, 20);
			this.cmbUsuario.Name = "cmbUsuario";
			this.cmbUsuario.Size = new System.Drawing.Size(350, 21);
			this.cmbUsuario.TabIndex = 0;
			this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
			// 
			// cmbPadMenu
			// 
			this.cmbPadMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPadMenu.FormattingEnabled = true;
			this.cmbPadMenu.Location = new System.Drawing.Point(480, 20);
			this.cmbPadMenu.Name = "cmbPadMenu";
			this.cmbPadMenu.Size = new System.Drawing.Size(350, 21);
			this.cmbPadMenu.TabIndex = 8;
			this.cmbPadMenu.SelectedIndexChanged += new System.EventHandler(this.cmbPadMenu_SelectedIndexChanged);
			// 
			// cmdClose
			// 
			this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdClose.ForeColor = System.Drawing.Color.Black;
			this.cmdClose.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.Image")));
			this.cmdClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdClose.Location = new System.Drawing.Point(363, 386);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(107, 55);
			this.cmdClose.TabIndex = 7;
			this.cmdClose.Text = "&Cerrar";
			this.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdClose.UseVisualStyleBackColor = true;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// TV1
			// 
			this.TV1.ImageIndex = 0;
			this.TV1.ImageList = this.imgList;
			this.TV1.Location = new System.Drawing.Point(3, 45);
			this.TV1.Name = "TV1";
			this.TV1.SelectedImageIndex = 0;
			this.TV1.Size = new System.Drawing.Size(350, 406);
			this.TV1.TabIndex = 10;
			this.TV1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV1_AfterSelect);
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "Principal");
			this.imgList.Images.SetKeyName(1, "Item");
			// 
			// TV2
			// 
			this.TV2.ImageIndex = 0;
			this.TV2.ImageList = this.imgList;
			this.TV2.Location = new System.Drawing.Point(480, 45);
			this.TV2.Name = "TV2";
			this.TV2.SelectedImageIndex = 0;
			this.TV2.Size = new System.Drawing.Size(350, 406);
			this.TV2.TabIndex = 11;
			this.TV2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV2_AfterSelect);
			// 
			// frmTvAccesos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 452);
			this.ControlBox = false;
			this.Controls.Add(this.TV2);
			this.Controls.Add(this.TV1);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.cmbPadMenu);
			this.Controls.Add(this.cmbUsuario);
			this.Controls.Add(this.pnlBotones);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTvAccesos";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mantenimiento de Accesos al Menú del Sistema";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.frmTvAccesos_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTvAccesos_KeyDown);
			this.pnlBotones.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbPadMenu;
        private System.Windows.Forms.Button cmdClose;
		private System.Windows.Forms.Button cmdDelAll;
		private System.Windows.Forms.Button cmdDel;
		private System.Windows.Forms.Button cmdAddAll;
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.Button cmdCpPl;
		private System.Windows.Forms.TreeView TV1;
		private System.Windows.Forms.TreeView TV2;
		private System.Windows.Forms.ImageList imgList;
	}
}