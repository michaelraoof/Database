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
    public partial class Update_using_proc : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public Update_using_proc()
        {
            InitializeComponent();
        }

        private void Save_update_policeman_using_proc_Click(object sender, EventArgs e)
        {

            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;

            cm.CommandText = "updatee";
            cm.CommandType = CommandType.StoredProcedure;

          
            cm.Parameters.Add("f", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;           
            cm.Parameters.Add("iid",cmb_policemanid_update_using_proc.SelectedItem.ToString());
            cm.ExecuteNonQuery();

            /////////////////////////////////////////////////////////////////////////////
            OracleCommand cma = new OracleCommand();
            cma.Connection = conn;

            cma.CommandText = "updatee_middle_ini";
            cma.CommandType = CommandType.StoredProcedure;
            cma.Parameters.Add("middle_ini", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cma.Parameters.Add("iid", cmb_policemanid_update_using_proc.SelectedItem.ToString());

            cma.ExecuteNonQuery();
            ///////////////////////////////////////////////////////////////////////////////

            OracleCommand cmb = new OracleCommand();
            cmb.Connection = conn;

            cmb.CommandText = "updatee_last_name";
            cmb.CommandType = CommandType.StoredProcedure;
            cmb.Parameters.Add("last_namee", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cmb.Parameters.Add("iid", cmb_policemanid_update_using_proc.SelectedItem.ToString());

            cmb.ExecuteNonQuery();
            //////////////////////////////////////////////////////////////////////////////////////////////////
            //OracleCommand cmc = new OracleCommand();
            //cmc.Connection = conn;

            //cmc.CommandText = "updatee_shift_timee";
            //cmc.CommandType = CommandType.StoredProcedure;
            //cmc.Parameters.Add("shift_timee", Shift_Time_box_policeman_update_using_proc.Text);
            //cmc.Parameters.Add("iid", cmb_policemanid_update_using_proc.SelectedItem.ToString());

            //cmc.ExecuteNonQuery();
            //////////////////////////////////////////////////////////////////////////////////////////////////////



            OracleCommand cms = new OracleCommand();
            cms.Connection = conn;

            cms.CommandText = "updatee_shift_duration";
            cms.CommandType = CommandType.StoredProcedure;
            cms.Parameters.Add("shift_durationn", OracleDbType.Int64, 100).Direction = ParameterDirection.Output;
            cms.Parameters.Add("iid", cmb_policemanid_update_using_proc.SelectedItem.ToString());

            cms.ExecuteNonQuery();
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            OracleCommand cmw = new OracleCommand();
            cmw.Connection = conn;

            cmw.CommandText = "updatee_cell_no";
            cmw.CommandType = CommandType.StoredProcedure;

            cmw.Parameters.Add("cell_noo", OracleDbType.Int64, 100).Direction = ParameterDirection.Output;
            cmw.Parameters.Add("iid", cmb_policemanid_update_using_proc.SelectedItem.ToString());

            cmw.ExecuteNonQuery();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            OracleCommand cmq = new OracleCommand();
            cmq.Connection = conn;

            cmq.CommandText = "updatee_prison_name";
            cmq.CommandType = CommandType.StoredProcedure;
            cmq.Parameters.Add("prison_namee", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cmq.Parameters.Add("iid", cmb_policemanid_update_using_proc.SelectedItem.ToString());

            cmq.ExecuteNonQuery();

            MessageBox.Show("Policeman updated");
            
        }

        private void Update_using_proc_Load(object sender, EventArgs e)
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
                cmb_policemanid_update_using_proc.Items.Add(dr[0]);
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
                cmb_prisonname_update_policeman_using_proc.Items.Add(drr[0]);
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
                cmb_CellNo_for_updatepoliceman_proc.Items.Add(drea[0]);
            }
            drea.Close();
        }

        private void cmb_policemanid_update_using_proc_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Policemen where Policeman_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", int.Parse(cmb_policemanid_update_using_proc.SelectedItem.ToString()));
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                First_name_box_policeman_update_using_proc.Text = dr[0].ToString();
                Middle_Initial_box_policeman_update_proc.Text = dr[1].ToString();
                Last_Name_box_policeman_update_using_proc.Text = dr[2].ToString();
                Shift_Time_box_policeman_update_using_proc.Text = dr[4].ToString();
                Shift_Duration_box_policeman_update_proc.Text = dr[5].ToString();
                cmb_CellNo_for_updatepoliceman_proc.Text = dr[6].ToString();
                cmb_prisonname_update_policeman_using_proc.Text = dr[7].ToString();


            }
            dr.Close();
        }
    }
}
