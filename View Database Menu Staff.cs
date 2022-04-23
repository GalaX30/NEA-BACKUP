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
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public View_Database_Menu_Staff()
        {
            InitializeComponent();
        }

        void fill_listbox(string a, string b, string c)
        {
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;

            databaseList.Items.Clear();
            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select * from " + a;
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                databaseList.Items.Add(dataReader[b] + " " + dataReader[c]);
            }
            databaseConnection.Close();
        }

        private void View_Database_Menu_Load(object sender, EventArgs e)
        {
            fill_listbox("StaffTable", "Firstname", "Lastname");
        }

        private void databaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (databaseList.SelectedIndex == 0 || databaseList.SelectedIndex < databaseList.Items.Count - 1)
            //{
            //    databaseList.SelectedIndex = databaseList.SelectedIndex + 1;

            //    if (databaseList.SelectedItems.Contains("plant"))
            //    {
            //        infoLbl1.Text = "flowers";
            //    }

            //    else if (databaseList.SelectedItems.Contains("sugar"))
            //    {
            //        infoLbl1.Text = "Sweets";
            //    }

            //    else if (databaseList.SelectedItems.Contains("eyes"))
            //    {
            //        infoLbl1.Text = "face";
            //    }

            //}



            //foreach (con li in databaseList.Items)
            //{
            //    if (li.Selected)
            //    {
            //        infoLbl1.Text = li.Text.ToString();
            //    }
            //}
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            fill_listbox("StaffTable", "Firstname", "Lastname");
            //databaseList.Items.Clear();
            //cmd = new SQLiteCommand();
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = "select * from StaffTable";
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    databaseList.Items.Add(dr["Firstname"] + " " + dr["Lastname"]);
            //}
            //con.Close();
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
                databaseList.Refresh();
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
            //string selectedStaff = databaseList.Items[databaseList.SelectedIndex].ToString();
            ////int dashindex = selectedStaff.IndexOf(" - ");
            ////string Guestidstring = selectedStaff.Substring(0, dashindex);
            //int Guestid = Convert.ToInt32(selectedStaff);
            //Guest g = new Guest(Guestid);
            //thebp.Setaguest(g);
            //ManageGuest MG = new ManageGuest(thebp);
            //this.Hide();
            //MG.ShowDialog();
        }
    }
}