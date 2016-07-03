namespace Task_Tracker
{
    partial class IterationForm
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
            this.projectIDTextBox = new System.Windows.Forms.TextBox();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iterationListView = new System.Windows.Forms.ListView();
            this.iterationID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaveButton = new System.Windows.Forms.Button();
            this.IterationTasksList = new System.Windows.Forms.ListBox();
            this.AddIterationTask = new System.Windows.Forms.Button();
            this.IterationIDLabel = new System.Windows.Forms.Label();
            this.ITEditButton = new System.Windows.Forms.Button();
            this.NewIterationButton = new System.Windows.Forms.Button();
            this.projectDropdown = new System.Windows.Forms.ComboBox();
            this.graphBtn = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectIDTextBox
            // 
            this.projectIDTextBox.Enabled = false;
            this.projectIDTextBox.Location = new System.Drawing.Point(105, 81);
            this.projectIDTextBox.Name = "projectIDTextBox";
            this.projectIDTextBox.Size = new System.Drawing.Size(55, 20);
            this.projectIDTextBox.TabIndex = 1;
            this.projectIDTextBox.TextChanged += new System.EventHandler(this.projectIDTextBox_TextChanged);
            // 
            // projectTextBox
            // 
            this.projectTextBox.Enabled = false;
            this.projectTextBox.Location = new System.Drawing.Point(105, 107);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(136, 20);
            this.projectTextBox.TabIndex = 2;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(105, 133);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(136, 20);
            this.startDatePicker.TabIndex = 5;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(105, 159);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(136, 20);
            this.endDatePicker.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iteration ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Project ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Iteration Tasks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "End Date";
            // 
            // iterationListView
            // 
            this.iterationListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.iterationListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iterationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.iterationID,
            this.projectID,
            this.startDate,
            this.endDate});
            this.iterationListView.FullRowSelect = true;
            this.iterationListView.HideSelection = false;
            this.iterationListView.Location = new System.Drawing.Point(373, 55);
            this.iterationListView.MultiSelect = false;
            this.iterationListView.Name = "iterationListView";
            this.iterationListView.Size = new System.Drawing.Size(470, 275);
            this.iterationListView.TabIndex = 14;
            this.iterationListView.UseCompatibleStateImageBehavior = false;
            this.iterationListView.View = System.Windows.Forms.View.Details;
            this.iterationListView.SelectedIndexChanged += new System.EventHandler(this.iterationListView_SelectedIndexChanged_1);
            // 
            // iterationID
            // 
            this.iterationID.Text = "ID";
            this.iterationID.Width = 23;
            // 
            // projectID
            // 
            this.projectID.Text = "Project ID";
            this.projectID.Width = 59;
            // 
            // startDate
            // 
            this.startDate.Text = "Start Date";
            this.startDate.Width = 172;
            // 
            // endDate
            // 
            this.endDate.Text = "End Date";
            this.endDate.Width = 200;
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(142, 292);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // IterationTasksList
            // 
            this.IterationTasksList.FormattingEnabled = true;
            this.IterationTasksList.Location = new System.Drawing.Point(105, 185);
            this.IterationTasksList.Name = "IterationTasksList";
            this.IterationTasksList.Size = new System.Drawing.Size(136, 95);
            this.IterationTasksList.TabIndex = 16;
            this.IterationTasksList.SelectedIndexChanged += new System.EventHandler(this.IterationTasksList_SelectedIndexChanged);
            // 
            // AddIterationTask
            // 
            this.AddIterationTask.Enabled = false;
            this.AddIterationTask.Location = new System.Drawing.Point(247, 185);
            this.AddIterationTask.Name = "AddIterationTask";
            this.AddIterationTask.Size = new System.Drawing.Size(84, 21);
            this.AddIterationTask.TabIndex = 17;
            this.AddIterationTask.Text = "Add/Remove";
            this.AddIterationTask.UseVisualStyleBackColor = true;
            this.AddIterationTask.Click += new System.EventHandler(this.AddIterationTask_Click);
            // 
            // IterationIDLabel
            // 
            this.IterationIDLabel.AutoSize = true;
            this.IterationIDLabel.Location = new System.Drawing.Point(109, 58);
            this.IterationIDLabel.Name = "IterationIDLabel";
            this.IterationIDLabel.Size = new System.Drawing.Size(0, 13);
            this.IterationIDLabel.TabIndex = 0;
            this.IterationIDLabel.TextChanged += new System.EventHandler(this.IterationIDLabel_TextChanged);
            // 
            // ITEditButton
            // 
            this.ITEditButton.Enabled = false;
            this.ITEditButton.Location = new System.Drawing.Point(247, 212);
            this.ITEditButton.Name = "ITEditButton";
            this.ITEditButton.Size = new System.Drawing.Size(84, 21);
            this.ITEditButton.TabIndex = 18;
            this.ITEditButton.Text = "Edit Task";
            this.ITEditButton.UseVisualStyleBackColor = true;
            this.ITEditButton.Click += new System.EventHandler(this.ITEditButton_Click);
            // 
            // NewIterationButton
            // 
            this.NewIterationButton.Location = new System.Drawing.Point(10, 292);
            this.NewIterationButton.Name = "NewIterationButton";
            this.NewIterationButton.Size = new System.Drawing.Size(99, 23);
            this.NewIterationButton.TabIndex = 19;
            this.NewIterationButton.Text = "New";
            this.NewIterationButton.UseVisualStyleBackColor = true;
            this.NewIterationButton.Click += new System.EventHandler(this.NewIterationButton_Click);
            // 
            // projectDropdown
            // 
            this.projectDropdown.BackColor = System.Drawing.Color.White;
            this.projectDropdown.FormattingEnabled = true;
            this.projectDropdown.Location = new System.Drawing.Point(105, 106);
            this.projectDropdown.Name = "projectDropdown";
            this.projectDropdown.Size = new System.Drawing.Size(226, 21);
            this.projectDropdown.TabIndex = 20;
            this.projectDropdown.Visible = false;
            this.projectDropdown.SelectedIndexChanged += new System.EventHandler(this.projectDropdown_SelectedIndexChanged);
            // 
            // graphBtn
            // 
            this.graphBtn.Location = new System.Drawing.Point(10, 321);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(99, 23);
            this.graphBtn.TabIndex = 21;
            this.graphBtn.Text = "View Progress";
            this.graphBtn.UseVisualStyleBackColor = true;
            this.graphBtn.Visible = false;
            this.graphBtn.Click += new System.EventHandler(this.graphBtn_Click);
            // 
            // reportButton
            // 
            this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reportButton.Enabled = false;
            this.reportButton.Location = new System.Drawing.Point(744, 336);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(99, 23);
            this.reportButton.TabIndex = 22;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(639, 336);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 23);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // IterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 399);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.graphBtn);
            this.Controls.Add(this.projectDropdown);
            this.Controls.Add(this.NewIterationButton);
            this.Controls.Add(this.ITEditButton);
            this.Controls.Add(this.IterationIDLabel);
            this.Controls.Add(this.AddIterationTask);
            this.Controls.Add(this.IterationTasksList);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.iterationListView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.projectTextBox);
            this.Controls.Add(this.projectIDTextBox);
            this.MinimumSize = new System.Drawing.Size(487, 393);
            this.Name = "IterationForm";
            this.Text = "Manage Iterations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IterationForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox projectIDTextBox;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView iterationListView;
        private System.Windows.Forms.ColumnHeader iterationID;
        private System.Windows.Forms.ColumnHeader projectID;
        private System.Windows.Forms.ColumnHeader startDate;
        private System.Windows.Forms.ColumnHeader endDate;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListBox IterationTasksList;
        private System.Windows.Forms.Button AddIterationTask;
        private System.Windows.Forms.Label IterationIDLabel;
        private System.Windows.Forms.Button ITEditButton;
        private System.Windows.Forms.Button NewIterationButton;
        private System.Windows.Forms.ComboBox projectDropdown;
        private System.Windows.Forms.Button graphBtn;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button deleteButton;
    }
}