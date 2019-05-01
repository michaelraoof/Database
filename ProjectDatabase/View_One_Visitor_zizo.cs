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
    public partial class View_One_Visitor : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public View_One_Visitor()
        {
            InitializeComponent();
        }

        private void dataGridView_for_one_prison_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_One_Visitor_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Visitor_ID from Visitors";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Select_ID_for_viewVisitordata.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void Select_ID_for_viewVisitordata_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Visitors where Visitor_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", Select_ID_for_viewVisitordata.SelectedItem.ToString());
            OracleDataReader dre = c.ExecuteReader();

            table.Columns.Add("First_Name", typeof(string));
            table.Columns.Add("Middle_Initial", typeof(string));
            table.Columns.Add("Last_Name", typeof(string));
            table.Columns.Add("Visitor_ID", typeof(int));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Relation_To_Prisoner", typeof(string));
            

            table.Load(dre);
            dataGridView_for_one_prison.DataSource = table;

            dre.Close();
        }
    }
}
