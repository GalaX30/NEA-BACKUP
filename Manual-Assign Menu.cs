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
    public partial class Manual_Assign_Menu : Form
    {
        SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        SQLiteCommand customCommand;
        SQLiteDataReader dataReader;
        public Manual_Assign_Menu()
        {
            InitializeComponent();
            //fill_listbox();
        }

        void fill_listbox(string a, string b, string c)
        {
            staffList.Items.Clear();
            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select * from " + a;
            dataReader = customCommand.ExecuteReader();
            while (dataReader.Read())
            {
                staffList.Items.Add(dataReader[b] + " " + dataReader[c]);
            }
            databaseConnection.Close();
        }

        //void fill_listbox()
        //{
        //    string constring = "Data Source = StaffDatabaseComplete.db";
        //    string query = "select * from StaffTable where name ='" + staffList.Text + "' ;";
        //    SQLiteConnection conDataBase = new SQLiteConnection(constring);
        //    SQLiteCommand cmdDataBase = new SQLiteCommand(query, conDataBase);
        //    SQLiteDataReader myReader;

        //    try
        //    {
        //        conDataBase.Open();
        //        myReader = cmdDataBase.ExecuteReader();

        //        while (myReader.Read())
        //        {
        //            string sName = myReader.GetString("Firstname");
        //            staffList.Items.Add(sName);
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void Manual_Assign_Menu_Load(object sender, EventArgs e)
        {

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            fill_listbox("StaffTable", "FirstName", "LastName");
        }

        private void staffList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }

        private void idLbl_Click(object sender, EventArgs e)
        {

        }

        private void firstnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void lastnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void genderLbl_Click(object sender, EventArgs e)
        {

        }

        private void floor1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void floor2Lbl_Click(object sender, EventArgs e)
        {

        }

        private void floor3Lbl_Click(object sender, EventArgs e)
        {

        }

        private void presentLbl_Click(object sender, EventArgs e)
        {

        }

        private void floorLbl_Click(object sender, EventArgs e)
        {

        }

        private void assignTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void assignBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchLbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void filterBtn_Click(object sender, EventArgs e)
        {

        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu MainmenuInterface = new Main_Menu();
            MainmenuInterface.ShowDialog();
        }

        
    }
}
