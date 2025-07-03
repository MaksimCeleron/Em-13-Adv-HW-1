using System;
using System.Linq;

namespace Emolod_HW_3;

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
                }
                
                return number;
            }
            
            Console.WriteLine("\nВведене вами значення не є числом.");
        }
    }

    static void calculate(int kVt)
    {
        double beforeh = 1.44;
        double onetosh = 1.68;
        double sixhandab = 1.92;

        double result = kVt < 101 ? kVt * beforeh : kVt > 101 && kVt < 600 ? kVt * onetosh : kVt * sixhandab;

        Console.WriteLine("\nПотрібно сплатити: " + result + " грн");
    }

    public static void Main()
    {
        // Console.OutputEncoding = Encoding.Unicode;
        // Console.InputEncoding = Encoding.Unicode;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Тарифікація:");
            Console.WriteLine("До 101 кВт•год — 1,44 грн/кВт•год");
            Console.WriteLine("Від 101 до 600 кВт•год — 1,68 грн/кВт•год");
            Console.WriteLine("Від 600 кВт•год — 1,92 грн/кВт•год");

            calculate(readNum("\nВведіть кількість спожитих кіловат-годин:"));
            Console.WriteLine("Для продовження натисныть клавішу Enter...");
            Console.ReadLine();
        }
    }
}
