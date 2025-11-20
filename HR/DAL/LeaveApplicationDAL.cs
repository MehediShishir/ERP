using HR.UI;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace HR.DAL
{
    public class LeaveApplicationDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();

        public void InsertLeaveApplication(string employeeID, string leaveType, DateTime leaveDate)
        {
            string sql = @"INSERT INTO [dbo].[LeaveApplication]
                            ([Employee_ID], [Leave_Type], [Leave_Date])
                            VALUES (@Employee_ID, @Leave_Type, @Leave_Date)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {

                cmd.Parameters.Add(new SqlParameter("@Employee_ID", SqlDbType.NVarChar) { Value = (object)employeeID ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Leave_Type", SqlDbType.NVarChar) { Value = (object)leaveType ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Leave_Date", SqlDbType.Date) { Value = (object)leaveDate ?? DBNull.Value });

                con.Open();
                cmd.ExecuteNonQuery();

               
            }
        }

        public DataTable GetLeaveApplications()
        {
            DataTable dt = new DataTable();

            string sql = @"SELECT [Leave_Request_ID],
                                  [Employee_ID],
                                  [Leave_Type],
                                  [Leave_Date]
                           FROM [dbo].[LeaveApplication]";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            return dt;
        }

        public void UpdateLeaveApplication(string leaveRequestID, string employeeID, string leaveType, DateTime leaveDate)
        {
            string sql = @"UPDATE [dbo].[LeaveApplication] 
                           SET [Employee_ID] = @Employee_ID,
                               [Leave_Type] = @Leave_Type,
                               [Leave_Date] = @Leave_Date
                           WHERE [Leave_Request_ID] = @Leave_Request_ID";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.Add(new SqlParameter("@Leave_Request_ID", SqlDbType.NVarChar) { Value = (object)leaveRequestID ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Employee_ID", SqlDbType.NVarChar) { Value = (object)employeeID ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Leave_Type", SqlDbType.NVarChar) { Value = (object)leaveType ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@Leave_Date", SqlDbType.Date) { Value = (object)leaveDate ?? DBNull.Value });

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteLeaveApplication(string leaveRequestID)
        {
            string sql = @"DELETE FROM [dbo].[LeaveApplication]
                           WHERE [Leave_Request_ID] = @Leave_Request_ID";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Leave_Request_ID", leaveRequestID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
