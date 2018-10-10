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
            string test = "asd123";
            int i;
            bool b = Int32.TryParse(test, out i);
            Console.WriteLine("{0} {1} {2}", test+1, i+1 , b);
            List<int> test2 = new List<int>();
            test2.Add(4);
            Console.WriteLine(test2[0]);
            if (!test2.Remove(5))
            {
                Console.WriteLine("Couldnt find 5");
            }

            if (test2.Remove(4))
            {
                Console.WriteLine("Removed 4");
            }
            Console.WriteLine(test2[0]);
        }
    }
}
