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
    public partial class DepartmentSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void ClearControl()
        {
            txtDepartmentID.Text = string.Empty;
            txtDepartmentName.Text = string.Empty;
            txtDescription.Text = string.Empty;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string departmentID = txtDepartmentID.Text;
            string departmentName = txtDepartmentName.Text;
            string description = txtDescription.Text;


        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string departmentID = txtDepartmentID.Text;
                string departmentName = txtDepartmentName.Text;
                string description = txtDescription.Text;

                string sql = @"INSERT INTO [dbo].[Department]
                        ([Name]
                        ,[Description])
                    VALUES
                        (@Name, @Description);";

                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();

                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@Name", departmentName);
                        cmd.Parameters.AddWithValue("@Description", description);

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
                string departmentID = txtDepartmentID.Text;
                string departmentName = txtDepartmentName.Text;
                string description = txtDescription.Text;

                string sql = @"UPDATE [dbo].[Department]
                    SET [Name] = @Name
                         ,[Description] = @Description
                    WHERE [Department_ID] = @ID";

                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();

                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@ID", departmentID);
                        cmd.Parameters.AddWithValue("@Name", departmentName);
                        cmd.Parameters.AddWithValue("@Description", description);
                        
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
                System.Data.DataTable dtDedepartment = new System.Data.DataTable();
                string sql = @"SELECT [Department_ID]
                ,[Name]
                ,[Description]
                FROM [dbo].[Department]";
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtDedepartment);
                }
                grdDepartment.DataSource = dtDedepartment;
                grdDepartment.DataBind();
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
                string departmentID = txtDepartmentID.Text;
                string sql = "DELETE FROM [dbo].[Department] WHERE [Department_ID]=@ID";
                string connectionString = ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@ID", departmentID);
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