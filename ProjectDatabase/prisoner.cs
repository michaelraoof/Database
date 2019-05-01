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
    public partial class prisoner : Form
    {
        OracleDataAdapter adapterr;
        DataSet dataSett;
        OracleCommandBuilder builderr;
        public prisoner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=hr;Password=hr;";
            string cmdstr = @"select * from prisoners where prisoner_id =:id";

            adapterr = new OracleDataAdapter(cmdstr, constr);
            adapterr.SelectCommand.Parameters.Add("id", textBox1.Text);
            dataSett = new DataSet();
            adapterr.Fill(dataSett);
            dataGridView1.DataSource = dataSett.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=hr;Password=hr;";
            string cmdstr = "select * from prisoners";

            adapterr = new OracleDataAdapter(cmdstr, constr);
            dataSett = new DataSet();
            adapterr.Fill(dataSett);
            dataGridView1.DataSource = dataSett.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> list_Of_Prison_names = new List<string>();
            List<string> list_Of_Cell_NOs = new List<string>();

            string constr = "Data Source=orcl;User Id=hr;Password=hr;";

            string prison = "select prison_name from prisons";

            OracleDataAdapter adapter = new OracleDataAdapter(prison, constr);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
     
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                list_Of_Prison_names.Add(dataSet.Tables[0].Rows[i]["prison_name"].ToString());

            string update = @"update PRISONS set N0_Of_Prisoners =(select count(*)
                             from PRISONERS where prison_name=:name)
                             where prison_name=:name";

            for (int i = 0; i < list_Of_Prison_names.Count; i++)
            {
                adapter = new OracleDataAdapter(update, constr);
                adapter.SelectCommand.Parameters.Add("name", list_Of_Prison_names[i]);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
            }

            string cells = "select cell_no from cells";

            adapter = new OracleDataAdapter(cells, constr);
            dataSet = new DataSet();
            adapter.Fill(dataSet);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                list_Of_Cell_NOs.Add(dataSet.Tables[0].Rows[i]["cell_no"].ToString());

            string update_No_of_Cell_Prisoners = @"update Cells set No_of_Cell_Prisoners =(select count(*)
                             from PRISONERS where cell_no=:n)
                             where cell_no=:n";

            for (int i = 0; i < list_Of_Cell_NOs.Count; i++)
            {
                adapter = new OracleDataAdapter(update_No_of_Cell_Prisoners, constr);
                adapter.SelectCommand.Parameters.Add("n", list_Of_Cell_NOs[i]);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
            }

            builderr = new OracleCommandBuilder(adapter);
            adapter.Update(dataSett.Tables[0]);
        }

        private void prisoner_Load(object sender, EventArgs e)
        {

        }
    }
}
