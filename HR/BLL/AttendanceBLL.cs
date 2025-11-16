using HR.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HR.BLL
{
    public class AttendanceBLL
    {
        public void addAttendance(string attendanceID, string employeeID, string date)
        {
            try
            {
                AttendanceDAL attendanceDAL = new HR.DAL.AttendanceDAL();
                attendanceDAL.insertAttendance(attendanceID, employeeID, date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void updateAttendance(string attendanceID, string employeeID, String date)
        {
            try
            {
                AttendanceDAL attendanceDAL = new AttendanceDAL();
                attendanceDAL.updateAttendance(attendanceID, employeeID, date);
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
                AttendanceDAL attendanceDAL = new AttendanceDAL();
                attendanceDAL.deleteAttendance(attendanceID);
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
                AttendanceDAL attendanceDAL = new AttendanceDAL();
                return attendanceDAL.getAttendance();
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}