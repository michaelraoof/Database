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
    public partial class update_prison : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;

        public update_prison()
        {
            InitializeComponent();
        }

        private void update_prison_Load(object sender, EventArgs e)
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
                cmb_prison_name_update.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void cmb_prison_name_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Prisons where Prison_Name=:name";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("name", cmb_prison_name_update.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {


                Location_box_update.Text = dr[1].ToString();


            }
            dr.Close();
        }

        private void update_cells_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Prisons set Locations=:location where Prison_Name =:name";


            cmd.Parameters.Add("name", cmb_prison_name_update.SelectedItem);
           



            cmd.Parameters.Add("id", cmb_prison_name_update.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Prison updated");
            }
        }
    }
}
