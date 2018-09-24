using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BLL;
namespace FactoryBLL
{
    public class EmployeeFactoryBLL
    {
        public static IEmployeeBLL createnew()
        {
            IEmployeeBLL objempbll = new EmployeeBLL();
            return objempbll;
        }
        public static IEmployeeBLL createEmployeeBLL()
        {
            IEmployeeBLL obj = new EmployeeBLL();
            return obj;
        }




        public static IEmployeeBLL createEmployeeBLobj()
        {
            IEmployeeBLL obj = new EmployeeBLL();
            return obj;
        }
    }
}
