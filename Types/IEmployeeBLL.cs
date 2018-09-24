using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
   public interface IEmployeeBLL
    {
       //CRUD1
       List<int> displaydropdown();
       int addadmin(IEmployeeBO obj);
       List<IEmployeeBO> display();
       int displayapproved(IEmployeeBO obj);

       List<IEmployeeBO> displayall();
       List<IEmployeeBO> everythingdisplay();
       List<IEmployeeBO> displayunithead();

       //CRUD3
       int addEmployee(IEmployeeBO obj);
       List<int> getUH();
       List<IEmployeeBO> ViewEmployee();

       List<string> getEmployeeName();

       List<int> getUnitHeadID();
     int editEmployees(IEmployeeBO objBo);



     List<int> getProjectID();

     List<int> getEmployeeID();

     string getEmpName(int id);

    

    int getUnitHeadId(int id);

    int  getctc(int id);

    string getDesignation(int id);




    }
}
