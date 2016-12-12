using System;

namespace Exersice4
{
    class Program
    {
        static void Main()
        {
            char[] separators = { ',', ' ', ';', '.' };
            string offer = Console.ReadLine();

            string[] offer_words = offer.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Количество слов в предложении: {0}", offer_words.Length);
            Console.ReadLine();
            Main();
        }
    }
}
