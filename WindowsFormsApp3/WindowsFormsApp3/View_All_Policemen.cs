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
    public partial class View_All_Policemen : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public View_All_Policemen()
        {
            InitializeComponent();
        }

        private void Viewfor_all_policemen_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Policemen";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            table.Columns.Add("First_Name", typeof(string));
            table.Columns.Add("Middle_Initial", typeof(string));
            table.Columns.Add("Last_Name", typeof(string));
            table.Columns.Add("Policeman_ID", typeof(int));
            table.Columns.Add("Shift_Time", typeof(string));
            table.Columns.Add("Shift_Duration", typeof(int));
            table.Columns.Add("Cell_No", typeof(int));
            table.Columns.Add("Prison_Name", typeof(string));
            table.Load(dr);
            dataGridView_all_policemen.DataSource = table;

            dr.Close();

        }
    }
}
