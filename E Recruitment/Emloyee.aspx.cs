using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Recruitment
{
    public partial class Emloyee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string pass = Convert.ToString(Session["Pwd"]);
                if (pass == "ChangePwd")
                {
                    Response.Redirect("ChangePwd.aspx");
                }
                else
                {
                    Response.Redirect("Login1.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }
    }
}