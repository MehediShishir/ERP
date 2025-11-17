using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data;
using HR.BLL;

namespace HR.UI
{
    public partial class EmployeeInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        EmployeeBLL employeeBLL;

        protected void btnShow_Click(object sender, EventArgs e)
        {
            showEmployee();
        }

        private void showEmployee()
        {
            try
            {
                employeeBLL = new EmployeeBLL();
                DataTable dtEmployee = employeeBLL.getEmployees();

                grdEmployee.DataSource = dtEmployee;
                grdEmployee.DataBind();
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
                int id = Convert.ToInt32(txtEmployeeID.Text);
                string employeeName = txtEmployeeName.Text;
                string email = txtEmail.Text;
                string mobileNumber = txtMobileNumber.Text;

                employeeBLL = new EmployeeBLL();
                employeeBLL.updateEmployee(id, employeeName, email, mobileNumber);



                ClearControl();
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
                string employeeName = txtEmployeeName.Text;
                string email = txtEmail.Text;
                string mobileNumber = txtMobileNumber.Text;

                employeeBLL = new EmployeeBLL();
                employeeBLL.addEmployee(employeeName, email, mobileNumber);

                ClearControl();
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
                int id = Convert.ToInt32(txtEmployeeID.Text);

                employeeBLL = new EmployeeBLL();
                employeeBLL.deleteEmployee(id);


                ClearControl();
            }
            catch (Exception msgException)
            {
                throw msgException;

            }

        }
        

        private void ClearControl()
        {
            txtEmployeeID.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMobileNumber.Text = string.Empty;
        }

        protected void grdEmployee_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int selectedIndex = Convert.ToInt32(e.CommandArgument.ToString());

            string employeeID = ((Label)grdEmployee.Rows[selectedIndex].FindControl("lblEmployeeID")).Text;

            //string employeeID = grdEmployee.Rows[selectedIndex].Cells[4].Text;

            if (e.CommandName == "Select")
            {
               txtEmployeeID.Text = ((Label)grdEmployee.Rows[selectedIndex].FindControl("lblEmployeeID")).Text;
               txtEmployeeName.Text = ((Label)grdEmployee.Rows[selectedIndex].FindControl("lblEmployeeName")).Text;
               txtEmail.Text = ((Label)grdEmployee.Rows[selectedIndex].FindControl("lblEmail")).Text;
               txtMobileNumber.Text = ((Label)grdEmployee.Rows[selectedIndex].FindControl("lblMobileNumber")).Text;
            }
           
            else if (e.CommandName == "Delete")
            {
               

                try
                {
                    int id = Convert.ToInt32(employeeID);

                    employeeBLL = new EmployeeBLL();
                    employeeBLL.deleteEmployee(id);


                    ClearControl();
                }
                catch (Exception msgException)
                {
                    throw msgException;

                }

            }

        }

        protected void grdEmployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            showEmployee();
                        
        }
       
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/StartPage.aspx");

        }
    }
}