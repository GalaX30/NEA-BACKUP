using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace NEA
{
    public class Medication
    {

        public Medication()
        {

        }

        public Medication(string MedicationName)
        {
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;
            List<Medication> MedicationInfo = new List<Medication>();

            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select MedicationID, Medication, MedicationAmount from MedicationTable WHERE Medication ='" + MedicationName + "'";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                this._displaymedicationID = Convert.ToInt32(dataReader["MedicationID"]);
                this._displayMedication = Convert.ToString(dataReader["Medication"]);
                this._displaymedicationAmount = Convert.ToString(dataReader["MedicationAmount"]);
            }
            databaseConnection.Close();
        }

        //public static Medication displayMedicationInfo()
        //{
        //    SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        //    SQLiteCommand customCommand;
        //    SQLiteDataReader dataReader;
        //    List<Medication> MedicationInfo = new List<Medication>();

        //    customCommand = new SQLiteCommand();
        //    databaseConnection.Open();
        //    customCommand.Connection = databaseConnection;
        //    customCommand.CommandText = "select * from MedicationTable";
        //    dataReader = customCommand.ExecuteReader();

        //    Medication SelectedMedication = new Medication();

        //    while (dataReader.Read())
        //    {
        //        SelectedMedication._displaymedicationID = Convert.ToInt32(dataReader["MedicationID"]);
        //        SelectedMedication._displaymedicationName = Convert.ToString(dataReader["MedicationName"]);
        //        SelectedMedication._displaymedicationAmount = Convert.ToInt32(dataReader["MedicationAmount"]);
        //    }
        //    databaseConnection.Close();
        //    return SelectedMedication;
        //}


        private int _displaymedicationID;
        public int getdisplaymedicationID()
        {
            return _displaymedicationID;
        }
        public void setdisplaymedicationID(int displaymedicationID)
        {
            _displaymedicationID = displaymedicationID;
        }
        //---------------------------------------------------------------------------------
        private string _displayMedication;
        public string getdisplayMedication()
        {
            return _displayMedication;
        }
        public void setdisplayMedication(string displayMedication)
        {
            _displayMedication = displayMedication;
        }
        //---------------------------------------------------------------------------------
        private string _displaymedicationAmount;
        public string getdisplaymedicationAmount()
        {
            return _displaymedicationAmount;
        }
        public void setdisplaymedicationAmount(string displaymedicationAmount)
        {
            _displaymedicationAmount = displaymedicationAmount;
        }


        public static List<Medication> getallmedication()
        {
            List<Medication> Medicationlist = new List<Medication>();
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;
            List<Medication> MedicationInfo = new List<Medication>();

            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select MedicationID, Medication, MedicationAmount from MedicationTable";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Medication m = new Medication();

                m._displaymedicationID = Convert.ToInt32(dataReader["MedicationID"]);
                m._displayMedication = Convert.ToString(dataReader["Medication"]);
                m._displaymedicationAmount = Convert.ToString(dataReader["MedicationAmount"]);

                Medicationlist.Add(m);
            }
            databaseConnection.Close();
            return Medicationlist;
        }
    }

    public class Resident
    {
        public Resident()
        {

        }

        public Resident(string FirstName)
        {
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;
            List<Resident> ResidentInfo = new List<Resident>();

            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select ResidentID, FirstName, LastName, Gender, NeedMedication, FloorIDResident from ResidentTable WHERE FirstName ='" + FirstName + "'";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                this._displayresidentID = Convert.ToInt32(dataReader["ResidentID"]);
                this._displayresidentFirstName = Convert.ToString(dataReader["FirstName"]);
                this._displayresidentLastName = Convert.ToString(dataReader["LastName"]);
                this._displayresidentGender = Convert.ToString(dataReader["Gender"]);
                this._displayneedMedication = Convert.ToBoolean(dataReader["NeedMedication"]);
                this._displayresidentFloorID = Convert.ToInt32(dataReader["FloorIDResident"]);
            }
            databaseConnection.Close();
        }


        private int _displayresidentID;
        public int getdisplayresidentID()
        {
            return _displayresidentID;
        }
        public void setdisplayresidentID(int displayresidentID)
        {
            _displayresidentID = displayresidentID;
        }
        //---------------------------------------------------------------------------------
        private string _displayresidentFirstName;
        public string getdisplayresidentFirstName()
        {
            return _displayresidentFirstName;
        }
        public void setdisplayresidentFirstName(string displayresidentFirstName)
        {
            _displayresidentFirstName = displayresidentFirstName;
        }
        //---------------------------------------------------------------------------------
        private string _displayresidentLastName;
        public string getdisplayresidentLastName()
        {
            return _displayresidentLastName;
        }
        public void setdisplayresidentLastName(string displayresidentLastName)
        {
            _displayresidentLastName = displayresidentLastName;
        }
        //---------------------------------------------------------------------------------
        private string _displayresidentGender;
        public string getdisplayresidentGender()
        {
            return _displayresidentGender;
        }
        public void setdisplayresidentGender(string displayresidentGender)
        {
            _displayresidentGender = displayresidentGender;
        }
        //---------------------------------------------------------------------------------
        private bool _displayneedMedication;
        public bool getdisplayneedMedication()
        {
            return _displayneedMedication;
        }
        public void setdisplayneedMedication(bool displayneedMedication)
        {
            _displayneedMedication = displayneedMedication;
        }
        //---------------------------------------------------------------------------------
        private int _displayresidentFloorID;
        public int getdisplayresidentFloorID()
        {
            return _displayresidentFloorID;
        }
        public void setdisplayresidentFloorID(int displayresidentFloorID)
        {
            _displayresidentFloorID = displayresidentFloorID;
        }


        public static List<Resident> getallresidents()
        {
            List<Resident> Residentlist = new List<Resident>();
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;
            List<Resident> ResidentInfo = new List<Resident>();

            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select ResidentID, FirstName, LastName, Gender, NeedMedication, FloorIDResident from ResidentTable";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Resident x = new Resident();
                x._displayresidentID = Convert.ToInt32(dataReader["ResidentID"]);
                x._displayresidentFirstName = Convert.ToString(dataReader["FirstName"]);
                x._displayresidentLastName = Convert.ToString(dataReader["LastName"]);
                x._displayresidentGender = Convert.ToString(dataReader["Gender"]);
                x._displayneedMedication = Convert.ToBoolean(dataReader["NeedMedication"]);
                x._displayresidentFloorID = Convert.ToInt32(dataReader["FloorIDResident"]);

                Residentlist.Add(x);
            }
            databaseConnection.Close();
            return Residentlist;
        }
    }

    public class Staff
    {

        public Staff()
        {

        }

        public Staff(string FirstName)
        {
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;
            List<Staff> StaffInfo = new List<Staff>();

            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "SELECT StaffID, FirstName, LastName, Gender, QualifiedForFloor1, QualifiedForFloor2, QualifiedForFloor3, CurrentlyPresent, UsernameStaff, PasswordStaff, PermissionLevel, FloorIDStaff FROM StaffTable WHERE FirstName ='" + FirstName + "'";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                this._displaystaffID = dataReader.GetInt32(0);
                this._displaystaffFirstName = Convert.ToString(dataReader["FirstName"]);
                this._displaystaffLastName = Convert.ToString(dataReader["LastName"]);
                this._displaystaffGender = Convert.ToString(dataReader["Gender"]);
                this._displaystaffFloor1 = Convert.ToBoolean(dataReader["QualifiedForFloor1"]);
                this._displaystaffFloor2 = Convert.ToBoolean(dataReader["QualifiedForFloor2"]);
                this._displaystaffFloor3 = Convert.ToBoolean(dataReader["QualifiedForFloor3"]);
                this._displaystaffPresent = Convert.ToBoolean(dataReader["CurrentlyPresent"]);
                this._displaystaffUsername = Convert.ToString(dataReader["UsernameStaff"]);
                this._displaystaffPassword = Convert.ToString(dataReader["PasswordStaff"]);
                this._PermissionChecker = Convert.ToBoolean(dataReader["PermissionLevel"]);

                if (this._PermissionChecker == true)
                {
                    this._displaystaffPermission = "Admin";
                }

                else
                {
                    this._displaystaffPermission = "Regular";
                }

                this._displaystaffFloorID = Convert.ToString(dataReader["FloorIDStaff"]);

                if (this._displaystaffFloorID == "")
                {
                    this._displaystaffFloorID = "None";
                }

                else
                {
                    this._displaystaffFloorID = Convert.ToString(dataReader["FloorIDStaff"]);
                }
            }
            databaseConnection.Close();
        }


        private int _displaystaffID;
        public int getdisplaystaffID()
        {
            return _displaystaffID;
        }
        public void setdisplaystaffID(int displaystaffID)
        {
            _displaystaffID = displaystaffID;
        }
        //---------------------------------------------------------------------------------
        private string _displaystaffFirstName;
        public string getdisplaystaffFirstName()
        {
            return _displaystaffFirstName;
        }
        public void setdisplaystaffFirstName(string displaystaffFirstName)
        {
            _displaystaffFirstName = displaystaffFirstName;
        }
        //---------------------------------------------------------------------------------
        private string _displaystaffLastName;
        public string getdisplaystaffLastName()
        {
            return _displaystaffLastName;
        }
        public void setdisplaystaffLastName(string displaystaffLastName)
        {
            _displaystaffLastName = displaystaffLastName;
        }
        //---------------------------------------------------------------------------------
        private string _displaystaffGender;
        public string getdisplaystaffGender()
        {
            return _displaystaffGender;
        }
        public void setdisplaystaffGender(string displaystaffGender)
        {
            _displaystaffGender = displaystaffGender;
        }
        //---------------------------------------------------------------------------------
        private bool _displaystaffFloor1;
        public bool getdisplaystaffFloor1()
        {
            return _displaystaffFloor1;
        }
        public void setdisplaystaffFloor1(bool displaystaffFloor1)
        {
            _displaystaffFloor1 = displaystaffFloor1;
        }
        //---------------------------------------------------------------------------------
        private bool _displaystaffFloor2;
        public bool getdisplaystaffFloor2()
        {
            return _displaystaffFloor2;
        }
        public void setdisplaystaffFloor2(bool displaystaffFloor2)
        {
            _displaystaffFloor2 = displaystaffFloor2;
        }
        //---------------------------------------------------------------------------------
        private bool _displaystaffFloor3;
        public bool getdisplaystaffFloor3()
        {
            return _displaystaffFloor3;
        }
        public void setdisplaystaffFloor3(bool displaystaffFloor3)
        {
            _displaystaffFloor3 = displaystaffFloor3;
        }
        //---------------------------------------------------------------------------------
        private bool _displaystaffPresent;
        public bool getdisplaystaffPresent()
        {
            return _displaystaffPresent;
        }
        public void setdisplaystaffPresent(bool displaystaffPresent)
        {
            _displaystaffPresent = displaystaffPresent;
        }
        //---------------------------------------------------------------------------------
        private string _displaystaffUsername;
        public string getdisplaystaffUsername()
        {
            return _displaystaffUsername;
        }
        public void setdisplaystaffUsername(string displaystaffUsername)
        {
            _displaystaffUsername = displaystaffUsername;
        }
        //---------------------------------------------------------------------------------
        private string _displaystaffPassword;
        public string getdisplaystaffPassword()
        {
            return _displaystaffPassword;
        }
        public void setdisplaystaffPassword(string displaystaffPassword)
        {
            _displaystaffPassword = displaystaffPassword;
        }
        //---------------------------------------------------------------------------------
        private string _displaystaffPermission;
        public string getdisplaystaffPermission()
        {
            return _displaystaffPermission;
        }
        public void setdisplaystaffPermission(string displaystaffPermission)
        {
            _displaystaffPermission = displaystaffPermission;
        }
        //---------------------------------------------------------------------------------
        private bool _PermissionChecker;
        public bool getPermissionChecker()
        {
            return _PermissionChecker;
        }
        public void PermissionChecker(bool PermissionChecker)
        {
            _PermissionChecker = PermissionChecker;
        }
        //---------------------------------------------------------------------------------
        private string _displaystaffFloorID;
        public string getdisplaystaffFloorID()
        {
            return _displaystaffFloorID;
        }
        public void setdisplaystaffFloorID(string displaystaffFloorID)
        {
            _displaystaffFloorID = displaystaffFloorID;
        }

        public static List<Staff> getallstaff()
        {
            List<Staff> Stafflist = new List<Staff>();
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;
            List<Staff> StaffInfo = new List<Staff>();

            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "SELECT StaffID, FirstName, LastName, Gender, QualifiedForFloor1, QualifiedForFloor2, QualifiedForFloor3, CurrentlyPresent, UsernameStaff, PasswordStaff, PermissionLevel, FloorIDStaff FROM StaffTable";
            dataReader = customCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Staff s = new Staff();
                s._displaystaffID = dataReader.GetInt32(0);
                s._displaystaffFirstName = Convert.ToString(dataReader["FirstName"]);
                s._displaystaffLastName = Convert.ToString(dataReader["LastName"]);
                s._displaystaffGender = Convert.ToString(dataReader["Gender"]);
                s._displaystaffFloor1 = Convert.ToBoolean(dataReader["QualifiedForFloor1"]);
                s._displaystaffFloor2 = Convert.ToBoolean(dataReader["QualifiedForFloor2"]);
                s._displaystaffFloor3 = Convert.ToBoolean(dataReader["QualifiedForFloor3"]);
                s._displaystaffPresent = Convert.ToBoolean(dataReader["CurrentlyPresent"]);
                s._displaystaffUsername = Convert.ToString(dataReader["UsernameStaff"]);
                s._displaystaffPassword = Convert.ToString(dataReader["PasswordStaff"]);
                s._PermissionChecker = Convert.ToBoolean(dataReader["PermissionLevel"]);

                if (s._PermissionChecker == true)
                {
                    s._displaystaffPermission = "Admin";
                }

                else
                {
                    s._displaystaffPermission = "Regular";
                }

                s._displaystaffFloorID = Convert.ToString(dataReader["FloorIDStaff"]);

                if (s._displaystaffFloorID == "")
                {
                    s._displaystaffFloorID = "None";
                }

                else
                {
                    s._displaystaffFloorID = Convert.ToString(dataReader["FloorIDStaff"]);
                }
                Stafflist.Add(s);
            }
            databaseConnection.Close();
            return Stafflist;
        }
    }


    class PublicVariables
    {

        public static bool Permission = false;


        //public static bool _permission = false;

        //public static bool Permission
        //{
        //    get { return _permission; }
        //    set { _permission = value; }
        //}

        public static bool _checkerbool = false;

        public static bool Checkerbool
        {
            get { return _checkerbool; }
            set { _checkerbool = value; }
        }
    }
}
