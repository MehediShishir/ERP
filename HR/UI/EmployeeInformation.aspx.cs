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

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeBLL employeeBLL = new EmployeeBLL();
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

                EmployeeBLL employeeBLL = new EmployeeBLL();
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

                EmployeeBLL employeeBLL = new EmployeeBLL();
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

                EmployeeBLL employeeBLL = new EmployeeBLL();
                employeeBLL.deleteEmployee(id);


                ClearControl();
            }
            catch (Exception msgException)
            {
                throw msgException;

            }

        }
        private void ExecuteSql(string sql)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
            var myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            var myCommand = new SqlCommand(sql, myConnection).ExecuteNonQuery();
            myConnection.Close();
        }

        private void ClearControl()
        {
            txtEmployeeID.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMobileNumber.Text = string.Empty;
        }
       
    }
}