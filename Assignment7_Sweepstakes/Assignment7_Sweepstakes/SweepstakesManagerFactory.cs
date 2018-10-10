using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    static class SweepstakesManagerFactory
    {
        public static ISweepstakesManager CreateSweepstakesManager(string type)
        {
            switch (type)
            {
                case "Queue":
                    return new SweepstakesQueueManager();
                default:
                    return new SweepstakesStackManager();
            }
        }
    }
}
