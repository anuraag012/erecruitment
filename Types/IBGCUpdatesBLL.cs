using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCUpdatesBLL
    {
        int ChangePwdBLL(IBGCCheckBO objBO);
        List<ICandidateBO> DisplayBGCStatus_HR();
        IBGCCheckBO Login_BGC(string Uname);
        IBGCCheckBO Login_BGCAdmin(string Uname);
        List<int> fetch_DDLAdminBO();
        List<int> fetch_DDLVacBO();
        DateTime fetch_ReqByDateBLL(int vacID);
        int CreateBGCBLL(IBGCCheckBO objBO);
        List<ICandidateBO> EditBGCStatus_AdminBLL(int user);
        int UpdateBGCStatus_AdminBLL(ICandidateBO objBO);
    }
}
