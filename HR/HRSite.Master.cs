using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR
{
    public partial class HRSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }


        protected void btnAttendance_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/Attendance.aspx");
        }

        protected void btnDepartmentSetup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/DepartmentSetup.aspx");
        }

        protected void btnDesignation_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/Designation.aspx");
        }

        protected void btnEmployeeInformation_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/EmployeeInformation.aspx");
        }

        protected void btnLeaveApplication_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/LeaveApplication.aspx");
        }
    }
}