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
    public partial class Form1 : Form
    {
       policemen_by_prison CR;
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer3_Load(object sender, EventArgs e)
        {
            CR = new policemen_by_prison();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                prison_name_combo.Items.Add(v.Value);
        }

        private void generatereport_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, prison_name_combo.Text);
            crystalReportViewer3.ReportSource = CR;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
