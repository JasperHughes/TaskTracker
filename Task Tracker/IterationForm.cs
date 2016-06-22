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
        List<Iteration> iterations;
        List<Task> tasks;
        Iteration iteration;
        public IterationForm()
        {
            InitializeComponent();
            LoadIterations();

        }

        private void LoadIterations()
        {
            iterationListView.Items.Clear();

            // Load all the iterations into the List View
            

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
                projects = DBInterface.GetProjects();
                if (projectIDTextBox.Text != "" && projects.Contains(projects.Find(project => project.ID == Int32.Parse(projectIDTextBox.Text))))
                {

                    if (!iterations.Contains(iterations.Find(iteration => iteration.ID == Int32.Parse(IterationIDLabel.Text))))
                    {
                        try
                        {
                            iteration = new Iteration();
                            iteration.ID = Int32.Parse(IterationIDLabel.Text);
                            iteration.ProjectID = Int32.Parse(projectIDTextBox.Text);
                            iteration.StartDate = startDatePicker.Value;
                            iteration.EndDate = endDatePicker.Value;
                            iteration.Project = projects.Find(project => project.ID == iteration.ProjectID);
                            DBInterface.Add(iteration);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }
                    else {
                        try
                        {
                            iteration = iterations.Find(iteration => iteration.ID == Int32.Parse(IterationIDLabel.Text));
                            
                            iteration.StartDate = startDatePicker.Value;
                            iteration.EndDate = endDatePicker.Value;
                            DBInterface.Update(iteration);

                        }
                        catch (Exception ex)
                        {
                            // TODO What should really happen on error?
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }
                    ResetFields();

                    LoadIterations();
                }
                else {
                    MessageBox.Show("Please enter make sure input is valid");
                }
              //  UpdateAddEditLabel();

            }
        }
        private void iterationListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (iterationListView.SelectedItems.Count > 0)
            {
                // Load Values into Editable fields

                ListViewItem item = iterationListView.SelectedItems[0];
                int i = 0;
                IterationTasksList.Items.Clear();
                IterationIDLabel.Text = item.SubItems[i++].Text;
                projectIDTextBox.Text = item.SubItems[i++].Text;
                projectTextBox.Text = item.SubItems[i++].Text;
                foreach (IterationTask it in iterations.Find(iteration => iteration.ID == Int32.Parse(IterationIDLabel.Text)).IterationTasks) {
                    IterationTasksList.Items.Add(it.TaskID);
                }
                i++;
                i++;
                startDatePicker.Text = item.SubItems[i++].Text;
                endDatePicker.Text = item.SubItems[i++].Text;
                if (IterationTasksList.Items.Count != 0)
                {
                    IterationTasksList.SelectedIndex = 0;
                }
                else {
                    ITEditButton.Enabled = false;
                }
                projectIDTextBox.Enabled = false;
               // LoadIterations();
                //UpdateAddEditLabel();
            }
        }

        private void AddIterationTask_Click(object sender, EventArgs e)
        {
            EditIterationTasksForm eitf = new EditIterationTasksForm(iterations.Find(iteration => iteration.ID == Int32.Parse(IterationIDLabel.Text)));
            eitf.Show();
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

        private void IterationTasksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ITEditButton.Enabled = true;
        }

        private void ITEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                tasks = DBInterface.GetTasks();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message, ex.GetType().ToString());
            }

            if (IterationTasksList.SelectedItem != null)
            {
                EditTaskForm etf = new EditTaskForm(tasks.Find(task => task.ID == Int32.Parse(IterationTasksList.SelectedItem.ToString())), new TasksForm());
                etf.Show();
            }
        }

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            ResetFields();
            projectIDTextBox.Enabled = true;
            IterationIDLabel.Text = (iterations[iterations.Count-1].ID + 1).ToString();

        }
        private void ResetFields() {
            // Reset edit fields
            IterationIDLabel.Text = "";
            projectIDTextBox.Text = "";
            projectTextBox.Text = "";

            IterationTasksList.Items.Clear();
            startDatePicker.ResetText();
            endDatePicker.ResetText();
        }
    }
}
