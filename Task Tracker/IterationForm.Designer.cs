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
            this.iterationTasksTextBox = new System.Windows.Forms.TextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iterationListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaveButton = new System.Windows.Forms.Button();
            this.IterationTasksList = new System.Windows.Forms.ListBox();
            this.AddIterationTask = new System.Windows.Forms.Button();
            this.RemoveIterationTask = new System.Windows.Forms.Button();
            this.IterationIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projectIDTextBox
            // 
            this.projectIDTextBox.Location = new System.Drawing.Point(142, 81);
            this.projectIDTextBox.Name = "projectIDTextBox";
            this.projectIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.projectIDTextBox.TabIndex = 1;
            this.projectIDTextBox.TextChanged += new System.EventHandler(this.projectIDTextBox_TextChanged);
            // 
            // projectTextBox
            // 
            this.projectTextBox.Enabled = false;
            this.projectTextBox.Location = new System.Drawing.Point(142, 107);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(100, 20);
            this.projectTextBox.TabIndex = 2;
            // 
            // iterationTasksTextBox
            // 
            this.iterationTasksTextBox.Location = new System.Drawing.Point(142, 133);
            this.iterationTasksTextBox.Name = "iterationTasksTextBox";
            this.iterationTasksTextBox.Size = new System.Drawing.Size(100, 20);
            this.iterationTasksTextBox.TabIndex = 3;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(142, 209);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(99, 20);
            this.startDatePicker.TabIndex = 5;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(142, 235);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(99, 20);
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
            this.label4.Location = new System.Drawing.Point(7, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Iteration Tasks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "End Date";
            // 
            // iterationListView
            // 
            this.iterationListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.iterationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 23;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Project ID";
            this.columnHeader2.Width = 59;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Project";
            this.columnHeader3.Width = 45;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Iteration Tasks";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Developer Iteration Tasks";
            this.columnHeader5.Width = 134;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Start Date";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "End Date";
            this.columnHeader7.Width = 57;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(142, 266);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // IterationTasksList
            // 
            this.IterationTasksList.FormattingEnabled = true;
            this.IterationTasksList.Location = new System.Drawing.Point(142, 160);
            this.IterationTasksList.Name = "IterationTasksList";
            this.IterationTasksList.Size = new System.Drawing.Size(99, 43);
            this.IterationTasksList.TabIndex = 16;
            // 
            // AddIterationTask
            // 
            this.AddIterationTask.Location = new System.Drawing.Point(249, 133);
            this.AddIterationTask.Name = "AddIterationTask";
            this.AddIterationTask.Size = new System.Drawing.Size(26, 19);
            this.AddIterationTask.TabIndex = 17;
            this.AddIterationTask.Text = "+";
            this.AddIterationTask.UseVisualStyleBackColor = true;
            this.AddIterationTask.Click += new System.EventHandler(this.AddIterationTask_Click);
            // 
            // RemoveIterationTask
            // 
            this.RemoveIterationTask.Location = new System.Drawing.Point(249, 160);
            this.RemoveIterationTask.Name = "RemoveIterationTask";
            this.RemoveIterationTask.Size = new System.Drawing.Size(26, 19);
            this.RemoveIterationTask.TabIndex = 18;
            this.RemoveIterationTask.Text = "-";
            this.RemoveIterationTask.UseVisualStyleBackColor = true;
            this.RemoveIterationTask.Click += new System.EventHandler(this.RemoveIterationTask_Click);
            // 
            // IterationIDLabel
            // 
            this.IterationIDLabel.AutoSize = true;
            this.IterationIDLabel.Location = new System.Drawing.Point(139, 58);
            this.IterationIDLabel.Name = "IterationIDLabel";
            this.IterationIDLabel.Size = new System.Drawing.Size(0, 13);
            this.IterationIDLabel.TabIndex = 0;
            // 
            // IterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 399);
            this.Controls.Add(this.IterationIDLabel);
            this.Controls.Add(this.RemoveIterationTask);
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
            this.Controls.Add(this.iterationTasksTextBox);
            this.Controls.Add(this.projectTextBox);
            this.Controls.Add(this.projectIDTextBox);
            this.Name = "IterationForm";
            this.Text = "IterationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox projectIDTextBox;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.TextBox iterationTasksTextBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView iterationListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListBox IterationTasksList;
        private System.Windows.Forms.Button AddIterationTask;
        private System.Windows.Forms.Button RemoveIterationTask;
        private System.Windows.Forms.Label IterationIDLabel;
    }
}