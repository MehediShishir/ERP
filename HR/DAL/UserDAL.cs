using System;
using System.Data.SqlClient;
using System.Configuration;

namespace HR.DAL
{
    public class UserDAL
    {
        private string conn = ConfigurationManager.ConnectionStrings["dberpconnection"].ConnectionString;

        public bool ValidateUser(string username, string password)
        {
            bool isValid = false;

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                string sql= "SELECT COUNT(*) FROM Admin WHERE Username=@username AND Password=@pass";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pass", password);

                int count = (int)cmd.ExecuteScalar(); //returns first rows first column. Thats why im getting the res

                isValid = count == 1;
            }

            return isValid;
        }
    }
}
