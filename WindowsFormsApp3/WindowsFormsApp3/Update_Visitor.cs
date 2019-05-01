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
    public partial class Update_Visitor : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;

        public Update_Visitor()
        {
            InitializeComponent();
        }

        private void Relation_To_Prisoner_Click(object sender, EventArgs e)
        {

        }

        private void Last_Name_box_update_visitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_Name_box_update_visitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_box_update_visitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_box_update_visitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Middle_Initial_box_update_visitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_visitorID_update_prisoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Visitors where Visitor_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", int.Parse(cmb_visitorID_update_prisoner.SelectedItem.ToString()));
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                First_Name_box_update_visitor.Text = dr[0].ToString();
                Middle_Initial_box_update_visitor.Text = dr[1].ToString();
                Last_Name_box_update_visitor.Text = dr[2].ToString();
                Gender_box_update_visitor.Text = dr[4].ToString();
                Realtion_box_update_visitor.Text = dr[5].ToString();
               
            }
            dr.Close();
        }

        private void Update_Visitor_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Visitor_ID from Visitors";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_visitorID_update_prisoner.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Visitors set First_Name=:f_name, Middle_Initial=:m_name," +
                " Last_Name=:L_name,  Gender=:gender, Relation_To_Prisoner=:relation where Visitor_ID =:id";


            cmd.Parameters.Add("f_name", First_Name_box_update_visitor.Text);
            cmd.Parameters.Add("m_name", Middle_Initial_box_update_visitor.Text);
            cmd.Parameters.Add("L_name", Last_Name_box_update_visitor.Text);
            cmd.Parameters.Add("gender", Gender_box_update_visitor.Text);
            cmd.Parameters.Add("Relation_To_Prisoner", Realtion_box_update_visitor.Text);
          
            cmd.Parameters.Add("id", int.Parse(cmb_visitorID_update_prisoner.SelectedItem.ToString()));
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Visitor updated");
            }
        }
    }
    }

