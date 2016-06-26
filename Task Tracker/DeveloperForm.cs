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
    public partial class DeveloperForm : Form
    {
        #region "Initialise"

        // Only have 1 instance of the Edit Developer Form.
        private EditDeveloperForm editDeveloperForm;

        public DeveloperForm()
        {
            InitializeComponent();
            editDeveloperForm = new EditDeveloperForm(this);
        }

        #endregion

        #region "Form"

        private void DeveloperForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        public void UpdateForm()
        {
            LoadDevelopers();
        }

        private void DeveloperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel the closing of the form and hide form instead
            e.Cancel = true;
            HideForm();
        }

        private void HideForm()
        {
            // Whent the form is hidden, also hide the Edit Developer form
            this.Hide();
            editDeveloperForm.Hide();
        }

        #endregion

        #region "Developer List"

        private void ActiveOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Reload developers.
            LoadDevelopers();
        }

        private void LoadDevelopers()
        {

            // Load all the developers into the List View
            List<Developer> developers;

            try
            {
                // Get list of developers, either all or only active if the
                // Active Only checkbox is on
                if (this.ActiveOnlyCheckBox.Checked)
                {
                    developers = DBInterface.GetActiveDevelopers();
                }
                else
                {
                    developers = DBInterface.GetDevelopers();
                }

                this.DevelopersDataGridView.DataSource = developers;

                // Hide ID
                this.DevelopersDataGridView.Columns["ID"].Visible = false;

                // Control the order of items
                int displayIndex = 0;
                this.DevelopersDataGridView.Columns["GivenNames"].DisplayIndex = displayIndex++;
                this.DevelopersDataGridView.Columns["FamilyName"].DisplayIndex = displayIndex++;
                this.DevelopersDataGridView.Columns["Email"].DisplayIndex = displayIndex++;
                this.DevelopersDataGridView.Columns["ContactNumber"].DisplayIndex = displayIndex++;
                this.DevelopersDataGridView.Columns["ActiveString"].DisplayIndex = displayIndex++;
                this.DevelopersDataGridView.Columns["Notes"].DisplayIndex = displayIndex++;


                // Change header text for these 2 word fields
                this.DevelopersDataGridView.Columns["FamilyName"].HeaderText = "Family Name";
                this.DevelopersDataGridView.Columns["GivenNames"].HeaderText = "Given Names";
                this.DevelopersDataGridView.Columns["ContactNumber"].HeaderText = "Contact Number";

                // Use ActiveString instead of Active which creates checkbox
                this.DevelopersDataGridView.Columns["Active"].Visible = false;
                this.DevelopersDataGridView.Columns["ActiveString"].HeaderText = "Active";
            }
            catch (Exception ex)
            {
                // TODO What should really happen on error?
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        
        private void DevelopersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Load selected developer. If header clicked do nothing.
            if (e.RowIndex >= 0)
            {
                // Get the selected developer's id
                int id = (int)DevelopersDataGridView.CurrentRow.Cells["ID"].Value;

                // Get the developer with this id
                Developer developer = DBInterface.GetDeveloper(id);

                // Load the Edit Developer Form
                LoadDeveloper(developer);
            }
        }

        private void LoadDeveloper(Developer developer)
        {
            // Load the developer in the EditDeveloperForm
            editDeveloperForm.CurrentDeveloper = developer;
            editDeveloperForm.Show();
            editDeveloperForm.Focus();

        }

        #endregion

        #region "Button Events"

        private void CloseButton_Click(object sender, EventArgs e)
        {
            HideForm();
        }
        
        private void NewDeveloperButton_Click(object sender, EventArgs e)
        {
            // Load the Edit Developer form. Using a null current developer indicates
            // this is a new developer.
            LoadDeveloper(null);
        }

        #endregion


    }
}
