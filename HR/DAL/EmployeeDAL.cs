using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace HR.DAL
{
    public class EmployeeDAL
    {
        private readonly string _connectionString;

        public EmployeeDAL()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
        }

        public void insertEmployee(string name, string email, string mobile)
        {
            try {
                const string sql = @"INSERT INTO [dbo].[Employee] ([Name], [Email], [Phone_number]) VALUES(@Name, @Email, @MobileNumber)";
                using (var myConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = (object)name ?? DBNull.Value });
                        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar) { Value = (object)email ?? DBNull.Value });
                        cmd.Parameters.Add(new SqlParameter("@MobileNumber", SqlDbType.NVarChar) { Value = (object)mobile ?? DBNull.Value });

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
        public void deleteEmployee(int id)
        {
            try {
                const string sql = @"DELETE FROM [dbo].[Employee] WHERE [ID] = @ID";
                using (var myConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = id });
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
        public void updateEmployee(int id, string name, string email, string mobile)
        {
            try {
                const string sql = @"UPDATE [dbo].[Employee] SET [Name] = @Name, [Email] = @Email, [Phone_number] = @MobileNumber WHERE [ID] = @ID";
                using (var myConnection = new System.Data.SqlClient.SqlConnection(_connectionString))
                {
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = id });
                        cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = (object)name ?? DBNull.Value });
                        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar) { Value = (object)email ?? DBNull.Value });
                        cmd.Parameters.Add(new SqlParameter("@MobileNumber", SqlDbType.NVarChar) { Value = (object)mobile ?? DBNull.Value });
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
        public DataTable getEmployees()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
            DataTable dtEmployee = new DataTable();

            string sql = @"SELECT [ID], [Name], [Email], [Phone_number]
                   FROM [dbo].[Employee]";

            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dtEmployee);
            }

            return dtEmployee;
        }

    }
}