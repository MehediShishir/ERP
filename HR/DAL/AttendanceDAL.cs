using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace HR.DAL
{
    public class AttendanceDAL
    {
        private readonly string _connectionString;

        public AttendanceDAL()
        {
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();

        }

        public void insertAttendance(string attendanceID, string employeeID, string date)
        {
            try
            {
                string sql = @"INSERT INTO [dbo].[Attendance]
                   ([Employee_ID]
                  ,[Date])
                VALUES
                   (@Employee_ID
                      ,@Date)";
                using (var myConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.Add(new SqlParameter("@AttendanceID", SqlDbType.NVarChar) { Value = (object)attendanceID ?? DBNull.Value });
                        cmd.Parameters.Add(new SqlParameter("@Employee_ID", SqlDbType.NVarChar) { Value = (object)employeeID ?? DBNull.Value });
                        cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.NVarChar) { Value = (object)date ?? DBNull.Value });

                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteAttendance(string attendanceID)
        {
            try
            {
                const string sql = @"DELETE FROM [dbo].[Attendance] WHERE [Attendance_ID] = @AttendanceID";
                using (var myConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.Add(new SqlParameter("@AttendanceID", SqlDbType.NVarChar) { Value = (object)attendanceID ?? DBNull.Value });
                        

                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void updateAttendance(string attendanceID, string employeeID, string date)
        {
            try
            {
                string sql = @"UPDATE [dbo].[Attendance] SET [Employee_ID]=@Employee_ID, [Date]=@Date WHERE [Attendance_ID]= @AttendanceID";

                using (var myConnection = new SqlConnection(_connectionString))
                {
                    using (var cmd = new SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.Add(new SqlParameter("@AttendanceID", SqlDbType.NVarChar) { Value = (object)attendanceID ?? DBNull.Value });
                        cmd.Parameters.Add(new SqlParameter("@Employee_ID", SqlDbType.NVarChar) { Value = (object)employeeID ?? DBNull.Value });
                        cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.NVarChar) { Value = (object)date ?? DBNull.Value });

                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public DataTable getAttendance()
        {
            try
            {
                const string sql = "SELECT * FROM [dbo].[Attendance]";
                using (var myConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, myConnection))
                    {
                        using (var adapter = new System.Data.SqlClient.SqlDataAdapter(cmd))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        
    }
}