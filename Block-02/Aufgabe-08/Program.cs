using System;

namespace Aufgabe_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                uint zahl = 0;
                uint temp = 0;
                uint quersumme = 0;
                string teilbardurch3 = null;
                string teilbardurch9 = null;
                char wiederholen = ' ';

                Console.Write("Zahl\t: ");
                zahl = Convert.ToUInt32(Console.ReadLine());
                temp = zahl;

                while (temp != 0)
                {
                    quersumme += temp % 10;
                    temp /= 10;
                }
                if (quersumme % 3 == 0) { teilbardurch3 = "Ja"; }
                else { teilbardurch3 = "Nein"; }
                if (quersumme % 9 == 0) { teilbardurch9 = "Ja"; }
                else { teilbardurch9 = "Nein"; }

                Console.Clear();
                Console.WriteLine("Zahl: {0}\nQuersumme: {1}\nTeilbar durch 3: {2}\nTeilbar durch 9: {3}", zahl, quersumme, teilbardurch3, teilbardurch9);

                Console.WriteLine("\nMöchten sie eine weitere Berechnung? (j/n)");
                wiederholen = Console.ReadKey().KeyChar;

                if (wiederholen == 'j' || wiederholen == 'J') { Console.Clear(); continue; }
                else if (wiederholen == 'n' || wiederholen == 'N') { Console.Clear(); break; }
            }
        }
    }
}
