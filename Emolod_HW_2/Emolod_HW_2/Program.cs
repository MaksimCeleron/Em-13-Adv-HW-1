using System;
using System.Linq;

namespace Emolod_HW_2;

public static class Program
{
    static int readNum(string message)
    {
        while (true)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine().Trim();
            if (int.TryParse(input, out int number) && number > 0)
            {
                if (number < 1)
                {
                    Console.WriteLine("\nЗначення не може бути від'ємним.");
                    continue;
                }

                return number;
            }

            Console.WriteLine("\nВведене вами значення не є числом.");
        }
    }

    static void calculate(int km, int idle)
    {
        int costperkm = 10;
        int costpermin = 2;
        int mincost = 50;

        int result = (km * costperkm) + (idle * costpermin);
        if (result < mincost)
        {
            Console.WriteLine("\nМінімальна вартість поїздки 50 грн.");
        }
        else
        {
            Console.WriteLine("\nВартість вашої поїздки: " + result + " грн");
        }

        Console.WriteLine("Для продовження натисніть будь-яку клавішу...");
        Console.ReadKey();
    }

    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Тарифи:");
            Console.WriteLine("1 км — 10 грн");
            Console.WriteLine("1 хв простою — 2 грн");
            Console.WriteLine("Мінімальна вартість поїздки — 50 грн");

            int km = readNum("\nВведіть кількість кілометрів:");
            int idle = readNum("\nВведіть кількість хвилин простою:");

            calculate(km, idle);
        }
    }
}
