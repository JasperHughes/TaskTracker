using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Tracker.DAO;
using System.Globalization;

namespace Task_Tracker
{
    public partial class TasksForm : Form
    {
        public TasksForm()
        {
            InitializeComponent();
      
        }


        private void TaksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskTrackerDataSet.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.taskTrackerDataSet.Tasks);

        }

        private void TaskFormSaveButton_Click(object sender, EventArgs e)

        {
            int intProjectID = Convert.ToInt32(ProjectIDTextBox.Text);
            DateTime sDate = Convert.ToDateTime(CompletetionDateTextBox.Text);



            Task task = new Task();
            task.TaskName = TaskNameTextBox.Text;
            task.Description = DescriptionTextBox.Text;
            task.CompletionDate = sDate;
            task.Priority = PriorityTextBox.Text;
            task.ProjectID = intProjectID;
            DBInterface.Add(task);
            this.tasksTableAdapter.Fill(this.taskTrackerDataSet.Tasks);
        }

        private void ProjectIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
        }

        private void PriorityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

    
        }
    }
}
