using System;

namespace Aufgabe_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dezimalZahl = DezimalzahlEinlesen(0, 99999);
            string binaerZahl = BerechneBinaerZahl(dezimalZahl);
            Console.Write("Binaerzahl :");
            for (int i = binaerZahl.Length - 1; i >= 0; i--)
                Console.Write(binaerZahl[i]);
            Console.ReadLine();
        }
        private static int DezimalzahlEinlesen(int min, int max)
        {
            int dezimalZahl = 0;
            do
            {
                Console.Write("Dezimalzahl von {0} bis {1}:",min,max);
            } while (int.TryParse(Console.ReadLine(), out dezimalZahl) == false || dezimalZahl < min || dezimalZahl > max);
            return dezimalZahl;
        }
        private static string BerechneBinaerZahl(int dezimalZahl)
        {
            string binaerZahl = "";
            for (int dz = dezimalZahl; dz >= 1; dz /= 2)
                binaerZahl = binaerZahl + Convert.ToString(dz % 2);
            return binaerZahl;
        }
    }
}
