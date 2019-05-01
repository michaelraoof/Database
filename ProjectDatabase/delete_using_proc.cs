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
    public partial class delete_using_proc : Form
    {
        OracleConnection con;
        string ordb = "data source = orcl; user id =hr; password=hr;";

        public delete_using_proc()
        {
            InitializeComponent();
        }

        private void delete_using_proc_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Prisoner_ID from Prisoners";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_prisonID_delete_prisoner_using_proc.Items.Add(dr[0]);
            }
        }

        private void Delete_Button_prisoner_using_proc_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete_prisonerr";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("iid", Convert.ToInt32(cmb_prisonID_delete_prisoner_using_proc.Text.ToString()));

            cmd.ExecuteNonQuery();
           
                cmb_prisonID_delete_prisoner_using_proc.Items.RemoveAt(cmb_prisonID_delete_prisoner_using_proc.SelectedIndex);
                First_Name_box_del_using_proc.Text = "";
                Middle_Initial_box_del_using_proc.Text = "";
                Last_Name_box_del_using_proc.Text = "";
                Gender_box_del_using_proc.Text = "";
                Age_box_del_using_proc.Text = "";
                Cell_No_Box_del_using_proc.Text = "";
                Prison_Name_box_del_using_proc.Text = "";
                Address_box_del_using_proc.Text = "";


                MessageBox.Show("Prisoner deleted");
            
        }

        private void cmb_prisonID_delete_prisoner_using_proc_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from Prisoners where Prisoner_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_prisonID_delete_prisoner_using_proc.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                First_Name_box_del_using_proc.Text = dr[0].ToString();
                Middle_Initial_box_del_using_proc.Text = dr[1].ToString();
                Last_Name_box_del_using_proc.Text = dr[2].ToString();
                Gender_box_del_using_proc.Text = dr[4].ToString();
                Address_box_del_using_proc.Text = dr[5].ToString();
                Age_box_del_using_proc.Text = dr[6].ToString();
                Cell_No_Box_del_using_proc.Text = dr[7].ToString();
                Prison_Name_box_del_using_proc.Text = dr[8].ToString();
            }
        }
    }
}
