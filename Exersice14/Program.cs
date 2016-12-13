using System;
using System.Text;

namespace Exersice14
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            Console.Write("Введите новую длину строки: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите символ-запонитель: ");
            char replace = Convert.ToChar(Console.ReadLine());
            StringBuilder newtext = new StringBuilder(text, length);

            if (length < text.Length)
            {
                newtext.Remove(length, newtext.Length - length);
            }
            else
                for (int i = 0; i <= (length - text.Length); i++)
                {
                    newtext.Insert(0, replace);
                }
            Console.WriteLine(newtext);
            Console.ReadKey();
        }
    }
}
