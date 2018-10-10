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

        public ISweepstakesManager GetAccount(string name)
        {
            if(accounts.TryGetValue(name, out ISweepstakesManager manager))
            {
                return manager;
            }
            throw new Exception("Account not found");
        } 

        public void MakeNewAccount()
        {
            string name = InputAccountName();
            ISweepstakesManager manager = MakeSweepstakesManager();

            accounts.Add(name, manager);
        }

        private ISweepstakesManager MakeSweepstakesManager()
        {
            try
            {
                string type = InputManagerType();
                ISweepstakesManager newManager = SweepstakesManagerFactory.CreateSweepstakesManager(type);
                return newManager;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return MakeSweepstakesManager();
            }

        }

        private string InputManagerType()
        {
            Console.WriteLine("Please enter what kind of SweepstakesManager you would like.");
            return Console.ReadLine();
        }

        private string InputAccountName()
        {
            Console.WriteLine("Please enter the name for the new account.");
            return Console.ReadLine();
        }
    }
}
