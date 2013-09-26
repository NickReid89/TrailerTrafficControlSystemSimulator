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
    public partial class RetentionReport : Form
    {
        TrailerReportALL report;
        public RetentionReport()
        {
            InitializeComponent();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            if (report == null) report = new TrailerReportALL();
            crystalReportViewer1.ReportSource = report;


            crystalReportViewer1.Refresh();
        }
    }
}
