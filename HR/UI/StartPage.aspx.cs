using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class StartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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