using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

                //var number = "12345";
                //int z = Convert.ToByte(number);
                //Console.WriteLine(z);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");

            }



        }
    }
}
