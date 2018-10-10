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
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Sweepstakes demo");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Create 5 contestants");
            Console.WriteLine("Enter whatever info you like, but be sure the e-mail addresses are valid to get the full effect.");
            Console.WriteLine();
            List<Contestant> contestants = new List<Contestant>();
            for(int i = 0; i < 5; i++)
            {
                contestants.Add(new Contestant());
            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Create a new MarketingFirm and an account to manage some sweepstakes in that marketing firm.");
            Console.WriteLine("There could potentially be dozens of these accounts. This demonstration will only use one.");
            Console.WriteLine("Make sure the name is exactly 'manager' and the type is exactly 'Stack'");
            Console.WriteLine();
            MarketingFirm testFirm = new MarketingFirm();
            testFirm.MakeNewAccount();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Now we can make some Sweepstakes and give them to the manager in the account we just made");
            testFirm.GetAccount("manager").InsertSweepstakes(new Sweepstakes("For the kids!"));
            testFirm.GetAccount("manager").InsertSweepstakes(new Sweepstakes("Win a car!"));
            testFirm.GetAccount("manager").InsertSweepstakes(new Sweepstakes("Win a goat!"));
            Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("3 Sweepstakes have been made. 'For the kids!', 'Win a car!', and 'Wina a goat!'");
            Console.WriteLine("The Sweepstakes have been stored in a stack.");
            Console.WriteLine("Now we should sign up our Contestants:");
            Console.ReadLine();
            Console.WriteLine("First we need to remove the Sweepstakes from the stack.");
            Console.ReadLine();

            Sweepstakes s1 = testFirm.GetAccount("manager").GetSweepstakes();
            Sweepstakes s2 = testFirm.GetAccount("manager").GetSweepstakes();
            Sweepstakes s3 = testFirm.GetAccount("manager").GetSweepstakes();

            Console.WriteLine("Now we will add some of the Contestants we made earlier to various Sweepstakes.");
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

            Console.WriteLine("And finally, we give the Sweepstakes back to the manager (push onto the stack)");
            Console.ReadLine();

            testFirm.GetAccount("manager").InsertSweepstakes(s1);
            testFirm.GetAccount("manager").InsertSweepstakes(s2);
            testFirm.GetAccount("manager").InsertSweepstakes(s3);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();



            //EmailMan.SendWinnerMessageTo("esoemad5@gmail.com");
            //Console.WriteLine("Message Sent!");
        }
    }
}
