using System.Globalization;

namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("szám1: ");
                double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("szám2: ");
                double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("adj meg egy operátort");
                string @operator = Console.ReadLine();

                decimal result = 0;
                switch (@operator)
                {
                    case "+":
                        result = (decimal)(num1 + num2);
                        break;
                    case "-":
                        result = (decimal)(num1 - num2);
                        break;
                    case "*":
                        result = (decimal)(num1 * num2);
                        break;
                    case "/":
                        {
                            if (num2 == 0)
                            {
                                Console.WriteLine("nincs nullával osztás");
                                continue;
                            }
                            result = (decimal)(num1 / num2);
                        } break;
                    default:
                        Console.WriteLine("nem jó operátor!");
                        continue;
                }
                Console.WriteLine(result);

            }
        }
    }
}
