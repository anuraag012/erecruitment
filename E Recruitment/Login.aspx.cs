using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Recruitment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string User = TxtUser.Text;
            string Pass = TxtPass.Text;
            if (User == "Employee" && Pass == "ChangePwd@123")
            {
                Response.Redirect("ChangePwd.aspx");
            }
            else
            {
                if (User == "Admin")
                {
                    Response.Redirect("EditDetails_Administrator.aspx");
                }
                else
                {
                    if (User == "HR")
                    {
                        Response.Redirect("AddBGCAdministrator_HR.aspx");
                    }

                    else
                    {

                        if (User == "UnitHead")
                        {
                            Response.Redirect("ApproveAdministrator_UnitHead.aspx");
                        }
                        else if (User == "Employee")
                        {
                            Response.Redirect("Emloyee.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('Please enter a valid Username or Password')</script>");
                        }

                    }
                }
            }

        }
        }
    }
