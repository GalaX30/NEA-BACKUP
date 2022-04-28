﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace NEA
{
    public class Medication
    {
        public static Medication displayMedicationInfo()
        {
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;
            List<Medication> MedicationInfo = new List<Medication>();

            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select * from MedicationTable";
            dataReader = customCommand.ExecuteReader();

            Medication SelectedMedication = new Medication();

            while (dataReader.Read())
            {
                SelectedMedication._displaymedicationID = Convert.ToInt32(dataReader["MedicationID"]);
                SelectedMedication._displaymedicationName = Convert.ToString(dataReader["MedicationName"]);
                SelectedMedication._displaymedicationAmount = Convert.ToInt32(dataReader["MedicationAmount"]);
            }
            databaseConnection.Close();
            return SelectedMedication;
        }


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
        private string _displaymedicationName;
        public string getdisplaymedicationName()
        {
            return _displaymedicationName;
        }
        public void setdisplaymedicationName(string displaymedicationName)
        {
            _displaymedicationName = displaymedicationName;
        }
        //---------------------------------------------------------------------------------
        private int _displaymedicationAmount;
        public int getdisplaymedicationAmount()
        {
            return _displaymedicationAmount;
        }
        public void setdisplaymedicationAmount(int displaymedicationAmount)
        {
            _displaymedicationAmount = displaymedicationAmount;
        }
    }

    public class Resident
    {
        //public static Resident displayResidentInfo(string firstnameresident)
        //{
        //    SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        //    SQLiteCommand customCommand;
        //    SQLiteDataReader dataReader;
        //    List<Resident> ResidentInfo = new List<Resident>();

        //    customCommand = new SQLiteCommand();
        //    databaseConnection.Open();
        //    customCommand.Connection = databaseConnection;
        //    customCommand.CommandText = "select * from ResidentTable WHERE FirstName ='" + firstnameresident + "'";
        //    dataReader = customCommand.ExecuteReader();

        //    Resident SelectedResident = new Resident();

        //    while (dataReader.Read())
        //    {
        //        SelectedResident._displayresidentID = Convert.ToInt32(dataReader["ResidentID"]);
        //        SelectedResident._displayresidentFirstName = Convert.ToString(dataReader["FirstName"]);
        //        SelectedResident._displayresidentLastName = Convert.ToString(dataReader["LastName"]);
        //        SelectedResident._displayresidentGender = Convert.ToString(dataReader["Gender"]);
        //        SelectedResident._displayneedMedication = Convert.ToBoolean(dataReader["NeedMedication"]);
        //        SelectedResident._displayresidentFloorID = Convert.ToInt32(dataReader["FloorIDResident"]);
        //    }
        //    databaseConnection.Close();
        //    return SelectedResident;
        //}

        public Resident()
        {

        }

        public Resident(int ID)
        {
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;
            List<Resident> ResidentInfo = new List<Resident>();

            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select ResidentID, FirstName, LastName, Gender, NeedMedication, FloorIDResident from ResidentTable WHERE ResidentID ='" + ID + "'";
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

                //s._displaystaffFloorID = Convert.ToInt32(dataReader["FloorIDStaff"]);
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

        public Staff(int ID)
        {
            SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            SQLiteCommand customCommand;
            SQLiteDataReader dataReader;
            List<Staff> StaffInfo = new List<Staff>();

            customCommand = new SQLiteCommand();
            databaseConnection.Open();
            customCommand.Connection = databaseConnection;
            customCommand.CommandText = "select StaffID, FirstName, LastName, Gender, QualifiedForFloor1, QualifiedForFloor2, QualifiedForFloor3, CurrentlyPresent, UsernameStaff, PasswordStaff, PermissionLevel, FloorIDStaff from StaffTable WHERE StaffID ='" + ID + "'";
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

                this._displaystaffFloorID = Convert.ToInt32(dataReader["FloorIDStaff"]);
            }
            databaseConnection.Close();
        }


        //public Staff displayStaffInfo (string firstname)
        //{
            //SQLiteConnection databaseConnection = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
            //SQLiteCommand customCommand;
            //SQLiteDataReader dataReader;
            //List<Staff> StaffInfo = new List<Staff>();

            //customCommand = new SQLiteCommand();
            //databaseConnection.Open();
            //customCommand.Connection = databaseConnection;
            //customCommand.CommandText = "select StaffID, FirstName, LastName, Gender, QualifiedForFloor1, QualifiedForFloor2, QualifiedForFloor3, CurrentlyPresent, UsernameStaff, PasswordStaff, PermissionLevel, FloorIDStaff from StaffTable WHERE FirstName ='" + firstname + "'";
            //dataReader = customCommand.ExecuteReader();

            //while (dataReader.Read())
            //{
            //    this._displaystaffID = dataReader.GetInt32(1);
            //    this._displaystaffFirstName = Convert.ToString(dataReader["FirstName"]);
            //    this._displaystaffLastName = Convert.ToString(dataReader["LastName"]);
            //    this._displaystaffGender = Convert.ToString(dataReader["Gender"]);
            //    this._displaystaffFloor1 = Convert.ToBoolean(dataReader["QualifiedForFloor1"]);
            //    this._displaystaffFloor2 = Convert.ToBoolean(dataReader["QualifiedForFloor2"]);
            //    this._displaystaffFloor3 = Convert.ToBoolean(dataReader["QualifiedForFloor3"]);
            //    this._displaystaffPresent = Convert.ToBoolean(dataReader["CurrentlyPresent"]);
            //    this._displaystaffUsername = Convert.ToString(dataReader["UsernameStaff"]);
            //    this._displaystaffPassword = Convert.ToString(dataReader["PasswordStaff"]);
            //    this._PermissionChecker = Convert.ToBoolean(dataReader["PermissionLevel"]);

            //    if (this._PermissionChecker == true)
            //    {
            //        this._displaystaffPermission = "Admin";
            //    }

            //    else
            //    {
            //        this._displaystaffPermission = "Regular";
            //    }

            //    this._displaystaffFloorID = Convert.ToInt32(dataReader["FloorIDStaff"]);
            //}
            //databaseConnection.Close();
            //return this;
        //}


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
        private int _displaystaffFloorID;
        public int getdisplaystaffFloorID()
        {
            return _displaystaffFloorID;
        }
        public void setdisplaystaffFloorID(int displaystaffFloorID)
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
            customCommand.CommandText = "select StaffID, FirstName, LastName, Gender, QualifiedForFloor1, QualifiedForFloor2, QualifiedForFloor3, CurrentlyPresent, UsernameStaff, PasswordStaff, PermissionLevel, FloorIDStaff from StaffTable";
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

                //s._displaystaffFloorID = Convert.ToInt32(dataReader["FloorIDStaff"]);
                Stafflist.Add(s);
            }
            databaseConnection.Close();
            return Stafflist;
        }
    }


    class PublicVariables
    {
        public static bool _permission = false;

        public static bool Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }

        public static bool _checkerbool = false;

        public static bool Checkerbool
        {
            get { return _checkerbool; }
            set { _checkerbool = value; }
        }
    }
}
