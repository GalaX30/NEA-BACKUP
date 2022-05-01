using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA
{
    public partial class Database_Details_Menu : Form
    {
        Staff CurrentStaff;
        public Database_Details_Menu(Staff stafftest)
        {
            CurrentStaff = stafftest;
            InitializeComponent();
        }

        private void Database_Details_Menu_Load(object sender, EventArgs e)
        {
            itemLbl.Text = (CurrentStaff.getdisplaystaffFirstName() + " " + CurrentStaff.getdisplaystaffLastName());
            infoLbl1.Text = ("ID: " + CurrentStaff.getdisplaystaffID());
            infoLbl2.Text = ("Firstname: " + CurrentStaff.getdisplaystaffFirstName());
            infoLbl3.Text = ("Lastname: " + CurrentStaff.getdisplaystaffLastName());
            infoLbl4.Text = ("Gender: " + CurrentStaff.getdisplaystaffGender());
            infoLbl5.Text = ("Can work on floor 1: " + CurrentStaff.getdisplaystaffFloor1());
            infoLbl6.Text = ("Can work on floor 2: " + CurrentStaff.getdisplaystaffFloor2());
            infoLbl7.Text = ("Can work on floor 3: " + CurrentStaff.getdisplaystaffFloor3());
            infoLbl8.Text = ("Is at work: " + CurrentStaff.getdisplaystaffPresent());
            infoLbl9.Text = ("Currently on floor: " + CurrentStaff.getdisplaystaffFloorID());
        }

        private void itemLbl_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl1_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl2_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl3_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl4_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl5_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl6_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl7_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl8_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl9_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl10_Click(object sender, EventArgs e)
        {

        }
    }
}
