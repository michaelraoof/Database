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
    public partial class insert_prison : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public insert_prison()
        {
            InitializeComponent();
        }

        private void Save_add_prison_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            cmd.CommandText = "insert into Prisons values (:Prison_Name ,:Locations,:N0_Of_Prisoners,:N0_Of_Policemen)";

            cmd.Parameters.Add("Prison_Name", Prison_Name_box_insert.Text.ToString());
            cmd.Parameters.Add("Locations", Location_box_insert.Text.ToString());
            cmd.Parameters.Add("N0_Of_Prisoners", int.Parse(cmb_No_of_prisoners_insert_prison.SelectedItem.ToString()));
            cmd.Parameters.Add("N0_Of_Policemen",int.Parse(cmb_no_of_policemen_insert_prison.SelectedItem.ToString()));


            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("New prison is added");
            }

        }

        private void insert_prison_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            cmb_no_of_policemen_insert_prison.Items.Add("0");
            cmb_No_of_prisoners_insert_prison.Items.Add("0");

        }
    }
}
