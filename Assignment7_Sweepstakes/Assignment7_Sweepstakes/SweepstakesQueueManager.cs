using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakesQueue;

        public SweepstakesQueueManager()
        {
            sweepstakesQueue = new Queue<Sweepstakes>();
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
    }
}
