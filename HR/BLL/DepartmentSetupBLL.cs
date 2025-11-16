using HR.DAL;
using System;
using System.Data;

namespace HR.BLL
{
    public class DepartmentSetupBLL
    {
        public void AddDepartment(string departmentID, string name, string description)
        {
            try
            {
                DepartmentSetupDAL dal = new DepartmentSetupDAL();
                dal.InsertDepartment(departmentID, name, description);
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
                DepartmentSetupDAL dal = new DepartmentSetupDAL();
                dal.UpdateDepartment(departmentID, name, description);
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
                DepartmentSetupDAL dal = new DepartmentSetupDAL();
                dal.DeleteDepartment(departmentID);
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
                DepartmentSetupDAL dal = new DepartmentSetupDAL();
                return dal.GetDepartments();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
