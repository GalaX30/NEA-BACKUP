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
            if (PublicVariables.Permission == true)
            {
                adminBtn.Visible = true;
            }

            else
            {
                adminBtn.Visible = false;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckDatabaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Database_Options_Menu DatabaseOptionsWindow = new View_Database_Options_Menu();
            DatabaseOptionsWindow.ShowDialog();
        }

        private void AutoAssignButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auto_Assign_Menu AutoAssignWindow = new Auto_Assign_Menu();
            AutoAssignWindow.ShowDialog();
        }

        private void SearchStaffButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manual_Assign_Menu ManualAssignWindow = new Manual_Assign_Menu();
            ManualAssignWindow.ShowDialog();
        }

        private void CheckFloorsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Check_Floors_Menu CheckFloorsWindow = new Check_Floors_Menu();
            CheckFloorsWindow.ShowDialog();
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
