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
    public partial class Prison : Form
    {
        public Prison()
        {
            InitializeComponent();
        }

        private void view_all_prisons_Click(object sender, EventArgs e)
        {
            view_all_prison all_prisons = new view_all_prison();
            all_prisons.Show();
        }

        private void view_one_prison_Click(object sender, EventArgs e)
        {
            view_one_prison one_prison = new view_one_prison();
            one_prison.Show();
        }

        private void insert_prison_Click(object sender, EventArgs e)
        {

            insert_prison insert_prison = new insert_prison();
            insert_prison.Show();
        }

        private void Delete_prison_Click(object sender, EventArgs e)
        {
            Delete_prison del_prison = new Delete_prison();
            del_prison.Show();
        }

        private void Update_prison_Click(object sender, EventArgs e)
        {
            update_prison upda_prison = new update_prison();
            upda_prison.Show();
        }
    }
}
