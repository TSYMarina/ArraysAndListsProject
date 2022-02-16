using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO:

            // Create an int Array and populate numbers 1-10

            var arrayOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evens = new List<int>();
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var num in arrayOfNumbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.WriteLine($"Here is the list of even numbers:  ");
            foreach(var evenNum in evens)
            {
                Console.Write($"-* {evenNum} *-" );
            }
            Console.WriteLine();
            Console.WriteLine($"Here is the list of odd numbers:  ");
            foreach (var oddNum in odds)
            {
                Console.Write($"-* {oddNum} *-");
            }
        }
    }
}


/*Exercise 1:
                1
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                2
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                3
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                4
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                5
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                6
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                7
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                8
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                9
            for(int i = 0; i < 5; i++)
            {
            Console.WriteLine($"{i}")
            }
                10
                for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                11
                for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                12
                for(int i = 0; i < 5; i++)
            {
                Console.WriteLine( $"{i}");
            }
                13
                for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                14
                for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
                15
                for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            */