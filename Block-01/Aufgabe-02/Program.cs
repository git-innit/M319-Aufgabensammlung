using System;

namespace Aufgabe_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort steps = 0;
            char enviromentclass = ' ';
            double money = 0;
            short position = 0;
            while (true)
            {
                try
                {
                    Console.Write("Schritte pro Tag?: ");
                    steps = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("Umweltkategorie?: ");
                    enviromentclass = Convert.ToChar(Console.ReadLine());
                    Console.Write("Bankkontostand?: ");
                    money = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Position x-Achse?: ");
                    position = Convert.ToInt16(Console.ReadLine());
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
            Console.WriteLine("\n\nSchritte pro Tag\t: " + steps);
            Console.WriteLine("Umweltkategorie\t\t: " + enviromentclass.ToString().ToUpper());
            Console.WriteLine("Bankkontostand\t\t: " + money);
            Console.WriteLine("Position x-Achse\t: " + position);
            Console.Write("\nBetätige eine beliebige Taste ... ");
            Console.ReadKey();
        }
    }
}