// Created by: Evgeny Vovk
// Created on: Apr 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program guesses the correct number
        int number;

        // input
        Console.WriteLine("");
        Console.Write("Input a number to check if it's positive or negative: ");
        number = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        if (number >= 0)
        {
            Console.WriteLine("The number " + number + " is a positive number.");
        }

        else
        {
            Console.WriteLine("The number " + number + " is a negative number.");
        }

        Console.WriteLine("\nDone.");
    }
}