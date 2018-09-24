using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using DAL;

namespace FactoryDAL
{
    public class EmployeeDALFactory
    {
        public static IEmployeeDAL createDAL()
        {
            IEmployeeDAL objemp = new EmployeeDAL();
            return objemp;
        }
        public static IEmployeeDAL createEmployeeDAL()
        {
            IEmployeeDAL obj = new EmployeeDAL();
            return obj;
        }
      
    }
}
