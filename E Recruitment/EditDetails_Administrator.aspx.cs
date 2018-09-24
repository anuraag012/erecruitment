using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;
using FactoryBLL;
using FactoryBO;

namespace E_Recruitment
{
    public partial class EditDetails_Administrator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                    bindBGCStatus();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }
        protected void bindBGCStatus()
        {
            int user = Convert.ToInt32(Session["BGCAdministratorID"]);
            try
            {
                List<ICandidateBO> ListObjBO = new List<ICandidateBO>();
                IBGCUpdatesBLL objBLL = FactoryBLL.BGCUpdatesFactoryBLL.CreateUpdatesBLL();
                ListObjBO = objBLL.EditBGCStatus_AdminBLL(user);
                GridView1.DataSource = ListObjBO;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
                
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GridView1.Rows[e.RowIndex];
                ICandidateBO objBO = FactoryBO.CandidateFactoryBO.CreateCandidate();
                HiddenField hdnfld = (HiddenField)row.FindControl("hdnField");
                objBO.CandidateProfileID = Convert.ToInt32(hdnfld.Value);
                DropDownList ddlBGCStatus = (DropDownList)row.FindControl("DDlBGCStatus");
                objBO.BGCTestStatus = ddlBGCStatus.SelectedItem.Text;
                TextBox txtRemarks = (TextBox)row.FindControl("TextBoxRemarks");
                objBO.Remarks = txtRemarks.Text;

                // List<ICandidateBO> ListObjBO = new List<ICandidateBO>();
                IBGCUpdatesBLL objBLL = FactoryBLL.BGCUpdatesFactoryBLL.CreateUpdatesBLL();
                int ret = objBLL.UpdateBGCStatus_AdminBLL(objBO);
                if (ret > 0)
                {
                    Response.Write("<script>alert('Updated Successfully')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Error')</script>");

                }
                GridView1.EditIndex = -1;
                bindBGCStatus();
                //GridView1.DataSource = ListObjBO;
                //GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridView1.EditIndex = e.NewEditIndex;
                bindBGCStatus();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                GridView1.PageIndex = e.NewPageIndex;
                bindBGCStatus();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }
    }
}