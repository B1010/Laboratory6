using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
