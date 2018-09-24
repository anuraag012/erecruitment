using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface ICandidateDAL
    {
        List<ICandidateBO> viewCandidateGrid();

        DateTime getDOB(int id);

        DateTime getDOJ(int id);

        string getGender(int id);

        int getProjectID(int id);

        void delCandidate(int id);
    }
}
