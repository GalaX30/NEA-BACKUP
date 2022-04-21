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
    public partial class View_Database_Menu : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public View_Database_Menu()
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

        }

        private void itemLbl_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl1_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl2_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl3_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl4_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl5_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl6_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl7_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl8_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl9_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl10_Click(object sender, EventArgs e)
        {

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

        private void residentBtn_Click(object sender, EventArgs e)
        {
            fill_listbox("ResidentTable", "Firstname", "Lastname");
            //databaseList.Items.Clear();
            //cmd = new SQLiteCommand();
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = "select * from ResidentTable";
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    databaseList.Items.Add(dr["Firstname"] + " " + dr["Lastname"]);
            //}
            //con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fill_listbox("StaffTable", "Firstname", null);
            databaseList.Items.Clear();
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from MedicationTable";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                databaseList.Items.Add(dr["Medication"]);
            }
            con.Close();
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
    }
}