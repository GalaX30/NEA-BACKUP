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
    public partial class Database_Details_Menu_Medication : Form
    {
        Medication CurrentMedication;
        public Database_Details_Menu_Medication(Medication SelectedMedication)
        {
            CurrentMedication = SelectedMedication;
            InitializeComponent();
        }

        private void Database_Details_Menu_Medication_Load(object sender, EventArgs e)
        {
            itemLbl.Text = (CurrentMedication.getdisplayMedication());
            infoLbl1.Text = ("ID: " + CurrentMedication.getdisplaymedicationID());
            infoLbl2.Text = ("Medication Name: " + CurrentMedication.getdisplayMedication());
            infoLbl3.Text = ("Amount: " + CurrentMedication.getdisplaymedicationAmount());
        }

        private void infoLbl1_Click(object sender, EventArgs e)
        {

        }

        private void itemLbl_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl2_Click(object sender, EventArgs e)
        {

        }

        private void infoLbl3_Click(object sender, EventArgs e)
        {

        }
    }
}
