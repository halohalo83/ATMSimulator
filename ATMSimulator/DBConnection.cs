using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    class DBConnection
    {
        private string con = "data source=.\\SQLEXPRESS;Initial Catalog=ATMSimulator;User ID=sa;Password=hung1502;persist security info=False;packet size=4096";

        public string Con
        {
            get
            {
                return con;
            }
        }
    }
}
