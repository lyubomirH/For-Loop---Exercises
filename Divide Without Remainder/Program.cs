﻿namespace Divide_Without_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                count++;
                if (numb % 2 == 0)
                {

                    p1++;
                }
                if (numb % 3 == 0)
                {

                    p2++;
                }
                if (numb % 4 == 0)
                {

                    p3++;
                }
            }

            double p1Percent = (p1 / count) * 100;
            double p2Percent = (p2 / count) * 100;
            double p3Percent = (p3 / count) * 100;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
        }
    }
}