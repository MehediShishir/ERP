using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnShow_click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;
            lblCompanyName.Text = companyName;

            string companyAddress = txtCompanyAddress.Text;
            lblCompanyAddress.Text = companyAddress;

            string companyPhoneNumber = txtCompanyPhoneNumber.Text;
            lblCompanyPhoneNumber.Text = companyPhoneNumber;

            string companyEmail = txtCompanyEmail.Text;
            lblCompanyEmail.Text = companyEmail;

            string companyType = txtCompanyType.Text;
            lblCompanyType.Text = companyType;

            
        }
    }
}