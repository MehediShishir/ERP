using System;
using System.Data;
using System.Data.SqlClient;

namespace HR.DAL
{
    public class DesignationDAL
    {
        private readonly string _connectionString;

        public DesignationDAL()
        {
            _connectionString = System.Configuration.ConfigurationManager
                                .ConnectionStrings["dberpconnection"].ToString();
        }

        public void InsertDesignation(string id, string title, string shortCode)
        {
            string sql = @"INSERT INTO [dbo].[Designation]
                           ([Title], [Short_code])
                           VALUES (@Title, @Short_code)";

            using (SqlConnection cn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Short_code", shortCode);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDesignation(string id, string title, string shortCode)
        {
            string sql = @"UPDATE [dbo].[Designation]
                           SET [Title] = @Title,
                               [Short_code] = @Short_code
                           WHERE [Designation_ID] = @ID";

            using (SqlConnection cn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Short_code", shortCode);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDesignation(string id)
        {
            string sql = @"DELETE FROM [dbo].[Designation]
                           WHERE [Designation_ID] = @ID";

            using (SqlConnection cn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@ID", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetDesignations()
        {
            string sql = @"SELECT [Designation_ID], [Title], [Short_code]
                           FROM [dbo].[Designation]";

            using (SqlConnection cn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
