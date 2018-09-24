using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using FactoryBO;
using BO;

namespace DAL
{
    public class EmployeeDAL:IEmployeeDAL
    {
        //CRUD1
        public List<int> displayDropdownDB()
        {
            try
            {
                List<int> empno = new List<int>();
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "extractEmp";
            comm.Connection = conn;
            SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
            {
                int employeeid = Convert.ToInt32(reader["EmployeeID"]);
                empno.Add(employeeid);
            }
            return empno;
            }
            catch (Exception)
            {
                throw;
            } 
            


        }

        public int addadminDB(IEmployeeBO obj)
        {
            

            try
            {
            //List<IEmployeeBO> list = new List<IEmployeeBO>();
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "addBGCadmin";
            command.Parameters.AddWithValue("@AdministratorID", 0);
            command.Parameters.AddWithValue("@EmployeeID", obj.EmployeeID);
            command.Parameters.AddWithValue("@role_ID", obj.RoleID);
            command.Parameters.AddWithValue("@bgcStatus", obj.BgcStatus);
            command.Parameters.AddWithValue("@StatusChangetime", obj.StatusChangeTime);
            command.Parameters["@AdministratorID"].Direction = ParameterDirection.Output;
            command.Connection = conn;
            int check = command.ExecuteNonQuery();
            if (check > 0)
            {
                return check;
            }
            return 0;
        }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public int displayapprovedDB(IEmployeeBO obj)
        {
            try
            {
            List<IEmployeeBO> newlist = new List<IEmployeeBO>();
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "updateBGCadmin";
            command.Connection = conn;
            command.Parameters.AddWithValue("@AdministratorID", obj.AdministratorID);
            command.Parameters.AddWithValue("@bgcStatus", obj.BgcStatus);
            command.Parameters.AddWithValue("@StatusChangeTime", obj.StatusChangeTime);
            int check = command.ExecuteNonQuery();
            if (check > 0)
            {
                return check;
            }
            return 0;
        }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<IEmployeeBO> displayunitheadDB()
        {
            try
            {
                List<IEmployeeBO> list = new List<IEmployeeBO>();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "displayunithead";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    int adminid = Convert.ToInt32(reader["AdministratorID"]);
                    string bgcstatus = Convert.ToString(reader["bgcStatus"]);
                    DateTime statuschangetime = Convert.ToDateTime(reader["StatusChangeTime"]);

                    IEmployeeBO obj = EmployeeBOFactory.CreateEmployee(adminid, bgcstatus, statuschangetime);

                    list.Add(obj);

                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<IEmployeeBO> displayDB()
        {
            try
            {
            List<IEmployeeBO> list = new List<IEmployeeBO>();
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "displayHR1";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                int adminid = Convert.ToInt32(reader["AdministratorID"]);
                string bgcstatus = Convert.ToString(reader["bgcStatus"]);
                DateTime statuschangetime = Convert.ToDateTime(reader["StatusChangeTime"]);
                string Employeename = Convert.ToString(reader["EmployeeName"]);
                IEmployeeBO obj = EmployeeBOFactory.CreateEmp2(adminid, bgcstatus, statuschangetime, Employeename);

                list.Add(obj);

            }
            return list;
        }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<IEmployeeBO> displayeverythingDB()
        {
            try
            {
                List<IEmployeeBO> newlist = new List<IEmployeeBO>();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "displayeverything";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {


                    int employeeid = Convert.ToInt32(reader["employee_ID"]);

                    IEmployeeBO obj = EmployeeBOFactory.createemp1(employeeid);

                    newlist.Add(obj);

                }
                return newlist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        

    

        public List<IEmployeeBO> displayallDB()
        {
            try
            {
                List<IEmployeeBO> list = new List<IEmployeeBO>();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "displayallBGC";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int adminid = Convert.ToInt32(reader["AdministratorID"]);
                    string bgcstatus = Convert.ToString(reader["bgcStatus"]);
                    DateTime statuschangetime = Convert.ToDateTime(reader["StatusChangeTime"]);
                    string employeename = Convert.ToString(reader["EmployeeName"]);
                    IEmployeeBO obj = EmployeeBOFactory.CreateEmp2(adminid, bgcstatus, statuschangetime, employeename);

                    list.Add(obj);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }


        }











        //CRUD 3


        public int addEmployeeDB(IEmployeeBO objBO)
        {
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_insertEmploy";
            command.Connection = connection;
            command.Parameters.AddWithValue("@EmployeeName", objBO.EmployeeName);
            command.Parameters.AddWithValue("@UnitHeadID",objBO.UnitHeadID);
            command.Parameters.AddWithValue("@ProjectID",objBO.ProjectId);
            command.Parameters.AddWithValue("@DOB", objBO.DOB);
            command.Parameters.AddWithValue("@DOJ", objBO.DOJ);
            command.Parameters.AddWithValue("@Gender", objBO.Gender);
            command.Parameters.AddWithValue("@CTC", objBO.CTC);
            command.Parameters.AddWithValue("@Designation", objBO.Designation);
            command.Parameters.AddWithValue("@Location", objBO.Location);
            command.Parameters.AddWithValue("@Role1", "Employee");
            command.Parameters.AddWithValue("@Experience", 0);
            command.Parameters.AddWithValue("@Password","ChangePwd");
            command.Parameters.AddWithValue("@EmployeeID", 0);
            command.Parameters.AddWithValue("@IsNew", 1);

            command.Parameters["@EmployeeID"].Direction = ParameterDirection.Output;


            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
                return (Convert.ToInt32(command.Parameters["@EmployeeID"].Value));
            else

                return result;
        }
        public List<int> getUHDB()
        {
            List<int> listUH = EmployeeBOFactory.createintList();
            int uhID;
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_getUH";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                uhID = Convert.ToInt32(reader["EmployeeID"]);
                listUH.Add(uhID);
            }
            return listUH;
        }


        public List<IEmployeeBO> viewEmployeeDB()
        {
            List<IEmployeeBO> list = new List<IEmployeeBO>();

            try
            {

                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_displayEmployee";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    int empID = Convert.ToInt32(reader["EmployeeID"]);
                    DateTime dateOfBirth = Convert.ToDateTime(reader["DOB"]);
                    DateTime dateOfJoining = Convert.ToDateTime(reader["DOJ"]);
                    string designation = Convert.ToString(reader["Designation"]);
                    string location = Convert.ToString(reader["Location"]);
                    string gender = Convert.ToString(reader["Gender"]);
                    Int32 ctc = Convert.ToInt32(reader["CTC"]);
                    int unitHeadID = Convert.ToInt32(reader["UnitHeadiD"]);
                    int projectID = Convert.ToInt32(reader["ProjectID"]);
                    IEmployeeBO objBO = EmployeeBOFactory.createEmployeeBO(empID, dateOfBirth, dateOfJoining, designation, location, gender, ctc, unitHeadID, projectID);

                    list.Add(objBO);

                }

            }
            catch (Exception)
            {
            }
            return list;
        }
        public int editEmployeeDB(IEmployeeBO objBo)
        {
            int rowAffected;
            try
            {

                SqlConnection conn = new SqlConnection();
                string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                conn.ConnectionString = str;
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_updateempdetails";
                command.Parameters.AddWithValue("@EmployeeName", objBo.EmployeeName);
                command.Parameters.AddWithValue("@UnitHeadID", objBo.UnitHeadID);
                command.Parameters.AddWithValue("@Designation", objBo.Designation);
                command.Parameters.AddWithValue("@CTC", objBo.CTC);

               rowAffected = command.ExecuteNonQuery();
               conn.Close();
                return rowAffected;

            }
            catch(Exception)
            {

            }
            return 0;

           

        }


        public List<int> getUnitHeadIDDB()
        {

            List<int> listUH = EmployeeBOFactory.createintList();
            int uhID;
            SqlConnection conn = new SqlConnection();
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            conn.ConnectionString = str;
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_getUnitHeadId1";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                uhID = Convert.ToInt32(reader["UnitHeadID"]);
                listUH.Add(uhID);
            }
            return listUH;


        }

        public List<string> getEmployeeNameDB()
        {

            List<string> listid = EmployeeBOFactory.createintList1();
            string name;
            SqlConnection conn = new SqlConnection();
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            conn.ConnectionString = str;
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_getEmployeeName";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = Convert.ToString(reader["EmployeeName"]); ;
                listid.Add(name);
            }
            return listid;

        }
     public  List<int> getProjectIDDB()
        {
            List<int> listUH = EmployeeBOFactory.createintList();
            int uhID;
            SqlConnection conn = new SqlConnection();
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            conn.ConnectionString = str;
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_getProjectID";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                uhID = Convert.ToInt32(reader["ProjectID"]);
                listUH.Add(uhID);
            }
            return listUH;

     }
        public List<int> getEmployeeIDDB()
         {
             List<int> listUH = EmployeeBOFactory.createintList();
             int uhID;
             SqlConnection conn = new SqlConnection();
             string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
             conn.ConnectionString = str;
             conn.Open();
             SqlCommand command = new SqlCommand();
             command.Connection = conn;
             command.CommandType = CommandType.StoredProcedure;
             command.CommandText = "sp_getEmployeeID";
             command.Connection = conn;
             SqlDataReader reader = command.ExecuteReader();
             while (reader.Read())
             {
                 uhID = Convert.ToInt32(reader["EmployeeID"]);
                 listUH.Add(uhID);
             }
             return listUH;

        }
       public  string getEmpNameDB(int id)
        {
          
            string name;
            SqlConnection conn = new SqlConnection();
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            conn.ConnectionString = str;
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_getEmpName";
            command.Connection = conn;
           command.Parameters.AddWithValue("@EmployeeID",id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = Convert.ToString(reader["EmployeeName"]);
                return name;
            }
            string msg = "Emp";
            return msg;
       }
       public int getUnitIDDB(int id)
       {
            int UNITID;
            SqlConnection conn = new SqlConnection();
            string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            conn.ConnectionString = str;
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_getUnitID";
            command.Connection = conn;
           command.Parameters.AddWithValue("@EmployeeID",id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                UNITID = Convert.ToInt32(reader["UnitHeadID"]);
                return UNITID;
            }
           
            return 0;
        }
      public int getCTCDB(int id)
       {
           int UNITID;
           SqlConnection conn = new SqlConnection();
           string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
           conn.ConnectionString = str;
           conn.Open();
           SqlCommand command = new SqlCommand();
           command.Connection = conn;
           command.CommandType = CommandType.StoredProcedure;
           command.CommandText = "sp_getCTC";
           command.Connection = conn;
           command.Parameters.AddWithValue("@EmployeeID", id);
           SqlDataReader reader = command.ExecuteReader();
           while (reader.Read())
           {
               UNITID = Convert.ToInt32(reader["CTC"]);
               return UNITID;
           }

           return 0;
       }

      public string getDesignationDB(int id)
      {
          string name;
          SqlConnection conn = new SqlConnection();
          string str = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
          conn.ConnectionString = str;
          conn.Open();
          SqlCommand command = new SqlCommand();
          command.Connection = conn;
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "sp_getDesignation";
          command.Connection = conn;
          command.Parameters.AddWithValue("@EmployeeID", id);
          SqlDataReader reader = command.ExecuteReader();
          while (reader.Read())
          {
              name = Convert.ToString(reader["Designation"]);
              return name;
          }
          string msg = "Emp";
          return msg;
        }
    }
}

