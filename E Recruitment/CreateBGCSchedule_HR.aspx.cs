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
    public partial class CreateBGCSchedule_HR : System.Web.UI.Page
    {
        DateTime x = DateTime.Now;
       // DateTime req = new DateTime();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    
                    List<int> DDLadminList = new List<int>();

                    IBGCUpdatesBLL objBLL = FactoryBLL.BGCUpdatesFactoryBLL.CreateUpdatesBLL();

                    DDLadminList = objBLL.fetch_DDLAdminBO();
                    DdlAdminID.Items.Add(new ListItem("--Select--", "0"));
                    foreach (var item in DDLadminList)
                    {
                        DdlAdminID.Items.Add(new ListItem(item.ToString()));
                    }

                    List<int> DDLVacancyList = new List<int>();

                    IBGCUpdatesBLL objBLL2 = FactoryBLL.BGCUpdatesFactoryBLL.CreateUpdatesBLL();

                    DDLVacancyList = objBLL2.fetch_DDLVacBO();
                    DdlVacancyID.Items.Add(new ListItem("--Select--", "0"));
                    foreach (var item in DDLVacancyList)
                    {
                        DdlVacancyID.Items.Add(new ListItem(item.ToString()));
                    }

               
                    DdlVacancyID.Enabled = false;
                    RFVVacancyID.Enabled = false;
                    TextBoxReqByDate.Text = "Please select a vacancy ID";
                    TextBoxReqByDate.Enabled = false;
                    TextBoxFromDate.Text = x.ToString("yyyy-MM-dd");
                    TextBoxFromDate.Enabled = false;
                    TextBoxToDate.Text = x.ToString("yyyy-MM-dd");
                    TextBoxToDate.Enabled = false;
                    RFVFromDate.Enabled = false;
                    RFVToDate.Enabled = false;

                    RVFromDate.MaximumValue = x.AddDays(-1).ToString("MM-dd-yyyy");
                    RVFromDate.MinimumValue = x.AddDays(-7).ToString("MM-dd-yyyy");
                    RVToDate.MaximumValue = x.AddDays(-1).ToString("MM-dd-yyyy");
                    RVToDate.MinimumValue = x.AddDays(-7).ToString("MM-dd-yyyy");
                }

             }

            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }
        //protected void DdlVacancyID_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
        protected void CreateBGCScheduleButton_Click(object sender, EventArgs e)
        {
            try
            {
                IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
                objBO.AdminID = Convert.ToInt32(DdlAdminID.SelectedItem.Text);
                objBO.VacancyID = Convert.ToInt32(DdlVacancyID.SelectedItem.Text);
                objBO.FromDate = Convert.ToDateTime(TextBoxFromDate.Text);
                objBO.ToDate = Convert.ToDateTime(TextBoxToDate.Text);
                IBGCUpdatesBLL objBLL = FactoryBLL.BGCUpdatesFactoryBLL.CreateUpdatesBLL();
                int BGCID = objBLL.CreateBGCBLL(objBO);
                Response.Write("<script>alert('BGC schedule is created successfully. BGC ID: " + BGCID + "')</script>");
                CreateBGCScheduleButton.Enabled = false;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }

        //protected void DdlVacancyID_TextChanged(object sender, EventArgs e)
        //{

        //}

        protected void DdlVacancyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IBGCUpdatesBLL objBLL3 = FactoryBLL.BGCUpdatesFactoryBLL.CreateUpdatesBLL();
                 
                if (DdlVacancyID.SelectedValue == "0")
                {
                    TextBoxReqByDate.Text = "Please select a vacancy ID";
                    TextBoxReqByDate.Enabled = false;
                    TextBoxFromDate.Enabled = false;
                    TextBoxToDate.Enabled = false;
                    RFVFromDate.Enabled = false;
                    RFVToDate.Enabled = false;
                }
                else
                {
                    int VacId = Convert.ToInt32(DdlVacancyID.SelectedItem.Text);
                    DateTime req = new DateTime();
                    req = objBLL3.fetch_ReqByDateBLL(VacId);
                    Session["RBD"]=req;
                    TextBoxReqByDate.Text = (req).ToString("MM-dd-yyyy");
                    
                    TextBoxFromDate.Enabled = true;
                    RFVFromDate.Enabled = true;
                    TextBoxFromDate.Text = req.ToString("yyyy-MM-dd");
                    TextBoxToDate.Enabled = true;
                    RFVToDate.Enabled = true;
                    TextBoxToDate.Text = req.ToString("yyyy-MM-dd");
                    RVFromDate.Enabled = true;
                    RVToDate.Enabled = true;
                    RVFromDate.MaximumValue = req.AddDays(-1).ToString("MM-dd-yyyy");
                    RVFromDate.MinimumValue = req.AddDays(-7).ToString("MM-dd-yyyy");
                   // RVToDate.MaximumValue = req.AddDays(-1).ToString("MM-dd-yyyy");
                  //  RVToDate.MinimumValue = req.AddDays(-6).ToString("MM-dd-yyyy");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }

        protected void DdlAdminID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(DdlAdminID.SelectedValue=="0")
                {
                    TextBoxReqByDate.Text = "Please select an Admin ID";
                    DdlVacancyID.Enabled = false;
                    RFVVacancyID.Enabled = false;
                    TextBoxReqByDate.Enabled = false;
                    TextBoxFromDate.Enabled = false;
                    TextBoxToDate.Enabled = false;
                    RFVFromDate.Enabled = false;
                    RFVToDate.Enabled = false;
                }
                else
                {
                    TextBoxReqByDate.Text = "Please select a Vacancy ID";
                    DdlVacancyID.Enabled = true;
                    RFVVacancyID.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception: " + ex.Message + "');window.location ='Login1.aspx';</script>");
            }
        }

        protected void TextBoxFromDate_TextChanged(object sender, EventArgs e)
        {
           DateTime FromDate = Convert.ToDateTime(TextBoxFromDate.Text);
           DateTime req = Convert.ToDateTime(Session["RBD"]);
           RVToDate.MaximumValue = req.AddDays(-1).ToString("MM-dd-yyyy");
           RVToDate.MinimumValue = FromDate.AddDays(1).ToString("MM-dd-yyyy");
        }
        
                //IBGCUpdatesBLL objBLL3 = FactoryBLL.BGCUpdatesFactoryBLL.CreateUpdatesBLL();
                //DateTime req = new DateTime();
                //int VacId = Convert.ToInt32(DdlVacancyID.SelectedItem.Text);
                //req = objBLL3.fetch_ReqByDateBLL(VacId);
                //TextBoxReqByDate.Text = (req).ToShortDateString();

    }
}