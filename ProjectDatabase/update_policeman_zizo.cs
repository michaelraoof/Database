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
    public partial class update_policeman : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;

        public update_policeman()
        {
            InitializeComponent();
        }

        private void update_policeman_Load(object sender, EventArgs e)
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
               cmb_policemanid_update.Items.Add(dr[0]);
            }
            dr.Close();
            ///////////////////Prison_Name////////////////////////


            OracleCommand cmdd = new OracleCommand();
            cmdd.Connection = conn;
            cmdd.CommandText = "select Prison_Name from Prisons";
            cmdd.CommandType = CommandType.Text;

            OracleDataReader drr = cmdd.ExecuteReader();
            while (drr.Read())
            {
                cmb_prisonname_update_policeman.Items.Add(drr[0]);
            }
            drr.Close();
            //////////////////////Cell_No//////////////////////


            OracleCommand cmmd = new OracleCommand();
            cmmd.Connection = conn;
            cmmd.CommandText = "select Cell_No from Cells";
            cmmd.CommandType = CommandType.Text;

            OracleDataReader drea = cmmd.ExecuteReader();
            while (drea.Read())
            {
                cmb_CellNo_for_updatepoliceman.Items.Add(drea[0]);
            }
            drea.Close();

        }

        private void Save_update_policeman_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "update Policemen set First_Name=:f_name, Middle_Initial=:m_name," +
                " Last_Name=:L_name,  Shift_Time=:shift_time,Shift_Duration=:shift_duration, Cell_No=:cell_no," +
                " Prison_Name=:prison_name where Policeman_ID =:id";

            cmd.Parameters.Add("f_name", First_name_box_policeman_update.Text);
            cmd.Parameters.Add("m_name", Middle_Initial_box_policeman_update.Text);
            cmd.Parameters.Add("L_name", Last_Name_box_policeman_update.Text);
            cmd.Parameters.Add("shift_time",Convert.ToDateTime(Shift_Time_box_policeman_update.Text).ToString());
            cmd.Parameters.Add("shift_duration", Shift_Duration_box_policeman_update.Text);
            cmd.Parameters.Add("cell_no", Convert.ToInt32(cmb_CellNo_for_updatepoliceman.Text));
            cmd.Parameters.Add("prison_name", cmb_prisonname_update_policeman.Text);
            cmd.Parameters.Add("id", Convert.ToInt32(cmb_policemanid_update.SelectedItem.ToString()));
            

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Policeman updated");
            }
        }

        private void cmb_policemanid_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Policemen where Policeman_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", int.Parse(cmb_policemanid_update.SelectedItem.ToString()));
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                First_name_box_policeman_update.Text = dr[0].ToString();
                Middle_Initial_box_policeman_update.Text = dr[1].ToString();
                Last_Name_box_policeman_update.Text = dr[2].ToString();
                Shift_Time_box_policeman_update.Text = dr[4].ToString();
                Shift_Duration_box_policeman_update.Text = dr[5].ToString();          
                cmb_CellNo_for_updatepoliceman.Text = dr[6].ToString();
                cmb_prisonname_update_policeman.Text = dr[7].ToString();


            }
            dr.Close();
        }
    }
}
