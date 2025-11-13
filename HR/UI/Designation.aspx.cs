using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class Designation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string designationID = txtDesignationID.Text;
                string designationTitle = txtDesignationTitle.Text;
                string shortCode = txtShortCode.Text;

                string sql = @"INSERT INTO [dbo].[Designation]
                                ([Title], [Short_code])
                            VALUES
                                (@Title, @Short_code)";

                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();

                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@Title", designationTitle);
                        cmd.Parameters.AddWithValue("@Short_code", shortCode);

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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string designationID = txtDesignationID.Text;
                string designationTitle = txtDesignationTitle.Text;
                string shortCode = txtShortCode.Text;

                string sql = @"UPDATE [dbo].[Designation]
                    SET [Title] = @Title,[Short_code] = @Short_code 
                WHERE [Designation_ID]=@ID";

                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();

                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@ID", designationID);
                        cmd.Parameters.AddWithValue("@Title", designationTitle);
                        cmd.Parameters.AddWithValue("@Short_code", shortCode);

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
                string designationID = txtDesignationID.Text;
                string sql = "DELETE FROM [dbo].[Designation] WHERE [Designation_ID]=@ID";
                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@ID", designationID);
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
                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                System.Data.DataTable dtDesignation = new System.Data.DataTable();
                string sql = @"SELECT [Designation_ID]
                ,[Title]
                ,[Short_code]
                FROM [dbo].[Designation]";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtDesignation);
                }
                grdDesignation.DataSource = dtDesignation;
                grdDesignation.DataBind();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }


        }
        private void ClearControl()
        {
            txtDesignationID.Text = string.Empty;
            txtDesignationTitle.Text = string.Empty;
            txtShortCode.Text = string.Empty;
         
        }
    }
}