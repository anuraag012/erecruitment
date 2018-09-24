using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using DAL;

namespace FactoryDAL
{
    public class BGCUpdatesFactoryDAL
    {
        public static IBGCUpdatesDAL CreateUpdatesDAL()
        {
            IBGCUpdatesDAL objUpdatesDAL = new BGCUpdatesDAL();
            return objUpdatesDAL;
        }
    }
}
