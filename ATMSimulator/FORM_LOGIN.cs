using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class FORM_LOGIN : Form
    {
        DBConnection db = new DBConnection();
        Show show = new Show();
        public FORM_LOGIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(db.Con);
            //SqlCommand cmd = new SqlCommand("Command String", con);
            //SqlDataReader readdata;

            //try
            //{
            //    con.Open();
            //    int account = int.Parse(txbAcctNum.Text);
            //    int pin = int.Parse(txbPIN.Text);
            //    int accountDB = 0;
            //    int pinDB = 0;

            //    cmd.CommandText = "SELECT * FROM Accounts WHERE AcctNum = '" + account + "'";
            //    readdata = cmd.ExecuteReader();
            //    while (readdata.Read())
            //    {
            //        accountDB = int.Parse(readdata["AcctNum"].ToString());
            //        pinDB = int.Parse(readdata["PIN"].ToString());
            //    }
            //    con.Close();
            //    con.Dispose();
            //    if ((account == accountDB) && (pin == pinDB))
            //    {
            //        show.AcctNum = accountDB;
            //        FORM_MAIN fm = new FORM_MAIN();
            //        fm.Show();
            //        this.Hide();
            //    }  
            //    else
            //    {
            //        MessageBox.Show("Không tìm thấy account");

            //    }

            //}
            //catch 
            //{
            //    MessageBox.Show("Lỗi hệ thống", "Error");

            //}

            FORM_MAIN fm = new FORM_MAIN();
            fm.Show();
            this.Hide();

        }
    }
}
