using System;
using System.Linq;

namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Wert {i + 1}?:\t");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("\n" + array.Sum());
        }
    }
}
