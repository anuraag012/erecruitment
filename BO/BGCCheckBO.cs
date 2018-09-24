using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
    public class BGCCheckBO:IBGCCheckBO
    {
        private DateTime fromDate;
                                        
        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        private DateTime toDate;

        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        private int adminID;

        public int AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }

        private int vacancyID;

        public int VacancyID
        {
            get { return vacancyID; }
            set { vacancyID = value; }
        }
        private int bgcTestID;

        public int BGCTestID
        {
            get { return bgcTestID; }
            set { bgcTestID = value; }
        }
        //private DateTime requiredByDate;

        //public DateTime RequiredByDate
        //{
        //    get { return requiredByDate; }
        //    set { requiredByDate = value; }
        //}
        
        
        public BGCCheckBO()
        { 
        }

        //public BGCCheckBO(int adminID)
        //{
        //    this.adminID = adminID;
        //}


        private int empID;

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
        private string empRole;

        public string EmpRole
        {
            get { return empRole; }
            set { empRole = value; }
        }
        private string empPass;

        public string EmpPass
        {
            get { return empPass; }
            set { empPass = value; }
        }
        public BGCCheckBO(int empID, string empRole, string empPass)
        {
            this.empID = empID;
            this.empRole = empRole;
            this.empPass = empPass;
        }


        private int roleID;

        public int RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }
        public BGCCheckBO(int empID, int roleID, string empPass)
        {
            this.empID = empID;
            this.roleID = roleID;
            this.empPass = empPass;
        }
        private string newEmpPass;

        public string NewEmpPass
        {
            get { return newEmpPass; }
            set { newEmpPass = value; }
        }

        public BGCCheckBO( int empID, string newEmpPass)
        {
            this.empID = empID;
           // this.empPass = empPass;
            this.newEmpPass = newEmpPass;
        }
        
    }
}
