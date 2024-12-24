using System;

namespace Aufgabe_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Startwert? :\t");
            string startwert = Console.ReadLine();
            Console.Write("Endwert? :\t");
            string endwert = Console.ReadLine();
            int x = Convert.ToInt32(startwert);
            Console.WriteLine(x);
            while (x <= Convert.ToInt32(endwert))
            {
                x += 1;
                Console.WriteLine(x);
            }
            Environment.Exit(0);
        }
    }
}
