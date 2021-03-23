using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        private int productid;
        private String productname;
        private decimal productprice;
        private int productcount;

        public int Productid { get => productid; set => productid = value; }
        public string Productname { get => productname; set => productname = value; }
        public decimal Productprice { get => productprice; set => productprice = value; }
        public int Productcount { get => productcount; set => productcount = value; }
    }
}
