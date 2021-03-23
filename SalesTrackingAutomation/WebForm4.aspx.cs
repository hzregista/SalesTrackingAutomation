using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Entity;
using DataAccess;
namespace SalesTrackingAutomation
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> ProdList = BLLProduct.BLLProdList();
            Repeater1.DataSource = ProdList;
            Repeater1.DataBind();
        }
    }
}