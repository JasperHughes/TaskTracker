namespace Task_Tracker
{
    partial class IterationTaskDatesForm
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
            this.StartDateDtPck = new System.Windows.Forms.DateTimePicker();
            this.EndDateDtPck = new System.Windows.Forms.DateTimePicker();
            this.OkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartDateDtPck
            // 
            this.StartDateDtPck.Location = new System.Drawing.Point(29, 35);
            this.StartDateDtPck.Name = "StartDateDtPck";
            this.StartDateDtPck.Size = new System.Drawing.Size(200, 20);
            this.StartDateDtPck.TabIndex = 0;
            // 
            // EndDateDtPck
            // 
            this.EndDateDtPck.Location = new System.Drawing.Point(29, 95);
            this.EndDateDtPck.Name = "EndDateDtPck";
            this.EndDateDtPck.Size = new System.Drawing.Size(200, 20);
            this.EndDateDtPck.TabIndex = 1;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(169, 133);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Planned End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Planned Start Date";
            // 
            // IterationTaskDatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.EndDateDtPck);
            this.Controls.Add(this.StartDateDtPck);
            this.MaximumSize = new System.Drawing.Size(272, 207);
            this.MinimumSize = new System.Drawing.Size(272, 207);
            this.Name = "IterationTaskDatesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IterationTaskDatesForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartDateDtPck;
        private System.Windows.Forms.DateTimePicker EndDateDtPck;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}