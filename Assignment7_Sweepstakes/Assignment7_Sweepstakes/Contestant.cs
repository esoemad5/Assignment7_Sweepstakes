using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class Contestant // : Interface goes here
    {
        string firstName;
        string lastName;
        string emailAddress;
        int registrationNumber;
        
        public Contestant()
        {
            SetVariables(GetInfo());
            // How to set registration number? should be unique compared to all contestants (in the sweepstakes? in all the sweepstakes in their manager? in all sweepstakes globally?)
        }
        private void SetVariables(Stack<string> info)
        {
            string emailAddress = info.Pop();
            string lastName = info.Pop();
            string firstName = info.Pop();

        }
        private Stack<string> GetInfo()
        {
            Stack<string> info = new Stack<string>();

            Console.WriteLine("Please enter your first name:");
            info.Push(Console.ReadLine());
            Console.WriteLine("Please enter your last name:");
            info.Push(Console.ReadLine());
            Console.WriteLine("Please enter your e-mail address:");
            info.Push(Console.ReadLine());

            return info;
        }

        // Observer methods???
    }
}
