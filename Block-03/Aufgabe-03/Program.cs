using System;

namespace Aufgabe_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title("Jahreszeiten");
            Console.Write("Monat [1-12]: ");
            byte m = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Der Monat {0} ist ein {1}monat", m, Season(m));
            Console.ReadLine();
        }
        private static void Title(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine("************************");
        }
        private static string Season(byte m)
        {
            string monat_str = null;
            switch (m)
            {
                case 12:
                case 01:
                case 02:
                    monat_str = "Winter";
                    break;
                case 03:
                case 04:
                case 05:
                    monat_str = "Frühlings";
                    break;
                case 06:
                case 07:
                case 08:
                    monat_str = "Sommer";
                    break;
                case 09:
                case 10:
                case 11:
                    monat_str = "Herbst";
                    break;
            }
            return monat_str;
        }
    }
}
