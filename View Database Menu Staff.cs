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
    
    public partial class View_Database_Menu_Staff : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        //Staff SelectedStaff;
        public View_Database_Menu_Staff(/*Staff staff*/)
        {
            //SelectedStaff = new Staff(staff);
            InitializeComponent();
        }

        //public string ID;
        //public string displayID;
        //public string displaystaffID;
        //public string displaystaffFirstname;
        //public string displaystaffLastname;
        //public string displaystaffGender;
        //public string displaystaffFloor1;
        //public string displaystaffFloor2;
        //public string displaystaffFloor3;
        //public string displaystaffPresent;
        //public string displaystaffUsername;
        //public string displaystaffPassword;
        //public string displaystaffPermission;
        //public string displaystaffFloorID;

        //void getValuesStaff()
        //{
        //    SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        //    SQLiteCommand customCommand;
        //    SQLiteDataReader dataReader;

        //    customCommand = new SQLiteCommand();
        //    databaseConnection.Open();
        //    customCommand.Connection = databaseConnection;
        //    customCommand.CommandText = "select * from StaffTable WHERE FirstName = '" + a + "'";
        //    dataReader = customCommand.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        displaystaffID = (dataReader["StaffID"]).ToString();
        //        displaystaffFirstname = (dataReader["FirstName"]).ToString();
        //        displaystaffLastname = (dataReader["LastName"]).ToString();
        //        displaystaffGender = (dataReader["Gender"]).ToString();
        //        displaystaffFloor1 = (dataReader["QualifiedForFloor1"]).ToString();
        //        displaystaffFloor2 = (dataReader["QualifiedForFloor2"]).ToString();
        //        displaystaffFloor3 = (dataReader["QualifiedForFloor3"]).ToString();
        //        displaystaffPresent = (dataReader["CurrentlyPresent"]).ToString();
        //        displaystaffUsername = (dataReader["UsernameStaff"]).ToString();
        //        displaystaffPassword = (dataReader["PasswordStaff"]).ToString();
        //        displaystaffPermission = (dataReader["PermissionLevel"]).ToString();

        //        if (displaystaffPermission == "1")
        //        {
        //            displaystaffPermission = "Admin";
        //        }

        //        else
        //        {
        //            displaystaffPermission = "Regular";
        //        }

        //        displaystaffFloorID = (dataReader["FloorIDStaff"]).ToString();
        //    }

        //    databaseConnection.Close();
        //}

        //void fill_textbox()
        //{
        //    SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        //    SQLiteCommand customCommand;
        //    SQLiteDataReader dataReader;

        //    customCommand = new SQLiteCommand();
        //    databaseConnection.Open();
        //    customCommand.Connection = databaseConnection;
        //    customCommand.CommandText = "select * from StaffTable WHERE StaffFirstname ='" + fill_listbox(b) + "'";
        //    dataReader = customCommand.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        displayID = (dataReader["StaffID"]).ToString();
        //        idTxt.Text = displayID;
        //    }

        //    databaseConnection.Close();
        //}

        //public static displayStaffInfo (GetDataStaff, string firstname)
        //{
        //    SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        //    SQLiteCommand customCommand;
        //    SQLiteDataReader dataReader;
        //    List<GetDataStaff> StaffInfo = new List<GetDataStaff>();

        //    customCommand = new SQLiteCommand();
        //    databaseConnection.Open();
        //    customCommand.Connection = databaseConnection;
        //    customCommand.CommandText = "select * from StaffTable WHERE FirstName ='" + databaseList.SelectedIndex.ToString() + "'";
        //    dataReader = customCommand.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        GetDataStaff SelectedStaff = new GetDataStaff();

        //        //displayValues.displaystaffID = dataReader.GetString(dataReader.GetOrdinal("StaffID"));
        //        SelectedStaff._displaystaffID = dataReader["StaffID"];
        //        SelectedStaff.displaystaffFirstname = dataReader["FirstName"];
        //        SelectedStaff.displaystaffLastname = dataReader["LastName"];
        //        SelectedStaff.displaystaffGender = dataReader["Gender"];
        //        SelectedStaff.displaystaffFloor1 = dataReader["QualifiedForFloor1"];
        //        SelectedStaff.displaystaffFloor2 = dataReader["QualifiedForFloor2"];
        //        SelectedStaff.displaystaffFloor3 = dataReader["QualifiedForFloor3"];
        //        SelectedStaff.displaystaffPresent = dataReader["CurrentlyPresent"];
        //        SelectedStaff.displaystaffUsername = dataReader["UsernameStaff"];
        //        SelectedStaff.displaystaffPassword = dataReader["PasswordStaff"];
        //        SelectedStaff.displaystaffPermission = dataReader["PermissionLevel"];

        //        if (SelectedStaff.displaystaffPermission == 1)
        //        {
        //            SelectedStaff.displaystaffPermission = "Admin";
        //        }

        //        else
        //        {
        //            SelectedStaff.displaystaffPermission = "Regular";
        //        }

        //        SelectedStaff.displaystaffFloorID = dataReader["FloorIDStaff"];
        //    }

        //    databaseConnection.Close();
        //}


        void fill_listbox2(string a, string b)
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
                databaseList.Items.Add(dataReader[b]);
            }

            databaseConnection.Close();
        }

        //void fill_listbox(string a, string b, string c)
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

        private void View_Database_Menu_Load(object sender, EventArgs e)
        {
            //fill_listbox("StaffTable", "Firstname", "Lastname");

            fill_listbox2("StaffTable", "Firstname");
        }

        private void databaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ID = databaseList.Items[databaseList.SelectedIndex].ToString();

            //SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            //SQLiteCommand customCommand;
            //SQLiteDataReader dataReader;

            //customCommand = new SQLiteCommand();
            //databaseConnection.Open();
            //customCommand.Connection = databaseConnection;
            //customCommand.CommandText = "select * from StaffTable WHERE StaffID = '" + ID + "'";
            //dataReader = customCommand.ExecuteReader();

            //while (dataReader.Read())
            //{
            //    idLbl.Text = ("ID: " + dataReader[ID]);
            //}
            //idLbl.Visible = false;
            //idLbl.Visible = true;
            
            //databaseConnection.Close();





            //if (databaseList.SelectedIndex == 0 || databaseList.SelectedIndex < databaseList.Items.Count - 1)
            //{
            //    databaseList.SelectedIndex = databaseList.SelectedIndex + 1;

            //    if (databaseList.SelectedItems.Contains("plant"))
            //    {
            //        infoLbl1.Text = "flowers";
            //    }

            //    else if (databaseList.SelectedItems.Contains("sugar"))
            //    {
            //        infoLbl1.Text = "Sweets";
            //    }

            //    else if (databaseList.SelectedItems.Contains("eyes"))
            //    {
            //        infoLbl1.Text = "face";
            //    }

            //}



            //foreach (con li in databaseList.Items)
            //{
            //    if (li.Selected)
            //    {
            //        infoLbl1.Text = li.Text.ToString();
            //    }
            //}
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            //fill_listbox("StaffTable", "Firstname", "Lastname");

            fill_listbox2("StaffTable", "Firstname");
            //databaseList.Items.Clear();
            //cmd = new SQLiteCommand();
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = "select * from StaffTable";
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    databaseList.Items.Add(dr["Firstname"] + " " + dr["Lastname"]);
            //}
            //con.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu MainmenuInterface = new Main_Menu();
            MainmenuInterface.ShowDialog();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

            //-----------------------------------Sorting feature-----------------------------------
            bool sorted = false;

            if (sorted == true)
            {
                databaseList.Sorted = true;
                databaseList.Refresh();
            }

            else
            {

            }
            //-------------------------------------------------------------------------------------
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLbl_Click(object sender, EventArgs e)
        {

        }

        private void idLbl_Click_1(object sender, EventArgs e)
        {

        }

        private void idTxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void firstnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void firstnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void lastnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderLbl_Click(object sender, EventArgs e)
        {

        }

        private void genderTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void presentLbl_Click(object sender, EventArgs e)
        {

        }

        private void presentTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floor1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void floor1Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floor2Lbl_Click(object sender, EventArgs e)
        {

        }

        private void floor2Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floor3Lbl_Click(object sender, EventArgs e)
        {

        }

        private void floor3Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void onfloorLbl_Click(object sender, EventArgs e)
        {

        }

        private void onfloorTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff = Staff.displayStaffInfo(databaseList.GetItemText(databaseList.SelectedIndex.ToString()));

            Database_Details_Menu DataLabels = new Database_Details_Menu(staff);
            DataLabels.ShowDialog();







            //SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            //SQLiteCommand customCommand;
            //SQLiteDataReader dataReader;

            //customCommand = new SQLiteCommand();
            //databaseConnection.Open();
            //customCommand.Connection = databaseConnection;
            //customCommand.CommandText = "select * from StaffTable WHERE StaffID = '" + ID + "'";
            //dataReader = customCommand.ExecuteReader();

            //while (dataReader.Read())
            //{
            //    idLbl.Text = ("ID: " + dataReader[ID]);
            //}
            //idLbl.Visible = false;
            //idLbl.Visible = true;

            //databaseConnection.Close();




            //fill_textbox();

            //SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            //SQLiteCommand customCommand;
            //SQLiteDataReader dataReader;

            //idTxt.Text = String.Empty;
            //customCommand = new SQLiteCommand();
            //databaseConnection.Open();
            //customCommand.Connection = databaseConnection;
            //customCommand.CommandText = "select * from StaffTable WHERE FirstName = '" + displaystaffID + "'";
            //dataReader = customCommand.ExecuteReader();

            //while (dataReader.Read())
            //{

            //    idTxt.Text = ("ID: " + dataReader["StaffID"]);
            //}

            //databaseConnection.Close();






            //////////////SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            //////////////SQLiteCommand customCommand;
            //////////////SQLiteDataReader dataReader;

            //////////////customCommand = new SQLiteCommand();
            //////////////databaseConnection.Open();
            //////////////customCommand.Connection = databaseConnection;
            //////////////customCommand.CommandText = "select * from StaffTable WHERE FirstName = '" + databaseList.SelectedIndex.ToString() + "'";
            //////////////dataReader = customCommand.ExecuteReader();

            //////////////while (dataReader.Read())
            //////////////{
            //////////////    displayValues.displayID = (dataReader["StaffID"]).ToString();
            //////////////    displayValues.displaystaffFirstname = (dataReader["FirstName"]).ToString();
            //////////////    displayValues.displaystaffLastname = (dataReader["LastName"]).ToString();
            //////////////    displayValues.displaystaffGender = (dataReader["Gender"]).ToString();
            //////////////    displayValues.displaystaffFloor1 = (dataReader["QualifiedForFloor1"]).ToString();
            //////////////    displayValues.displaystaffFloor2 = (dataReader["QualifiedForFloor2"]).ToString();
            //////////////    displayValues.displaystaffFloor3 = (dataReader["QualifiedForFloor3"]).ToString();
            //////////////    displayValues.displaystaffPresent = (dataReader["CurrentlyPresent"]).ToString();
            //////////////    displayValues.displaystaffUsername = (dataReader["UsernameStaff"]).ToString();
            //////////////    displayValues.displaystaffPassword = (dataReader["PasswordStaff"]).ToString();
            //////////////    displayValues.displaystaffPermission = (dataReader["PermissionLevel"]).ToString();

            //////////////    if (displayValues.displaystaffPermission == "1")
            //////////////    {
            //////////////        displayValues.displaystaffPermission = "Admin";
            //////////////    }

            //////////////    else
            //////////////    {
            //////////////        displayValues.displaystaffPermission = "Regular";
            //////////////    }

            //////////////    displayValues.displaystaffFloorID = (dataReader["FloorIDStaff"]).ToString();
            //////////////}
            ////////////////this.idTxt.Visible = true;
            ////////////////this.idLbl.Text += displaystaffID;
            //////////////databaseConnection.Close();
            ////////////////idTxt.Text = (displaystaffID);




            //View_Database_Menu_Staff.DoEvents();

            //string selectedStaff = databaseList.Items[databaseList.SelectedIndex].ToString();
            ////int dashindex = selectedStaff.IndexOf(" - ");
            ////string Guestidstring = selectedStaff.Substring(0, dashindex);
            //int Guestid = Convert.ToInt32(selectedStaff);
            //Guest g = new Guest(Guestid);
            //thebp.Setaguest(g);
            //ManageGuest MG = new ManageGuest(thebp);
            //this.Hide();
            //MG.ShowDialog();
        }
    }
}