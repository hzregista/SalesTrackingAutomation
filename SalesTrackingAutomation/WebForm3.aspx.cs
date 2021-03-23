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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Staff> StaffList = BLLStaff.BLLStaffList();
            Repeater1.DataSource = StaffList;
            Repeater1.DataBind();
        }
    }
}