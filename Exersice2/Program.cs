using System;

namespace Exersice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение в котором необходимо отобразить предыдущий и последующий:");
            string text = Convert.ToString(Console.ReadLine());
            Console.Write("Введите символ: ");
            string symbol = Convert.ToString(Console.ReadLine());
            int temp =0;
            temp=text.IndexOf(symbol);

            if (temp != -1)
            {
                for (int i=0; i<=text.Length - 1; i++)
                {
                    if (text.Substring(i, 1) == symbol)
                    {
                        if (i==0) Console.WriteLine("Последующий символ: " + text.Substring(i + 1, 1));
                        if (i==text.Length - 1) Console.WriteLine("Предыдущий символ: " + text.Substring(i - 1, 1));
                        if ((i!=0)&&(i!=text.Length - 1))
                        {
                            Console.WriteLine("Предыдущий символ: " + text.Substring(i - 1, 1));
                            Console.WriteLine("Последующий символ: " + text.Substring(i + 1, 1));
                        }
                    }
                }
            }
            else Console.WriteLine("Такого символа нет");
            Console.ReadLine();
        }
    }
}
