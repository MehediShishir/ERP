using HR.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class Attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string attendanceID = txtAttendanceID.Text;
            string employeeID = txtEmployeeID.Text;
            string date = txtDate.Text;          
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try { 


                AttendanceBLL attendanceBLL = new HR.BLL.AttendanceBLL();
                DataTable dtAttendance = attendanceBLL.getAttendance();

                //            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                //            System.Data.DataTable dtAttendance = new System.Data.DataTable();
                //            string sql = @"SELECT [Attendance_ID]
                //    ,[Employee_ID]
                //    ,[Date]
                //FROM [dbo].[Attendance]";
                //            using (SqlConnection cn = new SqlConnection(connectionString))
                //            using (SqlCommand cmd = new SqlCommand(sql, cn))
                //            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                //            {
                //                da.Fill(dtAttendance);
                //            }
                grdAttendance.DataSource = dtAttendance;
                grdAttendance.DataBind();
            }
            catch (Exception msgException)
            {
                throw msgException;


            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string attendanceID = txtAttendanceID.Text;
                string employeeID = txtEmployeeID.Text;
                string date = txtDate.Text;



                AttendanceBLL attendanceBLL = new HR.BLL.AttendanceBLL();
                attendanceBLL.addAttendance(attendanceID, employeeID, date);
                //        string sql = @"INSERT INTO [dbo].[Attendance]
                //   ([Employee_ID]
                //   ,[Date])
                //VALUES
                //   (@Employee_ID
                //      ,@Date)";
                //        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                //        using (SqlConnection myConnection = new SqlConnection(connectionString))
                //        {
                //            using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                //            {
                //                cmd.Parameters.AddWithValue("@Employee_ID", employeeID);
                //                cmd.Parameters.AddWithValue("@Date", date);
                //                myConnection.Open();
                //                cmd.ExecuteNonQuery();
                //            }
                //        }
            }
            catch (Exception msgException)
            {
                
                throw msgException;
            }


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                string attendanceID = txtAttendanceID.Text;
                string employeeID = txtEmployeeID.Text;
                string date = txtDate.Text;

                AttendanceBLL attendanceBLL = new AttendanceBLL();
                attendanceBLL.updateAttendance(attendanceID, employeeID, date);

                //string sql = @"UPDATE [dbo].[Attendance] SET [Employee_ID]=@Employee_ID, [Date]=@Date WHERE [Attendance_ID]=@Attendance_ID";
                //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                //using (SqlConnection myConnection = new SqlConnection(connectionString))
                //{
                //    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                //    {
                //        cmd.Parameters.AddWithValue("@Attendance_ID", attendanceID);
                //        cmd.Parameters.AddWithValue("@Employee_ID", employeeID);
                //        cmd.Parameters.AddWithValue("@Date", date);
                //        myConnection.Open();
                //        cmd.ExecuteNonQuery();
                //    }
                //}
            }
            catch (Exception msgException)
            {
                throw msgException;


            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                string attendanceID = txtAttendanceID.Text;

                AttendanceBLL attendanceBLL = new HR.BLL.AttendanceBLL();
                attendanceBLL.deleteAttendance(attendanceID);

                //string sql = @"DELETE FROM [dbo].[Attendance] WHERE [Attendance_ID]=@Attendance_ID";
                //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dberpconnection"].ToString();
                //using (SqlConnection myConnection = new SqlConnection(connectionString))
                //{
                //    using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                //    {
                //        cmd.Parameters.AddWithValue("@Attendance_ID", attendanceID);
                //        myConnection.Open();
                //        cmd.ExecuteNonQuery();
                //    }
                //}
            }
            catch (Exception msgException)
            {
                throw msgException;


            }

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/StartPage.aspx");

        }
    }
}