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
    public partial class view_multi_rows_proc : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public view_multi_rows_proc()
        {
            InitializeComponent();
        }

        private void view_all_visitors_using_proc_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select_all_table";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("multi_rows", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            table.Columns.Add("First_Name", typeof(string));
            table.Columns.Add("Middle_Initial", typeof(string));
            table.Columns.Add("Last_Name", typeof(string));
            table.Columns.Add("Visitor_ID", typeof(int));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Relation_To_Prisoner", typeof(string));

            table.Load(dr);
            dataGridView1_v_all_visitors_using_proc.DataSource = table;

            dr.Close();
        }

        private void view_multi_rows_proc_Load(object sender, EventArgs e)
        {

        }
    }
}
