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
    public partial class view_one_row_using_proc : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public view_one_row_using_proc()
        {
            InitializeComponent();
        }

        private void view_one_row_using_proc_Load(object sender, EventArgs e)
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
                Select_ID_for_viewprisonerdata_using_proc.Items.Add(dr[0]);
            }
            dr.Close();
           
        }

        private void Select_ID_for_viewprisonerdata_using_proc_SelectedIndexChanged(object sender, EventArgs e)
        {

            OracleCommand cp = new OracleCommand();
            cp.Connection = conn;

            cp.CommandText = "select_one_row_first_name";
            cp.CommandType = CommandType.StoredProcedure;
            cp.Parameters.Add("iid", Convert.ToInt64(Select_ID_for_viewprisonerdata_using_proc.SelectedItem.ToString()));
            cp.Parameters.Add("f_namee", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;

            cp.ExecuteNonQuery();



            First_Name_box_view_using_proc.Text = cp.Parameters["f_namee"].Value.ToString();
            /***************************************************************************/


            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;

            cm.CommandText = "select_one_row_middle_name";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("iid", Convert.ToInt64(Select_ID_for_viewprisonerdata_using_proc.SelectedItem.ToString()));
            cm.Parameters.Add("middle_name", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;

            cm.ExecuteNonQuery();



            Middle_Initial_box_updateview_using_proc.Text = cm.Parameters["middle_name"].Value.ToString();
            /**********************************************************************************/


            OracleCommand cw = new OracleCommand();
            cw.Connection = conn;

            cw.CommandText = "select_one_row_last_name";
            cw.CommandType = CommandType.StoredProcedure;
            cw.Parameters.Add("iid", Convert.ToInt64(Select_ID_for_viewprisonerdata_using_proc.SelectedItem.ToString()));
            cw.Parameters.Add("last_namee", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cw.ExecuteNonQuery();

            Last_Name_box_updateview_using_proc.Text = cw.Parameters["last_namee"].Value.ToString();

            /**********************************************************************************/
            OracleCommand cq = new OracleCommand();
            cq.Connection = conn;

            cq.CommandText = "select_one_row_address";
            cq.CommandType = CommandType.StoredProcedure;
            cq.Parameters.Add("iid", Convert.ToInt64(Select_ID_for_viewprisonerdata_using_proc.SelectedItem.ToString()));
     
            cq.Parameters.Add("addresss", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cq.ExecuteNonQuery();
            Address_box_updateview_using_proc.Text = cq.Parameters["addresss"].Value.ToString();
            /**********************************************************************************/
            OracleCommand cv = new OracleCommand();
            cv.Connection = conn;

            cv.CommandText = "select_one_row_gender";
            cv.CommandType = CommandType.StoredProcedure;
            cv.Parameters.Add("iid", Convert.ToInt64(Select_ID_for_viewprisonerdata_using_proc.SelectedItem.ToString()));

            cv.Parameters.Add("genderr", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cv.ExecuteNonQuery();
            Gender_box_updateview_using_proc.Text = cv.Parameters["genderr"].Value.ToString();
            /**********************************************************************************/
            OracleCommand cl = new OracleCommand();
            cl.Connection = conn;

            cl.CommandText = "select_one_row_age";
            cl.CommandType = CommandType.StoredProcedure;
            cl.Parameters.Add("iid", Convert.ToInt64(Select_ID_for_viewprisonerdata_using_proc.SelectedItem.ToString()));

            cl.Parameters.Add("agee", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cl.ExecuteNonQuery();
            Age_box_updateview_using_proc.Text = cl.Parameters["agee"].Value.ToString();
            /**********************************************************************************/
            OracleCommand co = new OracleCommand();
            co.Connection = conn;

            co.CommandText = "select_one_row_cell_no";
            co.CommandType = CommandType.StoredProcedure;
            co.Parameters.Add("iid", Convert.ToInt64(Select_ID_for_viewprisonerdata_using_proc.SelectedItem.ToString()));

            co.Parameters.Add("cell_noo", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            co.ExecuteNonQuery();
            cell_no_box_view_row_using_proc.Text = co.Parameters["cell_noo"].Value.ToString();
            /**********************************************************************************/

            OracleCommand cy = new OracleCommand();
            cy.Connection = conn;

            cy.CommandText = "select_one_row_prison_name";
            cy.CommandType = CommandType.StoredProcedure;
            cy.Parameters.Add("iid", Convert.ToInt64(Select_ID_for_viewprisonerdata_using_proc.SelectedItem.ToString()));
            cy.Parameters.Add("prison_namee", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cy.ExecuteNonQuery();
            prison_name_box_using_proc.Text = cy.Parameters["prison_namee"].Value.ToString();



      


        }

    }
}
