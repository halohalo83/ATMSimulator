using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class FORM_QUICKWITHDRAWAL : Form
    {
        public FORM_QUICKWITHDRAWAL()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapSoKhac_Click(object sender, EventArgs e)
        {
            FORM_WITHDRAWAL fwd = new FORM_WITHDRAWAL();
            this.Hide();
            fwd.ShowDialog();
            this.Show();
        }
    }
}
