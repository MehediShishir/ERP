using System;
using System.Data;
using HR.BLL;

namespace HR.UI
{
    public partial class LeaveApplication : System.Web.UI.Page
    {
        LeaveApplicationBLL bll;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void showLeaveApplications()
        {
            try
            {
                bll = new LeaveApplicationBLL();
                DataTable dt = bll.ShowLeaveApplications();

                grdLeaveApplication.DataSource = dt;
                grdLeaveApplication.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            showLeaveApplications();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {


            try
            {
                string leaveRequestID = txtLeaveRequestID.Text;
                string leaveType = txtLeaveType.Text;
                string employeeID = txtEmployeeID.Text;
                DateTime leaveDate = Convert.ToDateTime(txtLeaveDate.Text);
                bll = new LeaveApplicationBLL();

                bll.SaveLeaveApplication(
                    employeeID,
                    leaveType,
                    leaveDate
                );

                ClearControl();
                showLeaveApplications();
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
                string leaveRequestID = txtLeaveRequestID.Text;
                string leaveType = txtLeaveType.Text;
                string employeeID = txtEmployeeID.Text;
                DateTime leaveDate = Convert.ToDateTime(txtLeaveDate.Text);
                bll = new LeaveApplicationBLL();
                
                bll.UpdateLeaveApplication(
                    leaveRequestID,
                    employeeID,
                    leaveType,
                    leaveDate
                );

                ClearControl();
                showLeaveApplications();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string leaveRequestID = txtLeaveRequestID.Text;

                bll = new LeaveApplicationBLL();
                bll.DeleteLeaveApplication(leaveRequestID);

                ClearControl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grdLeaveApplication_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int selectedIndex = Convert.ToInt32(e.CommandArgument.ToString());
            string leaveRequestID = ((System.Web.UI.WebControls.Label)grdLeaveApplication.Rows[selectedIndex].FindControl("lblLeaveRequestID")).Text;

            if (e.CommandName == "Select")
            {
                txtLeaveRequestID.Text = leaveRequestID;
                txtEmployeeID.Text = ((System.Web.UI.WebControls.Label)grdLeaveApplication.Rows[selectedIndex].FindControl("lblEmployeeID")).Text;
                txtLeaveType.Text = ((System.Web.UI.WebControls.Label)grdLeaveApplication.Rows[selectedIndex].FindControl("lblLeaveType")).Text;
                txtLeaveDate.Text = ((System.Web.UI.WebControls.Label)grdLeaveApplication.Rows[selectedIndex].FindControl("lblLeaveDate")).Text;
            }
            else if (e.CommandName == "Delete")
            {
                try
                {
                    bll = new LeaveApplicationBLL();
                    bll.DeleteLeaveApplication(leaveRequestID);

                    ClearControl();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void grdLeaveApplication_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            showLeaveApplications();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/StartPage.aspx");
        }

        private void ClearControl()
        {
            txtLeaveRequestID.Text = string.Empty;
            txtEmployeeID.Text = string.Empty;
            txtLeaveType.Text = string.Empty;
            txtLeaveDate.Text = string.Empty;
        }
    }
}
