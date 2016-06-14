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

            // Load all the developers into the List View
            List<Iteration> iterations;

            try
            {
                iterations = (List<Iteration>)DBInterface.SelectAll(DBInterface.Table.ITERATIONS);
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
                    // TODO If there are no developers what happens?
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
                iteration.ID = Int32.Parse(ReplaceEmptyStringWithNull(IDTextBox.Text));
                iteration.ProjectID= Int32.Parse(ReplaceEmptyStringWithNull(projectIDTextBox.Text));
         
                
                // TODO Fix these values
           
                /*   iteration.Project= ReplaceEmptyStringWithNull(projectTextBox.Text);
                iteration.IterationTasks= ReplaceEmptyStringWithNull(iterationTasksTextBox.Text);
                iteration.DeveloperIterationTasks = ReplaceEmptyStringWithNull(developerIterationTasksTextBox.Text);
                iteration.StartDate = ReplaceEmptyStringWithNull(startDatePicker.Text);
                iteration.EndDate = ReplaceEmptyStringWithNull(endDatePicker.Text);
            */
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
        // Replace empty string with null, otherwise leave it as is.
        private string ReplaceEmptyStringWithNull(string value)
        {
            return value.Length == 0 ? null : value;
        }
    }
}
