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
        public string taskName { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public DateTime date { get; set; }
        public int ProjectID { get; set; }
        public TasksForm(string name, string description, DateTime compDate, int priority, int project)
        {
            InitializeComponent();
            this.taskName = name;
            this.Description = description;
            this.date = compDate;
            this.Priority = priority;
            this.ProjectID = project;
        }
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
            int intPriority = Convert.ToInt32(PriorityTextBox.Text);
            int intProjectID = Convert.ToInt32(ProjectIDTextBox.Text);
            DateTime sDate = Convert.ToDateTime(CompletetionDateTextBox.Text);

            var nDate = DateTime.ParseExact(CompletetionDateTextBox.Text, "mm/dd/yyyy hh: mm:ss", null);
            TasksForm task = new TasksForm(this.TaskNameTextBox.Text, this.DescriptionTextBox.Text, sDate, intPriority, intProjectID);
            DBInterface.Add(task);
        }
    }
}
