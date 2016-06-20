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
        List<Project> projects;

        public IterationForm()
        {
            InitializeComponent();
            LoadIterations();
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
                        string itTasks = "";
                        string devItTasks = "";
                        iterationListView.Items.Add(iteration.ID.ToString());
                        iterationListView.Items[i].SubItems.Add(iteration.ProjectID.ToString());
                        iterationListView.Items[i].SubItems.Add(iteration.Project.ProjectName);
                        foreach (IterationTask it in iteration.IterationTasks) {
                            itTasks += it.TaskID.ToString()+ ",";
                        }
                        if (itTasks != ""){
                            iterationListView.Items[i].SubItems.Add(itTasks.Remove(itTasks.Length - 1));
                        }
                        else {
                            iterationListView.Items[i].SubItems.Add("");
                        }
                        foreach (DeveloperIterationTask dit in iteration.DeveloperIterationTasks){
                            devItTasks += dit.TaskID.ToString() + ",";
                        }
                        if (devItTasks != ""){
                            iterationListView.Items[i].SubItems.Add(devItTasks.Remove(devItTasks.Length - 1));
                        }
                        else {
                            iterationListView.Items[i].SubItems.Add("");
                        }
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

                Iteration iteration = new Iteration();
                try
                {
                    projects = DBInterface.GetProjects();

               
                    iteration.ID = Int32.Parse(IDTextBox.Text);
                    iteration.ProjectID = Int32.Parse(projectIDTextBox.Text);
                    foreach (string listboxval in IterationTasksList.Items) {
     //TODO                   iteration.IterationTasks.Add()
                    }
                    iteration.StartDate = startDatePicker.Value;
                    iteration.EndDate = endDatePicker.Value;
                    iteration.Project = projects.Find(project => project.ID == iteration.ProjectID);

                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
        
           
            
                try
                {
                
                        iteration.ID = Int32.Parse(IDTextBox.Text);
                        DBInterface.Add(iteration);
                    
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
                IterationTasksList.Items.Clear();
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

        private void projectIDTextBox_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                projects = DBInterface.GetProjects();
                projectTextBox.Text = projects.Find(project => project.ID == Int32.Parse(projectIDTextBox.Text)).ProjectName; 
            }
            catch (Exception ex)
            {
                projectTextBox.Text = "";
                Console.WriteLine(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
