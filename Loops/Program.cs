﻿using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            /*for (var i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            for (var i = 10; i >= 1; i--)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            } */

            //var name = "John Smith";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}
            //var numbers = new int[] { 1, 2, 3, 4 };
            //foreach (var number in numbers)
            //{
            //  Console.WriteLine(number);
            //}

            /*var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            } */

            {
                while (true)
                {
                    Console.Write("Please type your name: ");
                    var input = Console.ReadLine();

                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("@Echo: " + input);
                        continue;
                    }
                    break;
                }
            }
            
        }
    }
}
