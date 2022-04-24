using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace NEA
{
    class Get_Values_Staff
    {
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
        //    customCommand.CommandText = "select * from StaffTable";
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
    }
}
