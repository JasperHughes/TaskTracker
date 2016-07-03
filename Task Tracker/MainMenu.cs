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
    public partial class MainMenu : Form
    {
        DeveloperForm developerForm;
        TasksForm taskForm;
        IterationForm iterationForm;
        public MainMenu()
        {
            InitializeComponent();
            developerForm = new DeveloperForm();
            taskForm = new TasksForm();
            iterationForm = new IterationForm();

        }

        private void DevelopersButton_Click(object sender, EventArgs e)
        {
            // Load the Developer Form
            developerForm.Owner = this;
            Enabled = false;
            developerForm.Show();
        }

        private void TasksButton_Click(object sender, EventArgs e)
        {
            //Load Tasks form
            taskForm.Owner = this;
            Enabled = false;
            taskForm.Show();
        }

        private void IterationsButton_Click(object sender, EventArgs e)
        {
            //load iteration form
            iterationForm.Owner = this;
            Enabled = false;
            iterationForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the application
            Environment.Exit(0);
        }


    }
}
