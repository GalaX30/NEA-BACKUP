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
    public partial class View_Database_Menu_Residents : Form
    {
        public View_Database_Menu_Residents()
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

        private void View_Database_Menu_Residents_Load(object sender, EventArgs e)
        {
            fill_listbox("ResidentTable", "Firstname", "Lastname");
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            fill_listbox("ResidentTable", "Firstname", "Lastname");
        }

        private void idLbl_Click(object sender, EventArgs e)
        {

        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void lastnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floor3Lbl_Click(object sender, EventArgs e)
        {

        }

        private void lastnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void genderLbl_Click(object sender, EventArgs e)
        {

        }

        private void genderTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void medicheckTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void medicheckLbl_Click(object sender, EventArgs e)
        {

        }

        private void prescriptionidLbl_Click(object sender, EventArgs e)
        {

        }

        private void precriptionidTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floorLbl_Click(object sender, EventArgs e)
        {

        }

        private void floorTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu MainmenuInterface = new Main_Menu();
            MainmenuInterface.ShowDialog();
        }

        private void databaseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
