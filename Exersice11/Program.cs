using System;

namespace Exersice11
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = "+7 495 123-45-67";
            char[] separators = { ',', ' ', ';', '-', '+' };

            string[] phoneNumber_arr = phoneNumber.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Номер ATC: {0}", phoneNumber_arr[2]);
        }
    }
}