using System;

namespace Exersice10
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "удалить из строки все слова длина которых меньше трёх символов";
            char[] separators = { ',', ' ', ';' };

            string[] text_arr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in text_arr)
            {
                if (item.Length < 3) text = text.Replace(item, "-");
            }
            Console.WriteLine(text);
        }
    }
}
