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
        private ISweepstakesManager manager;

        public MarketingFirm()
        {
            // Make a manager here??
        }

        private void MakeSweepstakesManager(string type)
        {
            manager =  SweepstakesManagerFactory.CreateSweepstakesManager(type);
        }
    }
}
