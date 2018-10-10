using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class Contestant // : Interface goes here
    {
        private Dictionary<string, string> info;
        private int registrationNumber;
        
        public Contestant()
        {
            info = new Dictionary<string, string>();
            SetInfo(InputInfo());

            // How to set registration number? should be unique compared to all contestants (in the sweepstakes? in all the sweepstakes in their manager? in all sweepstakes globally?)
        }
        private void SetInfo(Stack<string> info)
        {
            this.info.Add("emailAddress", info.Pop());
            this.info.Add("lastName", info.Pop());
            this.info.Add("firstName", info.Pop());

        }

        private Stack<string> InputInfo()
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

        public string GetInfo(string key)
        {
            if(info.TryGetValue(key, out string output))
            {
                return output;
            }
            else
            {
                string message = "There is no value associated with: {0}" + key;
                throw new FormatException(message);
            }
        }

        // Observer methods???
    }
}
