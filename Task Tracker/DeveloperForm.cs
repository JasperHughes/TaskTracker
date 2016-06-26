﻿using System;
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
        // Only have 1 instance of the Edit Developer Form.
        private EditDeveloperForm editDeveloperForm;

        public DeveloperForm()
        {
            InitializeComponent();
            editDeveloperForm = new EditDeveloperForm(this);
        }

        private void DeveloperForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        public void UpdateForm()
        {
            LoadDevelopers();
        }

        private void LoadDevelopers()
        {
            DevelopersListView.Items.Clear();

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

        private void DevelopersListView_ItemActivate(object sender, EventArgs e)
        {
            // If there is a selected item show the Edit developer form for the selected developer.
            if (DevelopersListView.SelectedItems.Count > 0)
            {
                ListViewItem item = DevelopersListView.SelectedItems[0];
                int id = Int32.Parse(item.SubItems[0].Text);

                // Get the developer with this id
                Developer developer = DBInterface.GetDeveloper(id);

                // Load the Edit Developer Form
                LoadDeveloper(developer);
            }
        }

        private void DeveloperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel the closing of the form and hide form instead
            e.Cancel = true;
            HideForm();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            HideForm();
        }

        private void HideForm()
        {
            // Whent the form is hidden, also hide the Edit Developer form
            this.Hide();
            editDeveloperForm.Hide();
        }


        private void NewDeveloperButton_Click(object sender, EventArgs e)
        {
            // Load the Edit Developer form. Using a null current developer indicates
            // this is a new developer.
            LoadDeveloper(null);
        }

        private void LoadDeveloper(Developer developer)
        {
            // Load the developer in the EditDeveloperForm
            editDeveloperForm.CurrentDeveloper = developer;
            editDeveloperForm.Show();
            editDeveloperForm.Focus();

        }

        private void ActiveOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Reload developers.
            LoadDevelopers();
        }

    }
}
