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
        SQLiteConnection databaseConn = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");

        public LoginWindow()
        {
            InitializeComponent();
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
            string query = "Select * from LoginTable where UsernameStaff = '" + UsernameTextBox.Text.Trim() + "' and PasswordStaff = '" + PasswordTextBox.Text.Trim() + "'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, databaseConn);
            DataTable data = new DataTable();

            adapter.Fill(data);

            if (data.Rows.Count == 1)
            {

                //SQLiteCommand checkPerm = new SQLiteCommand("SELECT * FROM LoginTable WHERE (PermissionLevel = @user)", databaseConn);
                //checkPerm.Parameters.AddWithValue("@user", txtBox_UserName.Text);
                //string staffPerm = (string)checkPerm.ExecuteScalar();

                //if (staffPerm == "Admin")
                //{
                //    PublicVariables.permission = true;
                //}

                //else
                //{
                //    PublicVariables.permission = false;
                //}

                ////Create a database reader
                //databaseConn.Open();

                ////create a new SqlParameter
                ////                        your username textbox ↓    
                //SQLiteParameter customParm = new SQLiteParameter("@username", UsernameTextBox.Text);

                ////                     your username column ↓    
                //string sql = "select * from LoginTable where UsernameStaff=@username";
                //SQLiteCommand customCmd = new SQLiteCommand(sql, databaseConn);
                //SQLiteDataReader dataRead = customCmd.ExecuteReader();

                //while (dataRead.Read())
                //{
                //    //reads permission column
                //    PublicVariables.permission = Convert.ToBoolean(dataRead["permission"]);
                //}

                this.Hide();
                Main_Menu MainmenuInterface = new Main_Menu();
                MainmenuInterface.ShowDialog();
                //string Username = UsernameTextBox.Text;
                //string Password = PasswordTextBox.Text;
            }

            else
            {
                incorrectLbl.Show();
            }

            ////create a SqlConnection


            ////Create a database reader
            //databaseConn.Open();

            ////create a new SqlParameter
            ////                        your username textbox ↓    
            //SQLiteParameter customParm = new SQLiteParameter("@username", UsernameTextBox.Text);

            ////                     your username column ↓    
            //string sql = "select * from LoginTable where UsernameStaff=@username";
            //SQLiteCommand customCmd = new SQLiteCommand(sql, databaseConn);
            //SQLiteDataReader dataRead = customCmd.ExecuteReader();

            //while (dataRead.Read())
            //{
            //    //reads permission column
            //    PublicVariables.permission = Convert.ToBoolean(dataRead["permission"]);
            //}

            databaseConn.Close();
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
