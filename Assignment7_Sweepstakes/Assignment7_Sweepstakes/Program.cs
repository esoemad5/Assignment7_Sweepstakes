using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class Program
    {
        private static List<Contestant> contestants;
        private static MarketingFirm testFirm;
        static void Main(string[] args)
        {
            RunDemo();
        }
        private static void CreateContestants()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Create 5 contestants");
            Console.WriteLine("Enter whatever info you like, but be sure the e-mail addresses are valid to get the full effect.");
            Console.WriteLine("A lot of e-mal providers will block messages from applications like this.");
            Console.WriteLine("ab6343416@gmail.com works with this application. The password is: HorseBatteryStaple");
            Console.WriteLine();
            Console.WriteLine("Highlighting text in the console works like + C");
            Console.WriteLine("Right clicking in the console is the same thing as Ctrl + V");
            Console.WriteLine();
            contestants = new List<Contestant>();
            for (int i = 0; i < 5; i++)
            {
                contestants.Add(new Contestant());
            }
        }
        private static void CreateMarketingFirm()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("We have created a new MarketingFirm and are in the process of making account to manage some sweepstakes in that marketing firm.");
            Console.WriteLine("There could potentially be dozens of these accounts in this MarketingFirm, but this demonstration will only use one.");
            Console.WriteLine("Make sure the name is exactly 'Manager' and the type is exactly 'Stack'");
            Console.WriteLine();
            testFirm = new MarketingFirm();
            testFirm.MakeNewAccount();
        }
        private static void Make3Sweepstakes()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Now we can make some Sweepstakes and give them to the manager in the account we just made.");
            Console.WriteLine("We will make 3 Sweepstakes, and you can name them whatever you like.");
            testFirm.GetAccount("Manager").InsertSweepstakes(new Sweepstakes(Sweepstakes.AskForSweepstakesName()));
            testFirm.GetAccount("Manager").InsertSweepstakes(new Sweepstakes(Sweepstakes.AskForSweepstakesName()));
            testFirm.GetAccount("Manager").InsertSweepstakes(new Sweepstakes(Sweepstakes.AskForSweepstakesName()));
        }
        private static void RegisterContestants()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("3 Sweepstakes have been made.");
            Console.WriteLine("The Sweepstakes have been stored in a stack.");
            Console.WriteLine("Now we should sign up our Contestants:");
            Console.ReadLine();
            Console.WriteLine("First, we need to remove the Sweepstakes from the stack. And store them in seperate List.");
            Console.ReadLine();

            List<Sweepstakes> sweepstakes = new List<Sweepstakes>();
            while (true)
            {
                try
                {
                    sweepstakes.Add(testFirm.GetAccount("Manager").GetSweepstakes());
                }
                catch (InvalidOperationException)
                {
                    break;
                }
            }

            Console.WriteLine("Now, we will add some of the Contestants we made earlier to various Sweepstakes.");
            Console.ReadLine();
            int i = 0;
            foreach(Sweepstakes item in sweepstakes)
            {
                for(int j = 0; j < 3; j++)
                {
                    item.RegisterContestant(contestants[i]);
                    i++;
                    i %= contestants.Count();
                }
            }

            Console.WriteLine("And finally, we give the Sweepstakes back to the manager (push it onto the stack).");
            Console.ReadLine();
            foreach (Sweepstakes item in sweepstakes)
            {
                testFirm.GetAccount("Manager").InsertSweepstakes(item);
            }

            Console.WriteLine();
        }
        private static void ChooseWinners()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("It's time to pick the winners!");
            Console.WriteLine("Once a winner has been decided, we don't care about the Sweepstakes anymore.");
            Console.WriteLine("So, we can just pop the Sweepstakes off of the Manager's stack and not worry about replacing it.");
            while (true)
            {
                try
                {
                    Sweepstakes sweepstakes = testFirm.GetAccount("Manager").GetSweepstakes();
                    Console.WriteLine("Press return to see the results of the next Sweepstakes!");
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("{0} has selected a winner:", sweepstakes.Name);
                    sweepstakes.PickWinner();

                }
                catch (InvalidOperationException)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Check the e-mails associated with each winner!");

        }
        private static void EndDemo()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Thank you for watching this demo!");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadLine();
        }
        private static void RunDemo()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Sweepstakes demo");
            CreateContestants();
            CreateMarketingFirm();
            Make3Sweepstakes();
            RegisterContestants();
            ChooseWinners();
            EndDemo();
        }
    }
}
