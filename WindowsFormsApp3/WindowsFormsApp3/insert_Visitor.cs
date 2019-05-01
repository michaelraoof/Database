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
    public partial class insert_Visitor : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public insert_Visitor()
        {
            InitializeComponent();
        }

        private void Save_add_Visitor_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            cmd.CommandText = "insert into Visitors values (:First_Name,:Middle_Initial,:Last_Name,VISITOR_ID_SEQ.nextval ,:Gender ,:Relation_To_Prisoner)";
            
            cmd.Parameters.Add("First_Name", First_name_visitors_box.Text);
            cmd.Parameters.Add("Middle_Initial", Middle_Initial_visitors_box.Text);
            cmd.Parameters.Add("Last_Name", Last_Name_visitors_box.Text);
            //cmd.Parameters.Add("Visitor_ID", int.Parse(Visitor_ID_box.Text));
            cmd.Parameters.Add("Gender", Gender_Visitor_box.Text);
            cmd.Parameters.Add("Relation_To_Prisoner", Relation_To_Prisoner_box.Text);
         
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("New Visitor is added");
            }

        }

        private void insert_Visitor_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();


        }
    }
}
