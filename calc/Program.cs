using System.ComponentModel.Design;
using System.Globalization;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calc";
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
                try
                {
                    Console.Write("szám1: ");
                    decimal num1 = decimal.Parse(Console.ReadLine()!);
                    Console.Write("szám2: ");
                    decimal num2 = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine("adj meg egy operátort: +,-,*,^,/");

                    
                    string @operator = Console.ReadLine();

                    decimal result = 0;
                    switch (@operator)

                    {

                        case "+":
                            result = (num1 + num2);
                            break;
                        case "-":
                            result = (num1 - num2);
                            break;
                        case "*":
                            result = (num1 * num2);
                            break;
                        case "^":
                            result = (decimal)Math.Pow((double)num1, (double)num2);
                            break;
                        case "/":
                            {
                                if (num2 == 0)
                                {   
                                    Console.WriteLine("nincs nullával osztás");
                                    continue;
                                }
                                result = (num1 / num2);
                            }
                            break;
                        default:
                            Console.WriteLine("nem jó operátor!");
                            continue;
                    }
                    Console.WriteLine(result);

                    Console.WriteLine("írd azt hogy EXIT ha kiszeretnél lépni");
                    string exit = Console.ReadLine();
                    if (exit.ToUpper() == "EXIT")
                    {
                        break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("nem számot adtál meg");
                }

        }
    }
}
