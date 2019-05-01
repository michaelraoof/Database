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
    public partial class view_one_case : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public view_one_case()
        {
            InitializeComponent();
        }

        private void Select_Number_for_viewcasedata_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Cases where Case_No=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", Select_Number_for_viewcasedata.SelectedItem.ToString());
            OracleDataReader dre = c.ExecuteReader();

            table.Columns.Add("Case_No", typeof(string));
            table.Columns.Add("Case_Type", typeof(string));
            table.Columns.Add("Penalty", typeof(int));
            table.Columns.Add("Crime", typeof(string));
           

            table.Load(dre);
            dataGridView_for_one_Case.DataSource = table;

            dre.Close();
        }

        private void view_one_case_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Case_No from Cases";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Select_Number_for_viewcasedata.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void Select_id_policeman_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_for_one_Case_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
