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
            this.GivenNamesTextBox = new System.Windows.Forms.TextBox();
            this.FamilyNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ActiveCheckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DevelopersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AddEditLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GivenNamesTextBox
            // 
            this.GivenNamesTextBox.Location = new System.Drawing.Point(129, 55);
            this.GivenNamesTextBox.MaxLength = 255;
            this.GivenNamesTextBox.Name = "GivenNamesTextBox";
            this.GivenNamesTextBox.Size = new System.Drawing.Size(235, 20);
            this.GivenNamesTextBox.TabIndex = 1;
            // 
            // FamilyNameTextBox
            // 
            this.FamilyNameTextBox.Location = new System.Drawing.Point(129, 80);
            this.FamilyNameTextBox.MaxLength = 255;
            this.FamilyNameTextBox.Name = "FamilyNameTextBox";
            this.FamilyNameTextBox.Size = new System.Drawing.Size(235, 20);
            this.FamilyNameTextBox.TabIndex = 2;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(129, 105);
            this.EmailTextBox.MaxLength = 255;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(235, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.Location = new System.Drawing.Point(129, 130);
            this.ContactNumberTextBox.MaxLength = 50;
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.Size = new System.Drawing.Size(235, 20);
            this.ContactNumberTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Given Names:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Family Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact Number:";
            // 
            // ActiveCheckbox
            // 
            this.ActiveCheckbox.AutoSize = true;
            this.ActiveCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActiveCheckbox.Checked = true;
            this.ActiveCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActiveCheckbox.Location = new System.Drawing.Point(129, 155);
            this.ActiveCheckbox.Name = "ActiveCheckbox";
            this.ActiveCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ActiveCheckbox.TabIndex = 9;
            this.ActiveCheckbox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ActiveCheckbox.UseMnemonic = false;
            this.ActiveCheckbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Active Developer?:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(206, 262);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DevelopersListView
            // 
            this.DevelopersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.DevelopersListView.Location = new System.Drawing.Point(392, 24);
            this.DevelopersListView.Name = "DevelopersListView";
            this.DevelopersListView.Size = new System.Drawing.Size(617, 312);
            this.DevelopersListView.TabIndex = 12;
            this.DevelopersListView.UseCompatibleStateImageBehavior = false;
            this.DevelopersListView.View = System.Windows.Forms.View.Details;
            this.DevelopersListView.SelectedIndexChanged += new System.EventHandler(this.DevelopersListView_SelectedIndexChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Notes:";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(129, 180);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotesTextBox.Size = new System.Drawing.Size(235, 80);
            this.NotesTextBox.TabIndex = 14;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(23, 326);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 15;
            this.IDTextBox.Visible = false;
            // 
            // AddEditLabel
            // 
            this.AddEditLabel.AutoSize = true;
            this.AddEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEditLabel.Location = new System.Drawing.Point(23, 13);
            this.AddEditLabel.Name = "AddEditLabel";
            this.AddEditLabel.Size = new System.Drawing.Size(51, 16);
            this.AddEditLabel.TabIndex = 16;
            this.AddEditLabel.Text = "label7";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(289, 262);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseMnemonic = false;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 358);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddEditLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DevelopersListView);
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
            this.Name = "DeveloperForm";
            this.Text = "DeveloperForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeveloperForm_FormClosing);
            this.Load += new System.EventHandler(this.DeveloperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GivenNamesTextBox;
        private System.Windows.Forms.TextBox FamilyNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ActiveCheckbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListView DevelopersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label AddEditLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}