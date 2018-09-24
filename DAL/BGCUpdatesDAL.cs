using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using FactoryBO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class BGCUpdatesDAL:IBGCUpdatesDAL
    {



        public int ChangePwdDAL(IBGCCheckBO objBO)
        {
            try
            {

            int ret;
         //   IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
            SqlConnection conn = new SqlConnection();
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            conn.ConnectionString = str;
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "ChangePwd";
            comm.Parameters.AddWithValue("@EmployeeID", objBO.EmpID);
           // comm.Parameters.AddWithValue("@Password", objBO.EmpPass);
            comm.Parameters.AddWithValue("@NewPwd", objBO.NewEmpPass);

            //objBO.EmpID = Convert.ToInt32(Uname);
            comm.Connection = conn;
            int rows = comm.ExecuteNonQuery();
            if(rows>0)
            {
               // msg = "Password Updated";
                ret = 1;
            }
            else
            {
               // msg = "Could not Update your Password. Please enter valid Credentials";
                ret = 0;
            }

           // SqlDataReader reader = comm.ExecuteReader();
            //while (reader.Read())
            //{
            //    objBO.EmpRole = Convert.ToString(reader["Role1"]);
            //    objBO.EmpPass = Convert.ToString(reader["Password"]);
            //    return objBO;
            //}
            return ret;
            }
            catch
            {
                throw;
            }

        }

        public List<ICandidateBO> ViewCandidates_HR()
        {
            try
            {

                //List<ICandidateBO> candidateList = new List<ICandidateBO>();
                List<ICandidateBO> candidateList = new List<ICandidateBO>();

                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "ViewBGCStatus_HR";
                comm.Connection = conn;
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    ICandidateBO objBO = FactoryBO.CandidateFactoryBO.CreateCandidate();
                    objBO.CandidateProfileID = Convert.ToInt32(reader["Candidate_profile_ID"]);
                    int testStatus = Convert.ToInt32(reader["TestStatus"]);
                    if (testStatus >= 5)
                    {
                        objBO.TestStatus = "Cleared";
                    }
                    else
                    {
                        objBO.TestStatus = "Not Cleared";
                    }

                    int BGCTestStatus = Convert.ToInt32(reader["BGCTest_Status"]);
                    if (BGCTestStatus == 1)
                    {
                        objBO.BGCTestStatus = "Cleared";
                        objBO.Remarks = "NA";
                    }
                    else if (BGCTestStatus == 2)
                    {
                        objBO.BGCTestStatus = "Rejected";
                        objBO.Remarks = Convert.ToString(reader["Remarks"]);
                    }
                    else if (BGCTestStatus == 0)
                    {
                        objBO.BGCTestStatus = "Pending";
                        objBO.Remarks = "NA";
                    }
                    else
                    {
                        objBO.BGCTestStatus = "Pending";
                        objBO.Remarks = "NA";
                    }
                    candidateList.Add(objBO);
                }
                conn.Close();
                return candidateList;
            }
            catch
            {
                throw;
            }

        }

        public List<ICandidateBO> EditBGCStatus_AdminDAL(int user)
        {
            try
            {
                
                // int adminId = Convert.ToInt32(Session["BGCAdministratorID"]);
                //List<ICandidateBO> candidateList = new List<ICandidateBO>();
                List<ICandidateBO> candidateList = new List<ICandidateBO>();

                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "displayBGCStatus_admin1";
                comm.Parameters.AddWithValue("@userID", user);
               // comm.Parameters.AddWithValue("", );
                comm.Connection = conn;
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    ICandidateBO objBO = FactoryBO.CandidateFactoryBO.CreateCandidate();
                    objBO.CandidateProfileID = Convert.ToInt32(reader["Candidate_profile_ID"]);
                    objBO.VacancyID = Convert.ToInt32(reader["Vacancy_ID"]);
                    objBO.BGCTestID = Convert.ToInt32(reader["BGCTest_ID"]);
                    int testStatus = Convert.ToInt32(reader["TestStatus"]);
                    if (testStatus >= 5)
                    {
                        objBO.TestStatus = "Cleared";
                    }
                    else
                    {
                        objBO.TestStatus = "Not Cleared";
                    }

                    int BGCTestStatus = Convert.ToInt32(reader["BGCTest_Status"]);
                    //if (BGCTestStatus == 0)
                    //{
                    //    objBO.BGCTestStatus = "Pending";
                    //    objBO.Remarks = "NA";
                    //}
                    //else
                    //{
                    //    objBO.BGCTestStatus = "Rejected";
                    //    objBO.Remarks = Convert.ToString(reader["Remarks"]);
                    //}
                    if (BGCTestStatus == 1)
                    {
                        objBO.BGCTestStatus = "Cleared";
                        objBO.Remarks = "NA";
                    }
                    else if (BGCTestStatus == 2)
                    {
                        objBO.BGCTestStatus = "Rejected";
                        objBO.Remarks = Convert.ToString(reader["Remarks"]);
                    }
                    else if (BGCTestStatus == 0)
                    {
                        objBO.BGCTestStatus = "Pending";
                        objBO.Remarks = "NA";
                    }
                    else
                    {
                        objBO.BGCTestStatus = "Pending";
                        objBO.Remarks = "NA";
                    }

                    candidateList.Add(objBO);
                }
                conn.Close();
                return candidateList;
            }
            catch
            {
                throw;
            }
        }
        public IBGCCheckBO LoginDAL(string Uname)
        {
            try
            {
                IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "fetch_login_BGC";
                comm.Parameters.AddWithValue("@EmployeeID", Uname);
                objBO.EmpID = Convert.ToInt32(Uname);
                comm.Connection = conn;
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    objBO.EmpRole = Convert.ToString(reader["Role1"]);
                    objBO.EmpPass = Convert.ToString(reader["Password"]);
                    return objBO;
                }
                return objBO;
            }
            catch
            {
                throw;
            }
        }

        public IBGCCheckBO LoginDALAdmin(string Uname)
        {
            try
            {
                IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "BGC_login";
                comm.Parameters.AddWithValue("@AdministratorID", Uname);
                objBO.EmpID = Convert.ToInt32(Uname);
                comm.Connection = conn;
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    objBO.RoleID = Convert.ToInt32(reader["role_ID"]);
                    objBO.EmpPass = Convert.ToString(reader["Password"]);
                    return objBO;
                }
                return objBO;
            }
            catch
            {
                throw;
            }
        }
        public List<int> fetch_DDLAdminDAL()
        {
            try
            {
                List<int> DDLAdminList = new List<int>();
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "fetch_DDLAdminID";
                comm.Connection = conn;
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    // IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
                    int AdminID = Convert.ToInt32(reader["AdministratorID"]);
                    DDLAdminList.Add(AdminID);
                }
                return DDLAdminList;
            }
            catch
            {
                throw;
            }

        }
        public List<int> fetch_DDLVacDAL()
        {
            try
            {
                List<int> DDLVacList = new List<int>();
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "fetch_DDLVacID";
                comm.Connection = conn;
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    // IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
                    int VacID = Convert.ToInt32(reader["Vacancy_ID"]);
                    DDLVacList.Add(VacID);
                }
                return DDLVacList;
            }
            catch { throw; }
        }
       
        public DateTime fetch_ReqByDateDAL(int vacID)
        {
            try
            {
                DateTime temp = DateTime.Now;
               // List<int> DDLVacList = new List<int>();
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "fetch_ReqDate";
                comm.Connection = conn;
                comm.Parameters.AddWithValue("@VacancyID", vacID);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    // IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
                    //int VacID = Convert.ToInt32(reader["Vacancy_ID"]);
                    DateTime req1 = Convert.ToDateTime(reader["Require_by_date"]);
                    return req1;
                    //DDLVacList.Add(VacID);
                }
                //return DDLVacList;
                return temp;
            }
            catch { throw; }
        }
        public int CreateBGCDAL(IBGCCheckBO objBO)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "CreateBGCSchedule";
                comm.Connection = conn;
                comm.Parameters.AddWithValue("@FromDate", objBO.FromDate);
                comm.Parameters.AddWithValue("@ToDate", objBO.ToDate);
                comm.Parameters.AddWithValue("@AdminID", objBO.AdminID);
                comm.Parameters.AddWithValue("@VacancyID", objBO.VacancyID);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    int BGCID = Convert.ToInt32(reader["BGCID"]);
                    return BGCID;
                }
                return 0;
                //int rows=comm.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

        }
        public int UpdateBGCStatus_AdminDAL(ICandidateBO objBO)
        {
            try
            {
                int testValue;
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "UpdateBGCStatus_admin";
                comm.Connection = conn;
                comm.Parameters.AddWithValue("@Candidate_profile_ID", objBO.CandidateProfileID);

                if (objBO.BGCTestStatus == "Cleared")
                {
                    testValue = 1;
                }
                else if (objBO.BGCTestStatus == "Rejected")
                {
                    testValue = 2;
                }
                else
                {
                    testValue = 0;
                }

                comm.Parameters.AddWithValue("@BGCTest_Status", testValue);
                comm.Parameters.AddWithValue("@Remarks", objBO.Remarks);
                int rows = comm.ExecuteNonQuery();
                return rows;
            }
            catch
            {
                throw;
            }
        }


    }
}
