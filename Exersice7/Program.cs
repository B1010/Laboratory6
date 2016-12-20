using System;

namespace Exersice7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ведите строку, символы которой необходимо инвертировать: ");

            string str = Console.ReadLine();
            string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < str.Length; i++)
            {
                var index = abc.IndexOf(str[i]);
                if (index + 1 <= 26)
                {
                    Console.Write(abc[index + 26]);
                }
                else
                {
                    Console.Write(abc[index - 26]);
                }
            }
            Console.ReadKey();
        }
    }
}
