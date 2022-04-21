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
                this.Hide();
                Main_Menu MainmenuInterface = new Main_Menu();
                MainmenuInterface.ShowDialog();
            }

            else
            {
                incorrectLbl.Show();
            }
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
