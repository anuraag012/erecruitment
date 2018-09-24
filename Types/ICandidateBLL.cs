using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface ICandidateBLL
    {
        List<ICandidateBO> viewCandidateGrid();

        DateTime getDob(int id);

        DateTime getDoj(int id);

        string getGender(int id);

        int getProjectID(int id);

        void deleteCandidate(int id);
    }
}
