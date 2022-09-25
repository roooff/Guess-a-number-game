using System;
using System.Text.RegularExpressions;

namespace Guess_a_number_v0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input from the user
            uint input = 0;
            // a variable for generating a random number from 0->100
            uint randomNumber = 0;               
            // Figuring out the logic
            while (true)
            {
                Console.Write($"Guess a number from 1 ->100 : ");
                input = uint.Parse(Console.ReadLine());
                randomNumber = 100 - input;
                if (input!=randomNumber)
                {
                    if (randomNumber>input)
                    {
                        Console.WriteLine("Too low. :(");
                        Console.WriteLine("Try again");
                    }
                    else if (input>randomNumber)
                    {
                        Console.WriteLine("Too high. :(");
                        Console.WriteLine("Try again");
                    }
                    
                }
                if (input == randomNumber)
                {
                    Console.WriteLine("Congratulations!!");
                    Console.WriteLine("You Guessed it.");
                    break;
                }

            }
        }
    }
}
