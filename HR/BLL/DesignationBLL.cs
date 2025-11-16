using HR.DAL;
using System;
using System.Data;

namespace HR.BLL
{
    public class DesignationBLL
    {
        public void AddDesignation(string id, string title, string shortCode)
        {
            DesignationDAL dal = new DesignationDAL();
            dal.InsertDesignation(id, title, shortCode);
        }

        public void UpdateDesignation(string id, string title, string shortCode)
        {
            DesignationDAL dal = new DesignationDAL();
            dal.UpdateDesignation(id, title, shortCode);
        }

        public void DeleteDesignation(string id)
        {
            DesignationDAL dal = new DesignationDAL();
            dal.DeleteDesignation(id);
        }

        public DataTable GetDesignations()
        {
            DesignationDAL dal = new DesignationDAL();
            return dal.GetDesignations();
        }
    }
}
