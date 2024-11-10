using System;

namespace Aufgabe_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char geschlecht = ' ';
            byte gewicht = 0;
            string gewichtsklasse = null;

            Console.Write("Geschlecht [m/w]\t: ");
            geschlecht = Convert.ToChar(Console.ReadLine().ToLower());
            Console.Write("Gewicht [in Kg]\t\t: ");
            gewicht = Convert.ToByte(Console.ReadLine());

            if (geschlecht == 'm')
            {
                if (gewicht < 55)
                {
                    gewichtsklasse = "Fliegengewicht";
                }
                else if (gewicht > 55 && gewicht < 66) 
                {
                    gewichtsklasse = "Leichtgewicht";
                }
                else if (gewicht > 66 && gewicht < 84)
                {
                    gewichtsklasse = "Mittelgewicht";
                }
                else if (gewicht > 84 && gewicht < 120)
                {
                    gewichtsklasse = "Schwergewicht";
                }
            }
            else if (geschlecht == 'w')
            {
                if (gewicht < 48)
                {
                    gewichtsklasse = "Fliegengewicht";
                }
                else if (gewicht > 48 && gewicht < 55)
                {
                    gewichtsklasse = "Leichtgewicht";
                }
                else if (gewicht > 55 && gewicht < 63)
                {
                    gewichtsklasse = "Mittelgewicht";
                }
                else if (gewicht > 63 && gewicht < 72)
                {
                    gewichtsklasse = "Schwergewicht";
                }
            }
            else
            {
                gewichtsklasse = "geschlecht ungültig";
            }
            Console.WriteLine("Gewichtsklasse: {0}", gewichtsklasse);
        }
    }
}
