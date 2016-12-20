using System;

namespace Exersice9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string textFind = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string Find = Console.ReadLine();
            int index = 0;

            if (textFind.IndexOf(Find) > -1)
            {
                index = textFind.IndexOf(Find) + 1;
                Console.WriteLine("Найдена подстрока, индекс первой буквы: " + index);
            }
            else
            {
                Console.WriteLine("Подстрока не найдена");
            }
            Console.ReadLine();
        }
    }
}
