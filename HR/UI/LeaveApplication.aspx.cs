using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class LeaveApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string leaveRequestID = txtLeaveRequestID.Text;
            lblLeaveRequestID.Text = leaveRequestID;

            string employeeID = txtEmployeeID.Text;
            lblEmployeeID.Text = employeeID;

            string leaveType = txtLeaveType.Text;
            lblLeaveType.Text = leaveType;

            string leaveDate = txtLeaveDate.Text;
            lblLeaveDate.Text = leaveDate;
        }
    }
}