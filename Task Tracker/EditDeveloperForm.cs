using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Tracker.DAO;
using Task_Tracker.Reporting;

namespace Task_Tracker
{
    public partial class EditDeveloperForm : Form
    {
        // Link back to calling form which is always DeveloperForm
        private DeveloperForm callingForm;

        // List of required fields for a developer that must be entered 
        // in order for Save button to be enabled
        private TextBox[] requiredFields;

        // The current developer that is being edited. If it's null then
        // adding a new developer
        private Developer currentDeveloper;
        public Developer CurrentDeveloper
        {
            get
            {
                return currentDeveloper;
            }
            set
            {
                currentDeveloper = value;
                this.UpdateForm();
            }
        }

        public EditDeveloperForm(DeveloperForm form)
        {
            InitializeComponent();

            this.callingForm = form;

            requiredFields = new TextBox[] {
                this.FamilyNameTextBox,
                this.GivenNamesTextBox,
                this.ContactNumberTextBox,
                this.EmailTextBox
            };
        }



        public void UpdateForm() {
            // Update the textboxes and page label with appropriate values
            if (CurrentDeveloper == null)
            {
                FamilyNameTextBox.Text = "";
                GivenNamesTextBox.Text = "";
                EmailTextBox.Text = "";
                ContactNumberTextBox.Text = "";
                ActiveStatusLabel.Text = "Yes";
                NotesTextBox.Text = "";

                AddEditLabel.Text = "Add Developer";
            }
            else
            {
                GivenNamesTextBox.Text = CurrentDeveloper.GivenNames;
                FamilyNameTextBox.Text = CurrentDeveloper.FamilyName;
                EmailTextBox.Text = CurrentDeveloper.Email;
                ContactNumberTextBox.Text = CurrentDeveloper.ContactNumber;
                ActiveStatusLabel.Text = CurrentDeveloper.Active ? "Yes" : "No";
                NotesTextBox.Text = CurrentDeveloper.Notes;

                AddEditLabel.Text = "Edit Developer ";
            }
            CheckEnableActions();

            LoadIterations();
        }

        private void LoadIterations()
        {
            // Load the list of iterations in the DataGridView
            if (CurrentDeveloper != null)
            {
                this.IterationsDataGridView.ReadOnly = true;
                this.IterationsDataGridView.DataSource = DBInterface.GetDeveloperIterationView(CurrentDeveloper.ID);

                // Hide the Developer ID, Iteration ID and Project ID columns
                // they are only required by the query
                this.IterationsDataGridView.Columns["DeveloperID"].Visible = false;
                this.IterationsDataGridView.Columns["IterationID"].Visible = false;
                this.IterationsDataGridView.Columns["ProjectID"].Visible = false;

                // Select first iteration so tasks are loaded
                if (this.IterationsDataGridView.RowCount > 0)
                {
                    this.IterationsDataGridView.Visible = true;
                    this.IterationsDataGridView.Rows[0].Selected = true;
                    LoadTasks();
                }
                else
                {
                    // Hide the view of iterations and tasks, when there are none
                    this.IterationsDataGridView.Visible = false;
                    this.TasksDataGridView.Visible = false;

                }
            }
            else
            {
                // Hide the view of iterations and tasks, new developers won't have any
                this.IterationsDataGridView.Visible = false;
                this.TasksDataGridView.Visible = false;
            }
        }

        private void LoadTasks()
        {
            // Load the list of tasks for the selected iteration that developer is assigned to

            // If iteration is selected
            if (this.IterationsDataGridView.SelectedRows.Count > 0)
            {
                // Set up the TasksDataGridView
                int iterationID = (int)this.IterationsDataGridView.SelectedRows[0].Cells["IterationID"].Value;
                this.TasksDataGridView.ReadOnly = true;
                this.TasksDataGridView.DataSource = DBInterface.GetDeveloperTasksByIteration(CurrentDeveloper.ID, iterationID);
                this.TasksDataGridView.Visible = true;

                // Hide columns user doesn't need to see
                this.TasksDataGridView.Columns["ID"].Visible = false;
                this.TasksDataGridView.Columns["ProjectID"].Visible = false;
                this.TasksDataGridView.Columns["Project"].Visible = false;
            }
            else
            {
                // When no selected row hide TasksDataGridView
                this.TasksDataGridView.Visible = false;
            }
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            // If any of the text boxes are changed check which actions are available.
            CheckEnableActions();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveDeveloper(new Developer());

            // Hide form after saving developer
            HideForm();
        }

