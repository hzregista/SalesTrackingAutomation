using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sales
    {
        private int salesid;
        private int soldproductid;
        private String productname;
        private int staffsellid;
        private String staffname;
        private decimal saleprice;
        private int customerid;
        private String customername;
        
        
        public int Salesid { get => salesid; set => salesid = value; }
        public int Soldproductid { get => soldproductid; set => soldproductid = value; }
        public int Staffsellid { get => staffsellid; set => staffsellid = value; }
        public decimal Saleprice { get => saleprice; set => saleprice = value; }
        public int Customerid { get => customerid; set => customerid = value; }
        public string Customername { get => customername; set => customername = value; }
        public string Productname { get => productname; set => productname = value; }
        public string Staffname { get => staffname; set => staffname = value; }
    }
}
