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
    public partial class ViewAdministrators_HR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    databind();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
        }
        private void databind()
        {
            try
            {
                IEmployeeBLL empbll = EmployeeFactoryBLL.createnew();
                List<IEmployeeBO> newlist = empbll.displayall();
                viewgrdapproved.DataSource = newlist;
                viewgrdapproved.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
        }

        protected void viewgrdapproved_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                viewgrdapproved.PageIndex = e.NewPageIndex;
                databind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
        }

       
    }
}