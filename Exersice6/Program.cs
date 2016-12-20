using System;

namespace Exersice6
{
    class Program
    {
        static void Main()
        {
            char[] separators = { ',', ' ', ';' };

            Console.WriteLine("Введите предложение, в котором необходимо выполнить преобразования: ");
            string words = Console.ReadLine();
            string[] iwords = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(iwords);

            for (int i = 0; i < iwords.Length; i++)
            {
                iwords[i] = iwords[i].Remove(iwords[i].Length-1, 1) + (string)(iwords[i].Remove(0, iwords[i].Length - 1)).ToUpper();
                iwords[i] = (string)(iwords[i].Remove(1, iwords[i].Length - 1)).ToUpper() + iwords[i].Remove(0, 1);

                Console.Write("{0} ", iwords[i]);
            }
            Console.ReadLine();
        }
    }
}
