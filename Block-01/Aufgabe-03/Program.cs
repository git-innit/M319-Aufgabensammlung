using System;

namespace Aufgabe_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort carspeed = 0;
            ushort distance = 0;
            byte relgasper100km = 0;
            double traveltime = 0;
            double gasper100km = 0;
            while (true)
            {
                try
                {
                    Console.Write("Wie schnell bewegt sich Ihr Auto(in Km/h)?: ");
                    carspeed = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("Weche Distanz legen Sie zurück (in Km)?: ");
                    distance = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("Verbrauch des Auto (in Liter pro 100Km)?: ");
                    relgasper100km = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("\nVersuche es erneut durch betätigen einer beliebigen Taste");
                    Console.ReadKey(); Console.Clear(); continue;
                }
                break;
            }

            traveltime = (double)(((Convert.ToDouble(distance) / (Convert.ToDouble(carspeed)))) * 60);
            gasper100km = (double)(((Convert.ToDouble(relgasper100km)) * Convert.ToDouble(distance)) / 100.00);

            Console.WriteLine("\n\nFahrzeit\t: " + traveltime + " Minuten");
            Console.WriteLine("Verbrauch (L)\t: " + gasper100km + " Liter");
            Console.Write("\nBetätige eine beliebige Taste ... ");
            Console.ReadKey();
        }
    }
}