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
            this.taskNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addToTaskBtn
            // 
            this.addToTaskBtn.Enabled = false;
            this.addToTaskBtn.Location = new System.Drawing.Point(290, 127);
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
            this.removeFromTaskBtn.Location = new System.Drawing.Point(290, 283);
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
            this.unassignedToIterationLB.Location = new System.Drawing.Point(12, 78);
            this.unassignedToIterationLB.Name = "unassignedToIterationLB";
            this.unassignedToIterationLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.unassignedToIterationLB.Size = new System.Drawing.Size(239, 277);
            this.unassignedToIterationLB.TabIndex = 4;
            this.unassignedToIterationLB.SelectedIndexChanged += new System.EventHandler(this.unassignedToIterationLB_SelectedIndexChanged);
            // 
            // assignedToIterationLB
            // 
            this.assignedToIterationLB.FormattingEnabled = true;
            this.assignedToIterationLB.Location = new System.Drawing.Point(404, 75);
            this.assignedToIterationLB.Name = "assignedToIterationLB";
            this.assignedToIterationLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.assignedToIterationLB.Size = new System.Drawing.Size(239, 277);
            this.assignedToIterationLB.TabIndex = 5;
            this.assignedToIterationLB.SelectedIndexChanged += new System.EventHandler(this.assignedToIterationLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Developers Not Assigned To This Task";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 55);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(261, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Developers Assigned To This Task";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taskNameLbl
            // 
            this.taskNameLbl.AutoSize = true;
            this.taskNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLbl.Location = new System.Drawing.Point(14, 13);
            this.taskNameLbl.Name = "taskNameLbl";
            this.taskNameLbl.Size = new System.Drawing.Size(98, 20);
            this.taskNameLbl.TabIndex = 8;
            this.taskNameLbl.Text = "Task Name";
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 367);
            this.Controls.Add(this.taskNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignedToIterationLB);
            this.Controls.Add(this.unassignedToIterationLB);
            this.Controls.Add(this.removeFromTaskBtn);
            this.Controls.Add(this.addToTaskBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(673, 406);
            this.MinimumSize = new System.Drawing.Size(673, 406);
            this.Name = "EditTaskForm";
            this.Text = "EditTaskForm";
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
        private System.Windows.Forms.Label taskNameLbl;
    }
}