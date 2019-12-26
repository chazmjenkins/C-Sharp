using System;

namespace MacOS_Test1
{
    public class Person
    {
        public int Age;
    }

    /*public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            number++;



            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            /*var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";

            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);*/


            /*var firstName = "Chaz";
            var lastName = "Jenkins";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths
c:\\folder1\\folder2
c:\\folder3\\folder4";
            Console.WriteLine(text);*/
        }
    }
}
