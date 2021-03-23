using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using Entity;
using Business;
namespace SalesTrackingAutomation
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Productname = TextBox1.Text;
            pro.Productprice = Convert.ToDecimal(TextBox2.Text);
            pro.Productcount = Convert.ToInt32(TextBox3.Text);
            BLLProduct.BLLAddProd(pro);
        }
    }
}