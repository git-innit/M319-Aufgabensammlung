using System;
namespace Aufgabe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben sie eine einzige Römische Ziffer ein:\t");
            string eingabe = Console.ReadLine().ToUpper();

            short dezimalwert = GetDezimal(eingabe);

            Console.WriteLine("Der Dezimalwert von {0} entspicht {1}",eingabe,dezimalwert);
        }
        private static short GetDezimal(string eingabe)
        {
            short rueckgabe = 0;
            switch (eingabe)
            {
                case "I": rueckgabe = 1; break;
                case "V": rueckgabe = 5; break;
                case "X": rueckgabe = 10; break;
                case "L": rueckgabe = 50; break;
                case "C": rueckgabe = 100; break;
                case "D": rueckgabe = 500; break;
                case "M": rueckgabe = 1000; break;
            }
            return rueckgabe;
        }
    }
}
