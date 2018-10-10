using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDemo();
        }
        private static void RunDemo()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Sweepstakes demo");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Create 5 contestants");
            Console.WriteLine("Enter whatever info you like, but be sure the e-mail addresses are valid to get the full effect.");
            Console.WriteLine("Right clicking in the console is the same thing as Ctrl + V");
            Console.WriteLine();
            List<Contestant> contestants = new List<Contestant>();
            for (int i = 0; i < 5; i++)
            {
                contestants.Add(new Contestant());
            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("We have created a new MarketingFirm and are in the process of making account to manage some sweepstakes in that marketing firm.");
            Console.WriteLine("There could potentially be dozens of these accounts in this MarketingFirm, but this demonstration will only use one.");
            Console.WriteLine("Make sure the name is exactly 'Manager' and the type is exactly 'Stack'");
            Console.WriteLine();
            MarketingFirm testFirm = new MarketingFirm();
            testFirm.MakeNewAccount();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Now we can make some Sweepstakes and give them to the manager in the account we just made.");
            testFirm.GetAccount("Manager").InsertSweepstakes(new Sweepstakes("For the kids!"));
            testFirm.GetAccount("Manager").InsertSweepstakes(new Sweepstakes("Win a car!"));
            testFirm.GetAccount("Manager").InsertSweepstakes(new Sweepstakes("Win a goat!"));
            Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("3 Sweepstakes have been made. 'For the kids!', 'Win a car!', and 'Win a goat!'");
            Console.WriteLine("The Sweepstakes have been stored in a stack.");
            Console.WriteLine("Now we should sign up our Contestants:");
            Console.ReadLine();
            Console.WriteLine("First, we need to remove the Sweepstakes from the stack.");
            Console.ReadLine();

            Sweepstakes s1 = testFirm.GetAccount("Manager").GetSweepstakes();
            Sweepstakes s2 = testFirm.GetAccount("Manager").GetSweepstakes();
            Sweepstakes s3 = testFirm.GetAccount("Manager").GetSweepstakes();

            Console.WriteLine("Now, we will add some of the Contestants we made earlier to various Sweepstakes.");
            Console.ReadLine();

            s1.RegisterContestant(contestants[0]);
            s1.RegisterContestant(contestants[1]);
            s1.RegisterContestant(contestants[2]);

            s2.RegisterContestant(contestants[3]);
            s2.RegisterContestant(contestants[4]);
            s2.RegisterContestant(contestants[0]);

            s3.RegisterContestant(contestants[1]);
            s3.RegisterContestant(contestants[2]);
            s3.RegisterContestant(contestants[3]);

            Console.WriteLine("And finally, we give the Sweepstakes back to the manager (push it onto the stack).");
            Console.ReadLine();

            testFirm.GetAccount("Manager").InsertSweepstakes(s1);
            testFirm.GetAccount("Manager").InsertSweepstakes(s2);
            testFirm.GetAccount("Manager").InsertSweepstakes(s3);
            Console.WriteLine();
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
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Check the e-mails associated with each winner!");
            Console.WriteLine("Thank you for watching this demo!");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
