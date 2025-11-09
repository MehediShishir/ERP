using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace HR.UI
{
    public partial class EmployeeInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            lblEmployeeName.Text = employeeName;
            
            string email = txtEmail.Text;
            lblEmail.Text = email;

            string mobileNumber = txtMobileNumber.Text;
            lblMobileNumber.Text = mobileNumber;    

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                string employeeName = txtEmployeeName.Text;
                string email = txtEmail.Text;
                string mobileNumber = txtMobileNumber.Text;
                string sql = "INSERT INTO [dbo].[Employee] ([Name], [Email], [Phone_number]) VALUES('" + employeeName + "','" + email + "','" + mobileNumber + "')";
                ExecuteSql(sql);
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
            ClearControl(myConnection);
            myConnection.Close();
        }

        private void ClearControl(SqlConnection myConnection)
        {
            txtEmployeeName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMobileNumber.Text = string.Empty;
        }
    }
}