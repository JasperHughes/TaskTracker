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

            IterationLbl.Text = "Assign Tasks to Iteration " + iteration.ID;
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
                assignedToIterationLB.Items.Add(DBInterface.GetTask(itTask.TaskID));
            }
            foreach (Task task in unassignedTasks)
            {
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
            DBInterface.Delete(delItTask);
            populateLists();
            removeFromIterationBtn.Enabled = false;
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
    }
}
