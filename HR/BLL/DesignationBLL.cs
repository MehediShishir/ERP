using HR.DAL;
using System;
using System.Data;

namespace HR.BLL
{
    public class DesignationBLL
    {
        public void addDesignation(string id, string title, string shortCode)
        {
            DesignationDAL dal = new DesignationDAL();
            dal.InsertDesignation(id, title, shortCode);
        }

        public void updateDesignation(string id, string title, string shortCode)
        {
            DesignationDAL dal = new DesignationDAL();
            dal.UpdateDesignation(id, title, shortCode);
        }

        public void deleteDesignation(string id)
        {
            DesignationDAL dal = new DesignationDAL();
            dal.DeleteDesignation(id);
        }

        public DataTable getDesignations()
        {
            DesignationDAL dal = new DesignationDAL();
            return dal.GetDesignations();
        }
    }
}
