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
    public partial class insert_cell : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public insert_cell()
        {
            InitializeComponent();
        }

        private void insert_cell_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            cmb_No_of_prisoners_for_insert_cell.Items.Add("0");
            cmb_cell_type_for_insert_cell.Items.Add("solo");
            cmb_cell_type_for_insert_cell.Items.Add("group");

        }

        private void Save_add_Cell_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            cmd.CommandText = "insert into Cells values (CELL_NO_SEQ.nextval ,:Cell_Type,:No_of_Cell_Prisoners)";

            cmd.Parameters.Add("Cell_Type", cmb_cell_type_for_insert_cell.SelectedIndex.ToString());
            cmd.Parameters.Add("No_of_Cell_Prisoners", int.Parse(cmb_No_of_prisoners_for_insert_cell.SelectedItem.ToString()));


            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("New Cell is added");
            }
        }
    }
}
