using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    static class SweepstakesManagerFactory : ICreateSweepstakesManager
    {
        public static ISweepstakesManager CreateSweepstakesManager(string type)
        {
            switch (type)
            {
                case "Queue":
                    return new SweepstakesQueueManager();
                case "Stack":
                    return new SweepstakesStackManager();
                default:
                    string message = "No SweepstakesManager of type '" + type + "'";
                    throw new FormatException(message);
            }
        }
    }
}
