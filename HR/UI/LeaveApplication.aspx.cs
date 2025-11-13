using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class LeaveApplication : System.Web.UI.Page
    {
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string leaveRequestID = txtLeaveRequestID.Text;
            string employeeID = txtEmployeeID.Text;
            string leaveType = txtLeaveType.Text;
            string leaveDate = txtLeaveDate.Text;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try {
                string leaveRequestID = txtLeaveRequestID.Text;
                string employeeID = txtEmployeeID.Text;
                string leaveType = txtLeaveType.Text;
                string leaveDate = txtLeaveDate.Text;

                string sql = @"INSERT INTO [dbo].[LeaveApplication]
           ([Employee_ID]
           ,[Leave_Type]
           ,[Leave_Date])
                VALUES
           (@Employee_ID
           ,@Leave_Type
           ,@Leave_Date)";
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                using (System.Data.SqlClient.SqlConnection myConnection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@Employee_ID", employeeID);
                        cmd.Parameters.AddWithValue("@Leave_Type", leaveType);
                        cmd.Parameters.AddWithValue("@Leave_Date", leaveDate);
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


        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                System.Data.DataTable dtLeaveApplication = new System.Data.DataTable();
                string sql = @"SELECT [Leave_Request_ID]
      ,[Employee_ID]
      ,[Leave_Type]
      ,[Leave_Date]
  FROM [dbo].[LeaveApplication]";
                using (System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(connectionString))
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, cn))
                using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd))
                {
                    da.Fill(dtLeaveApplication);
                }
                grdLeaveApplication.DataSource = dtLeaveApplication;
                grdLeaveApplication.DataBind();
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
                string leaveRequestID = txtLeaveRequestID.Text;
                string employeeID = txtEmployeeID.Text; 
                string leaveType = txtLeaveType.Text;   
                string leaveDate = txtLeaveDate.Text;   
                string sql = @"UPDATE [dbo].[LeaveApplication] SET [Employee_ID]=@Employee_ID, [Leave_Type]=@Leave_Type, [Leave_Date]=@Leave_Date WHERE [Leave_Request_ID]=@Leave_Request_ID";
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                using (System.Data.SqlClient.SqlConnection myConnection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@Leave_Request_ID", leaveRequestID);
                        cmd.Parameters.AddWithValue("@Employee_ID", employeeID);
                        cmd.Parameters.AddWithValue("@Leave_Type", leaveType);
                        cmd.Parameters.AddWithValue("@Leave_Date", leaveDate);
                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception msgException)
            {
                throw msgException;
            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try { 
                string leaveRequestID = txtLeaveRequestID.Text;
                string sql = @"DELETE FROM [dbo].[LeaveApplication] WHERE [Leave_Request_ID]=@Leave_Request_ID";
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                using (System.Data.SqlClient.SqlConnection myConnection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@Leave_Request_ID", leaveRequestID);
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
    }
}