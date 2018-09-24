using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BO;

namespace FactoryBO
{
    public class BGCCheckFactoryBO
    {
        public static IBGCCheckBO CreateBGCCheck()
        {
            IBGCCheckBO objCheckBO = new BGCCheckBO();
            return objCheckBO;
        }
    }
}
