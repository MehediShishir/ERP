using HR.BLL;
using System;
using System.Data;

namespace HR.UI
{
    public partial class Designation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void ClearControl()
        {
            txtDesignationID.Text = "";
            txtDesignationTitle.Text = "";
            txtShortCode.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DesignationBLL bll = new DesignationBLL();
                bll.AddDesignation(txtDesignationID.Text,
                                   txtDesignationTitle.Text,
                                   txtShortCode.Text);

                ClearControl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DesignationBLL bll = new DesignationBLL();
                bll.UpdateDesignation(txtDesignationID.Text,
                                      txtDesignationTitle.Text,
                                      txtShortCode.Text);

                ClearControl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DesignationBLL bll = new DesignationBLL();
                bll.DeleteDesignation(txtDesignationID.Text);

                ClearControl();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DesignationBLL bll = new DesignationBLL();
                DataTable dt = bll.GetDesignations();

                grdDesignation.DataSource = dt;
                grdDesignation.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/StartPage.aspx");
        }
    }
}
