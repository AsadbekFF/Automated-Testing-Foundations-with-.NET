using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            int sum = 0;
            int max = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1])
                {
                    sum++;
                }
                else
                {
                    if (sum > max)
                    {
                        max = sum;
                        sum = 1;
                    }
                }
            }

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
