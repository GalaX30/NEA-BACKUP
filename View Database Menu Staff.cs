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
        SQLiteConnection con = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");

        public View_Database_Menu_Staff(/*Staff staff*/)
        {
            InitializeComponent();
        }

        void fill_listbox()
        {
            List<Staff> Slist = Staff.getallstaff();
            foreach (Staff s in Slist)
            {
                int ID = s.getdisplaystaffID();
                string First = s.getdisplaystaffFirstName();
                string Last = s.getdisplaystaffLastName();

                string entry = ID.ToString() + " " + First + " " + Last;
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

        private void idTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLbl_Click(object sender, EventArgs e)
        {

        }

        private void idLbl_Click_1(object sender, EventArgs e)
        {

        }

        private void idTxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void firstnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void firstnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void lastnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderLbl_Click(object sender, EventArgs e)
        {

        }

        private void genderTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void presentLbl_Click(object sender, EventArgs e)
        {

        }

        private void presentTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floor1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void floor1Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floor2Lbl_Click(object sender, EventArgs e)
        {

        }

        private void floor2Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floor3Lbl_Click(object sender, EventArgs e)
        {

        }

        private void floor3Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void onfloorLbl_Click(object sender, EventArgs e)
        {

        }

        private void onfloorTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string selected = databaseList.Items[databaseList.SelectedIndex].ToString();
            int selID = selected.IndexOf(" ");
            string staffid = selected.Substring(0, selID);
            int ID = Convert.ToInt32(staffid);
            Staff s = new Staff(ID);

            Database_Details_Menu DataLabels = new Database_Details_Menu(s);
            DataLabels.ShowDialog();
        }
    }
}