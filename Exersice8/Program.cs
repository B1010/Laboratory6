using System;
using System.Text.RegularExpressions;

namespace Exersice8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Подсчёт количества цифр и знаков. Введите данные: ");
            string str = Console.ReadLine();

            int countZnaki = Regex.Matches(str, @"[!"";:.,-/\=+_?]").Count;
            int countDigits = Regex.Matches(str, @"\d").Count;

            Console.WriteLine("Цифры: {1}\nЗнаки: {0}\n", countZnaki, countDigits);
            Console.ReadLine();
        }
    }
}
