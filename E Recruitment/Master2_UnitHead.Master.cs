﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Recruitment
{
    public partial class Master2_UnitHead : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logout2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login1.aspx");
        }
    }
}