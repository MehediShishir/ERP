using System;
using HR.BLL;

namespace HR
{
    public partial class Login : System.Web.UI.Page
    {
        UserBLL bll = new UserBLL();

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            bool result = bll.Login(username, password);

            if (result)
            {
                Session["User"] = username;
                Response.Redirect("StartPage.aspx");
            }
            else
            {
                lblMsg.Text = "Invalid username or password!";
            }
        }
    }
}
