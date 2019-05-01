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
    public partial class MasterDetailFormPrison : Form
    {
        public MasterDetailFormPrison()
        {
            InitializeComponent();
        }

        private void Master_Detail_Load(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hrr;Data Source=orcl";
            DataSet ds = new DataSet();

            OracleDataAdapter adapter1 = new OracleDataAdapter("SELECT * from Prisons", constr);
            adapter1.Fill(ds, "Prison");

            OracleDataAdapter adapter2 = new OracleDataAdapter("SELECT * from Prisoners", constr);
            adapter2.Fill(ds, "prisoner");

            DataRelation r = new DataRelation("Prisoners", ds.Tables[0].Columns["prison_name"],
                                                ds.Tables[1].Columns["prison_name"]);
            ds.Relations.Add(r);

            BindingSource bs_Master = new BindingSource(ds, "Prison");
            BindingSource bs_Child = new BindingSource(bs_Master, "Prisoners");

            dataGridView1.DataSource = bs_Master;
            dataGridView2.DataSource = bs_Child;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
