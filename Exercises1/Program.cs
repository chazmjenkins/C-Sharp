using System;

namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1. Write a program and ask the user to enter a number. The number should
            between 1 to 10. If the user enters a valid number, display "Valid" on the
            console. Otherwise, dispay "Invalid". (This logic is used alot in applications
            where values entered into input boxes need to be validated.)

            Console.WriteLine("Type any number 1-10:  ");
            var inputUserValue = Console.ReadLine();
            var inputUserValueInt = Convert.ToInt32(inputUserValue);

            if (inputUserValueInt >= 1 && inputUserValueInt <= 10)
                Console.WriteLine("Valid");
            //correct input
            else
                Console.WriteLine("Invalid"); */

            /*2. Write a program which takes two numbers from the console and displays the
             maximum of the two. -> Rephrasing to ask for user input of 2 numbers show which
             number is greater than the other.

            Console.WriteLine("Enter a number");
            var int1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number");
            var int2 = Convert.ToInt32(Console.ReadLine());

            var max = (int1 > int2) ? int1 : int2;
            Console.WriteLine("Max is " + max); */

            /*3. Write a program and ask the user to enter the width and height of an image.
              Then tell if the image is landscape or portrait. */

            /*Console.WriteLine("This program needs the dimensions of an image to determine if the image is landscape or portrait.");
            Console.WriteLine("What is the width of the image?");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the image?");
            var height = Convert.ToInt32(Console.ReadLine());
            var dimensions = 0;

            if (height < width)
            {
                dimensions = 1;
                //Portrait. 
            }

            else

            if (width > height)
            {
                dimensions = 2;
                //Landscape.
            }
            else


            if (width == height)
            {
                dimensions = 3;
                //Square.
            }
            else
            {
            }

            int switchDimensions = dimensions;

            switch (switchDimensions)
            {
                case 1:
                    Console.WriteLine("This image has Portrait dimensions.");
                    break;

                case 2:
                    Console.WriteLine("This image is Landscape dimensions.");
                    break;

                case 3:
                    Console.WriteLine("This image is Square dimensions.");
                    break;
                    */

            /*4. Your job is to write a program for a speed camera. For simplicity, ignore the
             details such as camera, sensors, etc and focus purely on the logic. Write a program that
             ask the user to enter the speed limit. Once set, the program asks for the speed of a car.
             If the user enters a value less than the speed limit, program should display OK on the
             console. If the value is above the speed limit, the program should calculate the number
             of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be
             incurred and displayed on the console. If the numer of demerit points is above 12, the 
             program should display License Suspended. */

            var speedLimit = 85;
            Console.WriteLine("Car speed is required to calculate whether car is above speed limit.");
            Console.WriteLine("What is the speed?");
            var speed = Convert.ToInt32(Console.ReadLine());
            
            if (speed < speedLimit)
                Console.WriteLine("Driver going the speed limit.");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (speed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
                                    
        }
    }
}
