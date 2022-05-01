using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace NEA
{
    
    public partial class View_Database_Menu_Staff : Form
    {
        public View_Database_Menu_Staff()
        {
            InitializeComponent();
        }

        void fill_listbox()
        {
            List<Staff> Slist = Staff.getallstaff();
            foreach (Staff s in Slist)
            {
                string First = s.getdisplaystaffFirstName();
                string Last = s.getdisplaystaffLastName();

                string entry = First.ToString() + " " + Last;
                databaseList.Items.Add(entry);
            }
        }

        private void View_Database_Menu_Load(object sender, EventArgs e)
        {
            fill_listbox();
        }

        private void databaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            databaseList.Items.Clear();
            fill_listbox();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu MainmenuInterface = new Main_Menu();
            MainmenuInterface.ShowDialog();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

            //-----------------------------------Sorting feature-----------------------------------
            bool sorted = false;

            if (sorted == true)
            {
                databaseList.Sorted = true;
                databaseList.Items.Clear();
                fill_listbox();
            }

            else
            {

            }
            //-------------------------------------------------------------------------------------
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string selected = databaseList.Items[databaseList.SelectedIndex].ToString();
            int selFirst = selected.IndexOf(" ");
            string staffFirst = selected.Substring(0, selFirst);
            string First = Convert.ToString(staffFirst);
            Staff s = new Staff(First);

            Database_Details_Menu DataLabels = new Database_Details_Menu(s);
            DataLabels.ShowDialog();
        }
    }
}