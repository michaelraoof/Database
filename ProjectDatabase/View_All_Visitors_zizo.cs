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
    public partial class View_All_Visitors : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public View_All_Visitors()
        {
            InitializeComponent();
        }

        private void Viewfor_all_visitors_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Visitors";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            table.Columns.Add("First_Name", typeof(string));
            table.Columns.Add("Middle_Initial", typeof(string));
            table.Columns.Add("Last_Name", typeof(string));
            table.Columns.Add("Visitor_ID", typeof(int));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Relation_To_Prisoner", typeof(string));
         
            table.Load(dr);
            dataGridView1_v_all_visitors.DataSource = table;

            dr.Close();
        }

        private void View_All_Visitors_Load(object sender, EventArgs e)
        {

        }
    }
}
