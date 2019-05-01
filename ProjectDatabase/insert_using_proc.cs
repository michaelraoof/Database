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
    public partial class insert_using_proc : Form
    {

        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public insert_using_proc()
        {
            InitializeComponent();
        }

        private void Save_add_prison_using_proc_Click(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "insert_case";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("case_noo", Case_No_box_insert_using_proc.Text);
            c.Parameters.Add("case_typee",Case_Type_box_insert_using_proc.Text);
            c.Parameters.Add("penaltyy",penalty_box_insert_using_proc.Text);
            c.Parameters.Add("crimee",Crime_box_insert_using_proc.Text);
            c.ExecuteNonQuery();
            MessageBox.Show("new case added");

        }

        private void insert_using_proc_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
