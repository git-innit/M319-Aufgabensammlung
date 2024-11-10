using System;

namespace Aufgabe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte monatzahl = 0;
            string monatstring = null;

            Console.WriteLine("Jahreszeiten");
            Console.WriteLine("************************");
            Console.Write("Monat (zahl)\t: ");
            monatzahl = Convert.ToByte(Console.ReadLine());

            switch (monatzahl)
            {
                case 1:
                case 2:
                case 3:
                    monatstring = "Wintermonat";
                    break;
                case 4:
                case 5:
                case 6:
                    monatstring = "Frühlingsmonat";
                    break;
                case 7:
                case 8:
                case 9:
                    monatstring = "Sommermonat";
                    break;
                case 10:
                case 11:
                case 12:
                    monatstring = "Herbstmonat";
                    break;
            }
            Console.WriteLine("Der Monat {0} ist ein {1}", monatzahl, monatstring);
        }
    }
}
