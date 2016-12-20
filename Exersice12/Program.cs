using System;

namespace Exersice12
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateUSA = "4/23/2011";
            char[] separators = { '/' };

            string[] dateUSA_arr = dateUSA.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Новый формат даты: {0}.{1}.{2}", dateUSA_arr[1], dateUSA_arr[0], dateUSA_arr[2]);
            Console.ReadLine();
        }
    }
}
