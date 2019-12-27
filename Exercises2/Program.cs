using System;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             1. Write a program to count how many numbers between 1 and 100 are divisible by 3
             with no remainder. Display the count on the console.
             */

            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);

            /*
             2. Write a program and continulously ask the user to enter a number or "ok" to exit.
             Calculate the sum of all the previously entered numbers and display it on the console.
             */

            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
            /*
             3. Write a program and ask the user to enter a number. Compute the factorial of the number
             and print it on the console. For example, if the user enters 5, the program should calculate
             5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
             */

            Console.Write("Enter a number: ");
            var number3 = Convert.ToInt32(Console.ReadLine());
            var factorial3 = 1;
            for (var exercise3 = 1; exercise3 <= number3; exercise3++)
                factorial3 *= exercise3;
            Console.WriteLine("{0}! = {1}", number3, factorial3);

            /*
             4. Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess
             the number. If the user guesses the number, display "You won"; otherwise, display "You lost".
             (To make
             */

            var number4 = new Random().Next(1, 10);
            Console.WriteLine("Secret is " + number4);
            for (var i4 = 0; i4 < 4; i4++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number4)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost!");

            /*
             5. Write a program and ask the user to enter a series of numbers separated by comma. Find the
             maximum of the numbers and display it on the console. For example, if the user enters
             "5, 3, 8, 1, 4", the program should display 8.
             */

            Console.Write("Enter comma separated numbers: ");
            var input5 = Console.ReadLine();
            var numbers5 = input5.Split(',');
            //Assume the first number is the max - Instructor note.
            var max5 = Convert.ToInt32(numbers5[0]);
            foreach (var str in numbers5)
            {
                var number5 = Convert.ToInt32(str);
                if (number5 > max5)
                    max5 = number5;
            }
            Console.WriteLine("Max is " + max5);
        }
    }
}
