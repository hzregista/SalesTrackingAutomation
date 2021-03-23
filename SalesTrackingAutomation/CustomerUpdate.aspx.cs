using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Business;
using DataAccess;
namespace SalesTrackingAutomation
{
    public partial class CustomerUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(Request.QueryString["customerid"]);
            Label1.Text = cid.ToString();
            Customer cs = new Customer();
            if(Page.IsPostBack==false)
            {
                List<Customer> CustomerList = BLLCustomer.BLLGetCustomer(cid);
                TextBox1.Text = CustomerList[0].Customername.ToString();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            cs.Customername = TextBox1.Text;
            cs.Customerid = Convert.ToInt32(Label1.Text);
            BLLCustomer.BLLCustomerUpdate(cs);
            Response.Redirect("WebForm2.aspx");
        }
    }
}