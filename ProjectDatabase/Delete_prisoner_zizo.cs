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
    public partial class Delete_prisoner : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public Delete_prisoner()
        {
            InitializeComponent();
        }

        private void cmb_prisonname_ininsert_prisoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Prisoners where Prisoner_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_prisonID_delete_prisoner.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                First_Name_box_del.Text = dr[0].ToString();
                Middle_Initial_box_del.Text = dr[1].ToString();
                Last_Name_box_del.Text = dr[2].ToString();
                Gender_box_del.Text = dr[4].ToString();
                Address_box_del.Text = dr[5].ToString();
                Age_box_del.Text = dr[6].ToString();
                Cell_No_Box_del.Text = dr[7].ToString();
                Prison_Name_box_del.Text = dr[8].ToString();
            }
            dr.Close();
        }

        private void Delete_prisoner_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Prisoner_ID from Prisoners";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_prisonID_delete_prisoner.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "delete from Prisoners where Prisoner_ID=:id";

            c.Parameters.Add("id", cmb_prisonID_delete_prisoner.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                
                cmb_prisonID_delete_prisoner.Items.RemoveAt(cmb_prisonID_delete_prisoner.SelectedIndex);
                First_Name_box_del.Text = "";
                Last_Name_box_del.Text = "";
                Middle_Initial_box_del.Text = "";
                Gender_box_del.Text = "";
                Age_box_del.Text = "";
                Cell_No_Box_del.Text = "";
                Prison_Name_box_del.Text = "";
                Address_box_del.Text = "";

                MessageBox.Show("Prisoner deleted");
            }

        }
    }
}
