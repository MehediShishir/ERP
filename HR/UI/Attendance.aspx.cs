using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class Attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string attendanceID = txtAttendanceID.Text;
            lblAttendanceID.Text = attendanceID;

            string employeeID = txtEmployeeID.Text;
            lblEmployeeID.Text = employeeID;

            string date = txtDate.Text;
            lblDate.Text = date;

            
        }
    }
}