using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string pred = Console.ReadLine();
            StringBuilder a = new StringBuilder(pred);
            Console.Write("Введите ключ: ");
            int key = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= pred.Length; i++)
            {
                a.Insert(0, key);
                if (pred.Length < a.Length)
                {
                    a.Remove(pred.Length, a.Length - pred.Length);
                }
            }
            Console.Write(a);
            Console.ReadKey();
        }
    }
}
