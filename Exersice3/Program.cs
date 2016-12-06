using System;

namespace Exersice3
{
    class Program
    {
        static void Main()
        {
            bool result = false;
            int sovpad = 0;
            char[] separators = { ',', ' ', ';' };

            Console.WriteLine("Ввседите 3 разный ФИО:");
            string ifam = Console.ReadLine().ToUpper();
            string jfam = Console.ReadLine().ToUpper();
            string lfam = Console.ReadLine().ToUpper();
            string search = "ИВАН";

            string[] ifam_words = ifam.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] jfam_words = jfam.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] lfam_words = lfam.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in ifam_words)
            {
                if (search.Equals(word))
                {
                    result = true;
                    sovpad++;
                    break;
                }
            }
            foreach (string word in jfam_words)
            {
                if (search.Equals(word))
                {
                    result = true;
                    sovpad++;
                    break;
                }
            }
            foreach (string word in lfam_words)
            {
                if (search.Equals(word))
                {
                    result = true;
                    sovpad++;
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine("\nНайдено совпадение! Количество человек с именем Иван: {0}", sovpad);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено!");
            }
        }
    }
}
