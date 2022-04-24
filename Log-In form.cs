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
        SQLiteConnection con, con2;
        SQLiteCommand cmd, cmd2;
        SQLiteDataReader dr, dr2;

        public LoginWindow()
        {
            InitializeComponent();
            con = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
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
            //string username = UsernameTextBox.Text;
            //string password = PasswordTextBox.Text;

            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM StaffTable where UsernameStaff='" + UsernameTextBox.Text + "' AND PasswordStaff='" + PasswordTextBox.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //cmd2 = new SQLiteCommand();
                //con2.Open();
                //cmd2.Connection = con2;
                //cmd2.CommandText = "SELECT PermissionLevel From StaffTable WHERE UsernameStaff ='" + UsernameTextBox.Text + "'";
                //dr2 = cmd2.ExecuteReader();

                //if (dr2.Read())
                //{
                //    bool isAdmin = (bool)cmd2.ExecuteScalar();
                //
                //    if (isAdmin)
                //    {
                //        PublicVariables.Permission = true;
                //    }

                //    else
                //    {
                //        PublicVariables.Permission = false;
                //    }
                //}

                //con2.Close();





                //string admin = dr["PermissionLevel"].ToString();

                //if (admin == "Admin")
                //{
                //    PublicVariables.Permission = true;
                //}

                //else
                //{
                //    PublicVariables.Permission = false;
                //}

                this.Hide();
                Main_Menu MainmenuInterface = new Main_Menu();
                MainmenuInterface.ShowDialog();
            }

            else
            {
                incorrectLbl.Show();
            }

            con.Close();
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
