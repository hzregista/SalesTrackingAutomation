using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Business;
using Entity;
using DataAccess;

namespace SalesTrackingAutomation
{
    public partial class NewSale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbproduct", Connection.conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DropDownList1.DataValueField = "productid";
                DropDownList1.DataTextField = "productname";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();

                SqlCommand cmd2 = new SqlCommand("SELECT * FROM tbstaff", Connection.conn);
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                DropDownList2.DataValueField = "staffid";
                DropDownList2.DataTextField = "staffname";
                DropDownList2.DataSource = dt2;
                DropDownList2.DataBind();

                SqlCommand cmd3 = new SqlCommand("SELECT * FROM tbcustomer", Connection.conn);
                SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                DropDownList3.DataValueField = "customerid";
                DropDownList3.DataTextField = "customername";
                DropDownList3.DataSource = dt3;
                DropDownList3.DataBind();

            }
        }
    }
}