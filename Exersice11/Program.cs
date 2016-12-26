using System;

namespace Exersice11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер телефона в котором надо найти номер АТС:");
            string phoneNumber = Console.ReadLine();
            char[] separators = { ',', ' ', ';', '-', '+', '(', ')' };

            string[] phoneNumber_arr = phoneNumber.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (phoneNumber_arr.Length == 5)
            {
                Console.WriteLine("Номер ATC: {0}", phoneNumber_arr[2]);
            }

            if (phoneNumber_arr.Length == 3)
            {
                Console.WriteLine("Номер ATC: {0}", phoneNumber_arr[0]);
            }
            Console.ReadLine();
        }
    }
}