using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            Main();
        }
    }
}
