using System;

namespace Aufgabe_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Umrechner umrechner = new Umrechner();
            byte loop = 1;

            do
            {
                Console.Write("Welche Temperatureinheit möchten sie angeben?: ");
                string eiheitsangabe = Console.ReadLine().ToLower();
                Console.Write("Geben sie die Temperatur in der oben genannten Einheit an: ");
                double temperatur_in = Convert.ToDouble(Console.ReadLine());

                if (eiheitsangabe == "celsius" || eiheitsangabe == "c")
                {
                    double rueckgabewert = umrechner.Celsius2Fahrenheit(temperatur_in);
                    Console.WriteLine("Die Temperatur in Fahrenheit ist: {0}", rueckgabewert);
                }
                else
                {
                    double rueckgabewert = umrechner.Fahrenheit2Celsius(temperatur_in);
                    Console.WriteLine("Die Temperatur in Celsius ist: {0}", rueckgabewert);
                }
                Console.WriteLine("Erneut anfangen? (1 zum Wiederholen, 0 zum Beenden): ");
                loop = Convert.ToByte(Console.ReadLine());
                Console.Clear();
            }
            while (loop != 0);
        }
    }
    class Umrechner
    {
        public double Celsius2Fahrenheit(double temperatur_in)
        {
            double fahrenheit = (((temperatur_in * 9) / 5) + 32);
            return fahrenheit;
        }
        public double Fahrenheit2Celsius(double temperatur_in)
        {
            double celsius = (((temperatur_in - 32) * 5) / 9);
            return celsius;
        }
    }
}
