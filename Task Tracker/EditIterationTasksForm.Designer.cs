namespace Task_Tracker
{
    partial class EditIterationTasksForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignedToIterationLB = new System.Windows.Forms.ListBox();
            this.unassignedToIterationLB = new System.Windows.Forms.ListBox();
            this.removeFromIterationBtn = new System.Windows.Forms.Button();
            this.addToIterationBtn = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 11);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(242, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tasks Assigned to This Iteration";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Unassigned Tasks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // assignedToIterationLB
            // 
            this.assignedToIterationLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignedToIterationLB.FormattingEnabled = true;
            this.assignedToIterationLB.Location = new System.Drawing.Point(406, 31);
            this.assignedToIterationLB.Name = "assignedToIterationLB";
            this.assignedToIterationLB.Size = new System.Drawing.Size(239, 277);
            this.assignedToIterationLB.TabIndex = 12;
            this.assignedToIterationLB.SelectedIndexChanged += new System.EventHandler(this.assignedToIterationLB_SelectedIndexChanged);
            // 
            // unassignedToIterationLB
            // 
            this.unassignedToIterationLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.unassignedToIterationLB.FormattingEnabled = true;
            this.unassignedToIterationLB.Location = new System.Drawing.Point(14, 34);
            this.unassignedToIterationLB.Name = "unassignedToIterationLB";
            this.unassignedToIterationLB.Size = new System.Drawing.Size(239, 277);
            this.unassignedToIterationLB.TabIndex = 11;
            this.unassignedToIterationLB.SelectedIndexChanged += new System.EventHandler(this.unassignedToIterationLB_SelectedIndexChanged);
            // 
            // removeFromIterationBtn
            // 
            this.removeFromIterationBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.removeFromIterationBtn.Enabled = false;
            this.removeFromIterationBtn.Location = new System.Drawing.Point(292, 239);
            this.removeFromIterationBtn.Name = "removeFromIterationBtn";
            this.removeFromIterationBtn.Size = new System.Drawing.Size(75, 23);
            this.removeFromIterationBtn.TabIndex = 10;
            this.removeFromIterationBtn.Text = "<---";
            this.removeFromIterationBtn.UseVisualStyleBackColor = true;
            this.removeFromIterationBtn.Click += new System.EventHandler(this.removeFromIterationBtn_Click);
            // 
            // addToIterationBtn
            // 
            this.addToIterationBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addToIterationBtn.Enabled = false;
            this.addToIterationBtn.Location = new System.Drawing.Point(292, 83);
            this.addToIterationBtn.Name = "addToIterationBtn";
            this.addToIterationBtn.Size = new System.Drawing.Size(75, 23);
            this.addToIterationBtn.TabIndex = 9;
            this.addToIterationBtn.Text = "--->";
            this.addToIterationBtn.UseVisualStyleBackColor = true;
            this.addToIterationBtn.Click += new System.EventHandler(this.addToIterationBtn_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(570, 332);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditIterationTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 367);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignedToIterationLB);
            this.Controls.Add(this.unassignedToIterationLB);
            this.Controls.Add(this.removeFromIterationBtn);
            this.Controls.Add(this.addToIterationBtn);
            this.MaximumSize = new System.Drawing.Size(673, 406);
            this.MinimumSize = new System.Drawing.Size(602, 278);
            this.Name = "EditIterationTasksForm";
            this.Text = "Assign Tasks to Iteration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditIterationTasksForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox assignedToIterationLB;
        private System.Windows.Forms.ListBox unassignedToIterationLB;
        private System.Windows.Forms.Button removeFromIterationBtn;
        private System.Windows.Forms.Button addToIterationBtn;
        private System.Windows.Forms.Button CloseButton;
    }
}