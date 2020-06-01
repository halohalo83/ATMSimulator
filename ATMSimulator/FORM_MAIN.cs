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
    public partial class FORM_MAIN : Form
    {
        public FORM_MAIN()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {
            FORM_QUICKWITHDRAWAL fqd = new FORM_QUICKWITHDRAWAL();
            this.Hide();
            fqd.ShowDialog();
            this.Show();
        }
    }
}
