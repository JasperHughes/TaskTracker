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
                ActiveCheckbox.Checked = true;
                NotesTextBox.Text = "";

                AddEditLabel.Text = "Add Developer";
            }
            else
            {
                GivenNamesTextBox.Text = CurrentDeveloper.GivenNames;
                FamilyNameTextBox.Text = CurrentDeveloper.FamilyName;
                EmailTextBox.Text = CurrentDeveloper.Email;
                ContactNumberTextBox.Text = CurrentDeveloper.ContactNumber;
                ActiveCheckbox.Checked = CurrentDeveloper.Active;
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
            }
            else
            {
                // Hide the view of iterations, new developers won't have any
                this.IterationsDataGridView.Visible = false;
            }
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            // If any of the text boxes are changed check which actions are available.
            CheckEnableActions();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Move all the details from the textboxes to Developer object
            Developer developer = new Developer();
            developer.FamilyName = FamilyNameTextBox.Text;
            developer.GivenNames = GivenNamesTextBox.Text;
            developer.Email = EmailTextBox.Text;
            developer.ContactNumber = ContactNumberTextBox.Text;
            developer.Active = ActiveCheckbox.Checked;
            developer.Notes = NotesTextBox.Text;

            try
            {
                // Save the developer to the database.
                if (CurrentDeveloper == null)
                {
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

            // Hide form after saving developer
            HideForm();
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
            // TODO Delete functionality
            // TODO Cannot delete a developer that is assigned to an incomplete task
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
            bool enableDelete = (currentDeveloper != null);
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

        }

        private void IterationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (view.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Report button clicked
                int iteratorID = (int)view.Rows[e.RowIndex].Cells["IterationID"].Value;

                MessageBox.Show("Hello " + iteratorID);

                // TODO Print report
            }
        }
    }
}
