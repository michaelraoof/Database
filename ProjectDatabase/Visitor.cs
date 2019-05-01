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
    public partial class Visitor : Form
    {
        OracleDataAdapter adapterr;
        DataSet dataSett;
        OracleCommandBuilder builderr;
        public Visitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=hr;Password=hrr;";
            string cmdstr = @"select * from visitors where visitor_id =:id";

            OracleDataAdapter adapterr = new OracleDataAdapter(cmdstr, constr);
            adapterr.SelectCommand.Parameters.Add("id", textBox1.Text);
            DataSet dataSett = new DataSet();
            adapterr.Fill(dataSett);
            dataGridView1.DataSource = dataSett.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=hr;Password=hr;";
            string cmdstr = "select * from visitors";

            adapterr = new OracleDataAdapter(cmdstr, constr);
            dataSett = new DataSet();
            adapterr.Fill(dataSett);
            dataGridView1.DataSource = dataSett.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            builderr = new OracleCommandBuilder(adapterr);
            adapterr.Update(dataSett.Tables[0]);
        }

        private void Visitor_Load(object sender, EventArgs e)
        {

        }
    }
}
