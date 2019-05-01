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
    public partial class insert_prisoner : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public insert_prisoner()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void insert_prisoner_Load(object sender, EventArgs e)
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
                cmb_prisonname_ininsert_prisoner.Items.Add(dr[0]);
            }
            dr.Close();
            OracleCommand cmdd = new OracleCommand();
            cmdd.Connection = conn;
            cmdd.CommandText = "select Cell_No from Cells";
            cmdd.CommandType = CommandType.Text;

            OracleDataReader dreader = cmdd.ExecuteReader();
            while (dreader.Read())
            {
                cmb_CellNo_for_insertprisoners.Items.Add(dreader[0]);
            }
            dreader.Close();
           

        }

        private void Save_add_prisoner_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
          

            cmd.CommandText = "insert into Prisoners values (:First_Name,:Middle_Initial,:Last_Name,PRISONER_ID_SEQ.nextval ,:Gender ,:Address ,:Age ,:Cell_No ,:Prison_Name)";
            cmd.Parameters.Add("First_Name", First_name_box.Text);
            cmd.Parameters.Add("Middle_Initial", Middle_Initial_box.Text);
            cmd.Parameters.Add("Last_Name", Last_Name_box.Text);
            //cmd.Parameters.Add("Prisoner_ID", Prisoner_ID_box.Text);

            cmd.Parameters.Add("Gender", Gneder_Prisoner_box.Text);
            cmd.Parameters.Add("Address", Address_box.Text);
            cmd.Parameters.Add("Age", Age_box.Text);
            cmd.Parameters.Add("Cell_No", cmb_CellNo_for_insertprisoners.Text);
            cmd.Parameters.Add("Prison_Name", cmb_prisonname_ininsert_prisoner.Text);
    
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                
                MessageBox.Show("New Prisoner is added");
            }
        }

        private void cmb_CellNo_for_insertprisoners_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            
        }

        private void cmb_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
