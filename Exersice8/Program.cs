using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exersice8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Подсчёт количества цифр и знаков. Введите данные: ");
            string str = Console.ReadLine();

            char[] mainstring = str.ToCharArray();
            int[] digits = { 0, 0 };

            foreach (char itempfor in mainstring)
            {
                if (Char.IsDigit(itempfor))
                    digits[0]++;
            }

            foreach (char jtempfor in mainstring)
            {
                if (Char.IsDigit(jtempfor))
                    digits[1]++;
            }

            Console.WriteLine("Цифры: {1}\nЗнаки: {0}", digits[0], digits[1]);
            Console.ReadLine();
        }
    }
}
