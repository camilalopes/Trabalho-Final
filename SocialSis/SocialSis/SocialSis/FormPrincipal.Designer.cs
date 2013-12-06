namespace GUI
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pRODUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtSairSistema = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtSairSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem});
            resources.ApplyResources(this.clienteToolStripMenuItem, "clienteToolStripMenuItem");
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            resources.ApplyResources(this.visualizarToolStripMenuItem, "visualizarToolStripMenuItem");
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.pRODUTOToolStripMenuItem,
            this.cOMPRAToolStripMenuItem});
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // pRODUTOToolStripMenuItem
            // 
            this.pRODUTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem1});
            resources.ApplyResources(this.pRODUTOToolStripMenuItem, "pRODUTOToolStripMenuItem");
            this.pRODUTOToolStripMenuItem.Name = "pRODUTOToolStripMenuItem";
            // 
            // visualizarToolStripMenuItem1
            // 
            this.visualizarToolStripMenuItem1.Name = "visualizarToolStripMenuItem1";
            resources.ApplyResources(this.visualizarToolStripMenuItem1, "visualizarToolStripMenuItem1");
            this.visualizarToolStripMenuItem1.Click += new System.EventHandler(this.visualizarToolStripMenuItem1_Click);
            // 
            // cOMPRAToolStripMenuItem
            // 
            this.cOMPRAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem2});
            resources.ApplyResources(this.cOMPRAToolStripMenuItem, "cOMPRAToolStripMenuItem");
            this.cOMPRAToolStripMenuItem.Name = "cOMPRAToolStripMenuItem";
            // 
            // visualizarToolStripMenuItem2
            // 
            this.visualizarToolStripMenuItem2.Name = "visualizarToolStripMenuItem2";
            resources.ApplyResources(this.visualizarToolStripMenuItem2, "visualizarToolStripMenuItem2");
            this.visualizarToolStripMenuItem2.Click += new System.EventHandler(this.visualizarToolStripMenuItem2_Click);
            // 
            // BtSairSistema
            // 
            this.BtSairSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtSairSistema, "BtSairSistema");
            this.BtSairSistema.Name = "BtSairSistema";
            this.BtSairSistema.TabStop = false;
            this.BtSairSistema.Click += new System.EventHandler(this.BtSairSistema_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.BtSairSistema);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtSairSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cOMPRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem2;
        private System.Windows.Forms.PictureBox BtSairSistema;
        private System.Windows.Forms.Label label1;
    }
}