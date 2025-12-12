using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HR.DAL;


namespace HR.BLL
{
    public class UserBLL
    {
        UserDAL dal = new UserDAL();

        public bool Login(string username, string password)
        {
            // You can add extra logic here later (password hash, logs etc.)
            return dal.ValidateUser(username, password);
        }
    }
}


