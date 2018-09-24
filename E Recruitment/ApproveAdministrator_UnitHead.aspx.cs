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
    public partial class ApproveAdministrator_UnitHead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    bgcdata();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
        }
        private void bgcdata()
        {
            try
            {
                IEmployeeBLL objbll = EmployeeFactoryBLL.createnew();
                List<IEmployeeBO> list = objbll.displayunithead();
                BGCgrdview.DataSource = list;
                BGCgrdview.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
        }
        protected void BGCgrdview_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                BGCgrdview.EditIndex = e.NewEditIndex;
                bgcdata();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
        }

        protected void BGCgrdview_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = BGCgrdview.Rows[e.RowIndex];
                Label lbladminid2 = (Label)row.FindControl("lbladminid2");
                DropDownList ddlstatus = (DropDownList)row.FindControl("ddlstatus");
                Label lblStatusChangeTime2 = (Label)row.FindControl("lblStatusChangeTime2");
                int adminid = Convert.ToInt32(lbladminid2.Text);
                string status = ddlstatus.SelectedValue;
                DateTime statuschangetime = DateTime.Now;
                IEmployeeBO objbo = EmployeeBOFactory.CreateEmployee(adminid, status, statuschangetime);
                IEmployeeBLL objbll = EmployeeFactoryBLL.createnew();
                int check = objbll.displayapproved(objbo);
                if (check > 0)
                {
                    BGCgrdview.EditIndex = -1;
                    bgcdata();

                }
                else
                {
                    Response.Redirect("<script>alert('Employee details are not updated please update again')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }

        }

        protected void BGCgrdview_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                BGCgrdview.EditIndex = -1;
                bgcdata();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
        }

        protected void BGCgrdview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                BGCgrdview.PageIndex = e.NewPageIndex;
                bgcdata();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
        }

       

    }
}