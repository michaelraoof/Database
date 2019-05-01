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
    public partial class view_all_cases : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public view_all_cases()
        {
            InitializeComponent();
        }

        private void Viewfor_all_cases_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Cases";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            table.Columns.Add("Case_No", typeof(int));
            table.Columns.Add("Case_Type", typeof(string));
            table.Columns.Add("Penalty", typeof(int));
            table.Columns.Add("Crime", typeof(string));
   
            table.Load(dr);
            dataGridView_view_all_cases.DataSource = table;

            dr.Close();
        }

        private void dataGridView_view_all_cases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
