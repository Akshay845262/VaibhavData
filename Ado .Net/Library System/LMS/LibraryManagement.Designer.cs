namespace LMS
{
    partial class LibraryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryManagement));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memberManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberManagementToolStripMenuItem,
            this.bookManagementToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memberManagementToolStripMenuItem
            // 
            this.memberManagementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.memberManagementToolStripMenuItem.Name = "memberManagementToolStripMenuItem";
            this.memberManagementToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.memberManagementToolStripMenuItem.Text = "&Member Management";
            this.memberManagementToolStripMenuItem.Click += new System.EventHandler(this.memberManagementToolStripMenuItem_Click);
            // 
            // bookManagementToolStripMenuItem
            // 
            this.bookManagementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookManagementToolStripMenuItem.Name = "bookManagementToolStripMenuItem";
            this.bookManagementToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.bookManagementToolStripMenuItem.Text = "&Book Management";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem.Text = "&Transaction";
            // 
            // LibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 426);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LibraryManagement";
            this.Text = "Library Management System ";
            this.Load += new System.EventHandler(this.LibraryManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memberManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
    }
}