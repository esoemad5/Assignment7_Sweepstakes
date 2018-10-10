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
            Console.WriteLine();
            List<Contestant> contestants = new List<Contestant>();
            for(int i = 0; i < 5; i++)
            {
                contestants.Add(new Contestant()); // Enter whatever info you like, but be sure the e-mail addresses are valid to get the full effect.
            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Create a new MarketingFirm and an account to manage some sweepstakes in that marketing firm.");
            Console.WriteLine("There could potentially be dozens of these accounts. This demonstration will only use one.");
            Console.WriteLine();
            MarketingFirm testFirm = new MarketingFirm(); // Enter whatever name you like, but the type must be 'Stack' or 'Queue'. Case sensitive.
            testFirm.MakeNewAccount();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Now we can make some Sweepstakes and give them to the manager in the account we just made");
            Sweepstakes s1 = new Sweepstakes("For the kids!");
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
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();



            //EmailMan.SendWinnerMessageTo("esoemad5@gmail.com");
            //Console.WriteLine("Message Sent!");
        }
    }
}
