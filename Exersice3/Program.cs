using System;

namespace Exersice3
{
    class Program
    {
        static void Main()
        {
            bool result = false;
            int sovpad = 0, g = 0, x = -1;
            string[] family = new string[3];
            
            string search = " ИВАН ";

            Console.WriteLine("Ввседите 3 разных ФИО:");
            for(int i=0; i<3; i++)
            {
                family[i] = Console.ReadLine().ToUpper();
            }

            foreach (string word in family)
            {
                while (g != -1)
                {
                    g = word.IndexOf(search, x + 1);
                    x = g;
                    sovpad++;
                    result = true;
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
            Console.ReadLine();
        }
    }
}
