using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            const int passwordLength = 10;
            var Random = new Random();
            char[] buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = ((char)('a' + Random.Next(0, 26)));
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
