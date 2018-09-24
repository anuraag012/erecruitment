using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
   public interface IBGCCheckBO
    {
         DateTime FromDate { get; set; }
         DateTime ToDate { get; set; }
         int AdminID { get; set; }
         int VacancyID { get; set; }
         int BGCTestID { get; set; }
         int EmpID { get; set; }
         string EmpRole { get; set; }
         string EmpPass { get; set; }
         int RoleID { get; set; }
         string NewEmpPass { get; set; }
    }
}
