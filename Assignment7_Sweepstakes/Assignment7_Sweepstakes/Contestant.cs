using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Sweepstakes
{
    class Contestant : IObserver
    {
        private Dictionary<string, string> info;
        private int registrationNumber;
        public int RegistrationNumber { get => registrationNumber; }
        
        public Contestant()
        {
            info = new Dictionary<string, string>();
            SetInfo(InputInfo());

            // how to deal with registrationNumber? where are contestants created?
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

        public void Update(Contestant winner)
        {
            if(winner == this)
            {
                Console.WriteLine("You won!!!");
            }
            else
            {
                Console.WriteLine("{0} has won. Try again next time!", winner.GetInfo("firstName"));
            }
        }
    }
}
