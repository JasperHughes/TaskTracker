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
    public partial class IterationTaskDatesForm : Form
    {
        Iteration currentIteration;
        Task currentTask;
        EditIterationTasksForm parent;

        public IterationTaskDatesForm(Iteration iteration, Task task, EditIterationTasksForm origin)
        {
            currentIteration = iteration;
            currentTask = task;
            parent = origin;

            InitializeComponent();
            this.Text = "It:" + iteration.ID + " Task:" + task.ID + " Dates";
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (EndDateDtPck.Value < StartDateDtPck.Value)
            {
                MessageBox.Show("End date must not be before Start date");
            }
            else
            {
                IterationTask itTaskToAdd = new IterationTask();
                itTaskToAdd.TaskID = currentTask.ID;
                itTaskToAdd.IterationID = currentIteration.ID;
                itTaskToAdd.PlannedStartDate = StartDateDtPck.Value;
                itTaskToAdd.PlannedCompletionDate = EndDateDtPck.Value;
                DBInterface.Add(itTaskToAdd);
                this.Close();
            }
        }

        private void IterationTaskDatesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.populateLists();
            Owner.Enabled = true;
            this.Dispose();
        }
    }
}
