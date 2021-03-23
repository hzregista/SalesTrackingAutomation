using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using DataAccess;
using Business;
namespace SalesTrackingAutomation
{
    public partial class DeleteCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int csid = Convert.ToInt32(Request.QueryString["customerid"]);
            Customer cs = new Customer();
            cs.Customerid = csid;
            BLLCustomer.BLLCustomerDelete(cs.Customerid);
            Response.Redirect("WebForm2.aspx");

        }
    }
}