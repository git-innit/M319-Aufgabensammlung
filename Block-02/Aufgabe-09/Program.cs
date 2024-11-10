using System;

namespace Aufgabe_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            byte num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, glückszahl = 0;
            while (true)
            {
                num1 = (byte)rnd.Next(43);
                num2 = (byte)rnd.Next(43);
                num3 = (byte)rnd.Next(43);
                num4 = (byte)rnd.Next(43);
                num5 = (byte)rnd.Next(43);
                num6 = (byte)rnd.Next(43);
                glückszahl = (byte)rnd.Next(7);
                if (num1 == num2 || num1 == num3 || num1 == num4 || num1 == num5 || num1 == num6 || 
                    num2 == num3 || num2 == num4 || num2 == num5 || num2 == num6 || num3 == num4 || 
                    num3 == num5 || num3 == num6 || num4 == num5 || num4 == num6 || num5 == num6)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Ausgabe = {0}, {1}, {2}, {3}, {4}, {5}\nGlückszahl = {6}", num1, num2, num3, num4, num5, num6, glückszahl);
        }
    }
}
