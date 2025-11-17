using HR.BLL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace HR.UI
{
    public partial class Designation : System.Web.UI.Page
    {
        DesignationBLL designationBLL;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void ClearControl()
        {
            txtDesignationID.Text = string.Empty;
            txtDesignationTitle.Text = string.Empty;
            txtShortCode.Text = string.Empty;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            showDesignation();
        }

        private void showDesignation()
        {
            try
            {
                designationBLL = new DesignationBLL();
                DataTable dt = designationBLL.getDesignations();

                grdDesignation.DataSource = dt;
                grdDesignation.DataBind();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                designationBLL = new DesignationBLL();
                designationBLL.addDesignation(
                    txtDesignationID.Text,
                    txtDesignationTitle.Text,
                    txtShortCode.Text
                );

                ClearControl();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                designationBLL = new DesignationBLL();
                designationBLL.updateDesignation(
                    txtDesignationID.Text,
                    txtDesignationTitle.Text,
                    txtShortCode.Text
                );

                ClearControl();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                designationBLL = new DesignationBLL();
                designationBLL.deleteDesignation(txtDesignationID.Text);

                ClearControl();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        protected void grdDesignation_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int selectedIndex = Convert.ToInt32(e.CommandArgument.ToString());

            string designationID = ((Label)grdDesignation.Rows[selectedIndex]
                .FindControl("lblDesignationID")).Text;

            if (e.CommandName == "Select")
            {
                txtDesignationID.Text = designationID;
                txtDesignationTitle.Text = ((Label)grdDesignation.Rows[selectedIndex]
                    .FindControl("lblDesignationTitle")).Text;
                txtShortCode.Text = ((Label)grdDesignation.Rows[selectedIndex]
                    .FindControl("lblShortCode")).Text;
            }
            else if (e.CommandName == "Delete")
            {
                try
                {
                    designationBLL = new DesignationBLL();
                    designationBLL.deleteDesignation(designationID);

                    ClearControl();
                }
                catch (Exception msgException)
                {
                    throw msgException;
                }
            }
        }

        protected void grdDesignation_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            showDesignation();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/StartPage.aspx");
        }
    }
}
