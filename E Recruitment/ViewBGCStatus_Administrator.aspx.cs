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
    public partial class ViewBGCStatus_Administrator : System.Web.UI.Page
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
                GridView2.DataSource = ListObjBO;
                GridView2.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }

        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                GridView2.PageIndex = e.NewPageIndex;
                bindBGCStatus();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }
    }
}