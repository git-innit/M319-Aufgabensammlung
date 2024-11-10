using System;

namespace Aufgabe_04b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UInt32 zahl = 0;

            Console.Write("Geben Sie eine ganze Zahl von 0 bis 100000 ein: ");
            zahl = Convert.ToUInt32(Console.ReadLine());
            zahl = (((zahl + 25) / 50) * 50);
            Console.WriteLine("Die gerundete Zahl ist:\t" + zahl);
        }
    }
}
