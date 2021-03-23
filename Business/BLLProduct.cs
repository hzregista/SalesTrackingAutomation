using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;
namespace Business
{
   public class BLLProduct
    {
        public static List<Product> BLLProdList()
        {
            return DALProduct.ProductList();
        }
        public static int BLLAddProd (Product p)
        {
            if (p.Productname!="" && p.Productcount!=0 && p.Productprice>1)
            {
                return DALProduct.AddProd(p);
            }
            else { return -1; }
        }
    }
}
