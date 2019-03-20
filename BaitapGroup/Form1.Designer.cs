namespace BaitapGroup
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyen1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.role2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.role3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.role3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.role4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.userToolStripMenuItem,
            this.quyen1ToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // quyen1ToolStripMenuItem
            // 
            this.quyen1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quyeToolStripMenuItem,
            this.role2ToolStripMenuItem,
            this.role3ToolStripMenuItem,
            this.role3ToolStripMenuItem1,
            this.role4ToolStripMenuItem});
            this.quyen1ToolStripMenuItem.Name = "quyen1ToolStripMenuItem";
            this.quyen1ToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quyen1ToolStripMenuItem.Text = "Role";
            // 
            // quyeToolStripMenuItem
            // 
            this.quyeToolStripMenuItem.Name = "quyeToolStripMenuItem";
            this.quyeToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.quyeToolStripMenuItem.Text = "Role 1";
            this.quyeToolStripMenuItem.Click += new System.EventHandler(this.quyeToolStripMenuItem_Click);
            // 
            // role2ToolStripMenuItem
            // 
            this.role2ToolStripMenuItem.Name = "role2ToolStripMenuItem";
            this.role2ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.role2ToolStripMenuItem.Text = "Role 2";
            this.role2ToolStripMenuItem.Click += new System.EventHandler(this.role2ToolStripMenuItem_Click);
            // 
            // role3ToolStripMenuItem
            // 
            this.role3ToolStripMenuItem.Name = "role3ToolStripMenuItem";
            this.role3ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.role3ToolStripMenuItem.Text = "Role 3";
            this.role3ToolStripMenuItem.Click += new System.EventHandler(this.role3ToolStripMenuItem_Click);
            // 
            // role3ToolStripMenuItem1
            // 
            this.role3ToolStripMenuItem1.Name = "role3ToolStripMenuItem1";
            this.role3ToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.role3ToolStripMenuItem1.Text = "Role 4";
            this.role3ToolStripMenuItem1.Click += new System.EventHandler(this.role3ToolStripMenuItem1_Click);
            // 
            // role4ToolStripMenuItem
            // 
            this.role4ToolStripMenuItem.Name = "role4ToolStripMenuItem";
            this.role4ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.role4ToolStripMenuItem.Text = "Role 5";
            this.role4ToolStripMenuItem.Click += new System.EventHandler(this.role4ToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(0, 27);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(800, 328);
            this.pnMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quyen1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem role2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem role3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem role3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem role4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.Panel pnMain;
    }
}

