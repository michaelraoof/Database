using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using ProjectDatabase;
namespace prison_system
{
    public partial class Form2 : Form
    {
        visits_by_date CR2;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CR2 = new visits_by_date();
            foreach (ParameterDiscreteValue v in CR2.ParameterFields[0].DefaultValues)
                visit_date_combo.Items.Add(v.Value);

        }

        private void generate_report_Click(object sender, EventArgs e)
        {

            CR2.SetParameterValue(0, visit_date_combo.Text);
            crystalReportViewer1.ReportSource = CR2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void visit_date_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
