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
    public partial class View_Database_Menu_Medicine : Form
    {
        public View_Database_Menu_Medicine()
        {
            InitializeComponent();
        }
        void fill_listbox()
        {
            List<Medication> Mlist = Medication.getallmedication();
            foreach (Medication s in Mlist)
            {
                string MediName = s.getdisplayMedication();

                string entry = MediName.ToString();
                databaseList.Items.Add(entry);
            }
        }

        private void View_Database_Menu_Medicine_Load(object sender, EventArgs e)
        {
            databaseList.Items.Clear();
            fill_listbox();
        }

        private void databaseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            databaseList.Items.Clear();
            fill_listbox();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string selected = databaseList.Items[databaseList.SelectedIndex].ToString();
            Medication m = new Medication(selected);

            Database_Details_Menu_Medication DataLabels = new Database_Details_Menu_Medication(m);
            DataLabels.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterBtn_Click(object sender, EventArgs e)
        {

        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu MainmenuInterface = new Main_Menu();
            MainmenuInterface.ShowDialog();
        }
    }
}
