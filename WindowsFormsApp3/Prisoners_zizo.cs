using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp3
{
    public partial class Prisoners : Form
    {
        public Prisoners()
        {
            InitializeComponent();
        }

        private void Prisoners_Load(object sender, EventArgs e)
        {
            

        }

        private void view_all_prisoners_Click(object sender, EventArgs e)
        {
            View_all_prisoners all_prisoners = new View_all_prisoners();
            all_prisoners.Show();

            

        }

        private void view_one_prisoner_Click(object sender, EventArgs e)
        {
            View_one_prisoner one_prisoners = new View_one_prisoner();
            one_prisoners.Show();
        }

        private void insert_prisoner_Click(object sender, EventArgs e)
        {
            insert_prisoner insert_prisoner = new insert_prisoner();
            insert_prisoner.Show();
        }

        private void Delete_prisoner_Click(object sender, EventArgs e)
        {
            Delete_prisoner delete_prisoner = new Delete_prisoner();
            delete_prisoner.Show();
        }

        private void Update_prisoner_Click(object sender, EventArgs e)
        {
            Update_prisoner update_prisoner = new Update_prisoner();
            update_prisoner.Show();
        }
    }
}
