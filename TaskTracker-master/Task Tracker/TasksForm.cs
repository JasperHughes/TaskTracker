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


        private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            HideForm();
        }
        private void HideForm()
        {

            this.Hide();
        }

        private void TaksForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void TaskFormSaveButton_Click(object sender, EventArgs e)
        {
            bool priority = false;
            bool project = false;
            if (PriorityTextBox.Text.Equals("Select a Priority"))
            {
                MessageBox.Show("Please select a priority");
                priority = false;
            }
            else
            {
                priority = true;
            }
            if (ProjectIDTextBox.Text.Equals("Select a Project"))
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
                if (CompletetionDateTextBox.Checked)
                {
                    task.CompletionDate = CompletetionDateTextBox.Value;
                }
                else
                {
                    task.CompletionDate = DateTime.MinValue;
                }
                task.Priority = PriorityTextBox.Text;
                task.ProjectID = (int)ProjectIDTextBox.SelectedValue;
                DBInterface.Add(task);
                ReloadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Task selected = DBInterface.GetTask((int)dataGridView1.CurrentRow.Cells[0].Value);
            EditTaskForm etf = new EditTaskForm(selected, this);
            etf.Show();

        }

        public void ReloadData()
        {
            // TODO: This line of code loads data into the 'taskTrackerDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.taskTrackerDataSet.Projects);
            // TODO: This line of code loads data into the 'taskTrackerDataSet.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.taskTrackerDataSet.Tasks);

        }

        private void TaskCloseButton_Click(object sender, EventArgs e)
        {
            HideForm();
        }

    
    }
}
