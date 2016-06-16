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
            this.graphtest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DevelopersButton
            // 
            this.DevelopersButton.Location = new System.Drawing.Point(13, 13);
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
            this.IterationsButton.Location = new System.Drawing.Point(13, 43);
            this.IterationsButton.Name = "IterationsButton";
            this.IterationsButton.Size = new System.Drawing.Size(171, 23);
            this.IterationsButton.TabIndex = 1;
            this.IterationsButton.Text = "Manage Iterations";
            this.IterationsButton.UseVisualStyleBackColor = true;
            // 
            // TasksButton
            // 
            this.TasksButton.Location = new System.Drawing.Point(13, 73);
            this.TasksButton.Name = "TasksButton";
            this.TasksButton.Size = new System.Drawing.Size(171, 23);
            this.TasksButton.TabIndex = 2;
            this.TasksButton.Text = "Manage Tasks";
            this.TasksButton.UseVisualStyleBackColor = true;
            this.TasksButton.Click += new System.EventHandler(this.TasksButton_Click);
            // 
            // graphtest
            // 
            this.graphtest.Location = new System.Drawing.Point(62, 166);
            this.graphtest.Name = "graphtest";
            this.graphtest.Size = new System.Drawing.Size(75, 23);
            this.graphtest.TabIndex = 3;
            this.graphtest.Text = "Test Graph";
            this.graphtest.UseVisualStyleBackColor = true;
            this.graphtest.Click += new System.EventHandler(this.graphtest_Click);
            // 
            // MainMenu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.graphtest);
            this.Controls.Add(this.TasksButton);
            this.Controls.Add(this.IterationsButton);
            this.Controls.Add(this.DevelopersButton);
            this.Name = "MainMenu";
            this.Text = "Task Tracker - Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DevelopersButton;
        private System.Windows.Forms.Button IterationsButton;
        private System.Windows.Forms.Button TasksButton;
        private System.Windows.Forms.Button graphtest;
    }
}

