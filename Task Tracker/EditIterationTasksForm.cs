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

namespace Task_Tracker
{
    public partial class EditIterationTasksForm : Form
    {
        private Iteration currentIteration;
        private List<IterationTask> tasks;
        private List<Task> unassignedTasks;
        private IterationForm parent;

        public EditIterationTasksForm(Iteration iteration, IterationForm origin)
        {
            currentIteration = iteration;
            parent = origin;

            InitializeComponent();
            Text = "Assign Tasks to Iteration " + currentIteration.ID;

            populateLists();
        }

        public void populateLists()
        {
            unassignedToIterationLB.Items.Clear();
            assignedToIterationLB.Items.Clear();
            tasks = DBInterface.GetTasksForIteration(currentIteration.ID);
            unassignedTasks = DBInterface.GetUnassignedTasks();
            foreach (IterationTask itTask in tasks)
            {
                Task taskToAdd = DBInterface.GetTask(itTask.TaskID);
                if (taskToAdd.CompletionDate != null)
                {
                    assignedToIterationLB.Items.Add(taskToAdd + " (Completed)");
                }
                else
                {
                    assignedToIterationLB.Items.Add(taskToAdd);
                }
            }
            foreach (Task task in unassignedTasks)
            {
                if (task.CompletionDate == null) 
                    unassignedToIterationLB.Items.Add(task);
            }
        }

        private void assignedToIterationLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (assignedToIterationLB.SelectedItems.Count > 0)
            {
                unassignedToIterationLB.SelectedItem = null;
                removeFromIterationBtn.Enabled = true;
            }
            else
            {
                removeFromIterationBtn.Enabled = false;
            }
        }

        private void unassignedToIterationLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unassignedToIterationLB.SelectedItems.Count > 0)
            {
                assignedToIterationLB.SelectedItem = null;
                addToIterationBtn.Enabled = true;
            }
            else
            {
                addToIterationBtn.Enabled = false;
            }
        }

        private void removeFromIterationBtn_Click(object sender, EventArgs e)
        {
            IterationTask delItTask = tasks[assignedToIterationLB.SelectedIndex];
            if (DBInterface.GetTask(delItTask.TaskID).CompletionDate == null)
            {
                DBInterface.Delete(delItTask);
                populateLists();
                removeFromIterationBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cannot remove a task that has already been completed.");
            }  
        }

        private void addToIterationBtn_Click(object sender, EventArgs e)
        {
            Task taskSelected = unassignedTasks[unassignedToIterationLB.SelectedIndex];
            IterationTaskDatesForm itdf = new IterationTaskDatesForm(currentIteration, taskSelected, this);
            itdf.Owner = this;
            itdf.Show();
            Enabled = false;
            addToIterationBtn.Enabled = false;
        }

        private void EditIterationTasksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.LoadIterations();
            this.Dispose();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
