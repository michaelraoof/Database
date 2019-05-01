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
    public partial class Delete_cell : Form
    {

        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public Delete_cell()
        {
            InitializeComponent();
        }

        private void Delete_cell_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Cell_No from Cells";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_Cell_no_delete.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void delelte_Cell_Click(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "delete from Cells where Cell_No=:id";

            c.Parameters.Add("id", cmb_Cell_no_delete.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {

                cmb_Cell_no_delete.Items.RemoveAt(cmb_Cell_no_delete.SelectedIndex);
                Cell_Type_box_del.Text = "";
                No_of_Cell_Prisoners_box_del.Text = "";
              


                MessageBox.Show("Cell deleted");
            }
        }

        private void cmb_Cell_no_delete_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Cells where Cell_No=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_Cell_no_delete.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {

                Cell_Type_box_del.Text = dr[1].ToString();
                No_of_Cell_Prisoners_box_del.Text = dr[2].ToString();
                

            }
            dr.Close();
        }
    }
}
