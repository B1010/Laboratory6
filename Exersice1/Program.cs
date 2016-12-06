using System;
using System.Linq;

namespace Exersice1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку в которой необходимо подсчитать количество пробелов:");
            String istring = Console.ReadLine();

            char[] jstring = istring.ToCharArray();
            char[] filter = { ' ' };
            int count = 0;

            foreach (char tempfor in jstring)
            {
                if (filter.Contains(tempfor))
                    count++;
            }

            Console.WriteLine("Количество пробелов: {0}", count);
            Console.ReadKey();
        }
    }
}
