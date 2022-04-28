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
    public partial class View_Database_Menu_Residents : Form
    {
        public View_Database_Menu_Residents()
        {
            InitializeComponent();
        }

        void fill_listbox()
        {
            List<Resident> Rlist = Resident.getallresidents();
            foreach (Resident s in Rlist)
            {
                int ID = s.getdisplayresidentID();
                string First = s.getdisplayresidentFirstName();
                string Last = s.getdisplayresidentLastName();

                string entry = ID.ToString() + " " + First + " " + Last;
                databaseList.Items.Add(entry);
            }
        }

        private void View_Database_Menu_Residents_Load(object sender, EventArgs e)
        {
            fill_listbox();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            databaseList.Items.Clear();
            fill_listbox();
        }

        private void idLbl_Click(object sender, EventArgs e)
        {

        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void lastnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floor3Lbl_Click(object sender, EventArgs e)
        {

        }

        private void lastnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void genderLbl_Click(object sender, EventArgs e)
        {

        }

        private void genderTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void medicheckTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void medicheckLbl_Click(object sender, EventArgs e)
        {

        }

        private void prescriptionidLbl_Click(object sender, EventArgs e)
        {

        }

        private void precriptionidTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void floorLbl_Click(object sender, EventArgs e)
        {

        }

        private void floorTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu MainmenuInterface = new Main_Menu();
            MainmenuInterface.ShowDialog();
        }

        private void databaseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string selected = databaseList.Items[databaseList.SelectedIndex].ToString();
            int selID = selected.IndexOf(" ");
            string residentid = selected.Substring(0, selID);
            int ID = Convert.ToInt32(residentid);
            Resident x = new Resident(ID);

            Database_Details_Menu_Residents DataLabelsResidents = new Database_Details_Menu_Residents(x);
            DataLabelsResidents.ShowDialog();
        }
    }
}
