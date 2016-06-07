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
using Task_Tracker.DAO.Tables;

namespace Task_Tracker
{
    public partial class DeveloperForm : Form
    {
        public DeveloperForm()
        {
            InitializeComponent();
        }

        private void DeveloperForm_Load(object sender, EventArgs e)
        {
            LoadDevelopers();
            UpdateAddEditLabel();
        }


        private void LoadDevelopers()
        {
            DevelopersListView.Items.Clear();

            // Load all the developers into the List View
            List<Developer> developers;

            try
            {
                developers = (List<Developer>)DBInterface.SelectAll(DBInterface.Table.DEVELOPERS);
                if (developers.Count > 0)
                {
                    int i = 0;
                    foreach (Developer developer in developers)
                    {
                        DevelopersListView.Items.Add(developer.ID.ToString());
                        DevelopersListView.Items[i].SubItems.Add(developer.GivenNames);
                        DevelopersListView.Items[i].SubItems.Add(developer.FamilyName);
                        DevelopersListView.Items[i].SubItems.Add(developer.Email);
                        DevelopersListView.Items[i].SubItems.Add(developer.ContactNumber);
                        DevelopersListView.Items[i].SubItems.Add(developer.Active ? "Yes" : "No");
                        DevelopersListView.Items[i].SubItems.Add(developer.Notes);

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
            // TODO Add validation to check all values entered

            Developer developer = new Developer();
            developer.FamilyName = ReplaceEmptyStringWithNull(FamilyNameTextBox.Text);
            developer.GivenNames = ReplaceEmptyStringWithNull(GivenNamesTextBox.Text);
            developer.Email = ReplaceEmptyStringWithNull(EmailTextBox.Text);
            developer.ContactNumber = ReplaceEmptyStringWithNull(ContactNumberTextBox.Text);
            developer.Active = ActiveCheckbox.Checked;
            developer.Notes = ReplaceEmptyStringWithNull(NotesTextBox.Text);

            try
            {
                if (IDTextBox.Text == "")
                {
                    DBInterface.Add(developer);
                }
                else
                {
                    developer.ID = Int32.Parse(IDTextBox.Text);
                    DBInterface.Update(developer);
                }
            }
            catch (Exception ex)
            {
                // TODO What should really happen on error?
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            // Reset edit fields
            FamilyNameTextBox.Text = "";
            GivenNamesTextBox.Text = "";
            EmailTextBox.Text = "";
            ContactNumberTextBox.Text = "";
            ActiveCheckbox.Checked = true;
            NotesTextBox.Text = "";
            IDTextBox.Text = "";

            LoadDevelopers();
            UpdateAddEditLabel();

        }

        private void DevelopersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DevelopersListView.SelectedItems.Count > 0)
            {
                // Load Values into Editable fields
                ListViewItem item = DevelopersListView.SelectedItems[0];
                int i = 0;
                
                IDTextBox.Text = item.SubItems[i++].Text;
                GivenNamesTextBox.Text = item.SubItems[i++].Text;
                FamilyNameTextBox.Text = item.SubItems[i++].Text;
                EmailTextBox.Text = item.SubItems[i++].Text;
                ContactNumberTextBox.Text = item.SubItems[i++].Text;
                ActiveCheckbox.Checked = item.SubItems[i++].Text == "Yes";
                NotesTextBox.Text = item.SubItems[i++].Text;

                LoadDevelopers();
                UpdateAddEditLabel();
            }
        }

        private void UpdateAddEditLabel()
        {
            if (IDTextBox.Text == "")
            {
                AddEditLabel.Text = "Add New Developer";
            }
            else
            {
                AddEditLabel.Text = "Editing Developer " + IDTextBox.Text;
            }
        }

        
        // Replace empty string with null, otherwise leave it as is.
        private string ReplaceEmptyStringWithNull(string value)
        {
            return value.Length == 0 ? null : value;
        }
    }
}
