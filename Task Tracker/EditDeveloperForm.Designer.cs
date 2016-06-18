namespace Task_Tracker
{
    partial class EditDeveloperForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddEditLabel = new System.Windows.Forms.Label();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ActiveCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.FamilyNameTextBox = new System.Windows.Forms.TextBox();
            this.GivenNamesTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.taskTrackerDataSet = new Task_Tracker.TaskTrackerDataSet();
            this.developersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developersTableAdapter = new Task_Tracker.TaskTrackerDataSetTableAdapters.DevelopersTableAdapter();
            this.fKDeveloperIDDeveloperIterationTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerIterationTasksTableAdapter = new Task_Tracker.TaskTrackerDataSetTableAdapters.DeveloperIterationTasksTableAdapter();
            this.IterationsDataGridView = new System.Windows.Forms.DataGridView();
            this.ActionColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDeveloperIDDeveloperIterationTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IterationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(283, 278);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 32;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseMnemonic = false;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddEditLabel
            // 
            this.AddEditLabel.AutoSize = true;
            this.AddEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEditLabel.Location = new System.Drawing.Point(13, 29);
            this.AddEditLabel.Name = "AddEditLabel";
            this.AddEditLabel.Size = new System.Drawing.Size(51, 16);
            this.AddEditLabel.TabIndex = 31;
            this.AddEditLabel.Text = "label7";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(123, 196);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotesTextBox.Size = new System.Drawing.Size(235, 80);
            this.NotesTextBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Notes:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(200, 278);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 28;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Active Developer?:";
            // 
            // ActiveCheckbox
            // 
            this.ActiveCheckbox.AutoSize = true;
            this.ActiveCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActiveCheckbox.Checked = true;
            this.ActiveCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActiveCheckbox.Location = new System.Drawing.Point(123, 171);
            this.ActiveCheckbox.Name = "ActiveCheckbox";
            this.ActiveCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ActiveCheckbox.TabIndex = 26;
            this.ActiveCheckbox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ActiveCheckbox.UseMnemonic = false;
            this.ActiveCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Family Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Given Names:";
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.Location = new System.Drawing.Point(123, 146);
            this.ContactNumberTextBox.MaxLength = 50;
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.Size = new System.Drawing.Size(235, 20);
            this.ContactNumberTextBox.TabIndex = 21;
            this.ContactNumberTextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(123, 121);
            this.EmailTextBox.MaxLength = 255;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(235, 20);
            this.EmailTextBox.TabIndex = 20;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // FamilyNameTextBox
            // 
            this.FamilyNameTextBox.Location = new System.Drawing.Point(123, 96);
            this.FamilyNameTextBox.MaxLength = 255;
            this.FamilyNameTextBox.Name = "FamilyNameTextBox";
            this.FamilyNameTextBox.Size = new System.Drawing.Size(235, 20);
            this.FamilyNameTextBox.TabIndex = 19;
            this.FamilyNameTextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // GivenNamesTextBox
            // 
            this.GivenNamesTextBox.Location = new System.Drawing.Point(123, 71);
            this.GivenNamesTextBox.MaxLength = 255;
            this.GivenNamesTextBox.Name = "GivenNamesTextBox";
            this.GivenNamesTextBox.Size = new System.Drawing.Size(235, 20);
            this.GivenNamesTextBox.TabIndex = 18;
            this.GivenNamesTextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(13, 278);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 34;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // taskTrackerDataSet
            // 
            this.taskTrackerDataSet.DataSetName = "TaskTrackerDataSet";
            this.taskTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // developersBindingSource
            // 
            this.developersBindingSource.DataMember = "Developers";
            this.developersBindingSource.DataSource = this.taskTrackerDataSet;
            // 
            // developersTableAdapter
            // 
            this.developersTableAdapter.ClearBeforeFill = true;
            // 
            // fKDeveloperIDDeveloperIterationTasksBindingSource
            // 
            this.fKDeveloperIDDeveloperIterationTasksBindingSource.DataMember = "FK_DeveloperID_DeveloperIterationTasks";
            this.fKDeveloperIDDeveloperIterationTasksBindingSource.DataSource = this.developersBindingSource;
            // 
            // developerIterationTasksTableAdapter
            // 
            this.developerIterationTasksTableAdapter.ClearBeforeFill = true;
            // 
            // IterationsDataGridView
            // 
            this.IterationsDataGridView.AllowUserToAddRows = false;
            this.IterationsDataGridView.AllowUserToDeleteRows = false;
            this.IterationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IterationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActionColumn});
            this.IterationsDataGridView.Location = new System.Drawing.Point(408, 49);
            this.IterationsDataGridView.Name = "IterationsDataGridView";
            this.IterationsDataGridView.ReadOnly = true;
            this.IterationsDataGridView.Size = new System.Drawing.Size(527, 150);
            this.IterationsDataGridView.TabIndex = 35;
            this.IterationsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IterationsDataGridView_CellContentClick);
            // 
            // ActionColumn
            // 
            this.ActionColumn.FillWeight = 60F;
            this.ActionColumn.HeaderText = "Actions";
            this.ActionColumn.Name = "ActionColumn";
            this.ActionColumn.ReadOnly = true;
            this.ActionColumn.Text = "Report";
            this.ActionColumn.ToolTipText = "Print Report";
            this.ActionColumn.UseColumnTextForButtonValue = true;
            // 
            // EditDeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 519);
            this.Controls.Add(this.IterationsDataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddEditLabel);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ActiveCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContactNumberTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.FamilyNameTextBox);
            this.Controls.Add(this.GivenNamesTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditDeveloperForm";
            this.Text = "Add/Edit Developer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditDeveloperForm_FormClosing);
            this.Load += new System.EventHandler(this.EditDeveloperForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDeveloperIDDeveloperIterationTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IterationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label AddEditLabel;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ActiveCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox FamilyNameTextBox;
        private System.Windows.Forms.TextBox GivenNamesTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.Button DeleteButton;
        private TaskTrackerDataSet taskTrackerDataSet;
        private System.Windows.Forms.BindingSource developersBindingSource;
        private TaskTrackerDataSetTableAdapters.DevelopersTableAdapter developersTableAdapter;
        private System.Windows.Forms.BindingSource fKDeveloperIDDeveloperIterationTasksBindingSource;
        private TaskTrackerDataSetTableAdapters.DeveloperIterationTasksTableAdapter developerIterationTasksTableAdapter;
        private System.Windows.Forms.DataGridView IterationsDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn ActionColumn;

    }
}