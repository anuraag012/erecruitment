using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;
using FactoryBO;

namespace E_Recruitment
{
    public partial class ViewBGCStatus_HR : System.Web.UI.Page
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
                try
                {
                    List<ICandidateBO> ListObjBO = new List<ICandidateBO>();

                    IBGCUpdatesBLL objBLL = FactoryBLL.BGCUpdatesFactoryBLL.CreateUpdatesBLL();
                    ListObjBO = objBLL.DisplayBGCStatus_HR();

                    GridViewBGCStatusHR.DataSource = ListObjBO;
                    GridViewBGCStatusHR.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
                }
                
            }

            protected void GridViewBGCStatusHR_PageIndexChanging(object sender, GridViewPageEventArgs e)
            {
                GridViewBGCStatusHR.PageIndex = e.NewPageIndex;
                bindBGCStatus();
            }
        
        }
    }
