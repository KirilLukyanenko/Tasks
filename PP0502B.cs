using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = Convert.ToInt32(Console.ReadLine());
            var rezults = new List<List<string>>();
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                var arrayInput = input.Split(new char[] { ' ' }).ToList();

                arrayInput.RemoveAt(0);
                arrayInput.Reverse();
                rezults.Add(arrayInput.ToList());
            }

            foreach (var value in rezults)
            {
                var str = String.Empty;

                foreach (var item in value)
                    str += String.Format("{0} ", item);

                Console.WriteLine(str);
            }
        }
    }
}
