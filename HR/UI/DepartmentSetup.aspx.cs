using System;
using System.Collections.Generic;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string departmentID = txtDepartmentID.Text;
            lblDepartmentID.Text = departmentID;

            string departmentName = txtDepartmentName.Text;
            lblDepartmentName.Text = departmentName;

            string description = txtDescription.Text;
            lblDescription.Text = description;

        }
    }
}