using System;

namespace Exersice11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите мобильный номер телефона в котором надо найти номер АТС:");
            string phoneNumber = Console.ReadLine();
            char[] separators = { ',', ' ', ';', '-', '+' };

            string[] phoneNumber_arr = phoneNumber.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Номер ATC: {0}", phoneNumber_arr[2]);
            Console.ReadLine();
        }
    }
}