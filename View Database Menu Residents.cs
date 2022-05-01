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
                string First = s.getdisplayresidentFirstName();
                string Last = s.getdisplayresidentLastName();

                string entry = First.ToString() + " " + Last;
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
            int selFirst = selected.IndexOf(" ");
            string residentfirst = selected.Substring(0, selFirst);
            string First = Convert.ToString(residentfirst);
            Resident x = new Resident(First);

            Database_Details_Menu_Residents DataLabelsResidents = new Database_Details_Menu_Residents(x);
            DataLabelsResidents.ShowDialog();
        }
    }
}
