using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class MarketingFirm
    {
        private Dictionary<string, ISweepstakesManager> accounts;

        public MarketingFirm()
        {
            accounts = new Dictionary<string, ISweepstakesManager>();
        }

        public void MakeSweepstakesManager(string name)
        {
            try
            {
                string type = InputManagerType();
                ISweepstakesManager newManager = SweepstakesManagerFactory.CreateSweepstakesManager(type);
                accounts.Add(name, newManager);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                MakeSweepstakesManager(name);
            }
        }

        private string InputManagerType()
        {
            Console.WriteLine("Please enter what kind of SweepstakesManager you would like.");
            return Console.ReadLine();
        }
    }
}
