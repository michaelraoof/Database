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
    public partial class Delete_Visitor : Form
    {

        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public Delete_Visitor()
        {
            InitializeComponent();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "delete from Visitors where Visitor_ID=:id";

            c.Parameters.Add("id", cmb_VisitorID_delete_prisoner.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {

                cmb_VisitorID_delete_prisoner.Items.RemoveAt(cmb_VisitorID_delete_prisoner.SelectedIndex);
                First_Name_box_del_visitor.Text = "";
                Last_Name_box_del_visitor.Text = "";
                Middle_Initial_box_del_visitor.Text = "";
                Gender_box_del_visitor.Text = "";
                Relation_box_del_visitor.Text = "";
                

                MessageBox.Show("Prisoner deleted");
            }
        }

        private void Delete_Visitor_Load(object sender, EventArgs e)
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
                cmb_VisitorID_delete_prisoner.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_VisitorID_delete_prisoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Visitors where Visitor_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_VisitorID_delete_prisoner.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                First_Name_box_del_visitor.Text = dr[0].ToString();
                Middle_Initial_box_del_visitor.Text = dr[1].ToString();
                Last_Name_box_del_visitor.Text = dr[2].ToString();
                Gender_box_del_visitor.Text = dr[4].ToString();
                Relation_box_del_visitor.Text = dr[5].ToString();
               
            }
            dr.Close();
        }
    }
}
