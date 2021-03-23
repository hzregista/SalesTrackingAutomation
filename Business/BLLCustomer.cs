using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;
namespace Business
{
    public class BLLCustomer
    {
        public static List<Customer> BLLCustList()
        {
            return DALCustomer.CustomerList();
        }

        public static int BLLAddCus(Customer c)
        {
            if (c.Customername != null && c.Customername != "" && c.Customername.Length <50 )
            {
                return DALCustomer.CustAdd(c);
            }
            else { return -1; }
        }

        public static bool BLLCustomerDelete(int bc)
        {
            if (bc!= null)
            {
                return DALCustomer.CustomerDelete(bc);
            }
            return false;
        }

        public static List<Customer> BLLGetCustomer(int gc)
        {
            return DALCustomer.GetCustomer(gc);
        }

        public static bool BLLCustomerUpdate(Customer bcu)
        {
            if (bcu.Customername!="")
            {
                return DALCustomer.CustomerUpdate(bcu);
            }
            else { return false; }
        }
    }
}
