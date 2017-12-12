using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        private static readonly string north = "0";
        private static readonly string south = "1";
        private static readonly string west = "2";
        private static readonly string east = "3";
        private static readonly string start = "studnia";
        static void Main(string[] args)
        {
            var count = Convert.ToInt32(Console.ReadLine());
            var rezults = new List<List<int>>();
            for (int i = 0; i < count; i++)
            {
                var moves = Convert.ToInt32(Console.ReadLine());
                var x = 0;
                var y = 0;

                for (int j = 0; j < moves; j++)
                {
                    string input = Console.ReadLine();
                    string[] arrayInput = input.Split(new char[] { ' ' });
                    var direction = Convert.ToInt32(arrayInput[0]);
                    var steps = Convert.ToInt32(arrayInput[1]);

                    switch (direction)
                    {
                        case 0: y = y + steps; break;
                        case 1: y = y - steps; break;
                        case 2: x = x - steps; break;
                        case 3: x = x + steps; break;
                    }
                }

                rezults.Add(new List<int>() { x, y });
            }

            for (int i = 0; i < count; i++)
            {
                int x = rezults[i][0];
                int y = rezults[i][1];
                if (x == 0 && y == 0)
                {
                    Console.WriteLine(start);
                    continue;
                }

                if (y != 0)
                {
                    var strRezult = String.Empty;
                    strRezult += String.Format("{0} {1}", y > 0 ? north : south, Math.Abs(y));
                    Console.WriteLine(strRezult);
                }

                if (x != 0)
                {
                    var rezult = String.Empty;
                    rezult += String.Format("{0} {1}", x > 0 ? east : west, Math.Abs(x));
                    Console.WriteLine(rezult);
                }
            }
        }
    }
}
