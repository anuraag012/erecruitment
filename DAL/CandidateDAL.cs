using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class CandidateDAL : ICandidateDAL
    {
        public List<ICandidateBO> viewCandidateGrid()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_Candidategridview1";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();


                List<ICandidateBO> objCandidateBOList = new List<ICandidateBO>();
                while (reader.Read())
                {

                    {
                        ICandidateBO objCandidateBO = new CandidateBO(Convert.ToInt32(reader["Candidate_profile_ID"]), Convert.ToInt32(reader["Vacancy_ID"]), reader["Candidate_Name"].ToString(), Convert.ToDateTime(reader["DOB"]), reader["Location"].ToString(), reader["Gender"].ToString());
                        objCandidateBOList.Add(objCandidateBO);
                    }
                }
                conn.Close();
                return (objCandidateBOList);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DateTime getDOB(int id)
        {
            try
            {
                DateTime name;
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_getDOB";
                command.Connection = conn;
                command.Parameters.AddWithValue("@Candidate_profile_ID", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    name = Convert.ToDateTime(reader["DOB"]);
                    return name;
                }
                return DateTime.Today;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DateTime getDOJ(int id)
        {
            try
            {
                DateTime doj;
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_getDOJ";
                command.Connection = conn;
                command.Parameters.AddWithValue("@Candidate_profile_ID", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    doj = Convert.ToDateTime(reader["Require_by_date"]);
                    return doj;
                }
                return DateTime.Today;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string getGender(int id)
        {
            try
            {
                string name;
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_getGender";
                command.Connection = conn;
                command.Parameters.AddWithValue("@Candidate_profile_ID", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    name = Convert.ToString(reader["Gender"]);
                    return name;
                }
                string msg = "Gender";
                return msg;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int getProjectID(int id)
        {
            try
            {
                int id1;
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_getProjectID1";
                command.Connection = conn;
                command.Parameters.AddWithValue("@Candidate_profile_ID", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id1 = Convert.ToInt32(reader["ProjectID"]);
                    return id1;
                }

                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void delCandidate(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_delCandidate";
                command.Connection = conn;
                command.Parameters.AddWithValue("@Candidate_profile_ID", id);
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();

            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
