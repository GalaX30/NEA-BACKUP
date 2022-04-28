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
    class Database
    {
        public SQLiteConnection dataConn;

        //Constructor
        public Database()
        {
            //SQLiteConnection Class provides methods for reading the result of a command executed against a SQLite database
            dataConn = new SQLiteConnection("Data Source = StaffDatabaseComplete.db");
        }
    }
}