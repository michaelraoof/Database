using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class connected_using_proc : Form
    {
        public connected_using_proc()
        {
            InitializeComponent();
        }

        private void view_one_row_button_Click(object sender, EventArgs e)
        {
            view_one_row_using_proc s = new view_one_row_using_proc();
            s.Show();
        }

        private void view_multi_eow_Click(object sender, EventArgs e)
        {
            view_multi_rows_proc ss = new view_multi_rows_proc();
            ss.Show();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            insert_using_proc ins = new insert_using_proc();
            ins.Show();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            Update_using_proc upd = new Update_using_proc();
            upd.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            delete_using_proc delet = new delete_using_proc();
            delet.Show();
        }
    }
}
