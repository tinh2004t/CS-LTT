namespace prjWindowsForm
{
    partial class Main
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xửLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệToolStripMenuItem,
            this.xửLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệToolStripMenuItem
            // 
            this.hệToolStripMenuItem.Name = "hệToolStripMenuItem";
            this.hệToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệToolStripMenuItem.Text = "Hệ Thống";
            this.hệToolStripMenuItem.Click += new System.EventHandler(this.hệToolStripMenuItem_Click);
            // 
            // xửLýToolStripMenuItem
            // 
            this.xửLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1ToolStripMenuItem,
            this.bài2ToolStripMenuItem,
            this.bài3ToolStripMenuItem,
            this.bài4ToolStripMenuItem,
            this.bài5ToolStripMenuItem,
            this.bài6ToolStripMenuItem,
            this.bài7ToolStripMenuItem});
            this.xửLýToolStripMenuItem.Name = "xửLýToolStripMenuItem";
            this.xửLýToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.xửLýToolStripMenuItem.Text = "Xử lý";
            // 
            // bài1ToolStripMenuItem
            // 
            this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài1ToolStripMenuItem.Text = "Bài 1";
            this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài2ToolStripMenuItem.Text = "Bài 2";
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            // 
            // bài4ToolStripMenuItem
            // 
            this.bài4ToolStripMenuItem.Name = "bài4ToolStripMenuItem";
            this.bài4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài4ToolStripMenuItem.Text = "Bài 4";
            this.bài4ToolStripMenuItem.Click += new System.EventHandler(this.bài4ToolStripMenuItem_Click);
            // 
            // bài5ToolStripMenuItem
            // 
            this.bài5ToolStripMenuItem.Name = "bài5ToolStripMenuItem";
            this.bài5ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài5ToolStripMenuItem.Text = "Bài 5";
            this.bài5ToolStripMenuItem.Click += new System.EventHandler(this.bài5ToolStripMenuItem_Click);
            // 
            // bài6ToolStripMenuItem
            // 
            this.bài6ToolStripMenuItem.Name = "bài6ToolStripMenuItem";
            this.bài6ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài6ToolStripMenuItem.Text = "Bài 6";
            // 
            // bài7ToolStripMenuItem
            // 
            this.bài7ToolStripMenuItem.Name = "bài7ToolStripMenuItem";
            this.bài7ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài7ToolStripMenuItem.Text = "Bài 7";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xửLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài7ToolStripMenuItem;
    }
}