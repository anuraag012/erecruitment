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
    public partial class AddSelectedCandidates_HR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { if (!IsPostBack)
        {
            bindData();
        }

        }
        protected void bindData()
        {
            ICandidateBLL obj = CandidateFactoryBLL.createCandidateBLobj();
            grdaddemp.DataSource = obj.viewCandidateGrid();
            grdaddemp.DataBind();
        }

       protected void grdaddemp_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = grdaddemp.Rows[e.NewEditIndex];

            Label lblid = (Label)row.FindControl("Label1");
            Session["CandID"] = lblid.Text;
            int id = Convert.ToInt32(lblid.Text);
           

            Label lblname = (Label)row.FindControl("Label2");
            Session["candName"] = lblname.Text;
            string name = lblname.Text;
           
            Label lblloc = (Label)row.FindControl("Label4");
            Session["loc"] = lblloc.Text;
            string loc = lblloc.Text;
          
            ICandidateBLL obj = CandidateFactoryBLL.createCandidateBLobj();
            ICandidateBO objBo = CandidateFactoryBO.createEmployeeBO(id);
          
            Session["DOB"] = Convert.ToString(obj.getDob(id));
           
            Session["Gender"] = obj.getGender(id);
            Session["DOJ"] = Convert.ToString(obj.getDoj(id));
            Session["ProjectID"] = Convert.ToString(obj.getProjectID(id));
           
            Response.Redirect("AddEmployeeDetails_HR.aspx");
            grdaddemp.EditIndex = -1;
        }

        protected void grdaddemp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdaddemp.PageIndex = e.NewPageIndex;
            bindData();

        }
    }
}