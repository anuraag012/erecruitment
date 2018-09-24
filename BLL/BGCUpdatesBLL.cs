using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using FactoryBO;
using FactoryDAL;

namespace BLL
{
    public class BGCUpdatesBLL:IBGCUpdatesBLL
    {
        public int ChangePwdBLL(IBGCCheckBO objBO)
        {
            try
            {
                IBGCUpdatesDAL objDAL = FactoryDAL.BGCUpdatesFactoryDAL.CreateUpdatesDAL();
                int msg = objDAL.ChangePwdDAL(objBO);
                return msg;
            }
            catch { throw; }
        }
        public List<ICandidateBO> DisplayBGCStatus_HR()
        {
            try
            {
                IBGCUpdatesDAL objDAL = FactoryDAL.BGCUpdatesFactoryDAL.CreateUpdatesDAL();
                List<ICandidateBO> ListObjBO = new List<ICandidateBO>();

                ListObjBO = objDAL.ViewCandidates_HR();
                //  ICandidateBO obj = FactoryBO.CandidateFactoryBO.CreateCandidate();
                return ListObjBO;
            }
            catch { throw; }
        }

        public List<ICandidateBO> EditBGCStatus_AdminBLL(int user)
        {
            try
            {
                IBGCUpdatesDAL objDAL = FactoryDAL.BGCUpdatesFactoryDAL.CreateUpdatesDAL();
                List<ICandidateBO> ListObjBO = new List<ICandidateBO>();

                ListObjBO = objDAL.EditBGCStatus_AdminDAL(user);
                //  ICandidateBO obj = FactoryBO.CandidateFactoryBO.CreateCandidate();
                return ListObjBO;
            }
            catch { throw; }
        }
        public IBGCCheckBO Login_BGC(string Uname)
        {
            try
            {
                IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
                IBGCUpdatesDAL objDAL = FactoryDAL.BGCUpdatesFactoryDAL.CreateUpdatesDAL();
                objBO = objDAL.LoginDAL(Uname);
                return objBO;
            }
            catch { throw; }
        }
       public IBGCCheckBO Login_BGCAdmin(string Uname)
        {
            try
            {
                IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
                IBGCUpdatesDAL objDAL = FactoryDAL.BGCUpdatesFactoryDAL.CreateUpdatesDAL();
                objBO = objDAL.LoginDALAdmin(Uname);
                return objBO;
            }
            catch { throw; }
        }
       public List<int> fetch_DDLAdminBO()
       {
           try
           {
               List<int> DDLadminList = new List<int>();
               //IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
               IBGCUpdatesDAL objDAL = FactoryDAL.BGCUpdatesFactoryDAL.CreateUpdatesDAL();
               DDLadminList = objDAL.fetch_DDLAdminDAL();
               return DDLadminList;
           }
           catch { throw; }
       }
       public List<int> fetch_DDLVacBO()
       {
           try
           {
               List<int> DDLvacList = new List<int>();
               //IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
               IBGCUpdatesDAL objDAL = FactoryDAL.BGCUpdatesFactoryDAL.CreateUpdatesDAL();
               DDLvacList = objDAL.fetch_DDLVacDAL();
               return DDLvacList;
           }
           catch { throw; }
       }
       public DateTime fetch_ReqByDateBLL(int vacID)
       {
           try
           {
              // List<int> DDLvacList = new List<int>();
               //IBGCCheckBO objBO = FactoryBO.BGCCheckFactoryBO.CreateBGCCheck();
               IBGCUpdatesDAL objDAL = FactoryDAL.BGCUpdatesFactoryDAL.CreateUpdatesDAL();
               DateTime req = objDAL.fetch_ReqByDateDAL(vacID);
               return req;
           }
           catch { throw; }
       }
       public int CreateBGCBLL(IBGCCheckBO objBO)
       {
           try
           {
               IBGCUpdatesDAL objDAL = FactoryDAL.BGCUpdatesFactoryDAL.CreateUpdatesDAL();
               int BGCid = objDAL.CreateBGCDAL(objBO);
               return BGCid;
           }
           catch { throw; }
       }
        public int UpdateBGCStatus_AdminBLL(ICandidateBO objBO)
       {
           try
           {
               IBGCUpdatesDAL objDAL = FactoryDAL.BGCUpdatesFactoryDAL.CreateUpdatesDAL();
               int success = objDAL.UpdateBGCStatus_AdminDAL(objBO);
               return success;
           }
           catch { throw; }
       }
     }
}