        private void SaveDeveloper(Developer developer)
        {
            // Move all the details from the textboxes to Developer object
            developer.FamilyName = FamilyNameTextBox.Text;
            developer.GivenNames = GivenNamesTextBox.Text;
            developer.Email = EmailTextBox.Text;
            developer.ContactNumber = ContactNumberTextBox.Text;
            developer.Notes = NotesTextBox.Text;

            try
            {
                // Save the developer to the database.
                if (CurrentDeveloper == null)
                {
                    developer.Active = true;
                    DBInterface.Add(developer);
                }
                else
                {
                    developer.ID = CurrentDeveloper.ID;
                    DBInterface.Update(developer);
                }
            }
            catch (Exception ex)
            {
                // TODO What should really happen on error?
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void HideForm()
        {
            // In addition to hiding the form, need to update the calling form.
            this.Hide();
            callingForm.UpdateForm();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            HideForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Deleting the developer actually marks Active as False in order to retain the record for 
            // future purposes.

            // Only take action when developer is active
            if (currentDeveloper.Active)
            {
                // Cannot delete a developer that is assigned to an incomplete task
                int incompleteTasks = DBInterface.GetDeveloperIncompleteTasks(currentDeveloper.ID).Count;
                if (incompleteTasks > 0)
                {
                    MessageBox.Show("Developer cannot be deleted, they have "
                        + incompleteTasks + " incomplete tasks. " + Environment.NewLine
                        + "Either complete those tasks or remove them from this developer.", 
                        "Delete Developer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Mark current developer as inactive, save to the database (along with other changes
                    // to textfields) and update the form
                    currentDeveloper.Active = false;
                    SaveDeveloper(currentDeveloper);
                    UpdateForm();
                    MessageBox.Show(currentDeveloper + " has been made inactive. " + Environment.NewLine
                        + "They have not been deleted so that all previous work can be referenced.",
                        "Delete Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Developer is inactive so no need to do anything
                MessageBox.Show("Developer has already been deleted.", "Delete Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void CheckEnableActions()
        {
            // If there is a value in all required fields then enable Save button
            bool enableSave = true;
            foreach (TextBox textBox in requiredFields)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    enableSave = false;
                    break;
                }
            }

            this.SaveButton.Enabled = enableSave;
            this.saveToolStripMenuItem.Enabled = enableSave;

            // Delete button only enabled when editing a developer
            bool enableDelete = (currentDeveloper != null && CurrentDeveloper.Active);
            this.DeleteButton.Enabled = enableDelete;
            this.deleteToolStripMenuItem.Enabled = enableDelete;
        }

        private void EditDeveloperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel the closing of the form and hide form instead
            e.Cancel = true;
            HideForm();
        }

        private void EditDeveloperForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskTrackerDataSet.DeveloperIterationTasks' table. You can move, or remove it, as needed.
            this.developerIterationTasksTableAdapter.Fill(this.taskTrackerDataSet.DeveloperIterationTasks);
            // TODO: This line of code loads data into the 'taskTrackerDataSet.Developers' table. You can move, or remove it, as needed.
            this.developersTableAdapter.Fill(this.taskTrackerDataSet.Developers);

            UpdateForm();

        }

        private void IterationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (view.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Report button clicked
                int iterationID = (int)view.Rows[e.RowIndex].Cells["IterationID"].Value;

                // Go ahead and print the report.
                PrintReport(iterationID);
            }
        }

        private void PrintReport(int iterationID)
        {
            Iteration iteration = DBInterface.GetIteration(iterationID);
            if (iteration != null)
            {

                DeveloperIterationReport report = new DeveloperIterationReport(CurrentDeveloper, iteration);
                // TODO Enable printing of report
                //report.Print();

                // During testing just show print preview of document.
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = report;
                printPreviewDialog.ShowDialog();

            }
            else
            {
                // Error finding iteration record so display error to user to try again
                MessageBox.Show("Couldn't find Report to print. Try again.","Unable to Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IterationsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

    }
}
