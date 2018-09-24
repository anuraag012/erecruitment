using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;
using FactoryBO;
using FactoryBLL;

namespace E_Recruitment
{
    public partial class ViewNewEmployees_HR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindData();
            }
        }
        protected void bindData()
        {
            try
            {


                for (int i = 0; i < 5; i++)
                {
                    List<IEmployeeBO> list = EmployeeBOFactory.createEmployeeBO();
                    IEmployeeBLL objBLL = EmployeeFactoryBLL.createEmployeeBLL();
                    list = objBLL.ViewEmployee();
                    grdEmployee.DataSource = list;

                    if (list.Count != 0)
                    {

                        grdEmployee.DataBind();
                    }
                    else
                    {
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Employee Doesnot Exit')", true);
                    }
                }
            }catch(Exception )
            { }
        }
        protected void grdEmployee_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdEmployee.PageIndex = e.NewPageIndex;
            bindData();
        }

      
    }
}