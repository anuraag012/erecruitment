using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
     public interface ICandidateBO
    {
         int VacancyID { get; set; }
         int BGCTestID { get; set; }
         string BGCTestStatus { get; set; }
         string Remarks { get; set; }
         int CandidateProfileID { get; set; }
         string TestStatus { get; set; }
         DateTime DOB { get; set; }
         string Gender { get; set; }
         string Location { get; set; }
         string CandidateName { get; set; }
    }
}
