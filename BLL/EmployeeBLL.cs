using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using FactoryDAL;
namespace BLL
{
    public class EmployeeBLL:IEmployeeBLL
    {
        //crud1
        public List<int> displaydropdown()
        {
            IEmployeeDAL obj1 = EmployeeDALFactory.createDAL();
            List<IEmployeeBO> newlist = new List<IEmployeeBO>();
            
            return (obj1.displayDropdownDB());
        }
        public int addadmin(IEmployeeBO obj)
        {
            IEmployeeDAL obj2 = EmployeeDALFactory.createDAL();
            return (obj2.addadminDB(obj));
        }
        public List<IEmployeeBO> display()
        {
            IEmployeeDAL obj3 = EmployeeDALFactory.createDAL();
            return (obj3.displayDB());
        }
        public int displayapproved(IEmployeeBO obj)
        {
            IEmployeeDAL obj4 = EmployeeDALFactory.createDAL();
            return (obj4.displayapprovedDB(obj));
        }
        public List<IEmployeeBO> displayall()
        {
            IEmployeeDAL obj6 = EmployeeDALFactory.createDAL();
            return (obj6.displayallDB());
        }
       
        public List<IEmployeeBO> everythingdisplay()
        {
            IEmployeeDAL obj6 = EmployeeDALFactory.createDAL();
            return (obj6.displayeverythingDB());
        }
        public List<IEmployeeBO> displayunithead()
        {
            IEmployeeDAL obj7 = EmployeeDALFactory.createDAL();
            return (obj7.displayunitheadDB());
        }

        //CRUD3
        public int addEmployee(IEmployeeBO obj)
        {
            IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
            int result = objDAL.addEmployeeDB(obj);
            return result;
        }
        public List<int> getUH()
        {
            IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
            List<int> list = objDAL.getUHDB();
            return list;
        }
        public List<IEmployeeBO> ViewEmployee()
        {
            IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
            List<IEmployeeBO> objList = objDAL.viewEmployeeDB();
            return objList;
        }
        public int editEmployees(IEmployeeBO objBo)
        {
            IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
            int obj1 = objDAL.editEmployeeDB(objBo);
            return obj1;
        }
        public List<int> getUnitHeadID()
        {
            IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
            List<int> list = objDAL.getUnitHeadIDDB();
            return list;
        }
        public List<string> getEmployeeName()
        {
            IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
            List<string> list = objDAL.getEmployeeNameDB();
            return list;
        }
        public List<int> getProjectID()
        {
            IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
            List<int> list = objDAL.getProjectIDDB();
            return list;
        }
       public  List<int> getEmployeeID()
        {
            IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
            List<int> list = objDAL.getEmployeeIDDB();
            return list;
        }
       public string getEmpName(int id)
       {
           IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
           string obj1 = objDAL.getEmpNameDB(id);
           return obj1;
       }
        public  int getUnitHeadId(int id)
       {
           IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
           int obj1 = objDAL.getUnitIDDB(id);
           return obj1;
       }
      public   int  getctc(int id)
      {
          IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
          int obj1 = objDAL.getCTCDB(id);
          return obj1;
      }

   public string getDesignation(int id)
      {
          IEmployeeDAL objDAL = EmployeeDALFactory.createEmployeeDAL();
          string obj1 = objDAL.getDesignationDB(id);
          return obj1;
      }
    }
}
