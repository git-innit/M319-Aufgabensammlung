using System;

namespace Aufgabe_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            int m = 0;
            int j = 0;
            int h = 0;
            int c = 0;
            string wochentag = null;

            Console.Write("Tag (Zahl)\t: ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Monat (Zahl)\t: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Jahr (Zahl)\t: ");
            j = Convert.ToInt32(Console.ReadLine());

            int rt = t; int rm = m; int rj = j;

            if (m <= 2)
            {
                m += 10;
                j--;
            }
            else
            {
                m -= 2;
            }

            c = j / 100;
            j = j % 100;

            h = (((26 * m - 2) / 10) + t + j + j / 4 + c / 4 - 2 * c) % 7;

            if (h < 0)
            {
                h += 7;
            }
            switch (h)
            {
                case 0: wochentag = "Sonntag"; break;
                case 1: wochentag = "Montag"; break;
                case 2: wochentag = "Dienstag"; break;
                case 3: wochentag = "Mittwoch"; break;
                case 4: wochentag = "Donnerstag"; break;
                case 5: wochentag = "Freitag"; break;
                case 6: wochentag = "Samstag"; break;
            }
            Console.WriteLine("Der {0}.{1}.{2} ist ein {3}",rt,rm,rj,wochentag);
        }
    }
}
