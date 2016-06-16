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
    public partial class IterationForm : Form
    {
        public IterationForm()
        {
            InitializeComponent();
        }

        private void LoadIterations()
        {
            iterationListView.Items.Clear();

            // Load all the iterations into the List View
            List<Iteration> iterations;

            try
            {
                iterations = DBInterface.GetIterations();
                if (iterations.Count > 0)
                {
                    int i = 0;
                    foreach (Iteration iteration in iterations)
                    {
                        iterationListView.Items.Add(iteration.ID.ToString());
                        iterationListView.Items[i].SubItems.Add(iteration.ProjectID.ToString());
                        iterationListView.Items[i].SubItems.Add(iteration.Project.ToString());
                        iterationListView.Items[i].SubItems.Add(iteration.IterationTasks.ToString());
                        iterationListView.Items[i].SubItems.Add(iteration.DeveloperIterationTasks.ToString());
                        iterationListView.Items[i].SubItems.Add(iteration.StartDate.ToString());
                        iterationListView.Items[i].SubItems.Add(iteration.EndDate.ToString());


                        i++;
                    }
                }
                else
                {
                    // TODO If there are no iterations what happens?
                }
            }
            catch (Exception ex)
            {
                // TODO What should really happen on error?
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            {
                // TODO Add validation to check all values entered
                List<Project> projects;
                Iteration iteration = new Iteration();
                try
                {
                    projects = DBInterface.GetProjects();

               
                    iteration.ID = Int32.Parse(IDTextBox.Text);
                    iteration.ProjectID = Int32.Parse(projectIDTextBox.Text);
                    iteration.StartDate = startDatePicker.Value;
                    iteration.EndDate = endDatePicker.Value;
                    iteration.Project = projects.Find(project => project.ID == iteration.ProjectID);

                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
        
            //    iteration.IterationTasks= ReplaceEmptyStringWithNull(iterationTasksTextBox.Text);
            //    iteration.DeveloperIterationTasks = ReplaceEmptyStringWithNull(developerIterationTasksTextBox.Text);

            
                try
                {
                    if (IDTextBox.Text == "")
                    {
                        DBInterface.Add(iteration);
                    }
                    else
                    {
                        iteration.ID = Int32.Parse(IDTextBox.Text);
                        DBInterface.Update(iteration);
                    }
                }
                catch (Exception ex)
                {
                    // TODO What should really happen on error?
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

                // Reset edit fields
                IDTextBox.Text = "";
                projectIDTextBox.Text = "";
                projectTextBox.Text = "";
                iterationTasksTextBox.Text = "";
                developerIterationTasksTextBox.Text = "";
                startDatePicker.ResetText();
                endDatePicker.ResetText();

                LoadIterations();
              //  UpdateAddEditLabel();

            }
        }
        private void IterationListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (iterationListView.SelectedItems.Count > 0)
            {
                // Load Values into Editable fields
                ListViewItem item = iterationListView.SelectedItems[0];
                int i = 0;

                IDTextBox.Text = item.SubItems[i++].Text;
                projectIDTextBox.Text = item.SubItems[i++].Text;
                projectTextBox.Text = item.SubItems[i++].Text;
                iterationTasksTextBox.Text = item.SubItems[i++].Text;
                developerIterationTasksTextBox.Text = item.SubItems[i++].Text;
                startDatePicker.Text = item.SubItems[i++].Text;
                endDatePicker.Text = item.SubItems[i++].Text;

                LoadIterations();
                //UpdateAddEditLabel();
            }
        }

        private void AddIterationTask_Click(object sender, EventArgs e)
        {
            IterationTasksList.Items.Add(iterationTasksTextBox.Text);
            iterationTasksTextBox.Text = "";
        }

        private void RemoveIterationTask_Click(object sender, EventArgs e)
        {
            IterationTasksList.Items.Remove(IterationTasksList.SelectedItem);
        }

        private void AddDevIterationTask_Click(object sender, EventArgs e)
        {
            DevIterationTasksList.Items.Add(developerIterationTasksTextBox.Text);
            developerIterationTasksTextBox.Text = "";
        }

        private void RemoveDevIterationTask_Click(object sender, EventArgs e)
        {
            DevIterationTasksList.Items.Remove(DevIterationTasksList.SelectedItem);
        }
    }
}
