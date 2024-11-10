using System;

namespace Aufgabe_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort Jahr = 0;
            byte m = 0, n = 0, s = 0, a = 0, b = 0, c = 0, d = 0, e = 0, Ostertag = 0;
            string Ostermonat = null;

            Console.Write("Jahr (Zahl)\t: ");
            Jahr = Convert.ToUInt16(Console.ReadLine());

            m = (byte)((8 * (Jahr / 100) + 13) / 25 - 2);
            s = (byte)(Jahr / 100 - Jahr / 400 - 2);
            m = (byte)((15 + s - m) % 30);
            n = (byte)((6 + s) % 7);

            a = (byte)(Jahr % 19);
            b = (byte)(Jahr % 4);
            c = (byte)(Jahr % 7);
            d = (byte)((19 * a + m) % 30);
            if (d == 29) { d = 28; }
            else
            {
                if (d == 28 && a >= 11) { d = 27; }
            }
            e = (byte)((2 * b + 4 * c + 6 * d + n) % 7);

            Ostertag = (byte)(22 + d + e);
            if (Ostertag > 31) { Ostertag = (byte)(Ostertag % 31); Ostermonat = "April"; }
            else { Ostermonat = "März"; }

            Console.WriteLine("\nDer Ostertag ist am {0}.{1}.{2}", Ostertag, Ostermonat, Jahr);
        }
    }
}
