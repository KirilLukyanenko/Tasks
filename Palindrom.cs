using System;
using System.Collections.Generic;

namespace Palindrom
{
    class Program
    {
        private static readonly int max = 99999;
        private static readonly int min = 10000;
        static void Main(string[] args)
        {
            var primeNumbers = new List<long>();

            for (int i = max; i >= min; i--)
            {
                if (IsPrime(i))
                    primeNumbers.Add(i);
            }

            long maxPalindrom = 0;
            long number1 = 0;
            long number2 = 0;

            for (int i = 0; i < primeNumbers.Count; i++)
            {
                long value1 = primeNumbers[i];

                for (int j = i; j < primeNumbers.Count; j++)
                {
                    long value2 = primeNumbers[j];
                    long value = value1 * value2;
                    
                    if (!IsPalindrom(value))
                        continue;

                    if (value > maxPalindrom)
                    {
                        maxPalindrom = value;
                        number1 = value1;
                        number2 = value2;
                    }
                }
            }

            Console.WriteLine("First number: {0}\nSecond number: {1} \nPalindrom: {2}", number1, number2, maxPalindrom);
        }

        private static bool IsPrime(long number)
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

        private static bool IsPalindrom(long value)
        {
            var str = value.ToString();
            var length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                    return false;
            }

            return true;
        }
    }
}
