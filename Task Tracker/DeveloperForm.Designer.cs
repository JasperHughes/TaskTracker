namespace Task_Tracker
{
    partial class DeveloperForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDeveloperButton = new System.Windows.Forms.Button();
            this.ActiveOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.DevelopersDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DevelopersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(641, 524);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 17;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseMnemonic = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDeveloperToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.fileToolStripMenuItem.Text = "Developers";
            // 
            // newDeveloperToolStripMenuItem
            // 
            this.newDeveloperToolStripMenuItem.Name = "newDeveloperToolStripMenuItem";
            this.newDeveloperToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newDeveloperToolStripMenuItem.Text = "New";
            this.newDeveloperToolStripMenuItem.Click += new System.EventHandler(this.NewDeveloperButton_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewDeveloperButton
            // 
            this.NewDeveloperButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewDeveloperButton.Location = new System.Drawing.Point(12, 524);
            this.NewDeveloperButton.Name = "NewDeveloperButton";
            this.NewDeveloperButton.Size = new System.Drawing.Size(112, 23);
            this.NewDeveloperButton.TabIndex = 19;
            this.NewDeveloperButton.Text = "New Developer";
            this.NewDeveloperButton.UseVisualStyleBackColor = true;
            this.NewDeveloperButton.Click += new System.EventHandler(this.NewDeveloperButton_Click);
            // 
            // ActiveOnlyCheckBox
            // 
            this.ActiveOnlyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveOnlyCheckBox.AutoSize = true;
            this.ActiveOnlyCheckBox.Location = new System.Drawing.Point(576, 28);
            this.ActiveOnlyCheckBox.Name = "ActiveOnlyCheckBox";
            this.ActiveOnlyCheckBox.Size = new System.Drawing.Size(137, 17);
            this.ActiveOnlyCheckBox.TabIndex = 20;
            this.ActiveOnlyCheckBox.Text = "Active Developers Only";
            this.ActiveOnlyCheckBox.UseVisualStyleBackColor = true;
            this.ActiveOnlyCheckBox.CheckedChanged += new System.EventHandler(this.ActiveOnlyCheckBox_CheckedChanged);
            // 
            // DevelopersDataGridView
            // 
            this.DevelopersDataGridView.AllowUserToAddRows = false;
            this.DevelopersDataGridView.AllowUserToDeleteRows = false;
            this.DevelopersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DevelopersDataGridView.Location = new System.Drawing.Point(12, 51);
            this.DevelopersDataGridView.Name = "DevelopersDataGridView";
            this.DevelopersDataGridView.ReadOnly = true;
            this.DevelopersDataGridView.Size = new System.Drawing.Size(704, 467);
            this.DevelopersDataGridView.TabIndex = 21;
            this.DevelopersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DevelopersDataGridView_CellClick);
            // 
            // DeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 559);
            this.Controls.Add(this.DevelopersDataGridView);
            this.Controls.Add(this.ActiveOnlyCheckBox);
            this.Controls.Add(this.NewDeveloperButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeveloperForm";
            this.Text = "Manage Developers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeveloperForm_FormClosing);
            this.Load += new System.EventHandler(this.DeveloperForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DevelopersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDeveloperToolStripMenuItem;
        private System.Windows.Forms.Button NewDeveloperButton;
        private System.Windows.Forms.CheckBox ActiveOnlyCheckBox;
        private System.Windows.Forms.DataGridView DevelopersDataGridView;
    }
}