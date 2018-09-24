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
    public partial class Add_BGC_Administrator_HR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                bindddl();
            }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
            
        }
        private void binddata()
        {
            try
            {

            IEmployeeBLL empbll = EmployeeFactoryBLL.createnew();
            List<IEmployeeBO> list = empbll.display();
            addBGCview.Visible = true;
            addBGCview.DataSource = list;
            addBGCview.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }

        }
        private void bindddl()
        {
            try
            {
                //List<IEmployeeBO> dispemp = new List<IEmployeeBO>();
                //IEmployeeBO empbo = EmployeeBOFactory.CreateEmployee();
            IEmployeeBLL empbll = EmployeeFactoryBLL.createnew();
            ddlAdmin.DataSource = empbll.displaydropdown();
            ddlAdmin.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
        }

        protected void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
            //for (int i = 0; i <= 5; i++)
            //{
            int employeeid = Convert.ToInt32(ddlAdmin.SelectedItem.Text);
            string status = "Pending";
            DateTime statusChangeTime = DateTime.Now;
            int role_id = 3;
            int administratorID = 0;
            IEmployeeBO empadd = EmployeeBOFactory.createemp(employeeid, status, statusChangeTime, role_id, administratorID);

            IEmployeeBLL empbll = EmployeeFactoryBLL.createnew();
            List<IEmployeeBO> list = empbll.everythingdisplay();
            //foreach (IEmployeeBO item in list)
            //{
            //    if(item.EmployeeID==500002)
            //    Response.Write("found");
            //}
            var match = list.Exists(p => p.EmployeeID == employeeid);
            if (match == false)
            {

                int check = empbll.addadmin(empadd);
                ddlAdmin.Items.Remove(ddlAdmin.SelectedItem.Text);

                if (check > 0)
                {

                    binddata();

                }
            }

            else
            {
                Response.Write("<script>alert('The employee selected is already a BGC ADMINISTRATOR please select another employee.');</script>");
                ddlAdmin.Items.Remove(ddlAdmin.SelectedItem.Text);


                binddata();

            }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }

        }
        protected void addBGCview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
            addBGCview.PageIndex = e.NewPageIndex;
            binddata();
        }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');</script>");
            }
        }

        
        
    }
}