using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Business;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
namespace SalesTrackingAutomation
    
{
    public partial class AddStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbdepartment", Connection.conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DropDownList1.DataValueField = "departmentid";
                DropDownList1.DataTextField = "departmentname";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Staff stf = new Staff();
            stf.Staffname = TextBox1.Text;
            stf.Staffdepid = Convert.ToInt32(DropDownList1.SelectedValue);
            stf.Staffsalary = Convert.ToDecimal(TextBox2.Text);
            BLLStaff.BLLAddStaff(stf);

        }
    }
}