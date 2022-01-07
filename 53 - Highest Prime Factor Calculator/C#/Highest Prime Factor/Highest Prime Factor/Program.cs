using System;

namespace Highest_Prime_Factor
{
    internal class Program
    {
        static int value = 0;

        /// <summary>
        /// Returns the highest prime factor of a given input
        /// </summary>
        /// <param name="value">Integer value which the highest prime factor is to be found</param>
        /// <returns></returns>
        static int getHighestPrimeFactor(int value)
        {
            int return_value = 0;

            bool isPrime = true;
            int currentFactor = 0;

            // Find each factor and check if its prime
            for (int i = 1; i <= value; i++)
            {
                if (value % i == 0)
                {
                    currentFactor = i;

                    for (int j = 2; j < currentFactor / 2; j++)
                        if (value % j == 0) isPrime = false;

                    if (isPrime) return_value = currentFactor;
                }

                isPrime = true;
            }

            return return_value;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            try
            {
                value = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Highest prime factor is: {0}", getHighestPrimeFactor(value));
        }
    }
}
