using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using DAL;

namespace FactoryDAL
{
    public class CandidateFactoryDAL
    {
        public static ICandidateDAL createCandidateDAL()
        {
            ICandidateDAL obj = new CandidateDAL();
            return obj;
        }

        public static ICandidateDAL createObjCandidateDal()
        {
            ICandidateDAL obj = new CandidateDAL();
            return obj;
        }
    }
}
