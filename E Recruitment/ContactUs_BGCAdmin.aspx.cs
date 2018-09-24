using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Recruitment
{
    public partial class ContactUs_BGCAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            Response.Write("<script>if(confirm('Email send successfully.')){document.location='Homepage_HR.aspx';}</script>");
        }
    }
}