﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class Sweepstakes : ISubject
    {
        Dictionary<int, Contestant> contestants;

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }

        void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        string PickWinner()
        {
            // As a developer, I want to use the observer design pattern to notify all users of the winning contestant, with the winner of the sweepstakes getting a different message specifically congratulating them on being the winner. Bonus
            // As a developer, I want to send an actual email to a sweepstakes winner using the built in SmtpClient class in C#. Bonus points
            return "";
        }

        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("{0} {1}", contestant.GetInfo("firstName"), contestant.GetInfo("lastName") );
            Console.WriteLine("e-mail: {0}", contestant.GetInfo("emailAddress") );
            Console.WriteLine("Registration Number: {0}", contestant.RegistrationNumber );
        }

        public void AddObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }
    }
}
