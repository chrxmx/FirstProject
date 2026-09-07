namespace FirstProject
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title  = "név kérés";
            Console.WindowWidth = 50; 
            
            Console.Write("ki vagy: ");

            string Name = Console.ReadLine();
            Console.WriteLine($"te vagy {Name}!");
        }
    }
}
