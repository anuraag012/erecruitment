using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BLL;
namespace FactoryBLL
{
  public class CandidateFactoryBLL
    {
        public static ICandidateBLL createCandidateBLobj()
        {
            ICandidateBLL objCandidateBL = new BLL.CandidateBLL();
            return objCandidateBL;

        }
    }
}
