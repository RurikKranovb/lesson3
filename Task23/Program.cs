using System;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var readLine = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= readLine; i++)
            {
                Console.WriteLine(Math.Pow(i,3));
            }
        }
    }
}
