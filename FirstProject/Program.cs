using System.Globalization;
using System.Linq.Expressions;

namespace FirstProject
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "név kérés";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("ki vagy: ");

            string Name = Console.ReadLine();
            Console.WriteLine($"te vagy {Name}!");
          
           

            }
        }
    }
