using HR.BLL;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class Attendance : System.Web.UI.Page
    {
        AttendanceBLL attendanceBLL;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            showAttendance();
        }

        private void showAttendance()
        {
            try
            {
                attendanceBLL = new AttendanceBLL();
                DataTable dt = attendanceBLL.getAttendance();

                grdAttendance.DataSource = dt;
                grdAttendance.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string attendanceID = txtAttendanceID.Text;
                string employeeID = txtEmployeeID.Text;
                string date = txtDate.Text;

                attendanceBLL = new AttendanceBLL();
                attendanceBLL.addAttendance(attendanceID, employeeID, date);

                ClearControl();
                showAttendance();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string attendanceID = txtAttendanceID.Text;
                string employeeID = txtEmployeeID.Text;
                string date = txtDate.Text;

                attendanceBLL = new AttendanceBLL();
                attendanceBLL.updateAttendance(attendanceID, employeeID, date);

                ClearControl();
                showAttendance();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grdAttendance_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int selectedIndex = Convert.ToInt32(e.CommandArgument.ToString());

            string attendanceID = ((Label)grdAttendance.Rows[selectedIndex].FindControl("lblAttendanceID")).Text;

            if (e.CommandName == "Select")
            {
                txtAttendanceID.Text = ((Label)grdAttendance.Rows[selectedIndex].FindControl("lblAttendanceID")).Text;
                txtEmployeeID.Text = ((Label)grdAttendance.Rows[selectedIndex].FindControl("lblEmployeeID")).Text;
                txtDate.Text = ((Label)grdAttendance.Rows[selectedIndex].FindControl("lblDate")).Text;
            }
            else if (e.CommandName == "Delete")
            {
                try
                {
                    attendanceBLL = new AttendanceBLL();
                    attendanceBLL.deleteAttendance(attendanceID);

                    ClearControl();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void grdAttendance_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            showAttendance();
        }

        private void ClearControl()
        {
            txtAttendanceID.Text = string.Empty;
            txtEmployeeID.Text = string.Empty;
            txtDate.Text = string.Empty;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/StartPage.aspx");
        }
    }
}
