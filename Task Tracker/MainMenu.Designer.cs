namespace Task_Tracker
{
    partial class MainMenu
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
            this.DevelopersButton = new System.Windows.Forms.Button();
            this.IterationsButton = new System.Windows.Forms.Button();
            this.TasksButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDevelopersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageIterationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DevelopersButton
            // 
            this.DevelopersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevelopersButton.Location = new System.Drawing.Point(13, 51);
            this.DevelopersButton.Name = "DevelopersButton";
            this.DevelopersButton.Size = new System.Drawing.Size(171, 23);
            this.DevelopersButton.TabIndex = 0;
            this.DevelopersButton.Text = "Manage Developers";
            this.DevelopersButton.UseMnemonic = false;
            this.DevelopersButton.UseVisualStyleBackColor = true;
            this.DevelopersButton.Click += new System.EventHandler(this.DevelopersButton_Click);
            // 
            // IterationsButton
            // 
            this.IterationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IterationsButton.Location = new System.Drawing.Point(13, 81);
            this.IterationsButton.Name = "IterationsButton";
            this.IterationsButton.Size = new System.Drawing.Size(171, 23);
            this.IterationsButton.TabIndex = 1;
            this.IterationsButton.Text = "Manage Iterations";
            this.IterationsButton.UseVisualStyleBackColor = true;
            this.IterationsButton.Click += new System.EventHandler(this.IterationsButton_Click);
            // 
            // TasksButton
            // 
            this.TasksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TasksButton.Location = new System.Drawing.Point(13, 111);
            this.TasksButton.Name = "TasksButton";
            this.TasksButton.Size = new System.Drawing.Size(171, 23);
            this.TasksButton.TabIndex = 2;
            this.TasksButton.Text = "Manage Tasks";
            this.TasksButton.UseVisualStyleBackColor = true;
            this.TasksButton.Click += new System.EventHandler(this.TasksButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(13, 140);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(171, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(194, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDevelopersToolStripMenuItem,
            this.manageIterationsToolStripMenuItem,
            this.manageTasksToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // manageDevelopersToolStripMenuItem
            // 
            this.manageDevelopersToolStripMenuItem.Name = "manageDevelopersToolStripMenuItem";
            this.manageDevelopersToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.manageDevelopersToolStripMenuItem.Text = "Manage Developers";
            this.manageDevelopersToolStripMenuItem.Click += new System.EventHandler(this.DevelopersButton_Click);
            // 
            // manageIterationsToolStripMenuItem
            // 
            this.manageIterationsToolStripMenuItem.Name = "manageIterationsToolStripMenuItem";
            this.manageIterationsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.manageIterationsToolStripMenuItem.Text = "Manage Iterations";
            this.manageIterationsToolStripMenuItem.Click += new System.EventHandler(this.IterationsButton_Click);
            // 
            // manageTasksToolStripMenuItem
            // 
            this.manageTasksToolStripMenuItem.Name = "manageTasksToolStripMenuItem";
            this.manageTasksToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.manageTasksToolStripMenuItem.Text = "Manage Tasks";
            this.manageTasksToolStripMenuItem.Click += new System.EventHandler(this.TasksButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 179);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TasksButton);
            this.Controls.Add(this.IterationsButton);
            this.Controls.Add(this.DevelopersButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(210, 218);
            this.MinimumSize = new System.Drawing.Size(210, 218);
            this.Name = "MainMenu";
            this.Text = "Task Tracker - Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DevelopersButton;
        private System.Windows.Forms.Button IterationsButton;
        private System.Windows.Forms.Button TasksButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDevelopersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageIterationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

