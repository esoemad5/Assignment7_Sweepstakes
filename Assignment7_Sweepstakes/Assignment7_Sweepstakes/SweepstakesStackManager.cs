using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakesStack;

        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }
    }
}
