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
    public partial class EditEmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IEmployeeBLL objEmpBLL = EmployeeFactoryBLL.createEmployeeBLL();
                List<int> list = objEmpBLL.getEmployeeID();
                ddlEmpID.DataSource = list;
                ddlEmpID.DataBind();
                ddlEmpID.Items.Insert(0, "--Select--");
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string empName = txtEmpName.Text;
                string designation = txtdesignation.Text;
                Int32 ctc = Convert.ToInt32(txtctc.Text);
                Int32 unitHead = Convert.ToInt32(txtUnitHead.Text);
                IEmployeeBO objBo = EmployeeBOFactory.createEmployeeBO(empName, designation, ctc, unitHead);
                IEmployeeBLL objBll = EmployeeFactoryBLL.createEmployeeBLL();
                int res = objBll.editEmployees(objBo);
           
            if (res > 0)
            {
                Response.Write("<script>if(confirm('Employee Details Updated  Successfully.')){document.location='EditEmployeeDetails.aspx';}</script>");
               
            }
            else
            {
                Response.Write("<script>if(confirm('Employee not Details Updated  Successfully.')){document.location='EditEmployeeDetails.aspx';}</script>");
            }
            }
            catch (Exception)
            {

            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
            LblEmpID.Visible = true;
            LblEmpName.Visible = true;
            LblDesgn.Visible = true;
            LblCTC.Visible = true;
            LblUnitHeadID.Visible = true;
            txtEmpID.Visible = true;
            txtEmpName.Visible = true;
            txtdesignation.Visible = true;
            txtctc.Visible = true;
            rectc.Visible = true;
            redesignation.Visible = true;
            rfvctc.Visible = true;
            rfvdesignation.Visible = true;

            txtUnitHead.Visible = true;
            BtnUpdate.Visible = true;
            BtnCancel.Visible = true;
            BtnSubmit.Visible = false;
            LblEmpID1.Visible = false;
            ddlEmpID.Visible = false;
            int id = Convert.ToInt32(ddlEmpID.SelectedValue);

            Session["empid"] = ddlEmpID.SelectedValue;
                txtEmpID.Text = Session["empid"].ToString();
                IEmployeeBO objBo = EmployeeBOFactory.createEmployeeBO(id);
                IEmployeeBLL objBll = EmployeeFactoryBLL.createEmployeeBLL();
                txtEmpName.Text = objBll.getEmpName(id);

                txtUnitHead.Text =Convert.ToString(objBll.getUnitHeadId(id));
                txtctc.Text = Convert.ToString(objBll.getctc(id));
                txtdesignation.Text = objBll.getDesignation(id);

                txtUnitHead.DataBind();

                txtEmpName.DataBind();
                ddlEmpID.Items.Insert(0, "--Select--");
            }
            catch (Exception)
            {

            }
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditEmployeeDetails.aspx");
        }
    }
}