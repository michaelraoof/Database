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
    public partial class insert_case : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public insert_case()
        {
            InitializeComponent();
        }

        private void insert_case_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Save_add_Case_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            cmd.CommandText = "insert into Cases values (CASE_NO_SEQ.nextval,:Case_Type,:Penalty,:Crime )";

            cmd.Parameters.Add("Case_Type", Case_Type_box_insert.Text);
            cmd.Parameters.Add("Penalty", Convert.ToInt32(penalty_box_insert.Text));
            cmd.Parameters.Add("Crime", Crime_box_insert.Text);
         

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("New Case is added");
            }
        }
    }
}
