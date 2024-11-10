using System;

namespace Aufgabe_04a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie eine ganze Zahl von 0 bis 100000 ein: ");
            UInt32 zahl = Convert.ToUInt32(Console.ReadLine());
            zahl = (((zahl + 50) / 100) * 100); //wichtig
            Console.WriteLine("Die gerundete Zahl ist:\t" + zahl);
        }
    }
}
