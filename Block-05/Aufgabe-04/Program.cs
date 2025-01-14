using System;

namespace Aufgabe_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

            int[,] matrix2 = {
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

            int[,] resultMatrix = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    resultMatrix[i, i2] = matrix1[i, i2] + matrix2[i, i2];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    Console.Write(resultMatrix[i, i2] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
