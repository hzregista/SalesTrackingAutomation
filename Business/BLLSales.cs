using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;
namespace Business
{
    public class BLLSales
    {
        public static List<Sales> BLLSalesList()
        {
            return DALSales.SalesList();
        }
    }
}
