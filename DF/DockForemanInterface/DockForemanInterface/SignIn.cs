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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            OdbcConnection Conn = new OdbcConnection("DSN=ora10glocal;uid=TTCS;PWD=Pass1234");
            OdbcCommand cmd = new OdbcCommand("SELECT EMPLOYEEPASSWORD FROM EMPLOYEE WHERE LASTNAME = '" + txtUserName.Text + "'AND EMPLOYEETYPE = 'Foreman';", Conn);
            Conn.Open();
            Object EmpPass = cmd.ExecuteScalar();
            cmd.Dispose();
            Conn.Close();

            if (txtUserName.Text == "")
            {
                MessageBox.Show("User name is empty!");
            }
            else if (Convert.ToString(EmpPass) == "")
            {
                MessageBox.Show("Password is empty!");
            }
            else if (Convert.ToString(EmpPass) != txtPassword.Text)
            {
                MessageBox.Show("Wrong password! please type again!");
            }
            else
            {
                string Emp = Convert.ToString(EmpPass);
                var frm = new Form1(Emp);
                frm.ShowDialog();
                //this.Visible = false
            }
        }
    }
}
