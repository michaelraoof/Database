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
    public partial class update_cell : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
       
        public update_cell()
        {
            InitializeComponent();
        }

        private void update_cell_Load(object sender, EventArgs e)
        {
            cmb_cell_type_update_cell.Items.Add("solo");
            cmb_cell_type_update_cell.Items.Add("group");

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Cell_No from Cells";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_Cell_no_update.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void update_cells_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Cells set Cell_Type=:cell_Type," +
                " No_of_Cell_Prisoners=:no_of_Cell_Prisoners where Cell_No =:id";


            cmd.Parameters.Add("cell_Type", cmb_cell_type_update_cell.SelectedItem);
            cmd.Parameters.Add("no_of_Cell_Prisoners", No_of_Cell_Prisoners_box_update.Text);
           


            cmd.Parameters.Add("id", int.Parse(cmb_Cell_no_update.SelectedItem.ToString()));
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Cell updated");
            }
        }

        private void cmb_Cell_no_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Cells where Cell_No=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_Cell_no_update.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {

                
                No_of_Cell_Prisoners_box_update.Text = dr[2].ToString();
                

            }
            dr.Close();
        }
    }
}
