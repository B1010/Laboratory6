using System;

namespace Exersice10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение в котором необходимо заменить все слова короче 3 символов:");
            string text = Console.ReadLine();
            char[] separators = { ',', ' ', ';' };

            string[] text_arr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in text_arr)
            {
                if (item.Length < 3) text = text.Replace(item, "-");
            }
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
