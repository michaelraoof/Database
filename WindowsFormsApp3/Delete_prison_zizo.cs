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
    public partial class Delete_prison : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public Delete_prison()
        {
            InitializeComponent();
        }

        private void cmb_prison_name_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Prisons where Prison_Name=:name";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("name", cmb_prison_name_del.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {

                Location_box_del.Text = dr[1].ToString();
            }
        }
        private void Delete_prison_Load(object sender, EventArgs e)
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
                cmb_prison_name_del.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void delelte_prison_Click(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "delete from Prisons where Prison_Name=:name";

            c.Parameters.Add("name", cmb_prison_name_del.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {

                cmb_prison_name_del.Items.RemoveAt(cmb_prison_name_del.SelectedIndex);
                Location_box_del.Text = "";
               



                MessageBox.Show("prison deleted");
            }
        }
    }
}
