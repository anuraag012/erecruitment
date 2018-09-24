using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BO;

namespace FactoryBO
{
    public class CandidateFactoryBO
    {
        public static ICandidateBO CreateCandidate()
        {
            ICandidateBO objCandidateBO = new CandidateBO();
            return objCandidateBO;
        }


        public static ICandidateBO createCandBO()
        {
            ICandidateBO objCandidateBO = new CandidateBO();
            return objCandidateBO;
        }

        public static ICandidateBO createEmployeeBO(int id)
        {
            ICandidateBO objCandidateBO = new CandidateBO(id);
            return objCandidateBO;
        }
    }
}
