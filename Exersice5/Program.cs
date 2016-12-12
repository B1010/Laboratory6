using System;
using System.Linq;

namespace Exersice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение в котором необходимо подсчитать количество гласных и согласных:");

            string str = Console.ReadLine();
            char[] mainstring = str.ToCharArray();
            char[] jfilter = { 'б', 'п', 'в', 'ф', 'д', 'т', 'з', 'с', 'ж', 'ш', 'ч', 'ц', 'щ', 'г', 'к', 'х', 'м', 'н', 'л', 'р' };
            char[] ifilter = { 'а', 'э', 'о', 'ы', 'и', 'у', 'я', 'е', 'ё', 'ю' };
            int icount = 0, jcount = 0;

            foreach (char itempfor in mainstring)
            {
                if (ifilter.Contains(itempfor))
                    icount++;
            }

            foreach (char jtempfor in mainstring)
            {
                if (jfilter.Contains(jtempfor))
                    jcount++;
            }

            Console.WriteLine("Согласные: {0}. Гласные: {1}", icount, jcount);
            Console.ReadKey();
        }
    }
}
