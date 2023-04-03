using System;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую координату X");
            var firstX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первую координату Y");
            var firstY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первую координату Z");
            var firstZ = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите вторую координату X");
            var secondX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую координату Y");
            var secondY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую координату Z");
            var secondZ = Convert.ToInt32(Console.ReadLine());

            var distance = Math.Round(Math.Sqrt(Math.Pow(secondX - firstX, 2) + Math.Pow(secondY - firstY, 2) +
                                     Math.Pow(secondZ - firstZ, 2)), 2);

            Console.WriteLine(distance);
            //A (3,6,8); B (2,1,-7)
            //A (7,-5, 0); B (1,-1,9)
        }
    }
}
