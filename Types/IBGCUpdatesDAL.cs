using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
   public interface IBGCUpdatesDAL
    {
       int ChangePwdDAL(IBGCCheckBO objBO);
       List<ICandidateBO> ViewCandidates_HR();
       IBGCCheckBO LoginDAL(string Uname);
       IBGCCheckBO LoginDALAdmin(string Uname);
       List<int> fetch_DDLAdminDAL();
       List<int> fetch_DDLVacDAL();
       DateTime fetch_ReqByDateDAL(int vacID);
       int CreateBGCDAL(IBGCCheckBO objBO);
       List<ICandidateBO> EditBGCStatus_AdminDAL(int user);
       int UpdateBGCStatus_AdminDAL(ICandidateBO objBO);
    }
}
