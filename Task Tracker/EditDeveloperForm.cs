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

        #region "Initialise"

        // Link back to calling form which is always DeveloperForm
        private DeveloperForm callingForm;

        // List of required fields for a developer that must be entered 
        // in order for Save button to be enabled
        private TextBox[] requiredFields;

        // The ideal width of this form. The form is being resized when
        // iterations panel is hidden so this is used as a baseline.
        private static readonly int IDEAL_FORM_WIDTH = 850;

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

        #endregion

        #region "Form"

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

        private void InactiveDeveloperMessageLabel_Paint(object sender, PaintEventArgs e)
        {
            // Paint border red, cannot be done with properties on form design
            ControlPaint.DrawBorder(e.Graphics, InactiveDeveloperMessageLabel.DisplayRectangle, Color.FromArgb(192, 0, 0), ButtonBorderStyle.Solid);
        }
        
        public void UpdateForm()
        {
            // Update the textboxes and page label with appropriate values
            if (CurrentDeveloper == null)
            {
                FamilyNameTextBox.Text = "";
                GivenNamesTextBox.Text = "";
                EmailTextBox.Text = "";
                ContactNumberTextBox.Text = "";
                ActiveStatusLabel.Text = "Yes";
                NotesTextBox.Text = "";

                // Update the form's label
                this.Text = "Add Developer";
            }
            else
            {
                GivenNamesTextBox.Text = CurrentDeveloper.GivenNames;
                FamilyNameTextBox.Text = CurrentDeveloper.FamilyName;
                EmailTextBox.Text = CurrentDeveloper.Email;
                ContactNumberTextBox.Text = CurrentDeveloper.ContactNumber;
                ActiveStatusLabel.Text = CurrentDeveloper.Active ? "Yes" : "No";
                NotesTextBox.Text = CurrentDeveloper.Notes;

                // Update the form's label
                this.Text = "Edit Developer";
            }

            // Show Inactive Developer label at appropriate time
            this.InactiveDeveloperMessageLabel.Visible = CurrentDeveloper != null ? !CurrentDeveloper.Active : false;

            // Default value of Iterations Only checkbox is false
            this.CurrentIterationOnlyCheckBox.Checked = false;

            CheckEnableActions();

            LoadIterations();

            // Reset size of form as it may need to be changed due to 
            // iterations panel being shown or hidden.
            ResetFormDimensions();
        }

        private void ResetFormDimensions()
        {
            // If there are no iterations resize form to exclude blank panel area.
            // Note. Do not use visibility status of IterationsPanel, as it will
            // always return false when form in hidden state.
            if (this.IterationsDataGridView.RowCount == 0)
            {
                this.Width = this.Width - this.IterationsPanel.Width;
            }
            else
            {
                this.Width = IDEAL_FORM_WIDTH;
            }
        }

        private void HideForm()
        {
            // In addition to hiding the form, need to update the calling form.
            this.Hide();
            callingForm.UpdateForm();
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
        
        #endregion

        #region "Textbox, Button Events"

        private void Input_TextChanged(object sender, EventArgs e)
        {
            // If any of the text boxes are changed check which actions are available.
            CheckEnableActions();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Use current developer, but if null create a new object.
            Developer developer = CurrentDeveloper;
            if (developer == null)
            {
                developer = new Developer();
            }
            SaveDeveloper(developer);

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

        #endregion

        #region "Iterations"

        private void CurrentIterationOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Reload the list of iterations
            LoadIterations();
        }

        private void IterationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            // Reload tasks when any valid cell is clicked on
            if (e.RowIndex >= 0)
            {
                // If there is a row currently selected and it's different to the cell's row then reload tasks
                int currentSelectedRowIndex = -1;
                if (view.SelectedRows.Count > 0)
                {
                    currentSelectedRowIndex = view.SelectedRows[0].Index;
                }

                // Clear any selected rows
                view.ClearSelection();
                // Set the cell's row as selected so that LoadTasks gets the right iteration
                view.Rows[e.RowIndex].Selected = true;

                // If this is a newly selected iteration reload tasks
                if (currentSelectedRowIndex == 0 ||
                    (currentSelectedRowIndex >= 0 && e.RowIndex != currentSelectedRowIndex))
                {
                    LoadTasks();
                }
            }

            if (view.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Report button clicked
                int iterationID = (int)view.Rows[e.RowIndex].Cells["IterationID"].Value;

                // Go ahead and print the report.
                PrintReport(iterationID);
            }
        }

        private void IterationsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void LoadIterations()
        {
            // Load the list of iterations in the DataGridView
            if (CurrentDeveloper != null)
            {
                this.IterationsDataGridView.ReadOnly = true;

                // Get list of all iterations
                List<DeveloperIterationView> allIterations = DBInterface.GetDeveloperIterationView(CurrentDeveloper.ID);
                // If only current iteration is to be shown get those elements.
                if (this.CurrentIterationOnlyCheckBox.Checked)
                {
                    List<DeveloperIterationView> filteredIterations = DBInterface.GetDeveloperCurrentIterationView(CurrentDeveloper.ID);
                    this.IterationsDataGridView.DataSource = filteredIterations;
                }
                else
                {
                    this.IterationsDataGridView.DataSource = allIterations;
                }

                // Hide the Developer ID, Iteration ID and Project ID columns
                // they are only required by the query
                this.IterationsDataGridView.Columns["DeveloperID"].Visible = false;
                this.IterationsDataGridView.Columns["IterationID"].Visible = false;
                this.IterationsDataGridView.Columns["ProjectID"].Visible = false;

                // Select first iteration so tasks are loaded
                if (allIterations.Count > 0)
                {
                    this.IterationsPanel.Visible = true;
                    if (this.IterationsDataGridView.RowCount > 0)
                    {
                        this.IterationsDataGridView.Rows[0].Selected = true;
                        LoadTasks();
                    }
                    else
                    {
                        // If there are no iterations hide the tasks panel
                        this.TasksPanel.Visible = false;
                    }
                }
                else
                {
                    // Hide the view of iterations and tasks, when there are none
                    this.IterationsPanel.Visible = false;
                    this.TasksPanel.Visible = false;
                }
            }
            else
            {
                // Reset iterations data source
                this.IterationsDataGridView.DataSource = null;

                // Hide the view of iterations and tasks, new developers won't have any
                this.IterationsPanel.Visible = false;
                this.TasksPanel.Visible = false;
            }
        }

        #endregion

        #region "Tasks"

        private void IncompleteTasksOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Reload the iteration tasks.
            LoadTasks();
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

                List<Task> tasks = null;
                if (this.IncompleteTasksOnlyCheckBox.Checked)
                {
                    tasks = DBInterface.GetDeveloperIncompleteTasksByIteration(CurrentDeveloper.ID, iterationID);
                }
                else
                {
                    tasks = DBInterface.GetDeveloperTasksByIteration(CurrentDeveloper.ID, iterationID);
                }

                this.TasksDataGridView.DataSource = tasks;
                this.TasksPanel.Visible = true;

                // Hide columns user doesn't need to see
                this.TasksDataGridView.Columns["ID"].Visible = false;
                this.TasksDataGridView.Columns["ProjectID"].Visible = false;
                this.TasksDataGridView.Columns["Project"].Visible = false;
            }
            else
            {
                // When no selected row hide Tasks panel
                this.TasksPanel.Visible = false;
            }
        }

        #endregion
        
        #region "Reporting"

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
                MessageBox.Show("Couldn't find Report to print. Try again.", "Unable to Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
