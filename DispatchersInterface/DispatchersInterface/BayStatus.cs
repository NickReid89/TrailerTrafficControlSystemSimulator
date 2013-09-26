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
    public partial class BayStatus : Form
    {
        public BayStatus()
        {
            InitializeComponent();
            LotStatusNorth();
            LotStatusWest();
            LotStatusEast();
            LotStatusSouth();
        }
        public void LotStatusNorth()
        {
            int x = 20;
            foreach (Button Child in panelNorth.Controls)
            {
                Button Bt = Child as Button;
                Bt.Click += new EventHandler(Clicked);
                Bt.Text = "North - " + Convert.ToString(x);
                OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                String query = "Select LOCATIONSTATUS FROM LOCATION WHERE LOT_NO = '" + Bt.Text + "'";
                OdbcCommand cmd = new OdbcCommand(query, Conn);
                OdbcDataAdapter ODA = new OdbcDataAdapter(cmd);
                x--;
                Conn.Open();
                object status = cmd.ExecuteScalar();
                string y = Convert.ToString(status);
                if (y == "Occupied")
                {
                    Bt.BackColor = Color.Green;
                }
                else if (y == "Available")
                {
                    Bt.BackColor = Color.Gray;
                }
                else if (y == "reserved")
                {
                    Bt.BackColor = Color.Blue;
                }
                else if (y == "Broken Seal")
                {
                    Bt.BackColor = Color.Yellow;
                }
                else if (y == "Mechanical Problems")
                {
                    Bt.BackColor = Color.Red;
                }
                else if (y == "Moving")
                {
                    Bt.BackColor = Color.Orange;
                }
                Conn.Close();

            }
        }
        public void LotStatusWest()
        {
            int x = 22;
            foreach (Button Child in panelWest.Controls)
            {
                Button Bt = Child as Button;
                Bt.Click += new EventHandler(Clicked);
                Bt.Text = "West - " + Convert.ToString(x);
                OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                String query = "Select LOCATIONSTATUS FROM LOCATION WHERE LOT_NO = '" + Bt.Text + "'";
                OdbcCommand cmd = new OdbcCommand(query, Conn);
                OdbcDataAdapter ODA = new OdbcDataAdapter(cmd);
                x--;
                Conn.Open();
                object status = cmd.ExecuteScalar();
                string y = Convert.ToString(status);
                if (y == "Occupied")
                {
                    Bt.BackColor = Color.Green;
                }
                else if (y == "Available")
                {
                    Bt.BackColor = Color.Gray;
                }
                else if (y == "reserved")
                {
                    Bt.BackColor = Color.Blue;
                }
                else if (y == "Broken Seal")
                {
                    Bt.BackColor = Color.Yellow;
                }
                else if (y == "Mechanical Problems")
                {
                    Bt.BackColor = Color.Red;
                }
                else if (y == "Moving")
                {
                    Bt.BackColor = Color.Orange;
                }
                Conn.Close();

            }
        }
        public void LotStatusSouth()
        {
            int x = 16;
            foreach (Button Child in panelSouth.Controls)
            {
                Button Bt = Child as Button;
                Bt.Click += new EventHandler(Clicked);
                Bt.Text = "South - " + Convert.ToString(x);
                OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                String query = "Select LOCATIONSTATUS FROM LOCATION WHERE LOT_NO = '" + Bt.Text + "'";
                OdbcCommand cmd = new OdbcCommand(query, Conn);
                OdbcDataAdapter ODA = new OdbcDataAdapter(cmd);
                x--;
                Conn.Open();
                object status = cmd.ExecuteScalar();
                string y = Convert.ToString(status);
                if (y == "Occupied")
                {
                    Bt.BackColor = Color.Green;
                }
                else if (y == "Available")
                {
                    Bt.BackColor = Color.Gray;
                }
                else if (y == "reserved")
                {
                    Bt.BackColor = Color.Blue;
                }
                else if (y == "Broken Seal")
                {
                    Bt.BackColor = Color.Yellow;
                }
                else if (y == "Mechanical Problems")
                {
                    Bt.BackColor = Color.Red;
                }
                else if (y == "Moving")
                {
                    Bt.BackColor = Color.Orange;
                }
                Conn.Close();

            }
        }
        public void LotStatusEast()
        {
            int x = 14;
            foreach (Button Child in panelEast.Controls)
            {
                Button Bt = Child as Button;
                Bt.Click += new EventHandler(Clicked);
                Bt.Text = "East - " + Convert.ToString(x);
                OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
                String query = "Select LOCATIONSTATUS FROM LOCATION WHERE LOT_NO = '" + Bt.Text + "'";
                OdbcCommand cmd = new OdbcCommand(query, Conn);
                OdbcDataAdapter ODA = new OdbcDataAdapter(cmd);
                x--;
                Conn.Open();
                object status = cmd.ExecuteScalar();
                string y = Convert.ToString(status);
                if (y == "Occupied")
                {
                    Bt.BackColor = Color.Green;
                }
                else if (y == "Available")
                {
                    Bt.BackColor = Color.Gray;
                }
                else if (y == "reserved")
                {
                    Bt.BackColor = Color.Blue;
                }
                else if (y == "Broken Seal")
                {
                    Bt.BackColor = Color.Yellow;
                }
                else if (y == "Mechanical Problems")
                {
                    Bt.BackColor = Color.Red;
                }
                else if (y == "Moving")
                {
                    Bt.BackColor = Color.Orange;
                }
                Conn.Close();

            }
        }
        private void LotInfo(string LotNo)
        {
            
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            string qTrailer_ID = "Select TRAILER_NO FROM LOCATION WHERE LOT_NO = '" + LotNo + "'";
            string qBOL_ID = "Select BOL.SEAL_NO FROM BOL,LOCATION WHERE LOT_NO = '" + LotNo + "' AND LOCATION.TRAILER_NO = BOL.TRAILER_ID";
            string qSupplier = "Select BOL.SUPPLIER FROM BOL,LOCATION WHERE LOT_NO = '" + LotNo + "' AND LOCATION.TRAILER_NO = BOL.TRAILER_ID";
            string qComp = "Select BOL.ComponentsDESC FROM BOL,LOCATION WHERE LOT_NO = '" + LotNo + "' AND LOCATION.TRAILER_NO = BOL.TRAILER_ID";
            OdbcCommand cmd = new OdbcCommand(qTrailer_ID, Conn);
            OdbcCommand cmd2 = new OdbcCommand(qBOL_ID, Conn);
            OdbcCommand cmd3 = new OdbcCommand(qSupplier, Conn);
            OdbcCommand cmd4 = new OdbcCommand(qComp, Conn);
            OdbcDataAdapter ODA = new OdbcDataAdapter(cmd);
            OdbcDataAdapter ODA2 = new OdbcDataAdapter(cmd2);
            OdbcDataAdapter ODA3 = new OdbcDataAdapter(cmd3);
            OdbcDataAdapter ODA4 = new OdbcDataAdapter(cmd4);
            Conn.Open();
            string Trailer_No = ((string)cmd.ExecuteScalar());
            string BOL_ID = ((string)cmd2.ExecuteScalar());
            string Supplier = ((string)cmd3.ExecuteScalar());
            string Comp = ((string)cmd4.ExecuteScalar());
            Conn.Close();
            lblTrailerNumber.Text = Trailer_No;
            lblBoLNum.Text = BOL_ID;
            lblSupplier.Text = Supplier;
            lblComponent.Text = Comp;
        }
        private string IsTrailerInLot(string LotNo)
        {

            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            string lotStatus = "Select LOCATIONSTATUS from LOCATION WHERE LOT_NO = '" + LotNo + "'";
            OdbcCommand cmd = new OdbcCommand(lotStatus, Conn);
            OdbcDataAdapter ODA = new OdbcDataAdapter(cmd);
            Conn.Open();
            string Status = ((string)cmd.ExecuteScalar());
            Conn.Close();


            return Status;
        }
        private void Clicked(object sender, EventArgs e)
        {

            Button button = sender as Button;
            string status = IsTrailerInLot(button.Text);
            if (status == "Available")
            {
                lblTrailerNumber.Text = "None";
                lblBoLNum.Text = "None";
                lblSupplier.Text = "None";
                lblComponent.Text = "None";
            }
            else if (status == "Moving")
            {
                lblTrailerNumber.Text = "None";
                lblBoLNum.Text = "None";
                lblSupplier.Text = "None";
                lblComponent.Text = "None";
            }
            else
            {
                LotInfo(button.Text);

            }

        }

    }
}
