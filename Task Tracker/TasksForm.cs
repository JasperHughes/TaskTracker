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
            // TODO: This line of code loads data into the 'taskTrackerDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.taskTrackerDataSet.Projects);
            // TODO: This line of code loads data into the 'taskTrackerDataSet.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.taskTrackerDataSet.Tasks);
            // TODO: This line of code loads data into the 'taskTrackerDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.taskTrackerDataSet.Projects);
            // TODO: This line of code loads data into the 'taskTrackerDataSet.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.taskTrackerDataSet.Tasks);

        }

        private void TaskFormSaveButton_Click(object sender, EventArgs e)
        {
            bool priority = false;
            bool project = false;
            if(PriorityTextBox.Text.Equals("Select a Priority"))
            {
                MessageBox.Show("Please select a priority");
                priority = false;
            }
            else
            {
                priority = true;
            }
            if(ProjectIDTextBox.Text.Equals("Select a Project"))
            {
                MessageBox.Show("Please select a project");
                project = false;
            }
            else
            {
                project = true;
            }

            if (project && priority)
            {
                Task task = new Task();
                task.TaskName = TaskNameTextBox.Text;
                task.Description = DescriptionTextBox.Text;
                task.CompletionDate = CompletetionDateTextBox.Value;
                task.Priority = PriorityTextBox.Text;
                task.ProjectID = (int)ProjectIDTextBox.SelectedValue;
                DBInterface.Add(task);
                this.tasksTableAdapter.Fill(this.taskTrackerDataSet.Tasks);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Task selected = DBInterface.GetTask((int)dataGridView1.CurrentRow.Cells[0].Value);
            EditTaskForm etf = new EditTaskForm(selected);
            etf.Show();
        }
    }
}
