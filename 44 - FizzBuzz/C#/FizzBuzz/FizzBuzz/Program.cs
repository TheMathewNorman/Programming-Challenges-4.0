using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Stop at which value?: ");
            uint stopAt;
            while (!uint.TryParse(Console.ReadLine(), out stopAt))
            {
                Console.WriteLine("Please enter a positive numerical value.");
                Console.Write("Stop at which value?: ");
            }

            for (uint i = 1; i <= stopAt; i++)
            {
                bool fizz = i % 3 == 0, buzz = i % 5 == 0;
                string output = "";

                if (fizz)
                    output += "Fizz";
                if (buzz)
                    output += "Buzz";
                if (output == "")
                    output = i.ToString();
                Console.WriteLine("{0}: {1}", i, output);
            }

            Console.Read();
        }
    }
}
