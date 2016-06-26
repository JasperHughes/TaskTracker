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
            this.DevelopersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CloseButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDeveloperButton = new System.Windows.Forms.Button();
            this.ActiveOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DevelopersListView
            // 
            this.DevelopersListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.DevelopersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevelopersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.DevelopersListView.Location = new System.Drawing.Point(12, 51);
            this.DevelopersListView.Name = "DevelopersListView";
            this.DevelopersListView.Size = new System.Drawing.Size(614, 306);
            this.DevelopersListView.TabIndex = 12;
            this.DevelopersListView.UseCompatibleStateImageBehavior = false;
            this.DevelopersListView.View = System.Windows.Forms.View.Details;
            this.DevelopersListView.ItemActivate += new System.EventHandler(this.DevelopersListView_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Given Names";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Family Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Contact Number";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Active";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Notes";
            this.columnHeader7.Width = 130;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(554, 361);
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
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDeveloperToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDeveloperToolStripMenuItem
            // 
            this.newDeveloperToolStripMenuItem.Name = "newDeveloperToolStripMenuItem";
            this.newDeveloperToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newDeveloperToolStripMenuItem.Text = "New Developer";
            this.newDeveloperToolStripMenuItem.Click += new System.EventHandler(this.NewDeveloperButton_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewDeveloperButton
            // 
            this.NewDeveloperButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewDeveloperButton.Location = new System.Drawing.Point(12, 361);
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
            this.ActiveOnlyCheckBox.Location = new System.Drawing.Point(489, 28);
            this.ActiveOnlyCheckBox.Name = "ActiveOnlyCheckBox";
            this.ActiveOnlyCheckBox.Size = new System.Drawing.Size(137, 17);
            this.ActiveOnlyCheckBox.TabIndex = 20;
            this.ActiveOnlyCheckBox.Text = "Active Developers Only";
            this.ActiveOnlyCheckBox.UseVisualStyleBackColor = true;
            this.ActiveOnlyCheckBox.CheckedChanged += new System.EventHandler(this.ActiveOnlyCheckBox_CheckedChanged);
            // 
            // DeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 396);
            this.Controls.Add(this.ActiveOnlyCheckBox);
            this.Controls.Add(this.NewDeveloperButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DevelopersListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeveloperForm";
            this.Text = "Manage Developers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeveloperForm_FormClosing);
            this.Load += new System.EventHandler(this.DeveloperForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDeveloperToolStripMenuItem;
        private System.Windows.Forms.Button NewDeveloperButton;
        public System.Windows.Forms.ListView DevelopersListView;
        private System.Windows.Forms.CheckBox ActiveOnlyCheckBox;
    }
}