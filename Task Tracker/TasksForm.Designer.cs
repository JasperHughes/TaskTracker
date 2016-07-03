namespace Task_Tracker
{
    partial class TasksForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TaskFormSaveButton = new System.Windows.Forms.Button();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CompletetionDateTextBox = new System.Windows.Forms.DateTimePicker();
            this.ProjectIDTextBox = new System.Windows.Forms.ComboBox();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTrackerDataSet = new Task_Tracker.TaskTrackerDataSet();
            this.PriorityTextBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new Task_Tracker.TaskTrackerDataSetTableAdapters.TasksTableAdapter();
            this.projectsTableAdapter = new Task_Tracker.TaskTrackerDataSetTableAdapters.ProjectsTableAdapter();
            this.TaskCloseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskNameTextBox.Location = new System.Drawing.Point(115, 11);
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.TaskNameTextBox.TabIndex = 5;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionTextBox.Location = new System.Drawing.Point(115, 53);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // TaskFormSaveButton
            // 
            this.TaskFormSaveButton.Location = new System.Drawing.Point(757, 229);
            this.TaskFormSaveButton.Name = "TaskFormSaveButton";
            this.TaskFormSaveButton.Size = new System.Drawing.Size(75, 38);
            this.TaskFormSaveButton.TabIndex = 11;
            this.TaskFormSaveButton.Text = "Save";
            this.TaskFormSaveButton.UseVisualStyleBackColor = true;
            this.TaskFormSaveButton.Click += new System.EventHandler(this.TaskFormSaveButton_Click);
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskNameLabel.Location = new System.Drawing.Point(3, 0);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(104, 42);
            this.TaskNameLabel.TabIndex = 12;
            this.TaskNameLabel.Text = "Task Name";
            this.TaskNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pirority";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "Completed Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 43);
            this.label4.TabIndex = 15;
            this.label4.Text = "Project";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CompletetionDateTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TaskNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TaskNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProjectIDTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PriorityTextBox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 211);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // CompletetionDateTextBox
            // 
            this.CompletetionDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CompletetionDateTextBox.Location = new System.Drawing.Point(113, 137);
            this.CompletetionDateTextBox.Name = "CompletetionDateTextBox";
            this.CompletetionDateTextBox.ShowCheckBox = true;
            this.CompletetionDateTextBox.Size = new System.Drawing.Size(104, 20);
            this.CompletetionDateTextBox.TabIndex = 18;
            // 
            // ProjectIDTextBox
            // 
            this.ProjectIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProjectIDTextBox.DataSource = this.projectsBindingSource;
            this.ProjectIDTextBox.DisplayMember = "ProjectName";
            this.ProjectIDTextBox.DropDownWidth = 250;
            this.ProjectIDTextBox.FormattingEnabled = true;
            this.ProjectIDTextBox.Location = new System.Drawing.Point(113, 179);
            this.ProjectIDTextBox.Name = "ProjectIDTextBox";
            this.ProjectIDTextBox.Size = new System.Drawing.Size(104, 21);
            this.ProjectIDTextBox.TabIndex = 19;
            this.ProjectIDTextBox.ValueMember = "ID";
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.taskTrackerDataSet;
            // 
            // taskTrackerDataSet
            // 
            this.taskTrackerDataSet.DataSetName = "TaskTrackerDataSet";
            this.taskTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PriorityTextBox
            // 
            this.PriorityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriorityTextBox.FormattingEnabled = true;
            this.PriorityTextBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.PriorityTextBox.Location = new System.Drawing.Point(113, 94);
            this.PriorityTextBox.Name = "PriorityTextBox";
            this.PriorityTextBox.Size = new System.Drawing.Size(104, 21);
            this.PriorityTextBox.TabIndex = 20;
            this.PriorityTextBox.Text = "Select a Priority";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.taskNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.completionDateDataGridViewTextBoxColumn,
            this.projectIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tasksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(238, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 211);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "TaskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "TaskName";
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            // 
            // completionDateDataGridViewTextBoxColumn
            // 
            this.completionDateDataGridViewTextBoxColumn.DataPropertyName = "CompletionDate";
            this.completionDateDataGridViewTextBoxColumn.HeaderText = "CompletionDate";
            this.completionDateDataGridViewTextBoxColumn.Name = "completionDateDataGridViewTextBoxColumn";
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.taskTrackerDataSet;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // TaskCloseButton
            // 
            this.TaskCloseButton.Location = new System.Drawing.Point(30, 237);
            this.TaskCloseButton.Name = "TaskCloseButton";
            this.TaskCloseButton.Size = new System.Drawing.Size(89, 30);
            this.TaskCloseButton.TabIndex = 18;
            this.TaskCloseButton.Text = "Close";
            this.TaskCloseButton.UseVisualStyleBackColor = true;
            this.TaskCloseButton.Click += new System.EventHandler(this.TaskCloseButton_Click);
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 277);
            this.Controls.Add(this.TaskCloseButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TaskFormSaveButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TasksForm";
            this.Text = "Manage Tasks";
            this.Load += new System.EventHandler(this.TaksForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button TaskFormSaveButton;
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker CompletetionDateTextBox;
        private System.Windows.Forms.ComboBox ProjectIDTextBox;
        private System.Windows.Forms.ComboBox PriorityTextBox;
        private TaskTrackerDataSet taskTrackerDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private TaskTrackerDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private TaskTrackerDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button TaskCloseButton;
    }
}