﻿using System;
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
            return sweepstakesQueue.Pop();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
    }
}
