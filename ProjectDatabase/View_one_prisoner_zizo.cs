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
    public partial class View_one_prisoner : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public View_one_prisoner()
        {
            InitializeComponent();
        }

        private void View_one_prisoner_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Prisoner_ID from Prisoners";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Select_ID_for_viewprisonerdata.Items.Add(dr[0]);
                
            }
            dr.Close();
        }

        private void Select_ID_for_viewprisondata_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Prisoners where Prisoner_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", Select_ID_for_viewprisonerdata.SelectedItem.ToString());
            OracleDataReader dre = c.ExecuteReader();
          
            table.Columns.Add("First_Name", typeof(string));
            table.Columns.Add("Middle_Initial", typeof(string));
            table.Columns.Add("Last_Name", typeof(string));
            table.Columns.Add("Prisoner_ID", typeof(int));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Cell_No", typeof(int));
            table.Columns.Add("Prison_Name", typeof(string));

                table.Load(dre);
                dataGridView_for_one_prison.DataSource = table;
            
            dre.Close();
        }

        private void Viewfor_one_prisoners_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_for_one_prison_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
