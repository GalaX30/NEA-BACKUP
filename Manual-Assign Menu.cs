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

        public Manual_Assign_Menu()
        {
            InitializeComponent();
        }


        void fill_listbox()
        {
            staffList.Items.Clear();
            List<Staff> Rlist = Staff.getallstaff();
            foreach (Staff r in Rlist)
            {
                int ID = r.getdisplaystaffID();
                string First = r.getdisplaystaffFirstName();
                string Last = r.getdisplaystaffLastName();
                string Gender = r.getdisplaystaffGender();
                bool Floor1 = r.getdisplaystaffFloor1();
                bool Floor2 = r.getdisplaystaffFloor2();
                bool Floor3 = r.getdisplaystaffFloor3();
                string Present = Convert.ToString(r.getdisplaystaffPresent());
                if (Present == "True")
                {
                    Present = "Present";
                }

                else
                {
                    Present = "Absent";
                }

                string FloorID = "On floor: " + r.getdisplaystaffFloorID();

                string entry = First + " | " + Last + " | " + Gender + " | " + Present + " | " + FloorID;
                staffList.Items.Add(entry);
            }
        }





        public void Update()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            string selected = staffList.Items[staffList.SelectedIndex].ToString();
            int selectedFirst = selected.IndexOf(" ");
            string staffFirst = selected.Substring(0, selectedFirst);
            string FirstName = Convert.ToString(staffFirst);

            using var cmd = new SQLiteCommand(sqlite_conn);
            cmd.CommandText = "UPDATE StaffTable SET FloorIDStaff = @id WHERE FirstName = '" + FirstName + "'";

            cmd.Parameters.AddWithValue("@id", assignTxt.Text);


            cmd.Prepare();

            cmd.ExecuteNonQuery();


            sqlite_conn.Close();

        }






        public static SQLiteConnection Connect()
        {
            SQLiteConnection sqlite_conn;


            var DBconnection = "Data Source = StaffDatabaseComplete.db";

            sqlite_conn = new SQLiteConnection(DBconnection);
            return sqlite_conn;
        }

        public static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn = Connect();
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }





        private void Manual_Assign_Menu_Load(object sender, EventArgs e)
        {
            fill_listbox();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            fill_listbox();
        }



        private void staffList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = staffList.Items[staffList.SelectedIndex].ToString();
            int selectedFirst = selected.IndexOf(" ");
            string staffFirst = selected.Substring(0, selectedFirst);
            string FirstName = Convert.ToString(staffFirst);

            Staff current = new Staff(FirstName);

            idLbl.Text = "ID: " + current.getdisplaystaffID();
            idLbl.Update();
            firstnameLbl.Text = "Firstname: " + current.getdisplaystaffFirstName();
            firstnameLbl.Update();
            lastnameLbl.Text = "Lastname: " + current.getdisplaystaffLastName();
            lastnameLbl.Update();
            genderLbl.Text = "Gender: " + current.getdisplaystaffGender();
            genderLbl.Update();
            floor1Lbl.Text = "Qualified for floor 1: " + current.getdisplaystaffFloor1();
            floor1Lbl.Update();
            floor2Lbl.Text = "Qualified for floor 2: " + current.getdisplaystaffFloor2();
            floor2Lbl.Update();
            floor3Lbl.Text = "Qualified for floor 3: " + current.getdisplaystaffFloor3();
            floor3Lbl.Update();
            presentLbl.Text = "Currently present: " + current.getdisplaystaffPresent();
            presentLbl.Update();
            assignTxt.Text = current.getdisplaystaffFloorID();
            assignTxt.Update();
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


            Update();



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
