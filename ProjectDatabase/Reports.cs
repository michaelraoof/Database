using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectDatabase;

namespace prison_system
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void PrisonersByPrisonbutton_Click(object sender, EventArgs e)
        {
            Form3 PrisonersByPrison = new Form3();
            PrisonersByPrison.Show();


        }

        private void Prisonersbycrimebutton_Click(object sender, EventArgs e)
        {
            Form4 Prisonersbycrime = new Form4();
            Prisonersbycrime.Show();
        }

        private void PolicemenByPrisonbutton_Click(object sender, EventArgs e)
        {
            Form1 PolicemenByPrison = new Form1();
            PolicemenByPrison.Show();

        }

        private void Visitsbydatebutton_Click(object sender, EventArgs e)
        {
            Form2 Visitsbydate = new Form2();
            Visitsbydate.Show();

        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
