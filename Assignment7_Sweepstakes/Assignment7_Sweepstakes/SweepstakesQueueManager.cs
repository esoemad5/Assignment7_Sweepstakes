using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakes;

        public SweepstakesQueueManager()
        {
            sweepstakes = new Queue<Sweepstakes>();
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
