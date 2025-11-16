using System.Data;
using HR.DAL;

namespace HR.BLL
{
    public class LeaveApplicationBLL
    {
        LeaveApplicationDAL dal = new LeaveApplicationDAL();

        public void SaveLeaveApplication(string empID, string leaveType, string leaveDate)
        {
            dal.InsertLeaveApplication(empID, leaveType, leaveDate);
        }

        public DataTable ShowLeaveApplications()
        {
            return dal.GetLeaveApplications();
        }

        public void UpdateLeaveApplication(string leaveRequestID, string empID, string leaveType, string leaveDate)
        {
            dal.UpdateLeaveApplication(leaveRequestID, empID, leaveType, leaveDate);
        }

        public void DeleteLeaveApplication(string leaveRequestID)
        {
            dal.DeleteLeaveApplication(leaveRequestID);
        }
    }
}
