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
    public partial class Visitor : Form
    {
        public Visitor()
        {
            InitializeComponent();
        }

        private void view_all_visitors_Click(object sender, EventArgs e)
        {
            View_All_Visitors visitorr = new View_All_Visitors();
            visitorr.Show();
        }

        private void view_one_visitor_Click(object sender, EventArgs e)
        {
            View_One_Visitor one_visitor = new View_One_Visitor();
            one_visitor.Show();
        }

        private void insert_Visitor_Click(object sender, EventArgs e)
        {
            insert_Visitor ad_visitor = new insert_Visitor();
            ad_visitor.Show();
        }

        private void Delete_Visitor_Click(object sender, EventArgs e)
        {
            Delete_Visitor del_visitor = new Delete_Visitor();
            del_visitor.Show();
        }

        private void Update_Visitor_Click(object sender, EventArgs e)
        {
            Update_Visitor upd_visitor = new Update_Visitor();
            upd_visitor.Show();
        }
    }
}
