using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double laenge = 0, breite = 0;

            do
            {
                Console.Write("Geben Sie die Laenge ein: ");
            } while (double.TryParse(Console.ReadLine(), out laenge) == false);
            do
            {
                Console.Write("Geben Sie die Breite ein: ");
            } while (double.TryParse(Console.ReadLine(), out breite) == false);
            double resultat = Rechteckflaeche(laenge, breite);
            Console.WriteLine("Das Resultat ist {0}", resultat);
            Console.ReadLine();
        }
        static double Rechteckflaeche(double l, double b)
        {
            return l * b;
        }
    }
}
