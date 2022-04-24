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
        public Database_Details_Menu(Staff staff)
        {
            CurrentStaff = staff;
            InitializeComponent();
        }

        private void Database_Details_Menu_Load(object sender, EventArgs e)
        {
            //infoLbl1.Visible = true;
            infoLbl1.Text = CurrentStaff.getdisplaystaffID().ToString();
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
