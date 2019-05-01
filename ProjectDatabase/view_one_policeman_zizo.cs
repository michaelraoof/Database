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
    public partial class view_one_policeman : Form
    {

        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public view_one_policeman()
        {
            InitializeComponent();
        }

        private void Select_ID_for_viewpolicemandata_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Policemen where Policeman_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", Select_ID_for_viewpolicemandata.SelectedItem.ToString());
            OracleDataReader dre = c.ExecuteReader();

            table.Columns.Add("First_Name", typeof(string));
            table.Columns.Add("Middle_Initial", typeof(string));
            table.Columns.Add("Last_Name", typeof(string));
            table.Columns.Add("Policeman_ID", typeof(int));
            table.Columns.Add("Shift_Time", typeof(string));
            table.Columns.Add("Shift_Duration", typeof(int));
            table.Columns.Add("Cell_No", typeof(int));
            table.Columns.Add("Prison_Name", typeof(string));

            table.Load(dre);
            dataGridView_for_one_policeman.DataSource = table;

            dre.Close();

        }

        private void view_one_policeman_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Policeman_ID from Policemen";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Select_ID_for_viewpolicemandata.Items.Add(dr[0]);

            }
            dr.Close();
        }
    }
}
