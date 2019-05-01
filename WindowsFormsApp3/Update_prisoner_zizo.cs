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
    public partial class Update_prisoner : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;

        public Update_prisoner()
        {
            InitializeComponent();
        }

        private void Update_prisoner_Load(object sender, EventArgs e)
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
                comboBox1.Items.Add(dr[0]);
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
                cmb_prisonname_forupdate_prisoner.Items.Add(drr[0]);
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
                cmb_Cell_no_forudpate_prisoner.Items.Add(drea[0]);
            }
            drea.Close();


        }



        private void Update_Button_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
     
            cmd.CommandText = "update Prisoners set First_Name=:f_name, Middle_Initial=:m_name," +
                " Last_Name=:L_name,  Gender=:gender, Address=:address, Age=:age, Cell_No=:cell_no," +
                " Prison_Name=:prison_name where Prisoner_ID =:id";

            cmd.Parameters.Add("f_name", First_Name_box_update.Text);
            cmd.Parameters.Add("m_name", Middle_Initial_box_update.Text);
            cmd.Parameters.Add("L_name", Last_Name_box_update.Text);
            cmd.Parameters.Add("gender", Gender_box_update.Text);
            cmd.Parameters.Add("address", Address_box_update.Text);
            cmd.Parameters.Add("age", Convert.ToInt32(Age_box_update.Text));
            cmd.Parameters.Add("cell_no", Convert.ToInt32(cmb_Cell_no_forudpate_prisoner.Text));
            cmd.Parameters.Add("prison_name", cmb_prisonname_forupdate_prisoner.Text);
            cmd.Parameters.Add("id", Convert.ToInt32(comboBox1.SelectedItem.ToString()));


            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Prisoner updated");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Prisoners where Prisoner_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", int.Parse(comboBox1.SelectedItem.ToString()));
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                First_Name_box_update.Text = dr[0].ToString();
                Middle_Initial_box_update.Text = dr[1].ToString();
                Last_Name_box_update.Text = dr[2].ToString();
                Gender_box_update.Text = dr[4].ToString();
                Address_box_update.Text = dr[5].ToString();
                Age_box_update.Text = dr[6].ToString();
                cmb_Cell_no_forudpate_prisoner.Text = dr[7].ToString();
                cmb_prisonname_forupdate_prisoner.Text = dr[8].ToString();


            }
            dr.Close();
        }

        private void cmb_Cell_no_forudpate_prisoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_prisonname_forupdate_prisoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
