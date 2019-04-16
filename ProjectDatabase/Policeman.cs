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
    public partial class Policeman : Form
    {
        OracleDataAdapter adapterr;
        DataSet dataSett;
        OracleCommandBuilder builderr;
        public Policeman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=hr;Password=hr;";
            string cmdstr = @"select * from policemen where policeman_id =:id";

            adapterr = new OracleDataAdapter(cmdstr, constr);
            adapterr.SelectCommand.Parameters.Add("id", textBox1.Text);
            dataSett = new DataSet();
            adapterr.Fill(dataSett);
            dataGridView1.DataSource = dataSett.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=hr;Password=hr;";
            string cmdstr = "select * from policemen";

            adapterr = new OracleDataAdapter(cmdstr, constr);
            dataSett = new DataSet();
            adapterr.Fill(dataSett);
            dataGridView1.DataSource = dataSett.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> list_Of_Prisons_name = new List<string>();

            string constr = "Data Source=orcl;User Id=hr;Password=hr;";

            string prison = "select prison_name from prisons";

            OracleDataAdapter adapter = new OracleDataAdapter(prison, constr);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                list_Of_Prisons_name.Add(dataSet.Tables[0].Rows[i]["prison_name"].ToString());

            string update_NO_Policemen = @"update PRISONS set N0_Of_Policemen =(select count(*)
                                          from POLICEMEN where prison_name=:name)
                                          where prison_name=:name";

            for (int i = 0; i < list_Of_Prisons_name.Count; i++)
            {
                adapter = new OracleDataAdapter(update_NO_Policemen, constr);
                adapter.SelectCommand.Parameters.Add("name", list_Of_Prisons_name[i]);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
            }

            builderr = new OracleCommandBuilder(adapter);
            adapter.Update(dataSett.Tables[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MasterDetailFormPolicemen master_form2 = new MasterDetailFormPolicemen();
            master_form2.Show();

        }
    }
}
