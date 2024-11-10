using System;

namespace Aufgabe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Was ist Ihr Gewicht (in Kg)?:\t\t");
            byte weight = Convert.ToByte(Console.ReadLine());
            Console.Write("Was ist Ihre Körpergrösse(in cm)?:\t");
            byte height = Convert.ToByte(Console.ReadLine());

            float BMI = (float)(weight /  (Math.Pow(height, 2)));
            BMI = (float)Math.Round(BMI, 1);

            Console.WriteLine("Ihr BMI: {0} ", BMI);
        }
    }
}
