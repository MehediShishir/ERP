using HR.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HR.BLL
{
    public class EmployeeBLL
    {
        public void addEmployee(string name, string email, string mobile)
        {
            try
            {
                EmployeeDAL employeeDAL = new EmployeeDAL();
                employeeDAL.insertEmployee(name, email, mobile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void deleteEmployee(int id)
        {
            try
            {
                EmployeeDAL employeeDAL = new EmployeeDAL();
                employeeDAL.deleteEmployee(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateEmployee(int id, string name, string email, string mobile)
        {
            try
            {
                EmployeeDAL employeeDAL = new EmployeeDAL();
                employeeDAL.updateEmployee(id, name, email, mobile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getEmployees()
        {
            try
            {
                EmployeeDAL employeeDAL = new EmployeeDAL();
                return employeeDAL.getEmployees();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}