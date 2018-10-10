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
        List<IObserver> observers;

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
            AddObserver(contestant);
        }

        public string PickWinner()
        {
            Random rand = new Random();
            int winner = rand.Next(0, contestants.Count);
            int counter = 0;
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                if(counter == winner)
                {
                    NotifyObservers(contestant.Value);
                    string winnerName = contestant.Value.GetInfo("firstName") + " " + contestant.Value.GetInfo("lastName");
                    return winnerName;
                }
                counter++;
            }
            throw new Exception("Winner not found.");
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("{0} {1}", contestant.GetInfo("firstName"), contestant.GetInfo("lastName") );
            Console.WriteLine("e-mail: {0}", contestant.GetInfo("emailAddress") );
            Console.WriteLine("Registration Number: {0}", contestant.RegistrationNumber );
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (!observers.Remove(observer))
            {
                throw new Exception("Observer was not found.");
            }
        }

        public void NotifyObservers(Contestant winner)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(winner);
                if(observer == winner)
                {
                    // As a developer, I want to send an actual email to a sweepstakes winner using the built in SmtpClient class in C#. Bonus points
                }
            }
        }
    }
}
