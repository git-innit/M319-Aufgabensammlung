using System;

namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char repeat = ' ';
            while (true)
            {
                byte number = Convert.ToByte(rnd.Next(1, 101));
                byte attemptsleft = 6;
                byte guessnr = 0;
                bool success = false;

                Console.WriteLine("***************************");
                Console.WriteLine("THE ULTIMATE GUESSAPP v1.0");
                Console.WriteLine("**************************");

                while (attemptsleft > 0)
                {
                    guessnr++;
                    Console.Write("Your {0}th guess (You have {1} left):", guessnr, attemptsleft);
                    byte guessed = Convert.ToByte(Console.ReadLine());
                    if (guessed == number)
                    {
                        success = true;
                        break;
                    }
                    else if (guessed > number)
                    {
                        Console.WriteLine("The number ist too high!");
                    }
                    else if (guessed < number)
                    {
                        Console.WriteLine("The number ist too low!");
                    }
                    attemptsleft--;
                }
                if (success == true)
                {
                    Console.WriteLine("\nBoaaa ey! Respect! You are a person of honor");
                }
                else if (success == false)
                {
                    Console.WriteLine("\nWhat's wrong? Why are you not able to do this?\n\nthe number would have been{0}!", number);
                }

                Console.Write("\nWould you like to play again?[y=Yes, n=No]? ");
                repeat = Console.ReadLine()[0];

                if (repeat == 'y' || repeat == 'Y')
                {
                    Console.Clear();
                    continue;
                }
                else if (repeat == 'n' || repeat == 'N')
                {
                    break;
                }
            }
        }
    }
}
