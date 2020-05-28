using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    class Show
    {
        private static int acctNum;

       public int AcctNum
        {
            set
            {
                acctNum = value;
            }
            get
            {
                return acctNum;
            }
        }
    }
}
