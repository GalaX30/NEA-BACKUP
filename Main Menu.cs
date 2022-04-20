using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckDatabaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Database_Menu DatabaseWindow = new View_Database_Menu();
            DatabaseWindow.ShowDialog();
        }

        private void AutoAssignButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auto_Assign_Menu AutoAssignWindow = new Auto_Assign_Menu();
            AutoAssignWindow.ShowDialog();
        }

        private void SearchStaffButton_Click(object sender, EventArgs e)
        {

        }

        private void CheckFloorsButton_Click(object sender, EventArgs e)
        {

        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void SignatureLogo_Click(object sender, EventArgs e)
        {

        }

        private void AdminSettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
