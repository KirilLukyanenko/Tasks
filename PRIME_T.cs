using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly string prime = "TAK";
        private static readonly string notPrime = "NIE";
        static void Main(string[] args)
        {
            var amount = Convert.ToInt32(Console.ReadLine());
            var inputList = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                inputList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < amount; i++)
            {
                if (IsPrime(inputList[i]))
                    Console.WriteLine(prime);
                else
                    Console.WriteLine(notPrime);
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
