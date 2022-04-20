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
    class Program
    {
        static void Main(string[] args)
        {
            //Linking to the SQL Database
            Database SignatureDatabase = new Database();
            string query = @"SELECT * 
                             FROM StaffTable;";

            SQLiteCommand display = new SQLiteCommand(query, SignatureDatabase.dataConn);

            //dbObject.insert();
            SignatureDatabase.dataConn.Open();
            SQLiteDataReader displayQuery = display.ExecuteReader();
            if (displayQuery.HasRows)
            {
                while (displayQuery.Read())
                {
                    Console.WriteLine(displayQuery["FirstName"] + " " + displayQuery["LastName"] + " " + displayQuery["StaffID"]);
                }
            }

            LoginWindow LoginInterface = new LoginWindow();
            LoginInterface.ShowDialog();
            //Main_Menu MainmenuInterface = new Main_Menu();
            //MainmenuInterface.ShowDialog();
            //Auto_Assign_Menu AutoAssignWindow = new Auto_Assign_Menu();
            //AutoAssignWindow.ShowDialog();
            //dbObject.myConn.Close();
        }
    }
}