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

namespace ProjectDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prisoner_Click(object sender, EventArgs e)
        {
            prisoner prisonerr = new prisoner();
            prisonerr.Show();

        }

        private void visitor_click(object sender, EventArgs e)
        {
            Visitor visitor = new Visitor();
            visitor.Show();

        }

        private void prison_click(object sender, EventArgs e)
        {
            Prison prison = new Prison();
            prison.Show();

        }

        private void policeman_click(object sender, EventArgs e)
        {
            Policeman policeman = new Policeman();
            policeman.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cells cells = new Cells();
            cells.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cases cases = new Cases();
            cases.Show();
        }
    }
}
