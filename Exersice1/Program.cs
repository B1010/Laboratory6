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
            Console.WriteLine("Количество пробелов: {0}", istring.Split(' ').Length - 1);
            Console.ReadKey();
        }
    }
}
