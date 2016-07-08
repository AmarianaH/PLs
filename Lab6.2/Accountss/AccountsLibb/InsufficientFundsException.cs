using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibb
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException()
        {
            throw new InsufficientFundsException("InsufficientFundsException Class : You Can't withraw this value!! Sorry for that !!! ");
        }
        public InsufficientFundsException(String m) : base(m)
        {

        }
    }
}
