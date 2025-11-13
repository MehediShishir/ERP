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

namespace HR.UI
{
    public partial class EmployeeInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try {
                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                DataTable dtEmployee = new DataTable();

                string sql = @"SELECT [ID]
                ,[Name]
                ,[Email]
                ,[Phone_number]
                FROM [dbo].[Employee]";

                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtEmployee);

                }
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
            {   string id = txtEmployeeID.Text;
                string employeeName = txtEmployeeName.Text;
                string email = txtEmail.Text;
                string mobileNumber = txtMobileNumber.Text;
                string sql = @"UPDATE [dbo].[Employee] SET [Name]=@Name, [Email]=@Email, [Phone_number]=@MobileNumber WHERE [ID]=@id";

                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();

                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Name", employeeName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);

                        myConnection.Open();
                        cmd.ExecuteNonQuery();

                    }

                }


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
                string sql = "INSERT INTO [dbo].[Employee] ([Name], [Email], [Phone_number]) VALUES(@Name, @Email, @MobileNumber)";

                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                
                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    
                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@Name", employeeName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);

                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                       
                    }
                    
                }
                
                
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
                string id = txtEmployeeID.Text;
                
                string sql = "DELETE FROM [dbo].[Employee] WHERE [ID]=@id";
                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();

                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }


                ClearControl();
            }
            catch (Exception msgException)
            {
                throw msgException;

            }




            //try
            //{
            //    string employeeID = txtEmployeeID.Text;
                
            //    string sql = "DELETE FROM [dbo].[Employee] WHERE [ID]='" + employeeID + "'";
            //    ExecuteSql(sql);
            //    ClearControl();
            //}
            //catch (Exception msgException)
            //{
            //    throw msgException;
            //}


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