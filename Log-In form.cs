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
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

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
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM StaffTable where UsernameStaff='" + UsernameTextBox.Text + "' AND PasswordStaff='" + PasswordTextBox.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
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
