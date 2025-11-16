using System;
using System.Data;
using System.Data.SqlClient;

namespace HR.DAL
{
    public class DepartmentSetupDAL
    {
        private readonly string _connectionString;

        public DepartmentSetupDAL()
        {
            _connectionString = System.Configuration.ConfigurationManager
                                .ConnectionStrings["dberpconnection"].ToString();
        }

        public void InsertDepartment(string departmentID, string name, string description)
        {
            try
            {
                string sql = @"INSERT INTO [dbo].[Department]
                               ([Name], [Description])
                               VALUES (@Name, @Description)";

                using (SqlConnection cn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Description", description);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateDepartment(string departmentID, string name, string description)
        {
            try
            {
                string sql = @"UPDATE [dbo].[Department]
                               SET [Name] = @Name,
                                   [Description] = @Description
                               WHERE [Department_ID] = @ID";

                using (SqlConnection cn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@ID", departmentID);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Description", description);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteDepartment(string departmentID)
        {
            try
            {
                string sql = @"DELETE FROM [dbo].[Department]
                               WHERE [Department_ID] = @ID";

                using (SqlConnection cn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@ID", departmentID);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetDepartments()
        {
            try
            {
                string sql = @"SELECT [Department_ID], [Name], [Description]
                               FROM [dbo].[Department]";

                using (SqlConnection cn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
