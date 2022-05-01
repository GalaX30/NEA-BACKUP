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
    public partial class LoginWindow : Form
    {
        //SQLiteConnection databaseConn = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        SQLiteConnection conn, conn2;
        SQLiteCommand command, command2;
        SQLiteDataReader dataread, dataread2;


        public LoginWindow()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            conn2 = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Staff.getstafflogininfo(UsernameTextBox.Text);

            //if (UsernameTextBox.Text == Staff.getdisplaystaffUsername() && PasswordTextBox.Text == Staff.getdisplaystaffPassword())
            //{
            //    if (Staff.getdisplaystaffPermission() == "Admin")
            //    {
            //        PublicVariables.Permission = true;
            //        Main_Menu MainmenuInterface = new Main_Menu();
            //        MainmenuInterface.ShowDialog();
            //    }

            //    else
            //    {
            //        PublicVariables.Permission = false;
            //        Main_Menu MainmenuInterface = new Main_Menu();
            //        MainmenuInterface.ShowDialog();
            //    }
            //}

            //else
            //{
            //    incorrectLbl.Show();
            //}


            command = new SQLiteCommand();
            conn.Open();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM StaffTable where UsernameStaff = '" + UsernameTextBox.Text + "' AND PasswordStaff = '" + PasswordTextBox.Text + "'";
            dataread = command.ExecuteReader();

            if (dataread.Read())
            {
                command2 = new SQLiteCommand();
                conn2.Open();
                command2.Connection = conn2;
                command2.CommandText = "SELECT UsernameStaff, PasswordStaff, PermissionLevel FROM StaffTable where UsernameStaff = '" + UsernameTextBox.Text + "' AND PasswordStaff = '" + PasswordTextBox.Text + "' AND PermissionLevel = 'Admin'";
                dataread2 = command2.ExecuteReader();

                if (dataread2.Read())
                {
                    PublicVariables.Permission = true;
                }

                else
                {
                    PublicVariables.Permission = false;
                }

                this.Hide();
                Main_Menu MainmenuInterface = new Main_Menu();
                MainmenuInterface.ShowDialog();

                conn2.Close();
            }

            else
            {
                incorrectLbl.Show();
            }

            conn.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void incorrectLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
