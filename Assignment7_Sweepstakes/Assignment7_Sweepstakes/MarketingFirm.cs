using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    //  As a developer, I want to create a user interface for any information the application would need to get from the user. One example would be the functionality to assign a Contestant object a first name, last name, email address, and registration number.
    class MarketingFirm
    {
        private Dictionary<string, ISweepstakesManager> accounts;

        public MarketingFirm()
        {
            accounts = new Dictionary<string, ISweepstakesManager>();
        }

        private void MakeSweepstakesManager(string name)
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
            Console.WriteLine();
            return Console.ReadLine();
        }
    }
}
