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
    public partial class Prison : Form
    {
        OracleDataAdapter adapterr;
        DataSet dataSett;
        OracleCommandBuilder builderr;
        public Prison()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=hr;Password=hrr;";
            string cmdstr = @"select * from prisons where prison_name = :pname";

            adapterr = new OracleDataAdapter(cmdstr, constr);
            adapterr.SelectCommand.Parameters.Add("pname", textBox1.Text);
            dataSett = new DataSet();
            adapterr.Fill(dataSett);
            dataGridView1.DataSource = dataSett.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            string constr = "Data Source=orcl;User Id=hr;Password=hr;";
            string cmdstr = "select * from prisons";

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

        private void button4_Click(object sender, EventArgs e)
        {
            MasterDetailFormPrison master_form = new MasterDetailFormPrison();
            master_form.Show();
        }

        private void Prison_Load(object sender, EventArgs e)
        {

        }
    }
}
