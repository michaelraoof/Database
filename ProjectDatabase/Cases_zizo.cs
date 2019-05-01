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
    public partial class Cases : Form
    {
        public Cases()
        {
            InitializeComponent();
        }

        private void view_all_cases_Click(object sender, EventArgs e)
        {
            view_all_cases all_cases = new view_all_cases();
            all_cases.Show();
        }

        private void view_one_case_Click(object sender, EventArgs e)
        {
            view_one_case one_case = new view_one_case();
            one_case.Show();
        }

        private void insert_case_Click(object sender, EventArgs e)
        {

            insert_case insert_case = new insert_case();
            insert_case.Show();
        }

        private void Delete_case_Click(object sender, EventArgs e)
        {
            Delete_case del_case = new Delete_case();
            del_case.Show();
        }

        private void Update_case_Click(object sender, EventArgs e)
        {
            update_case upda_case = new update_case();
            upda_case.Show();
        }
    }
}
