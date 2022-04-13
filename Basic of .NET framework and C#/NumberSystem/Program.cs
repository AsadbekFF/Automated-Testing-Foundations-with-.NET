using System;

namespace NumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("In binary system: " + Convert.ToString(num, 2));
            Console.WriteLine("In octal number system: " + Convert.ToString(num, 8));
            Console.WriteLine("In hexadecimal number system: " + Convert.ToString(num, 16));
            Console.ReadKey();
        }
    }
}
