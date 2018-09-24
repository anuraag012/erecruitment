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
    public partial class ChangePwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPass = TxtOldPass.Text;
                string newPass = TxtNewPass.Text;
                string confirmPass = TxtConfirmPass.Text;
                if (oldPass != "ChangePwd")
                {
                    Response.Write("<script>alert('Please enter a valid Password')</script>");
                }

                else if (oldPass == newPass)
                {
                    Response.Write("<script>alert('Please enter a new Password')</script>");
                }
                else if (newPass != confirmPass)
                {
                    Response.Write("<script>alert('Password Mismatch')</script>");
                }
                else
                {
                    IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
                    IBGCUpdatesBLL objBLL = FactoryBLL.BGCUpdatesFactoryBLL.CreateUpdatesBLL();
                    // objBO.EmpPass = oldPass;
                    objBO.EmpID = Convert.ToInt32(Session["newEmp"]);

                    objBO.NewEmpPass = confirmPass;
                    int ret = objBLL.ChangePwdBLL(objBO);
                    if (ret == 1)
                    {
                        Response.Write("<script>alert('Your password is updated successfully. Please login again with the new credentials to activate your account.');window.location ='Login1.aspx';</script>");

                    }
                    else
                    {
                        Response.Write("<script>alert('Your password could not be updated. Please enter valid credentials.')</script>");
                    }
                    //Response.Write("<script>alert('"+msg+"')</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }
        protected void BtnReset_Click(object sender, EventArgs e)
        {
            try{
            Response.Redirect("ChangePwd.aspx");
            }
             catch(Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }


    }
}