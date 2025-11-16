using System;
using HR.BLL;

namespace HR.UI
{
    public partial class LeaveApplication : System.Web.UI.Page
    {
        LeaveApplicationBLL bll = new LeaveApplicationBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void ClearControl()
        {
            txtLeaveRequestID.Text = string.Empty;
            txtLeaveType.Text = string.Empty;
            txtLeaveDate.Text = string.Empty;
            txtEmployeeID.Text = string.Empty;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            bll.SaveLeaveApplication(
                txtEmployeeID.Text,
                txtLeaveType.Text,
                txtLeaveDate.Text
            );

            ClearControl();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            grdLeaveApplication.DataSource = bll.ShowLeaveApplications();
            grdLeaveApplication.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            bll.UpdateLeaveApplication(
                txtLeaveRequestID.Text,
                txtEmployeeID.Text,
                txtLeaveType.Text,
                txtLeaveDate.Text
            );

            ClearControl();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            bll.DeleteLeaveApplication(txtLeaveRequestID.Text);
            ClearControl();
        }
    }
}
