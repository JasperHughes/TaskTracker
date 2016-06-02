using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Tracker
{
    public partial class MainMenu : Form
    {
        private ;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void DevelopersButton_Click(object sender, EventArgs e)
        {
            // Load the Developer Form in Modal 
            DeveloperForm developerForm = new DeveloperForm();
            developerForm.ShowDialog();
        }
    }
}
