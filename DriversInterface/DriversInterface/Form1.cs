using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace DriversInterface
{
    public partial class frmDriverInterface : Form
    {
        // This is the count down for the driver.
        DateTime TCountDown;
        // Let's the time go down.
        Timer t = new Timer() { Interval = 500, Enabled = true };
        public frmDriverInterface(string Emp)
        {

            // Creates controls on the form.
            InitializeComponent();
            // This is the employee's password you can use to identity the user.
            lblEmp.Text = Emp;
            //loads up the datagrid view.
            dgvDriverRequests();
            if (dgvRequests.Rows.Count == 0)
            {
                btnSelectedTask.Enabled = false;
            }


        }

        private void btnSelectedTask_Click(object sender, EventArgs e)
        {

            btnRefresh.Enabled = false;
                //Hides/Shows controls as needed.
                lblTN.Visible = true;
                lblTimeLeft.Visible = true;
                lblSealNum.Visible = true;
                panelCurrRequest.Visible = true;
                dgvRequests.Visible = false;
                btnStartBreak.Enabled = false;
                btnLogin.Enabled = false;
                btnSelectedTask.Enabled = false;
                btnTrailerPickedup.Enabled = true;

                // Selects information for the datagrid view.
                Object Start_Loc = dgvRequests.SelectedRows[0].Cells[2].Value;
                Object Req_By = dgvRequests.SelectedRows[0].Cells[3].Value;
                Object End_Loc = dgvRequests.SelectedRows[0].Cells[4].Value;
                Object Seal_No = dgvRequests.SelectedRows[0].Cells[7].Value;
                Object Trailer_No = dgvRequests.SelectedRows[0].Cells[5].Value;
                Object Notes = dgvRequests.SelectedRows[0].Cells[6].Value;

                // Sets the labels to information taken from the datagrid view.
                lblLoc.Text += Convert.ToString(Start_Loc);
                lblReqDue.Text += Convert.ToString(Req_By);
                lblLocTo.Text += Convert.ToString(End_Loc);
                lblTN.Text = Convert.ToString(Trailer_No);
                lblNotes.Text += Convert.ToString(Notes);
                lblSealNum.Text = Convert.ToString(Seal_No);

                // Sets the timer to count down by 5 minutes.
                TCountDown = DateTime.Now.AddMinutes(5);
                //Starts the countdown.
                t.Tick += new EventHandler(t_Tick);


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStartBreak_Click(object sender, EventArgs e)
        {

            // Hides controls to disable form.
            btnReport.Enabled = false;
            btnSelectedTask.Enabled = false;
            panelCurrRequest.Visible = false;
            dgvRequests.Visible = false;
            // Switches text so you need to sign back in.
            btnStartBreak.Text = "End Break";
            // Asks if you are ready to sign back in.
            DialogResult login = MessageBox.Show("Are you sure you want to log back in?", "Login", MessageBoxButtons.YesNo);
            // If it is yes enable everything.
            if (login == DialogResult.Yes)
            {
                btnReport.Enabled = true;
                btnSelectedTask.Enabled = true;
                dgvRequests.Visible = true;
                panelCurrRequest.Visible = true;
                btnStartBreak.Text = "Start Break";
            }

        }

        private void btnTrailerPickedup_Click(object sender, EventArgs e)
        {
            // Grabbing information from the data base.
            
            // Where the trailer is going
            object lotNO = dgvRequests.SelectedRows[0].Cells[4].Value;
            // Request Number
            object ReNo = dgvRequests.SelectedRows[0].Cells[0].Value;
            // Start location for request.
            object Start = dgvRequests.SelectedRows[0].Cells[2].Value;
           
           // Connection string
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            // Sets request to Finished.
            OdbcCommand cmd = new OdbcCommand("UPDATE REQUESTS SET STATUS='Finished' WHERE REQUEST_NO = '" + Convert.ToString(ReNo) + "';", Conn); 
            // Selected the trailer ID, since only the trailer number is in the database.
            OdbcCommand TrailerNO = new OdbcCommand("Select Trailer_NO from TRAILER WHERE Trailer_NO = '" + lblTN.Text + "';",Conn);
            // Start connection.
            Conn.Open();
            // Execute Connection
            cmd.ExecuteNonQuery();
            // Collect trailer ID
            Object trailerNo = TrailerNO.ExecuteScalar();
            // Close connection
            Conn.Close();
            // Update location table, the first command puts the trailer in the new lot. The second clears up the one that just left.
            OdbcCommand cmdCT = new OdbcCommand("UPDATE LOCATION SET LOCATIONSTATUS='Occupied', TRAILER_NO ='" + lblTN.Text + "' WHERE LOT_NO = '" + Convert.ToString(lotNO) + "'", Conn);
            OdbcCommand cmdEmptyLot = new OdbcCommand("UPDATE LOCATION SET LOCATIONSTATUS='Available', TRAILER_NO = '0' WHERE LOT_NO = '" + Convert.ToString(Start) + "';", Conn);
            OdbcCommand EmptyTrailer = new OdbcCommand("UPDATE TRAILER SET QUANTITY=0 WHERE TRAILER_NO = '" + lblTN.Text + "';", Conn);
            // Open Connection
            Conn.Open();
            // Execute query
             cmdCT.ExecuteNonQuery();
             cmdEmptyLot.ExecuteNonQuery();
             EmptyTrailer.ExecuteNonQuery();
            // Close Connection.
            Conn.Close();   
            
            // Refreshd datagrid view
            dgvRequests.Refresh();

            //show/hide controls as needed.
            dgvRequests.Visible = true;
            btnLogin.Enabled = true;
            btnSelectedTask.Enabled = true;
            btnStartBreak.Enabled = true;
            btnTrailerPickedup.Enabled = false;
            lblTimer.Visible = false;
            lblTN.Visible = false;
            lblTimeLeft.Visible = false;
            lblSealNum.Visible = false;
            // Check for new requests
            dgvDriverRequests();
            if (dgvRequests.Rows.Count == 0)
            {
                btnSelectedTask.Enabled = false;
            }
            btnRefresh.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // If the user logs out, I just close the form.
            Close();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            // Time counts down from now.
            TimeSpan ts = TCountDown.Subtract(DateTime.Now);
            // Sets the label to be this format
            lblTimeLeft.Text = ts.ToString(@"mm\:ss");
            // If the timer reaches zero then stop.
            if(lblTimeLeft.Text == "00:00"){
                t.Stop();
            }
            // If the minute is under 1 then the driver is going to be close to being late so it goes into red.
            else if (ts.Minutes < 1)
            {
                lblTimeLeft.BackColor = Color.Red;
            }

            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            /* 
             * 
             * 
             * 
             * I need to resend the request to the dispatcher
            */
            // Selects the start location of the trailer.
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
           object Start = dgvRequests.SelectedRows[0].Cells[2].Value;
           object EndLoc = dgvRequests.SelectedRows[0].Cells[4].Value;
            // Selects the problem with a trailer.
           string prob = cboIssue.SelectedItem.ToString();
            //REquest No.
           object ReNo = dgvRequests.SelectedRows[0].Cells[0].Value;

            object STAT = dgvRequests.SelectedRows[0].Cells[1].Value;
            object Time = dgvRequests.SelectedRows[0].Cells[3].Value;
            object TN = dgvRequests.SelectedRows[0].Cells[5].Value;
            object SN = dgvRequests.SelectedRows[0].Cells[6].Value;

            string Stat = Convert.ToString(STAT);
            string TIME = Convert.ToString(Time);
            string TRNO = Convert.ToString(TN);
            string SealNo = Convert.ToString(SN);

            string Component = "Select component from requests where REQUEST_NO = '" + Convert.ToString(ReNo) + "'";
            string Supplier = "Select Supplier from requests where REQUEST_NO = '" + Convert.ToString(ReNo) + "'";
            OdbcCommand cmdComp = new OdbcCommand(Component, Conn);
            OdbcCommand cmdSupplier = new OdbcCommand(Supplier, Conn);

            Conn.Open();
            Object ObjReqComp = cmdComp.ExecuteScalar();
            Object ObjReqSupplier = cmdSupplier.ExecuteScalar();
            Conn.Close();
           // Connection String
            string reqComp = Convert.ToString(ObjReqComp);
            string reqSupp = Convert.ToString(ObjReqSupplier);
            // Update request to show it has a problem
            
            OdbcCommand cmd = new OdbcCommand("UPDATE REQUESTS SET STATUS='" + Convert.ToString(cboIssue.SelectedItem) + "' WHERE REQUEST_NO = '" + Convert.ToString(dgvRequests.SelectedRows[0].Cells[0].Value) + "';", Conn);
           // Update lot to mark it on the map as boken.
            OdbcCommand LotBroke = new OdbcCommand("UPDATE LOCATION SET LOCATIONSTATUS = '" + prob + "' WHERE LOT_NO = '" + Start + "';",Conn);
            // Open connection
            int x = 5;
            int result;
            if (int.TryParse(Convert.ToString(Start), out result))
            {

                OdbcCommand NewRequest = new OdbcCommand("INSERT INTO REQUESTS (COMPONENT,PO_NO,END_LOCATION,SCHEDULED_DATE,SEALNO,SUPPLIER,TRAILER_NO,STATUS)  VALUES('" + reqComp + "','0','" + Convert.ToString(EndLoc) + "',to_date('" + TIME + "','dd/mm/yy hh:mi:ss AM'),'" + SealNo + "','" + reqSupp + "','" + TRNO + "','Attention')", Conn);
                Conn.Open();
                // Execute queries
                cmd.ExecuteNonQuery();
                LotBroke.ExecuteNonQuery();
                NewRequest.ExecuteNonQuery();
                // Close Connections
                Conn.Close();
            }
           else
            {
               // OdbcCommand NewRequest = new OdbcCommand("INSERT INTO REQUESTS (COMPONENT,LOCATION_ID,PO_NO,SCHEDULED_DATE,SEALNO,SUPPLIER,TRAILER_NO,STATUS)  VALUES('" + reqComp + "','" + Convert.ToString(Start) + "','0',to_date('" + TIME + "','dd/mm/yy hh:mi:ss AM'),'" + SealNo + "','" + reqSupp + "','" + TRNO + "','Needed')", Conn);
                Conn.Open();
                // Execute queries
                cmd.ExecuteNonQuery();
                LotBroke.ExecuteNonQuery();
               // NewRequest.ExecuteNonQuery();
                // Close Connections
                Conn.Close();
            }
            
           //OdbcCommand NewRequest = new OdbcCommand("Insert INTO REQUESTS(SCHEDULED_DATE) VALUES(to_date('" + TIME + "','dd/mm/yy hh:mi:ss AM'))",Conn);
           
            // Refresh datagrid view
            dgvRequests.Refresh();
            dgvRequests.Visible = true;
            // Show driver the issue hass been reported.
            MessageBox.Show("Issue Reported!");
            // Show hide things.
            btnTrailerPickedup.Enabled = false;
            btnLogin.Enabled = true;
            btnStartBreak.Enabled = true;
            btnSelectedTask.Enabled = true;
            lblTN.Visible = false;
            lblTimeLeft.Visible = false;
            lblSealNum.Visible = false;
            dgvRequests.Visible = true;
            dgvDriverRequests();
        }

        private void dgvDriverRequests()
        {
            // Can't pick up a trailer without one selected.
            btnTrailerPickedup.Enabled = false;

            // Create table for the request information.
            DataTable DeliveryLocation = new DataTable();
           
            DeliveryLocation.Columns.Add("Request No.", typeof(Int32));
            DeliveryLocation.Columns.Add("Status", typeof(string));
            DeliveryLocation.Columns.Add("Start Location", typeof(string));
            DeliveryLocation.Columns.Add("Required By", typeof(DateTime));
            DeliveryLocation.Columns.Add("End Location", typeof(string));
            DeliveryLocation.Columns.Add("Trailer No.", typeof(string));
            DeliveryLocation.Columns.Add("Seal No", typeof(string));
            DeliveryLocation.Columns.Add("Notes", typeof(string));

            
            // Select all the request information.

            // Select portion of the statement.
            string select = "SELECT REQUESTS.REQUEST_NO,REQUESTS.Status,REQUESTS.LOCATION_ID,REQUESTS.SCHEDULED_DATE,REQUESTS.END_LOCATION,REQUESTS.TRAILER_NO,REQUESTS.SEALNO, REQUESTS.NOTES";
            // Where clause
            string where = " WHERE REQUESTS.STATUS = 'In Progress' AND REQUESTS.EMPLOYEE_ID ='" + lblEmp.Text + "' AND EMPLOYEE.EMPLOYEEPASSWORD = REQUESTS.EMPLOYEE_ID ";

            // Connection string
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            // Command for the select statement.
            OdbcCommand cmd = new OdbcCommand(select + " FROM REQUESTS,EMPLOYEE" + where, Conn);
            // Open connection
            Conn.Open();
            // This reads the information
            OdbcDataReader rdr = cmd.ExecuteReader();
            // While there is stuff ot be read.
            while (rdr.Read())
            {
                // Add the information to the data table and columns listed.
                DeliveryLocation.Rows.Add(
                    rdr.GetInt32(0),
                    rdr.GetString(1),
                    rdr.GetString(2),
                    rdr.GetDateTime(3),
                    rdr.GetString(4),
                    rdr.GetString(5),
                    rdr.GetString(6),
                    rdr.GetString(7)
                    
                    

                    );
            }
            // Destroy the information in the datagrid view.
            dgvRequests.DataSource = null;
            // Update it to make sure nothing is in it.
            dgvRequests.Update();
            // Fill it with proper information.
            dgvRequests.DataSource = DeliveryLocation;
            // kill the odbc command. If this is not done you'll have problems re using it.
            dgvRequests.Columns[0].Visible = false;
            cmd.Dispose();
            // Close the connnection.
            Conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDriverRequests();
            if (dgvRequests.Rows.Count > 0)
            {
                btnSelectedTask.Enabled = true;
            }
            else
            {
                btnSelectedTask.Enabled = false;
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            Form CM = new CompletedMoves(lblEmp.Text);
            CM.Show();
        }

    }
}
