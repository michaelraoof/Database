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
    public partial class Form3 : Form
    {
        prisonersbyprison CR3;
        public Form3()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CR3 = new prisonersbyprison();
            foreach (ParameterDiscreteValue v in CR3.ParameterFields[0].DefaultValues)
                prisoners_prison_combo.Items.Add(v.Value);
        }

        private void Generate_report_buttton_Click(object sender, EventArgs e)
        {

            CR3.SetParameterValue(0, prisoners_prison_combo.Text);
            crystalReportViewer1.ReportSource = CR3;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
