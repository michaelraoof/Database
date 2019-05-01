using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Policeman : Form
    {
        public Policeman()
        {
            InitializeComponent();
        }

        private void view_all_policeman_Click(object sender, EventArgs e)
        {
            View_All_Policemen all_policemen = new View_All_Policemen();
            all_policemen.Show();
        }

        private void view_one_policeman_Click(object sender, EventArgs e)
        {

            view_one_policeman one_policeman = new view_one_policeman();
            one_policeman.Show();
        }

        private void insert_policeman_Click(object sender, EventArgs e)
        {
            insert_policeman add_policeman = new insert_policeman();
            add_policeman.Show();
        }

        private void Delete_policeman_Click(object sender, EventArgs e)
        {
            Delete_policeman dele_policeman = new Delete_policeman();
            dele_policeman.Show();
        }

        private void Update_policman_Click(object sender, EventArgs e)
        {

            update_policeman upda_policeman = new update_policeman();
            upda_policeman.Show();
        }
    }
}
