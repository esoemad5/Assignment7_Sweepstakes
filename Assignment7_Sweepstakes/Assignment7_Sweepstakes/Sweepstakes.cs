using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;

        public Sweepstakes(string name)
        {

        }

        void RegisterContestant(Contestant contestant)
        {

        }

        string PickWinner()
        {
            // As a developer, I want to use the observer design pattern to notify all users of the winning contestant, with the winner of the sweepstakes getting a different message specifically congratulating them on being the winner. Bonus
            // As a developer, I want to send an actual email to a sweepstakes winner using the built in SmtpClient class in C#. Bonus points
            return "";
        }

        void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
