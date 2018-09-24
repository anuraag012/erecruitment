using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
    public class CandidateBO:ICandidateBO
    {
        private string candidateName;

        public string CandidateName
        {
            get { return candidateName; }
            set { candidateName = value; }
        }
        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        
        
        private DateTime dob;

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
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
        private string bgcTestStatus;

           public string BGCTestStatus
        {
            get { return bgcTestStatus; }
            set { bgcTestStatus = value; }
        }

           private string remarks;
                    
           public string Remarks
           {
               get { return remarks; }
               set { remarks = value; }
           }
           private int candidateProfileID;

           public int CandidateProfileID
           {
               get { return candidateProfileID; }
               set { candidateProfileID = value; }
           }
           private string testStatus;
           private int p1;
           private string p2;
           private string p3;
           private string p4;
           private DateTime dateTime;
           private int id;

           public string TestStatus
           {
               get { return testStatus; }
               set { testStatus = value; }
           }
           
        public CandidateBO()
        { 
        }
        public CandidateBO(int candidateProfileID, string testStatus, string bgcTestStatus, string remarks)
        {
            this.candidateProfileID = candidateProfileID;
            this.testStatus = testStatus;
            this.bgcTestStatus = bgcTestStatus;
            this.remarks = remarks;
        }
        
        public CandidateBO(int candidateProfileID,int vacancyID,string candidateName,DateTime dob,string location,string gender)
        {
            this.candidateProfileID = candidateProfileID;
            this.vacancyID = vacancyID;
            this.candidateName = candidateName;
            this.dob = dob;
            this.location = location;
            this.gender = gender;
        }
        public CandidateBO(int candidateProfileID, int vacancyID, int bgcTestID, string testStatus, string bgcTestStatus, string remarks)
        {
            this.candidateProfileID = candidateProfileID;
            this.vacancyID = vacancyID;
            this.bgcTestID = bgcTestID;
            this.testStatus = testStatus;
            this.bgcTestStatus = bgcTestStatus;
            this.remarks = remarks;
        }
        public CandidateBO(int candidateProfileID, string bgcTestStatus, string remarks)
        {
            this.candidateProfileID = candidateProfileID;
            this.bgcTestStatus = bgcTestStatus;
            this.remarks = remarks;
        }

        public CandidateBO(int p1, string p2, string p3, string p4, DateTime dateTime)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.dateTime = dateTime;
        }

        public CandidateBO(string p2, string p3, string p4, DateTime dateTime)
        {
            // TODO: Complete member initialization
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.dateTime = dateTime;
        }

        public CandidateBO(int id)
        {
            // TODO: Complete member initialization
            this.id = id;
        }
        
        
    }
}
