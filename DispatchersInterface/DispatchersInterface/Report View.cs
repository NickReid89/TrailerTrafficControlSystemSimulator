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
    public partial class Report_View : Form
    {
        
        public Report_View()
        {
            InitializeComponent();
        }

        private void btnTrLo_Click(object sender, EventArgs e)
        {
            Form TL = new TrailerReportView();
            TL.Show();
        }

        private void btnRetention_Click(object sender, EventArgs e)
        {
            Form RR = new RetentionReport();
            RR.Show();
        }

        private void btnLotReport_Click(object sender, EventArgs e)
        {
            Form LOTS = new AllLotsListed();
            LOTS.Show();
        }

        private void btnAllMovements_Click(object sender, EventArgs e)
        {
            Form AMR = new ALLMOVESREPORT();
            AMR.Show();
        }
    }
}
