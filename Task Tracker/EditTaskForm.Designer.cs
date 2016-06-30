namespace Task_Tracker
{
    partial class EditTaskForm
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
            this.addToTaskBtn = new System.Windows.Forms.Button();
            this.removeFromTaskBtn = new System.Windows.Forms.Button();
            this.unassignedToIterationLB = new System.Windows.Forms.ListBox();
            this.assignedToIterationLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriorityTextBox = new System.Windows.Forms.ComboBox();
            this.CompletetionDateTextBox = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProjectIDTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveTaskBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToTaskBtn
            // 
            this.addToTaskBtn.Enabled = false;
            this.addToTaskBtn.Location = new System.Drawing.Point(291, 301);
            this.addToTaskBtn.Name = "addToTaskBtn";
            this.addToTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.addToTaskBtn.TabIndex = 2;
            this.addToTaskBtn.Text = "--->";
            this.addToTaskBtn.UseVisualStyleBackColor = true;
            this.addToTaskBtn.Click += new System.EventHandler(this.addToTaskBtn_Click);
            // 
            // removeFromTaskBtn
            // 
            this.removeFromTaskBtn.Enabled = false;
            this.removeFromTaskBtn.Location = new System.Drawing.Point(291, 330);
            this.removeFromTaskBtn.Name = "removeFromTaskBtn";
            this.removeFromTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.removeFromTaskBtn.TabIndex = 3;
            this.removeFromTaskBtn.Text = "<---";
            this.removeFromTaskBtn.UseVisualStyleBackColor = true;
            this.removeFromTaskBtn.Click += new System.EventHandler(this.removeFromTaskBtn_Click);
            // 
            // unassignedToIterationLB
            // 
            this.unassignedToIterationLB.FormattingEnabled = true;
            this.unassignedToIterationLB.Location = new System.Drawing.Point(12, 259);
            this.unassignedToIterationLB.Name = "unassignedToIterationLB";
            this.unassignedToIterationLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.unassignedToIterationLB.Size = new System.Drawing.Size(239, 134);
            this.unassignedToIterationLB.TabIndex = 4;
            this.unassignedToIterationLB.SelectedIndexChanged += new System.EventHandler(this.unassignedToIterationLB_SelectedIndexChanged);
            // 
            // assignedToIterationLB
            // 
            this.assignedToIterationLB.FormattingEnabled = true;
            this.assignedToIterationLB.Location = new System.Drawing.Point(405, 259);
            this.assignedToIterationLB.Name = "assignedToIterationLB";
            this.assignedToIterationLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.assignedToIterationLB.Size = new System.Drawing.Size(239, 134);
            this.assignedToIterationLB.TabIndex = 5;
            this.assignedToIterationLB.SelectedIndexChanged += new System.EventHandler(this.assignedToIterationLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available Developers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 239);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected Developers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.TaskNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TaskNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PriorityTextBox, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.CompletetionDateTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProjectIDTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 80);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskNameLabel.Location = new System.Drawing.Point(3, 0);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(62, 40);
            this.TaskNameLabel.TabIndex = 12;
            this.TaskNameLabel.Text = "Task Name";
            this.TaskNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskNameTextBox.Location = new System.Drawing.Point(71, 10);
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.TaskNameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "Project";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriorityTextBox
            // 
            this.PriorityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityTextBox.FormattingEnabled = true;
            this.PriorityTextBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.PriorityTextBox.Location = new System.Drawing.Point(490, 9);
            this.PriorityTextBox.Name = "PriorityTextBox";
            this.PriorityTextBox.Size = new System.Drawing.Size(139, 21);
            this.PriorityTextBox.TabIndex = 20;
            this.PriorityTextBox.Text = "Select a Priority";
            // 
            // CompletetionDateTextBox
            // 
            this.CompletetionDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CompletetionDateTextBox.Location = new System.Drawing.Point(303, 10);
            this.CompletetionDateTextBox.Name = "CompletetionDateTextBox";
            this.CompletetionDateTextBox.ShowCheckBox = true;
            this.CompletetionDateTextBox.Size = new System.Drawing.Size(137, 20);
            this.CompletetionDateTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(214, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 40);
            this.label3.TabIndex = 21;
            this.label3.Text = "Completed Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(446, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 40);
            this.label4.TabIndex = 22;
            this.label4.Text = "Priority";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProjectIDTextBox
            // 
            this.ProjectIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectIDTextBox.Location = new System.Drawing.Point(71, 50);
            this.ProjectIDTextBox.Name = "ProjectIDTextBox";
            this.ProjectIDTextBox.ReadOnly = true;
            this.ProjectIDTextBox.Size = new System.Drawing.Size(137, 20);
            this.ProjectIDTextBox.TabIndex = 23;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 130);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(632, 69);
            this.DescriptionTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Description";
            // 
            // saveTaskBtn
            // 
            this.saveTaskBtn.Location = new System.Drawing.Point(540, 205);
            this.saveTaskBtn.Name = "saveTaskBtn";
            this.saveTaskBtn.Size = new System.Drawing.Size(104, 23);
            this.saveTaskBtn.TabIndex = 20;
            this.saveTaskBtn.Text = "Save Changes";
            this.saveTaskBtn.UseVisualStyleBackColor = true;
            this.saveTaskBtn.Click += new System.EventHandler(this.saveTaskBtn_Click);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 405);
            this.Controls.Add(this.saveTaskBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignedToIterationLB);
            this.Controls.Add(this.unassignedToIterationLB);
            this.Controls.Add(this.removeFromTaskBtn);
            this.Controls.Add(this.addToTaskBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(673, 443);
            this.MinimumSize = new System.Drawing.Size(673, 443);
            this.Name = "EditTaskForm";
            this.Text = "Edit Task";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addToTaskBtn;
        private System.Windows.Forms.Button removeFromTaskBtn;
        private System.Windows.Forms.ListBox unassignedToIterationLB;
        private System.Windows.Forms.ListBox assignedToIterationLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PriorityTextBox;
        private System.Windows.Forms.DateTimePicker CompletetionDateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveTaskBtn;
        private System.Windows.Forms.TextBox ProjectIDTextBox;
    }
}