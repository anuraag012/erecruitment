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
    public partial class AddEmployeeDetails_HR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                txtempname.Text = Session["candName"].ToString();
               
                txtloc.Text = Session["loc"].ToString();
                txtgend.Text = Session["Gender"].ToString();
                
                var dateTimeNow = DateTime.Parse(Session["DOB"].ToString());
                txtdob.Text = dateTimeNow.ToShortDateString();

                var dateTimeNow1 = DateTime.Parse(Session["DOJ"].ToString());
                txtdoj.Text = dateTimeNow1.ToShortDateString();
                txtPid.Text = Session["ProjectID"].ToString();

                if (!IsPostBack)
                {
                    IEmployeeBLL objEmpBLL = EmployeeFactoryBLL.createEmployeeBLL();
                    List<int> list1 = objEmpBLL.getUnitHeadID();
                    ddlunithead.DataSource = list1;
                    ddlunithead.DataBind();
                    ddlunithead.Items.Insert(0, "--Select--");
                }

            }


            catch (Exception)
            {
            }

        }


        private void DataBind()
        {
            ICandidateBLL objCandMng = CandidateFactoryBLL.createCandidateBLobj();
            ICandidateBO objCandBO = CandidateFactoryBO.createCandBO();
            //ddlunithead.Items.Insert(0, "--Select--");
            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                IEmployeeBLL objEmployeeMng = EmployeeFactoryBLL.createEmployeeBLobj();
                IEmployeeBO objEmployee = EmployeeBOFactory.createEmpBO();
                objEmployee.EmployeeName = txtempname.Text;
                objEmployee.DOJ = DateTime.Parse(txtdoj.Text);
                objEmployee.DOB = DateTime.Parse(txtdob.Text);
                objEmployee.Location = txtloc.Text;
                objEmployee.Gender = txtgend.Text;
                objEmployee.CTC = Convert.ToInt32(txtctc.Text);
                objEmployee.Designation = txtdesignation.Text;
                objEmployee.UnitHeadID = Convert.ToInt32(ddlunithead.SelectedValue);
              
                objEmployee.ProjectId = 100001;
                int ID = objEmployeeMng.addEmployee(objEmployee);
                int id = Int32.Parse(Session["CandID"].ToString());
                ICandidateBLL obj = CandidateFactoryBLL.createCandidateBLobj();
                ICandidateBO objBo = CandidateFactoryBO.createEmployeeBO(id);
                
                obj.deleteCandidate(id);
                Response.Write("<script>if(confirm('Details Submitted Successfully.    Employee ID :" + ID + "')){document.location='AddSelectedCandidates_HR.aspx';}</script>");
                
            }

            catch (Exception)
            { }
           
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSelectedCandidates_HR.aspx");
        }
    }
}