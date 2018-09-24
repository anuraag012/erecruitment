using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IEmployeeBO
    {
        int EmployeeID { get; set; }
        string EmployeeName { get; set; }
        DateTime DOB { get; set; }
        DateTime DOJ { get; set; }
        string Gender { get; set; }
        string Divison { get; set; }
        float CTC { get; set; }
        string Designation { get; set; }
        int UnitHeadID { get; set; }
        int ProjectId { get; set; }
        int AdministratorID { get; set; }
        string BgcStatus { get; set; }
        DateTime StatusChangeTime { get; set; }
        int RoleID { get; set; }
        string Location { get; set; }


       // string Location { get; set; }
    }
}
