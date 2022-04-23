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
    public partial class View_Database_Options_Menu : Form
    {
        public View_Database_Options_Menu()
        {
            InitializeComponent();
        }

        private void View_Database_Options_Menu_Load(object sender, EventArgs e)
        {

        }

        private void staffdataBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Database_Menu_Staff DatabaseWindowStaff = new View_Database_Menu_Staff();
            DatabaseWindowStaff.ShowDialog();
        }

        private void residentdataBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Database_Menu_Residents DatabaseWindowResidents = new View_Database_Menu_Residents();
            DatabaseWindowResidents.ShowDialog();
        }

        private void medicationdataBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Database_Menu_Medicine DatabaseWindowMedicine = new View_Database_Menu_Medicine();
            DatabaseWindowMedicine.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu MainmenuInterface = new Main_Menu();
            MainmenuInterface.ShowDialog();
        }
    }
}
