using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace DockForemanInterface
{
    public partial class Form1 : Form
    {
        
       public Form1(string Emp)
        {
            InitializeComponent();
            string employeePassword = Emp;
            lblEmpId.Text = employeePassword;
            BayLocations();
            EmptyTrailerDGV();
            
            EBayLocations();
            baysFilled();
            cboDeparture.SelectedIndex = 0;
            
        }
        


        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            // if you search you can press submit since you'll have a trailer selected.
            btnSubmit.Visible = true;

            // This is the results of your search.
            DataTable results = new DataTable();
            results.Columns.Add("Part", typeof(string));
            results.Columns.Add("Supplier", typeof(string));
            results.Columns.Add("Quantity", typeof(Int32));
            results.Columns.Add("Trailer ID", typeof(string));
            results.Columns.Add("Seal No. ", typeof(string));
            results.Columns.Add("PO No. ", typeof(Int32));
            results.Columns.Add("Trailer Location ", typeof(string));
            
            // Four queries on what you want to search by.
            string query = "Select BOL.Componentsdesc,BOL.SUPPLIER,TRAILER.QUANTITY,BOL.TRAILER_ID,BOL.SEAL_NO,BOL.PO_NO,LOCATION.LOT_NO FROM BOL,LOCATION,TRAILER WHERE BOL.TRAILER_ID = TRAILER.TRAILER_NO AND BOL.TRAILER_ID = LOCATION.TRAILER_NO AND ARRIVALSTATUS = 'Arrived' AND LOCATION_ID < 300 AND LOCATIONSTATUS='Occupied' AND componentsdesc <> 'None'";

            if (cboSearchBy.SelectedIndex == 0)
            {
                query = "Select BOL.Componentsdesc,BOL.SUPPLIER,TRAILER.QUANTITY,BOL.TRAILER_ID,BOL.SEAL_NO,BOL.PO_NO,LOCATION.LOT_NO FROM BOL,LOCATION,TRAILER WHERE BOL.TRAILER_ID = TRAILER.TRAILER_NO AND BOL.TRAILER_ID = LOCATION.TRAILER_NO AND ARRIVALSTATUS = 'Arrived' AND LOCATION_ID < 300 AND LOCATIONSTATUS='Occupied' AND componentsdesc <> 'None'";
            }
            else if (cboSearchBy.SelectedIndex == 1)
            {
                query = "Select BOL.Componentsdesc,BOl.SUPPLIER,TRAILER.QUANTITY,BOL.TRAILER_ID,BOL.SEAL_NO,BOL.PO_NO,LOCATION.LOT_NO FROM BOL,LOCATION,TRAILER WHERE BOL.TRAILER_ID = TRAILER.TRAILER_NO AND BOL.Componentsdesc LIKE '" + txtSearchValue.Text + "%' AND ARRIVALSTATUS = 'Arrived' AND BOL.TRAILER_ID = LOCATION.TRAILER_NO AND LOCATIONSTATUS='Occupied' AND LOCATION_ID < 300  AND componentsdesc <> 'None'";
            }
            else if (cboSearchBy.SelectedIndex == 2)
            {
                query = "Select BOL.Componentsdesc,BOl.SUPPLIER,TRAILER.QUANTITY,BOL.TRAILER_ID,BOL.SEAL_NO,BOL.PO_NO,LOCATION.LOT_NO FROM BOL,LOCATION,TRAILER WHERE BOL.TRAILER_ID = TRAILER.TRAILER_NO AND ARRIVALSTATUS = 'Arrived' AND BOL.TRAILER_ID = LOCATION.TRAILER_NO AND  BOL.PO_NO LIKE '" + txtSearchValue.Text + "%'  AND LOCATION_ID < 300 AND LOCATIONSTATUS='Occupied'  AND componentsdesc <> 'None'";
            }
            else if (cboSearchBy.SelectedIndex == 3)
            {
                query = "Select BOL.Componentsdesc,BOl.SUPPLIER,TRAILER.QUANTITY,BOL.TRAILER_ID,BOL.SEAL_NO,BOL.PO_NO,LOCATION.LOT_NO FROM BOL,LOCATION,TRAILER WHERE BOL.TRAILER_ID = TRAILER.TRAILER_NO AND BOL.TRAILER_ID LIKE '" + txtSearchValue.Text + "%'  AND ARRIVALSTATUS = 'Arrived' AND BOL.TRAILER_ID = LOCATION.TRAILER_NO AND LOCATIONSTATUS='Occupied'  AND LOCATION_ID < 300  AND componentsdesc <> 'None'";
            }
            // connection string
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            // command
            OdbcCommand cmd = new OdbcCommand(query, Conn);
            // Adapter.
            OdbcDataAdapter ODA = new OdbcDataAdapter(cmd);
            // open connection.
            Conn.Open();
            // reads in data.
            OdbcDataReader rdr = cmd.ExecuteReader();
            // reads the data and adds them to rows.
            while (rdr.Read())
            {
                results.Rows.Add(
                    rdr.GetString(0),
                    rdr.GetString(1),
                    rdr.GetString(2),
                    rdr.GetString(3),
                    rdr.GetString(4),
                    rdr.GetString(5),
                    rdr.GetString(6)
                    
                    );
            }
            
            // set the datagrid View to null
            dgvPartsView.DataSource = null;
            // update table to clear it.
            dgvPartsView.Update();
            // set the datasource to the data table.
            dgvPartsView.DataSource = results;
            // dispose command
            cmd.Dispose();
            // close connection.
            Conn.Close();
            // Set the bays you can chose from to true.
            PanelBays.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'currentRequests.REQUESTS' table. You can move, or remove it, as needed.
            this.rEQUESTSTableAdapter.Fill(this.currentRequests.REQUESTS);
            
        }


        private void btnSubmit_Click_2(object sender, EventArgs e)
        {
            // this checks the length of the number of quanties you put in.
            int textLength = txtQuantity.Text.Length;
            // If the notes are empty, give it a defualt value to keep it from going null.
            if (txtNotes.Text == "")
            {
                txtNotes.Text = "Empty";
            }
            // Up above I checked the length of quantities. I did this so I can check to see if there was a letter put in
            // There doesn't seem to be an isnumeric function in C#
            for (int i = 0; i < textLength; i++)
            {
                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Fill in Quantities textbox!");
                }
                else if (!char.IsNumber(txtQuantity.Text[i]))
                {
                    MessageBox.Show("Please only put in a number");
                    break;
                }
                // else it must be all fine.
                else
                {
                  
                    Object obPart = dgvPartsView.SelectedRows[0].Cells[0].Value;
                    Object obSupplier = dgvPartsView.SelectedRows[0].Cells[1].Value;
                    Object obBayarea = dgvBays.SelectedRows[0].Cells[0].Value;
                    // trailer location.
                    Object oTriLoc = dgvPartsView.SelectedRows[0].Cells[6].Value;
                    Object Area = dgvBays.SelectedRows[0].Cells[2].Value;
                    

                    string TrailerLocation = Convert.ToString(oTriLoc);
                    string part = Convert.ToString(obPart);
                    string Supplier = Convert.ToString(obSupplier);
                    string quantity     = txtQuantity.Text;
                    string Bayarea = Convert.ToString(obBayarea);
                    // conneciton string.
                    OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                    string UpdateLocation = "UPDATE LOCATION SET LOCATIONSTATUS = 'Moving' WHERE LOT_NO = '" + TrailerLocation + "'";
                    string BayLocation = "UPDATE LOCATION SET LOCATIONSTATUS ='Moving' WHERE LOT_NO = '" + Bayarea + "'";
                    
                   OdbcCommand CL = new OdbcCommand(UpdateLocation, Conn);
                    OdbcCommand CBL = new OdbcCommand(BayLocation, Conn);
                   
                    OdbcCommand cmd = new OdbcCommand("INSERT INTO REQUESTS(Component,quantity,NOTES,SCHEDULED_DATE,END_LOCATION,Supplier) VALUES(?,?,?,?,?,?)", Conn);
                    
                    
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = part;
                    cmd.Parameters.Add("?", OdbcType.Int).Value = Convert.ToInt32(quantity);
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtNotes.Text;
                    cmd.Parameters.Add("?", OdbcType.DateTime).Value = dtpRequest.Value;
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = Bayarea;
                    cmd.Parameters.Add("?", OdbcType.VarChar).Value = Supplier;
                    
                    
                    // Send in Dock as well.
                    
                    Conn.Open();
                    CL.ExecuteNonQuery();
                    CBL.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                   
                    Conn.Close();
                    
                    MessageBox.Show("Request has been sent!");
                    BayLocations();
                    EBayLocations();
                    // I use a break here either it'll go through as many times as the quanties length is large
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if a bay is select then let the user submit.
            if (dgvBays.SelectedRows[0].Cells[0].Selected == true)
            {
                btnSubmit.Visible = true;
            }
        }
        private void BayLocations()
        {
            DataTable Bays = new DataTable();
            Bays.Columns.Add("Location_ID", typeof(string));
            Bays.Columns.Add("Bay No", typeof(Int32));
            Bays.Columns.Add("Area", typeof(string));
            Bays.Columns.Add("Status", typeof(string));
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            
           if (lblEmpId.Text == "DF1")
            {
            
                string bayQuery = "Select LOT_NO,location_id,LOCATIONAREA, LOCATIONSTATUS FROM LOCATION WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Available' AND LOCATIONAREA = 'East'";

                OdbcCommand cmdBay = new OdbcCommand(bayQuery, Conn);

                OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                Conn.Open();

                OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                while (rdrBay.Read())
                {
                    Bays.Rows.Add(
                    rdrBay.GetString(0),
                    rdrBay.GetInt32(1),
                    rdrBay.GetString(2),
                    rdrBay.GetString(3)
                    );
                }
                dgvBays.DataSource = null;

                dgvBays.Update();

                dgvBays.DataSource = Bays;
                dgvBays.Columns[1].Visible = false;
                cmdBay.Dispose();

                Conn.Close();
            }
             if (lblEmpId.Text == "DF2")
            {
                string bayQuery = "Select LOT_NO,location_id,LOCATIONAREA, LOCATIONSTATUS FROM LOCATION WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Available' AND LOCATIONAREA = 'South'";

                OdbcCommand cmdBay = new OdbcCommand(bayQuery, Conn);

                OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                Conn.Open();

                OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                while (rdrBay.Read())
                {
                    Bays.Rows.Add(
                    rdrBay.GetString(0),
                    rdrBay.GetInt32(1),
                    rdrBay.GetString(2),
                    rdrBay.GetString(3)
                    );
                }
                dgvBays.DataSource = null;

                dgvBays.Update();

                dgvBays.DataSource = Bays;
                dgvBays.Columns[1].Visible = false;
                cmdBay.Dispose();

                Conn.Close();
            }
            else if (lblEmpId.Text == "DF3")
            {
                string bayQuery = "Select LOT_NO,location_id,LOCATIONAREA, LOCATIONSTATUS FROM LOCATION WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Available' AND LOCATIONAREA = 'West'";

                OdbcCommand cmdBay = new OdbcCommand(bayQuery, Conn);

                OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                Conn.Open();

                OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                while (rdrBay.Read())
                {
                    Bays.Rows.Add(
                    rdrBay.GetString(0),
                    rdrBay.GetInt32(1),
                    rdrBay.GetString(2),
                    rdrBay.GetString(3)
                    );
                }
                dgvBays.DataSource = null;

                dgvBays.Update();

                dgvBays.DataSource = Bays;
                dgvBays.Columns[1].Visible = false;
                cmdBay.Dispose();

                Conn.Close();
            }
            else if(lblEmpId.Text == "DF4")
            {
                string bayQuery = "Select LOT_NO,location_id,LOCATIONAREA, LOCATIONSTATUS FROM LOCATION WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Available' AND LOCATIONAREA = 'North'";

                OdbcCommand cmdBay = new OdbcCommand(bayQuery, Conn);

                OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                Conn.Open();

                OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                while (rdrBay.Read())
                {
                    Bays.Rows.Add(
                    rdrBay.GetString(0),
                    rdrBay.GetInt32(1),
                    rdrBay.GetString(2),
                    rdrBay.GetString(3)
                    );
                }
                dgvBays.DataSource = null;

                dgvBays.Update();

                dgvBays.DataSource = Bays;
                dgvBays.Columns[1].Visible = false;
                cmdBay.Dispose();

                Conn.Close();
            }
            

            

        }

        private void EmptyTrailerDGV()
        {
            // shows all the empty trailers
            DataTable ETrailer = new DataTable();
       
            ETrailer.Columns.Add("Supplier", typeof(string));
            ETrailer.Columns.Add("Carrier", typeof(string));

            string query = "Select DISTINCT SUPPLIER,CARRIER from BOL";
           
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                
            OdbcCommand cmd = new OdbcCommand(query, Conn);

            OdbcDataAdapter ODA = new OdbcDataAdapter(cmd);

            Conn.Open();

            OdbcDataReader rdrBay = cmd.ExecuteReader();

            while (rdrBay.Read())
            {
                ETrailer.Rows.Add(         
                rdrBay.GetString(0),
                rdrBay.GetString(1)
                );
            }

            dgvEmpty.DataSource = null;

            dgvEmpty.Update();

            dgvEmpty.DataSource = ETrailer;

            cmd.Dispose();

            Conn.Close();
            
        }
        private void AllRequests()
        {
            
            //shows all the requests in progress
            DataTable AllRequests = new DataTable();
            AllRequests.Columns.Add("Request No", typeof(Int32));
            AllRequests.Columns.Add("Component", typeof(string));
            AllRequests.Columns.Add("Quantity", typeof(Int32));
            AllRequests.Columns.Add("Status", typeof(string));
            AllRequests.Columns.Add("Trailer No", typeof(string));
            AllRequests.Columns.Add("PO No", typeof(string));
            AllRequests.Columns.Add("Bay", typeof(string));

            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            string AllRequestsQuery = "Select Request_No, Component, Quantity, Status, Trailer_NO, PO_NO, END_LOCATION FROM REQUESTS WHERE STATUS = 'Needed' OR STATUS = 'Finished' OR STATUS = 'Attention' OR STATUS = 'Broken Seal' OR STATUS = 'Mechanical Problems' ORDER BY STATUS ASC";

            OdbcCommand cmdAllRequests = new OdbcCommand(AllRequestsQuery, Conn);

            OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdAllRequests);

            Conn.Open();

            OdbcDataReader rdrAR = cmdAllRequests.ExecuteReader();

            while (rdrAR.Read())
            {
                AllRequests.Rows.Add(
                rdrAR.GetInt32(0),
                rdrAR.GetString(1),
                rdrAR.GetInt32(2),
                rdrAR.GetString(3),
                rdrAR.GetString(4),
                rdrAR.GetString(5),
                rdrAR.GetString(6)
                );
            }

            DGVRequests.DataSource = null;

            DGVRequests.Update();

            DGVRequests.DataSource = AllRequests;
            cmdAllRequests.Dispose();

            Conn.Close();
            
        }
        private void EBayLocations()
        {
            // show all the empty bay locations.
            
            DataTable Bays = new DataTable();
            Bays.Columns.Add("Location_Id", typeof(string));
            Bays.Columns.Add("Bay No", typeof(string));
            Bays.Columns.Add("Area", typeof(string));
            Bays.Columns.Add("Status", typeof(string));
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            if (lblEmpId.Text == "DF1")
            {
                string bayQuery = "Select LOCATION_ID,LOT_NO,LOCATIONAREA, LOCATIONSTATUS FROM LOCATION WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Available' AND LOCATIONAREA = 'East'";

                OdbcCommand cmdBay = new OdbcCommand(bayQuery, Conn);

                OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                Conn.Open();

                OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                while (rdrBay.Read())
                {
                    Bays.Rows.Add(
                    rdrBay.GetString(0),
                    rdrBay.GetString(1),
                    rdrBay.GetString(2),
                    rdrBay.GetString(3)

                    );

                }

                dgvAvalBays.DataSource = null;

                dgvAvalBays.Update();

                dgvAvalBays.DataSource = Bays;

                dgvAvalBays.Columns[0].Visible = false;
                cmdBay.Dispose();

                Conn.Close();
            }
            else if (lblEmpId.Text == "DF2")
            {
                string bayQuery = "Select LOCATION_ID,LOT_NO,LOCATIONAREA, LOCATIONSTATUS FROM LOCATION WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Available' AND LOCATIONAREA = 'South'";

                OdbcCommand cmdBay = new OdbcCommand(bayQuery, Conn);

                OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                Conn.Open();

                OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                while (rdrBay.Read())
                {
                    Bays.Rows.Add(
                    rdrBay.GetString(0),
                    rdrBay.GetString(1),
                    rdrBay.GetString(2),
                    rdrBay.GetString(3)

                    );

                }

                dgvAvalBays.DataSource = null;

                dgvAvalBays.Update();

                dgvAvalBays.DataSource = Bays;

                dgvAvalBays.Columns[0].Visible = false;
                cmdBay.Dispose();

                Conn.Close();
            }
            else if (lblEmpId.Text == "DF3")
            {
                string bayQuery = "Select LOCATION_ID,LOT_NO,LOCATIONAREA, LOCATIONSTATUS FROM LOCATION WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Available' AND LOCATIONAREA = 'West'";

                OdbcCommand cmdBay = new OdbcCommand(bayQuery, Conn);

                OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                Conn.Open();

                OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                while (rdrBay.Read())
                {
                    Bays.Rows.Add(
                    rdrBay.GetString(0),
                    rdrBay.GetString(1),
                    rdrBay.GetString(2),
                    rdrBay.GetString(3)

                    );

                }

                dgvAvalBays.DataSource = null;

                dgvAvalBays.Update();

                dgvAvalBays.DataSource = Bays;

                dgvAvalBays.Columns[0].Visible = false;
                cmdBay.Dispose();

                Conn.Close();
            }
            else
            {
                string bayQuery = "Select LOCATION_ID,LOT_NO,LOCATIONAREA, LOCATIONSTATUS FROM LOCATION WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Available' AND LOCATIONAREA = 'North'";

                OdbcCommand cmdBay = new OdbcCommand(bayQuery, Conn);

                OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                Conn.Open();

                OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                while (rdrBay.Read())
                {
                    Bays.Rows.Add(
                    rdrBay.GetString(0),
                    rdrBay.GetString(1),
                    rdrBay.GetString(2),
                    rdrBay.GetString(3)

                    );

                }

                dgvAvalBays.DataSource = null;

                dgvAvalBays.Update();

                dgvAvalBays.DataSource = Bays;

                dgvAvalBays.Columns[0].Visible = false;
                cmdBay.Dispose();

                Conn.Close();
            }
            /***************************************************************************
             * USEFUL
             ***************************************************************************/ 
        
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (DGVRequests.Rows.Count == 0)
            {
                MessageBox.Show("No trailers to report!");
            }
            else
            {
                // Allows the foreman to accept a part.
                Object RN = DGVRequests.SelectedRows[0].Cells[0].Value;
                Object status = DGVRequests.SelectedRows[0].Cells[3].Value;
                if (Convert.ToString(status) == "Finished")
                {
                    OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                    OdbcCommand cmdAccepted = new OdbcCommand("UPDATE REQUESTS SET STATUS='arrived' WHERE REQUEST_NO = '" + Convert.ToString(RN) + "';", Conn);

                    Conn.Open();
                    cmdAccepted.ExecuteNonQuery();
                    Conn.Close();

                    AllRequests();
                    DGVRequests.Refresh();
                    DGVRequests.Visible = true;


                    MessageBox.Show("Request has been accepted!!");

                }
                else
                {
                    MessageBox.Show("You can not accept this request!");
                }

            }
             
        }

        private void btnSubmitEmpty_Click(object sender, EventArgs e)
        {
            // submiting empty trailer request.
            if (txtENotes.Text == "")
            {
                txtENotes.Text = "Empty";
            }
            // Object LocationTo = dgvAvalBays.SelectedRows[0].Cells[0].Value;
            Object LocationFrom = dgvAvalBays.SelectedRows[0].Cells[1].Value;

            Object Supp = dgvEmpty.SelectedRows[0].Cells[0].Value;
            
            

            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            string UpdateLocation = "UPDATE LOCATION SET LOCATIONSTATUS = 'Moving' WHERE LOT_NO = '" + Convert.ToString(LocationFrom) + "'";
            OdbcCommand CB = new OdbcCommand(UpdateLocation, Conn);
            OdbcCommand cmd = new OdbcCommand("INSERT INTO REQUESTS(END_LOCATION,SCHEDULED_DATE,NOTES,STATUS,SUPPLIER) VALUES(?,?,?,?,?)", Conn);

            //cmd.Parameters.Add("?", OdbcType.Int).Value = Convert.ToInt32(LocationTo);
            cmd.Parameters.Add("?", OdbcType.VarChar).Value = Convert.ToString(LocationFrom);
            cmd.Parameters.Add("?", OdbcType.DateTime).Value = dtpEmptyTrailer.Value;
            cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtENotes.Text;
            cmd.Parameters.Add("?", OdbcType.VarChar).Value = "Needed";
            cmd.Parameters.Add("?", OdbcType.VarChar).Value = Convert.ToString(Supp);
           

            Conn.Open();
            CB.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            Conn.Close();
            
            EBayLocations();
            EmptyTrailerDGV();
            BayLocations();
            MessageBox.Show("Request has been sent!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Allows foreman to delete an accidental request made.
            if (DGVRequests.Rows.Count == 0)
            {
                MessageBox.Show("No requests to delete!");
            }
            else
            {
            DialogResult Confirmation = MessageBox.Show("Are you sure you want to delete this request?","Confirm Request",MessageBoxButtons.YesNo);
            Object status = DGVRequests.SelectedRows[0].Cells[3].Value;
            Object Bay = DGVRequests.SelectedRows[0].Cells[6].Value;
            

                if (Confirmation == DialogResult.Yes)
                {
                    if (Convert.ToString(status) == "Needed")
                    {
                        OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                        OdbcCommand FreeBay = new OdbcCommand("Update Location SET LOCATIONSTATUS = 'Available' WHERE LOT_NO = '" + Convert.ToString(Bay) + "'", Conn);
                        OdbcCommand Query = new OdbcCommand("DELETE FROM REQUESTS WHERE REQUEST_NO = '" + DGVRequests.SelectedRows[0].Cells[0].Value + "';", Conn);

                        Conn.Open();

                        Query.ExecuteNonQuery();
                        FreeBay.ExecuteNonQuery();
                        Conn.Close();
                        AllRequests();
                        BayLocations();
                        EBayLocations();
                        DGVRequests.Refresh();
                        DGVRequests.Visible = true;

                        MessageBox.Show("Request has been Deleted!");

                    }
                    else
                    {
                        MessageBox.Show("You can not delete this request!");
                    }
                }
            }
        }

        private void btnReportBrokenSeal_Click(object sender, EventArgs e)
        {
            // If a trailer arrives with a broken seal this allows it to be reported.
            if (DGVRequests.Rows.Count == 0)
            {
                MessageBox.Show("No trailers to report!");
            }
            else
            {
                Object TN = DGVRequests.SelectedRows[0].Cells[0].Value;
                Object status = DGVRequests.SelectedRows[0].Cells[3].Value;
                Object bay = DGVRequests.SelectedRows[0].Cells[6].Value;
                if (Convert.ToString(status) == "Finished")
                {
                    OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                    OdbcCommand cmdAccepted = new OdbcCommand("UPDATE REQUESTS SET STATUS='Broken Seal' WHERE REQUEST_NO = '" + Convert.ToString(TN) + "';", Conn);
                    OdbcCommand LotBroke = new OdbcCommand("UPDATE LOCATION SET LOCATIONSTATUS = 'Broken Seal' WHERE LOT_NO = '" + Convert.ToString(bay) + "';", Conn);
                    Conn.Open();
                    cmdAccepted.ExecuteNonQuery();
                    Conn.Close();

                    AllRequests();
                    DGVRequests.Refresh();
                    DGVRequests.Visible = true;


                    MessageBox.Show("Trailer has been reported!");

                }
                else
                {
                    MessageBox.Show("You can not accept this request!");
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // refreshes stuff.
            AllRequests();
            DGVRequests.Refresh();
            DGVRequests.Visible = true;
        }
        private void baysFilled()
        {
            // shows the bay locations to be selected.
            DataTable Bays = new DataTable();
  
            Bays.Columns.Add("Bay No", typeof(string));
            Bays.Columns.Add("Supplier", typeof(string));
            Bays.Columns.Add("Trailer No", typeof(string));

            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");

            string BayQuery;

            if (lblEmpId.Text == "DF1")
            {
                 BayQuery = "Select LOT_NO, SUPPLIER,TRAILER_ID FROM LOCATION,BOL WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Occupied' AND LOCATIONAREA = 'East' AND LOCATION.TRAILER_NO = BOL.TRAILER_ID";

                 OdbcCommand cmdBay = new OdbcCommand(BayQuery, Conn);

                 OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                 Conn.Open();

                 OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                 while (rdrBay.Read())
                 {
                     Bays.Rows.Add(
                     rdrBay.GetString(0),
                     rdrBay.GetString(1),
                     rdrBay.GetString(2)
                  
                     );
                 }
                 dgvTrailerinBays.DataSource = null;

                 dgvTrailerinBays.Update();

                 dgvTrailerinBays.DataSource = Bays;
                 
                 cmdBay.Dispose();

                 Conn.Close();
            }
            else if (lblEmpId.Text == "DF2")
            {
                 
                 BayQuery = "Select LOT_NO, SUPPLIER,TRAILER_ID FROM LOCATION,BOL WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Occupied' AND LOCATIONAREA = 'South' AND LOCATION.TRAILER_NO = BOL.TRAILER_ID";

                 OdbcCommand cmdBay = new OdbcCommand(BayQuery, Conn);

                 OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                 Conn.Open();

                 OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                 while (rdrBay.Read())
                 {
                     Bays.Rows.Add(
                     rdrBay.GetString(0),
                     rdrBay.GetString(1),
                     rdrBay.GetString(2)

                     );
                 }
                 dgvTrailerinBays.DataSource = null;

                 dgvTrailerinBays.Update();

                 dgvTrailerinBays.DataSource = Bays;

                 cmdBay.Dispose();

                 Conn.Close();
            }
            else if (lblEmpId.Text == "DF3")
            {
                BayQuery = "Select LOT_NO, SUPPLIER,TRAILER_ID FROM LOCATION,BOL WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Occupied' AND LOCATIONAREA = 'West' AND LOCATION.TRAILER_NO = BOL.TRAILER_ID";

                OdbcCommand cmdBay = new OdbcCommand(BayQuery, Conn);

                OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                Conn.Open();

                OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                while (rdrBay.Read())
                {
                    Bays.Rows.Add(
                    rdrBay.GetString(0),
                    rdrBay.GetString(1),
                    rdrBay.GetString(2)

                    );
                }
                dgvTrailerinBays.DataSource = null;

                dgvTrailerinBays.Update();

                dgvTrailerinBays.DataSource = Bays;

                cmdBay.Dispose();

                Conn.Close();
            }
            else if (lblEmpId.Text == "DF4")
            {
                BayQuery = "Select LOT_NO, SUPPLIER,TRAILER_ID FROM LOCATION,BOL WHERE LOCATION_ID > 300 AND LOCATIONSTATUS = 'Occupied' AND LOCATIONAREA = 'North' AND LOCATION.TRAILER_NO = BOL.TRAILER_ID";

                OdbcCommand cmdBay = new OdbcCommand(BayQuery, Conn);

                OdbcDataAdapter ODABay = new OdbcDataAdapter(cmdBay);

                Conn.Open();

                OdbcDataReader rdrBay = cmdBay.ExecuteReader();

                while (rdrBay.Read())
                {
                    Bays.Rows.Add(
                    rdrBay.GetString(0),
                    rdrBay.GetString(1),
                    rdrBay.GetString(2)

                    );
                }
                dgvTrailerinBays.DataSource = null;

                dgvTrailerinBays.Update();

                dgvTrailerinBays.DataSource = Bays;

                cmdBay.Dispose();

                Conn.Close();
            }

        }


        private void btnReturnTrailer_Click(object sender, EventArgs e)
        {
            if (dgvTrailerinBays.Rows.Count == 0)
            {
                MessageBox.Show("Please select an empty trailer");
            }
            else{
            // submiting empty trailer request.
            if (txtSendBackNotes.Text == "")
            {
                txtSendBackNotes.Text = "Empty";
            }
            
            Object LocationFrom = dgvTrailerinBays.SelectedRows[0].Cells[0].Value;
            
            Object Supplier = dgvTrailerinBays.SelectedRows[0].Cells[1].Value;
            
            Object TrailerNo = dgvTrailerinBays.SelectedRows[0].Cells[2].Value;
            
            string choice = cboDeparture.SelectedItem.ToString();
           
            
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            string UpdateLocation = "UPDATE LOCATION SET LOCATIONSTATUS = 'Moving' WHERE LOT_NO = '" + Convert.ToString(LocationFrom) + "'";
            OdbcCommand CB = new OdbcCommand(UpdateLocation, Conn);

            OdbcCommand cmd = new OdbcCommand("INSERT INTO REQUESTS(LOCATION_ID,SCHEDULED_DATE,NOTES,STATUS,SUPPLIER,TRAILER_NO) VALUES(?,?,?,?,?,?)", Conn);

            
            cmd.Parameters.Add("?", OdbcType.VarChar).Value = Convert.ToString(LocationFrom);
            cmd.Parameters.Add("?", OdbcType.DateTime).Value = dtpEmptyTrailer.Value;
            cmd.Parameters.Add("?", OdbcType.VarChar).Value = txtENotes.Text;
            cmd.Parameters.Add("?", OdbcType.VarChar).Value = cboDeparture.SelectedItem.ToString();
            cmd.Parameters.Add("?", OdbcType.VarChar).Value = Convert.ToString(Supplier);
            cmd.Parameters.Add("?", OdbcType.VarChar).Value = Convert.ToString(TrailerNo);
           

            Conn.Open();
            CB.ExecuteNonQuery();
            
            cmd.ExecuteNonQuery();
            Conn.Close();
              
            cmd.Dispose();
            CB.Dispose();
            
            EBayLocations();
            EmptyTrailerDGV();
            BayLocations();
            baysFilled();
            
            MessageBox.Show("Request has been sent!");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}