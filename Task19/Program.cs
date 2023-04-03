using System;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Input(out var item);

            while (!(item >= 11111 && item <= 99999))
            {
                Input(out item);
            }

            var reverse = 0;

            while (item > reverse)
            {
                reverse = reverse * 10 + item % 10;
                item /= 10;
            }

            reverse /= 10;

            Console.WriteLine(item == reverse ? "да" : "нет");
        }

        private static void Input(out int item)
        {
            Console.WriteLine("Введите пятизначное число:");
            item = Convert.ToInt32(Console.ReadLine());
        }
    }
}
