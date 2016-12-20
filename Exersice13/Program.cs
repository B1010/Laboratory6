using System;
using System.Text;

namespace Exersice13
{
    class Program
    {
        static void Main()
        {
            DateTime time0 = DateTime.Now;
            strA();
            TimeSpan time0_0 = DateTime.Now - time0;

            DateTime time1 = DateTime.Now;
            strB();
            TimeSpan time1_1 = DateTime.Now - time1;

            Console.WriteLine("Выполнение String заняло: {0}", time0_0);
            Console.WriteLine("Выполнение StringBuilder заняло: {0}", time1_1);
            Console.ReadLine();
        }
        public static void strA()
        {
            String strA = "";
            for (int i = 0; i < 50000; i++)
            {
                strA = strA + i;
            }
        }
        public static void strB()
        {
            var strB = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                strB.Append(i);
            }
            string str = strB.ToString();
        }
    }
}
