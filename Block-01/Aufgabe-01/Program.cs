using System;

namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vorname = null;
            string nachname = null;
            byte alter = 0;
            while (true)
            {
                Console.Write("Bitte gebe deinen Vornamen ein: ");
                vorname = Console.ReadLine(); Console.Clear();
                Console.Write("Bitte gebe deinen Nachnamen ein: ");
                nachname = Console.ReadLine(); Console.Clear();
                Console.Write("Bitte gebe dein Alter ein: ");
                try
                {
                    alter = Convert.ToByte(Console.ReadLine());
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Alter darf nicht grösser als 255 sein und keine Buchstaben enthalten");
                    Console.WriteLine("\nVersuche es erneut durch betätigen einer beliebigen Taste");
                    Console.ReadKey(); Console.Clear(); continue;
                }
                alter++;
                if (vorname == null || nachname == null || vorname == "" || nachname == "")
                {
                    Console.WriteLine("Vor-/Nachname darf nicht leer sein");
                    Console.WriteLine("\nVersuche es erneut durch betätigen einer beliebigen Taste");
                    Console.ReadKey(); Console.Clear(); continue;
                }
                else { break;}
            }
            Console.WriteLine("Hallo " + vorname + " " + nachname + ", bald wirst du " + alter);
            Console.ReadKey();
        }
    }
}