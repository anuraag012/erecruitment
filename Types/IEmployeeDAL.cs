using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IEmployeeDAL
    {
        //CRUD1
        List<int> displayDropdownDB();
        List<IEmployeeBO> displayDB();

        int addadminDB(IEmployeeBO obj);
        int displayapprovedDB(IEmployeeBO obj);

        List<IEmployeeBO> displayallDB();
        List<IEmployeeBO> displayeverythingDB();
        List<IEmployeeBO> displayunitheadDB();

        //CRUD3
         int addEmployeeDB(IEmployeeBO obj);
         List<int> getUHDB();
         List<IEmployeeBO> viewEmployeeDB();
         int editEmployeeDB(IEmployeeBO objBo);
         List<int> getUnitHeadIDDB();
         List<string> getEmployeeNameDB();

         List<int> getProjectIDDB();

         List<int> getEmployeeIDDB();

         string getEmpNameDB(int id);

         int getUnitIDDB(int id);

         int getCTCDB(int id);

         string getDesignationDB(int id);

         //int displayapprovedDB(IEmployeeBO obj);
    }
}
