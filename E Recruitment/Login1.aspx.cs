using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using Types;

namespace E_Recruitment
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
                IBGCUpdatesBLL objBLL = FactoryBLL.BGCUpdatesFactoryBLL.CreateUpdatesBLL();

                string User = txtusid.Text;
                string Pass = txtpwd.Text;
                Session["Pwd"] = Pass;

                if (User.Length == 6)
                {
                    objBO = objBLL.Login_BGC(User);

                    if (objBO.EmpPass == Pass)
                    {
                        if (objBO.EmpRole == "Employee")
                        {
                            Session["newEmp"] = User;
                            Response.Redirect("Emloyee.aspx");
                        }
                        else if (objBO.EmpRole == "Unit Head")
                        {
                            Response.Redirect("Homepage_UnitHead.aspx");
                        }
                        else if (objBO.EmpRole == "HR")
                        {
                            Response.Redirect("Homepage_HR.aspx");
                        }
                        else
                        {
                            // not employee
                            Response.Write("<script>alert('Please enter a valid Username or Password')</script>");
                        }
                    }
                    else
                    {
                        //not employee
                        Response.Write("<script>alert('Please enter a valid Username or Password')</script>");
                    }

                }
                else if (User.Length == 3)
                {
                    objBO = objBLL.Login_BGCAdmin(User);
                    Session["BGCAdministratorID"] = User;

                    if (objBO.RoleID == 3 && objBO.EmpPass == Pass)
                    {
                        //  if(objBO.EmpPass==Pass)
                        // {
                        Response.Redirect("Homepage_BGCAdmin.aspx");
                        //   }

                    }
                    else
                    {
                        //not BGC admin
                        Response.Write("<script>alert('Please enter a valid Username or Password')</script>");
                    }
                }

                {
                    //not Admin
                    Response.Write("<script>alert('Please enter a valid Username or Password')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }

        }
    }

}
