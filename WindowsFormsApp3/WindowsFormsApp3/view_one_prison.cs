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
    public partial class view_one_prison : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public view_one_prison()
        {
            InitializeComponent();
        }

        private void view_one_prison_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Prison_Name from Prisons";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Select_Number_for_viewprisondata.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void Select_Number_for_viewprisondata_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Prisons where Prison_Name=:name";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("name", Select_Number_for_viewprisondata.SelectedItem.ToString());
            OracleDataReader dre = c.ExecuteReader();

            table.Columns.Add("Locations", typeof(string));
            table.Columns.Add("N0_Of_Prisoners", typeof(int));
            table.Columns.Add("N0_Of_Policemen", typeof(int));


            table.Load(dre);
            dataGridView_for_one_prison.DataSource = table;

            dre.Close();
        }
    }
}
