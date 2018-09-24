using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using FactoryBO;
using FactoryDAL;

namespace BLL
{
    public class CandidateBLL:ICandidateBLL
    {

       public List<ICandidateBO> viewCandidateGrid()
        {
            ICandidateDAL objDAL = CandidateFactoryDAL.createCandidateDAL();
            List<ICandidateBO> objList = objDAL.viewCandidateGrid();
            return objList;
        }
       
       public DateTime getDob(int id)
        {
            ICandidateDAL objCandDal = CandidateFactoryDAL.createObjCandidateDal();
           DateTime dob= objCandDal.getDOB(id);
           return dob;
       }

       public DateTime getDoj(int id)
       {
           ICandidateDAL objCandDal = CandidateFactoryDAL.createObjCandidateDal();
           DateTime doj = objCandDal.getDOJ(id);
           return doj;
       }

       public string getGender(int id)
       {
           ICandidateDAL objCandDal = CandidateFactoryDAL.createObjCandidateDal();
          string gen = objCandDal.getGender(id);
          return gen;
       }
      public  int getProjectID(int id)
       {
           ICandidateDAL objCandDal = CandidateFactoryDAL.createObjCandidateDal();
            int pid = objCandDal.getProjectID(id);
            return pid;
       }
      public void deleteCandidate(int id)
      {
          ICandidateDAL objCandDal = CandidateFactoryDAL.createObjCandidateDal();
          objCandDal.delCandidate(id);
        
      }
    }
}
