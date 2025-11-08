using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class Designation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string designationID = txtDesignationID.Text;
            lblDesignationID.Text = designationID;

            string designationTitle = txtDesignationTitle.Text;
            lblDesignationTitle.Text = designationTitle;

            string shortCode = txtShortCode.Text;
            lblShortCode.Text = shortCode;
        }
    }
}