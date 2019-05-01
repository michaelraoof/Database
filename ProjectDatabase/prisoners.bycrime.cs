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
   
    public partial class Form4 : Form
    { prisonersbycrime CR4;
        public Form4()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CR4 = new prisonersbycrime();
            foreach (ParameterDiscreteValue v in CR4.ParameterFields[0].DefaultValues)
                crime_combo.Items.Add(v.Value);
        }

        private void generate_button_Click(object sender, EventArgs e)
        {

            CR4.SetParameterValue(0, crime_combo.Text);
            crystalReportViewer1.ReportSource = CR4;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
