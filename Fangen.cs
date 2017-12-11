using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<int>();
            var isLastItem = false;
            while (!isLastItem)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                    isLastItem = true;
                else
                    data.Add(input);
            }

            foreach (var value in data)
            {
                var mill = new Windmill(value);
                mill.DisplayRezult();
            }
        }
    }

    class Windmill
    {
        public Windmill(int size)
        {
            count = Math.Abs(size);
            int length = count * 2;
            rezult = new string[length, length];
            if (size < 0)
                CreateWindMillToRight(length);
            else
                CreateWindMillToLeft(length);

            rezult[count - 1, count - 1] = "*";
            rezult[count, count - 1] = "*";
            rezult[count - 1, count] = "*";
            rezult[count, count] = "*";
        }

        private int count;
        private int stars;
        private int dots;
        private string[,] rezult;

        public void DisplayRezult()
        {
            for (int i = 0; i < count * 2; i++)
            {
                for (int j = 0; j < count * 2; j++)
                {
                    Console.Write(rezult[i, j]);
                }

                Console.WriteLine();
            }
        }
        private void CreateWindMillToLeft(int length)
        {
            for (int n = 0; n < count - 1; n++)
            {
                stars = count - n;
                dots = count - n - 1;
                for (int i = n; i < length - n - 1; i++)
                {
                    rezult[i, n] = GetSymbol(n);
                }
                for (int i = n; i < length - n - 1; i++)
                {
                    rezult[length - n - 1, i] = GetSymbol(n);
                }
                for (int i = length - n - 1; i > n; i--)
                {
                    rezult[i, length - n - 1] = GetSymbol(n);
                }
                for (int i = length - n - 1; i > n; i--)
                {
                    rezult[n, i] = GetSymbol(n);
                }
            }
        }

        private void CreateWindMillToRight(int length)
        {
            for (int n = 0; n < count - 1; n++)
            {
                stars = count - n;
                dots = count - n - 1;
                for (int i = n; i < length - n - 1; i++)
                {
                    rezult[n, i] = GetSymbol(n);
                }
                for (int i = n; i < length - n - 1; i++)
                {
                    rezult[i, length - n - 1] = GetSymbol(n);
                }
                for (int i = length - n - 1; i > n; i--)
                {
                    rezult[length - n - 1, i] = GetSymbol(n);
                }
                for (int i = length - n - 1; i > n; i--)
                {
                    rezult[i, n] = GetSymbol(n);
                }
            }
        }
        private string GetSymbol(int value)
        {
            if (stars > 0)
            {
                stars--;
                return "*";
            }
            else
            {
                dots--;
                if (dots == 0)
                {
                    stars = count - value;
                    dots = count - value - 1;
                }

                return ".";
            }
        }
    }
}
