using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BLL;

namespace FactoryBLL
{
    public class BGCUpdatesFactoryBLL
    {
        public static IBGCUpdatesBLL CreateUpdatesBLL()
        {
            IBGCUpdatesBLL objUpdatesBLL = new BGCUpdatesBLL();
            return objUpdatesBLL;
        }
    }
}
