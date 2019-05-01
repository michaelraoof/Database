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
    public partial class update_case : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;

        public update_case()
        {
            InitializeComponent();
        }

        private void update_case_Load(object sender, EventArgs e)
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
                cmb_Case_no_Update.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Cases set Case_Type=:case_Type, Penalty=:penalty," +
                " Crime=:crime where Case_No =:id";


            cmd.Parameters.Add("case_Type", Case_Type_box_update.Text);
            cmd.Parameters.Add("penalty", Penalty_box_update.Text);
            cmd.Parameters.Add("crime", Crime_box_update.Text);


            cmd.Parameters.Add("id", int.Parse(cmb_Case_no_Update.SelectedItem.ToString()));
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Case updated");
            }
        }

        private void cmb_Case_no_Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Cases where Case_No=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_Case_no_Update.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {

                Case_Type_box_update.Text = dr[1].ToString();
                Penalty_box_update.Text = dr[2].ToString();
                Crime_box_update.Text = dr[3].ToString();

            }
            dr.Close();
        }
    }
}
