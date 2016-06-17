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
    public partial class EditTaskForm : Form
    {
        private Task currentTask;
        private Iteration currentIteration;
        private List<Developer> developers;
        public EditTaskForm(Task task)
        {
            currentTask = task;
            try {
                currentIteration = currentTask.IterationTasks.Single(it => it.Task.Equals(currentTask)).Iteration;
            }
            catch
            {
                currentIteration = null;
            }
            InitializeComponent();
            taskNameLbl.Text = currentTask.TaskName;
            PopulateLists();         
        }

        private void PopulateLists()
        {
            unassignedToIterationLB.Items.Clear();
            assignedToIterationLB.Items.Clear();
            developers = DBInterface.GetDevelopers();
            foreach (Developer d in developers)
            {
                foreach(DeveloperIterationTask dit in d.DeveloperIterationTasks)
                {
                    if (dit.Task.Equals(currentTask))
                    {
                        assignedToIterationLB.Items.Add(d);
                        break;                        
                    }
                }
                if (!assignedToIterationLB.Items.Contains(d))
                {
                    unassignedToIterationLB.Items.Add(d);
                }
            }
        }

        private void addToTaskBtn_Click(object sender, EventArgs e)
        {
            if(currentIteration != null)
            {
                foreach (Developer d in unassignedToIterationLB.SelectedItems)
                {
                    DeveloperIterationTask dit = new DeveloperIterationTask();
                    dit.Developer = d;
                    dit.Iteration = currentIteration;
                    dit.Task = currentTask;
                    dit.DeveloperID = d.ID;
                    dit.IterationID = currentIteration.ID;
                    dit.TaskID = currentTask.ID;
                    DBInterface.Add(dit);
                }
                PopulateLists();
            }
            if (unassignedToIterationLB.SelectedItems.Count == 0)
            {
                addToTaskBtn.Enabled = false;
            }
        }

        private void removeFromTaskBtn_Click(object sender, EventArgs e)
        {
            if (currentIteration != null)
            {
                foreach (Developer d in assignedToIterationLB.SelectedItems)
                {
                    DeveloperIterationTask dit = DBInterface.GetDeveloperIterationTask(d.ID, currentIteration.ID, currentTask.ID);
                    DBInterface.Delete(dit);
                }
                PopulateLists();
            }
            if(assignedToIterationLB.SelectedItems.Count == 0)
            {
                removeFromTaskBtn.Enabled = false;
            }
        }

        private void unassignedToIterationLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unassignedToIterationLB.SelectedItems.Count > 0)
            {
                addToTaskBtn.Enabled = true;
            }
            else
            {
                addToTaskBtn.Enabled = false;
            }
        }

        private void assignedToIterationLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (assignedToIterationLB.SelectedItems.Count > 0)
            {
                removeFromTaskBtn.Enabled = true;
            }
            else
            {
                removeFromTaskBtn.Enabled = false;
            }
        }
    }
}
