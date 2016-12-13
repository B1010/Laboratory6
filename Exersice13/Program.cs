using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice13
{
    class Program
    {
        static void Main()
        {
        }
        static void strA()
        {
            String strA = "";
            for (int i = 0; i < 50000; i++)
            {
                strA = strA + i;
            }
            Console.WriteLine(strA);
        }
        static void strB()
        {
            DateTime dold = DateTime.Now;
            var strB = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                strB.Append(i);
            }
            string str = strB.ToString();
            TimeSpan sp = DateTime.Now - dold;
        }
    }
}
