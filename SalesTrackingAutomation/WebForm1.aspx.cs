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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Department> DepList = BLLDepartment.BLLDepartmentList();
            Repeater1.DataSource = DepList;
            Repeater1.DataBind();
        }
    }
}