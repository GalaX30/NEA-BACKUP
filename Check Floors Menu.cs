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
    public partial class Check_Floors_Menu : Form
    {
        public Check_Floors_Menu()
        {
            InitializeComponent();
        }

        SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        SQLiteCommand customCommand;
        SQLiteDataReader dataReader;

        //void fill_listbox(string z, string a, string b, string c)
        //{
        //    SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        //    SQLiteCommand customCommand;
        //    SQLiteDataReader dataReader;

        //    databaseList.Items.Clear();
        //    customCommand = new SQLiteCommand();
        //    databaseConnection.Open();
        //    customCommand.Connection = databaseConnection;
        //    customCommand.CommandText = "select * from " + a;
        //    dataReader = customCommand.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        databaseList.Items.Add(dataReader[b] + " " + dataReader[c]);
        //    }
        //    databaseConnection.Close();
        //}

        private void Check_Floors_Menu_Load(object sender, EventArgs e)
        {
            floor1staffBox.Items.Clear();
            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select * from StaffTable WHERE FloorIDStaff = '1'";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                floor1staffBox.Items.Add(dataReader["Firstname"] + " " + dataReader["Lastname"]);
            }
            databaseConnection.Close();




            floor2staffBox.Items.Clear();
            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select * from StaffTable WHERE FloorIDStaff = '2'";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                floor2staffBox.Items.Add(dataReader["Firstname"] + " " + dataReader["Lastname"]);
            }
            databaseConnection.Close();




            floor3staffBox.Items.Clear();
            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select * from StaffTable WHERE FloorIDStaff = '3'";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                floor3staffBox.Items.Add(dataReader["Firstname"] + " " + dataReader["Lastname"]);
            }
            databaseConnection.Close();




            floor1residentBox.Items.Clear();
            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select * from ResidentTable WHERE FloorIDResident = '1'";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                floor1residentBox.Items.Add(dataReader["Firstname"] + " " + dataReader["Lastname"]);
            }
            databaseConnection.Close();




            floor2residentBox.Items.Clear();
            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select * from ResidentTable WHERE FloorIDResident = '2'";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                floor2residentBox.Items.Add(dataReader["Firstname"] + " " + dataReader["Lastname"]);
            }
            databaseConnection.Close();




            floor3residentBox.Items.Clear();
            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select * from ResidentTable WHERE FloorIDResident = '3'";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                floor3residentBox.Items.Add(dataReader["Firstname"] + " " + dataReader["Lastname"]);
            }
            databaseConnection.Close();
        }

        private void floor1staffLbl_Click(object sender, EventArgs e)
        {

        }

        private void floor1staffBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void floor1residentLbl_Click(object sender, EventArgs e)
        {

        }

        private void floor1residentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void floor2staffLbl_Click(object sender, EventArgs e)
        {

        }

        private void floor2staffBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void floor2residentLbl_Click(object sender, EventArgs e)
        {

        }

        private void floor2residentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void floor3staffLbl_Click(object sender, EventArgs e)
        {

        }

        private void floor3staffBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void floor3residentLbl_Click(object sender, EventArgs e)
        {

        }

        private void floor3residentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu MainmenuInterface = new Main_Menu();
            MainmenuInterface.ShowDialog();
        }
    }
}
