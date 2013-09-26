using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace DispatchersInterface
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
            // Sets search index to all.
            cboSearch.SelectedIndex = 3;
            radNeeded.Checked = true;
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // This enables the accept view. I have it originally disable because of a users presses this without
            // selecting a record it will cause the program to crash.
            btnArrived.Visible = true;

            // Data table to hold the important portion of the bill of lading's. 
            DataTable results = new DataTable();
            results.Columns.Add("ID", typeof(string));
            results.Columns.Add("Bill Of Lading No.", typeof(string));
            results.Columns.Add("Shipper Name", typeof(string));
            results.Columns.Add("Supplier Company", typeof(string));
            results.Columns.Add("Trailer ID", typeof(string));
            results.Columns.Add("Seal No.", typeof(string));
            results.Columns.Add("PO No.", typeof(string));
            results.Columns.Add("Description of Contents", typeof(string));
            results.Columns.Add("ETA", typeof(DateTime));
            results.Columns.Add("Quantity", typeof(string));
            results.Columns.Add("Arrival Status", typeof(string));

            //string userChoice = txtFilter.Text;

            // This is the default sql query to fill in the datagrid view of all Bill of Lading's

            string Query = "SELECT BOL.BOL_ID,BOL.BOL_NO,BOL.CARRIER,BOL.SUPPLIER,BOL.TRAILER_ID,BOL.SEAL_NO,BOL.PO_NO,BOL.componentsdesc,BOL.ETA,TRAILER.QUANTITY,BOL.ARRIVALSTATUS" +
      " FROM BOL,TRAILER WHERE BOL.BOL_ID = TRAILER.TRAILER_ID ORDER BY BOL_ID DESC";
            // This is the selection for searching by Trailer ID. The second IF statement checks to see if
            // the search is empty. If it is the program will inform the user there was no text input.
            // After this the program will do a full or partial search to allow the user to search as needed.
            if (cboSearch.SelectedIndex == 0)
            {
                if (txtFilter.Text.Equals(""))
                {
                    MessageBox.Show("No text input!");
                }
                else
                {
                    Query = "SELECT BOL.BOL_ID,BOL.BOL_NO,BOL.CARRIER,BOL.SUPPLIER,BOL.TRAILER_ID,BOL.SEAL_NO,BOL.PO_NO,BOL.componentsdesc,BOL.ETA,TRAILER.QUANTITY,BOL.ARRIVALSTATUS" +
      " FROM BOL,TRAILER WHERE BOL.BOL_ID = TRAILER.TRAILER_ID AND BOL.TRAILER_ID LIKE '" + txtFilter.Text + "%' ORDER BY BOL_ID DESC";
                }

            }
            // This is the selection for searching by Bill of Lading number. The second IF statement checks to see if
            // the search is empty. If it is the program will inform the user there was no text input.
            // After this the program will do a full or partial search to allow the user to search as needed.
            else if (cboSearch.SelectedIndex == 1)
            {
                if (txtFilter.Text.Equals(""))
                {
                    MessageBox.Show("No text input!");
                }
                else
                {
                    Query = "SELECT BOL.BOL_ID,BOL.BOL_NO,BOL.CARRIER,BOL.SUPPLIER,BOL.TRAILER_ID,BOL.SEAL_NO,BOL.PO_NO,BOL.componentsdesc,BOL.ETA,TRAILER.QUANTITY,BOL.ARRIVALSTATUS" +
                " FROM BOL,TRAILER WHERE BOL.TRAILER_ID = TRAILER.TRAILER_NO AND BOL.BOL_NO LIKE '" + txtFilter.Text + "%' ORDER BY ARRIVALSTATUS DESC";
                }
            }
            // This is the selection for searching by Purchase Order Number. The second IF statement checks to see if
            // the search is empty. If it is the program will inform the user there was no text input.
            // After this the program will do a full or partial search to allow the user to search as needed.
            else if (cboSearch.SelectedIndex == 2)
            {
                if (txtFilter.Text.Equals(""))
                {
                    MessageBox.Show("No text input!");
                }
                else
                {
                    Query = "SELECT BOL.BOL_ID,BOL.BOL_NO,BOL.CARRIER,BOL.SUPPLIER,BOL.TRAILER_ID,BOL.SEAL_NO,BOL.PO_NO,BOL.componentsdesc,BOL.ETA,TRAILER.QUANTITY,BOL.ARRIVALSTATUS" +
      " FROM BOL,TRAILER WHERE BOL.TRAILER_ID = TRAILER.TRAILER_NO AND BOL.PO_NO LIKE '" + txtFilter.Text + "%' ORDER BY ARRIVALSTATUS DESC";
                }
            }
            // NOTE there is no "SelectedIndex 3" The reasoning behind this, is that above I have a default SQL query above so the sql query would have repeated itself.

            // Connection to ODBC database.
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");

            // This is the command being built with the SQL command "Query" and the connection it is being sent to "Conn"
            OdbcCommand cmd = new OdbcCommand(Query, Conn);

            OdbcDataAdapter ODA = new OdbcDataAdapter(cmd);
            // Opens the connection for the SQL query to be sent in.
            Conn.Open();
            // Executes the sql query to the database.
            OdbcDataReader rdr = cmd.ExecuteReader();
            // This is the results from the SQL statement. This fills the data table in with the requested results needed. 
           
            while (rdr.Read())
            {
                
                results.Rows.Add(
                rdr.GetInt32(0),
                rdr.GetString(1),
                rdr.GetString(2),
                rdr.GetString(3),
                rdr.GetString(4),
                rdr.GetString(5),
                rdr.GetInt32(6),
                rdr.GetString(7),
                rdr.GetDate(8),
                rdr.GetString(9),
                rdr.GetString(10)
                
               );
            }
            
            // Cleans out the datagrid view.
            DGBOL.DataSource = null;
            // Updates the datagrid view, I'm not sure why this needs to be there but it does to make things work.
            DGBOL.Update();
            // This sets the datagrid view's data source to the data table I created above.
            DGBOL.DataSource = results;
            // This is for cleaning up the connection.
            cmd.Dispose();
            // Closes the connection since we don't need it anymore.
            Conn.Close();
            foreach (DataGridViewRow row in this.DGBOL.Rows){
                if (row.Cells[10].Value.ToString() == "Expected")
                {

                    row.DefaultCellStyle.BackColor = Color.SpringGreen;
                }
            }
        }

        private void btnArrived_Click(object sender, EventArgs e)
        {
         Object BOL_NO = DGBOL.SelectedRows[0].Cells[0].Value;
         // This grabs the Bill of Lading ID from the cell the user selected. This needs to be put into an object initially.
         Object BOL_ID = DGBOL.SelectedRows[0].Cells[1].Value;
         // This grabs the Trailers status(Arrived, Expected) from the cell the user selected. This needs to be put into an object initially.
         Object Status = DGBOL.SelectedRows[0].Cells[10].Value;
         // This converts the object to a string so the Bill of Lading ID can be read by the complier to use in an SQL Query.
         string SQLBOL_ID = Convert.ToString(BOL_ID);
         // This is converted so the IF statement below can evaluate whether the trailer has already arrived or not.
         string TrailerStatus = Convert.ToString(Status);

         string SQLBOL_NO = Convert.ToString(BOL_NO);

                // If the trailer has arrived, it can't arrive again, so this needs to handled.
                if (TrailerStatus == "Arrived")
                {
                    // Message to inform the user they probably selected the wrong row.
                    MessageBox.Show("Trailer has already arrived!");
                }
                // If the trailer is "Expected" the trailer will start to be accepted.
                else
                {
                    string TrNo = Convert.ToString(DGBOL.SelectedRows[0].Cells[4].Value);
                    string TS = Convert.ToString(DGBOL.SelectedRows[0].Cells[5].Value);
                    string Quantity = Convert.ToString(DGBOL.SelectedRows[0].Cells[9].Value);
                    // This creates the form that will let the Dispatcher put a lot in.
                    var Accept = new PlaceTrailerInLot(TrNo);
                        
                    /* Shows up the lot screen. I bring this screen up initially so the Dispatcher can place a trailer in a lot 
                       and then once it closes observe how the cell "Trailer Status" will switch from "Expected" to "Arrived"
                       giving a feeling of confirmation besides the initial text box coming up. */
                    Accept.ShowDialog();
                    /* This flips the cell trailer status to arrived. There was two ways to go about this. You could either refresh
                       the whole page which may cause preformance issues later on if there was a massive amounts of Bill of Ladings
                       Or I could manually artificially change it for the user. However in doing this if the user was to exit out and
                       open up the application again the change would be permenent. */

                    DGBOL.SelectedRows[0].Cells[10].Value = "Arrived";
                    // The query to switch the trailer from "Expected" to "Arrived" based on the Bill of Lading ID.
                    string ChangeStatus = "UPDATE BOL SET ARRIVALSTATUS = 'Arrived' WHERE BOL_NO = '" + BOL_ID + "'";
                    string Trailer = "INSERT INTO TRAILER (TRAILER_NO,SEAL_NO,QUANTITY) values('"+TrNo+"','"+TS+"','"+Quantity+"')";
                    // Opens connection to the ODBC Database.
                    OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                    // This is the command being built with the SQL command "ChangeStatus" and the connection it is being sent to "Conn"
                    OdbcCommand cmdStatus = new OdbcCommand(ChangeStatus, Conn);
                    OdbcCommand cmdTEST = new OdbcCommand(Trailer, Conn);
                    //OdbcDataAdapter ODAStatus = new OdbcDataAdapter(cmdStatus);
                    // Opens the connection.
                    Conn.Open();
                    // This is the result from the query executing.
                   // OdbcDataReader RDRStatus = cmdStatus.ExecuteReader();
                    cmdStatus.ExecuteNonQuery();
                    cmdTEST.ExecuteNonQuery();
                    // Cleans up SQL.
                    cmdStatus.Dispose();
                    // Closes the connection.
                    Conn.Close(); 

            }
    }

        private void btnTrailerInfo_Click(object sender, EventArgs e)
        {
            // This creates the report object.
            var REPORTS = new Report_View();
            // This opens the report.
            REPORTS.Show();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            // If you click requests, the arrivals screen vanishes the requests screen appears, and the various datagrid views are populated.
            panelBOL.Visible = false;
            TabRequest.Visible = true; 
            DisRequests();
            Drivers();
            ReturnDrivers();
            AllRequestsForDay();
            ReturnTrailerRequests();
            FreeTrailers();
         
        }

        private void btnArrivals_Click(object sender, EventArgs e)
        {
            // If you click arrivals, the request screen is gone and the request screen is visible.
            panelBOL.Visible = true;
            TabRequest.Visible = false;
        }

        private void DisRequests()
        {
            // This is the table to hold requests from the dispatcher
            DataTable AllRequests = new DataTable();
            AllRequests.Columns.Add("Request No", typeof(Int32));
            AllRequests.Columns.Add("Component", typeof(string));
            AllRequests.Columns.Add("Supplier", typeof(string));
            AllRequests.Columns.Add("Quantity", typeof(Int32));
            AllRequests.Columns.Add("Status", typeof(string));
            AllRequests.Columns.Add("Time Due", typeof(DateTime));
            AllRequests.Columns.Add("End Location", typeof(string));
            
           
            // connection string.
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            // query to see the information.
            string AllRequestsQuery = "Select Request_No, Component,SUPPLIER,Quantity,Status,SCHEDULED_DATE,END_LOCATION FROM REQUESTS WHERE STATUS = 'Needed'OR STATUS = 'Attention' ORDER BY SCHEDULED_DATE DESC";
            // call for requests.
            OdbcCommand cmdAllRequests = new OdbcCommand(AllRequestsQuery, Conn);
            // open connection.
            Conn.Open();
            // reads from database.
            OdbcDataReader rdrAR = cmdAllRequests.ExecuteReader();
            // information from database.
            while (rdrAR.Read())
            {
                AllRequests.Rows.Add(
                rdrAR.GetInt32(0),
                rdrAR.GetString(1),
                rdrAR.GetString(2),
                rdrAR.GetInt32(3),
                rdrAR.GetString(4),
                rdrAR.GetDateTime(5),
                rdrAR.GetString(6)
                
                );
            }
            // set datagrid view to null
            dgvRequests.DataSource = null;
            // update the datagrid view to set it as empty.
            dgvRequests.Update();
            // set the new datasoursce to the data table.
            dgvRequests.DataSource = AllRequests;
            dgvRequests.Columns[0].Visible = false;

            foreach (DataGridViewRow row in this.dgvRequests.Rows)
            {
                if (row.Cells[4].Value.ToString() == "Attention")
                {

                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
       
            }
            // kill the command.
            cmdAllRequests.Dispose();
            // close the connection.
            Conn.Close();


        }

        private void btnCheckTrailers_Click(object sender, EventArgs e)
        {
            if (dgvRequests.RowCount == 0)
            {

            }
            else
            {

                // Selects part name from database
                Object part = dgvRequests.SelectedRows[0].Cells[1].Value;
                // selects supplier from databse.
                Object Supp = dgvRequests.SelectedRows[0].Cells[2].Value;

                // connection string.
                OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                // If there is no part the dockforeman is probably looking for an empty trailer so I bring up the available trailers
                // for the dispatcher!
                if (Convert.ToString(part) == "None")
                {
                    DataTable AllRequests = new DataTable();

                    AllRequests.Columns.Add("Supplier", typeof(string));

                    AllRequests.Columns.Add("Trailer ID", typeof(string));
                    AllRequests.Columns.Add("Po No", typeof(string));
                    AllRequests.Columns.Add("Location No", typeof(string));
                    AllRequests.Columns.Add("Date Arrived", typeof(string));


                    string PartsAvalQuery = "Select  BOL.SUPPLIER, BOL.TRAILER_ID, BOL.PO_NO,LOCATION.LOT_NO, round(sysdate - BOL.ARRIVALDATE) from LOCATION,BOL WHERE BOL.TRAILER_ID = LOCATION.TRAILER_NO AND LOCATION.LOCATIONSTATUS = 'Occupied' AND BOL.ARRIVALSTATUS='Arrived' AND BOL.SUPPLIER = '" + Convert.ToString(Supp) + "';";

                    OdbcCommand cmdAllEmptyRequests = new OdbcCommand(PartsAvalQuery, Conn);

                    OdbcDataAdapter ODAPartsAval = new OdbcDataAdapter(cmdAllEmptyRequests);

                    Conn.Open();

                    OdbcDataReader rdrPA = cmdAllEmptyRequests.ExecuteReader();

                    while (rdrPA.Read())
                    {
                        AllRequests.Rows.Add(
                        rdrPA.GetString(0),
                        rdrPA.GetString(1),
                        rdrPA.GetString(2),
                        rdrPA.GetString(3),
                        rdrPA.GetString(4)

                        );
                    }

                    dgvPA.DataSource = null;

                    dgvPA.Update();

                    dgvPA.DataSource = AllRequests;
                    cmdAllEmptyRequests.Dispose();

                    Conn.Close();

                }
                // Else there is a part requested. This is handled differently to show the dispatcher available parts in the database that
                // will hopefully fit the dock foremans needs.
                else
                {
                    DataTable AllRequests = new DataTable();

                    AllRequests.Columns.Add("COMPONENT", typeof(string));
                    AllRequests.Columns.Add("Quantity", typeof(string));
                    AllRequests.Columns.Add("SUPPLIER", typeof(string));
                    AllRequests.Columns.Add("Location", typeof(string));
                    AllRequests.Columns.Add("BOL_NO", typeof(string));
                    AllRequests.Columns.Add("PO NO", typeof(Int32));
                    AllRequests.Columns.Add("Trailer NO", typeof(string));
                    AllRequests.Columns.Add("Age", typeof(string));


                    string PartsAvalQuery = "SELECT Componentsdesc,TRAILER.QUANTITY,SUPPLIER,LOCATION_ID,BOL_NO,PO_NO,BOL.TRAILER_ID,round(SYSDATE - BOL.ARRIVALDATE) FROM BOL,TRAILER,LOCATION WHERE Componentsdesc = '" + Convert.ToString(part) + "'AND SUPPLIER = '" + Convert.ToString(Supp) + "' AND  ARRIVALSTATUS = 'Arrived' AND BOL.TRAILER_ID = TRAILER.TRAILER_NO AND LOCATION.TRAILER_NO = TRAILER.TRAILER_NO";
                    //DateDiff('d', {TRAILER.DATE_OF_ARRIVAL}, CurrentDate );
                    //
                    OdbcCommand cmdAllRequests = new OdbcCommand(PartsAvalQuery, Conn);

                    OdbcDataAdapter ODAPartsAval = new OdbcDataAdapter(cmdAllRequests);

                    Conn.Open();

                    OdbcDataReader rdrPA = cmdAllRequests.ExecuteReader();

                    while (rdrPA.Read())
                    {
                        AllRequests.Rows.Add(
                        rdrPA.GetString(0),
                        rdrPA.GetString(1),
                        rdrPA.GetString(2),
                        rdrPA.GetString(3),
                        rdrPA.GetString(4),
                        rdrPA.GetInt32(5),
                        rdrPA.GetString(6)
                       
                       // rdrPA.GetString(7)


                        );
                    }

                    dgvPA.DataSource = null;

                    dgvPA.Update();

                    dgvPA.DataSource = AllRequests;
                    cmdAllRequests.Dispose();

                    Conn.Close();
                }
            }
        }

        private void Drivers()
        {
            // This is just me listing all the drivers in the database so the dispatcher can choose one for his request.
            DataTable Driver = new DataTable();
           Driver.Columns.Add("Employee No", typeof(string));
            Driver.Columns.Add("First Name", typeof(string));
            Driver.Columns.Add("Last Name", typeof(string));
            Driver.Columns.Add("No of Tasks", typeof(string));
           
            
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");

          
           
            string DriverQuery = "Select EMPLOYEE_NO,FIRSTNAME,LASTNAME,count(REQUEST_NO) AS TASKS FROM EMPLOYEE LEFT OUTER JOIN REQUESTS ON EMPLOYEEPASSWORD = EMPLOYEE_ID WHERE EMPLOYEETYPE = 'Driver' GROUP BY EMPLOYEE_NO,FIRSTNAME,LASTNAME ORDER BY TASKS DESC";
           
            OdbcCommand cmdDriver = new OdbcCommand(DriverQuery, Conn);


            Conn.Open();

            OdbcDataReader rdrDR = cmdDriver.ExecuteReader();
            
            while (rdrDR.Read())
            {
                Driver.Rows.Add(
                
             
                //rdrDR.GetString(0),
                rdrDR.GetString(0),
                rdrDR.GetString(1),
                rdrDR.GetString(2),
                rdrDR.GetString(3)
                
             
                );
            }

            dgvDriver.DataSource = null;

            dgvDriver.Update();

            dgvDriver.DataSource = Driver;
            //dgvDriver.Columns[0].Visible = false;
            cmdDriver.Dispose();

            Conn.Close();

        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            // If the text is none give it some text. Why did I do this? When you bring in information from the database into a 
            // datagrid it will crash because the datagrid does not know how to handle null values. This is a sort of work around
            // to get things functional.
            if (txtDPNotes.Text == "")
            {
                txtDPNotes.Text = "None";
            }


            // If the data source is null that means the user didn't push check for parts button, then they didn't use my system right and
            // need a warning message.
            if (dgvRequests.Rows.Count == 0)
            {
                MessageBox.Show("There are no current requests!");
            }
            else if (dgvPA.Rows.Count <= 0)
            {
                MessageBox.Show("Please select a part or empty trailer");
            }
            
            else
            {
                // Select employee ID
                object emp = dgvDriver.SelectedRows[0].Cells[0].Value;
                // Select start Location
                object loc = dgvPA.SelectedRows[0].Cells[3].Value;
                // Select Request Number.
                object ReqNo = dgvRequests.SelectedRows[0].Cells[0].Value;
                // Trailer Number
                object TrNo = dgvPA.SelectedRows[0].Cells[1].Value;

                object Comp = dgvRequests.SelectedRows[0].Cells[1].Value;

                // Query to capture employee password.
                string EmpPass = "SELECT EMPLOYEEPASSWORD FROM EMPLOYEE WHERE EMPLOYEE_NO = '" + Convert.ToString(emp) + "';";
                
                // Conn string
                OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                // command to get employee password.
                OdbcCommand cmdGetPAss = new OdbcCommand(EmpPass, Conn);
                //open
                Conn.Open();
                // put password into pass object.
                Object Pass = cmdGetPAss.ExecuteScalar();

                // close.
                Conn.Close();
                // Dispose command.
                cmdGetPAss.Dispose();
                // Query to driver.
                if (Convert.ToString(Comp) == "None")
                {

                    string SendDriver = "UPDATE REQUESTS SET TRAILER_NO = '" + Convert.ToString(dgvPA.SelectedRows[0].Cells[1].Value) + "', STATUS = 'In Progress' ,EMPLOYEE_ID = '" + Convert.ToString(Pass) + "', NOTES = '" + txtDPNotes.Text + "', LOCATION_ID = '" + Convert.ToString(loc) + "' WHERE REQUEST_NO = '" + Convert.ToString(ReqNo) + "'";
                    OdbcCommand cmdSendDriver = new OdbcCommand(SendDriver, Conn);
                    Conn.Open();
                    // Send command to driver.
                    cmdSendDriver.ExecuteNonQuery();
                    Conn.Close();
                    // Dispose of command.
                    cmdSendDriver.Dispose();
                }
                else
                {
                    string SendDriver = "UPDATE REQUESTS SET TRAILER_NO = '" + Convert.ToString(dgvPA.SelectedRows[0].Cells[6].Value) + "', STATUS = 'In Progress' ,EMPLOYEE_ID = '" + Convert.ToString(Pass) + "', NOTES = '" + txtDPNotes.Text + "', LOCATION_ID = '" + Convert.ToString(loc) + "' WHERE REQUEST_NO = '" + Convert.ToString(ReqNo) + "'";
                    OdbcCommand cmdSendDriver = new OdbcCommand(SendDriver, Conn);
                    Conn.Open();
                    // Send command to driver.
                    cmdSendDriver.ExecuteNonQuery();
                    Conn.Close();
                    // Dispose of command.
                    cmdSendDriver.Dispose();
                }

            }
            // Refresh the requests for the dispatcher.
            DisRequests();
            Drivers();

        }

        private void AllRequestsForDay()
        {
            // Datatable.
            DataTable AllDriverRequestsFD = new DataTable();
            AllDriverRequestsFD.Columns.Add("Request No", typeof(Int32));
            AllDriverRequestsFD.Columns.Add("Component", typeof(string));
            AllDriverRequestsFD.Columns.Add("Supplier", typeof(string));
            AllDriverRequestsFD.Columns.Add("Quantity", typeof(Int32));
            AllDriverRequestsFD.Columns.Add("Status", typeof(string));
            AllDriverRequestsFD.Columns.Add("Time Due", typeof(DateTime));
            AllDriverRequestsFD.Columns.Add("First Name", typeof(string));
            AllDriverRequestsFD.Columns.Add("Last Name", typeof(string));
            // Connections string.
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            // Query
            string AllDriverRequestsQuery = "Select Request_No, Component,SUPPLIER,Quantity,Status,SCHEDULED_DATE,EMPLOYEE.FIRSTNAME,EMPLOYEE.LASTNAME FROM REQUESTS,EMPLOYEE WHERE REQUESTS.EMPLOYEE_ID = EMPLOYEE.EMPLOYEEPASSWORD AND STATUS = 'Finished' ORDER BY STATUS ASC";
            // this is the command for the query.
            OdbcCommand cmdAllDriverRequests = new OdbcCommand(AllDriverRequestsQuery, Conn);
            // opens connection.
            Conn.Open();
            // This reads the information from the database.
            OdbcDataReader rdrADR = cmdAllDriverRequests.ExecuteReader();
            // read in the information from the database.
            while (rdrADR.Read())
            {
                AllDriverRequestsFD.Rows.Add(
                rdrADR.GetInt32(0),
                rdrADR.GetString(1),
                rdrADR.GetString(2),
                rdrADR.GetInt32(3),
                rdrADR.GetString(4),
                rdrADR.GetDateTime(5),
                rdrADR.GetString(6),
                rdrADR.GetString(7)

                );
            }
            // set the table to null.
            dgvAllDriverRequests.DataSource = null;
            // update datagrid view.
            dgvAllDriverRequests.Update();
            // set the datatable to the datasource.
            dgvAllDriverRequests.DataSource = AllDriverRequestsFD;
            dgvAllDriverRequests.Columns[0].Visible = false;
            // dispose of command.
            cmdAllDriverRequests.Dispose();
            // close connection.
            Conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // This refreshes the request list.
            DisRequests();
        }

        private void radNeeded1_CheckedChanged(object sender, EventArgs e)
        {
            // This is the table to hold requests from the dispatcher
            DataTable AllRequests = new DataTable();
            AllRequests.Columns.Add("Request No", typeof(Int32));
            AllRequests.Columns.Add("Component", typeof(string));
            AllRequests.Columns.Add("Supplier", typeof(string));
            AllRequests.Columns.Add("Quantity", typeof(Int32));
            AllRequests.Columns.Add("Status", typeof(string));
            AllRequests.Columns.Add("Time Due", typeof(DateTime));

            // connection string.
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            // query to see the information.
            string AllRequestsQuery = "Select Request_No, Component,SUPPLIER,Quantity,Status,SCHEDULED_DATE FROM REQUESTS WHERE STATUS = 'Needed' ORDER BY STATUS ASC";
            // call for requests.
            OdbcCommand cmdAllRequests = new OdbcCommand(AllRequestsQuery, Conn);
            // open connection.
            Conn.Open();
            // reads from database.
            OdbcDataReader rdrAR = cmdAllRequests.ExecuteReader();
            // information from database.
            while (rdrAR.Read())
            {
                AllRequests.Rows.Add(
                rdrAR.GetInt32(0),
                rdrAR.GetString(1),
                rdrAR.GetString(2),
                rdrAR.GetInt32(3),
                rdrAR.GetString(4),
                rdrAR.GetDateTime(5)

                );
            }
            // set datagrid view to null
            dgvAllDriverRequests.DataSource = null;
            // update the datagrid view to set it as empty.
            dgvAllDriverRequests.Update();
            // set the new datasoursce to the data table.
            dgvAllDriverRequests.DataSource = AllRequests;
            dgvAllDriverRequests.Columns[0].Visible = false;
            // kill the command.
            cmdAllRequests.Dispose();
            // close the connection.
            Conn.Close();
        }

        private void radFinished1_CheckedChanged(object sender, EventArgs e)
        {
            // This shows all the finished requests.
            AllRequestsForDay();
        }

        private void radAll1_CheckedChanged(object sender, EventArgs e)
        {
            //datatable.
            DataTable AllDriverRequestsFD = new DataTable();
            AllDriverRequestsFD.Columns.Add("Request No", typeof(Int32));
            AllDriverRequestsFD.Columns.Add("Component", typeof(string));
            AllDriverRequestsFD.Columns.Add("Supplier", typeof(string));
            AllDriverRequestsFD.Columns.Add("Quantity", typeof(Int32));
            AllDriverRequestsFD.Columns.Add("Status", typeof(string));
            AllDriverRequestsFD.Columns.Add("Time Due", typeof(DateTime));
            AllDriverRequestsFD.Columns.Add("First Name", typeof(string));
            AllDriverRequestsFD.Columns.Add("Last Name", typeof(string));
            // connection string.
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            // Query.
            string AllDriverRequestsQuery = "Select Request_No, Component,SUPPLIER,Quantity,Status,SCHEDULED_DATE,EMPLOYEE.FIRSTNAME,EMPLOYEE.LASTNAME FROM REQUESTS,EMPLOYEE WHERE REQUESTS.EMPLOYEE_ID = EMPLOYEE.EMPLOYEEPASSWORD ORDER BY STATUS ASC";
            // this is the command to see all of the driver requests.
            OdbcCommand cmdAllDriverRequests = new OdbcCommand(AllDriverRequestsQuery, Conn);
            // opens connection.
            Conn.Open();
            // this reads the information in the database.
            OdbcDataReader rdrADR = cmdAllDriverRequests.ExecuteReader();
            // fills datatable with information from database.
            while (rdrADR.Read())
            {
                AllDriverRequestsFD.Rows.Add(
                rdrADR.GetInt32(0),
                rdrADR.GetString(1),
                rdrADR.GetString(2),
                rdrADR.GetInt32(3),
                rdrADR.GetString(4),
                rdrADR.GetDateTime(5),
                rdrADR.GetString(6),
                rdrADR.GetString(7)

                );
            }
            //sets datagrid view to null
            dgvAllDriverRequests.DataSource = null;
            // updates datagrid view.
            dgvAllDriverRequests.Update();
            // sets data table to datasource.
            dgvAllDriverRequests.DataSource = AllDriverRequestsFD;
            dgvAllDriverRequests.Columns[0].Visible = false;
            // cleans up command.
            cmdAllDriverRequests.Dispose();
            // Closes connection.
            Conn.Close();
        }

        private void radInProgress1_CheckedChanged(object sender, EventArgs e)
        {
            //datatable.
            DataTable AllDriverRequestsFD = new DataTable();
            AllDriverRequestsFD.Columns.Add("Request No", typeof(Int32));
            AllDriverRequestsFD.Columns.Add("Component", typeof(string));
            AllDriverRequestsFD.Columns.Add("Supplier", typeof(string));
            AllDriverRequestsFD.Columns.Add("Quantity", typeof(Int32));
            AllDriverRequestsFD.Columns.Add("Status", typeof(string));
            AllDriverRequestsFD.Columns.Add("Time Due", typeof(DateTime));
            AllDriverRequestsFD.Columns.Add("First Name", typeof(string));
            AllDriverRequestsFD.Columns.Add("Last Name", typeof(string));
            // connection string.
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            // Query.
            string AllDriverRequestsQuery = "Select Request_No, Component,SUPPLIER,Quantity,Status,SCHEDULED_DATE,EMPLOYEE.FIRSTNAME,EMPLOYEE.LASTNAME FROM REQUESTS,EMPLOYEE WHERE REQUESTS.EMPLOYEE_ID = EMPLOYEE.EMPLOYEEPASSWORD AND STATUS = 'In Progress' ORDER BY STATUS ASC";
            // this is the command to see all of the driver requests.
            OdbcCommand cmdAllDriverRequests = new OdbcCommand(AllDriverRequestsQuery, Conn);
            // opens connection.
            Conn.Open();
            // this reads the information in the database.
            OdbcDataReader rdrADR = cmdAllDriverRequests.ExecuteReader();
            // fills datatable with information from database.
            while (rdrADR.Read())
            {
                AllDriverRequestsFD.Rows.Add(
                rdrADR.GetInt32(0),
                rdrADR.GetString(1),
                rdrADR.GetString(2),
                rdrADR.GetInt32(3),
                rdrADR.GetString(4),
                rdrADR.GetDateTime(5),
                rdrADR.GetString(6),
                rdrADR.GetString(7)

                );
            }
            //sets datagrid view to null
            dgvAllDriverRequests.DataSource = null;
            // updates datagrid view.
            dgvAllDriverRequests.Update();
            // sets data table to datasource.
            dgvAllDriverRequests.DataSource = AllDriverRequestsFD;
            dgvAllDriverRequests.Columns[0].Visible = false;
            // cleans up command.
            cmdAllDriverRequests.Dispose();
            // Closes connection.
            Conn.Close();
        }

        private void btnLotView_Click(object sender, EventArgs e)
        {
            Form LV = new LotView();
            LV.Show();
        }

        private void ReturnTrailerRequests()
        {
      
            // This is the table to hold requests from the dispatcher
            DataTable AllRequests = new DataTable();
            AllRequests.Columns.Add("Request No", typeof(Int32));
            AllRequests.Columns.Add("Supplier", typeof(string));
            AllRequests.Columns.Add("Status", typeof(string));
            AllRequests.Columns.Add("Time Due", typeof(DateTime));
            
            AllRequests.Columns.Add("Trailer No", typeof(string));
            AllRequests.Columns.Add("Bay", typeof(string));
            
           
            // connection string.
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            // query to see the information.
            string AllRequestsQuery = "Select Request_No,SUPPLIER,Status,SCHEDULED_DATE,TRAILER_NO,LOCATION_ID FROM REQUESTS WHERE STATUS = 'Return' ORDER BY STATUS ASC";
            // call for requests.
            OdbcCommand cmdAllRequests = new OdbcCommand(AllRequestsQuery, Conn);
            // open connection.
            Conn.Open();
            // reads from database.
            OdbcDataReader rdrAR = cmdAllRequests.ExecuteReader();
            // information from database.
            while (rdrAR.Read())
            {
                AllRequests.Rows.Add(
                rdrAR.GetInt32(0),             
                rdrAR.GetString(1),
                rdrAR.GetString(2),
                rdrAR.GetDateTime(3),
                rdrAR.GetString(4),
                rdrAR.GetString(5)
               
                );
            }
            // set datagrid view to null
            dgvSTB.DataSource = null;
            // update the datagrid view to set it as empty.
            dgvSTB.Update();
            // set the new datasoursce to the data table.
            dgvSTB.DataSource = AllRequests;
            dgvSTB.Columns[0].Visible = false;
            // kill the command.
            cmdAllRequests.Dispose();
            // close the connection.
            Conn.Close();
        }

        private void btnTrailerMap_Click(object sender, EventArgs e)
        {
            Form TM = new LotView();
            TM.Show();
        }

        private void ReturnDrivers ()
        {
        
            // This is just me listing all the drivers in the database so the dispatcher can choose one for his request.
            DataTable Driver = new DataTable();
           Driver.Columns.Add("Employee No", typeof(string));
            Driver.Columns.Add("First Name", typeof(string));
            Driver.Columns.Add("Last Name", typeof(string));
            Driver.Columns.Add("No of Tasks", typeof(string));
           
            
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");

            string DriverQuery = "Select EMPLOYEE_NO,FIRSTNAME,LASTNAME,count(REQUEST_NO) AS TASKS FROM EMPLOYEE LEFT OUTER JOIN REQUESTS ON EMPLOYEEPASSWORD = EMPLOYEE_ID WHERE EMPLOYEETYPE = 'Driver' GROUP BY EMPLOYEE_NO,FIRSTNAME,LASTNAME ORDER BY TASKS DESC";
            //string DriverQuery = "Select FIRSTNAME,LASTNAME,COUNT(NVL(EMPLOYEE_ID,0)) AS TASKS FROM EMPLOYEE,REQUESTS   GROUP BY FIRSTNAME,LASTNAME";
            OdbcCommand cmdDriver = new OdbcCommand(DriverQuery, Conn);

            Conn.Open();

            OdbcDataReader rdrDR = cmdDriver.ExecuteReader();
            
            while (rdrDR.Read())
            {
                Driver.Rows.Add(

                rdrDR.GetString(0),
                rdrDR.GetString(1),
                rdrDR.GetString(2),
                rdrDR.GetString(3)

                );
            }

            DGVDrivers.DataSource = null;

            DGVDrivers.Update();

            DGVDrivers.DataSource = Driver;
            DGVDrivers.Columns[0].Visible = false;
            cmdDriver.Dispose();

            Conn.Close();

        }
        private void FreeTrailers()
        {
            DataTable Trailers = new DataTable();
            Trailers.Columns.Add("Available", typeof(Int32));
            string Query = "Select LOCATION_ID from LOCATION where LOCATION_ID <300 AND LOCATIONSTATUS = 'Available'";
            // Connection to ODBC database.
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");

            // This is the command being built with the SQL command "Query" and the connection it is being sent to "Conn"
            OdbcCommand cmd = new OdbcCommand(Query, Conn);

            Conn.Open();
            // Executes the sql query to the database.
            OdbcDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                Trailers.Rows.Add(
                rdr.GetInt32(0)


                );
            }
            // Cleans out the datagrid view.
            dgvFreeTrailers.DataSource = null;
            // Updates the datagrid view, I'm not sure why this needs to be there but it does to make things work.
            dgvFreeTrailers.Update();
            // This sets the datagrid view's data source to the data table I created above.
            dgvFreeTrailers.DataSource = Trailers;
            // This is for cleaning up the connection.
            cmd.Dispose();
            // Closes the connection since we don't need it anymore.
            Conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // If the data source is null that means the user didn't push check for parts button, then they didn't use my system right and
            // need a warning message.  
            if (dgvSTB.Rows.Count == 0)
            {
                MessageBox.Show("Please select a part or empty trailer");
            }
            // They did the right thing!

            else
            {

                if (txtDPNotes.Text == "")
                {
                    txtDPNotes.Text = "None";
                }
                // Select employee ID
                object emp = DGVDrivers.SelectedRows[0].Cells[0].Value;
                // Select start Location
                object loc = dgvFreeTrailers.SelectedRows[0].Cells[0].Value;
                // Select Request Number.
                object ReqNo = dgvSTB.SelectedRows[0].Cells[0].Value;
                // Trailer Number
                
                
                // Query to capture employee password.
                string EmpPass = "SELECT EMPLOYEEPASSWORD FROM EMPLOYEE WHERE EMPLOYEE_NO = '" + Convert.ToString(emp) + "';";
              
                // Conn string
                OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                // command to get employee password.
                OdbcCommand cmdGetPAss = new OdbcCommand(EmpPass, Conn);
                //open
                Conn.Open();
                // put password into pass object.
                Object Pass = cmdGetPAss.ExecuteScalar();
                // close.
                Conn.Close();
                // Dispose command.
                cmdGetPAss.Dispose();
                // Query to driver.
                string SendDriver = "UPDATE REQUESTS SET STATUS = 'In Progress' ,EMPLOYEE_ID = '" + Convert.ToString(Pass) + "', NOTES = '" + txtDPNotes.Text + "', END_LOCATION = '" + Convert.ToString(loc) + "' WHERE REQUEST_NO = '" + Convert.ToString(ReqNo) + "'";
                Object Bay = dgvSTB.SelectedRows[0].Cells[5].Value;
                string FreeBay = "UPDATE LOCATION SET LOCATIONSTATUS = 'Available', TRAILER_NO = 0 WHERE LOT_NO = '" + Convert.ToString(Bay) + "'";
                string LotEntering = "UPDATE LOCATION SET LOCATIONSTATUS = 'Moving' WHERE LOCATION_ID = '" + Convert.ToString(loc) + "'";
                OdbcCommand cmdSendDriver = new OdbcCommand(SendDriver, Conn);
                OdbcCommand cmdFreeBay = new OdbcCommand(FreeBay, Conn);
                OdbcCommand cmdLotStatus = new OdbcCommand(LotEntering, Conn);
                Conn.Open();
                // Send command to driver.
                cmdSendDriver.ExecuteNonQuery();
                cmdFreeBay.ExecuteNonQuery();
                cmdLotStatus.ExecuteNonQuery();
                Conn.Close();
                // Dispose of command. 
                cmdSendDriver.Dispose();
                cmdFreeBay.Dispose();
                cmdLotStatus.Dispose();

                // Refresh the requests for the dispatcher.
                DisRequests();
                FreeTrailers();
                ReturnTrailerRequests();
                ReturnDrivers();
            }
        }

        private void TabRequest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBayView_Click(object sender, EventArgs e)
        {
            Form Bays = new BayStatus();
            Bays.Show();
        }

        private void btnLots_Click(object sender, EventArgs e)
        {
            Form Lots = new LotView();
            Lots.Show();
        }

    }
}
