using HR.BLL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class DepartmentSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DepartmentSetupBLL departmentBLL;

        protected void btnShow_Click(object sender, EventArgs e)
        {
            showDepartment();
        }

        private void showDepartment()
        {
            try
            {
                departmentBLL = new DepartmentSetupBLL();
                DataTable dtDepartment = departmentBLL.GetDepartments();

                grdDepartment.DataSource = dtDepartment;
                grdDepartment.DataBind();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string deptID = txtDepartmentID.Text;
                string deptName = txtDepartmentName.Text;
                string description = txtDescription.Text;

                departmentBLL = new DepartmentSetupBLL();
                departmentBLL.UpdateDepartment(deptID, deptName, description);

                ClearControl();
                showDepartment();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string deptID = txtDepartmentID.Text;
                string deptName = txtDepartmentName.Text;
                string description = txtDescription.Text;

                departmentBLL = new DepartmentSetupBLL();
                departmentBLL.AddDepartment(deptID, deptName, description);

                ClearControl();
                showDepartment();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string deptID = txtDepartmentID.Text;

                departmentBLL = new DepartmentSetupBLL();
                departmentBLL.DeleteDepartment(deptID);

                ClearControl();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        private void ClearControl()
        {
            txtDepartmentID.Text = string.Empty;
            txtDepartmentName.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        protected void grdDepartment_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int selectedIndex = Convert.ToInt32(e.CommandArgument.ToString());

            string deptID = ((Label)grdDepartment.Rows[selectedIndex].FindControl("lblDeptID")).Text;

            if (e.CommandName == "Select")
            {
                txtDepartmentID.Text = ((Label)grdDepartment.Rows[selectedIndex].FindControl("lblDeptID")).Text;
                txtDepartmentName.Text = ((Label)grdDepartment.Rows[selectedIndex].FindControl("lblDeptName")).Text;
                txtDescription.Text = ((Label)grdDepartment.Rows[selectedIndex].FindControl("lblDescription")).Text;
            }
            else if (e.CommandName == "Delete")
            {
                try
                {
                    departmentBLL = new DepartmentSetupBLL();
                    departmentBLL.DeleteDepartment(deptID);

                    ClearControl();
                }
                catch (Exception msgException)
                {
                    throw msgException;
                }
            }
        }

        protected void grdDepartment_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            showDepartment();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/StartPage.aspx");
        }
    }
}
