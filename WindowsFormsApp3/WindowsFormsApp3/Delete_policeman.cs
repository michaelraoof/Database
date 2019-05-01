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
    public partial class Delete_policeman : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public Delete_policeman()
        {
            InitializeComponent();
        }

        private void Delete_policeman_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Policeman_ID from Policemen";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_policemanid_del.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_policemanid_del_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Policemen where Policeman_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_policemanid_del.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                First_name_box_policeman_del.Text = dr[0].ToString();
                Middle_Initial_box_policeman_del.Text = dr[1].ToString();
                Last_Name_box_policeman_del.Text = dr[2].ToString();
                Shift_Time_box_policeman_del.Text = dr[4].ToString();
                Shift_Duration_box_policeman_del.Text = dr[5].ToString();
                cmb_CellNo_for_deletepoliceman.Text = dr[6].ToString();
                cmb_prisonname_delete_policeman.Text = dr[7].ToString();
            }
            dr.Close();
        }

        private void delete_button_policeman_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "delete from Policemen where Policeman_ID=:id";

            c.Parameters.Add("id", cmb_policemanid_del.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {

                cmb_policemanid_del.Items.RemoveAt(cmb_policemanid_del.SelectedIndex);
                First_name_box_policeman_del.Text = "";
                Last_Name_box_policeman_del.Text = "";
                Middle_Initial_box_policeman_del.Text = "";
                Shift_Time_box_policeman_del.Text = "";
                Shift_Duration_box_policeman_del.Text = "";
                cmb_CellNo_for_deletepoliceman.Text = "";
                cmb_prisonname_delete_policeman.Text = "";
                

                MessageBox.Show("policeman deleted");
            }
        }
    }
}
