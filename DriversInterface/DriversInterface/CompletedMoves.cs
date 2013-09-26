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
    public partial class CompletedMoves : Form
    {
        public CompletedMoves(string employeeID)
        {
            InitializeComponent();
            CompletedMovesDGV(employeeID);
        }
        private void CompletedMovesDGV(string emp)
        {
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
            string where = " WHERE REQUESTS.STATUS <> 'Needed' AND REQUESTS.STATUS <> 'In Progress' AND REQUESTS.EMPLOYEE_ID ='" + emp + "' ";

            // Connection string
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            // Command for the select statement.
            OdbcCommand cmd = new OdbcCommand(select + " FROM REQUESTS" + where, Conn);
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
            dgvCompletedMoves.DataSource = null;
            // Update it to make sure nothing is in it.
            dgvCompletedMoves.Update();
            // Fill it with proper information.
            dgvCompletedMoves.DataSource = DeliveryLocation;
            // kill the odbc command. If this is not done you'll have problems re using it.
            dgvCompletedMoves.Columns[0].Visible = false;
            cmd.Dispose();
            // Close the connnection.
            Conn.Close();
        }
    }
 
}
