using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer
    {
        private int customerid;
        private String customername;
        public int Customerid { get => customerid; set => customerid = value; }
        public string Customername { get => customername; set => customername = value; }
    }
}
