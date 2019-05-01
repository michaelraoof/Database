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
    public partial class Delete_case : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public Delete_case()
        {
            InitializeComponent();
        }

        private void Delete_case_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Case_No from Cases";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_Case_no_delete.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_Case_no_delete_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Cases where Case_No=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_Case_no_delete.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                
                Case_Type_box_del.Text = dr[1].ToString();
                Penalty_box_del.Text = dr[2].ToString();
                Crime_box_del.Text = dr[3].ToString();
                
            }
            dr.Close();
        }

        private void delelte_Case_Click(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "delete from Cases where Case_No=:id";

            c.Parameters.Add("id", cmb_Case_no_delete.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {

                cmb_Case_no_delete.Items.RemoveAt(cmb_Case_no_delete.SelectedIndex);
                Case_Type_box_del.Text = "";
                Penalty_box_del.Text = "";
                Crime_box_del.Text = "";
              

                MessageBox.Show("Case deleted");
            }
        }
    }
}
