using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HR.DAL
{
    public class LeaveApplicationDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();

        public void InsertLeaveApplication(string employeeID, string leaveType, string leaveDate)
        {
            string sql = @"INSERT INTO [dbo].[LeaveApplication]
                            ([Employee_ID], [Leave_Type], [Leave_Date])
                            VALUES (@Employee_ID, @Leave_Type, @Leave_Date)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Employee_ID", employeeID);
                cmd.Parameters.AddWithValue("@Leave_Type", leaveType);
                cmd.Parameters.AddWithValue("@Leave_Date", leaveDate);

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

        public void UpdateLeaveApplication(string leaveRequestID, string employeeID, string leaveType, string leaveDate)
        {
            string sql = @"UPDATE [dbo].[LeaveApplication] 
                           SET [Employee_ID] = @Employee_ID,
                               [Leave_Type] = @Leave_Type,
                               [Leave_Date] = @Leave_Date
                           WHERE [Leave_Request_ID] = @Leave_Request_ID";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Leave_Request_ID", leaveRequestID);
                cmd.Parameters.AddWithValue("@Employee_ID", employeeID);
                cmd.Parameters.AddWithValue("@Leave_Type", leaveType);
                cmd.Parameters.AddWithValue("@Leave_Date", leaveDate);

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
