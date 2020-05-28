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
    public partial class FORM_CHECKBALANCE : Form
    {
        DBConnection db = new DBConnection();
        Show show = new Show();
        public FORM_CHECKBALANCE()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FORM_CHECKBALANCE_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(db.Con);
            SqlCommand cmd = new SqlCommand("Command String", con);
            SqlDataReader readdata;
            try
            {
                con.Open();
                cmd.CommandText = "Select * from Accounts where AcctNum = '" + show.AcctNum + "'";
                readdata = cmd.ExecuteReader();
                string balanceDB = null;
                while(readdata.Read())
                {
                    balanceDB = readdata["Balance"].ToString();
                }
                con.Close();
                con.Dispose();
                labelMoney.Text += " " + balanceDB.ToString();

            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống", "Error");

            }
        }
    }
}
