using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using prison_system;

namespace ProjectDatabase
{
    public partial class Connected_or_Disconnected : Form
    {
        public Connected_or_Disconnected()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            som3a_Form1 form1 = new som3a_Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Form m = new Main_Form();
            m.Show();
        }

        private void connected_proc_Click(object sender, EventArgs e)
        {
            connected_using_proc qe = new connected_using_proc();
            qe.Show();
        }

        private void Get_Reports_Click(object sender, EventArgs e)
        {
            Reports re = new Reports();
            re.Show();
        }
    }
}
