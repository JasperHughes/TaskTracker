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
            developerForm.Show();
        }

        private void graphtest_Click(object sender, EventArgs e)
        {
            //testing graph
            IterationGraph ig = new IterationGraph();
            ig.iterationID = 2;
            ig.Show();
        }

        private void TasksButton_Click(object sender, EventArgs e)
        {
            //Load Tasks form
            taskForm.Show();
    

        }

        private void IterationsButton_Click(object sender, EventArgs e)
        {

            iterationForm.Show();
        }

    }
}
