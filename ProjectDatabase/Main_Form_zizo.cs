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
    public partial class Main_Form : Form
    {
       

        public Main_Form()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            Prisoners prisonerr = new Prisoners();
            prisonerr.Show();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prison prison = new Prison();
            prison.Show();
        }

        private void Visitor_Click(object sender, EventArgs e)
        {

            Visitor visitorr = new Visitor();
            visitorr.Show();
        }

        private void Policeman_Click(object sender, EventArgs e)
        {
            Policeman policeman = new Policeman();
            policeman.Show();
        }

        private void Cases_Click(object sender, EventArgs e)
        {
            Cases Case = new Cases();
            Case.Show();
        }

        private void Cells_Click(object sender, EventArgs e)
        {
            Cells cell = new Cells();
            cell.Show();
        }
    }
}
