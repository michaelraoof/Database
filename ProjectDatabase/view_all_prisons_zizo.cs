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
    public partial class view_all_prison : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        
        public view_all_prison()
        {
            InitializeComponent();
        }

        private void Viewfor_all_cases_Click(object sender, EventArgs e)
        {

        }

        private void Viewfor_all_Prisons_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Prisons";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            table.Columns.Add("Prison_Name", typeof(string));
            table.Columns.Add("Locations", typeof(string));
            table.Columns.Add("N0_Of_Prisoners", typeof(int));
            table.Columns.Add("N0_Of_Policemen", typeof(int));

            table.Load(dr);
            dataGridView_view_all_prisons.DataSource = table;

            dr.Close();
        }

        private void view_all_prison_Load(object sender, EventArgs e)
        {

        }
    }
}
