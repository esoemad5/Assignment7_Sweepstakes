using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    static class RegistrationNumberFactory
    {
        private static int nextNumber = 0;
        public static int DistributeNumber()
        {
            nextNumber++;
            return nextNumber;
        }
    }
}
