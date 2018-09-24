using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
    public class EmployeeBO:IEmployeeBO
    {
        int employeeID;
        string employeeName;
        DateTime dob;
        DateTime doj;
        string gender;
        string divison;
        float ctc;
        string designation;
        int  unitHeadID;
        int projectId;
        int administratorID;
        string bgcStatus;
        DateTime statusChangeTime;
        int roleID;
        string location;
        private string EmpName;
        private string DateofBirth;
        private string DateofJoining;
        private float CTC1;
        private string Designation1;
        private int UnitheadID;
        private int ProjectID;
        private string Location1;
        private string Gender1;
        private string Password;
        private DateTime DateofBirth1;
        private DateTime DateofJoining1;
        

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string Location
        {
            get
            { return location; }
            set
            { location = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
       

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
 
        public DateTime DOJ
        {
            get { return doj; }
            set { doj = value; }
        }


        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Divison
        {
            get { return divison; }
            set { divison = value; }
        }

 
        public float CTC
        {
            get { return ctc; }
            set { ctc = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public int UnitHeadID
        {
            get { return unitHeadID; }
            set { unitHeadID = value; }
        }
        public int ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }

        public int AdministratorID
        {
            get
            {
                return administratorID;
            }
            set
            {
                administratorID = value;
            }
        }
        public string BgcStatus
        {
            get
            {
                return bgcStatus;
            }
            set
            {
                bgcStatus = value;
            }
        }
        public DateTime StatusChangeTime
        {
            get
            {
                return statusChangeTime;
            }
            set
            {
                statusChangeTime = value;
            }
        }
        
        public int RoleID
        {
            get
            {
                return roleID;
            }
            set
            {
                roleID = value;
            }
        }
        public EmployeeBO(int AdministratorID, string bgcStatus, DateTime StatusChangeTime, int employeeID, int RoleID)
        {
            this.AdministratorID = AdministratorID;
            this.bgcStatus = bgcStatus;
            this.StatusChangeTime = StatusChangeTime;
            this.employeeID = employeeID;
            this.RoleID = RoleID;
            
        }
        

        public EmployeeBO(int employeeID, string employeeName, DateTime dob, DateTime doj, string gender, string divison, float ctc, string designation, int unitHeadID, int projectId)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.dob = dob;
            this.doj = doj;
            this.gender = gender;
            this.divison = divison;
            this.ctc = ctc;
            this.designation = designation;
            this.unitHeadID = unitHeadID;
            this.projectId = projectId;
        }
        public EmployeeBO(int employeeID)
        {
            this.employeeID = employeeID;
        }
        public EmployeeBO()
        {
            //def
        }
        public EmployeeBO(int employeeID, DateTime dob, DateTime doj, string designation, string location, string gender, int ctc, int unitHeadID, int projectId)
        {
            // TODO: Complete member initialization
            this.employeeID = employeeID;
            this.dob = dob;
            this.doj = doj;
            this.designation = designation;
            this.location = location;
            this.gender = gender;
            this.ctc = ctc;
            this.unitHeadID = unitHeadID;
            this.projectId = projectId;
        }

        public EmployeeBO(string employeeName, string designation, int ctc, int unitHeadID)
        {
            // TODO: Complete member initialization
            this.employeeName = employeeName;
            this.designation = designation;
            this.ctc = ctc;
            this.unitHeadID = unitHeadID;
        }

        

        public EmployeeBO(string EmpName, DateTime DateofBirth1, DateTime DateofJoining1, float CTC1, string Designation1, int UnitheadID, int ProjectID, string Location1, string Gender1, string Password)
        {
            // TODO: Complete member initialization
            this.EmpName = EmpName;
            this.DateofBirth1 = DateofBirth1;
            this.DateofJoining1 = DateofJoining1;
            this.CTC1 = CTC1;
            this.Designation1 = Designation1;
            this.UnitheadID = UnitheadID;
            this.ProjectID = ProjectID;
            this.Location1 = Location1;
            this.Gender1 = Gender1;
            this.Password = Password;
        }
        public EmployeeBO(int administratorID, string bgcStatus, DateTime statusChangeTime, string employeeName)
        {
            this.administratorID = administratorID;
            this.bgcStatus = bgcStatus;
            this.statusChangeTime = statusChangeTime;
            this.employeeName = employeeName;
        }
        public EmployeeBO(int administratorID, string bgcStatus, DateTime statusChangeTime)
        {
            this.administratorID = administratorID;
            this.bgcStatus = bgcStatus;
            this.statusChangeTime = statusChangeTime;
            
        }
    }
}
