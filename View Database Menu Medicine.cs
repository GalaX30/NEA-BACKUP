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
    public partial class View_Database_Menu_Medicine : Form
    {
        public View_Database_Menu_Medicine()
        {
            InitializeComponent();
        }
        void fill_listbox()
        {
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;

            databaseList.Items.Clear();
            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select * from MedicationTable";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                databaseList.Items.Add(dataReader["Medication"]);
            }
            databaseConnection.Close();
        }

        private void View_Database_Menu_Medicine_Load(object sender, EventArgs e)
        {
            fill_listbox();
        }

        private void idLbl_Click(object sender, EventArgs e)
        {

        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void medicationLbl_Click(object sender, EventArgs e)
        {

        }

        private void medicationTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ammountLbl_Click(object sender, EventArgs e)
        {

        }

        private void ammountTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void databaseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            fill_listbox();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
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
