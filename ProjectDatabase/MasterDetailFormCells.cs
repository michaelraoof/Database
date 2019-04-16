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
    public partial class MasterDetailFormCells : Form
    {
        public MasterDetailFormCells()
        {
            InitializeComponent();
        }

        private void MasterDetailFormCells_Load(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            DataSet ds = new DataSet();

            OracleDataAdapter adapter1 = new OracleDataAdapter("SELECT * from Cells", constr);
            adapter1.Fill(ds, "cells");

            OracleDataAdapter adapter2 = new OracleDataAdapter("SELECT * from Prisoners", constr);
            adapter2.Fill(ds, "prisoner");

            DataRelation r = new DataRelation("cellPrisoners", ds.Tables[0].Columns["cell_no"],
                                                ds.Tables[1].Columns["cell_no"]);
            ds.Relations.Add(r);

            BindingSource bs_Master = new BindingSource(ds, "cells");
            BindingSource bs_Child = new BindingSource(bs_Master, "cellPrisoners");

            dataGridView1.DataSource = bs_Master;
            dataGridView2.DataSource = bs_Child;
        }
    }
}
