using HR.BLL;
using System;
using System.Data;

namespace HR.UI
{
    public partial class DepartmentSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        private void ClearControl()
        {
            txtDepartmentID.Text = "";
            txtDepartmentName.Text = "";
            txtDescription.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentSetupBLL bll = new DepartmentSetupBLL();
                bll.AddDepartment(txtDepartmentID.Text, txtDepartmentName.Text, txtDescription.Text);

                ClearControl();
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
                DepartmentSetupBLL bll = new DepartmentSetupBLL();
                bll.UpdateDepartment(txtDepartmentID.Text, txtDepartmentName.Text, txtDescription.Text);

                ClearControl();
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
                DepartmentSetupBLL bll = new DepartmentSetupBLL();
                bll.DeleteDepartment(txtDepartmentID.Text);

                ClearControl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentSetupBLL bll = new DepartmentSetupBLL();
                DataTable dt = bll.GetDepartments();

                grdDepartment.DataSource = dt;
                grdDepartment.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
