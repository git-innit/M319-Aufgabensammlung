using System;

namespace Aufgabe_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte Maximalwert eingeben:\t");
            int maximalwert = Convert.ToInt32(Console.ReadLine());

            if (maximalwert <= 2)
            {
                Environment.Exit(1);
            }

            Console.WriteLine(2);
            int zahl = 3;

            while (zahl <= maximalwert)
            {
                int check = 2;
                bool istNichtModNull = true;

                while (check <= Math.Sqrt(zahl) + 1)
                {
                    if (zahl % check == 0)
                    {
                        istNichtModNull = false;
                        break;
                    }
                    check += 1;
                }

                if (istNichtModNull)
                {
                    Console.WriteLine(zahl);
                }

                zahl += 2;
            }
            Environment.Exit(0);
        }
    }
}