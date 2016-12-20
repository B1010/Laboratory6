using System;

namespace Exersice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение в котором необходимо отобразить предыдущий и последующий:");
            string s = Convert.ToString(Console.ReadLine());
            Console.Write("Введите символ: ");
            string p = Convert.ToString(Console.ReadLine());
            int k =0;
            k=s.IndexOf(p);

            if (k != -1)
            {
                for (int i=0; i<=s.Length - 1; i++)
                {
                    if (s.Substring(i, 1) == p)
                    {
                        if (i==0) Console.WriteLine("Последующий символ: " + s.Substring(i + 1, 1));
                        if (i==s.Length - 1) Console.WriteLine("Предыдущий символ: " + s.Substring(i - 1, 1));
                        if ((i!=0)&&(i!=s.Length - 1))
                        {
                            Console.WriteLine("Предыдущий символ: " + s.Substring(i - 1, 1));
                            Console.WriteLine("Последующий символ: " + s.Substring(i + 1, 1));
                        }
                    }
                }
            }
            else Console.WriteLine("Такого символа нет");
            Console.ReadLine();
        }
    }
}
