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
    public partial class FORM_BILL : Form
    {
        public FORM_BILL()
        {
            InitializeComponent();
            Input();
            

        }
        void Input()
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            int[] A = { 100000, 50000, 20000, 10000 };
            int T = int.Parse(FORM_WITHDRAWAL.s);
            int[] k = proc(A, T);
            lbl1t.Text = k[3].ToString() + " tờ";
            lbl2t.Text = k[2].ToString() + " tờ";
            lbl3t.Text = k[1].ToString() + " tờ";
            lbl5t.Text = k[0].ToString() + " tờ";
            lbMoney.Text = T.ToString("C", cul);
               
        }
        static int[] proc(int[] A, int T)
        {
            int[] k = new int[A.Length];
            if (T % 10000 == 0)
            {
                for (int j = 0; j < k.Length; j++)
                {
                    k[j] = 0;
                }
                int i = 0;
                while (i <= A.Length && T > 0)
                {
                    k[i] = T / A[i];
                    T -= k[i] * A[i];
                    i++;
                }
            }
            return k;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
