using System;
using System.Linq;

namespace Emolod_HW_1;

public static class Program
{
    static double readNum(string message)
    {
        while (true)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine().Trim();
            if (double.TryParse(input, out double number))
            {
                return number;
            }

            Console.WriteLine("\nВведене вами значення не є числом.");
        }
    }

    static void showError(string message)
    {
        Console.WriteLine(message);
    }

    static bool scan(double num1, double num2, string operation, out string error)
    {
        error = "";

        switch (operation)
        {
            case "/":
                if (num2 == 0)
                {
                    error = "\nНа нуль ділити не можна.";
                    return false;
                }
                break;
            case "sq":
                if (num1 == 0)
                {
                    error = "\nЧисло не може бути від'ємним.";
                    return false;
                }
                break;
            case "^":
                if (num2 == 0)
                {
                    error = "\nСтепінь не може бути від'ємною.";
                    return false;
                }
                break;
        }

        return true;
    }

    static double calculate(double num1, double num2, string operation)
    {
        return operation switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => num1 - num2,
            "sq" => Math.Sqrt(num1),
            "^" => Math.Pow(num1, num2)
        };
    }

    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        string[] operations = { "+", "-", "*", "/", "sq", "^" };

        while
        {
            Console.Clear();
            Console.WriteLine("Доступні операції:");
            Console.WriteLine("+, -, *, /, sq(квадратний корінь), ^");
            Console.WriteLine("\nВиберіть операцію:");

            string operation = Console.ReadLine().Trim();

            if (!operations.Contains(operation))
            {
                showError("\nНевідома операція.");
                Console.WriteLine("Для продовження натисніть будь-яку клавішу...");
                Console.ReadKey();
                continue;
            }

            double num1, num2 = 0;

            switch (operation)
            {
                case "sq":
                    num1 = readNum("\nВведіть число:");
                    break;
                case "^":
                    num1 = readNum("\nВведіть число:");
                    num2 = readNum("\nВведіть степінь:");
                    break;
                default:
                    num1 = readNum("\nВведіть перше число:");
                    num2 = readNum("\nВведіть друге число:");
                    break;
            }

            if (!scan(num1, num2, operation, out string error))
            {
                showError(error);
            }
            else
            {
                Console.WriteLine("\nРезультат: " + calculate(num1, num2, operation));
            }
            Console.WriteLine("Для продовження натисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}
