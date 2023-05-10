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

namespace Graduation_Project_System
{
    public partial class studentsReportForm : Form
    {
        CrystalReport3 CR;

        public studentsReportForm()
        {
            InitializeComponent();
        }

        private void studentsReportForm_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport3();
            //crystalReportViewer1.ReportSource = CR;
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = CR;

        }
    }
}
