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
    public partial class AddDep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Department dp = new Department();
            dp.Departmentname = TextBox1.Text;
            BLLDepartment.BLLAddDep(dp);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}