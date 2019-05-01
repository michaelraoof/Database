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
    public partial class view_one_cell : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public view_one_cell()
        {
            InitializeComponent();
        }

        private void view_one_cell_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Cell_No from Cells";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Select_Number_for_viewcelldata.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void Select_Number_for_viewcelldata_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Cells where Cell_No=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", Select_Number_for_viewcelldata.SelectedItem.ToString());
            OracleDataReader dre = c.ExecuteReader();

            table.Columns.Add("Cell_No", typeof(int));
            table.Columns.Add("Cell_Type", typeof(string));
            table.Columns.Add("No_of_Cell_Prisoners", typeof(int));


            table.Load(dre);
            dataGridView_for_one_Cell.DataSource = table;

            dre.Close();
        }
    }
}
