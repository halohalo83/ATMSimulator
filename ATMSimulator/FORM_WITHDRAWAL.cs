using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class FORM_WITHDRAWAL : Form
    {
        public FORM_WITHDRAWAL()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(s) % 10000 == 0 && Convert.ToInt32(s) > 0)
                {
                    FORM_BILL fb = new FORM_BILL();
                    this.Hide();
                    fb.ShowDialog();
                    this.Show();
                }

                else
                {
                    MessageBox.Show("Số tiền rút phải là bội của 10000", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("Yêu cầu nhập số tiền cần rút", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                

            }
        }
        
        public static String s = "";
        private void btnNumber1_Click(object sender, EventArgs e)
        {
            s += 1.ToString();
            lbSotien.Text = s;
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            s += 2.ToString();
            lbSotien.Text = s;
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            s += 3.ToString();
            lbSotien.Text = s;
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            s += 4.ToString();
            lbSotien.Text = s;
        }
        private void btnNumber5_Click(object sender, EventArgs e)
        {
            s += 5.ToString();
            lbSotien.Text = s;
        }
        private void btnNumber6_Click(object sender, EventArgs e)
        {
            s += 6.ToString();
            lbSotien.Text = s;
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            s += 7.ToString();
            lbSotien.Text = s;
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            s += 8.ToString();
            lbSotien.Text = s;
        }
        private void btnNumber9_Click(object sender, EventArgs e)
        {
            s += 9.ToString();
            lbSotien.Text = s;
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            s += 0.ToString();
            lbSotien.Text = s;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (s != "")
            {
                s = s.Remove(s.Length - 1);
                lbSotien.Text = s;
            }

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            FORM_BILL fb = new FORM_BILL();
        }

    }
}
