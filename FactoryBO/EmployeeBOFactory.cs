using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using Types;
namespace FactoryBO
{
   public class EmployeeBOFactory
    {
        public static IEmployeeBO CreateEmployee()
        {
            IEmployeeBO objemp = new EmployeeBO();
            return objemp;
        }
        public static IEmployeeBO Createemp(int employeeid)
        {
            IEmployeeBO objemp = new EmployeeBO(employeeid);
            return objemp;
        }
        public static List<IEmployeeBO> createEmployeeBO()
        {
            List<IEmployeeBO> list = new List<IEmployeeBO>();
            return list;
        }
        public static IEmployeeBO CreateEmployee(int AdministratorID, string bgcStatus, DateTime StatusChangeTime)
        {
            IEmployeeBO objemp = new EmployeeBO(AdministratorID, bgcStatus, StatusChangeTime);
            return objemp;
        }

        public static IEmployeeBO createemp(int employeeid, string status, DateTime statusChangeTime, int role_id, int administratorid)
        {
            IEmployeeBO objemp = new EmployeeBO(administratorid, status, statusChangeTime, employeeid, role_id);
            //AdministratorID, bgcStatus,  StatusChangeTime,  employeeID,  RoleID);
            //employeeid,status,statusChangeTime,administratorid,role_id
            return objemp;
        }




        public static IEmployeeBO createEmployeeBO(int empID, DateTime dateOfBirth, DateTime dateOfJoining, string designation, string location, string gender, int ctc, int unitHeadID, int projectID)
        {
            IEmployeeBO obj = new EmployeeBO(empID, dateOfBirth, dateOfJoining, designation, location, gender, ctc, unitHeadID, projectID);
            return obj;
        }

        public static IEmployeeBO createEmployeeBO(string EmpName, string designation, int ctc, int unitHead)
        {
            IEmployeeBO obj = new EmployeeBO(EmpName, designation, ctc, unitHead);
            return obj;
        }

        public static List<int> createintList()
        {
            List<int> list = new List<int>();
            return list;
        }

        public static List<string> createintList1()
        {
            List<string> list = new List<string>();
            return list;
        }

        public static IEmployeeBO createEmployeeBO(string EmpName, DateTime DateofBirth, DateTime DateofJoining, float CTC, string Designation, int UnitheadID, int ProjectID, string Location, string Gender, string Password)
        {
            IEmployeeBO obj = new EmployeeBO(EmpName, DateofBirth, DateofJoining, CTC, Designation, UnitheadID, ProjectID, Location, Gender, Password);
            return obj;
        }

        public static IEmployeeBO createEmpBO()
        {
            IEmployeeBO obj = new EmployeeBO();
            return obj;
        }
        public static IEmployeeBO createemp1(int employeeid)
        {
            IEmployeeBO obj = new EmployeeBO(employeeid);
            return obj;
        }

        public static IEmployeeBO CreateEmp2(int adminid, string bgcstatus, DateTime statuschangetime, string Employeename)
        {
            IEmployeeBO obj = new EmployeeBO(adminid, bgcstatus, statuschangetime, Employeename);
            return obj;
        }

        public static IEmployeeBO createEmployeeBO(int id)
        {
            IEmployeeBO obj = new EmployeeBO(id);
            return obj;
        }
    }
}
