using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DispatchersInterface
{
    public partial class TrailerReportView : Form
    {
        TrailerReport report;
        public TrailerReportView()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            if (report == null) report = new TrailerReport();
            crystalReportViewer1.ReportSource = report;


            crystalReportViewer1.Refresh();
        }
    }
}
