using System;
using System.Text;

namespace Exersice15
{
    class Program
    {
        static char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        static void Main(string[] args)
        {
            //Кодирование и декодирование с использованием Шифра Виженера
            Console.Write("Введите строку: ");
            string texttoencode = Console.ReadLine();
            Console.Write("Введите ключ: ");
            int key = int.Parse(Console.ReadLine());

            string encodetext = Encode(texttoencode, Convert.ToString(key));
            string decodetext = Decode(encodetext, Convert.ToString(key));

            Console.WriteLine("\nЗашифрованная строка {0}", encodetext);
            Console.WriteLine("Расшифрованная строка {0}", decodetext);
            Console.ReadLine();
        }
        //зашифровать
        static string Encode(string input, string keyword)
        {
            int N = characters.Length;
            input = input.ToUpper();
            keyword = keyword.ToUpper();

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int c = (Array.IndexOf(characters, symbol) +
                    Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[c];
                keyword_index++;

                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }
        //расшифровать
        static string Decode(string input, string keyword)
        {
            int N = characters.Length;
            input = input.ToUpper();
            keyword = keyword.ToUpper();

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int p = (Array.IndexOf(characters, symbol) + N - Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[p];
                keyword_index++;

                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }
            return result;
        }
    }
}
